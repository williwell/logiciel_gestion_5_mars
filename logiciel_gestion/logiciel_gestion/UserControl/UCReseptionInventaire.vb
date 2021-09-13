Public Class UCReseptionInventaire
    Dim sameID As String
    Dim nomClass = "UCReseptionInventaire"

    Private Sub tbIdPiece_KeyDown(sender As Object, e As KeyEventArgs) Handles tbIdPiece.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If sameID <> tbIdPiece.Text Then
                    nudQuantiteMod.ReadOnly = True
                    Dim table As DataTable = InventaireEntity.getInstance.getInventaire(tbIdPiece.Text)
                    If table.Rows.Count > 0 Then
                        labPasItem.Text = ""
                        tbNomPiece.Text = table.Rows(0)(1)
                        tbQuantitePiece.Text = table.Rows(0)(2)
                        tbDescription.Text = table.Rows(0)(3)
                        tbEmplacementPiece.Text = table.Rows(0)(5)
                        tbCommande.Text = table.Rows(0)(8)
                        If table.Rows(0)(7) <> 1 Then
                            labPasItem.Text = "Cette item n'est plus utilisé normalement!"
                            labPasItem.ForeColor = Color.FromArgb(225, 202, 56)
                        End If
                        nudQuantiteMod.ReadOnly = False
                        nudQuantiteMod.Select()
                    Else
                        labPasItem.Text = "Le numéro d'item n'existe pas!"
                        labPasItem.ForeColor = Color.Red
                        tbIdPiece.SelectAll()
                    End If
                    sameID = tbIdPiece.Text
                End If
            End If
        Catch ex As Exception
            ErrLog.getInstance.writeErr(ex.Message, nomClass, "tbIdPiece_keyDown")
            MessageBox.Show("Une erreur c'est produit!")
        End Try
    End Sub

    Private Sub tbIdPiece_GotFocus(sender As Object, e As EventArgs) Handles tbIdPiece.GotFocus
        tbIdPiece.SelectAll()
    End Sub

    Private Sub tbIdPiece_Click(sender As Object, e As EventArgs) Handles tbIdPiece.Click
        tbIdPiece.SelectAll()
    End Sub

    Private Sub nudQuantiteMod_KeyDown(sender As Object, e As KeyEventArgs) Handles nudQuantiteMod.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If nudQuantiteMod.Value > 0 Then
                    ajouter()
                End If
            End If
        Catch ex As Exception
            ErrLog.getInstance.writeErr(ex.Message, nomClass, "nudQuantiteMod_keyDown")
            MessageBox.Show("Une erreur c'est produit!")
        End Try
    End Sub

    Private Sub btAjouter_Click(sender As Object, e As EventArgs) Handles btAjouter.Click
        ajouter()
    End Sub

    Private Sub ajouter()
        Try
            Dim result As DialogResult = MessageBox.Show("Voulez-vous vraiment ajouter " + nudQuantiteMod.Value.ToString, "Attention!", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim commande As Integer = Integer.Parse(tbCommande.Text) - nudQuantiteMod.Value
                If commande < 0 Then
                    commande = 0
                End If
                If InventaireModel.getInstance.ajouterInventaire(tbIdPiece.Text, Integer.Parse(tbQuantitePiece.Text) + nudQuantiteMod.Value, commande) Then
                    labPasItem.Text = "Le nombre d'item à bien été ajouter"
                    labPasItem.ForeColor = Color.Green
                    tbNomPiece.Text = ""
                    tbQuantitePiece.Text = ""
                    tbDescription.Text = ""
                    tbEmplacementPiece.Text = ""
                    tbCommande.Text = ""
                    nudQuantiteMod.ReadOnly = True
                    nudQuantiteMod.Text = ""
                    sameID = ""
                    tbIdPiece.Select()
                    tbIdPiece.SelectAll()
                Else
                    MessageBox.Show("Une erreur c'est produit")
                End If
            End If
        Catch ex As Exception
            ErrLog.getInstance.writeErr(ex.Message, nomClass, "ajouter")
            MessageBox.Show("Une erreur c'est produit!")
        End Try
    End Sub

    Private Sub UCReseptionInventaire_Load(sender As Object, e As EventArgs) Handles Me.Load
        tbIdPiece.Select()
        nudQuantiteMod.Text = ""
    End Sub

    Private Sub remplir()

    End Sub
End Class
