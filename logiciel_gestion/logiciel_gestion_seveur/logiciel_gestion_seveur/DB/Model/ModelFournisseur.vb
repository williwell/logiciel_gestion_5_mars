Imports System.Data
Imports MySql.Data.MySqlClient
Public Class ModelFournisseur
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    ReadOnly connection As New MySqlConnection(ConnectionDB.GetInstance.connectionString)
    Shared instance As ModelFournisseur = Nothing
    ReadOnly nomClass As String = "ModelFournisseur"


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
    Shared Function Getinstance() As ModelFournisseur
        If IsNothing(instance) Then
            instance = New ModelFournisseur
        End If
        Return instance
    End Function

    Public Function AddFour(liste() As String) As DataTable
        Dim table As New DataTable
        table.Columns.Add("bool", GetType(Boolean))
        table.Rows.Add(False)
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If

            Dim command As New MySqlCommand
            command.Connection = connection
            For i As Integer = 0 To liste.Length - 1
                command.Parameters.AddWithValue("@" & i, liste(i))
            Next
            command.CommandText = $"insert into fournisseur(NomFournisseur,Adresse1,Adresse2,Telephone,NomContacte,LeadTime,Couriel,MethodeCommande,NoCompte,MethodePaiement)
                                                values(@0,@1,@2,@3,@4,@5,@6,@7,@8,@9)"

            connection.Open()
            command.ExecuteReader()
            connection.Close()

            table(0)(0) = True
            Return table
        Catch ex As Exception
            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "addFour")
            'MessageBox.Show("Une erreur c'est produit lors de l'ajout du fournisseur!")
            Return table
        End Try
    End Function

    Public Function ModFour(liste() As String) As DataTable
        Dim table As New DataTable
        table.Columns.Add("bool", GetType(Boolean))
        table.Rows.Add(False)
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

            table(0)(0) = True
            Return table
        Catch ex As Exception

            ErrLog.GetInstance.WriteErr(ex.Message, nomClass, "modFour")
            'MessageBox.Show("Une erreur c'est produit lors de la modification du fournisseur!")
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

