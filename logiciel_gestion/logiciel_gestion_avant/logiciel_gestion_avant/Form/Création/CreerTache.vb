Public Class CreerTache
    ReadOnly tache As UCTache

    Sub New(uc As UCTache)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        tache = uc
    End Sub

    Private Sub BTSave_Click(sender As Object, e As EventArgs) Handles BTSave.Click
        Dim liste(3) As String

        If RadioButton1.Checked Then
            liste(0) = 0
        Else
            liste(0) = 1
        End If

        liste(1) = DateTimePicker1.Value.ToString("yyyy-MM-dd")

        If String.IsNullOrEmpty(TBDesc.Text) Then
            liste(3) = "null"
        Else
            liste(3) = TBDesc.Text
        End If

        If String.IsNullOrEmpty(TBNom.Text) Then
            MessageBox.Show("Vous devez avoir un titre de mit!")
        ElseIf TBNom.Text.Length <= 100 Then
            liste(2) = TBNom.Text
            Dim id As String = ConnectionServeur.Getinstance.GetInfo(liste, "addTache")(0)(0)
            If id <> "0" Then
                MessageBox.Show("Ajout de la tâche réussit!")
                Dim row As DataRow = MainForm.tableTache.NewRow
                row(0) = id
                For c As Integer = 1 To MainForm.tableTache.Columns.Count - 1
                    row(c) = liste(c - 1)
                Next
                MainForm.tableTache.Rows.Add(row)
                tache.LoadDGV()
                Me.Close()
            Else
                MessageBox.Show("Une erreure est survenu durant l'enregistrement sur le serveur!")
            End If
        Else
            MessageBox.Show("Le titre est trop long! (Maximun de 100 caratères)")
        End If
    End Sub

    Private Sub BTSupp_Click(sender As Object, e As EventArgs) Handles BTSupp.Click
        Me.Close()
    End Sub
End Class