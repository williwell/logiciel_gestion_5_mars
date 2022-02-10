Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Public Class Form1
    Shared instance As Form1 = Nothing
    ReadOnly keyCombo As New List(Of Keys)({Keys.ControlKey, Keys.H, Keys.P})
    ReadOnly currentKeys As New List(Of Keys)
    Dim checkClient As TcpClient
    Dim conc As Boolean = True
    ReadOnly thread As New Thread(AddressOf StillConnect)
    Private Delegate Sub setValue(text As Boolean)
    Dim table As DataTable
    Dim option1 As String
    Dim option2 As String
    Dim bool As Boolean = True

    Public Shared Function GetInstance() As Form1
        If IsNothing(instance) Then
            instance = New Form1
        End If
        Return instance
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyOption.ReadOption(option1, option2)

        Me.KeyPreview = True

        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        For c As Integer = 1 To DataGridView1.Columns.Count - 1
            DataGridView1.Columns(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next

        DataGridView1.Rows.Add("AVANT-MIDI")
        DataGridView1.Rows.Add("APRÈS-MIDI")

        Dim hauteur = (DataGridView1.Height - DataGridView1.ColumnHeadersHeight) / 2
        For r As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(r).Height = hauteur
        Next

        DataGridView1.ClearSelection()

        Dim bool As Boolean = True
        Dim dateLundi As Date = Now
        Dim dateVen As Date = Now.AddDays(1)
        While bool
            If dateLundi.DayOfWeek = 1 Then
                bool = False
            End If
            If dateLundi.DayOfWeek >= 1 And dateLundi.DayOfWeek <= 5 Then
                DataGridView1.Columns(dateLundi.DayOfWeek).HeaderText += " " & dateLundi.ToString("dd MMMM yyyy")
            End If
            If dateLundi.DayOfWeek > 1 Then
                dateLundi = dateLundi.AddDays(-1)
            End If

        End While

        bool = True
        While bool
            If dateVen.DayOfWeek = 5 Then
                bool = False
            End If
            If dateVen.DayOfWeek <= 5 Then
                DataGridView1.Columns(dateVen.DayOfWeek).HeaderText += " " & dateVen.ToString("dd MMMM yyyy")
            End If
            If dateVen.DayOfWeek < 5 Then
                dateVen = dateVen.AddDays(1)
            End If
        End While

        thread.Start()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        currentKeys.Add(e.KeyCode)

        If currentKeys.Intersect(keyCombo).Count = keyCombo.Count Then
            currentKeys.Clear()
            Dim ip As New IPSetting(Me)
            ip.ShowDialog()
            conc = False
        End If
    End Sub

    'Utilisé pour enlever les touche qui ne sont plus sélectionner par l'utilisateur(Utilisé pour faire la combinaison de touche pour ouvrire option secret)
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        currentKeys.Remove(e.KeyCode)
    End Sub

    Private Sub StillConnect()

        Try
            While bool
                Try
                    checkClient = New TcpClient(option1, option2)
                    conc = True
                    If Application.OpenForms().OfType(Of Form1).Any Then
                        While conc
                            Fermer(True)
                            If Application.OpenForms().OfType(Of Form1).Any Then
                                Try
                                    table = GetTache(checkClient)
                                    CheckTable()
                                Catch ex As Exception
                                    conc = False
                                    Fermer(False)
                                End Try
                                Thread.Sleep(60000)
                            Else
                                conc = False
                                bool = False
                            End If
                        End While
                    Else
                        bool = False
                    End If
                Catch
                    Fermer(False)
                    If Not Application.OpenForms().OfType(Of Form1).Any Then
                        bool = False
                    End If
                End Try
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PutText(str As String, dt As Integer, r As Integer)
        Dim fin As Integer
        Dim width As Integer = DataGridView1.Columns(dt).Width
        For c As Integer = 0 To str.Length - 1
            If TextRenderer.MeasureText(str.Substring(0, fin), DataGridView1.DefaultCellStyle.Font).Width >= width Then
                DataGridView1.Rows(r).Cells(dt).Value += str.Substring(0, fin - 3) & vbCrLf
                str = str.Substring(fin - 3)
                fin = 1
                c -= 3
            Else
                fin += 1
            End If
        Next
        DataGridView1.Rows(r).Cells(dt).Value += str & vbCrLf
    End Sub

    Private Sub CheckTable()
        Try
            For r As Integer = 0 To DataGridView1.Rows.Count - 1
                For c As Integer = 1 To DataGridView1.Columns.Count - 1
                    DataGridView1.Rows(r).Cells(c).Value = ""
                Next
                For i As Integer = 0 To table.Rows.Count - 1
                    If r = table(i)(1) Then
                        Dim dt As Date = table(i)(2)
                        Dim widthCell As Integer = DataGridView1.Columns(dt.DayOfWeek).Width

                        Dim str As String = table(i)(3)

                        DataGridView1.Rows(r).Cells(dt.DayOfWeek).Value += vbCrLf & vbCrLf

                        PutText(str, dt.DayOfWeek, r)

                        str = table(i)(4)

                        PutText(str, dt.DayOfWeek, r)
                    End If
                Next
            Next
            For c As Integer = 1 To DataGridView1.Columns.Count - 1
                If Date.Now.DayOfWeek > c Then
                    DataGridView1.Rows(0).Cells(c).Style.BackColor = Color.LightYellow
                    DataGridView1.Rows(1).Cells(c).Style.BackColor = Color.LightYellow
                ElseIf Date.Now.DayOfWeek = c Then
                    If Date.Now.ToString("HH") >= 12 Then
                        DataGridView1.Rows(0).Cells(c).Style.BackColor = Color.LightYellow
                        DataGridView1.Rows(1).Cells(c).Style.BackColor = Color.LightBlue
                    Else
                        DataGridView1.Rows(0).Cells(c).Style.BackColor = Color.LightBlue
                        DataGridView1.Rows(1).Cells(c).Style.BackColor = Color.LightGreen
                    End If
                Else
                    DataGridView1.Rows(0).Cells(c).Style.BackColor = Color.LightGreen
                    DataGridView1.Rows(1).Cells(c).Style.BackColor = Color.LightGreen
                End If
            Next
        Catch
            Fermer(False)
            conc = False
        End Try
    End Sub

    Public Sub Fermer(bool As Boolean)
        If DataGridView1.InvokeRequired Then
            Dim d As New setValue(AddressOf SetVisible)
            BeginInvoke(d, New Object() {bool})
        Else
            DataGridView1.Visible = bool
            Label1.Visible = Not bool
        End If
    End Sub

    Private Sub SetVisible(bool As Boolean)
        DataGridView1.Visible = bool
        Label1.Visible = Not bool
    End Sub

    Public Function GetTache(cl As TcpClient) As DataTable
        Dim table As DataTable = Nothing

        If conc Then
            Try
                Dim serverStream As NetworkStream = cl.GetStream()
                Dim outStream As Byte() = Encoding.UTF8.GetBytes("getAujTache;$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()

                table = CreateTable(serverStream)
            Catch ex As Exception

            End Try
        End If
        Return table
    End Function

    Private Function CreateTable(serverStrem As NetworkStream) As DataTable
        Dim search As Boolean = True
        Dim i As Integer = 0
        Dim int As Integer = 0
        Dim table As New DataTable

        Dim inStream(1024) As Byte
        Dim str As String = ""

        While search
            serverStrem.Read(inStream, 0, inStream.Length())
            str += Encoding.UTF8.GetString(inStream)
            If InStr(str, "\\end;") >= 1 Then
                search = False
            End If

            Using myFileWriter As IO.StreamWriter = IO.File.AppendText("C:\logiciel_gestion_5_mars_fichier\texte.txt")
                myFileWriter.WriteLine(str)
                myFileWriter.WriteLine("ok")
                myFileWriter.Close()
            End Using
        End While

        Dim row As Integer = Integer.Parse(str.Substring(0, str.IndexOf(";")))
        str = str.Substring(str.IndexOf(";") + 1)
        Dim col As Integer = Integer.Parse(str.Substring(0, str.IndexOf(";")))
        str = str.Substring(str.IndexOf(";") + 1)


        For c As Integer = 0 To col
            table.Columns.Add(str.Substring(0, str.IndexOf(";")), GetType(String))
            str = str.Substring(str.IndexOf(";") + 1)
        Next

        For r As Integer = 0 To row
            table.Rows.Add()
        Next


        search = True
        While search
            If Not str.Substring(0, 6) = "\\end;" Then
                If Not str.Substring(0, 6) = "\\row;" Then
                    'MessageBox.Show(i & "  " & int)
                    table(i)(int) = str.Substring(0, str.IndexOf(";"))
                    int += 1
                    str = str.Substring(str.IndexOf(";") + 1)

                Else
                    i += 1
                    int = 0
                    str = str.Substring(str.IndexOf(";") + 1)
                End If
            Else
                search = False
            End If
        End While

        Return table
    End Function

    Public Sub SetOption(str1 As String, str2 As String)
        option1 = str1
        option2 = str2
    End Sub


    '__________________________________________________________________________________________________________
    'Get
    '__________________________________________________________________________________________________________
    Public Function GetOption1() As String
        Return option1
    End Function

    Public Function GetOption2() As String
        Return option2
    End Function
End Class
