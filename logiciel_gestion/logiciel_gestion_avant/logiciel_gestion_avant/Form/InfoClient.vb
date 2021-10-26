Public Class InfoClient
    Private Sub InfoClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectionServeur.Getinstance.GetInfo("FactureClient")
    End Sub
End Class