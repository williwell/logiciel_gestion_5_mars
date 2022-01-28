<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCInfoClientVehicule
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
        Me.DGVClient = New System.Windows.Forms.DataGridView()
        Me.TBID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBPrenom1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBNom1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBTel1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBNom2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBPrenom2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TBSexe = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBTel2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.DGVClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVClient
        '
        Me.DGVClient.AllowUserToAddRows = False
        Me.DGVClient.AllowUserToDeleteRows = False
        Me.DGVClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVClient.Location = New System.Drawing.Point(258, 83)
        Me.DGVClient.Name = "DGVClient"
        Me.DGVClient.ReadOnly = True
        Me.DGVClient.RowTemplate.Height = 25
        Me.DGVClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVClient.Size = New System.Drawing.Size(547, 269)
        Me.DGVClient.TabIndex = 0
        '
        'TBID
        '
        Me.TBID.Location = New System.Drawing.Point(26, 109)
        Me.TBID.Name = "TBID"
        Me.TBID.ReadOnly = True
        Me.TBID.Size = New System.Drawing.Size(226, 23)
        Me.TBID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(26, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Client Actuel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(258, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ancien Client"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Prénom 1"
        '
        'TBPrenom1
        '
        Me.TBPrenom1.Location = New System.Drawing.Point(26, 153)
        Me.TBPrenom1.Name = "TBPrenom1"
        Me.TBPrenom1.ReadOnly = True
        Me.TBPrenom1.Size = New System.Drawing.Size(226, 23)
        Me.TBPrenom1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nom 1"
        '
        'TBNom1
        '
        Me.TBNom1.Location = New System.Drawing.Point(26, 197)
        Me.TBNom1.Name = "TBNom1"
        Me.TBNom1.ReadOnly = True
        Me.TBNom1.Size = New System.Drawing.Size(226, 23)
        Me.TBNom1.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 443)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Téléphone 1"
        '
        'TBTel1
        '
        Me.TBTel1.Location = New System.Drawing.Point(26, 461)
        Me.TBTel1.Name = "TBTel1"
        Me.TBTel1.ReadOnly = True
        Me.TBTel1.Size = New System.Drawing.Size(226, 23)
        Me.TBTel1.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Nom 2"
        '
        'TBNom2
        '
        Me.TBNom2.Location = New System.Drawing.Point(26, 285)
        Me.TBNom2.Name = "TBNom2"
        Me.TBNom2.ReadOnly = True
        Me.TBNom2.Size = New System.Drawing.Size(226, 23)
        Me.TBNom2.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Prénom 2"
        '
        'TBPrenom2
        '
        Me.TBPrenom2.Location = New System.Drawing.Point(26, 241)
        Me.TBPrenom2.Name = "TBPrenom2"
        Me.TBPrenom2.ReadOnly = True
        Me.TBPrenom2.Size = New System.Drawing.Size(226, 23)
        Me.TBPrenom2.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 575)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 15)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Email"
        '
        'TBEmail
        '
        Me.TBEmail.Location = New System.Drawing.Point(26, 593)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.ReadOnly = True
        Me.TBEmail.Size = New System.Drawing.Size(226, 23)
        Me.TBEmail.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 531)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Sexe"
        '
        'TBSexe
        '
        Me.TBSexe.Location = New System.Drawing.Point(26, 549)
        Me.TBSexe.Name = "TBSexe"
        Me.TBSexe.ReadOnly = True
        Me.TBSexe.Size = New System.Drawing.Size(226, 23)
        Me.TBSexe.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 487)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 15)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Téléphone 2"
        '
        'TBTel2
        '
        Me.TBTel2.Location = New System.Drawing.Point(26, 505)
        Me.TBTel2.Name = "TBTel2"
        Me.TBTel2.ReadOnly = True
        Me.TBTel2.Size = New System.Drawing.Size(226, 23)
        Me.TBTel2.TabIndex = 15
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(26, 417)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(226, 23)
        Me.TextBox3.TabIndex = 32
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 399)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 15)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Code Postal"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(26, 373)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(226, 23)
        Me.TextBox2.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 355)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 15)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Appartement"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(26, 329)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(226, 23)
        Me.TextBox1.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(26, 311)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 15)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Adresse"
        '
        'UCInfoClientVehicule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TBEmail)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TBSexe)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TBTel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBTel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TBNom2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TBPrenom2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBNom1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBPrenom1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBID)
        Me.Controls.Add(Me.DGVClient)
        Me.Name = "UCInfoClientVehicule"
        Me.Size = New System.Drawing.Size(808, 649)
        CType(Me.DGVClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVClient As DataGridView
    Friend WithEvents TBID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TBPrenom1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBNom1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBTel1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBNom2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBPrenom2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TBSexe As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TBTel2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label14 As Label
End Class
