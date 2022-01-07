Public Class UCCouleur
    ReadOnly main As MainForm
    Dim tableCouleur As New DataTable
    Dim listeOr(0, 0) As String

    Sub New(mainform As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = mainform
    End Sub

    Private Sub UCCouleur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Mettre les colonnes dans la tableCouleur
        tableCouleur.Columns.Add("ID")
        tableCouleur.Columns.Add("Nom")
        tableCouleur.Columns.Add("Code")
        tableCouleur.Columns.Add("Coût")

        RemplirDGV()
    End Sub

    'On passe tous les lignes et les colonnes du DataGridView pour remettre les informations de la listeoriginal
    Private Sub BTAnnuler_Click(sender As Object, e As EventArgs) Handles BTAnnuler.Click
        For r As Integer = 0 To dgvCouleur.Rows.Count - 1
            For c As Integer = 0 To dgvCouleur.Columns.Count - 1
                tableCouleur(r)(c) = listeOr(r, c)
            Next
        Next
        CheckerChange()
    End Sub

    'On remplie le DataGridView avec les information de la tableCoulVe du mainform
    Public Sub RemplirDGV()
        'Clear la table pour ne pas ajouter par desus
        tableCouleur.Clear()

        For r As Integer = 0 To MainForm.tableCoulVe.Rows.Count - 1
            If MainForm.tableCoulVe.Rows(r).Item("deleteCoul") = True Then
                Dim row As DataRow = tableCouleur.NewRow
                row(0) = MainForm.tableCoulVe.Rows(r).Item("id")
                row(1) = MainForm.tableCoulVe.Rows(r).Item("nom")
                row(2) = MainForm.tableCoulVe.Rows(r).Item("code")
                row(3) = MainForm.tableCoulVe.Rows(r).Item("cout")
                tableCouleur.Rows.Add(row)
            End If
        Next

        'On met la tableCouleur comme source pour le DataGridView et après on met l'information dans la listeOriginal
        dgvCouleur.DataSource = tableCouleur
        ReDim listeOr(tableCouleur.Rows.Count - 1, tableCouleur.Columns.Count - 1)
        For r As Integer = 0 To tableCouleur.Rows.Count - 1
            For c As Integer = 0 To tableCouleur.Columns.Count - 1
                listeOr(r, c) = tableCouleur(r)(c)
            Next
        Next
    End Sub

    Private Sub BTEnregistrer_Click(sender As Object, e As EventArgs) Handles BTEnregistrer.Click
        'On passe chaqu'une des lignes de la tableCouleur et on crée une liste pour Ajouter
        For r As Integer = 0 To tableCouleur.Rows.Count - 1
            Dim bool As Boolean = False
            Dim listeAdd(tableCouleur.Columns.Count - 1) As String
            'On passe chaqu'une des colonnes de la tableCouleur
            For c As Integer = 0 To tableCouleur.Columns.Count - 1
                'On met l'information dans la liste et on regarde si l'information de la liste original n'est pas parreil à la table
                listeAdd(c) = tableCouleur(r)(c)
                If Not tableCouleur(r)(c) = listeOr(r, c) Then
                    bool = True
                End If
            Next
            'Si un information est diffént, on envoye les nouvelles données au serveur
            If bool Then
                If ConnectionServeur.Getinstance.AddDelete(listeAdd, "updateCouleur") Then
                    For c As Integer = 0 To tableCouleur.Columns.Count - 1
                        listeOr(r, c) = listeAdd(c)
                    Next

                    'Faire un loop pour trouver la ligne qui a le même id dans la table CoulVe du mainform à la listeadd à l'index 0
                    'Après on loop pour les colonnes et mettre les nouvelles données dans la table CoulVe du mainform
                    'Une fois fait on appel la fonction RemplirDGV
                    For r2 As Integer = 0 To MainForm.tableCoulVe.Rows.Count - 1
                        If MainForm.tableCoulVe.Rows(r2).Item("id") = listeAdd(0) Then
                            For c As Integer = 1 To MainForm.tableCoulVe.Columns.Count - 2
                                MainForm.tableCoulVe(r2)(c) = listeAdd(c)
                            Next
                        End If
                    Next
                    RemplirDGV()
                    MessageBox.Show("Enregistrement réussit!")
                Else
                    MessageBox.Show("Une erreure c'est produit durant l'enregistrement")
                End If
            End If
        Next
        CheckerChange()
    End Sub

    'Crée un nouveau form de CreerCouleur et le faire apparaître et quand ce form est fermé appeler la fonction RmeplirDGV
    Private Sub BtCreer_Click(sender As Object, e As EventArgs) Handles BtCreer.Click
        Dim CreerCoul As New CreerCouleur
        CreerCoul.ShowDialog(Me)
        RemplirDGV()
    End Sub

    'Quand Commence a éditer une cell on check si cette cell est de la colonne 0 si oui on annule la frappe sur le clavier(Enpêcher d'écrire)
    Private Sub DGVCouleur_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvCouleur.CellBeginEdit
        If e.ColumnIndex = 0 Then
            e.Cancel = True
        End If
    End Sub

    'Quand on commence à éditer une cellule du DataGridView on regarde si l'index de la colonne est 3
    'Si oui, on crée un nouveau handler avec le keyPress qu'on vien de faire et qui appel la fonction TextBox_KeyPress
    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvCouleur.EditingControlShowing
        If dgvCouleur.CurrentCell.ColumnIndex = 3 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        End If
    End Sub

    'Quand cette fonction est appeler on regarde quelle colonne le DataGridView est sélectionné pour être sur qu'il soit bien à l'index 3
    'Après, on regarde pour voir si la touche qui a été pressé n'est pas un nombre, si c'est le cas, on supprieme le keypress
    Private Sub TextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If dgvCouleur.CurrentCell.ColumnIndex = 3 Then
            If Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    'Quand on click sur le bouton déléte on envoie l'information au serveur de changer la variable DeleteCoul a False pour le ID qu'on a envoyer
    'Après on change l'information dans la table CoulVe du mainform et on appel la fonction RemplirDGV et CheckerChange
    Private Sub BtDel_Click(sender As Object, e As EventArgs) Handles BtDel.Click
        If MessageBox.Show("Voulez-vous vraiment supprimer " + dgvCouleur.CurrentRow.Cells(1).Value + "?", "Attention!", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ConnectionServeur.Getinstance.GetInfo(dgvCouleur.CurrentRow.Cells(0).Value, "ChangeDelete")
            'loop pour trouver le même id dans la table CoulVe du Mainform et changer la valeur de DeleteCoul a 0
            For r As Integer = 0 To MainForm.tableCoulVe.Rows.Count - 1
                If MainForm.tableCoulVe.Rows(r).Item("id") = dgvCouleur.CurrentRow.Cells(0).Value Then
                    MainForm.tableCoulVe.Rows(r).Item("deleteCoul") = 0
                End If
            Next
            RemplirDGV()
            CheckerChange()
        End If
    End Sub

    'Quand on fini d'éditer une cellule dans le DataGridView, on appel la fonction CheckChange
    Private Sub DGVCouleur_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCouleur.CellEndEdit
        CheckerChange()
    End Sub

    'On met les boutons enregistrer et annuler a False pour leur attribu enabled comme ca on ne peut plus clicker dessus
    'Après, on fait deux loop pour passer toutes les lignes et les colonnes du DataGridView
    'Si la cellule de ligne et colonne sélectionné n'est pas pareille à la listeOriginal on met les deux boutons a True pour enabled
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

    'Si la personne click dans le UserControl, on s'assure que le menu dans le Mainform est fermer
    Private Sub UCCouleur_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub
End Class
