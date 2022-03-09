Imports System.ComponentModel

Public Class GestionVehicule
    ReadOnly row As DataGridViewRow
    ReadOnly table As New DataTable
    ReadOnly tableCoulVe As New DataTable
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
            For r2 As Integer = MainForm.tableFacture.Rows.Count - 1 To 0 Step -1
                If MainForm.TableClient.Rows(r).Item("id") = MainForm.tableFacture.Rows(r2).Item("idclient") Then
                    If MainForm.tableFacture.Rows(r2).Item("idvehicule") = row.Cells(0).Value Then
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

        If row.Cells(10).Value = "True" Then
            CBFabriquer.Checked = True
        End If
        If row.Cells(11).Value = "True" Then
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

        For c As Integer = 0 To DGVClient.Columns.Count - 1
            DGVClient.Columns(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    Private Sub RemplirListe(lis As String())
        'On remplie la liste avec les valeur qui sont dans le form
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
        'On resoit un comboBox et un datatable pour créer une liste de toute les nom qui sont dans la datatable
        'Après on utilise cette liste comme datasource du combobox pour faire afficher tous les noms
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
        'Envoi les nouvelles données au seveur et attend la réponse de celui ci si ca marcher ou pas
        If ConnectionServeur.Getinstance.AddDelete(liste, "updateVehicule") Then

            'Update Vehicule dans la table du mainform
            For r As Integer = 0 To MainForm.tableVe.Rows.Count - 1
                If MainForm.tableVe.Rows(r).Item("id") = liste(0) Then
                    For c As Integer = 1 To MainForm.tableVe.Columns.Count - 1
                        MainForm.tableVe(r)(c) = liste(c)
                    Next
                End If
            Next

            'Message de confirmation de réussite et changement de la liste originale pour matcher les nouvelles données
            MessageBox.Show("Enregistrement fait avec succès!")
            For i As Integer = 1 To liste.Count - 1
                listeOR(i) = liste(i)
            Next

            'Remplir le datarow avec les nouvelles données pour quand on va fermer la fenêtre elle soit envoyer dans le datagrid view de ucgestionVehicule
            row.Cells(1).Value = TBMatricule.Text
            row.Cells(2).Value = MainForm.tableModel(CBModel.SelectedIndex)(1)
            row.Cells(3).Value = tableCoulVe(CBCoulVe.SelectedIndex)(1)
            row.Cells(4).Value = tableCoulVe(CBCoulVe.SelectedIndex)(2)
            row.Cells(5).Value = MainForm.tableCoulToi(CBCoulToile.SelectedIndex)(1)
            row.Cells(6).Value = MainForm.tableCoulToi(CBCoulToile.SelectedIndex)(2)
            row.Cells(7).Value = MainForm.tableCoulTis(CBCoulTissus.SelectedIndex)(1)
            row.Cells(8).Value = MainForm.tableCoulTis(CBCoulTissus.SelectedIndex)(2)
            row.Cells(9).Value = CBFabriquer.Checked
            row.Cells(10).Value = CBInv.Checked

            CheckChange()
        Else
            'Message d'erreure si l'enregistrement sur le serveur à échouer
            MessageBox.Show("Une erreure est survenue durant l'enregistrement!", "Attention!")
        End If
    End Sub

    Private Sub TBMatricule_TextChanged(sender As Object, e As EventArgs) Handles TBMatricule.TextChanged
        'Checker si un boolean est true pour savoir si on doit le mettre dans la liste de changement et faire appel a la fonction CheckChange
        If bool Then
            liste(1) = TBMatricule.Text()
            CheckChange()
        End If
    End Sub

    Private Sub CBModel_SelectedValueChanged(sender As Object, e As EventArgs) Handles CBModel.SelectedValueChanged
        'Checker si un boolean est true pour savoir si on doit le mettre dans la liste de changement et faire appel a la fonction CheckChange
        If bool Then
            liste(2) = MainForm.tableModel(CBModel.SelectedIndex)(0)
            CheckChange()
        End If
    End Sub

    Private Sub CBCoulVe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCoulVe.SelectedIndexChanged
        'Checker si un boolean est true pour savoir si on doit le mettre dans la liste de changement
        'après on regarde si le combo box est sur aucune couleur pour savoir se quoi doit mettre dans la liste
        'et faire appel a la fonction CheckChange
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
        'Checker si un boolean est true pour savoir si on doit le mettre dans la liste de changement et faire appel a la fonction CheckChange
        If bool Then
            liste(4) = MainForm.tableCoulToi(CBCoulToile.SelectedIndex)(0)
            CheckChange()
        End If
    End Sub

    Private Sub CBCoulTissus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCoulTissus.SelectedIndexChanged
        'Checker si un boolean est true pour savoir si on doit le mettre dans la liste de changement et faire appel a la fonction CheckChange
        If bool Then
            liste(5) = MainForm.tableCoulTis(CBCoulTissus.SelectedIndex)(0)
            CheckChange()
        End If
    End Sub

    Private Sub CBFabriquer_CheckedChanged(sender As Object, e As EventArgs) Handles CBFabriquer.CheckedChanged
        'Checker si un boolean est true pour savoir si on doit le mettre dans la liste de changement et faire appel a la fonction CheckChange
        If bool Then
            liste(6) = CBFabriquer.Checked
            CheckChange()
        End If
    End Sub

    Private Sub CBInv_CheckedChanged(sender As Object, e As EventArgs) Handles CBInv.CheckedChanged
        'Checker si un boolean est true pour savoir si on doit le mettre dans la liste de changement et faire appel a la fonction CheckChange
        If bool Then
            liste(7) = CBInv.Checked
            CheckChange()
        End If
    End Sub

    Private Sub DTPPrevu_ValueChanged(sender As Object, e As EventArgs) Handles DTPPrevu.ValueChanged
        'Checker si un boolean est true pour savoir si on doit le mettre dans la liste de changement
        'après on regarde la date sélectionner dans le datetimepicker pour voir si la valeur est plus
        'basse que la date d'aujourd'hui ou la date originale
        'si oui on mais le bool a false pour qui ne recheck pas le changement de date et on mais la date du moment
        'Sinon on mais la date sélection
        'et on faire appel a la fonction CheckChange
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
        'On crée un boolean pour qui est mit a false et on fait un loop pour passer toute la liste qui contien les changements
        'On compare cette liste avec la liste original pour voir si a des changement
        'Si a des changement on met le boolean a true et on change l'attribue enable du boutton sauvegarder avec ce boolean
        Dim boolCh As Boolean = False
        For i As Integer = 0 To liste.Count - 1
            If Not listeOR(i) = liste(i) Then
                boolCh = True
            End If
        Next

        BTSave.Enabled = boolCh
    End Sub

    Private Sub GestionVehicule_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'Quand le form ferme on envoir la datarow au UserControl de gestion Véhicule pour qui modifie son datagridview
        uc.ChangeRow(row)
    End Sub
End Class