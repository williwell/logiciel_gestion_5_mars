<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListeInvManque
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
        Me.TBIDCl = New System.Windows.Forms.TextBox()
        Me.TBPrenom1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBPrenom2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBNom1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBSexe = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBTel2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBTel1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBNom2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DGVManque = New System.Windows.Forms.DataGridView()
        Me.TBNoFour = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBCoutUn = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TBMin = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TBCommande = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TBEmplacement = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TBQuantite = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TBNomInv = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TBIDInv = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TBMethoCom = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TBCouriel = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TBLeadTime = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TBNomContacte = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TBTelFour = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TBAdresse2 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TBAdresse1 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TBNomFour = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TBIDFour = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TBDevise = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TBNoMFR = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TBDescription = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TBNoCompte = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TBMethodePaiement = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.CBUtilise = New System.Windows.Forms.CheckBox()
        CType(Me.DGVManque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(68, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Info Client"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID"
        '
        'TBIDCl
        '
        Me.TBIDCl.Location = New System.Drawing.Point(68, 173)
        Me.TBIDCl.Name = "TBIDCl"
        Me.TBIDCl.ReadOnly = True
        Me.TBIDCl.Size = New System.Drawing.Size(269, 23)
        Me.TBIDCl.TabIndex = 2
        '
        'TBPrenom1
        '
        Me.TBPrenom1.Location = New System.Drawing.Point(68, 217)
        Me.TBPrenom1.Name = "TBPrenom1"
        Me.TBPrenom1.ReadOnly = True
        Me.TBPrenom1.Size = New System.Drawing.Size(269, 23)
        Me.TBPrenom1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Prénom1"
        '
        'TBPrenom2
        '
        Me.TBPrenom2.Location = New System.Drawing.Point(68, 305)
        Me.TBPrenom2.Name = "TBPrenom2"
        Me.TBPrenom2.ReadOnly = True
        Me.TBPrenom2.Size = New System.Drawing.Size(269, 23)
        Me.TBPrenom2.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Prenom2"
        '
        'TBNom1
        '
        Me.TBNom1.Location = New System.Drawing.Point(68, 261)
        Me.TBNom1.Name = "TBNom1"
        Me.TBNom1.ReadOnly = True
        Me.TBNom1.Size = New System.Drawing.Size(269, 23)
        Me.TBNom1.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nom1"
        '
        'TBSexe
        '
        Me.TBSexe.Location = New System.Drawing.Point(68, 481)
        Me.TBSexe.Name = "TBSexe"
        Me.TBSexe.ReadOnly = True
        Me.TBSexe.Size = New System.Drawing.Size(269, 23)
        Me.TBSexe.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(68, 463)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Sexe"
        '
        'TBTel2
        '
        Me.TBTel2.Location = New System.Drawing.Point(68, 437)
        Me.TBTel2.Name = "TBTel2"
        Me.TBTel2.ReadOnly = True
        Me.TBTel2.Size = New System.Drawing.Size(269, 23)
        Me.TBTel2.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(68, 419)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Téléphone2"
        '
        'TBTel1
        '
        Me.TBTel1.Location = New System.Drawing.Point(68, 393)
        Me.TBTel1.Name = "TBTel1"
        Me.TBTel1.ReadOnly = True
        Me.TBTel1.Size = New System.Drawing.Size(269, 23)
        Me.TBTel1.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(68, 375)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Téléphone1"
        '
        'TBNom2
        '
        Me.TBNom2.Location = New System.Drawing.Point(68, 349)
        Me.TBNom2.Name = "TBNom2"
        Me.TBNom2.ReadOnly = True
        Me.TBNom2.Size = New System.Drawing.Size(269, 23)
        Me.TBNom2.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(68, 331)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 15)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Nom2"
        '
        'TBEmail
        '
        Me.TBEmail.Location = New System.Drawing.Point(68, 525)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.ReadOnly = True
        Me.TBEmail.Size = New System.Drawing.Size(269, 23)
        Me.TBEmail.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(68, 507)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Email"
        '
        'DGVManque
        '
        Me.DGVManque.AllowUserToAddRows = False
        Me.DGVManque.AllowUserToDeleteRows = False
        Me.DGVManque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVManque.Location = New System.Drawing.Point(944, 173)
        Me.DGVManque.Name = "DGVManque"
        Me.DGVManque.ReadOnly = True
        Me.DGVManque.RowTemplate.Height = 25
        Me.DGVManque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVManque.Size = New System.Drawing.Size(441, 463)
        Me.DGVManque.TabIndex = 20
        '
        'TBNoFour
        '
        Me.TBNoFour.Location = New System.Drawing.Point(368, 525)
        Me.TBNoFour.Name = "TBNoFour"
        Me.TBNoFour.ReadOnly = True
        Me.TBNoFour.Size = New System.Drawing.Size(269, 23)
        Me.TBNoFour.TabIndex = 39
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(368, 507)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 15)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Numéro Fournisseur"
        '
        'TBCoutUn
        '
        Me.TBCoutUn.Location = New System.Drawing.Point(368, 481)
        Me.TBCoutUn.Name = "TBCoutUn"
        Me.TBCoutUn.ReadOnly = True
        Me.TBCoutUn.Size = New System.Drawing.Size(149, 23)
        Me.TBCoutUn.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(368, 463)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 15)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Cout Unitaire"
        '
        'TBMin
        '
        Me.TBMin.Location = New System.Drawing.Point(368, 437)
        Me.TBMin.Name = "TBMin"
        Me.TBMin.ReadOnly = True
        Me.TBMin.Size = New System.Drawing.Size(269, 23)
        Me.TBMin.TabIndex = 35
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(368, 419)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 15)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Stock Minimun"
        '
        'TBCommande
        '
        Me.TBCommande.Location = New System.Drawing.Point(368, 393)
        Me.TBCommande.Name = "TBCommande"
        Me.TBCommande.ReadOnly = True
        Me.TBCommande.Size = New System.Drawing.Size(269, 23)
        Me.TBCommande.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(368, 375)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 15)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "En Commande"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(368, 331)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 15)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Utilisé"
        '
        'TBEmplacement
        '
        Me.TBEmplacement.Location = New System.Drawing.Point(368, 305)
        Me.TBEmplacement.Name = "TBEmplacement"
        Me.TBEmplacement.ReadOnly = True
        Me.TBEmplacement.Size = New System.Drawing.Size(269, 23)
        Me.TBEmplacement.TabIndex = 29
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(368, 287)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 15)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Emplacement"
        '
        'TBQuantite
        '
        Me.TBQuantite.Location = New System.Drawing.Point(368, 261)
        Me.TBQuantite.Name = "TBQuantite"
        Me.TBQuantite.ReadOnly = True
        Me.TBQuantite.Size = New System.Drawing.Size(269, 23)
        Me.TBQuantite.TabIndex = 27
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(368, 243)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 15)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Quantité"
        '
        'TBNomInv
        '
        Me.TBNomInv.Location = New System.Drawing.Point(368, 217)
        Me.TBNomInv.Name = "TBNomInv"
        Me.TBNomInv.ReadOnly = True
        Me.TBNomInv.Size = New System.Drawing.Size(269, 23)
        Me.TBNomInv.TabIndex = 25
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(368, 199)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 15)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Nom"
        '
        'TBIDInv
        '
        Me.TBIDInv.Location = New System.Drawing.Point(368, 173)
        Me.TBIDInv.Name = "TBIDInv"
        Me.TBIDInv.ReadOnly = True
        Me.TBIDInv.Size = New System.Drawing.Size(269, 23)
        Me.TBIDInv.TabIndex = 23
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(368, 155)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(18, 15)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "ID"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label20.Location = New System.Drawing.Point(368, 61)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(95, 25)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "Info Pièce"
        '
        'TBMethoCom
        '
        Me.TBMethoCom.Location = New System.Drawing.Point(656, 525)
        Me.TBMethoCom.Name = "TBMethoCom"
        Me.TBMethoCom.ReadOnly = True
        Me.TBMethoCom.Size = New System.Drawing.Size(269, 23)
        Me.TBMethoCom.TabIndex = 58
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(656, 507)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(121, 15)
        Me.Label21.TabIndex = 57
        Me.Label21.Text = "Méthode Commande"
        '
        'TBCouriel
        '
        Me.TBCouriel.Location = New System.Drawing.Point(656, 481)
        Me.TBCouriel.Name = "TBCouriel"
        Me.TBCouriel.ReadOnly = True
        Me.TBCouriel.Size = New System.Drawing.Size(269, 23)
        Me.TBCouriel.TabIndex = 56
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(656, 463)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 15)
        Me.Label22.TabIndex = 55
        Me.Label22.Text = "Couriel"
        '
        'TBLeadTime
        '
        Me.TBLeadTime.Location = New System.Drawing.Point(656, 437)
        Me.TBLeadTime.Name = "TBLeadTime"
        Me.TBLeadTime.ReadOnly = True
        Me.TBLeadTime.Size = New System.Drawing.Size(269, 23)
        Me.TBLeadTime.TabIndex = 54
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(656, 419)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 15)
        Me.Label23.TabIndex = 53
        Me.Label23.Text = "Lead Time"
        '
        'TBNomContacte
        '
        Me.TBNomContacte.Location = New System.Drawing.Point(656, 393)
        Me.TBNomContacte.Name = "TBNomContacte"
        Me.TBNomContacte.ReadOnly = True
        Me.TBNomContacte.Size = New System.Drawing.Size(269, 23)
        Me.TBNomContacte.TabIndex = 52
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(656, 375)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(85, 15)
        Me.Label24.TabIndex = 51
        Me.Label24.Text = "Nom Contacte"
        '
        'TBTelFour
        '
        Me.TBTelFour.Location = New System.Drawing.Point(656, 349)
        Me.TBTelFour.Name = "TBTelFour"
        Me.TBTelFour.ReadOnly = True
        Me.TBTelFour.Size = New System.Drawing.Size(269, 23)
        Me.TBTelFour.TabIndex = 50
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(656, 331)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(61, 15)
        Me.Label25.TabIndex = 49
        Me.Label25.Text = "Téléphone"
        '
        'TBAdresse2
        '
        Me.TBAdresse2.Location = New System.Drawing.Point(656, 305)
        Me.TBAdresse2.Name = "TBAdresse2"
        Me.TBAdresse2.ReadOnly = True
        Me.TBAdresse2.Size = New System.Drawing.Size(269, 23)
        Me.TBAdresse2.TabIndex = 48
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(656, 287)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(54, 15)
        Me.Label26.TabIndex = 47
        Me.Label26.Text = "Adresse2"
        '
        'TBAdresse1
        '
        Me.TBAdresse1.Location = New System.Drawing.Point(656, 261)
        Me.TBAdresse1.Name = "TBAdresse1"
        Me.TBAdresse1.ReadOnly = True
        Me.TBAdresse1.Size = New System.Drawing.Size(269, 23)
        Me.TBAdresse1.TabIndex = 46
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(656, 243)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(61, 15)
        Me.Label27.TabIndex = 45
        Me.Label27.Text = "Addresse1"
        '
        'TBNomFour
        '
        Me.TBNomFour.Location = New System.Drawing.Point(656, 217)
        Me.TBNomFour.Name = "TBNomFour"
        Me.TBNomFour.ReadOnly = True
        Me.TBNomFour.Size = New System.Drawing.Size(269, 23)
        Me.TBNomFour.TabIndex = 44
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(656, 199)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(34, 15)
        Me.Label28.TabIndex = 43
        Me.Label28.Text = "Nom"
        '
        'TBIDFour
        '
        Me.TBIDFour.Location = New System.Drawing.Point(656, 173)
        Me.TBIDFour.Name = "TBIDFour"
        Me.TBIDFour.ReadOnly = True
        Me.TBIDFour.Size = New System.Drawing.Size(269, 23)
        Me.TBIDFour.TabIndex = 42
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(656, 155)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(18, 15)
        Me.Label29.TabIndex = 41
        Me.Label29.Text = "ID"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label30.Location = New System.Drawing.Point(656, 61)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(148, 25)
        Me.Label30.TabIndex = 40
        Me.Label30.Text = "Info Fournisseur"
        '
        'TBDevise
        '
        Me.TBDevise.Location = New System.Drawing.Point(523, 481)
        Me.TBDevise.Name = "TBDevise"
        Me.TBDevise.ReadOnly = True
        Me.TBDevise.Size = New System.Drawing.Size(41, 23)
        Me.TBDevise.TabIndex = 60
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(523, 463)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(41, 15)
        Me.Label31.TabIndex = 59
        Me.Label31.Text = "Devise"
        '
        'TBNoMFR
        '
        Me.TBNoMFR.Location = New System.Drawing.Point(368, 569)
        Me.TBNoMFR.Name = "TBNoMFR"
        Me.TBNoMFR.ReadOnly = True
        Me.TBNoMFR.Size = New System.Drawing.Size(269, 23)
        Me.TBNoMFR.TabIndex = 62
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(368, 551)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(78, 15)
        Me.Label32.TabIndex = 61
        Me.Label32.Text = "Numéro MFR"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(656, 129)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(269, 23)
        Me.ComboBox1.TabIndex = 63
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(656, 111)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(136, 15)
        Me.Label33.TabIndex = 64
        Me.Label33.Text = "Sélectionner Fournisseur"
        '
        'TBDescription
        '
        Me.TBDescription.Location = New System.Drawing.Point(368, 613)
        Me.TBDescription.Multiline = True
        Me.TBDescription.Name = "TBDescription"
        Me.TBDescription.ReadOnly = True
        Me.TBDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TBDescription.Size = New System.Drawing.Size(269, 100)
        Me.TBDescription.TabIndex = 65
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(368, 595)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(67, 15)
        Me.Label34.TabIndex = 66
        Me.Label34.Text = "Description"
        '
        'TBNoCompte
        '
        Me.TBNoCompte.Location = New System.Drawing.Point(656, 569)
        Me.TBNoCompte.Name = "TBNoCompte"
        Me.TBNoCompte.ReadOnly = True
        Me.TBNoCompte.Size = New System.Drawing.Size(269, 23)
        Me.TBNoCompte.TabIndex = 68
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(656, 551)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(97, 15)
        Me.Label35.TabIndex = 67
        Me.Label35.Text = "Numéro Compte"
        '
        'TBMethodePaiement
        '
        Me.TBMethodePaiement.Location = New System.Drawing.Point(656, 613)
        Me.TBMethodePaiement.Name = "TBMethodePaiement"
        Me.TBMethodePaiement.ReadOnly = True
        Me.TBMethodePaiement.Size = New System.Drawing.Size(269, 23)
        Me.TBMethodePaiement.TabIndex = 70
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(656, 595)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(108, 15)
        Me.Label36.TabIndex = 69
        Me.Label36.Text = "Méthode Paiement"
        '
        'CBUtilise
        '
        Me.CBUtilise.AutoSize = True
        Me.CBUtilise.Location = New System.Drawing.Point(371, 353)
        Me.CBUtilise.Name = "CBUtilise"
        Me.CBUtilise.Size = New System.Drawing.Size(45, 19)
        Me.CBUtilise.TabIndex = 71
        Me.CBUtilise.Text = "Oui"
        Me.CBUtilise.UseVisualStyleBackColor = True
        '
        'ListeInvManque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1397, 736)
        Me.Controls.Add(Me.CBUtilise)
        Me.Controls.Add(Me.TBMethodePaiement)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.TBNoCompte)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.TBDescription)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TBNoMFR)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.TBDevise)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.TBMethoCom)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.TBCouriel)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TBLeadTime)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.TBNomContacte)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.TBTelFour)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.TBAdresse2)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.TBAdresse1)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.TBNomFour)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.TBIDFour)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.TBNoFour)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TBCoutUn)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TBMin)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TBCommande)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TBEmplacement)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TBQuantite)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TBNomInv)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TBIDInv)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.DGVManque)
        Me.Controls.Add(Me.TBEmail)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TBSexe)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBTel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TBTel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TBNom2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TBPrenom2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBNom1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBPrenom1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBIDCl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ListeInvManque"
        Me.Text = "ListeInvManque"
        CType(Me.DGVManque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TBIDCl As TextBox
    Friend WithEvents TBPrenom1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBPrenom2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBNom1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBSexe As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBTel2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBTel1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBNom2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DGVManque As DataGridView
    Friend WithEvents TBNoFour As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TBCoutUn As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TBMin As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TBCommande As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TBEmplacement As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TBQuantite As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TBNomInv As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TBIDInv As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TBMethoCom As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TBCouriel As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TBLeadTime As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TBNomContacte As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TBTelFour As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TBAdresse2 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TBAdresse1 As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents TBNomFour As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents TBIDFour As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents TBDevise As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents TBNoMFR As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label33 As Label
    Friend WithEvents TBDescription As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents TBNoCompte As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents TBMethodePaiement As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents CBUtilise As CheckBox
End Class
