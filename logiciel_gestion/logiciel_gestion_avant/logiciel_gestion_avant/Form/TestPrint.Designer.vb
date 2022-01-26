<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TestPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestPrint))
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
        Me.BTPrint = New System.Windows.Forms.Button()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.LabFac = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
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
        Me.Label6.Location = New System.Drawing.Point(631, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Pour:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(631, 215)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "CONTRAT DE VENTE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Client: "
        '
        'DGVModel
        '
        Me.DGVModel.AllowUserToAddRows = False
        Me.DGVModel.AllowUserToDeleteRows = False
        Me.DGVModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVModel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Description, Me.Code, Me.Montant})
        Me.DGVModel.EnableHeadersVisualStyles = False
        Me.DGVModel.Location = New System.Drawing.Point(77, 254)
        Me.DGVModel.Name = "DGVModel"
        Me.DGVModel.ReadOnly = True
        Me.DGVModel.RowHeadersVisible = False
        Me.DGVModel.RowTemplate.Height = 25
        Me.DGVModel.Size = New System.Drawing.Size(712, 43)
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
        Me.Label4.Location = New System.Drawing.Point(631, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "N° Facture: "
        '
        'DGVCoulVe
        '
        Me.DGVCoulVe.AllowUserToAddRows = False
        Me.DGVCoulVe.AllowUserToDeleteRows = False
        Me.DGVCoulVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCoulVe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DGVCoulVe.EnableHeadersVisualStyles = False
        Me.DGVCoulVe.Location = New System.Drawing.Point(77, 296)
        Me.DGVCoulVe.Name = "DGVCoulVe"
        Me.DGVCoulVe.ReadOnly = True
        Me.DGVCoulVe.RowHeadersVisible = False
        Me.DGVCoulVe.RowTemplate.Height = 25
        Me.DGVCoulVe.Size = New System.Drawing.Size(712, 43)
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
        Me.LabDate.Location = New System.Drawing.Point(631, 118)
        Me.LabDate.Name = "LabDate"
        Me.LabDate.Size = New System.Drawing.Size(40, 15)
        Me.LabDate.TabIndex = 4
        Me.LabDate.Text = "DATE: "
        '
        'DGVCoul
        '
        Me.DGVCoul.AllowUserToAddRows = False
        Me.DGVCoul.AllowUserToDeleteRows = False
        Me.DGVCoul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCoul.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DGVCoul.EnableHeadersVisualStyles = False
        Me.DGVCoul.Location = New System.Drawing.Point(77, 338)
        Me.DGVCoul.Name = "DGVCoul"
        Me.DGVCoul.ReadOnly = True
        Me.DGVCoul.RowHeadersVisible = False
        Me.DGVCoul.RowTemplate.Height = 25
        Me.DGVCoul.Size = New System.Drawing.Size(712, 222)
        Me.DGVCoul.TabIndex = 11
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "COULEUR"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
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
        Me.Label3.Location = New System.Drawing.Point(77, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(233, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Téléphone (514) 264-4040    1-844-562-7778"
        '
        'DGVOption
        '
        Me.DGVOption.AllowUserToAddRows = False
        Me.DGVOption.AllowUserToDeleteRows = False
        Me.DGVOption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOption.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.DGVOption.EnableHeadersVisualStyles = False
        Me.DGVOption.Location = New System.Drawing.Point(77, 559)
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
        Me.Label2.Location = New System.Drawing.Point(77, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Joliette, Qc J6E3N9"
        '
        'DGVTotal
        '
        Me.DGVTotal.AllowUserToAddRows = False
        Me.DGVTotal.AllowUserToDeleteRows = False
        Me.DGVTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTotal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.DGVTotal.EnableHeadersVisualStyles = False
        Me.DGVTotal.Location = New System.Drawing.Point(77, 648)
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
        Me.Label1.Location = New System.Drawing.Point(77, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 15)
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
        Me.LabFin.Location = New System.Drawing.Point(333, 847)
        Me.LabFin.Name = "LabFin"
        Me.LabFin.Size = New System.Drawing.Size(168, 15)
        Me.LabFin.TabIndex = 16
        Me.LabFin.Text = "MERCI DE VOTRE CONFIANCE!"
        '
        'LabFin2
        '
        Me.LabFin2.AutoSize = True
        Me.LabFin2.Location = New System.Drawing.Point(344, 862)
        Me.LabFin2.Name = "LabFin2"
        Me.LabFin2.Size = New System.Drawing.Size(141, 15)
        Me.LabFin2.TabIndex = 17
        Me.LabFin2.Text = "GARANTIE 5 MARS 3 ANS"
        '
        'LabDateNow
        '
        Me.LabDateNow.AutoSize = True
        Me.LabDateNow.Location = New System.Drawing.Point(677, 118)
        Me.LabDateNow.Name = "LabDateNow"
        Me.LabDateNow.Size = New System.Drawing.Size(112, 15)
        Me.LabDateNow.TabIndex = 18
        Me.LabDateNow.Text = "DATE AUJOURD'HUI"
        '
        'LabClient
        '
        Me.LabClient.AutoSize = True
        Me.LabClient.Location = New System.Drawing.Point(127, 200)
        Me.LabClient.Name = "LabClient"
        Me.LabClient.Size = New System.Drawing.Size(85, 15)
        Me.LabClient.TabIndex = 19
        Me.LabClient.Text = "Client a mettre"
        '
        'BTPrint
        '
        Me.BTPrint.Location = New System.Drawing.Point(677, 47)
        Me.BTPrint.Name = "BTPrint"
        Me.BTPrint.Size = New System.Drawing.Size(75, 23)
        Me.BTPrint.TabIndex = 16
        Me.BTPrint.Text = "Print"
        Me.BTPrint.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'LabFac
        '
        Me.LabFac.AutoSize = True
        Me.LabFac.Location = New System.Drawing.Point(703, 133)
        Me.LabFac.Name = "LabFac"
        Me.LabFac.Size = New System.Drawing.Size(110, 15)
        Me.LabFac.TabIndex = 20
        Me.LabFac.Text = "No facture à mettre"
        '
        'PrintDocument1
        '
        '
        'TestPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(987, 907)
        Me.Controls.Add(Me.LabFac)
        Me.Controls.Add(Me.LabClient)
        Me.Controls.Add(Me.BTPrint)
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
        Me.Name = "TestPrint"
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
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
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
    Friend WithEvents BTPrint As Button
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents LabFac As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
