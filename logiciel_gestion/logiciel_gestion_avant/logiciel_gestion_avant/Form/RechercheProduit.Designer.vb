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
        CType(Me.dgvProduit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProduit
        '
        Me.dgvProduit.AllowUserToAddRows = False
        Me.dgvProduit.AllowUserToDeleteRows = False
        Me.dgvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProduit.Location = New System.Drawing.Point(0, 0)
        Me.dgvProduit.MultiSelect = False
        Me.dgvProduit.Name = "dgvProduit"
        Me.dgvProduit.ReadOnly = True
        Me.dgvProduit.RowTemplate.Height = 25
        Me.dgvProduit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduit.Size = New System.Drawing.Size(1000, 478)
        Me.dgvProduit.TabIndex = 0
        '
        'RechercheProduit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1000, 478)
        Me.Controls.Add(Me.dgvProduit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RechercheProduit"
        Me.Text = "Recherche De Produit"
        CType(Me.dgvProduit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvProduit As DataGridView
End Class
