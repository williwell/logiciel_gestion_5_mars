Public Class ListeInvManque
    Dim table As DataTable
    Dim id As String
    Dim tableInv As New DataTable
    Dim bool As Boolean = False

    Sub New(tableManque As DataTable, idcl As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        table = tableManque
        id = idcl
    End Sub

    Private Sub ListeInvManque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVManque.DataSource = table

        Dim tableCl As New DataTable
        For c As Integer = 0 To MainForm.TableClient.Columns.Count - 1
            tableCl.Columns.Add(MainForm.TableClient.Columns(c).ColumnName)
        Next

        For r As Integer = 0 To MainForm.TableClient.Rows.Count - 1
            For r2 As Integer = 0 To MainForm.tableVenteVe.Rows.Count - 1
                If MainForm.tableVenteVe.Rows(r2).Item("idclient") = MainForm.TableClient.Rows(r).Item("id") Then
                    If MainForm.tableVenteVe.Rows(r2).Item("idvehicule") = id Then
                        Dim row As DataRow = tableCl.NewRow
                        For c As Integer = 0 To MainForm.TableClient.Columns.Count - 1
                            row(c) = MainForm.TableClient(r)(c)
                        Next
                        tableCl.Rows.Add(row)
                    End If
                End If
            Next
        Next

        Dim liste(table.Rows.Count - 1) As String

        For i As Integer = 0 To table.Rows.Count - 1
            liste(i) = table(i)(0)
        Next

        For i As Integer = 0 To MainForm.tableInv.Columns.Count - 1
            tableInv.Columns.Add(MainForm.tableInv.Columns(i).ColumnName)
        Next

        For r As Integer = 0 To MainForm.tableInv.Rows.Count - 1
            For i As Integer = 0 To liste.Length - 1
                If MainForm.tableInv.Rows(r).Item("id") = liste(i) Then
                    Dim row As DataRow = tableInv.NewRow
                    For c As Integer = 0 To MainForm.tableInv.Columns.Count - 1
                        row(c) = MainForm.tableInv(r)(c)
                    Next
                    tableInv.Rows.Add(row)
                End If
            Next
        Next

        TBIDCl.Text = tablecl(0)(0)
        TBPrenom1.Text = tablecl(0)(1)
        TBNom1.Text = tablecl(0)(2)
        TBPrenom2.Text = tablecl(0)(3)
        TBNom2.Text = tablecl(0)(4)
        TBTel1.Text = tablecl(0)(5)
        TBTel2.Text = tablecl(0)(6)
        TBSexe.Text = tablecl(0)(7)
        TBEmail.Text = tablecl(0)(8)

        bool = True
        ChargerInv(0)

        DGVManque.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DGVManque.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub ChargerInv(index As Integer)
        TBIDInv.Text = tableInv(index)(0)
        TBNomInv.Text = tableInv(index)(1)
        TBQuantite.Text = tableInv(index)(2)
        TBDescription.Text = tableInv(index)(3)
        TBEmplacement.Text = tableInv(index)(4)
        If tableInv(index)(5) = "True" Then
            CBUtilise.Checked = True
        Else
            CBUtilise.Checked = False
        End If
        TBCommande.Text = tableInv(index)(6)
        TBMin.Text = tableInv(index)(7)
    End Sub

    Private Sub DGVManque_SelectionChanged(sender As Object, e As EventArgs) Handles DGVManque.SelectionChanged
        If bool Then
            If Not IsNothing(DGVManque.CurrentRow) Then
                ChargerInv(DGVManque.CurrentRow.Index)
            End If
        End If
    End Sub
End Class