<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCGestionVehicule
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.cbModel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbPrix = New System.Windows.Forms.TextBox()
        Me.dgvOptionMo = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvCoulMo = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btCreer = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvCoulAjout = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvOptionAjout = New System.Windows.Forms.DataGridView()
        Me.BtEnregistrer = New System.Windows.Forms.Button()
        Me.BtAnnuler = New System.Windows.Forms.Button()
        CType(Me.dgvOptionMo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCoulMo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCoulAjout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOptionAjout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbModel
        '
        Me.cbModel.FormattingEnabled = True
        Me.cbModel.Location = New System.Drawing.Point(52, 64)
        Me.cbModel.Name = "cbModel"
        Me.cbModel.Size = New System.Drawing.Size(315, 23)
        Me.cbModel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Model"
        '
        'tbPrix
        '
        Me.tbPrix.Location = New System.Drawing.Point(52, 108)
        Me.tbPrix.Name = "tbPrix"
        Me.tbPrix.Size = New System.Drawing.Size(315, 23)
        Me.tbPrix.TabIndex = 3
        '
        'dgvOptionMo
        '
        Me.dgvOptionMo.AllowUserToAddRows = False
        Me.dgvOptionMo.AllowUserToDeleteRows = False
        Me.dgvOptionMo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOptionMo.Location = New System.Drawing.Point(52, 158)
        Me.dgvOptionMo.Name = "dgvOptionMo"
        Me.dgvOptionMo.RowTemplate.Height = 25
        Me.dgvOptionMo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOptionMo.Size = New System.Drawing.Size(351, 150)
        Me.dgvOptionMo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Option Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Couleur Model"
        '
        'dgvCoulMo
        '
        Me.dgvCoulMo.AllowUserToAddRows = False
        Me.dgvCoulMo.AllowUserToDeleteRows = False
        Me.dgvCoulMo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCoulMo.Location = New System.Drawing.Point(52, 329)
        Me.dgvCoulMo.Name = "dgvCoulMo"
        Me.dgvCoulMo.RowTemplate.Height = 25
        Me.dgvCoulMo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCoulMo.Size = New System.Drawing.Size(351, 150)
        Me.dgvCoulMo.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Prix de base du véhicule"
        '
        'btCreer
        '
        Me.btCreer.Location = New System.Drawing.Point(52, 20)
        Me.btCreer.Name = "btCreer"
        Me.btCreer.Size = New System.Drawing.Size(134, 23)
        Me.btCreer.TabIndex = 12
        Me.btCreer.Text = "Créer Nouveau Model"
        Me.btCreer.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(415, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Couleur non associée"
        '
        'dgvCoulAjout
        '
        Me.dgvCoulAjout.AllowUserToAddRows = False
        Me.dgvCoulAjout.AllowUserToDeleteRows = False
        Me.dgvCoulAjout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCoulAjout.Location = New System.Drawing.Point(415, 329)
        Me.dgvCoulAjout.Name = "dgvCoulAjout"
        Me.dgvCoulAjout.RowTemplate.Height = 25
        Me.dgvCoulAjout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCoulAjout.Size = New System.Drawing.Size(351, 150)
        Me.dgvCoulAjout.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(415, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Option non assosiée"
        '
        'dgvOptionAjout
        '
        Me.dgvOptionAjout.AllowUserToAddRows = False
        Me.dgvOptionAjout.AllowUserToDeleteRows = False
        Me.dgvOptionAjout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOptionAjout.Location = New System.Drawing.Point(415, 158)
        Me.dgvOptionAjout.Name = "dgvOptionAjout"
        Me.dgvOptionAjout.RowTemplate.Height = 25
        Me.dgvOptionAjout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOptionAjout.Size = New System.Drawing.Size(351, 150)
        Me.dgvOptionAjout.TabIndex = 13
        '
        'BtEnregistrer
        '
        Me.BtEnregistrer.Enabled = False
        Me.BtEnregistrer.Location = New System.Drawing.Point(52, 485)
        Me.BtEnregistrer.Name = "BtEnregistrer"
        Me.BtEnregistrer.Size = New System.Drawing.Size(148, 23)
        Me.BtEnregistrer.TabIndex = 17
        Me.BtEnregistrer.Text = "Enregistrer Changement"
        Me.BtEnregistrer.UseVisualStyleBackColor = True
        '
        'BtAnnuler
        '
        Me.BtAnnuler.Enabled = False
        Me.BtAnnuler.Location = New System.Drawing.Point(226, 485)
        Me.BtAnnuler.Name = "BtAnnuler"
        Me.BtAnnuler.Size = New System.Drawing.Size(141, 23)
        Me.BtAnnuler.TabIndex = 18
        Me.BtAnnuler.Text = "Annuler Changement"
        Me.BtAnnuler.UseVisualStyleBackColor = True
        '
        'UCGestionVehicule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtAnnuler)
        Me.Controls.Add(Me.BtEnregistrer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvCoulAjout)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvOptionAjout)
        Me.Controls.Add(Me.btCreer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvCoulMo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvOptionMo)
        Me.Controls.Add(Me.tbPrix)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbModel)
        Me.Name = "UCGestionVehicule"
        Me.Size = New System.Drawing.Size(808, 649)
        CType(Me.dgvOptionMo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCoulMo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCoulAjout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOptionAjout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbModel As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbPrix As TextBox
    Friend WithEvents dgvOptionMo As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvCoulMo As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents btCreer As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvCoulAjout As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvOptionAjout As DataGridView
    Friend WithEvents BtEnregistrer As Button
    Friend WithEvents BtAnnuler As Button
End Class
