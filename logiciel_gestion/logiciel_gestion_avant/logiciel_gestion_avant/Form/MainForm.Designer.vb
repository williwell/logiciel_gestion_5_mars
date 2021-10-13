<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanUC = New System.Windows.Forms.Panel()
        Me.btMenu = New System.Windows.Forms.Button()
        Me.panMenu = New System.Windows.Forms.Panel()
        Me.BtOptionModel = New System.Windows.Forms.Button()
        Me.BtCouleur = New System.Windows.Forms.Button()
        Me.btModel = New System.Windows.Forms.Button()
        Me.btFour = New System.Windows.Forms.Button()
        Me.btVente = New System.Windows.Forms.Button()
        Me.btInventaire = New System.Windows.Forms.Button()
        Me.btAccueil = New System.Windows.Forms.Button()
        Me.lbNonConc = New System.Windows.Forms.Label()
        Me.btConnec = New System.Windows.Forms.Button()
        Me.panMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanUC
        '
        Me.PanUC.Location = New System.Drawing.Point(12, 36)
        Me.PanUC.Name = "PanUC"
        Me.PanUC.Size = New System.Drawing.Size(808, 649)
        Me.PanUC.TabIndex = 1
        '
        'btMenu
        '
        Me.btMenu.Location = New System.Drawing.Point(3, 3)
        Me.btMenu.Name = "btMenu"
        Me.btMenu.Size = New System.Drawing.Size(94, 23)
        Me.btMenu.TabIndex = 0
        Me.btMenu.Text = "Menu"
        Me.btMenu.UseVisualStyleBackColor = True
        '
        'panMenu
        '
        Me.panMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panMenu.Controls.Add(Me.BtOptionModel)
        Me.panMenu.Controls.Add(Me.BtCouleur)
        Me.panMenu.Controls.Add(Me.btModel)
        Me.panMenu.Controls.Add(Me.btFour)
        Me.panMenu.Controls.Add(Me.btVente)
        Me.panMenu.Controls.Add(Me.btInventaire)
        Me.panMenu.Controls.Add(Me.btAccueil)
        Me.panMenu.Controls.Add(Me.btMenu)
        Me.panMenu.Location = New System.Drawing.Point(12, 3)
        Me.panMenu.MaximumSize = New System.Drawing.Size(100, 235)
        Me.panMenu.MinimumSize = New System.Drawing.Size(100, 30)
        Me.panMenu.Name = "panMenu"
        Me.panMenu.Size = New System.Drawing.Size(100, 235)
        Me.panMenu.TabIndex = 2
        '
        'BtOptionModel
        '
        Me.BtOptionModel.Location = New System.Drawing.Point(3, 206)
        Me.BtOptionModel.Name = "BtOptionModel"
        Me.BtOptionModel.Size = New System.Drawing.Size(94, 23)
        Me.BtOptionModel.TabIndex = 7
        Me.BtOptionModel.Text = "Option Model"
        Me.BtOptionModel.UseVisualStyleBackColor = True
        '
        'BtCouleur
        '
        Me.BtCouleur.Location = New System.Drawing.Point(3, 177)
        Me.BtCouleur.Name = "BtCouleur"
        Me.BtCouleur.Size = New System.Drawing.Size(94, 23)
        Me.BtCouleur.TabIndex = 6
        Me.BtCouleur.Text = "Couleur"
        Me.BtCouleur.UseVisualStyleBackColor = True
        '
        'btModel
        '
        Me.btModel.Location = New System.Drawing.Point(3, 148)
        Me.btModel.Name = "btModel"
        Me.btModel.Size = New System.Drawing.Size(94, 23)
        Me.btModel.TabIndex = 5
        Me.btModel.Text = "Model"
        Me.btModel.UseVisualStyleBackColor = True
        '
        'btFour
        '
        Me.btFour.Location = New System.Drawing.Point(3, 90)
        Me.btFour.Name = "btFour"
        Me.btFour.Size = New System.Drawing.Size(94, 23)
        Me.btFour.TabIndex = 4
        Me.btFour.Text = "Fournisseur"
        Me.btFour.UseVisualStyleBackColor = True
        '
        'btVente
        '
        Me.btVente.Location = New System.Drawing.Point(3, 119)
        Me.btVente.Name = "btVente"
        Me.btVente.Size = New System.Drawing.Size(94, 23)
        Me.btVente.TabIndex = 3
        Me.btVente.Text = "Contrat"
        Me.btVente.UseVisualStyleBackColor = True
        '
        'btInventaire
        '
        Me.btInventaire.Location = New System.Drawing.Point(3, 61)
        Me.btInventaire.Name = "btInventaire"
        Me.btInventaire.Size = New System.Drawing.Size(94, 23)
        Me.btInventaire.TabIndex = 2
        Me.btInventaire.Text = "Inventaire"
        Me.btInventaire.UseVisualStyleBackColor = True
        '
        'btAccueil
        '
        Me.btAccueil.Location = New System.Drawing.Point(3, 32)
        Me.btAccueil.Name = "btAccueil"
        Me.btAccueil.Size = New System.Drawing.Size(94, 23)
        Me.btAccueil.TabIndex = 1
        Me.btAccueil.Text = "Accueil"
        Me.btAccueil.UseVisualStyleBackColor = True
        '
        'lbNonConc
        '
        Me.lbNonConc.AutoSize = True
        Me.lbNonConc.Location = New System.Drawing.Point(265, 14)
        Me.lbNonConc.Name = "lbNonConc"
        Me.lbNonConc.Size = New System.Drawing.Size(0, 15)
        Me.lbNonConc.TabIndex = 3
        '
        'btConnec
        '
        Me.btConnec.Location = New System.Drawing.Point(483, 7)
        Me.btConnec.Name = "btConnec"
        Me.btConnec.Size = New System.Drawing.Size(94, 23)
        Me.btConnec.TabIndex = 5
        Me.btConnec.Text = "Connecter"
        Me.btConnec.UseVisualStyleBackColor = True
        Me.btConnec.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 692)
        Me.Controls.Add(Me.btConnec)
        Me.Controls.Add(Me.lbNonConc)
        Me.Controls.Add(Me.panMenu)
        Me.Controls.Add(Me.PanUC)
        Me.MaximumSize = New System.Drawing.Size(848, 731)
        Me.MinimumSize = New System.Drawing.Size(848, 731)
        Me.Name = "MainForm"
        Me.Text = "Logiciel Gestion 5-Mars vr"
        Me.panMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanUC As Panel
    Friend WithEvents btMenu As Button
    Friend WithEvents panMenu As Panel
    Friend WithEvents btVente As Button
    Friend WithEvents btInventaire As Button
    Friend WithEvents btAccueil As Button
    Friend WithEvents btFour As Button
    Friend WithEvents lbNonConc As Label
    Friend WithEvents btConnec As Button
    Friend WithEvents btModel As Button
    Friend WithEvents BtOptionModel As Button
    Friend WithEvents BtCouleur As Button
End Class
