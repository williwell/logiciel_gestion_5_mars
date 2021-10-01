Imports System.Data
Imports MySql.Data.MySqlClient
Public Class EntityFournisseur
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    ReadOnly connection As New MySqlConnection(ConnectionDB.GetInstance.connectionString)
    Shared instance As EntityFournisseur = Nothing
    ReadOnly nomClass As String = "EntityFournisseur"


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
    Public Shared Function GetInstance() As EntityFournisseur
        If IsNothing(instance) Then
            instance = New EntityFournisseur
        End If
        Return instance
    End Function

    Public Function GetFournisseur() As DataTable
        Dim table As New DataTable("fournisseur")
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"SELECT * FROM `fournisseur`"
            connection.Open()
            Dim reader = command.ExecuteReader()
            table.Load(reader)
            connection.Close()
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "getFournisseur")
            'MessageBox.Show("Une erreur c'est produit!")
        End Try
        Return table
    End Function

    Public Function GetOneFournisseur(id As Integer) As DataTable
        Dim table As New DataTable("fournisseur")
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"SELECT * FROM `fournisseur` where id = {id}"
            connection.Open()
            Dim reader = command.ExecuteReader()
            table.Load(reader)
            connection.Close()
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "getFournisseur")
            'MessageBox.Show("Une erreur c'est produit!")
        End Try
        Return table
    End Function

    Public Function GetFournisseur(id As String) As DataTable
        Dim table As New DataTable("fournisseur")
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"SELECT * FROM `fournisseur`
                                    inner join `invfour`
                                    on fournisseur.id = invfour.idFournisseur
                                    where invfour.idInventaire = '{id}' and invFour.idFournisseur <> 1"
            connection.Open()
            Dim reader = command.ExecuteReader()
            table.Load(reader)
            connection.Close()
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "getFournisseur")
            'MessageBox.Show("Une erreur c'est produit!")
        End Try
        Return table
    End Function

    Public Function GetFournisseurAdd(id() As Integer) As DataTable
        Dim table As New DataTable("fournisseur")
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            Dim str As String = "SELECT * FROM `fournisseur` where id <> 1 "
            For i As Integer = 0 To id.Count - 1
                str = str & " and id <> '" & id(i) & "'"
            Next
            command.CommandText = $"{str}"
            connection.Open()
            Dim reader = command.ExecuteReader()
            table.Load(reader)
            connection.Close()
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "getFournisseur")
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

