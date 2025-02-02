Imports System.Diagnostics
Public Class about
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim urlgit As String = "https://github.com/Antoww"
        Try
            Process.Start(New ProcessStartInfo(urlgit) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("An error occurred while trying to open the link.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim urlweb As String = "https://antow.net/"
        Try
            Process.Start(New ProcessStartInfo(urlweb) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("An error occurred while trying to open the link.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class