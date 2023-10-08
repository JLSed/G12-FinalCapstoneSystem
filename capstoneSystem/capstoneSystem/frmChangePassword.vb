Public Class frmChangePassword

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not txtConfirmpasswordEdit.Text = txtNewpasswordEdit.Text Then
            MsgBox("Please confirm the new password correctly", MsgBoxStyle.Information)
        Else
            DBstring = "update teacherAccount set [password] ='" & txtNewpasswordEdit.Text & "' where [username] ='" & frmForgotPassword.txtUsername.Text & "';"
            Dim DBcmd As New OleDb.OleDbCommand
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBcmd.ExecuteNonQuery()
            DBcmd.Dispose()
            DBreader.Close()
            MsgBox("Password Changed", MsgBoxStyle.Information)
            frmForgotPassword.Close()
            frmLogin.Enabled = True
            frmForgotPassword.Enabled = True
            Me.Close()
        End If
    End Sub

    Private Sub frmChangePassword_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmLogin.Enabled = True
        frmForgotPassword.Enabled = True
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        If txtNewpasswordEdit.PasswordChar = Nothing Then
            txtNewpasswordEdit.PasswordChar = "*"
            Button23.Image = My.Resources.eye_fill_icon
        Else
            txtNewpasswordEdit.PasswordChar = Nothing
            Button23.Image = My.Resources.eye_slash_fill_icon
        End If
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        If txtConfirmpasswordEdit.PasswordChar = Nothing Then
            txtConfirmpasswordEdit.PasswordChar = "*"
            Button24.Image = My.Resources.eye_fill_icon
        Else
            txtConfirmpasswordEdit.PasswordChar = Nothing
            Button24.Image = My.Resources.eye_slash_fill_icon
        End If
    End Sub

    Private Sub frmChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class