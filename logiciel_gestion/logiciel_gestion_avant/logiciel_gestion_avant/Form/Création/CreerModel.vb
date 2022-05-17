Imports System.ComponentModel

Public Class CreerModel
    ReadOnly ucGestionModel As UCGestionModel
    ReadOnly tableOpAjout As New DataTable
    ReadOnly tableOpMo As New DataTable
    ReadOnly tableCoulAjout As New DataTable
    ReadOnly tableCoulMo As New DataTable
    ReadOnly tableInvAjout As New DataTable
    ReadOnly tableInvMo As New DataTable
    ReadOnly tableMid As New DataTable

    Sub New(uc As UCGestionModel)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        ucGestionModel = uc
    End Sub

    Private Sub CreerModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim liste(-1) As String

        tableOpAjout.Columns.Add("ID")
        tableOpAjout.Columns.Add("Nom")
        tableOpAjout.Columns.Add("Cout")
        For r As Integer = 0 To MainForm.tableOp.Rows.Count - 1
            If MainForm.tableOp.Rows(r).Item("id") <> 0 And MainForm.tableOp.Rows(r).Item("deleteopt") <> False Then
                Dim row As DataRow = tableOpAjout.NewRow
                row(0) = MainForm.tableOp.Rows(r).Item("id")
                row(1) = MainForm.tableOp.Rows(r).Item("Nom")
                row(2) = MainForm.tableOp.Rows(r).Item("Cout")
                tableOpAjout.Rows.Add(row)
            End If
        Next

        dgvOptionAjout.DataSource = tableOpAjout
        RemplirColDGV(dgvOptionAjout, dgvOptionMo, tableOpMo)

        tableCoulAjout.Columns.Add("ID")
        tableCoulAjout.Columns.Add("Nom")
        tableCoulAjout.Columns.Add("Code")
        tableCoulAjout.Columns.Add("Cout")
        For r As Integer = 0 To MainForm.tableCoulVe.Rows.Count - 1
            If MainForm.tableCoulVe.Rows(r).Item("id") <> 0 And MainForm.tableCoulVe.Rows(r).Item("deletecoul") <> False Then
                Dim row As DataRow = tableCoulAjout.NewRow
                row(0) = MainForm.tableCoulVe.Rows(r).Item("id")
                row(1) = MainForm.tableCoulVe.Rows(r).Item("Nom")
                row(2) = MainForm.tableCoulVe.Rows(r).Item("Code")
                row(3) = MainForm.tableCoulVe.Rows(r).Item("Cout")
                tableCoulAjout.Rows.Add(row)
            End If
        Next

        dgvCoulAjout.DataSource = tableCoulAjout
        RemplirColDGV(dgvCoulAjout, dgvCoulMo, tableCoulMo)

        tableInvAjout.Columns.Add("ID")
        tableInvAjout.Columns.Add("Nom")
        tableInvAjout.Columns.Add("Description")
        tableInvAjout.Columns.Add("Utilisé")
        For r As Integer = 0 To MainForm.tableInv.Rows.Count - 1
            Dim row As DataRow = tableInvAjout.NewRow
            row(0) = MainForm.tableInv.Rows(r).Item("id")
            row(1) = MainForm.tableInv.Rows(r).Item("nom")
            row(2) = MainForm.tableInv.Rows(r).Item("description")
            row(3) = MainForm.tableInv.Rows(r).Item("utilise")
            tableInvAjout.Rows.Add(row)
        Next

        DGVInventaireAdd.DataSource = tableInvAjout
        RemplirColDGVInv(DGVInventaireAdd, DGVInventaireMo, tableInvMo)

        For i As Integer = 0 To DGVInventaireAdd.Columns.Count
            If i = DGVInventaireAdd.Columns.Count Then
                tableMid.Columns.Add("nombreItem")
            Else
                tableMid.Columns.Add(DGVInventaireAdd.Columns(i).Name)
            End If
        Next

        For r As Integer = 0 To DGVInventaireAdd.Rows.Count - 1
            Dim row As DataRow = tableMid.NewRow
            For c As Integer = 0 To DGVInventaireAdd.Columns.Count
                If c = DGVInventaireAdd.Columns.Count Then
                    row(c) = ""
                Else
                    row(c) = DGVInventaireAdd.Rows(r).Cells(c).Value
                End If
            Next
            tableMid.Rows.Add(row)
        Next

        SetColumn(dgvCoulAjout)
        SetColumn(dgvCoulMo)
        SetColumn(dgvOptionAjout)
        SetColumn(dgvOptionMo)
        SetColumn(DGVInventaireAdd)
        SetColumn(DGVInventaireMo)
    End Sub

    Private Sub SetColumn(dgv As DataGridView)
        For c As Integer = 0 To dgv.Columns.Count - 1
            dgv.Columns(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    Private Sub RemplirColDGV(dgv As DataGridView, dgv2 As DataGridView, table As DataTable)
        For i As Integer = 0 To dgv.Columns.Count - 1
            table.Columns.Add(dgv.Columns(i).Name, GetType(String))
        Next
        dgv2.DataSource = table
    End Sub

    Private Sub RemplirColDGVInv(dgv As DataGridView, dgv2 As DataGridView, table As DataTable)
        For i As Integer = 0 To dgv.Columns.Count - 1
            table.Columns.Add(dgv.Columns(i).Name, GetType(String))
        Next
        table.Columns.Add("NombreItem")
        dgv2.DataSource = table
    End Sub

    Private Sub DgvOptionAjout_DoubleClick(sender As Object, e As EventArgs) Handles dgvOptionAjout.DoubleClick
        PopulateRow(tableOpMo, dgvOptionAjout, dgvOptionMo)
    End Sub

    Private Sub DgvOptionMo_DoubleClick(sender As Object, e As EventArgs) Handles dgvOptionMo.DoubleClick
        PopulateRow(tableOpAjout, dgvOptionMo, dgvOptionAjout)
    End Sub

    Private Sub DgvCoulAjout_DoubleClick(sender As Object, e As EventArgs) Handles dgvCoulAjout.DoubleClick
        PopulateRow(tableCoulMo, dgvCoulAjout, dgvCoulMo)
    End Sub

    Private Sub DgvCoulMo_DoubleClick(sender As Object, e As EventArgs) Handles dgvCoulMo.DoubleClick
        PopulateRow(tableCoulAjout, dgvCoulMo, dgvCoulAjout)
    End Sub

    Private Sub DGVInventaireAdd_DoubleClick(sender As Object, e As EventArgs) Handles DGVInventaireAdd.DoubleClick
        PopulateRowInv(tableInvMo, DGVInventaireAdd, DGVInventaireMo)
    End Sub

    Private Sub DGVInventaireMo_DoubleClick(sender As Object, e As EventArgs) Handles DGVInventaireMo.DoubleClick
        PopulateRowInv(tableInvAjout, DGVInventaireMo, DGVInventaireAdd)
    End Sub

    Private Sub PopulateRow(table As DataTable, dgvGiver As DataGridView, dgvRecever As DataGridView)
        Dim row As DataRow = table.NewRow
        For i As Integer = 0 To dgvGiver.Columns.Count - 1
            row(i) = dgvGiver.CurrentRow.Cells(i).Value
        Next
        table.Rows.Add(row)
        dgvRecever.Sort(dgvRecever.Columns(0), ListSortDirection.Ascending)
        dgvGiver.Rows.Remove(dgvGiver.CurrentRow)
    End Sub

    Private Sub PopulateRowInv(table As DataTable, dgvGiver As DataGridView, dgvRecever As DataGridView)
        Dim row As DataRow = table.NewRow
        Dim nbr As Integer = 0

        For i As Integer = 0 To tableMid.Rows.Count - 1
            If dgvGiver.CurrentRow.Cells(0).Value = tableMid(i)(0) Then
                If dgvGiver.Columns.Count > dgvRecever.Columns.Count Then
                    nbr = 2
                End If
                For c As Integer = 0 To dgvGiver.Columns.Count - nbr
                    row(c) = tableMid(i)(c)
                Next
            End If
        Next

        table.Rows.Add(row)
        dgvRecever.Sort(dgvRecever.Columns(0), ListSortDirection.Ascending)
        dgvGiver.Rows.Remove(dgvGiver.CurrentRow)
    End Sub

    Private Sub BtAnnuler_Click(sender As Object, e As EventArgs) Handles BtAnnuler.Click
        Me.Close()
    End Sub

    Private Sub BtEnregistrer_Click(sender As Object, e As EventArgs) Handles BtEnregistrer.Click
        Dim id As String
        If Not String.IsNullOrEmpty(TbName.Text) Then
            id = ConnectionServeur.Getinstance.AddModel(TbName.Text, nudCout.Value.ToString)
            If Not id = 0 Then

                Dim row As DataRow = MainForm.tableModel.NewRow
                row(0) = id
                row(1) = TbName.Text
                row(2) = nudCout.Value.ToString
                MainForm.tableModel.Rows.Add(row)

                If dgvOptionMo.Rows.Count > 0 Then
                    ConnectionServeur.Getinstance.AddDelete(CreateListe(dgvOptionMo), id, "AddOpMo")

                    For r As Integer = 0 To dgvOptionMo.Rows.Count - 1
                        Dim row2 As DataRow = MainForm.tableOpMo.NewRow
                        row2(0) = dgvOptionMo.Rows(r).Cells(0).Value
                        row2(1) = id
                        MainForm.tableOpMo.Rows.Add(row2)
                    Next

                End If
                If dgvCoulMo.Rows.Count > 0 Then
                    ConnectionServeur.Getinstance.AddDelete(CreateListe(dgvCoulMo), id, "AddCoulMo")

                    For r As Integer = 0 To dgvCoulMo.Rows.Count - 1
                        Dim row2 As DataRow = MainForm.tableCoulMo.NewRow
                        row2(0) = dgvCoulMo.Rows(r).Cells(0).Value
                        row2(1) = id
                        MainForm.tableCoulMo.Rows.Add(row2)
                    Next

                End If
                If DGVInventaireMo.Rows.Count > 0 Then
                    ConnectionServeur.Getinstance.AddDeleteListe(CreateListeInv(DGVInventaireMo), id, "AddInvMo")

                    For r As Integer = 0 To DGVInventaireMo.Rows.Count - 1
                        Dim row2 As DataRow = MainForm.tableInvMo.NewRow
                        row2(0) = DGVInventaireMo.Rows(r).Cells(0).Value
                        row2(1) = id
                        If String.IsNullOrEmpty(DGVInventaireMo.Rows(r).Cells(4).Value) Then
                            row2(2) = 0
                        Else
                            row2(2) = DGVInventaireMo.Rows(r).Cells(4).Value
                        End If
                        MainForm.tableInvMo.Rows.Add(row2)
                    Next

                End If
                ucGestionModel.RemplirModel()
                MessageBox.Show("Création du nouveau model réussit")
                Me.Close()
            Else
                MessageBox.Show("Une erreure est survenu durant la création du nouveau model!")
            End If
        Else
            MessageBox.Show("Le champ nom ne peut pas être vide!")
        End If
    End Sub

    Private Function CreateListe(dgv As DataGridView) As String()
        Dim liste() As String = Nothing
        Dim nbr As Integer = 0
        For i As Integer = 0 To dgv.Rows.Count - 1
            ReDim Preserve liste(nbr)
            liste(nbr) = dgv.Rows(i).Cells(0).Value
            nbr += 1
        Next
        Return liste
    End Function

    Private Function CreateListeInv(dgv As DataGridView) As String()
        Dim liste() As String = Nothing
        Dim nbr As Integer = -1
        For i As Integer = 0 To dgv.Rows.Count - 1
            nbr += 1
            ReDim Preserve liste(nbr)
            liste(nbr) = dgv.Rows(i).Cells(0).Value
            nbr += 1
            ReDim Preserve liste(nbr)
            If String.IsNullOrEmpty(dgv.Rows(i).Cells(dgv.Columns.Count - 1).Value) Then
                liste(nbr) = 0
            Else
                liste(nbr) = dgv.Rows(i).Cells(dgv.Columns.Count - 1).Value
            End If
        Next
        Return liste
    End Function

    Private Sub DGVInventaireMo_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DGVInventaireMo.CellBeginEdit
        If Not e.ColumnIndex = 4 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub NUDCout_KeyDown(sender As Object, e As KeyEventArgs) Handles nudCout.KeyDown
        If e.KeyCode = 110 Or e.KeyCode = 190 Then
            e.SuppressKeyPress = True
            SendKeys.Send(",")
        End If
    End Sub
    Private Sub DGVInventaireMo_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DGVInventaireMo.EditingControlShowing
        If DGVInventaireMo.CurrentCell.ColumnIndex = 4 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        End If
    End Sub

    Private Sub TextBox_keyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class