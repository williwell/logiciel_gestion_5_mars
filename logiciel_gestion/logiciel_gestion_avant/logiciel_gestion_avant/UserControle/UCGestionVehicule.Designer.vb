<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCGestionVehicule
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.DGVVehicule = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBCoulToi = New System.Windows.Forms.ComboBox()
        Me.CBCoulVe = New System.Windows.Forms.ComboBox()
        Me.CBCoulTis = New System.Windows.Forms.ComboBox()
        Me.CBModel = New System.Windows.Forms.ComboBox()
        Me.TBSearchMat = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RBFabNon = New System.Windows.Forms.RadioButton()
        Me.RBFabOui = New System.Windows.Forms.RadioButton()
        Me.RBFabTous = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RBInvNon = New System.Windows.Forms.RadioButton()
        Me.RBInvOui = New System.Windows.Forms.RadioButton()
        Me.RBInvTous = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DGVVehicule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVVehicule
        '
        Me.DGVVehicule.AllowUserToAddRows = False
        Me.DGVVehicule.AllowUserToDeleteRows = False
        Me.DGVVehicule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVehicule.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGVVehicule.Location = New System.Drawing.Point(0, 171)
        Me.DGVVehicule.Name = "DGVVehicule"
        Me.DGVVehicule.ReadOnly = True
        Me.DGVVehicule.RowTemplate.Height = 25
        Me.DGVVehicule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVVehicule.Size = New System.Drawing.Size(1115, 480)
        Me.DGVVehicule.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(270, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Recherche Matricule"
        '
        'CBCoulToi
        '
        Me.CBCoulToi.FormattingEnabled = True
        Me.CBCoulToi.Location = New System.Drawing.Point(511, 112)
        Me.CBCoulToi.Name = "CBCoulToi"
        Me.CBCoulToi.Size = New System.Drawing.Size(238, 23)
        Me.CBCoulToi.TabIndex = 16
        '
        'CBCoulVe
        '
        Me.CBCoulVe.FormattingEnabled = True
        Me.CBCoulVe.Location = New System.Drawing.Point(511, 83)
        Me.CBCoulVe.Name = "CBCoulVe"
        Me.CBCoulVe.Size = New System.Drawing.Size(238, 23)
        Me.CBCoulVe.TabIndex = 15
        '
        'CBCoulTis
        '
        Me.CBCoulTis.FormattingEnabled = True
        Me.CBCoulTis.Location = New System.Drawing.Point(511, 141)
        Me.CBCoulTis.Name = "CBCoulTis"
        Me.CBCoulTis.Size = New System.Drawing.Size(238, 23)
        Me.CBCoulTis.TabIndex = 14
        '
        'CBModel
        '
        Me.CBModel.FormattingEnabled = True
        Me.CBModel.Location = New System.Drawing.Point(511, 54)
        Me.CBModel.Name = "CBModel"
        Me.CBModel.Size = New System.Drawing.Size(238, 23)
        Me.CBModel.TabIndex = 13
        '
        'TBSearchMat
        '
        Me.TBSearchMat.Location = New System.Drawing.Point(270, 142)
        Me.TBSearchMat.Name = "TBSearchMat"
        Me.TBSearchMat.Size = New System.Drawing.Size(238, 23)
        Me.TBSearchMat.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RBFabNon)
        Me.Panel1.Controls.Add(Me.RBFabOui)
        Me.Panel1.Controls.Add(Me.RBFabTous)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(42, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(96, 100)
        Me.Panel1.TabIndex = 18
        '
        'RBFabNon
        '
        Me.RBFabNon.AutoSize = True
        Me.RBFabNon.Location = New System.Drawing.Point(0, 66)
        Me.RBFabNon.Name = "RBFabNon"
        Me.RBFabNon.Size = New System.Drawing.Size(48, 19)
        Me.RBFabNon.TabIndex = 24
        Me.RBFabNon.Text = "Non"
        Me.RBFabNon.UseVisualStyleBackColor = True
        '
        'RBFabOui
        '
        Me.RBFabOui.AutoSize = True
        Me.RBFabOui.Location = New System.Drawing.Point(0, 41)
        Me.RBFabOui.Name = "RBFabOui"
        Me.RBFabOui.Size = New System.Drawing.Size(44, 19)
        Me.RBFabOui.TabIndex = 23
        Me.RBFabOui.Text = "Oui"
        Me.RBFabOui.UseVisualStyleBackColor = True
        '
        'RBFabTous
        '
        Me.RBFabTous.AutoSize = True
        Me.RBFabTous.Checked = True
        Me.RBFabTous.Location = New System.Drawing.Point(0, 18)
        Me.RBFabTous.Name = "RBFabTous"
        Me.RBFabTous.Size = New System.Drawing.Size(92, 19)
        Me.RBFabTous.TabIndex = 22
        Me.RBFabTous.TabStop = True
        Me.RBFabTous.Text = "Tous afficher"
        Me.RBFabTous.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Fabriquer"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RBInvNon)
        Me.Panel2.Controls.Add(Me.RBInvOui)
        Me.Panel2.Controls.Add(Me.RBInvTous)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(144, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(96, 100)
        Me.Panel2.TabIndex = 19
        '
        'RBInvNon
        '
        Me.RBInvNon.AutoSize = True
        Me.RBInvNon.Location = New System.Drawing.Point(1, 66)
        Me.RBInvNon.Name = "RBInvNon"
        Me.RBInvNon.Size = New System.Drawing.Size(48, 19)
        Me.RBInvNon.TabIndex = 27
        Me.RBInvNon.Text = "Non"
        Me.RBInvNon.UseVisualStyleBackColor = True
        '
        'RBInvOui
        '
        Me.RBInvOui.AutoSize = True
        Me.RBInvOui.Location = New System.Drawing.Point(3, 41)
        Me.RBInvOui.Name = "RBInvOui"
        Me.RBInvOui.Size = New System.Drawing.Size(44, 19)
        Me.RBInvOui.TabIndex = 26
        Me.RBInvOui.Text = "Oui"
        Me.RBInvOui.UseVisualStyleBackColor = True
        '
        'RBInvTous
        '
        Me.RBInvTous.AutoSize = True
        Me.RBInvTous.Checked = True
        Me.RBInvTous.Location = New System.Drawing.Point(3, 18)
        Me.RBInvTous.Name = "RBInvTous"
        Me.RBInvTous.Size = New System.Drawing.Size(92, 19)
        Me.RBInvTous.TabIndex = 25
        Me.RBInvTous.TabStop = True
        Me.RBInvTous.Text = "Tous afficher"
        Me.RBInvTous.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "En Inventaire"
        '
        'UCGestionVehicule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBCoulToi)
        Me.Controls.Add(Me.CBCoulVe)
        Me.Controls.Add(Me.CBCoulTis)
        Me.Controls.Add(Me.CBModel)
        Me.Controls.Add(Me.TBSearchMat)
        Me.Controls.Add(Me.DGVVehicule)
        Me.Name = "UCGestionVehicule"
        Me.Size = New System.Drawing.Size(1115, 651)
        CType(Me.DGVVehicule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVVehicule As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents CBCoulToi As ComboBox
    Friend WithEvents CBCoulVe As ComboBox
    Friend WithEvents CBCoulTis As ComboBox
    Friend WithEvents CBModel As ComboBox
    Friend WithEvents TBSearchMat As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RBFabNon As RadioButton
    Friend WithEvents RBFabOui As RadioButton
    Friend WithEvents RBFabTous As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RBInvNon As RadioButton
    Friend WithEvents RBInvOui As RadioButton
    Friend WithEvents RBInvTous As RadioButton
    Friend WithEvents Label2 As Label
End Class
