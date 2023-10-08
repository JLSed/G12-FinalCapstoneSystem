<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonitoring
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tbpDashboard = New System.Windows.Forms.TabPage
        Me.lblDashboardNoTeacher = New System.Windows.Forms.Label
        Me.lblDashboardNoOnBreak = New System.Windows.Forms.Label
        Me.lblDashboardNoLate = New System.Windows.Forms.Label
        Me.lblDashboardNoOnTime = New System.Windows.Forms.Label
        Me.lblDashboardNoAbsent = New System.Windows.Forms.Label
        Me.lblDashboardNoPresent = New System.Windows.Forms.Label
        Me.lblDashboardDate = New System.Windows.Forms.Label
        Me.btnMainPageTab0 = New System.Windows.Forms.Button
        Me.btnTeacherNotesTab0 = New System.Windows.Forms.Button
        Me.btnAuditLogTab0 = New System.Windows.Forms.Button
        Me.btnDashboardtab0 = New System.Windows.Forms.Button
        Me.tbpAuditLog = New System.Windows.Forms.TabPage
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbActivity = New System.Windows.Forms.ComboBox
        Me.txtUsernamesearch = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtIDsearch = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpDateR2 = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpDateR1 = New System.Windows.Forms.DateTimePicker
        Me.btnHomePageTab1 = New System.Windows.Forms.Button
        Me.btnTeacherNotesTab1 = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DescendingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearSortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnClearAllFilter = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnDashboardTab1 = New System.Windows.Forms.Button
        Me.lstvwAuditLog = New System.Windows.Forms.ListView
        Me.tbpTeacherNotes = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtNameSearchBN = New System.Windows.Forms.TextBox
        Me.txtIDSearchBN = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label20 = New System.Windows.Forms.Label
        Me.rtxtReasonBN = New System.Windows.Forms.RichTextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblDaysBN = New System.Windows.Forms.Label
        Me.lblDateEndBN = New System.Windows.Forms.Label
        Me.lblDateStartBN = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblDateAnnouncedBN = New System.Windows.Forms.Label
        Me.lblNameBN = New System.Windows.Forms.Label
        Me.lstvwBreakNotice = New System.Windows.Forms.ListView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtNameSearchTN = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtIDSearchTN = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblLogDateNote = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.lblLogStatusNote = New System.Windows.Forms.Label
        Me.lblTimeInTimeOutNote = New System.Windows.Forms.Label
        Me.rtxtNoteTN = New System.Windows.Forms.RichTextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.lstvwTeacherNotes = New System.Windows.Forms.ListView
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnHomePageTab2 = New System.Windows.Forms.Button
        Me.btnTeacherNotesTab2 = New System.Windows.Forms.Button
        Me.btnAuditLogTab2 = New System.Windows.Forms.Button
        Me.btnDashboardTab2 = New System.Windows.Forms.Button
        Me.tmrRefresher = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.tbpDashboard.SuspendLayout()
        Me.tbpAuditLog.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.tbpTeacherNotes.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbpDashboard)
        Me.TabControl1.Controls.Add(Me.tbpAuditLog)
        Me.TabControl1.Controls.Add(Me.tbpTeacherNotes)
        Me.TabControl1.Location = New System.Drawing.Point(-1, -23)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1371, 795)
        Me.TabControl1.TabIndex = 1
        '
        'tbpDashboard
        '
        Me.tbpDashboard.AutoScroll = True
        Me.tbpDashboard.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.moniBGN1
        Me.tbpDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tbpDashboard.Controls.Add(Me.lblDashboardNoTeacher)
        Me.tbpDashboard.Controls.Add(Me.lblDashboardNoOnBreak)
        Me.tbpDashboard.Controls.Add(Me.lblDashboardNoLate)
        Me.tbpDashboard.Controls.Add(Me.lblDashboardNoOnTime)
        Me.tbpDashboard.Controls.Add(Me.lblDashboardNoAbsent)
        Me.tbpDashboard.Controls.Add(Me.lblDashboardNoPresent)
        Me.tbpDashboard.Controls.Add(Me.lblDashboardDate)
        Me.tbpDashboard.Controls.Add(Me.btnMainPageTab0)
        Me.tbpDashboard.Controls.Add(Me.btnTeacherNotesTab0)
        Me.tbpDashboard.Controls.Add(Me.btnAuditLogTab0)
        Me.tbpDashboard.Controls.Add(Me.btnDashboardtab0)
        Me.tbpDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpDashboard.Location = New System.Drawing.Point(4, 22)
        Me.tbpDashboard.Name = "tbpDashboard"
        Me.tbpDashboard.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDashboard.Size = New System.Drawing.Size(1363, 769)
        Me.tbpDashboard.TabIndex = 0
        Me.tbpDashboard.Text = "Dashboard"
        Me.tbpDashboard.UseVisualStyleBackColor = True
        '
        'lblDashboardNoTeacher
        '
        Me.lblDashboardNoTeacher.AutoSize = True
        Me.lblDashboardNoTeacher.BackColor = System.Drawing.Color.Transparent
        Me.lblDashboardNoTeacher.Font = New System.Drawing.Font("Agency FB", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboardNoTeacher.Location = New System.Drawing.Point(834, 593)
        Me.lblDashboardNoTeacher.Name = "lblDashboardNoTeacher"
        Me.lblDashboardNoTeacher.Size = New System.Drawing.Size(159, 115)
        Me.lblDashboardNoTeacher.TabIndex = 50
        Me.lblDashboardNoTeacher.Text = "100"
        '
        'lblDashboardNoOnBreak
        '
        Me.lblDashboardNoOnBreak.AutoSize = True
        Me.lblDashboardNoOnBreak.BackColor = System.Drawing.Color.Transparent
        Me.lblDashboardNoOnBreak.Font = New System.Drawing.Font("Agency FB", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboardNoOnBreak.ForeColor = System.Drawing.Color.SlateGray
        Me.lblDashboardNoOnBreak.Location = New System.Drawing.Point(819, 303)
        Me.lblDashboardNoOnBreak.Name = "lblDashboardNoOnBreak"
        Me.lblDashboardNoOnBreak.Size = New System.Drawing.Size(159, 115)
        Me.lblDashboardNoOnBreak.TabIndex = 49
        Me.lblDashboardNoOnBreak.Text = "100"
        '
        'lblDashboardNoLate
        '
        Me.lblDashboardNoLate.AutoSize = True
        Me.lblDashboardNoLate.BackColor = System.Drawing.Color.Transparent
        Me.lblDashboardNoLate.Font = New System.Drawing.Font("Agency FB", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboardNoLate.ForeColor = System.Drawing.Color.Salmon
        Me.lblDashboardNoLate.Location = New System.Drawing.Point(473, 576)
        Me.lblDashboardNoLate.Name = "lblDashboardNoLate"
        Me.lblDashboardNoLate.Size = New System.Drawing.Size(159, 115)
        Me.lblDashboardNoLate.TabIndex = 48
        Me.lblDashboardNoLate.Text = "100"
        '
        'lblDashboardNoOnTime
        '
        Me.lblDashboardNoOnTime.AutoSize = True
        Me.lblDashboardNoOnTime.BackColor = System.Drawing.Color.Transparent
        Me.lblDashboardNoOnTime.Font = New System.Drawing.Font("Agency FB", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboardNoOnTime.ForeColor = System.Drawing.Color.PaleGreen
        Me.lblDashboardNoOnTime.Location = New System.Drawing.Point(133, 576)
        Me.lblDashboardNoOnTime.Name = "lblDashboardNoOnTime"
        Me.lblDashboardNoOnTime.Size = New System.Drawing.Size(159, 115)
        Me.lblDashboardNoOnTime.TabIndex = 47
        Me.lblDashboardNoOnTime.Text = "100"
        '
        'lblDashboardNoAbsent
        '
        Me.lblDashboardNoAbsent.AutoSize = True
        Me.lblDashboardNoAbsent.BackColor = System.Drawing.Color.Transparent
        Me.lblDashboardNoAbsent.Font = New System.Drawing.Font("Agency FB", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboardNoAbsent.ForeColor = System.Drawing.Color.Firebrick
        Me.lblDashboardNoAbsent.Location = New System.Drawing.Point(473, 303)
        Me.lblDashboardNoAbsent.Name = "lblDashboardNoAbsent"
        Me.lblDashboardNoAbsent.Size = New System.Drawing.Size(159, 115)
        Me.lblDashboardNoAbsent.TabIndex = 46
        Me.lblDashboardNoAbsent.Text = "100"
        '
        'lblDashboardNoPresent
        '
        Me.lblDashboardNoPresent.AutoSize = True
        Me.lblDashboardNoPresent.BackColor = System.Drawing.Color.Transparent
        Me.lblDashboardNoPresent.Font = New System.Drawing.Font("Agency FB", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboardNoPresent.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblDashboardNoPresent.Location = New System.Drawing.Point(133, 303)
        Me.lblDashboardNoPresent.Name = "lblDashboardNoPresent"
        Me.lblDashboardNoPresent.Size = New System.Drawing.Size(159, 115)
        Me.lblDashboardNoPresent.TabIndex = 45
        Me.lblDashboardNoPresent.Text = "100"
        '
        'lblDashboardDate
        '
        Me.lblDashboardDate.AutoSize = True
        Me.lblDashboardDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDashboardDate.Font = New System.Drawing.Font("Franklin Gothic Demi", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboardDate.ForeColor = System.Drawing.Color.Khaki
        Me.lblDashboardDate.Location = New System.Drawing.Point(139, 126)
        Me.lblDashboardDate.Name = "lblDashboardDate"
        Me.lblDashboardDate.Size = New System.Drawing.Size(841, 81)
        Me.lblDashboardDate.TabIndex = 44
        Me.lblDashboardDate.Text = "DASHBOARD • FEBRUARY 2"
        '
        'btnMainPageTab0
        '
        Me.btnMainPageTab0.BackColor = System.Drawing.Color.Transparent
        Me.btnMainPageTab0.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.btn2
        Me.btnMainPageTab0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMainPageTab0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMainPageTab0.FlatAppearance.BorderSize = 0
        Me.btnMainPageTab0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMainPageTab0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMainPageTab0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMainPageTab0.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnMainPageTab0.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMainPageTab0.Image = Global.capstoneSystem.My.Resources.Resources.Home_icon
        Me.btnMainPageTab0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMainPageTab0.Location = New System.Drawing.Point(1119, 30)
        Me.btnMainPageTab0.Name = "btnMainPageTab0"
        Me.btnMainPageTab0.Size = New System.Drawing.Size(207, 48)
        Me.btnMainPageTab0.TabIndex = 13
        Me.btnMainPageTab0.Text = "Main Page"
        Me.btnMainPageTab0.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnMainPageTab0.UseVisualStyleBackColor = False
        '
        'btnTeacherNotesTab0
        '
        Me.btnTeacherNotesTab0.BackColor = System.Drawing.Color.Transparent
        Me.btnTeacherNotesTab0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTeacherNotesTab0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTeacherNotesTab0.FlatAppearance.BorderSize = 0
        Me.btnTeacherNotesTab0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnTeacherNotesTab0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnTeacherNotesTab0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeacherNotesTab0.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnTeacherNotesTab0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnTeacherNotesTab0.Image = Global.capstoneSystem.My.Resources.Resources.File_Lines_icon
        Me.btnTeacherNotesTab0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTeacherNotesTab0.Location = New System.Drawing.Point(581, 39)
        Me.btnTeacherNotesTab0.Name = "btnTeacherNotesTab0"
        Me.btnTeacherNotesTab0.Size = New System.Drawing.Size(264, 45)
        Me.btnTeacherNotesTab0.TabIndex = 7
        Me.btnTeacherNotesTab0.Text = "Teacher Notes"
        Me.btnTeacherNotesTab0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTeacherNotesTab0.UseVisualStyleBackColor = False
        '
        'btnAuditLogTab0
        '
        Me.btnAuditLogTab0.BackColor = System.Drawing.Color.Transparent
        Me.btnAuditLogTab0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAuditLogTab0.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAuditLogTab0.FlatAppearance.BorderSize = 0
        Me.btnAuditLogTab0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAuditLogTab0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAuditLogTab0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAuditLogTab0.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnAuditLogTab0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAuditLogTab0.Image = Global.capstoneSystem.My.Resources.Resources.audit_icon
        Me.btnAuditLogTab0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAuditLogTab0.Location = New System.Drawing.Point(332, 39)
        Me.btnAuditLogTab0.Name = "btnAuditLogTab0"
        Me.btnAuditLogTab0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAuditLogTab0.Size = New System.Drawing.Size(193, 45)
        Me.btnAuditLogTab0.TabIndex = 11
        Me.btnAuditLogTab0.Text = "Audit Log"
        Me.btnAuditLogTab0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAuditLogTab0.UseVisualStyleBackColor = False
        '
        'btnDashboardtab0
        '
        Me.btnDashboardtab0.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboardtab0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDashboardtab0.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnDashboardtab0.FlatAppearance.BorderSize = 0
        Me.btnDashboardtab0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDashboardtab0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDashboardtab0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboardtab0.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnDashboardtab0.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDashboardtab0.Image = Global.capstoneSystem.My.Resources.Resources.dashboard_icon
        Me.btnDashboardtab0.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboardtab0.Location = New System.Drawing.Point(79, 39)
        Me.btnDashboardtab0.Name = "btnDashboardtab0"
        Me.btnDashboardtab0.Size = New System.Drawing.Size(213, 45)
        Me.btnDashboardtab0.TabIndex = 10
        Me.btnDashboardtab0.Text = "Dashboard"
        Me.btnDashboardtab0.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDashboardtab0.UseVisualStyleBackColor = True
        '
        'tbpAuditLog
        '
        Me.tbpAuditLog.BackColor = System.Drawing.SystemColors.Highlight
        Me.tbpAuditLog.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.moniBGN2
        Me.tbpAuditLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tbpAuditLog.Controls.Add(Me.Label1)
        Me.tbpAuditLog.Controls.Add(Me.Label6)
        Me.tbpAuditLog.Controls.Add(Me.cmbActivity)
        Me.tbpAuditLog.Controls.Add(Me.txtUsernamesearch)
        Me.tbpAuditLog.Controls.Add(Me.Label5)
        Me.tbpAuditLog.Controls.Add(Me.txtIDsearch)
        Me.tbpAuditLog.Controls.Add(Me.Label4)
        Me.tbpAuditLog.Controls.Add(Me.Label2)
        Me.tbpAuditLog.Controls.Add(Me.dtpDateR2)
        Me.tbpAuditLog.Controls.Add(Me.Label3)
        Me.tbpAuditLog.Controls.Add(Me.dtpDateR1)
        Me.tbpAuditLog.Controls.Add(Me.btnHomePageTab1)
        Me.tbpAuditLog.Controls.Add(Me.btnTeacherNotesTab1)
        Me.tbpAuditLog.Controls.Add(Me.MenuStrip1)
        Me.tbpAuditLog.Controls.Add(Me.btnClearAllFilter)
        Me.tbpAuditLog.Controls.Add(Me.Button3)
        Me.tbpAuditLog.Controls.Add(Me.btnDashboardTab1)
        Me.tbpAuditLog.Controls.Add(Me.lstvwAuditLog)
        Me.tbpAuditLog.Location = New System.Drawing.Point(4, 22)
        Me.tbpAuditLog.Name = "tbpAuditLog"
        Me.tbpAuditLog.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpAuditLog.Size = New System.Drawing.Size(1363, 769)
        Me.tbpAuditLog.TabIndex = 1
        Me.tbpAuditLog.Text = "Audit Log"
        Me.tbpAuditLog.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(769, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 33)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "DATE RANGE:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(134, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 22)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "TYPE OF ACTIVITY:"
        '
        'cmbActivity
        '
        Me.cmbActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbActivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmbActivity.FormattingEnabled = True
        Me.cmbActivity.Location = New System.Drawing.Point(41, 242)
        Me.cmbActivity.Name = "cmbActivity"
        Me.cmbActivity.Size = New System.Drawing.Size(373, 32)
        Me.cmbActivity.TabIndex = 57
        '
        'txtUsernamesearch
        '
        Me.txtUsernamesearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsernamesearch.Location = New System.Drawing.Point(956, 247)
        Me.txtUsernamesearch.Name = "txtUsernamesearch"
        Me.txtUsernamesearch.Size = New System.Drawing.Size(180, 29)
        Me.txtUsernamesearch.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(822, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 22)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "USERNAME:"
        '
        'txtIDsearch
        '
        Me.txtIDsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDsearch.Location = New System.Drawing.Point(707, 248)
        Me.txtIDsearch.Name = "txtIDsearch"
        Me.txtIDsearch.Size = New System.Drawing.Size(100, 29)
        Me.txtIDsearch.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(665, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 22)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(793, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 33)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Search By:"
        '
        'dtpDateR2
        '
        Me.dtpDateR2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateR2.Location = New System.Drawing.Point(891, 167)
        Me.dtpDateR2.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.dtpDateR2.Name = "dtpDateR2"
        Me.dtpDateR2.Size = New System.Drawing.Size(376, 35)
        Me.dtpDateR2.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 44)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "FILTERS"
        '
        'dtpDateR1
        '
        Me.dtpDateR1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateR1.Location = New System.Drawing.Point(469, 167)
        Me.dtpDateR1.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.dtpDateR1.Name = "dtpDateR1"
        Me.dtpDateR1.Size = New System.Drawing.Size(376, 35)
        Me.dtpDateR1.TabIndex = 25
        '
        'btnHomePageTab1
        '
        Me.btnHomePageTab1.BackColor = System.Drawing.Color.Transparent
        Me.btnHomePageTab1.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.btn2
        Me.btnHomePageTab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHomePageTab1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHomePageTab1.FlatAppearance.BorderSize = 0
        Me.btnHomePageTab1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHomePageTab1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHomePageTab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHomePageTab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnHomePageTab1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnHomePageTab1.Image = Global.capstoneSystem.My.Resources.Resources.Home_icon
        Me.btnHomePageTab1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHomePageTab1.Location = New System.Drawing.Point(1119, 30)
        Me.btnHomePageTab1.Name = "btnHomePageTab1"
        Me.btnHomePageTab1.Size = New System.Drawing.Size(207, 48)
        Me.btnHomePageTab1.TabIndex = 27
        Me.btnHomePageTab1.Text = "Main Page"
        Me.btnHomePageTab1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnHomePageTab1.UseVisualStyleBackColor = False
        '
        'btnTeacherNotesTab1
        '
        Me.btnTeacherNotesTab1.BackColor = System.Drawing.Color.Transparent
        Me.btnTeacherNotesTab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTeacherNotesTab1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTeacherNotesTab1.FlatAppearance.BorderSize = 0
        Me.btnTeacherNotesTab1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnTeacherNotesTab1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnTeacherNotesTab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeacherNotesTab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnTeacherNotesTab1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnTeacherNotesTab1.Image = Global.capstoneSystem.My.Resources.Resources.File_Lines_icon
        Me.btnTeacherNotesTab1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTeacherNotesTab1.Location = New System.Drawing.Point(581, 39)
        Me.btnTeacherNotesTab1.Name = "btnTeacherNotesTab1"
        Me.btnTeacherNotesTab1.Size = New System.Drawing.Size(264, 45)
        Me.btnTeacherNotesTab1.TabIndex = 24
        Me.btnTeacherNotesTab1.Text = "Teacher Notes"
        Me.btnTeacherNotesTab1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTeacherNotesTab1.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(45, 164)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(164, 53)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FilterToolStripMenuItem
        '
        Me.FilterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AToolStripMenuItem, Me.DescendingToolStripMenuItem1, Me.ClearSortToolStripMenuItem})
        Me.FilterToolStripMenuItem.Image = Global.capstoneSystem.My.Resources.Resources.Filter_Filled_icon
        Me.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem"
        Me.FilterToolStripMenuItem.Size = New System.Drawing.Size(156, 49)
        Me.FilterToolStripMenuItem.Text = "Sort by:"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.Image = Global.capstoneSystem.My.Resources.Resources.ascending_icon
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(267, 50)
        Me.AToolStripMenuItem.Text = "Ascending"
        '
        'DescendingToolStripMenuItem1
        '
        Me.DescendingToolStripMenuItem1.Image = Global.capstoneSystem.My.Resources.Resources.descending_icon
        Me.DescendingToolStripMenuItem1.Name = "DescendingToolStripMenuItem1"
        Me.DescendingToolStripMenuItem1.Size = New System.Drawing.Size(267, 50)
        Me.DescendingToolStripMenuItem1.Text = "Descending"
        '
        'ClearSortToolStripMenuItem
        '
        Me.ClearSortToolStripMenuItem.Image = Global.capstoneSystem.My.Resources.Resources.ClearSort_icon
        Me.ClearSortToolStripMenuItem.Name = "ClearSortToolStripMenuItem"
        Me.ClearSortToolStripMenuItem.Size = New System.Drawing.Size(267, 50)
        Me.ClearSortToolStripMenuItem.Text = "Clear Sort"
        '
        'btnClearAllFilter
        '
        Me.btnClearAllFilter.BackColor = System.Drawing.Color.Transparent
        Me.btnClearAllFilter.FlatAppearance.BorderSize = 0
        Me.btnClearAllFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearAllFilter.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAllFilter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClearAllFilter.Image = Global.capstoneSystem.My.Resources.Resources.ClearSort_icon
        Me.btnClearAllFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClearAllFilter.Location = New System.Drawing.Point(235, 167)
        Me.btnClearAllFilter.Name = "btnClearAllFilter"
        Me.btnClearAllFilter.Size = New System.Drawing.Size(177, 54)
        Me.btnClearAllFilter.TabIndex = 28
        Me.btnClearAllFilter.Text = "Clear Filter"
        Me.btnClearAllFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClearAllFilter.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Image = Global.capstoneSystem.My.Resources.Resources.audit_icon
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(332, 39)
        Me.Button3.Name = "Button3"
        Me.Button3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button3.Size = New System.Drawing.Size(193, 45)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Audit Log"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnDashboardTab1
        '
        Me.btnDashboardTab1.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboardTab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDashboardTab1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboardTab1.FlatAppearance.BorderSize = 0
        Me.btnDashboardTab1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDashboardTab1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDashboardTab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboardTab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnDashboardTab1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDashboardTab1.Image = Global.capstoneSystem.My.Resources.Resources.dashboard_icon
        Me.btnDashboardTab1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboardTab1.Location = New System.Drawing.Point(79, 39)
        Me.btnDashboardTab1.Name = "btnDashboardTab1"
        Me.btnDashboardTab1.Size = New System.Drawing.Size(213, 45)
        Me.btnDashboardTab1.TabIndex = 25
        Me.btnDashboardTab1.Text = "Dashboard"
        Me.btnDashboardTab1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDashboardTab1.UseVisualStyleBackColor = True
        '
        'lstvwAuditLog
        '
        Me.lstvwAuditLog.BackColor = System.Drawing.Color.White
        Me.lstvwAuditLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstvwAuditLog.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwAuditLog.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lstvwAuditLog.Location = New System.Drawing.Point(6, 384)
        Me.lstvwAuditLog.Name = "lstvwAuditLog"
        Me.lstvwAuditLog.Size = New System.Drawing.Size(1351, 358)
        Me.lstvwAuditLog.TabIndex = 19
        Me.lstvwAuditLog.UseCompatibleStateImageBehavior = False
        '
        'tbpTeacherNotes
        '
        Me.tbpTeacherNotes.BackColor = System.Drawing.SystemColors.Highlight
        Me.tbpTeacherNotes.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.moniBG4
        Me.tbpTeacherNotes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tbpTeacherNotes.Controls.Add(Me.GroupBox2)
        Me.tbpTeacherNotes.Controls.Add(Me.Panel4)
        Me.tbpTeacherNotes.Controls.Add(Me.GroupBox1)
        Me.tbpTeacherNotes.Controls.Add(Me.Panel3)
        Me.tbpTeacherNotes.Controls.Add(Me.btnHomePageTab2)
        Me.tbpTeacherNotes.Controls.Add(Me.btnTeacherNotesTab2)
        Me.tbpTeacherNotes.Controls.Add(Me.btnAuditLogTab2)
        Me.tbpTeacherNotes.Controls.Add(Me.btnDashboardTab2)
        Me.tbpTeacherNotes.Location = New System.Drawing.Point(4, 22)
        Me.tbpTeacherNotes.Name = "tbpTeacherNotes"
        Me.tbpTeacherNotes.Size = New System.Drawing.Size(1363, 769)
        Me.tbpTeacherNotes.TabIndex = 2
        Me.tbpTeacherNotes.Text = "Teacher Notes"
        Me.tbpTeacherNotes.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.txtNameSearchBN)
        Me.GroupBox2.Controls.Add(Me.txtIDSearchBN)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Copperplate Gothic Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(761, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(590, 78)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SEARCH FOR TEACHER BREAK NOTICE"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Image = Global.capstoneSystem.My.Resources.Resources.ClearSort_icon
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(437, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 49)
        Me.Button2.TabIndex = 62
        Me.Button2.Text = "Clear Filter"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtNameSearchBN
        '
        Me.txtNameSearchBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameSearchBN.Location = New System.Drawing.Point(206, 25)
        Me.txtNameSearchBN.Name = "txtNameSearchBN"
        Me.txtNameSearchBN.Size = New System.Drawing.Size(225, 29)
        Me.txtNameSearchBN.TabIndex = 62
        '
        'txtIDSearchBN
        '
        Me.txtIDSearchBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDSearchBN.Location = New System.Drawing.Point(54, 25)
        Me.txtIDSearchBN.Name = "txtIDSearchBN"
        Me.txtIDSearchBN.Size = New System.Drawing.Size(79, 29)
        Me.txtIDSearchBN.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(139, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 22)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "NAME:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 22)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "ID:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.lstviewBGv2
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.lstvwBreakNotice)
        Me.Panel4.Location = New System.Drawing.Point(761, 206)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(602, 552)
        Me.Panel4.TabIndex = 32
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label12.Location = New System.Drawing.Point(236, -3)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(195, 44)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "BREAK NOTICE"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.white_roundedBorder
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Controls.Add(Me.rtxtReasonBN)
        Me.Panel5.Controls.Add(Me.GroupBox3)
        Me.Panel5.Controls.Add(Me.lblDateAnnouncedBN)
        Me.Panel5.Controls.Add(Me.lblNameBN)
        Me.Panel5.Location = New System.Drawing.Point(15, 271)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(575, 342)
        Me.Panel5.TabIndex = 30
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(6, 109)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 20)
        Me.Label20.TabIndex = 60
        Me.Label20.Text = "REASON:"
        '
        'rtxtReasonBN
        '
        Me.rtxtReasonBN.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.rtxtReasonBN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtxtReasonBN.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtReasonBN.Location = New System.Drawing.Point(10, 132)
        Me.rtxtReasonBN.Name = "rtxtReasonBN"
        Me.rtxtReasonBN.ReadOnly = True
        Me.rtxtReasonBN.Size = New System.Drawing.Size(551, 146)
        Me.rtxtReasonBN.TabIndex = 58
        Me.rtxtReasonBN.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblDaysBN)
        Me.GroupBox3.Controls.Add(Me.lblDateEndBN)
        Me.GroupBox3.Controls.Add(Me.lblDateStartBN)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 62)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(551, 44)
        Me.GroupBox3.TabIndex = 59
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "START:"
        '
        'lblDaysBN
        '
        Me.lblDaysBN.AutoSize = True
        Me.lblDaysBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaysBN.Location = New System.Drawing.Point(350, 16)
        Me.lblDaysBN.Name = "lblDaysBN"
        Me.lblDaysBN.Size = New System.Drawing.Size(150, 18)
        Me.lblDaysBN.TabIndex = 3
        Me.lblDaysBN.Text = "On break for 10 days."
        '
        'lblDateEndBN
        '
        Me.lblDateEndBN.AutoSize = True
        Me.lblDateEndBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateEndBN.Location = New System.Drawing.Point(142, 16)
        Me.lblDateEndBN.Name = "lblDateEndBN"
        Me.lblDateEndBN.Size = New System.Drawing.Size(110, 18)
        Me.lblDateEndBN.TabIndex = 2
        Me.lblDateEndBN.Text = "March 10, 2023"
        '
        'lblDateStartBN
        '
        Me.lblDateStartBN.AutoSize = True
        Me.lblDateStartBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateStartBN.Location = New System.Drawing.Point(6, 16)
        Me.lblDateStartBN.Name = "lblDateStartBN"
        Me.lblDateStartBN.Size = New System.Drawing.Size(110, 18)
        Me.lblDateStartBN.TabIndex = 1
        Me.lblDateStartBN.Text = "March 10, 2023"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(142, 2)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "END:"
        '
        'lblDateAnnouncedBN
        '
        Me.lblDateAnnouncedBN.AutoSize = True
        Me.lblDateAnnouncedBN.BackColor = System.Drawing.Color.Transparent
        Me.lblDateAnnouncedBN.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateAnnouncedBN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDateAnnouncedBN.Location = New System.Drawing.Point(137, -3)
        Me.lblDateAnnouncedBN.Name = "lblDateAnnouncedBN"
        Me.lblDateAnnouncedBN.Size = New System.Drawing.Size(60, 38)
        Me.lblDateAnnouncedBN.TabIndex = 58
        Me.lblDateAnnouncedBN.Text = "da"
        '
        'lblNameBN
        '
        Me.lblNameBN.AutoSize = True
        Me.lblNameBN.BackColor = System.Drawing.Color.Transparent
        Me.lblNameBN.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameBN.ForeColor = System.Drawing.Color.IndianRed
        Me.lblNameBN.Location = New System.Drawing.Point(56, 34)
        Me.lblNameBN.Name = "lblNameBN"
        Me.lblNameBN.Size = New System.Drawing.Size(62, 23)
        Me.lblNameBN.TabIndex = 58
        Me.lblNameBN.Text = "aaaa"
        '
        'lstvwBreakNotice
        '
        Me.lstvwBreakNotice.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lstvwBreakNotice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstvwBreakNotice.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lstvwBreakNotice.ForeColor = System.Drawing.SystemColors.Window
        Me.lstvwBreakNotice.Location = New System.Drawing.Point(3, 56)
        Me.lstvwBreakNotice.Name = "lstvwBreakNotice"
        Me.lstvwBreakNotice.Size = New System.Drawing.Size(596, 209)
        Me.lstvwBreakNotice.TabIndex = 19
        Me.lstvwBreakNotice.UseCompatibleStateImageBehavior = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtNameSearchTN)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtIDSearchTN)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Copperplate Gothic Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(23, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 78)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SEARCH FOR TEACHER NOTES"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Image = Global.capstoneSystem.My.Resources.Resources.ClearSort_icon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(476, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 49)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Clear Filter"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtNameSearchTN
        '
        Me.txtNameSearchTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameSearchTN.Location = New System.Drawing.Point(205, 27)
        Me.txtNameSearchTN.Name = "txtNameSearchTN"
        Me.txtNameSearchTN.Size = New System.Drawing.Size(249, 29)
        Me.txtNameSearchTN.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(138, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 22)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "NAME:"
        '
        'txtIDSearchTN
        '
        Me.txtIDSearchTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDSearchTN.Location = New System.Drawing.Point(56, 29)
        Me.txtIDSearchTN.MaxLength = 3
        Me.txtIDSearchTN.Name = "txtIDSearchTN"
        Me.txtIDSearchTN.Size = New System.Drawing.Size(76, 29)
        Me.txtIDSearchTN.TabIndex = 58
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 22)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "ID:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.lstviewBG1
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.lstvwTeacherNotes)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Location = New System.Drawing.Point(0, 206)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(663, 548)
        Me.Panel3.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.white_roundedBorder
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.lblLogDateNote)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.lblLogStatusNote)
        Me.Panel1.Controls.Add(Me.lblTimeInTimeOutNote)
        Me.Panel1.Controls.Add(Me.rtxtNoteTN)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Location = New System.Drawing.Point(9, 313)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(641, 275)
        Me.Panel1.TabIndex = 54
        '
        'lblLogDateNote
        '
        Me.lblLogDateNote.AutoSize = True
        Me.lblLogDateNote.BackColor = System.Drawing.Color.Transparent
        Me.lblLogDateNote.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogDateNote.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLogDateNote.Location = New System.Drawing.Point(201, -3)
        Me.lblLogDateNote.Name = "lblLogDateNote"
        Me.lblLogDateNote.Size = New System.Drawing.Size(0, 38)
        Me.lblLogDateNote.TabIndex = 54
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Gray
        Me.Label14.Location = New System.Drawing.Point(325, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 29)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "|"
        '
        'lblLogStatusNote
        '
        Me.lblLogStatusNote.AutoSize = True
        Me.lblLogStatusNote.BackColor = System.Drawing.Color.Transparent
        Me.lblLogStatusNote.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogStatusNote.ForeColor = System.Drawing.Color.IndianRed
        Me.lblLogStatusNote.Location = New System.Drawing.Point(345, 30)
        Me.lblLogStatusNote.Name = "lblLogStatusNote"
        Me.lblLogStatusNote.Size = New System.Drawing.Size(0, 35)
        Me.lblLogStatusNote.TabIndex = 56
        '
        'lblTimeInTimeOutNote
        '
        Me.lblTimeInTimeOutNote.AutoSize = True
        Me.lblTimeInTimeOutNote.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeInTimeOutNote.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeInTimeOutNote.ForeColor = System.Drawing.Color.IndianRed
        Me.lblTimeInTimeOutNote.Location = New System.Drawing.Point(57, 38)
        Me.lblTimeInTimeOutNote.Name = "lblTimeInTimeOutNote"
        Me.lblTimeInTimeOutNote.Size = New System.Drawing.Size(41, 25)
        Me.lblTimeInTimeOutNote.TabIndex = 55
        Me.lblTimeInTimeOutNote.Text = " • "
        '
        'rtxtNoteTN
        '
        Me.rtxtNoteTN.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.rtxtNoteTN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtxtNoteTN.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtNoteTN.Location = New System.Drawing.Point(14, 71)
        Me.rtxtNoteTN.Name = "rtxtNoteTN"
        Me.rtxtNoteTN.ReadOnly = True
        Me.rtxtNoteTN.Size = New System.Drawing.Size(613, 164)
        Me.rtxtNoteTN.TabIndex = 41
        Me.rtxtNoteTN.Text = ""
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label25.Location = New System.Drawing.Point(-17, 45)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(681, 23)
        Me.Label25.TabIndex = 40
        Me.Label25.Text = "_____________________________________________________________"
        '
        'lstvwTeacherNotes
        '
        Me.lstvwTeacherNotes.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lstvwTeacherNotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstvwTeacherNotes.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwTeacherNotes.ForeColor = System.Drawing.SystemColors.Window
        Me.lstvwTeacherNotes.Location = New System.Drawing.Point(0, 56)
        Me.lstvwTeacherNotes.Name = "lstvwTeacherNotes"
        Me.lstvwTeacherNotes.Size = New System.Drawing.Size(660, 251)
        Me.lstvwTeacherNotes.TabIndex = 53
        Me.lstvwTeacherNotes.UseCompatibleStateImageBehavior = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Agency FB", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label11.Location = New System.Drawing.Point(212, -3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(219, 44)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "TEACHER NOTES"
        '
        'btnHomePageTab2
        '
        Me.btnHomePageTab2.BackColor = System.Drawing.Color.Transparent
        Me.btnHomePageTab2.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.btn2
        Me.btnHomePageTab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHomePageTab2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHomePageTab2.FlatAppearance.BorderSize = 0
        Me.btnHomePageTab2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHomePageTab2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHomePageTab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHomePageTab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnHomePageTab2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnHomePageTab2.Image = Global.capstoneSystem.My.Resources.Resources.Home_icon
        Me.btnHomePageTab2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHomePageTab2.Location = New System.Drawing.Point(1119, 30)
        Me.btnHomePageTab2.Name = "btnHomePageTab2"
        Me.btnHomePageTab2.Size = New System.Drawing.Size(207, 48)
        Me.btnHomePageTab2.TabIndex = 28
        Me.btnHomePageTab2.Text = "Main Page"
        Me.btnHomePageTab2.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnHomePageTab2.UseVisualStyleBackColor = False
        '
        'btnTeacherNotesTab2
        '
        Me.btnTeacherNotesTab2.BackColor = System.Drawing.Color.Transparent
        Me.btnTeacherNotesTab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTeacherNotesTab2.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnTeacherNotesTab2.FlatAppearance.BorderSize = 0
        Me.btnTeacherNotesTab2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnTeacherNotesTab2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnTeacherNotesTab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeacherNotesTab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold)
        Me.btnTeacherNotesTab2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnTeacherNotesTab2.Image = Global.capstoneSystem.My.Resources.Resources.File_Lines_icon
        Me.btnTeacherNotesTab2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTeacherNotesTab2.Location = New System.Drawing.Point(581, 39)
        Me.btnTeacherNotesTab2.Name = "btnTeacherNotesTab2"
        Me.btnTeacherNotesTab2.Size = New System.Drawing.Size(264, 45)
        Me.btnTeacherNotesTab2.TabIndex = 13
        Me.btnTeacherNotesTab2.Text = "Teacher Notes"
        Me.btnTeacherNotesTab2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTeacherNotesTab2.UseVisualStyleBackColor = False
        '
        'btnAuditLogTab2
        '
        Me.btnAuditLogTab2.BackColor = System.Drawing.Color.Transparent
        Me.btnAuditLogTab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAuditLogTab2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAuditLogTab2.FlatAppearance.BorderSize = 0
        Me.btnAuditLogTab2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAuditLogTab2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAuditLogTab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAuditLogTab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold)
        Me.btnAuditLogTab2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAuditLogTab2.Image = Global.capstoneSystem.My.Resources.Resources.audit_icon
        Me.btnAuditLogTab2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAuditLogTab2.Location = New System.Drawing.Point(332, 39)
        Me.btnAuditLogTab2.Name = "btnAuditLogTab2"
        Me.btnAuditLogTab2.Size = New System.Drawing.Size(193, 45)
        Me.btnAuditLogTab2.TabIndex = 15
        Me.btnAuditLogTab2.Text = "Audit Log"
        Me.btnAuditLogTab2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAuditLogTab2.UseVisualStyleBackColor = False
        '
        'btnDashboardTab2
        '
        Me.btnDashboardTab2.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboardTab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDashboardTab2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboardTab2.FlatAppearance.BorderSize = 0
        Me.btnDashboardTab2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDashboardTab2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDashboardTab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboardTab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold)
        Me.btnDashboardTab2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDashboardTab2.Image = Global.capstoneSystem.My.Resources.Resources.dashboard_icon
        Me.btnDashboardTab2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboardTab2.Location = New System.Drawing.Point(79, 39)
        Me.btnDashboardTab2.Name = "btnDashboardTab2"
        Me.btnDashboardTab2.Size = New System.Drawing.Size(213, 45)
        Me.btnDashboardTab2.TabIndex = 14
        Me.btnDashboardTab2.Text = "Dashboard"
        Me.btnDashboardTab2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDashboardTab2.UseVisualStyleBackColor = True
        '
        'tmrRefresher
        '
        Me.tmrRefresher.Interval = 60000
        '
        'frmMonitoring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmMonitoring"
        Me.Text = "Monitoring"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.tbpDashboard.ResumeLayout(False)
        Me.tbpDashboard.PerformLayout()
        Me.tbpAuditLog.ResumeLayout(False)
        Me.tbpAuditLog.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tbpTeacherNotes.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbpDashboard As System.Windows.Forms.TabPage
    Friend WithEvents btnAuditLogTab0 As System.Windows.Forms.Button
    Friend WithEvents btnDashboardtab0 As System.Windows.Forms.Button
    Friend WithEvents tbpAuditLog As System.Windows.Forms.TabPage
    Friend WithEvents tbpTeacherNotes As System.Windows.Forms.TabPage
    Friend WithEvents btnTeacherNotesTab0 As System.Windows.Forms.Button
    Friend WithEvents btnTeacherNotesTab2 As System.Windows.Forms.Button
    Friend WithEvents btnAuditLogTab2 As System.Windows.Forms.Button
    Friend WithEvents btnDashboardTab2 As System.Windows.Forms.Button
    Friend WithEvents btnMainPageTab0 As System.Windows.Forms.Button
    Friend WithEvents lblDashboardNoTeacher As System.Windows.Forms.Label
    Friend WithEvents lblDashboardNoOnBreak As System.Windows.Forms.Label
    Friend WithEvents lblDashboardNoLate As System.Windows.Forms.Label
    Friend WithEvents lblDashboardNoOnTime As System.Windows.Forms.Label
    Friend WithEvents lblDashboardNoAbsent As System.Windows.Forms.Label
    Friend WithEvents lblDashboardNoPresent As System.Windows.Forms.Label
    Friend WithEvents lblDashboardDate As System.Windows.Forms.Label
    Friend WithEvents lstvwAuditLog As System.Windows.Forms.ListView
    Friend WithEvents tmrRefresher As System.Windows.Forms.Timer
    Friend WithEvents dtpDateR2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateR1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescendingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearSortToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnClearAllFilter As System.Windows.Forms.Button
    Friend WithEvents btnHomePageTab1 As System.Windows.Forms.Button
    Friend WithEvents btnTeacherNotesTab1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnDashboardTab1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIDsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbActivity As System.Windows.Forms.ComboBox
    Friend WithEvents txtUsernamesearch As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnHomePageTab2 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNameSearchTN As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtIDSearchTN As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lstvwBreakNotice As System.Windows.Forms.ListView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIDSearchBN As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lstvwTeacherNotes As System.Windows.Forms.ListView
    Friend WithEvents txtNameSearchBN As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents rtxtNoteTN As System.Windows.Forms.RichTextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblLogDateNote As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblLogStatusNote As System.Windows.Forms.Label
    Friend WithEvents lblTimeInTimeOutNote As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblDateAnnouncedBN As System.Windows.Forms.Label
    Friend WithEvents lblNameBN As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents rtxtReasonBN As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDaysBN As System.Windows.Forms.Label
    Friend WithEvents lblDateEndBN As System.Windows.Forms.Label
    Friend WithEvents lblDateStartBN As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
