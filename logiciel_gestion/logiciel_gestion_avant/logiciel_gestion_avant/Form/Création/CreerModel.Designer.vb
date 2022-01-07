<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreerModel
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreerModel))
        Me.BtAnnuler = New System.Windows.Forms.Button()
        Me.BtEnregistrer = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvCoulAjout = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvOptionAjout = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvCoulMo = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvOptionMo = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DGVInventaireAdd = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DGVInventaireMo = New System.Windows.Forms.DataGridView()
        Me.TbName = New System.Windows.Forms.TextBox()
        Me.nudCout = New System.Windows.Forms.NumericUpDown()
        CType(Me.dgvCoulAjout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOptionAjout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCoulMo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOptionMo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVInventaireAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVInventaireMo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtAnnuler
        '
        Me.BtAnnuler.Location = New System.Drawing.Point(175, 448)
        Me.BtAnnuler.Name = "BtAnnuler"
        Me.BtAnnuler.Size = New System.Drawing.Size(141, 23)
        Me.BtAnnuler.TabIndex = 32
        Me.BtAnnuler.Text = "Annuler Création"
        Me.BtAnnuler.UseVisualStyleBackColor = True
        '
        'BtEnregistrer
        '
        Me.BtEnregistrer.Location = New System.Drawing.Point(21, 448)
        Me.BtEnregistrer.Name = "BtEnregistrer"
        Me.BtEnregistrer.Size = New System.Drawing.Size(148, 23)
        Me.BtEnregistrer.TabIndex = 31
        Me.BtEnregistrer.Text = "Créer"
        Me.BtEnregistrer.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(384, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 15)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Couleur non associée"
        '
        'dgvCoulAjout
        '
        Me.dgvCoulAjout.AllowUserToAddRows = False
        Me.dgvCoulAjout.AllowUserToDeleteRows = False
        Me.dgvCoulAjout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCoulAjout.Location = New System.Drawing.Point(384, 292)
        Me.dgvCoulAjout.Name = "dgvCoulAjout"
        Me.dgvCoulAjout.ReadOnly = True
        Me.dgvCoulAjout.RowTemplate.Height = 25
        Me.dgvCoulAjout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCoulAjout.Size = New System.Drawing.Size(351, 150)
        Me.dgvCoulAjout.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(384, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 15)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Option non assosiée"
        '
        'dgvOptionAjout
        '
        Me.dgvOptionAjout.AllowUserToAddRows = False
        Me.dgvOptionAjout.AllowUserToDeleteRows = False
        Me.dgvOptionAjout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOptionAjout.Location = New System.Drawing.Point(384, 121)
        Me.dgvOptionAjout.Name = "dgvOptionAjout"
        Me.dgvOptionAjout.ReadOnly = True
        Me.dgvOptionAjout.RowTemplate.Height = 25
        Me.dgvOptionAjout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOptionAjout.Size = New System.Drawing.Size(351, 150)
        Me.dgvOptionAjout.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 15)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Prix de base du véhicule"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Couleur Model"
        '
        'dgvCoulMo
        '
        Me.dgvCoulMo.AllowUserToAddRows = False
        Me.dgvCoulMo.AllowUserToDeleteRows = False
        Me.dgvCoulMo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCoulMo.Location = New System.Drawing.Point(21, 292)
        Me.dgvCoulMo.Name = "dgvCoulMo"
        Me.dgvCoulMo.ReadOnly = True
        Me.dgvCoulMo.RowTemplate.Height = 25
        Me.dgvCoulMo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCoulMo.Size = New System.Drawing.Size(351, 150)
        Me.dgvCoulMo.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Option Model"
        '
        'dgvOptionMo
        '
        Me.dgvOptionMo.AllowUserToAddRows = False
        Me.dgvOptionMo.AllowUserToDeleteRows = False
        Me.dgvOptionMo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOptionMo.Location = New System.Drawing.Point(21, 121)
        Me.dgvOptionMo.Name = "dgvOptionMo"
        Me.dgvOptionMo.ReadOnly = True
        Me.dgvOptionMo.RowTemplate.Height = 25
        Me.dgvOptionMo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOptionMo.Size = New System.Drawing.Size(351, 150)
        Me.dgvOptionMo.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Model"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1166, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 15)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Inventaire non associée"
        '
        'DGVInventaireAdd
        '
        Me.DGVInventaireAdd.AllowUserToAddRows = False
        Me.DGVInventaireAdd.AllowUserToDeleteRows = False
        Me.DGVInventaireAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVInventaireAdd.Location = New System.Drawing.Point(1166, 121)
        Me.DGVInventaireAdd.Name = "DGVInventaireAdd"
        Me.DGVInventaireAdd.ReadOnly = True
        Me.DGVInventaireAdd.RowTemplate.Height = 25
        Me.DGVInventaireAdd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVInventaireAdd.Size = New System.Drawing.Size(407, 321)
        Me.DGVInventaireAdd.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(753, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 15)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Inventaire Model"
        '
        'DGVInventaireMo
        '
        Me.DGVInventaireMo.AllowUserToAddRows = False
        Me.DGVInventaireMo.AllowUserToDeleteRows = False
        Me.DGVInventaireMo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVInventaireMo.Location = New System.Drawing.Point(753, 121)
        Me.DGVInventaireMo.Name = "DGVInventaireMo"
        Me.DGVInventaireMo.RowTemplate.Height = 25
        Me.DGVInventaireMo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVInventaireMo.Size = New System.Drawing.Size(407, 321)
        Me.DGVInventaireMo.TabIndex = 33
        '
        'TbName
        '
        Me.TbName.Location = New System.Drawing.Point(21, 27)
        Me.TbName.Name = "TbName"
        Me.TbName.Size = New System.Drawing.Size(315, 23)
        Me.TbName.TabIndex = 37
        '
        'nudCout
        '
        Me.nudCout.DecimalPlaces = 2
        Me.nudCout.Location = New System.Drawing.Point(21, 71)
        Me.nudCout.Maximum = New Decimal(New Integer() {500000, 0, 0, 0})
        Me.nudCout.Name = "nudCout"
        Me.nudCout.Size = New System.Drawing.Size(315, 23)
        Me.nudCout.TabIndex = 38
        '
        'CreerModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1576, 500)
        Me.Controls.Add(Me.nudCout)
        Me.Controls.Add(Me.TbName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DGVInventaireAdd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DGVInventaireMo)
        Me.Controls.Add(Me.BtAnnuler)
        Me.Controls.Add(Me.BtEnregistrer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvCoulAjout)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvOptionAjout)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvCoulMo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvOptionMo)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CreerModel"
        Me.Text = "Créer Nouveau Model"
        CType(Me.dgvCoulAjout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOptionAjout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCoulMo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOptionMo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVInventaireAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVInventaireMo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtAnnuler As Button
    Friend WithEvents BtEnregistrer As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvCoulAjout As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvOptionAjout As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvCoulMo As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvOptionMo As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DGVInventaireAdd As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents DGVInventaireMo As DataGridView
    Friend WithEvents TbName As TextBox
    Friend WithEvents nudCout As NumericUpDown
End Class
