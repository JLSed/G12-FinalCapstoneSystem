Public Class frmMenu
    Dim otpholder As String

    Private Sub tbpgChart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbpgEditAccount.Click

    End Sub

    Private Sub tbctlMenu_Selected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles tbctlMenu.Selected
        If tbctlMenu.SelectedIndex = 4 Then

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbutUs.Click
        tbctlMenu.SelectTab(tbpgAboutUs)
    End Sub

    Private Sub btnEditUsername_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditUsername.Click
        If btnChangeUsername.Visible = True Then
            txtEditUsername.Enabled = False
            btnChangeUsername.Visible = False
        Else
            txtEditUsername.Enabled = True
            btnChangeUsername.Visible = True
        End If
    End Sub

    Private Sub btnEditPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditPassword.Click
        If GroupBox1.Visible = True Then
            GroupBox1.Visible = False
        Else
            GroupBox1.Visible = True
        End If
    End Sub

    Private Sub btnChangeUsername_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeUsername.Click
        If MsgBox("Do you want to change to this username?", MsgBoxStyle.Information + vbYesNo, "CAUTION") = MsgBoxResult.Yes Then
            DBstring = "update teacherAccount set [username] ='" & txtEditUsername.Text & "' where [idAcc] ='" & frmMainPage.lblIDnum.Text & "';"
            Dim DBcmd As New OleDb.OleDbCommand
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBcmd.ExecuteNonQuery()
            DBcmd.Dispose()
            DBreader.Close()
            frmLogin.username = Me.txtEditUsername.Text
            MsgBox("Username Changed", MsgBoxStyle.Information)
            btnChangeUsername.Visible = False
            txtEditUsername.Text = frmLogin.username
            txtEditUsername.Enabled = False
        Else
            btnChangeUsername.Visible = False
            txtEditUsername.Text = frmLogin.username
            txtEditUsername.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditAccount.Click
        txtEditUsername.Text = frmLogin.username
        btnEditAccount.ForeColor = Color.White
        btnBackupCode.ForeColor = Color.Silver
        btnOTP.ForeColor = Color.Silver
        btnAbutUs.ForeColor = Color.Silver
    End Sub

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtEditUsername.Text = frmLogin.username
        DBstring = "select BackupCode from [teacherAccount] where username like '" & frmLogin.username & "';"
        Dim DBcmd As New OleDb.OleDbCommand
        Dim oldPassholder As String = ""
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While (DBreader.Read())
            txtBackUpCode.Text = DBreader("BackupCode").ToString
        End While
        DBcmd.Dispose()
        DBreader.Close()
        DBstring = "select Gmail from [teacherInfo] where ID like " & frmMainPage.lblIDnum.Text & ";"
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While (DBreader.Read())
            txtRegisteredEmail.Text = DBreader("Gmail").ToString
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MsgBox("Do you want to change to this password?", MsgBoxStyle.Information + vbYesNo, "CAUTION") = MsgBoxResult.Yes Then
            DBstring = "select password from [teacherAccount] where password like '" & txtOldpasswordEdit.Text & "';"
            Dim DBcmd As New OleDb.OleDbCommand
            Dim oldPassholder As String = ""
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBadapter.SelectCommand = DBcmd
            DBreader = DBcmd.ExecuteReader
            While (DBreader.Read())
                oldPassholder = DBreader("password").ToString
            End While
            DBcmd.Dispose()
            DBreader.Close()
            If Not oldPassholder = txtOldpasswordEdit.Text Then
                MsgBox("Old Password does not match", MsgBoxStyle.Information)
            ElseIf Not txtConfirmpasswordEdit.Text = txtNewpasswordEdit.Text Then
                MsgBox("Please confirm the new password correctly", MsgBoxStyle.Information)
            Else
                DBstring = "update teacherAccount set [password] ='" & txtNewpasswordEdit.Text & "' where [idAcc] ='" & frmMainPage.lblIDnum.Text & "%'"
                DBcmd.CommandText = DBstring
                DBcmd.Connection = DBconnection
                DBcmd.ExecuteNonQuery()
                DBcmd.Dispose()
                DBreader.Close()
                MsgBox("Password Changed", MsgBoxStyle.Information)
                GroupBox1.Visible = False
                txtConfirmpasswordEdit.Text = ""
                txtOldpasswordEdit.Text = ""
                txtNewpasswordEdit.Text = ""
            End If
        Else
            GroupBox1.Visible = False
            txtConfirmpasswordEdit.Text = ""
            txtOldpasswordEdit.Text = ""
            txtNewpasswordEdit.Text = ""
        End If
    End Sub

    Private Sub btnMainPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainPage.Click
        frmMainPage.WindowState = FormWindowState.Maximized
        frmMainPage.Show()
        Me.Close()
    End Sub

    Private Sub btnBackupCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackupCode.Click
        tbctlMenu.SelectTab(tbpgBackupCode)
    End Sub

    Private Sub btnOTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOTP.Click
        If txtRegisteredEmail.Text = Nothing Then
            Label16.Text = "You currently dont have a registered email"
        Else
            Label16.Text = "Registered Email"
        End If
        tbctlMenu.SelectTab(tbpgOTP)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        tbctlMenu.SelectTab(tbpgEditAccount)
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tbctlMenu.SelectTab(tbpgOTP)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        tbctlMenu.SelectTab(tbpgAboutUs)
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        tbctlMenu.SelectTab(tbpgEditAccount)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        tbctlMenu.SelectTab(tbpgBackupCode)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        tbctlMenu.SelectTab(tbpgAboutUs)
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        tbctlMenu.SelectTab(tbpgEditAccount)
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        tbctlMenu.SelectTab(tbpgBackupCode)
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        tbctlMenu.SelectTab(tbpgOTP)
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        If txtBackUpCode.PasswordChar = Nothing Then
            txtBackUpCode.PasswordChar = "*"
            Button21.Image = My.Resources.eye_fill_icon
        Else
            txtBackUpCode.PasswordChar = Nothing
            Button21.Image = My.Resources.eye_slash_fill_icon
        End If
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        If txtOldpasswordEdit.PasswordChar = Nothing Then
            txtOldpasswordEdit.PasswordChar = "*"
            Button22.Image = My.Resources.eye_fill_icon
        Else
            txtOldpasswordEdit.PasswordChar = Nothing
            Button22.Image = My.Resources.eye_slash_fill_icon
        End If
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

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        frmMainPage.Show()
        Me.Close()
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        frmMainPage.Show()
        Me.Close()
    End Sub

    Function generateBackupCode()
        Dim Random1 As New Random
        Dim backupPin As String = Convert.ToString(Random1.Next(1000, 9999)) + "-" + Convert.ToString(Random1.Next(1000, 9999)) _
        + "-" + Convert.ToString(Random1.Next(1000, 9999)) + "-" + Convert.ToString(Random1.Next(1000, 9999))
        Return backupPin
    End Function

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Are you sure you want to overwrite the old backup code?", MsgBoxStyle.Exclamation + vbYesNo, "CAUTION") = MsgBoxResult.Yes Then
            Dim DBcmd As New OleDb.OleDbCommand
            Dim pinHolder As String = ""
            Dim backupPin As String = generateBackupCode()
            DBstring = "select BackupCode from teacherAccount where BackupCode like '" & backupPin & "%'"
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBadapter.SelectCommand = DBcmd
            DBreader = DBcmd.ExecuteReader
            While DBreader.Read
                pinHolder = DBreader("BackupCode").ToString
            End While
            DBcmd.Dispose()
            DBreader.Close()
            If pinHolder = backupPin Then
                backupPin = generateBackupCode()
            End If
            DBstring = "update teacherAccount set [BackupCode] ='" & backupPin & "' where [idAcc] ='" & frmMainPage.lblIDnum.Text & "';"
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBcmd.ExecuteNonQuery()
            DBcmd.Dispose()
            DBreader.Close()
            MsgBox("Backup Code Changed", MsgBoxStyle.Information)
            txtBackUpCode.Text = backupPin
        End If
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        If txtRegisteredEmail.PasswordChar = Nothing Then
            txtRegisteredEmail.PasswordChar = "*"
            Button28.Image = My.Resources.eye_fill_icon
        Else
            txtRegisteredEmail.PasswordChar = Nothing
            Button28.Image = My.Resources.eye_slash_fill_icon
        End If
    End Sub

    Function generateOTP()
        Dim alphabets As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim small_alphabets As String = "abcdefghijklmnopqrstuvwxyz"
        Dim numbers As String = "1234567890"

        Dim characters As String = numbers
        'characters += Convert.ToString(alphabets & small_alphabets) & numbers
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
    Private Sub btnSendCodeRE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendCodeRE.Click
        otpholder = generateOTP()
        Try
            SendEmailMessage(txtEmailRE.Text, "Automated Attendance System - Verification Code [" & otpholder _
                             & "]", "Your verification code for our system is [" & otpholder _
                             & "]. Please ignore if you did not request this code.")
        Catch fe As System.FormatException
            MsgBox("Please Input a Valid Email.", MsgBoxStyle.Critical, "Invalid Email Adress")
            Exit Sub
        Catch ex As Exception
            MsgBox("Mail failed to deliver.", MsgBoxStyle.Critical, "Mailing Error")
            Exit Sub
        End Try

        MsgBox("Your verification code has been sent to your email.", MsgBoxStyle.Information, "Mail Sent")
        Label17.Visible = True
        txtVerifyCodeRE.Visible = True
        btnVerfyCodeRE.Visible = True
    End Sub

    Private Sub btnRE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRE.Click
        grpbOTP.Visible = True
    End Sub

    Private Sub btnVerfyCodeRE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerfyCodeRE.Click
        If txtVerifyCodeRE.Text = otpholder Then
            DBstring = "update teacherInfo set [Gmail] ='" & txtEmailRE.Text & "' where [ID] =" & frmMainPage.lblIDnum.Text & ";"
            Dim DBcmd As New OleDb.OleDbCommand
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBcmd.ExecuteNonQuery()
            DBcmd.Dispose()
            DBreader.Close()
            MsgBox("Email Registered", MsgBoxStyle.Information, "Email Registration Success")
            DBstring = "select Gmail from teacherInfo where ID like " & frmMainPage.lblIDnum.Text & ";"
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBadapter.SelectCommand = DBcmd
            DBreader = DBcmd.ExecuteReader
            While DBreader.Read
                txtRegisteredEmail.Text = DBreader("Gmail").ToString
            End While
            grpbOTP.Visible = False
        End If
    End Sub

    Private Sub btnGenerateBackupCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateBackupCode.Click
        Dim DBcmd As New OleDb.OleDbCommand
        Dim pinHolder As String = ""
        Dim backupPin As String = generateBackupCode()
        DBstring = "select BackupCode from teacherAccount where BackupCode like '" & backupPin & "%'"
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While DBreader.Read
            pinHolder = DBreader("BackupCode").ToString
        End While
        DBcmd.Dispose()
        DBreader.Close()
        If pinHolder = backupPin Then
            backupPin = generateBackupCode()
        End If
        txtBackUpCode.Text = backupPin
        DBstring = "update teacherAccount set [BackupCode] ='" & backupPin & "' where [idAcc] ='" & frmMainPage.lblIDnum.Text & "';"
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBcmd.ExecuteNonQuery()
        DBcmd.Dispose()
        DBreader.Close()
        MsgBox("Backup Code Generated")
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        frmMainPage.Show()
        Me.Close()
    End Sub

    Private Sub txtEditUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEditUsername.TextChanged

    End Sub
End Class