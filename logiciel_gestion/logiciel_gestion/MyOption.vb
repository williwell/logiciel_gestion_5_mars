
Public Class MyOption
    Shared instance As MyOption = Nothing

    Public Shared Function getInstance() As MyOption
        If IsNothing(instance) Then
            instance = New MyOption
        End If
        Return instance
    End Function

    Public Sub saveOption()
        Dim textFileStream As New IO.FileStream("C:\logiciel_gestion_5_mars_fichier\settings.txt", IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite, IO.FileShare.None)
        Dim myFileWriter As New IO.StreamWriter(textFileStream)
        myFileWriter.WriteLine(MainForm.getInstance.getOption1)
        myFileWriter.WriteLine(MainForm.getInstance.getOption2)
        myFileWriter.WriteLine(MainForm.getInstance.getOption3)
        myFileWriter.WriteLine(MainForm.getInstance.getOption4)
        myFileWriter.WriteLine(MainForm.getInstance.getOption5)
        myFileWriter.WriteLine(MainForm.getInstance.getOption6)
        myFileWriter.Close()
        textFileStream.Close()
        MessageBox.Show("Sauvegarde effectuer")
    End Sub

    Public Sub readOption()
        Dim myFileReader As New IO.StreamReader("C:\logiciel_gestion_5_mars_fichier\settings.txt")
        Dim option1 = myFileReader.ReadLine()
        Dim option2 = myFileReader.ReadLine()
        Dim option3 = myFileReader.ReadLine()
        Dim option4 = myFileReader.ReadLine()
        Dim option5 = myFileReader.ReadLine()
        Dim option6 = myFileReader.ReadLine()
        myFileReader.Close()
        MainForm.getInstance.setOption(option1, option2, option3, option4, option5, Integer.Parse(option6))
    End Sub
End Class
