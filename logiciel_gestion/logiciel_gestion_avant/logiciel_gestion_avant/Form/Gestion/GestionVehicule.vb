Imports System.ComponentModel

Public Class GestionVehicule
    ReadOnly row As DataGridViewRow
    Dim table As New DataTable
    Dim tableModel As DataTable
    Dim tableCoulVe As New DataTable
    Dim tableCoulToile As DataTable
    Dim tableCoulTissus As DataTable
    Dim bool As Boolean = True
    ReadOnly listeOR(8) As String
    ReadOnly liste(8) As String
    ReadOnly uc As UCGestionVehicule

    Sub New(rowVe As DataGridViewRow, gest As UCGestionVehicule)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        row = rowVe
        uc = gest
    End Sub

    Private Sub GestionVehicule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bool = False

        tableCoulVe.Columns.Add("id")
        tableCoulVe.Columns.Add("nom")
        tableCoulVe.Columns.Add("code")
        tableCoulVe.Columns.Add("cout")

        table.Columns.Add("ID")
        table.Columns.Add("Prenom1")
        table.Columns.Add("Nom1")
        table.Columns.Add("Prenom2")
        table.Columns.Add("Nom2")
        table.Columns.Add("Téléphone1")
        table.Columns.Add("Téléphone2")
        table.Columns.Add("Sexe")
        table.Columns.Add("Email")

        For r As Integer = 0 To MainForm.TableClient.Rows.Count - 1
            For r2 As Integer = 0 To MainForm.tableVenteVe.Rows.Count - 1
                If MainForm.TableClient.Rows(r).Item("id") = MainForm.tableVenteVe.Rows(r2).Item("idclient") Then
                    If MainForm.tableVenteVe.Rows(r2).Item("idvehicule") = row.Cells(0).Value Then
                        Dim row As DataRow = table.NewRow
                        row(0) = MainForm.TableClient.Rows(r).Item("id")
                        row(1) = MainForm.TableClient.Rows(r).Item("prenom1")
                        row(2) = MainForm.TableClient.Rows(r).Item("nom1")
                        row(3) = MainForm.TableClient.Rows(r).Item("prenom2")
                        row(4) = MainForm.TableClient.Rows(r).Item("nom2")
                        row(5) = MainForm.TableClient.Rows(r).Item("telephone1")
                        row(6) = MainForm.TableClient.Rows(r).Item("telephone2")
                        row(7) = MainForm.TableClient.Rows(r).Item("sexe")
                        row(8) = MainForm.TableClient.Rows(r).Item("email")
                        table.Rows.Add(row)
                    End If
                End If
            Next
            For r2 As Integer = 0 To MainForm.tableLivrer.Rows.Count - 1
                If MainForm.TableClient.Rows(r).Item("id") = MainForm.tableLivrer.Rows(r2).Item("idclient") Then
                    If MainForm.tableLivrer.Rows(r2).Item("idvehicule") = row.Cells(0).Value Then
                        Dim row As DataRow = table.NewRow
                        row(0) = MainForm.TableClient.Rows(r).Item("id")
                        row(1) = MainForm.TableClient.Rows(r).Item("prenom1")
                        row(2) = MainForm.TableClient.Rows(r).Item("nom1")
                        row(3) = MainForm.TableClient.Rows(r).Item("prenom2")
                        row(4) = MainForm.TableClient.Rows(r).Item("nom2")
                        row(5) = MainForm.TableClient.Rows(r).Item("telephone1")
                        row(6) = MainForm.TableClient.Rows(r).Item("telephone2")
                        row(7) = MainForm.TableClient.Rows(r).Item("sexe")
                        row(8) = MainForm.TableClient.Rows(r).Item("email")
                        table.Rows.Add(row)
                    End If
                End If
            Next
        Next

        If table.Rows.Count > 0 Then
            DGVClient.DataSource = table

            TBIDCl.Text = table(0)(0)
            TBPrenom1.Text = table(0)(1)
            TBNom1.Text = table(0)(2)
            TBPrenom2.Text = table(0)(3)
            TBNom2.Text = table(0)(4)
            TBTel1.Text = table(0)(5)
            TBTel2.Text = table(0)(6)
            TBSexe.Text = table(0)(7)
            TBEmail.Text = table(0)(8)

            DGVClient.Rows.RemoveAt(0)
        End If

        TBIDVe.Text = row.Cells(0).Value
        TBMatricule.Text = row.Cells(1).Value

        RemplirCB(CBModel, MainForm.tableModel)

        RemplirCB(CBCoulToile, MainForm.tableCoulToi)

        RemplirCB(CBCoulTissus, MainForm.tableCoulTis)


        SelectionComboBox(CBModel, row.Cells(2).Value)
        SelectionComboBox(CBCoulVe, row.Cells(3).Value & " - " & row.Cells(4).Value)
        SelectionComboBox(CBCoulToile, row.Cells(5).Value)
        SelectionComboBox(CBCoulTissus, row.Cells(7).Value)

        If row.Cells(9).Value = "True" Then
            CBFabriquer.Checked = True
        End If
        If row.Cells(10).Value = "True" Then
            CBInv.Checked = True
        End If

        Dim tabletempo As New DataTable

        tabletempo.Columns.Add("dateprevu")
        For r As Integer = 0 To MainForm.tableVenteVe.Rows.Count - 1
            If MainForm.tableVenteVe.Rows(r).Item("idvehicule") = row.Cells(0).Value Then
                Dim row As DataRow = tabletempo.NewRow
                row(0) = MainForm.tableVenteVe.Rows(r).Item("dateprevu")
                tabletempo.Rows.Add(row)
            End If
        Next

        If tabletempo.Rows.Count > 0 Then
            DTPPrevu.Visible = True
            LabDatePrevu.Visible = True
            DTPPrevu.Value = tabletempo(0)(0)
        End If

        RemplirListe(liste)
        RemplirListe(listeOR)

        bool = True
    End Sub

    Private Sub RemplirListe(lis As String())
        lis(0) = row.Cells(0).Value
        lis(1) = row.Cells(1).Value
        lis(2) = Mainform.tableModel(CBModel.SelectedIndex)(0)
        lis(3) = tableCoulVe(CBCoulVe.SelectedIndex)(0)
        lis(4) = MainForm.tableCoulToi(CBCoulToile.SelectedIndex)(0)
        lis(5) = MainForm.tableCoulTis(CBCoulTissus.SelectedIndex)(0)
        lis(6) = CBFabriquer.Checked
        lis(7) = CBInv.Checked
        lis(8) = DTPPrevu.Value.ToString("yyyy-MM-dd")
    End Sub

    Private Sub RemplirCB(CB As ComboBox, tablemain As DataTable)
        Dim liste(tablemain.Rows.Count - 1)
        For i As Integer = 0 To tablemain.Rows.Count - 1
            liste(i) = tablemain(i)(1)
        Next

        CB.DataSource = liste
    End Sub

    Private Sub CBModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBModel.SelectedIndexChanged
        tableCoulVe.Clear()


        For r As Integer = 0 To MainForm.tableCoulVe.Rows.Count - 1
            For r2 As Integer = 0 To MainForm.tableCoulMo.Rows.Count - 1
                If MainForm.tableCoulVe.Rows(r).Item("id") = MainForm.tableCoulMo.Rows(r2).Item("idcouleur") Then
                    If MainForm.tableCoulMo.Rows(r2).Item("idmodel") = MainForm.tableModel(CBModel.SelectedIndex)(0) Then
                        Dim row As DataRow = tableCoulVe.NewRow
                        row(0) = MainForm.tableCoulVe.Rows(r).Item("id")
                        row(1) = MainForm.tableCoulVe.Rows(r).Item("nom")
                        row(2) = MainForm.tableCoulVe.Rows(r).Item("code")
                        row(3) = MainForm.tableCoulVe.Rows(r).Item("cout")
                        tableCoulVe.Rows.Add(row)
                    End If
                End If
            Next
        Next

        Dim listeCoul(0) As String
        If tableCoulVe.Rows.Count > 0 Then
            ReDim listeCoul(tableCoulVe.Rows.Count - 1)
            For i As Integer = 0 To tableCoulVe.Rows.Count - 1
                listeCoul(i) = tableCoulVe(i)(1) & " - " & tableCoulVe(i)(2)
            Next
        Else
            listeCoul(0) = "Aucune couleur de disponible pour ce model"
        End If
        CBCoulVe.DataSource = listeCoul
    End Sub

    Private Sub SelectionComboBox(cb As ComboBox, str As String)
        For i As Integer = 0 To cb.Items.Count - 1
            If cb.Items(i) = str Then
                cb.SelectedIndex = i
            End If
        Next
    End Sub

    Private Sub BTSave_Click(sender As Object, e As EventArgs) Handles BTSave.Click
        If ConnectionServeur.Getinstance.AddDelete(liste, "updateVehicule") Then
            MessageBox.Show("Enregistrement fait avec succès!")
            For i As Integer = 1 To liste.Count - 1
                listeOR(i) = liste(i)
            Next

            row.Cells(1).Value = TBMatricule.Text
            row.Cells(2).Value = tableModel(CBModel.SelectedIndex)(1)
            row.Cells(3).Value = tableCoulVe(CBCoulVe.SelectedIndex)(1)
            row.Cells(4).Value = tableCoulVe(CBCoulVe.SelectedIndex)(2)
            row.Cells(5).Value = tableCoulToile(CBCoulToile.SelectedIndex)(1)
            row.Cells(6).Value = tableCoulToile(CBCoulToile.SelectedIndex)(2)
            row.Cells(7).Value = tableCoulTissus(CBCoulTissus.SelectedIndex)(1)
            row.Cells(8).Value = tableCoulTissus(CBCoulTissus.SelectedIndex)(2)
            row.Cells(9).Value = CBFabriquer.Checked
            row.Cells(10).Value = CBInv.Checked

            CheckChange()
        Else
            MessageBox.Show("Une erreure est survenue durant l'enregistrement!", "Attention!")
        End If
    End Sub

    Private Sub TBMatricule_TextChanged(sender As Object, e As EventArgs) Handles TBMatricule.TextChanged
        If bool Then
            liste(1) = TBMatricule.Text()
            CheckChange()
        End If
    End Sub

    Private Sub CBModel_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBModel.SelectedValueChanged
        If bool Then
            liste(2) = MainForm.tableModel(CBModel.SelectedIndex)(0)
            CheckChange()
        End If
    End Sub

    Private Sub CBCoulVe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCoulVe.SelectedIndexChanged
        If bool Then
            If Not CBCoulVe.SelectedItem = "Aucune couleur de disponible pour ce model" Then
                liste(3) = MainForm.tableCoulVe(CBCoulVe.SelectedIndex)(0)
            Else
                liste(3) = 0
            End If
            CheckChange()
        End If
    End Sub

    Private Sub CBCoulToile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCoulToile.SelectedIndexChanged
        If bool Then
            liste(4) = MainForm.tableCoulToi(CBCoulToile.SelectedIndex)(0)
            CheckChange()
        End If
    End Sub

    Private Sub CBCoulTissus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCoulTissus.SelectedIndexChanged
        If bool Then
            liste(5) = MainForm.tableCoulTis(CBCoulTissus.SelectedIndex)(0)
            CheckChange()
        End If
    End Sub

    Private Sub CBFabriquer_CheckedChanged(sender As Object, e As EventArgs) Handles CBFabriquer.CheckedChanged
        If bool Then
            liste(6) = CBFabriquer.Checked
            CheckChange()
        End If
    End Sub

    Private Sub CBInv_CheckedChanged(sender As Object, e As EventArgs) Handles CBInv.CheckedChanged
        If bool Then
            liste(7) = CBInv.Checked
            CheckChange()
        End If
    End Sub

    Private Sub DTPPrevu_ValueChanged(sender As Object, e As EventArgs) Handles DTPPrevu.ValueChanged
        If bool Then
            If DTPPrevu.Value.ToString("yyyy-MM-dd") < Now.ToString("yyyy-MM-dd") And Not DTPPrevu.Value.ToString("yyyy-MM-dd") = listeOR(8) Then
                bool = False
                DTPPrevu.Value = Now
                liste(8) = DTPPrevu.Value.ToString("yyyy-MM-dd")
                bool = True
            Else
                liste(8) = DTPPrevu.Value.ToString("yyyy-MM-dd")
            End If
            CheckChange()
        End If
    End Sub

    Private Sub CheckChange()
        Dim boolCh As Boolean = False
        For i As Integer = 0 To liste.Count - 1
            If Not listeOR(i) = liste(i) Then
                boolCh = True
            End If
        Next

        BTSave.Enabled = boolCh
    End Sub

    Private Sub GestionVehicule_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        uc.ChangeRow(row)
    End Sub
End Class