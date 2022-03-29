Public Class ListeVehicule
    ReadOnly uc As CreerContrat
    Dim veInventaire As Boolean = False

    Sub New(ucVente As CreerContrat)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        uc = ucVente
    End Sub

    Private Sub ListeVehicule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Créer une table temporaire et ajouter les colonnes que j'ai besoin
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


        'Mettre les information d'un véhicule si il est en inventaire et fabriquer
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

        'Assigner la table à la DataSource
        DGVVehicule.DataSource = table

        For c As Integer = 0 To DGVVehicule.Columns.Count - 1
            DGVVehicule.Columns(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    'SI on double click sur une ligne on envoie le id de la ligne du DataGridView au UserControl Vente, on appel la fonction NextPage et on ferme ce form
    Private Sub DGVVehicule_DoubleClick(sender As Object, e As EventArgs) Handles DGVVehicule.DoubleClick
        Dim row As DataGridViewRow = DGVVehicule.CurrentRow
        uc.SetIDVe(row)
        Me.Close()
    End Sub
End Class