Public Class CreerCouleur
    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        If Not String.IsNullOrEmpty(TBNom.Text) Then
            If Not String.IsNullOrEmpty(TBCode.Text) Then
                Dim liste() As String = {TBNom.Text, TBCode.Text, NUDCout.Value}
                If ConnectionServeur.Getinstance.AddDelete(liste, "AddCoul") Then
                    MessageBox.Show("La création de la nouvelle couleur réussit!")

                    Dim row As DataRow = MainForm.tableCoulVe.NewRow
                    Dim nbr As Integer = 0
                    For r As Integer = 0 To MainForm.tableCoulVe.Rows.Count - 1
                        If MainForm.tableCoulVe.Rows(r).Item("id") >= nbr Then
                            nbr = Integer.Parse(MainForm.tableCoulVe.Rows(r).Item("id")) + 1
                        End If
                    Next
                    row(0) = nbr
                    For c As Integer = 0 To liste.Length - 1
                        row(c + 1) = liste(c)
                    Next
                    MainForm.tableCoulVe.Rows.Add(row)

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

    Private Sub NUDCout_KeyDown(sender As Object, e As KeyEventArgs) Handles NUDCout.KeyDown
        If e.KeyCode = 110 Or e.KeyCode = 190 Then
            e.SuppressKeyPress = True
            SendKeys.Send(",")
        End If
    End Sub
End Class