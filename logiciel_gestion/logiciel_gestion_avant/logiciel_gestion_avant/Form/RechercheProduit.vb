Public Class RechercheProduit
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    ReadOnly ucInvent As UCInventaire
    ReadOnly search As New BindingSource
    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________
    Sub New(uc As UCInventaire)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        ucInvent = uc
    End Sub


    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________
    Private Sub RechercheProduit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvProduit.DataSource = MainForm.tableInv
        dgvProduit.Sort(dgvProduit.Columns(1), 0)

        For c As Integer = 0 To dgvProduit.Columns.Count - 1
            If c <> 3 Then
                dgvProduit.Columns(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Else
                dgvProduit.Columns(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End If
        Next

        search.DataSource = dgvProduit.DataSource
    End Sub

    Private Sub DgvProduit_DoubleClick(sender As Object, e As EventArgs) Handles dgvProduit.DoubleClick
        If dgvProduit.CurrentRow IsNot Nothing Then
            ucInvent.SetIDProduit(dgvProduit.CurrentRow.Cells(0).Value)
            Me.Close()
        End If
    End Sub

    Private Sub TBSearchMat_TextChanged(sender As Object, e As EventArgs) Handles TBID.TextChanged, TBNom.TextChanged, TBDescription.TextChanged, TBEmplacement.TextChanged
        Dim str As String = ""

        If Not String.IsNullOrEmpty(Trim(TBID.Text)) Then
            str += "ID like '%" & TBID.Text & "%'"
        End If

        If Not String.IsNullOrEmpty(Trim(TBNom.Text)) Then
            If String.IsNullOrEmpty(str) Then
                str += "Nom like'%" & TBNom.Text & "%'"
            Else
                str += " and Nom like '%" & TBNom.Text & "%'"
            End If
        End If

        If Not String.IsNullOrEmpty(Trim(TBDescription.Text)) Then
            If String.IsNullOrEmpty(str) Then
                str += "Description like'%" & TBDescription.Text & "%'"
            Else
                str += " and Description like '%" & TBDescription.Text & "%'"
            End If
        End If

        If Not String.IsNullOrEmpty(Trim(TBEmplacement.Text)) Then
            If String.IsNullOrEmpty(str) Then
                str += "Emplacement like '%" & TBEmplacement.Text & "%'"
            Else
                str += " and Emplacement like '%" & TBEmplacement.Text & "%'"
            End If
        End If

        search.Filter = str
    End Sub
    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Set
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Get
    '__________________________________________________________________________________________________________


End Class