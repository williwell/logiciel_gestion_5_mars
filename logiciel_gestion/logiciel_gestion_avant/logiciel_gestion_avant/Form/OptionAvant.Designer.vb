<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionAvant
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
        Me.btAnnuler = New System.Windows.Forms.Button()
        Me.tbPortDB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btSauv = New System.Windows.Forms.Button()
        Me.tbNom = New System.Windows.Forms.TextBox()
        Me.tbIp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btAnnuler
        '
        Me.btAnnuler.Location = New System.Drawing.Point(153, 192)
        Me.btAnnuler.Name = "btAnnuler"
        Me.btAnnuler.Size = New System.Drawing.Size(85, 23)
        Me.btAnnuler.TabIndex = 27
        Me.btAnnuler.Text = "Annuler"
        Me.btAnnuler.UseVisualStyleBackColor = True
        '
        'tbPortDB
        '
        Me.tbPortDB.Location = New System.Drawing.Point(59, 163)
        Me.tbPortDB.Name = "tbPortDB"
        Me.tbPortDB.Size = New System.Drawing.Size(179, 23)
        Me.tbPortDB.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Port à utilisé"
        '
        'btSauv
        '
        Me.btSauv.Location = New System.Drawing.Point(59, 192)
        Me.btSauv.Name = "btSauv"
        Me.btSauv.Size = New System.Drawing.Size(85, 23)
        Me.btSauv.TabIndex = 18
        Me.btSauv.Text = "Sauvegarder"
        Me.btSauv.UseVisualStyleBackColor = True
        '
        'tbNom
        '
        Me.tbNom.Location = New System.Drawing.Point(59, 119)
        Me.tbNom.Name = "tbNom"
        Me.tbNom.Size = New System.Drawing.Size(179, 23)
        Me.tbNom.TabIndex = 17
        '
        'tbIp
        '
        Me.tbIp.Location = New System.Drawing.Point(59, 75)
        Me.tbIp.Name = "tbIp"
        Me.tbIp.Size = New System.Drawing.Size(179, 23)
        Me.tbIp.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nom ordinateur serveur"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Ip serveur"
        '
        'OptionAvant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 450)
        Me.Controls.Add(Me.btAnnuler)
        Me.Controls.Add(Me.tbPortDB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btSauv)
        Me.Controls.Add(Me.tbNom)
        Me.Controls.Add(Me.tbIp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "OptionAvant"
        Me.Text = "Option"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btAnnuler As Button
    Friend WithEvents tbPortDB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btSauv As Button
    Friend WithEvents tbNom As TextBox
    Friend WithEvents tbIp As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
