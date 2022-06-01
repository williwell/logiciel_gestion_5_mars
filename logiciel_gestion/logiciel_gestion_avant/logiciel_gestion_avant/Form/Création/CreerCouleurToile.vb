Public Class CreerCouleurToile
    ReadOnly uc As UCCouleurToile

    Sub New(ucCoul As UCCouleurToile)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        uc = ucCoul
    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        If Not String.IsNullOrEmpty(TBNom.Text) Then
            If Not String.IsNullOrEmpty(TBCode.Text) Then
                Dim liste() As String = {TBNom.Text, TBCode.Text}
                If ConnectionServeur.Getinstance.AddDelete(liste, "AddCoulToile") Then
                    MessageBox.Show(MsgTextFr.Getinstance.MsgCreationCoul)

                    Dim row As DataRow = MainForm.tableCoulToi.NewRow
                    Dim nbr As Integer = 0
                    For r As Integer = 0 To MainForm.tableCoulToi.Rows.Count - 1
                        If MainForm.tableCoulToi.Rows(r).Item("id") >= nbr Then
                            nbr = Integer.Parse(MainForm.tableCoulToi.Rows(r).Item("id")) + 1
                        End If
                    Next
                    row(0) = nbr
                    For c As Integer = 0 To liste.Length - 1
                        row(c + 1) = liste(c)
                    Next
                    row(liste.Length + 1) = True
                    MainForm.tableCoulToi.Rows.Add(row)

                    uc.LoadCoul()
                    Me.Close()
                Else
                    MessageBox.Show(MsgTextFr.Getinstance.MsgErrServ)
                End If
            Else
                MessageBox.Show(MsgTextFr.Getinstance.MsgMissCodeCoul)
            End If
        Else
            MessageBox.Show(MsgTextFr.Getinstance.MsgMissNomCoul)
        End If
    End Sub

    Private Sub NUDCout_KeyDown(sender As Object, e As KeyEventArgs)
        Dim lang = Globalization.CultureInfo.CurrentCulture
        If lang.Name = "fr-CA" Then
            If e.KeyCode = 110 Or e.KeyCode = 190 Then
                e.SuppressKeyPress = True
                SendKeys.Send(",")
            End If
        End If
    End Sub
End Class