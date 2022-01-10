Public Class ListeInvManque
    ReadOnly table As DataTable
    ReadOnly id As String
    ReadOnly tableInv As New DataTable
    Dim bool As Boolean = False
    Dim tableFour As New DataTable

    Sub New(tableManque As DataTable, idcl As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        table = tableManque
        id = idcl
    End Sub

    Private Sub ListeInvManque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVManque.DataSource = table

        'Création de la table temporaire avec les nom de colonnes de la table client du mainform
        Dim tableCl As New DataTable
        For c As Integer = 0 To MainForm.TableClient.Columns.Count - 1
            tableCl.Columns.Add(MainForm.TableClient.Columns(c).ColumnName)
        Next

        'Ajout des colonnes de la table FOurnisseur avec les nom de colonnes du mainform tableFOur
        For c As Integer = 0 To MainForm.tableFour.Columns.Count - 1
            tableFour.Columns.Add(MainForm.tableFour.Columns(c).ColumnName)
        Next

        'Loop pour mettre les information des clients avec une jointure avec la table VenteVéhicule
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

        'Créer une liste et mettre tous les id de la table qu'on a recu dans le constructeur paramétrer
        Dim liste(table.Rows.Count - 1) As String
        For i As Integer = 0 To table.Rows.Count - 1
            liste(i) = table(i)(0)
        Next

        'Créer les colonnes pour la table Inv
        For i As Integer = 0 To MainForm.tableInv.Columns.Count - 1
            tableInv.Columns.Add(MainForm.tableInv.Columns(i).ColumnName)
        Next

        'Remplir la table Inv selon la table inv du mainform et selon les id de la liste qu'on a
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

        'Mettre information de la première ligne de la table client que nous avons créer et remplir plus haut
        TBIDCl.Text = tablecl(0)(0)
        TBPrenom1.Text = tablecl(0)(1)
        TBNom1.Text = tablecl(0)(2)
        TBPrenom2.Text = tablecl(0)(3)
        TBNom2.Text = tablecl(0)(4)
        TBTel1.Text = tablecl(0)(5)
        TBTel2.Text = tablecl(0)(6)
        TBSexe.Text = tablecl(0)(7)
        TBEmail.Text = tablecl(0)(8)

        'Changer la valeur de bool pour que maintenant les changement soit pris en conte et appeler la fonction ChargerInv après
        bool = True
        ChargerInv(DGVManque.Rows(0).Cells(0).Value)

        'on empêche le DataGridView de pouvoir trier les résultats
        DGVManque.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        DGVManque.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    'Mettre les informations d'une ligne de la table inv dans les textes box associer selon l'index recu
    Private Sub ChargerInv(id As Integer)
        For r As Integer = 0 To tableInv.Rows.Count - 1
            If tableInv(r)(0) = id Then
                TBIDInv.Text = tableInv(r)(0)
                TBNomInv.Text = tableInv(r)(1)
                TBQuantite.Text = tableInv(r)(2)
                TBDescription.Text = tableInv(r)(3)
                TBEmplacement.Text = tableInv(r)(4)
                If tableInv(r)(5) = "True" Then
                    CBUtilise.Checked = True
                Else
                    CBUtilise.Checked = False
                End If
                TBCommande.Text = tableInv(r)(6)
                TBMin.Text = tableInv(r)(7)
            End If
        Next


        'Prendre les infos des fournisseur de cette pièce et les mettre dans la table fournisseur pour les faires afficher et
        'être utilisé dans le form
        tableFour.Rows.Clear()
        For r As Integer = 0 To MainForm.tableInvFour.Rows.Count - 1
            If MainForm.tableInvFour.Rows(r).Item("idinventaire") = DGVManque.CurrentRow.Cells(0).Value Then
                For r2 As Integer = 0 To MainForm.tableFour.Rows.Count - 1
                    If MainForm.tableFour.Rows(r2).Item("id") = MainForm.tableInvFour.Rows(r).Item("idfournisseur") Then
                        Dim row As DataRow = tableFour.NewRow
                        For c As Integer = 0 To MainForm.tableFour.Columns.Count - 1
                            row(c) = MainForm.tableFour(r2)(c)
                        Next
                        tableFour.Rows.Add(row)
                    End If
                Next
            End If
        Next

        'Création de la liste avec les noms des fournisseurs qui sont liée à cette pièce d'inventaire, après on mais ces noms dans le
        'combobox
        Dim liste(tableFour.Rows.Count - 1) As String
        For r As Integer = 0 To tableFour.Rows.Count - 1
            liste(r) = tableFour(r)(1)
        Next
        CBFour.DataSource = liste

        RemplirFour(0)
    End Sub

    'Quand on change de ligne dans Le DatGridView  on check si le bool est true pour savoir si on doit faire l'action ou non
    'Après on regarde pour être sur qu'on a bien clicker sur une ligne et après on appel la fonction ChargerInv avec la ligne
    'qu'on a présentement sélectionner
    Private Sub DGVManque_SelectionChanged(sender As Object, e As EventArgs) Handles DGVManque.SelectionChanged
        If bool Then
            If Not IsNothing(DGVManque.CurrentRow) Then
                ChargerInv(DGVManque.CurrentRow.Cells(0).Value)
            End If
        End If
    End Sub

    'Remplir les informations des fournisseur selon l'index recu en argument
    Private Sub RemplirFour(i As Integer)
        TBIDFour.Text = tableFour(i)(0)
        TBNomFour.Text = tableFour(i)(1)
        TBAdresse1.Text = tableFour(i)(2)
        TBAdresse2.Text = tableFour(i)(3)
        TBTelFour.Text = tableFour(i)(4)
        TBNomContacte.Text = tableFour(i)(5)
        TBLeadTime.Text = tableFour(i)(5)
        TBCouriel.Text = tableFour(i)(6)
        TBMethoCom.Text = tableFour(i)(7)
        TBNoCompte.Text = tableFour(i)(8)
        TBMethodePaiement.Text = tableFour(i)(9)

        'Loop pour trouver la ligne correspondante dans la table inventaireFournisseur du mainform et prendre l'information pour la mettre dans les textbox
        For r As Integer = 0 To MainForm.tableInvFour.Rows.Count - 1
            If MainForm.tableInvFour.Rows(r).Item("idinventaire") = DGVManque.CurrentRow.Cells(0).Value And MainForm.tableInvFour.Rows(r).Item("idfournisseur") = tableFour(i)(0) Then
                TBCoutUn.Text = MainForm.tableInvFour(r)(2)
                TBNoFour.Text = MainForm.tableInvFour(r)(3)
                TBNoMFR.Text = MainForm.tableInvFour(r)(4)
                TBDevise.Text = MainForm.tableInvFour(r)(5)
            End If
        Next
    End Sub

    'Quand on change l'index du combobox on appel la fonction remplirFour avec comme paramètre l'index du combobox qui est maintenent sélectionner
    Private Sub CBFour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBFour.SelectedIndexChanged
        RemplirFour(CBFour.SelectedIndex)
    End Sub
End Class