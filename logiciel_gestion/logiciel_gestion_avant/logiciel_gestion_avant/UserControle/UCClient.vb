Public Class UCClient
    ReadOnly main As MainForm
    Dim tableCl As DataTable

    Sub New(mainform As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = mainform
    End Sub

    Private Sub UCClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadClient()
    End Sub

    Private Sub BtCreer_Click(sender As Object, e As EventArgs) Handles BtCreer.Click
        Dim creer As New CreerClient(Me)
        creer.ShowDialog(Me)
    End Sub

    Public Sub LoadClient()
        tableCl = MainForm.TableClient
        DGVClient.DataSource = tableCl
    End Sub

    Private Sub DGVClient_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClient.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim InfoClient As New GestionClient(DGVClient.CurrentRow.Cells(0).Value, Me)
            InfoClient.ShowDialog()
        End If
    End Sub

    Private Sub UCClient_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub
End Class
