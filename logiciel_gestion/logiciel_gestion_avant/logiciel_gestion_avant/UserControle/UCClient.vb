Public Class UCClient
    ReadOnly main As MainForm

    Sub New(mainform As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = mainform
    End Sub

    Private Sub UCClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVClient.DataSource = MainForm.TableClient

        For c As Integer = 0 To DGVClient.Columns.Count - 1
            DGVClient.Columns(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    'Crée un nouveau form de type CreerClient et le faire apparaitre
    Private Sub BtCreer_Click(sender As Object, e As EventArgs) Handles BtCreer.Click
        Dim creer As New CreerClient(Me)
        creer.ShowDialog(Me)
    End Sub

    'Si on double click sur une ligne du DataGridView on crée un nouveau form de GestionClient avec comme paramètre la ligne du DataGridView e ton affiche
    Private Sub DGVClient_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClient.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim InfoClient As New GestionClient(DGVClient.CurrentRow.Cells(0).Value)
            InfoClient.ShowDialog(Me)
        End If
    End Sub

    'Si on click sur le UserControl on s'assure que le menu est fermé
    Private Sub UCClient_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub
End Class
