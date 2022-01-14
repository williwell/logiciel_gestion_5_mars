Public Class UCInfoClientVehicule
    ReadOnly main As MainForm
    ReadOnly table As New DataTable

    Sub New(mainform As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = mainform
    End Sub

    Private Sub UCInfoClientVehicule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Select Case c.id, c.Prenom1, c.nom1, c.Prenom2, c.nom2, c.telephone1, c.telephone2, c.sexe, c.email FROM `client` c 
        '                            inner Join `ventevehicule` v on c.id = v.idclient
        '                            where v.idvehicule = {id}
        'For c As Integer = 0 To MainForm.TableClient.Columns.Count - 1
        '    table.Columns.Add(MainForm.TableClient.Columns(c).ColumnName)
        'Next

        'For r As Integer = 0 To MainForm.TableClient.Rows.Count - 1
        '    For r2 As Integer = 0 To MainForm.tableVenteVe.Rows.Count - 1
        '        If MainForm.TableClient.Rows(r).Item("id") = MainForm.tableVenteVe.Rows(r2).Item("idclient") And MainForm.tableVenteVe.Rows(r2).Item("idvehicule") = id Then
        '            Dim row As DataRow = table.NewRow
        '            For c As Integer = 0 To MainForm.TableClient.Columns.Count - 1
        '                row(c) = MainForm.TableClient(r)(c)
        '            Next
        '            table.Rows.Add(row)
        '        End If
        '    Next
        'Next

        'table = ConnectionServeur.Getinstance.GetInfo(id, "getInfoClVe")

        If table.Rows.Count > 0 Then
            DGVClient.DataSource = table

            TBID.Text = table(0)(0)
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


    End Sub

    'Si on click dans le UserCOntrol on check pour être sur que le menu dans le Mainform soit bien fermer
    Private Sub UCInfoClientVehicule_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub
End Class
