Imports System.Net.Sockets
Imports System.Text
Public Class ConnectionServeur
    Dim serverStream As NetworkStream
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
            Dim outStream As Byte() = Encoding.ASCII.GetBytes("test$")
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()

            Dim inStream(1024) As Byte
            serverStream.Read(inStream, 0, 1024)
            If Not Boolean.Parse(Encoding.ASCII.GetString(inStream)) Then
                MessageBox.Show("Impossible de se connecter au serveur!")
            End If
        Catch ex As Exception
            MessageBox.Show("Impossible de se connecter au serveur!")
        End Try
    End Sub

    Public Function GetInventaire() As DataTable
        Dim search As Boolean = True
        Dim i As Integer = 0
        Dim int As Integer = 0
        Dim table As New DataTable

        Try
            Dim serverStream As NetworkStream = clientSocket.GetStream()
            Dim outStream As Byte() = Encoding.ASCII.GetBytes("getInventaire$")
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()

            Dim inStream(1024) As Byte
            serverStream.Read(inStream, 0, 1024)
            Dim str As String = Encoding.ASCII.GetString(inStream)

            Dim row As Integer = Integer.Parse(str.Substring(0, str.IndexOf(";")))
            str = str.Substring(str.IndexOf(";") + 1)
            Dim col As Integer = Integer.Parse(str.Substring(0, str.IndexOf(";")))
            str = str.Substring(str.IndexOf(";") + 1)


            For c As Integer = 0 To col
                MessageBox.Show(str.Substring(0, str.IndexOf(";")))
                table.Columns.Add(str.Substring(0, str.IndexOf(";")), GetType(String))
                str = str.Substring(str.IndexOf(";") + 1)
            Next

            For r As Integer = 0 To row
                table.Rows.Add()
            Next

            While search
                If Not str.Substring(0, 6) = "\\end;" Then
                    If Not str.Substring(0, 6) = "\\row;" Then
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
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        Return table
    End Function
End Class
