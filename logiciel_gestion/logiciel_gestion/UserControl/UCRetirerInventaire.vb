Public Class UCRetirerInventaire
    Dim sameID As String
    Dim nomClass = "UCRetirerInventaire"
    Dim table As DataTable
    Dim result As DialogResult
    Dim enlever As Integer

    Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub

    Private Sub tbIdPiece_KeyDown(sender As Object, e As KeyEventArgs) Handles tbIdPiece.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If sameID <> tbIdPiece.Text Then
                    nudQuantiteMod.ReadOnly = True
                    table = InventaireEntity.getInstance.getInventaire(tbIdPiece.Text)
                    If table.Rows.Count > 0 Then
                        If table.Rows(0)(2) < 0 Then
                            result = MessageBox.Show("Le nombre d'item est négatif dans l'inventaire voulez-vous continuer quand même?", "Attention!", MessageBoxButtons.YesNo)
                            If result = DialogResult.Yes Then
                                remplir()
                            End If
                        Else
                            remplir()
                        End If

                    Else
                        labPasItem.Text = "Le numéro d'item n'existe pas!"
                        labPasItem.ForeColor = Color.Red
                        cleane()
                    End If

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
                    retirer()
                End If
            End If
        Catch ex As Exception
            ErrLog.getInstance.writeErr(ex.Message, nomClass, "nudQuantiteMod_keyDown")
            MessageBox.Show("Une erreur c'est produit!")
        End Try
    End Sub

    Private Sub retirer()
        Try
            result = MessageBox.Show("Voulez-vous vraiment retirer " + nudQuantiteMod.Value.ToString, "Attention!", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                enlever = Integer.Parse(tbQuantitePiece.Text) - nudQuantiteMod.Value

                If enlever < 0 Then

                    result = MessageBox.Show("Le nombre d'objet enlever est plus quand que la quantité dans l'inventaire voulez-vraiment continuer?", "Attention!", MessageBoxButtons.YesNo)

                    If result = DialogResult.Yes Then

                        If InventaireModel.getInstance.enleverInventaire(tbIdPiece.Text, enlever) Then
                            labPasItem.Text = "Le nombre d'item à bien été enlever"
                            labPasItem.ForeColor = Color.Green
                        Else
                            MessageBox.Show("Une erreur c'est produit")
                        End If

                    End If

                Else

                    If InventaireModel.getInstance.enleverInventaire(tbIdPiece.Text, enlever) Then
                        labPasItem.Text = "Le nombre d'item à bien été retirer"
                        labPasItem.ForeColor = Color.Green
                        cleane()
                    Else
                        MessageBox.Show("Une erreur c'est produit")
                    End If
                End If

            End If

        Catch ex As Exception
            ErrLog.getInstance.writeErr(ex.Message, nomClass, "retirer")
            MessageBox.Show("Une erreur c'est produit!")
        End Try
    End Sub

    Private Sub UCRetirerInventaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbIdPiece.Select()
        nudQuantiteMod.Text = ""
    End Sub

    Private Sub btEnlever_Click(sender As Object, e As EventArgs) Handles btEnlever.Click
        retirer()
    End Sub

    Private Sub cleane()
        Try
            tbNomPiece.Text = ""
            tbQuantitePiece.Text = ""
            tbDescription.Text = ""
            tbEmplacementPiece.Text = ""
            tbCommande.Text = ""
            nudQuantiteMod.ReadOnly = True
            sameID = ""
            tbIdPiece.Select()
            tbIdPiece.SelectAll()
        Catch ex As Exception
            ErrLog.getInstance.writeErr(ex.Message, nomClass, "cleane")
            MessageBox.Show("Une erreur c'est produit!")
        End Try
    End Sub

    Private Sub remplir()
        labPasItem.Text = ""
        tbNomPiece.Text = table.Rows(0)(1)
        tbQuantitePiece.Text = table.Rows(0)(2)
        tbDescription.Text = table.Rows(0)(3)
        tbEmplacementPiece.Text = table.Rows(0)(5)
        tbCommande.Text = table.Rows(0)(8)
        sameID = tbIdPiece.Text
        If table.Rows(0)(7) <> 1 Then
            labPasItem.Text = "Cette item n'est plus utilisé normalement!"
            labPasItem.ForeColor = Color.FromArgb(225, 202, 56)

        End If
        nudQuantiteMod.ReadOnly = False
        nudQuantiteMod.Select()
    End Sub
End Class
