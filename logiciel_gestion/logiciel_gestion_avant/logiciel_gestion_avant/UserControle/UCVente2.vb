Public Class UCVente2
    ReadOnly main As MainForm
    ReadOnly uc As UCVente
    Dim table As DataTable
    ReadOnly tableCh As New DataTable
    Dim id As Integer
    Dim prix As Decimal
    Dim TPS As Decimal
    Dim TVQ As Decimal

    Sub New(ucVente As UCVente, form As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = form
        uc = ucVente
    End Sub

    Private Sub UCVente2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id = uc.getIDModel
        table = ConnectionServeur.Getinstance.GetInfo(id, "getOptionModel")
        DGVOpDispo.DataSource = table
        For i As Integer = 0 To table.Columns.Count - 1
            tableCh.Columns.Add(table.Columns(i).ColumnName)
        Next
        DGVOpCh.DataSource = tableCh
    End Sub

    Public Sub LoadDGV()
        If Not id = uc.GetIDModel Then
            id = uc.GetIDModel
            table = ConnectionServeur.Getinstance.GetInfo(id, "getOptionModel")
            DGVOpDispo.DataSource = table

            For i As Integer = DGVOpCh.Rows.Count - 1 To 0 Step -1
                DGVOpCh.Rows.RemoveAt(i)
            Next
        End If
    End Sub

    Private Sub BTPrev_Click(sender As Object, e As EventArgs) Handles BTPrev.Click
        main.ChangeUCPrev1(CBTPS.Checked, CBTVQ.Checked)
    End Sub

    Private Sub BTNext_Click(sender As Object, e As EventArgs) Handles BTNext.Click
        Dim liste(0) As String
        Dim nbr As Integer = 0

        For i As Integer = 0 To DGVOpCh.Rows.Count - 1
            ReDim Preserve liste(nbr)
            liste(nbr) = DGVOpCh.Rows(i).Cells(0).Value
            nbr += 1
        Next
        uc.nextPage2(liste)

        main.ChangeUCNext2()
    End Sub

    Private Sub DGVOpDispo_DoubleClick(sender As Object, e As EventArgs) Handles DGVOpDispo.DoubleClick
        ListGest.PopulateRow(tableCh, DGVOpDispo, DGVOpCh)
        checkPrix()
    End Sub

    Private Sub DGVOpCh_DoubleClick(sender As Object, e As EventArgs) Handles DGVOpCh.DoubleClick
        ListGest.PopulateRow(table, DGVOpCh, DGVOpDispo)
        checkPrix()
    End Sub

    Public Sub SetPrix(prixMo As String, tpsbool As Boolean, tvqbool As Boolean)
        prix = Math.Round(Double.Parse(prixMo), 2)
        CBTPS.Checked = tpsbool
        CBTVQ.Checked = tvqbool

        CheckPrix()
    End Sub

    Private Sub CheckPrix()
        Dim d As Double = prix
        For i As Integer = 0 To DGVOpCh.Rows.Count - 1
            d += DGVOpCh.Rows(i).Cells(2).Value
        Next

        If CBTPS.Checked Then
            TPS = Math.Round(d * MainForm.GetInstance.GetOption4, 2)
            TBTPS.Text = TPS.ToString("0.00$")
        Else
            TPS = 0
            TBTPS.Text = TPS.ToString("0.00$")
        End If

        If CBTVQ.Checked Then
            TVQ = Math.Round(d * MainForm.GetInstance.GetOption5, 2)
            TBTVQ.Text = TVQ.ToString("0.00$")
        Else
            TVQ = 0
            TBTVQ.Text = TVQ.ToString("0.00$")
        End If

        TBCout.Text = d

        TBTotal.Text = Math.Round(d + TPS + TVQ, 2).ToString("0.00$")
    End Sub

    Private Sub CBTPS_CheckedChanged(sender As Object, e As EventArgs) Handles CBTPS.CheckedChanged, CBTVQ.CheckedChanged
        CheckPrix()
    End Sub

    Private Sub UCVente2_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub
End Class
