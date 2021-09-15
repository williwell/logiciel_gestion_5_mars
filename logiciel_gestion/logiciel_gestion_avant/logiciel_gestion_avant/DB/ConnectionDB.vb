Public Class ConnectionDB
    Public connectionString As String = "Server='" & MainForm.getInstance.getOption1 & "';Database='" & MainForm.getInstance.getOption3 & "';Uid='" & MainForm.getInstance.getOption4 & "';Pwd='" & MainForm.getInstance.getOption5 & "';Port=" & MainForm.getInstance.getOption6 & ";SslMode=none"
    Shared instance As ConnectionDB = Nothing

    Public Shared Function getInstance() As ConnectionDB
        If IsNothing(instance) Then
            instance = New ConnectionDB()
        End If
        Return instance
    End Function
End Class
