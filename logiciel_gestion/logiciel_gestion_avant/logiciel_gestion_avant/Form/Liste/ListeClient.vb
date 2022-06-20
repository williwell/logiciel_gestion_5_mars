Public Class ListeClient
    ReadOnly uc As CreerCommande

    Sub New(ucVe As CreerCommande)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        uc = ucVe
    End Sub

    Private Sub ListeClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Mettre les info de la table client du mainform dans le DataGridView
        DGVClient.DataSource = MainForm.TableClient

        For c As Integer = 0 To DGVClient.Columns.Count - 1
            DGVClient.Columns(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    Private Sub DGVClient_DoubleClick(sender As Object, e As EventArgs) Handles DGVClient.DoubleClick
        'Quand on double click sur une 
        uc.SetIDCl(DGVClient.CurrentRow)
        Me.Close()
    End Sub
End Class