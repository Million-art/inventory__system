Public Class Form1
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim result = MessageBox.Show("are you sure do you wont to exit? ", "closing exam", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TextBox1.Text = "million" And TextBox2.Text = "1234" Then
            GroupBox1.Visible = False
        Else
            MessageBox.Show("incorect username or password")
            TextBox1.Focus()
        End If
    End Sub
End Class
