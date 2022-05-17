﻿Public Class RechercheProduit
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    ReadOnly ucInvent As UCInventaire
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
    End Sub

    Private Sub DgvProduit_DoubleClick(sender As Object, e As EventArgs) Handles dgvProduit.DoubleClick
        If dgvProduit.CurrentRow IsNot Nothing Then
            ucInvent.SetIDProduit(dgvProduit.CurrentRow.Cells(0).Value)
            Me.Close()
        End If
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