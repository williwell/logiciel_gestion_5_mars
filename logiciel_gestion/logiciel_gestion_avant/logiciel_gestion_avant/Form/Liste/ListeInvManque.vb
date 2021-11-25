Public Class ListeInvManque
    Dim table As DataTable
    Dim id As String
    Dim tableInv As DataTable
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
        Dim tablecl As DataTable = ConnectionServeur.Getinstance.GetInfo(id, "getOneClientByVe")
        Dim liste(table.Rows.Count - 1) As String

        For i As Integer = 0 To table.Rows.Count - 1
            liste(i) = table(i)(0)
        Next

        tableInv = ConnectionServeur.Getinstance.GetInfo(liste, "getInvManque")

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