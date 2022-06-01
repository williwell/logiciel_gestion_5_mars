Public Class UCCouleurTissus
    ReadOnly main As MainForm
    ReadOnly tableCoul As New DataTable
    Dim listeOr(0, 0) As String

    Sub New(mainform As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = mainform
    End Sub

    Private Sub UCCouleurTissus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Créer les colonnes de la tableCOul, mettre comme datasource la table au DataGridView et appeler la fonction LoadCoul
        tableCoul.Columns.Add("ID")
        tableCoul.Columns.Add("Nom")
        tableCoul.Columns.Add("Code")
        dgvCouleur.DataSource = tableCoul
        LoadCoul()

        For c As Integer = 0 To dgvCouleur.Columns.Count - 1
            dgvCouleur.Columns(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    Private Sub BtCreer_Click(sender As Object, e As EventArgs) Handles BtCreer.Click
        'Créer un nouveau form de CreerCouleurTissus et le fait apparaitre
        Dim NewColor As New CreerCouleurTissus(Me)
        NewColor.ShowDialog(Me)
    End Sub

    Public Sub LoadCoul()
        'Clearer la table Coul de ses lignes
        tableCoul.Clear()

        'Loop pour prendre les informations de la tableCoultis du mainform qui ne sont pas mit comme delete et les mettre dans la tableCoul
        For r As Integer = 0 To MainForm.tableCoulTis.Rows.Count - 1
            If MainForm.tableCoulTis.Rows(r).Item("deletecoul") = True Then
                Dim row As DataRow = tableCoul.NewRow
                row(0) = MainForm.tableCoulTis.Rows(r).Item("id")
                row(1) = MainForm.tableCoulTis.Rows(r).Item("nom")
                row(2) = MainForm.tableCoulTis.Rows(r).Item("code")
                tableCoul.Rows.Add(row)
            End If
        Next

        'Remplir la listeOriginal avec les informations de la tableCoul
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

    'Si on click sur ce bouton, on remet toute l'information de la listeOriginal dans la tableCoul pour remettre les informations de base dedans
    'Après on appel la finction CheckerChange
    Private Sub BTAnnuler_Click(sender As Object, e As EventArgs) Handles BTAnnuler.Click
        For r As Integer = 0 To dgvCouleur.Rows.Count - 1
            For c As Integer = 0 To dgvCouleur.Columns.Count - 1
                tableCoul(r)(c) = listeOr(r, c)
            Next
        Next
        CheckerChange()
    End Sub

    'Si on click sur ce bouton, on check toutes les données de la tableCoul pour voir qu'elles sont différente de la listeOriginal
    'et on fait l'enregistrement sur le serveur avec les nouvelles donné
    Private Sub BTEnregistrer_Click(sender As Object, e As EventArgs) Handles BTEnregistrer.Click
        'Loop pour passé toutes les lignes de la tableCoul
        For r As Integer = 0 To tableCoul.Rows.Count - 1
            Dim bool As Boolean = False
            Dim listeAdd(tableCoul.Columns.Count - 1) As String
            'Loop pour passé toutes les colonnes de la tableCoul et les mettres dans la listeAdd
            For c As Integer = 0 To tableCoul.Columns.Count - 1
                listeAdd(c) = tableCoul(r)(c)
                'Si la valeur de ligne et la colonnes n'est pas égal à la listeOriginal de cette même position, on met le boolean à true
                If Not tableCoul(r)(c) = listeOr(r, c) Then
                    bool = True
                End If
            Next
            'Si le bool est à true sa veut dire qu'au moin une information de la colonnes dans la ligne qu'on est rendu
            'est différente de la listeOriginal
            If bool Then
                'On enregistre sur le serveur
                If ConnectionServeur.Getinstance.AddDelete(listeAdd, "updateCouleurTis") Then
                    'On loop pour mettre l'information que la listeOriginal a jour avec les nouvelles informations qu'on a enregristrer
                    For c As Integer = 0 To tableCoul.Columns.Count - 1
                        listeOr(r, c) = listeAdd(c)
                    Next
                    'loop pour trouver la ligne dans la tableCoulTis qui a le même id que celui mit dans la listeAdd
                    For r2 As Integer = 0 To MainForm.tableCoulTis.Rows.Count - 1
                        If MainForm.tableCoulTis.Rows(r).Item("id") = listeAdd(0) Then
                            'loop pour mettre les nouvelles informations dans la table CoulTis du Mainform 
                            For c As Integer = 1 To MainForm.tableCoulTis.Columns.Count - 2
                                MainForm.tableCoulTis(r2)(c) = listeAdd(c)
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

    'Si on commence à éditer une ligne dans le DataGridView et que l'index de la colonnes est 0 on annule pour ne pas pourvoir changer le id
    Private Sub DGVCouleur_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvCouleur.CellBeginEdit
        If e.ColumnIndex = 0 Then
            e.Cancel = True
        End If
    End Sub

    'Si on édite une cellule et que cette cellule est à l'index de colonne 3 on créer un nouveau handler avec le keypress
    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvCouleur.EditingControlShowing
        If dgvCouleur.CurrentCell.ColumnIndex = 3 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        End If
    End Sub

    'Si le keypress est fait et que l'index de la colonnes est 3 et que ce n'est pas un nombre qui est pressé, on met le handled à true pour
    'Annuler le keypress
    Private Sub TextBox_keyPress(sender As Object, e As KeyPressEventArgs)
        If dgvCouleur.CurrentCell.ColumnIndex = 3 Then
            If Not Char.IsDigit(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    'Si on click sur ce bouton, on envoie au serveur l'information de changer le paramètre deletecoul a 0
    'Après on fait appel à la fonction LoadCoul pour réchager les nouvelles couleurs dans le DataGridView
    Private Sub BtDel_Click(sender As Object, e As EventArgs) Handles BtDel.Click
        If MessageBox.Show(MsgTextFr.Getinstance.MsgConfirSupp + dgvCouleur.CurrentRow.Cells(1).Value + "?", MsgTextFr.Getinstance.MsgAttention, MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ConnectionServeur.Getinstance.GetInfo(dgvCouleur.CurrentRow.Cells(0).Value, "ChangeDeleteTis")
            'Loop pour trouver la ligne dans la table Coultis du mainform avec celle du DataGridView selectionner
            For r As Integer = 0 To MainForm.tableCoulTis.Rows.Count - 1
                If MainForm.tableCoulTis.Rows(r).Item("id") = dgvCouleur.CurrentRow.Cells(0).Value Then
                    MainForm.tableCoulTis.Rows(r).Item("deleteCoul") = 0
                End If
            Next
            LoadCoul()
        End If
    End Sub

    'Quand on fini d'éditer une cellule on appel la fonction CheckChange
    Private Sub DGVCouleur_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCouleur.CellEndEdit
        CheckerChange()
    End Sub

    'Fonction qui set à regarder si a des différences entre la listeOriginal et le DataGridView pour savoir si on doit activer les boutons ou non
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

    'Si on click dans le UserControl on check que le menu du mainform sois belle et bien fermer
    Private Sub UCCouleurTissus_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub
End Class
