Public Class UCInventaire
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    Dim sameID As String
    Dim sameFour As Integer
    ReadOnly tableOri As New DataTable
    ReadOnly change(13) As String
    Dim triger As Boolean = True
    Shared instance As UCInventaire = Nothing
    Shared main As MainForm


    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________
    Sub New(mainforn As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = mainforn
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________
    Private Sub UCInventaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Créeation des colonnes pour la tableOriginal
        For c As Integer = 0 To MainForm.tableInv.Columns.Count - 1
            tableOri.Columns.Add(MainForm.tableInv.Columns(c).ColumnName)
        Next
        For c As Integer = 0 To MainForm.tableInvFour.Columns.Count - 1
            tableOri.Columns.Add(MainForm.tableInvFour.Columns(c).ColumnName)
        Next
        For c As Integer = 0 To MainForm.tableFour.Columns.Count - 1
            If MainForm.tableFour.Columns(c).ColumnName = "id" Then
                tableOri.Columns.Add("id2")
            Else
                tableOri.Columns.Add(MainForm.tableFour.Columns(c).ColumnName)
            End If
        Next

        triger = False
        Dim liste() As String = {"CAD", "US"}
        CBDevise.DataSource = liste
        triger = True
        tbIDPro.Select()
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________

    'On check les touche qui sont appuyer quand on est dans le textbox des id et on regarde si cette touche est entre
    'Si oui, on appel les fonction Start et BtSauvChanger
    Private Sub TbIDPro_KeyDown(sender As Object, e As KeyEventArgs) Handles tbIDPro.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If sameID <> tbIDPro.Text Then
                    Start()
                End If
                e.SuppressKeyPress = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Fonction qui sert à changer la propriété readonly ou enable des objets selon le boolean recu en paramètre
    Private Sub ChangeRead(read As Boolean)
        tbNom.ReadOnly = read
        nudQuantite.ReadOnly = read
        tbEmplacement.ReadOnly = read
        nudCoutUn.ReadOnly = read
        cbUse.Enabled = Not read
        nudEnCommende.ReadOnly = read
        tbDescription.ReadOnly = read
        nudMinInv.ReadOnly = read
        tbNoFour.ReadOnly = read
        tbNoMFR.ReadOnly = read
        btAddFour.Enabled = Not read
        btRemoveFour.Enabled = Not read
        CBDevise.Enabled = Not read
    End Sub

    'Fonction qui sert a enlever toutes information qui est mit dans les objets
    Private Sub Cleane()
        triger = False
        tbNom.Text = ""
        nudQuantite.Value = 0
        tbDescription.Text = ""
        tbIDFour.Text = ""
        tbEmplacement.Text = ""
        nudCoutUn.Value = 0
        cbUse.Checked = False
        nudEnCommende.Value = 0
        nudMinInv.Value = 0
        tbNoFour.Text = ""
        tbNoMFR.Text = ""
        triger = True
        tbNomFour.Text = ""
        tbAdres1.Text = ""
        tbAdres2.Text = ""
        tbTel.Text = ""
        tbNomConc.Text = ""
        tbLeepTime.Text = ""
        tbCouriel.Text = ""
        tbMetCom.Text = ""
        tbNoCompte.Text = ""
        tbMethoPaie.Text = ""
    End Sub

    'Cette Fonction sert à remplir les objets avec l'information de la tableOriginal et mettre dans une liste
    Private Sub Remplir()
        triger = False
        tbNom.Text = tableOri(0)(1)
        change(1) = tableOri(0)(1)

        nudQuantite.Value = tableOri(0)(2)
        change(2) = tableOri(0)(2)

        tbDescription.Text = tableOri(0)(3)
        change(3) = tableOri(0)(3)

        tbEmplacement.Text = tableOri(0)(4)
        change(4) = tableOri(0)(4)

        cbUse.Checked = tableOri(0)(5)
        change(5) = tableOri(0)(5)

        nudEnCommende.Value = tableOri(0)(6)
        change(6) = tableOri(0)(6)

        nudMinInv.Value = tableOri(0)(7)
        change(7) = tableOri(0)(7)

        triger = True
    End Sub

    'Fonction qui sert à remplir les informations de l'inventaire que l'utilisateur à mit
    Private Sub Remplir(id As Integer)
        triger = False

        change(8) = tableOri(id)(8)
        change(9) = tableOri(id)(9)
        change(10) = tableOri(id)(10)
        nudCoutUn.Value = tableOri(id)(10)
        tbNoFour.Text = tableOri(id)(11)
        tbNoMFR.Text = tableOri(id)(12)
        If CBDevise.Items(0).ToString = tableOri(id)(13) Then
            CBDevise.SelectedIndex = 0
        Else
            CBDevise.SelectedIndex = 1
        End If
        change(13) = CBDevise.SelectedItem.ToString
        tbIDFour.Text = tableOri(id)(14)
        tbNomFour.Text = tableOri(id)(15)
        tbAdres1.Text = tableOri(id)(16)
        tbAdres2.Text = tableOri(id)(17)
        tbTel.Text = tableOri(id)(18)
        tbNomConc.Text = tableOri(id)(19)
        tbLeepTime.Text = tableOri(id)(20)
        tbCouriel.Text = tableOri(id)(21)
        tbMetCom.Text = tableOri(id)(22)
        tbNoCompte.Text = tableOri(id)(23)
        tbMethoPaie.Text = tableOri(id)(24)

        triger = True
    End Sub

    'Quand on click sur ce bouton, on envoie au serveur l'information de la liste pour modifier l'inventaire sur le serveur
    Private Sub BtSauv_Click(sender As Object, e As EventArgs) Handles btSauv.Click
        'Sauvegarde sur le serveur des information relatif à l'item
        If ConnectionServeur.Getinstance.AddDelete(change, "modInventaire") Then
            Dim liste() As String = {tbIDPro.Text, tbIDFour.Text, nudCoutUn.Value, tbNoFour.Text, tbNoMFR.Text, CBDevise.SelectedItem.ToString}

            'Trouver la ligne correspondante dans la table inventaire et changer les informations
            For r As Integer = 0 To MainForm.tableInv.Rows.Count - 1
                If MainForm.tableInv.Rows(r).Item("id") = change(0) Then
                    For c As Integer = 1 To MainForm.tableInv.Columns.Count - 1
                        MainForm.tableInv(r)(c) = change(c)
                    Next
                End If
            Next

            'Sauvegarde sur le serveur des changement du fournisseur
            If ConnectionServeur.Getinstance.AddDelete(liste, "modInvFour") Then

                'Trouver la ligne correspondante dans la table invfour et changer les informations
                For r As Integer = 0 To MainForm.tableInvFour.Rows.Count - 1
                    If MainForm.tableInvFour.Rows(r).Item("idinventaire") = liste(0) And MainForm.tableInvFour.Rows(r).Item("idfournisseur") = liste(1) Then
                        For c As Integer = 2 To MainForm.tableInvFour.Columns.Count - 1
                            MainForm.tableInvFour(r)(c) = liste(c)
                        Next
                    End If
                Next

                MessageBox.Show(MsgTextFr.Getinstance.MsgModServ)
                For i As Integer = 1 To change.Length - 1
                    If Not (i = 8 Or i = 9) Then
                        tableOri(cbNoFour.SelectedIndex)(i) = change(i)
                    End If
                Next
                BtSauvChanger()
            Else
                MessageBox.Show(MsgTextFr.Getinstance.MsgSauvServ)

            End If
        Else
            MessageBox.Show(MsgTextFr.Getinstance.MsgSauvServ)
        End If

    End Sub

    'Quand on appuie sur ce bouton, on ouvre un nouveau form de type RechercheProduit et on l'affiche. Après quand le form qu'on a créer
    'ferme, on sélection le textbox id pour après envoyer un keypress de enter
    Private Sub BtRecherche_Click(sender As Object, e As EventArgs) Handles btRecherche.Click
        Dim recherche As New RechercheProduit(Me)
        recherche.ShowDialog(Me)
        tbIDPro.Select()
        SendKeys.Send("{ENTER}")
    End Sub

    'QUand on appuie sur ce bouton, on appel les fonction remplir pour remmetre les information avant les modifications
    Private Sub BtAnnulMod_Click(sender As Object, e As EventArgs) Handles btAnnulMod.Click
        Remplir()
        Remplir(cbNoFour.SelectedIndex)
        btSauvChanger()
    End Sub

    'Quand on click sur ce bouton, on créer un nouveau form de type CreerProduit et on l'affiche
    Private Sub BtCreer_Click(sender As Object, e As EventArgs) Handles btCreer.Click
        Dim creer As New creerProduit()
        creer.ShowDialog(Me)
    End Sub

    'Quand on change l'index du combobox Numéro fournisseur on appel une fonction pour changer les informations
    Private Sub CbNoFour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNoFour.SelectedIndexChanged
        If Not sameFour = cbNoFour.SelectedIndex Then
            Remplir(cbNoFour.SelectedIndex)
            sameFour = cbNoFour.SelectedIndex
        End If
    End Sub

    'Quand on click sur ce bouton, on créer une liste des fournisseur déja associer avec cette pièce d'inventaire
    'puis on créer un nouveau form de type ListeFournisseur et on l'affiche
    Private Sub BtAddFour_Click(sender As Object, e As EventArgs) Handles btAddFour.Click
        Dim liste(cbNoFour.Items.Count - 1) As String
        For i As Integer = 0 To cbNoFour.Items.Count - 1
            cbNoFour.SelectedIndex = i
            liste(i) = Integer.Parse(tbIDFour.Text)
        Next
        Dim listeFour As New ListeFournisseur(2, tbIDPro.Text, liste)
        listeFour.ShowDialog(Me)
        Start()
    End Sub

    'Quand on click sur ce bouton, on ouvre un nouveau form de type ListeFournisseur et on l'affiche
    Private Sub BrRemoveFour_Click(sender As Object, e As EventArgs) Handles btRemoveFour.Click
        Dim listeFour As New ListeFournisseur(3, tbIDPro.Text)
        listeFour.ShowDialog(Me)
        Start()
    End Sub

    'Cette fonction sert à mettre l'information d'un item dans les objets du userControl et faire la liste original
    Private Sub Start()
        ChangeRead(True)

        tableOri.Clear()

        'loop pour mettre toute l'information nécessaire dans la table
        For r As Integer = 0 To MainForm.tableInv.Rows.Count - 1
            If MainForm.tableInv.Rows(r).Item("id") = tbIDPro.Text Then
                For r2 As Integer = 0 To MainForm.tableInvFour.Rows.Count - 1
                    If MainForm.tableInv.Rows(r).Item("id") = MainForm.tableInvFour.Rows(r2).Item("idinventaire") Then
                        For r3 As Integer = 0 To MainForm.tableFour.Rows.Count - 1
                            If MainForm.tableInvFour.Rows(r2).Item("idfournisseur") = MainForm.tableFour.Rows(r3).Item("id") Then
                                Dim row As DataRow = tableOri.NewRow
                                For c As Integer = 0 To MainForm.tableInv.Columns.Count - 1
                                    row(c) = MainForm.tableInv(r)(c)
                                Next
                                Dim nbr As Integer = MainForm.tableInv.Columns.Count
                                For c As Integer = 0 To MainForm.tableInvFour.Columns.Count - 1
                                    row(c + nbr) = MainForm.tableInvFour(r2)(c)
                                Next
                                nbr += MainForm.tableInvFour.Columns.Count
                                For c As Integer = 0 To MainForm.tableFour.Columns.Count - 1
                                    row(c + nbr) = MainForm.tableFour(r3)(c)
                                Next
                                tableOri.Rows.Add(row)
                            End If
                        Next
                    End If
                Next
            End If
        Next

        'On regarde combien de ligne on a dans la table, si on a en 0 on enlève toutes inforations qui pourraient être encore dans les
        'objets du UserControl et on affiche que le numéro d'item n'existe pas
        If tableOri.Rows.Count = 0 Then
            Cleane()
            labPasItem.Text = MsgTextFr.Getinstance.MsgNoIdProduit
            labPasItem.ForeColor = Color.Red
            tbIDPro.SelectAll()
            sameID = tbIDPro.Text

            'Si on a des ligne on remplie les objets avec l'information de l'inventaire
        Else
            Remplir()

            Dim liste(tableOri.Rows.Count - 1) As String
            For i As Integer = 0 To tableOri.Rows.Count - 1
                liste(i) = i + 1
            Next
            cbNoFour.DataSource = liste

            Remplir(0)
            ChangeRead(False)
            labPasItem.Text = ""
            sameID = tbIDPro.Text
            change(0) = tbIDPro.Text
        End If

    End Sub

    '__________________________________________________________________________________________________________
    'Functions
    '__________________________________________________________________________________________________________
    Shared Function GetInstance() As UCInventaire
        If IsNothing(instance) Then
            instance = New UCInventaire(main)
        End If
        Return instance
    End Function


    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________

    'On met l'information dans la liste change et si le trigger est true on appel la fonction btSauvChanger
    Private Sub TbNom_TextChanged(sender As Object, e As EventArgs) Handles tbNom.TextChanged
        change(1) = tbNom.Text
        If triger Then
            BtSauvChanger()
        End If
    End Sub

    'On met l'information dans la liste change et si le trigger est true on appel la fonction btSauvChanger
    Private Sub NudQuantite_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantite.ValueChanged
        change(2) = Convert.ToString(nudQuantite.Value)
        If triger Then
            btSauvChanger()
        End If
    End Sub

    'On met l'information dans la liste change et si le trigger est true on appel la fonction btSauvChanger
    Private Sub TbDescription_TextChanged(sender As Object, e As EventArgs) Handles tbDescription.TextChanged
        change(3) = tbDescription.Text
        If triger Then
            btSauvChanger()
        End If
    End Sub

    'On met l'information dans la liste change et si le trigger est true on appel la fonction btSauvChanger
    Private Sub TbEmplacement_TextChanged(sender As Object, e As EventArgs) Handles tbEmplacement.TextChanged
        change(4) = tbEmplacement.Text
        If triger Then
            btSauvChanger()
        End If
    End Sub

    'On met l'information dans la liste change et si le trigger est true on appel la fonction btSauvChanger
    Private Sub CbUse_CheckedChanged(sender As Object, e As EventArgs) Handles cbUse.CheckedChanged
        change(5) = cbUse.Checked
        If triger Then
            btSauvChanger()
        End If
    End Sub

    'On met l'information dans la liste change et si le trigger est true on appel la fonction btSauvChanger
    Private Sub NudEnCommende_ValueChanged(sender As Object, e As EventArgs) Handles nudEnCommende.ValueChanged
        change(6) = Convert.ToString(nudEnCommende.Value)
        If triger Then
            btSauvChanger()
        End If
    End Sub

    'On met l'information dans la liste change et si le trigger est true on appel la fonction btSauvChanger
    Private Sub NudMinInv_ValueChanged(sender As Object, e As EventArgs) Handles nudMinInv.ValueChanged
        change(7) = Convert.ToString(nudMinInv.Value)
        If triger Then
            btSauvChanger()
        End If
    End Sub

    'On met l'information dans la liste change et si le trigger est true on appel la fonction btSauvChanger
    Private Sub NudCoutUn_ValueChanged(sender As Object, e As EventArgs) Handles nudCoutUn.ValueChanged
        change(10) = Convert.ToString(nudCoutUn.Value)
        If triger Then
            btSauvChanger()
        End If
    End Sub

    'On met l'information dans la liste change et si le trigger est true on appel la fonction btSauvChanger
    Private Sub TbNoFour_TextChanged(sender As Object, e As EventArgs) Handles tbNoFour.TextChanged
        change(11) = tbNoFour.Text
        If triger Then
            btSauvChanger()
        End If
    End Sub

    'On met l'information dans la liste change et si le trigger est true on appel la fonction btSauvChanger
    Private Sub TbNoMFR_TextChanged(sender As Object, e As EventArgs) Handles tbNoMFR.TextChanged
        change(12) = tbNoMFR.Text
        If triger Then
            btSauvChanger()
        End If
    End Sub

    'On met l'information dans la liste change et si le trigger est true on appel la fonction btSauvChanger
    Private Sub CBDevise_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBDevise.SelectedIndexChanged
        change(13) = CBDevise.SelectedItem.ToString
        If triger Then
            BtSauvChanger()
        End If
    End Sub

    'Fonction qui sert à regarder si à une différence entre la table oroginal et la liste Change. Si a une différence on change le enable des
    'boutons BtSauv et BtAnnulMod
    Private Sub BtSauvChanger()
        Dim modif As Boolean = False
        For i As Integer = 1 To tableOri.Columns.Count - 12
            If Not Convert.ToString(tableOri(cbNoFour.SelectedIndex)(i)) = change(i) Then
                modif = True
            End If
        Next

        btSauv.Enabled = modif
        btAnnulMod.Enabled = modif
    End Sub

    'On regarde quel touche à été appuyer et si cette touche est un point on change en virgule
    Private Sub NudCoutUn_KeyDown(sender As Object, e As KeyEventArgs) Handles nudCoutUn.KeyDown
        If e.KeyCode = 110 Or e.KeyCode = 190 Then
            e.SuppressKeyPress = True
            SendKeys.Send(",")
        End If
    End Sub

    '__________________________________________________________________________________________________________
    'Set
    '__________________________________________________________________________________________________________

    'Fonction qui sert à recevoir un id et le mettre dans le textbox et puis envoyer enter comme keypress
    Public Sub SetIDProduit(id As String)
        tbIDPro.Text = id
        tbIDPro.Select()
        SendKeys.Send("{ENTER}")
    End Sub

    'Si on click dans le UserCOntrol on check si le menu du mainform est bien fermer
    Private Sub UCInventaire_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub

    '__________________________________________________________________________________________________________
    'Get
    '__________________________________________________________________________________________________________

End Class
