Imports System.Data.OleDb

Module connectToDB
    Public DBconnection As New OleDbConnection
    Public DBadapter As New OleDbDataAdapter
    Public DBreader As OleDbDataReader
    Public DBstring As String

    Sub connectDB()
        DBconnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\capstoneSystem2\capstoneSystem2\bin\Debug\systemDB.accdb; persist security info=false;"
        DBconnection.Open()
    End Sub

    Sub LogActivity(ByVal ID As String, ByVal TeacherName As String, ByVal Username As String, ByVal Activity As String)
        DBstring = "insert into teacherAuditLog1([Time], [ID], [TeacherName], [Username], [Activity], [ActivityDate]) values ('" _
        & TimeOfDay.ToString("hh:mm:ss tt") & "', '" _
        & ID & "', '" _
        & TeacherName & "', '" _
        & Username & "', '" _
        & Activity & "', '" _
        & DateTime.Today.ToString("MMMM dd, yyyy") & "')"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBcmd.ExecuteNonQuery()
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

End Module

