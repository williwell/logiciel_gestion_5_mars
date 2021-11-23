<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCAccueil
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
        Me.DGVItemLow = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGVVehicule = New System.Windows.Forms.DataGridView()
        CType(Me.DGVItemLow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVVehicule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVItemLow
        '
        Me.DGVItemLow.AllowUserToAddRows = False
        Me.DGVItemLow.AllowUserToDeleteRows = False
        Me.DGVItemLow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVItemLow.Location = New System.Drawing.Point(74, 65)
        Me.DGVItemLow.Name = "DGVItemLow"
        Me.DGVItemLow.ReadOnly = True
        Me.DGVItemLow.RowTemplate.Height = 25
        Me.DGVItemLow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVItemLow.Size = New System.Drawing.Size(704, 220)
        Me.DGVItemLow.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inventaire en manque"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Liste Livraison Véhicule"
        '
        'DGVVehicule
        '
        Me.DGVVehicule.AllowUserToAddRows = False
        Me.DGVVehicule.AllowUserToDeleteRows = False
        Me.DGVVehicule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVehicule.Location = New System.Drawing.Point(74, 325)
        Me.DGVVehicule.Name = "DGVVehicule"
        Me.DGVVehicule.ReadOnly = True
        Me.DGVVehicule.RowTemplate.Height = 25
        Me.DGVVehicule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVVehicule.Size = New System.Drawing.Size(704, 273)
        Me.DGVVehicule.TabIndex = 1
        '
        'UCAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DGVVehicule)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVItemLow)
        Me.Name = "UCAccueil"
        Me.Size = New System.Drawing.Size(808, 649)
        CType(Me.DGVItemLow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVVehicule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVItemLow As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DGVVehicule As DataGridView
End Class
