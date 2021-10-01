Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class ConnectionServeur
    Shared instance As ConnectionServeur = Nothing
    Dim clientSocket As TcpClient
    Dim checkClient As TcpClient
    Dim conc As Boolean = False
    Dim thread As New Thread(AddressOf stillConnect)
    Shared main As MainForm
    Delegate Sub MySubDelegate()
    Dim bool As Boolean

    Sub New(mainform As MainForm)
        main = mainform
    End Sub

    Shared Function getinstance() As ConnectionServeur
        If IsNothing(instance) Then
            instance = New ConnectionServeur(main)
        End If
        Return instance
    End Function


    Public Function TestConnection() As Boolean
        Dim tCheckCo As New Thread(AddressOf checkCo)
        Dim tWaiting As New Thread(AddressOf waiting)
        Try
            bool = True
            tCheckCo.Start()
            tWaiting.Start()
            While bool

            End While

            Return conc

        Catch ex As Exception
            Return conc
        End Try
    End Function

    Public Function GetInventaire(id As String) As DataTable
        Dim table As New DataTable

        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim outStream As Byte() = Encoding.ASCII.GetBytes("getInventaire;" & id & ";$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()

                table = createTable(serverStream)
            Catch ex As Exception

            End Try
        End If
        Return table
    End Function

    Public Function modQuantite(liste() As String) As Boolean
        Dim bool As Boolean = False

        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim text As String = "\\liste;"

                For i As Integer = 0 To liste.Length - 1
                    text += liste(i) & ";"
                Next
                text += "\\listeEnd;"

                Dim outStream As Byte() = Encoding.ASCII.GetBytes(text & "modQuantite;$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()



                Dim table As DataTable = createTable(serverStream)
                bool = Boolean.Parse(table(0)(0))
            Catch ex As Exception

            End Try
        End If
        Return bool
    End Function

    Private Function createTable(serverStrem As NetworkStream) As DataTable
        Dim search As Boolean = True
        Dim i As Integer = 0
        Dim int As Integer = 0
        Dim table As New DataTable

        Dim inStream(1024) As Byte
        Dim str As String = ""

        While search
            serverStrem.Read(inStream, 0, inStream.Length())
            str += Encoding.ASCII.GetString(inStream)
            If InStr(str, "\\end;") >= 1 Then
                search = False
            End If
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

    Shared Sub setMain(mainform As MainForm)
        main = mainform
    End Sub

    Private Sub stillConnect(mainform As MainForm)
        checkClient = New TcpClient(MainForm.getInstance.getOption1(), 8888)
        Dim bool As Boolean = True
        Dim bool2 As Boolean = True

        While bool
            If Application.OpenForms().OfType(Of MainForm).Any Then
                If conc Then
                    bool2 = True
                End If
                While bool2
                    If Application.OpenForms().OfType(Of MainForm).Any Then
                        Thread.Sleep(1000)
                        Try
                            Dim serverStream As NetworkStream = clientSocket.GetStream()
                            Dim outStream As Byte() = Encoding.ASCII.GetBytes("test;$")
                            serverStream.Write(outStream, 0, outStream.Length)
                            serverStream.Flush()

                            Dim inStream(1024) As Byte
                            serverStream.Read(inStream, 0, inStream.Length())
                            If Boolean.Parse(Encoding.ASCII.GetString(inStream)) Then
                                conc = True
                            End If
                        Catch ex As Exception
                            conc = False
                            bool2 = False
                            main.fermer()
                        End Try
                    Else
                        bool2 = False
                    End If
                End While
            Else
                bool = False
                bool2 = False
            End If
        End While

        'If conc Then
        '    serverStream = checkClient.GetStream()
        '    outStream = Encoding.ASCII.GetBytes("fermer;$")
        '    serverStream.Write(outStream, 0, outStream.Length)
        '    serverStream.Flush()
        'End If
    End Sub

    Public Sub fermer()
        If conc Then
            Dim serverStream As NetworkStream = clientSocket.GetStream()
            Dim outStream As Byte() = Encoding.ASCII.GetBytes("fermer;$")
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()
        End If
    End Sub

    Private Sub checkCo()
        Try
            clientSocket = New TcpClient(MainForm.getInstance.getOption1(), 8888)
            Dim serverStream As NetworkStream = clientSocket.GetStream()
            Dim outStream As Byte() = Encoding.ASCII.GetBytes("test;$")
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()

            Dim inStream(1024) As Byte
            serverStream.Read(inStream, 0, inStream.Length())
            If Boolean.Parse(Encoding.ASCII.GetString(inStream)) Then
                conc = True
                thread.Start(main)
            End If
            bool = False
        Catch ex As Exception
            bool = False
        End Try
    End Sub

    Private Sub waiting()
        Thread.Sleep(15000)
        If bool = True Then
            conc = False
            bool = False
        End If
    End Sub
End Class
