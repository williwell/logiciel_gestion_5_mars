Public Class UCGestionVehicule
    Dim table As DataTable
    Dim search As New BindingSource
    Dim bool As Boolean = True
    Dim str As String = ""

    Private Sub UCGestionVehicule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        table = ConnectionServeur.Getinstance.GetInfo("GetVehiculeAll")
        DGVVehicule.DataSource = table
        search.DataSource = DGVVehicule.DataSource

        Dim tableModel As DataTable = ConnectionServeur.Getinstance.GetInfo("getModel")
        Dim listeMo(tableModel.Rows.Count) As String
        listeMo(0) = "Tous les models"

        For i As Integer = 1 To tableModel.Rows.Count
            listeMo(i) = tableModel(i - 1)(1)
        Next
        CBModel.DataSource = listeMo

        Dim tableVe As DataTable = ConnectionServeur.Getinstance.GetInfo("getCouleur")
        Dim listeVe(tableVe.Rows.Count) As String
        listeVe(0) = "Toutes les Couleurs"

        For i As Integer = 1 To tableVe.Rows.Count
            listeVe(i) = tableVe(i - 1)(1)
        Next
        CBCoulVe.DataSource = listeVe

        Dim tableToi As DataTable = ConnectionServeur.Getinstance.GetInfo("getCoulToile")
        Dim listeToi(tableToi.Rows.Count) As String
        listeToi(0) = "Toutes les Couleurs Toiles"

        For i As Integer = 1 To tableToi.Rows.Count
            listeToi(i) = tableToi(i - 1)(1)
        Next
        CBCoulToi.DataSource = listeToi

        Dim tableTis As DataTable = ConnectionServeur.Getinstance.GetInfo("getCoulTissus")
        Dim listeTis(tableTis.Rows.Count) As String
        listeTis(0) = "Toutes les Couleurs Toiles"

        For i As Integer = 1 To tableTis.Rows.Count
            listeTis(i) = tableTis(i - 1)(1)
        Next
        CBCoulTis.DataSource = listeTis
    End Sub

    Private Sub SearchDGV()
        Dim str As String = ""
        If CBFab.Checked Then
            str += "fabriquer like 'true'"
        End If

        If CBInv.Checked Then
            If String.IsNullOrEmpty(str) Then
                str += "eninventaire like 'true'"
            Else
                str += " and eninventaire like 'true'"
            End If
        End If

        If Not String.IsNullOrEmpty(Trim(TBSearchMat.Text)) Then
            If String.IsNullOrEmpty(str) Then
                str += "nomatricule like '" & TBSearchMat.Text & "'"
            Else
                str += " and nomatricule like '" & TBSearchMat.Text & "'"
            End If
        End If

        If Not CBModel.SelectedIndex = 0 Then
            If String.IsNullOrEmpty(str) Then
                str += "Model like '" & CBModel.SelectedItem & "'"
            Else
                str += " and Model like '" & CBModel.SelectedItem & "'"
            End If
        End If

        If Not CBCoulVe.SelectedIndex = 0 Then
            If String.IsNullOrEmpty(str) Then
                str += "CouleurVehicule like '" & CBCoulVe.SelectedItem & "'"
            Else
                str += " and CouleurVehicule like '" & CBCoulVe.SelectedItem & "'"
            End If
        End If

        If Not CBCoulToi.SelectedIndex = 0 Then
            If String.IsNullOrEmpty(str) Then
                str += "CouleurToile like '" & CBCoulToi.SelectedItem & "'"
            Else
                str += " and CouleurToile like '" & CBCoulToi.SelectedItem & "'"
            End If
        End If

        If Not CBCoulTis.SelectedIndex = 0 Then
            If String.IsNullOrEmpty(str) Then
                str += "CouleurTissus like '" & CBCoulTis.SelectedItem & "'"
            Else
                str += " and CouleurTissus like '" & CBCoulTis.SelectedItem & "'"
            End If
        End If

        search.Filter = str
    End Sub

    Private Sub CBFab_CheckedChanged(sender As Object, e As EventArgs) Handles CBFab.CheckedChanged
        SearchDGV()
    End Sub

    Private Sub CBInv_CheckedChanged(sender As Object, e As EventArgs) Handles CBInv.CheckedChanged
        SearchDGV()
    End Sub

    Private Sub TBSearchMat_TextChanged(sender As Object, e As EventArgs) Handles TBSearchMat.TextChanged
        SearchDGV()
    End Sub

    Private Sub CBModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBModel.SelectedIndexChanged
        SearchDGV()
    End Sub

    Private Sub CBCoulVe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCoulVe.SelectedIndexChanged
        SearchDGV()
    End Sub

    Private Sub CBCoulToi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCoulToi.SelectedIndexChanged
        SearchDGV()
    End Sub

    Private Sub CBCoulTis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCoulTis.SelectedIndexChanged
        SearchDGV()
    End Sub
End Class
