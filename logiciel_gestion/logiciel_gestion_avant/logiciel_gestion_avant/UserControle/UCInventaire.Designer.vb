<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCInventaire
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbIDPro = New System.Windows.Forms.TextBox()
        Me.tbNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbEmplacement = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbIDFour = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nudQuantite = New System.Windows.Forms.NumericUpDown()
        Me.tbDescription = New System.Windows.Forms.TextBox()
        Me.labPasItem = New System.Windows.Forms.Label()
        Me.nudEnCommende = New System.Windows.Forms.NumericUpDown()
        Me.nudCoutUn = New System.Windows.Forms.NumericUpDown()
        Me.btSauv = New System.Windows.Forms.Button()
        Me.btRecherche = New System.Windows.Forms.Button()
        Me.cbUse = New System.Windows.Forms.CheckBox()
        Me.btAnnulMod = New System.Windows.Forms.Button()
        Me.tbNomFour = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbAdres2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbAdres1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbCouriel = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbLeepTime = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbNomConc = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbTel = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbMethoPaie = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbNoCompte = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbMetCom = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.nudMinInv = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btCreer = New System.Windows.Forms.Button()
        Me.tbNoMFR = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tbNoFour = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbNoFour = New System.Windows.Forms.ComboBox()
        Me.btRemoveFour = New System.Windows.Forms.Button()
        Me.btAddFour = New System.Windows.Forms.Button()
        CType(Me.nudQuantite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEnCommende, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCoutUn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinInv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Produit"
        '
        'tbIDPro
        '
        Me.tbIDPro.Location = New System.Drawing.Point(41, 72)
        Me.tbIDPro.Name = "tbIDPro"
        Me.tbIDPro.Size = New System.Drawing.Size(359, 23)
        Me.tbIDPro.TabIndex = 0
        '
        'tbNom
        '
        Me.tbNom.Location = New System.Drawing.Point(41, 116)
        Me.tbNom.Name = "tbNom"
        Me.tbNom.ReadOnly = True
        Me.tbNom.Size = New System.Drawing.Size(359, 23)
        Me.tbNom.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nom Produit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(422, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID Fournisseur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "En Commande"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Coût Unitaire"
        '
        'tbEmplacement
        '
        Me.tbEmplacement.Location = New System.Drawing.Point(41, 204)
        Me.tbEmplacement.Name = "tbEmplacement"
        Me.tbEmplacement.ReadOnly = True
        Me.tbEmplacement.Size = New System.Drawing.Size(116, 23)
        Me.tbEmplacement.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Emplacement"
        '
        'tbIDFour
        '
        Me.tbIDFour.Location = New System.Drawing.Point(422, 126)
        Me.tbIDFour.Name = "tbIDFour"
        Me.tbIDFour.ReadOnly = True
        Me.tbIDFour.Size = New System.Drawing.Size(209, 23)
        Me.tbIDFour.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(41, 476)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Description"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(41, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Quantité"
        '
        'nudQuantite
        '
        Me.nudQuantite.Location = New System.Drawing.Point(41, 160)
        Me.nudQuantite.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudQuantite.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.nudQuantite.Name = "nudQuantite"
        Me.nudQuantite.ReadOnly = True
        Me.nudQuantite.Size = New System.Drawing.Size(116, 23)
        Me.nudQuantite.TabIndex = 2
        '
        'tbDescription
        '
        Me.tbDescription.Location = New System.Drawing.Point(41, 494)
        Me.tbDescription.Multiline = True
        Me.tbDescription.Name = "tbDescription"
        Me.tbDescription.ReadOnly = True
        Me.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbDescription.Size = New System.Drawing.Size(359, 100)
        Me.tbDescription.TabIndex = 10
        '
        'labPasItem
        '
        Me.labPasItem.AutoSize = True
        Me.labPasItem.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labPasItem.ForeColor = System.Drawing.Color.Red
        Me.labPasItem.Location = New System.Drawing.Point(422, 18)
        Me.labPasItem.Name = "labPasItem"
        Me.labPasItem.Size = New System.Drawing.Size(0, 28)
        Me.labPasItem.TabIndex = 35
        '
        'nudEnCommende
        '
        Me.nudEnCommende.Location = New System.Drawing.Point(41, 317)
        Me.nudEnCommende.Name = "nudEnCommende"
        Me.nudEnCommende.ReadOnly = True
        Me.nudEnCommende.Size = New System.Drawing.Size(116, 23)
        Me.nudEnCommende.TabIndex = 6
        '
        'nudCoutUn
        '
        Me.nudCoutUn.Location = New System.Drawing.Point(41, 248)
        Me.nudCoutUn.Name = "nudCoutUn"
        Me.nudCoutUn.ReadOnly = True
        Me.nudCoutUn.Size = New System.Drawing.Size(116, 23)
        Me.nudCoutUn.TabIndex = 4
        '
        'btSauv
        '
        Me.btSauv.Enabled = False
        Me.btSauv.Location = New System.Drawing.Point(41, 600)
        Me.btSauv.Name = "btSauv"
        Me.btSauv.Size = New System.Drawing.Size(172, 23)
        Me.btSauv.TabIndex = 11
        Me.btSauv.Text = "Enregistrer"
        Me.btSauv.UseVisualStyleBackColor = True
        '
        'btRecherche
        '
        Me.btRecherche.Location = New System.Drawing.Point(40, 18)
        Me.btRecherche.Name = "btRecherche"
        Me.btRecherche.Size = New System.Drawing.Size(172, 23)
        Me.btRecherche.TabIndex = 27
        Me.btRecherche.Text = "Recherche Produit"
        Me.btRecherche.UseVisualStyleBackColor = True
        '
        'cbUse
        '
        Me.cbUse.AutoSize = True
        Me.cbUse.Enabled = False
        Me.cbUse.Location = New System.Drawing.Point(41, 277)
        Me.cbUse.Name = "cbUse"
        Me.cbUse.Size = New System.Drawing.Size(76, 19)
        Me.cbUse.TabIndex = 5
        Me.cbUse.Text = "Est Utilisé"
        Me.cbUse.UseVisualStyleBackColor = True
        '
        'btAnnulMod
        '
        Me.btAnnulMod.Enabled = False
        Me.btAnnulMod.Location = New System.Drawing.Point(228, 600)
        Me.btAnnulMod.Name = "btAnnulMod"
        Me.btAnnulMod.Size = New System.Drawing.Size(172, 23)
        Me.btAnnulMod.TabIndex = 12
        Me.btAnnulMod.Text = "Annuler Modification"
        Me.btAnnulMod.UseVisualStyleBackColor = True
        '
        'tbNomFour
        '
        Me.tbNomFour.Location = New System.Drawing.Point(422, 170)
        Me.tbNomFour.Name = "tbNomFour"
        Me.tbNomFour.ReadOnly = True
        Me.tbNomFour.Size = New System.Drawing.Size(209, 23)
        Me.tbNomFour.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(422, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 15)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Nom Fournisseur"
        '
        'tbAdres2
        '
        Me.tbAdres2.Location = New System.Drawing.Point(422, 258)
        Me.tbAdres2.Name = "tbAdres2"
        Me.tbAdres2.ReadOnly = True
        Me.tbAdres2.Size = New System.Drawing.Size(209, 23)
        Me.tbAdres2.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(422, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 15)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Adresse 2"
        '
        'tbAdres1
        '
        Me.tbAdres1.Location = New System.Drawing.Point(422, 214)
        Me.tbAdres1.Name = "tbAdres1"
        Me.tbAdres1.ReadOnly = True
        Me.tbAdres1.Size = New System.Drawing.Size(209, 23)
        Me.tbAdres1.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(422, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 15)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Adresse 1"
        '
        'tbCouriel
        '
        Me.tbCouriel.Location = New System.Drawing.Point(422, 434)
        Me.tbCouriel.Name = "tbCouriel"
        Me.tbCouriel.ReadOnly = True
        Me.tbCouriel.Size = New System.Drawing.Size(209, 23)
        Me.tbCouriel.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(422, 416)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 15)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "Couriel"
        '
        'tbLeepTime
        '
        Me.tbLeepTime.Location = New System.Drawing.Point(422, 390)
        Me.tbLeepTime.Name = "tbLeepTime"
        Me.tbLeepTime.ReadOnly = True
        Me.tbLeepTime.Size = New System.Drawing.Size(209, 23)
        Me.tbLeepTime.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(422, 372)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(209, 15)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Temps d'arriver normal pour les pièces"
        '
        'tbNomConc
        '
        Me.tbNomConc.Location = New System.Drawing.Point(422, 346)
        Me.tbNomConc.Name = "tbNomConc"
        Me.tbNomConc.ReadOnly = True
        Me.tbNomConc.Size = New System.Drawing.Size(209, 23)
        Me.tbNomConc.TabIndex = 19
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(422, 328)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 15)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "Nom du conctact"
        '
        'tbTel
        '
        Me.tbTel.Location = New System.Drawing.Point(422, 302)
        Me.tbTel.Name = "tbTel"
        Me.tbTel.ReadOnly = True
        Me.tbTel.Size = New System.Drawing.Size(209, 23)
        Me.tbTel.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(422, 284)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 15)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Téléphone"
        '
        'tbMethoPaie
        '
        Me.tbMethoPaie.Location = New System.Drawing.Point(422, 566)
        Me.tbMethoPaie.Name = "tbMethoPaie"
        Me.tbMethoPaie.ReadOnly = True
        Me.tbMethoPaie.Size = New System.Drawing.Size(209, 23)
        Me.tbMethoPaie.TabIndex = 24
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(422, 548)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(124, 15)
        Me.Label19.TabIndex = 60
        Me.Label19.Text = "Méthode de paiement"
        '
        'tbNoCompte
        '
        Me.tbNoCompte.Location = New System.Drawing.Point(422, 522)
        Me.tbNoCompte.Name = "tbNoCompte"
        Me.tbNoCompte.ReadOnly = True
        Me.tbNoCompte.Size = New System.Drawing.Size(209, 23)
        Me.tbNoCompte.TabIndex = 23
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(422, 504)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 15)
        Me.Label17.TabIndex = 58
        Me.Label17.Text = "Numéro de compte"
        '
        'tbMetCom
        '
        Me.tbMetCom.Location = New System.Drawing.Point(422, 478)
        Me.tbMetCom.Name = "tbMetCom"
        Me.tbMetCom.ReadOnly = True
        Me.tbMetCom.Size = New System.Drawing.Size(209, 23)
        Me.tbMetCom.TabIndex = 22
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(422, 460)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(135, 15)
        Me.Label18.TabIndex = 56
        Me.Label18.Text = "Méthode de commande"
        '
        'nudMinInv
        '
        Me.nudMinInv.Location = New System.Drawing.Point(41, 361)
        Me.nudMinInv.Name = "nudMinInv"
        Me.nudMinInv.ReadOnly = True
        Me.nudMinInv.Size = New System.Drawing.Size(116, 23)
        Me.nudMinInv.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(41, 343)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(183, 15)
        Me.Label16.TabIndex = 62
        Me.Label16.Text = "Minimun besoin dans l'inventaire"
        '
        'btCreer
        '
        Me.btCreer.Location = New System.Drawing.Point(218, 18)
        Me.btCreer.Name = "btCreer"
        Me.btCreer.Size = New System.Drawing.Size(173, 23)
        Me.btCreer.TabIndex = 28
        Me.btCreer.Text = "Créer un nouveau produit"
        Me.btCreer.UseVisualStyleBackColor = True
        '
        'tbNoMFR
        '
        Me.tbNoMFR.Location = New System.Drawing.Point(41, 449)
        Me.tbNoMFR.Name = "tbNoMFR"
        Me.tbNoMFR.ReadOnly = True
        Me.tbNoMFR.Size = New System.Drawing.Size(359, 23)
        Me.tbNoMFR.TabIndex = 9
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(41, 431)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(129, 15)
        Me.Label21.TabIndex = 67
        Me.Label21.Text = "Numéro Manufacturier"
        '
        'tbNoFour
        '
        Me.tbNoFour.Location = New System.Drawing.Point(41, 405)
        Me.tbNoFour.Name = "tbNoFour"
        Me.tbNoFour.ReadOnly = True
        Me.tbNoFour.Size = New System.Drawing.Size(359, 23)
        Me.tbNoFour.TabIndex = 8
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(41, 387)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(115, 15)
        Me.Label22.TabIndex = 65
        Me.Label22.Text = "Numéro Fournisseur"
        '
        'cbNoFour
        '
        Me.cbNoFour.FormattingEnabled = True
        Me.cbNoFour.Location = New System.Drawing.Point(422, 72)
        Me.cbNoFour.Name = "cbNoFour"
        Me.cbNoFour.Size = New System.Drawing.Size(209, 23)
        Me.cbNoFour.TabIndex = 13
        '
        'btRemoveFour
        '
        Me.btRemoveFour.Enabled = False
        Me.btRemoveFour.Location = New System.Drawing.Point(666, 125)
        Me.btRemoveFour.Name = "btRemoveFour"
        Me.btRemoveFour.Size = New System.Drawing.Size(124, 23)
        Me.btRemoveFour.TabIndex = 26
        Me.btRemoveFour.Text = "Retirer Fournisseur"
        Me.btRemoveFour.UseVisualStyleBackColor = True
        '
        'btAddFour
        '
        Me.btAddFour.Enabled = False
        Me.btAddFour.Location = New System.Drawing.Point(666, 72)
        Me.btAddFour.Name = "btAddFour"
        Me.btAddFour.Size = New System.Drawing.Size(124, 23)
        Me.btAddFour.TabIndex = 25
        Me.btAddFour.Text = "Ajouter Fournisseur"
        Me.btAddFour.UseVisualStyleBackColor = True
        '
        'UCInventaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btRemoveFour)
        Me.Controls.Add(Me.btAddFour)
        Me.Controls.Add(Me.cbNoFour)
        Me.Controls.Add(Me.tbNoMFR)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.tbNoFour)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.btCreer)
        Me.Controls.Add(Me.nudMinInv)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.tbMethoPaie)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.tbNoCompte)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.tbMetCom)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.tbCouriel)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tbLeepTime)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tbNomConc)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tbTel)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.tbAdres2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbAdres1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbNomFour)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btAnnulMod)
        Me.Controls.Add(Me.cbUse)
        Me.Controls.Add(Me.btRecherche)
        Me.Controls.Add(Me.btSauv)
        Me.Controls.Add(Me.nudCoutUn)
        Me.Controls.Add(Me.nudEnCommende)
        Me.Controls.Add(Me.labPasItem)
        Me.Controls.Add(Me.tbDescription)
        Me.Controls.Add(Me.nudQuantite)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbIDFour)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbEmplacement)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbNom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbIDPro)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UCInventaire"
        Me.Size = New System.Drawing.Size(808, 649)
        CType(Me.nudQuantite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEnCommende, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCoutUn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinInv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbIDPro As TextBox
    Friend WithEvents tbNom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbEmplacement As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbIDFour As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents nudQuantite As NumericUpDown
    Friend WithEvents tbDescription As TextBox
    Friend WithEvents labPasItem As Label
    Friend WithEvents nudEnCommende As NumericUpDown
    Friend WithEvents nudCoutUn As NumericUpDown
    Friend WithEvents btSauv As Button
    Friend WithEvents btRecherche As Button
    Friend WithEvents cbUse As CheckBox
    Friend WithEvents btAnnulMod As Button
    Friend WithEvents tbNomFour As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbAdres2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbAdres1 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbCouriel As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbLeepTime As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tbNomConc As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents tbTel As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tbMethoPaie As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tbNoCompte As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents tbMetCom As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents nudMinInv As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents btCreer As Button
    Friend WithEvents tbNoMFR As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents tbNoFour As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cbNoFour As ComboBox
    Friend WithEvents btRemoveFour As Button
    Friend WithEvents btAddFour As Button
End Class
