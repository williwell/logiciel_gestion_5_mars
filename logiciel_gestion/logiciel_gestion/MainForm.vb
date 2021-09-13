Imports MySql.Data.MySqlClient
Public Class MainForm
    Dim ucAjout As New UCReseptionInventaire
    Dim ucRetirer As New UCRetirerInventaire
    Dim keyCombo As New List(Of Keys)({Keys.ControlKey, Keys.H, Keys.P})
    Dim currentKeys As New List(Of Keys)
    Dim options As New StructureOption.mesOption
    Shared instance As MainForm = Nothing

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
    End Sub


    Private Sub btAjoutUc_Click(sender As Object, e As EventArgs) Handles btAjoutUc.Click
        ucAjout.Dispose()
        ucAjout = enleverUCAjout()
        Panel1.Controls.Clear()
        Panel1.Controls.Add(ucAjout)
    End Sub

    Private Sub btRetirerUc_Click(sender As Object, e As EventArgs) Handles btRetirerUc.Click
        ucRetirer.Dispose()
        ucRetirer = enleverUCEnlever()
        Panel1.Controls.Clear()
        Panel1.Controls.Add(ucRetirer)
    End Sub

    Private Function enleverUCAjout() As UCReseptionInventaire
        Return New UCReseptionInventaire
    End Function

    Private Function enleverUCEnlever() As UCRetirerInventaire
        Return New UCRetirerInventaire
    End Function

    Public Sub setOption(str1 As String, str2 As String)
        options.option1 = str1
        options.option2 = str2
    End Sub

    Public Function getOption1() As String
        Return options.option1
    End Function

    Public Function getOption2() As String
        Return options.option2
    End Function
End Class
