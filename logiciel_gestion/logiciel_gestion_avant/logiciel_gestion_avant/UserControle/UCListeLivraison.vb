Public Class UCListeLivraison
    Dim table As New DataTable
    ReadOnly main As MainForm
    Dim SourceRowIndex As Integer = -1
    ReadOnly tableOR As New DataTable
    Dim rowInd As Integer = -1
    Dim tableCl As New DataTable
    Dim bool As Boolean = False

    Sub New(mainforn As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = mainforn
    End Sub

    Private Sub UCListeLivraison_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Ajout des colonnes pour la tableCl
        tableCl.Columns.Add("v.id")
        For c As Integer = 0 To MainForm.TableClient.Columns.Count - 1
            If MainForm.TableClient.Columns(c).ColumnName = "id" Then
                tableCl.Columns.Add("c.id")
            Else
                tableCl.Columns.Add(MainForm.TableClient.Columns(c).ColumnName)
            End If
        Next
        tableCl.Columns.Add("idvehicule")

        'Ajout des lignes dans la tableCL selon les besoins
        For r As Integer = 0 To MainForm.tableVenteVe.Rows.Count - 1
            For r2 As Integer = 0 To MainForm.TableClient.Rows.Count - 1
                If MainForm.tableVenteVe.Rows(r).Item("idclient") = MainForm.TableClient.Rows(r2).Item("id") Then
                    Dim row As DataRow = tableCl.NewRow
                    Dim nbr As Integer = 1
                    row(0) = MainForm.tableVenteVe.Rows(r).Item("id")
                    For c As Integer = 0 To MainForm.TableClient.Columns.Count - 1
                        row(c + nbr) = MainForm.TableClient(r2)(c)
                    Next
                    nbr += MainForm.TableClient.Columns.Count
                    row(nbr) = MainForm.tableVenteVe.Rows(r).Item("idvehicule")
                    tableCl.Rows.Add(row)
                End If
            Next
        Next

        'Ajout des colonnes dans la table table
        table.Columns.Add("ID")
        table.Columns.Add("Numéro Matricule")
        table.Columns.Add("Model")
        table.Columns.Add("Couleur Véhicule")
        table.Columns.Add("Couleur Toile")
        table.Columns.Add("Couleur Tissus")
        table.Columns.Add("Fabriquer")
        table.Columns.Add("En Inventaire")
        table.Columns.Add("Priorité")

        'Ajout des lignes dans la table
        For r As Integer = 0 To MainForm.tableVe.Rows.Count - 1
            For r3 As Integer = 0 To MainForm.tableVenteVe.Rows.Count - 1
                If MainForm.tableVe.Rows(r).Item("id") = MainForm.tableVenteVe.Rows(r3).Item("idvehicule") Then
                    Dim row As DataRow = table.NewRow
                    row(0) = MainForm.tableVe.Rows(r).Item("id")
                    row(1) = MainForm.tableVe.Rows(r).Item("nomatricule")

                    For r2 As Integer = 0 To MainForm.tableModel.Rows.Count - 1
                        If MainForm.tableVe.Rows(r).Item("idmodel") = MainForm.tableModel.Rows(r2).Item("id") Then
                            row(2) = MainForm.tableModel.Rows(r2).Item("nom")
                        End If
                    Next

                    For r2 As Integer = 0 To MainForm.tableCoulVe.Rows.Count - 1
                        If MainForm.tableVe.Rows(r).Item("idcouleur") = MainForm.tableCoulVe.Rows(r2).Item("id") Then
                            row(3) = MainForm.tableCoulVe.Rows(r2).Item("nom")
                        End If
                    Next

                    For r2 As Integer = 0 To MainForm.tableCoulToi.Rows.Count - 1
                        If MainForm.tableVe.Rows(r).Item("idcoultoile") = MainForm.tableCoulToi.Rows(r2).Item("id") Then
                            row(4) = MainForm.tableCoulToi.Rows(r2).Item("nom")
                        End If
                    Next

                    For r2 As Integer = 0 To MainForm.tableCoulTis.Rows.Count - 1
                        If MainForm.tableVe.Rows(r).Item("idcoultissus") = MainForm.tableCoulTis.Rows(r2).Item("id") Then
                            row(5) = MainForm.tableCoulTis.Rows(r2).Item("nom")
                        End If
                    Next

                    row(6) = MainForm.tableVe.Rows(r).Item("fabriquer")
                    row(7) = MainForm.tableVe.Rows(r).Item("eninventaire")
                    row(8) = MainForm.tableVenteVe.Rows(r3).Item("priorite")
                    table.Rows.Add(row)
                End If
            Next

        Next

        table.DefaultView.Sort = "Priorité ASC"
        table = table.DefaultView.ToTable

        DGVVehicule.DataSource = table

        'Ajout des colonnes et des lignes dans la table original
        For c As Integer = 0 To table.Columns.Count - 1
            tableOR.Columns.Add(table.Columns(c).ColumnName)
        Next
        For r As Integer = 0 To table.Rows.Count - 1
            Dim row As DataRow = tableOR.NewRow
            For c As Integer = 0 To table.Columns.Count - 1
                row(c) = table(r)(c)
            Next
            tableOR.Rows.Add(row)
        Next

        LoadClient(0)
        bool = True

        For c As Integer = 0 To DGVVehicule.Columns.Count - 1
            DGVVehicule.Columns(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    'Si on click dans le userControl on regarde pour voir si le menu du mainform est belle et bien fermer
    Private Sub UCListeLivraison_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.FermerMenu()
    End Sub

    'Fonction qui sert a mettre les informations d'un client dans les textbox du userControl 
    Private Sub LoadClient(index As Integer)
        Dim id As Integer

        For r As Integer = 0 To tableCl.Rows.Count - 1
            If DGVVehicule.Rows(index).Cells(0).Value = tableCl(r)(tableCl.Columns.Count - 1) Then
                id = r
            End If
        Next

        TBID.Text = tableCl(id)(1)
        TBPrenom1.Text = tableCl(id)(2)
        TBNom1.Text = tableCl(id)(3)
        TBPrenom2.Text = tableCl(id)(4)
        TBNom2.Text = tableCl(id)(5)
        TBTel1.Text = tableCl(id)(6)
        TBTel2.Text = tableCl(id)(7)
        TBSexe.Text = tableCl(id)(8)
        TBEmail.Text = tableCl(id)(9)
    End Sub

    'Quand on click dans le DataGridView on regarde si c'est un left Click sur la sourie
    'puis on prend les coordonnées du click et on appel la fonction DoDragDrop
    Private Sub DGVVehicule_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DGVVehicule.MouseDown
        SourceRowIndex = -1
        Try
            If e.Button = Windows.Forms.MouseButtons.Left Then
                SourceRowIndex = DGVVehicule.HitTest(e.X, e.Y).RowIndex
                DGVVehicule.Rows(SourceRowIndex).Selected = True
                LoadClient(SourceRowIndex)
                DGVVehicule.Refresh()
                DoDragDrop(DGVVehicule.Rows(SourceRowIndex), DragDropEffects.Move)
            End If

            For i As Integer = 1 To DGVVehicule.Rows.Count
                DGVVehicule.Rows(i - 1).Cells(DGVVehicule.Columns.Count - 1).Value = i
            Next

            CheckChange()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVVehicule_DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles DGVVehicule.DragOver
        If SourceRowIndex >= 0 Then
            e.Effect = DragDropEffects.Move
        End If
    End Sub

    '
    Private Sub DGVVehicule_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles DGVVehicule.DragDrop
        Dim pt As Point = DGVVehicule.PointToClient(New Point(e.X, e.Y))
        Dim TargetRowIndex As Integer = DGVVehicule.HitTest(pt.X, pt.Y).RowIndex
        If TargetRowIndex > SourceRowIndex Then
            TargetRowIndex -= 1
        End If
        Dim drMove As DataRow = table.NewRow
        drMove.ItemArray = table.Rows(SourceRowIndex).ItemArray
        table.Rows.RemoveAt(SourceRowIndex)
        If TargetRowIndex = -1 Then
            TargetRowIndex = table.Rows.Count
        End If
        table.Rows.InsertAt(drMove, TargetRowIndex)
    End Sub

    Private Sub DGVVehicule_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DGVVehicule.MouseUp
        SourceRowIndex = -1
    End Sub

    'Qunad on click sur le bouton on crée une liste pour mettre toutes les informations du table dedans
    Private Sub BTSave_Click(sender As Object, e As EventArgs) Handles BTSave.Click
        Dim liste(0) As String
        For i As Integer = 0 To table.Rows.Count - 1
            ReDim Preserve liste(i)
            liste(i) = table(i)(0)
        Next

        'On envoie la liste au serveur pour updater les informations
        If ConnectionServeur.Getinstance.AddDelete(liste, "updatePriorite") Then

            'on loop pour mettre les informations à jour dans la tableVenteVe du mainform avec la liste
            For i As Integer = 0 To liste.Length - 1
                For r As Integer = 0 To MainForm.tableVenteVe.Rows.Count - 1
                    If MainForm.tableVenteVe.Rows(r).Item("id") = liste(i) Then
                        MainForm.tableVenteVe.Rows(r).Item("priorite") = i + 1
                    End If
                Next
            Next

            ChangerTable(tableOR, table)
            CheckChange()
            MessageBox.Show("Changement des priorité fait avec succès!")
        Else
            MessageBox.Show("Une erreure c'est produit durant l'enregistrement des changement de priorité!", "Attention!")
        End If
    End Sub

    'Quand on click sur ce bouton, on appel la fonction ChangerTable avec la table et la table orginale pour remettre les informations originale
    Private Sub BTAnnuler_Click(sender As Object, e As EventArgs) Handles BTAnnuler.Click
        ChangerTable(table, tableOR)
    End Sub

    'Fonction qui sert à mettre les infos d'une table dans une autre
    Private Sub ChangerTable(tableRec As DataTable, tableGiver As DataTable)
        For r As Integer = 0 To tableGiver.Rows.Count - 1
            For c As Integer = 0 To tableGiver.Columns.Count - 1
                tableRec(r)(c) = tableGiver(r)(c)
            Next
        Next
    End Sub

    'Fonction qui sert à regarder les infos entre la table et la tableOriginal pour voir si à des différences si oui on change les boutons
    Private Sub CheckChange()
        Dim bool As Boolean = False
        For r As Integer = 0 To table.Rows.Count - 1
            For c As Integer = 0 To table.Columns.Count - 1
                If Not table(r)(c) = tableOR(r)(c) Then
                    bool = True
                End If
            Next
        Next
        BTSave.Enabled = bool
        BTAnnuler.Enabled = bool
    End Sub
End Class
