Imports MySql.Data.MySqlClient
Public Class EntityFournisseur
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    Dim connection As New MySqlConnection(ConnectionDB.getInstance.connectionString)
    Shared instance As EntityFournisseur = Nothing
    Dim nomClass As String = "EntityFournisseur"


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
    Public Shared Function getInstance() As EntityFournisseur
        If IsNothing(instance) Then
            instance = New EntityFournisseur
        End If
        Return instance
    End Function

    Public Function getFournisseur() As DataTable
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
            ErrLog.getInstance.writeErr(ex.Message, nomClass, "getFournisseur")
            MessageBox.Show("Une erreur c'est produit!")
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
