Imports System.Data
Imports MySql.Data.MySqlClient
Public Class ModelOption
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    ReadOnly connection As New MySqlConnection(ConnectionDB.GetInstance.connectionString)
    Shared instance As ModelOption = Nothing
    ReadOnly nomClass As String = "ModelOption"


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
    Shared Function Getinstance() As ModelOption
        If IsNothing(instance) Then
            instance = New ModelOption
        End If
        Return instance
    End Function

    Public Function AddOptionMo(idOption As String, idModel As String) As DataTable
        Dim table As New DataTable
        table.Columns.Add("bool", GetType(Boolean))
        table.Rows.Add(False)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection

            command.CommandText = $"insert into optionModel values({idOption},{idModel})"

            connection.Open()
            command.ExecuteReader()
            connection.Close()

            table(0)(0) = True
            Return table
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "addOptionMo")
            'MessageBox.Show("Une erreur c'est produit lors de l'ajout du fournisseur!")
            Return table
        End Try
    End Function

    Public Function DeleteOpMo(idOption As String, idModel As String) As DataTable
        Dim table As New DataTable
        table.Columns.Add("bool", GetType(Boolean))
        table.Rows.Add(False)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"delete from OptionModel where idoption = {idOption} and idModel = {idModel}"

            connection.Open()
            command.ExecuteReader()
            connection.Close()

            table(0)(0) = True
            Return table
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "DeleteOpMo")
            'MessageBox.Show("Une erreur c'est produit lors de l'ajout du fournisseur!")
            Return table
        End Try
    End Function

    Public Function DeleteOpItem(liste() As String) As DataTable
        Dim table As New DataTable
        table.Columns.Add("bool", GetType(Boolean))
        table.Rows.Add(False)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"delete from OptionModel where idoption = {liste(1)} and idPiece = {liste(0)}"

            connection.Open()
            command.ExecuteReader()
            connection.Close()

            table(0)(0) = True
            Return table
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "DeleteOpMo")
            'MessageBox.Show("Une erreur c'est produit lors de l'ajout du fournisseur!")
            Return table
        End Try
    End Function

    Public Function UpdateOption(liste() As String) As DataTable
        Dim table As New DataTable
        table.Columns.Add("bool", GetType(Boolean))
        table.Rows.Add(False)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Update optiondispo set nom = '{liste(1)}', cout = {liste(2)} where id = {liste(0)}"

            connection.Open()
            command.ExecuteReader()
            connection.Close()

            table(0)(0) = True
            Return table
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "UpdateOption")
            'MessageBox.Show("Une erreur c'est produit lors de l'ajout du fournisseur!")
            Return table
        End Try
    End Function

    Public Function ChangeDelete(id As String) As DataTable
        Dim table As New DataTable
        table.Columns.Add("bool", GetType(Boolean))
        table.Rows.Add(False)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Update Optiondispo set DeleteOpt = 0 where id = {id}"

            connection.Open()
            command.ExecuteReader()
            connection.Close()

            table(0)(0) = True
            Return table
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "ChangeDelete")
            'MessageBox.Show("Une erreur c'est produit lors de l'ajout du fournisseur!")
            Return table
        End Try
    End Function

    Public Function CreateOption(liste() As String) As DataTable
        Dim table As New DataTable
        table.Columns.Add("bool", GetType(String))
        table.Rows.Add("False")
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Insert into OptionDispo(nom,cout,DeleteOpt) values('{liste(0)}',{liste(1)},1)"

            connection.Open()
            command.ExecuteReader()
            connection.Close()

            table(0)(0) = LastId()
            Return table
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "CreateOption")
            'MessageBox.Show("Une erreur c'est produit lors de l'ajout du fournisseur!")
            Return table
        End Try
    End Function

    Public Function LastId() As String
        Dim table As New DataTable
        table.Columns.Add("id", GetType(String))
        table.Rows.Add("False")
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Select id from optiondispo ORDER BY ID DESC LIMIT 1"

            connection.Open()
            Dim reader = command.ExecuteReader()
            table.Load(reader)
            connection.Close()

            Return table(1)(0)
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "LastId")
            'MessageBox.Show("Une erreur c'est produit lors de l'ajout du fournisseur!")
            Return table(0)(0)
        End Try
    End Function


    Public Function AddOptionItem(liste() As String) As DataTable
        Dim table As New DataTable
        table.Columns.Add("bool", GetType(Boolean))
        table.Rows.Add(False)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection

            command.CommandText = $"insert into optionPiece values({liste(0)},{liste(1)},{liste(2)})"

            connection.Open()
            command.ExecuteReader()
            connection.Close()

            table(0)(0) = True
            Return table
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "addOptionItem")
            'MessageBox.Show("Une erreur c'est produit lors de l'ajout du fournisseur!")
            Return table
        End Try
    End Function

    Public Function UpdateOptInv(idInv As String, idOpt As String, nbr As Integer) As DataTable
        Dim table As New DataTable
        table.Columns.Add("bool", GetType(Boolean))
        table.Rows.Add(False)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection

            command.CommandText = $"Update OptionPiece set Quantite = {nbr} where idPiece = {idInv} and idOption = {idOpt}"

            connection.Open()
            command.ExecuteReader()
            connection.Close()

            table(0)(0) = True
            Return table
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "UpdateOptInv")
            'MessageBox.Show("Une erreur c'est produit lors de l'ajout du fournisseur!")
            Return table
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


