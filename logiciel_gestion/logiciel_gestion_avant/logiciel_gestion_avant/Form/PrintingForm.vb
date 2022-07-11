Imports System.Drawing.Printing
Public Class PrintingForm
    Dim nbr As Integer = 0
    Dim liste(-1) As String
    ReadOnly nbrPage As Integer = 1
    ReadOnly rowFac As DataRow
    ReadOnly listeCoul As String()
    ReadOnly dateImp As Date
    ReadOnly bool As Boolean

    Sub New(row As DataRow, lst As String(), dateRecu As Date, boolEx As Boolean)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        rowFac = row
        listeCoul = lst
        dateImp = dateRecu
        bool = boolEx
    End Sub

    Private Sub TestPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVModel.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGVModel.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGreen
        DGVCoulVe.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGVCoulVe.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGreen
        DGVCoul.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGVCoul.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGVCoul.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGreen
        DGVOption.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGVOption.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGreen
        DGVTotal.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGVTotal.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGreen

        Dim rowVe As DataRow = Nothing
        Dim rowMo As DataRow = Nothing
        Dim rowCoulVe As DataRow = Nothing
        Dim rowCoulToi As DataRow = Nothing
        Dim rowcoulTis As DataRow = Nothing
        Dim total As Double = 0
        Dim nbr As Double = 0

        LabFac.Text = rowFac.Item("idCommande")

        For r As Integer = 0 To MainForm.TableClient.Rows.Count - 1
            If MainForm.TableClient.Rows(r).Item("id") = rowFac.Item("idclient") Then
                LabClient.Text = MainForm.TableClient.Rows(r).Item("nom1") & " " & MainForm.TableClient.Rows(r).Item("prenom1")
                LabAddCl.Text = MainForm.TableClient.Rows(r).Item("addresse")

                If MainForm.TableClient.Rows(r).Item("app") <> "null" Then
                    LabAddCl.Text += "  App: " & MainForm.TableClient.Rows(r).Item("app")
                End If

                LabPosCl.Text = MainForm.TableClient.Rows(r).Item("codepostal")
                LabTelCl.Text = MainForm.TableClient.Rows(r).Item("telephone1")
                LabEmailCl.Text = MainForm.TableClient.Rows(r).Item("email")
            End If
        Next

        LabDateNow.Text = dateImp.ToString("yyyy-MM-dd")

        For r As Integer = 0 To MainForm.tableVe.Rows.Count - 1
            If MainForm.tableVe.Rows(r).Item("id") = rowFac.Item("idVehicule") Then
                rowVe = MainForm.tableVe.Rows(r)
                Exit For
            End If
        Next

        For r As Integer = 0 To MainForm.tableModel.Rows.Count - 1
            If MainForm.tableModel.Rows(r).Item("id") = rowVe.Item("idmodel") Then
                rowMo = MainForm.tableModel.Rows(r)
                Exit For
            End If
        Next

        For r As Integer = 0 To MainForm.tableCoulVe.Rows.Count - 1
            If MainForm.tableCoulVe.Rows(r).Item("id") = rowVe.Item("idcouleur") Then
                rowCoulVe = MainForm.tableCoulVe.Rows(r)
                Exit For
            End If
        Next

        For r As Integer = 0 To MainForm.tableCoulToi.Rows.Count - 1
            If MainForm.tableCoulToi.Rows(r).Item("id") = rowVe.Item("idCoulToile") Then
                rowCoulToi = MainForm.tableCoulToi.Rows(r)
                Exit For
            End If
        Next

        For r As Integer = 0 To MainForm.tableCoulTis.Rows.Count - 1
            If MainForm.tableCoulTis.Rows(r).Item("id") = rowVe.Item("idCoulTissus") Then
                rowcoulTis = MainForm.tableCoulTis.Rows(r)
                Exit For
            End If
        Next

        nbr = rowFac.Item("prixModel")
        DGVModel.Rows.Add(rowMo.Item("nom"), "", nbr.ToString("c"))
        nbr = rowFac.Item("prixcouleur")
        DGVCoulVe.Rows.Add(rowCoulVe.Item("nom"), rowCoulVe.Item("code"), nbr.ToString("c"))
        DGVCoul.Rows.Add("Toile", rowCoulVe.Item("nom"), rowCoulToi.Item("code"))
        DGVCoul.Rows.Add("BANQUETTE", rowcoulTis.Item("nom"), rowcoulTis.Item("code"))

        Dim i As Integer = 0
        For r As Integer = 0 To listeCoul.Length / 3 - 1
            DGVCoul.Rows.Add(listeCoul(i), listeCoul(i + 1), listeCoul(i + 2))
            i += 3
        Next

        Dim h As Integer = SetHight(DGVCoul)
        DGVOption.Location = New Point(DGVOption.Location.X, DGVCoul.Location.Y + h + 1)

        For r As Integer = 0 To MainForm.tableOpVe.Rows.Count - 1
            If MainForm.tableOpVe.Rows(r).Item("idvehicule") = rowFac.Item("idVehicule") Then
                For r2 As Integer = 0 To MainForm.tableOp.Rows.Count - 1
                    If MainForm.tableOpVe.Rows(r).Item("idoption") = MainForm.tableOp.Rows(r2).Item("id") Then
                        nbr = MainForm.tableOp.Rows(r2).Item("cout")
                        DGVOption.Rows.Add(MainForm.tableOp.Rows(r2).Item("nom"), "", nbr.ToString("c"))
                        Exit For
                    End If
                Next
            End If
        Next

        h = SetHight(DGVOption)

        DGVTotal.Location = New Point(DGVTotal.Location.X, DGVOption.Location.Y + h + 1)

        total += DGVModel.Rows(0).Cells(2).Value
        total += DGVCoulVe.Rows(0).Cells(2).Value

        For r As Integer = 0 To DGVCoul.Rows.Count - 1
            total += DGVCoul.Rows(r).Cells(3).Value
        Next

        For r As Integer = 0 To DGVOption.Rows.Count - 1
            total += DGVOption.Rows(r).Cells(2).Value
        Next

        DGVTotal.Rows.Add("", "TOTAL", total.ToString("c"))
        nbr = rowFac.Item("echange")
        DGVTotal.Rows.Add("", "ÉCHANGE", nbr.ToString("c"))
        total -= DGVTotal.Rows(1).Cells(2).Value
        DGVTotal.Rows.Add("", "SOUS-TOTAL", total.ToString("c"))
        nbr = DGVTotal.Rows(2).Cells(2).Value * rowFac.Item("tps")
        DGVTotal.Rows.Add("813181443RT0001", "TPS", nbr.ToString("c"))
        nbr = DGVTotal.Rows(2).Cells(2).Value * rowFac.Item("tvq")
        DGVTotal.Rows.Add("1220140063TQ0001", "TVQ", nbr.ToString("c"))
        nbr = DGVTotal.Rows(2).Cells(2).Value
        total = nbr + DGVTotal.Rows(3).Cells(2).Value + DGVTotal.Rows(4).Cells(2).Value
        DGVTotal.Rows.Add("", "TOTAL", total.ToString("c"))
        DGVTotal.Rows.Add("", "ACOMPTE", rowFac.Item("acompte"))
        total = DGVTotal.Rows(5).Cells(2).Value - DGVTotal.Rows(6).Cells(2).Value
        DGVTotal.Rows.Add("", "BALANCE", total.ToString("c"))
        nbr = rowFac.Item("payerlivraison")
        DGVTotal.Rows.Add("", "PAYER A LA LIVRAISON", nbr.ToString("c"))
        nbr = rowFac.Item("balanceechange")
        DGVTotal.Rows.Add("", "BALANCE ECHANGE", nbr.ToString("c"))
        total -= rowFac.Item("PayerLivraison")
        total += CDbl(rowFac.Item("remettrecl")) + CDbl(rowFac.Item("balanceEchange"))
        DGVTotal.Rows.Add("", "FINANCEMENT", total.ToString("c"))
        nbr = rowFac.Item("remettrecl")
        DGVTotal.Rows.Add("", "A REMETTRE CLIENT", nbr.ToString("c"))

        SetHight(DGVTotal)

        LabSig1.Location = New Point(LabSig1.Location.X, DGVTotal.Location.Y + DGVTotal.Height + 60)
        LabLine1.Location = New Point(LabLine1.Location.X, LabSig1.Location.Y - 12)
        LabSig2.Location = New Point(LabSig2.Location.X, DGVTotal.Location.Y + DGVTotal.Height + 60)
        LabLine2.Location = New Point(LabLine2.Location.X, LabSig2.Location.Y - 12)
        Lab5M.Location = New Point(Lab5M.Location.X, DGVTotal.Location.Y + DGVTotal.Height + 60)
        LabLine3.Location = New Point(Lab5M.Location.X, LabSig1.Location.Y - 12)
        LabFin.Location = New Point(LabFin.Location.X, LabSig1.Location.Y + LabSig1.Height + 20)
        LabFin2.Location = New Point(LabFin2.Location.X, LabFin.Location.Y + LabFin.Height)

        DGVModel.ClearSelection()
        DGVCoulVe.ClearSelection()
        DGVCoul.ClearSelection()
        DGVOption.ClearSelection()
        DGVTotal.ClearSelection()

        If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings

            Dim PageSetup As New PageSettings
            With PageSetup
                .Margins.Left = 50
                .Margins.Right = 50
                .Margins.Top = 50
                .Margins.Bottom = 50
                .Landscape = False
            End With
            PrintDocument1.DefaultPageSettings = PageSetup
        End If

        PrintDocument1.Print()

        If bool = True Then
            Dim ex As New TestExcel(rowFac, listeCoul)
            ex.ShowDialog()
        End If

        Me.Close()
    End Sub

    Private Function SetHight(dgv As DataGridView)
        Dim h As Integer = 0
        For r As Integer = 0 To dgv.Rows.Count - 1
            h += dgv.Rows(r).Height
        Next

        h += dgv.ColumnHeadersHeight

        dgv.Height = h + 2

        Return h
    End Function

    Private Function PutBmp(ob As DataGridView, ByVal e As PrintPageEventArgs) As Boolean
        Dim bool As Boolean = True
        For i As Integer = 0 To liste.Length - 1
            If ob.Name = liste(i) Then
                bool = False
            End If
        Next

        If bool Then
            If ob.Location.Y + ob.Height > PrintDocument1.DefaultPageSettings.PaperSize.Height - 50 Then
                e.HasMorePages = True
                ob.Location = New Point(ob.Location.X, PictureBox1.Location.Y + PictureBox1.Height + 30)
                Return True
            Else
                Using bmp As New Bitmap(ob.Width, ob.Height)
                    ob.DrawToBitmap(bmp, New Rectangle(0, 0, ob.Width, ob.Height))
                    e.Graphics.DrawImage(bmp, ob.Location.X, ob.Location.Y, ob.Width, ob.Height)
                    ReDim Preserve liste(nbr)
                    liste(nbr) = ob.Name
                    nbr += 1
                End Using
                Return False
            End If
        End If
        Return False
    End Function

    Private Function PutBmpLine(ob1 As Label, ob2 As Label, ob3 As Label, ByVal e As PrintPageEventArgs) As Boolean
        Dim bool As Boolean = True
        For i As Integer = 0 To liste.Length - 1
            If ob1.Name = liste(i) Then
                bool = False
            End If
        Next

        If bool Then
            If ob1.Location.Y + ob1.Height > PrintDocument1.DefaultPageSettings.PaperSize.Height - 50 Then
                e.HasMorePages = True
                ob1.Location = New Point(ob1.Location.X, PictureBox1.Location.Y + PictureBox1.Height + 70)
                ob2.Location = New Point(ob2.Location.X, PictureBox1.Location.Y + PictureBox1.Height + 70)
                ob3.Location = New Point(ob3.Location.X, PictureBox1.Location.Y + PictureBox1.Height + 70)
                Return True
            Else
                Using bmp As New Bitmap(ob1.Width, ob1.Height)
                    ob1.DrawToBitmap(bmp, New Rectangle(0, 0, ob1.Width, ob1.Height))
                    e.Graphics.DrawLine(Pens.Black, ob1.Location.X, ob1.Location.Y, ob1.Location.X + 200, ob1.Location.Y)
                    ReDim Preserve liste(nbr)
                    liste(nbr) = ob1.Name
                    nbr += 1
                End Using
                Using bmp As New Bitmap(ob2.Width, ob2.Height)
                    ob2.DrawToBitmap(bmp, New Rectangle(0, 0, ob2.Width, ob2.Height))
                    e.Graphics.DrawLine(Pens.Black, ob2.Location.X, ob2.Location.Y, ob2.Location.X + 200, ob2.Location.Y)
                    ReDim Preserve liste(nbr)
                    liste(nbr) = ob2.Name
                    nbr += 1
                End Using
                Using bmp As New Bitmap(ob1.Width, ob1.Height)
                    ob3.DrawToBitmap(bmp, New Rectangle(0, 0, ob3.Width, ob3.Height))
                    e.Graphics.DrawLine(Pens.Black, ob3.Location.X, ob3.Location.Y, ob3.Location.X + 200, ob3.Location.Y)
                    ReDim Preserve liste(nbr)
                    liste(nbr) = ob3.Name
                    nbr += 1
                End Using
                Return False
            End If
        End If
        Return False
    End Function

    Private Function PutBmpLab(ob1 As Label, ob2 As Label, ob3 As Label, ByVal e As PrintPageEventArgs) As Boolean
        Dim bool As Boolean = True
        For i As Integer = 0 To liste.Length - 1
            If ob1.Name = liste(i) Then
                bool = False
            End If
        Next

        If bool Then
            If ob1.Location.Y + ob1.Height > PrintDocument1.DefaultPageSettings.PaperSize.Height - 50 Then
                e.HasMorePages = True
                LabLine1.Location = New Point(LabLine1.Location.X, PictureBox1.Location.Y + PictureBox1.Height + 30)
                LabLine2.Location = New Point(LabLine2.Location.X, PictureBox1.Location.Y + PictureBox1.Height + 30)
                LabLine3.Location = New Point(LabLine3.Location.X, PictureBox1.Location.Y + PictureBox1.Height + 30)
                ob1.Location = New Point(ob1.Location.X, LabLine1.Location.Y + LabLine1.Height + 15)
                ob2.Location = New Point(ob2.Location.X, LabLine2.Location.Y + LabLine2.Height + 15)
                ob3.Location = New Point(ob3.Location.X, LabLine3.Location.Y + LabLine3.Height + 15)
                Return True
            Else
                Using bmp As New Bitmap(ob1.Width, ob1.Height)
                    ob1.DrawToBitmap(bmp, New Rectangle(0, 0, ob1.Width, ob1.Height))
                    e.Graphics.DrawImage(bmp, ob1.Location.X, ob1.Location.Y, ob1.Width, ob1.Height)
                    ReDim Preserve liste(nbr)
                    liste(nbr) = ob1.Name
                    nbr += 1
                End Using
                Using bmp As New Bitmap(ob2.Width, ob2.Height)
                    ob2.DrawToBitmap(bmp, New Rectangle(0, 0, ob2.Width, ob2.Height))
                    e.Graphics.DrawImage(bmp, ob2.Location.X, ob2.Location.Y, ob2.Width, ob2.Height)
                    ReDim Preserve liste(nbr)
                    liste(nbr) = ob2.Name
                    nbr += 1
                End Using
                Using bmp As New Bitmap(ob1.Width, ob1.Height)
                    ob3.DrawToBitmap(bmp, New Rectangle(0, 0, ob3.Width, ob3.Height))
                    e.Graphics.DrawImage(bmp, ob3.Location.X, ob3.Location.Y, ob3.Width, ob3.Height)
                    ReDim Preserve liste(nbr)
                    liste(nbr) = ob3.Name
                    nbr += 1
                End Using
                Return False
            End If
        End If
        Return False
    End Function

    Private Function PutBmp(ob1 As Label, ByVal e As PrintPageEventArgs) As Boolean
        Dim bool As Boolean = True
        For i As Integer = 0 To liste.Length - 1
            If ob1.Name = liste(i) Then
                bool = False
            End If
        Next

        If bool Then
            If ob1.Location.Y + ob1.Height > PrintDocument1.DefaultPageSettings.PaperSize.Height - 50 Then
                e.HasMorePages = True
                ob1.Location = New Point(ob1.Location.X, PictureBox1.Location.Y + PictureBox1.Height + 30)
                Return True
            Else
                Using bmp As New Bitmap(ob1.Width, ob1.Height)
                    ob1.DrawToBitmap(bmp, New Rectangle(0, 0, ob1.Width, ob1.Height))
                    e.Graphics.DrawImage(bmp, ob1.Location.X, ob1.Location.Y, ob1.Width, ob1.Height)
                    ReDim Preserve liste(nbr)
                    liste(nbr) = ob1.Name
                    nbr += 1
                End Using
                Return False
            End If
        End If
        Return False
    End Function

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Using bmp As New Bitmap(PictureBox1.Width, PictureBox1.Height)
            'draw the form on the memory bitmap
            PictureBox1.DrawToBitmap(bmp, New Rectangle(0, 0, PictureBox1.Width, PictureBox1.Height))
            e.Graphics.DrawImage(bmp, PictureBox1.Location.X, PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        End Using

        PutBmp(LabClient, e)
        PutBmp(LabDate, e)
        PutBmp(LabDateNow, e)
        PutBmp(Label1, e)
        PutBmp(Label2, e)
        PutBmp(Label3, e)
        PutBmp(Label4, e)
        PutBmp(Label5, e)
        PutBmp(Label6, e)
        PutBmp(Label7, e)
        PutBmp(LabAddCl, e)
        PutBmp(LabPosCl, e)
        PutBmp(LabTelCl, e)
        PutBmp(LabEmailCl, e)
        PutBmp(LabFac, e)

        PutBmp(DGVModel, e)
        PutBmp(DGVCoulVe, e)
        PutBmp(DGVCoul, e)

        If PutBmp(DGVOption, e) Then
            DGVTotal.Location = New Point(DGVTotal.Location.X, DGVOption.Location.Y + DGVOption.Height - 1)
            LabSig1.Location = New Point(LabSig1.Location.X, DGVTotal.Location.Y + DGVTotal.Height + 60)
            LabLine1.Location = New Point(LabLine1.Location.X, LabSig1.Location.Y - 12)
            LabSig2.Location = New Point(LabSig2.Location.X, DGVTotal.Location.Y + DGVTotal.Height + 60)
            LabLine2.Location = New Point(LabLine2.Location.X, LabSig2.Location.Y - 12)
            Lab5M.Location = New Point(Lab5M.Location.X, DGVTotal.Location.Y + DGVTotal.Height + 60)
            LabLine3.Location = New Point(Lab5M.Location.X, LabSig1.Location.Y - 12)
            LabFin.Location = New Point(LabFin.Location.X, LabSig1.Location.Y + LabSig1.Height + 20)
            LabFin2.Location = New Point(LabFin2.Location.X, LabFin.Location.Y + LabFin.Height)
            Exit Sub
        End If

        If PutBmp(DGVTotal, e) Then
            LabLine1.Location = New Point(LabLine1.Location.X, LabSig1.Location.Y + 60)
            LabSig1.Location = New Point(LabSig1.Location.X, LabLine1.Location.Y + LabLine1.Height + 15)
            LabLine2.Location = New Point(LabLine2.Location.X, LabSig2.Location.Y + 60)
            LabSig2.Location = New Point(LabSig2.Location.X, LabLine2.Location.Y + LabLine2.Height + 15)
            LabLine3.Location = New Point(Lab5M.Location.X, LabSig1.Location.Y + 60)
            Lab5M.Location = New Point(Lab5M.Location.X, LabLine3.Location.Y + LabLine3.Height + 15)
            LabFin.Location = New Point(LabFin.Location.X, LabSig1.Location.Y + LabSig1.Height + 20)
            LabFin2.Location = New Point(LabFin2.Location.X, LabFin.Location.Y + LabFin.Height)
            Exit Sub
        End If

        If PutBmpLab(LabSig1, LabSig2, Lab5M, e) Then
            LabFin.Location = New Point(LabFin.Location.X, LabSig1.Location.Y + LabSig1.Height + 20)
            LabFin2.Location = New Point(LabFin2.Location.X, LabFin.Location.Y + LabFin.Height)
            Exit Sub
        Else
            PutBmpLine(LabLine1, LabLine2, LabLine3, e)
        End If

        If PutBmp(LabDateLiv, e) Then
            LabFin.Location = New Point(LabFin.Location.X, PictureBox1.Location.Y + PictureBox1.Height + 30)
            LabFin2.Location = New Point(LabFin2.Location.X, LabFin.Location.Y + LabFin.Height)
            LabDateLiv.Location = New Point(LabDate.Location.X, LabFin2.Location.Y + LabFin2.Height)
            Exit Sub
        End If

        If PutBmp(LabFin2, e) Then
            LabFin.Location = New Point(LabFin.Location.X, PictureBox1.Location.Y + PictureBox1.Height + 30)
            LabFin2.Location = New Point(LabFin2.Location.X, LabFin.Location.Y + LabFin.Height)
            Exit Sub
        End If

        PutBmp(LabFin, e)
    End Sub
End Class