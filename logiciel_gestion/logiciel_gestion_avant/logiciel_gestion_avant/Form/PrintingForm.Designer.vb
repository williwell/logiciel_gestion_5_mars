<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrintingForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrintingForm))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DGVModel = New System.Windows.Forms.DataGridView()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Montant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGVCoulVe = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabDate = New System.Windows.Forms.Label()
        Me.DGVCoul = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGVOption = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGVTotal = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabFin = New System.Windows.Forms.Label()
        Me.LabFin2 = New System.Windows.Forms.Label()
        Me.LabDateNow = New System.Windows.Forms.Label()
        Me.LabClient = New System.Windows.Forms.Label()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.LabFac = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.LabSig1 = New System.Windows.Forms.Label()
        Me.LabSig2 = New System.Windows.Forms.Label()
        Me.Lab5M = New System.Windows.Forms.Label()
        Me.LabLine1 = New System.Windows.Forms.Label()
        Me.LabLine2 = New System.Windows.Forms.Label()
        Me.LabLine3 = New System.Windows.Forms.Label()
        Me.LabAddCl = New System.Windows.Forms.Label()
        Me.LabPosCl = New System.Windows.Forms.Label()
        Me.LabTelCl = New System.Windows.Forms.Label()
        Me.LabEmailCl = New System.Windows.Forms.Label()
        Me.LabDateLiv = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.DGVModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVCoulVe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVCoul, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(617, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 12)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Pour:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(617, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 12)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Commande"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(77, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 12)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Client: "
        '
        'DGVModel
        '
        Me.DGVModel.AllowUserToAddRows = False
        Me.DGVModel.AllowUserToDeleteRows = False
        Me.DGVModel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVModel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Description, Me.Code, Me.Montant})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVModel.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGVModel.EnableHeadersVisualStyles = False
        Me.DGVModel.Location = New System.Drawing.Point(77, 231)
        Me.DGVModel.Name = "DGVModel"
        Me.DGVModel.ReadOnly = True
        Me.DGVModel.RowHeadersVisible = False
        Me.DGVModel.RowTemplate.Height = 25
        Me.DGVModel.Size = New System.Drawing.Size(712, 41)
        Me.DGVModel.TabIndex = 9
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Code
        '
        Me.Code.HeaderText = "CODE"
        Me.Code.Name = "Code"
        Me.Code.ReadOnly = True
        Me.Code.Width = 140
        '
        'Montant
        '
        Me.Montant.HeaderText = "MONTANT"
        Me.Montant.Name = "Montant"
        Me.Montant.ReadOnly = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(617, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "N° Commande: "
        '
        'DGVCoulVe
        '
        Me.DGVCoulVe.AllowUserToAddRows = False
        Me.DGVCoulVe.AllowUserToDeleteRows = False
        Me.DGVCoulVe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVCoulVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCoulVe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVCoulVe.DefaultCellStyle = DataGridViewCellStyle7
        Me.DGVCoulVe.EnableHeadersVisualStyles = False
        Me.DGVCoulVe.Location = New System.Drawing.Point(77, 271)
        Me.DGVCoulVe.Name = "DGVCoulVe"
        Me.DGVCoulVe.ReadOnly = True
        Me.DGVCoulVe.RowHeadersVisible = False
        Me.DGVCoulVe.RowTemplate.Height = 25
        Me.DGVCoulVe.Size = New System.Drawing.Size(712, 41)
        Me.DGVCoulVe.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "COULEUR DU VEHICULE"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = ""
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 140
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = ""
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'LabDate
        '
        Me.LabDate.AutoSize = True
        Me.LabDate.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabDate.Location = New System.Drawing.Point(617, 118)
        Me.LabDate.Name = "LabDate"
        Me.LabDate.Size = New System.Drawing.Size(32, 12)
        Me.LabDate.TabIndex = 4
        Me.LabDate.Text = "DATE: "
        '
        'DGVCoul
        '
        Me.DGVCoul.AllowUserToAddRows = False
        Me.DGVCoul.AllowUserToDeleteRows = False
        Me.DGVCoul.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVCoul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCoul.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.Nom, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVCoul.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGVCoul.EnableHeadersVisualStyles = False
        Me.DGVCoul.Location = New System.Drawing.Point(77, 311)
        Me.DGVCoul.Name = "DGVCoul"
        Me.DGVCoul.ReadOnly = True
        Me.DGVCoul.RowHeadersVisible = False
        Me.DGVCoul.RowTemplate.Height = 25
        Me.DGVCoul.Size = New System.Drawing.Size(712, 182)
        Me.DGVCoul.TabIndex = 11
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "COULEUR"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Nom
        '
        Me.Nom.HeaderText = "Nom"
        Me.Nom.Name = "Nom"
        Me.Nom.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = ""
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 140
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = ""
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(77, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Téléphone (514) 264-4040    1-844-562-7778"
        '
        'DGVOption
        '
        Me.DGVOption.AllowUserToAddRows = False
        Me.DGVOption.AllowUserToDeleteRows = False
        Me.DGVOption.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVOption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOption.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVOption.DefaultCellStyle = DataGridViewCellStyle9
        Me.DGVOption.EnableHeadersVisualStyles = False
        Me.DGVOption.Location = New System.Drawing.Point(77, 492)
        Me.DGVOption.Name = "DGVOption"
        Me.DGVOption.ReadOnly = True
        Me.DGVOption.RowHeadersVisible = False
        Me.DGVOption.RowTemplate.Height = 25
        Me.DGVOption.Size = New System.Drawing.Size(712, 49)
        Me.DGVOption.TabIndex = 12
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "OPTION"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = ""
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 140
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = ""
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(77, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Joliette, Qc J6E3N9"
        '
        'DGVTotal
        '
        Me.DGVTotal.AllowUserToAddRows = False
        Me.DGVTotal.AllowUserToDeleteRows = False
        Me.DGVTotal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTotal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVTotal.DefaultCellStyle = DataGridViewCellStyle10
        Me.DGVTotal.EnableHeadersVisualStyles = False
        Me.DGVTotal.Location = New System.Drawing.Point(77, 584)
        Me.DGVTotal.Name = "DGVTotal"
        Me.DGVTotal.ReadOnly = True
        Me.DGVTotal.RowHeadersVisible = False
        Me.DGVTotal.RowTemplate.Height = 25
        Me.DGVTotal.Size = New System.Drawing.Size(712, 172)
        Me.DGVTotal.TabIndex = 13
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = " TOTAL"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = " "
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 140
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = ""
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(77, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1265 Rue de Lanaudière"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.logiciel_gestion_avant.My.Resources.Resources._5mars_removebg_preview_ccexpress
        Me.PictureBox1.Location = New System.Drawing.Point(77, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 93)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LabFin
        '
        Me.LabFin.AutoSize = True
        Me.LabFin.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabFin.Location = New System.Drawing.Point(343, 989)
        Me.LabFin.Name = "LabFin"
        Me.LabFin.Size = New System.Drawing.Size(141, 12)
        Me.LabFin.TabIndex = 16
        Me.LabFin.Text = "MERCI DE VOTRE CONFIANCE!"
        '
        'LabFin2
        '
        Me.LabFin2.AutoSize = True
        Me.LabFin2.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabFin2.Location = New System.Drawing.Point(354, 1004)
        Me.LabFin2.Name = "LabFin2"
        Me.LabFin2.Size = New System.Drawing.Size(116, 12)
        Me.LabFin2.TabIndex = 17
        Me.LabFin2.Text = "GARANTIE 5 MARS 3 ANS"
        '
        'LabDateNow
        '
        Me.LabDateNow.AutoSize = True
        Me.LabDateNow.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabDateNow.Location = New System.Drawing.Point(677, 118)
        Me.LabDateNow.Name = "LabDateNow"
        Me.LabDateNow.Size = New System.Drawing.Size(94, 12)
        Me.LabDateNow.TabIndex = 18
        Me.LabDateNow.Text = "DATE AUJOURD'HUI"
        '
        'LabClient
        '
        Me.LabClient.AutoSize = True
        Me.LabClient.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabClient.Location = New System.Drawing.Point(138, 167)
        Me.LabClient.Name = "LabClient"
        Me.LabClient.Size = New System.Drawing.Size(68, 12)
        Me.LabClient.TabIndex = 19
        Me.LabClient.Text = "Client a mettre"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'LabFac
        '
        Me.LabFac.AutoSize = True
        Me.LabFac.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabFac.Location = New System.Drawing.Point(699, 130)
        Me.LabFac.Name = "LabFac"
        Me.LabFac.Size = New System.Drawing.Size(90, 12)
        Me.LabFac.TabIndex = 20
        Me.LabFac.Text = "No facture à mettre"
        '
        'PrintDocument1
        '
        '
        'LabSig1
        '
        Me.LabSig1.AutoSize = True
        Me.LabSig1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabSig1.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabSig1.Location = New System.Drawing.Point(77, 917)
        Me.LabSig1.Name = "LabSig1"
        Me.LabSig1.Size = New System.Drawing.Size(56, 14)
        Me.LabSig1.TabIndex = 21
        Me.LabSig1.Text = "Signature 1"
        '
        'LabSig2
        '
        Me.LabSig2.AutoSize = True
        Me.LabSig2.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabSig2.Location = New System.Drawing.Point(332, 917)
        Me.LabSig2.Name = "LabSig2"
        Me.LabSig2.Size = New System.Drawing.Size(54, 12)
        Me.LabSig2.TabIndex = 22
        Me.LabSig2.Text = "Signature 2"
        '
        'Lab5M
        '
        Me.Lab5M.AutoSize = True
        Me.Lab5M.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Lab5M.Location = New System.Drawing.Point(589, 917)
        Me.Lab5M.Name = "Lab5M"
        Me.Lab5M.Size = New System.Drawing.Size(49, 12)
        Me.Lab5M.TabIndex = 23
        Me.Lab5M.Text = "5 Mars VR"
        '
        'LabLine1
        '
        Me.LabLine1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabLine1.Location = New System.Drawing.Point(77, 905)
        Me.LabLine1.Name = "LabLine1"
        Me.LabLine1.Size = New System.Drawing.Size(200, 2)
        Me.LabLine1.TabIndex = 24
        '
        'LabLine2
        '
        Me.LabLine2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabLine2.Location = New System.Drawing.Point(332, 905)
        Me.LabLine2.Name = "LabLine2"
        Me.LabLine2.Size = New System.Drawing.Size(200, 2)
        Me.LabLine2.TabIndex = 25
        '
        'LabLine3
        '
        Me.LabLine3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabLine3.Location = New System.Drawing.Point(589, 905)
        Me.LabLine3.Name = "LabLine3"
        Me.LabLine3.Size = New System.Drawing.Size(200, 2)
        Me.LabLine3.TabIndex = 26
        '
        'LabAddCl
        '
        Me.LabAddCl.AutoSize = True
        Me.LabAddCl.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabAddCl.Location = New System.Drawing.Point(138, 179)
        Me.LabAddCl.Name = "LabAddCl"
        Me.LabAddCl.Size = New System.Drawing.Size(71, 12)
        Me.LabAddCl.TabIndex = 27
        Me.LabAddCl.Text = "Addresse Client"
        '
        'LabPosCl
        '
        Me.LabPosCl.AutoSize = True
        Me.LabPosCl.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabPosCl.Location = New System.Drawing.Point(138, 192)
        Me.LabPosCl.Name = "LabPosCl"
        Me.LabPosCl.Size = New System.Drawing.Size(57, 12)
        Me.LabPosCl.TabIndex = 29
        Me.LabPosCl.Text = "Code Postal"
        '
        'LabTelCl
        '
        Me.LabTelCl.AutoSize = True
        Me.LabTelCl.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabTelCl.Location = New System.Drawing.Point(138, 204)
        Me.LabTelCl.Name = "LabTelCl"
        Me.LabTelCl.Size = New System.Drawing.Size(50, 12)
        Me.LabTelCl.TabIndex = 30
        Me.LabTelCl.Text = "Téléphone"
        '
        'LabEmailCl
        '
        Me.LabEmailCl.AutoSize = True
        Me.LabEmailCl.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabEmailCl.Location = New System.Drawing.Point(138, 216)
        Me.LabEmailCl.Name = "LabEmailCl"
        Me.LabEmailCl.Size = New System.Drawing.Size(76, 12)
        Me.LabEmailCl.TabIndex = 31
        Me.LabEmailCl.Text = "Addresse couriel"
        '
        'LabDateLiv
        '
        Me.LabDateLiv.AutoSize = True
        Me.LabDateLiv.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabDateLiv.Location = New System.Drawing.Point(631, 1015)
        Me.LabDateLiv.Name = "LabDateLiv"
        Me.LabDateLiv.Size = New System.Drawing.Size(50, 12)
        Me.LabDateLiv.TabIndex = 33
        Me.LabDateLiv.Text = "Date Livré:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(77, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 12)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Adresse:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(77, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 12)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Code Postal:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(77, 204)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 12)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Téléphone:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(77, 216)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 12)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Email:"
        '
        'PrintingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(987, 1068)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LabDateLiv)
        Me.Controls.Add(Me.LabEmailCl)
        Me.Controls.Add(Me.LabTelCl)
        Me.Controls.Add(Me.LabPosCl)
        Me.Controls.Add(Me.LabAddCl)
        Me.Controls.Add(Me.LabLine3)
        Me.Controls.Add(Me.LabLine2)
        Me.Controls.Add(Me.LabLine1)
        Me.Controls.Add(Me.Lab5M)
        Me.Controls.Add(Me.LabSig2)
        Me.Controls.Add(Me.LabSig1)
        Me.Controls.Add(Me.LabFac)
        Me.Controls.Add(Me.LabClient)
        Me.Controls.Add(Me.LabDateNow)
        Me.Controls.Add(Me.LabFin2)
        Me.Controls.Add(Me.DGVCoul)
        Me.Controls.Add(Me.LabFin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DGVTotal)
        Me.Controls.Add(Me.DGVModel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DGVOption)
        Me.Controls.Add(Me.DGVCoulVe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabDate)
        Me.Name = "PrintingForm"
        Me.Text = "TestPrint"
        CType(Me.DGVModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVCoulVe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVCoul, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DGVModel As DataGridView
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents Montant As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents DGVCoulVe As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents LabDate As Label
    Friend WithEvents DGVCoul As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents DGVOption As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents DGVTotal As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabFin As Label
    Friend WithEvents LabFin2 As Label
    Friend WithEvents LabDateNow As Label
    Friend WithEvents LabClient As Label
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents LabFac As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents LabSig1 As Label
    Friend WithEvents LabSig2 As Label
    Friend WithEvents Lab5M As Label
    Friend WithEvents LabLine1 As Label
    Friend WithEvents LabLine2 As Label
    Friend WithEvents LabLine3 As Label
    Friend WithEvents LabAddCl As Label
    Friend WithEvents LabPosCl As Label
    Friend WithEvents LabTelCl As Label
    Friend WithEvents LabEmailCl As Label
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents LabDateLiv As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
