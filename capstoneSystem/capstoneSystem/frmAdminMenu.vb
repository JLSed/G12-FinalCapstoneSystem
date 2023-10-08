Imports System.IO
Public Class frmAdminMenu

    Private Sub frmAdminMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tlp.Height = 0
        setUpListview(lstvwTeacherList)
        setUpListview(lstvwEditTeacher)
        setUpListview(lstvwRemoveTeacher)
        setUpListview(lstvwRecoverTeacher)
        fillTeacherListView(lstvwTeacherList)
        fillCombobox(cmbNposition)
        fillCombobox(cmbPostionET)
        fillCombobox(cmbPositionFilterTL)
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
        End If
    End Sub

    Private Sub tmrCloseMenu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCloseMenu.Tick
        If tlp.Height <= 0 Then
            tmrCloseMenu.Stop()
        Else
            tlp.Height -= 5
        End If
    End Sub

    Private Sub fillCombobox(ByVal cmbHolder As ComboBox)
        DBstring = "select department from teacherDepartment"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        cmbHolder.Items.Clear()
        While (DBreader.Read())
            cmbHolder.Items.Add(DBreader("department").ToString)
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub setUpListview(ByVal listviewholder As ListView)
        listviewholder.View = View.Details
        ' listviewholder.GridLines = True
        listviewholder.FullRowSelect = True
        listviewholder.HideSelection = True
        listviewholder.MultiSelect = False
        listviewholder.Columns.Add("ID", 50, HorizontalAlignment.Center)
        listviewholder.Columns.Add("Status", 100, HorizontalAlignment.Center)
        listviewholder.Columns.Add("First Name", 190, HorizontalAlignment.Center)
        listviewholder.Columns.Add("Mi", 50, HorizontalAlignment.Center)
        listviewholder.Columns.Add("Last Name", 150, HorizontalAlignment.Center)
        listviewholder.Columns.Add("Gender", 150, HorizontalAlignment.Center)
        listviewholder.Columns.Add("Position", 150, HorizontalAlignment.Center)
    End Sub

    Private Sub fillTeacherListView(ByVal listviewholder As ListView)
        DBstring = "select * from [teacherInfo] where [Status] like 'Active' or [Status] like 'On-Break';"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        listviewholder.Items.Clear()
        While (DBreader.Read())
            With listviewholder.Items.Add(DBreader("ID").ToString)
                .SubItems.Add(DBreader("Status").ToString)
                .SubItems.Add(DBreader("TeacherNameFN").ToString)
                .SubItems.Add(DBreader("TeacherNameMN").ToString)
                .SubItems.Add(DBreader("TeacherNameLN").ToString)
                .SubItems.Add(DBreader("Sex").ToString)
                .SubItems.Add(DBreader("Position").ToString)
            End With
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub fillInfoTeacherList()
        DBstring = "select * from [teacherInfo] where ID like '" _
        & lstvwTeacherList.FocusedItem.SubItems(0).Text & "%'"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While (DBreader.Read())
            lblID.Text = "ID: " + DBreader("ID").ToString
            lblName.Text = "Name: " + DBreader("TeacherNameLN").ToString + ", " + DBreader("TeacherNameFN").ToString + " " + DBreader("TeacherNameMN").ToString
            lblSex.Text = "Sex: " + DBreader("Sex").ToString
            lblPosition.Text = "Position:" + DBreader("Position").ToString
            lblBarcodeTL.Text = DBreader("Barcode").ToString
            picbBarcodeTL.BackgroundImage = Code128(lblBarcodeTL.Text, "A")
            Try
                pcbProfile.Image = Image.FromFile(DBreader("TeacherPhotoPath"))
            Catch ex As Exception
                pcbProfile.Image = Nothing
            End Try
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub lstvwTeacherList_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstvwTeacherList.MouseClick
        fillInfoTeacherList()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMainPage.Click
        Me.Close()
        frmMainPage.Show()
    End Sub

    Private Sub btnAddTeacher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTeacher.Click
        TabControl1.SelectTab(2)
    End Sub

    Private Sub btnChangeAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeAccount.Click
        txtNusername.Enabled = True
    End Sub

    Private Sub btnBrowseFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseFile.Click
        Dim OpenFile As New OpenFileDialog()
        OpenFile.Filter = "Images (*.jpg;*.png)|*.jpg;*.png"
        OpenFile.FilterIndex = 1

        If OpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fileName As String = Path.GetFileName(OpenFile.FileName)
            Dim filePath As String = OpenFile.FileName
            Try
                My.Computer.FileSystem.CopyFile(filePath, ".\TeacherPhoto\" + fileName)
            Catch ex As IOException
                MsgBox("File Already Exist", MsgBoxStyle.Critical, "Error")
            End Try
            pcbTProfile.Image = Image.FromFile("./TeacherPhoto/" + fileName)
            txtTphotoPath.Text = "./TeacherPhoto/" + fileName
        End If
    End Sub

    Private Sub charLimiter(ByVal e)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnñopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub spaceLimiter(ByVal e)
        If Not (Asc(e.KeyChar) = 8) Then
            Dim NotallowedChars As String = " "
            If NotallowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtNfirstname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNfirstname.KeyPress
        charLimiter(e)
    End Sub

    Private Sub txtNfirstname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNfirstname.TextChanged
        Dim stringholder = txtNfirstname.Text.Replace(" ", "")
        Dim stringholder2 = txtNlastname.Text.Replace(" ", "")
        lblTname.Text = "Name: " + txtNfirstname.Text + " " + txtNmiddlename.Text.ToUpper + " " + txtNlastname.Text
        txtNusername.Text = stringholder + stringholder2 + "@yasc"
        If cmbNposition.Enabled = False Or txtNusername.Enabled = False Or txtNpassword.Enabled = False Then
            lblTposition.Text = "Position: " + cmbNposition.Text
            lblTusername.Text = "Username: " + txtNusername.Text
            lblTpassword.Text = "Password: " + txtNpassword.Text
        End If
    End Sub

    Private Sub txtNmiddlename_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNmiddlename.KeyPress
        charLimiter(e)
    End Sub

    Private Sub txtNmiddlename_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNmiddlename.TextChanged
        lblTname.Text = "Name: " + txtNfirstname.Text + " " + txtNmiddlename.Text.ToUpper + " " + txtNlastname.Text
        If txtNmiddlename.TextLength > 1 Then

        End If

    End Sub

    Private Sub txtNlastname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNlastname.KeyPress
        charLimiter(e)
    End Sub

    Private Sub txtNlastname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNlastname.TextChanged
        Dim stringholder = txtNfirstname.Text.Replace(" ", "")
        Dim stringholder2 = txtNlastname.Text.Replace(" ", "")
        lblTname.Text = "Name: " + txtNfirstname.Text + " " + txtNmiddlename.Text.ToUpper + " " + txtNlastname.Text
        txtNusername.Text = stringholder + stringholder2 + "@yasc"
        If txtNusername.Enabled = False Or txtNpassword.Enabled = False Then
            lblTusername.Text = "Username: " + txtNusername.Text
            lblTpassword.Text = "Password: " + txtNpassword.Text
        End If
    End Sub

    Private Sub GroupBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupBox1.MouseEnter
        If rdbMale.Checked = True Then
            lblTsex.Text = "Sex: Male"
        ElseIf rdbFemale.Checked = True Then
            lblTsex.Text = "Sex: Female"
        End If
    End Sub

    Private Sub txtNusername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNusername.KeyPress
        spaceLimiter(e)
    End Sub

    Private Sub txtNusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNusername.TextChanged
        Dim stringholder = txtNusername.Text.Replace(" ", "")
        lblTusername.Text = "Username: " + stringholder
    End Sub

    Private Sub txtNpassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNpassword.KeyPress
        spaceLimiter(e)
    End Sub

    Private Sub txtNpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNpassword.TextChanged
        Dim stringholder = txtNpassword.Text.Replace(" ", "")
        lblTpassword.Text = "Password: " + txtNpassword.Text
    End Sub

    Private Sub clearEverythingANT()
        txtNfirstname.Clear()
        txtNlastname.Clear()
        txtNmiddlename.Clear()
        txtNusername.Clear()
        txtNpassword.Text = "yasc@123"
        lblTsex.Text = "Sex: "
        lblTposition.Text = "Position: "
        cmbNposition.Text = Nothing
        rdbMale.Checked = False
        rdbFemale.Checked = False
        txtNusername.Enabled = False
        txtNpassword.Enabled = False
        pcbTProfile.Image = Nothing
        txtBarcode.Text = Nothing
        lblTBarcode.Text = "Barcode: "
        pcbBarcode.Image = Nothing
    End Sub

    Private Sub btnGoBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoBackANT.Click
        If txtNfirstname.TextLength > 1 Or txtNmiddlename.TextLength > 1 Or txtNlastname.TextLength > 1 _
        Or txtNusername.TextLength > 1 Or rdbMale.Checked = True Or rdbFemale.Checked = True Then
            If MsgBox("You have Unsave Information Entered." + vbNewLine + "Leaving will remove the Information Entered." + _
             vbNewLine + "Continue to leave?", vbYesNo, "Caution") = MsgBoxResult.Yes Then
                clearEverythingANT()
                TabControl1.SelectTab(0)
            ElseIf MsgBoxResult.No Then
            End If
        Else
            clearEverythingANT()
            TabControl1.SelectTab(0)
        End If
    End Sub

    Private Sub saveTeacherInfo(ByVal sex)
        DBstring = "insert into teacherInfo([TeacherNameFN], [TeacherNameMN], [TeacherNameLN], [Sex], [Position], [Status], [Barcode], [TeacherPhotoPath]) values ('" _
        & txtNfirstname.Text & "', '" _
        & txtNmiddlename.Text & "', '" _
        & txtNlastname.Text & "', '" _
        & sex & "', '" _
        & cmbNposition.Text & "', '" _
        & "Active" & "', '" _
        & txtBarcode.Text & "', '" _
        & txtTphotoPath.Text & "')"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBcmd.ExecuteNonQuery()
        DBcmd.Dispose()
        DBreader.Close()
    End Sub
    Private Function getId(ByVal fn As String)
        DBstring = "select ID from teacherInfo where TeacherNameFN like '" & fn & "%'"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        Dim idholder As String = ""
        While DBreader.Read
            idholder = DBreader("ID")
        End While
        Return idholder
        DBcmd.Dispose()
        DBreader.Close()
    End Function

    Function generateBackupCode()
        Dim Random1 As New Random
        Dim backupPin As String = Convert.ToString(Random1.Next(1000, 9999)) + "-" + Convert.ToString(Random1.Next(1000, 9999)) _
        + "-" + Convert.ToString(Random1.Next(1000, 9999)) + "-" + Convert.ToString(Random1.Next(1000, 9999))
        Return backupPin
    End Function

    Private Sub saveTeacherAccount(ByVal id As String)
        Dim DBcmd As New OleDb.OleDbCommand
        Dim pinHolder As String = ""
        Dim backupPin As String = generateBackupCode()
        DBstring = "select BackupCode from teacherAccount where BackupCode like '" & backupPin & "%'"
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While DBreader.Read
            pinHolder = DBreader("BackupCode").ToString
        End While
        DBcmd.Dispose()
        DBreader.Close()
        If pinHolder = backupPin Then
            backupPin = generateBackupCode()
        End If
        If cmbNposition.Text = "Admin" Then
            DBstring = "insert into teacherAccount([username], [password], [BackupCode], [idAcc], [isAdmin]) values ('" _
        & txtNusername.Text & "', '" _
        & txtNpassword.Text & "', '" _
        & backupPin & "', '" _
        & id & "', '1')"
        Else
            DBstring = "insert into teacherAccount([username], [password], [BackupCode], [idAcc], [isAdmin]) values ('" _
        & txtNusername.Text & "', '" _
        & txtNpassword.Text & "', '" _
        & backupPin & "', '" _
        & id & "', '0')"
        End If
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBcmd.ExecuteNonQuery()
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Function isUsernameTaken()
        DBstring = "select * from teacherAccount where username like '" & txtNusername.Text & "%'"
        Dim DBcmd As New OleDb.OleDbCommand
        Dim userHolder As String = ""
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While DBreader.Read
            userHolder = DBreader("username").ToString
        End While
        Return userHolder
        DBcmd.Dispose()
        DBreader.Close()
    End Function

    Private Sub btnAddnewTeacher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddnewTeacher.Click
        Dim gender As String = ""
        If rdbMale.Checked = True Then
            gender = "Male"
        ElseIf rdbFemale.Checked = True Then
            gender = "Female"
        End If

        If MsgBox("Are you sure to add this new teacher?", vbYesNo, "Warning") = MsgBoxResult.Yes Then
            If txtNfirstname.TextLength <= 0 Then
                MsgBox("Teacher First Name Not Found", MsgBoxStyle.Exclamation, "No First Name")
            ElseIf txtNmiddlename.TextLength <= 0 Then
                MsgBox("Teacher Middle Name Not Found", MsgBoxStyle.Exclamation, "No Middle Name")
            ElseIf txtNlastname.TextLength <= 0 Then
                MsgBox("Teacher Last Name Not Found", MsgBoxStyle.Exclamation, "No Last Name")
            ElseIf cmbNposition.Text = Nothing Then
                MsgBox("Teacher Position Not Found", MsgBoxStyle.Exclamation, "No Position")
                ' ElseIf txtTphotoPath.TextLength <= 0 Then
                '    MsgBox("Teacher Profile Not Found", MsgBoxStyle.Exclamation, "No Photo")
            ElseIf rdbMale.Checked = False And rdbFemale.Checked = False Then
                MsgBox("Teacher Sex Not Found", MsgBoxStyle.Exclamation, "No Sex")
            ElseIf lblTusername.Text = Nothing Then
                MsgBox("Teacher Username Not Found", MsgBoxStyle.Exclamation, "No Username")
            ElseIf lblTpassword.Text = Nothing Then
                MsgBox("Teacher Password Not Found", MsgBoxStyle.Exclamation, "No Password")
            ElseIf txtBarcode.Text = "" Then
                MsgBox("Generate a barcode First", MsgBoxStyle.Exclamation, "No Barcode")
            ElseIf txtNusername.Text = isUsernameTaken() Then
                MsgBox("Username is already taken.", MsgBoxStyle.Exclamation, "Invalid Username")
            Else
                saveTeacherInfo(gender)
                saveTeacherAccount(getId(txtNfirstname.Text))
                clearEverythingANT()
                MsgBox("New Teacher Recorded", MsgBoxStyle.Information)
                fillTeacherListView(lstvwTeacherList)
                fillTeacherListView(lstvwEditTeacher)
                fillTeacherListView(lstvwRemoveTeacher)
            End If
        End If
    End Sub

    

    Private Sub btnRemoveTeacher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveTeacher.Click
        TabControl1.SelectTab(tbpRemoveTeacher)
        fillTeacherListView(lstvwRemoveTeacher)
    End Sub

    Private Sub btnEditTeacher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditTeacher.Click
        TabControl1.SelectTab(1)
        fillTeacherListView(lstvwEditTeacher)
    End Sub

    Private Sub btnGoBackET_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoBackET.Click
        If btnSaveEditET.Visible = True Then
            If MsgBox("You have Unsave Information Entered." + vbNewLine + "Leaving will remove the Information Entered." + _
           vbNewLine + "Continue to leave?", MsgBoxStyle.Critical + vbYesNo, "Caution") = MsgBoxResult.Yes Then
                Label12.Visible = False
                Label13.Visible = False
                Label14.Visible = False
                btnEditProfileET.Visible = False
                txtFirstNET.Visible = False
                txtMiddleNET.Visible = False
                txtLastNET.Visible = False
                cmbSexET.Visible = False
                cmbPostionET.Visible = False
                btnSaveEditET.Visible = False
                btnResetpassET.Visible = False
                lblLastSelectholder.Text = lstvwEditTeacher.FocusedItem.SubItems(0).Text
                fillInfoEditTeacher(lblLastSelectholder.Text)
            Else
                Exit Sub
            End If
        End If
        TabControl1.SelectTab(0)
        fillTeacherListView(lstvwTeacherList)
    End Sub

    Private Sub fillInfoEditTeacher(ByVal lastIDselect)
        DBstring = "select * from [teacherInfo] where ID like '" _
        & lastIDselect & "%'"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While (DBreader.Read())
            lblIDET.Text = "ID: " + DBreader("ID").ToString
            lblNameET.Text = "Name: " + DBreader("TeacherNameLN") + ", " + DBreader("TeacherNameFN") + " " + DBreader("TeacherNameMN")
            lblSexET.Text = "Sex: " + DBreader("Sex").ToString
            cmbSexET.Text = DBreader("Sex").ToString
            cmbPostionET.Text = DBreader("Position").ToString
            lblfnholder.Text = DBreader("TeacherNameFN").ToString
            lblmnholder.Text = DBreader("TeacherNameMN").ToString
            lbllnholder.Text = DBreader("TeacherNameLN").ToString
            lblPositionET.Text = "Position: " + DBreader("Position")
            Try
                pcbProfileET.Image = Image.FromFile(DBreader("TeacherPhotoPath"))
            Catch ex As Exception
                pcbProfileET.Image = Nothing
            End Try
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub btnMakeChangesET_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakeChangesET.Click
        If lblIDET.Text = "ID: 00-0000" Then
            MsgBox("Please Select Someone First", MsgBoxStyle.Information, "Error")
        Else
            Try
                txtFirstNET.Text = lstvwEditTeacher.FocusedItem.SubItems(2).Text
                txtMiddleNET.Text = lstvwEditTeacher.FocusedItem.SubItems(3).Text
                txtLastNET.Text = lstvwEditTeacher.FocusedItem.SubItems(4).Text
            Catch ex As Exception
                txtFirstNET.Text = lblfnholder.Text
                txtMiddleNET.Text = lblmnholder.Text
                txtLastNET.Text = lbllnholder.Text
            End Try
            lblNameET.Text = "Name: "
            lblSexET.Text = "Sex: "
            Label12.Visible = True
            Label13.Visible = True
            Label14.Visible = True
            btnEditProfileET.Visible = True
            txtFirstNET.Visible = True
            txtMiddleNET.Visible = True
            txtLastNET.Visible = True
            cmbSexET.Visible = True
            cmbPostionET.Visible = True
            btnSaveEditET.Visible = True
            btnResetpassET.Visible = True
        End If
    End Sub

    Private Sub btnSaveEditET_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveEditET.Click
        If MsgBox("Are you sure to Edit the following Info?", vbYesNo, "Warning") = MsgBoxResult.Yes Then
            Dim DBcmd As New OleDb.OleDbCommand
            Dim isAdmin = ""
            DBstring = "Select isAdmin from teacherAccount where [idAcc] like '" & lblLastSelectholder.Text & "%'"
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBadapter.SelectCommand = DBcmd
            DBreader = DBcmd.ExecuteReader
            While DBreader.Read
                If DBreader("isAdmin").ToString = "1" And Not cmbPostionET.Text = "Admin" Then
                    isAdmin = "0"
                ElseIf cmbPostionET.Text = "Admin" Then
                    isAdmin = "1"
                End If
            End While
            DBcmd.Dispose()
            DBreader.Close()
            If isAdmin = "1" Then
                If MsgBox("Are you sure you want to make this person an admin?", MsgBoxStyle.YesNo, "Caution") = MsgBoxResult.Yes Then
                    DBstring = "update teacherAccount set [isAdmin] ='" & isAdmin & "' where [idAcc] = '" & lblLastSelectholder.Text & "';"
                    DBcmd.CommandText = DBstring
                    DBcmd.Connection = DBconnection
                    DBcmd.ExecuteNonQuery()
                    DBcmd.Dispose()
                    DBreader.Close()
                Else
                    DBstring = "Select [Position] from teacherInfo where [ID] like '" & lblLastSelectholder.Text & "%'"
                    DBcmd.CommandText = DBstring
                    DBcmd.Connection = DBconnection
                    DBadapter.SelectCommand = DBcmd
                    DBreader = DBcmd.ExecuteReader
                    While DBreader.Read
                        cmbPostionET.Text = DBreader("Position").ToString
                    End While
                    DBcmd.Dispose()
                    DBreader.Close()
                End If
            ElseIf isAdmin = "0" Then
                DBstring = "update teacherAccount set [isAdmin] ='" & isAdmin & "' where [idAcc] = '" & lblLastSelectholder.Text & "';"
                DBcmd.CommandText = DBstring
                DBcmd.Connection = DBconnection
                DBcmd.ExecuteNonQuery()
                DBcmd.Dispose()
                DBreader.Close()
            End If
            If Not lblFilePathHolderET.Text = "FILEPATHHOLDER" Then
                DBstring = "update teacherInfo set [TeacherNameFN] ='" & txtFirstNET.Text & _
            "', [TeacherNameMN] ='" & txtMiddleNET.Text & _
            "', [TeacherNameLN] ='" & txtLastNET.Text & _
            "', [Sex] ='" & cmbSexET.Text & _
            "', [Position] ='" & cmbPostionET.Text & _
            "', [TeacherPhotoPath] ='" & lblFilePathHolderET.Text & _
            "' where [ID] =" & lblLastSelectholder.Text & ""
            Else
                DBstring = "update teacherInfo set [TeacherNameFN] ='" & txtFirstNET.Text & _
            "', [TeacherNameMN] ='" & txtMiddleNET.Text & _
            "', [TeacherNameLN] ='" & txtLastNET.Text & _
            "', [Sex] ='" & cmbSexET.Text & _
            "', [Position] ='" & cmbPostionET.Text & _
            "' where [ID] =" & lblLastSelectholder.Text & ""
            End If
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBcmd.ExecuteNonQuery()
            DBcmd.Dispose()
            DBreader.Close()
            fillTeacherListView(lstvwEditTeacher)
            fillInfoEditTeacher(lblLastSelectholder.Text)
            Label12.Visible = False
            Label13.Visible = False
            Label14.Visible = False
            btnEditProfileET.Visible = False
            txtFirstNET.Visible = False
            txtMiddleNET.Visible = False
            txtLastNET.Visible = False
            cmbSexET.Visible = False
            cmbPostionET.Visible = False
            btnSaveEditET.Visible = False
            btnResetpassET.Visible = False
        End If
    End Sub

    Private Sub lstvwEditTeacher_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstvwEditTeacher.MouseClick
        If btnSaveEditET.Visible = True Then
            If MsgBox("You have Unsave Information Entered." + vbNewLine + "Leaving will remove the Information Entered." + _
           vbNewLine + "Continue to leave?", MsgBoxStyle.Critical + vbYesNo, "Caution") = MsgBoxResult.Yes Then
                Label12.Visible = False
                Label13.Visible = False
                Label14.Visible = False
                btnEditProfileET.Visible = False
                txtFirstNET.Visible = False
                txtMiddleNET.Visible = False
                txtLastNET.Visible = False
                cmbSexET.Visible = False
                cmbPostionET.Visible = False
                btnSaveEditET.Visible = False
                btnResetpassET.Visible = False
                lblLastSelectholder.Text = lstvwEditTeacher.FocusedItem.SubItems(0).Text
                fillInfoEditTeacher(lblLastSelectholder.Text)
            End If
        Else
            lblLastSelectholder.Text = lstvwEditTeacher.FocusedItem.SubItems(0).Text
            fillInfoEditTeacher(lblLastSelectholder.Text)
        End If
    End Sub

    Private Sub btnEditProfileET_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditProfileET.Click
        Dim OpenFile As New OpenFileDialog()
        OpenFile.Filter = "Images (*.jpg;*.png)|*.jpg;*.png"
        OpenFile.FilterIndex = 1

        If OpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fileName As String = Path.GetFileName(OpenFile.FileName)
            Dim filePath As String = OpenFile.FileName
            Try
                My.Computer.FileSystem.CopyFile(filePath, ".\TeacherPhoto\" + fileName)
            Catch ex As IOException
                MsgBox("File Already Exist", MsgBoxStyle.Critical, "Error")
            End Try
            pcbProfileET.Image = Image.FromFile("./TeacherPhoto/" + fileName)
            lblFilePathHolderET.Text = "./TeacherPhoto/" + fileName
        End If
    End Sub

    Private Sub cmbNposition_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNposition.SelectedIndexChanged
        lblTposition.Text = "Position: " + cmbNposition.Text
    End Sub

    Private Sub btnGoBackRT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoBackRT.Click
        TabControl1.SelectTab(tbpTeacherList)
    End Sub


    Private Sub filterStatusfiller(ByVal statusholder As String, ByVal listviewholder As ListView)
        DBstring = "select * from [teacherInfo] where [Status] like '" & statusholder & "%'"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        listviewholder.Items.Clear()
        While DBreader.Read
            With listviewholder.Items.Add(DBreader("ID").ToString)
                .SubItems.Add(DBreader("Status").ToString)
                .SubItems.Add(DBreader("TeacherNameFN").ToString)
                .SubItems.Add(DBreader("TeacherNameMN").ToString)
                .SubItems.Add(DBreader("TeacherNameLN").ToString)
                .SubItems.Add(DBreader("Sex").ToString)
                .SubItems.Add(DBreader("Position").ToString)
            End With
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub filterGenderfiller(ByVal genderholder As String, ByVal listviewholder As ListView)
        DBstring = "select * from [teacherInfo] where [Sex] like '" & genderholder & "%'"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        listviewholder.Items.Clear()
        While DBreader.Read
            With listviewholder.Items.Add(DBreader("ID").ToString)
                .SubItems.Add(DBreader("Status").ToString)
                .SubItems.Add(DBreader("TeacherNameFN").ToString)
                .SubItems.Add(DBreader("TeacherNameMN").ToString)
                .SubItems.Add(DBreader("TeacherNameLN").ToString)
                .SubItems.Add(DBreader("Sex").ToString)
                .SubItems.Add(DBreader("Position").ToString)
            End With
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub filterPositionfiller(ByVal cmbholder As ComboBox)
        DBstring = "select * from [teacherInfo] where [Position] like '" & cmbholder.Text & "%'"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        lstvwTeacherList.Items.Clear()
        While DBreader.Read
            With lstvwTeacherList.Items.Add(DBreader("ID").ToString)
                .SubItems.Add(DBreader("Status").ToString)
                .SubItems.Add(DBreader("TeacherNameFN").ToString)
                .SubItems.Add(DBreader("TeacherNameMN").ToString)
                .SubItems.Add(DBreader("TeacherNameLN").ToString)
                .SubItems.Add(DBreader("Sex").ToString)
                .SubItems.Add(DBreader("Position").ToString)
            End With
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub


    Private Sub fillInfoRemoveTeacher()
        DBstring = "select * from [teacherInfo] where ID like '" _
        & lstvwRemoveTeacher.FocusedItem.SubItems(0).Text & "%'"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While (DBreader.Read())
            lblIDRT.Text = "ID: " + DBreader("ID").ToString
            lblNameRT.Text = "Name: " + DBreader("TeacherNameLN") + ", " + DBreader("TeacherNameFN") + " " + DBreader("TeacherNameMN")
            lblSexRT.Text = "Sex: " + DBreader("Sex")
            lblPositionRT.Text = "Position:" + DBreader("Position")
            Try
                picbProfileRT.Image = Image.FromFile(DBreader("TeacherPhotoPath"))
            Catch ex As Exception
                picbProfileRT.Image = Nothing
            End Try
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub lstvwRemoveTeacher_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstvwRemoveTeacher.MouseClick
        fillInfoRemoveTeacher()
    End Sub

    Private Sub btnRemoveTeacherRT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveTeacherRT.Click
        If MsgBox("Are you sure you want to remove this teacher?", MsgBoxStyle.Critical + vbYesNo, "CAUTION") = MsgBoxResult.Yes Then
            'Dim idholder As String = 
            DBstring = "update [teacherInfo] set [Status] ='Inactive' where [ID] = " & Val(lstvwRemoveTeacher.FocusedItem.SubItems(0).Text)
            Dim DBcmd As New OleDb.OleDbCommand
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBcmd.ExecuteNonQuery()
            DBcmd.Dispose()
            DBreader.Close()
            MsgBox("Teacher Deleted", MsgBoxStyle.Information)
            fillTeacherListView(lstvwTeacherList)
            fillTeacherListView(lstvwEditTeacher)
            fillTeacherListView(lstvwRemoveTeacher)
        End If
    End Sub

    Private Sub cmbPositionFilterTL_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPositionFilterTL.SelectedIndexChanged
        filterPositionfiller(cmbPositionFilterTL)
    End Sub

    Private Sub btnClearFilterTL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearFilterTL.Click
        fillTeacherListView(lstvwTeacherList)
        cmbPositionFilterTL.Text = ""
    End Sub

    Private Sub cmbPositionFilterET_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPositionFilterET.SelectedIndexChanged
        filterPositionfiller(cmbPositionFilterET)
    End Sub

    Private Sub btnClearFilterET_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearFilterET.Click
        fillTeacherListView(lstvwEditTeacher)
        cmbPositionFilterET.Text = ""
    End Sub

    Private Sub btnClearFilterRT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearFilterRT.Click
        fillTeacherListView(lstvwRemoveTeacher)
        cmbPositionFilterRT.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecoverTeacher.Click
        TabControl1.SelectTab(tbpRecoverTeacher)
        DBstring = "select * from [teacherInfo] where [Status] like 'Inactive%'"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        lstvwRecoverTeacher.Items.Clear()
        While (DBreader.Read())
            With lstvwRecoverTeacher.Items.Add(DBreader("ID").ToString)
                .SubItems.Add(DBreader("Status").ToString)
                .SubItems.Add(DBreader("TeacherNameFN").ToString)
                .SubItems.Add(DBreader("TeacherNameMN").ToString)
                .SubItems.Add(DBreader("TeacherNameLN").ToString)
                .SubItems.Add(DBreader("Sex").ToString)
                .SubItems.Add(DBreader("Position").ToString)
            End With
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub ToolStripMenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem32.Click
        lstvwTeacherList.Sorting = SortOrder.Ascending
    End Sub

    Private Sub ToolStripMenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem33.Click
        lstvwTeacherList.Sorting = SortOrder.Descending
    End Sub

    Private Sub ToolStripMenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem34.Click
        lstvwTeacherList.Sorting = SortOrder.None
    End Sub

    Private Sub ToolStripMenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem37.Click
        filterStatusfiller("Active", lstvwTeacherList)
    End Sub

    Private Sub ToolStripMenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem38.Click
        filterStatusfiller("On-Break", lstvwTeacherList)
    End Sub

    Private Sub MaleToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaleToolStripMenuItem1.Click
        filterGenderfiller("Male", lstvwTeacherList)
    End Sub

    Private Sub FemaleToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FemaleToolStripMenuItem1.Click
        filterGenderfiller("Female", lstvwTeacherList)
    End Sub

    Private Sub ToolStripMenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem40.Click
        lstvwEditTeacher.Sorting = SortOrder.Ascending
    End Sub

    Private Sub ToolStripMenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem41.Click
        lstvwEditTeacher.Sorting = SortOrder.Descending
    End Sub

    Private Sub ToolStripMenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem42.Click
        lstvwEditTeacher.Sorting = SortOrder.None
    End Sub

    Private Sub ToolStripMenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem45.Click
        filterStatusfiller("Active", lstvwEditTeacher)
    End Sub

    Private Sub ToolStripMenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem46.Click
        filterStatusfiller("On-Break", lstvwEditTeacher)
    End Sub

    Private Sub ToolStripMenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem48.Click
        filterGenderfiller("Male", lstvwEditTeacher)
    End Sub

    Private Sub ToolStripMenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem49.Click
        filterGenderfiller("Female", lstvwEditTeacher)
    End Sub

    Private Sub ToolStripMenuItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem51.Click
        lstvwRemoveTeacher.Sorting = SortOrder.Ascending
    End Sub

    Private Sub ToolStripMenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem52.Click
        lstvwRemoveTeacher.Sorting = SortOrder.Descending
    End Sub

    Private Sub ToolStripMenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem53.Click
        lstvwRemoveTeacher.Sorting = SortOrder.None
    End Sub

    Private Sub ToolStripMenuItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem56.Click
        filterStatusfiller("Active", lstvwRemoveTeacher)
    End Sub

    Private Sub ToolStripMenuItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem57.Click
        filterStatusfiller("On-Break", lstvwRemoveTeacher)
    End Sub

    Private Sub ToolStripMenuItem59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem59.Click
        filterGenderfiller("Male", lstvwRemoveTeacher)
    End Sub

    Private Sub ToolStripMenuItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem60.Click
        filterGenderfiller("Female", lstvwRemoveTeacher)
    End Sub

    Private Sub ToolStripMenuItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem62.Click
        lstvwRecoverTeacher.Sorting = SortOrder.Ascending
    End Sub

    Private Sub ToolStripMenuItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem63.Click
        lstvwRecoverTeacher.Sorting = SortOrder.Descending
    End Sub

    Private Sub ToolStripMenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem64.Click
        lstvwRecoverTeacher.Sorting = SortOrder.None
    End Sub

    Private Sub ToolStripMenuItem70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem70.Click
        filterGenderfiller("Male", lstvwRecoverTeacher)
    End Sub

    Private Sub ToolStripMenuItem71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem71.Click
        filterGenderfiller("Female", lstvwRecoverTeacher)
    End Sub

    Private Sub btnRecoverTeacherRCT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecoverTeacherRCT.Click
        If MsgBox("Do you want to recover this teacher?", MsgBoxStyle.Information + vbYesNo, "CAUTION") = MsgBoxResult.Yes Then
            DBstring = "update teacherInfo set [Status] ='Active' where [ID] =" & Val(lstvwRecoverTeacher.FocusedItem.SubItems(0).Text)
            Dim DBcmd As New OleDb.OleDbCommand
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBcmd.ExecuteNonQuery()
            DBcmd.Dispose()
            DBreader.Close()
            MsgBox("Teacher Recovered", MsgBoxStyle.Information)
            DBstring = "select * from [teacherInfo] where [Status] like 'Inactive%'"
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBadapter.SelectCommand = DBcmd
            DBreader = DBcmd.ExecuteReader
            lstvwRecoverTeacher.Items.Clear()
            While (DBreader.Read())
                With lstvwRecoverTeacher.Items.Add(DBreader("ID").ToString)
                    .SubItems.Add(DBreader("Status").ToString)
                    .SubItems.Add(DBreader("TeacherNameFN").ToString)
                    .SubItems.Add(DBreader("TeacherNameMN").ToString)
                    .SubItems.Add(DBreader("TeacherNameLN").ToString)
                    .SubItems.Add(DBreader("Sex").ToString)
                    .SubItems.Add(DBreader("Position").ToString)
                End With
            End While
            DBcmd.Dispose()
            DBreader.Close()
            fillTeacherListView(lstvwTeacherList)
            fillTeacherListView(lstvwEditTeacher)
            fillTeacherListView(lstvwRemoveTeacher)
        End If
    End Sub

    Private Sub btnGoBackRCT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoBackRCT.Click
        TabControl1.SelectTab(tbpTeacherList)
    End Sub

    Private Sub fillInfoRecoverTeacher()
        DBstring = "select * from [teacherInfo] where ID like '" _
        & lstvwRecoverTeacher.FocusedItem.SubItems(0).Text & "%'"
        Dim DBcmd As New OleDb.OleDbCommand
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While (DBreader.Read())
            lblIDRCT.Text = "ID: " + DBreader("ID").ToString
            lblNameRCT.Text = "Name: " + DBreader("TeacherNameLN") + ", " + DBreader("TeacherNameFN") + " " + DBreader("TeacherNameMN")
            lblSexRCT.Text = "Sex: " + DBreader("Sex")
            lblPositionRCT.Text = "Position:" + DBreader("Position")
            Try
                picbProfileRCT.Image = Image.FromFile(DBreader("TeacherPhotoPath"))
            Catch ex As Exception
                picbProfileRCT.Image = Nothing
            End Try
        End While
        DBcmd.Dispose()
        DBreader.Close()
    End Sub

    Private Sub lstvwRecoverTeacher_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstvwRecoverTeacher.MouseClick
        fillInfoRecoverTeacher()
    End Sub

    Private Sub btnGenerateBarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateBarcode.Click
        Dim Random1 As New Random
        txtBarcode.Text = Convert.ToString(Random1.Next(100000000, 999999999))
        DBstring = "select [Barcode] from [teacherInfo] where [Barcode] like '" & txtBarcode.Text & "';"
        Dim DBcmd As New OleDb.OleDbCommand
        Dim tempBCholder As String = ""
        DBcmd.CommandText = DBstring
        DBcmd.Connection = DBconnection
        DBadapter.SelectCommand = DBcmd
        DBreader = DBcmd.ExecuteReader
        While (DBreader.Read())
            tempBCholder = DBreader("Barcode").ToString
        End While
        DBcmd.Dispose()
        DBreader.Close()
        If tempBCholder = txtBarcode.Text Then
            MsgBox("Identical Barcode Found. Please Generate again.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged
        pcbBarcode.BackgroundImage = Code128(txtBarcode.Text, "A")
        lblTBarcode.Text = "Barcode: " + txtBarcode.Text
    End Sub

    Private Sub btnBMPBarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBMPBarcode.Click
        Try
            If txtBarcode.Text = "" Then
                MsgBox("Generate a barcode first", MsgBoxStyle.Exclamation, "ERROR")
                Exit Sub
            Else
                Dim SaveFileDialog1 As New SaveFileDialog()
                SaveFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
                SaveFileDialog1.Filter = "All files (*.*)|*.*|Bitmap files (*.bmp)|*.bmp"
                SaveFileDialog1.FilterIndex = 2
                SaveFileDialog1.RestoreDirectory = True
                SaveFileDialog1.ShowDialog()
                If SaveFileDialog1.FileName <> "" Then
                    pcbBarcode.BackgroundImage.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
                    MsgBox("Barcode successfully saved as bitmap", MsgBoxStyle.Information)
                    'pcbBarcode.Image.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Dim PrintDoc As Printing.PrintDocument = New Printing.PrintDocument()
    Dim pd_PrintDialog As New PrintDialog

    Private Sub btnPrintBarcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintBarcode.Click
        If txtBarcode.Text = "" Then
            MsgBox("Generate a barcode first", MsgBoxStyle.Exclamation, "ERROR")
            Exit Sub
        Else
            pd_PrintDialog.UseEXDialog = True
            pd_PrintDialog.AllowPrintToFile = False
            pd_PrintDialog.PrinterSettings.Copies = 1
            If pd_PrintDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                PrintDoc.PrinterSettings = pd_PrintDialog.PrinterSettings
                AddHandler PrintDoc.PrintPage, AddressOf PrintDocHandler
                PrintDoc.Print()
                MsgBox("Print Success/PDF Saved", MsgBoxStyle.Information)
            ElseIf pd_PrintDialog.ShowDialog = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub PrintDocHandler(ByVal sender As Object, ByVal ev As Printing.PrintPageEventArgs)
        ev.Graphics.DrawImage(pcbBarcode.BackgroundImage, 0, 0, 150, 50)
    End Sub

    Private Sub lstvwEditTeacher_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvwEditTeacher.SelectedIndexChanged

    End Sub

    Private Sub btnResetpassET_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetpassET.Click
        If MsgBox("Are you sure you want to reset the password of this teacher?", MsgBoxStyle.Exclamation + vbYesNo, "CAUTION") Then
            DBstring = "update teacherAccount set [password] ='" & "yasc@123" & "' where [idAcc] = '" & lblLastSelectholder.Text & "';"
            Dim DBcmd As New OleDb.OleDbCommand
            DBcmd.CommandText = DBstring
            DBcmd.Connection = DBconnection
            DBcmd.ExecuteNonQuery()
            DBcmd.Dispose()
            DBreader.Close()
            MsgBox("Password is now on default", MsgBoxStyle.Information)
        End If
    End Sub
End Class