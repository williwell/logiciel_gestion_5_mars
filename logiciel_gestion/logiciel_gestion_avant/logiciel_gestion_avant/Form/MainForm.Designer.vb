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
        Me.components = New System.ComponentModel.Container()
        Me.PanUC = New System.Windows.Forms.Panel()
        Me.btMenu = New System.Windows.Forms.Button()
        Me.panMenu = New System.Windows.Forms.Panel()
        Me.btFour = New System.Windows.Forms.Button()
        Me.btVente = New System.Windows.Forms.Button()
        Me.btInventaire = New System.Windows.Forms.Button()
        Me.btAccueil = New System.Windows.Forms.Button()
        Me.lbNonConc = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        Me.panMenu.Controls.Add(Me.btFour)
        Me.panMenu.Controls.Add(Me.btVente)
        Me.panMenu.Controls.Add(Me.btInventaire)
        Me.panMenu.Controls.Add(Me.btAccueil)
        Me.panMenu.Controls.Add(Me.btMenu)
        Me.panMenu.Location = New System.Drawing.Point(12, 3)
        Me.panMenu.MaximumSize = New System.Drawing.Size(100, 144)
        Me.panMenu.MinimumSize = New System.Drawing.Size(100, 27)
        Me.panMenu.Name = "panMenu"
        Me.panMenu.Size = New System.Drawing.Size(100, 144)
        Me.panMenu.TabIndex = 2
        '
        'btFour
        '
        Me.btFour.Location = New System.Drawing.Point(20, 90)
        Me.btFour.Name = "btFour"
        Me.btFour.Size = New System.Drawing.Size(77, 23)
        Me.btFour.TabIndex = 4
        Me.btFour.Text = "Fournisseur"
        Me.btFour.UseVisualStyleBackColor = True
        '
        'btVente
        '
        Me.btVente.Location = New System.Drawing.Point(20, 119)
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
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btConnec As Button
End Class
