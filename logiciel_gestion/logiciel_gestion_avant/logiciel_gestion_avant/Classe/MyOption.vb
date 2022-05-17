Public Class MyOption
    Shared instance As MyOption = Nothing

    Public Shared Function GetInstance() As MyOption
        If IsNothing(instance) Then
            instance = New MyOption
        End If
        Return instance
    End Function

    Public Sub SaveOption()
        Dim textFileStream As New IO.FileStream("C:\logiciel_gestion_5_mars_fichier\settings.txt", IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite, IO.FileShare.None)
        Dim myFileWriter As New IO.StreamWriter(textFileStream)
        myFileWriter.WriteLine(MainForm.GetInstance.GetOption1)
        myFileWriter.WriteLine(MainForm.GetInstance.GetOption2)
        myFileWriter.WriteLine(MainForm.GetInstance.GetOption3)
        myFileWriter.WriteLine(MainForm.GetInstance.GetOption4)
        myFileWriter.WriteLine(MainForm.GetInstance.GetOption5)
        myFileWriter.Close()
        textFileStream.Close()
        MessageBox.Show(MsgTextFr.Getinstance.MsgSauv)
    End Sub

    Public Sub ReadOption()
        Dim myFileReader As New IO.StreamReader("C:\logiciel_gestion_5_mars_fichier\settings.txt")
        Dim option1 = myFileReader.ReadLine()
        Dim option2 = myFileReader.ReadLine()
        Dim option3 = myFileReader.ReadLine()
        Dim option4 = myFileReader.ReadLine()
        Dim option5 = myFileReader.ReadLine()
        myFileReader.Close()
        MainForm.GetInstance.SetOption(option1, option2, Integer.Parse(option3), Double.Parse(option4), Double.Parse(option5))
    End Sub
End Class
