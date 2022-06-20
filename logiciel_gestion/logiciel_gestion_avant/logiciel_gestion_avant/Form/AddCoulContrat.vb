Imports System.ComponentModel

Public Class AddCoulContrat
    ReadOnly liste() As String
    ReadOnly table As New DataTable
    ReadOnly contrat As CreerCommande
    ReadOnly vehicule As CreerVehicule
    Sub New(lst() As String, form As CreerCommande)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        liste = lst
        contrat = form
    End Sub

    Sub New(lst() As String, form As CreerVehicule)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        liste = lst
        vehicule = form
    End Sub

    Private Sub AddCoulContrat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        table.Columns.Add("Nom")
        table.Columns.Add("Nom Couleur")
        table.Columns.Add("Code")

        If liste.Length > 0 Then
            For i As Integer = 0 To (liste.Length / 3) - 1
                Dim row As DataRow = table.NewRow
                row(0) = liste(i * 3)
                row(1) = liste(i * 3 + 1)
                row(2) = liste(i * 3 + 2)
                table.Rows.Add(row)
            Next
        End If

        DGV.DataSource = table
        DGV.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub BTAdd_Click(sender As Object, e As EventArgs) Handles BTAdd.Click
        If String.IsNullOrEmpty(TBNom.Text) Then
            MessageBox.Show(MsgTextFr.Getinstance.MsgErrTBVide + "un nom")
        Else
            If String.IsNullOrEmpty(TBCouleur.Text) Then
                MessageBox.Show(MsgTextFr.Getinstance.MsgErrTBVide + "une couleur")
            Else
                Dim row As DataRow = table.NewRow
                row(0) = TBNom.Text
                row(1) = TBCouleur.Text
                row(2) = TBCode.Text
                table.Rows.Add(row)
                TBNom.Text = ""
                TBCouleur.Text = ""
                TBCode.Text = ""
                TBNom.Select()
            End If
        End If
    End Sub

    Private Sub BTDelete_Click(sender As Object, e As EventArgs) Handles BTDelete.Click
        If DGV.CurrentRow IsNot Nothing Then
            DGV.Rows.Remove(DGV.CurrentRow)
        End If
    End Sub

    Private Sub BTEnd_Click(sender As Object, e As EventArgs) Handles BTEnd.Click
        Me.Close()
    End Sub

    Private Sub AddCoulContrat_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim lst(DGV.Rows.Count * 3 - 1) As String
        For r As Integer = 0 To DGV.Rows.Count - 1
            lst(r * 3) = DGV.Rows(r).Cells(0).Value
            lst(r * 3 + 1) = DGV.Rows(r).Cells(1).Value
            lst(r * 3 + 2) = DGV.Rows(r).Cells(2).Value
        Next
        If IsNothing(contrat) Then
            vehicule.RemplirListe(lst)
        Else
            contrat.RemplirListe(lst)
        End If
    End Sub
End Class