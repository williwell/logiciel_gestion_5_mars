<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListeVehicule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListeVehicule))
        Me.DGVVehicule = New System.Windows.Forms.DataGridView()
        CType(Me.DGVVehicule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVVehicule
        '
        Me.DGVVehicule.AllowUserToAddRows = False
        Me.DGVVehicule.AllowUserToDeleteRows = False
        Me.DGVVehicule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVehicule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVVehicule.Location = New System.Drawing.Point(0, 0)
        Me.DGVVehicule.Name = "DGVVehicule"
        Me.DGVVehicule.ReadOnly = True
        Me.DGVVehicule.RowTemplate.Height = 25
        Me.DGVVehicule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVVehicule.Size = New System.Drawing.Size(1120, 519)
        Me.DGVVehicule.TabIndex = 0
        '
        'ListeVehicule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 519)
        Me.Controls.Add(Me.DGVVehicule)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListeVehicule"
        Me.Text = "Liste Vehicule"
        CType(Me.DGVVehicule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVVehicule As DataGridView
End Class
