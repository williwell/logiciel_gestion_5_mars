<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCVente3
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
        Me.BTSave = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BTPrev = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBPrenom1 = New System.Windows.Forms.TextBox()
        Me.TBNom1 = New System.Windows.Forms.TextBox()
        Me.TBPrenom2 = New System.Windows.Forms.TextBox()
        Me.TBNom2 = New System.Windows.Forms.TextBox()
        Me.TBTel1 = New System.Windows.Forms.TextBox()
        Me.TBTel2 = New System.Windows.Forms.TextBox()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.CBSexe = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BTSave
        '
        Me.BTSave.Location = New System.Drawing.Point(321, 591)
        Me.BTSave.Name = "BTSave"
        Me.BTSave.Size = New System.Drawing.Size(114, 23)
        Me.BTSave.TabIndex = 27
        Me.BTSave.Text = "Enregistrer"
        Me.BTSave.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(64, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 21)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Client Déja Existent"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(321, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 21)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Nouveau Client"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(321, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 15)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Nom 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(321, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 15)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Prenom 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(321, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Nom 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(321, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Prénom 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(64, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Client"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(64, 196)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(196, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Choisir Client"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BTPrev
        '
        Me.BTPrev.Location = New System.Drawing.Point(64, 591)
        Me.BTPrev.Name = "BTPrev"
        Me.BTPrev.Size = New System.Drawing.Size(114, 23)
        Me.BTPrev.TabIndex = 28
        Me.BTPrev.Text = "Précédent"
        Me.BTPrev.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(321, 504)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 15)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Email"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(321, 460)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 15)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Sexe"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(321, 416)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 15)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Téléphone 2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(321, 372)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 15)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Téléphnoe 1"
        '
        'TBPrenom1
        '
        Me.TBPrenom1.Location = New System.Drawing.Point(321, 214)
        Me.TBPrenom1.Name = "TBPrenom1"
        Me.TBPrenom1.Size = New System.Drawing.Size(204, 23)
        Me.TBPrenom1.TabIndex = 33
        '
        'TBNom1
        '
        Me.TBNom1.Location = New System.Drawing.Point(321, 258)
        Me.TBNom1.Name = "TBNom1"
        Me.TBNom1.Size = New System.Drawing.Size(204, 23)
        Me.TBNom1.TabIndex = 34
        '
        'TBPrenom2
        '
        Me.TBPrenom2.Location = New System.Drawing.Point(321, 302)
        Me.TBPrenom2.Name = "TBPrenom2"
        Me.TBPrenom2.Size = New System.Drawing.Size(204, 23)
        Me.TBPrenom2.TabIndex = 35
        '
        'TBNom2
        '
        Me.TBNom2.Location = New System.Drawing.Point(321, 346)
        Me.TBNom2.Name = "TBNom2"
        Me.TBNom2.Size = New System.Drawing.Size(204, 23)
        Me.TBNom2.TabIndex = 36
        '
        'TBTel1
        '
        Me.TBTel1.Location = New System.Drawing.Point(321, 390)
        Me.TBTel1.Name = "TBTel1"
        Me.TBTel1.Size = New System.Drawing.Size(204, 23)
        Me.TBTel1.TabIndex = 37
        '
        'TBTel2
        '
        Me.TBTel2.Location = New System.Drawing.Point(321, 434)
        Me.TBTel2.Name = "TBTel2"
        Me.TBTel2.Size = New System.Drawing.Size(204, 23)
        Me.TBTel2.TabIndex = 38
        '
        'TBEmail
        '
        Me.TBEmail.Location = New System.Drawing.Point(321, 522)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(204, 23)
        Me.TBEmail.TabIndex = 40
        '
        'CBSexe
        '
        Me.CBSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSexe.FormattingEnabled = True
        Me.CBSexe.Location = New System.Drawing.Point(321, 478)
        Me.CBSexe.Name = "CBSexe"
        Me.CBSexe.Size = New System.Drawing.Size(204, 23)
        Me.CBSexe.TabIndex = 41
        '
        'UCVente3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CBSexe)
        Me.Controls.Add(Me.TBEmail)
        Me.Controls.Add(Me.TBTel2)
        Me.Controls.Add(Me.TBTel1)
        Me.Controls.Add(Me.TBNom2)
        Me.Controls.Add(Me.TBPrenom2)
        Me.Controls.Add(Me.TBNom1)
        Me.Controls.Add(Me.TBPrenom1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BTPrev)
        Me.Controls.Add(Me.BTSave)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "UCVente3"
        Me.Size = New System.Drawing.Size(808, 649)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTSave As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents BTPrev As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TBPrenom1 As TextBox
    Friend WithEvents TBNom1 As TextBox
    Friend WithEvents TBPrenom2 As TextBox
    Friend WithEvents TBNom2 As TextBox
    Friend WithEvents TBTel1 As TextBox
    Friend WithEvents TBTel2 As TextBox
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents CBSexe As ComboBox
End Class
