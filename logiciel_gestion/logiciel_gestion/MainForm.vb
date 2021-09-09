Imports MySql.Data.MySqlClient
Public Class MainForm

    Dim connection As New MySqlConnection(ConnectionDB.getInstance.connectionString)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Select * from inventaire"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("inventaire")
            table.Load(reader)
            connection.Close()
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class
