Imports System.Data
Imports System.Net.Sockets
Imports System.Text
Public Class HandleClient
    Dim clientSocket As TcpClient
    Dim clNo As String
    Dim i As Integer = 0

    Public Sub StartClient(inClientSocket As TcpClient, clineNo As String)
        clientSocket = inClientSocket
        clNo = clineNo
        Dim ctThread As Threading.Thread = New Threading.Thread(AddressOf doChat)
        ctThread.Start()
    End Sub
    Private Sub DoChat()
        Dim bytesFrom(10024) As Byte
        Dim dataFromClient As String
        Dim bool As Boolean = True

        While (bool)
            Try
                If clientSocket.Connected = True Then
                    Dim networkStream As NetworkStream = clientSocket.GetStream()
                    networkStream.Read(bytesFrom, 0, 1024)
                    dataFromClient = Encoding.ASCII.GetString(bytesFrom)
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"))
                    If Not dataFromClient = "test;" Then
                        Msg("From client-" + clNo + ": " + dataFromClient)
                    End If
                    CheckData(dataFromClient, networkStream)
                    i = 0
                Else
                    clientSocket.Close()
                    bool = False
                End If
            Catch ex As Exception
                If i < 5 Then
                    Msg(ex.Message)
                    i += 1
                Else
                    clientSocket.Close()
                    bool = False
                End If
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
            Case "fermer"
                Msg("Fermeture client:" + clNo)
                Msg("")
                clientSocket.Close()
            Case "getInventaire"
                SendDataTable(EntityInventaire.GetInstance.GetInventaire(), networkStream)
            Case "getFournisseur"
                SendDataTable(EntityFournisseur.GetInstance.GetFournisseur(), networkStream)
            Case "getModel"
                SendDataTable(EntityModel.GetInstance.GetModel(), networkStream)
            Case "getOptionAdd"
                SendDataTable(EntityModel.GetInstance.GetOptionDispo(), networkStream)
            Case "getCouleurAdd"
                SendDataTable(EntityModel.GetInstance.GetCouleurDispo(), networkStream)
        End Select
    End Sub

    Sub Action(str As String, networkStream As NetworkStream, id As String)
        Select Case str
            Case "getInventaire"
                SendDataTable(EntityInventaire.GetInstance.GetInventaire(id), networkStream)
            Case "getInventaireOfFour"
                SendDataTable(EntityInventaire.GetInstance.GetInventaireOfFour(Integer.Parse(id)), networkStream)
            Case "getFournisseur"
                SendDataTable(EntityFournisseur.GetInstance.GetFournisseur(Integer.Parse(id)), networkStream)
            Case "getOneFournisseur"
                SendDataTable(EntityFournisseur.GetInstance.GetOneFournisseur(Integer.Parse(id)), networkStream)
            Case "getOptionModel"
                SendDataTable(EntityModel.GetInstance.GetOptionModel(Integer.Parse(id)), networkStream)
            Case "getCouleurModel"
                SendDataTable(EntityModel.GetInstance.GetCouleurModel(Integer.Parse(id)), networkStream)
        End Select
    End Sub

    Sub Action(str As String, networkStream As NetworkStream, text() As String)
        Select Case str
            Case "getFournisseurAdd"
                Dim int(text.Length - 1) As Integer
                For i As Integer = 0 To text.Length - 1
                    int(i) = Integer.Parse(text(i))
                Next
                SendDataTable(EntityFournisseur.GetInstance.GetFournisseurAdd(int), networkStream)
            Case "modFour"
                SendDataTable(ModelFournisseur.Getinstance.ModFour(text), networkStream)
            Case "modInventaire"
                SendDataTable(ModelInventaire.GetInstance.ModInventaire(text), networkStream)
            Case "ajoutInventaire"
                SendDataTable(ModelInventaire.GetInstance.AjoutInventaire(text), networkStream)
            Case "addInvFour"
                SendDataTable(ModelInvFour.Getinstance.AddInvFour(text), networkStream)
            Case "modInvFour"
                SendDataTable(ModelInvFour.Getinstance.ModInvFour(text), networkStream)
            Case "delInvFour"
                SendDataTable(ModelInvFour.Getinstance.DelInvFour(text), networkStream)
            Case "modQuantite"
                SendDataTable(ModelInventaire.GetInstance.ModQuantite(text), networkStream)
            Case "addFour"
                SendDataTable(ModelFournisseur.Getinstance.AddFour(text), networkStream)
            Case "getOptionAdd"
                SendDataTable(EntityModel.GetInstance.GetOptionDispo(text), networkStream)
            Case "getCouleurAdd"
                SendDataTable(EntityModel.GetInstance.GetCouleurDispo(text), networkStream)
        End Select
    End Sub

    'Sub Action(str As String, networkStream As NetworkStream, text() As String, id As String)
    '    Select Case str

    '    End Select
    'End Sub

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
        'msg(bool)
        'msg("")
    End Sub

    Sub CheckData(data As String, networkStream As NetworkStream)
        Dim i As Integer = -1
        Dim liste() As String = Nothing
        Dim nbr As Integer = 0
        Dim bool As Boolean = False

        If InStr(data, "\\liste;") >= 1 Then
            data = data.Substring(data.IndexOf(";") + 1)
            Dim check As Boolean = True

            While check
                If Not data.Substring(0, 11) = "\\listeEnd;" Then
                    bool = True
                    ReDim Preserve liste(nbr)
                    liste(nbr) = data.Substring(0, data.IndexOf(";"))
                    data = data.Substring(data.IndexOf(";") + 1)
                    nbr += 1
                Else
                    data = data.Substring(data.IndexOf(";") + 1)
                    check = False
                End If
            End While
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
        Next

        If bool Then
            i += 1
        End If

        Select Case i
            Case 0
                Action(str(0), networkStream)
            Case 1
                If IsNothing(liste) Then
                    Action(str(0), networkStream, str(1))
                Else
                    Action(str(0), networkStream, liste)
                End If
                'Case 2
                '    Action(str(0), networkStream, liste, str(1))
        End Select
    End Sub
End Class
