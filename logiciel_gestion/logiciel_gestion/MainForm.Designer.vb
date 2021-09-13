<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.labPasItem = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btAjoutUc = New System.Windows.Forms.Button()
        Me.btRetirerUc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labPasItem
        '
        Me.labPasItem.AutoSize = True
        Me.labPasItem.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labPasItem.ForeColor = System.Drawing.Color.Red
        Me.labPasItem.Location = New System.Drawing.Point(418, 69)
        Me.labPasItem.Name = "labPasItem"
        Me.labPasItem.Size = New System.Drawing.Size(0, 28)
        Me.labPasItem.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(186, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(653, 491)
        Me.Panel1.TabIndex = 18
        '
        'btAjoutUc
        '
        Me.btAjoutUc.BackColor = System.Drawing.Color.DarkGray
        Me.btAjoutUc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btAjoutUc.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btAjoutUc.Location = New System.Drawing.Point(12, 69)
        Me.btAjoutUc.Name = "btAjoutUc"
        Me.btAjoutUc.Size = New System.Drawing.Size(168, 58)
        Me.btAjoutUc.TabIndex = 19
        Me.btAjoutUc.Text = "AJouter"
        Me.btAjoutUc.UseVisualStyleBackColor = False
        '
        'btRetirerUc
        '
        Me.btRetirerUc.BackColor = System.Drawing.Color.DarkGray
        Me.btRetirerUc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btRetirerUc.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btRetirerUc.Location = New System.Drawing.Point(12, 198)
        Me.btRetirerUc.Name = "btRetirerUc"
        Me.btRetirerUc.Size = New System.Drawing.Size(168, 58)
        Me.btRetirerUc.TabIndex = 20
        Me.btRetirerUc.Text = "Retirer"
        Me.btRetirerUc.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(851, 515)
        Me.Controls.Add(Me.btRetirerUc)
        Me.Controls.Add(Me.btAjoutUc)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.labPasItem)
        Me.MaximumSize = New System.Drawing.Size(867, 554)
        Me.MinimumSize = New System.Drawing.Size(867, 554)
        Me.Name = "MainForm"
        Me.Text = "Reception"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labPasItem As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btAjoutUc As Button
    Friend WithEvents btRetirerUc As Button
End Class
