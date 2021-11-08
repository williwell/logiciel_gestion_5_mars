Public Class UCClient
    Dim tableCl As DataTable

    Private Sub UCClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadClient()
    End Sub

    Private Sub BtCreer_Click(sender As Object, e As EventArgs) Handles BtCreer.Click
        Dim creer As New CreerClient(Me)
        creer.ShowDialog(Me)
    End Sub

    Public Sub LoadClient()
        tableCl = ConnectionServeur.Getinstance.GetInfo("getClient")
        DGVClient.DataSource = tableCl
    End Sub

    Private Sub DGVClient_DoubleClick(sender As Object, e As EventArgs) Handles DGVClient.DoubleClick
        Dim InfoClient As New GestionClient(DGVClient.CurrentRow.Cells(0).Value, Me)
        InfoClient.ShowDialog()
    End Sub
End Class
