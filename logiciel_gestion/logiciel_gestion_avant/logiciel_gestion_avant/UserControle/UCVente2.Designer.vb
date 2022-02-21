<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCVente2
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
        Me.DGVOpDispo = New System.Windows.Forms.DataGridView()
        Me.DGVOpCh = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTPrev = New System.Windows.Forms.Button()
        Me.BTNext = New System.Windows.Forms.Button()
        Me.TBCout = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBTPS = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBTVQ = New System.Windows.Forms.TextBox()
        Me.CBTPS = New System.Windows.Forms.CheckBox()
        Me.CBTVQ = New System.Windows.Forms.CheckBox()
        CType(Me.DGVOpDispo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVOpCh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVOpDispo
        '
        Me.DGVOpDispo.AllowUserToAddRows = False
        Me.DGVOpDispo.AllowUserToDeleteRows = False
        Me.DGVOpDispo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOpDispo.Location = New System.Drawing.Point(22, 82)
        Me.DGVOpDispo.Name = "DGVOpDispo"
        Me.DGVOpDispo.ReadOnly = True
        Me.DGVOpDispo.RowTemplate.Height = 25
        Me.DGVOpDispo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVOpDispo.Size = New System.Drawing.Size(893, 242)
        Me.DGVOpDispo.TabIndex = 0
        '
        'DGVOpCh
        '
        Me.DGVOpCh.AllowUserToAddRows = False
        Me.DGVOpCh.AllowUserToDeleteRows = False
        Me.DGVOpCh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOpCh.Location = New System.Drawing.Point(22, 345)
        Me.DGVOpCh.Name = "DGVOpCh"
        Me.DGVOpCh.ReadOnly = True
        Me.DGVOpCh.RowTemplate.Height = 25
        Me.DGVOpCh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVOpCh.Size = New System.Drawing.Size(893, 242)
        Me.DGVOpCh.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Option Disponible"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 327)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Option Choisie"
        '
        'BTPrev
        '
        Me.BTPrev.Location = New System.Drawing.Point(254, 605)
        Me.BTPrev.Name = "BTPrev"
        Me.BTPrev.Size = New System.Drawing.Size(114, 23)
        Me.BTPrev.TabIndex = 30
        Me.BTPrev.Text = "Précédent"
        Me.BTPrev.UseVisualStyleBackColor = True
        '
        'BTNext
        '
        Me.BTNext.Location = New System.Drawing.Point(511, 605)
        Me.BTNext.Name = "BTNext"
        Me.BTNext.Size = New System.Drawing.Size(114, 23)
        Me.BTNext.TabIndex = 29
        Me.BTNext.Text = "Suivant"
        Me.BTNext.UseVisualStyleBackColor = True
        '
        'TBCout
        '
        Me.TBCout.Location = New System.Drawing.Point(938, 345)
        Me.TBCout.Name = "TBCout"
        Me.TBCout.ReadOnly = True
        Me.TBCout.Size = New System.Drawing.Size(162, 23)
        Me.TBCout.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(938, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 15)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Prix"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(938, 371)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 15)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "TPS"
        '
        'TBTPS
        '
        Me.TBTPS.Location = New System.Drawing.Point(938, 389)
        Me.TBTPS.Name = "TBTPS"
        Me.TBTPS.ReadOnly = True
        Me.TBTPS.Size = New System.Drawing.Size(162, 23)
        Me.TBTPS.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(938, 459)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 15)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Total"
        '
        'TBTotal
        '
        Me.TBTotal.Location = New System.Drawing.Point(938, 477)
        Me.TBTotal.Name = "TBTotal"
        Me.TBTotal.ReadOnly = True
        Me.TBTotal.Size = New System.Drawing.Size(162, 23)
        Me.TBTotal.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(938, 415)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 15)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "TVQ"
        '
        'TBTVQ
        '
        Me.TBTVQ.Location = New System.Drawing.Point(938, 433)
        Me.TBTVQ.Name = "TBTVQ"
        Me.TBTVQ.ReadOnly = True
        Me.TBTVQ.Size = New System.Drawing.Size(162, 23)
        Me.TBTVQ.TabIndex = 35
        '
        'CBTPS
        '
        Me.CBTPS.AutoSize = True
        Me.CBTPS.Location = New System.Drawing.Point(938, 506)
        Me.CBTPS.Name = "CBTPS"
        Me.CBTPS.Size = New System.Drawing.Size(45, 19)
        Me.CBTPS.TabIndex = 39
        Me.CBTPS.Text = "TPS"
        Me.CBTPS.UseVisualStyleBackColor = True
        '
        'CBTVQ
        '
        Me.CBTVQ.AutoSize = True
        Me.CBTVQ.Location = New System.Drawing.Point(938, 531)
        Me.CBTVQ.Name = "CBTVQ"
        Me.CBTVQ.Size = New System.Drawing.Size(48, 19)
        Me.CBTVQ.TabIndex = 40
        Me.CBTVQ.Text = "TVQ"
        Me.CBTVQ.UseVisualStyleBackColor = True
        '
        'UCVente2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CBTVQ)
        Me.Controls.Add(Me.CBTPS)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBTVQ)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TBTPS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBCout)
        Me.Controls.Add(Me.BTPrev)
        Me.Controls.Add(Me.BTNext)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVOpCh)
        Me.Controls.Add(Me.DGVOpDispo)
        Me.Name = "UCVente2"
        Me.Size = New System.Drawing.Size(1115, 651)
        CType(Me.DGVOpDispo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVOpCh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVOpDispo As DataGridView
    Friend WithEvents DGVOpCh As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BTPrev As Button
    Friend WithEvents BTNext As Button
    Friend WithEvents TBCout As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TBTPS As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBTVQ As TextBox
    Friend WithEvents CBTPS As CheckBox
    Friend WithEvents CBTVQ As CheckBox
End Class
