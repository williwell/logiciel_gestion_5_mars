<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreerContrat
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
        Me.CBModel = New System.Windows.Forms.ComboBox()
        Me.TBCoutM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBCoulTissus = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBCoulToile = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBCoulVe = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBCoutC = New System.Windows.Forms.TextBox()
        Me.BTVeEx = New System.Windows.Forms.Button()
        Me.BTNouvVe = New System.Windows.Forms.Button()
        Me.DGVOptionCh = New System.Windows.Forms.DataGridView()
        Me.DGVOptionDis = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBTPS = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBTotal = New System.Windows.Forms.TextBox()
        Me.CBTPS = New System.Windows.Forms.CheckBox()
        Me.CBTVQ = New System.Windows.Forms.CheckBox()
        Me.TBTVQ = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBEchange = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TBSousTotal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBAccompte = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TBBalance = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TBPayerLiv = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TBBalEchange = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TBFinancement = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TBRemettreCl = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TBTotalFin = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TBPrenom1 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TBNom1 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TBNom2 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TBPrenom2 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TBTel2 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TBTel1 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TBProvince = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TBVille = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TBAddresse = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TBCodePos = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TBApp = New System.Windows.Forms.TextBox()
        Me.BTNouvCl = New System.Windows.Forms.Button()
        Me.BTClEx = New System.Windows.Forms.Button()
        Me.BTSave = New System.Windows.Forms.Button()
        Me.CBSexe = New System.Windows.Forms.ComboBox()
        Me.BTAnnuler = New System.Windows.Forms.Button()
        Me.DTPLivraison = New System.Windows.Forms.DateTimePicker()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.BTCouleur = New System.Windows.Forms.Button()
        CType(Me.DGVOptionCh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVOptionDis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBModel
        '
        Me.CBModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBModel.FormattingEnabled = True
        Me.CBModel.Location = New System.Drawing.Point(12, 87)
        Me.CBModel.Name = "CBModel"
        Me.CBModel.Size = New System.Drawing.Size(263, 23)
        Me.CBModel.TabIndex = 0
        '
        'TBCoutM
        '
        Me.TBCoutM.Location = New System.Drawing.Point(281, 87)
        Me.TBCoutM.Name = "TBCoutM"
        Me.TBCoutM.ReadOnly = True
        Me.TBCoutM.Size = New System.Drawing.Size(138, 23)
        Me.TBCoutM.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Model"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(281, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Coût"
        '
        'CBCoulTissus
        '
        Me.CBCoulTissus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCoulTissus.FormattingEnabled = True
        Me.CBCoulTissus.Location = New System.Drawing.Point(12, 219)
        Me.CBCoulTissus.Name = "CBCoulTissus"
        Me.CBCoulTissus.Size = New System.Drawing.Size(263, 23)
        Me.CBCoulTissus.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Couleur Tissus"
        '
        'CBCoulToile
        '
        Me.CBCoulToile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCoulToile.FormattingEnabled = True
        Me.CBCoulToile.Location = New System.Drawing.Point(12, 175)
        Me.CBCoulToile.Name = "CBCoulToile"
        Me.CBCoulToile.Size = New System.Drawing.Size(263, 23)
        Me.CBCoulToile.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Couleur Toile"
        '
        'CBCoulVe
        '
        Me.CBCoulVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCoulVe.FormattingEnabled = True
        Me.CBCoulVe.Location = New System.Drawing.Point(12, 131)
        Me.CBCoulVe.Name = "CBCoulVe"
        Me.CBCoulVe.Size = New System.Drawing.Size(263, 23)
        Me.CBCoulVe.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Couleur Véhicule"
        '
        'TBCoutC
        '
        Me.TBCoutC.Location = New System.Drawing.Point(281, 131)
        Me.TBCoutC.Name = "TBCoutC"
        Me.TBCoutC.ReadOnly = True
        Me.TBCoutC.Size = New System.Drawing.Size(138, 23)
        Me.TBCoutC.TabIndex = 18
        '
        'BTVeEx
        '
        Me.BTVeEx.Location = New System.Drawing.Point(12, 43)
        Me.BTVeEx.Name = "BTVeEx"
        Me.BTVeEx.Size = New System.Drawing.Size(122, 23)
        Me.BTVeEx.TabIndex = 19
        Me.BTVeEx.Text = "Véhicule Existant"
        Me.BTVeEx.UseVisualStyleBackColor = True
        '
        'BTNouvVe
        '
        Me.BTNouvVe.Enabled = False
        Me.BTNouvVe.Location = New System.Drawing.Point(153, 43)
        Me.BTNouvVe.Name = "BTNouvVe"
        Me.BTNouvVe.Size = New System.Drawing.Size(122, 23)
        Me.BTNouvVe.TabIndex = 20
        Me.BTNouvVe.Text = "Nouveau Véhicule"
        Me.BTNouvVe.UseVisualStyleBackColor = True
        '
        'DGVOptionCh
        '
        Me.DGVOptionCh.AllowUserToAddRows = False
        Me.DGVOptionCh.AllowUserToDeleteRows = False
        Me.DGVOptionCh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOptionCh.Location = New System.Drawing.Point(12, 332)
        Me.DGVOptionCh.Name = "DGVOptionCh"
        Me.DGVOptionCh.ReadOnly = True
        Me.DGVOptionCh.RowTemplate.Height = 25
        Me.DGVOptionCh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVOptionCh.Size = New System.Drawing.Size(636, 226)
        Me.DGVOptionCh.TabIndex = 21
        '
        'DGVOptionDis
        '
        Me.DGVOptionDis.AllowUserToAddRows = False
        Me.DGVOptionDis.AllowUserToDeleteRows = False
        Me.DGVOptionDis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOptionDis.Location = New System.Drawing.Point(654, 332)
        Me.DGVOptionDis.Name = "DGVOptionDis"
        Me.DGVOptionDis.ReadOnly = True
        Me.DGVOptionDis.RowTemplate.Height = 25
        Me.DGVOptionDis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVOptionDis.Size = New System.Drawing.Size(636, 226)
        Me.DGVOptionDis.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Option Choisis"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(654, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 15)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Option Disponible"
        '
        'TBTPS
        '
        Me.TBTPS.Location = New System.Drawing.Point(220, 615)
        Me.TBTPS.Name = "TBTPS"
        Me.TBTPS.ReadOnly = True
        Me.TBTPS.Size = New System.Drawing.Size(138, 23)
        Me.TBTPS.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 591)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 15)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Total"
        '
        'TBTotal
        '
        Me.TBTotal.Location = New System.Drawing.Point(20, 609)
        Me.TBTotal.Name = "TBTotal"
        Me.TBTotal.ReadOnly = True
        Me.TBTotal.Size = New System.Drawing.Size(138, 23)
        Me.TBTotal.TabIndex = 25
        '
        'CBTPS
        '
        Me.CBTPS.AutoSize = True
        Me.CBTPS.Checked = True
        Me.CBTPS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBTPS.Location = New System.Drawing.Point(220, 590)
        Me.CBTPS.Name = "CBTPS"
        Me.CBTPS.Size = New System.Drawing.Size(45, 19)
        Me.CBTPS.TabIndex = 28
        Me.CBTPS.Text = "TPS"
        Me.CBTPS.UseVisualStyleBackColor = True
        '
        'CBTVQ
        '
        Me.CBTVQ.AutoSize = True
        Me.CBTVQ.Checked = True
        Me.CBTVQ.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBTVQ.Location = New System.Drawing.Point(220, 644)
        Me.CBTVQ.Name = "CBTVQ"
        Me.CBTVQ.Size = New System.Drawing.Size(48, 19)
        Me.CBTVQ.TabIndex = 30
        Me.CBTVQ.Text = "TVQ"
        Me.CBTVQ.UseVisualStyleBackColor = True
        '
        'TBTVQ
        '
        Me.TBTVQ.Location = New System.Drawing.Point(220, 669)
        Me.TBTVQ.Name = "TBTVQ"
        Me.TBTVQ.ReadOnly = True
        Me.TBTVQ.Size = New System.Drawing.Size(138, 23)
        Me.TBTVQ.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 635)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 15)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Échange"
        '
        'TBEchange
        '
        Me.TBEchange.Location = New System.Drawing.Point(20, 653)
        Me.TBEchange.Name = "TBEchange"
        Me.TBEchange.Size = New System.Drawing.Size(138, 23)
        Me.TBEchange.TabIndex = 31
        Me.TBEchange.Text = "0,00$"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 679)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 15)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Sous-Total"
        '
        'TBSousTotal
        '
        Me.TBSousTotal.Location = New System.Drawing.Point(20, 697)
        Me.TBSousTotal.Name = "TBSousTotal"
        Me.TBSousTotal.ReadOnly = True
        Me.TBSousTotal.Size = New System.Drawing.Size(138, 23)
        Me.TBSousTotal.TabIndex = 33
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(428, 635)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 15)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Acompte"
        '
        'TBAccompte
        '
        Me.TBAccompte.Location = New System.Drawing.Point(428, 653)
        Me.TBAccompte.Name = "TBAccompte"
        Me.TBAccompte.Size = New System.Drawing.Size(138, 23)
        Me.TBAccompte.TabIndex = 35
        Me.TBAccompte.Text = "0,00$"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(428, 679)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 15)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Balance"
        '
        'TBBalance
        '
        Me.TBBalance.Location = New System.Drawing.Point(428, 697)
        Me.TBBalance.Name = "TBBalance"
        Me.TBBalance.ReadOnly = True
        Me.TBBalance.Size = New System.Drawing.Size(138, 23)
        Me.TBBalance.TabIndex = 37
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(634, 591)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 15)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Payer Livraison"
        '
        'TBPayerLiv
        '
        Me.TBPayerLiv.Location = New System.Drawing.Point(634, 609)
        Me.TBPayerLiv.Name = "TBPayerLiv"
        Me.TBPayerLiv.Size = New System.Drawing.Size(138, 23)
        Me.TBPayerLiv.TabIndex = 39
        Me.TBPayerLiv.Text = "0,00$"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(634, 635)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 15)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "Balance Échange"
        '
        'TBBalEchange
        '
        Me.TBBalEchange.Location = New System.Drawing.Point(634, 653)
        Me.TBBalEchange.Name = "TBBalEchange"
        Me.TBBalEchange.Size = New System.Drawing.Size(138, 23)
        Me.TBBalEchange.TabIndex = 41
        Me.TBBalEchange.Text = "0,00$"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(820, 591)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 15)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Financement"
        '
        'TBFinancement
        '
        Me.TBFinancement.Location = New System.Drawing.Point(820, 609)
        Me.TBFinancement.Name = "TBFinancement"
        Me.TBFinancement.ReadOnly = True
        Me.TBFinancement.Size = New System.Drawing.Size(138, 23)
        Me.TBFinancement.TabIndex = 43
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(634, 679)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 15)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "Remettre Client"
        '
        'TBRemettreCl
        '
        Me.TBRemettreCl.Location = New System.Drawing.Point(634, 697)
        Me.TBRemettreCl.Name = "TBRemettreCl"
        Me.TBRemettreCl.Size = New System.Drawing.Size(138, 23)
        Me.TBRemettreCl.TabIndex = 45
        Me.TBRemettreCl.Text = "0,00$"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(428, 591)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 15)
        Me.Label17.TabIndex = 48
        Me.Label17.Text = "Total"
        '
        'TBTotalFin
        '
        Me.TBTotalFin.Location = New System.Drawing.Point(428, 609)
        Me.TBTotalFin.Name = "TBTotalFin"
        Me.TBTotalFin.ReadOnly = True
        Me.TBTotalFin.Size = New System.Drawing.Size(138, 23)
        Me.TBTotalFin.TabIndex = 47
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(592, 69)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 15)
        Me.Label18.TabIndex = 50
        Me.Label18.Text = "Prénom Client 1"
        '
        'TBPrenom1
        '
        Me.TBPrenom1.Location = New System.Drawing.Point(592, 87)
        Me.TBPrenom1.Name = "TBPrenom1"
        Me.TBPrenom1.Size = New System.Drawing.Size(170, 23)
        Me.TBPrenom1.TabIndex = 49
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(592, 113)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 15)
        Me.Label19.TabIndex = 52
        Me.Label19.Text = "Nom Client 1"
        '
        'TBNom1
        '
        Me.TBNom1.Location = New System.Drawing.Point(592, 131)
        Me.TBNom1.Name = "TBNom1"
        Me.TBNom1.Size = New System.Drawing.Size(170, 23)
        Me.TBNom1.TabIndex = 51
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(768, 113)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(77, 15)
        Me.Label20.TabIndex = 56
        Me.Label20.Text = "Nom Client 2"
        '
        'TBNom2
        '
        Me.TBNom2.Location = New System.Drawing.Point(768, 131)
        Me.TBNom2.Name = "TBNom2"
        Me.TBNom2.Size = New System.Drawing.Size(170, 23)
        Me.TBNom2.TabIndex = 55
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(768, 69)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(92, 15)
        Me.Label21.TabIndex = 54
        Me.Label21.Text = "Prénom Client 2"
        '
        'TBPrenom2
        '
        Me.TBPrenom2.Location = New System.Drawing.Point(768, 87)
        Me.TBPrenom2.Name = "TBPrenom2"
        Me.TBPrenom2.Size = New System.Drawing.Size(170, 23)
        Me.TBPrenom2.TabIndex = 53
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(592, 201)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(70, 15)
        Me.Label22.TabIndex = 60
        Me.Label22.Text = "Téléphone 2"
        '
        'TBTel2
        '
        Me.TBTel2.Location = New System.Drawing.Point(592, 219)
        Me.TBTel2.Name = "TBTel2"
        Me.TBTel2.Size = New System.Drawing.Size(170, 23)
        Me.TBTel2.TabIndex = 59
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(592, 157)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(70, 15)
        Me.Label23.TabIndex = 58
        Me.Label23.Text = "Téléphone 1"
        '
        'TBTel1
        '
        Me.TBTel1.Location = New System.Drawing.Point(592, 175)
        Me.TBTel1.Name = "TBTel1"
        Me.TBTel1.Size = New System.Drawing.Size(170, 23)
        Me.TBTel1.TabIndex = 57
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(768, 201)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(36, 15)
        Me.Label24.TabIndex = 64
        Me.Label24.Text = "Email"
        '
        'TBEmail
        '
        Me.TBEmail.Location = New System.Drawing.Point(768, 219)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(170, 23)
        Me.TBEmail.TabIndex = 63
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(768, 157)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(31, 15)
        Me.Label25.TabIndex = 62
        Me.Label25.Text = "Sexe"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(944, 157)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(53, 15)
        Me.Label26.TabIndex = 70
        Me.Label26.Text = "Province"
        '
        'TBProvince
        '
        Me.TBProvince.Location = New System.Drawing.Point(944, 175)
        Me.TBProvince.Name = "TBProvince"
        Me.TBProvince.Size = New System.Drawing.Size(170, 23)
        Me.TBProvince.TabIndex = 69
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(944, 113)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(29, 15)
        Me.Label27.TabIndex = 68
        Me.Label27.Text = "Ville"
        '
        'TBVille
        '
        Me.TBVille.Location = New System.Drawing.Point(944, 131)
        Me.TBVille.Name = "TBVille"
        Me.TBVille.Size = New System.Drawing.Size(170, 23)
        Me.TBVille.TabIndex = 67
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(944, 69)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(48, 15)
        Me.Label28.TabIndex = 66
        Me.Label28.Text = "Adresse"
        '
        'TBAddresse
        '
        Me.TBAddresse.Location = New System.Drawing.Point(944, 87)
        Me.TBAddresse.Name = "TBAddresse"
        Me.TBAddresse.Size = New System.Drawing.Size(170, 23)
        Me.TBAddresse.TabIndex = 65
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(1120, 113)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(70, 15)
        Me.Label30.TabIndex = 74
        Me.Label30.Text = "Code Postal"
        '
        'TBCodePos
        '
        Me.TBCodePos.Location = New System.Drawing.Point(1120, 131)
        Me.TBCodePos.Name = "TBCodePos"
        Me.TBCodePos.Size = New System.Drawing.Size(170, 23)
        Me.TBCodePos.TabIndex = 73
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(1120, 69)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(77, 15)
        Me.Label31.TabIndex = 72
        Me.Label31.Text = "Appartement"
        '
        'TBApp
        '
        Me.TBApp.Location = New System.Drawing.Point(1120, 87)
        Me.TBApp.Name = "TBApp"
        Me.TBApp.Size = New System.Drawing.Size(170, 23)
        Me.TBApp.TabIndex = 71
        '
        'BTNouvCl
        '
        Me.BTNouvCl.Enabled = False
        Me.BTNouvCl.Location = New System.Drawing.Point(733, 43)
        Me.BTNouvCl.Name = "BTNouvCl"
        Me.BTNouvCl.Size = New System.Drawing.Size(122, 23)
        Me.BTNouvCl.TabIndex = 76
        Me.BTNouvCl.Text = "Nouveau Client"
        Me.BTNouvCl.UseVisualStyleBackColor = True
        '
        'BTClEx
        '
        Me.BTClEx.Location = New System.Drawing.Point(592, 43)
        Me.BTClEx.Name = "BTClEx"
        Me.BTClEx.Size = New System.Drawing.Size(122, 23)
        Me.BTClEx.TabIndex = 75
        Me.BTClEx.Text = "Client Existant"
        Me.BTClEx.UseVisualStyleBackColor = True
        '
        'BTSave
        '
        Me.BTSave.Location = New System.Drawing.Point(930, 717)
        Me.BTSave.Name = "BTSave"
        Me.BTSave.Size = New System.Drawing.Size(184, 48)
        Me.BTSave.TabIndex = 77
        Me.BTSave.Text = "Enregistrer"
        Me.BTSave.UseVisualStyleBackColor = True
        '
        'CBSexe
        '
        Me.CBSexe.FormattingEnabled = True
        Me.CBSexe.Items.AddRange(New Object() {"Non Déterminé", "Homme", "Femme"})
        Me.CBSexe.Location = New System.Drawing.Point(768, 175)
        Me.CBSexe.Name = "CBSexe"
        Me.CBSexe.Size = New System.Drawing.Size(170, 23)
        Me.CBSexe.TabIndex = 78
        '
        'BTAnnuler
        '
        Me.BTAnnuler.Location = New System.Drawing.Point(1120, 717)
        Me.BTAnnuler.Name = "BTAnnuler"
        Me.BTAnnuler.Size = New System.Drawing.Size(184, 48)
        Me.BTAnnuler.TabIndex = 79
        Me.BTAnnuler.Text = "Annuler"
        Me.BTAnnuler.UseVisualStyleBackColor = True
        '
        'DTPLivraison
        '
        Me.DTPLivraison.Location = New System.Drawing.Point(12, 263)
        Me.DTPLivraison.Name = "DTPLivraison"
        Me.DTPLivraison.Size = New System.Drawing.Size(263, 23)
        Me.DTPLivraison.TabIndex = 80
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(12, 245)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(111, 15)
        Me.Label29.TabIndex = 81
        Me.Label29.Text = "Date prévu livraison"
        '
        'BTCouleur
        '
        Me.BTCouleur.Location = New System.Drawing.Point(281, 218)
        Me.BTCouleur.Name = "BTCouleur"
        Me.BTCouleur.Size = New System.Drawing.Size(138, 23)
        Me.BTCouleur.TabIndex = 82
        Me.BTCouleur.Text = "Ajouter des couleurs"
        Me.BTCouleur.UseVisualStyleBackColor = True
        '
        'CreerContrat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 772)
        Me.Controls.Add(Me.BTCouleur)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.DTPLivraison)
        Me.Controls.Add(Me.BTAnnuler)
        Me.Controls.Add(Me.CBSexe)
        Me.Controls.Add(Me.BTSave)
        Me.Controls.Add(Me.BTNouvCl)
        Me.Controls.Add(Me.BTClEx)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.TBCodePos)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.TBApp)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.TBProvince)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.TBVille)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.TBAddresse)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.TBEmail)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TBTel2)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.TBTel1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TBNom2)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.TBPrenom2)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TBNom1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TBPrenom1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TBTotalFin)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TBRemettreCl)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TBFinancement)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TBBalEchange)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TBPayerLiv)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TBBalance)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TBAccompte)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TBSousTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TBEchange)
        Me.Controls.Add(Me.CBTVQ)
        Me.Controls.Add(Me.TBTVQ)
        Me.Controls.Add(Me.CBTPS)
        Me.Controls.Add(Me.TBTPS)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TBTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DGVOptionDis)
        Me.Controls.Add(Me.DGVOptionCh)
        Me.Controls.Add(Me.BTNouvVe)
        Me.Controls.Add(Me.BTVeEx)
        Me.Controls.Add(Me.TBCoutC)
        Me.Controls.Add(Me.CBCoulTissus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBCoulToile)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBCoulVe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBCoutM)
        Me.Controls.Add(Me.CBModel)
        Me.Name = "CreerContrat"
        Me.Text = " Créer Contrat"
        CType(Me.DGVOptionCh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVOptionDis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBModel As ComboBox
    Friend WithEvents TBCoutM As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CBCoulTissus As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CBCoulToile As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CBCoulVe As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBCoutC As TextBox
    Friend WithEvents BTVeEx As Button
    Friend WithEvents BTNouvVe As Button
    Friend WithEvents DGVOptionCh As DataGridView
    Friend WithEvents DGVOptionDis As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TBTPS As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBTotal As TextBox
    Friend WithEvents CBTPS As CheckBox
    Friend WithEvents CBTVQ As CheckBox
    Friend WithEvents TBTVQ As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TBEchange As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TBSousTotal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TBAccompte As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TBBalance As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TBPayerLiv As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TBBalEchange As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TBFinancement As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TBRemettreCl As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TBTotalFin As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TBPrenom1 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TBNom1 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TBNom2 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TBPrenom2 As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TBTel2 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TBTel1 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents TBProvince As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents TBVille As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents TBAddresse As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents TBCodePos As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents TBApp As TextBox
    Friend WithEvents BTNouvCl As Button
    Friend WithEvents BTClEx As Button
    Friend WithEvents BTSave As Button
    Friend WithEvents CBSexe As ComboBox
    Friend WithEvents BTAnnuler As Button
    Friend WithEvents DTPLivraison As DateTimePicker
    Friend WithEvents Label29 As Label
    Friend WithEvents BTCouleur As Button
End Class
