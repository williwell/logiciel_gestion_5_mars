Public Class CreerContrat
    Dim tableCh As New DataTable
    Dim tableDis As New DataTable
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
            liste(r) = MainForm.tableModel.Rows(r).Item("id") & " - " & MainForm.tableModel.Rows(r).Item("nom")
        Next

        CBModel.DataSource = liste


        For r As Integer = 0 To MainForm.tableCoulTis.Rows.Count - 1
            ReDim Preserve liste(r)
            liste(r) = MainForm.tableCoulTis.Rows(r).Item("id") & " - " & MainForm.tableCoulTis.Rows(r).Item("nom")
        Next
        CBCoulTissus.DataSource = liste

        For r As Integer = 0 To MainForm.tableCoulToi.Rows.Count - 1
            ReDim Preserve liste(r)
            liste(r) = MainForm.tableCoulToi.Rows(r).Item("id") & " - " & MainForm.tableCoulToi.Rows(r).Item("nom")
        Next
        CBCoulToile.DataSource = liste
    End Sub

    Private Sub CBModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBModel.SelectedIndexChanged
        Dim idM As Integer
        For r As Integer = 0 To MainForm.tableModel.Rows.Count - 1
            If r = CBModel.SelectedIndex Then
                Dim cout As Double = CDbl(MainForm.tableModel.Rows(r).Item("cout"))
                TBCoutM.Text = cout.ToString("0.00$")
                idM = MainForm.tableModel.Rows(r).Item("id")
                Exit For
            End If
        Next

        Dim liste(-1) As String
        Dim nbr As Integer = 0
        For r As Integer = 0 To MainForm.tableCoulMo.Rows.Count - 1
            If idM = MainForm.tableCoulMo.Rows(r).Item("idmodel") Then
                For r2 As Integer = 0 To MainForm.tableCoulVe.Rows.Count - 1
                    If MainForm.tableCoulMo.Rows(r).Item("idcouleur") = MainForm.tableCoulVe.Rows(r2).Item("id") Then
                        ReDim Preserve liste(nbr)
                        liste(nbr) = MainForm.tableCoulVe.Rows(r2).Item("id") & "-" & MainForm.tableCoulVe.Rows(r2).Item("nom")
                        nbr += 1
                        Exit For
                    End If
                Next
            End If
        Next

        If liste.Length = 0 Then
            ReDim liste(0)
            liste(0) = "Aucune couleur associé à ce model"
        End If
        CBCoulVe.DataSource = liste

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
                If CBCoulVe.SelectedItem.ToString.Substring(0, InStr(CBCoulVe.SelectedItem, "-") - 1) = MainForm.tableCoulVe.Rows(r).Item("id") Then
                    Dim cout As Double = MainForm.tableCoulVe.Rows(r).Item("cout")
                    TBCoutC.Text = cout.ToString("0.00$")
                End If
            Next
        Else
            TBCoutC.Text = "0.00$"
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
            Dim cout As Double = CDbl(TBCoutM.Text) + CDbl(TBCoutC.Text)
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
        If IsNumeric(ChrW(e.KeyValue)) Or (e.KeyValue >= 96 And e.KeyValue <= 105) Or e.KeyValue = 188 Or e.KeyValue = 110 Or e.KeyValue = 190 Or e.KeyValue = 8 Or e.KeyValue = 37 Or e.KeyValue = 39 Then
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
    End Sub

    Private Sub BTNouvVe_Click(sender As Object, e As EventArgs) Handles BTNouvVe.Click
        ChangerEnableVe(True)
    End Sub

    Private Sub BTClEx_Click(sender As Object, e As EventArgs) Handles BTClEx.Click
        ChangerEnableCl(False)
    End Sub

    Private Sub BTNouvCl_Click(sender As Object, e As EventArgs) Handles BTNouvCl.Click
        ChangerEnableCl(True)
    End Sub

End Class