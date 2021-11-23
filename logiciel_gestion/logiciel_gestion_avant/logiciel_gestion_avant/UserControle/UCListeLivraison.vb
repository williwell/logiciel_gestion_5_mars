Public Class UCListeLivraison
    Dim table As DataTable
    ReadOnly main As MainForm
    Dim SourceRowIndex As Integer = -1
    ReadOnly tableOR As New DataTable
    Dim rowInd As Integer = -1
    Dim tableCl As DataTable
    Dim bool As Boolean = False

    Sub New(mainforn As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = mainforn
    End Sub

    Private Sub UCListeLivraison_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tableCl = ConnectionServeur.Getinstance.GetInfo("getOneInfoClVe")
        table = ConnectionServeur.Getinstance.GetInfo("getVehiculePrio")
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

        For r As Integer = 0 To DGVVehicule.Rows.Count - 1
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
