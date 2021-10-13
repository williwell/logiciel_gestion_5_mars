Imports System.ComponentModel

Public Class CreerModel
    Dim ucGestionModel As UCGestionVehicule
    Dim tableOpAjout As New DataTable
    Dim tableOpMo As New DataTable
    Dim tableCoulAjout As New DataTable
    Dim tableCoulMo As New DataTable
    Dim tableInvAjout As New DataTable
    Dim tableInvMo As New DataTable
    Dim tableMid As New DataTable

    Sub New(uc As UCGestionVehicule)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        ucGestionModel = uc
    End Sub

    Private Sub CreerModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim liste(-1) As String

        tableOpAjout = ConnectionServeur.Getinstance.GetInfo(liste, "getOptionAdd")
        dgvOptionAjout.DataSource = tableOpAjout
        RemplirColDGV(dgvOptionAjout, dgvOptionMo, tableOpMo)

        tableCoulAjout = ConnectionServeur.Getinstance.GetInfo(liste, "getCouleurAdd")
        dgvCoulAjout.DataSource = tableCoulAjout
        RemplirColDGV(dgvCoulAjout, dgvCoulMo, tableCoulMo)

        tableInvAjout = ConnectionServeur.Getinstance.GetInfo("getInvAdd")
        DGVInventaireAdd.DataSource = tableInvAjout
        RemplirColDGVInv(DGVInventaireAdd, DGVInventaireMo, tableInvMo)

        For i As Integer = 0 To DGVInventaireAdd.Columns.Count
            If i = DGVInventaireAdd.Columns.Count Then
                tableMid.Columns.Add("nombreItem")
            Else
                tableMid.Columns.Add(DGVInventaireAdd.Columns(i).Name)
            End If
        Next

        For r As Integer = 0 To DGVInventaireAdd.Rows.Count - 1
            Dim row As DataRow = tableMid.NewRow
            For c As Integer = 0 To DGVInventaireAdd.Columns.Count
                If c = DGVInventaireAdd.Columns.Count Then
                    row(c) = ""
                Else
                    row(c) = DGVInventaireAdd.Rows(r).Cells(c).Value
                End If
            Next
            tableMid.Rows.Add(row)
        Next
    End Sub

    Private Sub RemplirColDGV(dgv As DataGridView, dgv2 As DataGridView, table As DataTable)
        For i As Integer = 0 To dgv.Columns.Count - 1
            table.Columns.Add(dgv.Columns(i).Name, GetType(String))
        Next
        dgv2.DataSource = table
    End Sub

    Private Sub RemplirColDGVInv(dgv As DataGridView, dgv2 As DataGridView, table As DataTable)
        For i As Integer = 0 To dgv.Columns.Count - 1
            table.Columns.Add(dgv.Columns(i).Name, GetType(String))
        Next
        table.Columns.Add("NombreItem")
        dgv2.DataSource = table
    End Sub

    Private Sub dgvOptionAjout_DoubleClick(sender As Object, e As EventArgs) Handles dgvOptionAjout.DoubleClick
        PopulateRow(tableOpMo, dgvOptionAjout, dgvOptionMo)
    End Sub

    Private Sub dgvOptionMo_DoubleClick(sender As Object, e As EventArgs) Handles dgvOptionMo.DoubleClick
        PopulateRow(tableOpAjout, dgvOptionMo, dgvOptionAjout)
    End Sub

    Private Sub dgvCoulAjout_DoubleClick(sender As Object, e As EventArgs) Handles dgvCoulAjout.DoubleClick
        PopulateRow(tableCoulMo, dgvCoulAjout, dgvCoulMo)
    End Sub

    Private Sub dgvCoulMo_DoubleClick(sender As Object, e As EventArgs) Handles dgvCoulMo.DoubleClick
        PopulateRow(tableCoulAjout, dgvCoulMo, dgvCoulAjout)
    End Sub

    Private Sub DGVInventaireAdd_DoubleClick(sender As Object, e As EventArgs) Handles DGVInventaireAdd.DoubleClick
        PopulateRowInv(tableInvMo, DGVInventaireAdd, DGVInventaireMo)
    End Sub

    Private Sub DGVInventaireMo_DoubleClick(sender As Object, e As EventArgs) Handles DGVInventaireMo.DoubleClick
        PopulateRowInv(tableInvAjout, DGVInventaireMo, DGVInventaireAdd)
    End Sub

    Private Sub PopulateRow(table As DataTable, dgvGiver As DataGridView, dgvRecever As DataGridView)
        Dim row As DataRow = table.NewRow
        For i As Integer = 0 To dgvGiver.Columns.Count - 1
            row(i) = dgvGiver.CurrentRow.Cells(i).Value
        Next
        table.Rows.Add(row)
        dgvRecever.Sort(dgvRecever.Columns(0), ListSortDirection.Ascending)
        dgvGiver.Rows.Remove(dgvGiver.CurrentRow)
    End Sub

    Private Sub PopulateRowInv(table As DataTable, dgvGiver As DataGridView, dgvRecever As DataGridView)
        Dim row As DataRow = table.NewRow
        Dim nbr As Integer = 0

        For i As Integer = 0 To tableMid.Rows.Count - 1
            If dgvGiver.CurrentRow.Cells(0).Value = tableMid(i)(0) Then
                If dgvGiver.Columns.Count > dgvRecever.Columns.Count Then
                    nbr = 2
                End If
                For c As Integer = 0 To dgvGiver.Columns.Count - nbr
                    row(c) = tableMid(i)(c)
                Next
            End If
        Next

        table.Rows.Add(row)
        dgvRecever.Sort(dgvRecever.Columns(0), ListSortDirection.Ascending)
        dgvGiver.Rows.Remove(dgvGiver.CurrentRow)
    End Sub

    Private Sub BtAnnuler_Click(sender As Object, e As EventArgs) Handles BtAnnuler.Click
        Me.Close()
    End Sub

    Private Sub BtEnregistrer_Click(sender As Object, e As EventArgs) Handles BtEnregistrer.Click
        Dim id As String
        If Not String.IsNullOrEmpty(TbName.Text) Then
            id = ConnectionServeur.Getinstance.AddModel(TbName.Text, nudCout.Value.ToString)
            If Not id = 0 Then
                If dgvOptionMo.Rows.Count > 0 Then
                    ConnectionServeur.Getinstance.AddDelete(createListe(dgvOptionMo), id, "AddOpMo")
                End If
                If dgvCoulMo.Rows.Count > 0 Then
                    ConnectionServeur.Getinstance.AddDelete(createListe(dgvCoulMo), id, "AddCoulMo")
                End If
                If DGVInventaireMo.Rows.Count > 0 Then
                    ConnectionServeur.Getinstance.AddDeleteListe(createListeInv(DGVInventaireMo), id, "AddInvMo")
                End If
                ucGestionModel.RemplirModel()
                MessageBox.Show("Création du nouveau model réussit")
                Me.Close()
            Else
                MessageBox.Show("Une erreure est survenu durant la création du nouveau model!")
            End If
        Else
            MessageBox.Show("Le champ nom ne peut pas être vide!")
        End If
    End Sub

    Private Function createListe(dgv As DataGridView) As String()
        Dim liste() As String = Nothing
        Dim nbr As Integer = 0
        For i As Integer = 0 To dgv.Rows.Count - 1
            ReDim Preserve liste(nbr)
            liste(nbr) = dgv.Rows(i).Cells(0).Value
            nbr += 1
        Next
        Return liste
    End Function

    Private Function createListeInv(dgv As DataGridView) As String()
        Dim liste() As String = Nothing
        Dim nbr As Integer = -1
        For i As Integer = 0 To dgv.Rows.Count - 1
            nbr += 1
            ReDim Preserve liste(nbr)
            liste(nbr) = dgv.Rows(i).Cells(0).Value
            nbr += 1
            ReDim Preserve liste(nbr)
            liste(nbr) = dgv.Rows(i).Cells(dgv.Columns.Count - 1).Value
        Next
        Return liste
    End Function

    Private Sub DGVInventaireMo_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DGVInventaireMo.CellBeginEdit
        If Not e.ColumnIndex = 4 Then
            e.Cancel = True
        End If
    End Sub
End Class