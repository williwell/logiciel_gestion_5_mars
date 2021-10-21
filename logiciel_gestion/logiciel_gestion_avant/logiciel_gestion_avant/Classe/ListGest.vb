Imports System.ComponentModel

Public Class ListGest
    Shared Sub PopulateRow(table As DataTable, dgvGiver As DataGridView, dgvRecever As DataGridView)
        Dim row As DataRow = table.NewRow
        Dim nbr As Integer = 0
        For i As Integer = 0 To dgvGiver.Columns.Count - 1
            row(i) = dgvGiver.CurrentRow.Cells(i).Value
        Next
        table.Rows.Add(row)
        dgvRecever.Sort(dgvRecever.Columns(0), ListSortDirection.Ascending)
        dgvGiver.Rows.Remove(dgvGiver.CurrentRow)
    End Sub

    Shared Sub PopulateRow(table As DataTable, dgvGiver As DataGridView, dgvRecever As DataGridView, tableMid As DataTable)
        Dim row As DataRow = table.NewRow
        Dim nbr As Integer = 0

        If dgvGiver.Columns.Count > dgvRecever.Columns.Count Then
            nbr = 2
        End If

        For i As Integer = 0 To tableMid.Rows.Count - 1
            If tableMid(i)(0) = dgvGiver.CurrentRow.Cells(0).Value Then
                If nbr = 2 Then
                    tableMid(i)(tableMid.Columns.Count - 1) = dgvGiver.CurrentRow.Cells(dgvGiver.Columns.Count - 1).Value
                End If
                For int As Integer = 0 To dgvGiver.Columns.Count - nbr
                    row(int) = tableMid(i)(int)
                Next
            End If
        Next


        table.Rows.Add(row)
        dgvRecever.Sort(dgvRecever.Columns(0), ListSortDirection.Ascending)
        dgvGiver.Rows.Remove(dgvGiver.CurrentRow)
    End Sub

    Shared Function PopulateList(table As DataTable) As String()
        Dim list(table.Rows.Count - 1) As String
        For i As Integer = 0 To table.Rows.Count - 1
            list(i) = table(i)(0)
        Next
        Return list
    End Function

    Shared Sub changeBt(bool As Boolean, btSave As Button, btAnnuler As Button)
        btSave.Enabled = bool
        btAnnuler.Enabled = bool
    End Sub

    Shared Function CheckChange(liste(,) As String, table As DataTable, nbr As Integer) As Boolean
        For i As Integer = 0 To table.Rows.Count - 1
            For int As Integer = 0 To liste.Length / table.Columns.Count - 1
                If liste(int, 0) = table.Rows(i).Item(0) Then
                    For c As Integer = 0 To table.Columns.Count - 1
                        If Not liste(int, c) = table(int)(c) Then
                            Return True
                        End If
                    Next
                End If
            Next
        Next
        If Not nbr = table.Rows.Count Then
            Return True
        End If
        Return False
    End Function

    Shared Function CreateListeAdd(liste() As String, dgv As DataGridView) As String()
        Dim listeAdd() As String = Nothing
        Dim nbr As Integer = -1
        For i As Integer = 0 To dgv.Rows.Count - 1
            Dim bool As Boolean = True
            For int As Integer = 0 To liste.Length - 1
                If liste(int) = dgv.Rows(i).Cells(0).Value Then
                    bool = False
                End If
            Next
            If bool Then
                nbr += 1
                ReDim Preserve listeAdd(nbr)
                listeAdd(nbr) = dgv.Rows(i).Cells(0).Value
            End If
        Next
        Return listeAdd
    End Function

    Shared Sub RemplirModel(table As DataTable, instruction As String, ListeId() As String, cb As ComboBox)
        table = ConnectionServeur.Getinstance.GetInfo(instruction)
        Dim liste(table.Rows.Count - 1) As String
        ReDim ListeId(table.Rows.Count - 1)
        For i As Integer = 0 To table.Rows.Count - 1
            liste(i) = table(i)(1)
            ListeId(i) = table(i)(0)
        Next
        cb.DataSource = liste
        'Remplir(1)
    End Sub

    Shared Sub ListeOr(liste(,) As String, table As DataTable)
        For r As Integer = 0 To table.Rows.Count - 1
            For c As Integer = 0 To table.Columns.Count - 1
                liste(r, c) = table(r)(c)
            Next
        Next
    End Sub
End Class
