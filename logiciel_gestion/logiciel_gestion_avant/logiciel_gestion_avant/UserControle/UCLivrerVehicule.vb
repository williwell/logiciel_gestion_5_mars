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
            Dim liste() As String = {DGVVehicule.CurrentRow.Cells(0).Value, "0"}
            If ConnectionServeur.Getinstance.AddDelete(liste, "livrerVehicule") Then
                MessageBox.Show("Le véhicule à bien été mit comme livrer!")
                DGVVehicule.Rows.Remove(DGVVehicule.CurrentRow)
            Else
                MessageBox.Show("Une erreure est survenu durant le changement du véhicule à l'état livrer!", "Attention!")
            End If
        End If
    End Sub
End Class
