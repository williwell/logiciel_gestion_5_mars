Imports System.Data
Imports MySql.Data.MySqlClient
Public Class ModelModel
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    ReadOnly connection As New MySqlConnection(ConnectionDB.GetInstance.connectionString)
    Shared instance As ModelModel = Nothing
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
    Shared Function Getinstance() As ModelModel
        If IsNothing(instance) Then
            instance = New ModelModel
        End If
        Return instance
    End Function

    Public Function AddModel(Nom As String, cout As String) As DataTable
        Dim table As New DataTable
        table.Columns.Add("id", GetType(String))
        table.Rows.Add("0")
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection

            command.CommandText = $"insert into Model(Nom,cout) values('{Nom}',{cout})"

            connection.Open()
            command.ExecuteReader()
            connection.Close()

            table(0)(0) = EntityModel.GetInstance.GetLastIDModel()
            Return table
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "addModel")
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


