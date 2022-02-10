Imports System.ComponentModel

Public Class IPSetting
    Dim form As Form1

    Sub New(f As Form1)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        form = f
    End Sub

    Private Sub IPSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = form.GetOption1
        TextBox2.Text = form.GetOption2
    End Sub

    Private Sub IPSetting_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MyOption.SaveOption(TextBox1.Text, TextBox2.Text)
        form.SetOption(TextBox1.Text, TextBox2.Text)
    End Sub
End Class