Imports System.ComponentModel

Public Class UCGestionVehicule
    Dim tableModel As DataTable
    Dim listeId() As String
    Dim tableOptionAdd As DataTable
    Dim OrOpAdd(0, 0) As String
    Dim tableOptionMo As DataTable
    Dim OrOpMo(0, 0) As String
    Dim tableCouleurAdd As DataTable
    Dim OrCoulAdd(0, 0) As String
    Dim tableCouleurMo As DataTable
    Dim OrCoulMo(0, 0) As String
    Dim listeOpMo() As String
    Dim listeOpDispo() As String
    Dim listeCoulMo() As String
    Dim listeCoulDispo() As String
    Dim nbrOp As Integer
    Dim nbrCoul As Integer

    Private Sub UCGestionVehicule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemplirModel()
    End Sub

    Private Sub Remplir(id As String)
        tbPrix.Text = tableModel(id - 1)(2)

        tableOptionMo = ConnectionServeur.Getinstance.GetInfo(id, "getOptionModel")
        ReDim OrOpMo(tableOptionMo.Rows.Count - 1, tableOptionMo.Columns.Count - 1)
        ListeOr(OrOpMo, tableOptionMo)
        dgvOptionMo.DataSource = tableOptionMo
        listeOpMo = PopulateList(tableOptionMo)
        nbrOp = listeOpMo.Length

        Dim liste(dgvOptionMo.Rows.Count - 1) As String
        For i As Integer = 0 To liste.Count - 1
            liste(i) = dgvOptionMo.Rows(i).Cells(0).Value
        Next

        tableOptionAdd = ConnectionServeur.Getinstance.GetInfo(liste, "getOptionAdd")
        ReDim OrOpAdd(tableOptionAdd.Rows.Count - 1, tableOptionAdd.Columns.Count - 1)
        ListeOr(OrOpAdd, tableOptionAdd)
        dgvOptionAjout.DataSource = tableOptionAdd
        listeOpDispo = PopulateList(tableOptionAdd)

        tableCouleurMo = ConnectionServeur.Getinstance.GetInfo(id, "getCouleurModel")
        ReDim OrCoulMo(tableCouleurMo.Rows.Count - 1, tableCouleurMo.Columns.Count - 1)
        ListeOr(OrCoulMo, tableCouleurMo)
        dgvCoulMo.DataSource = tableCouleurMo
        listeCoulMo = PopulateList(tableCouleurMo)
        nbrCoul = listeCoulMo.Length

        ReDim liste(dgvCoulMo.Rows.Count - 1)
        For i As Integer = 0 To liste.Count - 1
            liste(i) = dgvCoulMo.Rows(i).Cells(0).Value
        Next

        tableCouleurAdd = ConnectionServeur.Getinstance.GetInfo(liste, "getCouleurAdd")
        ReDim OrCoulAdd(tableCouleurAdd.Rows.Count - 1, tableCouleurAdd.Columns.Count - 1)
        ListeOr(OrCoulAdd, tableCouleurAdd)
        dgvCoulAjout.DataSource = tableCouleurAdd
        listeCoulDispo = PopulateList(tableCouleurAdd)
    End Sub

    Private Sub CbModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbModel.SelectedIndexChanged
        Remplir(cbModel.SelectedIndex + 1)
    End Sub

    Private Sub DgvOptionMo_DoubleClick(sender As Object, e As EventArgs) Handles dgvOptionMo.DoubleClick
        PopulateRow(tableOptionAdd, dgvOptionMo, dgvOptionAjout)
    End Sub

    Private Sub DgvOptionAjout_DoubleClick(sender As Object, e As EventArgs) Handles dgvOptionAjout.DoubleClick
        PopulateRow(tableOptionMo, dgvOptionAjout, dgvOptionMo)
    End Sub

    Private Sub DgvCoulMo_DoubleClick(sender As Object, e As EventArgs) Handles dgvCoulMo.DoubleClick
        PopulateRow(tableCouleurAdd, dgvCoulMo, dgvCoulAjout)
    End Sub

    Private Sub DgvCoulAjout_DoubleClick(sender As Object, e As EventArgs) Handles dgvCoulAjout.DoubleClick
        PopulateRow(tableCouleurMo, dgvCoulAjout, dgvCoulMo)
    End Sub

    Public Sub PopulateRow(table As DataTable, dgvGiver As DataGridView, dgvRecever As DataGridView)
        Dim row As DataRow = table.NewRow
        For i As Integer = 0 To dgvGiver.Columns.Count - 1
            row(i) = dgvGiver.CurrentRow.Cells(i).Value
        Next
        table.Rows.Add(row)
        dgvRecever.Sort(dgvRecever.Columns(0), ListSortDirection.Ascending)
        dgvGiver.Rows.Remove(dgvGiver.CurrentRow)
        CheckChange()
    End Sub

    Public Function PopulateList(table As DataTable) As String()
        Dim list(table.Rows.Count - 1) As String
        For i As Integer = 0 To table.Rows.Count - 1
            list(i) = table(i)(0)
        Next
        Return list
    End Function

    Public Sub CheckChange()
        Dim change As Boolean = CheckFor(listeOpMo, tableOptionMo, nbrOp)

        If Not change Then
            change = CheckFor(listeCoulMo, tableCouleurMo, nbrCoul)
        End If

        If change Then
            BtEnregistrer.Enabled = True
            BtAnnuler.Enabled = True
        Else
            BtEnregistrer.Enabled = False
            BtAnnuler.Enabled = False
        End If
    End Sub

    Public Function CheckFor(liste() As String, table As DataTable, nbr As Integer) As Boolean
        Dim bool As Boolean
        For i As Integer = 0 To table.Rows.Count - 1
            bool = False
            For int As Integer = 0 To liste.Length - 1
                If liste(int) = table.Rows(i).Item(0) Then
                    bool = True
                End If
            Next
            If Not bool Then
                Return True
            End If
        Next
        If Not nbr = table.Rows.Count Then
            Return True
        End If
        Return False
    End Function

    Private Sub BtEnregistrer_Click(sender As Object, e As EventArgs) Handles BtEnregistrer.Click
        Dim listeAjout() As String = CreateListeAdd(listeOpMo, dgvOptionMo)
        Dim bool1 As Boolean = False
        Dim bool2 As Boolean = False

        If Not IsNothing(listeAjout) Then
            If ConnectionServeur.Getinstance.AddDelete(listeAjout, listeId(cbModel.SelectedIndex), "AddOpMo") Then
                listeAjout = CreateListeAdd(listeOpDispo, dgvOptionAjout)
                If Not IsNothing(listeAjout) Then
                    If ConnectionServeur.Getinstance.AddDelete(listeAjout, listeId(cbModel.SelectedIndex), "DeleteOpMo") Then
                        bool1 = True
                    End If
                End If
            End If
        End If

        listeAjout = CreateListeAdd(listeCoulMo, dgvCoulMo)

        If Not IsNothing(listeAjout) Then
            If ConnectionServeur.Getinstance.AddDelete(listeAjout, listeId(cbModel.SelectedIndex), "AddCoulMo") Then
                listeAjout = CreateListeAdd(listeCoulDispo, dgvCoulAjout)
                If Not IsNothing(listeAjout) Then
                    If ConnectionServeur.Getinstance.AddDelete(listeAjout, listeId(cbModel.SelectedIndex), "DeleteCoulMo") Then
                        bool2 = True
                    End If

                End If
            End If
        End If

        If bool1 And bool2 Then
            MessageBox.Show("L'enregistrement c'est effectuer correctement")
            ReDim OrOpMo(tableOptionMo.Rows.Count - 1, tableOptionMo.Columns.Count - 1)
            ListeOr(OrOpMo, tableOptionMo)
            ReDim OrOpAdd(tableOptionAdd.Rows.Count - 1, tableOptionAdd.Columns.Count - 1)
            ListeOr(OrOpAdd, tableOptionAdd)
            ReDim OrCoulMo(tableCouleurMo.Rows.Count - 1, tableCouleurMo.Columns.Count - 1)
            ListeOr(OrCoulMo, tableCouleurMo)
            ReDim OrCoulAdd(tableCouleurAdd.Rows.Count - 1, tableCouleurAdd.Columns.Count - 1)
            ListeOr(OrCoulAdd, tableCouleurAdd)
            CheckChange()
        Else
            MessageBox.Show("Un erreure est c'est produit durant l'enregistrement!")
        End If
    End Sub

    Public Function CreateListeAdd(liste() As String, dgv As DataGridView) As String()
        Dim listeAdd() As String = Nothing
        Dim nbr As Integer = -1
        For i As Integer = 0 To dgv.Rows.Count - 1
            Dim bool As Boolean = True
            For int As Integer = 0 To liste.Length - 1
                If liste(int) = dgv.Rows(i).Cells(0).Value Then
                    bool = False
                End If
            Next
            If bool Then
                nbr += 1
                ReDim Preserve listeAdd(nbr)
                listeAdd(nbr) = dgv.Rows(i).Cells(0).Value
            End If
        Next
        Return listeAdd
    End Function

    Private Sub BtAnnuler_Click(sender As Object, e As EventArgs) Handles BtAnnuler.Click
        AnnulerChangement(OrOpMo, tableOptionMo)
        AnnulerChangement(OrOpAdd, tableOptionAdd)
        AnnulerChangement(OrCoulMo, tableCouleurMo)
        AnnulerChangement(OrCoulAdd, tableCouleurAdd)
    End Sub

    Private Sub AnnulerChangement(liste(,) As String, table As DataTable)
        Dim i As Integer = liste.Length / table.Columns.Count
        For int As Integer = table.Rows.Count - 1 To 0 Step -1
            table.Rows.RemoveAt(int)
        Next

        For r As Integer = 0 To i - 1
            Dim row As DataRow = table.NewRow
            For c As Integer = 0 To table.Columns.Count - 1
                row(c) = liste(r, c)
            Next
            table.Rows.Add(row)
        Next
        CheckChange()
    End Sub

    Public Sub ListeOr(liste(,) As String, table As DataTable)
        For r As Integer = 0 To table.Rows.Count - 1
            For c As Integer = 0 To table.Columns.Count - 1
                liste(r, c) = table(r)(c)
            Next
        Next
    End Sub

    Private Sub btCreer_Click(sender As Object, e As EventArgs) Handles btCreer.Click
        Dim creer As New CreerModel(Me)
        creer.ShowDialog()
    End Sub

    Public Sub RemplirModel()
        tableModel = ConnectionServeur.Getinstance.GetInfo("getModel")
        Dim liste(tableModel.Rows.Count - 1) As String
        ReDim listeId(tableModel.Rows.Count - 1)
        For i As Integer = 0 To tableModel.Rows.Count - 1
            liste(i) = tableModel(i)(1)
            listeId(i) = tableModel(i)(0)
        Next
        cbModel.DataSource = liste
        Remplir(1)
    End Sub

    Private Sub btInv_Click(sender As Object, e As EventArgs) Handles btInv.Click
        Dim uc As New GestionInvModel(listeId(cbModel.SelectedIndex), Me)
        uc.ShowDialog()
    End Sub
End Class
