﻿
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
        myFileWriter.Close()
        textFileStream.Close()
        MessageBox.Show("Sauvegarde effectuer")
    End Sub

    Public Sub readOption()
        Dim myFileReader As New IO.StreamReader("C:\logiciel_gestion_5_mars_fichier\settings.txt")
        Dim option1 = myFileReader.ReadLine()
        Dim option2 = myFileReader.ReadLine()
        MainForm.getInstance.setOption(option1, option2)
    End Sub
End Class
