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
            dgvFour.DataSource = MainForm.tableFour
        ElseIf action = 2 Then
            Dim table As New DataTable

            For c As Integer = 0 To MainForm.tableFour.Columns.Count - 1
                table.Columns.Add(MainForm.tableFour.Columns(c).ColumnName)
            Next

            For r As Integer = 0 To MainForm.tableFour.Rows.Count - 1
                Dim bool As Boolean = True
                For i As Integer = 0 To idListe.Length - 1
                    If MainForm.tableFour.Rows(r).Item("id") = idListe(i) Or MainForm.tableFour.Rows(r).Item("id") = 1 Then
                        bool = False
                    End If
                Next
                If bool Then
                    Dim row As DataRow = table.NewRow
                    For c As Integer = 0 To MainForm.tableFour.Columns.Count - 1
                        row(c) = MainForm.tableFour(r)(c)
                    Next
                    table.Rows.Add(row)
                End If
            Next

            dgvFour.DataSource = table

            If Not dgvFour.Rows.Count > 0 Then
                MessageBox.Show("Ce produit a tous les fournisseurs!")
                Me.Close()
            End If
        ElseIf action = 3 Then
            Dim table As New DataTable
            For c As Integer = 0 To MainForm.tableFour.Columns.Count - 1
                table.Columns.Add(MainForm.tableFour.Columns(c).ColumnName)
            Next
            For c As Integer = 0 To (MainForm.tableInvFour.Columns.Count - 1)
                table.Columns.Add(MainForm.tableInvFour.Columns(c).ColumnName)
            Next

            For r As Integer = 0 To MainForm.tableFour.Rows.Count - 1
                For r2 As Integer = 0 To MainForm.tableInvFour.Rows.Count - 1
                    If MainForm.tableFour.Rows(r).Item("id") = MainForm.tableInvFour.Rows(r2).Item("idfournisseur") Then
                        If MainForm.tableInvFour.Rows(r2).Item("idInventaire") = idInv And MainForm.tableInvFour.Rows(r2).Item("idfournisseur") <> 1 Then
                            Dim row As DataRow = table.NewRow
                            Dim nbr As Integer = 0
                            For c As Integer = 0 To MainForm.tableFour.Columns.Count - 1
                                row(c) = MainForm.tableFour(r)(c)
                                nbr += 1
                            Next
                            For c As Integer = 0 To MainForm.tableInvFour.Columns.Count - 1
                                row(c + nbr) = MainForm.tableInvFour(r2)(c)
                            Next
                            table.Rows.Add(row)
                        End If
                    End If
                Next
            Next

            dgvFour.DataSource = table
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
        If action = 1 Then
            creerform.SetFournisseur(dgvFour.CurrentRow.Cells(1).Value)
            Me.Close()
        ElseIf action = 2 Then
            Dim liste() As String = {idInv, dgvFour.CurrentRow.Cells(0).Value}
            If ConnectionServeur.Getinstance.AddDelete(liste, "addInvFour") Then
                MessageBox.Show("L'ajout du fournisseur à bien été fait!")
                Dim rowadd As DataRow = MainForm.tableInvFour.NewRow
                rowadd(0) = idInv
                rowadd(1) = dgvFour.CurrentRow.Cells(0).Value
                rowadd(2) = 0
                rowadd(3) = "null"
                rowadd(4) = "null"
                rowadd(5) = "CAD"
                MainForm.tableInvFour.Rows.Add(rowadd)

                Dim table As New DataTable
                For i As Integer = 0 To MainForm.tableInv.Columns.Count - 1
                    table.Columns.Add(MainForm.tableInv.Columns(i).ColumnName)
                Next
                For i As Integer = 0 To MainForm.tableInvFour.Columns.Count - 1
                    table.Columns.Add(MainForm.tableInvFour.Columns(i).ColumnName)
                Next
                For i As Integer = 0 To MainForm.tableFour.Columns.Count - 1
                    If MainForm.tableFour.Columns(i).ColumnName = "id" Then
                        table.Columns.Add("idFour")
                    Else
                        table.Columns.Add(MainForm.tableFour.Columns(i).ColumnName)
                    End If
                Next

                For r As Integer = 0 To MainForm.tableInv.Rows.Count - 1
                    If MainForm.tableInv.Rows(r).Item("id") = idInv Then
                        For r2 As Integer = 0 To MainForm.tableInvFour.Rows.Count - 1
                            If MainForm.tableInv.Rows(r).Item("id") = MainForm.tableInvFour.Rows(r2).Item("idinventaire") Then
                                For r3 As Integer = 0 To MainForm.tableFour.Rows.Count - 1
                                    If MainForm.tableInvFour.Rows(r2).Item("idfournisseur") = MainForm.tableFour.Rows(r3).Item("id") Then
                                        Dim row As DataRow = table.NewRow
                                        Dim nbr As Integer = 0
                                        Dim nbr2 As Integer
                                        For i As Integer = 0 To MainForm.tableInv.Columns.Count - 1
                                            row(i) = MainForm.tableInv(r)(i)
                                            nbr += 1
                                        Next
                                        nbr2 = nbr
                                        For i As Integer = 0 To MainForm.tableInvFour.Columns.Count - 1
                                            row(i + nbr2) = MainForm.tableInvFour(r2)(i)
                                            nbr += 1
                                        Next
                                        For i As Integer = 0 To MainForm.tableFour.Columns.Count - 1
                                            row(i + nbr) = MainForm.tableFour(r3)(i)
                                        Next
                                        table.Rows.Add(row)
                                    End If
                                Next
                            End If
                        Next
                    End If
                Next

                For i As Integer = 0 To table.Rows.Count - 1
                    If table(i)(9) = 1 Then
                        liste(0) = idInv
                        liste(1) = 1
                        If ConnectionServeur.Getinstance.AddDelete(liste, "delInvFour") Then

                        End If
                    End If
                Next
            End If
            Me.Close()
        ElseIf action = 3 Then
            Dim liste() As String = {idInv, dgvFour.CurrentRow.Cells(0).Value}
            If ConnectionServeur.Getinstance.AddDelete(liste, "delInvFour") Then
                MessageBox.Show("La suppression du fournisseur à bien été fait!")
                For i As Integer = 0 To MainForm.tableInvFour.Rows.Count - 1
                    If MainForm.tableInvFour.Rows(i).Item("idinventaire") = idInv And MainForm.tableInvFour.Rows(i).Item("idfournisseur") = dgvFour.CurrentRow.Cells(0).Value Then
                        MainForm.tableInvFour.Rows.RemoveAt(dgvFour.CurrentRow.Index)
                        i = MainForm.tableInvFour.Rows.Count
                    End If
                Next
            End If

            Dim table As New DataTable

            For i As Integer = 0 To MainForm.tableInv.Columns.Count - 1
                table.Columns.Add(MainForm.tableInv.Columns(i).ColumnName)
            Next
            For i As Integer = 0 To MainForm.tableInvFour.Columns.Count - 1
                table.Columns.Add(MainForm.tableInvFour.Columns(i).ColumnName)
            Next
            For i As Integer = 0 To MainForm.tableFour.Columns.Count - 1
                If MainForm.tableFour.Columns(i).ColumnName = "id" Then
                    table.Columns.Add("idFour")
                Else
                    table.Columns.Add(MainForm.tableFour.Columns(i).ColumnName)
                End If
            Next

            For r As Integer = 0 To MainForm.tableInv.Rows.Count - 1
                If MainForm.tableInv.Rows(r).Item("id") = idInv Then
                    For r2 As Integer = 0 To MainForm.tableInvFour.Rows.Count - 1
                        If MainForm.tableInv.Rows(r).Item("id") = MainForm.tableInvFour.Rows(r2).Item("idinventaire") Then
                            For r3 As Integer = 0 To MainForm.tableFour.Rows.Count - 1
                                If MainForm.tableInvFour.Rows(r2).Item("idfournisseur") = MainForm.tableFour.Rows(r3).Item("id") Then
                                    Dim row As DataRow = table.NewRow
                                    Dim nbr As Integer = 0
                                    Dim nbr2 As Integer
                                    For i As Integer = 0 To MainForm.tableInv.Columns.Count - 1
                                        row(i) = MainForm.tableInv(r)(i)
                                        nbr += 1
                                    Next
                                    nbr2 = nbr
                                    For i As Integer = 0 To MainForm.tableInvFour.Columns.Count - 1
                                        row(i + nbr2) = MainForm.tableInvFour(r2)(i)
                                        nbr += 1
                                    Next
                                    For i As Integer = 0 To MainForm.tableFour.Columns.Count - 1
                                        row(i + nbr) = MainForm.tableFour(r3)(i)
                                    Next
                                    table.Rows.Add(row)
                                End If
                            Next
                        End If
                    Next
                End If
            Next

            If table.Rows.Count = 0 Then
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