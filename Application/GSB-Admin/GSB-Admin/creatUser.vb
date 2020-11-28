﻿Public Class creatUser

    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    'Bouton de retour au formulaire principal
    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Voulez-vous vraiment annuler l'ajout de cet utilisateur ?", "Annuler", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then
            Me.Close()
            frm_principal.Show()
        End If
    End Sub

    Private Sub rb_Visiteur_CheckedChanged(sender As Object, e As EventArgs) Handles rb_Visiteur.CheckedChanged
        If rb_Visiteur.Checked = True Then
            Me.Size = New Size(850, Me.Size.Height)
        Else
            Me.Size = New Size(470, Me.Size.Height)
        End If

    End Sub

    Private Sub creatUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

   
    
    Private Sub txtB_MDP_TextChanged(sender As Object, e As EventArgs) Handles txtB_MDP.TextChanged
        If txtB_MDP.Text.Trim.Length < 4 Then
            progressBar_Mdp.Value = 10

        End If

        If txtB_MDP.Text.Trim.Length >= 4 Then
            progressBar_Mdp.Value = 50

        End If

        If txtB_MDP.Text.Trim.Length >= 6 Then
            progressBar_Mdp.Value = 70

        End If
        If txtB_MDP.Text.Trim.Length >= 7 Then
            progressBar_Mdp.Value = 85

        End If
        If txtB_MDP.Text.Trim.Length >= 8 Then
            progressBar_Mdp.Value = 100


        End If
    End Sub

    Private Sub btn_Submit_Click(sender As Object, e As EventArgs) Handles btn_Submit.Click
        Dim Reponse As DialogResult 'Déclaration de la variavle "Reponse" en local
        Reponse = MessageBox.Show("Voulez-vous vraiment ajouter cet utilisateur ?", "Ajouter", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) 'Affichage de la message box avec le choix de quitter ou de rester
        If Reponse = DialogResult.Yes Then If txtB_MDP.Text.Trim.Length < 8 Then 
        lbl_InfoMdp.Text = "Le mot de passe doit contenir minimun 8 caractères"


    End Sub

    
End Class