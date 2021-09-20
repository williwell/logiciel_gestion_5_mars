Imports MySql.Data.MySqlClient
Public Class ModelInventaire
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    Dim connection As New MySqlConnection(ConnectionDB.getInstance.connectionString)
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
    Public Function modInventaire(liste() As String, id As String) As Boolean
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"update inventaire set   nom='{liste(1)}',
                                                            quantite={Integer.Parse(liste(2))},
                                                            description='{liste(3)}',
                                                            idFournisseur={Integer.Parse(liste(4))},
                                                            emplacement='{liste(5)}',
                                                            coutUnitaire={Double.Parse(liste(6))},
                                                            utilise={liste(7)},
                                                            enCommande={Integer.Parse(liste(8))},
                                                            minStock={Integer.Parse(liste(9))}
                                                            where id ='{id}'"
            connection.Open()
            Dim reader = command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            ErrLog.getInstance.writeErr(ex.Message, nomClass, "modInventaire")
            MessageBox.Show("Une erreur c'est produit!")
            Return False
        End Try
    End Function

    Public Function ajoutInventtaire(liste() As String) As Boolean
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
                                                                        {Integer.Parse(liste(4))},
                                                                        '{liste(5)}',
                                                                        {Double.Parse(liste(6))},
                                                                        {liste(7)},
                                                                        {Integer.Parse(liste(8))},
                                                                        {Integer.Parse(liste(9))},
                                                                        '{liste(10)}',
                                                                        '{liste(11)}')"

                connection.Open()
                Dim reader = command.ExecuteReader()
                connection.Close()
                Return True
        Catch ex As Exception
            ErrLog.getInstance.writeErr(ex.Message, nomClass, "ajoutInventaire")
            MessageBox.Show("Une erreur c'est produit!")
            Return False
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
