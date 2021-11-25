Public Class UCAccueil
    Dim tableItem As New DataTable
    Dim tableVehicule As New DataTable
    ReadOnly main As MainForm
    Dim tableInv As DataTable
    Dim tableManque As New DataTable

    Sub New(mainform As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = mainform
    End Sub

    Private Sub UCAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tableManque.Columns.Add("IDVe")
        tableManque.Columns.Add("IDPiece")
        tableManque.Columns.Add("Quantite")
        LoadDGV()
    End Sub

    Public Sub LoadDGV()
        tableItem = ConnectionServeur.Getinstance.GetInfo("getInvLow")
        DGVItemLow.DataSource = tableItem

        tableVehicule = ConnectionServeur.Getinstance.GetInfo("getVehiculeAccueil")
        DGVVehicule.DataSource = tableVehicule

        tableInv = ConnectionServeur.Getinstance.GetInfo("getInvAccueil")


        For i As Integer = 0 To DGVVehicule.Rows.Count - 1
            Dim table As DataTable = ConnectionServeur.Getinstance.GetInfo(DGVVehicule.Rows(i).Cells(0).Value, "getInvOneVe")
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
            If row.Cells("Quantite").Value <= 0 Then
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
            If row.Cells("DatePrevu").Value <= Date.Now Then
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
        main.fermerMenu()
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
        form.ShowDialog()
    End Sub
End Class
