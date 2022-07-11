Imports Microsoft.Office.Interop.Excel
Public Class TestExcel
    Dim appXl As Application
    Dim wbXl As Workbook
    Dim shXl As Worksheet
    ReadOnly rowFac As DataRow
    ReadOnly listeCoul As String()

    Sub New(rowFacture As DataRow, lst As String())

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        rowFac = rowFacture
        listeCoul = lst
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

        shXl.Range("C5").Cells.Value = "N° Commande"
        shXl.Range("C9").Cells.Value = "Commande"

        shXl.Range("A8").Cells.Value = shXl.Range("A8").Cells.Value & " " & row.Item("nom1") & " " & row.Item("prenom1")
        shXl.Range("A9").Cells.Value = row.Item("addresse") & "   app: " & row.Item("app")
        shXl.Range("A10").Cells.Value = row.Item("codepostal")
        shXl.Range("A11").Cells.Value = row.Item("telephone1")
        shXl.Range("A11").HorizontalAlignment = Constants.xlLeft
        shXl.Range("A12").Cells.Value = row.Item("email")

        shXl.Range("C4").Cells.Value = shXl.Range("C4").Cells.Value & " " & Date.Now.ToString("yyyy-MM-dd")
        shXl.Range("D5").Cells.Value = shXl.Range("D5").Cells.Value & " " & rowFac.Item("idCommande")




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
        info(3) = rowFac.Item("prixmodel")

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
        info(3) = rowFac.Item("prixcouleur")

        shXl.Range("A18", "D18").Value = info

        For r As Integer = 0 To MainForm.tableCoulToi.Rows.Count - 1
            If MainForm.tableCoulToi.Rows(r).Item("id") = rowVe.Item("idcoultoile") Then
                shXl.Range("a20").Value = "Toile - " & MainForm.tableCoulToi.Rows(r).Item("nom")
                shXl.Range("c20").Value = MainForm.tableCoulToi.Rows(r).Item("code")
                Exit For
            End If
        Next

        For r As Integer = 0 To MainForm.tableCoulTis.Rows.Count - 1
            If MainForm.tableCoulTis.Rows(r).Item("id") = rowVe.Item("idcoultissus") Then
                shXl.Range("a21").Value = "Banquette - " & MainForm.tableCoulTis.Rows(r).Item("nom")
                shXl.Range("c21").Value = MainForm.tableCoulTis.Rows(r).Item("code")
                Exit For
            End If
        Next

        Dim nbr As Integer = 22
        Dim count As Integer = 0
        For r As Integer = 0 To listeCoul.Length / 3 - 1
            shXl.Range("A" & nbr).EntireRow.Insert()
            info(0) = listeCoul(count) & " - " & listeCoul(count + 1)
            info(1) = " "
            info(2) = listeCoul(count + 2)
            info(3) = ""

            shXl.Range("A" & nbr, "D" & nbr).Value = info
            shXl.Range("A" & nbr, "B" & nbr).Cells.Borders.LineStyle = XlLineStyle.xlContinuous
            nbr += 1
            count += 3
        Next


        For r As Integer = 15 To 150
            If shXl.Range("A" & r).Value = "OPTION" Then
                nbr = r + 1
                Exit For
            End If
        Next

        shXl.Range("d" & nbr).Cells.Value = ""

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

        For r As Integer = 22 To 150
            If shXl.Range("c" & r).Value = "TOTAL" Then
                Dim total As Double = 0
                For r2 As Integer = 16 To r - 1
                    total += shXl.Range("d" & r2).Value
                Next
                shXl.Range("d" & r).Value = total
                shXl.Range("d" & r + 4).Value = rowFac.Item("echange")
                shXl.Range("d" & r + 5).Value = shXl.Range("d" & r).Value - shXl.Range("d" & r + 4).Value
                shXl.Range("d" & r + 6).Value = shXl.Range("d" & r + 5).Value * rowFac.Item("tps")
                shXl.Range("d" & r + 7).Value = shXl.Range("d" & r + 5).Value * rowFac.Item("tvq")
                shXl.Range("d" & r + 8).Value = shXl.Range("d" & r + 5).Value + shXl.Range("d" & r + 6).Value + shXl.Range("d" & r + 7).Value
                shXl.Range("d" & r + 9).Value = rowFac.Item("acompte")
                shXl.Range("d" & r + 10).Value = shXl.Range("d" & r + 8).Value - shXl.Range("d" & r + 9).Value
                shXl.Range("d" & r + 12).Value = rowFac.Item("payerlivraison")
                shXl.Range("d" & r + 13).Value = rowFac.Item("balanceechange")
                shXl.Range("d" & r + 15).Value = rowFac.Item("remettrecl")
                Exit For
            End If
        Next



        wbXl.SaveAs2("C:\logiciel_gestion_5_mars_fichier\Facture\Véhicule\" & Date.Now.ToString("yyyy-MM-dd") & "_no" & rowFac.Item("idCommande") & ".xlsx")

        shXl = Nothing
        wbXl = Nothing
        appXl.Quit()
        appXl = Nothing
        Me.Close()
    End Sub
End Class