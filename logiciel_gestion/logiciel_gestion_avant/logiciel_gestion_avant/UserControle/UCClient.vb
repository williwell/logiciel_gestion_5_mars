Public Class UCClient
    ReadOnly main As MainForm
    ReadOnly search As New BindingSource

    Sub New(mainform As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = mainform
    End Sub

    Private Sub UCClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVClient.DataSource = MainForm.TableClient
        search.DataSource = DGVClient.DataSource

        For c As Integer = 0 To DGVClient.Columns.Count - 1
            DGVClient.Columns(c).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
    End Sub

    'Crée un nouveau form de type CreerClient et le faire apparaitre
    Private Sub BtCreer_Click(sender As Object, e As EventArgs) Handles BtCreer.Click
        Dim creer As New CreerClient(Me)
        creer.ShowDialog(Me)
    End Sub

    'Si on double click sur une ligne du DataGridView on crée un nouveau form de GestionClient avec comme paramètre la ligne du DataGridView e ton affiche
    Private Sub DGVClient_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClient.CellDoubleClick
        If DGVClient.CurrentRow IsNot Nothing Then
            If e.RowIndex >= 0 Then
                Dim InfoClient As New GestionClient(DGVClient.CurrentRow.Cells(0).Value)
                InfoClient.ShowDialog(Me)
            End If
        End If
    End Sub

    'Si on click sur le UserControl on s'assure que le menu est fermé
    Private Sub UCClient_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        main.fermerMenu()
    End Sub

    Private Sub TBSearchMat_TextChanged(sender As Object, e As EventArgs) Handles TBPreNom.TextChanged, TBTel.TextChanged, TBEmail.TextChanged, TBNom.TextChanged
        Dim str As String = ""

        If Not String.IsNullOrEmpty(Trim(TBPreNom.Text)) Then
            str += "(Prenom1 like '%" & TBPreNom.Text & "%' or Prenom2 like '%" & TBPreNom.Text & "%')"
        End If

        If Not String.IsNullOrEmpty(Trim(TBNom.Text)) Then
            If String.IsNullOrEmpty(str) Then
                str += "(Nom1 like'%" & TBNom.Text & "%' or Nom2 like'%" & TBNom.Text & "%')"
            Else
                str += " and (Nom1 like '%" & TBNom.Text & "%' or Nom2 like'%" & TBNom.Text & "%')"
            End If
        End If

        If Not String.IsNullOrEmpty(Trim(TBTel.Text)) Then
            If String.IsNullOrEmpty(str) Then
                str += "(Telephone1 like'%" & TBTel.Text & "%' or Telephone2 like'%" & TBTel.Text & "%')"
            Else
                str += " and (Telephone1 like '%" & TBTel.Text & "%' or Telephone2 like'%" & TBTel.Text & "%')"
            End If
        End If

        If Not String.IsNullOrEmpty(Trim(TBEmail.Text)) Then
            If String.IsNullOrEmpty(str) Then
                str += "Email like '%" & TBEmail.Text & "%'"
            Else
                str += " and Email like '%" & TBEmail.Text & "%'"
            End If
        End If

        search.Filter = str
    End Sub
End Class
