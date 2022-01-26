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

        LabFin.Location = New Point(LabFin.Location.X, DGVTotal.Location.Y + DGVTotal.Height + 20)
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

        Dim ex As New TestExcel(rowFac)
        ex.ShowDialog()

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

    Private Function PutBmp(ob As Label, ByVal e As PrintPageEventArgs) As Boolean
        Dim bool As Boolean = True
        For i As Integer = 0 To liste.Length - 1
            If ob.Name = liste(i) Then
                bool = False
            End If
        Next
        If bool Then
            Dim txtHeight As Integer = PrintDocument1.DefaultPageSettings.PaperSize.Height
            Using bmp As Bitmap = New Bitmap(ob.Width, ob.Height)
                'draw the form on the memory bitmap
                ob.DrawToBitmap(bmp, New Rectangle(0, 0, ob.Width, ob.Height))
                If ob.Location.Y > txtHeight Then
                    e.HasMorePages = True
                    ob.Location = New Point(ob.Location.X, PictureBox1.Location.Y + PictureBox1.Height + 30)
                    Return True
                Else
                    e.Graphics.DrawImage(bmp, ob.Location.X, ob.Location.Y, ob.Width, ob.Height)
                    ReDim Preserve liste(nbr)
                    liste(nbr) = ob.Name
                    nbr += 1
                End If
            End Using
        End If
        Return False
    End Function

    Private Function PutBmp(ob As DataGridView, ByVal e As PrintPageEventArgs) As Boolean
        Dim bool As Boolean = True
        For i As Integer = 0 To liste.Length - 1
            If ob.Name = liste(i) Then
                bool = False
            End If
        Next
        If bool Then
            Dim txtHeight As Integer = PrintDocument1.DefaultPageSettings.PaperSize.Height
            Using bmp As Bitmap = New Bitmap(ob.Width, ob.Height)
                'draw the form on the memory bitmap
                If ob.Location.Y > txtHeight Then
                    e.HasMorePages = True
                    ob.Location = New Point(ob.Location.X, PictureBox1.Location.Y + PictureBox1.Height + 30)
                    Return True
                ElseIf ob.Location.Y < PictureBox1.Location.Y + PictureBox1.Height + 30 Then
                    ob.DrawToBitmap(bmp, New Rectangle(0, 0, ob.Width, ob.Height))
                    e.Graphics.DrawImage(bmp, ob.Location.X, PictureBox1.Location.Y + PictureBox1.Height + 30, ob.Width, ob.Height)
                Else
                    If ob.Location.Y + ob.Height > txtHeight Then
                        Dim HauteurCouper As Integer = ob.Height - (ob.Location.Y + ob.Height - txtHeight) - 45
                        ob.DrawToBitmap(bmp, New Rectangle(0, 0, ob.Width, HauteurCouper))
                        e.Graphics.DrawImage(bmp, ob.Location.X, ob.Location.Y, ob.Width, ob.Height)
                        e.HasMorePages = True

                        Dim total As Integer = 0
                        total += ob.ColumnHeadersHeight
                        For r As Integer = 0 To ob.Rows.Count - 1
                            total += ob.Rows(r).Height
                            If total >= HauteurCouper - 5 Then
                                For i As Integer = r To 0 Step -1
                                    ob.Rows.RemoveAt(i)
                                Next
                                ob.ColumnHeadersVisible = False
                                ob.Height = 0
                                For i As Integer = 0 To ob.Rows.Count - 1
                                    ob.Height += ob.Rows(i).Height
                                Next
                                ob.Height += 3
                                Exit For
                            End If
                        Next
                        ob.Location = New Point(ob.Location.X, PictureBox1.Location.Y + PictureBox1.Height + 30)
                        ob.ClearSelection()
                        Return True
                    Else
                        ob.DrawToBitmap(bmp, New Rectangle(0, 0, ob.Width, ob.Height))
                        e.Graphics.DrawImage(bmp, ob.Location.X, ob.Location.Y, ob.Width, ob.Height)
                        ReDim Preserve liste(nbr)
                        liste(nbr) = ob.Name
                        nbr += 1
                    End If
                End If
            End Using
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

        PutBmp(DGVModel, e)
        PutBmp(DGVCoulVe, e)
        PutBmp(DGVCoul, e)
        If Not PutBmp(DGVOption, e) Then
            If DGVTotal.Location.Y >= DGVOption.Location.Y Then
                DGVTotal.Location = New Point(DGVTotal.Location.X, DGVOption.Location.Y + DGVOption.Height)
            End If

            LabFin.Location = New Point(LabFin.Location.X, DGVTotal.Location.Y + DGVTotal.Height + 20)
            LabFin2.Location = New Point(LabFin2.Location.X, LabFin.Location.Y + LabFin.Height)
        End If
        If Not PutBmp(DGVTotal, e) Then
            LabFin.Location = New Point(LabFin.Location.X, DGVTotal.Location.Y + DGVTotal.Height + 20)
            LabFin2.Location = New Point(LabFin2.Location.X, LabFin.Location.Y + LabFin.Height)
        End If
        If Not PutBmp(LabFin, e) Then
            LabFin2.Location = New Point(LabFin2.Location.X, LabFin.Location.Y + LabFin.Height)
        End If
        PutBmp(LabFin2, e)
    End Sub
End Class