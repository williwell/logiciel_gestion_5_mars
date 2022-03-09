Public Class CreerClient
    ReadOnly client As UCClient
    Dim rue As Boolean
    Dim ville As Boolean
    Dim pro As Boolean

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
        rue = String.IsNullOrEmpty(TBRue.Text)
        ville = String.IsNullOrEmpty(TBVille.Text)
        pro = String.IsNullOrEmpty(TBProvince.Text)
        Dim liste(10) As String

        If String.IsNullOrEmpty(Trim(TBPrenom.Text)) Then
            MessageBox.Show("Vous devez rentrer un prénom")
        ElseIf String.IsNullOrEmpty(Trim(TBNom.Text)) Then
            MessageBox.Show("Vous devez rentrer un nom")
        Else
            If rue And ville And pro Then
                liste(8) = "null"
            ElseIf Not rue And Not ville And Not pro Then
                liste(8) = TBRue.Text & ", " & TBVille.Text & ", " & TBProvince.Text
            Else
                MessageBox.Show("Vous ne pouvez pas rentrer une adresse partielle!")
                Exit Sub
            End If

            liste(0) = TBPrenom.Text
            liste(1) = TBNom.Text

            If String.IsNullOrEmpty(Trim(TBPrenom2.Text)) Then
                liste(2) = "null"
            Else
                liste(2) = TBPrenom2.Text
            End If

            If String.IsNullOrEmpty(Trim(TBNom2.Text)) Then
                liste(3) = "null"
            Else
                liste(3) = TBNom2.Text
            End If

            If String.IsNullOrEmpty(Trim(TBTelephone.Text)) Then
                liste(4) = "null"
            Else
                liste(4) = TBTelephone.Text
            End If

            If String.IsNullOrEmpty(Trim(TBTel2.Text)) Then
                liste(5) = "null"
            Else
                liste(5) = TBTel2.Text
            End If

            liste(6) = CBSexe.SelectedItem
        If String.IsNullOrEmpty(Trim(TBEmail.Text)) Then
            liste(7) = "null"
        Else
            liste(7) = TBEmail.Text
        End If

        If String.IsNullOrEmpty(TBApp.Text) Then
                liste(9) = "null"
            Else
                liste(9) = TBApp.Text
            End If

            If String.IsNullOrEmpty(TBCode.Text) Then
                liste(10) = "null"
            Else
                liste(10) = TBCode.Text
            End If

            If ConnectionServeur.Getinstance.AddDelete(liste, "AddClient") Then
                    MessageBox.Show("Enregistrement effectuer avec succès")

                    Dim row As DataRow = MainForm.TableClient.NewRow
                    Dim nbr As Integer = 0
                    For r As Integer = 0 To MainForm.TableClient.Rows.Count - 1
                        If MainForm.TableClient.Rows(r).Item("id") >= nbr Then
                            nbr = Integer.Parse(MainForm.TableClient.Rows(r).Item("id")) + 1
                        End If
                    Next
                    row(0) = nbr
                    For c As Integer = 0 To liste.Length - 1
                        row(c + 1) = liste(c)
                    Next
                    MainForm.TableClient.Rows.Add(row)

                    'client.LoadClient()
                    Me.Close()
                Else
                    MessageBox.Show("Une erreure est survenu durant l'enregistrement!", "Attention!")
                End If
            End If
    End Sub

    Private Sub BTAnnuler_Click(sender As Object, e As EventArgs) Handles BTAnnuler.Click
        Me.Close()
    End Sub

    Private Sub TBTelephone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTelephone.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TBTel2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTel2.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class