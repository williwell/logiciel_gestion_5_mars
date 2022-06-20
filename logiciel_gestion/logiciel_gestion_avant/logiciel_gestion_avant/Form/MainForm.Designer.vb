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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PanUC = New System.Windows.Forms.Panel()
        Me.PanCommande = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BTCreerCommande = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PanGestVeh = New System.Windows.Forms.Panel()
        Me.BTLivrer = New System.Windows.Forms.Button()
        Me.BTGest = New System.Windows.Forms.Button()
        Me.PanCouleur = New System.Windows.Forms.Panel()
        Me.BTCoulTissu = New System.Windows.Forms.Button()
        Me.BTCoulToile = New System.Windows.Forms.Button()
        Me.BTCoulModel = New System.Windows.Forms.Button()
        Me.btMenu = New System.Windows.Forms.Button()
        Me.panMenu = New System.Windows.Forms.Panel()
        Me.BTFacture = New System.Windows.Forms.Button()
        Me.BTTache = New System.Windows.Forms.Button()
        Me.BTVehicule = New System.Windows.Forms.Button()
        Me.BtClient = New System.Windows.Forms.Button()
        Me.BtOptionModel = New System.Windows.Forms.Button()
        Me.BtCouleur = New System.Windows.Forms.Button()
        Me.btModel = New System.Windows.Forms.Button()
        Me.btFour = New System.Windows.Forms.Button()
        Me.btVente = New System.Windows.Forms.Button()
        Me.btInventaire = New System.Windows.Forms.Button()
        Me.btAccueil = New System.Windows.Forms.Button()
        Me.lbNonConc = New System.Windows.Forms.Label()
        Me.btConnec = New System.Windows.Forms.Button()
        Me.PanUC.SuspendLayout()
        Me.PanCommande.SuspendLayout()
        Me.PanGestVeh.SuspendLayout()
        Me.PanCouleur.SuspendLayout()
        Me.panMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanUC
        '
        Me.PanUC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanUC.Controls.Add(Me.PanCommande)
        Me.PanUC.Controls.Add(Me.ProgressBar1)
        Me.PanUC.Controls.Add(Me.PanGestVeh)
        Me.PanUC.Controls.Add(Me.PanCouleur)
        Me.PanUC.Location = New System.Drawing.Point(12, 36)
        Me.PanUC.Name = "PanUC"
        Me.PanUC.Size = New System.Drawing.Size(1115, 651)
        Me.PanUC.TabIndex = 1
        '
        'PanCommande
        '
        Me.PanCommande.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanCommande.Controls.Add(Me.Button3)
        Me.PanCommande.Controls.Add(Me.BTCreerCommande)
        Me.PanCommande.Location = New System.Drawing.Point(93, 86)
        Me.PanCommande.Name = "PanCommande"
        Me.PanCommande.Size = New System.Drawing.Size(108, 61)
        Me.PanCommande.TabIndex = 14
        Me.PanCommande.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(8, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Liste Comm"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BTCreerCommande
        '
        Me.BTCreerCommande.Location = New System.Drawing.Point(8, 3)
        Me.BTCreerCommande.Name = "BTCreerCommande"
        Me.BTCreerCommande.Size = New System.Drawing.Size(94, 23)
        Me.BTCreerCommande.TabIndex = 0
        Me.BTCreerCommande.Text = "Nouveau"
        Me.BTCreerCommande.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(390, 264)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(277, 23)
        Me.ProgressBar1.TabIndex = 6
        '
        'PanGestVeh
        '
        Me.PanGestVeh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanGestVeh.Controls.Add(Me.BTLivrer)
        Me.PanGestVeh.Controls.Add(Me.BTGest)
        Me.PanGestVeh.Location = New System.Drawing.Point(93, 231)
        Me.PanGestVeh.Name = "PanGestVeh"
        Me.PanGestVeh.Size = New System.Drawing.Size(108, 61)
        Me.PanGestVeh.TabIndex = 11
        Me.PanGestVeh.Visible = False
        '
        'BTLivrer
        '
        Me.BTLivrer.Location = New System.Drawing.Point(8, 32)
        Me.BTLivrer.Name = "BTLivrer"
        Me.BTLivrer.Size = New System.Drawing.Size(94, 23)
        Me.BTLivrer.TabIndex = 1
        Me.BTLivrer.Text = "Liste Fabriquer"
        Me.BTLivrer.UseVisualStyleBackColor = True
        '
        'BTGest
        '
        Me.BTGest.Location = New System.Drawing.Point(8, 3)
        Me.BTGest.Name = "BTGest"
        Me.BTGest.Size = New System.Drawing.Size(94, 23)
        Me.BTGest.TabIndex = 0
        Me.BTGest.Text = "Gestion"
        Me.BTGest.UseVisualStyleBackColor = True
        '
        'PanCouleur
        '
        Me.PanCouleur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanCouleur.Controls.Add(Me.BTCoulTissu)
        Me.PanCouleur.Controls.Add(Me.BTCoulToile)
        Me.PanCouleur.Controls.Add(Me.BTCoulModel)
        Me.PanCouleur.Location = New System.Drawing.Point(93, 149)
        Me.PanCouleur.Name = "PanCouleur"
        Me.PanCouleur.Size = New System.Drawing.Size(107, 89)
        Me.PanCouleur.TabIndex = 10
        Me.PanCouleur.Visible = False
        '
        'BTCoulTissu
        '
        Me.BTCoulTissu.Location = New System.Drawing.Point(9, 61)
        Me.BTCoulTissu.Name = "BTCoulTissu"
        Me.BTCoulTissu.Size = New System.Drawing.Size(94, 23)
        Me.BTCoulTissu.TabIndex = 2
        Me.BTCoulTissu.Text = "Tissus"
        Me.BTCoulTissu.UseVisualStyleBackColor = True
        '
        'BTCoulToile
        '
        Me.BTCoulToile.Location = New System.Drawing.Point(9, 32)
        Me.BTCoulToile.Name = "BTCoulToile"
        Me.BTCoulToile.Size = New System.Drawing.Size(94, 23)
        Me.BTCoulToile.TabIndex = 1
        Me.BTCoulToile.Text = "Toile"
        Me.BTCoulToile.UseVisualStyleBackColor = True
        '
        'BTCoulModel
        '
        Me.BTCoulModel.Location = New System.Drawing.Point(9, 3)
        Me.BTCoulModel.Name = "BTCoulModel"
        Me.BTCoulModel.Size = New System.Drawing.Size(94, 23)
        Me.BTCoulModel.TabIndex = 0
        Me.BTCoulModel.Text = "Model"
        Me.BTCoulModel.UseVisualStyleBackColor = True
        '
        'btMenu
        '
        Me.btMenu.Location = New System.Drawing.Point(3, 3)
        Me.btMenu.Name = "btMenu"
        Me.btMenu.Size = New System.Drawing.Size(94, 23)
        Me.btMenu.TabIndex = 0
        Me.btMenu.Text = "Menu"
        Me.btMenu.UseVisualStyleBackColor = True
        '
        'panMenu
        '
        Me.panMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panMenu.Controls.Add(Me.BTFacture)
        Me.panMenu.Controls.Add(Me.BTTache)
        Me.panMenu.Controls.Add(Me.BTVehicule)
        Me.panMenu.Controls.Add(Me.BtClient)
        Me.panMenu.Controls.Add(Me.BtOptionModel)
        Me.panMenu.Controls.Add(Me.BtCouleur)
        Me.panMenu.Controls.Add(Me.btModel)
        Me.panMenu.Controls.Add(Me.btFour)
        Me.panMenu.Controls.Add(Me.btVente)
        Me.panMenu.Controls.Add(Me.btInventaire)
        Me.panMenu.Controls.Add(Me.btAccueil)
        Me.panMenu.Controls.Add(Me.btMenu)
        Me.panMenu.Location = New System.Drawing.Point(12, 7)
        Me.panMenu.MaximumSize = New System.Drawing.Size(100, 348)
        Me.panMenu.MinimumSize = New System.Drawing.Size(100, 30)
        Me.panMenu.Name = "panMenu"
        Me.panMenu.Size = New System.Drawing.Size(100, 348)
        Me.panMenu.TabIndex = 2
        '
        'BTFacture
        '
        Me.BTFacture.Location = New System.Drawing.Point(3, 319)
        Me.BTFacture.Name = "BTFacture"
        Me.BTFacture.Size = New System.Drawing.Size(94, 23)
        Me.BTFacture.TabIndex = 11
        Me.BTFacture.Text = "Liste Factures"
        Me.BTFacture.UseVisualStyleBackColor = True
        '
        'BTTache
        '
        Me.BTTache.Location = New System.Drawing.Point(2, 290)
        Me.BTTache.Name = "BTTache"
        Me.BTTache.Size = New System.Drawing.Size(94, 23)
        Me.BTTache.TabIndex = 10
        Me.BTTache.Text = "Tâches"
        Me.BTTache.UseVisualStyleBackColor = True
        '
        'BTVehicule
        '
        Me.BTVehicule.Location = New System.Drawing.Point(2, 261)
        Me.BTVehicule.Name = "BTVehicule"
        Me.BTVehicule.Size = New System.Drawing.Size(94, 23)
        Me.BTVehicule.TabIndex = 9
        Me.BTVehicule.Text = "Véhicule"
        Me.BTVehicule.UseVisualStyleBackColor = True
        '
        'BtClient
        '
        Me.BtClient.Location = New System.Drawing.Point(2, 232)
        Me.BtClient.Name = "BtClient"
        Me.BtClient.Size = New System.Drawing.Size(94, 23)
        Me.BtClient.TabIndex = 8
        Me.BtClient.Text = "Client"
        Me.BtClient.UseVisualStyleBackColor = True
        '
        'BtOptionModel
        '
        Me.BtOptionModel.Location = New System.Drawing.Point(3, 206)
        Me.BtOptionModel.Name = "BtOptionModel"
        Me.BtOptionModel.Size = New System.Drawing.Size(94, 23)
        Me.BtOptionModel.TabIndex = 7
        Me.BtOptionModel.Text = "Option Model"
        Me.BtOptionModel.UseVisualStyleBackColor = True
        '
        'BtCouleur
        '
        Me.BtCouleur.Location = New System.Drawing.Point(3, 177)
        Me.BtCouleur.Name = "BtCouleur"
        Me.BtCouleur.Size = New System.Drawing.Size(94, 23)
        Me.BtCouleur.TabIndex = 6
        Me.BtCouleur.Text = "Couleur"
        Me.BtCouleur.UseVisualStyleBackColor = True
        '
        'btModel
        '
        Me.btModel.Location = New System.Drawing.Point(3, 148)
        Me.btModel.Name = "btModel"
        Me.btModel.Size = New System.Drawing.Size(94, 23)
        Me.btModel.TabIndex = 5
        Me.btModel.Text = "Model"
        Me.btModel.UseVisualStyleBackColor = True
        '
        'btFour
        '
        Me.btFour.Location = New System.Drawing.Point(3, 90)
        Me.btFour.Name = "btFour"
        Me.btFour.Size = New System.Drawing.Size(94, 23)
        Me.btFour.TabIndex = 4
        Me.btFour.Text = "Fournisseur"
        Me.btFour.UseVisualStyleBackColor = True
        '
        'btVente
        '
        Me.btVente.Location = New System.Drawing.Point(3, 119)
        Me.btVente.Name = "btVente"
        Me.btVente.Size = New System.Drawing.Size(94, 23)
        Me.btVente.TabIndex = 3
        Me.btVente.Text = "Commande"
        Me.btVente.UseVisualStyleBackColor = True
        '
        'btInventaire
        '
        Me.btInventaire.Location = New System.Drawing.Point(3, 61)
        Me.btInventaire.Name = "btInventaire"
        Me.btInventaire.Size = New System.Drawing.Size(94, 23)
        Me.btInventaire.TabIndex = 2
        Me.btInventaire.Text = "Inventaire"
        Me.btInventaire.UseVisualStyleBackColor = True
        '
        'btAccueil
        '
        Me.btAccueil.Location = New System.Drawing.Point(3, 32)
        Me.btAccueil.Name = "btAccueil"
        Me.btAccueil.Size = New System.Drawing.Size(94, 23)
        Me.btAccueil.TabIndex = 1
        Me.btAccueil.Text = "Accueil"
        Me.btAccueil.UseVisualStyleBackColor = True
        '
        'lbNonConc
        '
        Me.lbNonConc.AutoSize = True
        Me.lbNonConc.Location = New System.Drawing.Point(265, 14)
        Me.lbNonConc.Name = "lbNonConc"
        Me.lbNonConc.Size = New System.Drawing.Size(0, 15)
        Me.lbNonConc.TabIndex = 3
        '
        'btConnec
        '
        Me.btConnec.Location = New System.Drawing.Point(483, 7)
        Me.btConnec.Name = "btConnec"
        Me.btConnec.Size = New System.Drawing.Size(94, 23)
        Me.btConnec.TabIndex = 5
        Me.btConnec.Text = "Connecter"
        Me.btConnec.UseVisualStyleBackColor = True
        Me.btConnec.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1139, 699)
        Me.Controls.Add(Me.btConnec)
        Me.Controls.Add(Me.lbNonConc)
        Me.Controls.Add(Me.panMenu)
        Me.Controls.Add(Me.PanUC)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1155, 738)
        Me.MinimumSize = New System.Drawing.Size(1155, 738)
        Me.Name = "MainForm"
        Me.Text = "Logiciel Gestion 5-Mars VR"
        Me.PanUC.ResumeLayout(False)
        Me.PanCommande.ResumeLayout(False)
        Me.PanGestVeh.ResumeLayout(False)
        Me.PanCouleur.ResumeLayout(False)
        Me.panMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanUC As Panel
    Friend WithEvents btMenu As Button
    Friend WithEvents panMenu As Panel
    Friend WithEvents btVente As Button
    Friend WithEvents btInventaire As Button
    Friend WithEvents btAccueil As Button
    Friend WithEvents btFour As Button
    Friend WithEvents lbNonConc As Label
    Friend WithEvents btConnec As Button
    Friend WithEvents btModel As Button
    Friend WithEvents BtOptionModel As Button
    Friend WithEvents BtCouleur As Button
    Friend WithEvents BtClient As Button
    Friend WithEvents PanCouleur As Panel
    Friend WithEvents BTCoulTissu As Button
    Friend WithEvents BTCoulToile As Button
    Friend WithEvents BTCoulModel As Button
    Friend WithEvents BTVehicule As Button
    Friend WithEvents PanGestVeh As Panel
    Friend WithEvents BTLivrer As Button
    Friend WithEvents BTGest As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents BTTache As Button
    Friend WithEvents BTFacture As Button
    Friend WithEvents PanCommande As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents BTCreerCommande As Button
End Class
