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
        MainForm.getInstance.setOption(tbIp.Text, tbNom.Text, tbDBName.Text, tbNomUserDB.Text, tbPassUserDB.Text, Integer.Parse(tbPortDB.Text))
        MyOption.getInstance.saveOption()
    End Sub

    Private Sub OptionReception_Load(sender As Object, e As EventArgs) Handles Me.Load
        tbIp.Text = MainForm.getInstance.getOption1()
        tbNom.Text = MainForm.getInstance.getOption2()
        tbDBName.Text = MainForm.getInstance.getOption3()
        tbNomUserDB.Text = MainForm.getInstance.getOption4()
        tbPassUserDB.Text = MainForm.getInstance.getOption5()
        tbPortDB.Text = MainForm.getInstance.getOption6()
    End Sub

    Private Sub btAnnuler_Click(sender As Object, e As EventArgs) Handles btAnnuler.Click
        Me.Close()
    End Sub
End Class