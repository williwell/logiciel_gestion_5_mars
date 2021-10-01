Imports System.ComponentModel

Public Class OptionAvant
    ReadOnly connectionForm As Connection

    Sub New(connection As Connection)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        connectionForm = connection
    End Sub

    Private Sub OptionAvant_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        connectionForm.Show()
    End Sub

    Private Sub BtSauv_Click(sender As Object, e As EventArgs) Handles btSauv.Click
        MainForm.GetInstance.SetOption(tbIp.Text, tbNom.Text, Integer.Parse(tbPortDB.Text))
        MyOption.GetInstance.SaveOption()
    End Sub

    Private Sub OptionReception_Load(sender As Object, e As EventArgs) Handles Me.Load
        tbIp.Text = MainForm.getInstance.getOption1()
        tbNom.Text = MainForm.getInstance.getOption2()
        tbPortDB.Text = MainForm.getInstance.getOption3()
    End Sub

    Private Sub BtAnnuler_Click(sender As Object, e As EventArgs) Handles btAnnuler.Click
        Me.Close()
    End Sub


End Class