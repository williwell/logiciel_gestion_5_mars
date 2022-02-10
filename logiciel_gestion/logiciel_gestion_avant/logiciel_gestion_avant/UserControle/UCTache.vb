Public Class UCTache
    Dim main As MainForm


    Sub New(mainform As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = mainform
    End Sub

    Private Sub UCTache_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDGV()
    End Sub

    Public Sub LoadDGV()
        Dim table As New DataTable
        For c As Integer = 0 To MainForm.tableTache.Columns.Count - 1
            table.Columns.Add(MainForm.tableTache.Columns(c).ColumnName)
        Next

        For r As Integer = 0 To MainForm.tableTache.Rows.Count - 1
            Dim row As DataRow = table.NewRow
            For c As Integer = 0 To MainForm.tableTache.Columns.Count - 1
                row(c) = MainForm.tableTache(r)(c)
            Next
            table.Rows.Add(row)
        Next

        DGVTache.DataSource = table

        DGVTache.Columns(DGVTache.Columns.Count - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGVTache.Columns(DGVTache.Columns.Count - 2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub BTAdd_Click(sender As Object, e As EventArgs) Handles BTAdd.Click
        Dim creerTache As New CreerTache(Me)
        creerTache.ShowDialog()
    End Sub

    Private Sub BTMod_Click(sender As Object, e As EventArgs) Handles BTMod.Click
        Dim gest As New GestionTache(DGVTache.CurrentRow, Me)
        gest.ShowDialog()
    End Sub

    Private Sub BTSupp_Click(sender As Object, e As EventArgs) Handles BTSupp.Click
        If MessageBox.Show("Voulez-vous vraiment supprimer cette tâche?", "Attention", MessageBoxButtons.YesNo) = vbYes Then
            If ConnectionServeur.Getinstance.AddDelete(DGVTache.CurrentRow.Cells(0).Value, "delTache") Then
                DGVTache.Rows.Remove(DGVTache.CurrentRow)
            Else
                MessageBox.Show("Une erreur est survenu durant la suppression de la tâche!")
            End If
        End If
    End Sub
End Class
