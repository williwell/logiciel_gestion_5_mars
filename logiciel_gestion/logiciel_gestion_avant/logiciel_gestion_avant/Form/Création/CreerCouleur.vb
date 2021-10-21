Public Class CreerCouleur
    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        If Not String.IsNullOrEmpty(TBNom.Text) Then
            If Not String.IsNullOrEmpty(TBCode.Text) Then
                Dim liste() As String = {TBNom.Text, TBCode.Text, NUDCout.Value}
                If ConnectionServeur.Getinstance.AddDelete(liste, "AddCoul") Then
                    MessageBox.Show("La création de la nouvelle couleur réussit!")
                    Me.Close()
                Else
                    MessageBox.Show("Une erreure est survenue durant l'enregistrement!")
                End If
            Else
                MessageBox.Show("La couleur doit avoir un code!")
            End If
        Else
            MessageBox.Show("La couleur doit avoir un nom!")
        End If
    End Sub
End Class