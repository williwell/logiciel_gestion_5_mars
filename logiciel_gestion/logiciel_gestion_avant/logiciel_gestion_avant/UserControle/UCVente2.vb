Public Class UCVente2
    ReadOnly main As MainForm
    ReadOnly uc As UCVente
    Dim table As DataTable
    Dim tableCh As New DataTable
    Dim id As Integer
    Sub New(ucVente As UCVente, form As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = form
        uc = ucVente
    End Sub

    Private Sub UCVente2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id = uc.getIDModel
        table = ConnectionServeur.Getinstance.GetInfo(id, "getOptionModel")
        DGVOpDispo.DataSource = table
        For i As Integer = 0 To table.Columns.Count - 1
            tableCh.Columns.Add(table.Columns(i).ColumnName)
        Next
        DGVOpCh.DataSource = tableCh
    End Sub

    Public Sub loadDGV()
        If Not id = uc.getIDModel Then
            id = uc.getIDModel
            table = ConnectionServeur.Getinstance.GetInfo(id, "getOptionModel")
            DGVOpDispo.DataSource = table

            For i As Integer = DGVOpCh.Rows.Count - 1 To 0 Step -1
                DGVOpCh.Rows.RemoveAt(i)
            Next
        End If
    End Sub

    Private Sub BTPrev_Click(sender As Object, e As EventArgs) Handles BTPrev.Click
        main.ChangeUCPrev1()
    End Sub

    Private Sub BTNext_Click(sender As Object, e As EventArgs) Handles BTNext.Click
        Dim liste(0) As String
        Dim nbr As Integer = 0

        For i As Integer = 0 To DGVOpCh.Rows.Count - 1
            ReDim Preserve liste(nbr)
            liste(nbr) = DGVOpCh.Rows(i).Cells(0).Value
            nbr += 1
        Next
        uc.nextPage2(liste)

        main.ChangeUCNext2()
    End Sub

    Private Sub DGVOpDispo_DoubleClick(sender As Object, e As EventArgs) Handles DGVOpDispo.DoubleClick
        ListGest.PopulateRow(tableCh, DGVOpDispo, DGVOpCh)
    End Sub

    Private Sub DGVOpCh_DoubleClick(sender As Object, e As EventArgs) Handles DGVOpCh.DoubleClick
        ListGest.PopulateRow(table, DGVOpCh, DGVOpDispo)
    End Sub
End Class
