<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tbIdPiece = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbNomPiece = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbQuantitePiece = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbEmplacementPiece = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbCommande = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbDescription = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nudQuantiteMod = New System.Windows.Forms.NumericUpDown()
        Me.btAjouter = New System.Windows.Forms.Button()
        Me.btEnlever = New System.Windows.Forms.Button()
        Me.labPasItem = New System.Windows.Forms.Label()
        CType(Me.nudQuantiteMod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbIdPiece
        '
        Me.tbIdPiece.Location = New System.Drawing.Point(75, 87)
        Me.tbIdPiece.Name = "tbIdPiece"
        Me.tbIdPiece.Size = New System.Drawing.Size(218, 23)
        Me.tbIdPiece.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID pièce"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nom"
        '
        'tbNomPiece
        '
        Me.tbNomPiece.Location = New System.Drawing.Point(75, 131)
        Me.tbNomPiece.Name = "tbNomPiece"
        Me.tbNomPiece.ReadOnly = True
        Me.tbNomPiece.Size = New System.Drawing.Size(218, 23)
        Me.tbNomPiece.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Quantité"
        '
        'tbQuantitePiece
        '
        Me.tbQuantitePiece.Location = New System.Drawing.Point(75, 175)
        Me.tbQuantitePiece.Name = "tbQuantitePiece"
        Me.tbQuantitePiece.ReadOnly = True
        Me.tbQuantitePiece.Size = New System.Drawing.Size(218, 23)
        Me.tbQuantitePiece.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Emplacement"
        '
        'tbEmplacementPiece
        '
        Me.tbEmplacementPiece.Location = New System.Drawing.Point(75, 219)
        Me.tbEmplacementPiece.Name = "tbEmplacementPiece"
        Me.tbEmplacementPiece.ReadOnly = True
        Me.tbEmplacementPiece.Size = New System.Drawing.Size(218, 23)
        Me.tbEmplacementPiece.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nombre de pièce en attente d'arrivé"
        '
        'tbCommande
        '
        Me.tbCommande.Location = New System.Drawing.Point(75, 263)
        Me.tbCommande.Name = "tbCommande"
        Me.tbCommande.ReadOnly = True
        Me.tbCommande.Size = New System.Drawing.Size(218, 23)
        Me.tbCommande.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(75, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Description"
        '
        'tbDescription
        '
        Me.tbDescription.Location = New System.Drawing.Point(75, 307)
        Me.tbDescription.Multiline = True
        Me.tbDescription.Name = "tbDescription"
        Me.tbDescription.ReadOnly = True
        Me.tbDescription.Size = New System.Drawing.Size(218, 82)
        Me.tbDescription.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(75, 392)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Quantité  à modifier"
        '
        'nudQuantiteMod
        '
        Me.nudQuantiteMod.Location = New System.Drawing.Point(75, 410)
        Me.nudQuantiteMod.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudQuantiteMod.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudQuantiteMod.Name = "nudQuantiteMod"
        Me.nudQuantiteMod.ReadOnly = True
        Me.nudQuantiteMod.Size = New System.Drawing.Size(156, 23)
        Me.nudQuantiteMod.TabIndex = 14
        Me.nudQuantiteMod.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btAjouter
        '
        Me.btAjouter.Location = New System.Drawing.Point(75, 439)
        Me.btAjouter.Name = "btAjouter"
        Me.btAjouter.Size = New System.Drawing.Size(75, 23)
        Me.btAjouter.TabIndex = 15
        Me.btAjouter.Text = "Ajouter"
        Me.btAjouter.UseVisualStyleBackColor = True
        '
        'btEnlever
        '
        Me.btEnlever.Location = New System.Drawing.Point(156, 439)
        Me.btEnlever.Name = "btEnlever"
        Me.btEnlever.Size = New System.Drawing.Size(75, 23)
        Me.btEnlever.TabIndex = 16
        Me.btEnlever.Text = "Retirer"
        Me.btEnlever.UseVisualStyleBackColor = True
        '
        'labPasItem
        '
        Me.labPasItem.AutoSize = True
        Me.labPasItem.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labPasItem.ForeColor = System.Drawing.Color.Red
        Me.labPasItem.Location = New System.Drawing.Point(418, 69)
        Me.labPasItem.Name = "labPasItem"
        Me.labPasItem.Size = New System.Drawing.Size(0, 28)
        Me.labPasItem.TabIndex = 17
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 515)
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
        Me.Name = "MainForm"
        Me.Text = "Form1"
        CType(Me.nudQuantiteMod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbIdPiece As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbNomPiece As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbQuantitePiece As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbEmplacementPiece As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbCommande As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbDescription As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents nudQuantiteMod As NumericUpDown
    Friend WithEvents btAjouter As Button
    Friend WithEvents btEnlever As Button
    Friend WithEvents labPasItem As Label
End Class
