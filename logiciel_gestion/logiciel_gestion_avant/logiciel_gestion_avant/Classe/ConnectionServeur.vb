Imports System.Net.Sockets
Imports System.Text
Public Class ConnectionServeur
    Shared instance As ConnectionServeur = Nothing
    Dim clientSocket As TcpClient

    Shared Function getinstance() As ConnectionServeur
        If IsNothing(instance) Then
            instance = New ConnectionServeur
        End If
        Return instance
    End Function


    Public Sub TestConnection()
        Try
            clientSocket = New TcpClient("127.0.0.1", 8888)

            Dim serverStream As NetworkStream = clientSocket.GetStream()
            Dim outStream As Byte() = Encoding.ASCII.GetBytes("test;$")
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()

            Dim inStream(1024) As Byte
            serverStream.Read(inStream, 0, inStream.Length())
            If Not Boolean.Parse(Encoding.ASCII.GetString(inStream)) Then
                MessageBox.Show("Impossible de se connecter au serveur!")
            End If
        Catch ex As Exception
            MessageBox.Show("Impossible de se connecter au serveur!")
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function GetInventaire() As DataTable
        Dim table As New DataTable

        Try
            Dim serverStream As NetworkStream = clientSocket.GetStream()
            Dim outStream As Byte() = Encoding.ASCII.GetBytes("getInventaire;$")
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()

            table = createTable(serverStream)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        Return table
    End Function

    Public Function GetInventaire(id As String) As DataTable
        Dim table As New DataTable
        Dim search As Boolean = True

        Try
            Dim serverStream As NetworkStream = clientSocket.GetStream()
            Dim outStream As Byte() = Encoding.ASCII.GetBytes("getInventaire;" & id & ";$")
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()

            table = createTable(serverStream)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        Return table
    End Function

    Public Function getInventaireOfFour(id As Integer) As DataTable
        Dim table As New DataTable

        Try
            Dim serverStream As NetworkStream = clientSocket.GetStream()
            Dim outStream As Byte() = Encoding.ASCII.GetBytes("getInventaireOfFour;" & id & ";$")
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()

            table = createTable(serverStream)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        Return table
    End Function

    Public Function getFournisseur() As DataTable
        Dim table As New DataTable

        Try
            Dim serverStream As NetworkStream = clientSocket.GetStream()
            Dim outStream As Byte() = Encoding.ASCII.GetBytes("getFournisseur;$")
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()

            table = createTable(serverStream)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        Return table
    End Function

    Public Function getOneFournisseur(id As Integer) As DataTable
        Dim table As New DataTable

        Try
            Dim serverStream As NetworkStream = clientSocket.GetStream()
            Dim outStream As Byte() = Encoding.ASCII.GetBytes("getOneFournisseur;" & id & ";$")
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()

            table = createTable(serverStream)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        Return table
    End Function

    Public Function getFournisseur(id As String) As DataTable
        Dim table As New DataTable

        Try
            Dim serverStream As NetworkStream = clientSocket.GetStream()
            Dim outStream As Byte() = Encoding.ASCII.GetBytes("getFournisseur;" & id & ";$")
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()


            table = createTable(serverStream)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        Return table
    End Function

    Public Function getFournisseurAdd(id() As Integer) As DataTable
        Dim table As New DataTable

        Try
            Dim serverStream As NetworkStream = clientSocket.GetStream()
            Dim text As String = "\\liste;"

            For i As Integer = 0 To id.Length - 1
                text += id(i) & ";"
            Next
            text += "\\listeEnd;"

            Dim outStream As Byte() = Encoding.ASCII.GetBytes(text & "getFournisseur;$")
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()



            table = createTable(serverStream)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        Return table
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
End Class
