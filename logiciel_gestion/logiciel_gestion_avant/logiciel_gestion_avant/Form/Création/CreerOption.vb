Public Class CreerOption
    Dim tableAdd As New DataTable
    ReadOnly tableOp As New DataTable
    ReadOnly tableMid As New DataTable
    Private Sub CreerOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tableAdd.Columns.Add("id")
        tableAdd.Columns.Add("Nom")
        tableAdd.Columns.Add("Description")
        tableAdd.Columns.Add("Utilisé")

        For i As Integer = 0 To MainForm.tableInv.Rows.Count - 1
            Dim row As DataRow = tableAdd.NewRow
            row(0) = MainForm.tableInv.Rows(i).Item("id")
            row(1) = MainForm.tableInv.Rows(i).Item("nom")
            row(2) = MainForm.tableInv.Rows(i).Item("description")
            row(3) = MainForm.tableInv.Rows(i).Item("utilise")
            tableAdd.Rows.Add(row)
        Next

        DGVItemAdd.DataSource = tableAdd
        For i As Integer = 0 To DGVItemAdd.Columns.Count
            If i <> DGVItemAdd.Columns.Count Then
                tableOp.Columns.Add(DGVItemAdd.Columns(i).Name)
                tableMid.Columns.Add(DGVItemAdd.Columns(i).Name)
            Else
                tableOp.Columns.Add("nbrItem")
                tableMid.Columns.Add("nbrItem")
            End If
        Next

        For i As Integer = 0 To DGVItemAdd.Rows.Count - 1
            Dim r As DataRow = tableMid.NewRow
            For c As Integer = 0 To DGVItemAdd.Columns.Count
                If Not c = DGVItemAdd.Columns.Count Then
                    r(c) = DGVItemAdd.Rows(i).Cells(c).Value
                Else
                    r(c) = "1"
                End If
            Next
            tableMid.Rows.Add(r)
        Next
        DGVItemOption.DataSource = tableOp
    End Sub

    Private Sub DGVItemAdd_DoubleClick(sender As Object, e As EventArgs) Handles DGVItemAdd.DoubleClick
        TranferRow(DGVItemAdd, tableMid, tableOp)
    End Sub

    Private Sub DGVItemOption_DoubleClick(sender As Object, e As EventArgs) Handles DGVItemOption.DoubleClick
        TranferRow(DGVItemOption, tableMid, tableAdd)
    End Sub

    Private Sub TranferRow(dgvSender As DataGridView, table As DataTable, tableRecever As DataTable)
        Dim nbr As Integer = 1
        Dim bool As Boolean = True
        If dgvSender.Columns.Count > tableRecever.Columns.Count Then
            nbr = 2
        End If
        For r As Integer = 0 To table.Rows.Count - 1
            If bool Then
                If dgvSender.CurrentRow.Cells(0).Value = table(r)(0) Then
                    If nbr = 2 Then
                        table(r)(table.Columns.Count - 1) = dgvSender.CurrentRow.Cells(dgvSender.Columns.Count - 1).Value
                    End If
                    Dim row As DataRow = tableRecever.NewRow
                    For c As Integer = 0 To table.Columns.Count - nbr
                        row(c) = table(r)(c)
                    Next
                    tableRecever.Rows.Add(row)
                    dgvSender.Rows.Remove(dgvSender.CurrentRow)
                    bool = False
                End If
            End If
        Next
    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        Dim str As String = TBNom.Text
        Dim bool As Boolean = False

        str = str.Trim
        If Not String.IsNullOrEmpty(str) Then
            Dim liste() As String = {TBNom.Text, NUDCout.Value}
            Dim id As DataTable = ConnectionServeur.Getinstance.GetInfo(liste, "CreateOption")
            If Not id(0)(0) = "False" Then
                For r As Integer = 0 To DGVItemOption.Rows.Count - 1
                    Dim listeAdd(2) As String
                    listeAdd(0) = DGVItemOption.Rows(r).Cells(0).Value
                    listeAdd(1) = id(0)(0)
                    listeAdd(2) = DGVItemOption.Rows(r).Cells(DGVItemOption.Columns.Count - 1).Value
                    If Not ConnectionServeur.Getinstance.AddDelete(listeAdd, "AddOptionItem") Then
                        bool = True
                    End If
                Next
                If bool Then
                    MessageBox.Show("Une erreure est survenue durant l'enregistrement des pièces associer aux option!")
                Else
                    MessageBox.Show("La création de la nouvelle option est fait!")
                    Me.Close()
                End If
            Else
                MessageBox.Show("Une erreure est survenue durant l'enregistrement de la nouvelle option!")
            End If
        Else
            MessageBox.Show("Vous devez avoir un nom!")
        End If
    End Sub

    Private Sub NUDCout_KeyDown(sender As Object, e As KeyEventArgs) Handles NUDCout.KeyDown
        If e.KeyCode = 110 Or e.KeyCode = 190 Then
            e.SuppressKeyPress = True
            SendKeys.Send(",")
        End If
    End Sub

    Private Sub DGVOption_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DGVItemOption.EditingControlShowing
        If DGVItemOption.CurrentCell.ColumnIndex = 4 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        End If
    End Sub

    Private Sub TextBox_keyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub DGVOption_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DGVItemOption.CellBeginEdit
        If Not e.ColumnIndex = 4 Then
            e.Cancel = True
        End If
    End Sub
End Class