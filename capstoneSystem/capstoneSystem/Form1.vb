Public Class frmLogin
    Dim loginRestrictCounter = 0
    Dim loginRestrictTime = 31
    Public Shared username As String = ""
    Public Shared password As String = ""
    Public Shared ID As String = ""
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtBarcodeReader.Select()
        connectToDB.connectDB()
        tmrDBcheckerUpdater.Start()
    End Sub

    Private Sub tmrLoginRestrict_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLoginRestrict.Tick
        loginRestrictTime -= 1
        lblInvalid.Text = "Please try again later " + loginRestrictTime.ToString
        If loginRestrictTime <= 0 Then
            loginRestrictCounter = 0
            loginRestrictTime = 31
            txtUsername.ReadOnly = False
            txtPassword.ReadOnly = False
            btnLogin.Enabled = True
            grbLoginType.Enabled = True
            lblInvalid.Visible = False
            tmrLoginRestrict.Stop()
        End If
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        txtBarcodeReader.Select()
        DBstring = "select * from teacherAccount where username like '" & txtUsername.Text & "%'"
        Dim DBcmd As New OleDb.OleDbCommand
        Dim isAdmin As Boolean = 0
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While (DBreader.Read())
            username = DBreader("username").ToString
            password = DBreader("password").ToString
            ID = DBreader("idAcc").ToString
            frmMainPage.lblIDnum.Text = DBreader("idAcc").ToString
            Try
                isAdmin = DBreader("isAdmin").ToString
            Catch ice As InvalidCastException
                isAdmin = 0
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Occured")
            End Try

        End While
        DBcmd.Dispose()
        DBreader.Close()
        Dim teacherStatusholder As String = ""
        DBstring = "Select [Status] from teacherInfo where [ID] like '" & ID & "%'"
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While (DBreader.Read())
            teacherStatusholder = DBreader("Status").ToString
        End While
        DBcmd.Dispose()
        DBreader.Close()
        If teacherStatusholder = "Inactive" Then
            MsgBox("THIS ACCOUNT CAN NO LONGER BE ACCESS", MsgBoxStyle.Critical, "Login Error")
            txtUsername.Text = ""
            txtPassword.Text = ""
            Exit Sub
        End If
        If txtUsername.Text = username And txtPassword.Text = password Then
            If rdbClockIn.Checked = True Then
                MsgBox("Login Success")
                frmClockIn.Show()
                frmMainPage.Close()
                password = Nothing
                txtUsername.Text = ""
                txtPassword.Text = ""
            ElseIf rdbLogIn.Checked = True Then
                MsgBox("Login Success")
                frmMainPage.Show()
                frmClockIn.Close()
                password = Nothing
                txtUsername.Text = ""
                txtPassword.Text = ""
                If isAdmin = True Then
                    frmMainPage.lblIsAdmin.Visible = True
                    frmMainPage.btnMonitoring.Visible = True
                    frmMainPage.btnTeacherList.Visible = True
                End If
                
            Else
                MsgBox("Please select what type of Log In to execute.", MsgBoxStyle.Exclamation, "LOGIN TYPE NOT SELECTED")
            End If
            'Dim ani As New PictureBox
            'ani.Location = New Point(0, 0)
            'ani.Size = New Size(816, 407)
            'ani.SizeMode = PictureBoxSizeMode.StretchImage
            'ani.Image = My.Resources._try
            'Me.Controls.Add(ani)6
        ElseIf Not txtUsername.Text = username And txtPassword.Text = password Then
            lblInvalidPassword.Visible = False
            lblInvalidUsername.Text = "Invalid Username"
            lblInvalidUsername.Visible = True
        ElseIf txtUsername.Text = username And Not txtPassword.Text = password Then
            loginRestrictCounter += 1
            If loginRestrictCounter >= 5 Then
                txtUsername.ReadOnly = True
                txtPassword.ReadOnly = True
                btnLogin.Enabled = False
                grbLoginType.Enabled = False
                lblInvalid.Visible = True
                DBstring = "insert into teacherAuditLog1([Time], [ID], [TeacherName], [Activity], [ActivityDate]) values ('" _
                & TimeOfDay.ToString("hh:mm tt") & "', '" _
                & ID & "', '" _
                & username & "', '" _
                & "Failed to Login 5 times." & "', '" _
                & DateTime.Today.ToString("MMMM dd, yyyy") & "')"
                DBcmd.CommandText = DBstring
                DBcmd.Connection = DBconnection
                DBcmd.ExecuteNonQuery()
                DBcmd.Dispose()
                DBreader.Close()
                tmrLoginRestrict.Start()
            End If
            lblInvalidUsername.Visible = False
            lblInvalidPassword.Text = "Invalid Password"
            lblInvalidPassword.Visible = True
        ElseIf txtUsername.Text = Nothing And txtPassword.TextLength > 0 Then
            lblInvalidPassword.Visible = False
            lblInvalidUsername.Text = "Username cannot be empty"
            lblInvalidUsername.Visible = True
        ElseIf txtUsername.TextLength > 0 And txtPassword.Text = Nothing Then
            lblInvalidUsername.Visible = False
            lblInvalidPassword.Text = "Password cannot be empty"
            lblInvalidPassword.Visible = True
        ElseIf txtUsername.Text = Nothing And txtPassword.Text = Nothing Then
            lblInvalidUsername.Visible = True
            lblInvalidPassword.Visible = True
            lblInvalidUsername.Text = "Username cannot be empty"
            lblInvalidPassword.Text = "Password cannot be empty"
        ElseIf txtPassword.TextLength < 4 Then
            lblInvalidPassword.Text = "Password must be greater than 4 characters"
        Else
            lblInvalidUsername.Visible = True
            lblInvalidPassword.Visible = True
            lblInvalidUsername.Text = "Invalid Username"
            lblInvalidPassword.Text = "Invalid Password"
        End If
    End Sub

    Sub checkAccount()
        DBstring = "select * from student_list where ID like '" & txtUsername.Text & "%'"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader

    End Sub

    Private Sub lblForgotPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblForgotPassword.Click
        txtBarcodeReader.Select()
        Me.Enabled = False
        frmForgotPassword.Show()
    End Sub
    Private Sub lblForgotPassword_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblForgotPassword.MouseHover
        lblForgotPassword.ForeColor = Color.Black
    End Sub
    Private Sub lblForgotPassword_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblForgotPassword.MouseLeave
        lblForgotPassword.ForeColor = Color.Gray
    End Sub

    Private Sub btnLogin_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.MouseHover
        'btnLogin.Location = New Point(508, 312)
    End Sub

    Private Sub btnLogin_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.MouseLeave
        'btnLogin.Location = New Point(508, 310)
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        If txtPassword.TextLength <= 4 And Not txtPassword.TextLength = 0 Then
            txtPassword.BackColor = Color.FromArgb(247, 223, 223) 'very light red
        ElseIf txtPassword.TextLength > 4 Then
            txtPassword.BackColor = Color.FromArgb(208, 245, 218) 'very light green
        Else
            txtPassword.BackColor = Color.White
        End If
    End Sub

    Private Sub tmrDBcheckerUpdater_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDBcheckerUpdater.Tick
        isBreakStillValid()
        updateOnBreakStatus()
    End Sub

    Private Sub isBreakStillValid()
        Dim ID As New List(Of String)
        Dim DateEnd As New List(Of String)
        Dim DBcmd As New OleDb.OleDbCommand
        Try
            DBstring = "select teacherID, DateEnd from teacherOnBreak;"
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBadapter.SelectCommand = DBcmd
            DBreader = DBcmd.ExecuteReader
            While DBreader.Read
                With ID
                    .Add(DBreader("teacherID").ToString)
                End With
                With DateEnd
                    .Add(DBreader("DateEnd").ToString)
                End With
            End While
            DBcmd.Dispose()
            DBreader.Close()
        Catch ex As Exception

        End Try
        Dim dateN = Date.Now.ToString("MMMM dd, yyyy")
        For i As Integer = 0 To ID.Count - 1
            Try
                If DateEnd(i) = Date.Now.ToString("MMMM dd, yyyy") Then
                    Dim act = "Active"
                    DBstring = "update teacherInfo set [Status] ='" & act & "' where [ID] = " & ID(i).ToString & ";"
                    DBcmd.CommandText = DBstring
                    DBcmd.Connection = DBconnection
                    DBcmd.ExecuteNonQuery()
                    DBcmd.Dispose()
                    DBreader.Close()
                End If
            Catch aoore As ArgumentOutOfRangeException
                Exit For
            Catch ex As Exception
            End Try
        Next
    End Sub

    Private Sub updateOnBreakStatus()
        Dim ID As New List(Of String)
        Dim DateStart As New List(Of String)
        Dim DBcmd As New OleDb.OleDbCommand
        Try
            DBstring = "select teacherID, DateStart from teacherOnBreak;"
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBadapter.SelectCommand = DBcmd
            DBreader = DBcmd.ExecuteReader
            While DBreader.Read
                With ID
                    .Add(DBreader("teacherID").ToString)
                End With
                With DateStart
                    .Add(DBreader("DateStart").ToString)
                End With
            End While
            DBcmd.Dispose()
            DBreader.Close()
        Catch ex As Exception

        End Try
        Dim dateN = Date.Now.ToString("MMMM dd, yyyy")
        For i As Integer = 0 To ID.Count - 1
            Try
                If DateStart(i) = Date.Now.ToString("MMMM dd, yyyy") Then
                    Dim act = "On-Break"
                    DBstring = "update teacherInfo set [Status] ='" & act & "' where [ID] = " & ID(i).ToString & ";"
                    DBcmd.CommandText = DBstring
                    DBcmd.Connection = DBconnection
                    DBcmd.ExecuteNonQuery()
                    DBcmd.Dispose()
                    DBreader.Close()
                End If
            Catch aoore As ArgumentOutOfRangeException
                Exit For
            Catch ex As Exception
            End Try
        Next
    End Sub

    Private Sub txtBarcodeReader_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcodeReader.TextChanged
        Dim DBcmd As New OleDb.OleDbCommand
        Dim brcode As String = ""

        If txtBarcodeReader.TextLength > 5 Then
            DBstring = "Select [Barcode], [ID] from teacherInfo where [Barcode] like '" & txtBarcodeReader.Text & "%'"
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBadapter.SelectCommand = DBcmd
            DBreader = DBcmd.ExecuteReader
            While DBreader.Read
                If DBreader("Barcode").ToString = txtBarcodeReader.Text Then
                    brcode = DBreader("Barcode").ToString
                    ID = DBreader("ID").ToString
                End If
            End While
            DBreader.Close()
        End If
        If brcode = txtBarcodeReader.Text Then
            DBstring = "Select [username] from teacherAccount where [idAcc] like '" & ID & "%'"
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBadapter.SelectCommand = DBcmd
            DBreader = DBcmd.ExecuteReader
            While DBreader.Read
                username = DBreader("username").ToString
            End While
            DBcmd.Dispose()
            DBreader.Close()
            frmAutoClockIn.Show()
            txtBarcodeReader.Text = Nothing
        End If

    End Sub
    Private Sub rdbClockIn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbClockIn.Click
        txtBarcodeReader.Select()
    End Sub

    Private Sub rdbLogIn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbLogIn.CheckedChanged
        txtBarcodeReader.Select()
    End Sub

    Private Sub frmLogin_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        txtBarcodeReader.Select()
    End Sub
End Class
