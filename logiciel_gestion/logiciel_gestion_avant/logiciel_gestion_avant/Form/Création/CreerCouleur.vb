Public Class CreerCouleur
    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        If Not String.IsNullOrEmpty(TBNom.Text) Then
            If Not String.IsNullOrEmpty(TBCode.Text) Then
                Dim liste() As String = {TBNom.Text, TBCode.Text, NUDCout.Value}
                If ConnectionServeur.Getinstance.AddDelete(liste, "AddCoul") Then
                    MessageBox.Show(MsgTextFr.Getinstance.MsgCreationCoul)

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
                    row(liste.Length + 1) = True
                    MainForm.tableCoulVe.Rows.Add(row)

                    Me.Close()
                Else
                    MessageBox.Show(MsgTextFr.Getinstance.MsgErrServ)
                End If
            Else
                MessageBox.Show(MsgTextFr.Getinstance.MsgMissCodeCoul)
            End If
        Else
            MessageBox.Show(MsgTextFr.Getinstance.MsgMissNomCoul)
        End If
    End Sub

    Private Sub NUDCout_KeyDown(sender As Object, e As KeyEventArgs) Handles NUDCout.KeyDown
        Dim lang = Globalization.CultureInfo.CurrentCulture
        If lang.Name = "fr-CA" Then
            If e.KeyCode = 110 Or e.KeyCode = 190 Then
                e.SuppressKeyPress = True
                SendKeys.Send(",")
            End If
        End If
    End Sub
End Class