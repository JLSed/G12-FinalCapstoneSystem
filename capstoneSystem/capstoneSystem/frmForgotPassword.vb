Public Class frmForgotPassword
    Dim Gmailholder As String = ""
    Dim otpholder As String = ""
    Private Sub btnSearchUsername_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchUsername.Click
        If txtUsername.Text = "" Then
            MsgBox("Please Input your username first", MsgBoxStyle.Exclamation, "ERROR")
        Else
            DBstring = "select username from teacherAccount where [username] like '" & txtUsername.Text & "%'"
            Dim DBcmd As New OleDb.OleDbCommand
            Dim searchuserholder As String = ""
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBadapter.SelectCommand = DBcmd
            DBreader = DBcmd.ExecuteReader
            While DBreader.Read
                searchuserholder = DBreader("username").ToString
            End While
            DBcmd.Dispose()
            DBreader.Close()

            If txtUsername.Text = searchuserholder Then
                Label3.Visible = True
                grpbRecoverOption.Visible = True
            Else
                MsgBox("Can't find this username from the database. Please try again.", MsgBoxStyle.Information, "No Search Result")
            End If
        End If
    End Sub

    Private Sub btnBackupCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackupCode.Click
        grpbBackupCode.Visible = True
    End Sub

    Private Sub btnRequestRecovery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRequestRecovery.Click
        MsgBox("Please message one of the admins through SNS to request a reset to default password or notify them in person.", MsgBoxStyle.Information)
    End Sub

    Function generateOTP()
        Dim alphabets As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim small_alphabets As String = "abcdefghijklmnopqrstuvwxyz"
        Dim numbers As String = "1234567890"

        Dim characters As String = numbers
        characters += Convert.ToString(alphabets & small_alphabets) & numbers
        Dim length As Integer = Integer.Parse(6)
        Dim otp As String = String.Empty
        For i As Integer = 0 To length - 1
            Dim character As String = String.Empty
            Do
                Dim index As Integer = New Random().Next(0, characters.Length)
                character = characters.ToCharArray()(index).ToString()
            Loop While otp.IndexOf(character) <> -1
            otp += character
        Next
        Return otp
    End Function

    Private Sub btnOTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOTP.Click
        Dim IDholder As String = ""
        grpbOTP.Visible = True
        grpbBackupCode.Visible = False
        DBstring = "select idAcc from teacherAccount where username like '" & txtUsername.Text & "';"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While DBreader.Read
            IDholder = DBreader("idAcc").ToString
        End While
        DBcmd.Dispose()
        DBreader.Close()

        DBstring = "select Gmail from teacherInfo where ID like " & IDholder & ";"
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While DBreader.Read
            Gmailholder = DBreader("Gmail").ToString
        End While
        DBcmd.Dispose()
        DBreader.Close()
        Dim GmailholderFiltered As String = Gmailholder
        GmailholderFiltered = GmailholderFiltered.Remove(2, 7).Insert(2, "*******")
        lblRegisteredEmail.Text = GmailholderFiltered
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        If txtBackupPin1.PasswordChar = Nothing Then
            txtBackupPin1.PasswordChar = "*"
            txtBackupPin2.PasswordChar = "*"
            txtBackupPin3.PasswordChar = "*"
            txtBackupPin4.PasswordChar = "*"
            Button22.Image = My.Resources.eye_fill_icon
        Else
            txtBackupPin1.PasswordChar = Nothing
            txtBackupPin2.PasswordChar = Nothing
            txtBackupPin3.PasswordChar = Nothing
            txtBackupPin4.PasswordChar = Nothing
            Button22.Image = My.Resources.eye_slash_fill_icon
        End If
    End Sub

    Private Sub charLimiter(ByVal e)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtBackupPin_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBackupPin4.KeyPress, txtBackupPin3.KeyPress, txtBackupPin2.KeyPress, txtBackupPin1.KeyPress
        charLimiter(e)
    End Sub

    Private Sub btnConfirmBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmBackup.Click
        DBstring = "select BackupCode from [teacherAccount] where username like '" & txtUsername.Text & "';"
        Dim DBcmd As New OleDb.OleDbCommand
        Dim Backupholder As String = ""
        Dim allPinholder As String = ""
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While (DBreader.Read())
            Backupholder = DBreader("BackupCode").ToString
        End While
        DBcmd.Dispose()
        DBreader.Close()
        allPinholder = txtBackupPin1.Text + "-" + txtBackupPin2.Text + "-" + txtBackupPin3.Text + "-" + txtBackupPin4.Text
        If Not allPinholder = Backupholder Then
            MsgBox("Please input the correct Backup Code", MsgBoxStyle.Critical)
        Else
            Me.Enabled = False
            frmLogin.Enabled = False
            frmChangePassword.Show()
        End If
    End Sub

    Private Sub btnSendOTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendOTP.Click
        otpholder = generateOTP()
        Try
            SendEmailMessage(Gmailholder, "Automated Attendance System - One-Time-Password [" & otpholder _
                             & "]", "Your OTP code for our system is [" & otpholder _
                             & "]. Please ignore if you did not request this code.")
        Catch fe As System.FormatException
            MsgBox("Please Input a Valid Email.", MsgBoxStyle.Critical, "Invalid Email Adress")
            Exit Sub
        Catch ex As Exception
            MsgBox("Mail failed to deliver.", MsgBoxStyle.Critical, "Mailing Error")
            Exit Sub
        End Try

    End Sub

    Private Sub btnVerifyOTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerifyOTP.Click
        If txtVerifyOTP.Text = otpholder Then
            Me.Enabled = False
            frmLogin.Enabled = False
            frmChangePassword.Show()
        End If
    End Sub

    Private Sub frmForgotPassword_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmLogin.Enabled = True
    End Sub

    Private Sub frmForgotPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class