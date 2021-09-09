Public Class ConnectionDB
    Public connectionString = "Server='localhost';Database='5_mars_vr';Uid='root';Pwd='';Port=3306;SslMode=none"
    Shared instance As ConnectionDB = Nothing

    Public Shared Function getInstance() As ConnectionDB
        If IsNothing(instance) Then
            instance = New ConnectionDB()
        End If
        Return instance
    End Function
End Class
