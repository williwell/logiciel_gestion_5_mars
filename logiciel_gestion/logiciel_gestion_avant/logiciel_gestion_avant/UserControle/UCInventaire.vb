Public Class UCInventaire
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    Dim sameID As String
    Dim tableOri As DataTable
    Dim change(9) As String
    Dim triger As Boolean = True
    Dim modif As Boolean


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
                    changeRead(True)
                    tableOri = EntityInventaire.getInstance.getInventaire(tbIDPro.Text)
                    If tableOri.Rows.Count > 0 Then
                        remplir()
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
                End If
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
        nudQuantite.Value = tableOri(0)(2)
        tbDescription.Text = tableOri(0)(3)
        tbIDFour.Text = tableOri(0)(4)
        tbEmplacement.Text = tableOri(0)(5)
        nudCoutUn.Value = tableOri(0)(6)
        cbUse.Checked = tableOri(0)(7)
        nudEnCommende.Value = tableOri(0)(8)
        nudMinInv.Value = tableOri(0)(9)
        triger = True
        tbNomFour.Text = tableOri(0)(11)
        tbAdres1.Text = tableOri(0)(12)
        tbAdres2.Text = tableOri(0)(13)
        Dim tel As String = tableOri(0)(14)
        tbTel.Text = "(" & tel.Substring(0, 3) & ") " & tel.Substring(3, 3) & "-" & tel.Substring(6)
        tbNomConc.Text = tableOri(0)(15)
        tbLeepTime.Text = tableOri(0)(16)
        tbCouriel.Text = tableOri(0)(17)
        tbMetCom.Text = tableOri(0)(18)
        tbNoCompte.Text = tableOri(0)(19)
        tbMethoPaie.Text = tableOri(0)(20)
    End Sub

    Private Sub btSauv_Click(sender As Object, e As EventArgs) Handles btSauv.Click
        If ModelInventaire.getInstance.modInventaire(change, True) Then
            MessageBox.Show("La modification à bien été fait")
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
        btSauvChanger()
    End Sub

    Private Sub btCreer_Click(sender As Object, e As EventArgs) Handles btCreer.Click
        Dim creer As New creerProduit()
        creer.ShowDialog()
    End Sub

    '__________________________________________________________________________________________________________
    'Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________
    Private Sub tbDescription_TextChanged(sender As Object, e As EventArgs) Handles tbDescription.TextChanged
        change(3) = tbDescription.Text
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub nudCoutUn_ValueChanged(sender As Object, e As EventArgs) Handles nudCoutUn.ValueChanged
        change(6) = Convert.ToString(nudCoutUn.Value)
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub nudEnCommende_ValueChanged(sender As Object, e As EventArgs) Handles nudEnCommende.ValueChanged
        change(8) = Convert.ToString(nudEnCommende.Value)
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

    Private Sub tbEmplacement_TextChanged(sender As Object, e As EventArgs) Handles tbEmplacement.TextChanged
        change(5) = tbEmplacement.Text
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub tbNom_TextChanged(sender As Object, e As EventArgs) Handles tbNom.TextChanged
        change(1) = tbNom.Text
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub tbIDFour_TextChanged(sender As Object, e As EventArgs) Handles tbIDFour.TextChanged
        change(4) = tbIDFour.Text
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub cbUse_CheckedChanged(sender As Object, e As EventArgs) Handles cbUse.CheckedChanged
        change(7) = cbUse.Checked
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub nudMinInv_ValueChanged(sender As Object, e As EventArgs) Handles nudMinInv.ValueChanged
        change(9) = Convert.ToString(nudMinInv.Value)
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub btSauvChanger()
        modif = False
        For i As Integer = 1 To tableOri.Columns.Count - 12
            If Not Convert.ToString(tableOri(0)(i)) = change(i) Then
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
    End Sub



    '__________________________________________________________________________________________________________
    'Get
    '__________________________________________________________________________________________________________

End Class
