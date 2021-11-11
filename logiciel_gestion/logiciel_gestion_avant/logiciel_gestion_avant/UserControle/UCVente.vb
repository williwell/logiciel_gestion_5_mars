Public Class UCVente
    Dim main As MainForm
    Dim listeAdd(4) As String
    Shared tableModel As New DataTable
    Dim tableCoulVe As DataTable
    Dim tableCoulToile As DataTable
    Dim TableCoulTissus As DataTable
    Dim bool As Boolean = False
    Dim id As String = "0"

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
        main.ChangeUCNext1()
    End Sub

    Public Sub nextPage2(liste() As String)
        Dim nbr As Integer = listeAdd.Count
        For i As Integer = 0 To liste.Count - 1
            ReDim Preserve listeAdd(nbr)
            listeAdd(nbr) = liste(i)
            nbr += 1
        Next
    End Sub

    Private Sub BtNext_Click(sender As Object, e As EventArgs) Handles BtNext.Click
        NextPage("null", tableModel(CBModel.SelectedIndex)(0), tableCoulVe(CBCoulVe.SelectedIndex)(0), tableCoulToile(CBCoulToile.SelectedIndex)(0), TableCoulTissus(CBCoulTissus.SelectedIndex)(0))
    End Sub

    Public Function getIDModel() As String
        Return tableModel(CBModel.SelectedIndex)(0)
    End Function

    Public Function getListeAdd() As String()
        Return listeAdd
    End Function

    Public Function getID() As String
        Return id
    End Function

    Public Sub setID(idV As String)
        id = idV
    End Sub

    Public Function getDatePre() As Date
        Return DTPPre.Value
    End Function

    Public Sub clear()
        id = "0"
        CBModel.SelectedIndex = 0
        CBCoulVe.SelectedIndex = 0
        CBCoulToile.SelectedIndex = 0
        CBCoulTissus.SelectedIndex = 0
        DTPPre.Value = Now
    End Sub

    Public Function getPrix() As String
        Return tableModel(CBModel.SelectedIndex)(2)
    End Function
End Class
