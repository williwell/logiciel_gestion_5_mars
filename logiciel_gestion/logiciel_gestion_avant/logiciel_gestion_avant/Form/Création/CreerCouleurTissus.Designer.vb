<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreerCouleurTissus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreerCouleurTissus))
        Me.BtAnnuler = New System.Windows.Forms.Button()
        Me.TBCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtAnnuler
        '
        Me.BtAnnuler.Location = New System.Drawing.Point(139, 130)
        Me.BtAnnuler.Name = "BtAnnuler"
        Me.BtAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.BtAnnuler.TabIndex = 15
        Me.BtAnnuler.Text = "Annuler"
        Me.BtAnnuler.UseVisualStyleBackColor = True
        '
        'TBCode
        '
        Me.TBCode.Location = New System.Drawing.Point(58, 101)
        Me.TBCode.Name = "TBCode"
        Me.TBCode.Size = New System.Drawing.Size(156, 23)
        Me.TBCode.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Code Couleur"
        '
        'TBNom
        '
        Me.TBNom.Location = New System.Drawing.Point(58, 57)
        Me.TBNom.Name = "TBNom"
        Me.TBNom.Size = New System.Drawing.Size(156, 23)
        Me.TBNom.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nom Couleur"
        '
        'BtSave
        '
        Me.BtSave.Location = New System.Drawing.Point(58, 130)
        Me.BtSave.Name = "BtSave"
        Me.BtSave.Size = New System.Drawing.Size(75, 23)
        Me.BtSave.TabIndex = 8
        Me.BtSave.Text = "Enregistrer"
        Me.BtSave.UseVisualStyleBackColor = True
        '
        'CreerCouleurTissus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 222)
        Me.Controls.Add(Me.BtAnnuler)
        Me.Controls.Add(Me.TBCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBNom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtSave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CreerCouleurTissus"
        Me.Text = "Créer Couleur Tissus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtAnnuler As Button
    Friend WithEvents TBCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtSave As Button
End Class
