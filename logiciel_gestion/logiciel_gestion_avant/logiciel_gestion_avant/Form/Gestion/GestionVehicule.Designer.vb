<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionVehicule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionVehicule))
        Me.TBMatricule = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBModel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBCoulVe = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBCoulToile = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CBCoulTissus = New System.Windows.Forms.ComboBox()
        Me.DTPPrevu = New System.Windows.Forms.DateTimePicker()
        Me.LabDatePrevu = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TBSexe = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBTel2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBTel1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBNom2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TBPrenom2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TBNom1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TBPrenom1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TBIDCl = New System.Windows.Forms.TextBox()
        Me.DGVClient = New System.Windows.Forms.DataGridView()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TBIDVe = New System.Windows.Forms.TextBox()
        Me.BTSave = New System.Windows.Forms.Button()
        Me.CBFabriquer = New System.Windows.Forms.CheckBox()
        Me.CBInv = New System.Windows.Forms.CheckBox()
        Me.BTAdd = New System.Windows.Forms.Button()
        Me.DGVListePie = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTModOpt = New System.Windows.Forms.Button()
        CType(Me.DGVClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVListePie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBMatricule
        '
        Me.TBMatricule.Location = New System.Drawing.Point(56, 140)
        Me.TBMatricule.Name = "TBMatricule"
        Me.TBMatricule.Size = New System.Drawing.Size(178, 23)
        Me.TBMatricule.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Matricule"
        '
        'CBModel
        '
        Me.CBModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBModel.FormattingEnabled = True
        Me.CBModel.Location = New System.Drawing.Point(56, 184)
        Me.CBModel.Name = "CBModel"
        Me.CBModel.Size = New System.Drawing.Size(178, 23)
        Me.CBModel.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Couleur Véhicule"
        '
        'CBCoulVe
        '
        Me.CBCoulVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCoulVe.FormattingEnabled = True
        Me.CBCoulVe.Location = New System.Drawing.Point(56, 228)
        Me.CBCoulVe.Name = "CBCoulVe"
        Me.CBCoulVe.Size = New System.Drawing.Size(178, 23)
        Me.CBCoulVe.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Couleur Toile"
        '
        'CBCoulToile
        '
        Me.CBCoulToile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCoulToile.FormattingEnabled = True
        Me.CBCoulToile.Location = New System.Drawing.Point(56, 272)
        Me.CBCoulToile.Name = "CBCoulToile"
        Me.CBCoulToile.Size = New System.Drawing.Size(178, 23)
        Me.CBCoulToile.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Couleur Tissus"
        '
        'CBCoulTissus
        '
        Me.CBCoulTissus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCoulTissus.FormattingEnabled = True
        Me.CBCoulTissus.Location = New System.Drawing.Point(56, 316)
        Me.CBCoulTissus.Name = "CBCoulTissus"
        Me.CBCoulTissus.Size = New System.Drawing.Size(178, 23)
        Me.CBCoulTissus.TabIndex = 8
        '
        'DTPPrevu
        '
        Me.DTPPrevu.Location = New System.Drawing.Point(56, 410)
        Me.DTPPrevu.Name = "DTPPrevu"
        Me.DTPPrevu.Size = New System.Drawing.Size(178, 23)
        Me.DTPPrevu.TabIndex = 10
        Me.DTPPrevu.Visible = False
        '
        'LabDatePrevu
        '
        Me.LabDatePrevu.AutoSize = True
        Me.LabDatePrevu.Location = New System.Drawing.Point(56, 392)
        Me.LabDatePrevu.Name = "LabDatePrevu"
        Me.LabDatePrevu.Size = New System.Drawing.Size(64, 15)
        Me.LabDatePrevu.TabIndex = 11
        Me.LabDatePrevu.Text = "Date Prévu"
        Me.LabDatePrevu.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(329, 430)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 15)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Email"
        '
        'TBEmail
        '
        Me.TBEmail.Location = New System.Drawing.Point(329, 448)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.ReadOnly = True
        Me.TBEmail.Size = New System.Drawing.Size(178, 23)
        Me.TBEmail.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(329, 386)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 15)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Sexe"
        '
        'TBSexe
        '
        Me.TBSexe.Location = New System.Drawing.Point(329, 404)
        Me.TBSexe.Name = "TBSexe"
        Me.TBSexe.ReadOnly = True
        Me.TBSexe.Size = New System.Drawing.Size(178, 23)
        Me.TBSexe.TabIndex = 38
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(329, 342)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 15)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Téléphone 2"
        '
        'TBTel2
        '
        Me.TBTel2.Location = New System.Drawing.Point(329, 360)
        Me.TBTel2.Name = "TBTel2"
        Me.TBTel2.ReadOnly = True
        Me.TBTel2.Size = New System.Drawing.Size(178, 23)
        Me.TBTel2.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(329, 298)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 15)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Téléphone 1"
        '
        'TBTel1
        '
        Me.TBTel1.Location = New System.Drawing.Point(329, 316)
        Me.TBTel1.Name = "TBTel1"
        Me.TBTel1.ReadOnly = True
        Me.TBTel1.Size = New System.Drawing.Size(178, 23)
        Me.TBTel1.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(329, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 15)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Nom 2"
        '
        'TBNom2
        '
        Me.TBNom2.Location = New System.Drawing.Point(329, 272)
        Me.TBNom2.Name = "TBNom2"
        Me.TBNom2.ReadOnly = True
        Me.TBNom2.Size = New System.Drawing.Size(178, 23)
        Me.TBNom2.TabIndex = 32
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(329, 210)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 15)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Prénom 2"
        '
        'TBPrenom2
        '
        Me.TBPrenom2.Location = New System.Drawing.Point(329, 228)
        Me.TBPrenom2.Name = "TBPrenom2"
        Me.TBPrenom2.ReadOnly = True
        Me.TBPrenom2.Size = New System.Drawing.Size(178, 23)
        Me.TBPrenom2.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(329, 166)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 15)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Nom 1"
        '
        'TBNom1
        '
        Me.TBNom1.Location = New System.Drawing.Point(329, 184)
        Me.TBNom1.Name = "TBNom1"
        Me.TBNom1.ReadOnly = True
        Me.TBNom1.Size = New System.Drawing.Size(178, 23)
        Me.TBNom1.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(329, 122)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 15)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Prénom 1"
        '
        'TBPrenom1
        '
        Me.TBPrenom1.Location = New System.Drawing.Point(329, 140)
        Me.TBPrenom1.Name = "TBPrenom1"
        Me.TBPrenom1.ReadOnly = True
        Me.TBPrenom1.Size = New System.Drawing.Size(178, 23)
        Me.TBPrenom1.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(561, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(124, 25)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Ancien Client"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.Location = New System.Drawing.Point(329, 42)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(119, 25)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Client Actuel"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(329, 78)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 15)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "ID"
        '
        'TBIDCl
        '
        Me.TBIDCl.Location = New System.Drawing.Point(329, 96)
        Me.TBIDCl.Name = "TBIDCl"
        Me.TBIDCl.ReadOnly = True
        Me.TBIDCl.Size = New System.Drawing.Size(178, 23)
        Me.TBIDCl.TabIndex = 22
        '
        'DGVClient
        '
        Me.DGVClient.AllowUserToAddRows = False
        Me.DGVClient.AllowUserToDeleteRows = False
        Me.DGVClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVClient.Location = New System.Drawing.Point(561, 70)
        Me.DGVClient.Name = "DGVClient"
        Me.DGVClient.ReadOnly = True
        Me.DGVClient.RowTemplate.Height = 25
        Me.DGVClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVClient.Size = New System.Drawing.Size(672, 199)
        Me.DGVClient.TabIndex = 21
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label18.Location = New System.Drawing.Point(56, 42)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(161, 25)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Modifier Véhicule"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(56, 78)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(18, 15)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "ID"
        '
        'TBIDVe
        '
        Me.TBIDVe.Location = New System.Drawing.Point(56, 96)
        Me.TBIDVe.Name = "TBIDVe"
        Me.TBIDVe.ReadOnly = True
        Me.TBIDVe.Size = New System.Drawing.Size(178, 23)
        Me.TBIDVe.TabIndex = 43
        '
        'BTSave
        '
        Me.BTSave.Enabled = False
        Me.BTSave.Location = New System.Drawing.Point(56, 547)
        Me.BTSave.Name = "BTSave"
        Me.BTSave.Size = New System.Drawing.Size(178, 23)
        Me.BTSave.TabIndex = 46
        Me.BTSave.Text = "Enregistrer"
        Me.BTSave.UseVisualStyleBackColor = True
        '
        'CBFabriquer
        '
        Me.CBFabriquer.AutoSize = True
        Me.CBFabriquer.Location = New System.Drawing.Point(56, 345)
        Me.CBFabriquer.Name = "CBFabriquer"
        Me.CBFabriquer.Size = New System.Drawing.Size(76, 19)
        Me.CBFabriquer.TabIndex = 47
        Me.CBFabriquer.Text = "Fabriquer"
        Me.CBFabriquer.UseVisualStyleBackColor = True
        '
        'CBInv
        '
        Me.CBInv.AutoSize = True
        Me.CBInv.Location = New System.Drawing.Point(56, 370)
        Me.CBInv.Name = "CBInv"
        Me.CBInv.Size = New System.Drawing.Size(94, 19)
        Me.CBInv.TabIndex = 48
        Me.CBInv.Text = "En Inventaire"
        Me.CBInv.UseVisualStyleBackColor = True
        '
        'BTAdd
        '
        Me.BTAdd.Location = New System.Drawing.Point(696, 294)
        Me.BTAdd.Name = "BTAdd"
        Me.BTAdd.Size = New System.Drawing.Size(179, 23)
        Me.BTAdd.TabIndex = 50
        Me.BTAdd.Text = "Ajouter nouvelle pièce"
        Me.BTAdd.UseVisualStyleBackColor = True
        '
        'DGVListePie
        '
        Me.DGVListePie.AllowUserToAddRows = False
        Me.DGVListePie.AllowUserToDeleteRows = False
        Me.DGVListePie.AllowUserToResizeColumns = False
        Me.DGVListePie.AllowUserToResizeRows = False
        Me.DGVListePie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVListePie.Location = New System.Drawing.Point(561, 323)
        Me.DGVListePie.Name = "DGVListePie"
        Me.DGVListePie.ReadOnly = True
        Me.DGVListePie.RowTemplate.Height = 25
        Me.DGVListePie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVListePie.Size = New System.Drawing.Size(672, 294)
        Me.DGVListePie.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(561, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 25)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Pièce installer"
        '
        'BTModOpt
        '
        Me.BTModOpt.Location = New System.Drawing.Point(56, 447)
        Me.BTModOpt.Name = "BTModOpt"
        Me.BTModOpt.Size = New System.Drawing.Size(178, 23)
        Me.BTModOpt.TabIndex = 52
        Me.BTModOpt.Text = "Modifier Option Véhicule"
        Me.BTModOpt.UseVisualStyleBackColor = True
        '
        'GestionVehicule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1245, 629)
        Me.Controls.Add(Me.BTModOpt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BTAdd)
        Me.Controls.Add(Me.DGVListePie)
        Me.Controls.Add(Me.CBInv)
        Me.Controls.Add(Me.CBFabriquer)
        Me.Controls.Add(Me.BTSave)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TBIDVe)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TBEmail)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TBSexe)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TBTel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TBTel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TBNom2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TBPrenom2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TBNom1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TBPrenom1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TBIDCl)
        Me.Controls.Add(Me.DGVClient)
        Me.Controls.Add(Me.LabDatePrevu)
        Me.Controls.Add(Me.DTPPrevu)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBCoulTissus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBCoulToile)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBCoulVe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBModel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBMatricule)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionVehicule"
        Me.Text = "GestionVehicule"
        CType(Me.DGVClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVListePie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBMatricule As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBModel As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CBCoulVe As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CBCoulToile As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CBCoulTissus As ComboBox
    Friend WithEvents DTPPrevu As DateTimePicker
    Friend WithEvents LabDatePrevu As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TBSexe As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TBTel2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBTel1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBNom2 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TBPrenom2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TBNom1 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TBPrenom1 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TBIDCl As TextBox
    Friend WithEvents DGVClient As DataGridView
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TBIDVe As TextBox
    Friend WithEvents BTSave As Button
    Friend WithEvents CBFabriquer As CheckBox
    Friend WithEvents CBInv As CheckBox
    Friend WithEvents BTAdd As Button
    Friend WithEvents DGVListePie As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents BTModOpt As Button
End Class
