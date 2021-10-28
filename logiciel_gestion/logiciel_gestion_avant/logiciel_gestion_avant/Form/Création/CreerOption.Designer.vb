<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreerOption
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.DGVItemOption = New System.Windows.Forms.DataGridView()
        Me.TBNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGVItemAdd = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NUDCout = New System.Windows.Forms.NumericUpDown()
        Me.BtSave = New System.Windows.Forms.Button()
        CType(Me.DGVItemOption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVItemAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDCout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVItemOption
        '
        Me.DGVItemOption.AllowUserToAddRows = False
        Me.DGVItemOption.AllowUserToDeleteRows = False
        Me.DGVItemOption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVItemOption.Location = New System.Drawing.Point(45, 179)
        Me.DGVItemOption.Name = "DGVItemOption"
        Me.DGVItemOption.RowTemplate.Height = 25
        Me.DGVItemOption.Size = New System.Drawing.Size(456, 268)
        Me.DGVItemOption.TabIndex = 2
        '
        'TBNom
        '
        Me.TBNom.Location = New System.Drawing.Point(45, 91)
        Me.TBNom.Name = "TBNom"
        Me.TBNom.Size = New System.Drawing.Size(184, 23)
        Me.TBNom.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cout"
        '
        'DGVItemAdd
        '
        Me.DGVItemAdd.AllowUserToAddRows = False
        Me.DGVItemAdd.AllowUserToDeleteRows = False
        Me.DGVItemAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVItemAdd.Location = New System.Drawing.Point(614, 179)
        Me.DGVItemAdd.Name = "DGVItemAdd"
        Me.DGVItemAdd.ReadOnly = True
        Me.DGVItemAdd.RowTemplate.Height = 25
        Me.DGVItemAdd.Size = New System.Drawing.Size(456, 268)
        Me.DGVItemAdd.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Équipement utilisé"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(614, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Équipement non utilisé"
        '
        'NUDCout
        '
        Me.NUDCout.DecimalPlaces = 2
        Me.NUDCout.Location = New System.Drawing.Point(45, 135)
        Me.NUDCout.Name = "NUDCout"
        Me.NUDCout.Size = New System.Drawing.Size(184, 23)
        Me.NUDCout.TabIndex = 10
        '
        'BtSave
        '
        Me.BtSave.Location = New System.Drawing.Point(45, 453)
        Me.BtSave.Name = "BtSave"
        Me.BtSave.Size = New System.Drawing.Size(184, 23)
        Me.BtSave.TabIndex = 11
        Me.BtSave.Text = "Enregistrer"
        Me.BtSave.UseVisualStyleBackColor = True
        '
        'CreerOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 556)
        Me.Controls.Add(Me.BtSave)
        Me.Controls.Add(Me.NUDCout)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGVItemAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBNom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVItemOption)
        Me.Name = "CreerOption"
        Me.Text = "Créer nouvelle Option"
        CType(Me.DGVItemOption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVItemAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDCout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVItemOption As DataGridView
    Friend WithEvents TBNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DGVItemAdd As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NUDCout As NumericUpDown
    Friend WithEvents BtSave As Button
End Class
