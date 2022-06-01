Public Class ListeFournisseur
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    ReadOnly creerform As creerProduit
    ReadOnly action As Integer
    ReadOnly idInv As String
    ReadOnly idListe() As String


    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________
    Sub New(form As creerProduit, i As Integer)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        creerform = form
        action = i
    End Sub

    Sub New(i As Integer, id As String)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        action = i
        idInv = id
    End Sub

    Sub New(i As Integer, id As String, idListeGet() As String)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        action = i
        idInv = id
        idListe = idListeGet
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________
    Private Sub ListeFournisseur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Regader quel valeur est attrivbuer a action
        If action = 1 Then
            'Si action est 1 on fait juste mettre la table fournisseur du mainform dans le DataGridView
            dgvFour.DataSource = MainForm.tableFour

            For c As Integer = 0 To dgvFour.Columns.Count - 1
                dgvFour.Columns(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
        ElseIf action = 2 Then
            'Si action est 2 on creer une datatable temporaire pour mettre des information spécifique
            Dim table As New DataTable

            'On loop pour mettre tout les titre des Colonnes de la table fournisseur du mainform dans la table temporaire
            For c As Integer = 0 To MainForm.tableFour.Columns.Count - 1
                table.Columns.Add(MainForm.tableFour.Columns(c).ColumnName)
            Next

            'On loop dans la table fournisseur pour prendre l'information qu on a besoin pour la table tempo
            For r As Integer = 0 To MainForm.tableFour.Rows.Count - 1
                Dim bool As Boolean = True
                For i As Integer = 0 To idListe.Length - 1
                    If MainForm.tableFour.Rows(r).Item("id") = idListe(i) Or MainForm.tableFour.Rows(r).Item("id") = 1 Then
                        bool = False
                    End If
                Next
                If bool Then
                    Dim row As DataRow = table.NewRow
                    For c As Integer = 0 To MainForm.tableFour.Columns.Count - 1
                        row(c) = MainForm.tableFour(r)(c)
                    Next
                    table.Rows.Add(row)
                End If
            Next

            'On met la table tempo comme datasource du DataGridView
            dgvFour.DataSource = table

            'Si aucune rangé est mit dans le DataGridView on met un message et ferme le form
            If Not dgvFour.Rows.Count > 0 Then
                MessageBox.Show(MsgTextFr.Getinstance.MsgTousFour)
                Me.Close()
            End If

            For c As Integer = 0 To dgvFour.Columns.Count - 1
                dgvFour.Columns(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
        ElseIf action = 3 Then
            'Si action est 3 on creer une datatable temporaire pour mettre des information spécifique
            Dim table As New DataTable

            'On loop pour mettre tout les titre des Colonnes de la table fournisseur du mainform dans la table temporaire
            For c As Integer = 0 To MainForm.tableFour.Columns.Count - 1
                table.Columns.Add(MainForm.tableFour.Columns(c).ColumnName)
            Next
            'On loop pour mettre tout les titre des Colonnes de la table fournisseurInventaire du mainform dans la table temporaire
            For c As Integer = 0 To (MainForm.tableInvFour.Columns.Count - 1)
                table.Columns.Add(MainForm.tableInvFour.Columns(c).ColumnName)
            Next

            'On loop dans la table fournisseur et fournisseurInventaire pour prendre l'information qu on a besoin pour la table tempo
            For r As Integer = 0 To MainForm.tableFour.Rows.Count - 1
                For r2 As Integer = 0 To MainForm.tableInvFour.Rows.Count - 1
                    If MainForm.tableFour.Rows(r).Item("id") = MainForm.tableInvFour.Rows(r2).Item("idfournisseur") Then
                        If MainForm.tableInvFour.Rows(r2).Item("idInventaire") = idInv And MainForm.tableInvFour.Rows(r2).Item("idfournisseur") <> 1 Then
                            Dim row As DataRow = table.NewRow
                            Dim nbr As Integer = 0
                            For c As Integer = 0 To MainForm.tableFour.Columns.Count - 1
                                row(c) = MainForm.tableFour(r)(c)
                                nbr += 1
                            Next
                            For c As Integer = 0 To MainForm.tableInvFour.Columns.Count - 1
                                row(c + nbr) = MainForm.tableInvFour(r2)(c)
                            Next
                            table.Rows.Add(row)
                        End If
                    End If
                Next
            Next

            'On met la table tempo comme datasource du DataGridView
            dgvFour.DataSource = table

            'Si aucune rangé est mit dans le DataGridView on met un message et ferme le form
            If Not dgvFour.Rows.Count > 0 Then
                MessageBox.Show(MsgTextFr.Getinstance.MsgAucunFour)
                Me.Close()
            End If

            For c As Integer = 0 To dgvFour.Columns.Count - 1
                dgvFour.Columns(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
        End If
    End Sub


    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________
    Private Sub DgvFour_DoubleClick(sender As Object, e As EventArgs) Handles dgvFour.DoubleClick
        'Regarder quelle valeur est associer a action quand on double clock sur un élément
        If action = 1 Then
            'Si action est 1 on appel la fonction SetFournisseur du form CreerProduit avec le nom du fournisseur et on ferme le forme après
            creerform.SetFournisseur(dgvFour.CurrentRow.Cells(1).Value)
            Me.Close()
        ElseIf action = 2 Then
            'Si action est 2 on créer une liste avec les info du fournisseur pour l'ajouter dans la base de données sur le seurveur
            Dim liste() As String = {idInv, dgvFour.CurrentRow.Cells(0).Value}
            If ConnectionServeur.Getinstance.AddDelete(liste, "addInvFour") Then
                'Si l'enregistrement sur le serveur c'est fait sans erreure un écrit un message et on créer une ligne pour
                'l'ajouter dans la table InventaireFournisseur du mainform
                MessageBox.Show(MsgTextFr.Getinstance.MsgSauvServ)
                Dim rowadd As DataRow = MainForm.tableInvFour.NewRow
                rowadd(0) = idInv
                rowadd(1) = dgvFour.CurrentRow.Cells(0).Value
                rowadd(2) = 0
                rowadd(3) = "null"
                rowadd(4) = "null"
                rowadd(5) = "CAD"
                MainForm.tableInvFour.Rows.Add(rowadd)

                'On créer une table tempo pour mettre les noms de colonnes de la table inventaire, InventaireFournisseur et fournisseur
                Dim table As New DataTable
                For i As Integer = 0 To MainForm.tableInv.Columns.Count - 1
                    table.Columns.Add(MainForm.tableInv.Columns(i).ColumnName)
                Next
                For i As Integer = 0 To MainForm.tableInvFour.Columns.Count - 1
                    table.Columns.Add(MainForm.tableInvFour.Columns(i).ColumnName)
                Next
                For i As Integer = 0 To MainForm.tableFour.Columns.Count - 1
                    If MainForm.tableFour.Columns(i).ColumnName = "id" Then
                        table.Columns.Add("idFour")
                    Else
                        table.Columns.Add(MainForm.tableFour.Columns(i).ColumnName)
                    End If
                Next

                'Mettre les information dans la table si il on le même id que l'inventaire choisi
                For r As Integer = 0 To MainForm.tableInv.Rows.Count - 1
                    If MainForm.tableInv.Rows(r).Item("id") = idInv Then
                        For r2 As Integer = 0 To MainForm.tableInvFour.Rows.Count - 1
                            If MainForm.tableInv.Rows(r).Item("id") = MainForm.tableInvFour.Rows(r2).Item("idinventaire") Then
                                For r3 As Integer = 0 To MainForm.tableFour.Rows.Count - 1
                                    If MainForm.tableInvFour.Rows(r2).Item("idfournisseur") = MainForm.tableFour.Rows(r3).Item("id") Then
                                        Dim row As DataRow = table.NewRow
                                        Dim nbr As Integer = 0
                                        Dim nbr2 As Integer
                                        For i As Integer = 0 To MainForm.tableInv.Columns.Count - 1
                                            row(i) = MainForm.tableInv(r)(i)
                                            nbr += 1
                                        Next
                                        nbr2 = nbr
                                        For i As Integer = 0 To MainForm.tableInvFour.Columns.Count - 1
                                            row(i + nbr2) = MainForm.tableInvFour(r2)(i)
                                            nbr += 1
                                        Next
                                        For i As Integer = 0 To MainForm.tableFour.Columns.Count - 1
                                            row(i + nbr) = MainForm.tableFour(r3)(i)
                                        Next
                                        table.Rows.Add(row)
                                    End If
                                Next
                            End If
                        Next
                    End If
                Next

                'Regarder la table tempo qu'on a créer pour voir si l'inventaire sélectionné à le fournisseur associé
                '"Pas de fournisseur" si oui on l'enlève
                For i As Integer = 0 To table.Rows.Count - 1
                    If table(i)(9) = 1 Then
                        liste(0) = idInv
                        liste(1) = 1
                        If ConnectionServeur.Getinstance.AddDelete(liste, "delInvFour") Then
                            For r As Integer = MainForm.tableInvFour.Rows.Count - 1 To 0 Step -1
                                'Supprimer la ligne dans la table InventaireFournisseur sur le mainform
                                If MainForm.tableInvFour.Rows(r).Item("idinventaire") = idInv And MainForm.tableInvFour.Rows(r).Item("idfournisseur") = 1 Then
                                    MainForm.tableInvFour.Rows.Remove(MainForm.tableInvFour.Rows(r))
                                End If
                            Next
                        End If
                    End If
                Next
                Me.Close()
            End If
        ElseIf action = 3 Then
            'Si l'action est 3 on créer une liste avec les information du fournisseur et on suuprime se fournisseur sur le serveur
            Dim liste() As String = {idInv, dgvFour.CurrentRow.Cells(0).Value}
            If ConnectionServeur.Getinstance.AddDelete(liste, "delInvFour") Then
                'Si l'enregistrement sur le serveur est réussit on écrit un message et on l'enlève de la table inventaireFournisseur sur le mainform
                MessageBox.Show(MsgTextFr.Getinstance.MsgSupp)
                For i As Integer = 0 To MainForm.tableInvFour.Rows.Count - 1
                    If MainForm.tableInvFour.Rows(i).Item("idinventaire") = idInv And MainForm.tableInvFour.Rows(i).Item("idfournisseur") = dgvFour.CurrentRow.Cells(0).Value Then
                        MainForm.tableInvFour.Rows.RemoveAt(i)
                        i = MainForm.tableInvFour.Rows.Count
                    End If
                Next

                'Créer une table temporaire
                Dim table As New DataTable
                For i As Integer = 0 To MainForm.tableInv.Columns.Count - 1
                    table.Columns.Add(MainForm.tableInv.Columns(i).ColumnName)
                Next
                For i As Integer = 0 To MainForm.tableInvFour.Columns.Count - 1
                    table.Columns.Add(MainForm.tableInvFour.Columns(i).ColumnName)
                Next
                For i As Integer = 0 To MainForm.tableFour.Columns.Count - 1
                    If MainForm.tableFour.Columns(i).ColumnName = "id" Then
                        table.Columns.Add("idFour")
                    Else
                        table.Columns.Add(MainForm.tableFour.Columns(i).ColumnName)
                    End If
                Next

                'On met l'information des ligne qui on un inventaireFournisseur avec le id de l'inventaire choisi
                For r As Integer = 0 To MainForm.tableInv.Rows.Count - 1
                    If MainForm.tableInv.Rows(r).Item("id") = idInv Then
                        For r2 As Integer = 0 To MainForm.tableInvFour.Rows.Count - 1
                            If MainForm.tableInv.Rows(r).Item("id") = MainForm.tableInvFour.Rows(r2).Item("idinventaire") Then
                                For r3 As Integer = 0 To MainForm.tableFour.Rows.Count - 1
                                    If MainForm.tableInvFour.Rows(r2).Item("idfournisseur") = MainForm.tableFour.Rows(r3).Item("id") Then
                                        Dim row As DataRow = table.NewRow
                                        Dim nbr As Integer = 0
                                        Dim nbr2 As Integer
                                        For i As Integer = 0 To MainForm.tableInv.Columns.Count - 1
                                            row(i) = MainForm.tableInv(r)(i)
                                            nbr += 1
                                        Next
                                        nbr2 = nbr
                                        For i As Integer = 0 To MainForm.tableInvFour.Columns.Count - 1
                                            row(i + nbr2) = MainForm.tableInvFour(r2)(i)
                                            nbr += 1
                                        Next
                                        For i As Integer = 0 To MainForm.tableFour.Columns.Count - 1
                                            row(i + nbr) = MainForm.tableFour(r3)(i)
                                        Next
                                        table.Rows.Add(row)
                                    End If
                                Next
                            End If
                        Next
                    End If
                Next

                'Si la table n'a pas de ligne on met une nouvelle ligne sur le serveur avec l'information de Fournisseur "Pas de FOurnisseur"
                If table.Rows.Count = 0 Then
                    liste(0) = idInv
                    liste(1) = 1
                    If ConnectionServeur.Getinstance.AddDelete(liste, "addInvFour") Then
                        Dim row As DataRow = MainForm.tableInvFour.NewRow
                        row(0) = idInv
                        row(1) = 1
                        row(2) = 0
                        row(3) = "null"
                        row(4) = "null"
                        row(5) = "CAD"
                        MainForm.tableInvFour.Rows.Add(row)
                    End If
                End If
                Me.Close()
            Else
                MessageBox.Show(MsgTextFr.Getinstance.MsgErrServ, "Attention!")
            End If
        End If
    End Sub


    '__________________________________________________________________________________________________________
    'Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Set
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Get
    '__________________________________________________________________________________________________________

End Class