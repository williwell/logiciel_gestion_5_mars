Public Class UCInfoClientVehicule
    ReadOnly main As MainForm
    ReadOnly id As String
    Dim table As DataTable

    Sub New(idve As String, mainform As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        id = idve
        main = mainform
    End Sub

    Private Sub UCInfoClientVehicule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        table = ConnectionServeur.Getinstance.GetInfo(id, "getInfoClVe")

        If table.Rows.Count > 0 Then
            DGVClient.DataSource = table

            TBID.Text = table(0)(0)
            TBPrenom1.Text = table(0)(1)
            TBNom1.Text = table(0)(2)
            TBPrenom2.Text = table(0)(3)
            TBNom2.Text = table(0)(4)
            TBTel1.Text = table(0)(5)
            TBTel2.Text = table(0)(6)
            TBSexe.Text = table(0)(7)
            TBEmail.Text = table(0)(8)

            DGVClient.Rows.RemoveAt(0)
        End If
    End Sub

    Private Sub UCInfoClientVehicule_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub
End Class
