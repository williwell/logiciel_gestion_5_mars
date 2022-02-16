Public Class MyOption

    Shared Sub SaveOption(option1 As String, option2 As String)
        Dim textFileStream As New IO.FileStream("C:\logiciel_gestion_5_mars_fichier\Settings_Tache.txt", IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite, IO.FileShare.None)
        Dim myFileWriter As New IO.StreamWriter(textFileStream)
        myFileWriter.WriteLine(option1)
        myFileWriter.WriteLine(option2)
        myFileWriter.Close()
        textFileStream.Close()
        MessageBox.Show("Sauvegarde effectuer")
    End Sub

    Shared Sub ReadOption(ByRef option1 As String, ByRef option2 As String)
        If Not IO.Directory.Exists("C:\logiciel_gestion_5_mars_fichier") Then
            IO.Directory.CreateDirectory("C:\logiciel_gestion_5_mars_fichier")
            Dim textFileStream As New IO.FileStream("C:\logiciel_gestion_5_mars_fichier\Settings_Tache.txt", IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite, IO.FileShare.None)
            Dim myFileWriter As New IO.StreamWriter(textFileStream)
            myFileWriter.WriteLine("192.168.32.113")
            myFileWriter.WriteLine("8889")
            myFileWriter.Close()
            textFileStream.Close()
        End If
        Dim myFileReader As New IO.StreamReader("C:\logiciel_gestion_5_mars_fichier\Settings_Tache.txt")
        option1 = myFileReader.ReadLine()
        option2 = myFileReader.ReadLine()
        myFileReader.Close()
    End Sub
End Class

