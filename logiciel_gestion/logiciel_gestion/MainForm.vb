Imports MySql.Data.MySqlClient
Public Class MainForm
    Dim ucAjout As New UCReseptionInventaire
    Dim ucRetirer As New UCRetirerInventaire

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
End Class
