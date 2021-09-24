Imports System.Data
Imports MySql.Data.MySqlClient
Public Class EntityInventaire
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    ReadOnly connection As New MySqlConnection(ConnectionDB.GetInstance.connectionString)
    Shared instance As EntityInventaire = Nothing
    ReadOnly nomClass As String = "EntityInventaire"


    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Functions
    '__________________________________________________________________________________________________________
    Public Shared Function GetInstance() As EntityInventaire
        If IsNothing(instance) Then
            instance = New EntityInventaire
        End If
        Return instance
    End Function

    Public Function GetInventaire(id As String) As DataTable
        Dim table As New DataTable("inventaire")
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"SELECT * FROM `inventaire`
                                    inner join `invfour`
                                    on inventaire.id = invfour.idInventaire
                                    inner join `fournisseur`
                                    on invfour.idFournisseur = fournisseur.id
                                    WHERE inventaire.id = '{id}'"
            connection.Open()
            Dim reader = command.ExecuteReader()
            table.Load(reader)
            connection.Close()
            If Not table.Rows.Count > 0 Then
                table = New DataTable
                table.Columns.Add("error", GetType(String))
                table.Rows.Add("\\null")
            End If
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "getInventaire")
            Msg("Une erreur c'est produit!")
        End Try
        Return table
    End Function

    Public Function GetInventaire() As DataTable
        Dim table As New DataTable("inventaire")
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Select * from inventaire"
            connection.Open()
            Dim reader = command.ExecuteReader()
            table.Load(reader)
            connection.Close()
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "getInventaire")
            'MessageBox.Show("Une erreur c'est produit!")
        End Try
        Return table
    End Function

    Public Function GetInventaireOfFour(id As Integer) As DataTable
        Dim table As New DataTable("inventaire")
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Select * from inventaire
                                    inner join `invfour`
                                    on inventaire.id = invfour.idInventaire
                                    where invfour.idFournisseur = {id}"
            connection.Open()
            Dim reader = command.ExecuteReader()
            table.Load(reader)
            connection.Close()
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "getInventaireOfFour")
            'MessageBox.Show("Une erreur c'est produit!")
        End Try
        Return table
    End Function
    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Set
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Get
    '__________________________________________________________________________________________________________

End Class
