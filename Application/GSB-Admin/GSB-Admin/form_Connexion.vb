﻿Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class form_Connexion

   
    'Chargement de l'application
    Private Sub connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtB_Login.Text = ""
        txtB_MDP.Text = ""
    End Sub
    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    'Bouton de connexion
    Private Sub btn_Submit_Click_1(sender As Object, e As EventArgs) Handles btn_Submit.Click

        'Appel de la fonction qui charge nos Dictyonnary (connexion à la base de donées ainsi qu'à l'application)
        lectureFichier()

        'On vérifie que l'administrateur ne veux pas modifier ses identifiants de connexion
        If checkbox_Update.Checked = True Then

            'On vérifie tout d'abord que les informations sont les bonnes
            If Auth.Item("login") = txtB_Login.Text And Auth.Item("motdepasse") = txtB_MDP.Text Then
                'Ouverture du formulaire
                form_updateIdentifiant.Show()
                Me.Hide()
            Else
                txtB_MDP.Text = ""
                lbl_Error.Text = " Login ou mot de passe incorrects..."
            End If

        Else

            'On vérifie ici les informations qui ont été rentrer par la personne
            If Auth.Item("login") = txtB_Login.Text And Auth.Item("motdepasse") = txtB_MDP.Text Then
                form_MDIContainer.Show()
                Me.Hide()
            Else
                txtB_MDP.Text = ""
                lbl_Error.Text = " Login ou mot de passe incorrects..."
            End If

        End If

    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Gestion des ENABLED
    Private Sub txtB_Login_Click(sender As Object, e As EventArgs) Handles txtB_Login.Click
        If txtB_Login.Text.Trim.Length > 0 Then
            txtB_MDP.Enabled = True
        Else
            txtB_MDP.Enabled = False
        End If
    End Sub

    Private Sub txtB_MDP_Click(sender As Object, e As EventArgs) Handles txtB_MDP.Click
        If txtB_MDP.Text.Trim.Length > 0 Then
            btn_Submit.Enabled = True
        Else
            btn_Submit.Enabled = False
        End If
    End Sub
    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    'Boutton pour quitter l'application
    Private Sub btn_Quitte_Click_1(sender As Object, e As EventArgs) Handles btn_Quitte.Click
        End
    End Sub
    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

  
   
End Class