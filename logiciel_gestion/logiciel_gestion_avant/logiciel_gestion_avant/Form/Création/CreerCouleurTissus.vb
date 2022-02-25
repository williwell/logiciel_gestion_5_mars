Public Class CreerCouleurTissus
    ReadOnly uc As UCCouleurTissus

    Sub New(UCGestion As UCCouleurTissus)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        uc = UCGestion
    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        If Not String.IsNullOrEmpty(TBNom.Text) Then
            If Not String.IsNullOrEmpty(TBCode.Text) Then
                Dim liste() As String = {TBNom.Text, TBCode.Text}
                If ConnectionServeur.Getinstance.AddDelete(liste, "AddCoulTissus") Then
                    MessageBox.Show("La création de la nouvelle couleur réussit!")

                    Dim row As DataRow = MainForm.tableCoulTis.NewRow
                    Dim nbr As Integer = 0
                    For r As Integer = 0 To MainForm.tableCoulTis.Rows.Count - 1
                        If MainForm.tableCoulTis.Rows(r).Item("id") >= nbr Then
                            nbr = Integer.Parse(MainForm.tableCoulTis.Rows(r).Item("id")) + 1
                        End If
                    Next
                    row(0) = nbr
                    For c As Integer = 0 To liste.Length - 1
                        row(c + 1) = liste(c)
                    Next
                    row(liste.Length + 1) = True
                    MainForm.tableCoulTis.Rows.Add(row)

                    uc.LoadCoul()
                    Me.Close()
                Else
                    MessageBox.Show("Une erreure est survenue durant l'enregistrement!")
                End If
            Else
                MessageBox.Show("La couleur doit avoir un code!")
            End If
        Else
            MessageBox.Show("La couleur doit avoir un nom!")
        End If
    End Sub

    Private Sub NUDCout_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = 110 Or e.KeyCode = 190 Then
            e.SuppressKeyPress = True
            SendKeys.Send(",")
        End If
    End Sub
End Class