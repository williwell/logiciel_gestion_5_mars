Public Class ListeFournisseur
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    Dim creerform As creerProduit
    Dim action As Integer
    Dim idInv As String
    Dim idListe() As Integer


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

    Sub New(i As Integer, id As String, idListeGet() As Integer)
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
            dgvFour.DataSource = ConnectionServeur.getinstance.getFournisseur
        ElseIf action = 2 Then
            dgvFour.DataSource = ConnectionServeur.getinstance.getFournisseurAdd(idListe)
            If Not dgvFour.Rows.Count > 0 Then
                MessageBox.Show("Ce produit a tous les fournisseurs!")
                Me.Close()
            End If
        ElseIf action = 3 Then
            dgvFour.DataSource = ConnectionServeur.getinstance.getFournisseur(idInv)
            If Not dgvFour.Rows.Count > 0 Then
                MessageBox.Show("Ce produit n'a pas de fournisseur!")
                Me.Close()
            End If
        End If
    End Sub


    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________
    Private Sub dgvFour_DoubleClick(sender As Object, e As EventArgs) Handles dgvFour.DoubleClick
        Dim table As DataTable
        If action = 1 Then
            creerform.setFournisseur(dgvFour.CurrentRow.Cells(1).Value)
            Me.Close()
        ElseIf action = 2 Then
            Dim liste() As String = {idInv, dgvFour.CurrentRow.Cells(0).Value}
            If ConnectionServeur.getinstance.addInvFour(liste) Then
                MessageBox.Show("L'ajout du fournisseur à bien été fait!")
                table = ConnectionServeur.getinstance.GetInventaire(idInv)
                For i As Integer = 0 To table.Rows.Count - 1
                    If table(i)(9) = 1 Then
                        liste(0) = idInv
                        liste(1) = 1
                        ConnectionServeur.getinstance.delInvFour(liste)
                    End If
                Next
            End If
            Me.Close()
        ElseIf action = 3 Then
            Dim liste() As String = {idInv, dgvFour.CurrentRow.Cells(0).Value}
            If ConnectionServeur.getinstance.delInvFour(liste) Then
                MessageBox.Show("La suppression du fournisseur à bien été fait!")
            End If
            table = ConnectionServeur.getinstance.GetInventaire(idInv)
            If Not table.Rows.Count > 0 Then
                liste(0) = idInv
                liste(1) = 1
                ConnectionServeur.getinstance.addInvFour(liste)
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