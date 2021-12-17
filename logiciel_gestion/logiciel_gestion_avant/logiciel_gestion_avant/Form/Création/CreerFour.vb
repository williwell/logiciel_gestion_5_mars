Public Class CreerFour
    ReadOnly four As UCFournisseur

    Sub New(fournisseur As UCFournisseur)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        four = fournisseur
    End Sub

    Private Sub BtCreer_Click(sender As Object, e As EventArgs) Handles btCreer.Click
        Dim liste(9) As String
        If String.IsNullOrEmpty(tbNomFour.Text) Then
            MessageBox.Show("Le fournisseur doit avoir un nom!")
        Else
            liste(0) = tbNomFour.Text

            If String.IsNullOrEmpty(tbAdres2.Text) Then
                tbAdres2.Text = "null"
            Else
                If String.IsNullOrEmpty(tbAdres1.Text) Or tbAdres1.Text = "null" Then
                    tbAdres1.Text = tbAdres2.Text
                    tbAdres2.Text = "null"
                End If
            End If
            liste(2) = tbAdres2.Text

            If String.IsNullOrEmpty(tbAdres1.Text) Then
                tbAdres1.Text = "null"
            End If
            liste(1) = tbAdres1.Text

            If String.IsNullOrEmpty(tbTel.Text) Then
                tbTel.Text = "null"
            End If
            liste(3) = tbTel.Text

            If String.IsNullOrEmpty(tbNomCont.Text) Then
                tbNomCont.Text = "null"
            End If
            liste(4) = tbNomCont.Text

            If String.IsNullOrEmpty(tbLeadTime.Text) Then
                tbLeadTime.Text = "null"
            End If
            liste(5) = tbLeadTime.Text

            If String.IsNullOrEmpty(tbAddCour.Text) Then
                tbAddCour.Text = "null"
            End If
            liste(6) = tbAddCour.Text

            If String.IsNullOrEmpty(tbMethodeCom.Text) Then
                tbMethodeCom.Text = "null"
            End If
            liste(7) = tbMethodeCom.Text

            If String.IsNullOrEmpty(tbNoCompte.Text) Then
                tbNoCompte.Text = "null"
            End If
            liste(8) = tbNoCompte.Text

            If String.IsNullOrEmpty(tbMethodePaie.Text) Then
                tbMethodePaie.Text = "null"
            End If
            liste(9) = tbMethodePaie.Text

            If ConnectionServeur.Getinstance.AddDelete(liste, "addFour") Then
                MessageBox.Show("La création du fournisseur à bien été fait")

                Dim row As DataRow = MainForm.tableFour.NewRow
                Dim nbr As Integer = 0
                For r As Integer = 0 To MainForm.tableFour.Rows.Count - 1
                    If MainForm.tableFour.Rows(r).Item("id") >= nbr Then
                        nbr = Integer.Parse(MainForm.tableFour.Rows(r).Item("id")) + 1
                    End If
                Next
                row(0) = nbr
                For c As Integer = 0 To liste.Length - 1
                    row(c + 1) = liste(c)
                Next
                MainForm.tableFour.Rows.Add(row)

                four.LoadFour()
                Me.Close()
            Else
                MessageBox.Show("Une erreur c'est produit durant la création du fournisseur")
            End If
        End If
    End Sub

    Private Sub TbTel_KeyDown(sender As Object, e As KeyEventArgs) Handles tbTel.KeyDown
        If Not (e.KeyCode = Keys.Back OrElse e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Left OrElse e.KeyCode = Keys.Right) Then
            If Not ((e.KeyCode >= 96 AndAlso e.KeyCode <= 105) OrElse (e.KeyCode >= 48 AndAlso e.KeyCode <= 57)) Then
                e.SuppressKeyPress = True
            End If
        End If
    End Sub

    Private Sub BtAnnuler_Click(sender As Object, e As EventArgs) Handles btAnnuler.Click
        Me.Close()
    End Sub
End Class