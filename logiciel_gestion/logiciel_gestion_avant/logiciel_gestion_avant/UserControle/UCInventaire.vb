Public Class UCInventaire
    '__________________________________________________________________________________________________________
    'Attributes
    '__________________________________________________________________________________________________________
    Dim sameID As String
    Dim tableOri As New DataTable
    Dim change(8) As String
    Dim triger As Boolean = True
    Dim modif As Boolean

    '__________________________________________________________________________________________________________
    'Constructor
    '__________________________________________________________________________________________________________
    Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub

    '__________________________________________________________________________________________________________
    'Load
    '__________________________________________________________________________________________________________
    Private Sub UCInventaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbIDPro.Select()
    End Sub

    '__________________________________________________________________________________________________________
    'Methods
    '__________________________________________________________________________________________________________
    Private Sub tbIDPro_KeyDown(sender As Object, e As KeyEventArgs) Handles tbIDPro.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If sameID <> tbIDPro.Text Then
                    changeRead(True)
                    tableOri = EntityInventaire.getInstance.getInventaire(tbIDPro.Text)
                    If tableOri.Rows.Count > 0 Then
                        remplir(tableOri)
                        changeRead(False)
                        labPasItem.Text = ""
                    Else
                        remplir()
                        labPasItem.Text = "Le numéro d'item n'existe pas!"
                        labPasItem.ForeColor = Color.Red
                        tbIDPro.SelectAll()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub changeRead(read As Boolean)
        tbNom.ReadOnly = read
        nudQuantite.ReadOnly = read
        tbEmplacement.ReadOnly = read
        nudCoutUn.ReadOnly = read
        tbUse.ReadOnly = read
        nudEnCommende.ReadOnly = read
        tbDescription.ReadOnly = read
    End Sub

    Private Sub remplir()
        tbNom.Text = ""
        nudQuantite.Text = ""
        tbDescription.Text = ""
        tbIDFour.Text = ""
        tbEmplacement.Text = ""
        nudCoutUn.Text = ""
        tbUse.Text = ""
        nudEnCommende.Text = ""
    End Sub

    Private Sub remplir(table As DataTable)
        triger = False
        tbNom.Text = table(0)(1)
        nudQuantite.Value = table(0)(2)
        tbDescription.Text = table(0)(3)
        tbIDFour.Text = table(0)(4)
        tbEmplacement.Text = table(0)(5)
        nudCoutUn.Value = table(0)(6)
        tbUse.Text = table(0)(7)
        nudEnCommende.Value = table(0)(8)
        triger = True
    End Sub

    Private Sub btSauvChanger()
        modif = False
        For i As Integer = 1 To tableOri.Columns.Count - 1
            If Not Convert.ToString(tableOri(0)(i)) = change(i) Then
                modif = True
            End If
        Next

        btSauv.Enabled = modif
    End Sub

    Private Sub btSauv_Click(sender As Object, e As EventArgs) Handles btSauv.Click

        ModelInventaire.getInstance.modInventaire(change, True)
    End Sub

    '__________________________________________________________________________________________________________
    'Functions
    '__________________________________________________________________________________________________________




    '__________________________________________________________________________________________________________
    'Validation Functions
    '__________________________________________________________________________________________________________
    Private Sub tbDescription_TextChanged(sender As Object, e As EventArgs) Handles tbDescription.TextChanged
        change(3) = tbDescription.Text
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub nudCoutUn_ValueChanged(sender As Object, e As EventArgs) Handles nudCoutUn.ValueChanged
        change(6) = Convert.ToString(nudCoutUn.Value)
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub nudEnCommende_ValueChanged(sender As Object, e As EventArgs) Handles nudEnCommende.ValueChanged
        change(8) = Convert.ToString(nudEnCommende.Value)
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub nudQuantite_ValueChanged(sender As Object, e As EventArgs) Handles nudQuantite.ValueChanged
        change(2) = Convert.ToString(nudQuantite.Value)
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub tbEmplacement_TextChanged(sender As Object, e As EventArgs) Handles tbEmplacement.TextChanged
        change(5) = tbEmplacement.Text
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub tbNom_TextChanged(sender As Object, e As EventArgs) Handles tbNom.TextChanged
        change(1) = tbNom.Text
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub tbUse_TextChanged(sender As Object, e As EventArgs) Handles tbUse.TextChanged
        change(7) = tbUse.Text
        If triger Then
            btSauvChanger()
        End If
    End Sub

    Private Sub tbIDFour_TextChanged(sender As Object, e As EventArgs) Handles tbIDFour.TextChanged
        change(4) = tbIDFour.Text
        If triger Then
            btSauvChanger()
        End If
    End Sub



    '__________________________________________________________________________________________________________
    'Set
    '__________________________________________________________________________________________________________



    '__________________________________________________________________________________________________________
    'Get
    '__________________________________________________________________________________________________________

End Class
