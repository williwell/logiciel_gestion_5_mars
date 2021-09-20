Imports MySql.Data.MySqlClient
Public Class ModelInvFour
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    Dim connection As New MySqlConnection(ConnectionDB.getInstance.connectionString)
    Shared instance As ModelInvFour = Nothing
    Dim nomClass As String = "ModelInvFour"


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
    Shared Function getinstance() As ModelInvFour
        If IsNothing(instance) Then
            instance = New ModelInvFour
        End If
        Return instance
    End Function

    Public Function addInvFour(idInv As String, idFour As Integer) As Boolean
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"insert into invfour values('{idInv}',{idFour},0,'null','null')"

            connection.Open()
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            ErrLog.getInstance.writeErr(ex.Message, nomClass, "addInvFour")
            MessageBox.Show("Une erreur c'est produit lors de l'ajout du fournisseur!")
            Return False
        End Try
    End Function

    Public Function addInvFour(idInv As String, idFour As Integer, cout As Double, noFour As String, noMFR As String) As Boolean
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"insert into invfour values('{idInv}',{idFour},{cout}, '{noFour}', '{noMFR}')"

            connection.Open()
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            ErrLog.getInstance.writeErr(ex.Message, nomClass, "addInvFour")
            MessageBox.Show("Une erreur c'est produit lors de l'ajout du fournisseur!")
            Return False
        End Try
    End Function

    Public Function delInvFour(idInv As String, idFour As Integer) As Boolean
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"delete from invfour where idInventaire = '{idInv}' and idfournisseur = {idFour}"

            connection.Open()
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            ErrLog.getInstance.writeErr(ex.Message, nomClass, "delInvFour")
            MessageBox.Show("Une erreur c'est produit lors de la suppression du fournisseur!")
            Return False
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
