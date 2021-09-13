Public Class ConnectionDB
    Public connectionString = "Server='192.168.32.166';Database='5_mars_vr';Uid='Reception';Pwd='test';Port=3306;SslMode=none"
    Shared instance As ConnectionDB = Nothing

    Public Shared Function getInstance() As ConnectionDB
        If IsNothing(instance) Then
            instance = New ConnectionDB()
        End If
        Return instance
    End Function
End Class
