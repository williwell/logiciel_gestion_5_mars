Public Class UCLivrerVehicule
    Private Sub UCLivrerVehicule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim table As DataTable = ConnectionServeur.Getinstance.GetInfo("GetVehiculeFab")
        DGVVehicule.DataSource = table
    End Sub

    Private Sub BTLivrer_Click(sender As Object, e As EventArgs) Handles BTLivrer.Click
        Dim str As String = ""

        For i As Integer = 0 To DGVVehicule.Columns.Count - 1
            str += DGVVehicule.CurrentRow.Cells(i).Value & "; "
        Next

        If MessageBox.Show("Voulez-vous vraiment mettre ce véhicule comme étant livrer?" & vbCrLf & str, "Attention!", MessageBoxButtons.YesNo) = DialogResult.Yes Then

        End If
    End Sub
End Class
