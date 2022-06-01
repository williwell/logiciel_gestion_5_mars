Imports System.ComponentModel

Public Class GestionClient
    ReadOnly ID As String
    ReadOnly table As New DataTable
    ReadOnly liste() As String = {"Non déterminer", "Homme", "Femme"}

    Sub New(IDClient As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        ID = IDClient
    End Sub

    Private Sub GestionClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For c As Integer = 0 To MainForm.TableClient.Columns.Count - 1
            table.Columns.Add(MainForm.TableClient.Columns(c).ColumnName)
        Next

        LoadDGV()

        For c As Integer = 0 To DataGridView1.Columns.Count - 1
            DataGridView1.Columns(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    Private Sub LoadDGV()
        table.Clear()
        For r As Integer = 0 To MainForm.TableClient.Rows.Count - 1
            If MainForm.TableClient.Rows(r).Item("id") = ID Then
                Dim row As DataRow = table.NewRow
                For c As Integer = 0 To MainForm.TableClient.Columns.Count - 1
                    row(c) = MainForm.TableClient(r)(c)
                Next
                table.Rows.Add(row)
            End If
        Next

        CBSexe.DataSource = liste
        LoadInfo()
    End Sub

    Private Sub BTSave_Click(sender As Object, e As EventArgs) Handles BTSave.Click
        Dim listeAdd() As String = {TBID.Text, TBPrenom1.Text, TBNom1.Text, TBPrenom2.Text, TBNom2.Text, TBTel1.Text, TBTel2.Text, CBSexe.SelectedItem.ToString, TBEmail.Text}
        If ConnectionServeur.Getinstance.AddDelete(listeAdd, "modClient") Then
            For r As Integer = 0 To MainForm.TableClient.Rows.Count - 1
                If MainForm.TableClient.Rows(r).Item("id") = TBID.Text Then
                    For c As Integer = 0 To MainForm.TableClient.Columns.Count - 1
                        MainForm.TableClient(r)(c) = listeAdd(c)
                    Next
                    LoadDGV()
                End If
            Next
            For i As Integer = 0 To listeAdd.Length - 1
                table(0)(i) = listeAdd(i)
            Next
            MessageBox.Show(MsgTextFr.Getinstance.MsgSauvServ)
        Else
            MessageBox.Show(MsgTextFr.Getinstance.MsgErrServ, "Attention!")
        End If
    End Sub

    Private Sub LoadInfo()
        TBID.Text = table(0)(0)
        TBPrenom1.Text = table(0)(1)
        TBNom1.Text = table(0)(2)
        TBPrenom2.Text = table(0)(3)
        TBNom2.Text = table(0)(4)
        TBTel1.Text = table(0)(5)
        TBTel2.Text = table(0)(6)

        For i As Integer = 0 To liste.Length - 1
            If CBSexe.Items(i).ToString = table(0)(7) Then
                CBSexe.SelectedIndex = i
            End If
        Next

        TBEmail.Text = table(0)(8)

        If table(0)(9) <> "null" Then
            Dim str As String = table(0)(9)
            TBRue.Text = str.Substring(0, str.IndexOf(","))
            str = str.Substring(str.IndexOf(",") + 2)
            TBVille.Text = str.Substring(0, str.IndexOf(","))
            str = str.Substring(str.IndexOf(",") + 2)
            TBPro.Text = str
        End If

        TBApp.Text = table(0)(10)
        TBCode.Text = table(0)(11)
    End Sub

    Private Sub BTAnnuler_Click(sender As Object, e As EventArgs) Handles BTAnnuler.Click
        LoadInfo()
    End Sub

    Private Sub GestionClient_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'uc.LoadClient()
    End Sub

    Private Sub TBTel1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTel1.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TBTel2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTel2.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TBPrenom1_TextChanged(sender As Object, e As EventArgs) Handles TBPrenom1.TextChanged
        CheckChange()
    End Sub


    Private Sub CheckChange()
        For i As Integer = 0 To table.Columns.Count - 1

        Next
    End Sub
End Class