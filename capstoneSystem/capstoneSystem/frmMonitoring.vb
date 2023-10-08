Public Class frmMonitoring

    Private Sub btnAuditLogTab0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuditLogTab0.Click
        TabControl1.SelectTab(1)
    End Sub
    Private Sub btnTeacherNotesTab0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeacherNotesTab0.Click
        TabControl1.SelectTab(2)
    End Sub
    Private Sub btnDashboardTab1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDashboardTab1.Click
        TabControl1.SelectTab(0)
    End Sub
    Private Sub btnTeacherNotesTab1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeacherNotesTab1.Click
        TabControl1.SelectTab(2)
    End Sub
    Private Sub btnDashboardTab2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDashboardTab2.Click
        TabControl1.SelectTab(0)
    End Sub
    Private Sub btnAuditLogTab2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuditLogTab2.Click
        TabControl1.SelectTab(1)
    End Sub
    Private Sub btnMainPageTab0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainPageTab0.Click
        Me.Close()
        Me.Dispose()
        frmMainPage.Show()
    End Sub
    Private Sub btnMainPageTab1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHomePageTab1.Click
        Me.Dispose()
        frmMainPage.Show()
    End Sub
    Private Sub btnMainPageTab2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        frmMainPage.Show()
    End Sub


    Private Sub frmMonitoring_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setUplstvwAuditLog(lstvwAuditLog)
        setUplstvwTeacherNotes(lstvwTeacherNotes)
        setUplstvwBreakNotice(lstvwBreakNotice)
        filllstvwAuditLog(lstvwAuditLog)
        filllstvwTeacherNotes(lstvwTeacherNotes)
        filllstvwBreakNotice(lstvwBreakNotice)
        lblDashboardDate.Text = "DASHBOARD • " & DateTime.Today.ToString("MMM d yyyy")
        fillDashboard()
        tmrRefresher.Start()
        fillcmbActivity()
        Label1.BackColor = Color.FromArgb(60, 157, 234)
    End Sub

    Private Sub setUplstvwTeacherNotes(ByVal listviewholder As ListView)
        listviewholder.View = View.Details
        listviewholder.FullRowSelect = True
        listviewholder.HideSelection = True
        listviewholder.MultiSelect = False
        listviewholder.Columns.Add("ID", 50, HorizontalAlignment.Center)
        listviewholder.Columns.Add("NAME", 290, HorizontalAlignment.Left)
        listviewholder.Columns.Add("DATE", 195, HorizontalAlignment.Center)
        listviewholder.Columns.Add("STATUS", 100, HorizontalAlignment.Center)
    End Sub
    Private Sub filllstvwTeacherNotes(ByVal listviewholder As ListView)
        DBstring = "select * from [teacherLogTimeIn] order by LogDate DESC, ID DESC;"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        listviewholder.Items.Clear()
        While (DBreader.Read())
            With listviewholder.Items.Add(DBreader("ID").ToString)
                .SubItems.Add(DBreader("TeacherName").ToString)
                .SubItems.Add(DBreader("LogDate").ToString)
                .SubItems.Add(DBreader("LogInStatus").ToString)
            End With
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub setUplstvwBreakNotice(ByVal listviewholder As ListView)
        listviewholder.View = View.Details
        listviewholder.FullRowSelect = True
        listviewholder.HideSelection = True
        listviewholder.MultiSelect = False
        listviewholder.Columns.Add("DAYS", 50, HorizontalAlignment.Center)
        listviewholder.Columns.Add("ID", 50, HorizontalAlignment.Center)
        listviewholder.Columns.Add("NAME", 290, HorizontalAlignment.Left)
        listviewholder.Columns.Add("DATE ANNOUNCED", 200, HorizontalAlignment.Center)
    End Sub

    Private Sub filllstvwBreakNotice(ByVal listviewholder As ListView)
        DBstring = "select * from [teacherOnBreak] order by DateAnnounced DESC;"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        listviewholder.Items.Clear()
        While (DBreader.Read())
            With listviewholder.Items.Add(DBreader("Days").ToString)
                .SubItems.Add(DBreader("TeacherID").ToString)
                .SubItems.Add(DBreader("TeacherName").ToString)
                .SubItems.Add(DBreader("DateAnnounced").ToString)
            End With
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub setUplstvwAuditLog(ByVal listviewholder As ListView)
        listviewholder.View = View.Details
        ' listviewholder.GridLines = True
        listviewholder.FullRowSelect = True
        listviewholder.HideSelection = True
        listviewholder.MultiSelect = False
        listviewholder.Columns.Add("TIME", 100, HorizontalAlignment.Center)
        listviewholder.Columns.Add("ID", 50, HorizontalAlignment.Center)
        listviewholder.Columns.Add("NAME", 150, HorizontalAlignment.Left)
        listviewholder.Columns.Add("USERNAME", 90, HorizontalAlignment.Left)
        listviewholder.Columns.Add("LOG", 300, HorizontalAlignment.Center)
        listviewholder.Columns.Add("DATE", 150, HorizontalAlignment.Center)
    End Sub
    Sub filllstvwAuditLog(ByVal listviewholder As ListView)
        DBstring = "select * from [teacherAuditLog1] order by ActivityDate DESC, Time DESC;"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        listviewholder.Items.Clear()
        While (DBreader.Read())
            With listviewholder.Items.Add(DBreader("Time").ToString)
                .SubItems.Add(DBreader("ID").ToString)
                .SubItems.Add(DBreader("TeacherName").ToString)
                .SubItems.Add(DBreader("Username").ToString)
                .SubItems.Add(DBreader("Activity").ToString)
                .SubItems.Add(DBreader("ActivityDate").ToString)
            End With
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub fillDashboard()
        Dim DBcmd As New OleDb.OleDbCommand
        Dim NoTeacher As Integer = 0
        DBstring = "Select [ID] from teacherInfo where [Status] like 'Active' Or [Status] like 'On-Break';"
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While DBreader.Read
            NoTeacher += 1
        End While
        lblDashboardNoTeacher.Text = NoTeacher.ToString
        DBcmd.Dispose()
        DBreader.Close()
        Dim NoOnBreak As Integer = 0
        DBstring = "Select [ID] from teacherInfo where [Status] like 'On-Break';"
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While DBreader.Read
            NoOnBreak += 1
        End While
        lblDashboardNoOnBreak.Text = NoOnBreak.ToString
        DBcmd.Dispose()
        DBreader.Close()
        Dim NoPresent As Integer = 0
        Dim NoOnTime As Integer = 0
        Dim NoLate As Integer = 0
        Dim NoAbsent As Integer = 0
        DBstring = "Select * from teacherLogTimeIn where [LogDate] like '" & DateTime.Today.ToString("MMMM dd, yyyy") & "';"
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While DBreader.Read
            If DBreader("LogInStatus").ToString = "ON-TIME" Or DBreader("LogInStatus").ToString = "LATE" Then
                NoPresent += 1
            End If
            If DBreader("LogInStatus").ToString = "ON-TIME" Then
                NoOnTime += 1
            End If
            If DBreader("LogInStatus").ToString = "LATE" Then
                NoLate += 1
            End If
            If DBreader("LogInStatus").ToString = "ABSENT" Then
                NoAbsent += 1
            End If
        End While
        lblDashboardNoPresent.Text = NoPresent.ToString
        lblDashboardNoOnTime.Text = NoOnTime.ToString
        lblDashboardNoLate.Text = NoLate.ToString
        lblDashboardNoAbsent.Text = NoAbsent.ToString
        DBcmd.Dispose()
        DBreader.Close()
    End Sub



    Private Sub tmrRefresher_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRefresher.Tick
        fillDashboard()
        filllstvwAuditLog(lstvwAuditLog)
    End Sub

    Private Sub tbpDashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbpDashboard.Click

    End Sub

    Private Sub AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AToolStripMenuItem.Click
        tmrRefresher.Stop()
        lstvwAuditLog.Sorting = SortOrder.Ascending
    End Sub

    Private Sub DescendingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescendingToolStripMenuItem1.Click
        tmrRefresher.Stop()
        lstvwAuditLog.Sorting = SortOrder.Descending
    End Sub

    Private Sub ClearSortToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearSortToolStripMenuItem.Click
        tmrRefresher.Stop()
        lstvwAuditLog.Sorting = SortOrder.None
    End Sub

    Private Sub fillcmbActivity()
        cmbActivity.Items.Add("Logged In (TYPE= Clock In)")
        cmbActivity.Items.Add("Logged Out (TYPE= Clock In)")
        cmbActivity.Items.Add("Logged In (TYPE= Attendance Log)")
        cmbActivity.Items.Add("Logged Out (TYPE= Attendance Log)")
        cmbActivity.Items.Add("Timed In")
        cmbActivity.Items.Add("Timed Out")
        cmbActivity.Items.Add("Failed to Login 5 times.")

    End Sub

    Private Sub tbpAuditLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbpAuditLog.Click

    End Sub

    Private Sub cmbActivity_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbActivity.SelectedIndexChanged
        tmrRefresher.Stop()
        DBstring = "select * from [teacherAuditLog1] where Activity like '" & cmbActivity.Text & "%'"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        lstvwAuditLog.Items.Clear()
        While (DBreader.Read())
            With lstvwAuditLog.Items.Add(DBreader("Time").ToString)
                .SubItems.Add(DBreader("ID").ToString)
                .SubItems.Add(DBreader("TeacherName").ToString)
                .SubItems.Add(DBreader("Username").ToString)
                .SubItems.Add(DBreader("Activity").ToString)
                .SubItems.Add(DBreader("ActivityDate").ToString)
            End With
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub btnClearAllFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAllFilter.Click
        tmrRefresher.Start()
        filllstvwAuditLog(lstvwAuditLog)
    End Sub

    Private Sub dtpDateR1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateR1.ValueChanged
        tmrRefresher.Stop()
        DBstring = "select * from [teacherAuditLog1] where [ActivityDate] between '" & _
        dtpDateR1.Value.ToString("MMMM dd, yyyy") & "' and '" & dtpDateR2.Value.ToString("MMMM dd, yyyy") & "';"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        lstvwAuditLog.Items.Clear()
        While DBreader.Read
            With lstvwAuditLog.Items.Add(DBreader("Time").ToString)
                .SubItems.Add(DBreader("ID").ToString)
                .SubItems.Add(DBreader("TeacherName").ToString)
                .SubItems.Add(DBreader("Username").ToString)
                .SubItems.Add(DBreader("Activity").ToString)
                .SubItems.Add(DBreader("ActivityDate").ToString)
            End With
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub dtpDateR2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateR2.ValueChanged
        tmrRefresher.Stop()
        DBstring = "select * from [teacherAuditLog1] where [ActivityDate] between '" & _
       dtpDateR1.Value.ToString("MMMM dd, yyyy") & "' and '" & dtpDateR2.Value.ToString("MMMM dd, yyyy") & "';"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        lstvwAuditLog.Items.Clear()
        While DBreader.Read
            With lstvwAuditLog.Items.Add(DBreader("Time").ToString)
                .SubItems.Add(DBreader("ID").ToString)
                .SubItems.Add(DBreader("TeacherName").ToString)
                .SubItems.Add(DBreader("Username").ToString)
                .SubItems.Add(DBreader("Activity").ToString)
                .SubItems.Add(DBreader("ActivityDate").ToString)
            End With
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub txtIDsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIDsearch.TextChanged
        tmrRefresher.Stop()
        DBstring = "select * from [teacherAuditLog1] where ID like '" & txtIDsearch.Text & "%'"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        lstvwAuditLog.Items.Clear()
        While (DBreader.Read())
            With lstvwAuditLog.Items.Add(DBreader("Time").ToString)
                .SubItems.Add(DBreader("ID").ToString)
                .SubItems.Add(DBreader("TeacherName").ToString)
                .SubItems.Add(DBreader("Username").ToString)
                .SubItems.Add(DBreader("Activity").ToString)
                .SubItems.Add(DBreader("ActivityDate").ToString)
            End With
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub txtUsernamesearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsernamesearch.TextChanged
        tmrRefresher.Stop()
        DBstring = "select * from [teacherAuditLog1] where Username like '" & txtUsernamesearch.Text & "%'"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        lstvwAuditLog.Items.Clear()
        While (DBreader.Read())
            With lstvwAuditLog.Items.Add(DBreader("Time").ToString)
                .SubItems.Add(DBreader("ID").ToString)
                .SubItems.Add(DBreader("TeacherName").ToString)
                .SubItems.Add(DBreader("Username").ToString)
                .SubItems.Add(DBreader("Activity").ToString)
                .SubItems.Add(DBreader("ActivityDate").ToString)
            End With
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub btnHomePageTab2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHomePageTab2.Click
        frmMainPage.Show()
        Me.Close()
    End Sub

    Private Sub lstvwTeacherNotes_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstvwTeacherNotes.MouseClick
        DBstring = "select * from teacherLogTimeIn where ID like '" & lstvwTeacherNotes.FocusedItem.SubItems(0).Text & "%'"
        Dim DBcmd As New OleDb.OleDbCommand
        Dim dateConvert As String = ""
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While (DBreader.Read())
            lblLogDateNote.Text = DBreader("LogDate").ToString
            lblTimeInTimeOutNote.Text = DBreader("LogTimeIn").ToString & " • " & DBreader("LogTimeOut").ToString
            lblLogStatusNote.Text = DBreader("LogInStatus").ToString
            rtxtNoteTN.Text = DBreader("LogNote").ToString
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub lstvwTeacherNotes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvwTeacherNotes.SelectedIndexChanged

    End Sub

    Private Sub lstvwAuditLog_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvwAuditLog.SelectedIndexChanged

    End Sub

    Private Sub charLimiterNUM(ByVal e)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "0123456789"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtIDSearchTN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIDSearchTN.KeyPress
        charLimiterNUM(e)
    End Sub

    Private Sub txtIDSearchTN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIDSearchTN.TextChanged
        DBstring = "select * from [teacherLogTimeIn] where ID like '" & txtIDSearchTN.Text & "%'"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        lstvwTeacherNotes.Items.Clear()
        While (DBreader.Read())
            With lstvwTeacherNotes.Items.Add(DBreader("ID").ToString)
                .SubItems.Add(DBreader("TeacherName").ToString)
                .SubItems.Add(DBreader("LogDate").ToString)
                .SubItems.Add(DBreader("LogInStatus").ToString)
            End With
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub txtNameSearchTN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNameSearchTN.TextChanged
        DBstring = "select * from [teacherLogTimeIn] where TeacherName like '" & txtNameSearchTN.Text & "%'"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        lstvwTeacherNotes.Items.Clear()
        While (DBreader.Read())
            With lstvwTeacherNotes.Items.Add(DBreader("ID").ToString)
                .SubItems.Add(DBreader("TeacherName").ToString)
                .SubItems.Add(DBreader("LogDate").ToString)
                .SubItems.Add(DBreader("LogInStatus").ToString)
            End With
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub lstvwBreakNotice_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstvwBreakNotice.MouseClick
        DBstring = "select * from teacherOnBreak where TeacherID like '" & lstvwBreakNotice.FocusedItem.SubItems(1).Text & "%'"
        Dim DBcmd As New OleDb.OleDbCommand
        Dim dateConvert As String = ""
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While (DBreader.Read())
            lblDateAnnouncedBN.Text = DBreader("DateAnnounced").ToString
            lblDateStartBN.Text = DBreader("DateStart").ToString
            lblDateEndBN.Text = DBreader("DateEnd").ToString
            lblNameBN.Text = DBreader("teacherName").ToString
            lblDaysBN.Text = "On break for " + DBreader("Days").ToString + " days."
            rtxtReasonBN.Text = DBreader("Reason").ToString
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub lstvwBreakNotice_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvwBreakNotice.SelectedIndexChanged

    End Sub
End Class