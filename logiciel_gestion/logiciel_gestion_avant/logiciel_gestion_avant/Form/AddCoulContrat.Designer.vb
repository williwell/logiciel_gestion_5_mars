<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCoulContrat
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
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.TBNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTAdd = New System.Windows.Forms.Button()
        Me.BTEnd = New System.Windows.Forms.Button()
        Me.BTDelete = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBCouleur = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBCode = New System.Windows.Forms.TextBox()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(210, 12)
        Me.DGV.Name = "DGV"
        Me.DGV.RowTemplate.Height = 25
        Me.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV.Size = New System.Drawing.Size(504, 244)
        Me.DGV.TabIndex = 0
        '
        'TBNom
        '
        Me.TBNom.Location = New System.Drawing.Point(12, 30)
        Me.TBNom.Name = "TBNom"
        Me.TBNom.Size = New System.Drawing.Size(192, 23)
        Me.TBNom.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nom"
        '
        'BTAdd
        '
        Me.BTAdd.Location = New System.Drawing.Point(12, 147)
        Me.BTAdd.Name = "BTAdd"
        Me.BTAdd.Size = New System.Drawing.Size(106, 23)
        Me.BTAdd.TabIndex = 3
        Me.BTAdd.Text = "Ajouter"
        Me.BTAdd.UseVisualStyleBackColor = True
        '
        'BTEnd
        '
        Me.BTEnd.Location = New System.Drawing.Point(12, 262)
        Me.BTEnd.Name = "BTEnd"
        Me.BTEnd.Size = New System.Drawing.Size(106, 23)
        Me.BTEnd.TabIndex = 4
        Me.BTEnd.Text = "Terminer"
        Me.BTEnd.UseVisualStyleBackColor = True
        '
        'BTDelete
        '
        Me.BTDelete.Location = New System.Drawing.Point(210, 262)
        Me.BTDelete.Name = "BTDelete"
        Me.BTDelete.Size = New System.Drawing.Size(106, 23)
        Me.BTDelete.TabIndex = 5
        Me.BTDelete.Text = "Enlever"
        Me.BTDelete.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Couleur"
        '
        'TBCouleur
        '
        Me.TBCouleur.Location = New System.Drawing.Point(12, 74)
        Me.TBCouleur.Name = "TBCouleur"
        Me.TBCouleur.Size = New System.Drawing.Size(192, 23)
        Me.TBCouleur.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Code Couleur (Optionnel)"
        '
        'TBCode
        '
        Me.TBCode.Location = New System.Drawing.Point(12, 118)
        Me.TBCode.Name = "TBCode"
        Me.TBCode.Size = New System.Drawing.Size(192, 23)
        Me.TBCode.TabIndex = 8
        '
        'AddCoulContrat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 290)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBCouleur)
        Me.Controls.Add(Me.BTDelete)
        Me.Controls.Add(Me.BTEnd)
        Me.Controls.Add(Me.BTAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBNom)
        Me.Controls.Add(Me.DGV)
        Me.Name = "AddCoulContrat"
        Me.Text = "AddCoulContrat"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents TBNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTAdd As Button
    Friend WithEvents BTEnd As Button
    Friend WithEvents BTDelete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TBCouleur As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBCode As TextBox
End Class
