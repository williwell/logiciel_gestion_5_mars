Imports MySql.Data.MySqlClient
Public Class ModelFournisseur
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    Dim connection As New MySqlConnection(ConnectionDB.getInstance.connectionString)
    Shared instance As ModelFournisseur = Nothing
    Dim nomClass As String = "ModelFournisseur"


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
    Shared Function getinstance() As ModelFournisseur
        If IsNothing(instance) Then
            instance = New ModelFournisseur
        End If
        Return instance
    End Function

    Public Function modFour(liste() As String) As Boolean
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection
            For i As Integer = 0 To liste.Length - 1
                command.Parameters.AddWithValue("@" & i, liste(i))
            Next
            command.CommandText = $"update fournisseur set  nomFournisseur = @1,
                                                            adresse1 = @2,
                                                            adresse2 = @3,
                                                            telephone = @4,
                                                            NomContacte = @5,
                                                            leadTime = @6,
                                                            Couriel = @7,
                                                            MethodeCommande = @8,
                                                            noCompte = @9,
                                                            MethodePaiement = @10
                                                            where id = @0"

            connection.Open()
            command.ExecuteReader()
            connection.Close()
            Return True
        Catch ex As Exception
            ErrLog.getInstance.writeErr(ex.Message, nomClass, "modFournisseur")
            MessageBox.Show("Une erreur c'est produit lors de la modification du fournisseur!")
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
