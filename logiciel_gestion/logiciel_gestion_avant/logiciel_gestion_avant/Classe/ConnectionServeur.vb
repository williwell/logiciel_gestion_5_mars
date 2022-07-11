Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class ConnectionServeur
    Shared instance As ConnectionServeur = Nothing
    Dim clientSocket As TcpClient
    Dim checkClient As TcpClient
    Dim conc As Boolean = False
    ReadOnly thread As New Thread(AddressOf stillConnect)
    Shared main As MainForm
    Delegate Sub MySubDelegate()

    Sub New(mainform As MainForm)
        main = mainform
    End Sub

    Shared Function Getinstance() As ConnectionServeur
        If IsNothing(instance) Then
            instance = New ConnectionServeur(main)
        End If
        Return instance
    End Function


    Public Function TestConnection() As Boolean
        Try
            clientSocket = New TcpClient(MainForm.GetInstance.GetOption1, MainForm.GetInstance.GetOption3)
            Dim serverStream As NetworkStream = clientSocket.GetStream()
            Dim outStream As Byte() = Encoding.UTF8.GetBytes("Avant;0.4;$")
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()

            Dim inStream(1024) As Byte
            serverStream.Read(inStream, 0, inStream.Length())
            Dim str As String = Encoding.UTF8.GetString(inStream)
            If Boolean.Parse(str.Substring(0, str.IndexOf(";"))) Then
                conc = True
                thread.Start(main)
            Else
                MessageBox.Show(MsgTextFr.Getinstance.MsgErrConnectionServ, MsgTextFr.Getinstance.MsgAttention)
            End If
            Return conc
        Catch ex As Exception
            Return conc
        End Try
    End Function

    Public Function AddDelete(liste() As String, instruction As String) As Boolean
        Dim bool As Boolean = False

        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim text As String = "\\liste;"

                For i As Integer = 0 To liste.Length - 1
                    text += liste(i) & ";"
                Next
                text += "\\listeEnd;"

                Dim outStream As Byte() = Encoding.UTF8.GetBytes(text & instruction & ";$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()



                Dim table As DataTable = CreateTable(serverStream)
                bool = Boolean.Parse(table(0)(0))
            Catch ex As Exception

            End Try
        End If
        Return bool
    End Function

    Public Function GetInfo(Instruction As String) As DataTable
        Dim table As DataTable = Nothing
        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim outStream As Byte() = Encoding.UTF8.GetBytes(Instruction & ";$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()

                table = CreateTable(serverStream)
            Catch ex As Exception

            End Try
        End If
        Return table
    End Function

    Public Function GetInfo(id As String, instruction As String) As DataTable
        Dim table As DataTable = Nothing
        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim outStream As Byte() = Encoding.UTF8.GetBytes(instruction & ";" & id & ";$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()

                table = CreateTable(serverStream)
            Catch ex As Exception

            End Try
        End If
        Return table
    End Function

    Public Function AddDelete(id As String, instruction As String) As Boolean
        Dim table As DataTable
        Dim bool As Boolean = False
        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim outStream As Byte() = Encoding.UTF8.GetBytes(instruction & ";" & id & ";$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()

                table = CreateTable(serverStream)
                bool = Boolean.Parse(table(0)(0))
            Catch ex As Exception

            End Try
        End If
        Return bool
    End Function

    Public Function GetInfo(id() As String, Instruction As String) As DataTable
        Dim table As DataTable = Nothing
        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()

                Dim text As String = "\\liste;"

                For i As Integer = 0 To id.Length - 1
                    text += id(i) & ";"
                Next
                text += "\\listeEnd;"

                Dim outStream As Byte() = Encoding.UTF8.GetBytes(text & Instruction & ";$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()

                table = CreateTable(serverStream)
            Catch ex As Exception

            End Try
        End If
        Return table
    End Function

    Public Function AddModel(Nom As String, Cout As String) As String
        Dim nbr As Integer = 0
        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()

                Dim outStream As Byte() = Encoding.UTF8.GetBytes("AddModel;" & Nom & ";" & Cout & ";$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()

                Dim table As DataTable = CreateTable(serverStream)
                nbr = Integer.Parse(table(0)(0))
            Catch ex As Exception

            End Try
        End If
        Return nbr
    End Function

    Public Function AddDelete(liste() As String, id As String, texte As String) As Boolean
        Dim bool As Boolean = False

        If conc Then
            Try
                For i As Integer = 0 To liste.Length - 1
                    Dim serverStream As NetworkStream = clientSocket.GetStream()

                    Dim outStream As Byte() = Encoding.UTF8.GetBytes(texte & ";" & liste(i) & ";" & id & ";$")
                    serverStream.Write(outStream, 0, outStream.Length)
                    serverStream.Flush()

                    Dim table As DataTable = CreateTable(serverStream)
                    bool = Boolean.Parse(table(0)(0))
                Next
            Catch ex As Exception

            End Try
        End If
        Return bool
    End Function

    Public Function AddDeleteListe(liste() As String, id As String, instruction As String) As Boolean
        Dim bool As Boolean = False

        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim text As String = "\\liste;"

                For i As Integer = 0 To liste.Length - 1
                    text += liste(i) & ";"
                Next
                text += "\\listeEnd;"

                Dim outStream As Byte() = Encoding.UTF8.GetBytes(text & instruction & ";" & id & ";$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()

                Dim table As DataTable = CreateTable(serverStream)
                bool = Boolean.Parse(table(0)(0))
            Catch ex As Exception

            End Try
        End If
        Return bool
    End Function

    Public Function AddDeleteListeTable(liste() As String, id As String, instruction As String) As DataTable
        Dim table As DataTable = Nothing

        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim text As String = "\\liste;"

                For i As Integer = 0 To liste.Length - 1
                    text += liste(i) & ";"
                Next
                text += "\\listeEnd;"

                Dim outStream As Byte() = Encoding.UTF8.GetBytes(text & instruction & ";" & id & ";$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()

                table = CreateTable(serverStream)
            Catch ex As Exception

            End Try
        End If
        Return table
    End Function

    Public Function ModInv(idInv As String, idModel As String, nbr As String, str As String) As Boolean
        Dim bool As Boolean = False
        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()

                Dim outStream As Byte() = Encoding.UTF8.GetBytes(str & ";" & idInv & ";" & idModel & ";" & nbr & ";$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()

                Dim table As DataTable = CreateTable(serverStream)
                bool = True
            Catch ex As Exception

            End Try
        End If
        Return bool
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

    Shared Sub SetMain(mainform As MainForm)
        main = mainform
    End Sub

    Private Sub StillConnect(mainform As MainForm)
        checkClient = New TcpClient(MainForm.GetInstance.GetOption1, MainForm.GetInstance.GetOption3)
        Dim bool As Boolean = True

        Try
            While bool

                If Application.OpenForms().OfType(Of MainForm).Any Then
                    While conc
                        If Application.OpenForms().OfType(Of MainForm).Any Then
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
                                main.Fermer()
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

        End Try
    End Sub
End Class
