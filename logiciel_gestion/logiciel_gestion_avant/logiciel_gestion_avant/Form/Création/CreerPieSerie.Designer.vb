<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreerPieSerie
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
        Me.BTSave = New System.Windows.Forms.Button()
        Me.BTAnnuler = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBNom = New System.Windows.Forms.TextBox()
        Me.TBModel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTPInstall = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBNoSerie = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTSave
        '
        Me.BTSave.Location = New System.Drawing.Point(37, 209)
        Me.BTSave.Name = "BTSave"
        Me.BTSave.Size = New System.Drawing.Size(102, 23)
        Me.BTSave.TabIndex = 6
        Me.BTSave.Text = "Enregistrer"
        Me.BTSave.UseVisualStyleBackColor = True
        '
        'BTAnnuler
        '
        Me.BTAnnuler.Location = New System.Drawing.Point(158, 209)
        Me.BTAnnuler.Name = "BTAnnuler"
        Me.BTAnnuler.Size = New System.Drawing.Size(102, 23)
        Me.BTAnnuler.TabIndex = 7
        Me.BTAnnuler.Text = "Annuler"
        Me.BTAnnuler.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nom de la pièce"
        '
        'TBNom
        '
        Me.TBNom.Location = New System.Drawing.Point(37, 92)
        Me.TBNom.Name = "TBNom"
        Me.TBNom.Size = New System.Drawing.Size(223, 23)
        Me.TBNom.TabIndex = 1
        '
        'TBModel
        '
        Me.TBModel.Location = New System.Drawing.Point(37, 136)
        Me.TBModel.Name = "TBModel"
        Me.TBModel.Size = New System.Drawing.Size(223, 23)
        Me.TBModel.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Model de la pièce"
        '
        'DTPInstall
        '
        Me.DTPInstall.Location = New System.Drawing.Point(37, 180)
        Me.DTPInstall.Name = "DTPInstall"
        Me.DTPInstall.Size = New System.Drawing.Size(223, 23)
        Me.DTPInstall.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Date d'installation"
        '
        'TBNoSerie
        '
        Me.TBNoSerie.Location = New System.Drawing.Point(37, 48)
        Me.TBNoSerie.Name = "TBNoSerie"
        Me.TBNoSerie.Size = New System.Drawing.Size(223, 23)
        Me.TBNoSerie.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Numéro de série pièce"
        '
        'CreerPieSerie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 265)
        Me.Controls.Add(Me.TBNoSerie)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DTPInstall)
        Me.Controls.Add(Me.TBModel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBNom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTAnnuler)
        Me.Controls.Add(Me.BTSave)
        Me.Name = "CreerPieSerie"
        Me.Text = "Créer Pièce"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTSave As Button
    Friend WithEvents BTAnnuler As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TBNom As TextBox
    Friend WithEvents TBModel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DTPInstall As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents TBNoSerie As TextBox
    Friend WithEvents Label4 As Label
End Class
