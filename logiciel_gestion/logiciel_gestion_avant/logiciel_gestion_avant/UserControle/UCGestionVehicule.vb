Public Class UCGestionVehicule
    ReadOnly table As New DataTable
    ReadOnly search As New BindingSource
    ReadOnly main As MainForm

    Sub New(mainform As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = mainform
    End Sub

    Private Sub UCGestionVehicule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        table.Columns.Add("id")
        table.Columns.Add("nomatricule")
        table.Columns.Add("model")
        table.Columns.Add("cout")
        table.Columns.Add("couleurvehicule")
        table.Columns.Add("codecouleurvehicule")
        table.Columns.Add("couleurtoile")
        table.Columns.Add("codecouleurtoile")
        table.Columns.Add("couleurtissus")
        table.Columns.Add("codecouleurtissus")
        table.Columns.Add("fabriquer")
        table.Columns.Add("eninventaire")

        For r As Integer = 0 To MainForm.tableVe.Rows.Count - 1
            For r2 As Integer = 0 To MainForm.tableModel.Rows.Count - 1
                If MainForm.tableModel.Rows(r2).Item("id") = MainForm.tableVe.Rows(r).Item("idmodel") Then
                    For r3 As Integer = 0 To MainForm.tableCoulVe.Rows.Count - 1
                        If MainForm.tableCoulVe.Rows(r3).Item("id") = MainForm.tableVe.Rows(r).Item("idcouleur") Then
                            For r4 As Integer = 0 To MainForm.tableCoulToi.Rows.Count - 1
                                If MainForm.tableVe.Rows(r).Item("idcoultoile") = MainForm.tableCoulToi.Rows(r4).Item("id") Then
                                    For r5 As Integer = 0 To MainForm.tableCoulTis.Rows.Count - 1
                                        If MainForm.tableVe.Rows(r).Item("idcoultissus") = MainForm.tableCoulTis.Rows(r5).Item("id") Then
                                            Dim row As DataRow = table.NewRow
                                            row(0) = MainForm.tableVe.Rows(r).Item("id")
                                            row(1) = MainForm.tableVe.Rows(r).Item("nomatricule")
                                            row(2) = MainForm.tableModel.Rows(r2).Item("nom")
                                            row(3) = MainForm.tableModel.Rows(r2).Item("cout")
                                            row(4) = MainForm.tableCoulVe.Rows(r3).Item("nom")
                                            row(5) = MainForm.tableCoulVe.Rows(r3).Item("code")
                                            row(6) = MainForm.tableCoulToi.Rows(r4).Item("nom")
                                            row(7) = MainForm.tableCoulToi.Rows(r4).Item("code")
                                            row(8) = MainForm.tableCoulTis.Rows(r5).Item("nom")
                                            row(9) = MainForm.tableCoulTis.Rows(r5).Item("code")
                                            row(10) = MainForm.tableVe.Rows(r).Item("fabriquer")
                                            row(11) = MainForm.tableVe.Rows(r).Item("eninventaire")
                                            table.Rows.Add(row)
                                        End If
                                    Next
                                End If
                            Next
                        End If
                    Next
                End If
            Next
        Next

        DGVVehicule.DataSource = table
        search.DataSource = DGVVehicule.DataSource

        Dim listeMo(MainForm.tableModel.Rows.Count) As String
        listeMo(0) = "Tous les models"

        For i As Integer = 1 To MainForm.tableModel.Rows.Count
            listeMo(i) = MainForm.tableModel(i - 1)(1)
        Next
        CBModel.DataSource = listeMo

        Dim tableVe As New DataTable
        tableVe.Columns.Add("nom")

        For r As Integer = 0 To MainForm.tableCoulVe.Rows.Count - 1
            If MainForm.tableCoulVe.Rows(r).Item("deletecoul") = "True" Then
                Dim row As DataRow = tableVe.NewRow
                row(0) = MainForm.tableCoulVe.Rows(r).Item("nom")
                tableVe.Rows.Add(row)
            End If
        Next

        Dim listeVe(tableVe.Rows.Count) As String
        listeVe(0) = "Toutes les Couleurs"

        For i As Integer = 1 To tableVe.Rows.Count
            listeVe(i) = tableVe(i - 1)(0)
        Next
        CBCoulVe.DataSource = listeVe

        Dim listeToi(MainForm.tableCoulToi.Rows.Count) As String
        listeToi(0) = "Toutes les Couleurs Toiles"

        For i As Integer = 1 To MainForm.tableCoulToi.Rows.Count
            listeToi(i) = MainForm.tableCoulToi(i - 1)(1)
        Next
        CBCoulToi.DataSource = listeToi

        Dim listeTis(MainForm.tableCoulTis.Rows.Count) As String
        listeTis(0) = "Toutes les Couleurs Toiles"

        For i As Integer = 1 To MainForm.tableCoulTis.Rows.Count
            listeTis(i) = MainForm.tableCoulTis(i - 1)(1)
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
            Dim gestionVe As New GestionVehicule(DGVVehicule.CurrentRow, Me)
            gestionVe.ShowDialog()
        End If
    End Sub

    Private Sub UCGestionVehicule_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub

    Public Sub ChangeRow(row As DataGridViewRow)
        For r As Integer = 0 To DGVVehicule.Rows.Count - 1
            If DGVVehicule.Rows(r).Cells(0).Value = row.Cells(0).Value Then
                For c As Integer = 0 To DGVVehicule.Columns.Count - 1
                    DGVVehicule.Rows(r).Cells(c).Value = row.Cells(c).Value
                Next
            End If
        Next
    End Sub
End Class
