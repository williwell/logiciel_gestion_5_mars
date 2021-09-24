Public Class UCFournisseur
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    Dim main As MainForm
    Dim ucInv As UCInventaire
    Dim table As DataTable
    Dim liste(10) As String


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
        dgvFour.DataSource = ConnectionServeur.getinstance.getFournisseur()
        tbID.Text = dgvFour.CurrentRow.Cells(0).Value
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________
    Private Sub dgvFour_DoubleClick(sender As Object, e As EventArgs) Handles dgvFour.DoubleClick
        tbID.Text = dgvFour.CurrentRow.Cells(0).Value
    End Sub

    Private Sub tbID_TextChanged(sender As Object, e As EventArgs) Handles tbID.TextChanged
        table = ConnectionServeur.getinstance.getOneFournisseur(Integer.Parse(tbID.Text))
        remplir(table)
        dgvPiece.DataSource = ConnectionServeur.getinstance.getInventaireOfFour(Integer.Parse(tbID.Text))
    End Sub

    Private Sub dgvPiece_DoubleClick(sender As Object, e As EventArgs) Handles dgvPiece.DoubleClick
        ucInv.setIDProduit(dgvPiece.CurrentRow.Cells(0).Value)
        main.showInventaire()
    End Sub

    Private Sub remplir(table As DataTable)
        Try
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
            MessageBox.Show("Un erreure est survenu avec le serveur! 1")
            main.fermer()
        End Try
    End Sub

    Private Sub btSauv_Click(sender As Object, e As EventArgs) Handles btSauv.Click
        If ConnectionServeur.getinstance.modFour(liste) Then
            MessageBox.Show("La modification c'est fait sans problème")
            For i As Integer = 1 To liste.Length - 1
                table(0)(i) = liste(i)
                dgvFour.CurrentRow.Cells(i).Value = liste(i)
            Next
            btSauvChanger()
        Else
            MessageBox.Show("Un erreur est survenu du coté du serveur! 2")
        End If
    End Sub

    Private Sub tbTel_KeyDown(sender As Object, e As KeyEventArgs) Handles tbTel.KeyDown
        If Not (e.KeyCode = Keys.Back OrElse e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Left OrElse e.KeyCode = Keys.Right) Then
            If Not ((e.KeyCode >= 96 AndAlso e.KeyCode <= 105) OrElse (e.KeyCode >= 48 AndAlso e.KeyCode <= 57)) Then
                e.SuppressKeyPress = True
            End If
        End If
    End Sub

    Private Sub btAnnuler_Click(sender As Object, e As EventArgs) Handles btAnnuler.Click
        remplir(table)
    End Sub

    '__________________________________________________________________________________________________________
    'Functions
    '__________________________________________________________________________________________________________
    Private Sub btSauvChanger()
        Dim modif As Boolean = False
        For i As Integer = 1 To table.Columns.Count - 1
            If Not Convert.ToString(table(0)(i)) = liste(i) Then
                'MessageBox.Show(table(0)(i) & "  =  " & liste(i))
                modif = True
            End If
        Next

        btSauv.Enabled = modif
        btAnnuler.Enabled = modif
    End Sub


    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________
    Private Sub tbNomFour_TextChanged(sender As Object, e As EventArgs) Handles tbNomFour.TextChanged
        liste(1) = tbNomFour.Text
        btSauvChanger()
    End Sub

    Private Sub tbAdres1_TextChanged(sender As Object, e As EventArgs) Handles tbAdres1.TextChanged
        liste(2) = tbAdres1.Text
        btSauvChanger()
    End Sub

    Private Sub tbAdres2_TextChanged(sender As Object, e As EventArgs) Handles tbAdres2.TextChanged
        liste(3) = tbAdres2.Text
        btSauvChanger()
    End Sub

    Private Sub tbTel_TextChanged(sender As Object, e As EventArgs) Handles tbTel.TextChanged
        liste(4) = tbTel.Text
        btSauvChanger()
    End Sub



    Private Sub tbNomCont_TextChanged(sender As Object, e As EventArgs) Handles tbNomCont.TextChanged
        liste(5) = tbNomCont.Text
        btSauvChanger()
    End Sub

    Private Sub tbLeadTime_TextChanged(sender As Object, e As EventArgs) Handles tbLeadTime.TextChanged
        liste(6) = tbLeadTime.Text
        btSauvChanger()
    End Sub

    Private Sub tbAddCour_TextChanged(sender As Object, e As EventArgs) Handles tbAddCour.TextChanged
        liste(7) = tbAddCour.Text
        btSauvChanger()
    End Sub

    Private Sub tbMethodeCom_TextChanged(sender As Object, e As EventArgs) Handles tbMethodeCom.TextChanged
        liste(8) = tbMethodeCom.Text
        btSauvChanger()
    End Sub

    Private Sub tbNoCompte_TextChanged(sender As Object, e As EventArgs) Handles tbNoCompte.TextChanged
        liste(9) = tbNoCompte.Text
        btSauvChanger()
    End Sub

    Private Sub tbMethodePaie_TextChanged(sender As Object, e As EventArgs) Handles tbMethodePaie.TextChanged
        liste(10) = tbMethodePaie.Text
        btSauvChanger()
    End Sub





    '__________________________________________________________________________________________________________
    'Set
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Get
    '__________________________________________________________________________________________________________



End Class
