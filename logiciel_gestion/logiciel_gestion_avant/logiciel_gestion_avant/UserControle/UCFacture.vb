Public Class UCFacture
    ReadOnly main As MainForm
    ReadOnly search As New BindingSource

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
        table.Columns.Add("Matricule")
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
                    row(2) = MainForm.tableVe.Rows(r2).Item("niv")
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

        Dim liste(MainForm.tableModel.Rows.Count) As String
        liste(0) = "Tous les models"
        For r As Integer = 0 To MainForm.tableModel.Rows.Count - 1
            liste(r + 1) = MainForm.tableModel.Rows(r).Item("nom")
        Next
        CBModel.DataSource = liste

        search.DataSource = DGVFacture.DataSource
    End Sub

    Private Sub DGVFacture_DoubleClick(sender As Object, e As EventArgs) Handles DGVFacture.DoubleClick
        If DGVFacture.CurrentRow IsNot Nothing Then
            Dim f As New GestionFacture(DGVFacture.CurrentRow.Cells(0).Value)
            f.ShowDialog()
        End If
    End Sub

    Private Sub UCFacture_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.FermerMenu()
    End Sub

    Private Sub DGVFacture_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVFacture.MouseUp
        main.FermerMenu()
    End Sub

    Private Sub SearchText() Handles CBDate.CheckedChanged, DTP.ValueChanged, CBModel.SelectedIndexChanged, TBFacture.TextChanged, TBMatricule.TextChanged, TBClient.TextChanged
        Dim str As String = ""

        If CBDate.Checked = True Then
            DTP.Enabled = False
        Else
            DTP.Enabled = True
        End If

        If Not CBDate.Checked Then
            str = "Date like '" & DTP.Value.ToString("yyyy-MM-dd") & "'"
        End If

        If Not String.IsNullOrEmpty(Trim(TBFacture.Text)) Then
            If String.IsNullOrEmpty(str) Then
                str += "Id like '%" & TBFacture.Text & "%'"
            Else
                str += " and id like '%" & TBFacture.Text & "%'"
            End If
        End If

        If Not CBModel.SelectedIndex = 0 Then
            If String.IsNullOrEmpty(str) Then
                str += "Model like '" & CBModel.SelectedItem & "'"
            Else
                str += " and Model like '%" & CBModel.SelectedItem & "%'"
            End If
        End If

        If Not String.IsNullOrEmpty(Trim(TBMatricule.Text)) Then
            If String.IsNullOrEmpty(str) Then
                str += "Matricule like '%" & TBMatricule.Text & "%'"
            Else
                str += " and Matricule like '%" & TBMatricule.Text & "%'"
            End If
        End If

        If Not String.IsNullOrEmpty(Trim(TBClient.Text)) Then
            If String.IsNullOrEmpty(str) Then
                str += "Client like '%" & TBClient.Text & "%'"
            Else
                str += " and Client like '%" & TBClient.Text & "%'"
            End If
        End If

        search.Filter = str
    End Sub
End Class
