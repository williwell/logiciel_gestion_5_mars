Public Class UCCouleurToile
    ReadOnly main As MainForm
    ReadOnly tableCoul As New DataTable
    Dim listeOr(0, 0) As String

    Sub New(mainform As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = mainform
    End Sub

    Private Sub UCCouleurToile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Ajouter les colonnes dans la tableCoul et appeler la fonction LoadCoul
        tableCoul.Columns.Add("ID")
        tableCoul.Columns.Add("Nom")
        tableCoul.Columns.Add("Code")
        LoadCoul()

        For c As Integer = 0 To dgvCouleur.Columns.Count - 1
            dgvCouleur.Columns(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    'Si on click sur ce bouton, on créer un nouveau form de type CreerCOuleurToile et on l'affiche
    Private Sub BtCreer_Click(sender As Object, e As EventArgs) Handles BtCreer.Click
        Dim NewCoul As New CreerCouleurToile(Me)
        NewCoul.ShowDialog(Me)
    End Sub

    'Fonction qui sert a mettre les information dans la tableCoul pour après le mettre dans le DataGridView 
    Public Sub LoadCoul()
        'Clearer toutes les lignes dans la table
        tableCoul.Clear()

        'Loop pour prendre toutes les information de la tableCoulToi dans le mainform qui n'a pas le paramètre deleteCoul a 0
        For r As Integer = 0 To MainForm.tableCoulToi.Rows.Count - 1
            If MainForm.tableCoulToi.Rows(r).Item("deletecoul") = True Then
                Dim row As DataRow = tableCoul.NewRow
                row(0) = MainForm.tableCoulToi.Rows(r).Item("id")
                row(1) = MainForm.tableCoulToi.Rows(r).Item("nom")
                row(2) = MainForm.tableCoulToi.Rows(r).Item("code")
                tableCoul.Rows.Add(row)
            End If
        Next

        'Mettre le dataSource de DataGridView égal à la tableCOul
        dgvCouleur.DataSource = tableCoul

        'Remplir la listeOriginal avec les informations de la table qu'on vien de remplir
        ReDim listeOr(tableCoul.Rows.Count - 1, tableCoul.Columns.Count - 1)
        For r As Integer = 0 To tableCoul.Rows.Count - 1
            For c As Integer = 0 To tableCoul.Columns.Count - 1
                listeOr(r, c) = tableCoul(r)(c)
            Next
        Next

        If dgvCouleur.Rows.Count = 0 Then
            BtDel.Enabled = False
        Else
            BtDel.Enabled = True
        End If
    End Sub


    'Si on click sur ce bouton, on remet l'information qui est dans la listeOriginal dans le DataGridView pour annuler tous changement fait
    Private Sub BTAnnuler_Click(sender As Object, e As EventArgs) Handles BTAnnuler.Click
        For r As Integer = 0 To dgvCouleur.Rows.Count - 1
            For c As Integer = 0 To dgvCouleur.Columns.Count - 1
                tableCoul(r)(c) = listeOr(r, c)
            Next
        Next
        CheckerChange()
    End Sub

    'SI on click sur ce bouton, on check ce qui est différent dans le dataGridView et la liste original pour sa voir se que on doit sauvegarder
    Private Sub BTEnregistrer_Click(sender As Object, e As EventArgs) Handles BTEnregistrer.Click
        'Loop tous les lignes de la tableCoul
        For r As Integer = 0 To tableCoul.Rows.Count - 1
            Dim bool As Boolean = False
            Dim listeAdd(tableCoul.Columns.Count - 1) As String
            'Loop toutes les colonnes de la tableCoul et met l'information de la ligne et la colonne dans une listeAdd
            For c As Integer = 0 To tableCoul.Columns.Count - 1
                listeAdd(c) = tableCoul(r)(c)
                'SI la tableCoul et la listeOriginal n'est pas pareille on met le Boolean a true
                If Not tableCoul(r)(c) = listeOr(r, c) Then
                    bool = True
                End If
            Next
            'Si le boolean est true, on envoie la listeAdd au serveur pour qu'il fasse la modification
            If bool Then
                If ConnectionServeur.Getinstance.AddDelete(listeAdd, "updateCouleurToi") Then
                    'Loop pour mettre les nouvelle information dans la listeORiginal
                    For c As Integer = 0 To tableCoul.Columns.Count - 1
                        listeOr(r, c) = listeAdd(c)
                    Next
                    'loop pour Changer les informations dans la tableCOulToi du mainform
                    For r2 As Integer = 0 To MainForm.tableCoulToi.Rows.Count - 1
                        If MainForm.tableCoulToi.Rows(r2).Item("id") = listeAdd(0) Then
                            For c As Integer = 1 To MainForm.tableCoulToi.Columns.Count - 2
                                MainForm.tableCoulToi(r2)(c) = listeAdd(c)
                            Next
                        End If
                    Next
                    MessageBox.Show(MsgTextFr.Getinstance.MsgSauvServ)
                Else
                    MessageBox.Show(MsgTextFr.Getinstance.MsgErrServ)
                End If
            End If
        Next
        CheckerChange()
    End Sub

    'Quand on commence à éditer une cellule dans le DataGridView on regarde si la colonnes est de l'index 0 si oui on annule l'action
    Private Sub DGVCouleur_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvCouleur.CellBeginEdit
        If e.ColumnIndex = 0 Then
            e.Cancel = True
        End If
    End Sub

    'Quand on édite, si la colonne qui est éditer est la colonne 3 on créer un handler avec le keypress qui est effectuer
    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvCouleur.EditingControlShowing
        If dgvCouleur.CurrentCell.ColumnIndex = 3 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        End If
    End Sub

    'Si la colonne qui est sélectionner est de l'index 3 et que le keypress n'est pas un nombre, on met le handled de keypress a true
    Private Sub TextBox_keyPress(sender As Object, e As KeyPressEventArgs)
        If dgvCouleur.CurrentCell.ColumnIndex = 3 Then
            If Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    'Si on click sur ce bouton, on envoie au serveur l'instruction de changer le paramètre deleteCoul pour le mettre a 0 pour la ligne avec le même id
    Private Sub BtDel_Click(sender As Object, e As EventArgs) Handles BtDel.Click
        If MessageBox.Show(MsgTextFr.Getinstance.MsgConfirSupp + dgvCouleur.CurrentRow.Cells(1).Value + "?", MsgTextFr.Getinstance.MsgAttention, MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ConnectionServeur.Getinstance.GetInfo(dgvCouleur.CurrentRow.Cells(0).Value, "ChangeDeleteToi")
            'loop pour trouver quel ligne a le même id et changer le paramètre deleteCOul pour mettre 0
            For r As Integer = 0 To MainForm.tableCoulToi.Rows.Count - 1
                If MainForm.tableCoulToi.Rows(r).Item("id") = dgvCouleur.CurrentRow.Cells(0).Value Then
                    MainForm.tableCoulToi.Rows(r).Item("deleteCOul") = 0
                End If
            Next
            LoadCoul()
        End If
    End Sub

    'Quand on fini d'éditer une cellule on regarder si a des changement en appelent la fonction CheckerChange
    Private Sub DGVCouleur_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCouleur.CellEndEdit
        CheckerChange()
    End Sub

    'FOnction qui sert à voir si a des changement entre la listeOriginal et le datagridview et fait fonctionner les boutons ou non
    Private Sub CheckerChange()
        BTEnregistrer.Enabled = False
        BTAnnuler.Enabled = False
        For r As Integer = 0 To dgvCouleur.Rows.Count - 1
            For c As Integer = 0 To dgvCouleur.Columns.Count - 1
                If Not dgvCouleur.Rows(r).Cells(c).Value = listeOr(r, c) Then
                    BTEnregistrer.Enabled = True
                    BTAnnuler.Enabled = True
                End If
            Next
        Next
    End Sub

    'si on click dans le USerCOntrol on fait un check pour voir si le menu du mainform est bien fermer
    Private Sub UCCouleurToile_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub
End Class
