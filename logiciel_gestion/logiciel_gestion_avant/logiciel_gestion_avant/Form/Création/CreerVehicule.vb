Public Class CreerVehicule
    ReadOnly tableDis As New DataTable
    ReadOnly tableCh As New DataTable
    Dim listeIDM(0) As String
    Dim listeIDCoulVe(0) As String
    Dim listeIDCoulTis(0) As String
    Dim listeIDCoulToi(0) As String
    Dim listeCoul(-1) As String
    Dim gestVe As UCGestionVehicule

    Sub New(uc As UCGestionVehicule)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        gestVe = uc
    End Sub

    Private Sub CreerVehicule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim liste(-1) As String

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

        If liste.Length <> 0 Then
            CBModel.DataSource = liste
        Else
            CBModel.Items.Add(MsgTextFr.Getinstance.MsgMissModel)
            CBModel.SelectedIndex = 0
            BTSave.Enabled = False
        End If

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

        NUDAnnee.Value = Date.Now.ToString("yyyy")
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
            CBCoulVe.Items.Add(MsgTextFr.Getinstance.MsgMissCoulModel)
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
    End Sub

    Private Sub DGVOptionCh_DoubleClick(sender As Object, e As EventArgs) Handles DGVOptionCh.DoubleClick
        ListGest.PopulateRow(tableDis, DGVOptionCh, DGVOptionDis)
    End Sub

    Private Sub DGVOptionDis_DoubleClick(sender As Object, e As EventArgs) Handles DGVOptionDis.DoubleClick
        ListGest.PopulateRow(tableCh, DGVOptionDis, DGVOptionCh)
    End Sub

    Private Sub BTCouleur_Click(sender As Object, e As EventArgs) Handles BTCouleur.Click
        Dim form As New AddCoulContrat(listeCoul, Me)
        form.ShowDialog()
    End Sub

    Public Sub RemplirListe(lst() As String)
        listeCoul = lst
    End Sub

    Private Sub BTAnnuler_Click(sender As Object, e As EventArgs) Handles BTAnnuler.Click
        Me.Close()
    End Sub

    Private Sub BTSave_Click(sender As Object, e As EventArgs) Handles BTSave.Click
        If String.IsNullOrEmpty(TBNIV.Text) Then
            TBNIV.Text = "null"
        End If
        If String.IsNullOrEmpty(TBChassi.Text) Then
            TBChassi.Text = "null"
        End If

        Dim liste(6) As String
        liste(0) = TBNIV.Text
        liste(1) = listeIDM(CBModel.SelectedIndex)
        liste(2) = TBChassi.Text
        liste(3) = NUDAnnee.Value
        If CBCoulVe.SelectedItem <> MsgTextFr.Getinstance.MsgMissCoulModel Then
            liste(4) = listeIDCoulVe(CBCoulVe.SelectedIndex)
        Else
            liste(4) = 0
        End If
        liste(5) = listeIDCoulToi(CBCoulToile.SelectedIndex)
        liste(6) = listeIDCoulTis(CBCoulTissus.SelectedIndex)

        Dim id As String = ConnectionServeur.Getinstance.GetInfo(liste, "addvehicule")(0)(0)

        If id <> 0 Then
            Dim row As DataRow = MainForm.tableVe.NewRow
            row(0) = id
            For i As Integer = 0 To liste.Length - 1
                row(i + 1) = liste(i)
            Next
            row(8) = 0
            row(9) = 0
            MainForm.tableVe.Rows.Add(row)
            gestVe.LoadDGV()
            Dim listeOpt(0) As String
            listeOpt(0) = id
            Dim nbr As Integer = 2
            For r As Integer = 0 To DGVOptionCh.Rows.Count - 1
                ReDim Preserve listeOpt(nbr)
                listeOpt(nbr - 1) = DGVOptionCh.Rows(r).Cells("id").Value
                listeOpt(nbr) = DGVOptionCh.Rows(r).Cells("cout").Value
                nbr += 2
            Next

            If listeOpt.Length > 1 Then
                If ConnectionServeur.Getinstance.AddDelete(listeOpt, "addopVe") Then
                    For r As Integer = 0 To DGVOptionCh.Rows.Count - 1
                        Dim row2 As DataRow = MainForm.tableOpVe.NewRow
                        row2(0) = DGVOptionCh.Rows(r).Cells("id").Value
                        row2(1) = id
                        row2(2) = DGVOptionCh.Rows(r).Cells("cout").Value
                        MainForm.tableOpVe.Rows.Add(row2)
                    Next
                    If listeCoul.Length > 0 Then
                        Dim tableId As DataTable = ConnectionServeur.Getinstance.AddDeleteListeTable(listeCoul, id, "addCoulSupp")
                        If tableId(0)(0) <> -1 Then
                            For r As Integer = 0 To tableId.Rows.Count - 1
                                Dim row3 As DataRow = MainForm.tableCoulSupp.NewRow
                                row3(0) = tableId(r)(0)
                                row3(1) = listeCoul(3 * r)
                                row3(2) = listeCoul(3 * r + 1)
                                row3(3) = listeCoul(3 * r + 2)
                                row3(4) = id
                                MainForm.tableCoulSupp.Rows.Add(row3)
                            Next
                            MessageBox.Show(MsgTextFr.Getinstance.MsgSauvServ)
                            Me.Close()
                        Else
                            MessageBox.Show(MsgTextFr.Getinstance.MsgErrServ, MsgTextFr.Getinstance.MsgAttention)
                        End If
                    End If
                Else
                        MessageBox.Show(MsgTextFr.Getinstance.MsgErrServ, MsgTextFr.Getinstance.MsgAttention)
                End If
            End If
        Else
            MessageBox.Show(MsgTextFr.Getinstance.MsgErrServ, MsgTextFr.Getinstance.MsgAttention)
        End If
    End Sub
End Class