<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCTache
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
        Me.DGVTache = New System.Windows.Forms.DataGridView()
        Me.BTAdd = New System.Windows.Forms.Button()
        Me.BTMod = New System.Windows.Forms.Button()
        Me.BTSupp = New System.Windows.Forms.Button()
        CType(Me.DGVTache, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVTache
        '
        Me.DGVTache.AllowUserToAddRows = False
        Me.DGVTache.AllowUserToDeleteRows = False
        Me.DGVTache.AllowUserToResizeColumns = False
        Me.DGVTache.AllowUserToResizeRows = False
        Me.DGVTache.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTache.Location = New System.Drawing.Point(3, 92)
        Me.DGVTache.Name = "DGVTache"
        Me.DGVTache.RowTemplate.Height = 25
        Me.DGVTache.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVTache.Size = New System.Drawing.Size(1109, 556)
        Me.DGVTache.TabIndex = 0
        '
        'BTAdd
        '
        Me.BTAdd.Location = New System.Drawing.Point(3, 63)
        Me.BTAdd.Name = "BTAdd"
        Me.BTAdd.Size = New System.Drawing.Size(98, 23)
        Me.BTAdd.TabIndex = 1
        Me.BTAdd.Text = "Nouveau"
        Me.BTAdd.UseVisualStyleBackColor = True
        '
        'BTMod
        '
        Me.BTMod.Location = New System.Drawing.Point(107, 63)
        Me.BTMod.Name = "BTMod"
        Me.BTMod.Size = New System.Drawing.Size(98, 23)
        Me.BTMod.TabIndex = 2
        Me.BTMod.Text = "Modifier"
        Me.BTMod.UseVisualStyleBackColor = True
        '
        'BTSupp
        '
        Me.BTSupp.Location = New System.Drawing.Point(211, 63)
        Me.BTSupp.Name = "BTSupp"
        Me.BTSupp.Size = New System.Drawing.Size(98, 23)
        Me.BTSupp.TabIndex = 3
        Me.BTSupp.Text = "Supprimer"
        Me.BTSupp.UseVisualStyleBackColor = True
        '
        'UCTache
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BTSupp)
        Me.Controls.Add(Me.BTMod)
        Me.Controls.Add(Me.BTAdd)
        Me.Controls.Add(Me.DGVTache)
        Me.Name = "UCTache"
        Me.Size = New System.Drawing.Size(1115, 651)
        CType(Me.DGVTache, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVTache As DataGridView
    Friend WithEvents BTAdd As Button
    Friend WithEvents BTMod As Button
    Friend WithEvents BTSupp As Button
End Class
