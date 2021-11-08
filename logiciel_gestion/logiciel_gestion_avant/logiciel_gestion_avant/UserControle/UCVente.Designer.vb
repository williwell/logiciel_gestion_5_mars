<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCVente
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
        Me.BTChoisir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBModel = New System.Windows.Forms.ComboBox()
        Me.CBCoulVe = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBCoulTissus = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBCoulToile = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTChoisir
        '
        Me.BTChoisir.Location = New System.Drawing.Point(77, 212)
        Me.BTChoisir.Name = "BTChoisir"
        Me.BTChoisir.Size = New System.Drawing.Size(196, 23)
        Me.BTChoisir.TabIndex = 1
        Me.BTChoisir.Text = "Choisir véhicule"
        Me.BTChoisir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(64, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Véhicule"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(321, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Model"
        '
        'CBModel
        '
        Me.CBModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBModel.FormattingEnabled = True
        Me.CBModel.Location = New System.Drawing.Point(321, 230)
        Me.CBModel.Name = "CBModel"
        Me.CBModel.Size = New System.Drawing.Size(196, 23)
        Me.CBModel.TabIndex = 5
        '
        'CBCoulVe
        '
        Me.CBCoulVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCoulVe.FormattingEnabled = True
        Me.CBCoulVe.Location = New System.Drawing.Point(321, 274)
        Me.CBCoulVe.Name = "CBCoulVe"
        Me.CBCoulVe.Size = New System.Drawing.Size(196, 23)
        Me.CBCoulVe.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(321, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Couleur Véhicule"
        '
        'CBCoulTissus
        '
        Me.CBCoulTissus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCoulTissus.FormattingEnabled = True
        Me.CBCoulTissus.Location = New System.Drawing.Point(321, 362)
        Me.CBCoulTissus.Name = "CBCoulTissus"
        Me.CBCoulTissus.Size = New System.Drawing.Size(196, 23)
        Me.CBCoulTissus.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(321, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Couleur Tissus"
        '
        'CBCoulToile
        '
        Me.CBCoulToile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCoulToile.FormattingEnabled = True
        Me.CBCoulToile.Location = New System.Drawing.Point(321, 318)
        Me.CBCoulToile.Name = "CBCoulToile"
        Me.CBCoulToile.Size = New System.Drawing.Size(196, 23)
        Me.CBCoulToile.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(321, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Couleur Toile"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(321, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 21)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nouveau Véhicule"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(77, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 21)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Véhicule Déja Existent"
        '
        'BtNext
        '
        Me.BtNext.Location = New System.Drawing.Point(321, 591)
        Me.BtNext.Name = "BtNext"
        Me.BtNext.Size = New System.Drawing.Size(114, 23)
        Me.BtNext.TabIndex = 14
        Me.BtNext.Text = "Suivant"
        Me.BtNext.UseVisualStyleBackColor = True
        '
        'UCVente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtNext)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CBCoulTissus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBCoulToile)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBCoulVe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBModel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTChoisir)
        Me.Name = "UCVente"
        Me.Size = New System.Drawing.Size(808, 649)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTChoisir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CBModel As ComboBox
    Friend WithEvents CBCoulVe As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CBCoulTissus As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CBCoulToile As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BtNext As Button
End Class
