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
        Me.tbUse = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
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
        CType(Me.nudQuantite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEnCommende, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCoutUn, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tbIDPro.Size = New System.Drawing.Size(172, 23)
        Me.tbIDPro.TabIndex = 1
        '
        'tbNom
        '
        Me.tbNom.Location = New System.Drawing.Point(41, 116)
        Me.tbNom.Name = "tbNom"
        Me.tbNom.ReadOnly = True
        Me.tbNom.Size = New System.Drawing.Size(172, 23)
        Me.tbNom.TabIndex = 3
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
        Me.Label3.Location = New System.Drawing.Point(263, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID Fournisseur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 318)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "En commande"
        '
        'tbUse
        '
        Me.tbUse.Location = New System.Drawing.Point(41, 292)
        Me.tbUse.Name = "tbUse"
        Me.tbUse.ReadOnly = True
        Me.tbUse.Size = New System.Drawing.Size(172, 23)
        Me.tbUse.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Est encore utilisé"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Coût unitaire"
        '
        'tbEmplacement
        '
        Me.tbEmplacement.Location = New System.Drawing.Point(41, 204)
        Me.tbEmplacement.Name = "tbEmplacement"
        Me.tbEmplacement.ReadOnly = True
        Me.tbEmplacement.Size = New System.Drawing.Size(172, 23)
        Me.tbEmplacement.TabIndex = 13
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
        Me.tbIDFour.Location = New System.Drawing.Point(263, 72)
        Me.tbIDFour.Name = "tbIDFour"
        Me.tbIDFour.ReadOnly = True
        Me.tbIDFour.Size = New System.Drawing.Size(172, 23)
        Me.tbIDFour.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(41, 362)
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
        Me.nudQuantite.Name = "nudQuantite"
        Me.nudQuantite.ReadOnly = True
        Me.nudQuantite.Size = New System.Drawing.Size(172, 23)
        Me.nudQuantite.TabIndex = 17
        '
        'tbDescription
        '
        Me.tbDescription.Location = New System.Drawing.Point(41, 380)
        Me.tbDescription.Multiline = True
        Me.tbDescription.Name = "tbDescription"
        Me.tbDescription.ReadOnly = True
        Me.tbDescription.Size = New System.Drawing.Size(172, 75)
        Me.tbDescription.TabIndex = 30
        '
        'labPasItem
        '
        Me.labPasItem.AutoSize = True
        Me.labPasItem.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labPasItem.ForeColor = System.Drawing.Color.Red
        Me.labPasItem.Location = New System.Drawing.Point(41, 7)
        Me.labPasItem.Name = "labPasItem"
        Me.labPasItem.Size = New System.Drawing.Size(0, 28)
        Me.labPasItem.TabIndex = 35
        '
        'nudEnCommende
        '
        Me.nudEnCommende.Location = New System.Drawing.Point(41, 336)
        Me.nudEnCommende.Name = "nudEnCommende"
        Me.nudEnCommende.ReadOnly = True
        Me.nudEnCommende.Size = New System.Drawing.Size(172, 23)
        Me.nudEnCommende.TabIndex = 36
        '
        'nudCoutUn
        '
        Me.nudCoutUn.Location = New System.Drawing.Point(41, 248)
        Me.nudCoutUn.Name = "nudCoutUn"
        Me.nudCoutUn.ReadOnly = True
        Me.nudCoutUn.Size = New System.Drawing.Size(172, 23)
        Me.nudCoutUn.TabIndex = 37
        '
        'btSauv
        '
        Me.btSauv.Enabled = False
        Me.btSauv.Location = New System.Drawing.Point(41, 461)
        Me.btSauv.Name = "btSauv"
        Me.btSauv.Size = New System.Drawing.Size(172, 23)
        Me.btSauv.TabIndex = 38
        Me.btSauv.Text = "Enregistrer"
        Me.btSauv.UseVisualStyleBackColor = True
        '
        'UCInventaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Controls.Add(Me.tbUse)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbNom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbIDPro)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UCInventaire"
        Me.Size = New System.Drawing.Size(808, 503)
        CType(Me.nudQuantite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEnCommende, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCoutUn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbIDPro As TextBox
    Friend WithEvents tbNom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbUse As TextBox
    Friend WithEvents Label5 As Label
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
End Class
