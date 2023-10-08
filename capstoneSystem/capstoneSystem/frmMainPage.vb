Public Class frmMainPage

    
    'Dim recentNoteHolder As New List(Of String)
    Private Sub frmMainPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        filluserInfo()
        fillRecentAttendance()
        LogActivity(lblIDnum.Text, lblName.Text, frmLogin.username, "Logged In (TYPE= Attendance Log)")
        tmrTime.Start()
        frmLogin.Opacity = 60%
        tlp.Height = 0
    End Sub

    Private Sub frmMainPage_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If frmLogin.password = "yasc@123" Then
            If MsgBox("You are currently using the default password. Please change your password immediately", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "CHANGE PASSWORD") = MsgBoxResult.Yes Then
                frmMenu.Show()
            End If
        End If
    End Sub

    Private Sub fillRecentAttendance()
        DBstring = "select * from teacherLogTimeIn  where ID like '" & lblIDnum.Text & "%' order by ID DESC, LogDate DESC;"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        Dim dateHolder As New List(Of String)
        Dim timeInHolder As New List(Of String)
        Dim timeOutHolder As New List(Of String)
        'Dim TempHolder As New List(Of String)
        Dim StatusHolder As New List(Of String)
        While (DBreader.Read())
            With dateHolder
                If IsDBNull(DBreader("LogDate")) Then
                    .Add("Not Recorded")
                Else
                    .Add(DBreader("LogDate").ToString)
                End If
            End With
            With timeInHolder
                If IsDBNull(DBreader("LogTimeIn")) Then
                    .Add("Not Recorded")
                Else
                    .Add(DBreader("LogTimeIn").ToString)
                End If
            End With
            With timeOutHolder
                If IsDBNull(DBreader("LogTimeOut")) Then
                    .Add("Not Recorded")
                Else
                    .Add(DBreader("LogTimeOut").ToString)
                End If
            End With
            'With TempHolder
            '    If IsDBNull(DBreader("Temperature")) Then
            '        .Add("N/A")
            '    Else
            '        .Add(DBreader("Temperature").ToString)
            '    End If
            'End With
            With StatusHolder
                .Add(DBreader("LogInStatus").ToString)
            End With
            'With recentNoteHolder
            '    .Add(DBreader("LogNote").ToString)
            'End With
        End While
        DBcmd.Dispose()
        DBreader.Close()
        Try
            lblDate1.Text = dateHolder(0)
            lblTimeIn1.Text = timeInHolder(0)
            lblTimeOut1.Text = timeOutHolder(0)

            'lblTemp1.Text = TempHolder(0)
            If StatusHolder(0) = "ABSENT" Then
                lblStatus1.Visible = True
            ElseIf StatusHolder(0) = "ON-BREAK" Then
                lblStatus1.Text = "ON-BREAK"
                lblStatus1.Visible = True
            End If
            lblDate2.Text = dateHolder(1)
            lblTimeIn2.Text = timeInHolder(1)
            lblTimeOut2.Text = timeOutHolder(1)

            'lblTemp2.Text = TempHolder(1)
            If StatusHolder(1) = "ABSENT" Then
                lblStatus2.Visible = True
            ElseIf StatusHolder(1) = "ON-BREAK" Then
                lblStatus2.Text = "ON-BREAK"
                lblStatus2.Visible = True
            End If
            lblDate3.Text = dateHolder(2)
            lblTimeIn3.Text = timeInHolder(2)
            lblTimeOut3.Text = timeOutHolder(2)

            'lblTemp3.Text = TempHolder(2)
            If StatusHolder(2) = "ABSENT" Then
                lblStatus3.Visible = True
            ElseIf StatusHolder(2) = "ON-BREAK" Then
                lblStatus3.Text = "ON-BREAK"
                lblStatus3.Visible = True
            End If
            lblDate4.Text = dateHolder(3)
            lblTimeIn4.Text = timeInHolder(3)
            lblTimeOut4.Text = timeOutHolder(3)

            ' lblTemp4.Text = TempHolder(3)
            If StatusHolder(3) = "ABSENT" Then
                lblStatus4.Visible = True
            ElseIf StatusHolder(3) = "ON-BREAK" Then
                lblStatus4.Text = "ON-BREAK"
                lblStatus4.Visible = True
            End If
            lblDate5.Text = dateHolder(4)
            lblTimeIn5.Text = timeInHolder(4)
            lblTimeOut5.Text = timeOutHolder(4)

            '  lblTemp5.Text = TempHolder(4)
            If StatusHolder(4) = "ABSENT" Then
                lblStatus5.Visible = True
            ElseIf StatusHolder(4) = "ON-BREAK" Then
                lblStatus5.Text = "ON-BREAK"
                lblStatus5.Visible = True
            End If
        Catch ex As Exception
        End Try
        If lblDate1.Text = Nothing Then
            btnNote1.Visible = False
        End If
        If lblDate2.Text = Nothing Then
            btnNote2.Visible = False
        End If
        If lblDate3.Text = Nothing Then
            btnNote3.Visible = False
        End If
        If lblDate4.Text = Nothing Then
            btnNote4.Visible = False
        End If
        If lblDate5.Text = Nothing Then
            btnNote5.Visible = False
        End If

    End Sub

    Private Sub filluserInfo()
        DBstring = "select * from teacherInfo where ID like '" & lblIDnum.Text & "%'"
        Dim DBcmd As New OleDb.OleDbCommand
        Dim username As String = ""
        Dim password As String = ""
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While (DBreader.Read())
            lblName.Text = DBreader("TeacherNameLN").ToString + ", " + DBreader("TeacherNameFN").ToString + " " + DBreader("TeacherNameMN").ToString
            Try
                PictureBox1.Image = Image.FromFile(DBreader("TeacherPhotoPath"))
            Catch ex As Exception
                PictureBox1.Image = Nothing
            End Try

        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub updateTeacherNote(ByVal ID As String, ByVal logDate As String)
        DBstring = "select * from teacherLogTimeIn where ID like '" & ID & "' and LogDate like '" & logDate & "';"
        Dim DBcmd As New OleDb.OleDbCommand
        Dim dateConvert As String = ""
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While (DBreader.Read())
            dateConvert = DBreader("LogDate").ToString
            lblLogDateNote.Text = DBreader("LogDate").ToString
            lblTimeInTimeOutNote.Text = DBreader("LogTimeIn").ToString & " • " & DBreader("LogTimeOut").ToString
            lblLogStatusNote.Text = DBreader("LogInStatus").ToString
            rtxtNote.Text = DBreader("LogNote").ToString
        End While
        DBcmd.Dispose()
        DBreader.Close()
        If Not logDate = dateConvert Then
            rtxtNote.Clear()
            lblLogDateNote.Text = ""
            lblTimeInTimeOutNote.Text = " • "
            lblLogStatusNote.Text = ""
            btnAddNote.Enabled = False
            btnEditNote.Enabled = False
            Label14.Visible = True
        End If
    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        If tlp.Height = 0 Then
            tmrOpenMenu.Start()
        ElseIf tlp.Height >= 39 Then
            tmrCloseMenu.Start()
        End If
    End Sub

    Private Sub tmrOpenMenu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOpenMenu.Tick
        If tlp.Height >= 39 Then
            tmrOpenMenu.Stop()
        Else
            tlp.Height += 5
            'pnlNamesDisplay.Width -= 50
        End If
    End Sub

    Private Sub tmrCloseMenu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCloseMenu.Tick
        If tlp.Height <= 0 Then
            tmrCloseMenu.Stop()
        Else
            tlp.Height -= 5
            ' pnlNamesDisplay.Width += 50
        End If
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        If MsgBox("Do you want to Log out?", vbYesNo, "LOGOUT") = MsgBoxResult.Yes Then
            LogActivity(lblIDnum.Text, lblName.Text, frmLogin.username, "Logged Out (TYPE= Attendance Log)")
            Me.WindowState = FormWindowState.Normal
            Me.Close()
            frmLogin.WindowState = FormWindowState.Maximized
            frmLogin.Show()
        End If
    End Sub

    Private Sub btnSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetting.Click
        frmMenu.Show()
        'frmMenu.tbctlMenu.SelectTab(frmMenu.tbpgAboutUs)
    End Sub

    Private Sub btnTeacherList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeacherList.Click
        frmAdminMenu.Show()
    End Sub

    Private Sub btnChart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChart.Click
        frmChart.Show()
    End Sub

    Private Sub pcbSeeChart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pcbSeeChart.Click
        frmChart.Show()
    End Sub

    Private Sub tmrTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTime.Tick
        lblTime.Text = TimeOfDay.ToString("hh:mm tt")
    End Sub

    Private Sub btnMonitoring_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMonitoring.Click
        frmMonitoring.Show()
    End Sub
    Private Sub btnBreakNotice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBreakNotice.Click
        frmBreakNotice.Show()
    End Sub

    Private Sub btnNote1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNote1.Click
        rtxtNote.Clear()
        updateTeacherNote(lblIDnum.Text, lblDate1.Text)
        If rtxtNote.Text = Nothing Then
            Label14.Visible = True
            btnAddNote.Enabled = True
            btnEditNote.Enabled = False
        Else
            Label14.Visible = False
            btnAddNote.Enabled = False
            btnEditNote.Enabled = True
        End If
    End Sub

    Private Sub btnNote2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNote2.Click
        rtxtNote.Clear()
        updateTeacherNote(lblIDnum.Text, lblDate2.Text)
        If rtxtNote.Text = Nothing Then
            Label14.Visible = True
            btnAddNote.Enabled = True
            btnEditNote.Enabled = False
        Else
            Label14.Visible = False
            btnAddNote.Enabled = False
            btnEditNote.Enabled = True
        End If
    End Sub

    Private Sub btnNote3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNote3.Click
        rtxtNote.Clear()
        updateTeacherNote(lblIDnum.Text, lblDate3.Text)
        If rtxtNote.Text = Nothing Then
            Label14.Visible = True
            btnAddNote.Enabled = True
            btnEditNote.Enabled = False
        Else
            Label14.Visible = False
            btnAddNote.Enabled = False
            btnEditNote.Enabled = True
        End If
    End Sub

    Private Sub btnNote4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNote4.Click
        rtxtNote.Clear()
        updateTeacherNote(lblIDnum.Text, lblDate4.Text)
        If rtxtNote.Text = Nothing Then
            Label14.Visible = True
            btnAddNote.Enabled = True
            btnEditNote.Enabled = False
        Else
            Label14.Visible = False
            btnAddNote.Enabled = False
            btnEditNote.Enabled = True
        End If
    End Sub

    Private Sub btnNote5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNote5.Click
        rtxtNote.Clear()
        updateTeacherNote(lblIDnum.Text, lblDate5.Text)
        If rtxtNote.Text = Nothing Then
            Label14.Visible = True
            btnAddNote.Enabled = True
            btnEditNote.Enabled = False
        Else
            Label14.Visible = False
            btnAddNote.Enabled = False
            btnEditNote.Enabled = True
        End If
    End Sub

    Private Sub btnEditNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditNote.Click
        btnSaveNote.Enabled = True
        rtxtNote.ReadOnly = False
    End Sub

    Private Sub btnAddNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNote.Click
        Label14.Visible = False
        btnSaveNote.Enabled = True
        rtxtNote.ReadOnly = False
    End Sub

    Private Sub btnSaveNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveNote.Click
        If MsgBox("Do you want to save this note?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "CAUTION") = MsgBoxResult.Ok Then
            DBstring = "update teacherLogTimeIn set [LogNote] ='" & rtxtNote.Text & _
        "' where [ID] ='" & lblIDnum.Text & "' and [LogDate] = '" & lblLogDateNote.Text & "';"
            Dim DBcmd As New OleDb.OleDbCommand
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBcmd.ExecuteNonQuery()
            DBcmd.Dispose()
            DBreader.Close()
            btnSaveNote.Enabled = False
            btnAddNote.Enabled = False
            MsgBox("SAVED", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub dtpFilterDateNote_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFilterDateNote.ValueChanged
        updateTeacherNote(lblIDnum.Text, dtpFilterDateNote.Value.ToString("MMMM dd, yyyy"))
        If rtxtNote.Text = Nothing And Not lblLogDateNote.Text = "" Then
            Label14.Visible = True
            btnAddNote.Enabled = True
            btnEditNote.Enabled = False
        ElseIf Not rtxtNote.Text = Nothing And Not lblLogDateNote.Text = "" Then
            Label14.Visible = False
            btnAddNote.Enabled = False
            btnEditNote.Enabled = True
        End If
    End Sub

End Class