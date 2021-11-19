Public Class UCCouleurTissus
    ReadOnly main As MainForm
    ReadOnly tableCoul As DataTable
    ReadOnly listeOr(0, 0) As String

    Sub New(mainform As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = mainform
    End Sub

    Private Sub UCCouleurTissus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListGest.loadCoul(tableCoul, "getCoulTissus", dgvCouleur, listeOr)
    End Sub

    Private Sub BtCreer_Click(sender As Object, e As EventArgs) Handles BtCreer.Click
        Dim NewColor As New CreerCouleurTissus(Me)
        NewColor.ShowDialog()
    End Sub

    Public Sub LoadCoul()
        ListGest.LoadCoul(tableCoul, "getCoulTissus", dgvCouleur, listeOr)
    End Sub

    Private Sub BTAnnuler_Click(sender As Object, e As EventArgs) Handles BTAnnuler.Click
        For r As Integer = 0 To dgvCouleur.Rows.Count - 1
            For c As Integer = 0 To dgvCouleur.Columns.Count - 1
                tableCoul(r)(c) = listeOr(r, c)
            Next
        Next
        CheckerChange()
    End Sub

    Private Sub BTEnregistrer_Click(sender As Object, e As EventArgs) Handles BTEnregistrer.Click
        For r As Integer = 0 To tableCoul.Rows.Count - 1
            Dim bool As Boolean = False
            Dim listeAdd(tableCoul.Columns.Count - 1) As String
            For c As Integer = 0 To tableCoul.Columns.Count - 1
                listeAdd(c) = tableCoul(r)(c)
                If Not tableCoul(r)(c) = listeOr(r, c) Then
                    bool = True
                End If
            Next
            If bool Then
                If ConnectionServeur.Getinstance.AddDelete(listeAdd, "updateCouleur") Then
                    For c As Integer = 0 To tableCoul.Columns.Count - 1
                        listeOr(r, c) = listeAdd(c)
                    Next
                    MessageBox.Show("Enregistrement réussit!")
                Else
                    MessageBox.Show("Une erreure c'est produit durant l'enregistrement")
                End If
            End If
        Next
        CheckerChange()
    End Sub

    Private Sub DGVCouleur_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvCouleur.CellBeginEdit
        If e.ColumnIndex = 0 Then
            e.Cancel = True
        End If
    End Sub


    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvCouleur.EditingControlShowing
        If dgvCouleur.CurrentCell.ColumnIndex = 3 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress
        End If
    End Sub

    Private Sub TextBox_keyPress(sender As Object, e As KeyPressEventArgs)
        If dgvCouleur.CurrentCell.ColumnIndex = 3 Then
            If (Not Char.IsDigit(e.KeyChar)) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BtDel_Click(sender As Object, e As EventArgs) Handles BtDel.Click
        If MessageBox.Show("Voulez-vous vraiment supprimer " + dgvCouleur.CurrentRow.Cells(1).Value + "?", "Attention!", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ConnectionServeur.Getinstance.GetInfo(dgvCouleur.CurrentRow.Cells(0).Value, "ChangeDelete")
            loadCoul()
        End If
    End Sub

    Private Sub DGVCouleur_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCouleur.CellEndEdit
        CheckerChange()
    End Sub

    Private Sub CheckerChange()
        BTEnregistrer.Enabled = False
        BTAnnuler.Enabled = False
        For r As Integer = 0 To dgvCouleur.Rows.Count - 1
            For c As Integer = 0 To dgvCouleur.Columns.Count - 1
                If Not dgvCouleur.Rows(r).Cells(c).Value = listeOr(r, c) Then
                    BTEnregistrer.Enabled = True
                    BTAnnuler.Enabled = True
                End If
            Next
        Next
    End Sub

    Private Sub UCCouleurTissus_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub
End Class
