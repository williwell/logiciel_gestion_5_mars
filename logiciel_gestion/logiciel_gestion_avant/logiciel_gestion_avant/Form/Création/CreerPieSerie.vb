Public Class CreerPieSerie
    ReadOnly idVe As Integer

    Sub New(id As Integer)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        idVe = id
    End Sub

    Private Sub BTSave_Click(sender As Object, e As EventArgs) Handles BTSave.Click
        If String.IsNullOrEmpty(TBModel.Text) Then
            TBModel.Text = "null"
        End If
        If Not String.IsNullOrEmpty(TBNoSerie.Text) Then
            If Not String.IsNullOrEmpty(TBNom.Text) Then
                Dim listeAdd(4) As String
                listeAdd(0) = TBNoSerie.Text
                listeAdd(1) = TBNom.Text
                listeAdd(2) = TBModel.Text
                listeAdd(3) = DTPInstall.Value
                listeAdd(4) = idVe
                If ConnectionServeur.Getinstance.AddDelete(listeAdd, "addPieSerie") Then
                    MessageBox.Show(MsgTextFr.Getinstance.MsgSauvServ)

                    MainForm.tablePieSerie.Rows.Add(listeAdd)

                    Me.Close()
                Else
                    MessageBox.Show(MsgTextFr.Getinstance.MsgErrServ, "Attention!")
                End If
            Else
                MessageBox.Show(MsgTextFr.Getinstance.MsgMissNom)
            End If
        Else
            MessageBox.Show(MsgTextFr.Getinstance.MsgMissNoSerie)
        End If
    End Sub
End Class