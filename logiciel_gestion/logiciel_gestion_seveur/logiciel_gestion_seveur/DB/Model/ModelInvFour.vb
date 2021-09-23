Imports System.Data
Imports MySql.Data.MySqlClient
Public Class ModelInvFour
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    ReadOnly connection As New MySqlConnection(ConnectionDB.GetInstance.connectionString)
    Shared instance As ModelInvFour = Nothing
    ReadOnly nomClass As String = "ModelInvFour"


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
    Shared Function Getinstance() As ModelInvFour
        If IsNothing(instance) Then
            instance = New ModelInvFour
        End If
        Return instance
    End Function

    Public Function AddInvFour(liste() As String) As DataTable
        Dim table As New DataTable
        table.Columns.Add("bool", GetType(Boolean))
        table.Rows.Add(False)

        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection
            If liste.Length > 2 Then
                command.CommandText = $"insert into invfour values('{liste(0)}',{Integer.Parse(liste(1))},{Double.Parse(liste(2))}, '{liste(3)}', '{liste(4)}')"
            Else
                command.CommandText = $"insert into invfour values('{liste(0)}',{Integer.Parse(liste(1))},0,'null','null')"
            End If


            connection.Open()
            command.ExecuteReader()
            connection.Close()

            table(0)(0) = True
            Return table
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "addInvFour")
            'MessageBox.Show("Une erreur c'est produit lors de l'ajout du fournisseur!")
            Return table
        End Try
    End Function

    Public Function ModInvFour(liste() As String) As DataTable
        Dim table As New DataTable
        table.Columns.Add("bool", GetType(Boolean))
        table.Rows.Add(False)

        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"update invfour set  coutUnitaire = {Double.Parse(liste(2))},
                                                        noFour = '{liste(3)}',
                                                        noMFR = '{liste(4)}'
                                                        where idInventaire = '{liste(0)}' and idFournisseur = {Integer.Parse(liste(1))}"

            connection.Open()
            command.ExecuteReader()
            connection.Close()

            table(0)(0) = True
            Return table
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "modInvFour")
            'MessageBox.Show("Une erreur c'est produit lors de l'ajout du fournisseur!")
            Return table
        End Try
    End Function

    Public Function DelInvFour(liste() As String) As DataTable
        Dim table As New DataTable
        table.Columns.Add("bool", GetType(Boolean))
        table.Rows.Add(False)

        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"delete from invfour where idInventaire = '{liste(0)}' and idfournisseur = {Integer.Parse(liste(1))}"

            connection.Open()
            command.ExecuteReader()
            connection.Close()

            table(0)(0) = True
            Return table
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "delInvFour")
            'MessageBox.Show("Une erreur c'est produit lors de la suppression du fournisseur!")
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

