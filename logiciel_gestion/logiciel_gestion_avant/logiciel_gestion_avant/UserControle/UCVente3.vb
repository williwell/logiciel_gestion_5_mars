Public Class UCVente3
    ReadOnly uc As UCVente
    ReadOnly main As MainForm
    Dim idCl As String = 0

    Sub New(ucVente As UCVente, form As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        uc = ucVente
        main = form
    End Sub

    Private Sub BTSave_Click(sender As Object, e As EventArgs) Handles BTSave.Click
        If Not String.IsNullOrEmpty(TBPrenom1.Text) Or Not idCl = 0 Then
            If Not String.IsNullOrEmpty(TBNom1.Text) Or Not idCl = 0 Then
                Dim listeAddCl(7) As String
                If Not idCl = 0 Then
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
                    If Not IsNothing(liste(5)) Then
                        If ConnectionServeur.Getinstance.AddDelete(listeAdd, "addOpVe") And Not liste.Count - 1 = 6 Then
                            addClient(listeAddCl, id)
                        Else
                            MessageBox.Show("Une erreure c'est produit durant l'association des option!", "Attention!")
                        End If
                    Else
                        addClient(listeAddCl, id)
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

    Private Sub addClient(listeAddCl() As String, id As String)
        Dim table As DataTable
        If idCl = 0 Then
            table = ConnectionServeur.Getinstance.GetInfo(listeAddCl, "AddClientID")
            If Not table(0)(0) = 0 Then
                addVenteCl(id)
            Else
                MessageBox.Show("Une erreure c'est produit durant la création du nouveau client!", "Attention!")
            End If
        Else
            addVenteCl(id)
        End If
    End Sub

    Private Sub addVenteCl(id As String)
        Dim listeAdd(4) As String
        listeAdd(0) = id
        listeAdd(1) = Date.Now.ToString("yyyy-MM-dd")
        listeAdd(2) = uc.getDatePre
        listeAdd(4) = idCl
        Dim table As DataTable = ConnectionServeur.Getinstance.GetInfo("GetPriority")
        Dim nbr2 As Integer = table(0)(0) + 1
        listeAdd(3) = nbr2
        If ConnectionServeur.Getinstance.AddDelete(listeAdd, "addVenteClient") Then
            MessageBox.Show("Ajout fait avec succès")
            clear()
            uc.clear()
            main.ChangeUCPrev1()
        Else
            MessageBox.Show("Une erreure c'est produit durant l'association du véicule et du client!", "Attention!")
        End If
    End Sub

    Private Sub BTPrev_Click(sender As Object, e As EventArgs) Handles BTPrev.Click
        main.ChangeUCPrev2()
    End Sub

    Private Sub UCVente3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim liste() As String = {"Non déterminer", "Homme", "Femme"}
        CBSexe.DataSource = liste
        CBSexeCl.DataSource = liste
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
        idCl = 0
        changeEna(False)
        idCl = 0
    End Sub

    Private Sub BTClient_Click(sender As Object, e As EventArgs) Handles BTClient.Click
        Dim ListCl As New ListeClient(Me)
        ListCl.ShowDialog()
    End Sub

    Public Sub getRowCl(row As DataGridViewRow)
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
        changeEna(True)
    End Sub

    Private Sub changeEna(bool As Boolean)
        TBPrenom1.Enabled = Not bool
        TBNom1.Enabled = Not bool
        TBPrenom2.Enabled = Not bool
        TBNom2.Enabled = Not bool
        TBTel1.Enabled = Not bool
        TBTel2.Enabled = Not bool
        CBSexe.Enabled = Not bool
        TBEmail.Enabled = Not bool
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
    End Sub

    Private Sub BTNewCl_Click(sender As Object, e As EventArgs) Handles BTNewCl.Click
        changeEna(False)
        idCl = 0
    End Sub
End Class
