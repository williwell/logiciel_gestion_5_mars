<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreerClient
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTSave = New System.Windows.Forms.Button()
        Me.TBPrenom = New System.Windows.Forms.TextBox()
        Me.TBNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBTelephone = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBSexe = New System.Windows.Forms.ComboBox()
        Me.BTAnnuler = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Prénom"
        '
        'BTSave
        '
        Me.BTSave.Location = New System.Drawing.Point(67, 272)
        Me.BTSave.Name = "BTSave"
        Me.BTSave.Size = New System.Drawing.Size(108, 23)
        Me.BTSave.TabIndex = 1
        Me.BTSave.Text = "Enregistrer"
        Me.BTSave.UseVisualStyleBackColor = True
        '
        'TBPrenom
        '
        Me.TBPrenom.Location = New System.Drawing.Point(67, 67)
        Me.TBPrenom.Name = "TBPrenom"
        Me.TBPrenom.Size = New System.Drawing.Size(226, 23)
        Me.TBPrenom.TabIndex = 2
        '
        'TBNom
        '
        Me.TBNom.Location = New System.Drawing.Point(67, 111)
        Me.TBNom.Name = "TBNom"
        Me.TBNom.Size = New System.Drawing.Size(226, 23)
        Me.TBNom.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nom"
        '
        'TBTelephone
        '
        Me.TBTelephone.Location = New System.Drawing.Point(67, 155)
        Me.TBTelephone.Name = "TBTelephone"
        Me.TBTelephone.Size = New System.Drawing.Size(226, 23)
        Me.TBTelephone.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Téléphone"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Sexe"
        '
        'TBEmail
        '
        Me.TBEmail.Location = New System.Drawing.Point(67, 243)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(226, 23)
        Me.TBEmail.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(67, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Email"
        '
        'CBSexe
        '
        Me.CBSexe.FormattingEnabled = True
        Me.CBSexe.Location = New System.Drawing.Point(67, 199)
        Me.CBSexe.Name = "CBSexe"
        Me.CBSexe.Size = New System.Drawing.Size(226, 23)
        Me.CBSexe.TabIndex = 13
        '
        'BTAnnuler
        '
        Me.BTAnnuler.Location = New System.Drawing.Point(185, 272)
        Me.BTAnnuler.Name = "BTAnnuler"
        Me.BTAnnuler.Size = New System.Drawing.Size(108, 23)
        Me.BTAnnuler.TabIndex = 14
        Me.BTAnnuler.Text = "Annuler"
        Me.BTAnnuler.UseVisualStyleBackColor = True
        '
        'CreerClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 392)
        Me.Controls.Add(Me.BTAnnuler)
        Me.Controls.Add(Me.CBSexe)
        Me.Controls.Add(Me.TBEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBTelephone)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBNom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBPrenom)
        Me.Controls.Add(Me.BTSave)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(381, 431)
        Me.MinimumSize = New System.Drawing.Size(381, 431)
        Me.Name = "CreerClient"
        Me.Text = "Création Nouveau Client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BTSave As Button
    Friend WithEvents TBPrenom As TextBox
    Friend WithEvents TBNom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBTelephone As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CBSexe As ComboBox
    Friend WithEvents BTAnnuler As Button
End Class
