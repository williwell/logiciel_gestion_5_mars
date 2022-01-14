Imports System.ComponentModel

Public Class GestionInvOpt
    ReadOnly tableInvOpt As New DataTable
    Dim OrInvOpt(0, 0) As String
    ReadOnly tableInvAdd As New DataTable
    Dim OrInvAdd(0, 0) As String
    ReadOnly tableAll As New DataTable
    Dim OrTableAll(0, 0) As String
    Dim listeInvOpt() As String
    Dim listeInvAdd() As String
    Dim nbrInv As Integer
    ReadOnly id As String

    Sub New(idOpt As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        id = idOpt
    End Sub


    Private Sub GestionInvModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim liste() As String

        tableInvOpt.Columns.Add("ID")
        tableInvOpt.Columns.Add("Nom")
        tableInvOpt.Columns.Add("Description")
        tableInvOpt.Columns.Add("Utilisé")
        tableInvOpt.Columns.Add("Quantité")

        For r As Integer = 0 To MainForm.tableInv.Rows.Count - 1
            For r2 As Integer = 0 To MainForm.tableOpInv.Rows.Count - 1
                If MainForm.tableInv.Rows(r).Item("id") = MainForm.tableOpInv.Rows(r2).Item("idpiece") Then
                    If MainForm.tableOpInv.Rows(r2).Item("idoption") = id Then
                        Dim row As DataRow = tableInvOpt.NewRow
                        row(0) = MainForm.tableInv.Rows(r).Item("id")
                        row(1) = MainForm.tableInv.Rows(r).Item("nom")
                        row(2) = MainForm.tableInv.Rows(r).Item("description")
                        row(3) = MainForm.tableInv.Rows(r).Item("utilise")
                        row(4) = MainForm.tableOpInv.Rows(r2).Item("quantite")
                        tableInvOpt.Rows.Add(row)
                    End If
                End If
            Next
        Next

        ReDim OrInvOpt(tableInvOpt.Rows.Count - 1, tableInvOpt.Columns.Count - 1)
        ListGest.ListeOr(OrInvOpt, tableInvOpt)
        DGVInventaireOpt.DataSource = tableInvOpt
        listeInvOpt = ListGest.PopulateList(tableInvOpt)
        nbrInv = listeInvOpt.Length

        ReDim liste(DGVInventaireOpt.Rows.Count - 1)
        For i As Integer = 0 To liste.Count - 1
            liste(i) = DGVInventaireOpt.Rows(i).Cells(0).Value
        Next

        tableInvAdd.Columns.Add("ID")
        tableInvAdd.Columns.Add("Nom")
        tableInvAdd.Columns.Add("Description")
        tableInvAdd.Columns.Add("Utilisé")

        For r As Integer = 0 To MainForm.tableInv.Rows.Count - 1
            Dim bool As Boolean = True
            For i As Integer = 0 To liste.Length - 1
                If MainForm.tableInv.Rows(r).Item("id") = liste(i) Then
                    bool = False
                End If
            Next
            If bool Then
                Dim row As DataRow = tableInvAdd.NewRow
                row(0) = MainForm.tableInv.Rows(r).Item("id")
                row(1) = MainForm.tableInv.Rows(r).Item("nom")
                row(2) = MainForm.tableInv.Rows(r).Item("description")
                row(3) = MainForm.tableInv.Rows(r).Item("utilise")
                tableInvAdd.Rows.Add(row)
            End If
        Next

        ReDim OrInvAdd(tableInvAdd.Rows.Count - 1, tableInvAdd.Columns.Count - 1)
        ListGest.ListeOr(OrInvAdd, tableInvAdd)
        DGVInventaireAdd.DataSource = tableInvAdd
        listeInvAdd = ListGest.PopulateList(tableInvAdd)

        For i As Integer = 0 To tableInvOpt.Columns.Count - 1
            tableAll.Columns.Add(tableInvOpt.Columns(i).ColumnName)
        Next

        If tableInvOpt.Rows.Count > 0 Then
            For r As Integer = 0 To tableInvOpt.Rows.Count - 1
                Dim row As DataRow = tableAll.NewRow
                For c As Integer = 0 To tableInvOpt.Columns.Count - 1
                    row(c) = tableInvOpt(r)(c)
                Next
                tableAll.Rows.Add(row)
            Next
        End If
        If tableInvAdd.Rows.Count > 0 Then
            For r As Integer = 0 To tableInvAdd.Rows.Count - 1
                Dim row As DataRow = tableAll.NewRow
                For c As Integer = 0 To tableInvAdd.Columns.Count
                    If Not c = 4 Then
                        row(c) = tableInvAdd(r)(c)
                    Else
                        row(c) = ""
                    End If
                Next
                tableAll.Rows.Add(row)
            Next
        End If
        ReDim OrTableAll(tableAll.Rows.Count - 1, tableAll.Columns.Count - 1)
        ListGest.ListeOr(OrTableAll, tableAll)

        For c As Integer = 0 To DGVInventaireAdd.Columns.Count - 1
            DGVInventaireAdd.Columns(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next

        For c As Integer = 0 To DGVInventaireOpt.Columns.Count - 1
            DGVInventaireOpt.Columns(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    Private Sub DGVInventaireAdd_DoubleClick(sender As Object, e As EventArgs) Handles DGVInventaireAdd.DoubleClick
        ListGest.PopulateRow(tableInvOpt, DGVInventaireAdd, DGVInventaireOpt, tableAll)
        ListGest.changeBt(ListGest.CheckChange(OrInvOpt, tableInvOpt, nbrInv), btSave, btAnnuler)
    End Sub

    Private Sub DGVInventaireOpt_DoubleClick(sender As Object, e As EventArgs) Handles DGVInventaireOpt.DoubleClick
        ListGest.PopulateRow(tableInvAdd, DGVInventaireOpt, DGVInventaireAdd, tableAll)
        ListGest.changeBt(ListGest.CheckChange(OrInvOpt, tableInvOpt, nbrInv), btSave, btAnnuler)
    End Sub

    Private Sub DGVOption_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DGVInventaireOpt.EditingControlShowing
        If DGVInventaireOpt.CurrentCell.ColumnIndex = 4 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        End If
    End Sub

    Private Sub TextBox_keyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Sauvegarder()
    End Sub

    Private Sub Sauvegarder()
        Dim listeAjout() As String = CreateListeAdd(listeInvOpt, DGVInventaireOpt, True)
        Dim bool1 As Boolean = True
        Dim bool2 As Boolean = True

        For i As Integer = 0 To DGVInventaireOpt.Rows.Count - 1
            For int As Integer = 0 To OrInvOpt.Length / DGVInventaireOpt.Columns.Count - 1
                If DGVInventaireOpt.Rows(i).Cells(0).Value = OrInvOpt(int, 0) Then
                    For c As Integer = 0 To DGVInventaireOpt.Columns.Count - 1
                        If Not DGVInventaireOpt.Rows(i).Cells(c).Value = OrInvOpt(int, c) Then
                            If ConnectionServeur.Getinstance.ModInv(DGVInventaireOpt.Rows(i).Cells(0).Value, id, DGVInventaireOpt.Rows(i).Cells(c).Value, "ModInvOpt") Then

                                'Modifie la Quantité dans la table du mainform
                                For r As Integer = 0 To MainForm.tableOpInv.Rows.Count - 1
                                    If MainForm.tableOpInv.Rows(r).Item("idpiece") = DGVInventaireOpt.Rows(i).Cells(0).Value And MainForm.tableOpInv.Rows(r).Item("idoption") = id Then
                                        MainForm.tableOpInv.Rows(r).Item("quantite") = DGVInventaireOpt.Rows(i).Cells(c).Value
                                    End If
                                Next

                                bool2 = True
                            Else
                                bool2 = False
                            End If
                        End If
                    Next
                End If
            Next
        Next

        If Not IsNothing(listeAjout) Then
            If ConnectionServeur.Getinstance.AddDelete(listeAjout, "AddOptionItem") Then

                'Ajoute les ligne dans la table du mainform
                For i As Integer = 0 To listeAjout.Length - 1
                    Dim row As DataRow = MainForm.tableOpInv.NewRow
                    row(0) = listeAjout(i)
                    i += 1
                    row(1) = listeAjout(i)
                    i += 1
                    row(2) = listeAjout(i)
                    MainForm.tableOpInv.Rows.Add(row)
                Next

                deleteRow(bool1)
            Else
                bool1 = False
            End If
        Else
            deleteRow(bool1)
        End If

        If bool1 Then
            If bool2 Then
                MessageBox.Show("L'enregistrement c'est effectuer correctement")
            Else
                MessageBox.Show("Le changement des items pour le model c'est effectué correctement, mais une erreure c'est produit durant le changement des quantité des items")
            End If
        Else
            If bool2 Then
                MessageBox.Show("Le changement des quantités des items c'est effectué correctement, mais une erreure c'est produit durant l'enregistrement des produits.")
            Else
                MessageBox.Show("Un erreure est c'est produit durant l'enregistrement des changement!")
            End If
        End If
    End Sub

    Private Sub DeleteRow(ByRef bool1 As Boolean)
        Dim listeAjout() As String = CreateListeAdd(listeInvAdd, DGVInventaireAdd, False)
        If Not IsNothing(listeAjout) Then
            If ConnectionServeur.Getinstance.AddDelete(listeAjout, id, "DeleteInvOpt") Then

                'Supprimer les lignes dans la table du mainform
                For i As Integer = 0 To listeAjout.Length - 1
                    Dim row As DataRow = Nothing
                    For r As Integer = 0 To MainForm.tableOpInv.Rows.Count - 1
                        If MainForm.tableOpInv.Rows(r).Item("idoption") = listeAjout(i) And MainForm.tableOpInv.Rows(r).Item("idoption") = id Then
                            row = MainForm.tableOpInv.Rows(r)
                        End If
                    Next
                    If Not IsNothing(row) Then
                        MainForm.tableOpInv.Rows.Remove(row)
                    End If
                Next

                bool1 = True
                ReDim OrInvOpt(tableInvOpt.Rows.Count - 1, tableInvOpt.Columns.Count - 1)
                ListGest.ListeOr(OrInvOpt, tableInvOpt)
                ReDim OrInvAdd(tableInvAdd.Rows.Count - 1, tableInvAdd.Columns.Count - 1)
                ListGest.ListeOr(OrInvAdd, tableInvAdd)
                ListGest.ChangeBt(ListGest.CheckChange(OrInvOpt, tableInvOpt, nbrInv), btSave, btAnnuler)
            Else
                bool1 = False
            End If
        End If
    End Sub

    Public Function CreateListeAdd(liste() As String, dgv As DataGridView, bool As Boolean) As String()
        Dim listeAdd() As String = Nothing
        Dim nbr As Integer = -1
        For i As Integer = 0 To dgv.Rows.Count - 1
            Dim bool1 As Boolean = True
            For int As Integer = 0 To liste.Length - 1
                If liste(int) = dgv.Rows(i).Cells(0).Value Then
                    bool1 = False
                End If
            Next
            If bool1 Then
                nbr += 1
                ReDim Preserve listeAdd(nbr)
                listeAdd(nbr) = dgv.Rows(i).Cells(0).Value
                nbr += 1
                ReDim Preserve listeAdd(nbr)
                listeAdd(nbr) = id
                If bool Then
                    nbr += 1
                    ReDim Preserve listeAdd(nbr)
                    If String.IsNullOrEmpty(dgv.Rows(i).Cells(dgv.Columns.Count - 1).Value) Then
                        listeAdd(nbr) = 0
                    Else
                        listeAdd(nbr) = dgv.Rows(i).Cells(dgv.Columns.Count - 1).Value
                    End If
                End If
            End If
        Next
        Return listeAdd
    End Function

    Private Sub DGVInventaireMo_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DGVInventaireOpt.CellBeginEdit
        If Not e.ColumnIndex = 4 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub BtAnnuler_Click(sender As Object, e As EventArgs) Handles btAnnuler.Click
        AnnulerChangement(OrInvOpt, tableInvOpt)
        AnnulerChangement(OrInvAdd, tableInvAdd)
        AnnulerChangement(OrTableAll, tableAll)
        ListGest.changeBt(ListGest.CheckChange(OrInvOpt, tableInvOpt, nbrInv), btSave, btAnnuler)
    End Sub

    Private Sub AnnulerChangement(liste(,) As String, table As DataTable)
        Dim i As Integer = liste.Length / table.Columns.Count
        For int As Integer = table.Rows.Count - 1 To 0 Step -1
            table.Rows.RemoveAt(int)
        Next

        For r As Integer = 0 To i - 1
            Dim row As DataRow = table.NewRow
            For c As Integer = 0 To table.Columns.Count - 1
                row(c) = liste(r, c)
            Next
            table.Rows.Add(row)
        Next
    End Sub

    Private Sub DGVInventaireOpt_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVInventaireOpt.CellEndEdit
        Dim bool As Boolean
        For i As Integer = 0 To tableInvOpt.Rows.Count - 1
            bool = False
            For r As Integer = 0 To OrTableAll.Length / tableInvOpt.Columns.Count - 1
                If OrTableAll(r, 0) = tableInvOpt.Rows(i).Item(0) Then
                    For c As Integer = 0 To tableInvOpt.Columns.Count - 1
                        If Not OrTableAll(r, c) = tableInvOpt(i)(c) Then
                            bool = True
                        End If
                    Next
                End If
            Next
            If bool Then
                btSave.Enabled = True
            Else
                btSave.Enabled = False
            End If
        Next
        ListGest.changeBt(ListGest.CheckChange(OrInvOpt, tableInvOpt, nbrInv), btSave, btAnnuler)
    End Sub

    Private Sub GestionInvOpt_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If btSave.Enabled = True Then
            Dim result As DialogResult = MessageBox.Show("Voulez-vous sauvegarder les modifications que vous avez apporté?", "Attention", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                Sauvegarder()
            ElseIf result = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub
End Class