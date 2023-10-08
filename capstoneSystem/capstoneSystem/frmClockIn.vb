Public Class frmClockIn

    Private Sub frmClockIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmrDateTime.Start()
        fillTxtId()
        LogActivity(lblID.Text, lblName.Text, frmLogin.username, "Logged In (TYPE= Clock In)")
    End Sub

    Private Sub tmrDateTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDateTime.Tick
        lblDate.Text = DateTime.Today.ToString("MMMM dd, yyyy")
        lblTime.Text = TimeOfDay.ToString("hh:mm tt")
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
            "', [Temperature] ='" & txtTemp.Text & _
            "', [LogTimeIn] ='" & lblTime.Text & _
            "' where [ID] ='" & lblID.Text & "' and [LogDate] = '" & lblDate.Text & "';"
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBcmd.ExecuteNonQuery()
            DBcmd.Dispose()
            DBreader.Close()
        ElseIf Not LoginStatus = "ABSENT" And Not LoginStatus = "ON-BREAK" Then
            If CompareTime.TimeOfDay < DateTime.Now.TimeOfDay Then
                LoginStatus = "LATE"
            Else
                LoginStatus = "ON-TIME"
            End If
            DBstring = "insert into teacherlogTimeIn([ID], [TeacherName], [LogDate], [LogInStatus], [Temperature], [LogTimeIn]) values ('" _
             & lblID.Text & "', '" _
             & lblName.Text & "', '" _
             & lblDate.Text & "', '" _
             & LoginStatus & "', '" _
             & txtTemp.Text & "', '" _
             & lblTime.Text & "')"
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBcmd.ExecuteNonQuery()
            DBcmd.Dispose()
            DBreader.Close()
        ElseIf LoginStatus = "ON-BREAK" Then
            MsgBox("ON-BREAK", MsgBoxStyle.Critical, "TimeIn Error")
            LogActivity(lblID.Text, lblName.Text, frmLogin.username, "Logged Out (TYPE= Clock In)")
            Exit Sub
        End If
        LogActivity(lblID.Text, lblName.Text, frmLogin.username, "Timed In")
        LogActivity(lblID.Text, lblName.Text, frmLogin.username, "Logged Out (TYPE= Clock In)")
        MsgBox("Clock In", MsgBoxStyle.Information)
    End Sub

    Function getTimeDate()
        DBstring = "Select LogDate from teacherLogTimeIn where [ID] like '" & lblID.Text & "' and [LogDate] like '" & lblDate.Text & "';"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        Dim dateLogHolder As String = ""
        While (DBreader.Read)
            Try
                dateLogHolder = DBreader("LogDate").ToString
            Catch ex As Exception
                dateLogHolder = lblDate.Text
            End Try
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
            If IsDBNull(DBreader("LogTimeIn")) Then
                timeLogHolder = ""
            Else
                timeLogHolder = DBreader("LogTimeIn")
            End If
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
        MsgBox("Clock Out", MsgBoxStyle.Information)
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

    Private Sub btnTimeIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimeIn.Click
        If MsgBox("Time In?", vbYesNo, MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim dateLogHolder, timeLogHolderTI, timeLogHolderTO As String
            dateLogHolder = getTimeDate()
            timeLogHolderTI = getTimeInTime()
            timeLogHolderTO = getTimeOutTime()
            If dateLogHolder = lblDate.Text And Not timeLogHolderTO = "" Then
                MsgBox("Already Clock Out Today At " & timeLogHolderTO & ", Can't Clock In Anymore.", MsgBoxStyle.Critical, "Time In Error")
            ElseIf dateLogHolder = lblDate.Text And Not timeLogHolderTI = "" Then
                MsgBox("Already Clock In Today at " & timeLogHolderTI & ".", MsgBoxStyle.Critical, "Time In Error")
                'ElseIf txtTemp.Text = Nothing Then
                '    MsgBox("Please Input your Temperature first.", MsgBoxStyle.Question, "No Temp")
                'ElseIf Val(txtTemp.Text) > 100 Then
                '    MsgBox("Temperature Can't be greater than 100", MsgBoxStyle.Critical, "Temp Error")
            Else
                recordTimeIn()
                updateTeachersTimeIn()
                Me.Dispose()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnTimeOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimeOut.Click
        If MsgBox("Time Out?", vbYesNo, MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim dateLogHolder, timeLogHolderTI, timeLogHolderTO As String
            dateLogHolder = getTimeDate()
            timeLogHolderTI = getTimeInTime()
            timeLogHolderTO = getTimeOutTime()
            If dateLogHolder = lblDate.Text And Not timeLogHolderTO = "" Then
                MsgBox("Already Clock Out Today At " & timeLogHolderTO & ".", MsgBoxStyle.Critical, "Time Out Error")
            ElseIf timeLogHolderTI = Nothing Then
                MsgBox("Time In First.", MsgBoxStyle.Critical, "Error")
            Else
                recordTimeOut()
                Me.Dispose()
                Me.Close()
            End If
        End If
    End Sub

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

    'RIP temp function
    'Private Sub charLimiter(ByVal e)
    '    If Not (Asc(e.KeyChar) = 8) Then
    '        Dim allowedChars As String = "1234567890."
    '        Dim decimalPoint = "."
    '        If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
    '            e.KeyChar = ChrW(0)
    '            e.Handled = True
    '        ElseIf txtTemp.Text = Nothing Then
    '            If decimalPoint.Contains(e.KeyChar.ToString.ToLower) Then
    '                e.KeyChar = ChrW(0)
    '                e.Handled = True
    '            End If
    '        ElseIf InStr(txtTemp.Text, ".") > 1 Then
    '            If decimalPoint.Contains(e.KeyChar.ToString.ToLower) Then
    '                e.KeyChar = ChrW(0)
    '                e.Handled = True
    '            End If
    '        End If
    '    End If
    'End Sub
    'Private Sub txtTemp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTemp.KeyPress
    '    charLimiter(e)
    'End Sub

    Private Sub btnGoBackANT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoBackANT.Click
        If MsgBox("Do you want to go back?", vbYesNo, "LOGOUT") = MsgBoxResult.Yes Then
            LogActivity(lblID.Text, lblName.Text, frmLogin.username, "Logged Out (TYPE= Clock In)")
            Me.Close()
            frmLogin.Show()
        End If
    End Sub
End Class
