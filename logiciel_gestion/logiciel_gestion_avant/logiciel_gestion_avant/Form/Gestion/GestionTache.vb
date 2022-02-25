Public Class GestionTache
    ReadOnly row As DataGridViewRow
    ReadOnly uc As UCTache

    Sub New(r As DataGridViewRow, uctache As UCTache)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        row = r
        uc = uctache
    End Sub

    Private Sub GestionTache_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If row.Cells(1).Value = 0 Then
            RadioButton1.Checked = True
        Else
            RadioButton2.Checked = True
        End If

        DateTimePicker1.Value = row.Cells(2).Value

        TBNom.Text = row.Cells(3).Value
        TBDesc.Text = row.Cells(4).Value
    End Sub

    Private Sub BTSave_Click(sender As Object, e As EventArgs) Handles BTSave.Click
        Dim liste(4) As String
        liste(0) = row.Cells(0).Value
        If RadioButton1.Checked Then
            liste(1) = 0
        Else
            liste(1) = 1
        End If

        liste(2) = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        liste(3) = TBNom.Text
        liste(4) = TBDesc.Text

        If ConnectionServeur.Getinstance.AddDelete(liste, "modTache") Then
            For r As Integer = 0 To MainForm.tableTache.Rows.Count - 1
                If MainForm.tableTache.Rows(r).Item("id") = liste(0) Then
                    For c As Integer = 1 To MainForm.tableTache.Columns.Count - 1
                        MainForm.tableTache(r)(c) = liste(c)
                        MessageBox.Show("Modification effectuer correctement")
                    Next
                    Exit For
                End If
            Next
            uc.LoadDGV()
            Me.Close()
        Else
            MessageBox.Show("Une erreure est survenu durant l'enregistrement des changements!", "Attention!")
        End If
    End Sub

    Private Sub BTSupp_Click(sender As Object, e As EventArgs) Handles BTSupp.Click
        Me.Close()
    End Sub
End Class