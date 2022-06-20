<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RechercheProduit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RechercheProduit))
        Me.dgvProduit = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBNom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBDescription = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBEmplacement = New System.Windows.Forms.TextBox()
        CType(Me.dgvProduit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProduit
        '
        Me.dgvProduit.AllowUserToAddRows = False
        Me.dgvProduit.AllowUserToDeleteRows = False
        Me.dgvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvProduit.Location = New System.Drawing.Point(0, 109)
        Me.dgvProduit.MultiSelect = False
        Me.dgvProduit.Name = "dgvProduit"
        Me.dgvProduit.ReadOnly = True
        Me.dgvProduit.RowTemplate.Height = 25
        Me.dgvProduit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduit.Size = New System.Drawing.Size(1281, 513)
        Me.dgvProduit.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Recherche"
        '
        'TBID
        '
        Me.TBID.Location = New System.Drawing.Point(12, 62)
        Me.TBID.Name = "TBID"
        Me.TBID.Size = New System.Drawing.Size(220, 23)
        Me.TBID.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID Produit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(238, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nom"
        '
        'TBNom
        '
        Me.TBNom.Location = New System.Drawing.Point(238, 62)
        Me.TBNom.Name = "TBNom"
        Me.TBNom.Size = New System.Drawing.Size(220, 23)
        Me.TBNom.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(464, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Description"
        '
        'TBDescription
        '
        Me.TBDescription.Location = New System.Drawing.Point(464, 62)
        Me.TBDescription.Name = "TBDescription"
        Me.TBDescription.Size = New System.Drawing.Size(220, 23)
        Me.TBDescription.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(690, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Emplacement"
        '
        'TBEmplacement
        '
        Me.TBEmplacement.Location = New System.Drawing.Point(690, 62)
        Me.TBEmplacement.Name = "TBEmplacement"
        Me.TBEmplacement.Size = New System.Drawing.Size(220, 23)
        Me.TBEmplacement.TabIndex = 8
        '
        'RechercheProduit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1281, 622)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBEmplacement)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBNom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvProduit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RechercheProduit"
        Me.Text = "Recherche De Produit"
        CType(Me.dgvProduit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProduit As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TBID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TBNom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBDescription As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBEmplacement As TextBox
End Class
