Public Class frmChart

    Private Sub frmChart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstvwAttendanceHistory.View = View.Details
        lstvwAttendanceHistory.FullRowSelect = True
        lstvwAttendanceHistory.HideSelection = True
        lstvwAttendanceHistory.MultiSelect = False
        lstvwAttendanceHistory.Columns.Add("Status", 200, HorizontalAlignment.Center)
        lstvwAttendanceHistory.Columns.Add("Date", 380, HorizontalAlignment.Center)
        lstvwAttendanceHistory.Columns.Add("Time In", 250, HorizontalAlignment.Center)
        lstvwAttendanceHistory.Columns.Add("Time Out", 250, HorizontalAlignment.Center)
        lstvwAttendanceHistory.Columns.Add("Note", 400, HorizontalAlignment.Center)
        fillListView()
    End Sub

    Private Sub fillListView()
        DBstring = "select * from [teacherLogTimeIn] where ID like '" & frmMainPage.lblIDnum.Text & "%'"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        lstvwAttendanceHistory.Items.Clear()
        While (DBreader.Read())
            With lstvwAttendanceHistory.Items.Add(DBreader("LogInStatus").ToString)
                .SubItems.Add(DBreader("LogDate").ToString)
                If IsDBNull(DBreader("LogTimeIn")) Then
                    .SubItems.Add("No Record")
                Else
                    .SubItems.Add(DBreader("LogTimeIn").ToString)
                End If
                If IsDBNull(DBreader("LogTimeOut")) Then
                    .SubItems.Add("No Record")
                Else
                    .SubItems.Add(DBreader("LogTimeOut").ToString)
                End If
                .SubItems.Add(DBreader("LogNote").ToString)
            End With
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub filterStatusfiller(ByVal statusholder As String)
        DBstring = "select * from [teacherLogTimeIn] where [LogInStatus] like '" & statusholder & "' and ID like '" & frmMainPage.lblIDnum.Text & "';"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        lstvwAttendanceHistory.Items.Clear()
        While DBreader.Read
            With lstvwAttendanceHistory.Items.Add(DBreader("LogInStatus").ToString)
                .SubItems.Add(DBreader("LogDate").ToString)
                If IsDBNull(DBreader("LogTimeIn")) Then
                    .SubItems.Add("No Record")
                Else
                    .SubItems.Add(DBreader("LogTimeIn").ToString)
                End If
                If IsDBNull(DBreader("LogTimeOut")) Then
                    .SubItems.Add("No Record")
                Else
                    .SubItems.Add(DBreader("LogTimeOut").ToString)
                End If
                '  .SubItems.Add(DBreader("LogNote").ToString)
            End With
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub ABSENTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABSENTToolStripMenuItem.Click
        filterStatusfiller("ABSENT")
    End Sub

    Private Sub btnAscSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lstvwAttendanceHistory.Sorting = SortOrder.Ascending
    End Sub

    Private Sub btnDescSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lstvwAttendanceHistory.Sorting = SortOrder.Descending
    End Sub

    Private Sub btnClearSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lstvwAttendanceHistory.Sorting = SortOrder.None
    End Sub

    Private Sub btnMainPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainPage.Click
        Me.Close()
        frmMainPage.Show()
    End Sub

    Private Sub AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AToolStripMenuItem.Click
        lstvwAttendanceHistory.Sorting = SortOrder.Ascending
    End Sub

    Private Sub DescendingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescendingToolStripMenuItem1.Click
        lstvwAttendanceHistory.Sorting = SortOrder.Descending
    End Sub

    Private Sub ClearSortToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearSortToolStripMenuItem.Click
        lstvwAttendanceHistory.Sorting = SortOrder.None
    End Sub


    Private Sub btnClearAllFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAllFilter.Click
        dtpDateR1.Value = Date.Now
        dtpDateR2.Value = Date.Now
        fillListView()
    End Sub

    Private Sub LATEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LATEToolStripMenuItem.Click
        filterStatusfiller("LATE")
    End Sub

    Private Sub ONTIMEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ONTIMEToolStripMenuItem.Click
        filterStatusfiller("ON-TIME")
    End Sub

    Private Sub ONBREAKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ONBREAKToolStripMenuItem.Click
        filterStatusfiller("ON-BREAK")
    End Sub


    Private Sub dtpDateR1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateR1.ValueChanged
        DBstring = "select * from [teacherLogTimeIn] where [ID] like '" & frmMainPage.lblIDnum.Text & "' and [LogDate] between '" & _
        dtpDateR1.Value.ToString("MMMM dd, yyyy") & "' and '" & dtpDateR2.Value.ToString("MMMM dd, yyyy") & "';"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        lstvwAttendanceHistory.Items.Clear()
        While DBreader.Read
            With lstvwAttendanceHistory.Items.Add(DBreader("LogInStatus").ToString)
                .SubItems.Add(DBreader("LogDate").ToString)
                If IsDBNull(DBreader("LogTimeIn")) Then
                    .SubItems.Add("No Record")
                Else
                    .SubItems.Add(DBreader("LogTimeIn").ToString)
                End If
                If IsDBNull(DBreader("LogTimeOut")) Then
                    .SubItems.Add("No Record")
                Else
                    .SubItems.Add(DBreader("LogTimeOut").ToString)
                End If
                '  .SubItems.Add(DBreader("LogNote").ToString)
            End With
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub dtpDateR2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDateR2.ValueChanged
        DBstring = "select * from [teacherLogTimeIn] where [ID] like '" & frmMainPage.lblIDnum.Text & "' and [LogDate] between '" & _
        dtpDateR1.Value.ToString("MMMM dd, yyyy") & "' and '" & dtpDateR2.Value.ToString("MMMM dd, yyyy") & "';"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        lstvwAttendanceHistory.Items.Clear()
        While DBreader.Read
            With lstvwAttendanceHistory.Items.Add(DBreader("LogInStatus").ToString)
                .SubItems.Add(DBreader("LogDate").ToString)
                If IsDBNull(DBreader("LogTimeIn")) Then
                    .SubItems.Add("No Record")
                Else
                    .SubItems.Add(DBreader("LogTimeIn").ToString)
                End If
                If IsDBNull(DBreader("LogTimeOut")) Then
                    .SubItems.Add("No Record")
                Else
                    .SubItems.Add(DBreader("LogTimeOut").ToString)
                End If
                '  .SubItems.Add(DBreader("LogNote").ToString)
            End With
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub
End Class