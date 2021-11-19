
Imports System.ComponentModel

Public Class MainForm

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    Shared instance As MainForm = Nothing
    ReadOnly keyCombo As New List(Of Keys)({Keys.ControlKey, Keys.H, Keys.P})
    ReadOnly currentKeys As New List(Of Keys)
    Dim options As New StructureOption.MesOption
    ReadOnly ucAccueil As New UCAccueil(Me)
    ReadOnly ucInventaire As New UCInventaire(Me)
    ReadOnly ucVente As New UCVente(Me)
    ReadOnly ucFour As New UCFournisseur(Me, ucInventaire)
    ReadOnly ucModel As New UCGestionModel(Me)
    ReadOnly ucCouleur As New UCCouleur(Me)
    ReadOnly ucOption As New UCOption(Me)
    ReadOnly ucClient As New UCClient(Me)
    ReadOnly ucCoulToile As New UCCouleurToile(Me)
    ReadOnly ucCoulTissus As New UCCouleurTissus(Me)
    Dim ucVente2 As UCVente2
    Dim ucVente3 As UCVente3
    ReadOnly ucGestVeh As New UCGestionVehicule(Me)
    Private Delegate Sub setValue(text As String)


    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        MyOption.GetInstance.ReadOption()
        panMenu.Size = panMenu.MinimumSize
        ConnectionServeur.SetMain(Me)
        If ConnectionServeur.Getinstance.TestConnection() Then
            panMenu.Size = panMenu.MinimumSize
            AddUC()
        Else
            lbNonConc.Text = "Impossible de se connecter au serveur!"
            btConnec.Visible = True
            btMenu.Enabled = False
        End If
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________
    Private Sub AddUC()
        PanUC.Controls.Add(ucAccueil)
        PanUC.Controls.Add(ucInventaire)
        PanUC.Controls.Add(ucVente)
        PanUC.Controls.Add(ucFour)
        PanUC.Controls.Add(ucModel)
        PanUC.Controls.Add(ucCouleur)
        PanUC.Controls.Add(ucOption)
        PanUC.Controls.Add(ucClient)
        PanUC.Controls.Add(ucCoulToile)
        PanUC.Controls.Add(ucCoulTissus)
        PanUC.Controls.Add(ucVente2)
        PanUC.Controls.Add(ucVente3)
        PanUC.Controls.Add(ucGestVeh)
        ucAccueil.RowsColor()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        currentKeys.Add(e.KeyCode)

        If currentKeys.Intersect(keyCombo).Count = keyCombo.Count Then
            currentKeys.Clear()
            Dim connection As New Connection(Me)
            Me.Hide()
            connection.Show()
        End If

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        currentKeys.Remove(e.KeyCode)
    End Sub


    Private Sub BtMenu_Click(sender As Object, e As EventArgs) Handles btMenu.Click
        If panMenu.Size = panMenu.MinimumSize Then
            panMenu.Size = panMenu.MaximumSize
        Else
            panMenu.Size = panMenu.MinimumSize
        End If
        PanCouleur.Visible = False
    End Sub

    Private Sub BtAccueil_Click(sender As Object, e As EventArgs) Handles btAccueil.Click
        ucAccueil.LoadDGV()
        ucAccueil.BringToFront()
        panMenu.Size = panMenu.MinimumSize
    End Sub

    Private Sub BtInventaire_Click(sender As Object, e As EventArgs) Handles btInventaire.Click
        ShowInventaire()
    End Sub

    Private Sub BtVente_Click(sender As Object, e As EventArgs) Handles btVente.Click
        ucVente.BringToFront()
        panMenu.Size = panMenu.MinimumSize
    End Sub

    Private Sub BtFour_Click(sender As Object, e As EventArgs) Handles btFour.Click
        ucFour.BringToFront()
        panMenu.Size = panMenu.MinimumSize
    End Sub

    Public Sub ShowInventaire()
        ucInventaire.BringToFront()
        panMenu.Size = panMenu.MinimumSize
    End Sub

    Private Sub BtConnec_Click(sender As Object, e As EventArgs) Handles btConnec.Click
        If ConnectionServeur.Getinstance.TestConnection() Then
            AddUC()
            lbNonConc.Text = ""
            btConnec.Visible = False
            btMenu.Enabled = True
        Else
            MessageBox.Show("Toujours impossible de se connecter au serveur!")
        End If
    End Sub

    Public Sub Fermer()
        If lbNonConc.InvokeRequired Then
            Dim d As New setValue(AddressOf SetTexte)
            BeginInvoke(d, New Object() {"Impossible de se connecter au serveur!"})
        Else
            ucAccueil.BringToFront()
            lbNonConc.Text = "Impossible de se connecter au serveur!"
            btConnec.Visible = True
            btMenu.Enabled = False
        End If
    End Sub

    Private Sub SetTexte(text As String)
        ucAccueil.BringToFront()
        lbNonConc.Text = text
        btConnec.Visible = True
        btMenu.Enabled = False
    End Sub

    Private Sub BtModel_Click(sender As Object, e As EventArgs) Handles btModel.Click
        ucModel.BringToFront()
        panMenu.Size = panMenu.MinimumSize
    End Sub

    Public Sub SetUCVente2(ByRef uc As UCVente2)
        ucVente2 = uc
    End Sub

    Public Sub SetUCVente3(ByRef uc As UCVente3)
        ucVente3 = uc
    End Sub

    Public Sub ChangeUCNext1(tps As Boolean, tvq As Boolean)
        ucVente2.LoadDGV()
        ucVente2.BringToFront()
        ucVente2.SetPrix(ucVente.GetPrix(), tps, tvq)
    End Sub

    Public Sub ChangeUCNext2()
        ucVente3.BringToFront()
    End Sub

    Public Sub ChangeUCPrev1(tps As Boolean, tvq As Boolean)
        ucVente.BringToFront()
        ucVente.SetTaxe(tps, tvq)
    End Sub

    Public Sub ChangeUCPrev2()
        ucVente2.BringToFront()
    End Sub

    '__________________________________________________________________________________________________________
    'Functions
    '__________________________________________________________________________________________________________
    Public Shared Function GetInstance() As MainForm
        If IsNothing(instance) Then
            instance = New MainForm
        End If
        Return instance
    End Function

    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Set
    '__________________________________________________________________________________________________________
    Public Sub SetOption(str1 As String, str2 As String, int3 As Integer, doub4 As Double, doub5 As Double)
        options.option1 = str1
        options.option2 = str2
        options.option3 = int3
        options.option4 = doub4
        options.option5 = doub5
    End Sub


    '__________________________________________________________________________________________________________
    'Get
    '__________________________________________________________________________________________________________
    Public Function GetOption1() As String
        Return options.option1
    End Function

    Public Function GetOption2() As String
        Return options.option2
    End Function

    Public Function GetOption3() As String
        Return options.option3
    End Function

    Public Function GetOption4() As String
        Return options.option4
    End Function

    Public Function GetOption5() As String
        Return options.option5
    End Function

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MessageBox.Show("Voulez-vous vraiment fermer le programme?", "Attention!", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ConnectionServeur.Getinstance.GetInfo("fermer")
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub BtCouleur_Click(sender As Object, e As EventArgs) Handles BtCouleur.Click
        If PanCouleur.Visible = True Then
            PanCouleur.Visible = False
        Else
            PanCouleur.BringToFront()
            PanCouleur.Visible = True
            PanGestVeh.Visible = False
        End If
    End Sub

    Private Sub BtOptionModel_Click(sender As Object, e As EventArgs) Handles BtOptionModel.Click
        ucOption.BringToFront()
        panMenu.Size = panMenu.MinimumSize
    End Sub

    Private Sub BtClient_Click(sender As Object, e As EventArgs) Handles BtClient.Click
        ucClient.BringToFront()
        panMenu.Size = panMenu.MinimumSize
    End Sub

    Private Sub BTCoulModel_Click(sender As Object, e As EventArgs) Handles BTCoulModel.Click
        ucCouleur.BringToFront()
        panMenu.Size = panMenu.MinimumSize
    End Sub

    Private Sub BTCoulToile_Click(sender As Object, e As EventArgs) Handles BTCoulToile.Click
        ucCoulToile.BringToFront()
        panMenu.Size = panMenu.MinimumSize
    End Sub

    Private Sub BTCoulTissu_Click(sender As Object, e As EventArgs) Handles BTCoulTissu.Click
        ucCoulTissus.BringToFront()
        panMenu.Size = panMenu.MinimumSize
    End Sub

    Private Sub BTVehicule_Click(sender As Object, e As EventArgs) Handles BTVehicule.Click
        ucGestVeh.BringToFront()
        panMenu.Size = panMenu.MinimumSize
    End Sub

    Private Sub BTGest_Click(sender As Object, e As EventArgs) Handles BTGest.Click
        ucGestVeh.BringToFront()
        panMenu.Size = panMenu.MinimumSize
        PanGestVeh.Visible = False
    End Sub

    Public Sub PutUC(uc As UserControl)
        PanUC.Controls.Add(uc)
        uc.BringToFront()
    End Sub

    Private Sub MainForm_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If Not panMenu.DisplayRectangle.Contains(e.Location) Then
            panMenu.Size = panMenu.MinimumSize
        End If
    End Sub

    Public Sub FermerMenu()
        panMenu.Size = panMenu.MinimumSize
    End Sub
End Class
