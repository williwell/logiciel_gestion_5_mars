Public Class UCInventaire
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    Dim sameID As String
    Dim sameFour As Integer
    Dim tableOri As DataTable
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
        triger = False
        Dim liste() As String = {"CAD", "US"}
        CBDevise.DataSource = liste
        triger = True
        tbIDPro.Select()
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________
    Private Sub TbIDPro_KeyDown(sender As Object, e As KeyEventArgs) Handles tbIDPro.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If sameID <> tbIDPro.Text Then
                    Start()
                    BtSauvChanger()
                End If
                e.SuppressKeyPress = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

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

    Private Sub BtSauv_Click(sender As Object, e As EventArgs) Handles btSauv.Click
        If ConnectionServeur.Getinstance.AddDelete(change, "modInventaire") Then
            Dim liste() As String = {tbIDPro.Text, tbIDFour.Text, nudCoutUn.Value, tbNoFour.Text, tbNoMFR.Text, CBDevise.SelectedItem.ToString}
            If ConnectionServeur.Getinstance.AddDelete(liste, "modInvFour") Then
                MessageBox.Show("La modification à bien été fait")
                For i As Integer = 1 To change.Length - 1
                    If Not (i = 8 Or i = 9) Then
                        tableOri(cbNoFour.SelectedIndex)(i) = change(i)
                    End If
                Next
                BtSauvChanger()
            Else
                MessageBox.Show("Une erreure est survenue durant la sauvegerde de la modification!")

            End If
        Else
            MessageBox.Show("Une erreure est survenue durant la sauvegerde de la modification!")
        End If

    End Sub

    Private Sub BtRecherche_Click(sender As Object, e As EventArgs) Handles btRecherche.Click
        Dim recherche As New RechercheProduit(Me, main)
        recherche.ShowDialog()
        tbIDPro.Select()
        SendKeys.Send("{ENTER}")
    End Sub

    Private Sub BtAnnulMod_Click(sender As Object, e As EventArgs) Handles btAnnulMod.Click
        Remplir()
        Remplir(cbNoFour.SelectedIndex)
        btSauvChanger()
    End Sub

    Private Sub BtCreer_Click(sender As Object, e As EventArgs) Handles btCreer.Click
        Dim creer As New creerProduit()
        creer.ShowDialog()
    End Sub

    Private Sub CbNoFour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNoFour.SelectedIndexChanged
        If Not sameFour = cbNoFour.SelectedIndex Then
            Remplir(cbNoFour.SelectedIndex)
            sameFour = cbNoFour.SelectedIndex
        End If
    End Sub

    Private Sub BtAddFour_Click(sender As Object, e As EventArgs) Handles btAddFour.Click
        Dim liste(cbNoFour.Items.Count - 1) As String
        For i As Integer = 0 To cbNoFour.Items.Count - 1
            cbNoFour.SelectedIndex = i
            liste(i) = Integer.Parse(tbIDFour.Text)
        Next
        Dim listeFour As New ListeFournisseur(2, tbIDPro.Text, liste)
        listeFour.ShowDialog()
        start()
    End Sub

    Private Sub BrRemoveFour_Click(sender As Object, e As EventArgs) Handles btRemoveFour.Click
        Dim listeFour As New ListeFournisseur(3, tbIDPro.Text)
        listeFour.ShowDialog()
        Start()
    End Sub

    Private Sub Start()
        ChangeRead(True)
        tableOri = ConnectionServeur.Getinstance.GetInfo(tbIDPro.Text, "getInventaire")

        Try
            If tableOri(0)(0) = "\\null" Then
                Cleane()
                labPasItem.Text = "Le numéro d'item n'existe pas!"
                labPasItem.ForeColor = Color.Red
                tbIDPro.SelectAll()
                sameID = tbIDPro.Text
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
        Catch ex As Exception
            MessageBox.Show("Un erreur est survenu avec le serveur")
            main.Fermer()
        End Try

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
    Private Sub TbNom_TextChanged(sender As Object, e As EventArgs) Handles tbNom.TextChanged
        change(1) = tbNom.Text
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub NudQuantite_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantite.ValueChanged
        change(2) = Convert.ToString(nudQuantite.Value)
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub TbDescription_TextChanged(sender As Object, e As EventArgs) Handles tbDescription.TextChanged
        change(3) = tbDescription.Text
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub TbEmplacement_TextChanged(sender As Object, e As EventArgs) Handles tbEmplacement.TextChanged
        change(4) = tbEmplacement.Text
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub CbUse_CheckedChanged(sender As Object, e As EventArgs) Handles cbUse.CheckedChanged
        change(5) = cbUse.Checked
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub NudEnCommende_ValueChanged(sender As Object, e As EventArgs) Handles nudEnCommende.ValueChanged
        change(6) = Convert.ToString(nudEnCommende.Value)
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub NudMinInv_ValueChanged(sender As Object, e As EventArgs) Handles nudMinInv.ValueChanged
        change(7) = Convert.ToString(nudMinInv.Value)
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub NudCoutUn_ValueChanged(sender As Object, e As EventArgs) Handles nudCoutUn.ValueChanged
        change(10) = Convert.ToString(nudCoutUn.Value)
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub TbNoFour_TextChanged(sender As Object, e As EventArgs) Handles tbNoFour.TextChanged
        change(11) = tbNoFour.Text
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub TbNoMFR_TextChanged(sender As Object, e As EventArgs) Handles tbNoMFR.TextChanged
        change(12) = tbNoMFR.Text
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub CBDevise_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBDevise.SelectedIndexChanged
        change(13) = CBDevise.SelectedItem.ToString
        If triger Then
            BtSauvChanger()
        End If
    End Sub

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

    Private Sub NudCoutUn_KeyDown(sender As Object, e As KeyEventArgs) Handles nudCoutUn.KeyDown
        If e.KeyCode = 110 Or e.KeyCode = 190 Then
            e.SuppressKeyPress = True
            SendKeys.Send(",")
        End If
    End Sub

    '__________________________________________________________________________________________________________
    'Set
    '__________________________________________________________________________________________________________
    Public Sub SetIDProduit(id As String)
        tbIDPro.Text = id
        tbIDPro.Select()
        SendKeys.Send("{ENTER}")
    End Sub

    Private Sub UCInventaire_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub

    '__________________________________________________________________________________________________________
    'Get
    '__________________________________________________________________________________________________________

End Class
