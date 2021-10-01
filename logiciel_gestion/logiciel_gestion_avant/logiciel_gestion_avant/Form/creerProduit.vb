Public Class creerProduit
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    ReadOnly liste(11) As String
    Dim table As DataTable

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________
    Private Sub CreerProduit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        table = ConnectionServeur.Getinstance.GetFournisseur()
        Dim listeNom(table.Rows.Count - 1) As String
        For i As Integer = 0 To table.Rows.Count - 1
            listeNom(i) = table.Rows(i).Item(1).ToString
        Next
        cbFour.DataSource() = listeNom
    End Sub


    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________
    Private Sub BtSauv_Click(sender As Object, e As EventArgs) Handles btSauv.Click
        If Not checkVide() Then
            liste(0) = tbIDPro.Text
            liste(1) = tbNom.Text
            liste(2) = nudQuantite.Value
            If String.IsNullOrEmpty(tbDescription.Text) Then
                liste(3) = "null"
            Else
                liste(3) = tbDescription.Text
            End If

            For i As Integer = 0 To table.Rows.Count - 1
                If cbFour.SelectedItem = table.Rows(i).Item(1).ToString Then
                    liste(4) = i + 1
                End If
            Next
            If String.IsNullOrEmpty(tbEmplacement.Text) Then
                liste(5) = "null"
            Else
                liste(5) = tbEmplacement.Text
            End If
            liste(6) = nudCoutUn.Value
            liste(7) = cbUse.Checked
            liste(8) = nudEnCommende.Value
            liste(9) = nudMinInv.Value
            If String.IsNullOrEmpty(tbNoPieceFour.Text) Then
                liste(10) = "null"
            Else
                liste(10) = tbNoPieceFour.Text
            End If
            If String.IsNullOrEmpty(tbNoMFR.Text) Then
                liste(11) = "null"
            Else
                liste(11) = tbNoMFR.Text
            End If

            If ConnectionServeur.Getinstance.AjoutInventaire(liste) Then
                Dim liste2() As String = {liste(0), liste(4), liste(6), liste(10), liste(11)}
                If ConnectionServeur.Getinstance.AddInvFour(liste2) Then
                    MessageBox.Show("La création du nouveau produit à bien été fait!")
                Else
                    MessageBox.Show("Une erreur est survenue durant la création!", "Attention!")
                End If
            Else
                MessageBox.Show("Une erreur est survenue durant la création!", "Attention!")
            End If
        Else
            MessageBox.Show("Le id du nouveau produit et le nom du produit doit être rmplie obligatoirement!", "Attention!")
        End If
    End Sub

    Private Sub BtListeFour_Click(sender As Object, e As EventArgs) Handles btListeFour.Click
        Dim listeFour As New ListeFournisseur(Me, 1)
        listeFour.ShowDialog()
    End Sub

    Private Sub BtAnnul_Click(sender As Object, e As EventArgs) Handles btAnnul.Click
        Me.Close()
    End Sub

    '__________________________________________________________________________________________________________
    'Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________
    Private Function CheckVide() As Boolean
        Dim vide As Boolean = False
        If String.IsNullOrEmpty(tbIDPro.Text) Or String.IsNullOrEmpty(tbNom.Text) Then
            vide = True
        End If

        Return vide
    End Function

    '__________________________________________________________________________________________________________
    'Set
    '__________________________________________________________________________________________________________
    Public Sub SetFournisseur(nomFour As String)
        For i As Integer = 0 To cbFour.Items.Count - 1
            If cbFour.Items(i) = nomFour Then
                cbFour.SelectedIndex = i
            End If
        Next
    End Sub


    '__________________________________________________________________________________________________________
    'Get
    '__________________________________________________________________________________________________________


End Class