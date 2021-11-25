Public Class ListeFournisseur
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    ReadOnly creerform As creerProduit
    ReadOnly action As Integer
    ReadOnly idInv As String
    ReadOnly idListe() As String


    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________
    Sub New(form As creerProduit, i As Integer)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        creerform = form
        action = i
    End Sub

    Sub New(i As Integer, id As String)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        action = i
        idInv = id
    End Sub

    Sub New(i As Integer, id As String, idListeGet() As String)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        action = i
        idInv = id
        idListe = idListeGet
    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________
    Private Sub ListeFournisseur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If action = 1 Then
            dgvFour.DataSource = ConnectionServeur.Getinstance.GetInfo("getFournisseur")
        ElseIf action = 2 Then
            dgvFour.DataSource = ConnectionServeur.Getinstance.GetInfo(idListe, "getFournisseurAdd")
            If Not dgvFour.Rows.Count > 0 Then
                MessageBox.Show("Ce produit a tous les fournisseurs!")
                Me.Close()
            End If
        ElseIf action = 3 Then
            dgvFour.DataSource = ConnectionServeur.Getinstance.GetInfo(idInv, "getFournisseur")
            If Not dgvFour.Rows.Count > 0 Then
                MessageBox.Show("Ce produit n'a pas de fournisseur!")
                Me.Close()
            End If
        End If
    End Sub


    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________
    Private Sub DgvFour_DoubleClick(sender As Object, e As EventArgs) Handles dgvFour.DoubleClick
        Dim table As DataTable
        If action = 1 Then
            creerform.SetFournisseur(dgvFour.CurrentRow.Cells(1).Value)
            Me.Close()
        ElseIf action = 2 Then
            Dim liste() As String = {idInv, dgvFour.CurrentRow.Cells(0).Value}
            If ConnectionServeur.Getinstance.AddDelete(liste, "addInvFour") Then
                MessageBox.Show("L'ajout du fournisseur à bien été fait!")
                table = ConnectionServeur.Getinstance.GetInfo(idInv, "getInventaire")
                For i As Integer = 0 To table.Rows.Count - 1
                    If table(i)(9) = 1 Then
                        liste(0) = idInv
                        liste(1) = 1
                        ConnectionServeur.Getinstance.AddDelete(liste, "delInvFour")
                    End If
                Next
            End If
            Me.Close()
        ElseIf action = 3 Then
            Dim liste() As String = {idInv, dgvFour.CurrentRow.Cells(0).Value}
            If ConnectionServeur.Getinstance.AddDelete(liste, "delInvFour") Then
                MessageBox.Show("La suppression du fournisseur à bien été fait!")
            End If
            table = ConnectionServeur.Getinstance.GetInfo(idInv, "getInventaire")
            If table(0)(0) = "\\null" Then
                liste(0) = idInv
                liste(1) = 1
                ConnectionServeur.Getinstance.AddDelete(liste, "addInvFour")
            End If
            Me.Close()
        End If
    End Sub


    '__________________________________________________________________________________________________________
    'Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Set
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Get
    '__________________________________________________________________________________________________________

End Class