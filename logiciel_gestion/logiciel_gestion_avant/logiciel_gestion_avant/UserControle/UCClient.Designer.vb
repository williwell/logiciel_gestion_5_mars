<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCClient
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
        Me.DGVClient = New System.Windows.Forms.DataGridView()
        Me.BtCreer = New System.Windows.Forms.Button()
        CType(Me.DGVClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVClient
        '
        Me.DGVClient.AllowUserToAddRows = False
        Me.DGVClient.AllowUserToDeleteRows = False
        Me.DGVClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVClient.Location = New System.Drawing.Point(12, 45)
        Me.DGVClient.Name = "DGVClient"
        Me.DGVClient.ReadOnly = True
        Me.DGVClient.RowTemplate.Height = 25
        Me.DGVClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVClient.Size = New System.Drawing.Size(1100, 603)
        Me.DGVClient.TabIndex = 0
        '
        'BtCreer
        '
        Me.BtCreer.Location = New System.Drawing.Point(12, 16)
        Me.BtCreer.Name = "BtCreer"
        Me.BtCreer.Size = New System.Drawing.Size(97, 23)
        Me.BtCreer.TabIndex = 1
        Me.BtCreer.Text = "Nouveau Client"
        Me.BtCreer.UseVisualStyleBackColor = True
        '
        'UCClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtCreer)
        Me.Controls.Add(Me.DGVClient)
        Me.Name = "UCClient"
        Me.Size = New System.Drawing.Size(1115, 651)
        CType(Me.DGVClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVClient As DataGridView
    Friend WithEvents BtCreer As Button
End Class
