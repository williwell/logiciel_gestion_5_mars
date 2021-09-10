<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCReseptionInventaire
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
        Me.labPasItem = New System.Windows.Forms.Label()
        Me.btEnlever = New System.Windows.Forms.Button()
        Me.btAjouter = New System.Windows.Forms.Button()
        Me.nudQuantiteMod = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbDescription = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbCommande = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbEmplacementPiece = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbQuantitePiece = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbNomPiece = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbIdPiece = New System.Windows.Forms.TextBox()
        CType(Me.nudQuantiteMod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labPasItem
        '
        Me.labPasItem.AutoSize = True
        Me.labPasItem.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labPasItem.ForeColor = System.Drawing.Color.Red
        Me.labPasItem.Location = New System.Drawing.Point(406, 63)
        Me.labPasItem.Name = "labPasItem"
        Me.labPasItem.Size = New System.Drawing.Size(0, 28)
        Me.labPasItem.TabIndex = 34
        '
        'btEnlever
        '
        Me.btEnlever.Location = New System.Drawing.Point(144, 433)
        Me.btEnlever.Name = "btEnlever"
        Me.btEnlever.Size = New System.Drawing.Size(75, 23)
        Me.btEnlever.TabIndex = 33
        Me.btEnlever.Text = "Retirer"
        Me.btEnlever.UseVisualStyleBackColor = True
        '
        'btAjouter
        '
        Me.btAjouter.Location = New System.Drawing.Point(63, 433)
        Me.btAjouter.Name = "btAjouter"
        Me.btAjouter.Size = New System.Drawing.Size(75, 23)
        Me.btAjouter.TabIndex = 32
        Me.btAjouter.Text = "Ajouter"
        Me.btAjouter.UseVisualStyleBackColor = True
        '
        'nudQuantiteMod
        '
        Me.nudQuantiteMod.Location = New System.Drawing.Point(63, 404)
        Me.nudQuantiteMod.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudQuantiteMod.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudQuantiteMod.Name = "nudQuantiteMod"
        Me.nudQuantiteMod.ReadOnly = True
        Me.nudQuantiteMod.Size = New System.Drawing.Size(156, 23)
        Me.nudQuantiteMod.TabIndex = 31
        Me.nudQuantiteMod.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 386)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 15)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Quantité  à modifier"
        '
        'tbDescription
        '
        Me.tbDescription.Location = New System.Drawing.Point(63, 301)
        Me.tbDescription.Multiline = True
        Me.tbDescription.Name = "tbDescription"
        Me.tbDescription.ReadOnly = True
        Me.tbDescription.Size = New System.Drawing.Size(218, 82)
        Me.tbDescription.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(63, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 15)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Description"
        '
        'tbCommande
        '
        Me.tbCommande.Location = New System.Drawing.Point(63, 257)
        Me.tbCommande.Name = "tbCommande"
        Me.tbCommande.ReadOnly = True
        Me.tbCommande.Size = New System.Drawing.Size(218, 23)
        Me.tbCommande.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 15)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Nombre de pièce en attente d'arrivé"
        '
        'tbEmplacementPiece
        '
        Me.tbEmplacementPiece.Location = New System.Drawing.Point(63, 213)
        Me.tbEmplacementPiece.Name = "tbEmplacementPiece"
        Me.tbEmplacementPiece.ReadOnly = True
        Me.tbEmplacementPiece.Size = New System.Drawing.Size(218, 23)
        Me.tbEmplacementPiece.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Emplacement"
        '
        'tbQuantitePiece
        '
        Me.tbQuantitePiece.Location = New System.Drawing.Point(63, 169)
        Me.tbQuantitePiece.Name = "tbQuantitePiece"
        Me.tbQuantitePiece.ReadOnly = True
        Me.tbQuantitePiece.Size = New System.Drawing.Size(218, 23)
        Me.tbQuantitePiece.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Quantité"
        '
        'tbNomPiece
        '
        Me.tbNomPiece.Location = New System.Drawing.Point(63, 125)
        Me.tbNomPiece.Name = "tbNomPiece"
        Me.tbNomPiece.ReadOnly = True
        Me.tbNomPiece.Size = New System.Drawing.Size(218, 23)
        Me.tbNomPiece.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "ID pièce"
        '
        'tbIdPiece
        '
        Me.tbIdPiece.Location = New System.Drawing.Point(63, 81)
        Me.tbIdPiece.Name = "tbIdPiece"
        Me.tbIdPiece.Size = New System.Drawing.Size(218, 23)
        Me.tbIdPiece.TabIndex = 18
        '
        'UCReseptionInventaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.labPasItem)
        Me.Controls.Add(Me.btEnlever)
        Me.Controls.Add(Me.btAjouter)
        Me.Controls.Add(Me.nudQuantiteMod)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbDescription)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbCommande)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbEmplacementPiece)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbQuantitePiece)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbNomPiece)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbIdPiece)
        Me.Name = "UCReseptionInventaire"
        Me.Size = New System.Drawing.Size(650, 534)
        CType(Me.nudQuantiteMod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labPasItem As Label
    Friend WithEvents btEnlever As Button
    Friend WithEvents btAjouter As Button
    Friend WithEvents nudQuantiteMod As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents tbDescription As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbCommande As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbEmplacementPiece As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbQuantitePiece As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbNomPiece As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbIdPiece As TextBox
End Class
