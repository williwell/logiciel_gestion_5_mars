Public Class CreerContrat
    Dim idVe As Integer = 0
    Dim idCl As Integer = 0
    ReadOnly tableCh As New DataTable
    ReadOnly tableDis As New DataTable
    Dim listeIDM(0) As String
    Dim listeIDCoulVe(0) As String
    Dim listeIDCoulTis(0) As String
    Dim listeIDCoulToi(0) As String

    Private Sub CreerContrat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim liste(0) As String

        For c As Integer = 0 To MainForm.tableOp.Columns.Count - 2
            tableCh.Columns.Add(MainForm.tableOp.Columns(c).ColumnName)
        Next
        DGVOptionCh.DataSource = tableCh

        For c As Integer = 0 To MainForm.tableOp.Columns.Count - 2
            tableDis.Columns.Add(MainForm.tableOp.Columns(c).ColumnName)
        Next
        DGVOptionDis.DataSource = tableDis

        DGVOptionCh.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGVOptionDis.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        For r As Integer = 0 To MainForm.tableModel.Rows.Count - 1
            ReDim Preserve liste(r)
            liste(r) = MainForm.tableModel.Rows(r).Item("nom")
            ReDim Preserve listeIDM(r)
            listeIDM(r) = MainForm.tableModel.Rows(r).Item("id")
        Next

        CBModel.DataSource = liste


        For r As Integer = 0 To MainForm.tableCoulTis.Rows.Count - 1
            ReDim Preserve liste(r)
            liste(r) = MainForm.tableCoulTis.Rows(r).Item("nom")
            ReDim Preserve listeIDCoulTis(r)
            listeIDCoulTis(r) = MainForm.tableCoulTis.Rows(r).Item("id")
        Next
        CBCoulTissus.DataSource = liste

        For r As Integer = 0 To MainForm.tableCoulToi.Rows.Count - 1
            ReDim Preserve liste(r)
            liste(r) = MainForm.tableCoulToi.Rows(r).Item("nom")
            ReDim Preserve listeIDCoulToi(r)
            listeIDCoulToi(r) = MainForm.tableCoulToi.Rows(r).Item("id")
        Next
        CBCoulToile.DataSource = liste
        CBSexe.SelectedIndex = 0
    End Sub

    Private Sub CBModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBModel.SelectedIndexChanged
        SetComboBox()
    End Sub

    Private Sub SetComboBox()
        Dim idM As Integer
        ReDim listeIDCoulVe(0)

        tableCh.Clear()
        tableDis.Clear()
        CBCoulVe.Items.Clear()

        For r As Integer = 0 To MainForm.tableModel.Rows.Count - 1
            If r = CBModel.SelectedIndex Then
                Dim cout As Double = CDbl(MainForm.tableModel.Rows(r).Item("cout"))
                TBCoutM.Text = cout.ToString("0.00$")
                idM = MainForm.tableModel.Rows(r).Item("id")
                Exit For
            End If
        Next

        Dim nbr As Integer = 0
        For r As Integer = 0 To MainForm.tableCoulMo.Rows.Count - 1
            If idM = MainForm.tableCoulMo.Rows(r).Item("idmodel") Then
                For r2 As Integer = 0 To MainForm.tableCoulVe.Rows.Count - 1
                    If MainForm.tableCoulMo.Rows(r).Item("idcouleur") = MainForm.tableCoulVe.Rows(r2).Item("id") Then
                        CBCoulVe.Items.Add(MainForm.tableCoulVe.Rows(r2).Item("nom"))
                        ReDim Preserve listeIDCoulVe(nbr)
                        listeIDCoulVe(nbr) = MainForm.tableCoulVe.Rows(r2).Item("id")
                        Exit For
                    End If
                Next
            End If
        Next

        If CBCoulVe.Items.Count = 0 Then
            CBCoulVe.Items.Add("Aucune couleur associé à ce model")
        End If

        CBCoulVe.SelectedIndex = 0

        For r As Integer = 0 To MainForm.tableOpMo.Rows.Count - 1
            If idM = MainForm.tableOpMo.Rows(r).Item("idmodel") Then
                For r2 As Integer = 0 To MainForm.tableOp.Rows.Count - 1
                    If MainForm.tableOp.Rows(r2).Item("id") = MainForm.tableOpMo.Rows(r).Item("idoption") And MainForm.tableOp.Rows(r2).Item("deleteopt") = True Then
                        Dim row As DataRow = tableDis.NewRow
                        For c As Integer = 0 To MainForm.tableOp.Columns.Count - 2
                            row(c) = MainForm.tableOp(r2)(c)
                        Next
                        tableDis.Rows.Add(row)
                    End If
                Next
            End If
        Next

        CheckPrix()
    End Sub

    Private Sub CBCoulVe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCoulVe.SelectedIndexChanged
        If CBCoulVe.SelectedItem <> "Aucune couleur associé à ce model" Then
            For r As Integer = 0 To MainForm.tableCoulVe.Rows.Count - 1
                If CBCoulVe.SelectedItem = MainForm.tableCoulVe.Rows(r).Item("nom") Then
                    Dim cout As Double = MainForm.tableCoulVe.Rows(r).Item("cout")
                    TBCoutC.Text = cout.ToString("0.00$")
                End If
            Next
        Else
            TBCoutC.Text = "0,00$"
        End If
        CheckPrix()
    End Sub

    Private Sub DGVOptionCh_DoubleClick(sender As Object, e As EventArgs) Handles DGVOptionCh.DoubleClick
        ListGest.PopulateRow(tableDis, DGVOptionCh, DGVOptionDis)
        CheckPrix()
    End Sub

    Private Sub DGVOptionDis_DoubleClick(sender As Object, e As EventArgs) Handles DGVOptionDis.DoubleClick
        ListGest.PopulateRow(tableCh, DGVOptionDis, DGVOptionCh)
        CheckPrix()
    End Sub

    Private Sub CheckPrix()
        If TBCoutM.Text <> "" Then
            Dim cout As Double = CDbl(TBCoutM.Text) '+ CDbl(TBCoutC.Text)
            For r As Integer = 0 To DGVOptionCh.Rows.Count - 1
                cout += CDbl(DGVOptionCh.Rows(r).Cells("cout").Value)
            Next
            TBTotal.Text = cout.ToString("0.00$")
            If TBEchange.Text <> "" Then
                TBEchange.Text = CDbl(TBEchange.Text).ToString("0.00$")
            Else
                TBEchange.Text = "0,00$"
            End If
            TBSousTotal.Text = (CDbl(TBTotal.Text) - CDbl(TBEchange.Text)).ToString("0.00$")
            If CBTPS.Checked Then
                TBTPS.Text = (CDbl(TBSousTotal.Text) * MainForm.GetInstance.GetOption4).ToString("0.00$")
            Else
                TBTPS.Text = "0,00$"
            End If
            If CBTVQ.Checked Then
                TBTVQ.Text = (CDbl(TBSousTotal.Text) * MainForm.GetInstance.GetOption5).ToString("0.00$")
            Else
                TBTVQ.Text = "0,00$"
            End If
            If TBAccompte.Text <> "" Then
                TBAccompte.Text = CDbl(TBAccompte.Text).ToString("0.00$")
            Else
                TBAccompte.Text = "0,00$"
            End If
            TBTotalFin.Text = (CDbl(TBSousTotal.Text) + CDbl(TBTPS.Text) + CDbl(TBTVQ.Text)).ToString("0.00$")
            TBBalance.Text = (CDbl(TBTotalFin.Text) - CDbl(TBAccompte.Text)).ToString("0.00$")
        End If
    End Sub

    Private Sub TBEchange_Leave(sender As Object, e As EventArgs) Handles TBEchange.Leave, TBAccompte.Leave, CBTPS.CheckedChanged, CBTVQ.CheckedChanged
        CheckPrix()
    End Sub

    Private Sub TBEchange_KeyDown(sender As Object, e As KeyEventArgs) Handles TBEchange.KeyDown, TBAccompte.KeyDown
        If IsNumeric(ChrW(e.KeyValue)) Or (e.KeyValue >= 96 And e.KeyValue <= 105) Or e.KeyValue = 188 Or e.KeyValue = 110 Or e.KeyValue = 190 Or e.KeyValue = 8 Or e.KeyValue = 37 Or e.KeyValue = 39 Or e.KeyValue = 46 Then
            If e.KeyValue = 110 Or e.KeyValue = 190 Then
                e.SuppressKeyPress = True
                If Not (TBEchange.Text.Contains(",") And TBAccompte.Text.Contains(",")) Then
                    SendKeys.Send(",")
                End If
            End If
            If e.KeyValue = 188 Then
                If TBEchange.Text.Contains(",") And TBAccompte.Text.Contains(",") Then
                    e.SuppressKeyPress = True
                End If
            End If
        Else
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub ChangerEnableVe(bool As Boolean)
        BTNouvVe.Enabled = Not bool
        BTVeEx.Enabled = bool
        CBModel.Enabled = bool
        CBCoulVe.Enabled = bool
        CBCoulToile.Enabled = bool
        CBCoulTissus.Enabled = bool
    End Sub

    Private Sub ChangerEnableCl(bool As Boolean)
        BTClEx.Enabled = bool
        BTNouvCl.Enabled = Not bool
        TBPrenom1.Enabled = bool
        TBNom1.Enabled = bool
        TBPrenom2.Enabled = bool
        TBNom2.Enabled = bool
        TBTel1.Enabled = bool
        TBTel2.Enabled = bool
        CBSexe.Enabled = bool
        TBEmail.Enabled = bool
        TBAddresse.Enabled = bool
        TBVille.Enabled = bool
        TBProvince.Enabled = bool
        TBApp.Enabled = bool
        TBCodePos.Enabled = bool
    End Sub

    Private Sub BTVeEx_Click(sender As Object, e As EventArgs) Handles BTVeEx.Click
        ChangerEnableVe(False)
        Dim form As New ListeVehicule(Me)
        form.ShowDialog(Me)
    End Sub

    Private Sub BTNouvVe_Click(sender As Object, e As EventArgs) Handles BTNouvVe.Click
        ChangerEnableVe(True)
        SetComboBox()
    End Sub

    Private Sub BTClEx_Click(sender As Object, e As EventArgs) Handles BTClEx.Click
        ChangerEnableCl(False)
        Dim ListCl As New ListeClient(Me)
        ListCl.ShowDialog(Me)
    End Sub

    Private Sub BTNouvCl_Click(sender As Object, e As EventArgs) Handles BTNouvCl.Click
        ChangerEnableCl(True)
        idCl = 0
        TBPrenom1.Text = ""
        TBNom1.Text = ""
        TBPrenom2.Text = ""
        TBNom2.Text = ""
        TBTel1.Text = ""
        TBTel2.Text = ""
        CBSexe.SelectedIndex = 0
        TBEmail.Text = ""
        TBAddresse.Text = ""
        TBVille.Text = ""
        TBProvince.Text = ""
        TBApp.Text = ""
        TBCodePos.Text = ""
    End Sub

    Private Sub BTAnnuler_Click(sender As Object, e As EventArgs) Handles BTAnnuler.Click
        If MessageBox.Show("Voulez-vous vraiment annuler ce contrat?", "Attention", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Public Sub SetIDCl(row As DataGridViewRow)
        idCl = row.Cells("id").Value
        TBPrenom1.Text = row.Cells("prenom1").Value
        TBNom1.Text = row.Cells("nom1").Value
        TBPrenom2.Text = row.Cells("prenom2").Value
        TBNom2.Text = row.Cells("nom2").Value
        TBTel1.Text = row.Cells("telephone1").Value
        TBTel2.Text = row.Cells("telephone2").Value

        For i As Integer = 0 To CBSexe.Items.Count - 1
            CBSexe.SelectedIndex = i
            If CBSexe.SelectedItem = row.Cells("sexe").Value Then
                Exit For
            End If
        Next

        TBEmail.Text = row.Cells("email").Value

        If row.Cells("addresse").Value <> "null" Then
            Dim str As String = row.Cells("addresse").Value
            TBAddresse.Text = str.Substring(0, str.IndexOf(","))
            str = str.Substring(str.IndexOf(",") + 1)
            TBVille.Text = str.Substring(0, str.IndexOf(","))
            str = str.Substring(str.IndexOf(",") + 1)
            TBProvince.Text = str
        Else
            TBAddresse.Text = "null"
            TBVille.Text = "null"
            TBProvince.Text = "null"
        End If

        TBApp.Text = row.Cells("app").Value
        TBCodePos.Text = row.Cells("codepostal").Value
    End Sub

    Public Sub SetIDVe(row As DataGridViewRow)
        idVe = row.Cells("id").Value
        For i As Integer = 0 To CBModel.Items.Count - 1
            CBModel.SelectedIndex = i
            If CBModel.SelectedItem = row.Cells("model").Value Then
                Exit For
            End If
        Next
        'For r As Integer = 0 To MainForm.tableCoulVe.Rows.Count - 1
        '    If MainForm.tableCoulVe.Rows(r).Item("nom") = row.Cells("nom").Value Then
        CBCoulVe.Items.Add(row.Cells("couleur véhicule").Value)
        CBCoulVe.SelectedItem = row.Cells("couleur véhicule").Value

        'End If
        'Next

    End Sub

    Private Sub BTSave_Click(sender As Object, e As EventArgs) Handles BTSave.Click
        If idCl = 0 Then
            Dim strErr As String = ""
            If String.IsNullOrEmpty(TBPrenom1.Text) Then
                strErr = "Vous devez mettre un prénom"
            End If
            If String.IsNullOrEmpty(TBNom1.Text) Then
                If String.IsNullOrEmpty(strErr) Then
                    strErr = "Vous devez mettre un nom"
                Else
                    strErr += ", vous devez avoir un nom"
                End If
            End If
            If String.IsNullOrEmpty(TBTel1.Text) Then
                If String.IsNullOrEmpty(strErr) Then
                    strErr = "Vous devez mettre un numéro de téléphone"
                Else
                    strErr += ", vous devez avoir un numéro de téléphone"
                End If
            End If

            If Not String.IsNullOrEmpty(strErr) Then
                strErr += "!"
                MessageBox.Show(strErr)
            Else
                If String.IsNullOrEmpty(TBTel2.Text) Then
                    TBTel2.Text = "null"
                End If
                If String.IsNullOrEmpty(TBPrenom2.Text) Then
                    TBPrenom2.Text = "null"
                End If
                If String.IsNullOrEmpty(TBNom2.Text) Then
                    TBNom2.Text = "null"
                End If
                If String.IsNullOrEmpty(TBEmail.Text) Then
                    TBEmail.Text = "null"
                End If
                If String.IsNullOrEmpty(TBAddresse.Text) And String.IsNullOrEmpty(TBVille.Text) And String.IsNullOrEmpty(TBProvince.Text) Then
                    TBAddresse.Text = "null"
                End If
                If String.IsNullOrEmpty(TBApp.Text) Then
                    TBApp.Text = "null"
                End If
                If String.IsNullOrEmpty(TBCodePos.Text) Then
                    TBCodePos.Text = "null"
                End If

                Dim liste(10) As String

                liste(0) = TBPrenom1.Text
                liste(1) = TBNom1.Text
                liste(2) = TBPrenom2.Text
                liste(3) = TBNom2.Text
                liste(4) = TBTel1.Text
                liste(5) = TBTel2.Text
                liste(6) = CBSexe.SelectedItem
                liste(7) = TBEmail.Text
                If TBAddresse.Text = "null" Then
                    liste(8) = TBAddresse.Text
                Else
                    liste(8) = TBAddresse.Text & ", " & TBVille.Text & ", " & TBProvince.Text
                End If
                liste(9) = TBApp.Text
                liste(10) = TBCodePos.Text

                idCl = ConnectionServeur.Getinstance.GetInfo(liste, "addclientId")(0)(0)
                If idCl <> 0 Then
                    Dim row As DataRow = MainForm.TableClient.NewRow
                    row(0) = idCl
                    row(1) = TBPrenom1.Text
                    row(2) = TBNom1.Text
                    row(3) = TBPrenom2.Text
                    row(4) = TBNom2.Text
                    row(5) = TBTel1.Text
                    row(6) = TBTel2.Text
                    row(7) = CBSexe.SelectedItem
                    row(8) = TBEmail.Text
                    If TBAddresse.Text = "null" Then
                        row(9) = TBAddresse.Text
                    Else
                        row(9) = TBAddresse.Text & ", " & TBVille.Text & ", " & TBProvince.Text
                    End If
                    row(10) = TBApp.Text
                    row(11) = TBCodePos.Text
                    MainForm.TableClient.Rows.Add(row)
                    SaveVe()
                Else
                    MessageBox.Show("Une erreur est survenu durant l'enregistrement")
                End If
            End If
        Else
            SaveVe()
        End If
    End Sub

    Private Sub SaveVe()
        If idVe = 0 Then
            Dim liste(4) As String

            liste(0) = "null"
            liste(1) = listeIDM(CBModel.SelectedIndex)
            liste(2) = listeIDCoulVe(CBCoulVe.SelectedIndex)
            liste(3) = listeIDCoulToi(CBCoulToile.SelectedIndex)
            liste(4) = listeIDCoulTis(CBCoulTissus.SelectedIndex)
            idVe = ConnectionServeur.Getinstance.GetInfo(liste, "addvehicule")(0)(0)

            If idVe <> 0 Then
                Dim row As DataRow = MainForm.tableVe.NewRow
                row(0) = idVe
                row(1) = "null"
                row(2) = listeIDM(CBModel.SelectedIndex)
                row(3) = listeIDCoulVe(CBCoulVe.SelectedIndex)
                row(4) = listeIDCoulToi(CBCoulToile.SelectedIndex)
                row(5) = listeIDCoulTis(CBCoulTissus.SelectedIndex)
                row(6) = 0
                row(7) = 0
                SaveOp()
            Else
                MessageBox.Show("Une erreure est survenu durant l'enregistrement du Véhicule")
            End If
        Else
            SaveOp()
        End If
    End Sub

    Private Sub SaveOp()
        Dim listeAdd(0) As String
        listeAdd(0) = idVe
        Dim nbr As Integer = 0

        For r As Integer = 0 To DGVOptionCh.Rows.Count - 1
            nbr += 2
            ReDim Preserve listeAdd(nbr)
            listeAdd(nbr - 1) = DGVOptionCh.Rows(r).Cells("id").Value
            listeAdd(nbr) = DGVOptionCh.Rows(r).Cells("cout").Value
        Next

        If listeAdd.Length <> 1 Then
            If ConnectionServeur.Getinstance.AddDelete(listeAdd, "AddOpVe") Then
                For r As Integer = 0 To DGVOptionCh.Rows.Count - 1
                    Dim row As DataRow = MainForm.tableOpVe.NewRow
                    row(0) = DGVOptionCh.Rows(r).Cells("id").Value
                    row(1) = idVe
                    row(2) = DGVOptionCh.Rows(r).Cells("cout").Value
                    MainForm.tableOpVe.Rows.Add(row)
                Next
                SaveVente()
            Else
                MessageBox.Show("Une erreur est survenu durant l'enregistrement des options avec le véhicule")
            End If
        Else
            SaveVente()
        End If
    End Sub

    Private Sub SaveVente()
        Dim ListeAdd(10) As String
        ListeAdd(0) = idVe
        ListeAdd(1) = idCl
        ListeAdd(2) = Date.Now.ToString("yyyy-MM-dd")
        ListeAdd(3) = TBCoutM.Text.Substring(0, TBCoutM.Text.IndexOf("$"))
        ListeAdd(4) = TBCoutC.Text.Substring(0, TBCoutC.Text.IndexOf("$"))
        ListeAdd(5) = TBEchange.Text.Substring(0, TBEchange.Text.IndexOf("$"))
        ListeAdd(6) = TBAccompte.Text.Substring(0, TBAccompte.Text.IndexOf("$"))
        'ListeAdd(7) = TBPayerLiv.Text.Substring(0, TBPayerLiv.Text.IndexOf("$"))
        'ListeAdd(8) = TBRemettreCl.Text.Substring(0, TBRemettreCl.Text.IndexOf("$"))
        ListeAdd(7) = 0
        ListeAdd(8) = 0
        ListeAdd(9) = MainForm.GetInstance.GetOption4
        ListeAdd(10) = MainForm.GetInstance.GetOption5

        Dim table As DataTable = ConnectionServeur.Getinstance.GetInfo(ListeAdd, "addfacture")
        Dim idFac As Integer = table(0)(0)
        If idfac <> 0 Then
            MessageBox.Show("Ajout fait avec succès")

            Dim row2 As DataRow = MainForm.tableFacture.NewRow
            row2(0) = idFac
            row2(1) = idVe
            row2(2) = idCl
            row2(3) = Date.Now.ToString("yyyy-MM-dd")
            row2(4) = TBCoutM.Text.Substring(0, TBCoutM.Text.IndexOf("$"))
            row2(5) = TBCoutC.Text.Substring(0, TBCoutC.Text.IndexOf("$"))
            row2(6) = TBEchange.Text.Substring(0, TBCoutC.Text.IndexOf("$"))
            row2(7) = TBAccompte.Text.Substring(0, TBAccompte.Text.IndexOf("$"))
            'row2(8) = TBPayerLiv.Text.Substring(0, TBPayerLiv.Text.IndexOf("$"))
            ListeAdd(9) = 0
            ListeAdd(8) = 0
            'row2(9) = TBRemettreCl.Text.Substring(0, TBRemettreCl.Text.IndexOf("$"))
            row2(10) = MainForm.GetInstance.GetOption4
            row2(11) = MainForm.GetInstance.GetOption5

            MainForm.tableFacture.Rows.Add(row2)

            Dim print As New PrintingForm(row2)
            print.Show()

            Me.Close()
        Else
            MessageBox.Show("Une erreure est survenu durant l'enregistrement de la facture!", "Attention!")
        End If
    End Sub
End Class