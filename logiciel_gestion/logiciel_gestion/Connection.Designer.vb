﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connection
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
        Me.btConnection = New System.Windows.Forms.Button()
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btConnection
        '
        Me.btConnection.Location = New System.Drawing.Point(30, 110)
        Me.btConnection.Name = "btConnection"
        Me.btConnection.Size = New System.Drawing.Size(75, 23)
        Me.btConnection.TabIndex = 0
        Me.btConnection.Text = "Connexion"
        Me.btConnection.UseVisualStyleBackColor = True
        '
        'tbUser
        '
        Me.tbUser.Location = New System.Drawing.Point(30, 37)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(100, 23)
        Me.tbUser.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Utilisateur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "mot de passe"
        '
        'tbPass
        '
        Me.tbPass.Location = New System.Drawing.Point(30, 81)
        Me.tbPass.Name = "tbPass"
        Me.tbPass.Size = New System.Drawing.Size(100, 23)
        Me.tbPass.TabIndex = 5
        '
        'Connection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(185, 193)
        Me.Controls.Add(Me.tbPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbUser)
        Me.Controls.Add(Me.btConnection)
        Me.Name = "Connection"
        Me.Text = "Connection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btConnection As Button
    Friend WithEvents tbUser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbPass As TextBox
End Class
