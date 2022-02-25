Imports Microsoft.Office.Interop.Excel
Public Class TestExcel
    Dim appXl As Application
    Dim wbXl As Workbook
    Dim shXl As Worksheet
    ReadOnly rowFac As DataRow

    Sub New(rowFacture As DataRow)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        rowFac = rowFacture
    End Sub

    Private Sub TestExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim row As DataRow = Nothing
        Dim rowVe As DataRow = Nothing

        appXl = CreateObject("Excel.Application")
        appXl.Visible = False

        wbXl = appXl.Workbooks.Open("C:\logiciel_gestion_5_mars_fichier\IMAGINE.xlsx")
        shXl = wbXl.ActiveSheet

        For r As Integer = 0 To MainForm.TableClient.Rows.Count - 1
            If MainForm.TableClient.Rows(r).Item("id") = rowFac.Item("idclient") Then
                row = MainForm.TableClient.Rows(r)
            End If
        Next

        shXl.Range("A8").Cells.Value = shXl.Range("A8").Cells.Value & " " & row.Item("nom1") & " " & row.Item("prenom1")
        shXl.Range("A9").Cells.Value = row.Item("addresse") & "   app: " & row.Item("app")
        shXl.Range("A10").Cells.Value = row.Item("codepostal")
        shXl.Range("A11").Cells.Value = row.Item("telephone1")
        shXl.Range("A11").HorizontalAlignment = Constants.xlLeft
        shXl.Range("A12").Cells.Value = row.Item("email")

        shXl.Range("C4").Cells.Value = shXl.Range("C4").Cells.Value & " " & Date.Now.ToString("yyyy-MM-dd")
        shXl.Range("D5").Cells.Value = shXl.Range("D5").Cells.Value & " " & rowFac.Item("id")




        For i As Integer = 0 To MainForm.tableVe.Rows.Count - 1
            If MainForm.tableVe.Rows(i).Item("id") = rowFac.Item("idvehicule") Then
                rowVe = MainForm.tableVe.Rows(i)
                Exit For
            End If
        Next

        For r As Integer = 0 To MainForm.tableModel.Rows.Count - 1
            If MainForm.tableModel.Rows(r).Item("id") = rowVe.Item("idmodel") Then
                row = MainForm.tableModel.Rows(r)
                Exit For
            End If
        Next

        Dim info(3) As String
        info(0) = row(1)
        info(1) = " "
        info(2) = row(0)
        info(3) = row(2)

        shXl.Range("A16", "D16").Value = info


        For r As Integer = 0 To MainForm.tableCoulVe.Rows.Count - 1
            If MainForm.tableCoulVe.Rows(r).Item("id") = rowVe.Item("idcouleur") Then
                row = MainForm.tableCoulVe.Rows(r)
                Exit For
            End If
        Next

        info(0) = row(1)
        info(1) = " "
        info(2) = row(2)
        info(3) = row(3)

        shXl.Range("A18", "D18").Value = info

        For r As Integer = 0 To MainForm.tableCoulToi.Rows.Count - 1
            If MainForm.tableCoulToi.Rows(r).Item("id") = rowVe.Item("idcoultoile") Then
                shXl.Range("c20").Value = MainForm.tableCoulToi.Rows(r).Item("code")
                Exit For
            End If
        Next

        For r As Integer = 0 To MainForm.tableCoulTis.Rows.Count - 1
            If MainForm.tableCoulTis.Rows(r).Item("id") = rowVe.Item("idcoultissus") Then
                shXl.Range("c25").Value = MainForm.tableCoulTis.Rows(r).Item("code")
                Exit For
            End If
        Next

        Dim nbr As Integer
        For r As Integer = 15 To 150
            If shXl.Range("A" & r).Value = "OPTION" Then
                nbr = r + 1
                Exit For
            End If
        Next

        For r As Integer = 0 To MainForm.tableOpVe.Rows.Count - 1
            If MainForm.tableOpVe.Rows(r).Item("idvehicule") = rowFac.Item("idvehicule") Then
                For r2 As Integer = 0 To MainForm.tableOp.Rows.Count - 1
                    If MainForm.tableOp.Rows(r2).Item("id") = MainForm.tableOpVe.Rows(r).Item("idoption") Then
                        shXl.Range("A" & nbr + 1).EntireRow.Insert()
                        row = MainForm.tableOp.Rows(r2)
                        info(0) = row(1)
                        info(1) = " "
                        info(2) = row(0)
                        info(3) = row(2)

                        shXl.Range("A" & nbr, "D" & nbr).Value = info
                        shXl.Range("C" & nbr, "D" & nbr).Cells.Borders.LineStyle = XlLineStyle.xlContinuous
                        nbr += 1
                    End If
                Next
            End If
        Next
        shXl.Range("C" & nbr, "D" & nbr).Cells.Borders.LineStyle = XlLineStyle.xlContinuous

        wbXl.SaveAs2("C:\logiciel_gestion_5_mars_fichier\Facture\Véhicule\" & Date.Now.ToString("yyyy-MM-dd") & "_no" & rowFac.Item("id") & ".xlsx")

        shXl = Nothing
        wbXl = Nothing
        appXl.Quit()
        appXl = Nothing
        Me.Close()
    End Sub
End Class