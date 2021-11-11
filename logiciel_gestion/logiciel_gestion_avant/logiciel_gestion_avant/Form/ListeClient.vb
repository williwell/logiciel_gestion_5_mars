Public Class ListeClient
    Dim uc As UCVente3

    Sub New(ucVe As UCVente3)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        uc = ucVe
    End Sub

    Private Sub ListeClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim table As DataTable = ConnectionServeur.Getinstance.GetInfo("getClient")
        DGVClient.DataSource = table
    End Sub

    Private Sub DGVClient_DoubleClick(sender As Object, e As EventArgs) Handles DGVClient.DoubleClick
        uc.getRowCl(DGVClient.CurrentRow)
        Me.Close()
    End Sub
End Class