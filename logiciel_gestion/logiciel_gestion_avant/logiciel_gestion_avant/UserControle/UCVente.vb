Public Class UCVente
    ReadOnly main As MainForm
    Dim listeAdd(4) As String
    Shared tableModel As New DataTable
    Dim tableCoulVe As DataTable
    Dim tableCoulToile As DataTable
    Dim TableCoulTissus As DataTable
    Dim bool As Boolean = True
    Dim id As String = "0"
    Dim prix As Decimal
    Dim TPS As Decimal
    Dim TVQ As Decimal
    Dim total As Decimal

    Sub New(form As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = form
    End Sub

    Private Sub UCVente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ucVe2 As New UCVente2(Me, main)
        Dim ucVe3 As New UCVente3(Me, main)
        main.SetUCVente2(ucVe2)
        main.SetUCVente3(ucVe3)
        RemplirCB(tableModel, CBModel, "getModel")

        RemplirCB(tableCoulToile, CBCoulToile, "getCoulToile")

        RemplirCB(TableCoulTissus, CBCoulTissus, "getCoulTissus")

        CBTPS.Checked = True
        CBTVQ.Checked = True
    End Sub

    Private Sub CBModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBModel.SelectedIndexChanged
        tableCoulVe = ConnectionServeur.Getinstance.GetInfo(tableModel(CBModel.SelectedIndex)(0), "getCouleurModel")
        Dim liste(0) As String
        If tableCoulVe.Rows.Count > 0 Then
            ReDim liste(tableCoulVe.Rows.Count - 1)
            For i As Integer = 0 To tableCoulVe.Rows.Count - 1
                liste(i) = tableCoulVe(i)(1) & " - " & tableCoulVe(i)(2)
            Next
        Else
            liste(0) = "Aucune couleur de disponible pour ce model"
        End If
        CBCoulVe.DataSource = liste
        prix = Decimal.Parse(tableModel(CBModel.SelectedIndex)(2))
        TBCout.Text = prix.ToString("0.00$")
    End Sub

    Private Sub RemplirCB(ByRef table As DataTable, CB As ComboBox, str As String)
        table = ConnectionServeur.Getinstance.GetInfo(str)
        Dim liste(table.Rows.Count - 1)
        For i As Integer = 0 To table.Rows.Count - 1
            liste(i) = table(i)(1)
        Next

        CB.DataSource = liste
    End Sub

    Private Sub BTChoisir_Click(sender As Object, e As EventArgs) Handles BTChoisir.Click
        Dim form As New ListeVehicule(Me)
        form.ShowDialog()
    End Sub

    Public Sub NextPage(matricule As String, model As String, coulVe As String, coulToile As String, CoulTissus As String)
        listeAdd(0) = matricule
        listeAdd(1) = model
        listeAdd(2) = coulVe
        listeAdd(3) = coulToile
        listeAdd(4) = CoulTissus
        main.ChangeUCNext1(CBTPS.Checked, CBTVQ.Checked)
    End Sub

    Public Sub NextPage2(liste() As String)
        Dim nbr As Integer = listeAdd.Count
        For i As Integer = 0 To liste.Count - 1
            ReDim Preserve listeAdd(nbr)
            listeAdd(nbr) = liste(i)
            nbr += 1
        Next
    End Sub

    Private Sub BtNext_Click(sender As Object, e As EventArgs) Handles BtNext.Click
        Dim coulVe As String
        If tableCoulVe.Rows.Count = 0 Then
            coulVe = "null"
        Else
            coulVe = tableCoulVe(CBCoulVe.SelectedIndex)(0)
        End If

        Dim coulToile As String
        If tableCoulToile.Rows.Count = 0 Then
            coulToile = "null"
        Else
            coulToile = tableCoulToile(CBCoulToile.SelectedIndex)(0)
        End If

        Dim CoulTissus As String
        If TableCoulTissus.Rows.Count = 0 Then
            CoulTissus = "null"
        Else
            CoulTissus = TableCoulTissus(CBCoulTissus.SelectedIndex)(0)
        End If

        NextPage("null", tableModel(CBModel.SelectedIndex)(0), coulVe, coulToile, CoulTissus)
    End Sub

    Public Function GetIDModel() As String
        Return tableModel(CBModel.SelectedIndex)(0)
    End Function

    Public Function GetListeAdd() As String()
        Return listeAdd
    End Function

    Public Function GetID() As String
        Return id
    End Function

    Public Sub SetID(idV As String)
        id = idV
    End Sub

    Public Function GetDatePre() As Date
        Return DTPPre.Value
    End Function

    Public Sub Clear()
        id = "0"
        CBModel.SelectedIndex = 0
        CBCoulVe.SelectedIndex = 0
        CBCoulToile.SelectedIndex = 0
        CBCoulTissus.SelectedIndex = 0
        DTPPre.Value = Now
    End Sub

    Public Function GetPrix() As String
        Return tableModel(CBModel.SelectedIndex)(2)
    End Function

    Private Sub TBCout_TextChanged(sender As Object, e As EventArgs) Handles TBCout.TextChanged
        changeTaxe()
    End Sub

    Private Sub DTPPre_ValueChanged(sender As Object, e As EventArgs) Handles DTPPre.ValueChanged
        If bool Then
            If DTPPre.Value < Now Then
                bool = False
                DTPPre.Value = Now
                bool = True
            End If
        End If
    End Sub

    Private Sub CBTPS_CheckedChanged(sender As Object, e As EventArgs) Handles CBTPS.CheckedChanged
        changeTaxe()
    End Sub

    Private Sub CBTVQ_CheckedChanged(sender As Object, e As EventArgs) Handles CBTVQ.CheckedChanged
        changeTaxe()
    End Sub

    Private Sub changeTaxe()
        If CBTPS.Checked Then
            TPS = Math.Round(prix * MainForm.GetInstance.GetOption4, 2)
            TBTPS.Text = TPS.ToString("0.00$")
        Else
            TPS = 0
            TBTPS.Text = TPS.ToString("0.00$")
        End If

        If CBTVQ.Checked Then
            TVQ = Math.Round(prix * MainForm.GetInstance.GetOption5, 2)
            TBTVQ.Text = TVQ.ToString("0.00$")
        Else
            TVQ = 0
            TBTVQ.Text = TVQ.ToString("0.00$")
        End If

        total = Math.Round(prix + TPS + TVQ, 2)
        TBTotal.Text = total.ToString("0.00$")
    End Sub

    Public Sub SetTaxe(TPSBool As Boolean, TVQBool As Boolean)
        CBTPS.Checked = TPSBool
        CBTVQ.Checked = TVQBool
    End Sub

    Private Sub UCVente_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub
End Class
