Public Class UCVente3
    ReadOnly uc As UCVente
    ReadOnly main As MainForm

    Sub New(ucVente As UCVente, form As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        uc = ucVente
        main = form
    End Sub

    Private Sub BTSave_Click(sender As Object, e As EventArgs) Handles BTSave.Click
        If Not String.IsNullOrEmpty(TBPrenom1.Text) Then
            If Not String.IsNullOrEmpty(TBNom1.Text) Then
                Dim listeAddCl(7) As String
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

                Dim liste() As String = uc.getListeAdd
                Dim listeAdd() As String = {liste(0), liste(1), liste(2), liste(3), liste(4)}
                Dim table As DataTable
                Dim id As String
                If uc.getID = 0 Then
                    table = ConnectionServeur.Getinstance.GetInfo(listeAdd, "addVehicule")
                    id = table(0)(0)
                Else
                    id = uc.getID
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
                    If ConnectionServeur.Getinstance.AddDelete(listeAdd, "addOpVe") Then
                        table = ConnectionServeur.Getinstance.GetInfo(listeAddCl, "AddClientID")
                        If Not table(0)(0) = 0 Then
                            ReDim listeAdd(4)
                            listeAdd(0) = id
                            listeAdd(1) = Date.Now.ToString("yyyy-MM-dd")
                            listeAdd(2) = uc.getDatePre
                            listeAdd(4) = table(0)(0)
                            table = ConnectionServeur.Getinstance.GetInfo("GetPriority")
                            Dim nbr2 As Integer = table(0)(0) + 1
                            listeAdd(3) = nbr2
                            If ConnectionServeur.Getinstance.AddDelete(listeAdd, "addVenteClient") Then
                                MessageBox.Show("Ajout fait avec succès")
                                clear()
                            Else
                                MessageBox.Show("Une erreure c'est produit durant l'association du véicule et du client!", "Attention!")
                            End If
                        Else
                            MessageBox.Show("Une erreure c'est produit durant la création du nouveau client!", "Attention!")
                        End If
                    Else
                        MessageBox.Show("Une erreure c'est produit durant l'association des option!", "Attention!")
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

    Private Sub BTPrev_Click(sender As Object, e As EventArgs) Handles BTPrev.Click
        main.ChangeUCPrev2()
    End Sub

    Private Sub UCVente3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim liste() As String = {"Non déterminer", "Homme", "Femme"}
        CBSexe.DataSource = liste
    End Sub

    Private Sub clear()
        TBPrenom1.Text = ""
        TBNom1.Text = ""
        TBPrenom2.Text = ""
        TBNom2.Text = ""
        TBTel1.Text = ""
        TBTel2.Text = ""
        CBSexe.SelectedIndex = 0
        TBEmail.Text = ""
    End Sub
End Class
