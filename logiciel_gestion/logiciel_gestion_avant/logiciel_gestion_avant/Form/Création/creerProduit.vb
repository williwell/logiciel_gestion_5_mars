Public Class CreerProduit
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
        Dim liste() As String = {"CAD", "US"}
        CBDevise.DataSource = liste
        LabSameID.Text = ""

        Dim listeNom(MainForm.tableFour.Rows.Count - 1) As String
        For i As Integer = 0 To MainForm.tableFour.Rows.Count - 1
            listeNom(i) = MainForm.tableFour.Rows(i).Item(1).ToString
        Next
        cbFour.DataSource() = listeNom
    End Sub


    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________
    Private Sub BtSauv_Click(sender As Object, e As EventArgs) Handles btSauv.Click
        If Not CheckVide() Then
            liste(0) = tbIDPro.Text
            liste(1) = tbNom.Text
            liste(2) = nudQuantite.Value
            If String.IsNullOrEmpty(tbDescription.Text) Then
                liste(3) = "null"
            Else
                liste(3) = tbDescription.Text
            End If

            For i As Integer = 0 To MainForm.tableFour.Rows.Count - 1
                If cbFour.SelectedItem = MainForm.tableFour.Rows(i).Item(1).ToString Then
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

            If ConnectionServeur.Getinstance.AddDelete(liste, "ajoutInventaire") Then
                Dim liste2() As String = {liste(0), liste(4), liste(6), liste(10), liste(11), CBDevise.SelectedItem.ToString}
                If ConnectionServeur.Getinstance.AddDelete(liste2, "addInvFour") Then
                    MessageBox.Show("La création du nouveau produit à bien été fait!")
                    Me.Close()
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

    Private Sub NudCoutUn_KeyDown(sender As Object, e As KeyEventArgs) Handles nudCoutUn.KeyDown
        If e.KeyCode = 110 Or e.KeyCode = 190 Then
            e.SuppressKeyPress = True
            SendKeys.Send(",")
        End If
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

    Private Sub TbIDPro_LostFocus(sender As Object, e As EventArgs) Handles tbIDPro.LostFocus
        Dim bool As Boolean = False

        For i As Integer = 0 To MainForm.tableInv.Rows.Count - 1
            If MainForm.tableInv.Rows(i).Item("id") = tbIDPro.Text Then
                bool = True
            End If
        Next

        If bool Then
            tbIDPro.BackColor = Color.Red
            btSauv.Enabled = False
            LabSameID.Text = "Ce ID de produit existe déjà!"
            LabSameID.ForeColor = Color.Red
        Else
            LabSameID.Text = ""
            btSauv.Enabled = True
            tbIDPro.BackColor = Color.FromArgb(-1)
        End If
    End Sub

    '__________________________________________________________________________________________________________
    'Get
    '__________________________________________________________________________________________________________


End Class