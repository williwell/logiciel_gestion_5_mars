Public Class UCAccueil
    ReadOnly tableItem As New DataTable
    ReadOnly tableVehicule As New DataTable
    ReadOnly main As MainForm
    ReadOnly tableInv As New DataTable
    ReadOnly tableManque As New DataTable

    Sub New(mainform As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = mainform
    End Sub

    Private Sub UCAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            tableManque.Columns.Add("IDVe")
            tableManque.Columns.Add("IDPiece")
            tableManque.Columns.Add("Quantite")
            Dim listeTe() As String = {"id", "Nom", "Description", "Utilise", "Quantité", "Minimun Stock"}
            For i As Integer = 0 To listeTe.Length - 1
                tableItem.Columns.Add(listeTe(i))
            Next

            tableVehicule.Columns.Add("ID")
            tableVehicule.Columns.Add("Numéro Matricule")
            tableVehicule.Columns.Add("Model")
            tableVehicule.Columns.Add("Couleur Véhicule")
            tableVehicule.Columns.Add("Couleur Toile")
            tableVehicule.Columns.Add("Couleur Tissus")
            tableVehicule.Columns.Add("Fabriquer", GetType(Boolean))
            tableVehicule.Columns.Add("En Inventaire", GetType(Boolean))
            tableVehicule.Columns.Add("Date Prévu", GetType(Date))
            tableVehicule.Columns.Add("Priorité")

            tableInv.Columns.Add("id")
            tableInv.Columns.Add("quantite")
            LoadDGV()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LoadDGV()
        tableInv.Clear()
        tableItem.Clear()
        tableManque.Clear()
        tableVehicule.Clear()

        For r As Integer = 0 To MainForm.tableInv.Rows.Count - 1
            If Integer.Parse(MainForm.tableInv.Rows(r).Item("Quantite")) < Integer.Parse(MainForm.tableInv.Rows(r).Item("minStock")) Then
                Dim row As DataRow = tableItem.NewRow
                row(0) = MainForm.tableInv.Rows(r).Item("ID")
                row(1) = MainForm.tableInv.Rows(r).Item("Nom")
                row(2) = MainForm.tableInv.Rows(r).Item("Description")
                row(3) = MainForm.tableInv.Rows(r).Item("Utilise")
                row(4) = MainForm.tableInv.Rows(r).Item("Quantite")
                row(5) = MainForm.tableInv.Rows(r).Item("minStock")
                tableItem.Rows.Add(row)
            End If
        Next

        DGVItemLow.DataSource = tableItem

        For r As Integer = 0 To MainForm.tableVe.Rows.Count - 1
            For r2 As Integer = 0 To MainForm.tableVenteVe.Rows.Count - 1
                If MainForm.tableVe.Rows(r).Item("id") = MainForm.tableVenteVe.Rows(r2).Item("idvehicule") Then
                    If MainForm.tableVenteVe.Rows(r2).Item("dateprevu") < Date.Now.AddMonths(1) Then
                        Dim row As DataRow = tableVehicule.NewRow
                        row(0) = MainForm.tableVe.Rows(r).Item("id")
                        row(1) = MainForm.tableVe.Rows(r).Item("nomatricule")
                        row(6) = MainForm.tableVe.Rows(r).Item("fabriquer")
                        row(7) = MainForm.tableVe.Rows(r).Item("eninventaire")
                        row(8) = MainForm.tableVenteVe.Rows(r2).Item("dateprevu")
                        row(9) = MainForm.tableVenteVe.Rows(r2).Item("priorite")
                        For r3 As Integer = 0 To MainForm.tableModel.Rows.Count - 1
                            If MainForm.tableVe.Rows(r).Item("idmodel") = MainForm.tableModel.Rows(r3).Item("id") Then
                                row(2) = MainForm.tableModel.Rows(r3).Item("nom")
                            End If
                        Next
                        For r3 As Integer = 0 To MainForm.tableCoulVe.Rows.Count - 1
                            If MainForm.tableVe.Rows(r).Item("idcouleur") = MainForm.tableCoulVe.Rows(r3).Item("id") Then
                                row(3) = MainForm.tableCoulVe.Rows(r3).Item("nom")
                            End If
                        Next
                        For r3 As Integer = 0 To MainForm.tableCoulToi.Rows.Count - 1
                            If MainForm.tableVe.Rows(r).Item("idcoultoile") = MainForm.tableCoulToi.Rows(r3).Item("id") Then
                                row(4) = MainForm.tableCoulToi.Rows(r3).Item("nom")
                            End If
                        Next
                        For r3 As Integer = 0 To MainForm.tableCoulTis.Rows.Count - 1
                            If MainForm.tableVe.Rows(r).Item("idcoultissus") = MainForm.tableCoulTis.Rows(r3).Item("id") Then
                                row(5) = MainForm.tableCoulTis.Rows(r3).Item("nom")
                            End If
                        Next
                        tableVehicule.Rows.Add(row)
                    End If
                End If
            Next
        Next

        DGVVehicule.DataSource = tableVehicule

        For r As Integer = 0 To MainForm.tableInv.Rows.Count - 1
            Dim row As DataRow = tableInv.NewRow
            row(0) = MainForm.tableInv.Rows(r).Item("id")
            row(1) = MainForm.tableInv.Rows(r).Item("quantite")
            tableInv.Rows.Add(row)
        Next

        For i As Integer = 0 To DGVVehicule.Rows.Count - 1
            Dim table As New DataTable
            table.Columns.Add("idinv")
            table.Columns.Add("quantite")
            For r As Integer = 0 To MainForm.tableVe.Rows.Count - 1
                If MainForm.tableVe.Rows(r).Item("id") = DGVVehicule.Rows(i).Cells(0).Value Then
                    For r2 As Integer = 0 To MainForm.tableModel.Rows.Count - 1
                        If MainForm.tableVe.Rows(r).Item("idmodel") = MainForm.tableModel.Rows(r2).Item("id") Then
                            For r3 As Integer = 0 To MainForm.tableInvMo.Rows.Count - 1
                                If MainForm.tableModel.Rows(r2).Item("id") = MainForm.tableInvMo.Rows(r3).Item("idmodel") Then
                                    Dim row As DataRow = table.NewRow
                                    row(0) = MainForm.tableInvMo.Rows(r3).Item("idinventaire")
                                    row(1) = MainForm.tableInvMo.Rows(r3).Item("nombreitem")
                                    table.Rows.Add(row)
                                End If
                            Next
                        End If
                    Next
                End If
            Next

            Dim liste(1, -1) As String


            For t1 As Integer = 0 To table.Rows.Count - 1
                Dim bool As Boolean = True
                Dim nbr As Integer = 0
                While bool
                    If table(t1)(0) = tableInv(nbr)(0) Then
                        bool = False
                        tableInv(nbr)(1) -= table(t1)(1)
                        Dim bool2 As Boolean = True

                        If Not liste.Length = 0 Then
                            For i2 As Integer = 0 To liste.Length / 2 - 1
                                If liste(0, i2) = tableInv(nbr)(0) Then
                                    liste(1, i2) = tableInv(nbr)(1)
                                    bool2 = False
                                End If
                            Next
                            If bool2 Then
                                Dim nbr2 As Integer = liste.Length / 2
                                ReDim Preserve liste(1, nbr2)
                                liste(0, nbr2) = tableInv(nbr)(0)
                                liste(1, nbr2) = tableInv(nbr)(1)
                            End If
                        Else
                            ReDim liste(1, 0)
                            liste(0, 0) = tableInv(nbr)(0)
                            liste(1, 0) = tableInv(nbr)(1)
                        End If
                    End If
                    nbr += 1
                End While
            Next

            For r As Integer = 0 To liste.Length / 2 - 1
                Dim row As DataRow = tableManque.NewRow
                row(0) = DGVVehicule.Rows(i).Cells(0).Value
                For c As Integer = 1 To 2
                    row(c) = liste(c - 1, r)
                Next
                tableManque.Rows.Add(row)
            Next
        Next

        BlockSorting(DGVItemLow)
        BlockSorting(DGVVehicule)

        RowsColorInv()
        RowsColorVe()
    End Sub

    Private Sub BlockSorting(dgv As DataGridView)
        For Each col As DataGridViewColumn In dgv.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    Public Sub RowsColorInv()
        For Each row As DataGridViewRow In DGVItemLow.Rows
            If row.Cells("Quantité").Value <= 0 Then
                row.DefaultCellStyle.BackColor = Color.Red
            Else
                row.DefaultCellStyle.BackColor = Color.Yellow
            End If
            If row.Cells("utilise").Value = False Then
                row.DefaultCellStyle.BackColor = Color.Green
            End If
        Next
        DGVItemLow.ClearSelection()
        DGVVehicule.ClearSelection()
    End Sub

    Public Sub RowsColorVe()
        For Each row As DataGridViewRow In DGVVehicule.Rows
            If row.Cells("Date Prévu").Value <= Date.Now Then
                row.DefaultCellStyle.BackColor = Color.Yellow
            Else
                row.DefaultCellStyle.BackColor = Color.Green
            End If
        Next
        For i As Integer = 0 To tableManque.Rows.Count - 1
            If tableManque(i)(2) <= 0 Then
                For r As Integer = 0 To DGVVehicule.Rows.Count - 1
                    If DGVVehicule.Rows(r).Cells(0).Value = tableManque(i)(0) Then
                        DGVVehicule.Rows(r).DefaultCellStyle.BackColor = Color.Red
                    End If
                Next
            End If
        Next
        DGVItemLow.ClearSelection()
        DGVVehicule.ClearSelection()
    End Sub

    Private Sub UCAccueil_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.FermerMenu()
    End Sub

    Private Sub DGVVehicule_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVVehicule.CellDoubleClick
        Dim table As New DataTable
        table.Columns.Add("ID Piece")
        table.Columns.Add("Quantité en manque")

        For r As Integer = 0 To tableManque.Rows.Count - 1
            If tableManque(r)(0) = DGVVehicule.CurrentRow.Cells(0).Value Then
                Dim row As DataRow = table.NewRow
                For c As Integer = 0 To table.Columns.Count - 1
                    row(c) = tableManque(r)(c + 1)
                Next
                table.Rows.Add(row)
            End If
        Next
        Dim form As New ListeInvManque(table, DGVVehicule.CurrentRow.Cells(0).Value)
        form.ShowDialog(Me)
    End Sub
End Class
