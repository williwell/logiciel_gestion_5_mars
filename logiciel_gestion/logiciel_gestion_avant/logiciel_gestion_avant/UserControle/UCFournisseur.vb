Public Class UCFournisseur
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    ReadOnly main As MainForm
    ReadOnly ucInv As UCInventaire
    Dim table As DataTable
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
        LoadFour()
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________
    Private Sub DgvFour_DoubleClick(sender As Object, e As EventArgs) Handles dgvFour.DoubleClick
        tbID.Text = dgvFour.CurrentRow.Cells(0).Value
    End Sub

    Private Sub TbID_TextChanged(sender As Object, e As EventArgs) Handles tbID.TextChanged
        table = ConnectionServeur.Getinstance.GetInfo(Integer.Parse(tbID.Text), "getOneFournisseur")
        Remplir(table)
        dgvPiece.DataSource = ConnectionServeur.Getinstance.GetInfo(Integer.Parse(tbID.Text), "getInventaireOfFour")
    End Sub

    Private Sub DgvPiece_DoubleClick(sender As Object, e As EventArgs) Handles dgvPiece.DoubleClick
        ucInv.SetIDProduit(dgvPiece.CurrentRow.Cells(0).Value)
        main.ShowInventaire()
    End Sub

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
            MessageBox.Show("Un erreure est survenu avec le serveur! 1")
            main.Fermer()
        End Try
    End Sub

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

    Private Sub BtSauv_Click(sender As Object, e As EventArgs) Handles btSauv.Click
        If ConnectionServeur.Getinstance.AddDelete(liste, "modFour") Then
            MessageBox.Show("La modification c'est fait sans problème")
            For i As Integer = 1 To liste.Length - 1
                table(0)(i) = liste(i)
                dgvFour.CurrentRow.Cells(i).Value = liste(i)
            Next
            BtSauvChanger()
        Else
            MessageBox.Show("Un erreur est survenu du coté du serveur! 2")
        End If
    End Sub

    Private Sub TbTel_KeyDown(sender As Object, e As KeyEventArgs) Handles tbTel.KeyDown
        If Not (e.KeyCode = Keys.Back OrElse e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Left OrElse e.KeyCode = Keys.Right) Then
            If Not ((e.KeyCode >= 96 AndAlso e.KeyCode <= 105) OrElse (e.KeyCode >= 48 AndAlso e.KeyCode <= 57)) Then
                e.SuppressKeyPress = True
            End If
        End If
    End Sub

    Private Sub BtAnnuler_Click(sender As Object, e As EventArgs) Handles btAnnuler.Click
        Remplir(table)
    End Sub

    Private Sub BtCreerFour_Click(sender As Object, e As EventArgs) Handles btCreerFour.Click
        Dim creer As New CreerFour(Me)
        creer.ShowDialog()
    End Sub

    Public Sub LoadFour()
        dgvFour.DataSource = ConnectionServeur.Getinstance.GetInfo("getFournisseur")
        Threading.Thread.Sleep(500)
        tbID.Text = dgvFour.CurrentRow.Cells(0).Value
    End Sub

    '__________________________________________________________________________________________________________
    'Functions
    '__________________________________________________________________________________________________________
    Private Sub BtSauvChanger()
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
    Private Sub TbNomFour_TextChanged(sender As Object, e As EventArgs) Handles tbNomFour.TextChanged
        liste(1) = tbNomFour.Text
        BtSauvChanger()
    End Sub

    Private Sub TbAdres1_TextChanged(sender As Object, e As EventArgs) Handles tbAdres1.TextChanged
        liste(2) = tbAdres1.Text
        BtSauvChanger()
    End Sub

    Private Sub TbAdres2_TextChanged(sender As Object, e As EventArgs) Handles tbAdres2.TextChanged
        liste(3) = tbAdres2.Text
        BtSauvChanger()
    End Sub

    Private Sub TbTel_TextChanged(sender As Object, e As EventArgs) Handles tbTel.TextChanged
        liste(4) = tbTel.Text
        BtSauvChanger()
    End Sub



    Private Sub TbNomCont_TextChanged(sender As Object, e As EventArgs) Handles tbNomCont.TextChanged
        liste(5) = tbNomCont.Text
        BtSauvChanger()
    End Sub

    Private Sub TbLeadTime_TextChanged(sender As Object, e As EventArgs) Handles tbLeadTime.TextChanged
        liste(6) = tbLeadTime.Text
        BtSauvChanger()
    End Sub

    Private Sub TbAddCour_TextChanged(sender As Object, e As EventArgs) Handles tbAddCour.TextChanged
        liste(7) = tbAddCour.Text
        BtSauvChanger()
    End Sub

    Private Sub TbMethodeCom_TextChanged(sender As Object, e As EventArgs) Handles tbMethodeCom.TextChanged
        liste(8) = tbMethodeCom.Text
        BtSauvChanger()
    End Sub

    Private Sub TbNoCompte_TextChanged(sender As Object, e As EventArgs) Handles tbNoCompte.TextChanged
        liste(9) = tbNoCompte.Text
        BtSauvChanger()
    End Sub

    Private Sub TbMethodePaie_TextChanged(sender As Object, e As EventArgs) Handles tbMethodePaie.TextChanged
        liste(10) = tbMethodePaie.Text
        BtSauvChanger()
    End Sub

    Private Sub UCFournisseur_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub


    '__________________________________________________________________________________________________________
    'Set
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Get
    '__________________________________________________________________________________________________________



End Class
