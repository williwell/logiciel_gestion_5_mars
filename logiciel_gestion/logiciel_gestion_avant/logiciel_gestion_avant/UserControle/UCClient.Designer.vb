<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCClient
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
        Me.DGVClient = New System.Windows.Forms.DataGridView()
        Me.BtCreer = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBPreNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBTel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.TBNom = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DGVClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVClient
        '
        Me.DGVClient.AllowUserToAddRows = False
        Me.DGVClient.AllowUserToDeleteRows = False
        Me.DGVClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVClient.Location = New System.Drawing.Point(3, 125)
        Me.DGVClient.Name = "DGVClient"
        Me.DGVClient.ReadOnly = True
        Me.DGVClient.RowTemplate.Height = 25
        Me.DGVClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVClient.Size = New System.Drawing.Size(1109, 523)
        Me.DGVClient.TabIndex = 0
        '
        'BtCreer
        '
        Me.BtCreer.Location = New System.Drawing.Point(12, 16)
        Me.BtCreer.Name = "BtCreer"
        Me.BtCreer.Size = New System.Drawing.Size(97, 23)
        Me.BtCreer.TabIndex = 1
        Me.BtCreer.Text = "Nouveau Client"
        Me.BtCreer.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Prénom"
        '
        'TBPreNom
        '
        Me.TBPreNom.Location = New System.Drawing.Point(12, 96)
        Me.TBPreNom.Name = "TBPreNom"
        Me.TBPreNom.Size = New System.Drawing.Size(238, 23)
        Me.TBPreNom.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(500, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Téléphone"
        '
        'TBTel
        '
        Me.TBTel.Location = New System.Drawing.Point(500, 96)
        Me.TBTel.Name = "TBTel"
        Me.TBTel.Size = New System.Drawing.Size(238, 23)
        Me.TBTel.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Recherche"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(744, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Email"
        '
        'TBEmail
        '
        Me.TBEmail.Location = New System.Drawing.Point(744, 96)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(238, 23)
        Me.TBEmail.TabIndex = 29
        '
        'TBNom
        '
        Me.TBNom.Location = New System.Drawing.Point(256, 96)
        Me.TBNom.Name = "TBNom"
        Me.TBNom.Size = New System.Drawing.Size(238, 23)
        Me.TBNom.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(256, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 15)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Nom"
        '
        'UCClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBNom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBEmail)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBTel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBPreNom)
        Me.Controls.Add(Me.BtCreer)
        Me.Controls.Add(Me.DGVClient)
        Me.Name = "UCClient"
        Me.Size = New System.Drawing.Size(1115, 651)
        CType(Me.DGVClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVClient As DataGridView
    Friend WithEvents BtCreer As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TBPreNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBTel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TBEmail As TextBox
    Friend WithEvents TBNom As TextBox
    Friend WithEvents Label5 As Label
End Class
