<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionOptVe
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
        Me.DGVOptVe = New System.Windows.Forms.DataGridView()
        Me.DGVOptDis = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTSave = New System.Windows.Forms.Button()
        Me.BTAnnuler = New System.Windows.Forms.Button()
        CType(Me.DGVOptVe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVOptDis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVOptVe
        '
        Me.DGVOptVe.AllowUserToAddRows = False
        Me.DGVOptVe.AllowUserToDeleteRows = False
        Me.DGVOptVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOptVe.Location = New System.Drawing.Point(12, 27)
        Me.DGVOptVe.Name = "DGVOptVe"
        Me.DGVOptVe.ReadOnly = True
        Me.DGVOptVe.RowTemplate.Height = 25
        Me.DGVOptVe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVOptVe.Size = New System.Drawing.Size(584, 469)
        Me.DGVOptVe.TabIndex = 0
        '
        'DGVOptDis
        '
        Me.DGVOptDis.AllowUserToAddRows = False
        Me.DGVOptDis.AllowUserToDeleteRows = False
        Me.DGVOptDis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOptDis.Location = New System.Drawing.Point(602, 27)
        Me.DGVOptDis.Name = "DGVOptDis"
        Me.DGVOptDis.ReadOnly = True
        Me.DGVOptDis.RowTemplate.Height = 25
        Me.DGVOptDis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVOptDis.Size = New System.Drawing.Size(584, 469)
        Me.DGVOptDis.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Option du Véhicule"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(602, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Option disponible"
        '
        'BTSave
        '
        Me.BTSave.Location = New System.Drawing.Point(12, 502)
        Me.BTSave.Name = "BTSave"
        Me.BTSave.Size = New System.Drawing.Size(108, 23)
        Me.BTSave.TabIndex = 4
        Me.BTSave.Text = "Enregistrer"
        Me.BTSave.UseVisualStyleBackColor = True
        '
        'BTAnnuler
        '
        Me.BTAnnuler.Location = New System.Drawing.Point(126, 502)
        Me.BTAnnuler.Name = "BTAnnuler"
        Me.BTAnnuler.Size = New System.Drawing.Size(108, 23)
        Me.BTAnnuler.TabIndex = 5
        Me.BTAnnuler.Text = "Annuler"
        Me.BTAnnuler.UseVisualStyleBackColor = True
        '
        'GestionOptVe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1194, 541)
        Me.Controls.Add(Me.BTAnnuler)
        Me.Controls.Add(Me.BTSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVOptDis)
        Me.Controls.Add(Me.DGVOptVe)
        Me.Name = "GestionOptVe"
        Me.Text = "GestionOptVe"
        CType(Me.DGVOptVe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVOptDis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVOptVe As DataGridView
    Friend WithEvents DGVOptDis As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BTSave As Button
    Friend WithEvents BTAnnuler As Button
End Class
