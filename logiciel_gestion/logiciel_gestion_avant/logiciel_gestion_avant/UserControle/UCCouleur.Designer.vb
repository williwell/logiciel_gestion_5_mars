<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCouleur
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
        Me.dgvCouleur = New System.Windows.Forms.DataGridView()
        Me.BtCreer = New System.Windows.Forms.Button()
        Me.BTEnregistrer = New System.Windows.Forms.Button()
        Me.BTAnnuler = New System.Windows.Forms.Button()
        Me.BtDel = New System.Windows.Forms.Button()
        CType(Me.dgvCouleur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCouleur
        '
        Me.dgvCouleur.AllowUserToAddRows = False
        Me.dgvCouleur.AllowUserToDeleteRows = False
        Me.dgvCouleur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCouleur.Location = New System.Drawing.Point(280, 164)
        Me.dgvCouleur.Name = "dgvCouleur"
        Me.dgvCouleur.RowTemplate.Height = 25
        Me.dgvCouleur.Size = New System.Drawing.Size(550, 268)
        Me.dgvCouleur.TabIndex = 0
        '
        'BtCreer
        '
        Me.BtCreer.Location = New System.Drawing.Point(280, 135)
        Me.BtCreer.Name = "BtCreer"
        Me.BtCreer.Size = New System.Drawing.Size(176, 23)
        Me.BtCreer.TabIndex = 1
        Me.BtCreer.Text = "Créer Nouvelle Couleur Model"
        Me.BtCreer.UseVisualStyleBackColor = True
        '
        'BTEnregistrer
        '
        Me.BTEnregistrer.Enabled = False
        Me.BTEnregistrer.Location = New System.Drawing.Point(280, 438)
        Me.BTEnregistrer.Name = "BTEnregistrer"
        Me.BTEnregistrer.Size = New System.Drawing.Size(135, 23)
        Me.BTEnregistrer.TabIndex = 2
        Me.BTEnregistrer.Text = "Enregistrer"
        Me.BTEnregistrer.UseVisualStyleBackColor = True
        '
        'BTAnnuler
        '
        Me.BTAnnuler.Enabled = False
        Me.BTAnnuler.Location = New System.Drawing.Point(421, 438)
        Me.BTAnnuler.Name = "BTAnnuler"
        Me.BTAnnuler.Size = New System.Drawing.Size(135, 23)
        Me.BTAnnuler.TabIndex = 3
        Me.BTAnnuler.Text = "Annuler Modification"
        Me.BTAnnuler.UseVisualStyleBackColor = True
        '
        'BtDel
        '
        Me.BtDel.Location = New System.Drawing.Point(562, 438)
        Me.BtDel.Name = "BtDel"
        Me.BtDel.Size = New System.Drawing.Size(135, 23)
        Me.BtDel.TabIndex = 4
        Me.BtDel.Text = "Supprimer Couleur"
        Me.BtDel.UseVisualStyleBackColor = True
        '
        'UCCouleur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtDel)
        Me.Controls.Add(Me.BTAnnuler)
        Me.Controls.Add(Me.BTEnregistrer)
        Me.Controls.Add(Me.BtCreer)
        Me.Controls.Add(Me.dgvCouleur)
        Me.Name = "UCCouleur"
        Me.Size = New System.Drawing.Size(1115, 651)
        CType(Me.dgvCouleur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvCouleur As DataGridView
    Friend WithEvents BtCreer As Button
    Friend WithEvents BTEnregistrer As Button
    Friend WithEvents BTAnnuler As Button
    Friend WithEvents BtDel As Button
End Class
