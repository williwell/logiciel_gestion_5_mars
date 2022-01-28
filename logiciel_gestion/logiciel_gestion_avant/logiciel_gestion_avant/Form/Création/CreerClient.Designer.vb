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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreerClient))
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
        Me.TBNom2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBPrenom2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBTel2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Prénom 1"
        '
        'BTSave
        '
        Me.BTSave.Location = New System.Drawing.Point(67, 498)
        Me.BTSave.Name = "BTSave"
        Me.BTSave.Size = New System.Drawing.Size(108, 23)
        Me.BTSave.TabIndex = 1
        Me.BTSave.Text = "Enregistrer"
        Me.BTSave.UseVisualStyleBackColor = True
        '
        'TBPrenom
        '
        Me.TBPrenom.Location = New System.Drawing.Point(67, 27)
        Me.TBPrenom.Name = "TBPrenom"
        Me.TBPrenom.Size = New System.Drawing.Size(226, 23)
        Me.TBPrenom.TabIndex = 2
        '
        'TBNom
        '
        Me.TBNom.Location = New System.Drawing.Point(67, 71)
        Me.TBNom.Name = "TBNom"
        Me.TBNom.Size = New System.Drawing.Size(226, 23)
        Me.TBNom.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nom 1"
        '
        'TBTelephone
        '
        Me.TBTelephone.Location = New System.Drawing.Point(67, 335)
        Me.TBTelephone.Name = "TBTelephone"
        Me.TBTelephone.Size = New System.Drawing.Size(226, 23)
        Me.TBTelephone.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Téléphone 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 405)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Sexe"
        '
        'TBEmail
        '
        Me.TBEmail.Location = New System.Drawing.Point(67, 467)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(226, 23)
        Me.TBEmail.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(67, 449)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Email"
        '
        'CBSexe
        '
        Me.CBSexe.FormattingEnabled = True
        Me.CBSexe.Location = New System.Drawing.Point(67, 423)
        Me.CBSexe.Name = "CBSexe"
        Me.CBSexe.Size = New System.Drawing.Size(226, 23)
        Me.CBSexe.TabIndex = 13
        '
        'BTAnnuler
        '
        Me.BTAnnuler.Location = New System.Drawing.Point(185, 498)
        Me.BTAnnuler.Name = "BTAnnuler"
        Me.BTAnnuler.Size = New System.Drawing.Size(108, 23)
        Me.BTAnnuler.TabIndex = 14
        Me.BTAnnuler.Text = "Annuler"
        Me.BTAnnuler.UseVisualStyleBackColor = True
        '
        'TBNom2
        '
        Me.TBNom2.Location = New System.Drawing.Point(67, 159)
        Me.TBNom2.Name = "TBNom2"
        Me.TBNom2.Size = New System.Drawing.Size(226, 23)
        Me.TBNom2.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 15)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Nom 2"
        '
        'TBPrenom2
        '
        Me.TBPrenom2.Location = New System.Drawing.Point(67, 115)
        Me.TBPrenom2.Name = "TBPrenom2"
        Me.TBPrenom2.Size = New System.Drawing.Size(226, 23)
        Me.TBPrenom2.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(67, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Prénom 2"
        '
        'TBTel2
        '
        Me.TBTel2.Location = New System.Drawing.Point(67, 379)
        Me.TBTel2.Name = "TBTel2"
        Me.TBTel2.Size = New System.Drawing.Size(226, 23)
        Me.TBTel2.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(67, 361)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 15)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Téléphone 2"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(67, 203)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(226, 23)
        Me.TextBox1.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(67, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 15)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Adresse"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(67, 247)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(226, 23)
        Me.TextBox2.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(67, 229)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 15)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Appartement"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(67, 291)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(226, 23)
        Me.TextBox3.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(67, 273)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 15)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Code Postal"
        '
        'CreerClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 540)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TBTel2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TBNom2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBPrenom2)
        Me.Controls.Add(Me.Label7)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(381, 579)
        Me.MinimumSize = New System.Drawing.Size(381, 579)
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
    Friend WithEvents TBNom2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBPrenom2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBTel2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label11 As Label
End Class
