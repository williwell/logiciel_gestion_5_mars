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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CBInv = New System.Windows.Forms.CheckBox()
        Me.CBFab = New System.Windows.Forms.CheckBox()
        CType(Me.DGVVehicule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVVehicule
        '
        Me.DGVVehicule.AllowUserToAddRows = False
        Me.DGVVehicule.AllowUserToDeleteRows = False
        Me.DGVVehicule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVehicule.Location = New System.Drawing.Point(42, 170)
        Me.DGVVehicule.Name = "DGVVehicule"
        Me.DGVVehicule.ReadOnly = True
        Me.DGVVehicule.RowTemplate.Height = 25
        Me.DGVVehicule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVVehicule.Size = New System.Drawing.Size(707, 399)
        Me.DGVVehicule.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CBInv)
        Me.Panel1.Controls.Add(Me.CBFab)
        Me.Panel1.Location = New System.Drawing.Point(42, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(707, 34)
        Me.Panel1.TabIndex = 1
        '
        'CBInv
        '
        Me.CBInv.AutoSize = True
        Me.CBInv.Location = New System.Drawing.Point(91, 12)
        Me.CBInv.Name = "CBInv"
        Me.CBInv.Size = New System.Drawing.Size(94, 19)
        Me.CBInv.TabIndex = 1
        Me.CBInv.Text = "En Inventaire"
        Me.CBInv.UseVisualStyleBackColor = True
        '
        'CBFab
        '
        Me.CBFab.AutoSize = True
        Me.CBFab.Location = New System.Drawing.Point(0, 12)
        Me.CBFab.Name = "CBFab"
        Me.CBFab.Size = New System.Drawing.Size(76, 19)
        Me.CBFab.TabIndex = 0
        Me.CBFab.Text = "Fabriquer"
        Me.CBFab.UseVisualStyleBackColor = True
        '
        'UCGestionVehicule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGVVehicule)
        Me.Name = "UCGestionVehicule"
        Me.Size = New System.Drawing.Size(808, 621)
        CType(Me.DGVVehicule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVVehicule As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CBInv As CheckBox
    Friend WithEvents CBFab As CheckBox
End Class
