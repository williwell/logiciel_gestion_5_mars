Public Class CreerClient
    Dim client As UCClient

    Sub New(cl As UCClient)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        client = cl
    End Sub

    Private Sub CreerClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim liste() As String = {"Non déterminer", "Homme", "Femme"}
        CBSexe.DataSource = liste
    End Sub

    Private Sub BTSave_Click(sender As Object, e As EventArgs) Handles BTSave.Click
        If String.IsNullOrEmpty(Trim(TBPrenom.Text)) Then
            MessageBox.Show("Vous devez rentrer un prénom")
        ElseIf String.IsNullOrEmpty(trim(TBNom.Text)) Then
            MessageBox.Show("Vous devez rentrer un nom")
        Else
            Dim liste(4) As String
            liste(0) = TBPrenom.Text
            liste(1) = TBNom.Text
            If String.IsNullOrEmpty(Trim(TBTelephone.Text)) Then
                liste(2) = "null"
            Else
                liste(2) = TBTelephone.Text
            End If
            liste(3) = CBSexe.SelectedItem
            If String.IsNullOrEmpty(Trim(TBEmail.Text)) Then
                liste(4) = "null"
            Else
                liste(4) = TBEmail.Text
            End If
            If ConnectionServeur.Getinstance.AddDelete(liste, "AddClient") Then
                MessageBox.Show("Enregistrement effectuer avec succès")
            Else
                MessageBox.Show("Une erreure est survenu durant l'enregistrement!", "Attention!")
            End If
        End If
        client.loadClient()
        Me.Close()
    End Sub

    Private Sub BTAnnuler_Click(sender As Object, e As EventArgs) Handles BTAnnuler.Click
        Me.Close()
    End Sub

    Private Sub TBTelephone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTelephone.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class