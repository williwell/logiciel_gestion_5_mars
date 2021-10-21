Imports System.Data
Imports MySql.Data.MySqlClient
Public Class EntityOption
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    ReadOnly connection As New MySqlConnection(ConnectionDB.GetInstance.connectionString)
    Shared instance As EntityOption = Nothing
    ReadOnly nomClass As String = "EntityOption"


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
    Public Shared Function GetInstance() As EntityOption
        If IsNothing(instance) Then
            instance = New EntityOption
        End If
        Return instance
    End Function

    Public Function GetOptionModel(id As Integer) As DataTable
        Dim table As New DataTable("option")
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"SELECT id,nom,cout  FROM `optiondispo`
                                                        inner join optionmodel
                                                        on id = idOption
                                                        where idModel = '{id}'"
            connection.Open()
            Dim reader = command.ExecuteReader()
            table.Load(reader)
            connection.Close()
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "getOptionModel")
            'MessageBox.Show("Une erreur c'est produit!")
        End Try
        Return table
    End Function

    Public Function GetOptionDispo(id() As String) As DataTable
        Dim table As New DataTable("option")
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            Dim str As String = "SELECT id,nom,cout FROM `optionDispo` where id <> 0 and DeleteOpt <> 0"
            For i As Integer = 0 To id.Count - 1
                str = str & " and id <> " & id(i) & ""
            Next
            command.CommandText = str
            connection.Open()
            Dim reader = command.ExecuteReader()
            table.Load(reader)
            connection.Close()
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "getOptionDispo")
            'MessageBox.Show("Une erreur c'est produit!")
        End Try
        Return table
    End Function

    Public Function GetOptionDispo() As DataTable
        Dim table As New DataTable("option")
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = "SELECT id,nom,cout FROM `optionDispo` where DeleteOpt <> 0"
            connection.Open()
            Dim reader = command.ExecuteReader()
            table.Load(reader)
            connection.Close()
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "getOptionDispo")
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


