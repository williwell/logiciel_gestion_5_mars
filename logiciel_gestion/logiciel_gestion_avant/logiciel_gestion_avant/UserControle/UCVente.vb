Public Class UCVente
    ReadOnly main As MainForm
    Dim listeAdd(4) As String
    Shared tableModel As New DataTable
    ReadOnly tableCoulVe As New DataTable
    Dim tableCoulToile As New DataTable
    Dim TableCoulTissus As New DataTable
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
        'Création des colonnes pour la tableCoulVe
        tableCoulVe.Columns.Add("ID")
        tableCoulVe.Columns.Add("Nom")
        tableCoulVe.Columns.Add("Code")
        tableCoulVe.Columns.Add("Coût")

        'Création de nouveau userControl de type UCVente2 et UCVente3
        Dim ucVe2 As New UCVente2(Me, main)
        Dim ucVe3 As New UCVente3(Me, main)

        'On appel les fonction SetUCVente2 et UCVente3 qui se trouve dans le mainform
        main.SetUCVente2(ucVe2)
        main.SetUCVente3(ucVe3)

        'On utilise les table du mainform pour avoir les infos pour les tables dans le userControl et on appel la fonction RemplirCB
        tableModel = MainForm.tableModel
        RemplirCB(tableModel, CBModel)

        tableCoulToile = MainForm.tableCoulToi
        RemplirCB(tableCoulToile, CBCoulToile)

        TableCoulTissus = MainForm.tableCoulTis
        RemplirCB(TableCoulTissus, CBCoulTissus)

        CBTPS.Checked = True
        CBTVQ.Checked = True
    End Sub

    'Quand le combobox change d'index, on clear la tableCoulVe et on remet des nouvelles informations
    Private Sub CBModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBModel.SelectedIndexChanged
        tableCoulVe.Clear()

        'loop pour mettre les nouvelles infos selon le model qui est sélectionner
        For r As Integer = 0 To MainForm.tableCoulVe.Rows.Count - 1
            For r2 As Integer = 0 To MainForm.tableCoulMo.Rows.Count - 1
                If MainForm.tableCoulVe.Rows(r).Item("id") = MainForm.tableCoulMo.Rows(r2).Item("idcouleur") And MainForm.tableCoulMo.Rows(r2).Item("idmodel") = tableModel(CBModel.SelectedIndex)(0) Then
                    Dim row As DataRow = tableCoulVe.NewRow
                    row(0) = MainForm.tableCoulVe.Rows(r).Item("id")
                    row(1) = MainForm.tableCoulVe.Rows(r).Item("nom")
                    row(2) = MainForm.tableCoulVe.Rows(r).Item("code")
                    row(3) = MainForm.tableCoulVe.Rows(r).Item("cout")
                    tableCoulVe.Rows.Add(row)
                End If
            Next
        Next

        'On créer une liste avec les noms des couleurs et on utilise cette liste pour mettre dans le combobox
        Dim liste(0) As String
        If tableCoulVe.Rows.Count > 0 Then
            ReDim liste(tableCoulVe.Rows.Count - 1)
            For i As Integer = 0 To tableCoulVe.Rows.Count - 1
                liste(i) = tableCoulVe(i)(1) & " - " & tableCoulVe(i)(2)
            Next
        Else
            liste(0) = "Aucune couleur de disponible!"
        End If
        CBCoulVe.DataSource = liste

        prix = Decimal.Parse(tableModel(CBModel.SelectedIndex)(2))
        If CBCoulVe.Items(0).ToString <> "Aucune couleur de disponible!" Then
            prix += Decimal.Parse(tableCoulVe(CBCoulVe.SelectedIndex)(3))
        End If

        TBCout.Text = prix.ToString("0.00$")
    End Sub

    'Fonction qui sert à utilisé une table pour remplir un combobox
    Private Sub RemplirCB(ByRef table As DataTable, CB As ComboBox)
        Dim liste(table.Rows.Count - 1)
        For i As Integer = 0 To table.Rows.Count - 1
            liste(i) = table(i)(1)
        Next

        CB.DataSource = liste
    End Sub

    'Quand on click sur le bouton, on crée un nouveau form de type ListeVehicule et on le fait apparaître
    Private Sub BTChoisir_Click(sender As Object, e As EventArgs) Handles BTChoisir.Click

    End Sub

    'Cette fonction est utilisé pour mettre certaine information dans une liste et appeler une fonction du mainform pour changer de userControl
    Public Sub NextPage(matricule As String, model As String, coulVe As String, coulToile As String, CoulTissus As String)
        listeAdd(0) = matricule
        listeAdd(1) = model
        listeAdd(2) = coulVe
        listeAdd(3) = coulToile
        listeAdd(4) = CoulTissus
        main.ChangeUCNext1(CBTPS.Checked, CBTVQ.Checked)
    End Sub

    'Fonction qui est utiliser pour mettre des informations qui vienne du usercontrol UCVente2 dans la liste de ce UserControl
    Public Sub NextPage2(liste() As String)
        Dim nbr As Integer = listeAdd.Count
        For i As Integer = 0 To liste.Count - 1
            ReDim Preserve listeAdd(nbr)
            listeAdd(nbr) = liste(i)
            nbr += 1
        Next
    End Sub

    'Quand on click sur ce boutons, on regarde les tables pour voir si il sont vide on met vide dans des variables sinon on prend l'information
    'correspondante dans les tables qui sont lier au combobox
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

    'Fonction qui sert a avoir le id du model qui est sélectionner
    Public Function GetIDModel() As String
        Return tableModel(CBModel.SelectedIndex)(0)
    End Function

    'Fonction qui retourne la listeadd qui à été créer pour ajouter une vente
    Public Function GetListeAdd() As String()
        Return listeAdd
    End Function

    'Fonction qui retourne la variable id
    Public Function GetID() As String
        Return id
    End Function

    'Fonction qui recoit une variable et met la variable local id avec la variable recus
    Public Sub SetID(idV As String)
        id = idV
    End Sub

    'Fonction qui retourne la date sélectionner du DateTimePicker
    Public Function GetDatePre() As Date
        Return DTPPre.Value
    End Function

    'Fonction qui sert à remettre les infos du userControl à null
    Public Sub Clear()
        id = "0"
        CBModel.SelectedIndex = 0
        CBCoulVe.SelectedIndex = 0
        CBCoulToile.SelectedIndex = 0
        CBCoulTissus.SelectedIndex = 0
        DTPPre.Value = Now
    End Sub

    'Fonction qui retourne la valeur de la table pour qui le model est sélectionner
    Public Function GetPrix() As String
        Return GetPrixModel() + GetPrixCouleur()
    End Function

    'Quand on change le texte du textbox on appel la fonction changeTaxe
    Private Sub TBCout_TextChanged(sender As Object, e As EventArgs) Handles TBCout.TextChanged
        ChangeTaxe()
    End Sub

    'Quand on change la date du DateTimePicker on regarde si la date est plus petit que la date du moment et si oui on met le bool a false
    'et on change la date pour mettre en ce moment et on remet le bool as true
    Private Sub DTPPre_ValueChanged(sender As Object, e As EventArgs) Handles DTPPre.ValueChanged
        If bool Then
            If DTPPre.Value < Now Then
                bool = False
                DTPPre.Value = Now
                bool = True
            End If
        End If
    End Sub

    'Quand le checkbox change on appel la fonction changeTaxe
    Private Sub CBTPS_CheckedChanged(sender As Object, e As EventArgs) Handles CBTPS.CheckedChanged
        changeTaxe()
    End Sub

    'Quand le checkbox change on appel la fonction changeTaxe
    Private Sub CBTVQ_CheckedChanged(sender As Object, e As EventArgs) Handles CBTVQ.CheckedChanged
        changeTaxe()
    End Sub

    'Cette fonction sert a regarder si les cehckbox sont checker ou non et calculer le coût total selon les taxes
    Private Sub ChangeTaxe()
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

    'Fonction qui sert à changer si les checkbox doive être check ou non
    Public Sub SetTaxe(TPSBool As Boolean, TVQBool As Boolean)
        CBTPS.Checked = TPSBool
        CBTVQ.Checked = TVQBool
    End Sub

    'Quand on click dans le usercontrol, on regarde si le menu du mainform est bien fermer ou non
    Private Sub UCVente_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub

    'Function qui retourne la valeur de NUDEchange
    Public Function GetNUDEchange() As Double
        Return NUDEchange.Value
    End Function

    'Function qui retourne la valeur de NUDAcompte
    Public Function GetNUDAcompte() As Double
        Return NUDAcompte.Value
    End Function

    'Function qui retourne le prix du model qui est sélectionner
    Public Function GetPrixModel() As Double
        Return tableModel.Rows(CBModel.SelectedIndex).Item("cout")
    End Function

    'Function qui retourne le prix de la couleur qui est sélectionner
    Public Function GetPrixCouleur() As Double
        Return tableCoulVe.Rows(CBCoulVe.SelectedIndex).Item("coût")
    End Function

    'Fonction qui sert à changer le prix du textbox cout
    Private Sub CBCoulVe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCoulVe.SelectedIndexChanged
        prix = Decimal.Parse(tableModel(CBModel.SelectedIndex)(2))

        If CBCoulVe.Items(0).ToString <> "Aucune couleur de disponible!" Then
            prix += Decimal.Parse(tableCoulVe(CBCoulVe.SelectedIndex)(3))
        End If

        TBCout.Text = prix.ToString("0.00$")
    End Sub
End Class
