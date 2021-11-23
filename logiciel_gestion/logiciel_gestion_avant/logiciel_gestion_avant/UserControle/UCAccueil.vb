Public Class UCAccueil
    Dim tableItem As New DataTable
    Dim tableVehicule As New DataTable
    ReadOnly main As MainForm
    Dim tableInv As DataTable

    Sub New(mainform As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = mainform
    End Sub

    Private Sub UCAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDGV()
    End Sub

    Public Sub LoadDGV()
        tableItem = ConnectionServeur.Getinstance.GetInfo("getInvLow")
        DGVItemLow.DataSource = tableItem

        tableVehicule = ConnectionServeur.Getinstance.GetInfo("getVehiculeAccueil")
        DGVVehicule.DataSource = tableVehicule

        tableInv = ConnectionServeur.Getinstance.GetInfo("getinventaire")

        For i As Integer = 0 To DGVVehicule.Rows.Count - 1
            Dim table As DataTable = ConnectionServeur.Getinstance.GetInfo("getInvOneVe")

            'Rendu la! faire le calcul de l'inventaire pour les véhicules!
        Next

        CalculInv()

        BlockSorting(DGVItemLow)
        BlockSorting(DGVVehicule)

        RowsColorInv()
        RowsColorVe()
    End Sub

    Private Sub BlockSorting(dgv As DataGridView)
        For Each col As DataGridViewColumn In dgv.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Public Sub RowsColorInv()
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

    Public Sub RowsColorVe()
        For Each row As DataGridViewRow In DGVVehicule.Rows
            If row.Cells("DatePrevu").Value <= Date.Now Then
                row.DefaultCellStyle.BackColor = Color.Yellow
            Else
                row.DefaultCellStyle.BackColor = Color.Green
            End If
            'If row.Cells("utilise").Value = False Then
            '    row.DefaultCellStyle.BackColor = Color.Green
            'End If
        Next
        DGVItemLow.ClearSelection()
        DGVVehicule.ClearSelection()
    End Sub

    Private Sub UCAccueil_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub

    Private Sub CalculInv()

    End Sub
End Class
