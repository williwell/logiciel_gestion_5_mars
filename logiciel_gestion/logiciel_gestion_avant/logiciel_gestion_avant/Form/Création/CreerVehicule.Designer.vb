<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreerVehicule
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
        Me.BTCouleur = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DGVOptionDis = New System.Windows.Forms.DataGridView()
        Me.DGVOptionCh = New System.Windows.Forms.DataGridView()
        Me.CBCoulTissus = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBCoulToile = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBCoulVe = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBModel = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBNIV = New System.Windows.Forms.TextBox()
        Me.BTSave = New System.Windows.Forms.Button()
        Me.BTAnnuler = New System.Windows.Forms.Button()
        Me.TBChassi = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.NUDAnnee = New System.Windows.Forms.NumericUpDown()
        CType(Me.DGVOptionDis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVOptionCh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDAnnee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTCouleur
        '
        Me.BTCouleur.Location = New System.Drawing.Point(289, 246)
        Me.BTCouleur.Name = "BTCouleur"
        Me.BTCouleur.Size = New System.Drawing.Size(138, 23)
        Me.BTCouleur.TabIndex = 101
        Me.BTCouleur.Text = "Ajouter des couleurs"
        Me.BTCouleur.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "Option Choisis"
        '
        'DGVOptionDis
        '
        Me.DGVOptionDis.AllowUserToAddRows = False
        Me.DGVOptionDis.AllowUserToDeleteRows = False
        Me.DGVOptionDis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOptionDis.Location = New System.Drawing.Point(662, 316)
        Me.DGVOptionDis.Name = "DGVOptionDis"
        Me.DGVOptionDis.ReadOnly = True
        Me.DGVOptionDis.RowTemplate.Height = 25
        Me.DGVOptionDis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVOptionDis.Size = New System.Drawing.Size(636, 226)
        Me.DGVOptionDis.TabIndex = 97
        '
        'DGVOptionCh
        '
        Me.DGVOptionCh.AllowUserToAddRows = False
        Me.DGVOptionCh.AllowUserToDeleteRows = False
        Me.DGVOptionCh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOptionCh.Location = New System.Drawing.Point(20, 316)
        Me.DGVOptionCh.Name = "DGVOptionCh"
        Me.DGVOptionCh.ReadOnly = True
        Me.DGVOptionCh.RowTemplate.Height = 25
        Me.DGVOptionCh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVOptionCh.Size = New System.Drawing.Size(636, 226)
        Me.DGVOptionCh.TabIndex = 96
        '
        'CBCoulTissus
        '
        Me.CBCoulTissus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCoulTissus.FormattingEnabled = True
        Me.CBCoulTissus.Location = New System.Drawing.Point(20, 247)
        Me.CBCoulTissus.Name = "CBCoulTissus"
        Me.CBCoulTissus.Size = New System.Drawing.Size(263, 23)
        Me.CBCoulTissus.TabIndex = 92
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Couleur Tissus"
        '
        'CBCoulToile
        '
        Me.CBCoulToile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCoulToile.FormattingEnabled = True
        Me.CBCoulToile.Location = New System.Drawing.Point(20, 203)
        Me.CBCoulToile.Name = "CBCoulToile"
        Me.CBCoulToile.Size = New System.Drawing.Size(263, 23)
        Me.CBCoulToile.TabIndex = 90
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "Couleur Toile"
        '
        'CBCoulVe
        '
        Me.CBCoulVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCoulVe.FormattingEnabled = True
        Me.CBCoulVe.Location = New System.Drawing.Point(20, 159)
        Me.CBCoulVe.Name = "CBCoulVe"
        Me.CBCoulVe.Size = New System.Drawing.Size(263, 23)
        Me.CBCoulVe.TabIndex = 88
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 15)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Couleur Véhicule"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Model"
        '
        'CBModel
        '
        Me.CBModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBModel.FormattingEnabled = True
        Me.CBModel.Location = New System.Drawing.Point(20, 28)
        Me.CBModel.Name = "CBModel"
        Me.CBModel.Size = New System.Drawing.Size(263, 23)
        Me.CBModel.TabIndex = 83
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 15)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "NIV"
        '
        'TBNIV
        '
        Me.TBNIV.Location = New System.Drawing.Point(20, 72)
        Me.TBNIV.Name = "TBNIV"
        Me.TBNIV.Size = New System.Drawing.Size(263, 23)
        Me.TBNIV.TabIndex = 103
        '
        'BTSave
        '
        Me.BTSave.Location = New System.Drawing.Point(20, 548)
        Me.BTSave.Name = "BTSave"
        Me.BTSave.Size = New System.Drawing.Size(122, 23)
        Me.BTSave.TabIndex = 104
        Me.BTSave.Text = "Enregistré"
        Me.BTSave.UseVisualStyleBackColor = True
        '
        'BTAnnuler
        '
        Me.BTAnnuler.Location = New System.Drawing.Point(161, 548)
        Me.BTAnnuler.Name = "BTAnnuler"
        Me.BTAnnuler.Size = New System.Drawing.Size(122, 23)
        Me.BTAnnuler.TabIndex = 105
        Me.BTAnnuler.Text = "Annuler"
        Me.BTAnnuler.UseVisualStyleBackColor = True
        '
        'TBChassi
        '
        Me.TBChassi.Location = New System.Drawing.Point(20, 116)
        Me.TBChassi.Name = "TBChassi"
        Me.TBChassi.Size = New System.Drawing.Size(263, 23)
        Me.TBChassi.TabIndex = 107
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 15)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "Chassis"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(289, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 15)
        Me.Label9.TabIndex = 109
        Me.Label9.Text = "Année"
        '
        'NUDAnnee
        '
        Me.NUDAnnee.Location = New System.Drawing.Point(289, 117)
        Me.NUDAnnee.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.NUDAnnee.Name = "NUDAnnee"
        Me.NUDAnnee.Size = New System.Drawing.Size(120, 23)
        Me.NUDAnnee.TabIndex = 110
        '
        'CreerVehicule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1315, 614)
        Me.Controls.Add(Me.NUDAnnee)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TBChassi)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BTAnnuler)
        Me.Controls.Add(Me.BTSave)
        Me.Controls.Add(Me.TBNIV)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BTCouleur)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DGVOptionDis)
        Me.Controls.Add(Me.DGVOptionCh)
        Me.Controls.Add(Me.CBCoulTissus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBCoulToile)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBCoulVe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBModel)
        Me.Name = "CreerVehicule"
        Me.Text = "CreerVehicule"
        CType(Me.DGVOptionDis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVOptionCh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDAnnee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTCouleur As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents DGVOptionDis As DataGridView
    Friend WithEvents DGVOptionCh As DataGridView
    Friend WithEvents CBCoulTissus As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CBCoulToile As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CBCoulVe As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CBModel As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBNIV As TextBox
    Friend WithEvents BTSave As Button
    Friend WithEvents BTAnnuler As Button
    Friend WithEvents TBChassi As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents NUDAnnee As NumericUpDown
End Class
