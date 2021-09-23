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
                        checkData(dataFromClient, networkStream)
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
            Case "getFournisseur"
                SendDataTable(EntityFournisseur.getInstance.getFournisseur(), networkStream)
        End Select
    End Sub

    Sub Action(str As String, networkStream As NetworkStream, id As String)
        Select Case str
            Case "getInventaire"
                SendDataTable(EntityInventaire.getInstance.getInventaire(id), networkStream)
            Case "getInventaireOfFour"
                SendDataTable(EntityInventaire.getInstance.getInventaireOfFour(Integer.Parse(id)), networkStream)
            Case "getFournisseur"
                SendDataTable(EntityFournisseur.getInstance.getFournisseur(Integer.Parse(id)), networkStream)
            Case "getOneFournisseur"
                SendDataTable(EntityFournisseur.getInstance.getOneFournisseur(Integer.Parse(id)), networkStream)
        End Select
    End Sub

    Sub Action(str As String, networkStream As NetworkStream, text() As String)
        Select Case str
            Case "getFournisseurAdd"
                Dim int(text.Length - 1) As Integer
                For i As Integer = 0 To text.Length - 1
                    int(i) = Integer.Parse(text(i))
                Next
                SendDataTable(EntityFournisseur.getInstance.getFournisseurAdd(int), networkStream)
            Case "modFour"
                SendDataTable(ModelFournisseur.getinstance.modFour(text), networkStream)
            Case "modInventaire"
                SendDataTable(ModelInventaire.getInstance.modInventaire(text), networkStream)
            Case "ajoutInventaire"
                SendDataTable(ModelInventaire.getInstance.ajoutInventaire(text), networkStream)
            Case "addInvFour"
                SendDataTable(ModelInvFour.Getinstance.AddInvFour(text), networkStream)
            Case "modInvFour"
                SendDataTable(ModelInvFour.Getinstance.ModInvFour(text), networkStream)
            Case "delInvFour"
                SendDataTable(ModelInvFour.Getinstance.DelInvFour(text), networkStream)
        End Select
    End Sub

    Sub Action(str As String, networkStream As NetworkStream, text() As String, id As String)
        Select Case str

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
        Dim i As Integer = -1
        Dim liste() As String
        Dim nbr As Integer = 0
        Dim bool As Boolean = False

        If InStr(data, "\\liste;") >= 1 Then
            data = data.Substring(data.IndexOf(";") + 1)
            Dim check As Boolean = True

            While check
                If Not data.Substring(0, 11) = "\\listeEnd;" Then
                    ReDim Preserve liste(nbr)
                    liste(nbr) = data.Substring(0, data.IndexOf(";"))
                    data = data.Substring(data.IndexOf(";") + 1)
                    nbr += 1
                Else
                    data = data.Substring(data.IndexOf(";") + 1)
                    check = False
                End If
            End While
            bool = True
        End If

        For Each c As Char In data
            If c = ";" Then
                i += 1
            End If
        Next

        Dim str(i) As String

        For int As Integer = 0 To i
            str(int) = data.Substring(0, data.IndexOf(";"))
            data = data.Substring(data.IndexOf(";") + 1)
            Msg(str(int))
        Next

        If bool Then
            i += 1
        End If

        Msg(i)
        Select Case i
            Case 0
                Action(str(0), networkStream)
            Case 1
                If IsNothing(liste) Then
                    Action(str(0), networkStream, str(1))
                Else
                    Action(str(0), networkStream, liste)
                End If
            Case 2
                Action(str(0), networkStream, liste, str(1))
        End Select
    End Sub
End Module
