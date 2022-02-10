<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCOption
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
        Me.DGVOption = New System.Windows.Forms.DataGridView()
        Me.BTCreer = New System.Windows.Forms.Button()
        Me.BtSave = New System.Windows.Forms.Button()
        Me.BTAnnuler = New System.Windows.Forms.Button()
        Me.BTDelete = New System.Windows.Forms.Button()
        Me.BTItem = New System.Windows.Forms.Button()
        CType(Me.DGVOption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVOption
        '
        Me.DGVOption.AllowUserToAddRows = False
        Me.DGVOption.AllowUserToDeleteRows = False
        Me.DGVOption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOption.Location = New System.Drawing.Point(259, 171)
        Me.DGVOption.Name = "DGVOption"
        Me.DGVOption.RowTemplate.Height = 25
        Me.DGVOption.Size = New System.Drawing.Size(600, 264)
        Me.DGVOption.TabIndex = 3
        '
        'BTCreer
        '
        Me.BTCreer.Location = New System.Drawing.Point(259, 142)
        Me.BTCreer.Name = "BTCreer"
        Me.BTCreer.Size = New System.Drawing.Size(140, 23)
        Me.BTCreer.TabIndex = 1
        Me.BTCreer.Text = "Créer Nouvelle Option"
        Me.BTCreer.UseVisualStyleBackColor = True
        '
        'BtSave
        '
        Me.BtSave.Enabled = False
        Me.BtSave.Location = New System.Drawing.Point(259, 441)
        Me.BtSave.Name = "BtSave"
        Me.BtSave.Size = New System.Drawing.Size(117, 23)
        Me.BtSave.TabIndex = 4
        Me.BtSave.Text = "Enregistrer"
        Me.BtSave.UseVisualStyleBackColor = True
        '
        'BTAnnuler
        '
        Me.BTAnnuler.Enabled = False
        Me.BTAnnuler.Location = New System.Drawing.Point(382, 441)
        Me.BTAnnuler.Name = "BTAnnuler"
        Me.BTAnnuler.Size = New System.Drawing.Size(117, 23)
        Me.BTAnnuler.TabIndex = 5
        Me.BTAnnuler.Text = "Annuler"
        Me.BTAnnuler.UseVisualStyleBackColor = True
        '
        'BTDelete
        '
        Me.BTDelete.Location = New System.Drawing.Point(505, 441)
        Me.BTDelete.Name = "BTDelete"
        Me.BTDelete.Size = New System.Drawing.Size(117, 23)
        Me.BTDelete.TabIndex = 6
        Me.BTDelete.Text = "Supprimer Option"
        Me.BTDelete.UseVisualStyleBackColor = True
        '
        'BTItem
        '
        Me.BTItem.Location = New System.Drawing.Point(405, 142)
        Me.BTItem.Name = "BTItem"
        Me.BTItem.Size = New System.Drawing.Size(140, 23)
        Me.BTItem.TabIndex = 2
        Me.BTItem.Text = "Gérer Inventaire Option"
        Me.BTItem.UseVisualStyleBackColor = True
        '
        'UCOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BTItem)
        Me.Controls.Add(Me.BTDelete)
        Me.Controls.Add(Me.BTAnnuler)
        Me.Controls.Add(Me.BtSave)
        Me.Controls.Add(Me.BTCreer)
        Me.Controls.Add(Me.DGVOption)
        Me.Name = "UCOption"
        Me.Size = New System.Drawing.Size(1115, 651)
        CType(Me.DGVOption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVOption As DataGridView
    Friend WithEvents BTCreer As Button
    Friend WithEvents BtSave As Button
    Friend WithEvents BTAnnuler As Button
    Friend WithEvents BTDelete As Button
    Friend WithEvents BTItem As Button
End Class
