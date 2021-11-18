Public Class UCCouleurToile
    Dim main As MainForm
    Dim tableCoul As DataTable
    Dim listeOr(0, 0) As String

    Sub New(mainform As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = mainform
    End Sub

    Private Sub UCCouleurToile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCoul()
    End Sub

    Private Sub BtCreer_Click(sender As Object, e As EventArgs) Handles BtCreer.Click
        Dim NewCoul As New CreerCouleurToile(Me)
        NewCoul.ShowDialog()
    End Sub

    Public Sub LoadCoul()
        ListGest.LoadCoul(tableCoul, "getCoulToile", dgvCouleur, listeOr)
    End Sub



    Private Sub BTAnnuler_Click(sender As Object, e As EventArgs) Handles BTAnnuler.Click
        For r As Integer = 0 To dgvCouleur.Rows.Count - 1
            For c As Integer = 0 To dgvCouleur.Columns.Count - 1
                tableCoul(r)(c) = listeOr(r, c)
            Next
        Next
        CheckerChange()
    End Sub

    Public Sub RemplirDGV()
        tableCoul = ConnectionServeur.Getinstance.GetInfo("getCouleur")
        dgvCouleur.DataSource = tableCoul
        ReDim listeOr(tableCoul.Rows.Count - 1, tableCoul.Columns.Count - 1)
        For r As Integer = 0 To tableCoul.Rows.Count - 1
            For c As Integer = 0 To tableCoul.Columns.Count - 1
                listeOr(r, c) = tableCoul(r)(c)
            Next
        Next
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
            RemplirDGV()
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

    Private Sub UCCouleurToile_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub
End Class
