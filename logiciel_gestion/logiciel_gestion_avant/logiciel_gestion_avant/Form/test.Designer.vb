<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class test
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DGVVehicule = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVItemLow = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVVehicule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVItemLow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(69, 56)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(778, 594)
        Me.DataGridView1.TabIndex = 0
        '
        'Timer1
        '
        '
        'DGVVehicule
        '
        Me.DGVVehicule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVehicule.Location = New System.Drawing.Point(934, 334)
        Me.DGVVehicule.Name = "DGVVehicule"
        Me.DGVVehicule.RowTemplate.Height = 25
        Me.DGVVehicule.Size = New System.Drawing.Size(459, 273)
        Me.DGVVehicule.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(934, 316)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Liste Livraison Véhicule"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(934, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Inventaire en manque"
        '
        'DGVItemLow
        '
        Me.DGVItemLow.AllowUserToAddRows = False
        Me.DGVItemLow.AllowUserToDeleteRows = False
        Me.DGVItemLow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVItemLow.Location = New System.Drawing.Point(934, 74)
        Me.DGVItemLow.Name = "DGVItemLow"
        Me.DGVItemLow.ReadOnly = True
        Me.DGVItemLow.RowTemplate.Height = 25
        Me.DGVItemLow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVItemLow.Size = New System.Drawing.Size(459, 220)
        Me.DGVItemLow.TabIndex = 5
        '
        'test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1509, 742)
        Me.Controls.Add(Me.DGVVehicule)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVItemLow)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "test"
        Me.Text = "test"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVVehicule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVItemLow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DGVVehicule As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVItemLow As DataGridView
End Class
