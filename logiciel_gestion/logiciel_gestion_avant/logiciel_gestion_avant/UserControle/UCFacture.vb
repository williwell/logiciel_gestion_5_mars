Public Class UCFacture
    ReadOnly main As MainForm

    Sub New(m As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = m
    End Sub

    Private Sub UCFacture_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim table As New DataTable

        table.Columns.Add("ID")
        table.Columns.Add("Model")
        table.Columns.Add("Numéro Matricule")
        table.Columns.Add("Client")
        table.Columns.Add("Date")

        For r As Integer = 0 To MainForm.tableFacture.Rows.Count - 1
            Dim row As DataRow = table.NewRow
            row(0) = MainForm.tableFacture(r)(0)
            For r2 As Integer = 0 To MainForm.tableVe.Rows.Count - 1
                If MainForm.tableFacture.Rows(r).Item("idvehicule") = MainForm.tableVe.Rows(r2).Item("id") Then
                    For r3 As Integer = 0 To MainForm.tableModel.Rows.Count - 1
                        If MainForm.tableVe.Rows(r2).Item("idmodel") = MainForm.tableModel.Rows(r3).Item("id") Then
                            row(1) = MainForm.tableModel.Rows(r3).Item("nom")
                            Exit For
                        End If
                    Next
                    row(2) = MainForm.tableVe.Rows(r2).Item("nomatricule")
                    Exit For
                End If
            Next
            For r2 As Integer = 0 To MainForm.TableClient.Rows.Count - 1
                If MainForm.tableFacture.Rows(r).Item("idclient") = MainForm.TableClient.Rows(r2).Item("id") Then
                    row(3) = MainForm.TableClient.Rows(r2).Item("Nom1") & " " & MainForm.TableClient.Rows(r2).Item("Prenom1")
                    If MainForm.TableClient.Rows(r2).Item("Nom2") <> "null" Then
                        row(3) += " / " & MainForm.TableClient.Rows(r2).Item("Nom2") & " " & MainForm.TableClient.Rows(r2).Item("Prenom2")
                    End If
                    Exit For
                End If
            Next
            row(4) = MainForm.tableFacture(r).Item("date")
            table.Rows.Add(row)
        Next

        DGVFacture.DataSource = table

        DGVFacture.Columns(1).Width = 200
        DGVFacture.Columns(2).Width = 200
        DGVFacture.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub DGVFacture_DoubleClick(sender As Object, e As EventArgs) Handles DGVFacture.DoubleClick
        MessageBox.Show(DGVFacture.CurrentRow.Index)
    End Sub

    Private Sub UCFacture_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.FermerMenu()
    End Sub

    Private Sub DGVFacture_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVFacture.MouseUp
        main.FermerMenu()
    End Sub

End Class
