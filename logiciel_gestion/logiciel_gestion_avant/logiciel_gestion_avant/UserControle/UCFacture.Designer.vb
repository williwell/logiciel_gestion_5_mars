<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCFacture
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
        Me.DGVFacture = New System.Windows.Forms.DataGridView()
        Me.TBFacture = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBModel = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBDate = New System.Windows.Forms.CheckBox()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBMatricule = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBClient = New System.Windows.Forms.TextBox()
        CType(Me.DGVFacture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVFacture
        '
        Me.DGVFacture.AllowUserToAddRows = False
        Me.DGVFacture.AllowUserToDeleteRows = False
        Me.DGVFacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVFacture.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGVFacture.Location = New System.Drawing.Point(0, 61)
        Me.DGVFacture.Name = "DGVFacture"
        Me.DGVFacture.ReadOnly = True
        Me.DGVFacture.RowTemplate.Height = 25
        Me.DGVFacture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVFacture.Size = New System.Drawing.Size(1115, 590)
        Me.DGVFacture.TabIndex = 0
        '
        'TBFacture
        '
        Me.TBFacture.Location = New System.Drawing.Point(82, 32)
        Me.TBFacture.Name = "TBFacture"
        Me.TBFacture.Size = New System.Drawing.Size(200, 23)
        Me.TBFacture.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Recherche"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "No Facture"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(288, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Model"
        '
        'CBModel
        '
        Me.CBModel.FormattingEnabled = True
        Me.CBModel.Location = New System.Drawing.Point(288, 32)
        Me.CBModel.Name = "CBModel"
        Me.CBModel.Size = New System.Drawing.Size(200, 23)
        Me.CBModel.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(906, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Date Facture"
        '
        'CBDate
        '
        Me.CBDate.AutoSize = True
        Me.CBDate.Checked = True
        Me.CBDate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBDate.Location = New System.Drawing.Point(985, 13)
        Me.CBDate.Name = "CBDate"
        Me.CBDate.Size = New System.Drawing.Size(112, 19)
        Me.CBDate.TabIndex = 9
        Me.CBDate.Text = "Toutes Les Dates"
        Me.CBDate.UseVisualStyleBackColor = True
        '
        'DTP
        '
        Me.DTP.Enabled = False
        Me.DTP.Location = New System.Drawing.Point(906, 32)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(200, 23)
        Me.DTP.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(494, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Matricule Véhicule"
        '
        'TBMatricule
        '
        Me.TBMatricule.Location = New System.Drawing.Point(494, 32)
        Me.TBMatricule.Name = "TBMatricule"
        Me.TBMatricule.Size = New System.Drawing.Size(200, 23)
        Me.TBMatricule.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(700, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Nom Client"
        '
        'TBClient
        '
        Me.TBClient.Location = New System.Drawing.Point(700, 32)
        Me.TBClient.Name = "TBClient"
        Me.TBClient.Size = New System.Drawing.Size(200, 23)
        Me.TBClient.TabIndex = 13
        '
        'UCFacture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBClient)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBMatricule)
        Me.Controls.Add(Me.DTP)
        Me.Controls.Add(Me.CBDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBModel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBFacture)
        Me.Controls.Add(Me.DGVFacture)
        Me.Name = "UCFacture"
        Me.Size = New System.Drawing.Size(1115, 651)
        CType(Me.DGVFacture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVFacture As DataGridView
    Friend WithEvents TBFacture As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CBModel As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CBDate As CheckBox
    Friend WithEvents DTP As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents TBMatricule As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBClient As TextBox
End Class
