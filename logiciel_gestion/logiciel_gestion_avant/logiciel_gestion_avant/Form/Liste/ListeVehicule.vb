﻿Public Class ListeVehicule
    ReadOnly uc As UCVente

    Sub New(ucVente As UCVente)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        uc = ucVente
    End Sub

    Private Sub ListeVehicule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim table As New DataTable

        table.Columns.Add("ID")
        table.Columns.Add("Numéro Matricule")
        table.Columns.Add("Model")
        table.Columns.Add("Coût")
        table.Columns.Add("Couleur Véhicule")
        table.Columns.Add("Code Couleur Véhicule")
        table.Columns.Add("Couleur Toile")
        table.Columns.Add("Code Couleur Toile")
        table.Columns.Add("Couleur Tissus")
        table.Columns.Add("Code Couleur Tissus")

        For r As Integer = 0 To MainForm.tableVe.Rows.Count - 1
            If MainForm.tableVe.Rows(r).Item("eninventaire") = "True" And MainForm.tableVe.Rows(r).Item("fabriquer") = "True" Then
                For r2 As Integer = 0 To MainForm.tableModel.Rows.Count - 1
                    If MainForm.tableVe.Rows(r).Item("idmodel") = MainForm.tableModel.Rows(r2).Item("id") Then
                        For r3 As Integer = 0 To MainForm.tableCoulVe.Rows.Count - 1
                            If MainForm.tableVe.Rows(r).Item("idcouleur") = MainForm.tableCoulVe.Rows(r3).Item("id") Then
                                For r4 As Integer = 0 To MainForm.tableCoulToi.Rows.Count - 1
                                    If MainForm.tableVe.Rows(r).Item("idcoultoile") = MainForm.tableCoulToi.Rows(r4).Item("id") Then
                                        For r5 As Integer = 0 To MainForm.tableCoulTis.Rows.Count - 1
                                            If MainForm.tableVe.Rows(r).Item("idcoultissus") = MainForm.tableCoulTis.Rows(r5).Item("id") Then
                                                Dim row As DataRow = table.NewRow
                                                row(0) = MainForm.tableVe.Rows(r).Item("id")
                                                row(1) = MainForm.tableVe.Rows(r).Item("nomatricule")
                                                row(2) = MainForm.tableModel.Rows(r2).Item("nom")
                                                row(3) = MainForm.tableModel.Rows(r2).Item("cout")
                                                row(4) = MainForm.tableCoulVe.Rows(r3).Item("nom")
                                                row(5) = MainForm.tableCoulVe.Rows(r3).Item("code")
                                                row(6) = MainForm.tableCoulToi.Rows(r4).Item("nom")
                                                row(7) = MainForm.tableCoulToi.Rows(r4).Item("code")
                                                row(8) = MainForm.tableCoulTis.Rows(r5).Item("nom")
                                                row(9) = MainForm.tableCoulTis.Rows(r5).Item("code")
                                                table.Rows.Add(row)
                                            End If
                                        Next
                                    End If
                                Next
                            End If
                        Next
                    End If
                Next
            End If
        Next

        DGVVehicule.DataSource = table
    End Sub

    Private Sub DGVVehicule_DoubleClick(sender As Object, e As EventArgs) Handles DGVVehicule.DoubleClick
        Dim row As DataGridViewRow = DGVVehicule.CurrentRow
        uc.setID(row.Cells(0).Value)
        uc.NextPage(row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value)
        Me.Close()
    End Sub
End Class