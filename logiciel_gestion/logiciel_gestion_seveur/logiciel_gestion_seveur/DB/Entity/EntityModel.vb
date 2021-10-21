Imports System.Data
Imports MySql.Data.MySqlClient
Public Class EntityModel
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    ReadOnly connection As New MySqlConnection(ConnectionDB.GetInstance.connectionString)
    Shared instance As EntityModel = Nothing
    ReadOnly nomClass As String = "EntityModel"


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
    Public Shared Function GetInstance() As EntityModel
        If IsNothing(instance) Then
            instance = New EntityModel
        End If
        Return instance
    End Function

    Public Function GetModel() As DataTable
        Dim table As New DataTable("model")
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"SELECT * FROM `model`"
            connection.Open()
            Dim reader = command.ExecuteReader()
            table.Load(reader)
            connection.Close()
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "getModel")
            'MessageBox.Show("Une erreur c'est produit!")
        End Try
        Return table
    End Function

    Public Function GetLastIDModel() As String
        Dim table As New DataTable("Model")
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"SELECT * FROM Model ORDER BY ID DESC LIMIT 1"
            connection.Open()
            Dim reader = command.ExecuteReader()
            table.Load(reader)
            connection.Close()
            Return table(0)(0)
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "getLastIdModel")
            'MessageBox.Show("Une erreur c'est produit!")
            Return "0"
        End Try
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


