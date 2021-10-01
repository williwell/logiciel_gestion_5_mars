Imports System.Net
Imports System.Net.Sockets

Module Program
    Sub Main()
        Dim serverSocket As New TcpListener(IPAddress.Any, 8888)
        Dim clientSocket As TcpClient
        Dim counter As Integer

        serverSocket.Start()
        Msg("Server Started")
        counter = 0

        While True
            Try
                counter += 1
                clientSocket = serverSocket.AcceptTcpClient()
                Msg("Client No:" + Convert.ToString(counter) + " started!")
                Dim client As New handleClient
                client.startClient(clientSocket, Convert.ToString(counter))
            Catch ex As Exception
                Msg(ex.ToString)
            End Try

        End While
    End Sub

    Sub Msg(mesg As String)
        mesg.Trim()
        Console.WriteLine(" >> " + mesg)
    End Sub
End Module
