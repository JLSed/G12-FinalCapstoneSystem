Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmrDateTime.Start()
        connectToDB.connectDB()
    End Sub

    Private Sub tmrDateTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDateTime.Tick
        lblDate.Text = DateTime.Today.ToString("MMMM dd, yyyy")
        lblTime.Text = TimeOfDay
    End Sub

    Sub fillTxtId()
        DBstring = "Select * from teacherInfo where [ID] like '" & txtID.Text & "%'"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        txtName.Clear()
        While (DBreader.Read())
            txtName.Text = DBreader("teacherNameLN") & ", " & DBreader("teacherNameFN") & " " & DBreader("teacherNameMN")
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub txtID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtID.TextChanged
        If Not txtID.TextLength = 0 Then
            lblWarning.Visible = False
        Else
            lblWarning.Visible = True
        End If

        If txtID.Text = "'" Or txtID.Text = "'''" Then
        Else
            fillTxtId()
        End If
    End Sub

    Private Sub btnTimeIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimeIn.Click
        If MsgBox("Time In?", vbYesNo, MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            DBstring = "insert into teacherlog([ID], [TeacherName], [LogDate], [LogTimeIn]) values ('" _
                 & txtID.Text & "', '" _
                 & txtName.Text & "', '" _
                 & lblDate.Text & "', '" _
                 & lblTime.Text & "')"
            Dim DBcmd As New OleDb.OleDbCommand
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBcmd.ExecuteNonQuery()
            DBcmd.Dispose()
            MsgBox("Data Saved", MsgBoxStyle.Information)
            fillTxtId()
        End If
    End Sub
End Class
