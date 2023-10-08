Public Class frmBreakNotice

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Dim teacherIDOBholder As String = ""
        If DateDiff(DateInterval.Day, dtpStart.Value, dtpEnd.Value) < 1 Then
            MsgBox("Break Days must not be less than 1.", MsgBoxStyle.Exclamation, "Error")
        ElseIf DateDiff(DateInterval.Day, Now, dtpStart.Value) < 0 Or DateDiff(DateInterval.Day, Now, dtpEnd.Value) < 0 Then
            MsgBox("Cannot pick date that already passed.", MsgBoxStyle.Exclamation, "Error")
        ElseIf rtxtReason.TextLength < 1 Then
            MsgBox("Please type the reason of the break.", MsgBoxStyle.Exclamation, "Error")
        Else
            DBstring = "select teacherID from teacherOnBreak;"
            Dim DBcmd As New OleDb.OleDbCommand
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBadapter.SelectCommand = DBcmd
            DBreader = DBcmd.ExecuteReader
            While DBreader.Read
                If DBreader("teacherID") = frmMainPage.lblIDnum.Text Then
                    teacherIDOBholder = DBreader("teacherID")
                End If
            End While
            DBcmd.Dispose()
            DBreader.Close()
            If teacherIDOBholder = "" Then
                DBstring = "insert into teacherOnBreak([Days], [TeacherID], [TeacherName], [DateAnnounced], [DateStart], [DateEnd], [Reason]) values ('" _
              & DateDiff(DateInterval.Day, dtpStart.Value, dtpEnd.Value).ToString & "', '" _
              & frmMainPage.lblIDnum.Text & "', '" _
              & frmMainPage.lblName.Text & "', '" _
              & Date.Now.ToString("MMMM dd, yyyy") & "', '" _
              & dtpStart.Value.ToString("MMMM dd, yyyy") & "', '" _
              & dtpEnd.Value.ToString("MMMM dd, yyyy") & "', '" _
              & rtxtReason.Text & "')"
                DBcmd.CommandText = DBstring
                DBcmd.Connection = DBconnection
                DBcmd.ExecuteNonQuery()
                DBcmd.Dispose()
                DBreader.Close()
                MsgBox("Break Notice Submitted", MsgBoxStyle.Information)
                Me.Close()
            Else
                DBstring = "update teacherOnBreak set [Days] ='" & DateDiff(DateInterval.Day, dtpStart.Value, dtpEnd.Value).ToString & _
            "', [DateAnnounced] ='" & Date.Now.ToString("MMMM dd, yyyy") & _
            "', [DateStart] ='" & dtpStart.Value.ToString("MMMM dd, yyyy") & _
            "', [DateEnd] ='" & dtpEnd.Value.ToString("MMMM dd, yyyy") & _
            "', [Reason] ='" & rtxtReason.Text & _
            "' where [TeacherID] ='" & frmMainPage.lblIDnum.Text & "';"
                DBcmd.CommandText = DBstring
                DBcmd.Connection = DBconnection
                DBcmd.ExecuteNonQuery()
                DBcmd.Dispose()
                DBreader.Close()
                MsgBox("Break Notice Updated", MsgBoxStyle.Information)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmBreakNotice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpStart.MinDate = Date.Today
        dtpEnd.MinDate = Date.Today
    End Sub
End Class