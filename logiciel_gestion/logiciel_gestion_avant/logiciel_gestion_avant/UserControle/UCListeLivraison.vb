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
        tableCl.Columns.Add("v.id")
        For c As Integer = 0 To MainForm.TableClient.Columns.Count - 1
            If MainForm.TableClient.Columns(c).ColumnName = "id" Then
                tableCl.Columns.Add("c.id")
            Else
                tableCl.Columns.Add(MainForm.TableClient.Columns(c).ColumnName)
            End If
        Next
        tableCl.Columns.Add("idvehicule")

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

        'Select Case v.eninventaire, vv.priorite As Priorite
        '                            FROM `vehicule` v 
        '                            inner Join `ventevehicule` vv on v.id = vv.idvehicule 
        '                            order by priorite"

        table.Columns.Add("ID")
        table.Columns.Add("Numéro Matricule")
        table.Columns.Add("Model")
        table.Columns.Add("Couleur Véhicule")
        table.Columns.Add("Couleur Toile")
        table.Columns.Add("Couleur Tissus")
        table.Columns.Add("Fabriquer")
        table.Columns.Add("En Inventaire")
        table.Columns.Add("Priorité")

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
    End Sub

    Private Sub UCListeLivraison_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.FermerMenu()
    End Sub

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

    Private Sub BTSave_Click(sender As Object, e As EventArgs) Handles BTSave.Click
        Dim liste(0) As String
        For i As Integer = 0 To table.Rows.Count - 1
            ReDim Preserve liste(i)
            liste(i) = table(i)(0)
        Next

        If ConnectionServeur.Getinstance.AddDelete(liste, "updatePriorite") Then
            ChangerTable(tableOR, table)
            CheckChange()
            MessageBox.Show("Changement des priorité fait avec succès!")
        Else
            MessageBox.Show("Une erreure c'est produit durant l'enregistrement des changement de priorité!", "Attention!")
        End If
    End Sub

    Private Sub BTAnnuler_Click(sender As Object, e As EventArgs) Handles BTAnnuler.Click
        ChangerTable(table, tableOR)
    End Sub

    Private Sub ChangerTable(tableRec As DataTable, tableGiver As DataTable)
        For r As Integer = 0 To tableGiver.Rows.Count - 1
            For c As Integer = 0 To tableGiver.Columns.Count - 1
                tableRec(r)(c) = tableGiver(r)(c)
            Next
        Next
    End Sub

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
