Public Class UCGestionVehicule
    Dim table As DataTable
    ReadOnly search As New BindingSource
    Dim main As MainForm

    Sub New(mainform As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = mainform
    End Sub

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

    Private Sub TBSearchMat_TextChanged(sender As Object, e As EventArgs) Handles TBSearchMat.TextChanged, CBModel.SelectedIndexChanged, CBCoulVe.SelectedIndexChanged, CBCoulToi.SelectedIndexChanged, CBCoulTis.SelectedIndexChanged, RBFabNon.CheckedChanged, RBFabOui.CheckedChanged, RBFabTous.CheckedChanged, RBInvNon.CheckedChanged, RBInvOui.CheckedChanged, RBInvTous.CheckedChanged
        Dim str As String = ""

        If Not RBFabTous.Checked Then
            If RBFabOui.Checked Then
                str += "fabriquer like 'True'"
            Else
                str += "fabriquer like 'False'"
            End If
        End If

        If Not RBInvTous.Checked Then
            If String.IsNullOrEmpty(str) Then
                If RBInvOui.Checked Then
                    str += "eninventaire like 'True'"
                Else
                    str += "eninventaire like 'False'"
                End If
            Else
                If RBInvOui.Checked Then
                    str += " and eninventaire like 'True'"
                Else
                    str += " and eninventaire like 'False'"
                End If
            End If
        End If

        If Not String.IsNullOrEmpty(Trim(TBSearchMat.Text)) Then
            If String.IsNullOrEmpty(str) Then
                str += "nomatricule like '%" & TBSearchMat.Text & "%'"
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

    Private Sub DGVVehicule_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVVehicule.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim ucInfoClVe As New UCInfoClientVehicule(DGVVehicule.CurrentRow.Cells(0).Value, main)
            main.putUC(ucInfoClVe)
        End If
    End Sub

    Private Sub UCGestionVehicule_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub
End Class
