Imports System.ComponentModel

Public Class UCGestionModel
    ReadOnly main As MainForm
    Dim listeId() As String
    ReadOnly tableOptionAdd As New DataTable
    Dim OrOpAdd(0, 0) As String
    ReadOnly tableOptionMo As New DataTable
    Dim OrOpMo(0, 0) As String
    ReadOnly tableCouleurAdd As New DataTable
    Dim OrCoulAdd(0, 0) As String
    ReadOnly tableCouleurMo As New DataTable
    Dim OrCoulMo(0, 0) As String
    Dim listeOpMo() As String
    Dim listeOpDispo() As String
    Dim listeCoulMo() As String
    Dim listeCoulDispo() As String
    Dim nbrOp As Integer
    Dim nbrCoul As Integer

    Sub New(mainform As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = mainform
    End Sub

    Private Sub UCGestionVehicule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Mettre les nom de colonnes dans les table
        tableOptionMo.Columns.Add("ID")
        tableOptionMo.Columns.Add("Nom")
        tableOptionMo.Columns.Add("Coût")
        tableOptionAdd.Columns.Add("ID")
        tableOptionAdd.Columns.Add("Nom")
        tableOptionAdd.Columns.Add("Coût")
        tableCouleurMo.Columns.Add("ID")
        tableCouleurMo.Columns.Add("Nom")
        tableCouleurMo.Columns.Add("Code")
        tableCouleurMo.Columns.Add("Coût")
        tableCouleurAdd.Columns.Add("ID")
        tableCouleurAdd.Columns.Add("Nom")
        tableCouleurAdd.Columns.Add("Code")
        tableCouleurAdd.Columns.Add("Coût")

        RemplirModel()
    End Sub

    Private Sub Remplir(id As String)
        'Mettre que si a rien
        If MainForm.tableModel.Rows.Count <> 0 Then
            NUDCout.Value = MainForm.tableModel(cbModel.SelectedIndex)(2)
        End If

        'Clearer les tables pour pus qu'ils y aient de lignes
        tableOptionMo.Clear()
        tableOptionAdd.Clear()
        tableCouleurMo.Clear()
        tableCouleurAdd.Clear()

        'loop pour mettre les information dans la tableOptionModel avec les info de la tableOption du mainform
        For r As Integer = 0 To MainForm.tableOp.Rows.Count - 1
            For r2 As Integer = 0 To MainForm.tableOpMo.Rows.Count - 1
                If MainForm.tableOp.Rows(r).Item("id") = MainForm.tableOpMo.Rows(r2).Item("idoption") And MainForm.tableOpMo.Rows(r2).Item("idmodel") = id Then
                    Dim row As DataRow = tableOptionMo.NewRow
                    row(0) = MainForm.tableOp.Rows(r).Item("id")
                    row(1) = MainForm.tableOp.Rows(r).Item("nom")
                    row(2) = MainForm.tableOp.Rows(r).Item("cout")
                    tableOptionMo.Rows.Add(row)
                End If
            Next
        Next

        'Remplir la listeOriginal de Option Model
        ReDim OrOpMo(tableOptionMo.Rows.Count - 1, tableOptionMo.Columns.Count - 1)
        ListeOr(OrOpMo, tableOptionMo)
        dgvOptionMo.DataSource = tableOptionMo
        listeOpMo = PopulateList(tableOptionMo)
        nbrOp = listeOpMo.Length

        Dim liste(dgvOptionMo.Rows.Count - 1) As String
        For i As Integer = 0 To liste.Count - 1
            liste(i) = dgvOptionMo.Rows(i).Cells(0).Value
        Next

        'loop pour remplir la tableOptionAdd avec les infos de la tableOPtion du mainform qui n'est pas déja dans la tableOptionModel
        For r As Integer = 0 To MainForm.tableOp.Rows.Count - 1
            Dim bool As Boolean = True
            For i As Integer = 0 To liste.Length() - 1
                If MainForm.tableOp.Rows(r).Item("id") = 0 Or MainForm.tableOp.Rows(r).Item("id") = liste(i) Then
                    bool = False
                End If
            Next
            If MainForm.tableOp.Rows(r).Item("deleteopt") = "False" Then
                bool = False
            End If
            If bool Then
                Dim row As DataRow = tableOptionAdd.NewRow
                row(0) = MainForm.tableOp.Rows(r).Item("id")
                row(1) = MainForm.tableOp.Rows(r).Item("nom")
                row(2) = MainForm.tableOp.Rows(r).Item("cout")
                tableOptionAdd.Rows.Add(row)
            End If
        Next

        'Remplir la listeOriginal OptionAdd
        ReDim OrOpAdd(tableOptionAdd.Rows.Count - 1, tableOptionAdd.Columns.Count - 1)
        ListeOr(OrOpAdd, tableOptionAdd)
        dgvOptionAjout.DataSource = tableOptionAdd
        listeOpDispo = PopulateList(tableOptionAdd)

        'loop pour remplir la table CoulMo avec les info de la tableCoulVe de Mainform
        For r As Integer = 0 To MainForm.tableCoulVe.Rows.Count - 1
            For r2 As Integer = 0 To MainForm.tableCoulMo.Rows.Count - 1
                If MainForm.tableCoulVe.Rows(r).Item("id") = MainForm.tableCoulMo.Rows(r2).Item("idcouleur") Then
                    If MainForm.tableCoulMo.Rows(r2).Item("idmodel") = id Then
                        Dim row As DataRow = tableCouleurMo.NewRow
                        row(0) = MainForm.tableCoulVe.Rows(r).Item("id")
                        row(1) = MainForm.tableCoulVe.Rows(r).Item("nom")
                        row(2) = MainForm.tableCoulVe.Rows(r).Item("code")
                        row(3) = MainForm.tableCoulVe.Rows(r).Item("cout")
                        tableCouleurMo.Rows.Add(row)
                    End If
                End If
            Next
        Next

        'Remplir la liste original COuleurModel
        ReDim OrCoulMo(tableCouleurMo.Rows.Count - 1, tableCouleurMo.Columns.Count - 1)
        ListeOr(OrCoulMo, tableCouleurMo)
        dgvCoulMo.DataSource = tableCouleurMo
        listeCoulMo = PopulateList(tableCouleurMo)
        nbrCoul = listeCoulMo.Length

        ReDim liste(dgvCoulMo.Rows.Count - 1)
        For i As Integer = 0 To liste.Count - 1
            liste(i) = dgvCoulMo.Rows(i).Cells(0).Value
        Next

        'loop pour mettre information de tableCoulVe du mainform, qui n'est pas déja dans la tableCoulMo, dans la tableCoulAdd
        For r As Integer = 0 To MainForm.tableCoulVe.Rows.Count - 1
            Dim bool As Boolean = True
            For i As Integer = 0 To liste.Length() - 1
                If MainForm.tableCoulVe.Rows(r).Item("id") = 0 Or MainForm.tableCoulVe.Rows(r).Item("id") = liste(i) Then
                    bool = False
                End If
            Next
            If MainForm.tableCoulVe.Rows(r).Item("deletecoul") = "False" Then
                bool = False
            End If
            If bool Then
                Dim row As DataRow = tableCouleurAdd.NewRow
                row(0) = MainForm.tableCoulVe.Rows(r).Item("id")
                row(1) = MainForm.tableCoulVe.Rows(r).Item("nom")
                row(2) = MainForm.tableCoulVe.Rows(r).Item("code")
                row(3) = MainForm.tableCoulVe.Rows(r).Item("cout")
                tableCouleurAdd.Rows.Add(row)
            End If
        Next

        'Remplir la listeOriginal CoulAdd
        ReDim OrCoulAdd(tableCouleurAdd.Rows.Count - 1, tableCouleurAdd.Columns.Count - 1)
        ListeOr(OrCoulAdd, tableCouleurAdd)
        dgvCoulAjout.DataSource = tableCouleurAdd
        listeCoulDispo = PopulateList(tableCouleurAdd)
    End Sub

    'Quand on change le model dans le combobox on appel la fonction remplir pour changer les options et couleurs pour l'autre model
    Private Sub CbModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbModel.SelectedIndexChanged
        Remplir(MainForm.tableModel.Rows(cbModel.SelectedIndex).Item("id"))
    End Sub

    'Quand on double click sur une ligne du DataGridView on appel la fonction PopulateRow
    Private Sub DgvOptionMo_DoubleClick(sender As Object, e As EventArgs) Handles dgvOptionMo.DoubleClick
        PopulateRow(tableOptionAdd, dgvOptionMo, dgvOptionAjout)
    End Sub

    'Quand on double click sur une ligne du DataGridView on appel la fonction PopulateRow
    Private Sub DgvOptionAjout_DoubleClick(sender As Object, e As EventArgs) Handles dgvOptionAjout.DoubleClick
        PopulateRow(tableOptionMo, dgvOptionAjout, dgvOptionMo)
    End Sub

    'Quand on double click sur une ligne du DataGridView on appel la fonction PopulateRow
    Private Sub DgvCoulMo_DoubleClick(sender As Object, e As EventArgs) Handles dgvCoulMo.DoubleClick
        PopulateRow(tableCouleurAdd, dgvCoulMo, dgvCoulAjout)
    End Sub

    'Quand on double click sur une ligne du DataGridView on appel la fonction PopulateRow
    Private Sub DgvCoulAjout_DoubleClick(sender As Object, e As EventArgs) Handles dgvCoulAjout.DoubleClick
        PopulateRow(tableCouleurMo, dgvCoulAjout, dgvCoulMo)
    End Sub

    'Fonction qui permet d'envoyer une ligne d'un DataGridView à un autre DataGridView
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

    'Fonction qui sert a prendre une table et créer une liste des ID de cette table et retourne la liste
    Public Function PopulateList(table As DataTable) As String()
        Dim list(table.Rows.Count - 1) As String
        For i As Integer = 0 To table.Rows.Count - 1
            list(i) = table(i)(0)
        Next
        Return list
    End Function

    'FOnction qui sert a regarder si a des différence entre les listes original et les tables et de mettre les bouton fonctionnel ou non
    Public Sub CheckChange()
        Dim change As Boolean = CheckFor(listeOpMo, tableOptionMo, nbrOp)

        If Not change Then
            change = CheckFor(listeCoulMo, tableCouleurMo, nbrCoul)
        End If

        BtEnregistrer.Enabled = change
        BtAnnuler.Enabled = change
    End Sub

    'Fonction qui compare la liste avec la table et retourne un boolean 
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

    'QUand on click sur ce bouton on envoie les informations des tables CoulModel et OptionModel pour enregistrer les changements
    Private Sub BtEnregistrer_Click(sender As Object, e As EventArgs) Handles BtEnregistrer.Click
        Dim listeAjout() As String = CreateListeAdd(listeOpMo, dgvOptionMo)
        Dim bool1 As Boolean = False
        Dim bool2 As Boolean = False

        'On regarde si la liste est vide pour savoir si on doit enregistrer ou non
        If Not IsNothing(listeAjout) Then
            If ConnectionServeur.Getinstance.AddDelete(listeAjout, listeId(cbModel.SelectedIndex), "AddOpMo") Then
                'loop pour ajouter toute les options qui on été mit dans la liste
                For i As Integer = 0 To listeAjout.Length - 1
                    Dim row As DataRow = MainForm.tableOpMo.NewRow
                    row(0) = listeAjout(i)
                    row(1) = listeId(cbModel.SelectedIndex)
                    MainForm.tableOpMo.Rows.Add(row)
                Next

                listeAjout = CreateListeAdd(listeOpDispo, dgvOptionAjout)
                'on regarde la deuxieme liste pour voir si on doit supprimer ou non
                If Not IsNothing(listeAjout) Then
                    If ConnectionServeur.Getinstance.AddDelete(listeAjout, listeId(cbModel.SelectedIndex), "DeleteOpMo") Then
                        'Loop pour passer toutes les index de la listeajout et un deuxieme loop pour passé toutes les lignes de la tableOpMo
                        'du Mainform et enlever la ligne si elle est trouver
                        For i As Integer = 0 To listeAjout.Length - 1
                            Dim row As DataRow
                            For r As Integer = 0 To MainForm.tableOpMo.Rows.Count - 1
                                If MainForm.tableOpMo.Rows(r).Item("idoption") = listeAjout(i) And MainForm.tableOpMo.Rows(r).Item("idModel") = listeId(cbModel.SelectedIndex) Then
                                    row = MainForm.tableOpMo.Rows(r)
                                End If
                            Next
                            MainForm.tableOpMo.Rows.Remove(row)
                        Next

                        bool1 = True
                    End If
                Else
                    bool1 = True
                End If
            End If
        Else
            listeAjout = CreateListeAdd(listeOpDispo, dgvOptionAjout)
            'on regarde la deuxieme liste pour voir si on doit supprimer ou non
            If Not IsNothing(listeAjout) Then
                If ConnectionServeur.Getinstance.AddDelete(listeAjout, listeId(cbModel.SelectedIndex), "DeleteOpMo") Then
                    'Loop pour passer toutes les index de la listeajout et un deuxieme loop pour passé toutes les lignes de la tableOpMo
                    'du Mainform et enlever la ligne si elle est trouver
                    For i As Integer = 0 To listeAjout.Length - 1
                        Dim row As DataRow
                        For r As Integer = 0 To MainForm.tableOpMo.Rows.Count - 1
                            If MainForm.tableOpMo.Rows(r).Item("idoption") = listeAjout(i) And MainForm.tableOpMo.Rows(r).Item("idModel") = listeId(cbModel.SelectedIndex) Then
                                row = MainForm.tableOpMo.Rows(r)
                            End If
                        Next
                        MainForm.tableOpMo.Rows.Remove(row)
                    Next

                    bool1 = True
                End If
            Else
                bool1 = True
            End If
        End If



        listeAjout = CreateListeAdd(listeCoulMo, dgvCoulMo)
        'on regarde si la liste est sinon on enregistrer l'autre table sur le serveur
        If Not IsNothing(listeAjout) Then
            If ConnectionServeur.Getinstance.AddDelete(listeAjout, listeId(cbModel.SelectedIndex), "AddCoulMo") Then
                'loop pour ajouter toute les couleur qui on été mit dans la liste
                For i As Integer = 0 To listeAjout.Length - 1
                    Dim row As DataRow = MainForm.tableCoulMo.NewRow
                    row(0) = listeAjout(i)
                    row(1) = listeId(cbModel.SelectedIndex)
                    MainForm.tableOpMo.Rows.Add(row)
                Next

                listeAjout = CreateListeAdd(listeCoulDispo, dgvCoulAjout)
                'on regarde la deuxieme liste pour voir si on doit supprimer ou non
                If Not IsNothing(listeAjout) Then
                    If ConnectionServeur.Getinstance.AddDelete(listeAjout, listeId(cbModel.SelectedIndex), "DeleteCoulMo") Then
                        'Loop pour passer toutes les index de la listeajout et un deuxieme loop pour passé toutes les lignes de la tableCoulMo
                        'du Mainform et enlever la ligne si elle est trouver
                        For i As Integer = 0 To listeAjout.Length - 1
                            Dim row As DataRow
                            For r As Integer = 0 To MainForm.tableCoulMo.Rows.Count - 1
                                If MainForm.tableCoulMo.Rows(r).Item("idcouleur") = listeAjout(i) And MainForm.tableCoulMo.Rows(r).Item("idModel") = listeId(cbModel.SelectedIndex) Then
                                    row = MainForm.tableCoulMo.Rows(r)
                                End If
                            Next
                            MainForm.tableCoulMo.Rows.Remove(row)
                        Next

                        bool2 = True
                    End If
                Else
                    bool2 = True
                End If
            End If
        Else
            listeAjout = CreateListeAdd(listeCoulDispo, dgvCoulAjout)
            'on regarde la deuxieme liste pour voir si on doit supprimer ou non
            If Not IsNothing(listeAjout) Then
                If ConnectionServeur.Getinstance.AddDelete(listeAjout, listeId(cbModel.SelectedIndex), "DeleteCoulMo") Then
                    'Loop pour passer toutes les index de la listeajout et un deuxieme loop pour passé toutes les lignes de la tableCoulMo
                    'du Mainform et enlever la ligne si elle est trouver
                    For i As Integer = 0 To listeAjout.Length - 1
                        Dim row As DataRow
                        For r As Integer = 0 To MainForm.tableCoulMo.Rows.Count - 1
                            If MainForm.tableCoulMo.Rows(r).Item("idcouleur") = listeAjout(i) And MainForm.tableCoulMo.Rows(r).Item("idModel") = listeId(cbModel.SelectedIndex) Then
                                row = MainForm.tableCoulMo.Rows(r)
                            End If
                        Next
                        MainForm.tableCoulMo.Rows.Remove(row)
                    Next

                    bool2 = True
                End If
            Else
                bool2 = True
            End If
        End If

        'SI l'enregistrement c'est effectuer correctment, on change les toutes les listeOriginal pour leur nouvelle valeur
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

    'Fonction qui sert à créer une liste des différence entre les listes originals et des tables actuels et on retourne cette liste
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

    'Si on click sur ce bouton, on appel la fonction annuler changement pour table
    Private Sub BtAnnuler_Click(sender As Object, e As EventArgs) Handles BtAnnuler.Click
        AnnulerChangement(OrOpMo, tableOptionMo)
        AnnulerChangement(OrOpAdd, tableOptionAdd)
        AnnulerChangement(OrCoulMo, tableCouleurMo)
        AnnulerChangement(OrCoulAdd, tableCouleurAdd)
    End Sub

    'Fonction qui resoit la listeOriginal et la table qui vont ensemble et remet les infomtions de la liste original dans la table
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

    'Fonction qui sert à mettre les information de la table dans la listeOriginal pour changer la listeOriginal
    Public Sub ListeOr(liste(,) As String, table As DataTable)
        For r As Integer = 0 To table.Rows.Count - 1
            For c As Integer = 0 To table.Columns.Count - 1
                liste(r, c) = table(r)(c)
            Next
        Next
    End Sub

    'Si on appuie sur ce bouton, on créer un nouveau form de type CreerModel
    Private Sub BtCreer_Click(sender As Object, e As EventArgs) Handles btCreer.Click
        Dim creer As New CreerModel(Me)
        creer.ShowDialog()
    End Sub

    'Fonction qui sert a prendre les info des model de la tableModel du Mainform pour créer une liste qui est utilisé comme source pour le combobox
    Public Sub RemplirModel()
        Dim liste(MainForm.tableModel.Rows.Count - 1) As String
        ReDim listeId(MainForm.tableModel.Rows.Count - 1)
        For i As Integer = 0 To MainForm.tableModel.Rows.Count - 1
            liste(i) = MainForm.tableModel(i)(1)
            listeId(i) = MainForm.tableModel(i)(0)
        Next
        cbModel.DataSource = liste
        Remplir(1)
    End Sub

    'Si on appuie sur ce bouton, on créer un nouveau form de type GestionInvModel avec comme argument le id du model
    Private Sub BtInv_Click(sender As Object, e As EventArgs) Handles btInv.Click
        Dim uc As New GestionInvModel(listeId(cbModel.SelectedIndex), Me)
        uc.ShowDialog()
    End Sub

    'Si on appuie sur une touche du NumericUpDown on check quel touche est appuier et on réagie selon la touche
    Private Sub NUDCout_KeyDown(sender As Object, e As KeyEventArgs) Handles NUDCout.KeyDown
        Dim lang = Globalization.CultureInfo.CurrentCulture
        MessageBox.Show(lang.ToString)
        If e.KeyCode = 110 Or e.KeyCode = 190 Then
            e.SuppressKeyPress = True
            SendKeys.Send(",")
        End If
    End Sub

    'Si on click sur le UserCOntrol, on check si le menu du mainform est bien fermer
    Private Sub UCGestionModel_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub
End Class
