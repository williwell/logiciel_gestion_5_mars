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
            clientSocket = New TcpClient(MainForm.getInstance.getOption1, 8888)
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
            Return conc
        Catch ex As Exception
            Return conc
        End Try
    End Function



    Public Function GetInventaire() As DataTable
        Dim table As New DataTable

        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim outStream As Byte() = Encoding.ASCII.GetBytes("getInventaire;$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()

                table = createTable(serverStream)
            Catch ex As Exception

            End Try
        End If
        Return table
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

    Public Function GetInventaireOfFour(id As Integer) As DataTable
        Dim table As New DataTable

        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim outStream As Byte() = Encoding.ASCII.GetBytes("getInventaireOfFour;" & id & ";$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()

                table = createTable(serverStream)
            Catch ex As Exception

            End Try
        End If
        Return table
    End Function

    Public Function GetFournisseur() As DataTable
        Dim table As New DataTable

        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim outStream As Byte() = Encoding.ASCII.GetBytes("getFournisseur;$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()

                table = createTable(serverStream)
            Catch ex As Exception

            End Try
        End If
        Return table
    End Function

    Public Function GetOneFournisseur(id As Integer) As DataTable
        Dim table As New DataTable

        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim outStream As Byte() = Encoding.ASCII.GetBytes("getOneFournisseur;" & id & ";$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()

                table = createTable(serverStream)
            Catch ex As Exception

            End Try
        End If
        Return table
    End Function

    Public Function GetFournisseur(id As String) As DataTable
        Dim table As New DataTable

        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim outStream As Byte() = Encoding.ASCII.GetBytes("getFournisseur;" & id & ";$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()


                table = createTable(serverStream)
            Catch ex As Exception

            End Try
        End If
        Return table
    End Function

    Public Function GetFournisseurAdd(id() As Integer) As DataTable
        Dim table As New DataTable

        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim text As String = "\\liste;"

                For i As Integer = 0 To id.Length - 1
                    text += id(i) & ";"
                Next
                text += "\\listeEnd;"

                Dim outStream As Byte() = Encoding.ASCII.GetBytes(text & "getFournisseurAdd;$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()



                table = createTable(serverStream)
            Catch ex As Exception

            End Try
        End If
        Return table
    End Function

    Public Function ModFour(liste() As String) As Boolean
        Dim bool As Boolean = False

        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim text As String = "\\liste;"

                For i As Integer = 0 To liste.Length - 1
                    text += liste(i) & ";"
                Next
                text += "\\listeEnd;"

                Dim outStream As Byte() = Encoding.ASCII.GetBytes(text & "modFour;$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()



                Dim table As DataTable = createTable(serverStream)
                bool = Boolean.Parse(table(0)(0))
            Catch ex As Exception

            End Try
        End If
        Return bool
    End Function

    Public Function ModInventaire(liste() As String) As Boolean
        Dim bool As Boolean = False

        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim text As String = "\\liste;"

                For i As Integer = 0 To liste.Length - 1
                    text += liste(i) & ";"
                Next
                text += "\\listeEnd;"

                Dim outStream As Byte() = Encoding.ASCII.GetBytes(text & "modInventaire;$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()



                Dim table As DataTable = createTable(serverStream)
                bool = Boolean.Parse(table(0)(0))
            Catch ex As Exception

            End Try
        End If
        Return bool
    End Function

    Public Function AjoutInventaire(liste() As String) As Boolean
        Dim bool As Boolean = False

        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim text As String = "\\liste;"

                For i As Integer = 0 To liste.Length - 1
                    text += liste(i) & ";"
                Next
                text += "\\listeEnd;"

                Dim outStream As Byte() = Encoding.ASCII.GetBytes(text & "ajoutInventaire;$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()



                Dim table As DataTable = createTable(serverStream)
                bool = Boolean.Parse(table(0)(0))
            Catch ex As Exception

            End Try
        End If
        Return bool
    End Function

    Public Function ModInvFour(liste() As String) As Boolean
        Dim bool As Boolean = False

        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim text As String = "\\liste;"

                For i As Integer = 0 To liste.Length - 1
                    text += liste(i) & ";"
                Next
                text += "\\listeEnd;"

                Dim outStream As Byte() = Encoding.ASCII.GetBytes(text & "modInvFour;$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()



                Dim table As DataTable = createTable(serverStream)
                bool = Boolean.Parse(table(0)(0))
            Catch ex As Exception

            End Try
        End If
        Return bool
    End Function

    Public Function AddInvFour(liste() As String) As Boolean
        Dim bool As Boolean = False

        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim text As String = "\\liste;"

                For i As Integer = 0 To liste.Length - 1
                    text += liste(i) & ";"
                Next
                text += "\\listeEnd;"

                Dim outStream As Byte() = Encoding.ASCII.GetBytes(text & "addInvFour;$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()



                Dim table As DataTable = createTable(serverStream)
                bool = Boolean.Parse(table(0)(0))
            Catch ex As Exception

            End Try
        End If
        Return bool
    End Function

    Public Function DelInvFour(liste() As String) As Boolean
        Dim bool As Boolean = False

        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim text As String = "\\liste;"

                For i As Integer = 0 To liste.Length - 1
                    text += liste(i) & ";"
                Next
                text += "\\listeEnd;"

                Dim outStream As Byte() = Encoding.ASCII.GetBytes(text & "delInvFour;$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()



                Dim table As DataTable = createTable(serverStream)
                bool = Boolean.Parse(table(0)(0))
            Catch ex As Exception

            End Try
        End If
        Return bool
    End Function

    Public Function AddFour(liste() As String) As Boolean
        Dim bool As Boolean = False

        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim text As String = "\\liste;"

                For i As Integer = 0 To liste.Length - 1
                    text += liste(i) & ";"
                Next
                text += "\\listeEnd;"

                Dim outStream As Byte() = Encoding.ASCII.GetBytes(text & "addFour;$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()



                Dim table As DataTable = createTable(serverStream)
                bool = Boolean.Parse(table(0)(0))
            Catch ex As Exception

            End Try
        End If
        Return bool
    End Function

    Public Function GetModel() As DataTable
        Dim table As DataTable = Nothing
        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim outStream As Byte() = Encoding.ASCII.GetBytes("getModel;$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()

                table = createTable(serverStream)
            Catch ex As Exception

            End Try
        End If
        Return table
    End Function

    Public Function GetOptionModel(id As String) As DataTable
        Dim table As DataTable = Nothing
        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim outStream As Byte() = Encoding.ASCII.GetBytes("getOptionModel;" & id & ";$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()

                table = createTable(serverStream)
            Catch ex As Exception

            End Try
        End If
        Return table
    End Function

    Public Function GetCouleurModel(id As String) As DataTable
        Dim table As DataTable = Nothing
        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()
                Dim outStream As Byte() = Encoding.ASCII.GetBytes("getCouleurModel;" & id & ";$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()

                table = createTable(serverStream)
            Catch ex As Exception

            End Try
        End If
        Return table
    End Function

    Public Function GetOptionAdd(id() As String) As DataTable
        Dim table As DataTable = Nothing
        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()

                Dim text As String = "\\liste;"

                For i As Integer = 0 To id.Length - 1
                    text += id(i) & ";"
                Next
                text += "\\listeEnd;"

                Dim outStream As Byte() = Encoding.ASCII.GetBytes(text & "getOptionAdd;$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()

                table = createTable(serverStream)
            Catch ex As Exception

            End Try
        End If
        Return table
    End Function

    Public Function GetCouleurAdd(id() As String) As DataTable
        Dim table As DataTable = Nothing
        If conc Then
            Try
                Dim serverStream As NetworkStream = clientSocket.GetStream()

                Dim text As String = "\\liste;"

                For i As Integer = 0 To id.Length - 1
                    text += id(i) & ";"
                Next
                text += "\\listeEnd;"

                Dim outStream As Byte() = Encoding.ASCII.GetBytes(text & "getCouleurAdd;$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()

                table = createTable(serverStream)
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

    Shared Sub SetMain(mainform As MainForm)
        main = mainform
    End Sub

    Private Sub StillConnect(mainform As MainForm)
        checkClient = New TcpClient(MainForm.getInstance.getOption1, 8888)
        Dim bool As Boolean = True

        While bool

            If Application.OpenForms().OfType(Of MainForm).Any Then
                While conc
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
                            main.fermer()
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
    End Sub
End Class
