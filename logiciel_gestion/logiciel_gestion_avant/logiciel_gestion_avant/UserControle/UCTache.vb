﻿Imports System.ComponentModel
Public Class UCTache
    ReadOnly main As MainForm
    Dim bool As Boolean = True

    Sub New(mainform As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        main = mainform
    End Sub

    Private Sub UCTache_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDGV()
    End Sub

    Public Sub LoadDGV()
        Dim table As New DataTable
        For c As Integer = 0 To MainForm.tableTache.Columns.Count - 1
            table.Columns.Add(MainForm.tableTache.Columns(c).ColumnName)
        Next

        For r As Integer = 0 To MainForm.tableTache.Rows.Count - 1
            Dim row As DataRow = table.NewRow
            For c As Integer = 0 To MainForm.tableTache.Columns.Count - 1
                row(c) = MainForm.tableTache(r)(c)
            Next
            table.Rows.Add(row)
        Next

        DGVTache.DataSource = table

        DGVTache.Columns(DGVTache.Columns.Count - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGVTache.Columns(DGVTache.Columns.Count - 2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DGVTache.Sort(DGVTache.Columns("dateJour"), ListSortDirection.Ascending)
    End Sub

    Private Sub BTAdd_Click(sender As Object, e As EventArgs) Handles BTAdd.Click
        Dim creerTache As New CreerTache(Me)
        creerTache.ShowDialog()
    End Sub

    Private Sub BTMod_Click(sender As Object, e As EventArgs) Handles BTMod.Click
        Dim gest As New GestionTache(DGVTache.CurrentRow, Me)
        gest.ShowDialog()
    End Sub

    Private Sub BTSupp_Click(sender As Object, e As EventArgs) Handles BTSupp.Click
        If MessageBox.Show("Voulez-vous vraiment supprimer cette tâche?", "Attention", MessageBoxButtons.YesNo) = vbYes Then
            If ConnectionServeur.Getinstance.AddDelete(DGVTache.CurrentRow.Cells(0).Value, "delTache") Then
                DGVTache.Rows.Remove(DGVTache.CurrentRow)
            Else
                MessageBox.Show("Une erreur est survenu durant la suppression de la tâche!")
            End If
        End If
    End Sub

    'Fonctionqui sert a checker si à des tâches qui sont dépasser de plus de un moi et si oui on demande si on veut les supprimer. On met on boolean
    'pour savoir si on a déjà demander la question pour ne pas le répéter à chaque fois
    Public Sub CheckDateSupp()
        If bool Then
            Dim today As Date = Date.Now.AddMonths(-1)
            Dim nbr As Integer = 0

            For r As Integer = 0 To DGVTache.Rows.Count - 1
                If DGVTache.Rows(r).Cells("dateJour").Value <= today Then
                    nbr += 1
                End If
            Next
            Dim liste(nbr - 1) As String
            If nbr > 0 Then
                If MessageBox.Show(nbr & " tâches on une date dépasser de plus de 1 mois voulez-vous les supprimer?", "Attention!", MessageBoxButtons.YesNo) = vbYes Then
                    nbr = 0
                    For r As Integer = MainForm.tableTache.Rows.Count - 1 To 0 Step -1
                        If MainForm.tableTache.Rows(r).Item("dateJour") <= today Then
                            liste(nbr) = MainForm.tableTache.Rows(r).Item("id")
                            nbr += 1
                            MainForm.tableTache.Rows.RemoveAt(r)
                        End If
                    Next
                    If ConnectionServeur.Getinstance.AddDelete(liste, "DeleteTache") Then
                        MessageBox.Show("Suppression effectuer correctement")
                        LoadDGV()
                    Else
                        MessageBox.Show("Une erreure est survenu durant la suppression des tâches!", "Attention!")
                    End If
                End If
            End If
            bool = False
        End If
    End Sub
End Class
