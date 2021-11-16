Public Class UCFabriquer
    Dim table As DataTable
    Private Sub UCFabriquer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        table = ConnectionServeur.Getinstance.GetInfo("getVehiculeFab")
    End Sub
End Class
