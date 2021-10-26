<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionInvOpt
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
        Me.btAnnuler = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DGVInventaireAdd = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DGVInventaireOpt = New System.Windows.Forms.DataGridView()
        CType(Me.DGVInventaireAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVInventaireOpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btAnnuler
        '
        Me.btAnnuler.Enabled = False
        Me.btAnnuler.Location = New System.Drawing.Point(191, 583)
        Me.btAnnuler.Name = "btAnnuler"
        Me.btAnnuler.Size = New System.Drawing.Size(137, 23)
        Me.btAnnuler.TabIndex = 4
        Me.btAnnuler.Text = "Annuler"
        Me.btAnnuler.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Enabled = False
        Me.btSave.Location = New System.Drawing.Point(48, 583)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(137, 23)
        Me.btSave.TabIndex = 3
        Me.btSave.Text = "Enregistrer"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(618, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 15)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Inventaire non associée"
        '
        'DGVInventaireAdd
        '
        Me.DGVInventaireAdd.AllowUserToAddRows = False
        Me.DGVInventaireAdd.AllowUserToDeleteRows = False
        Me.DGVInventaireAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVInventaireAdd.Location = New System.Drawing.Point(618, 89)
        Me.DGVInventaireAdd.Name = "DGVInventaireAdd"
        Me.DGVInventaireAdd.ReadOnly = True
        Me.DGVInventaireAdd.RowTemplate.Height = 25
        Me.DGVInventaireAdd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVInventaireAdd.Size = New System.Drawing.Size(443, 488)
        Me.DGVInventaireAdd.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 15)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Inventaire Option"
        '
        'DGVInventaireOpt
        '
        Me.DGVInventaireOpt.AllowUserToAddRows = False
        Me.DGVInventaireOpt.AllowUserToDeleteRows = False
        Me.DGVInventaireOpt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVInventaireOpt.Location = New System.Drawing.Point(48, 89)
        Me.DGVInventaireOpt.Name = "DGVInventaireOpt"
        Me.DGVInventaireOpt.RowTemplate.Height = 25
        Me.DGVInventaireOpt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVInventaireOpt.Size = New System.Drawing.Size(543, 488)
        Me.DGVInventaireOpt.TabIndex = 1
        '
        'GestionInvOpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 677)
        Me.Controls.Add(Me.btAnnuler)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DGVInventaireAdd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DGVInventaireOpt)
        Me.Name = "GestionInvOpt"
        Me.Text = "Gestion Option Inventaire"
        CType(Me.DGVInventaireAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVInventaireOpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btAnnuler As Button
    Friend WithEvents btSave As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents DGVInventaireAdd As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents DGVInventaireOpt As DataGridView
End Class
