<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionReception
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbIp = New System.Windows.Forms.TextBox()
        Me.tbNom = New System.Windows.Forms.TextBox()
        Me.btSauv = New System.Windows.Forms.Button()
        Me.tbNomUserDB = New System.Windows.Forms.TextBox()
        Me.tbDBName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbPassUserDB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbPortDB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btAnnuler = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ip serveur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom ordinateur serveur"
        '
        'tbIp
        '
        Me.tbIp.Location = New System.Drawing.Point(92, 74)
        Me.tbIp.Name = "tbIp"
        Me.tbIp.Size = New System.Drawing.Size(179, 23)
        Me.tbIp.TabIndex = 2
        '
        'tbNom
        '
        Me.tbNom.Location = New System.Drawing.Point(92, 118)
        Me.tbNom.Name = "tbNom"
        Me.tbNom.Size = New System.Drawing.Size(179, 23)
        Me.tbNom.TabIndex = 3
        '
        'btSauv
        '
        Me.btSauv.Location = New System.Drawing.Point(92, 323)
        Me.btSauv.Name = "btSauv"
        Me.btSauv.Size = New System.Drawing.Size(85, 23)
        Me.btSauv.TabIndex = 4
        Me.btSauv.Text = "Sauvegarder"
        Me.btSauv.UseVisualStyleBackColor = True
        '
        'tbNomUserDB
        '
        Me.tbNomUserDB.Location = New System.Drawing.Point(92, 206)
        Me.tbNomUserDB.Name = "tbNomUserDB"
        Me.tbNomUserDB.Size = New System.Drawing.Size(179, 23)
        Me.tbNomUserDB.TabIndex = 8
        '
        'tbDBName
        '
        Me.tbDBName.Location = New System.Drawing.Point(92, 162)
        Me.tbDBName.Name = "tbDBName"
        Me.tbDBName.Size = New System.Drawing.Size(179, 23)
        Me.tbDBName.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nom d'utilisateur base de donné"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(92, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nom base de donnée"
        '
        'tbPassUserDB
        '
        Me.tbPassUserDB.Location = New System.Drawing.Point(92, 250)
        Me.tbPassUserDB.Name = "tbPassUserDB"
        Me.tbPassUserDB.Size = New System.Drawing.Size(179, 23)
        Me.tbPassUserDB.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(92, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Mot de passe de base de donnée"
        '
        'tbPortDB
        '
        Me.tbPortDB.Location = New System.Drawing.Point(92, 294)
        Me.tbPortDB.Name = "tbPortDB"
        Me.tbPortDB.Size = New System.Drawing.Size(179, 23)
        Me.tbPortDB.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(92, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Port à utilisé"
        '
        'btAnnuler
        '
        Me.btAnnuler.Location = New System.Drawing.Point(186, 323)
        Me.btAnnuler.Name = "btAnnuler"
        Me.btAnnuler.Size = New System.Drawing.Size(85, 23)
        Me.btAnnuler.TabIndex = 13
        Me.btAnnuler.Text = "Annuler"
        Me.btAnnuler.UseVisualStyleBackColor = True
        '
        'OptionReception
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(499, 480)
        Me.Controls.Add(Me.btAnnuler)
        Me.Controls.Add(Me.tbPortDB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbPassUserDB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbNomUserDB)
        Me.Controls.Add(Me.tbDBName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btSauv)
        Me.Controls.Add(Me.tbNom)
        Me.Controls.Add(Me.tbIp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "OptionReception"
        Me.Text = "OptionReception"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbIp As TextBox
    Friend WithEvents tbNom As TextBox
    Friend WithEvents btSauv As Button
    Friend WithEvents tbNomUserDB As TextBox
    Friend WithEvents tbDBName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbPassUserDB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbPortDB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btAnnuler As Button
End Class
