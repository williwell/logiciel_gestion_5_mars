Imports System.Drawing.Printing
Public Class TestPrint
    Dim nbr As Integer = 0
    Dim liste(-1) As String
    Dim nbrPage As Integer = 1
    Dim rowFac As DataRow

    Sub New(row As DataRow)
        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        rowFac = row
    End Sub

    Private Sub TestPrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVModel.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGVModel.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGreen
        DGVCoulVe.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGVCoulVe.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGreen
        DGVCoul.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
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

        LabFac.Text = rowFac.Item("id")

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

        LabDateNow.Text = Date.Now.ToString("yyyy-MM-dd")

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

        DGVModel.Rows.Add(rowMo.Item("nom"), "", rowMo.Item("cout"))
        DGVCoulVe.Rows.Add(rowCoulVe.Item("nom"), rowCoulVe.Item("code"), rowCoulVe.Item("cout"))
        DGVCoul.Rows.Add("Toile", rowCoulToi.Item("code"))
        DGVCoul.Rows.Add("ARMOIRE BAS")
        DGVCoul.Rows.Add("ARMOIRE HAUT")
        DGVCoul.Rows.Add("COMPTOIR")
        DGVCoul.Rows.Add("PORTES ARMOIRES")
        DGVCoul.Rows.Add("BANQUETTE", rowcoulTis.Item("code"))
        DGVCoul.Rows.Add("DECALQUE")
        DGVCoul.Rows.Add("MICRO ONDE")

        For r As Integer = 0 To MainForm.tableOpVe.Rows.Count - 1
            If MainForm.tableOpVe.Rows(r).Item("idvehicule") = rowFac.Item("idVehicule") Then
                For r2 As Integer = 0 To MainForm.tableOp.Rows.Count - 1
                    If MainForm.tableOpVe.Rows(r).Item("idoption") = MainForm.tableOp.Rows(r2).Item("id") Then
                        DGVOption.Rows.Add(MainForm.tableOp.Rows(r2).Item("nom"), "", MainForm.tableOp.Rows(r2).Item("cout"))
                        Exit For
                    End If
                Next
            End If
        Next

        DGVOption.Rows.Add("Option1")
        DGVOption.Rows.Add("Option2")
        DGVOption.Rows.Add("Option3")
        DGVOption.Rows.Add("Option4")
        DGVOption.Rows.Add("Option5")
        DGVOption.Rows.Add("Option6")
        DGVOption.Rows.Add("Option7")
        DGVOption.Rows.Add("Option8")
        DGVOption.Rows.Add("Option9")
        DGVOption.Rows.Add("Option10")
        DGVOption.Rows.Add("Option11")
        DGVOption.Rows.Add("Option12")
        DGVOption.Rows.Add("Option13")

        Dim h As Integer = SetHight(DGVOption)

        DGVTotal.Location = New Point(DGVTotal.Location.X, DGVOption.Location.Y + h + 1)

        DGVTotal.Rows.Add("", "SOUS-TOTAL")
        DGVTotal.Rows.Add("813181443RT0001", "TPS")
        DGVTotal.Rows.Add("1220140063TQ0001", "TVQ")
        DGVTotal.Rows.Add("", "TOTAL")
        DGVTotal.Rows.Add("", "ACOMPTE")
        DGVTotal.Rows.Add("", "BALANCE")
        DGVTotal.Rows.Add("", "PAYER A LA LIVRAISON")
        DGVTotal.Rows.Add("", "BALANCE ECHANGE")
        DGVTotal.Rows.Add("", "FINANCEMENT")
        DGVTotal.Rows.Add("", "A REMETTRE CLIENT")

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

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

        'PrintDocument1.Print()

        'Dim ex As New TestExcel(rowFac)
        'ex.ShowDialog()

        'Me.Close()
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
                Using bmp As Bitmap = New Bitmap(ob.Width, ob.Height)
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
                Using bmp As Bitmap = New Bitmap(ob1.Width, ob1.Height)
                    ob1.DrawToBitmap(bmp, New Rectangle(0, 0, ob1.Width, ob1.Height))
                    e.Graphics.DrawLine(Pens.Black, ob1.Location.X, ob1.Location.Y, ob1.Location.X + 200, ob1.Location.Y)
                    ReDim Preserve liste(nbr)
                    liste(nbr) = ob1.Name
                    nbr += 1
                End Using
                Using bmp As Bitmap = New Bitmap(ob2.Width, ob2.Height)
                    ob2.DrawToBitmap(bmp, New Rectangle(0, 0, ob2.Width, ob2.Height))
                    e.Graphics.DrawLine(Pens.Black, ob2.Location.X, ob2.Location.Y, ob2.Location.X + 200, ob2.Location.Y)
                    ReDim Preserve liste(nbr)
                    liste(nbr) = ob2.Name
                    nbr += 1
                End Using
                Using bmp As Bitmap = New Bitmap(ob1.Width, ob1.Height)
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
                ob1.Location = New Point(ob1.Location.X, PictureBox1.Location.Y + PictureBox1.Height + 30)
                ob2.Location = New Point(ob2.Location.X, PictureBox1.Location.Y + PictureBox1.Height + 30)
                ob3.Location = New Point(ob3.Location.X, PictureBox1.Location.Y + PictureBox1.Height + 30)
                Return True
            Else
                Using bmp As Bitmap = New Bitmap(ob1.Width, ob1.Height)
                    ob1.DrawToBitmap(bmp, New Rectangle(0, 0, ob1.Width, ob1.Height))
                    e.Graphics.DrawImage(bmp, ob1.Location.X, ob1.Location.Y, ob1.Width, ob1.Height)
                    ReDim Preserve liste(nbr)
                    liste(nbr) = ob1.Name
                    nbr += 1
                End Using
                Using bmp As Bitmap = New Bitmap(ob2.Width, ob2.Height)
                    ob2.DrawToBitmap(bmp, New Rectangle(0, 0, ob2.Width, ob2.Height))
                    e.Graphics.DrawImage(bmp, ob2.Location.X, ob2.Location.Y, ob2.Width, ob2.Height)
                    ReDim Preserve liste(nbr)
                    liste(nbr) = ob2.Name
                    nbr += 1
                End Using
                Using bmp As Bitmap = New Bitmap(ob1.Width, ob1.Height)
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
                Using bmp As Bitmap = New Bitmap(ob1.Width, ob1.Height)
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
        Using bmp As Bitmap = New Bitmap(PictureBox1.Width, PictureBox1.Height)
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

        If PutBmpLine(LabLine1, LabLine2, LabLine3, e) Then
            LabSig1.Location = New Point(LabSig1.Location.X, LabLine1.Location.Y + LabLine1.Height + 15)
            LabSig2.Location = New Point(LabSig2.Location.X, LabLine2.Location.Y + LabLine2.Height + 15)
            Lab5M.Location = New Point(Lab5M.Location.X, LabLine3.Location.Y + LabLine3.Height + 15)
            LabFin.Location = New Point(LabFin.Location.X, LabSig1.Location.Y + LabSig1.Height + 20)
            LabFin2.Location = New Point(LabFin2.Location.X, LabFin.Location.Y + LabFin.Height)
            Exit Sub
        End If

        If PutBmpLab(LabSig1, LabSig2, Lab5M, e) Then
            LabFin.Location = New Point(LabFin.Location.X, LabSig1.Location.Y + LabSig1.Height + 20)
            LabFin2.Location = New Point(LabFin2.Location.X, LabFin.Location.Y + LabFin.Height)
            Exit Sub
        End If

        If PutBmp(LabFin, e) Then
            LabFin2.Location = New Point(LabFin2.Location.X, LabFin.Location.Y + LabFin.Height)
            Exit Sub
        End If

        PutBmp(LabFin2, e)
    End Sub
End Class