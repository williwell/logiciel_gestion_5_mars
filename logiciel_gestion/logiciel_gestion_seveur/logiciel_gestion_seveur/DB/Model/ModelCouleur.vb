Imports System.Data
Imports MySql.Data.MySqlClient
Public Class ModelCouleur
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    ReadOnly connection As New MySqlConnection(ConnectionDB.GetInstance.connectionString)
    Shared instance As ModelCouleur = Nothing
    ReadOnly nomClass As String = "ModelCouleur"


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
    Shared Function Getinstance() As ModelCouleur
        If IsNothing(instance) Then
            instance = New ModelCouleur
        End If
        Return instance
    End Function

    Public Function AddCouleur(liste() As String) As DataTable
        Dim table As New DataTable
        table.Columns.Add("bool", GetType(Boolean))
        table.Rows.Add(False)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"insert into Couleur(nom,code,cout,deleteCoul) values('{liste(0)}','{liste(1)}',{liste(2)},1)"

            connection.Open()
            command.ExecuteReader()
            connection.Close()

            table(0)(0) = True
            Return table
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "addCouleur")
            'MessageBox.Show("Une erreur c'est produit lors de l'ajout du fournisseur!")
            Return table
        End Try
    End Function

    Public Function AddCouleurMo(idCouleur As String, idModel As String) As DataTable
        Dim table As New DataTable
        table.Columns.Add("bool", GetType(Boolean))
        table.Rows.Add(False)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"insert into CouleurModel values({idCouleur},{idModel})"

            connection.Open()
            command.ExecuteReader()
            connection.Close()

            table(0)(0) = True
            Return table
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "addCouleurMo")
            'MessageBox.Show("Une erreur c'est produit lors de l'ajout du fournisseur!")
            Return table
        End Try
    End Function

    Public Function DeleteCouleurMo(idCouleur As String, idModel As String) As DataTable
        Dim table As New DataTable
        table.Columns.Add("bool", GetType(Boolean))
        table.Rows.Add(False)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"delete from CouleurModel where idCouleur = {idCouleur} and idModel = {idModel}"

            connection.Open()
            command.ExecuteReader()
            connection.Close()

            table(0)(0) = True
            Return table
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "DeleteCouleurMo")
            'MessageBox.Show("Une erreur c'est produit lors de l'ajout du fournisseur!")
            Return table
        End Try
    End Function

    Public Function UpdateCouleur(liste() As String) As DataTable
        Dim table As New DataTable
        table.Columns.Add("bool", GetType(Boolean))
        table.Rows.Add(False)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Update Couleur set nom = '{liste(1)}', code = '{liste(2)}', cout = {liste(3)} where id = {liste(0)}"

            connection.Open()
            command.ExecuteReader()
            connection.Close()

            table(0)(0) = True
            Return table
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "UpdateCouleur")
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
            command.CommandText = $"Update Couleur set DeleteCoul = 0 where id = {id}"

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


