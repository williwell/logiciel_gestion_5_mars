<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreerFour
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
        Me.btCreer = New System.Windows.Forms.Button()
        Me.tbMethodePaie = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbNoCompte = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbMethodeCom = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbAddCour = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbLeadTime = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbNomCont = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbTel = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbAdres2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbAdres1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNomFour = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btAnnuler
        '
        Me.btAnnuler.Location = New System.Drawing.Point(136, 472)
        Me.btAnnuler.Name = "btAnnuler"
        Me.btAnnuler.Size = New System.Drawing.Size(85, 23)
        Me.btAnnuler.TabIndex = 51
        Me.btAnnuler.Text = "Annuler"
        Me.btAnnuler.UseVisualStyleBackColor = True
        '
        'btCreer
        '
        Me.btCreer.Location = New System.Drawing.Point(41, 472)
        Me.btCreer.Name = "btCreer"
        Me.btCreer.Size = New System.Drawing.Size(85, 23)
        Me.btCreer.TabIndex = 50
        Me.btCreer.Text = "Enregistrer"
        Me.btCreer.UseVisualStyleBackColor = True
        '
        'tbMethodePaie
        '
        Me.tbMethodePaie.Location = New System.Drawing.Point(41, 443)
        Me.tbMethodePaie.Name = "tbMethodePaie"
        Me.tbMethodePaie.Size = New System.Drawing.Size(180, 23)
        Me.tbMethodePaie.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(41, 425)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 15)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Méthode Paiement"
        '
        'tbNoCompte
        '
        Me.tbNoCompte.Location = New System.Drawing.Point(41, 399)
        Me.tbNoCompte.Name = "tbNoCompte"
        Me.tbNoCompte.Size = New System.Drawing.Size(180, 23)
        Me.tbNoCompte.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(41, 381)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 15)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Numéro Compte"
        '
        'tbMethodeCom
        '
        Me.tbMethodeCom.Location = New System.Drawing.Point(41, 355)
        Me.tbMethodeCom.Name = "tbMethodeCom"
        Me.tbMethodeCom.Size = New System.Drawing.Size(180, 23)
        Me.tbMethodeCom.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(41, 337)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 15)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Méthode de commande"
        '
        'tbAddCour
        '
        Me.tbAddCour.Location = New System.Drawing.Point(41, 311)
        Me.tbAddCour.Name = "tbAddCour"
        Me.tbAddCour.Size = New System.Drawing.Size(180, 23)
        Me.tbAddCour.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Adresse Couriel"
        '
        'tbLeadTime
        '
        Me.tbLeadTime.Location = New System.Drawing.Point(41, 267)
        Me.tbLeadTime.Name = "tbLeadTime"
        Me.tbLeadTime.Size = New System.Drawing.Size(180, 23)
        Me.tbLeadTime.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 15)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Délai Livraison"
        '
        'tbNomCont
        '
        Me.tbNomCont.Location = New System.Drawing.Point(41, 223)
        Me.tbNomCont.Name = "tbNomCont"
        Me.tbNomCont.Size = New System.Drawing.Size(180, 23)
        Me.tbNomCont.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 15)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Nom Contact"
        '
        'tbTel
        '
        Me.tbTel.Location = New System.Drawing.Point(41, 179)
        Me.tbTel.Name = "tbTel"
        Me.tbTel.Size = New System.Drawing.Size(180, 23)
        Me.tbTel.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(41, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 15)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Téléphone"
        '
        'tbAdres2
        '
        Me.tbAdres2.Location = New System.Drawing.Point(41, 135)
        Me.tbAdres2.Name = "tbAdres2"
        Me.tbAdres2.Size = New System.Drawing.Size(180, 23)
        Me.tbAdres2.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Adresse 2"
        '
        'tbAdres1
        '
        Me.tbAdres1.Location = New System.Drawing.Point(41, 91)
        Me.tbAdres1.Name = "tbAdres1"
        Me.tbAdres1.Size = New System.Drawing.Size(180, 23)
        Me.tbAdres1.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Adresse 1"
        '
        'tbNomFour
        '
        Me.tbNomFour.Location = New System.Drawing.Point(41, 47)
        Me.tbNomFour.Name = "tbNomFour"
        Me.tbNomFour.Size = New System.Drawing.Size(180, 23)
        Me.tbNomFour.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Nom Fournisseur"
        '
        'CreerFour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 541)
        Me.Controls.Add(Me.btAnnuler)
        Me.Controls.Add(Me.btCreer)
        Me.Controls.Add(Me.tbMethodePaie)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbNoCompte)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbMethodeCom)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbAddCour)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbLeadTime)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbNomCont)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbTel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbAdres2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbAdres1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbNomFour)
        Me.Controls.Add(Me.Label2)
        Me.MaximumSize = New System.Drawing.Size(279, 580)
        Me.MinimumSize = New System.Drawing.Size(279, 580)
        Me.Name = "CreerFour"
        Me.Text = "CreerFour"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btAnnuler As Button
    Friend WithEvents btCreer As Button
    Friend WithEvents tbMethodePaie As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbNoCompte As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbMethodeCom As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbAddCour As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbLeadTime As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbNomCont As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbTel As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbAdres2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbAdres1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbNomFour As TextBox
    Friend WithEvents Label2 As Label
End Class
