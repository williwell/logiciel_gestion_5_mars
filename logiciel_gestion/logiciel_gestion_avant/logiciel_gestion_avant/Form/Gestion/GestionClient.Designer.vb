<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionClient))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBPrenom1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBNom1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBPrenom2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBTel2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBTel1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TBNom2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.BTSave = New System.Windows.Forms.Button()
        Me.BTAnnuler = New System.Windows.Forms.Button()
        Me.CBSexe = New System.Windows.Forms.ComboBox()
        Me.TBCode = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TBApp = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TBRue = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TBVille = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TBPro = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(395, 353)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(611, 298)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(395, 335)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Liste Facture Client"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(395, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Info Véhicule"
        '
        'TBID
        '
        Me.TBID.Enabled = False
        Me.TBID.Location = New System.Drawing.Point(31, 27)
        Me.TBID.Name = "TBID"
        Me.TBID.Size = New System.Drawing.Size(226, 23)
        Me.TBID.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID"
        '
        'TBPrenom1
        '
        Me.TBPrenom1.Location = New System.Drawing.Point(31, 71)
        Me.TBPrenom1.Name = "TBPrenom1"
        Me.TBPrenom1.Size = New System.Drawing.Size(226, 23)
        Me.TBPrenom1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Prénom 1"
        '
        'TBNom1
        '
        Me.TBNom1.Location = New System.Drawing.Point(31, 115)
        Me.TBNom1.Name = "TBNom1"
        Me.TBNom1.Size = New System.Drawing.Size(226, 23)
        Me.TBNom1.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Nom 1"
        '
        'TBPrenom2
        '
        Me.TBPrenom2.Location = New System.Drawing.Point(31, 159)
        Me.TBPrenom2.Name = "TBPrenom2"
        Me.TBPrenom2.Size = New System.Drawing.Size(226, 23)
        Me.TBPrenom2.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Prénom 2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 537)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 15)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Sexe"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 493)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Téléphone 2"
        '
        'TBTel2
        '
        Me.TBTel2.Location = New System.Drawing.Point(31, 511)
        Me.TBTel2.Name = "TBTel2"
        Me.TBTel2.Size = New System.Drawing.Size(226, 23)
        Me.TBTel2.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 449)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Téléphone 1"
        '
        'TBTel1
        '
        Me.TBTel1.Location = New System.Drawing.Point(31, 467)
        Me.TBTel1.Name = "TBTel1"
        Me.TBTel1.Size = New System.Drawing.Size(226, 23)
        Me.TBTel1.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(31, 185)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 15)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Nom 2"
        '
        'TBNom2
        '
        Me.TBNom2.Location = New System.Drawing.Point(31, 203)
        Me.TBNom2.Name = "TBNom2"
        Me.TBNom2.Size = New System.Drawing.Size(226, 23)
        Me.TBNom2.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(31, 581)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Email"
        '
        'TBEmail
        '
        Me.TBEmail.Location = New System.Drawing.Point(31, 599)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(226, 23)
        Me.TBEmail.TabIndex = 20
        '
        'BTSave
        '
        Me.BTSave.Location = New System.Drawing.Point(31, 628)
        Me.BTSave.Name = "BTSave"
        Me.BTSave.Size = New System.Drawing.Size(102, 23)
        Me.BTSave.TabIndex = 21
        Me.BTSave.Text = "Enregistrer"
        Me.BTSave.UseVisualStyleBackColor = True
        '
        'BTAnnuler
        '
        Me.BTAnnuler.Enabled = False
        Me.BTAnnuler.Location = New System.Drawing.Point(155, 628)
        Me.BTAnnuler.Name = "BTAnnuler"
        Me.BTAnnuler.Size = New System.Drawing.Size(102, 23)
        Me.BTAnnuler.TabIndex = 22
        Me.BTAnnuler.Text = "Annuler"
        Me.BTAnnuler.UseVisualStyleBackColor = True
        '
        'CBSexe
        '
        Me.CBSexe.FormattingEnabled = True
        Me.CBSexe.Location = New System.Drawing.Point(31, 555)
        Me.CBSexe.Name = "CBSexe"
        Me.CBSexe.Size = New System.Drawing.Size(226, 23)
        Me.CBSexe.TabIndex = 19
        '
        'TBCode
        '
        Me.TBCode.Location = New System.Drawing.Point(31, 423)
        Me.TBCode.Name = "TBCode"
        Me.TBCode.Size = New System.Drawing.Size(226, 23)
        Me.TBCode.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(31, 405)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 15)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Code Postal"
        '
        'TBApp
        '
        Me.TBApp.Location = New System.Drawing.Point(31, 379)
        Me.TBApp.Name = "TBApp"
        Me.TBApp.Size = New System.Drawing.Size(226, 23)
        Me.TBApp.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(31, 361)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 15)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Appartement"
        '
        'TBRue
        '
        Me.TBRue.Location = New System.Drawing.Point(31, 247)
        Me.TBRue.Name = "TBRue"
        Me.TBRue.Size = New System.Drawing.Size(226, 23)
        Me.TBRue.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(31, 229)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 15)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Rue"
        '
        'TBVille
        '
        Me.TBVille.Location = New System.Drawing.Point(31, 291)
        Me.TBVille.Name = "TBVille"
        Me.TBVille.Size = New System.Drawing.Size(226, 23)
        Me.TBVille.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(31, 273)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 15)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Ville"
        '
        'TBPro
        '
        Me.TBPro.Location = New System.Drawing.Point(31, 335)
        Me.TBPro.Name = "TBPro"
        Me.TBPro.Size = New System.Drawing.Size(226, 23)
        Me.TBPro.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(31, 317)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 15)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Province"
        '
        'GestionClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 690)
        Me.Controls.Add(Me.TBPro)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TBVille)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TBCode)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TBApp)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TBRue)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CBSexe)
        Me.Controls.Add(Me.BTAnnuler)
        Me.Controls.Add(Me.BTSave)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TBEmail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TBTel2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TBTel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TBNom2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBPrenom2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBNom1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBPrenom1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionClient"
        Me.Text = "Gestion Client"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TBID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBPrenom1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBNom1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBPrenom2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TBTel2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TBTel1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TBNom2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents BTSave As Button
    Friend WithEvents BTAnnuler As Button
    Friend WithEvents CBSexe As ComboBox
    Friend WithEvents TBCode As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TBApp As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TBRue As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TBVille As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TBPro As TextBox
    Friend WithEvents Label16 As Label
End Class
