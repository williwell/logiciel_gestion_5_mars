Imports MySql.Data.MySqlClient

Public Class InventaireModel
    Dim connection As New MySqlConnection(ConnectionDB.getInstance.connectionString)
    Shared instance As InventaireModel = Nothing
    Dim nomClass As String = "InventaireModel"

    Public Shared Function getInstance() As InventaireModel
        If IsNothing(instance) Then
            instance = New InventaireModel
        End If
        Return instance
    End Function

    Public Function ajouterInventaire(id As String, ajout As Integer, commande As Integer) As Boolean
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"update inventaire set quantite={ajout}, EnCommande={commande} where id='{id}'"
            connection.Open()
            Dim reader = command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            ErrLog.getInstance.writeErr(ex.Message, nomClass, "ajouterInventaire")
            MessageBox.Show("Une erreur c'est produit!")
            Return False
        End Try
    End Function

    Public Function enleverInventaire(id As String, enlever As Integer) As Boolean
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"update inventaire set quantite={enlever} where id='{id}'"
            connection.Open()
            Dim reader = command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            ErrLog.getInstance.writeErr(ex.Message, nomClass, "enleverInventaire")
            MessageBox.Show("Une erreur c'est produit!")
            Return False
        End Try
    End Function
End Class
