Public Class Connection
    Dim mainform As MainForm
    Sub New(main As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        mainform = main
    End Sub
    Private Sub Connection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbPass.PasswordChar() = "*"
        tbUser.Select()
    End Sub



    Private Sub btConnection_Click(sender As Object, e As EventArgs) Handles btConnection.Click
        verifConnection()
    End Sub

    Private Sub Connection_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        mainform.Show()
    End Sub

    Private Sub verifConnection()
        If tbUser.Text = "admin" And tbPass.Text = "Reception1234" Then
            Dim optionRecp As New OptionAvant(Me)
            Me.Hide()
            optionRecp.Show()
        Else
            MessageBox.Show("Nom d'utilisatuer ou mot de passe incorrecte!")
        End If
    End Sub

    Private Sub tbPass_KeyDown(sender As Object, e As KeyEventArgs) Handles tbPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            verifConnection()
        End If
    End Sub

    Private Sub tbUser_KeyDown(sender As Object, e As KeyEventArgs) Handles tbUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            verifConnection()
        End If
    End Sub
End Class