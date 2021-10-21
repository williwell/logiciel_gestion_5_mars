Public Class test
    '' Create a new datatable
    'Dim table As New DataTable("Table")
    'Private Sub VB_Datagridview_Rows_Color_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    ' Add columns to your datatable, 
    '    ' with the name of the columns and their type 

    '    table.Columns.Add("Id", Type.GetType("System.Int32"))
    '    table.Columns.Add("First Name", Type.GetType("System.String"))
    '    table.Columns.Add("Last Name", Type.GetType("System.String"))
    '    table.Columns.Add("Age", Type.GetType("System.Int32"))

    '    ' Add rows to the datatable with some data
    '    table.Rows.Add(1, "XXXX", "YYYYY", 21)
    '    table.Rows.Add(2, "SSDD", "hGSQ", 5)
    '    table.Rows.Add(4, "cvfghyghj", "sdrgtyh", 19)
    '    table.Rows.Add(5, "hghfd", "ghjgdf", 36)
    '    table.Rows.Add(6, "cvvdfgh", "juyrfdvc", 3)
    '    table.Rows.Add(1, "XXXX", "YYYYY", 0)
    '    table.Rows.Add(2, "SSDD", "hGSQ", 12)
    '    table.Rows.Add(3, "fgfgd", "jgfdd", 0)
    '    table.Rows.Add(4, "cvfghyghj", "sdrgtyh", 9)
    '    table.Rows.Add(5, "hghfd", "ghjgdf", 1)
    '    table.Rows.Add(6, "cvvdfgh", "juyrfdvc", 32)
    '    table.Rows.Add(1, "XXXX", "YYYYY", 7)
    '    table.Rows.Add(2, "SSDD", "hGSQ", 1)
    '    table.Rows.Add(3, "fgfgd", "jgfdd", 14)
    '    table.Rows.Add(4, "cvfghyghj", "sdrgtyh", 0)
    '    table.Rows.Add(5, "hghfd", "ghjgdf", 33)
    '    table.Rows.Add(6, "cvvdfgh", "juyrfdvc", 21)
    '    table.Rows.Add(1, "XXXX", "YYYYY", 2)
    '    table.Rows.Add(2, "SSDD", "hGSQ", 18)
    '    table.Rows.Add(3, "fgfgd", "jgfdd", 45)
    '    table.Rows.Add(4, "cvfghyghj", "sdrgtyh", 4)


    '    ' now set the datagridview datasource equals to your datatable name
    '    DataGridView1.DataSource = table


    '    RowsColor()
    'End Sub

    'Public Sub RowsColor()

    '    For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
    '        Dim val As Integer
    '        val = DataGridView1.Rows(i).Cells(3).Value
    '        If val < 5 Then
    '            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red
    '            If val = 0 Then
    '                Timer1.Start()
    '            End If
    '        ElseIf val >= 5 And val < 10 Then
    '            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Orange
    '        ElseIf val >= 10 And val < 15 Then
    '            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
    '        Else
    '            DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
    '        End If
    '    Next
    'End Sub

    '' if val = 0
    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
    '        Dim val As Integer
    '        val = DataGridView1.Rows(i).Cells(3).Value
    '        If val = 0 Then
    '            If DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red Then
    '                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.White
    '            ElseIf DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.White Then
    '                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Red
    '            End If
    '        End If
    '    Next
    'End Sub

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

        For Each row As DataGridViewRow In DGVItemLow.Rows
            If row.Cells(row.Cells.Count - 2).Value <= 0 Then
                row.DefaultCellStyle.BackColor = Color.Red
            End If

        Next

        For r As Integer = 0 To DGVItemLow.RowCount - 1
            If DGVItemLow.Rows(r).Cells("Quantite").Value <= 0 Then
                DGVVehicule.Rows(0).DefaultCellStyle.BackColor = Color.Red
            End If
        Next
        RowsColor()
    End Sub

    Private Sub blockSorting(dgv As DataGridView)
        For Each col As DataGridViewColumn In dgv.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Public Sub RowsColor()

        For i As Integer = 0 To DGVItemLow.Rows.Count() - 1 Step +1
            Dim val As Integer
            val = DGVItemLow.Rows(i).Cells("Quantite").Value
            If val < 5 Then
                DGVItemLow.Rows(i).DefaultCellStyle.BackColor = Color.Red
            ElseIf val >= 5 And val < 10 Then
                DGVItemLow.Rows(i).DefaultCellStyle.BackColor = Color.Orange
            ElseIf val >= 10 And val < 15 Then
                DGVItemLow.Rows(i).DefaultCellStyle.BackColor = Color.Yellow
            Else
                DGVItemLow.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next
    End Sub
End Class