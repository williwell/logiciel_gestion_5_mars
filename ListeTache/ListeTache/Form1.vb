Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Public Class Form1
    Dim clientSocket As TcpClient
    Dim checkClient As TcpClient
    Dim conc As Boolean = False
    ReadOnly thread As New Thread(AddressOf StillConnect)
    Private Delegate Sub setValue(text As Boolean)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            clientSocket = New TcpClient("192.168.32.113", 8889)
            Dim serverStream As NetworkStream = clientSocket.GetStream()
            Dim outStream As Byte() = Encoding.UTF8.GetBytes("test;$")
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()

            Dim inStream(1024) As Byte
            serverStream.Read(inStream, 0, inStream.Length())
            If Boolean.Parse(Encoding.UTF8.GetString(inStream).Substring(0, 4)) Then
                conc = True
                thread.Start()
            End If

        Catch ex As Exception

        End Try

        DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        For c As Integer = 1 To DataGridView1.Columns.Count - 1
            DataGridView1.Columns(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
        Dim h As Integer = 8
        Dim m As String = ":00"
        For i As Integer = 0 To 15
            Dim str As String = h & m & Environment.NewLine & Environment.NewLine
            If m = ":00" Then
                m = ":30"
                str = str & h & m
            Else
                m = ":00"
                h += 1
                str = str & h & m
            End If
            DataGridView1.Rows.Add(str)
        Next

        Dim hauteur = (DataGridView1.Height - DataGridView1.ColumnHeadersHeight) / 16
        For r As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(r).Height = hauteur
        Next
    End Sub

    Private Sub StillConnect()
        checkClient = New TcpClient("192.168.32.113", 8889)
        Dim bool As Boolean = True

        Try
            While bool

                If Application.OpenForms().OfType(Of Form1).Any Then
                    While conc
                        If Application.OpenForms().OfType(Of Form1).Any Then
                            Thread.Sleep(1000)
                            Try
                                Dim serverStream As NetworkStream = clientSocket.GetStream()
                                Dim outStream As Byte() = Encoding.UTF8.GetBytes("test;$")
                                serverStream.Write(outStream, 0, outStream.Length)
                                serverStream.Flush()

                                Dim inStream(1024) As Byte
                                serverStream.Read(inStream, 0, inStream.Length())
                                If Boolean.Parse(Encoding.UTF8.GetString(inStream).Substring(0, 4)) Then
                                    conc = True
                                End If
                            Catch ex As Exception
                                conc = False
                                Fermer()
                            End Try
                        Else
                            conc = False
                            bool = False
                        End If
                    End While
                Else
                    bool = False
                End If
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Fermer()
        If DataGridView1.InvokeRequired Then
            Dim d As New SetValue(AddressOf SetVisible)
            BeginInvoke(d, New Object() {True})
        Else
            DataGridView1.Visible = False
            Label1.Visible = True
        End If
    End Sub

    Private Sub SetVisible(bool As Boolean)
        DataGridView1.Visible = bool
        Label1.Visible = Not bool
    End Sub
End Class
