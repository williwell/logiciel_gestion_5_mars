Public Class UCAccueil
    Dim tableItem As New DataTable
    ReadOnly tableVehicule As New DataTable
    ReadOnly main As MainForm

    Sub New(mainform As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = mainform
    End Sub

    Private Sub UCAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tableVehicule.Columns.Add("Temporaire") 'A changer plus tard
        tableVehicule.Rows.Add("Ce datagridview n'est pas encore implementé") 'A changer plus tard
        tableVehicule.Rows.Add("Ce datagridview n'est pas encore implementé") 'A changer plus tard

        LoadDGV()
    End Sub

    Public Sub LoadDGV()
        tableItem = ConnectionServeur.Getinstance.GetInfo("getInvLow")
        DGVVehicule.DataSource = tableVehicule
        DGVItemLow.DataSource = tableItem

        BlockSorting(DGVItemLow)
        BlockSorting(DGVVehicule)

        RowsColor()
    End Sub

    Private Sub BlockSorting(dgv As DataGridView)
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

    Private Sub UCAccueil_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub
End Class
