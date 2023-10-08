Imports System.Data.OleDb

Module connectToDB
    Public DBconnection As New OleDbConnection
    Public DBadapter As New OleDbDataAdapter
    Public DBreader As OleDbDataReader
    Public DBstring As String

    Sub connectDB()
        DBconnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|datadirectory|systemDB.accdb; persist security info=false;"
        DBconnection.Open()
    End Sub


End Module
