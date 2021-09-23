Imports System.Data
Imports MySql.Data.MySqlClient
Public Class ModelInventaire
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    Dim connection As New MySqlConnection(ConnectionDB.GetInstance.connectionString)
    Shared instance As ModelInventaire = Nothing
    Dim nomClass As String = "ModelInventaire"


    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________
    Public Function modInventaire(liste() As String) As DataTable
        Dim table As New DataTable
        table.Columns.Add("bool", GetType(Boolean))
        table.Rows.Add(False)

        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"update inventaire set   nom='{liste(1)}',
                                                            quantite={Integer.Parse(liste(2))},
                                                            description='{liste(3)}',
                                                            emplacement='{liste(4)}',
                                                            utilise={liste(5)},
                                                            enCommande={Integer.Parse(liste(6))},
                                                            minStock={Integer.Parse(liste(7))}
                                                            where id ='{liste(0)}'"
            connection.Open()
            Dim reader = command.ExecuteReader()
            connection.Close()

            table(0)(0) = True
            Return table
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "modInventaire")
            'MessageBox.Show("Une erreur c'est produit!")
            Return table
        End Try
    End Function

    Public Function ajoutInventaire(liste() As String) As DataTable
        Dim table As New DataTable
        table.Columns.Add("bool", GetType(Boolean))
        table.Rows.Add(False)

        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"insert into inventaire values(  '{liste(0)}',
                                                                        '{liste(1)}',
                                                                        {Integer.Parse(liste(2))},
                                                                        '{liste(3)}',
                                                                        '{liste(5)}',
                                                                        {liste(7)},
                                                                        {Integer.Parse(liste(8))},
                                                                        {Integer.Parse(liste(9))})"

            connection.Open()
            Dim reader = command.ExecuteReader()
            connection.Close()

            table(0)(0) = True
            Return table
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "ajoutInventaire")
            'MessageBox.Show("Une erreur c'est produit!")
            Return table
        End Try
    End Function

    '__________________________________________________________________________________________________________
    'Functions
    '__________________________________________________________________________________________________________
    Public Shared Function getInstance() As ModelInventaire
        If IsNothing(instance) Then
            instance = New ModelInventaire
        End If
        Return instance
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

