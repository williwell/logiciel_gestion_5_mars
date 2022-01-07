Public Class UCOption
    ReadOnly main As MainForm
    Dim listeOr(0, 0) As String

    Sub New(mainform As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = mainform
    End Sub

    Private Sub UCOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemplireDGV()
    End Sub

    'Fonction qui sert à remplir le DataGridView
    Public Sub RemplireDGV()
        Dim table As New DataTable
        table.Columns.Add("ID")
        table.Columns.Add("Nom")
        table.Columns.Add("Coût")

        For r As Integer = 0 To MainForm.tableOp.Rows.Count - 1
            If MainForm.tableOp.Rows(r).Item("deleteopt") = "True" Then
                Dim row As DataRow = table.NewRow
                row(0) = MainForm.tableOp.Rows(r).Item("id")
                row(1) = MainForm.tableOp.Rows(r).Item("nom")
                row(2) = MainForm.tableOp.Rows(r).Item("cout")
                table.Rows.Add(row)
            End If
        Next

        DGVOption.DataSource = table

        'On Remplie la liste originale
        ReDim listeOr(DGVOption.Rows.Count - 1, DGVOption.Columns.Count - 1)
        For r As Integer = 0 To DGVOption.Rows.Count - 1
            For c As Integer = 0 To DGVOption.Columns.Count - 1
                listeOr(r, c) = DGVOption.Rows(r).Cells(c).Value
            Next
        Next
    End Sub

    'Fonction qui sert à regarder si a des changement entre le datagridview et la liste originale pour savoir si on doit mettre les bouton save et annuler
    ' fonctionner ou non
    Private Sub CheckChange()
        BtSave.Enabled = False
        BTAnnuler.Enabled = False

        For r As Integer = 0 To DGVOption.Rows.Count - 1
            For c As Integer = 0 To DGVOption.Columns.Count - 1
                If Not DGVOption.Rows(r).Cells(c).Value = listeOr(r, c) Then
                    BtSave.Enabled = True
                    BTAnnuler.Enabled = True
                End If
            Next
        Next
    End Sub

    'Quand on fini d'éditer une cellule du datagridVIew on appel la finction CheckChange
    Private Sub DGVOption_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVOption.CellEndEdit
        CheckChange()
    End Sub

    'Quand on commence à éditer une cellule du datagridView on regarde quel index de colonne à été sélectionner et si c'est l'index 0
    'on cancelle l'éditage
    Private Sub DGVOption_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DGVOption.CellBeginEdit
        If e.ColumnIndex = 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub DGVOption_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DGVOption.EditingControlShowing
        If DGVOption.CurrentCell.ColumnIndex = 2 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        End If
    End Sub

    'Cette fonction sert a s'assuré que sa soit bien un nombre qui soit bien entré dans le datagridview
    Private Sub TextBox_keyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Quand on click sur ce bouton, on loop toute le datagridView pour remettre toute l'information de la listeOriginale dans le datagridView
    Private Sub BTAnnuler_Click(sender As Object, e As EventArgs) Handles BTAnnuler.Click
        For r As Integer = 0 To DGVOption.Rows.Count - 1
            For c As Integer = 0 To DGVOption.Columns.Count - 1
                DGVOption.Rows(r).Cells(c).Value = listeOr(r, c)
            Next
        Next
    End Sub

    'Quand on click sur ce bouton, on sauvegarde les modification fait dans le datagridview sur serveur
    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        'Loop pour passer toute les lignes dans le datagridview
        For r As Integer = 0 To DGVOption.Rows.Count - 1
            Dim bool As Boolean = False
            Dim listeAdd(DGVOption.Columns.Count - 1) As String
            For c As Integer = 0 To DGVOption.Columns.Count - 1
                listeAdd(c) = DGVOption.Rows(r).Cells(c).Value
                If Not DGVOption.Rows(r).Cells(c).Value = listeOr(r, c) Then
                    bool = True
                End If
            Next
            If bool Then
                If ConnectionServeur.Getinstance.AddDelete(listeAdd, "updateOption") Then

                    'Loop pour trouver la ligne correspondante dans la table du mainform pour la modifier
                    For i As Integer = 0 To MainForm.tableOp.Rows.Count - 1
                        If MainForm.tableOp.Rows(i).Item("id") = listeAdd(0) Then
                            For i2 As Integer = 0 To listeAdd.Length - 1
                                MainForm.tableOp(i)(i2) = listeAdd(i2)
                            Next
                        End If
                    Next

                    'Loop pour mettre les nouvelles information dans la liste ORiginale
                    For c As Integer = 0 To DGVOption.Columns.Count - 1
                        listeOr(r, c) = listeAdd(c)
                    Next
                    MessageBox.Show("Enregistrement réussit!")
                Else
                    MessageBox.Show("Une erreure est survenue durant l'enregistrement!")
                End If
            End If
        Next
        CheckChange()
    End Sub

    'Quand on click sur ce bouton, on envoie sur le serveur l'information qu'on doit changé le paramètre DeleteOpt pour qu'il soit considé comme
    'Supprimer
    Private Sub BTDelete_Click(sender As Object, e As EventArgs) Handles BTDelete.Click
        If MessageBox.Show("Voulez-vous vraiment supprimer " + DGVOption.CurrentRow.Cells(1).Value + "?", "Attention!", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ConnectionServeur.Getinstance.GetInfo(DGVOption.CurrentRow.Cells(0).Value, "ChangeDeleteOp")

            'Loop pour trouver la même ligne dans la table du mainform et modifier la valeur de deleteOpt
            For r As Integer = 0 To MainForm.tableOp.Rows.Count - 1
                If MainForm.tableOp.Rows(r).Item("id") = DGVOption.CurrentRow.Cells(0).Value Then
                    MainForm.tableOp.Rows(r).Item("deleteOpt") = 0
                End If
            Next

            RemplireDGV()
        End If
    End Sub

    'Quand on click sur le bouton, on créer un nouveau form de type CreerOption et on l'affiche
    Private Sub BTCreer_Click(sender As Object, e As EventArgs) Handles BTCreer.Click
        Dim OptionForm As New CreerOption
        OptionForm.ShowDialog(Me)
        RemplireDGV()
    End Sub

    'Quand on click sur ce bouton ou qu'on double click sur une ligne du datagridview, on créer un nouveau form de type GEstionInvOpt avec
    'le id de l'option qui est sélectionner dans le datagridview
    Private Sub BTItem_Click(sender As Object, e As EventArgs) Handles BTItem.Click, DGVOption.DoubleClick
        Dim form As New GestionInvOpt(DGVOption.CurrentRow.Cells(0).Value)
        form.ShowDialog(Me)
        RemplireDGV()
    End Sub

    'Quand on click dans le userControl, on check que le menu du mainform soit bien fermer
    Private Sub UCOption_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub
End Class
