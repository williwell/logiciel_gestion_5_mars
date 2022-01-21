Imports Microsoft.Office.Interop.Excel
Public Class TestExcel
    Dim appXl As Application
    Dim wbXl As Workbook
    Dim shXl As Worksheet
    Dim raXL As Range
    Private Sub TestExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        appXl = CreateObject("Excel.Application")
        appXl.Visible = True

        wbXl = appXl.Workbooks.Add
        shXl = wbXl.ActiveSheet

        shXl.Cells(1, 1) = "First Name"
        shXl.Cells(1, 2) = "Last Name"
        shXl.Cells(1, 3) = "Full Name"
        shXl.Cells(1, 4) = "Specialization"

        With shXl.Range("A1", "D1")
            .Font.Bold = True
            .VerticalAlignment = XlHAlign.xlHAlignCenter
        End With

        Dim students(5, 2) As String
        students(0, 0) = "Zara"
        students(0, 1) = "Ali"
        students(1, 0) = "Nuha"
        students(1, 1) = "Ali"
        students(2, 0) = "Arilia"
        students(2, 1) = "RamKumar"
        students(3, 0) = "Rita"
        students(3, 1) = "Jones"
        students(4, 0) = "Umme"
        students(4, 1) = "Ayman"

        shXl.Range("A2", "B6").Value = students

        raXL = shXl.Range("C2", "C6")
        raXL.Formula = "=A2 & "" "" & B2"

        With shXl
            .Cells(2, 4) = "Biology"
            .Cells(3, 4) = "Mathmematics"
            .Cells(4, 4) = "Physics"
            .Cells(5, 4) = "Mathmematics"
            .Cells(6, 4) = "Arabic"
        End With

        raXL = shXl.Range("A1", "D1")
        raXL.EntireColumn.AutoFit()

        appXl.Visible = False
        appXl.UserControl = False

        wbXl.SaveAs2("C:\logiciel_gestion_5_mars_fichier\Facture\Véhicule\test.xlsx")

        raXL = Nothing
        shXl = Nothing
        wbXl = Nothing
        appXl.Quit()
        appXl = Nothing
    End Sub
End Class