<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class creerProduit
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
        Me.nudMinInv = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btAnnul = New System.Windows.Forms.Button()
        Me.cbUse = New System.Windows.Forms.CheckBox()
        Me.btSauv = New System.Windows.Forms.Button()
        Me.nudCoutUn = New System.Windows.Forms.NumericUpDown()
        Me.nudEnCommende = New System.Windows.Forms.NumericUpDown()
        Me.tbDescription = New System.Windows.Forms.TextBox()
        Me.nudQuantite = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbEmplacement = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbIDPro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btListeFour = New System.Windows.Forms.Button()
        Me.cbFour = New System.Windows.Forms.ComboBox()
        Me.tbNoMFR = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbNoPieceFour = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.nudMinInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCoutUn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEnCommende, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQuantite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudMinInv
        '
        Me.nudMinInv.Location = New System.Drawing.Point(35, 341)
        Me.nudMinInv.Name = "nudMinInv"
        Me.nudMinInv.Size = New System.Drawing.Size(116, 23)
        Me.nudMinInv.TabIndex = 82
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(35, 323)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(183, 15)
        Me.Label16.TabIndex = 81
        Me.Label16.Text = "Minimun besoin dans l'inventaire"
        '
        'btAnnul
        '
        Me.btAnnul.Location = New System.Drawing.Point(222, 623)
        Me.btAnnul.Name = "btAnnul"
        Me.btAnnul.Size = New System.Drawing.Size(172, 23)
        Me.btAnnul.TabIndex = 80
        Me.btAnnul.Text = "Annuler"
        Me.btAnnul.UseVisualStyleBackColor = True
        '
        'cbUse
        '
        Me.cbUse.AutoSize = True
        Me.cbUse.Checked = True
        Me.cbUse.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbUse.Enabled = False
        Me.cbUse.Location = New System.Drawing.Point(35, 257)
        Me.cbUse.Name = "cbUse"
        Me.cbUse.Size = New System.Drawing.Size(76, 19)
        Me.cbUse.TabIndex = 79
        Me.cbUse.Text = "Est Utilisé"
        Me.cbUse.UseVisualStyleBackColor = True
        '
        'btSauv
        '
        Me.btSauv.Location = New System.Drawing.Point(35, 623)
        Me.btSauv.Name = "btSauv"
        Me.btSauv.Size = New System.Drawing.Size(172, 23)
        Me.btSauv.TabIndex = 78
        Me.btSauv.Text = "Enregistrer"
        Me.btSauv.UseVisualStyleBackColor = True
        '
        'nudCoutUn
        '
        Me.nudCoutUn.DecimalPlaces = 2
        Me.nudCoutUn.Location = New System.Drawing.Point(35, 228)
        Me.nudCoutUn.Name = "nudCoutUn"
        Me.nudCoutUn.Size = New System.Drawing.Size(116, 23)
        Me.nudCoutUn.TabIndex = 77
        '
        'nudEnCommende
        '
        Me.nudEnCommende.Location = New System.Drawing.Point(35, 297)
        Me.nudEnCommende.Name = "nudEnCommende"
        Me.nudEnCommende.Size = New System.Drawing.Size(116, 23)
        Me.nudEnCommende.TabIndex = 76
        '
        'tbDescription
        '
        Me.tbDescription.Location = New System.Drawing.Point(35, 517)
        Me.tbDescription.Multiline = True
        Me.tbDescription.Name = "tbDescription"
        Me.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbDescription.Size = New System.Drawing.Size(359, 100)
        Me.tbDescription.TabIndex = 75
        '
        'nudQuantite
        '
        Me.nudQuantite.Location = New System.Drawing.Point(35, 140)
        Me.nudQuantite.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudQuantite.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.nudQuantite.Name = "nudQuantite"
        Me.nudQuantite.Size = New System.Drawing.Size(116, 23)
        Me.nudQuantite.TabIndex = 74
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 15)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "Quantité"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 499)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 15)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Description"
        '
        'tbEmplacement
        '
        Me.tbEmplacement.Location = New System.Drawing.Point(35, 184)
        Me.tbEmplacement.Name = "tbEmplacement"
        Me.tbEmplacement.Size = New System.Drawing.Size(116, 23)
        Me.tbEmplacement.TabIndex = 71
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 15)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Emplacement"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 15)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Coût Unitaire"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "En Commande"
        '
        'tbNom
        '
        Me.tbNom.Location = New System.Drawing.Point(35, 96)
        Me.tbNom.Name = "tbNom"
        Me.tbNom.Size = New System.Drawing.Size(359, 23)
        Me.tbNom.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 15)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Nom Produit (*)"
        '
        'tbIDPro
        '
        Me.tbIDPro.Location = New System.Drawing.Point(35, 52)
        Me.tbIDPro.Name = "tbIDPro"
        Me.tbIDPro.Size = New System.Drawing.Size(359, 23)
        Me.tbIDPro.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 15)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "ID Produit (*)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 367)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Fournisseur"
        '
        'btListeFour
        '
        Me.btListeFour.Location = New System.Drawing.Point(222, 384)
        Me.btListeFour.Name = "btListeFour"
        Me.btListeFour.Size = New System.Drawing.Size(172, 23)
        Me.btListeFour.TabIndex = 85
        Me.btListeFour.Text = "Liste Détaillé Fournisseur"
        Me.btListeFour.UseVisualStyleBackColor = True
        '
        'cbFour
        '
        Me.cbFour.FormattingEnabled = True
        Me.cbFour.Location = New System.Drawing.Point(35, 385)
        Me.cbFour.Name = "cbFour"
        Me.cbFour.Size = New System.Drawing.Size(172, 23)
        Me.cbFour.TabIndex = 86
        '
        'tbNoMFR
        '
        Me.tbNoMFR.Location = New System.Drawing.Point(35, 473)
        Me.tbNoMFR.Name = "tbNoMFR"
        Me.tbNoMFR.Size = New System.Drawing.Size(359, 23)
        Me.tbNoMFR.TabIndex = 90
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 455)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 15)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "Numéro Manufacturier"
        '
        'tbNoPieceFour
        '
        Me.tbNoPieceFour.Location = New System.Drawing.Point(35, 429)
        Me.tbNoPieceFour.Name = "tbNoPieceFour"
        Me.tbNoPieceFour.Size = New System.Drawing.Size(359, 23)
        Me.tbNoPieceFour.TabIndex = 88
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 411)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 15)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "Numéro Pièce Fournisseur"
        '
        'creerProduit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 650)
        Me.Controls.Add(Me.tbNoMFR)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbNoPieceFour)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbFour)
        Me.Controls.Add(Me.btListeFour)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudMinInv)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btAnnul)
        Me.Controls.Add(Me.cbUse)
        Me.Controls.Add(Me.btSauv)
        Me.Controls.Add(Me.nudCoutUn)
        Me.Controls.Add(Me.nudEnCommende)
        Me.Controls.Add(Me.tbDescription)
        Me.Controls.Add(Me.nudQuantite)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbEmplacement)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbNom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbIDPro)
        Me.Controls.Add(Me.Label1)
        Me.Name = "creerProduit"
        Me.Text = "Créer Nouveau Produit"
        CType(Me.nudMinInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCoutUn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEnCommende, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQuantite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nudMinInv As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents btAnnul As Button
    Friend WithEvents cbUse As CheckBox
    Friend WithEvents btSauv As Button
    Friend WithEvents nudCoutUn As NumericUpDown
    Friend WithEvents nudEnCommende As NumericUpDown
    Friend WithEvents tbDescription As TextBox
    Friend WithEvents nudQuantite As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbEmplacement As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbNom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbIDPro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btListeFour As Button
    Friend WithEvents cbFour As ComboBox
    Friend WithEvents tbNoMFR As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbNoPieceFour As TextBox
    Friend WithEvents Label10 As Label
End Class
