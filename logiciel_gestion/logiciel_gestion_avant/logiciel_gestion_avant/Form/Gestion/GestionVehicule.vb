Public Class GestionVehicule
    Dim row As DataGridViewRow
    Dim table As DataTable
    Dim tableModel As DataTable
    Dim tableCoulVe As DataTable
    Dim tableCoulToile As DataTable
    Dim tableCoulTissus As DataTable

    Sub New(rowVe As DataGridViewRow)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        row = rowVe
    End Sub

    Private Sub GestionVehicule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        table = ConnectionServeur.Getinstance.GetInfo(row.Cells(0).Value, "getInfoClVe")

        If table.Rows.Count > 0 Then
            DGVClient.DataSource = table

            TBIDCl.Text = table(0)(0)
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

        TBIDVe.Text = row.Cells(0).Value

        RemplirCB(tableModel, CBModel, "getModel")

        RemplirCB(tableCoulToile, CBCoulToile, "getCoulToile")

        RemplirCB(TableCoulTissus, CBCoulTissus, "getCoulTissus")
    End Sub



    Private Sub RemplirCB(ByRef table As DataTable, CB As ComboBox, str As String)
        table = ConnectionServeur.Getinstance.GetInfo(str)
        Dim liste(table.Rows.Count - 1)
        For i As Integer = 0 To table.Rows.Count - 1
            liste(i) = table(i)(1)
        Next

        CB.DataSource = liste
    End Sub

    Private Sub CBModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBModel.SelectedIndexChanged
        tableCoulVe = ConnectionServeur.Getinstance.GetInfo(tableModel(CBModel.SelectedIndex)(0), "getCouleurModel")
        Dim liste(0) As String
        If tableCoulVe.Rows.Count > 0 Then
            ReDim liste(tableCoulVe.Rows.Count - 1)
            For i As Integer = 0 To tableCoulVe.Rows.Count - 1
                liste(i) = tableCoulVe(i)(1) & " - " & tableCoulVe(i)(2)
            Next
        Else
            liste(0) = "Aucune couleur de disponible pour ce model"
        End If
        CBCoulVe.DataSource = liste
    End Sub
End Class