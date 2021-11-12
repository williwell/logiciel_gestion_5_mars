Public Class ListeVehicule
    Dim uc As UCVente

    Sub New(ucVente As UCVente)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        uc = ucVente
    End Sub

    Private Sub ListeVehicule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim table As DataTable = ConnectionServeur.Getinstance.GetInfo("getVehicule")
        DGVVehicule.DataSource = table
    End Sub

    Private Sub DGVVehicule_DoubleClick(sender As Object, e As EventArgs) Handles DGVVehicule.DoubleClick
        Dim row As DataGridViewRow = DGVVehicule.CurrentRow
        uc.setID(row.Cells(0).Value)
        uc.NextPage(row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value)
        Me.Close()
    End Sub


End Class