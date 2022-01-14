Imports System.Drawing.Printing
Public Class TestPrint
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

        DGVModel.Rows.Add("")
        DGVCoulVe.Rows.Add("")
        DGVCoul.Rows.Add("Toile")
        DGVCoul.Rows.Add("ARMOIRE BAS")
        DGVCoul.Rows.Add("ARMOIRE HAUT")
        DGVCoul.Rows.Add("COMPTOIR")
        DGVCoul.Rows.Add("PORTES ARMOIRES")
        DGVCoul.Rows.Add("BANQUETTE")
        DGVCoul.Rows.Add("DECALQUE")
        DGVCoul.Rows.Add("MICRO ONDE")


        'Juste la pour tester
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
        DGVTotal.Rows.Add("799436514RT0001", "TPS")
        DGVTotal.Rows.Add("1224765785TQ0001", "TVQ")
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

        'Me.Height = LabFin2.Location.Y + 100
        Me.Height = 2500


        '-----------------------------
        Dim preview As New PrintPreviewDialog
        Dim pd As New PrintDocument
        pd.DefaultPageSettings.Landscape = False
        AddHandler pd.PrintPage, AddressOf OnPrintPage
        preview.Document = pd
        preview.ShowDialog()
        '------------------------
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

    Private Sub BTPrint_Click(sender As Object, e As EventArgs) Handles BTPrint.Click
        Dim printDialog1 As PrintDialog = New PrintDialog

        printDialog1.Document = PrintDocument1
        If printDialog1.ShowDialog = DialogResult.OK Then
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub OnPrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Using bmp As Bitmap = New Bitmap(PictureBox1.Width, PictureBox1.Height)
            'draw the form on the memory bitmap
            PictureBox1.DrawToBitmap(bmp, New Rectangle(0, 0, PictureBox1.Width, PictureBox1.Height))
            e.Graphics.DrawImage(bmp, PictureBox1.Location.X, PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        End Using

        PutBmp(DGVModel, e)
        PutBmp(DGVCoulVe, e)
        PutBmp(DGVCoul, e)
        PutBmp(DGVOption, e)
        PutBmp(DGVTotal, e)

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
    End Sub

    Private Sub PutBmp(ob As Label, ByVal e As PrintPageEventArgs)
        Using bmp As Bitmap = New Bitmap(ob.Width, ob.Height)
            'draw the form on the memory bitmap
            ob.DrawToBitmap(bmp, New Rectangle(0, 0, ob.Width, ob.Height))
            e.Graphics.DrawImage(bmp, ob.Location.X, ob.Location.Y, ob.Width, ob.Height)
        End Using
    End Sub

    Private Sub PutBmp(ob As DataGridView, ByVal e As PrintPageEventArgs)
        Using bmp As Bitmap = New Bitmap(ob.Width, ob.Height)
            'draw the form on the memory bitmap
            ob.DrawToBitmap(bmp, New Rectangle(0, 0, ob.Width, ob.Height))
            e.Graphics.DrawImage(bmp, ob.Location.X, ob.Location.Y, ob.Width, ob.Height)
        End Using
    End Sub
End Class