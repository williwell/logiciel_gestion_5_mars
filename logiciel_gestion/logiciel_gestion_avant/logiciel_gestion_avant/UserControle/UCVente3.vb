﻿Public Class UCVente3
    ReadOnly uc As UCVente
    ReadOnly main As MainForm
    Dim idCl As String = 0
    Dim veExist As Boolean = False

    Sub New(ucVente As UCVente, form As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        uc = ucVente
        main = form
    End Sub

    'Quand on click sur ce bouton, on envoie l'information au serveur pour ajouter une vente de véhicule et les info qui vont avec comme
    'les options du véhicule et les info du client
    Private Sub BTSave_Click(sender As Object, e As EventArgs) Handles BTSave.Click
        veExist = False
        If Not String.IsNullOrEmpty(TBPrenom1.Text) Or Not idCl = 0 Then
            If Not String.IsNullOrEmpty(TBNom1.Text) Or Not idCl = 0 Then
                Dim listeAddCl(10) As String
                If idCl = 0 Then
                    listeAddCl(0) = TBPrenom1.Text
                    listeAddCl(1) = TBNom1.Text

                    If String.IsNullOrEmpty(TBPrenom2.Text) Then
                        listeAddCl(2) = "null"
                    Else
                        listeAddCl(2) = TBPrenom2.Text
                    End If

                    If String.IsNullOrEmpty(TBNom2.Text) Then
                        listeAddCl(3) = "null"
                    Else
                        listeAddCl(3) = TBNom2.Text
                    End If

                    If String.IsNullOrEmpty(TBTel1.Text) Then
                        listeAddCl(4) = "null"
                    Else
                        listeAddCl(4) = TBTel1.Text
                    End If

                    If String.IsNullOrEmpty(TBTel2.Text) Then
                        listeAddCl(5) = "null"
                    Else
                        listeAddCl(5) = TBTel2.Text
                    End If

                    listeAddCl(6) = CBSexe.SelectedItem

                    If String.IsNullOrEmpty(TBEmail.Text) Then
                        listeAddCl(7) = "null"
                    Else
                        listeAddCl(7) = TBEmail.Text
                    End If

                    Dim rue As Boolean = String.IsNullOrEmpty(TBRue.Text)
                    Dim ville As Boolean = String.IsNullOrEmpty(TBVille.Text)
                    Dim pro As Boolean = String.IsNullOrEmpty(TBPro.Text)

                    If rue And ville And pro Then
                        listeAddCl(8) = "null"
                    ElseIf Not rue And Not ville And Not pro Then
                        listeAddCl(8) = TBRue.Text & ", " & TBVille.Text & ", " & TBPro.Text
                    Else
                        MessageBox.Show("Vous ne pouvez pas rentrer une adresse partielle!")
                    End If

                    If String.IsNullOrEmpty(TBApp.Text) Then
                        listeAddCl(9) = "null"
                    Else
                        listeAddCl(9) = TBApp.Text
                    End If

                    If String.IsNullOrEmpty(TBPoste.Text) Then
                        listeAddCl(10) = "null"
                    Else
                        listeAddCl(10) = TBPoste.Text
                    End If
                End If

                Dim liste() As String = uc.GetListeAdd
                Dim listeAdd() As String = {liste(0), liste(1), liste(2), liste(3), liste(4)}
                Dim table As DataTable
                Dim id As String = uc.GetID

                If id = 0 Then
                    table = ConnectionServeur.Getinstance.GetInfo(listeAdd, "addVehicule")
                    id = table(0)(0)

                    'Mettre les nouvelles informations du nouveau véhicule dans la table du mainform
                    Dim row As DataRow = MainForm.tableVe.NewRow
                    row(0) = id
                    For i As Integer = 0 To listeAdd.Length + 1
                        If i >= listeAdd.Length Then
                            row(i + 1) = 0
                        Else
                            row(i + 1) = listeAdd(i)
                        End If
                    Next
                    MainForm.tableVe.Rows.Add(row)
                Else
                    For r As Integer = 0 To MainForm.tableVe.Rows.Count - 1
                        If MainForm.tableVe.Rows(r).Item("id") = id Then
                            MainForm.tableVe.Rows(r).Item("eninventaire") = 0
                            Exit For
                        End If
                    Next
                    Dim listeTempo As String() = {id, 0}
                    ConnectionServeur.Getinstance.AddDelete(listeTempo, "livrervehicule")
                    veExist = True
                End If

                If Not id = "null" Then
                    Dim nbr As Integer = 0
                    ReDim listeAdd(nbr)
                    listeAdd(0) = id
                    For i As Integer = 5 To liste.Count - 1
                        nbr += 1
                        ReDim Preserve listeAdd(nbr)
                        listeAdd(nbr) = liste(i)
                    Next
                    If Not IsNothing(liste(5)) Then
                        If ConnectionServeur.Getinstance.AddDelete(listeAdd, "addOpVe") And Not liste.Count - 1 = 6 Then

                            'Loop pour ajouter toute les nouvelles option associé à ce véhicule
                            For i As Integer = 1 To listeAdd.Length - 1
                                Dim row As DataRow = MainForm.tableOpVe.NewRow
                                row(0) = listeAdd(i)
                                row(1) = listeAdd(0)
                                MainForm.tableOpVe.Rows.Add(row)
                            Next

                            AddClient(listeAddCl, id)
                        Else
                            MessageBox.Show("Une erreure c'est produit durant l'association des option!", "Attention!")
                        End If
                    Else
                        AddClient(listeAddCl, id)
                    End If
                Else
                    MessageBox.Show("Une erreure c'est produit durant l'enregistrement du véhicule")
                End If
            Else
                MessageBox.Show("Vous devez rentrer au moin un nom!", "Attention!")
            End If
        Else
            MessageBox.Show("Vous devez rentrer au moin un prénom!", "Attention!")
        End If
    End Sub

    'Fonction qui sert a envoyer l'info d'un nouveau client
    Private Sub AddClient(listeAddCl() As String, id As String)
        Dim table As DataTable
        If idCl = 0 Then
            table = ConnectionServeur.Getinstance.GetInfo(listeAddCl, "AddClientID")
            If Not table(0)(0) = 0 Then

                'On ajoute les infos du nouveau client dans la table du mainform
                Dim row As DataRow = MainForm.TableClient.NewRow
                For i As Integer = 0 To listeAddCl.Length - 1
                    row(i) = listeAddCl(i)
                Next
                MainForm.TableClient.Rows.Add(row)

                idCl = table(0)(0)
                AddVenteCl(id)
            Else
                MessageBox.Show("Une erreure c'est produit durant la création du nouveau client!", "Attention!")
            End If
        Else
            AddVenteCl(id)
        End If
    End Sub

    'Fonction qui sert à mettre une vente véhicule à un client déjà existent
    Private Sub AddVenteCl(id As String)
        Dim listeAdd(4) As String
        listeAdd(0) = id
        listeAdd(1) = Date.Now.ToString("yyyy-MM-dd")
        listeAdd(2) = uc.GetDatePre
        listeAdd(4) = idCl

        Dim nbr2 As Integer = 0
        For r As Integer = 0 To MainForm.tableVenteVe.Rows.Count - 1
            If MainForm.tableVenteVe.Rows(r).Item("priorite") >= nbr2 Then
                nbr2 = Integer.Parse(MainForm.tableVenteVe.Rows(r).Item("priorite"))
            End If
        Next
        nbr2 += 1
        listeAdd(3) = nbr2

        If veExist = False Then
            If ConnectionServeur.Getinstance.AddDelete(listeAdd, "addVenteClient") Then

                'On ajoute les informations pour de la vente vehicule dans la table du mainform
                Dim row As DataRow = MainForm.tableVenteVe.NewRow
                For i As Integer = 0 To listeAdd.Length - 1
                    row(i) = listeAdd(i)
                Next
                MainForm.tableVenteVe.Rows.Add(row)

                EnregistrerFact(id)
            Else
                MessageBox.Show("Une erreure c'est produit durant l'association du véicule et du client!", "Attention!")
            End If
        Else
            EnregistrerFact(id)
        End If
    End Sub

    Private Sub EnregistrerFact(id As String)
        Dim listeAdd(10) As String
        listeAdd(0) = id
        listeAdd(1) = idCl
        listeAdd(2) = Date.Now.ToString("yyyy-MM-dd")

        '--- à faire avec des place pour rentrer de l'information. je met en attendent des information bidons pour les tests
        listeAdd(3) = uc.GetPrixModel()
        listeAdd(4) = uc.GetPrixCouleur()
        listeAdd(5) = uc.GetNUDEchange
        listeAdd(6) = uc.GetNUDAcompte
        listeAdd(7) = 0
        listeAdd(8) = 0
        listeAdd(9) = MainForm.GetInstance.GetOption4
        listeAdd(10) = MainForm.GetInstance.GetOption5

        Dim table As DataTable = ConnectionServeur.Getinstance.GetInfo(listeAdd, "addfacture")
        Dim idfac As String = table(0)(0)

        If idfac <> 0 Then
            Dim row2 As DataRow = MainForm.tableFacture.NewRow
            row2(0) = idfac
            row2(1) = id
            row2(2) = idCl
            row2(3) = Date.Now.ToString("yyyy-MM-dd")

            '--- à faire avec des place pour rentrer de l'information. je met en attendent des information bidons pour les tests
            row2(4) = uc.GetPrixModel()
            row2(5) = uc.GetPrixCouleur()
            row2(6) = uc.GetNUDEchange
            row2(7) = uc.GetNUDAcompte
            row2(8) = 0
            row2(9) = 0
            row2(10) = MainForm.GetInstance.GetOption4
            row2(11) = MainForm.GetInstance.GetOption5

            MainForm.tableFacture.Rows.Add(row2)

            MessageBox.Show("Ajout fait avec succès")

            Dim print As New PrintingForm(row2)
            print.Show()

            Clear()
            uc.Clear()
            main.EnleverOpt()
            main.ChangeUCPrev1(True, True)
        Else
            MessageBox.Show("Une erreure est survenu durant la création de la facture sur le serveur")
        End If
    End Sub

    'Quand on click sur ce bouton, on appel la fonction du mainform pour changer la usercontrol qui est afficher pour mettre le usercontrol UCVente2
    Private Sub BTPrev_Click(sender As Object, e As EventArgs) Handles BTPrev.Click
        main.ChangeUCPrev2()
    End Sub

    Private Sub UCVente3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim liste() As String = {"Non déterminer", "Homme", "Femme"}
        CBSexe.DataSource = liste
        CBSexeCl.DataSource = liste
    End Sub

    'fonction qui sert à enlever le texte dans les objets du usercontrol
    Private Sub Clear()
        TBPrenom1.Text = ""
        TBNom1.Text = ""
        TBPrenom2.Text = ""
        TBNom2.Text = ""
        TBTel1.Text = ""
        TBTel2.Text = ""
        CBSexe.SelectedIndex = 0
        TBEmail.Text = ""
        idCl = 0
        ChangeEna(False)
        idCl = 0
    End Sub

    'Quand on click sur ce bouton, on créer un nouveau form de type ListeClient et on le fait apparaître
    Private Sub BTClient_Click(sender As Object, e As EventArgs) Handles BTClient.Click

    End Sub

    'Fonction qui sert à recevoir une ligne de datagridview et mettre l'information de celle ci dans les texteboxs du usercontrol
    Public Sub GetRowCl(row As DataGridViewRow)
        idCl = row.Cells(0).Value
        TBPreNom1Cl.Text = row.Cells(1).Value
        TBNom1Cl.Text = row.Cells(2).Value
        TBPrenom2Cl.Text = row.Cells(3).Value
        TBNom2Cl.Text = row.Cells(4).Value
        TBTel1Cl.Text = row.Cells(5).Value
        TBTel2Cl.Text = row.Cells(6).Value
        For i As Integer = 0 To CBSexeCl.Items.Count - 1
            If CBSexeCl.Items(i).ToString = row.Cells(7).Value Then
                CBSexeCl.SelectedIndex = i
            End If
        Next
        TBEmailCl.Text = row.Cells(8).Value
        TBAdresseCl.Text = row.Cells(9).Value
        TBAppCl.Text = row.Cells(10).Value
        TBPosteCl.Text = row.Cells(11).Value
        ChangeEna(True)
    End Sub

    'fonction qui sert à changer la visibilité des objets dans le usercontrol selon le boulean recu
    Private Sub ChangeEna(bool As Boolean)
        TBPrenom1.Enabled = Not bool
        TBNom1.Enabled = Not bool
        TBPrenom2.Enabled = Not bool
        TBNom2.Enabled = Not bool
        TBTel1.Enabled = Not bool
        TBTel2.Enabled = Not bool
        CBSexe.Enabled = Not bool
        TBEmail.Enabled = Not bool
        TBRue.Enabled = Not bool
        TBVille.Enabled = Not bool
        TBPro.Enabled = Not bool
        TBApp.Enabled = Not bool
        TBPoste.Enabled = Not bool
        Label12.Visible = bool
        Label13.Visible = bool
        Label14.Visible = bool
        Label15.Visible = bool
        Label16.Visible = bool
        Label17.Visible = bool
        Label18.Visible = bool
        Label19.Visible = bool
        TBPreNom1Cl.Visible = bool
        TBNom1Cl.Visible = bool
        TBPrenom2Cl.Visible = bool
        TBNom2Cl.Visible = bool
        TBTel1Cl.Visible = bool
        TBTel2Cl.Visible = bool
        CBSexeCl.Visible = bool
        TBEmailCl.Visible = bool
        Label23.Visible = bool
        Label24.Visible = bool
        Label25.Visible = bool
        TBAdresseCl.Visible = bool
        TBAppCl.Visible = bool
        TBPosteCl.Visible = bool
    End Sub

    'Quand on appui sur ce bouton, on fait appel à la fonction ChangeEna avec un boulean False comme paramètre et on met le paramètre idCl à 0
    Private Sub BTNewCl_Click(sender As Object, e As EventArgs) Handles BTNewCl.Click
        ChangeEna(False)
        idCl = 0
    End Sub

    'quand on click dans le usercontrol on check pour être sur que le menu du mainform est bien fermer
    Private Sub UCVente3_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub
End Class
