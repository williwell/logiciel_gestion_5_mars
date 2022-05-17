Public Class UCFournisseur
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    ReadOnly main As MainForm
    ReadOnly ucInv As UCInventaire
    ReadOnly table As New DataTable
    ReadOnly liste(10) As String


    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________
    Sub New(mainFo As MainForm, ucI As UCInventaire)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = mainFo
        ucInv = ucI
    End Sub


    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________
    Private Sub UCFournisseur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On créer les colonnes pour la table
        For i As Integer = 0 To MainForm.tableFour.Columns.Count - 1
            table.Columns.Add(MainForm.tableFour.Columns(i).ColumnName)
        Next

        'On met le datasource du datagridview avec la tableFour du mainform
        dgvFour.DataSource = MainForm.tableFour
        LoadFour()

        For c As Integer = 0 To dgvFour.Columns.Count - 1
            dgvFour.Columns(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next

        For c As Integer = 0 To dgvPiece.Columns.Count - 1
            dgvPiece.Columns(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    'SI on double click sur une ligne dans le DataGridView du Fournisseur on change le TextBox id pour mettre le id de la ligne clicker
    Private Sub DgvFour_DoubleClick(sender As Object, e As EventArgs) Handles dgvFour.Click
        tbID.Text = dgvFour.CurrentRow.Cells(0).Value
        If tbID.Text = "1" Then
            BTDelete.Enabled = False
        Else
            BTDelete.Enabled = True
        End If
    End Sub

    'Quand on change le texte du TextBox ID on va chercher l'information
    Private Sub TbID_TextChanged(sender As Object, e As EventArgs) Handles tbID.TextChanged
        'On clear la table de toutes les lignes
        table.Clear()

        'On rempli la table avec les information nécessaire
        For r As Integer = 0 To MainForm.tableFour.Rows.Count - 1
            If MainForm.tableFour.Rows(r).Item("id") = tbID.Text Then
                Dim row As DataRow = table.NewRow
                For c As Integer = 0 To MainForm.tableFour.Columns.Count - 1
                    row(c) = MainForm.tableFour(r)(c)
                Next
                table.Rows.Add(row)
            End If
        Next

        Remplir(table)

        'Création nouvelle table temporaire
        Dim tableInv As New DataTable

        'Ajouter les colonnes de la table Inv du mainform et quelque autre nom de colonne
        For c As Integer = 0 To MainForm.tableInv.Columns.Count - 1
            tableInv.Columns.Add(MainForm.tableInv.Columns(c).ColumnName)
        Next
        tableInv.Columns.Add("Coût Unitaire")
        tableInv.Columns.Add("Numéro Fournisseur")
        tableInv.Columns.Add("Numéro MFR")
        tableInv.Columns.Add("Devise")

        'Loop pour mettre l'information de l'inventaire qui est relier avec le fournissuer qui est présentement choisi
        For r As Integer = 0 To MainForm.tableInv.Rows.Count - 1
            For r2 As Integer = 0 To MainForm.tableInvFour.Rows.Count - 1
                If MainForm.tableInv.Rows(r).Item("id") = MainForm.tableInvFour.Rows(r2).Item("idinventaire") And MainForm.tableInvFour.Rows(r2).Item("idfournisseur") = tbID.Text Then
                    Dim row As DataRow = tableInv.NewRow
                    For c As Integer = 0 To MainForm.tableInv.Columns.Count - 1
                        row(c) = MainForm.tableInv(r)(c)
                    Next
                    For c As Integer = 0 To MainForm.tableInvFour.Columns.Count - 3
                        row(MainForm.tableInv.Columns.Count + c) = MainForm.tableInvFour(r2)(c + 2)
                    Next
                    tableInv.Rows.Add(row)
                End If
            Next
        Next

        'Associer la table avec le DataGridView pièce
        dgvPiece.DataSource = tableInv
    End Sub

    'Si on double click sur une ligne dans le DataGridView pièce, on fait afficher le UserControl Inventaire avec les informations de cette pièce
    Private Sub DgvPiece_DoubleClick(sender As Object, e As EventArgs) Handles dgvPiece.DoubleClick
        If dgvPiece.CurrentRow IsNot Nothing Then
            ucInv.SetIDProduit(dgvPiece.CurrentRow.Cells(0).Value)
            main.ShowInventaire()
        End If
    End Sub

    'Fonction qui sert a mettre l'information qu'on resoit dans les TextBox
    Private Sub Remplir(table As DataTable)
        Try
            If table(0)(0) = 1 Then
                ChangeEnable(False)
            Else
                ChangeEnable(True)
            End If
            liste(0) = table(0)(0)
            tbNomFour.Text = table(0)(1)
            tbAdres1.Text = table(0)(2)
            tbAdres2.Text = table(0)(3)
            tbTel.Text = table(0)(4)
            tbNomCont.Text = table(0)(5)
            tbLeadTime.Text = table(0)(6)
            tbAddCour.Text = table(0)(7)
            tbMethodeCom.Text = table(0)(8)
            tbNoCompte.Text = table(0)(9)
            tbMethodePaie.Text = table(0)(10)
        Catch ex As Exception
            MessageBox.Show("Un erreure est survenu avec le serveur!")
            main.Fermer()
        End Try
    End Sub

    'Fonction qui sert a changer les TextBox pour qui puisse être modifier ounon
    Private Sub ChangeEnable(bool As Boolean)
        tbNomFour.Enabled = bool
        tbAdres1.Enabled = bool
        tbAdres2.Enabled = bool
        tbTel.Enabled = bool
        tbNomCont.Enabled = bool
        tbLeadTime.Enabled = bool
        tbAddCour.Enabled = bool
        tbMethodeCom.Enabled = bool
        tbNoCompte.Enabled = bool
        tbMethodePaie.Enabled = bool
    End Sub

    'Si on click sur ce bouton on envoie au serveur une liste avec toutes les informations de la liste qui contient toute l'information
    'des textbox pour modifier dans la base de donnée
    Private Sub BtSauv_Click(sender As Object, e As EventArgs) Handles btSauv.Click
        If ConnectionServeur.Getinstance.AddDelete(liste, "modFour") Then
            MessageBox.Show("La modification c'est fait sans problème")
            'loop qui sert a mettre a jour les informations dans la table vu qu'il on été modifier dans des textbox
            For i As Integer = 1 To liste.Length - 1
                table(0)(i) = liste(i)
                dgvFour.CurrentRow.Cells(i).Value = liste(i)
            Next
            'loop pour trouver la ligne dans la tableFour du Mainform et le id qui est dans la liste
            For r As Integer = 0 To MainForm.tableFour.Rows.Count - 1
                If MainForm.tableFour.Rows(r).Item("id") = liste(0) Then
                    'loop pour passé toutes les colonnes pour changer les données dans la tableFour du Mainform
                    For c As Integer = 1 To MainForm.tableFour.Columns.Count - 1
                        MainForm.tableFour(r)(c) = liste(c)
                    Next
                End If
            Next
            BtSauvChanger()
        Else
            MessageBox.Show("Un erreur est survenu du coté du serveur!")
        End If
    End Sub

    'Si on appuie sur une touche dans le textbox téléphone on vérifie quel est le code de cette touche pour savoir ce si on doit le supprimer
    Private Sub TbTel_KeyDown(sender As Object, e As KeyEventArgs) Handles tbTel.KeyDown
        If Not (e.KeyCode = Keys.Back OrElse e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Left OrElse e.KeyCode = Keys.Right) Then
            If Not ((e.KeyCode >= 96 AndAlso e.KeyCode <= 105) OrElse (e.KeyCode >= 48 AndAlso e.KeyCode <= 57)) Then
                e.SuppressKeyPress = True
            End If
        End If
    End Sub

    'Si on click sur ce bouton on remplit les informations des textbox avec les information qu'on avait avant les changements
    Private Sub BtAnnuler_Click(sender As Object, e As EventArgs) Handles btAnnuler.Click
        Remplir(table)
    End Sub

    'Si on click sur se bouton, on crée un nouveau form de type CreerFour et on le fait afficher
    Private Sub BtCreerFour_Click(sender As Object, e As EventArgs) Handles btCreerFour.Click
        Dim creer As New CreerFour(Me)
        creer.ShowDialog(Me)
    End Sub

    'Fonction qui sert a attendre un peu après un ajout dans la base de donné et on change le textbox id pour refaire changer les informations
    '(Le temps d'attente est un teste, car, la version publier qui est utilisé, des fois lors d'ajout de fournisseur une erreure nous est dit
    'comme quoi l'ajout n'a pas réussit mais du côté du serveur aucune problème ne survient et envoye comme information réussit. Donc je fais
    'un peu de teste pour essayer de trouver le problème qui survient)
    Public Sub LoadFour()
        Threading.Thread.Sleep(500)
        tbID.Text = dgvFour.CurrentRow.Cells(0).Value
    End Sub

    '__________________________________________________________________________________________________________
    'Functions
    '__________________________________________________________________________________________________________

    'Fonction qui sert a vérifier si on doit activer ou non le bouton sauvegarder
    Private Sub BtSauvChanger()
        Dim modif As Boolean = False
        For i As Integer = 1 To table.Columns.Count - 1
            If Not Convert.ToString(table(0)(i)) = liste(i) Then
                modif = True
            End If
        Next

        btSauv.Enabled = modif
        btAnnuler.Enabled = modif
    End Sub


    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________

    'Quand on change le texte on modifie la liste
    Private Sub TbNomFour_TextChanged(sender As Object, e As EventArgs) Handles tbNomFour.TextChanged
        liste(1) = tbNomFour.Text
        BtSauvChanger()
    End Sub

    'Quand on change le texte on modifie la liste
    Private Sub TbAdres1_TextChanged(sender As Object, e As EventArgs) Handles tbAdres1.TextChanged
        liste(2) = tbAdres1.Text
        BtSauvChanger()
    End Sub

    'Quand on change le texte on modifie la liste
    Private Sub TbAdres2_TextChanged(sender As Object, e As EventArgs) Handles tbAdres2.TextChanged
        liste(3) = tbAdres2.Text
        BtSauvChanger()
    End Sub

    'Quand on change le texte on modifie la liste
    Private Sub TbTel_TextChanged(sender As Object, e As EventArgs) Handles tbTel.TextChanged
        liste(4) = tbTel.Text
        BtSauvChanger()
    End Sub

    'Quand on change le texte on modifie la liste
    Private Sub TbNomCont_TextChanged(sender As Object, e As EventArgs) Handles tbNomCont.TextChanged
        liste(5) = tbNomCont.Text
        BtSauvChanger()
    End Sub

    'Quand on change le texte on modifie la liste
    Private Sub TbLeadTime_TextChanged(sender As Object, e As EventArgs) Handles tbLeadTime.TextChanged
        liste(6) = tbLeadTime.Text
        BtSauvChanger()
    End Sub

    'Quand on change le texte on modifie la liste
    Private Sub TbAddCour_TextChanged(sender As Object, e As EventArgs) Handles tbAddCour.TextChanged
        liste(7) = tbAddCour.Text
        BtSauvChanger()
    End Sub

    'Quand on change le texte on modifie la liste
    Private Sub TbMethodeCom_TextChanged(sender As Object, e As EventArgs) Handles tbMethodeCom.TextChanged
        liste(8) = tbMethodeCom.Text
        BtSauvChanger()
    End Sub

    'Quand on change le texte on modifie la liste
    Private Sub TbNoCompte_TextChanged(sender As Object, e As EventArgs) Handles tbNoCompte.TextChanged
        liste(9) = tbNoCompte.Text
        BtSauvChanger()
    End Sub

    'Quand on change le texte on modifie la liste
    Private Sub TbMethodePaie_TextChanged(sender As Object, e As EventArgs) Handles tbMethodePaie.TextChanged
        liste(10) = tbMethodePaie.Text
        BtSauvChanger()
    End Sub

    'Quand on change le texte on modifie la liste
    Private Sub UCFournisseur_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.FermerMenu()
    End Sub

    'Quand on appuie sur le bouton, on demande à l'utilisateur deux fois de suite si il veut vraiment supprimer ce fournisseur si oui on le
    'supprime définitivement du serveur et toute se qui y ai associé
    Private Sub BTDelete_Click(sender As Object, e As EventArgs) Handles BTDelete.Click
        If MessageBox.Show("Voulez-vous vraiment supprimer ce fournisseur: " & dgvFour.CurrentRow.Cells(0).Value & " - " & dgvFour.CurrentRow.Cells(1).Value & "? (Cette action est irréversible)", "Attention!", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If MessageBox.Show("Êtes-vous sûr que vous voulez vraiment le supprimer: " & dgvFour.CurrentRow.Cells(0).Value & " - " & dgvFour.CurrentRow.Cells(1).Value & "? (Cette action est irréversible)", "Attention!", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                If ConnectionServeur.Getinstance.AddDelete(dgvFour.CurrentRow.Cells(0).Value, "DeleteInvFourFour") Then
                    'On loop pour trouver toute les lignes qui ont une connection avec ce fournisseur dans la table fourinv et les supprimer
                    'ON créer aussi une liste avec les id des inventaire qui sont lier au fournisseur qu'on supprime
                    Dim liste(-1) As String
                    Dim nbr As Integer = 0
                    For r As Integer = MainForm.tableInvFour.Rows.Count - 1 To 0 Step -1
                        If MainForm.tableInvFour.Rows(r).Item("idfournisseur") = dgvFour.CurrentRow.Cells(0).Value Then
                            ReDim Preserve liste(nbr)
                            liste(nbr) = MainForm.tableInvFour.Rows(r).Item("idinventaire")
                            nbr += 1
                            MainForm.tableInvFour.Rows.RemoveAt(r)
                        End If
                    Next

                    If liste.Length > 0 Then
                        'On envoie la liste au serveur pour qu'il vérifie si il doit ajouter des lignes dans la table invfour pour les inventaire qui
                        'n'ont plus de fournisseur
                        If ConnectionServeur.Getinstance.AddDelete(liste, "CheckInvFour") Then

                            'on loop pour trouver si a encore au moin un fournisseur sinon on leur rajoute le fournisseur 0 qui est le
                            ' fournisseur "Pas de fournisseur"
                            For i As Integer = 0 To liste.Length - 1
                                Dim bool As Boolean = True
                                For r As Integer = 0 To MainForm.tableInvFour.Rows.Count - 1
                                    If liste(i) = MainForm.tableInvFour.Rows(r).Item("idinventaire") Then
                                        bool = False
                                    End If
                                Next
                                If bool Then
                                    Dim row As DataRow = MainForm.tableInvFour.NewRow
                                    row(0) = liste(i)
                                    row(1) = 1
                                    row(2) = 0
                                    row(3) = "null"
                                    row(4) = "null"
                                    row(5) = "CAD"
                                    MainForm.tableInvFour.Rows.Add(row)
                                End If
                            Next

                            DeleteFour()
                        Else
                            MessageBox.Show("Une erreure est survenu durant la suppression du fournisseur")
                        End If
                    Else
                        DeleteFour()
                    End If
                Else
                    MessageBox.Show("une erreure est survenu durant la suppression du fournisseur")
                End If
            End If
        End If
    End Sub

    'Fonction qui sert a supprimer un fournisseur dans la base de donnée du serveur
    Private Sub DeleteFour()
        'Suppression du fournisseur sur le serveur
        If ConnectionServeur.Getinstance.AddDelete(dgvFour.CurrentRow.Cells(0).Value, "DeleteFour") Then

            'On loop pour trouver la ligne correspondante dans la table dournisseur du mainform pour supprimer la ligne
            Dim index As Integer = 0
            For r As Integer = 0 To MainForm.tableFour.Rows.Count - 1
                If MainForm.tableFour.Rows(r).Item("id") = dgvFour.CurrentRow.Cells(0).Value Then
                    index = r
                End If
            Next
            If index <> 0 Then
                MainForm.tableFour.Rows.RemoveAt(index)
            End If
            MessageBox.Show("Suppression du fournisseur réussit avec succès")
            Remplir(table)
        Else
            MessageBox.Show("Une erreure est survenu et a empêché la suppression du fournisseur")
        End If
    End Sub

    '__________________________________________________________________________________________________________
    'Set
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Get
    '__________________________________________________________________________________________________________



End Class
