Public Class UCOption
    Dim listeOr(0, 0) As String

    Private Sub UCOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemplireDGV()
    End Sub

    Public Sub RemplireDGV()
        DGVOption.DataSource = ConnectionServeur.Getinstance.GetInfo("getOptionAdd")

        ReDim listeOr(DGVOption.Rows.Count - 1, DGVOption.Columns.Count - 1)
        For r As Integer = 0 To DGVOption.Rows.Count - 1
            For c As Integer = 0 To DGVOption.Columns.Count - 1
                listeOr(r, c) = DGVOption.Rows(r).Cells(c).Value
            Next
        Next
    End Sub

    Private Sub CheckChange()
        BtSave.Enabled = False
        BTAnnuler.Enabled = False

        For r As Integer = 0 To DGVOption.Rows.Count - 1
            For c As Integer = 0 To DGVOption.Columns.Count - 1
                If Not DGVOption.Rows(r).Cells(c).Value = listeOr(r, c) Then
                    BtSave.Enabled = True
                    BTAnnuler.Enabled = True
                End If
            Next
        Next
    End Sub

    Private Sub DGVOption_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVOption.CellEndEdit
        CheckChange()
    End Sub

    Private Sub DGVOption_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DGVOption.CellBeginEdit
        If e.ColumnIndex = 0 Then
            e.Cancel = True
        End If
    End Sub


    Private Sub DGVOption_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DGVOption.EditingControlShowing
        If DGVOption.CurrentCell.ColumnIndex = 2 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        End If
    End Sub

    Private Sub TextBox_keyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BTAnnuler_Click(sender As Object, e As EventArgs) Handles BTAnnuler.Click
        For r As Integer = 0 To DGVOption.Rows.Count - 1
            For c As Integer = 0 To DGVOption.Columns.Count - 1
                DGVOption.Rows(r).Cells(c).Value = listeOr(r, c)
            Next
        Next
    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        For r As Integer = 0 To DGVOption.Rows.Count - 1
            Dim bool As Boolean = False
            Dim listeAdd(DGVOption.Columns.Count - 1) As String
            For c As Integer = 0 To DGVOption.Columns.Count - 1
                listeAdd(c) = DGVOption.Rows(r).Cells(c).Value
                If Not DGVOption.Rows(r).Cells(c).Value = listeOr(r, c) Then
                    bool = True
                End If
            Next
            If bool Then
                If ConnectionServeur.Getinstance.AddDelete(listeAdd, "updateOption") Then
                    For c As Integer = 0 To DGVOption.Columns.Count - 1
                        listeOr(r, c) = listeAdd(c)
                    Next
                    MessageBox.Show("Enregistrement réussit!")
                Else
                    MessageBox.Show("Une erreure est survenue durant l'enregistrement!")
                End If
            End If
        Next
        CheckChange()
    End Sub

    Private Sub BTDelete_Click(sender As Object, e As EventArgs) Handles BTDelete.Click
        If MessageBox.Show("Voulez-vous vraiment supprimer " + DGVOption.CurrentRow.Cells(1).Value + "?", "Attention!", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ConnectionServeur.Getinstance.GetInfo(DGVOption.CurrentRow.Cells(0).Value, "ChangeDeleteOp")
            RemplireDGV()
        End If
    End Sub

    Private Sub BTCreer_Click(sender As Object, e As EventArgs) Handles BTCreer.Click
        Dim OptionForm As New CreerOption
        OptionForm.ShowDialog()
    End Sub

    Private Sub BTItem_Click(sender As Object, e As EventArgs) Handles BTItem.Click
        Dim form As New GestionInvOpt(DGVOption.CurrentRow.Cells(0).Value)
        form.ShowDialog()
        RemplireDGV()
    End Sub

    Private Sub DGVOption_DoubleClick(sender As Object, e As EventArgs) Handles DGVOption.DoubleClick
        Dim form As New GestionInvOpt(DGVOption.CurrentRow.Cells(0).Value)
        form.ShowDialog()
        RemplireDGV()
    End Sub
End Class
