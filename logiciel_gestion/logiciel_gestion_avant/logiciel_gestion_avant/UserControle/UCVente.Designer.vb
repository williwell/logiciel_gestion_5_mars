<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCVente
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
        Me.DTPPre = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBTotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TBTVQ = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBTPS = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TBCout = New System.Windows.Forms.TextBox()
        Me.CBTVQ = New System.Windows.Forms.CheckBox()
        Me.CBTPS = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.NUDEchange = New System.Windows.Forms.NumericUpDown()
        Me.NUDAcompte = New System.Windows.Forms.NumericUpDown()
        CType(Me.NUDEchange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDAcompte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTChoisir
        '
        Me.BTChoisir.Location = New System.Drawing.Point(63, 172)
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
        Me.Label1.Location = New System.Drawing.Point(50, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Véhicule"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(307, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Model"
        '
        'CBModel
        '
        Me.CBModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBModel.FormattingEnabled = True
        Me.CBModel.Location = New System.Drawing.Point(307, 190)
        Me.CBModel.Name = "CBModel"
        Me.CBModel.Size = New System.Drawing.Size(200, 23)
        Me.CBModel.TabIndex = 5
        '
        'CBCoulVe
        '
        Me.CBCoulVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCoulVe.FormattingEnabled = True
        Me.CBCoulVe.Location = New System.Drawing.Point(307, 234)
        Me.CBCoulVe.Name = "CBCoulVe"
        Me.CBCoulVe.Size = New System.Drawing.Size(200, 23)
        Me.CBCoulVe.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(307, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Couleur Véhicule"
        '
        'CBCoulTissus
        '
        Me.CBCoulTissus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCoulTissus.FormattingEnabled = True
        Me.CBCoulTissus.Location = New System.Drawing.Point(307, 322)
        Me.CBCoulTissus.Name = "CBCoulTissus"
        Me.CBCoulTissus.Size = New System.Drawing.Size(200, 23)
        Me.CBCoulTissus.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(307, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Couleur Tissus"
        '
        'CBCoulToile
        '
        Me.CBCoulToile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCoulToile.FormattingEnabled = True
        Me.CBCoulToile.Location = New System.Drawing.Point(307, 278)
        Me.CBCoulToile.Name = "CBCoulToile"
        Me.CBCoulToile.Size = New System.Drawing.Size(200, 23)
        Me.CBCoulToile.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(307, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Couleur Toile"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(307, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 21)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nouveau Véhicule"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(63, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 21)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Véhicule Déja Existent"
        '
        'BtNext
        '
        Me.BtNext.Location = New System.Drawing.Point(797, 559)
        Me.BtNext.Name = "BtNext"
        Me.BtNext.Size = New System.Drawing.Size(114, 23)
        Me.BtNext.TabIndex = 14
        Me.BtNext.Text = "Suivant"
        Me.BtNext.UseVisualStyleBackColor = True
        '
        'DTPPre
        '
        Me.DTPPre.Location = New System.Drawing.Point(307, 366)
        Me.DTPPre.Name = "DTPPre"
        Me.DTPPre.Size = New System.Drawing.Size(200, 23)
        Me.DTPPre.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(307, 348)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Date Prévu Fabrication"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(579, 304)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 15)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Total"
        '
        'TBTotal
        '
        Me.TBTotal.Location = New System.Drawing.Point(579, 322)
        Me.TBTotal.Name = "TBTotal"
        Me.TBTotal.ReadOnly = True
        Me.TBTotal.Size = New System.Drawing.Size(162, 23)
        Me.TBTotal.TabIndex = 45
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(579, 260)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 15)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "TVQ"
        '
        'TBTVQ
        '
        Me.TBTVQ.Location = New System.Drawing.Point(579, 278)
        Me.TBTVQ.Name = "TBTVQ"
        Me.TBTVQ.ReadOnly = True
        Me.TBTVQ.Size = New System.Drawing.Size(162, 23)
        Me.TBTVQ.TabIndex = 43
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(579, 216)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 15)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "TPS"
        '
        'TBTPS
        '
        Me.TBTPS.Location = New System.Drawing.Point(579, 234)
        Me.TBTPS.Name = "TBTPS"
        Me.TBTPS.ReadOnly = True
        Me.TBTPS.Size = New System.Drawing.Size(162, 23)
        Me.TBTPS.TabIndex = 41
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(579, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 15)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Prix"
        '
        'TBCout
        '
        Me.TBCout.Location = New System.Drawing.Point(579, 190)
        Me.TBCout.Name = "TBCout"
        Me.TBCout.ReadOnly = True
        Me.TBCout.Size = New System.Drawing.Size(162, 23)
        Me.TBCout.TabIndex = 39
        '
        'CBTVQ
        '
        Me.CBTVQ.AutoSize = True
        Me.CBTVQ.Location = New System.Drawing.Point(579, 376)
        Me.CBTVQ.Name = "CBTVQ"
        Me.CBTVQ.Size = New System.Drawing.Size(48, 19)
        Me.CBTVQ.TabIndex = 48
        Me.CBTVQ.Text = "TVQ"
        Me.CBTVQ.UseVisualStyleBackColor = True
        '
        'CBTPS
        '
        Me.CBTPS.AutoSize = True
        Me.CBTPS.Location = New System.Drawing.Point(579, 351)
        Me.CBTPS.Name = "CBTPS"
        Me.CBTPS.Size = New System.Drawing.Size(45, 19)
        Me.CBTPS.TabIndex = 47
        Me.CBTPS.Text = "TPS"
        Me.CBTPS.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(797, 216)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 15)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Acompte"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(797, 172)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 15)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Échange"
        '
        'NUDEchange
        '
        Me.NUDEchange.Location = New System.Drawing.Point(797, 191)
        Me.NUDEchange.Name = "NUDEchange"
        Me.NUDEchange.Size = New System.Drawing.Size(162, 23)
        Me.NUDEchange.TabIndex = 53
        '
        'NUDAcompte
        '
        Me.NUDAcompte.Location = New System.Drawing.Point(797, 235)
        Me.NUDAcompte.Name = "NUDAcompte"
        Me.NUDAcompte.Size = New System.Drawing.Size(162, 23)
        Me.NUDAcompte.TabIndex = 54
        '
        'UCVente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.NUDAcompte)
        Me.Controls.Add(Me.NUDEchange)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CBTVQ)
        Me.Controls.Add(Me.CBTPS)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TBTotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TBTVQ)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TBTPS)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TBCout)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DTPPre)
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
        Me.Size = New System.Drawing.Size(1115, 651)
        CType(Me.NUDEchange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDAcompte, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DTPPre As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TBTotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TBTVQ As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TBTPS As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TBCout As TextBox
    Friend WithEvents CBTVQ As CheckBox
    Friend WithEvents CBTPS As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents NUDEchange As NumericUpDown
    Friend WithEvents NUDAcompte As NumericUpDown
End Class
