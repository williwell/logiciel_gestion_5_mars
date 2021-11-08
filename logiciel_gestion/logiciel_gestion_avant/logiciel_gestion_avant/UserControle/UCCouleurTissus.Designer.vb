<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCouleurTissus
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
        Me.BtDel = New System.Windows.Forms.Button()
        Me.BTAnnuler = New System.Windows.Forms.Button()
        Me.BTEnregistrer = New System.Windows.Forms.Button()
        Me.BtCreer = New System.Windows.Forms.Button()
        Me.dgvCouleur = New System.Windows.Forms.DataGridView()
        CType(Me.dgvCouleur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtDel
        '
        Me.BtDel.Location = New System.Drawing.Point(347, 404)
        Me.BtDel.Name = "BtDel"
        Me.BtDel.Size = New System.Drawing.Size(135, 23)
        Me.BtDel.TabIndex = 9
        Me.BtDel.Text = "Supprimer Couleur"
        Me.BtDel.UseVisualStyleBackColor = True
        '
        'BTAnnuler
        '
        Me.BTAnnuler.Enabled = False
        Me.BTAnnuler.Location = New System.Drawing.Point(206, 404)
        Me.BTAnnuler.Name = "BTAnnuler"
        Me.BTAnnuler.Size = New System.Drawing.Size(135, 23)
        Me.BTAnnuler.TabIndex = 8
        Me.BTAnnuler.Text = "Annuler Modification"
        Me.BTAnnuler.UseVisualStyleBackColor = True
        '
        'BTEnregistrer
        '
        Me.BTEnregistrer.Enabled = False
        Me.BTEnregistrer.Location = New System.Drawing.Point(65, 404)
        Me.BTEnregistrer.Name = "BTEnregistrer"
        Me.BTEnregistrer.Size = New System.Drawing.Size(135, 23)
        Me.BTEnregistrer.TabIndex = 7
        Me.BTEnregistrer.Text = "Enregistrer"
        Me.BTEnregistrer.UseVisualStyleBackColor = True
        '
        'BtCreer
        '
        Me.BtCreer.Location = New System.Drawing.Point(65, 101)
        Me.BtCreer.Name = "BtCreer"
        Me.BtCreer.Size = New System.Drawing.Size(176, 23)
        Me.BtCreer.TabIndex = 6
        Me.BtCreer.Text = "Créer Nouvelle Couleur Tissus"
        Me.BtCreer.UseVisualStyleBackColor = True
        '
        'dgvCouleur
        '
        Me.dgvCouleur.AllowUserToAddRows = False
        Me.dgvCouleur.AllowUserToDeleteRows = False
        Me.dgvCouleur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCouleur.Location = New System.Drawing.Point(65, 130)
        Me.dgvCouleur.Name = "dgvCouleur"
        Me.dgvCouleur.RowTemplate.Height = 25
        Me.dgvCouleur.Size = New System.Drawing.Size(550, 268)
        Me.dgvCouleur.TabIndex = 5
        '
        'UCCouleurTissus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtDel)
        Me.Controls.Add(Me.BTAnnuler)
        Me.Controls.Add(Me.BTEnregistrer)
        Me.Controls.Add(Me.BtCreer)
        Me.Controls.Add(Me.dgvCouleur)
        Me.Name = "UCCouleurTissus"
        Me.Size = New System.Drawing.Size(847, 647)
        CType(Me.dgvCouleur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtDel As Button
    Friend WithEvents BTAnnuler As Button
    Friend WithEvents BTEnregistrer As Button
    Friend WithEvents BtCreer As Button
    Friend WithEvents dgvCouleur As DataGridView
End Class
