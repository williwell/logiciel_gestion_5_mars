Imports System.Data
Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Module Program
    Sub Main()
        Dim serverSocket As New TcpListener(IPAddress.Parse("127.0.0.1"), 8888)
        Dim clientSocket As TcpClient
        While True
            Try
                serverSocket.Start()
                Msg("Server Started")
                clientSocket = serverSocket.AcceptTcpClient()
                Msg("Accept connection from client")
                Msg("")
                While (True)

                    If clientSocket.Connected Then
                        Dim networkStream As NetworkStream = clientSocket.GetStream()
                        Dim bytesFrom(10024) As Byte
                        networkStream.Read(bytesFrom, 0, 1024)
                        Dim dataFromClient As String = Encoding.ASCII.GetString(bytesFrom)
                        dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"))
                        Msg("Data from client -  " + dataFromClient)
                        Action(dataFromClient, networkStream)
                    Else
                        Msg("Waiting for new client")
                        clientSocket = serverSocket.AcceptTcpClient()
                        Msg("Accept connection from client")
                        Msg("")
                    End If

                End While

                clientSocket.Close()
                serverSocket.Stop()
                Msg("exit")
                Console.ReadLine()

            Catch ex As Exception
                Msg(ex.ToString)
            End Try

        End While
    End Sub

    Sub Msg(mesg As String)
        mesg.Trim()
        Console.WriteLine(" >> " + mesg)
    End Sub

    Sub Action(str As String, networkStream As NetworkStream)
        Select Case str
            Case "test"
                SendBoolean(True, networkStream)
            Case "getInventaire"
                SendDataTable(EntityInventaire.getInstance.getInventaire(), networkStream)
            Case "getInventaire(Id)"
                Dim id As String = ""
                SendDataTable(EntityInventaire.getInstance.getInventaire(id), networkStream)
        End Select
    End Sub

    Sub Action(str As String, networkStream As NetworkStream, id As String)
        Select Case str
            Case "getInventaire"
                SendDataTable(EntityInventaire.getInstance.getInventaire(id), networkStream)
        End Select
    End Sub

    Sub SendDataTable(table As DataTable, networkStream As NetworkStream)
        Dim sendBytes As [Byte]()
        Dim row As Integer = table.Rows.Count - 1
        Dim col As Integer = table.Columns.Count - 1
        Dim str As String = row & ";" & col & ";"

        For c As Integer = 0 To col
            str += table.Columns(c).ColumnName & ";"
        Next
        For r As Integer = 0 To row
            For c As Integer = 0 To col
                str += table(r)(c) & ";"
            Next
            str += "\\row;"
        Next
        str += "\\end;"

        sendBytes = Encoding.ASCII.GetBytes(str)
        networkStream.Write(sendBytes, 0, sendBytes.Length)
        networkStream.Flush()
        Msg(str)
        Msg("")
    End Sub

    Sub SendBoolean(bool As Boolean, networkStream As NetworkStream)
        Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes(bool)
        networkStream.Write(sendBytes, 0, sendBytes.Length)
        networkStream.Flush()
        Msg(bool)
        Msg("")
    End Sub

    Sub checkData(data As String, networkStream As NetworkStream)
        Dim i() As Integer
        'CEst la que je suis rendu
    End Sub
End Module
