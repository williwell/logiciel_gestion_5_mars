Public Class UCGestionVehicule
    Dim table As DataTable
    Dim search As New BindingSource
    Dim bool As Boolean = True

    Private Sub UCGestionVehicule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        table = ConnectionServeur.Getinstance.GetInfo("GetVehiculeAll")
        DGVVehicule.DataSource = table
        search.DataSource = DGVVehicule.DataSource
    End Sub

    Private Sub SearchDGV()
        If CBFab.Checked Then
            If CBInv.Checked Then
                search.Filter = "fabriquer like 'true' and eninventaire like 'true'"
            Else
                search.Filter = "fabriquer like 'true'"
            End If
        Else
            If CBInv.Checked Then
                search.Filter = "eninventaire like 'true'"
            Else
                search.Filter = ""
            End If
        End If
    End Sub

    Private Sub CBFab_CheckedChanged(sender As Object, e As EventArgs) Handles CBFab.CheckedChanged
        SearchDGV()
    End Sub

    Private Sub CBInv_CheckedChanged(sender As Object, e As EventArgs) Handles CBInv.CheckedChanged
        SearchDGV()
    End Sub
End Class
