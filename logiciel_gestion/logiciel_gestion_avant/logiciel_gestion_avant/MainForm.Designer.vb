<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanUC = New System.Windows.Forms.Panel()
        Me.btMenu = New System.Windows.Forms.Button()
        Me.panMenu = New System.Windows.Forms.Panel()
        Me.btVente = New System.Windows.Forms.Button()
        Me.btInventaire = New System.Windows.Forms.Button()
        Me.btAccueil = New System.Windows.Forms.Button()
        Me.panMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanUC
        '
        Me.PanUC.Location = New System.Drawing.Point(12, 36)
        Me.PanUC.Name = "PanUC"
        Me.PanUC.Size = New System.Drawing.Size(808, 503)
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
        Me.panMenu.Controls.Add(Me.btVente)
        Me.panMenu.Controls.Add(Me.btInventaire)
        Me.panMenu.Controls.Add(Me.btAccueil)
        Me.panMenu.Controls.Add(Me.btMenu)
        Me.panMenu.Location = New System.Drawing.Point(12, 3)
        Me.panMenu.MaximumSize = New System.Drawing.Size(100, 116)
        Me.panMenu.MinimumSize = New System.Drawing.Size(100, 27)
        Me.panMenu.Name = "panMenu"
        Me.panMenu.Size = New System.Drawing.Size(100, 116)
        Me.panMenu.TabIndex = 2
        '
        'btVente
        '
        Me.btVente.Location = New System.Drawing.Point(20, 90)
        Me.btVente.Name = "btVente"
        Me.btVente.Size = New System.Drawing.Size(77, 23)
        Me.btVente.TabIndex = 3
        Me.btVente.Text = "Contrat"
        Me.btVente.UseVisualStyleBackColor = True
        '
        'btInventaire
        '
        Me.btInventaire.Location = New System.Drawing.Point(20, 61)
        Me.btInventaire.Name = "btInventaire"
        Me.btInventaire.Size = New System.Drawing.Size(77, 23)
        Me.btInventaire.TabIndex = 2
        Me.btInventaire.Text = "Inventaire"
        Me.btInventaire.UseVisualStyleBackColor = True
        '
        'btAccueil
        '
        Me.btAccueil.Location = New System.Drawing.Point(20, 32)
        Me.btAccueil.Name = "btAccueil"
        Me.btAccueil.Size = New System.Drawing.Size(77, 23)
        Me.btAccueil.TabIndex = 1
        Me.btAccueil.Text = "Accueil"
        Me.btAccueil.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 551)
        Me.Controls.Add(Me.panMenu)
        Me.Controls.Add(Me.PanUC)
        Me.MaximumSize = New System.Drawing.Size(848, 590)
        Me.MinimumSize = New System.Drawing.Size(848, 590)
        Me.Name = "MainForm"
        Me.Text = "Logiciel Gestion 5-Mars vr"
        Me.panMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanUC As Panel
    Friend WithEvents btMenu As Button
    Friend WithEvents panMenu As Panel
    Friend WithEvents btVente As Button
    Friend WithEvents btInventaire As Button
    Friend WithEvents btAccueil As Button
End Class
