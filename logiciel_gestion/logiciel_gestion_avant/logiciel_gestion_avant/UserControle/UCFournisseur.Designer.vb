<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCFournisseur
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.tbNomFour = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbAdres2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbAdres1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbAddCour = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbLeadTime = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbNomCont = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbTel = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbMethodePaie = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbNoCompte = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbMethodeCom = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvPiece = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvFour = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btSauv = New System.Windows.Forms.Button()
        Me.btAnnuler = New System.Windows.Forms.Button()
        Me.btCreerFour = New System.Windows.Forms.Button()
        CType(Me.dgvPiece, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Fournisseur"
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(40, 62)
        Me.tbID.Name = "tbID"
        Me.tbID.ReadOnly = True
        Me.tbID.Size = New System.Drawing.Size(180, 23)
        Me.tbID.TabIndex = 1
        '
        'tbNomFour
        '
        Me.tbNomFour.Location = New System.Drawing.Point(40, 106)
        Me.tbNomFour.Name = "tbNomFour"
        Me.tbNomFour.Size = New System.Drawing.Size(180, 23)
        Me.tbNomFour.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nom Fournisseur"
        '
        'tbAdres2
        '
        Me.tbAdres2.Location = New System.Drawing.Point(40, 194)
        Me.tbAdres2.Name = "tbAdres2"
        Me.tbAdres2.Size = New System.Drawing.Size(180, 23)
        Me.tbAdres2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Adresse 2"
        '
        'tbAdres1
        '
        Me.tbAdres1.Location = New System.Drawing.Point(40, 150)
        Me.tbAdres1.Name = "tbAdres1"
        Me.tbAdres1.Size = New System.Drawing.Size(180, 23)
        Me.tbAdres1.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Adresse 1"
        '
        'tbAddCour
        '
        Me.tbAddCour.Location = New System.Drawing.Point(40, 370)
        Me.tbAddCour.Name = "tbAddCour"
        Me.tbAddCour.Size = New System.Drawing.Size(180, 23)
        Me.tbAddCour.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Adresse Couriel"
        '
        'tbLeadTime
        '
        Me.tbLeadTime.Location = New System.Drawing.Point(40, 326)
        Me.tbLeadTime.Name = "tbLeadTime"
        Me.tbLeadTime.Size = New System.Drawing.Size(180, 23)
        Me.tbLeadTime.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 308)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Délai Livraison"
        '
        'tbNomCont
        '
        Me.tbNomCont.Location = New System.Drawing.Point(40, 282)
        Me.tbNomCont.Name = "tbNomCont"
        Me.tbNomCont.Size = New System.Drawing.Size(180, 23)
        Me.tbNomCont.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Nom Contact"
        '
        'tbTel
        '
        Me.tbTel.Location = New System.Drawing.Point(40, 238)
        Me.tbTel.Name = "tbTel"
        Me.tbTel.Size = New System.Drawing.Size(180, 23)
        Me.tbTel.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Téléphone"
        '
        'tbMethodePaie
        '
        Me.tbMethodePaie.Location = New System.Drawing.Point(40, 502)
        Me.tbMethodePaie.Name = "tbMethodePaie"
        Me.tbMethodePaie.Size = New System.Drawing.Size(180, 23)
        Me.tbMethodePaie.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 484)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 15)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Méthode Paiement"
        '
        'tbNoCompte
        '
        Me.tbNoCompte.Location = New System.Drawing.Point(40, 458)
        Me.tbNoCompte.Name = "tbNoCompte"
        Me.tbNoCompte.Size = New System.Drawing.Size(180, 23)
        Me.tbNoCompte.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 440)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Numéro Compte"
        '
        'tbMethodeCom
        '
        Me.tbMethodeCom.Location = New System.Drawing.Point(40, 414)
        Me.tbMethodeCom.Name = "tbMethodeCom"
        Me.tbMethodeCom.Size = New System.Drawing.Size(180, 23)
        Me.tbMethodeCom.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(40, 396)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 15)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Méthode de commande"
        '
        'dgvPiece
        '
        Me.dgvPiece.AllowUserToAddRows = False
        Me.dgvPiece.AllowUserToDeleteRows = False
        Me.dgvPiece.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPiece.Location = New System.Drawing.Point(296, 326)
        Me.dgvPiece.Name = "dgvPiece"
        Me.dgvPiece.ReadOnly = True
        Me.dgvPiece.RowTemplate.Height = 25
        Me.dgvPiece.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPiece.Size = New System.Drawing.Size(561, 199)
        Me.dgvPiece.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(296, 308)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 15)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Pièce Fournisseur"
        '
        'dgvFour
        '
        Me.dgvFour.AllowUserToAddRows = False
        Me.dgvFour.AllowUserToDeleteRows = False
        Me.dgvFour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFour.Location = New System.Drawing.Point(296, 62)
        Me.dgvFour.Name = "dgvFour"
        Me.dgvFour.ReadOnly = True
        Me.dgvFour.RowTemplate.Height = 25
        Me.dgvFour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFour.Size = New System.Drawing.Size(561, 199)
        Me.dgvFour.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(296, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 15)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Choisir Fournisseur"
        '
        'btSauv
        '
        Me.btSauv.Enabled = False
        Me.btSauv.Location = New System.Drawing.Point(40, 531)
        Me.btSauv.Name = "btSauv"
        Me.btSauv.Size = New System.Drawing.Size(85, 23)
        Me.btSauv.TabIndex = 12
        Me.btSauv.Text = "Enregistrer"
        Me.btSauv.UseVisualStyleBackColor = True
        '
        'btAnnuler
        '
        Me.btAnnuler.Enabled = False
        Me.btAnnuler.Location = New System.Drawing.Point(135, 531)
        Me.btAnnuler.Name = "btAnnuler"
        Me.btAnnuler.Size = New System.Drawing.Size(85, 23)
        Me.btAnnuler.TabIndex = 13
        Me.btAnnuler.Text = "Annuler"
        Me.btAnnuler.UseVisualStyleBackColor = True
        '
        'btCreerFour
        '
        Me.btCreerFour.Location = New System.Drawing.Point(40, 18)
        Me.btCreerFour.Name = "btCreerFour"
        Me.btCreerFour.Size = New System.Drawing.Size(172, 23)
        Me.btCreerFour.TabIndex = 0
        Me.btCreerFour.Text = "Créer Nouveau Fournisseur"
        Me.btCreerFour.UseVisualStyleBackColor = True
        '
        'UCFournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btCreerFour)
        Me.Controls.Add(Me.btAnnuler)
        Me.Controls.Add(Me.btSauv)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dgvFour)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dgvPiece)
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
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UCFournisseur"
        Me.Size = New System.Drawing.Size(889, 649)
        CType(Me.dgvPiece, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbID As TextBox
    Friend WithEvents tbNomFour As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbAdres2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbAdres1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbAddCour As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbLeadTime As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbNomCont As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbTel As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbMethodePaie As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbNoCompte As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbMethodeCom As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dgvPiece As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents dgvFour As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents btSauv As Button
    Friend WithEvents btAnnuler As Button
    Friend WithEvents btCreerFour As Button
End Class
