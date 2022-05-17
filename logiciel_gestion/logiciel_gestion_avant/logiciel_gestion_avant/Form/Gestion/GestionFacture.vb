Public Class GestionFacture
    ReadOnly id As String

    Sub New(idGet As String)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        id = idGet
    End Sub

    Private Sub GestionFacture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.AutoScroll = True

        Dim rowFac As DataRow = MainForm.tableFacture.NewRow

        For r As Integer = 0 To MainForm.tableFacture.Rows.Count - 1
            If MainForm.tableFacture.Rows(r).Item("id") = id Then
                For c As Integer = 0 To MainForm.tableFacture.Columns.Count - 1
                    rowFac(c) = MainForm.tableFacture(r)(c)
                Next
                Exit For
            End If
        Next


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
        Dim nbr As Double

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

        LabDateNow.Text = rowFac.Item("date")

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
        DGVCoul.Rows.Add("ARMOIRE BAS")
        DGVCoul.Rows.Add("ARMOIRE HAUT")
        DGVCoul.Rows.Add("COMPTOIR")
        DGVCoul.Rows.Add("PORTES ARMOIRES")
        DGVCoul.Rows.Add("BANQUETTE", rowcoulTis.Item("nom"), rowcoulTis.Item("code"))
        DGVCoul.Rows.Add("DECALQUE")
        DGVCoul.Rows.Add("MICRO ONDE")

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


        Dim h As Integer = SetHight(DGVOption)

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
End Class