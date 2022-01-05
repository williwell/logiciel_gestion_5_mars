Public Class UCVente2
    ReadOnly main As MainForm
    ReadOnly uc As UCVente
    Dim table As New DataTable
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
        id = uc.GetIDModel

        'Création des colonnes pour la table
        table.Columns.Add("ID")
        table.Columns.Add("Nom")
        table.Columns.Add("Coût")

        remplirDGV()

        'Prend de l'information des colonnes de table et le mettre dans la tableCH
        DGVOpDispo.DataSource = table
        For i As Integer = 0 To table.Columns.Count - 1
            tableCh.Columns.Add(table.Columns(i).ColumnName)
        Next
        DGVOpCh.DataSource = tableCh
    End Sub

    'Fonction qui sert à remplir le DataGridView
    Public Sub LoadDGV()
        If Not id = uc.GetIDModel Then
            id = uc.GetIDModel
            remplirDGV()
            DGVOpDispo.DataSource = table

            For i As Integer = DGVOpCh.Rows.Count - 1 To 0 Step -1
                DGVOpCh.Rows.RemoveAt(i)
            Next
        End If
    End Sub

    'Quand on click sur le bouton, on appel la fonction du mainform pour retourner sur le usercontrol UCVente1
    Private Sub BTPrev_Click(sender As Object, e As EventArgs) Handles BTPrev.Click
        main.ChangeUCPrev1(CBTPS.Checked, CBTVQ.Checked)
    End Sub

    'Quand on click sur le bouton, on crée une liste  avec les infos du datagridview et on appel la fonction nextpage2 avec la liste qun'on
    'créer
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

    'Quand on double click sur une ligne on appel la fonction populateRow pour changer une ligne du dataGridView pour l'envoyer dans l'autre
    Private Sub DGVOpDispo_DoubleClick(sender As Object, e As EventArgs) Handles DGVOpDispo.DoubleClick
        ListGest.PopulateRow(tableCh, DGVOpDispo, DGVOpCh)
        checkPrix()
    End Sub

    'Quand on double click sur une ligne on appel la fonction populateRow pour changer une ligne du dataGridView pour l'envoyer dans l'autre
    Private Sub DGVOpCh_DoubleClick(sender As Object, e As EventArgs) Handles DGVOpCh.DoubleClick
        ListGest.PopulateRow(table, DGVOpCh, DGVOpDispo)
        CheckPrix()
    End Sub

    'Fonction qui set à mettre le prix selon la valeur recu et avec les taxes selon les infos recu
    Public Sub SetPrix(prixMo As String, tpsbool As Boolean, tvqbool As Boolean)
        prix = Math.Round(Double.Parse(prixMo), 2)
        CBTPS.Checked = tpsbool
        CBTVQ.Checked = tvqbool

        CheckPrix()
    End Sub

    'Quand cette fonction est appeler on regarde si les checkbox sont checker ou non et calculer le cout de base avec les taxes applicable
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

    'Quand on change le checkboc on appel cette fonction pour changer les prix
    Private Sub CBTPS_CheckedChanged(sender As Object, e As EventArgs) Handles CBTPS.CheckedChanged, CBTVQ.CheckedChanged
        CheckPrix()
    End Sub

    'Quand on click dans le usercontrol, on check pour voir si le menu du mainform est bien fermer 
    Private Sub UCVente2_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub

    'Fonction qui sert à reremplir le datagridview
    Private Sub RemplirDGV()
        table.Clear()

        For r As Integer = 0 To MainForm.tableOp.Rows.Count - 1
            For r2 As Integer = 0 To MainForm.tableOpMo.Rows.Count - 1
                If MainForm.tableOp.Rows(r).Item("id") = MainForm.tableOpMo.Rows(r2).Item("idoption") And MainForm.tableOpMo.Rows(r2).Item("idmodel") = id Then
                    Dim row As DataRow = table.NewRow
                    row(0) = MainForm.tableOp.Rows(r).Item("id")
                    row(1) = MainForm.tableOp.Rows(r).Item("nom")
                    row(2) = MainForm.tableOp.Rows(r).Item("cout")
                    table.Rows.Add(row)
                End If
            Next
        Next
    End Sub
End Class
