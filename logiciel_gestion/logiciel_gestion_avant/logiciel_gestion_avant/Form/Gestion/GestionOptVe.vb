Imports System.ComponentModel

Public Class GestionOptVe
    ReadOnly idVe As Integer
    ReadOnly tableOptVe As New DataTable
    ReadOnly tableOptDis As New DataTable
    Dim listeOr(-1) As String
    Sub New(id As Integer)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        idVe = id
    End Sub

    Private Sub GestionOptVe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nbr As Integer = 0
        For c As Integer = 0 To MainForm.tableOp.Columns.Count - 2
            tableOptVe.Columns.Add(MainForm.tableOp.Columns(c).ColumnName)
            tableOptDis.Columns.Add(MainForm.tableOp.Columns(c).ColumnName)
        Next

        Dim idMo As Integer
        For r As Integer = 0 To MainForm.tableVe.Rows.Count - 1
            If MainForm.tableVe.Rows(r).Item("id") = idVe Then
                idMo = MainForm.tableVe.Rows(r).Item("idmodel")
                Exit For
            End If
        Next

        For r As Integer = 0 To MainForm.tableOpMo.Rows.Count - 1
            If MainForm.tableOpMo.Rows(r).Item("idmodel") = idMo Then
                For r2 As Integer = 0 To MainForm.tableOp.Rows.Count - 1
                    If MainForm.tableOpMo.Rows(r).Item("idoption") = MainForm.tableOp.Rows(r2).Item("id") Then
                        Dim bool As Boolean = True
                        For r3 As Integer = 0 To MainForm.tableOpVe.Rows.Count - 1
                            If MainForm.tableOpVe.Rows(r3).Item("idoption") = MainForm.tableOp.Rows(r2).Item("id") And MainForm.tableOpVe.Rows(r3).Item("idvehicule") = idVe Then
                                bool = False
                                Exit For
                            End If
                        Next
                        If bool Then
                            Dim row As DataRow = tableOptDis.NewRow
                            row(0) = MainForm.tableOp.Rows(r2).ItemArray(0)
                            row(1) = MainForm.tableOp.Rows(r2).ItemArray(1)
                            row(2) = MainForm.tableOp.Rows(r2).ItemArray(2)
                            tableOptDis.Rows.Add(row)
                        Else
                            ReDim Preserve listeOr(nbr)
                            Dim row As DataRow = tableOptVe.NewRow
                            row(0) = MainForm.tableOp.Rows(r2).ItemArray(0)
                            row(1) = MainForm.tableOp.Rows(r2).ItemArray(1)
                            row(2) = MainForm.tableOp.Rows(r2).ItemArray(2)
                            tableOptVe.Rows.Add(row)
                            listeOr(nbr) = row(0)
                            nbr += 1
                        End If

                    End If
                Next
            End If
        Next

        DGVOptDis.DataSource = tableOptDis
        DGVOptVe.DataSource = tableOptVe

        DGVOptDis.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGVOptDis.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGVOptVe.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGVOptVe.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub DGVOptDis_DoubleClick(sender As Object, e As EventArgs) Handles DGVOptDis.DoubleClick
        PopulateRow(tableOptVe, DGVOptDis, DGVOptVe)
    End Sub

    Private Sub DGVOptVe_DoubleClick(sender As Object, e As EventArgs) Handles DGVOptVe.DoubleClick
        PopulateRow(tableOptDis, DGVOptVe, DGVOptDis)
    End Sub

    Public Sub PopulateRow(tableRecever As DataTable, dgvGiver As DataGridView, dgvRecever As DataGridView)
        If dgvGiver.CurrentRow IsNot Nothing Then
            Dim row As DataRow = tableRecever.NewRow
            For i As Integer = 0 To dgvGiver.Columns.Count - 1
                row(i) = dgvGiver.CurrentRow.Cells(i).Value
            Next
            tableRecever.Rows.Add(row)
            dgvRecever.Sort(dgvRecever.Columns(0), ListSortDirection.Ascending)
            dgvGiver.Rows.Remove(dgvGiver.CurrentRow)
            'CheckChange()
        End If
    End Sub

    Private Sub BTSave_Click(sender As Object, e As EventArgs) Handles BTSave.Click
        Dim listeAdd(0) As String
        Dim listeSupp(0) As String
        Dim nbrAdd As Integer = 2
        Dim nbrSupp As Integer = 1
        listeAdd(0) = idVe
        listeSupp(0) = idVe

        For i As Integer = 0 To listeOr.Length - 1
            Dim bool As Boolean = True
            For r As Integer = 0 To DGVOptVe.Rows.Count - 1
                If listeOr(i) = DGVOptDis.Rows(r).Cells(0).Value Then
                    bool = False
                End If
            Next
            If bool Then
                ReDim Preserve listeSupp(nbrSupp)
                listeSupp(nbrSupp) = listeOr(i)
                nbrSupp += 1
            End If
        Next
        For r As Integer = 0 To DGVOptVe.Rows.Count - 1
            Dim bool As Boolean = True
            For i As Integer = 0 To listeOr.Length - 1
                If listeOr(i) = DGVOptVe.Rows(r).Cells(0).Value Then
                    bool = False
                End If
            Next
            If bool Then
                ReDim Preserve listeAdd(nbrAdd)
                listeAdd(nbrAdd - 1) = DGVOptVe.Rows(r).Cells(0).Value
                listeAdd(nbrAdd) = DGVOptVe.Rows(r).Cells(2).Value
                nbrAdd += 2
            End If
        Next

        If listeSupp.Length > 1 Then
            If ConnectionServeur.Getinstance.AddDelete(listeSupp, "deleteOptVe") Then
                MessageBox.Show(MsgTextFr.Getinstance.MsgSauvServ)
            Else
                MessageBox.Show(MsgTextFr.Getinstance.MsgErrServ, MsgTextFr.Getinstance.MsgAttention)
            End If
        End If
        If listeAdd.Length > 1 Then
            If ConnectionServeur.Getinstance.AddDelete(listeAdd, "AddOpVe") Then
                MessageBox.Show(MsgTextFr.Getinstance.MsgSauvServ)
            Else
                MessageBox.Show(MsgTextFr.Getinstance.MsgErrServ, MsgTextFr.Getinstance.MsgAttention)
            End If
        End If
    End Sub

    Private Sub BTAnnuler_Click(sender As Object, e As EventArgs) Handles BTAnnuler.Click
        Me.Close()
    End Sub
End Class