Public Class UCInfoClientVehicule
    Dim id As String

    Sub New(idve As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        id = idve
    End Sub

    Private Sub UCInfoClientVehicule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectionServeur.Getinstance.GetInfo(id, "getInfoClVe")
    End Sub
End Class
