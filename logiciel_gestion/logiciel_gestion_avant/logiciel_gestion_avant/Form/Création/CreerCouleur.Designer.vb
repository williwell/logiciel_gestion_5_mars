<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreerCouleur
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
        Me.BtSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBNom = New System.Windows.Forms.TextBox()
        Me.TBCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NUDCout = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtAnnuler = New System.Windows.Forms.Button()
        CType(Me.NUDCout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtSave
        '
        Me.BtSave.Location = New System.Drawing.Point(64, 187)
        Me.BtSave.Name = "BtSave"
        Me.BtSave.Size = New System.Drawing.Size(75, 23)
        Me.BtSave.TabIndex = 0
        Me.BtSave.Text = "Enregistrer"
        Me.BtSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom Couleur"
        '
        'TBNom
        '
        Me.TBNom.Location = New System.Drawing.Point(64, 70)
        Me.TBNom.Name = "TBNom"
        Me.TBNom.Size = New System.Drawing.Size(156, 23)
        Me.TBNom.TabIndex = 2
        '
        'TBCode
        '
        Me.TBCode.Location = New System.Drawing.Point(64, 114)
        Me.TBCode.Name = "TBCode"
        Me.TBCode.Size = New System.Drawing.Size(156, 23)
        Me.TBCode.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Code Couleur"
        '
        'NUDCout
        '
        Me.NUDCout.DecimalPlaces = 2
        Me.NUDCout.Location = New System.Drawing.Point(64, 158)
        Me.NUDCout.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NUDCout.Name = "NUDCout"
        Me.NUDCout.Size = New System.Drawing.Size(156, 23)
        Me.NUDCout.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Coût"
        '
        'BtAnnuler
        '
        Me.BtAnnuler.Location = New System.Drawing.Point(145, 187)
        Me.BtAnnuler.Name = "BtAnnuler"
        Me.BtAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.BtAnnuler.TabIndex = 7
        Me.BtAnnuler.Text = "Annuler"
        Me.BtAnnuler.UseVisualStyleBackColor = True
        '
        'CreerCouleur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 296)
        Me.Controls.Add(Me.BtAnnuler)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NUDCout)
        Me.Controls.Add(Me.TBCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBNom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtSave)
        Me.MaximumSize = New System.Drawing.Size(310, 335)
        Me.MinimumSize = New System.Drawing.Size(310, 335)
        Me.Name = "CreerCouleur"
        Me.Text = "Création Nouvelle Couleur"
        CType(Me.NUDCout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TBNom As TextBox
    Friend WithEvents TBCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NUDCout As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents BtAnnuler As Button
End Class
