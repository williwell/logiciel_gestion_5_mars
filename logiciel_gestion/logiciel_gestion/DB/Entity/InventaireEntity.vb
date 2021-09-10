Imports MySql.Data.MySqlClient

Public Class InventaireEntity
    Dim connection As New MySqlConnection(ConnectionDB.getInstance.connectionString)
    Shared instance As InventaireEntity = Nothing
    Dim nomClass As String = "InventaireEntity"

    Public Shared Function getInstance() As InventaireEntity
        If IsNothing(instance) Then
            instance = New InventaireEntity
        End If
        Return instance
    End Function

    Public Function getInventaire(id As String) As DataTable
        Dim table As New DataTable("inventaire")
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Select * from inventaire where id='{id}'"
            connection.Open()
            Dim reader = command.ExecuteReader()
            table.Load(reader)
            connection.Close()
        Catch ex As Exception
            ErrLog.getInstance.writeErr(ex.Message, nomClass, "getInventaire")
            MessageBox.Show("Une erreur c'est produit!")
        End Try
        Return table
    End Function
End Class
