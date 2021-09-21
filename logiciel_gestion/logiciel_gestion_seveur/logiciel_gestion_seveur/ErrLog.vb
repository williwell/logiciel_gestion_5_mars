﻿Public Class ErrLog
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    Shared instance As ErrLog = Nothing


    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________
    Public Sub WriteErr(texte As String, classErr As String, functionErr As String)
        Dim textFileStream As New IO.FileStream("C:\logiciel_gestion_5_mars_fichier\ErrLog\" + DateTime.Now.ToString("yyyy-MM-dd-H-m-s") + ".txt", IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite, IO.FileShare.None)
        Dim myFileWriter As New IO.StreamWriter(textFileStream)
        myFileWriter.WriteLine(DateTime.Now.ToString())
        myFileWriter.WriteLine("    Classe: " + classErr)
        myFileWriter.WriteLine("    Function: " + functionErr)
        myFileWriter.WriteLine("    Message d'erreur: " + texte)
        myFileWriter.WriteLine("Fin du rapport d'erreure")
        myFileWriter.WriteLine("")
        myFileWriter.Close()
        textFileStream.Close()
    End Sub


    '__________________________________________________________________________________________________________
    'Functions
    '__________________________________________________________________________________________________________
    Public Shared Function GetInstance() As ErrLog
        If IsNothing(instance) Then
            instance = New ErrLog
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

