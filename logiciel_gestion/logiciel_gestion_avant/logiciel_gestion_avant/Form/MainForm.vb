
Imports System.ComponentModel

Public Class MainForm

    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    Shared instance As MainForm = Nothing
    Dim keyCombo As New List(Of Keys)({Keys.ControlKey, Keys.H, Keys.P})
    Dim currentKeys As New List(Of Keys)
    Dim options As New StructureOption.mesOption
    Dim ucAccueil As New UCAccueil
    Dim ucInventaire As New UCInventaire(Me)
    Dim ucVente As New UCVente
    Dim ucFour As New UCFournisseur(Me, ucInventaire)
    Dim connect As New ConnectionServeur(Me)
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


    Private Sub btMenu_Click(sender As Object, e As EventArgs) Handles btMenu.Click
        If panMenu.Size = panMenu.MinimumSize Then
            panMenu.Size = panMenu.MaximumSize
        Else
            panMenu.Size = panMenu.MinimumSize
        End If

    End Sub

    Private Sub btAccueil_Click(sender As Object, e As EventArgs) Handles btAccueil.Click
        'ucAccueil.BringToFront()
        'panMenu.Size = panMenu.MinimumSize
        MessageBox.Show("La section n'est pas encore implémenté")
    End Sub

    Private Sub btInventaire_Click(sender As Object, e As EventArgs) Handles btInventaire.Click
        showInventaire()
    End Sub

    Private Sub btVente_Click(sender As Object, e As EventArgs) Handles btVente.Click
        'ucVente.BringToFront()
        'panMenu.Size = panMenu.MinimumSize
        MessageBox.Show("La section n'est pas encore implémenté")
    End Sub

    Private Sub btFour_Click(sender As Object, e As EventArgs) Handles btFour.Click
        ucFour.BringToFront()
        panMenu.Size = panMenu.MinimumSize
    End Sub

    Public Sub showInventaire()
        ucInventaire.BringToFront()
        panMenu.Size = panMenu.MinimumSize
    End Sub

    Private Sub btConnec_Click(sender As Object, e As EventArgs) Handles btConnec.Click
        If ConnectionServeur.getinstance.TestConnection() Then
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

    Public Sub fermer()
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

    '__________________________________________________________________________________________________________
    'Functions
    '__________________________________________________________________________________________________________
    Public Shared Function getInstance() As MainForm
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
    Public Sub setOption(str1 As String, str2 As String, str3 As String, str4 As String, str5 As String, int6 As Integer)
        options.option1 = str1
        options.option2 = str2
        options.option3 = str3
        options.option4 = str4
        options.option5 = str5
        options.option6 = int6
    End Sub


    '__________________________________________________________________________________________________________
    'Get
    '__________________________________________________________________________________________________________
    Public Function getOption1() As String
        Return options.option1
    End Function

    Public Function getOption2() As String
        Return options.option2
    End Function

    Public Function getOption3() As String
        Return options.option3
    End Function

    Public Function getOption4() As String
        Return options.option4
    End Function

    Public Function getOption5() As String
        Return options.option5
    End Function

    Public Function getOption6() As Integer
        Return options.option6
    End Function

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Dispose()
    End Sub
End Class
