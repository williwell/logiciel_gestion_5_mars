﻿Public Class UCAccueil
    Dim tableItem As New DataTable
    Dim tableVehicule As New DataTable

    Private Sub UCAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tableVehicule.Columns.Add("Temporaire") 'A changer plus tard
        tableVehicule.Rows.Add("Ce datagridview n'est pas encore implementé") 'A changer plus tard
        tableVehicule.Rows.Add("Ce datagridview n'est pas encore implementé") 'A changer plus tard

        tableItem = ConnectionServeur.Getinstance.GetInfo("getInvLow")
        DGVVehicule.DataSource = tableVehicule
        DGVItemLow.DataSource = tableItem

        blockSorting(DGVItemLow)
        blockSorting(DGVVehicule)

        'For r As Integer = 0 To DGVItemLow.RowCount - 1
        '    If DGVItemLow.Rows(r).Cells("Quantite").Value <= 0 Then
        '        DGVVehicule.Rows(0).DefaultCellStyle.BackColor = Color.Red
        '    End If
        'Next
    End Sub

    Private Sub blockSorting(dgv As DataGridView)
        For Each col As DataGridViewColumn In dgv.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Public Sub RowsColor()
        For Each row As DataGridViewRow In DGVItemLow.Rows
            If row.Cells("Quantite").Value <= 0 Then
                row.DefaultCellStyle.BackColor = Color.Red
            Else
                row.DefaultCellStyle.BackColor = Color.Yellow
            End If
            If row.Cells("utilise").Value = False Then
                row.DefaultCellStyle.BackColor = Color.Green
            End If
        Next
        DGVItemLow.ClearSelection()
        DGVVehicule.ClearSelection()
    End Sub

End Class
