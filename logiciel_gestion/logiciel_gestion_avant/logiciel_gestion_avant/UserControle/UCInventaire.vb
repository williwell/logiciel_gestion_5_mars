Public Class UCInventaire
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    Dim sameID As String
    Dim sameFour As Integer
    Dim tableOri As DataTable
    Dim change(12) As String
    Dim triger As Boolean = True
    Shared instance As UCInventaire = Nothing


    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________
    Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________
    Private Sub UCInventaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbIDPro.Select()
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________
    Private Sub tbIDPro_KeyDown(sender As Object, e As KeyEventArgs) Handles tbIDPro.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If sameID <> tbIDPro.Text Then
                    start()
                End If
                e.SuppressKeyPress = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub changeRead(read As Boolean)
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
    End Sub

    Private Sub cleane()
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

    Private Sub remplir()
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

    Private Sub remplir(id As Integer)
        triger = False

        change(8) = tableOri(id)(8)
        change(9) = tableOri(id)(9)
        change(10) = tableOri(id)(10)
        nudCoutUn.Value = tableOri(id)(10)
        tbNoFour.Text = tableOri(id)(11)
        tbNoMFR.Text = tableOri(id)(12)
        tbIDFour.Text = tableOri(id)(13)
        tbNomFour.Text = tableOri(id)(14)
        tbAdres1.Text = tableOri(id)(15)
        tbAdres2.Text = tableOri(id)(16)
        tbTel.Text = tableOri(id)(17)
        tbNomConc.Text = tableOri(id)(18)
        tbLeepTime.Text = tableOri(id)(19)
        tbCouriel.Text = tableOri(id)(20)
        tbMetCom.Text = tableOri(id)(21)
        tbNoCompte.Text = tableOri(id)(22)
        tbMethoPaie.Text = tableOri(id)(23)

        triger = True
    End Sub

    Private Sub btSauv_Click(sender As Object, e As EventArgs) Handles btSauv.Click
        If ModelInventaire.getInstance.modInventaire(change, tableOri(0)(0)) Then
            If ModelInvFour.getinstance.modInvFour(tbIDPro.Text, tbIDFour.Text, nudCoutUn.Value, tbNoFour.Text, tbNoMFR.Text) Then
                MessageBox.Show("La modification à bien été fait")
                For i As Integer = 1 To change.Length - 1
                    If Not (i = 8 Or i = 9) Then
                        tableOri(cbNoFour.SelectedIndex)(i) = change(i)
                    End If
                Next
                btSauvChanger()
            Else
                MessageBox.Show("Une erreure est survenue durant la sauvegerde de la modification!")

            End If
        Else
                MessageBox.Show("Une erreure est survenue durant la sauvegerde de la modification!")
        End If

    End Sub

    Private Sub btRecherche_Click(sender As Object, e As EventArgs) Handles btRecherche.Click
        Dim recherche As New RechercheProduit(Me)
        recherche.ShowDialog()
        tbIDPro.Select()
        SendKeys.Send("{ENTER}")
    End Sub

    Private Sub btAnnulMod_Click(sender As Object, e As EventArgs) Handles btAnnulMod.Click
        remplir()
        remplir(cbNoFour.SelectedIndex)
        btSauvChanger()
    End Sub

    Private Sub btCreer_Click(sender As Object, e As EventArgs) Handles btCreer.Click
        Dim creer As New creerProduit()
        creer.ShowDialog()
    End Sub

    Private Sub cbNoFour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNoFour.SelectedIndexChanged
        If Not sameFour = cbNoFour.SelectedIndex Then
            remplir(cbNoFour.SelectedIndex)
            sameFour = cbNoFour.SelectedIndex
        End If
    End Sub

    Private Sub btAddFour_Click(sender As Object, e As EventArgs) Handles btAddFour.Click
        Dim liste(cbNoFour.Items.Count - 1) As Integer
        For i As Integer = 0 To cbNoFour.Items.Count - 1
            cbNoFour.SelectedIndex = i
            liste(i) = Integer.Parse(tbIDFour.Text)
        Next
        Dim listeFour As New ListeFournisseur(2, tbIDPro.Text, liste)
        listeFour.ShowDialog()
        start()
    End Sub

    Private Sub brRemoveFour_Click(sender As Object, e As EventArgs) Handles brRemoveFour.Click
        Dim listeFour As New ListeFournisseur(3, tbIDPro.Text)
        listeFour.ShowDialog()
        start()
    End Sub

    Private Sub start()
        changeRead(True)
        tableOri = EntityInventaire.getInstance.getInventaire(tbIDPro.Text)
        If tableOri.Rows.Count > 0 Then
            remplir()

            Dim liste(tableOri.Rows.Count - 1) As String
            For i As Integer = 0 To tableOri.Rows.Count - 1
                liste(i) = i + 1
            Next
            cbNoFour.DataSource = liste

            remplir(0)
            changeRead(False)
            labPasItem.Text = ""
            sameID = tbIDPro.Text
            change(0) = tbIDPro.Text
        Else
            cleane()
            labPasItem.Text = "Le numéro d'item n'existe pas!"
            labPasItem.ForeColor = Color.Red
            tbIDPro.SelectAll()
            sameID = tbIDPro.Text
        End If
    End Sub

    '__________________________________________________________________________________________________________
    'Functions
    '__________________________________________________________________________________________________________
    Shared Function getInstance() As UCInventaire
        If IsNothing(instance) Then
            instance = New UCInventaire
        End If
        Return instance
    End Function


    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________
    Private Sub tbNom_TextChanged(sender As Object, e As EventArgs) Handles tbNom.TextChanged
        change(1) = tbNom.Text
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub nudQuantite_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantite.ValueChanged
        change(2) = Convert.ToString(nudQuantite.Value)
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub tbDescription_TextChanged(sender As Object, e As EventArgs) Handles tbDescription.TextChanged
        change(3) = tbDescription.Text
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub tbEmplacement_TextChanged(sender As Object, e As EventArgs) Handles tbEmplacement.TextChanged
        change(4) = tbEmplacement.Text
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub cbUse_CheckedChanged(sender As Object, e As EventArgs) Handles cbUse.CheckedChanged
        change(5) = cbUse.Checked
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub nudEnCommende_ValueChanged(sender As Object, e As EventArgs) Handles nudEnCommende.ValueChanged
        change(6) = Convert.ToString(nudEnCommende.Value)
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub nudMinInv_ValueChanged(sender As Object, e As EventArgs) Handles nudMinInv.ValueChanged
        change(7) = Convert.ToString(nudMinInv.Value)
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub nudCoutUn_ValueChanged(sender As Object, e As EventArgs) Handles nudCoutUn.ValueChanged
        change(10) = Convert.ToString(nudCoutUn.Value)
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub tbNoFour_TextChanged(sender As Object, e As EventArgs) Handles tbNoFour.TextChanged
        change(11) = tbNoFour.Text
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub tbNoMFR_TextChanged(sender As Object, e As EventArgs) Handles tbNoMFR.TextChanged
        change(12) = tbNoMFR.Text
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub btSauvChanger()
        Dim modif As Boolean = False
        For i As Integer = 1 To tableOri.Columns.Count - 12
            If Not Convert.ToString(tableOri(cbNoFour.SelectedIndex)(i)) = change(i) Then
                modif = True
            End If
        Next

        btSauv.Enabled = modif
        btAnnulMod.Enabled = modif
    End Sub

    '__________________________________________________________________________________________________________
    'Set
    '__________________________________________________________________________________________________________
    Public Sub setIDProduit(id As String)
        tbIDPro.Text = id
        tbIDPro.Select()
        SendKeys.Send("{ENTER}")
    End Sub


    '__________________________________________________________________________________________________________
    'Get
    '__________________________________________________________________________________________________________

End Class
