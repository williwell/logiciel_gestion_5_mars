<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionInvModel
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionInvModel))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DGVInventaireAdd = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DGVInventaireMo = New System.Windows.Forms.DataGridView()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btAnnuler = New System.Windows.Forms.Button()
        CType(Me.DGVInventaireAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVInventaireMo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(582, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 15)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Inventaire non associée"
        '
        'DGVInventaireAdd
        '
        Me.DGVInventaireAdd.AllowUserToAddRows = False
        Me.DGVInventaireAdd.AllowUserToDeleteRows = False
        Me.DGVInventaireAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVInventaireAdd.Location = New System.Drawing.Point(582, 27)
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
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 15)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Inventaire Model"
        '
        'DGVInventaireMo
        '
        Me.DGVInventaireMo.AllowUserToAddRows = False
        Me.DGVInventaireMo.AllowUserToDeleteRows = False
        Me.DGVInventaireMo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVInventaireMo.Location = New System.Drawing.Point(12, 27)
        Me.DGVInventaireMo.Name = "DGVInventaireMo"
        Me.DGVInventaireMo.RowTemplate.Height = 25
        Me.DGVInventaireMo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVInventaireMo.Size = New System.Drawing.Size(543, 488)
        Me.DGVInventaireMo.TabIndex = 1
        '
        'btSave
        '
        Me.btSave.Enabled = False
        Me.btSave.Location = New System.Drawing.Point(12, 521)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(137, 23)
        Me.btSave.TabIndex = 3
        Me.btSave.Text = "Enregistrer"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btAnnuler
        '
        Me.btAnnuler.Location = New System.Drawing.Point(155, 521)
        Me.btAnnuler.Name = "btAnnuler"
        Me.btAnnuler.Size = New System.Drawing.Size(137, 23)
        Me.btAnnuler.TabIndex = 4
        Me.btAnnuler.Text = "Annuler"
        Me.btAnnuler.UseVisualStyleBackColor = True
        '
        'GestionInvModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 587)
        Me.Controls.Add(Me.btAnnuler)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DGVInventaireAdd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DGVInventaireMo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionInvModel"
        Me.Text = "Gestion Model Inventaire"
        CType(Me.DGVInventaireAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVInventaireMo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents DGVInventaireAdd As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents DGVInventaireMo As DataGridView
    Friend WithEvents btSave As Button
    Friend WithEvents btAnnuler As Button
End Class
