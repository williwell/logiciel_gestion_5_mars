Imports System.ComponentModel

Public Class OptionReception
    Dim connectionForm As Connection

    Sub New(connection As Connection)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        connectionForm = connection
    End Sub

    Private Sub OptionReception_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        connectionForm.Show()
    End Sub

    Private Sub btSauv_Click(sender As Object, e As EventArgs) Handles btSauv.Click
        MainForm.getInstance.setOption(tbIp.Text, tbNom.Text)
        MyOption.getInstance.saveOption()
    End Sub

    Private Sub OptionReception_Load(sender As Object, e As EventArgs) Handles Me.Load
        tbIp.Text = MainForm.getInstance.getOption1()
        tbNom.Text = MainForm.getInstance.getOption2()
    End Sub
End Class