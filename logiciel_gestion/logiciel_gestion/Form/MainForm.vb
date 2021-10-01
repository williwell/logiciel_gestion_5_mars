Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class MainForm
    Dim ucAjout As New UCReseptionInventaire
    Dim ucRetirer As New UCRetirerInventaire
    Dim keyCombo As New List(Of Keys)({Keys.ControlKey, Keys.H, Keys.P})
    Dim currentKeys As New List(Of Keys)
    Dim options As New StructureOption.mesOption
    Shared instance As MainForm = Nothing
    Private Delegate Sub setValue(bool As Boolean)

    Public Shared Function getInstance() As MainForm
        If IsNothing(instance) Then
            instance = New MainForm
        End If
        Return instance
    End Function

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        currentKeys.Add(e.KeyCode)

        If currentKeys.Intersect(keyCombo).Count = keyCombo.Count Then
            currentKeys.Clear()
            Dim connection As New Connection(Me)
            Me.Hide()
            connection.Show()
        End If

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        currentKeys.Remove(e.KeyCode)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        MyOption.getInstance.readOption()
        If Not ConnectionServeur.getinstance.TestConnection() Then
            lostConc(True)
        End If
        ConnectionServeur.setMain(Me)
    End Sub


    Private Sub btAjoutUc_Click(sender As Object, e As EventArgs) Handles btAjoutUc.Click
        ucAjout.Dispose()
        ucAjout = New UCReseptionInventaire
        Panel1.Controls.Clear()
        Panel1.Controls.Add(ucAjout)
    End Sub

    Private Sub btRetirerUc_Click(sender As Object, e As EventArgs) Handles btRetirerUc.Click
        ucRetirer.Dispose()
        ucRetirer = New UCRetirerInventaire
        Panel1.Controls.Clear()
        Panel1.Controls.Add(ucRetirer)
    End Sub

    Public Sub lostConc(bool As Boolean)
        btAjoutUc.Enabled = Not bool
        btRetirerUc.Enabled = Not bool
        btReconnect.Visible = bool
    End Sub

    Public Sub setOption(str1 As String, str2 As String, int3 As Integer)
        options.option1 = str1
        options.option2 = str2
        options.option3 = int3
    End Sub

    Public Function getOption1() As String
        Return options.option1
    End Function

    Public Function getOption2() As String
        Return options.option2
    End Function

    Public Function getOption3() As String
        Return options.option3
    End Function

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ConnectionServeur.getinstance.fermer()
    End Sub

    Private Sub btReconnect_Click(sender As Object, e As EventArgs) Handles btReconnect.Click
        If ConnectionServeur.getinstance.TestConnection() Then
            lostConc(False)
        Else
            MessageBox.Show("Toujours impossible de se connecter au serveur!")
        End If
    End Sub

    Public Sub fermer()
        If btAjoutUc.InvokeRequired Then
            Dim d As New setValue(AddressOf SetTexte)
            BeginInvoke(d, New Object() {True})
        Else
            lostConc(True)
        End If
    End Sub

    Private Sub SetTexte(bool As Boolean)
        lostConc(bool)
    End Sub
End Class
