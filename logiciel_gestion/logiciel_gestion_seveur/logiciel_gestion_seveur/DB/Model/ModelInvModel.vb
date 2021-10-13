Imports System.Data
Imports MySql.Data.MySqlClient
Public Class ModelInvModel
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    ReadOnly connection As New MySqlConnection(ConnectionDB.GetInstance.connectionString)
    Shared instance As ModelInvModel = Nothing
    ReadOnly nomClass As String = "ModelInvModel"


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
    Shared Function Getinstance() As ModelInvModel
        If IsNothing(instance) Then
            instance = New ModelInvModel
        End If
        Return instance
    End Function

    Public Function AddInvMo(texte() As String, idModel As String) As DataTable
        Dim table As New DataTable
        table.Columns.Add("bool", GetType(Boolean))
        table.Rows.Add(False)
        Try
            For i As Integer = 0 To texte.Length - 1
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If

                Dim command As New MySqlCommand
                command.Connection = connection

                Dim idInv = texte(i)
                i += 1
                Dim nbr = texte(i)

                command.CommandText = $"Insert into inventaireModel values({idInv},{idModel},{nbr})"

                connection.Open()
                command.ExecuteReader()
                connection.Close()
            Next

            table(0)(0) = True
            Return table
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "addInvMo")
            'MessageBox.Show("Une erreur c'est produit lors de l'ajout du fournisseur!")
            Return table
        End Try
    End Function

    Public Function DeleteInvMo(idInv As String, idModel As String) As DataTable
        Dim table As New DataTable
        table.Columns.Add("bool", GetType(Boolean))
        table.Rows.Add(False)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection

            command.CommandText = $"Delete from InventaireModel where idInventaire = {idInv} and idmodel = {idModel}"

            connection.Open()
            command.ExecuteReader()
            connection.Close()

            table(0)(0) = True
            Return table
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "addInvMo")
            'MessageBox.Show("Une erreur c'est produit lors de l'ajout du fournisseur!")
            Return table
        End Try
    End Function

    Public Function UpdateInvMo(idInv As String, idModel As String, nbr As Integer) As DataTable
        Dim table As New DataTable
        table.Columns.Add("bool", GetType(Boolean))
        table.Rows.Add(False)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection

            command.CommandText = $"Update inventaireModel set NombreItem = {nbr} where idInventaire = {idInv} and idmodel = {idModel}"

            connection.Open()
            command.ExecuteReader()
            connection.Close()

            table(0)(0) = True
            Return table
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "UpdateInvMo")
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



