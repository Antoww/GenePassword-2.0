Public Class Form1
    Public Function GeneratePassword(ByVal longueur As Integer) As String
        Dim sb As New System.Text.StringBuilder ' Variable builder
        Dim Dico As String = "" ' Variable contenant les caractères à utiliser
        Randomize() ' Prépare l'utilisation de l'aléatoire

        If (CheckBox1.Checked) Then ' Les lettres sont utilisés, on les ajoutes dans le dico'
            Dico &= "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        End If

        If (CheckBox2.Checked) Then ' Les chiffres sont utilisés, on les ajoutes dans le dico'
            Dico &= "1234567890"
        End If

        If (CheckBox3.Checked) Then ' Les caractères spéciaux sont utilisés, on les ajoutes dans le dico'
            Dico &= "&+=-*_$#@?!/\[]"
        End If

        If (Not CheckBox1.Checked And Not CheckBox2.Checked And Not CheckBox3.Checked) Then ' Aucun caractère n'est choisit
            MessageBox.Show("No character is selected, please select at least one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ' Message d'erreur
            Return String.Empty 'La fonction retourne 'rien' (vide)
            Exit Function ' On quitte la fonction, elle n'a plus rien à faire
        End If


        For i As Integer = 1 To longueur ' Boucle allant de 1 à [taille_du_mot_de_passe_choissit]
            sb.Append(Dico(Int(Rnd() * Dico.Length)))
        Next

        Return sb.ToString

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = GeneratePassword(NumericUpDown1.Value) ' Generation du mot de passe
    End Sub

    Private Sub TextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.SelectAll() ' On selectionne le contenu de la textbox
        Clipboard.SetText(TextBox1.Text) ' Copier dans le presse-papier
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.PerformClick() ' Quand l'application se lance, on fait comme si on appuyait sur le bouton "Générer" automatiquement
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form2.Show()
    End Sub

End Class
