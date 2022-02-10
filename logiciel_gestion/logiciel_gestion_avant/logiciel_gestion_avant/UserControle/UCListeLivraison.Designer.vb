<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCListeLivraison
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
        Me.DGVVehicule = New System.Windows.Forms.DataGridView()
        Me.BTSave = New System.Windows.Forms.Button()
        Me.BTAnnuler = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBPrenom1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBNom1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBNom2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBPrenom2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBSexe = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBTel2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBTel1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TBID = New System.Windows.Forms.TextBox()
        CType(Me.DGVVehicule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVVehicule
        '
        Me.DGVVehicule.AllowDrop = True
        Me.DGVVehicule.AllowUserToAddRows = False
        Me.DGVVehicule.AllowUserToDeleteRows = False
        Me.DGVVehicule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVehicule.Location = New System.Drawing.Point(20, 299)
        Me.DGVVehicule.MultiSelect = False
        Me.DGVVehicule.Name = "DGVVehicule"
        Me.DGVVehicule.ReadOnly = True
        Me.DGVVehicule.RowTemplate.Height = 25
        Me.DGVVehicule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVVehicule.Size = New System.Drawing.Size(1080, 238)
        Me.DGVVehicule.TabIndex = 0
        '
        'BTSave
        '
        Me.BTSave.Enabled = False
        Me.BTSave.Location = New System.Drawing.Point(20, 556)
        Me.BTSave.Name = "BTSave"
        Me.BTSave.Size = New System.Drawing.Size(168, 23)
        Me.BTSave.TabIndex = 1
        Me.BTSave.Text = "Enregistrer Nouvelle Priorité"
        Me.BTSave.UseVisualStyleBackColor = True
        '
        'BTAnnuler
        '
        Me.BTAnnuler.Enabled = False
        Me.BTAnnuler.Location = New System.Drawing.Point(194, 556)
        Me.BTAnnuler.Name = "BTAnnuler"
        Me.BTAnnuler.Size = New System.Drawing.Size(168, 23)
        Me.BTAnnuler.TabIndex = 2
        Me.BTAnnuler.Text = "Annuler Changement"
        Me.BTAnnuler.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(20, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Info Client"
        '
        'TBPrenom1
        '
        Me.TBPrenom1.Location = New System.Drawing.Point(20, 121)
        Me.TBPrenom1.Name = "TBPrenom1"
        Me.TBPrenom1.ReadOnly = True
        Me.TBPrenom1.Size = New System.Drawing.Size(168, 23)
        Me.TBPrenom1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Prénom 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nom 1"
        '
        'TBNom1
        '
        Me.TBNom1.Location = New System.Drawing.Point(20, 165)
        Me.TBNom1.Name = "TBNom1"
        Me.TBNom1.ReadOnly = True
        Me.TBNom1.Size = New System.Drawing.Size(168, 23)
        Me.TBNom1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Nom 2"
        '
        'TBNom2
        '
        Me.TBNom2.Location = New System.Drawing.Point(20, 253)
        Me.TBNom2.Name = "TBNom2"
        Me.TBNom2.ReadOnly = True
        Me.TBNom2.Size = New System.Drawing.Size(168, 23)
        Me.TBNom2.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Prénom 2"
        '
        'TBPrenom2
        '
        Me.TBPrenom2.Location = New System.Drawing.Point(20, 209)
        Me.TBPrenom2.Name = "TBPrenom2"
        Me.TBPrenom2.ReadOnly = True
        Me.TBPrenom2.Size = New System.Drawing.Size(168, 23)
        Me.TBPrenom2.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(194, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Email"
        '
        'TBEmail
        '
        Me.TBEmail.Location = New System.Drawing.Point(194, 209)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.ReadOnly = True
        Me.TBEmail.Size = New System.Drawing.Size(168, 23)
        Me.TBEmail.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(194, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 15)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Sexe"
        '
        'TBSexe
        '
        Me.TBSexe.Location = New System.Drawing.Point(194, 165)
        Me.TBSexe.Name = "TBSexe"
        Me.TBSexe.ReadOnly = True
        Me.TBSexe.Size = New System.Drawing.Size(168, 23)
        Me.TBSexe.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(194, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Téléphone 2"
        '
        'TBTel2
        '
        Me.TBTel2.Location = New System.Drawing.Point(194, 121)
        Me.TBTel2.Name = "TBTel2"
        Me.TBTel2.ReadOnly = True
        Me.TBTel2.Size = New System.Drawing.Size(168, 23)
        Me.TBTel2.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(194, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 15)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Téléphone 1"
        '
        'TBTel1
        '
        Me.TBTel1.Location = New System.Drawing.Point(194, 77)
        Me.TBTel1.Name = "TBTel1"
        Me.TBTel1.ReadOnly = True
        Me.TBTel1.Size = New System.Drawing.Size(168, 23)
        Me.TBTel1.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 15)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "ID"
        '
        'TBID
        '
        Me.TBID.Location = New System.Drawing.Point(20, 77)
        Me.TBID.Name = "TBID"
        Me.TBID.ReadOnly = True
        Me.TBID.Size = New System.Drawing.Size(168, 23)
        Me.TBID.TabIndex = 20
        '
        'UCListeLivraison
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TBID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBEmail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TBSexe)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TBTel2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TBTel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBNom2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBPrenom2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBNom1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBPrenom1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTAnnuler)
        Me.Controls.Add(Me.BTSave)
        Me.Controls.Add(Me.DGVVehicule)
        Me.Name = "UCListeLivraison"
        Me.Size = New System.Drawing.Size(1115, 651)
        CType(Me.DGVVehicule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVVehicule As DataGridView
    Friend WithEvents BTSave As Button
    Friend WithEvents BTAnnuler As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TBPrenom1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TBNom1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBNom2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBPrenom2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBSexe As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBTel2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TBTel1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TBID As TextBox
End Class
