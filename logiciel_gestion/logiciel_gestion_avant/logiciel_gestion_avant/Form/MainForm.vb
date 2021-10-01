
Imports System.ComponentModel

Public Class MainForm

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    Shared instance As MainForm = Nothing
    ReadOnly keyCombo As New List(Of Keys)({Keys.ControlKey, Keys.H, Keys.P})
    ReadOnly currentKeys As New List(Of Keys)
    Dim options As New StructureOption.mesOption
    ReadOnly ucAccueil As New UCAccueil
    ReadOnly ucInventaire As New UCInventaire(Me)
    ReadOnly ucVente As New UCVente
    ReadOnly ucFour As New UCFournisseur(Me, ucInventaire)
    ReadOnly ucModel As New UCGestionVehicule
    Private Delegate Sub setValue(text As String)

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        MyOption.getInstance.readOption()
        panMenu.Size = panMenu.MinimumSize
        ConnectionServeur.setMain(Me)
        If ConnectionServeur.getinstance.TestConnection() Then
            panMenu.Size = panMenu.MinimumSize
            PanUC.Controls.Add(ucAccueil)
            PanUC.Controls.Add(ucInventaire)
            PanUC.Controls.Add(ucVente)
            PanUC.Controls.Add(ucFour)
            PanUC.Controls.Add(ucModel)
        Else
            lbNonConc.Text = "Impossible de se connecter au serveur!"
            btConnec.Visible = True
            btMenu.Enabled = False
        End If
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________
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

    End Sub

    Private Sub BtAccueil_Click(sender As Object, e As EventArgs) Handles btAccueil.Click
        'ucAccueil.BringToFront()
        'panMenu.Size = panMenu.MinimumSize
        MessageBox.Show("La section n'est pas encore implémenté")
    End Sub

    Private Sub BtInventaire_Click(sender As Object, e As EventArgs) Handles btInventaire.Click
        showInventaire()
    End Sub

    Private Sub BtVente_Click(sender As Object, e As EventArgs) Handles btVente.Click
        'ucVente.BringToFront()
        'panMenu.Size = panMenu.MinimumSize
        MessageBox.Show("La section n'est pas encore implémenté")
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
            PanUC.Controls.Add(ucAccueil)
            PanUC.Controls.Add(ucInventaire)
            PanUC.Controls.Add(ucVente)
            PanUC.Controls.Add(ucFour)
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
    Public Sub SetOption(str1 As String, str2 As String, int3 As Integer)
        options.option1 = str1
        options.option2 = str2
        options.option3 = int3
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

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class
