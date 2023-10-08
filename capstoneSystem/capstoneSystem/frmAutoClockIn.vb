Public Class frmAutoClockIn

    Private Sub frmAutoClockIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDate.Text = DateTime.Today.ToString("MMMM dd, yyyy")
        lblTime.Text = TimeOfDay.ToString("hh:mm tt")
        fillTxtId()
        LogActivity(lblID.Text, lblName.Text, frmLogin.username, "Logged In (TYPE= Clock In)")
        autoTimeInTimeOut()
        frmLogin.txtBarcodeReader.Select()
    End Sub

    Private Sub autoTimeInTimeOut()
        DBstring = "Select * from teacherLogTimeIn where [ID] like '" & frmLogin.ID & "' and [LogDate] like '" & lblDate.Text & "';"
        Dim DBcmd As New OleDb.OleDbCommand
        Dim logdateholder As String = ""
        Dim logstatusholder As String = ""
        Dim logtimeholder As String = ""
        Dim teacherStatusholder As String = ""
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While (DBreader.Read())
            logdateholder = DBreader("LogDate").ToString
            logstatusholder = DBreader("LogInStatus").ToString
            logtimeholder = DBreader("LogTimeIn").ToString
        End While
        DBcmd.Dispose()
        DBreader.Close()
        DBstring = "Select [Status] from teacherInfo where [ID] like '" & frmLogin.ID & "%'"
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
            lblAnnouncer.Text = "THIS ACCOUNT CAN NO LONGER BE ACCESS"
            tmrFormTimer.Start()
            Exit Sub
        End If
        If logdateholder = lblDate.Text Then
            If Not logtimeholder = "" Then
                btnTimeOut_Click()
            ElseIf logtimeholder = "" And Not logstatusholder = "ON-BREAK" Then
                btnTimeIn_Click()
            ElseIf logstatusholder = "ON-BREAK" Then
                lblAnnouncer.Text = "ON-BREAK"
                tmrFormTimer.Start()
            End If
        ElseIf Not logdateholder = lblDate.Text And Not teacherStatusholder = "On-Break" Then
            btnTimeIn_Click()
        ElseIf Not logdateholder = lblDate.Text And teacherStatusholder = "On-Break" Then
            lblAnnouncer.Text = "ON-BREAK"
            tmrFormTimer.Start()

        End If
    End Sub

    Private Sub fillTxtId()
        DBstring = "Select * from teacherInfo where [ID] like '" & frmLogin.ID & "%'"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        lblName.Text = Nothing
        While (DBreader.Read())
            lblName.Text = DBreader("teacherNameLN") & ", " & DBreader("teacherNameFN") & " " & DBreader("teacherNameMN")
            lblID.Text = DBreader("ID")
            Try
                pcbProfile.Image = Image.FromFile(DBreader("TeacherPhotoPath"))
            Catch ex As Exception
                pcbProfile.Image = Nothing
            End Try
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub btnTimeIn_Click()
        If MsgBox("Time In?", vbYesNo, MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim dateLogHolder, timeLogHolderTI, timeLogHolderTO As String
            dateLogHolder = getTimeDate()
            timeLogHolderTI = getTimeInTime()
            timeLogHolderTO = getTimeOutTime()
            If dateLogHolder = lblDate.Text And Not timeLogHolderTO = "" Then
                lblAnnouncer.Text = "Already Clock Out Today At " & timeLogHolderTO & ", Can't Clock In Anymore."
                tmrFormTimer.Start()
            ElseIf "March 20, 2023" = lblDate.Text And Not timeLogHolderTI = "" Then
                lblAnnouncer.Text = "Already Clock In Today at " & timeLogHolderTI & "."
                tmrFormTimer.Start()
            Else
                recordTimeIn()
                updateTeachersTimeIn()
                lblAnnouncer.Text = "Timed In"
                tmrFormTimer.Start()
            End If
        End If
    End Sub

    Private Sub btnTimeOut_Click()
        If MsgBox("Time Out?", vbYesNo, MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim dateLogHolder, timeLogHolderTI, timeLogHolderTO As String
            dateLogHolder = getTimeDate()
            timeLogHolderTI = getTimeInTime()
            timeLogHolderTO = getTimeOutTime()
            If dateLogHolder = lblDate.Text And Not timeLogHolderTO = "" Then
                lblAnnouncer.Text = "Already Clock Out Today At " & timeLogHolderTO & "."
                tmrFormTimer.Start()
            ElseIf timeLogHolderTI = Nothing Then
                lblAnnouncer.Text = "Time In First."
                tmrFormTimer.Start()
            Else
                recordTimeOut()
                lblAnnouncer.Text = "Timed Out"
                tmrFormTimer.Start()
            End If
        End If
    End Sub

    Private Sub recordTimeIn()
        Dim CompareTime As DateTime = DateTime.Parse("07:00 AM")
        Dim LoginStatus As String = ""
        DBstring = "Select LogInStatus from teacherLogTimeIn where [ID] like '" & lblID.Text & "' and [LogDate] like '" & lblDate.Text & "';"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While (DBreader.Read)
            LoginStatus = DBreader("LogInStatus").ToString
        End While
        DBcmd.Dispose()
        DBreader.Close()

        If LoginStatus = "ABSENT" Then
            If CompareTime.TimeOfDay < DateTime.Now.TimeOfDay Then
                LoginStatus = "LATE"
            Else
                LoginStatus = "ON-TIME"
            End If
            DBstring = "update teacherLogTimeIn set [TeacherName] ='" & lblName.Text & _
            "', [LogDate] ='" & lblDate.Text & _
            "', [LogInStatus] ='" & LoginStatus & _
            "', [LogTimeIn] ='" & lblTime.Text & _
            "' where [ID] ='" & lblID.Text & "' and [LogDate] = '" & lblDate.Text & "';"
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBcmd.ExecuteNonQuery()
            DBcmd.Dispose()
            DBreader.Close()
        ElseIf Not LoginStatus = "ABSENT" Then
            If CompareTime.TimeOfDay < DateTime.Now.TimeOfDay Then
                LoginStatus = "LATE"
            Else
                LoginStatus = "ON-TIME"
            End If
            DBstring = "insert into teacherlogTimeIn([ID], [TeacherName], [LogDate], [LogInStatus], [LogTimeIn]) values ('" _
             & lblID.Text & "', '" _
             & lblName.Text & "', '" _
             & lblDate.Text & "', '" _
             & LoginStatus & "', '" _
             & lblTime.Text & "')"
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBcmd.ExecuteNonQuery()
            DBcmd.Dispose()
            DBreader.Close()
        End If
        LogActivity(lblID.Text, lblName.Text, frmLogin.username, "Timed In")
        LogActivity(lblID.Text, lblName.Text, frmLogin.username, "Logged Out (TYPE= Clock In)")
    End Sub

    Function getTimeDate()
        DBstring = "Select LogDate from teacherLogTimeIn where [ID] like '" & lblID.Text & "' and LogDate like '" & _
        lblDate.Text & "';"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        Dim dateLogHolder As String = ""
        While (DBreader.Read)
            dateLogHolder = DBreader("LogDate").ToString
        End While
        DBcmd.Dispose()
        DBreader.Close()
        Return dateLogHolder
    End Function
    Function getTimeInTime()
        DBstring = "Select * from teacherLogTimeIn where [ID] like '" & lblID.Text & "' and [LogDate] like '" & lblDate.Text & "';"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        Dim timeLogHolder As String = ""
        While (DBreader.Read)
            timeLogHolder = DBreader("LogTimeIn").ToString
        End While
        DBcmd.Dispose()
        DBreader.Close()
        Return timeLogHolder
    End Function

    Private Sub recordTimeOut()
        DBstring = "update teacherlogTimeIn set [LogTimeOut] ='" & lblTime.Text & "' where [TeacherName] = '" & lblName.Text & "' and [LogDate] = '" & lblDate.Text & "';"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBcmd.ExecuteNonQuery()
        DBcmd.Dispose()
        DBreader.Close()
        LogActivity(lblID.Text, lblName.Text, frmLogin.username, "Timed Out")
        LogActivity(lblID.Text, lblName.Text, frmLogin.username, "Logged Out (TYPE= Clock In)")
    End Sub
    Function getTimeOutTime()
        DBstring = "Select * from teacherLogTimeIn where [ID] like '" & lblID.Text & "' and [LogDate] like '" & lblDate.Text & "';"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        Dim timeLogHolder As String = ""
        While (DBreader.Read)
            If IsDBNull(DBreader("LogTimeOut")) Then
                timeLogHolder = ""
            Else
                timeLogHolder = DBreader("LogTimeOut")
            End If
        End While
        DBcmd.Dispose()
        DBreader.Close()
        Return timeLogHolder
    End Function


    Private Sub updateTeachersTimeIn()
        Dim teacherIDlist As New List(Of String)
        Dim teacherNamelsit As New List(Of String)
        Dim DBcmd As New OleDb.OleDbCommand
        DBstring = "Select [ID] from teacherInfo where [Status] like 'Active%'"
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While DBreader.Read
            With teacherIDlist
                .Add(DBreader("ID").ToString)
            End With
        End While
        DBcmd.Dispose()
        DBreader.Close()

        For Each x In teacherIDlist.ToList
            DBstring = "Select [LogDate] from teacherLogTimeIn where [ID] like '" & x & "%'"
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBadapter.SelectCommand = DBcmd
            DBreader = DBcmd.ExecuteReader
            While DBreader.Read
                If DBreader("LogDate").ToString = lblDate.Text Then
                    teacherIDlist.Remove(x)
                End If
            End While
            DBcmd.Dispose()
            DBreader.Close()
        Next

        For Each x In teacherIDlist.ToList
            DBstring = "Select * from teacherInfo where [ID] like '" & x & "%'"
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBadapter.SelectCommand = DBcmd
            DBreader = DBcmd.ExecuteReader
            While DBreader.Read
                With teacherNamelsit
                    .Add(DBreader("teacherNameLN").ToString & ", " & DBreader("teacherNameFN").ToString & " " & DBreader("teacherNameMN").ToString)
                End With
            End While
            DBcmd.Dispose()
            DBreader.Close()
        Next

        For i As Integer = 0 To teacherIDlist.Count - 1
            DBstring = "insert into teacherlogTimeIn([ID], [TeacherName], [LogDate], [LogInStatus]) values ('" _
            & teacherIDlist(i) & "', '" _
            & teacherNamelsit(i) & "', '" _
            & lblDate.Text & "', 'ABSENT')"
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBcmd.ExecuteNonQuery()
            DBcmd.Dispose()
            DBreader.Close()
        Next
        updateOnBreakTeacherTimein()
    End Sub

    Private Sub updateOnBreakTeacherTimein()
        Dim teacherIDlist As New List(Of String)
        Dim teacherNamelsit As New List(Of String)
        Dim DBcmd As New OleDb.OleDbCommand
        DBstring = "Select [ID] from teacherInfo where [Status] like 'On-Break%'"
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While DBreader.Read
            With teacherIDlist
                .Add(DBreader("ID").ToString)
            End With
        End While
        DBcmd.Dispose()
        DBreader.Close()

        For Each x In teacherIDlist.ToList
            DBstring = "Select [LogDate] from teacherLogTimeIn where [ID] like '" & x & "%'"
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBadapter.SelectCommand = DBcmd
            DBreader = DBcmd.ExecuteReader
            While DBreader.Read
                If DBreader("LogDate").ToString = lblDate.Text Then
                    teacherIDlist.Remove(x)
                End If
            End While
            DBcmd.Dispose()
            DBreader.Close()
        Next

        For Each x In teacherIDlist.ToList
            DBstring = "Select * from teacherInfo where [ID] like '" & x & "%'"
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBadapter.SelectCommand = DBcmd
            DBreader = DBcmd.ExecuteReader
            While DBreader.Read
                With teacherNamelsit
                    .Add(DBreader("teacherNameLN").ToString & ", " & DBreader("teacherNameFN").ToString & " " & DBreader("teacherNameMN").ToString)
                End With
            End While
            DBcmd.Dispose()
            DBreader.Close()
        Next

        For i As Integer = 0 To teacherIDlist.Count - 1
            DBstring = "insert into teacherlogTimeIn([ID], [TeacherName], [LogDate], [LogInStatus]) values ('" _
            & teacherIDlist(i) & "', '" _
            & teacherNamelsit(i) & "', '" _
            & lblDate.Text & "', 'ON-BREAK')"
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBcmd.ExecuteNonQuery()
            DBcmd.Dispose()
            DBreader.Close()
        Next
    End Sub

    Private Sub tmrFormTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFormTimer.Tick
        Me.Dispose()
        Me.Close()
    End Sub
End Class