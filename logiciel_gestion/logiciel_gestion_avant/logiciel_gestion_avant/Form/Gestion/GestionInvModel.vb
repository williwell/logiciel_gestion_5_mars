Imports System.ComponentModel

Public Class GestionInvModel
    Dim tableInvMo As DataTable
    Dim OrInvMo(0, 0) As String
    Dim tableInvAdd As DataTable
    Dim OrInvAdd(0, 0) As String
    ReadOnly tableAll As New DataTable
    Dim OrTableAll(0, 0) As String
    Dim listeInvMo() As String
    Dim listeInvAdd() As String
    Dim nbrInv As Integer
    ReadOnly id As String
    ReadOnly ucGestion As UCGestionModel

    Sub New(idModel As String, uc As UCGestionModel)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        id = idModel
        ucGestion = uc
    End Sub


    Private Sub GestionInvModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim liste() As String

        tableInvMo = ConnectionServeur.Getinstance.GetInfo(id, "getOnlyInv")
        ReDim OrInvMo(tableInvMo.Rows.Count - 1, tableInvMo.Columns.Count - 1)
        ucGestion.ListeOr(OrInvMo, tableInvMo)
        DGVInventaireMo.DataSource = tableInvMo
        listeInvMo = ucGestion.PopulateList(tableInvMo)
        nbrInv = listeInvMo.Length

        ReDim liste(DGVInventaireMo.Rows.Count - 1)
        For i As Integer = 0 To liste.Count - 1
            liste(i) = DGVInventaireMo.Rows(i).Cells(0).Value
        Next

        tableInvAdd = ConnectionServeur.Getinstance.GetInfo(liste, "getInvAdd")
        ReDim OrInvAdd(tableInvAdd.Rows.Count - 1, tableInvAdd.Columns.Count - 1)
        ucGestion.ListeOr(OrInvAdd, tableInvAdd)
        DGVInventaireAdd.DataSource = tableInvAdd
        listeInvAdd = ucGestion.PopulateList(tableInvAdd)

        For i As Integer = 0 To tableInvMo.Columns.Count - 1
            tableAll.Columns.Add(tableInvMo.Columns(i).ColumnName)
        Next

        If tableInvMo.Rows.Count > 0 Then
            For r As Integer = 0 To tableInvMo.Rows.Count - 1
                Dim row As DataRow = tableAll.NewRow
                For c As Integer = 0 To tableInvMo.Columns.Count - 1
                    row(c) = tableInvMo(r)(c)
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
        ucGestion.ListeOr(OrTableAll, tableAll)
    End Sub

    Private Sub DGVInventaireAdd_DoubleClick(sender As Object, e As EventArgs) Handles DGVInventaireAdd.DoubleClick
        PopulateRow(tableInvMo, DGVInventaireAdd, DGVInventaireMo)
    End Sub

    Private Sub DGVInventaireMo_DoubleClick(sender As Object, e As EventArgs) Handles DGVInventaireMo.DoubleClick
        PopulateRow(tableInvAdd, DGVInventaireMo, DGVInventaireAdd)
    End Sub



    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Dim listeAjout() As String = CreateListeAdd(listeInvMo, DGVInventaireMo, True)
        Dim bool1 As Boolean = True
        Dim bool2 As Boolean = True

        For i As Integer = 0 To DGVInventaireMo.Rows.Count - 1
            For int As Integer = 0 To OrInvMo.Length / DGVInventaireMo.Columns.Count - 1
                If DGVInventaireMo.Rows(i).Cells(0).Value = OrInvMo(int, 0) Then
                    For c As Integer = 0 To DGVInventaireMo.Columns.Count - 1
                        If Not DGVInventaireMo.Rows(i).Cells(c).Value = OrInvMo(int, c) Then
                            If ConnectionServeur.Getinstance.ModInv(DGVInventaireMo.Rows(i).Cells(0).Value, id, DGVInventaireMo.Rows(i).Cells(c).Value, "ModInvModel") Then
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
            If ConnectionServeur.Getinstance.AddDeleteListe(listeAjout, id, "AddInvMo") Then
                listeAjout = CreateListeAdd(listeInvAdd, DGVInventaireAdd, False)
                If Not IsNothing(listeAjout) Then
                    If ConnectionServeur.Getinstance.AddDelete(listeAjout, id, "DeleteInvMo") Then
                        bool1 = True
                        ReDim OrInvMo(tableInvMo.Rows.Count - 1, tableInvMo.Columns.Count - 1)
                        ucGestion.ListeOr(OrInvMo, tableInvMo)
                        ReDim OrInvAdd(tableInvAdd.Rows.Count - 1, tableInvAdd.Columns.Count - 1)
                        ucGestion.ListeOr(OrInvAdd, tableInvAdd)
                        ucGestion.CheckChange()
                    Else
                        bool1 = False
                    End If
                End If
            Else
                bool1 = False
            End If
        Else
            listeAjout = CreateListeAdd(listeInvAdd, DGVInventaireAdd, False)
            If Not IsNothing(listeAjout) Then
                If ConnectionServeur.Getinstance.AddDelete(listeAjout, id, "DeleteInvMo") Then
                    bool1 = True
                    ReDim OrInvMo(tableInvMo.Rows.Count - 1, tableInvMo.Columns.Count - 1)
                    ucGestion.ListeOr(OrInvMo, tableInvMo)
                    ReDim OrInvAdd(tableInvAdd.Rows.Count - 1, tableInvAdd.Columns.Count - 1)
                    ucGestion.ListeOr(OrInvAdd, tableInvAdd)
                    ucGestion.CheckChange()
                Else
                    bool1 = False
                End If
            End If
        End If

        If bool1 Then
            If bool2 Then
                MessageBox.Show("L'enregistrement c'est effectuer correctement")
                Me.Close()
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
                If bool Then
                    nbr += 1
                    ReDim Preserve listeAdd(nbr)
                    listeAdd(nbr) = dgv.Rows(i).Cells(dgv.Columns.Count - 1).Value
                End If
            End If
        Next
        Return listeAdd
    End Function

    Private Sub DGVOption_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DGVInventaireMo.EditingControlShowing
        If DGVInventaireMo.CurrentCell.ColumnIndex = 4 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        End If
    End Sub

    Private Sub TextBox_keyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Sub CheckChange()
        If ucGestion.CheckFor(listeInvMo, tableInvMo, nbrInv) Then
            btSave.Enabled = True
        Else
            btSave.Enabled = False
        End If
    End Sub

    Private Sub DGVInventaireMo_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DGVInventaireMo.CellBeginEdit
        If Not e.ColumnIndex = 4 Then
            e.Cancel = True
        End If
    End Sub

    Public Sub PopulateRow(table As DataTable, dgvGiver As DataGridView, dgvRecever As DataGridView)
        Dim row As DataRow = table.NewRow
        Dim nbr As Integer = 0

        If dgvGiver.Columns.Count = 5 Then
            nbr = 2
        End If

        For i As Integer = 0 To tableAll.Rows.Count - 1
            If tableAll(i)(0) = dgvGiver.CurrentRow.Cells(0).Value Then
                If nbr = 2 Then
                    tableAll(i)(4) = dgvGiver.CurrentRow.Cells(4).Value
                End If
                For int As Integer = 0 To dgvGiver.Columns.Count - nbr
                    row(int) = tableAll(i)(int)
                Next
            End If
        Next


        table.Rows.Add(row)
        dgvRecever.Sort(dgvRecever.Columns(0), ListSortDirection.Ascending)
        dgvGiver.Rows.Remove(dgvGiver.CurrentRow)
        CheckChange()
    End Sub

    Private Sub BtAnnuler_Click(sender As Object, e As EventArgs) Handles btAnnuler.Click
        AnnulerChangement(OrInvMo, tableInvMo)
        AnnulerChangement(OrInvAdd, tableInvAdd)
        AnnulerChangement(OrTableAll, tableAll)
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
        CheckChange()
    End Sub

    Private Sub DGVInventaireMo_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVInventaireMo.CellEndEdit
        Dim bool As Boolean
        For i As Integer = 0 To tableInvMo.Rows.Count - 1
            bool = False
            For r As Integer = 0 To OrTableAll.Length / tableInvMo.Columns.Count - 1
                If OrTableAll(r, 0) = tableInvMo.Rows(i).Item(0) Then
                    For c As Integer = 0 To tableInvMo.Columns.Count - 1
                        If Not OrTableAll(r, c) = tableInvMo(i)(c) Then
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
    End Sub
End Class