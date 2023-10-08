<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainPage))
        Me.tmrOpenMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCloseMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tlp = New System.Windows.Forms.TableLayoutPanel
        Me.btnSetting = New System.Windows.Forms.Button
        Me.btnBreakNotice = New System.Windows.Forms.Button
        Me.btnChart = New System.Windows.Forms.Button
        Me.btnMonitoring = New System.Windows.Forms.Button
        Me.btnTeacherList = New System.Windows.Forms.Button
        Me.btnLogout = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.lblLogDateNote = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.btnSaveNote = New System.Windows.Forms.Button
        Me.btnAddNote = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpFilterDateNote = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnEditNote = New System.Windows.Forms.Button
        Me.rtxtNote = New System.Windows.Forms.RichTextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblLogStatusNote = New System.Windows.Forms.Label
        Me.lblTimeInTimeOutNote = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.lblTime = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblName = New System.Windows.Forms.Label
        Me.lblIsAdmin = New System.Windows.Forms.Label
        Me.lblIDnum = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblStatus5 = New System.Windows.Forms.Button
        Me.lblStatus1 = New System.Windows.Forms.Button
        Me.lblStatus4 = New System.Windows.Forms.Button
        Me.lblStatus3 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblStatus2 = New System.Windows.Forms.Button
        Me.btnNote5 = New System.Windows.Forms.Button
        Me.btnNote4 = New System.Windows.Forms.Button
        Me.btnNote3 = New System.Windows.Forms.Button
        Me.btnNote2 = New System.Windows.Forms.Button
        Me.btnNote1 = New System.Windows.Forms.Button
        Me.pcbSeeChart = New System.Windows.Forms.PictureBox
        Me.lblTimeOut5 = New System.Windows.Forms.Label
        Me.lblTimeIn5 = New System.Windows.Forms.Label
        Me.lblDate5 = New System.Windows.Forms.Label
        Me.lblTimeOut4 = New System.Windows.Forms.Label
        Me.lblTimeIn4 = New System.Windows.Forms.Label
        Me.lblDate4 = New System.Windows.Forms.Label
        Me.lblTimeOut3 = New System.Windows.Forms.Label
        Me.lblTimeIn3 = New System.Windows.Forms.Label
        Me.lblDate3 = New System.Windows.Forms.Label
        Me.lblTimeOut2 = New System.Windows.Forms.Label
        Me.lblTimeIn2 = New System.Windows.Forms.Label
        Me.lblDate2 = New System.Windows.Forms.Label
        Me.lblTimeOut1 = New System.Windows.Forms.Label
        Me.lblTimeIn1 = New System.Windows.Forms.Label
        Me.lblDate1 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnMenu = New System.Windows.Forms.Button
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.tlp.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.pcbSeeChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrOpenMenu
        '
        Me.tmrOpenMenu.Interval = 10
        '
        'tmrCloseMenu
        '
        Me.tmrCloseMenu.Interval = 10
        '
        'tlp
        '
        Me.tlp.BackColor = System.Drawing.Color.Transparent
        Me.tlp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tlp.ColumnCount = 8
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143.0!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 748.0!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145.0!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103.0!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.tlp.Controls.Add(Me.btnSetting, 5, 0)
        Me.tlp.Controls.Add(Me.btnBreakNotice, 4, 0)
        Me.tlp.Controls.Add(Me.btnChart, 3, 0)
        Me.tlp.Controls.Add(Me.btnMonitoring, 2, 0)
        Me.tlp.Controls.Add(Me.btnTeacherList, 1, 0)
        Me.tlp.Controls.Add(Me.btnLogout, 6, 0)
        Me.tlp.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlp.Location = New System.Drawing.Point(0, 0)
        Me.tlp.Name = "tlp"
        Me.tlp.RowCount = 1
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp.Size = New System.Drawing.Size(1366, 45)
        Me.tlp.TabIndex = 9
        '
        'btnSetting
        '
        Me.btnSetting.BackColor = System.Drawing.Color.Transparent
        Me.btnSetting.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.btn2
        Me.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSetting.FlatAppearance.BorderSize = 0
        Me.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetting.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnSetting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSetting.Image = Global.capstoneSystem.My.Resources.Resources.setting_icon
        Me.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetting.Location = New System.Drawing.Point(1137, 3)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(104, 33)
        Me.btnSetting.TabIndex = 9
        Me.btnSetting.Text = "Settings"
        Me.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSetting.UseVisualStyleBackColor = False
        '
        'btnBreakNotice
        '
        Me.btnBreakNotice.BackColor = System.Drawing.Color.Transparent
        Me.btnBreakNotice.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.btn2
        Me.btnBreakNotice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBreakNotice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBreakNotice.FlatAppearance.BorderSize = 0
        Me.btnBreakNotice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBreakNotice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBreakNotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBreakNotice.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnBreakNotice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBreakNotice.Image = Global.capstoneSystem.My.Resources.Resources.Alarm_icon
        Me.btnBreakNotice.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnBreakNotice.Location = New System.Drawing.Point(992, 3)
        Me.btnBreakNotice.Name = "btnBreakNotice"
        Me.btnBreakNotice.Size = New System.Drawing.Size(139, 33)
        Me.btnBreakNotice.TabIndex = 8
        Me.btnBreakNotice.Text = "Break Notice"
        Me.btnBreakNotice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBreakNotice.UseVisualStyleBackColor = False
        '
        'btnChart
        '
        Me.btnChart.BackColor = System.Drawing.Color.Transparent
        Me.btnChart.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.btn2
        Me.btnChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChart.FlatAppearance.BorderSize = 0
        Me.btnChart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChart.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnChart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnChart.Image = Global.capstoneSystem.My.Resources.Resources.ChartIcon
        Me.btnChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChart.Location = New System.Drawing.Point(902, 3)
        Me.btnChart.Name = "btnChart"
        Me.btnChart.Size = New System.Drawing.Size(83, 33)
        Me.btnChart.TabIndex = 7
        Me.btnChart.Text = "Chart"
        Me.btnChart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnChart.UseVisualStyleBackColor = False
        '
        'btnMonitoring
        '
        Me.btnMonitoring.BackColor = System.Drawing.Color.Transparent
        Me.btnMonitoring.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.btn2
        Me.btnMonitoring.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMonitoring.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMonitoring.FlatAppearance.BorderSize = 0
        Me.btnMonitoring.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMonitoring.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMonitoring.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMonitoring.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnMonitoring.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMonitoring.Image = Global.capstoneSystem.My.Resources.Resources.Billboard_icon
        Me.btnMonitoring.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMonitoring.Location = New System.Drawing.Point(154, 3)
        Me.btnMonitoring.Name = "btnMonitoring"
        Me.btnMonitoring.Size = New System.Drawing.Size(127, 33)
        Me.btnMonitoring.TabIndex = 11
        Me.btnMonitoring.Text = "Monitoring"
        Me.btnMonitoring.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMonitoring.UseVisualStyleBackColor = False
        Me.btnMonitoring.Visible = False
        '
        'btnTeacherList
        '
        Me.btnTeacherList.BackColor = System.Drawing.Color.Transparent
        Me.btnTeacherList.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.btn2
        Me.btnTeacherList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTeacherList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTeacherList.FlatAppearance.BorderSize = 0
        Me.btnTeacherList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnTeacherList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnTeacherList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeacherList.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnTeacherList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnTeacherList.Image = Global.capstoneSystem.My.Resources.Resources.Users_icon
        Me.btnTeacherList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTeacherList.Location = New System.Drawing.Point(11, 3)
        Me.btnTeacherList.Name = "btnTeacherList"
        Me.btnTeacherList.Size = New System.Drawing.Size(137, 33)
        Me.btnTeacherList.TabIndex = 10
        Me.btnTeacherList.Text = "Teacher List"
        Me.btnTeacherList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTeacherList.UseVisualStyleBackColor = False
        Me.btnTeacherList.Visible = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.btn2
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLogout.Image = Global.capstoneSystem.My.Resources.Resources.logouticon
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(1247, 3)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(97, 33)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnMenu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 723)
        Me.Panel1.TabIndex = 11
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.white_roundedBorder
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.lblLogDateNote)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.btnSaveNote)
        Me.Panel5.Controls.Add(Me.btnAddNote)
        Me.Panel5.Controls.Add(Me.GroupBox1)
        Me.Panel5.Controls.Add(Me.btnEditNote)
        Me.Panel5.Controls.Add(Me.rtxtNote)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.lblLogStatusNote)
        Me.Panel5.Controls.Add(Me.lblTimeInTimeOutNote)
        Me.Panel5.Location = New System.Drawing.Point(770, 318)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(544, 448)
        Me.Panel5.TabIndex = 18
        '
        'lblLogDateNote
        '
        Me.lblLogDateNote.AutoSize = True
        Me.lblLogDateNote.BackColor = System.Drawing.Color.Transparent
        Me.lblLogDateNote.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogDateNote.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLogDateNote.Location = New System.Drawing.Point(172, 0)
        Me.lblLogDateNote.Name = "lblLogDateNote"
        Me.lblLogDateNote.Size = New System.Drawing.Size(0, 38)
        Me.lblLogDateNote.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(34, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 38)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "NOTE • "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(210, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "DATE:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Lucida Fax", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(83, 212)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(388, 40)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "NO NOTE RECORDED"
        Me.Label14.Visible = False
        '
        'btnSaveNote
        '
        Me.btnSaveNote.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveNote.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.btn2
        Me.btnSaveNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveNote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveNote.Enabled = False
        Me.btnSaveNote.FlatAppearance.BorderSize = 0
        Me.btnSaveNote.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnSaveNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSaveNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSaveNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveNote.Font = New System.Drawing.Font("Copperplate Gothic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSaveNote.Image = Global.capstoneSystem.My.Resources.Resources.Save_icon
        Me.btnSaveNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveNote.Location = New System.Drawing.Point(358, 392)
        Me.btnSaveNote.Name = "btnSaveNote"
        Me.btnSaveNote.Size = New System.Drawing.Size(134, 31)
        Me.btnSaveNote.TabIndex = 51
        Me.btnSaveNote.Text = "SAVE NOTE"
        Me.btnSaveNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaveNote.UseVisualStyleBackColor = False
        '
        'btnAddNote
        '
        Me.btnAddNote.BackColor = System.Drawing.Color.Transparent
        Me.btnAddNote.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.btn2
        Me.btnAddNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddNote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNote.Enabled = False
        Me.btnAddNote.FlatAppearance.BorderSize = 0
        Me.btnAddNote.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnAddNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAddNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAddNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNote.Font = New System.Drawing.Font("Copperplate Gothic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddNote.Image = Global.capstoneSystem.My.Resources.Resources.note_add_icon
        Me.btnAddNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddNote.Location = New System.Drawing.Point(64, 392)
        Me.btnAddNote.Name = "btnAddNote"
        Me.btnAddNote.Size = New System.Drawing.Size(130, 31)
        Me.btnAddNote.TabIndex = 50
        Me.btnAddNote.Text = "ADD NOTE"
        Me.btnAddNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddNote.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dtpFilterDateNote)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.GroupBox1.Location = New System.Drawing.Point(33, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(481, 44)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTER"
        '
        'dtpFilterDateNote
        '
        Me.dtpFilterDateNote.Location = New System.Drawing.Point(180, 18)
        Me.dtpFilterDateNote.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.dtpFilterDateNote.Name = "dtpFilterDateNote"
        Me.dtpFilterDateNote.Size = New System.Drawing.Size(180, 20)
        Me.dtpFilterDateNote.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "SEARCH BY:"
        '
        'btnEditNote
        '
        Me.btnEditNote.BackColor = System.Drawing.Color.Transparent
        Me.btnEditNote.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.btn2
        Me.btnEditNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditNote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditNote.Enabled = False
        Me.btnEditNote.FlatAppearance.BorderSize = 0
        Me.btnEditNote.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btnEditNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEditNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEditNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditNote.Font = New System.Drawing.Font("Copperplate Gothic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnEditNote.Image = Global.capstoneSystem.My.Resources.Resources.note_edit_icon
        Me.btnEditNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditNote.Location = New System.Drawing.Point(213, 392)
        Me.btnEditNote.Name = "btnEditNote"
        Me.btnEditNote.Size = New System.Drawing.Size(130, 31)
        Me.btnEditNote.TabIndex = 48
        Me.btnEditNote.Text = "EDIT NOTE"
        Me.btnEditNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditNote.UseVisualStyleBackColor = False
        '
        'rtxtNote
        '
        Me.rtxtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtxtNote.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.rtxtNote.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtNote.Location = New System.Drawing.Point(33, 131)
        Me.rtxtNote.Name = "rtxtNote"
        Me.rtxtNote.ReadOnly = True
        Me.rtxtNote.Size = New System.Drawing.Size(481, 249)
        Me.rtxtNote.TabIndex = 26
        Me.rtxtNote.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gray
        Me.Label11.Location = New System.Drawing.Point(296, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 29)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "|"
        '
        'lblLogStatusNote
        '
        Me.lblLogStatusNote.AutoSize = True
        Me.lblLogStatusNote.BackColor = System.Drawing.Color.Transparent
        Me.lblLogStatusNote.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogStatusNote.ForeColor = System.Drawing.Color.IndianRed
        Me.lblLogStatusNote.Location = New System.Drawing.Point(316, 38)
        Me.lblLogStatusNote.Name = "lblLogStatusNote"
        Me.lblLogStatusNote.Size = New System.Drawing.Size(0, 35)
        Me.lblLogStatusNote.TabIndex = 24
        '
        'lblTimeInTimeOutNote
        '
        Me.lblTimeInTimeOutNote.AutoSize = True
        Me.lblTimeInTimeOutNote.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeInTimeOutNote.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeInTimeOutNote.ForeColor = System.Drawing.Color.IndianRed
        Me.lblTimeInTimeOutNote.Location = New System.Drawing.Point(28, 41)
        Me.lblTimeInTimeOutNote.Name = "lblTimeInTimeOutNote"
        Me.lblTimeInTimeOutNote.Size = New System.Drawing.Size(41, 25)
        Me.lblTimeInTimeOutNote.TabIndex = 23
        Me.lblTimeInTimeOutNote.Text = " • "
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.cbg1
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.lblTime)
        Me.Panel4.Location = New System.Drawing.Point(677, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(118, 51)
        Me.Panel4.TabIndex = 17
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Agency FB", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTime.Location = New System.Drawing.Point(15, 10)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(91, 34)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "04:37 PM"
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.bg1b1
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.lblName)
        Me.Panel3.Controls.Add(Me.lblIsAdmin)
        Me.Panel3.Controls.Add(Me.lblIDnum)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(671, 165)
        Me.Panel3.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Uighur", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(138, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 42)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "ID:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.User_icon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'lblName
        '
        Me.lblName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Uighur", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(138, 23)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(377, 49)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Surname, FirstName MiddleName"
        '
        'lblIsAdmin
        '
        Me.lblIsAdmin.AutoSize = True
        Me.lblIsAdmin.BackColor = System.Drawing.Color.Transparent
        Me.lblIsAdmin.Font = New System.Drawing.Font("Microsoft Uighur", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIsAdmin.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblIsAdmin.Location = New System.Drawing.Point(141, 107)
        Me.lblIsAdmin.Name = "lblIsAdmin"
        Me.lblIsAdmin.Size = New System.Drawing.Size(79, 36)
        Me.lblIsAdmin.TabIndex = 4
        Me.lblIsAdmin.Text = "ADMIN"
        Me.lblIsAdmin.Visible = False
        '
        'lblIDnum
        '
        Me.lblIDnum.AutoSize = True
        Me.lblIDnum.BackColor = System.Drawing.Color.Transparent
        Me.lblIDnum.Font = New System.Drawing.Font("Microsoft Uighur", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDnum.Location = New System.Drawing.Point(192, 65)
        Me.lblIDnum.Name = "lblIDnum"
        Me.lblIDnum.Size = New System.Drawing.Size(141, 42)
        Me.lblIDnum.TabIndex = 3
        Me.lblIDnum.Text = "ID NUMBER"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.bgbgbg1
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.lblStatus5)
        Me.Panel2.Controls.Add(Me.lblStatus1)
        Me.Panel2.Controls.Add(Me.lblStatus4)
        Me.Panel2.Controls.Add(Me.lblStatus3)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.lblStatus2)
        Me.Panel2.Controls.Add(Me.btnNote5)
        Me.Panel2.Controls.Add(Me.btnNote4)
        Me.Panel2.Controls.Add(Me.btnNote3)
        Me.Panel2.Controls.Add(Me.btnNote2)
        Me.Panel2.Controls.Add(Me.btnNote1)
        Me.Panel2.Controls.Add(Me.pcbSeeChart)
        Me.Panel2.Controls.Add(Me.lblTimeOut5)
        Me.Panel2.Controls.Add(Me.lblTimeIn5)
        Me.Panel2.Controls.Add(Me.lblDate5)
        Me.Panel2.Controls.Add(Me.lblTimeOut4)
        Me.Panel2.Controls.Add(Me.lblTimeIn4)
        Me.Panel2.Controls.Add(Me.lblDate4)
        Me.Panel2.Controls.Add(Me.lblTimeOut3)
        Me.Panel2.Controls.Add(Me.lblTimeIn3)
        Me.Panel2.Controls.Add(Me.lblDate3)
        Me.Panel2.Controls.Add(Me.lblTimeOut2)
        Me.Panel2.Controls.Add(Me.lblTimeIn2)
        Me.Panel2.Controls.Add(Me.lblDate2)
        Me.Panel2.Controls.Add(Me.lblTimeOut1)
        Me.Panel2.Controls.Add(Me.lblTimeIn1)
        Me.Panel2.Controls.Add(Me.lblDate1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(35, 262)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(687, 510)
        Me.Panel2.TabIndex = 15
        '
        'lblStatus5
        '
        Me.lblStatus5.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus5.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.blue_button_2
        Me.lblStatus5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lblStatus5.FlatAppearance.BorderSize = 0
        Me.lblStatus5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.lblStatus5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.lblStatus5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.lblStatus5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblStatus5.Font = New System.Drawing.Font("Copperplate Gothic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus5.ForeColor = System.Drawing.Color.Sienna
        Me.lblStatus5.Location = New System.Drawing.Point(203, 403)
        Me.lblStatus5.Name = "lblStatus5"
        Me.lblStatus5.Size = New System.Drawing.Size(243, 31)
        Me.lblStatus5.TabIndex = 47
        Me.lblStatus5.Text = "ABSENT"
        Me.lblStatus5.UseVisualStyleBackColor = False
        Me.lblStatus5.Visible = False
        '
        'lblStatus1
        '
        Me.lblStatus1.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus1.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.blue_button_2
        Me.lblStatus1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lblStatus1.FlatAppearance.BorderSize = 0
        Me.lblStatus1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.lblStatus1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.lblStatus1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.lblStatus1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblStatus1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus1.ForeColor = System.Drawing.Color.Sienna
        Me.lblStatus1.Location = New System.Drawing.Point(203, 148)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(243, 31)
        Me.lblStatus1.TabIndex = 43
        Me.lblStatus1.Text = "ABSENT"
        Me.lblStatus1.UseVisualStyleBackColor = False
        Me.lblStatus1.Visible = False
        '
        'lblStatus4
        '
        Me.lblStatus4.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus4.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.blue_button_2
        Me.lblStatus4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lblStatus4.FlatAppearance.BorderSize = 0
        Me.lblStatus4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.lblStatus4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.lblStatus4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.lblStatus4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblStatus4.Font = New System.Drawing.Font("Copperplate Gothic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus4.ForeColor = System.Drawing.Color.Sienna
        Me.lblStatus4.Location = New System.Drawing.Point(203, 340)
        Me.lblStatus4.Name = "lblStatus4"
        Me.lblStatus4.Size = New System.Drawing.Size(243, 31)
        Me.lblStatus4.TabIndex = 46
        Me.lblStatus4.Text = "ABSENT"
        Me.lblStatus4.UseVisualStyleBackColor = False
        Me.lblStatus4.Visible = False
        '
        'lblStatus3
        '
        Me.lblStatus3.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus3.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.blue_button_2
        Me.lblStatus3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lblStatus3.FlatAppearance.BorderSize = 0
        Me.lblStatus3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.lblStatus3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.lblStatus3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.lblStatus3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblStatus3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus3.ForeColor = System.Drawing.Color.Sienna
        Me.lblStatus3.Location = New System.Drawing.Point(203, 277)
        Me.lblStatus3.Name = "lblStatus3"
        Me.lblStatus3.Size = New System.Drawing.Size(243, 31)
        Me.lblStatus3.TabIndex = 45
        Me.lblStatus3.Text = "ABSENT"
        Me.lblStatus3.UseVisualStyleBackColor = False
        Me.lblStatus3.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Font = New System.Drawing.Font("Verdana", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Orange
        Me.Label5.Location = New System.Drawing.Point(121, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(448, 42)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "RECENT ATTENDANCE"
        '
        'lblStatus2
        '
        Me.lblStatus2.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus2.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.blue_button_2
        Me.lblStatus2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lblStatus2.FlatAppearance.BorderSize = 0
        Me.lblStatus2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.lblStatus2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.lblStatus2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.lblStatus2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblStatus2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus2.ForeColor = System.Drawing.Color.Sienna
        Me.lblStatus2.Location = New System.Drawing.Point(203, 212)
        Me.lblStatus2.Name = "lblStatus2"
        Me.lblStatus2.Size = New System.Drawing.Size(243, 31)
        Me.lblStatus2.TabIndex = 44
        Me.lblStatus2.Text = "ABSENT"
        Me.lblStatus2.UseVisualStyleBackColor = False
        Me.lblStatus2.Visible = False
        '
        'btnNote5
        '
        Me.btnNote5.BackColor = System.Drawing.Color.Transparent
        Me.btnNote5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNote5.FlatAppearance.BorderSize = 0
        Me.btnNote5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNote5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNote5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNote5.Image = Global.capstoneSystem.My.Resources.Resources.notes1_icon
        Me.btnNote5.Location = New System.Drawing.Point(529, 392)
        Me.btnNote5.Name = "btnNote5"
        Me.btnNote5.Size = New System.Drawing.Size(109, 51)
        Me.btnNote5.TabIndex = 36
        Me.btnNote5.UseVisualStyleBackColor = False
        '
        'btnNote4
        '
        Me.btnNote4.BackColor = System.Drawing.Color.Transparent
        Me.btnNote4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNote4.FlatAppearance.BorderSize = 0
        Me.btnNote4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNote4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNote4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNote4.Image = Global.capstoneSystem.My.Resources.Resources.notes1_icon
        Me.btnNote4.Location = New System.Drawing.Point(529, 329)
        Me.btnNote4.Name = "btnNote4"
        Me.btnNote4.Size = New System.Drawing.Size(109, 51)
        Me.btnNote4.TabIndex = 35
        Me.btnNote4.UseVisualStyleBackColor = False
        '
        'btnNote3
        '
        Me.btnNote3.BackColor = System.Drawing.Color.Transparent
        Me.btnNote3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNote3.FlatAppearance.BorderSize = 0
        Me.btnNote3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNote3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNote3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNote3.Image = Global.capstoneSystem.My.Resources.Resources.notes1_icon
        Me.btnNote3.Location = New System.Drawing.Point(529, 266)
        Me.btnNote3.Name = "btnNote3"
        Me.btnNote3.Size = New System.Drawing.Size(109, 51)
        Me.btnNote3.TabIndex = 34
        Me.btnNote3.UseVisualStyleBackColor = False
        '
        'btnNote2
        '
        Me.btnNote2.BackColor = System.Drawing.Color.Transparent
        Me.btnNote2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNote2.FlatAppearance.BorderSize = 0
        Me.btnNote2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNote2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNote2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNote2.Image = Global.capstoneSystem.My.Resources.Resources.notes1_icon
        Me.btnNote2.Location = New System.Drawing.Point(529, 201)
        Me.btnNote2.Name = "btnNote2"
        Me.btnNote2.Size = New System.Drawing.Size(109, 51)
        Me.btnNote2.TabIndex = 33
        Me.btnNote2.UseVisualStyleBackColor = False
        '
        'btnNote1
        '
        Me.btnNote1.BackColor = System.Drawing.Color.Transparent
        Me.btnNote1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNote1.FlatAppearance.BorderSize = 0
        Me.btnNote1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNote1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNote1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNote1.Image = Global.capstoneSystem.My.Resources.Resources.notes1_icon
        Me.btnNote1.Location = New System.Drawing.Point(529, 137)
        Me.btnNote1.Name = "btnNote1"
        Me.btnNote1.Size = New System.Drawing.Size(109, 51)
        Me.btnNote1.TabIndex = 32
        Me.btnNote1.UseVisualStyleBackColor = False
        '
        'pcbSeeChart
        '
        Me.pcbSeeChart.BackColor = System.Drawing.Color.Transparent
        Me.pcbSeeChart.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.seeChartIcon
        Me.pcbSeeChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbSeeChart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pcbSeeChart.Location = New System.Drawing.Point(259, 444)
        Me.pcbSeeChart.Name = "pcbSeeChart"
        Me.pcbSeeChart.Size = New System.Drawing.Size(206, 66)
        Me.pcbSeeChart.TabIndex = 31
        Me.pcbSeeChart.TabStop = False
        '
        'lblTimeOut5
        '
        Me.lblTimeOut5.AutoSize = True
        Me.lblTimeOut5.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeOut5.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTimeOut5.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblTimeOut5.Location = New System.Drawing.Point(330, 409)
        Me.lblTimeOut5.Name = "lblTimeOut5"
        Me.lblTimeOut5.Size = New System.Drawing.Size(0, 18)
        Me.lblTimeOut5.TabIndex = 30
        '
        'lblTimeIn5
        '
        Me.lblTimeIn5.AutoSize = True
        Me.lblTimeIn5.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeIn5.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTimeIn5.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblTimeIn5.Location = New System.Drawing.Point(200, 409)
        Me.lblTimeIn5.Name = "lblTimeIn5"
        Me.lblTimeIn5.Size = New System.Drawing.Size(0, 18)
        Me.lblTimeIn5.TabIndex = 29
        '
        'lblDate5
        '
        Me.lblDate5.AutoSize = True
        Me.lblDate5.BackColor = System.Drawing.Color.Transparent
        Me.lblDate5.Font = New System.Drawing.Font("PMingLiU-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate5.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblDate5.Location = New System.Drawing.Point(43, 409)
        Me.lblDate5.Name = "lblDate5"
        Me.lblDate5.Size = New System.Drawing.Size(0, 16)
        Me.lblDate5.TabIndex = 28
        '
        'lblTimeOut4
        '
        Me.lblTimeOut4.AutoSize = True
        Me.lblTimeOut4.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeOut4.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTimeOut4.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblTimeOut4.Location = New System.Drawing.Point(330, 346)
        Me.lblTimeOut4.Name = "lblTimeOut4"
        Me.lblTimeOut4.Size = New System.Drawing.Size(0, 18)
        Me.lblTimeOut4.TabIndex = 27
        '
        'lblTimeIn4
        '
        Me.lblTimeIn4.AutoSize = True
        Me.lblTimeIn4.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeIn4.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTimeIn4.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblTimeIn4.Location = New System.Drawing.Point(200, 346)
        Me.lblTimeIn4.Name = "lblTimeIn4"
        Me.lblTimeIn4.Size = New System.Drawing.Size(0, 18)
        Me.lblTimeIn4.TabIndex = 26
        '
        'lblDate4
        '
        Me.lblDate4.AutoSize = True
        Me.lblDate4.BackColor = System.Drawing.Color.Transparent
        Me.lblDate4.Font = New System.Drawing.Font("PMingLiU-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate4.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblDate4.Location = New System.Drawing.Point(43, 346)
        Me.lblDate4.Name = "lblDate4"
        Me.lblDate4.Size = New System.Drawing.Size(0, 16)
        Me.lblDate4.TabIndex = 25
        '
        'lblTimeOut3
        '
        Me.lblTimeOut3.AutoSize = True
        Me.lblTimeOut3.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeOut3.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTimeOut3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblTimeOut3.Location = New System.Drawing.Point(330, 283)
        Me.lblTimeOut3.Name = "lblTimeOut3"
        Me.lblTimeOut3.Size = New System.Drawing.Size(0, 18)
        Me.lblTimeOut3.TabIndex = 24
        '
        'lblTimeIn3
        '
        Me.lblTimeIn3.AutoSize = True
        Me.lblTimeIn3.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeIn3.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTimeIn3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblTimeIn3.Location = New System.Drawing.Point(200, 283)
        Me.lblTimeIn3.Name = "lblTimeIn3"
        Me.lblTimeIn3.Size = New System.Drawing.Size(0, 18)
        Me.lblTimeIn3.TabIndex = 23
        '
        'lblDate3
        '
        Me.lblDate3.AutoSize = True
        Me.lblDate3.BackColor = System.Drawing.Color.Transparent
        Me.lblDate3.Font = New System.Drawing.Font("PMingLiU-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblDate3.Location = New System.Drawing.Point(43, 283)
        Me.lblDate3.Name = "lblDate3"
        Me.lblDate3.Size = New System.Drawing.Size(0, 16)
        Me.lblDate3.TabIndex = 22
        '
        'lblTimeOut2
        '
        Me.lblTimeOut2.AutoSize = True
        Me.lblTimeOut2.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeOut2.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTimeOut2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblTimeOut2.Location = New System.Drawing.Point(330, 218)
        Me.lblTimeOut2.Name = "lblTimeOut2"
        Me.lblTimeOut2.Size = New System.Drawing.Size(0, 18)
        Me.lblTimeOut2.TabIndex = 21
        '
        'lblTimeIn2
        '
        Me.lblTimeIn2.AutoSize = True
        Me.lblTimeIn2.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeIn2.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTimeIn2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblTimeIn2.Location = New System.Drawing.Point(200, 218)
        Me.lblTimeIn2.Name = "lblTimeIn2"
        Me.lblTimeIn2.Size = New System.Drawing.Size(0, 18)
        Me.lblTimeIn2.TabIndex = 20
        '
        'lblDate2
        '
        Me.lblDate2.AutoSize = True
        Me.lblDate2.BackColor = System.Drawing.Color.Transparent
        Me.lblDate2.Font = New System.Drawing.Font("PMingLiU-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblDate2.Location = New System.Drawing.Point(43, 218)
        Me.lblDate2.Name = "lblDate2"
        Me.lblDate2.Size = New System.Drawing.Size(0, 16)
        Me.lblDate2.TabIndex = 19
        '
        'lblTimeOut1
        '
        Me.lblTimeOut1.AutoSize = True
        Me.lblTimeOut1.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeOut1.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTimeOut1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblTimeOut1.Location = New System.Drawing.Point(330, 154)
        Me.lblTimeOut1.Name = "lblTimeOut1"
        Me.lblTimeOut1.Size = New System.Drawing.Size(96, 18)
        Me.lblTimeOut1.TabIndex = 18
        Me.lblTimeOut1.Text = "11111111"
        '
        'lblTimeIn1
        '
        Me.lblTimeIn1.AutoSize = True
        Me.lblTimeIn1.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeIn1.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTimeIn1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblTimeIn1.Location = New System.Drawing.Point(200, 154)
        Me.lblTimeIn1.Name = "lblTimeIn1"
        Me.lblTimeIn1.Size = New System.Drawing.Size(96, 18)
        Me.lblTimeIn1.TabIndex = 16
        Me.lblTimeIn1.Text = "11111111"
        '
        'lblDate1
        '
        Me.lblDate1.AutoSize = True
        Me.lblDate1.BackColor = System.Drawing.Color.Transparent
        Me.lblDate1.Font = New System.Drawing.Font("PMingLiU-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.lblDate1.Location = New System.Drawing.Point(43, 154)
        Me.lblDate1.Name = "lblDate1"
        Me.lblDate1.Size = New System.Drawing.Size(0, 16)
        Me.lblDate1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(56, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "DATE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(559, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 23)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "NOTE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(208, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 23)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "TIME IN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(331, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "TIME OUT"
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnMenu.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.bg1b2
        Me.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Location = New System.Drawing.Point(1300, 13)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(44, 35)
        Me.btnMenu.TabIndex = 10
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'tmrTime
        '
        '
        'frmMainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tlp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 100)
        Me.MaximizeBox = False
        Me.Name = "frmMainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Page"
        Me.TransparencyKey = System.Drawing.Color.DimGray
        Me.tlp.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pcbSeeChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrOpenMenu As System.Windows.Forms.Timer
    Friend WithEvents tmrCloseMenu As System.Windows.Forms.Timer
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnSetting As System.Windows.Forms.Button
    Friend WithEvents btnBreakNotice As System.Windows.Forms.Button
    Friend WithEvents btnChart As System.Windows.Forms.Button
    Friend WithEvents tlp As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblIsAdmin As System.Windows.Forms.Label
    Friend WithEvents lblIDnum As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblDate1 As System.Windows.Forms.Label
    Friend WithEvents lblTimeIn1 As System.Windows.Forms.Label
    Friend WithEvents lblTimeOut5 As System.Windows.Forms.Label
    Friend WithEvents lblTimeIn5 As System.Windows.Forms.Label
    Friend WithEvents lblDate5 As System.Windows.Forms.Label
    Friend WithEvents lblTimeOut4 As System.Windows.Forms.Label
    Friend WithEvents lblTimeIn4 As System.Windows.Forms.Label
    Friend WithEvents lblDate4 As System.Windows.Forms.Label
    Friend WithEvents lblTimeOut3 As System.Windows.Forms.Label
    Friend WithEvents lblTimeIn3 As System.Windows.Forms.Label
    Friend WithEvents lblDate3 As System.Windows.Forms.Label
    Friend WithEvents lblTimeOut2 As System.Windows.Forms.Label
    Friend WithEvents lblTimeIn2 As System.Windows.Forms.Label
    Friend WithEvents lblDate2 As System.Windows.Forms.Label
    Friend WithEvents lblTimeOut1 As System.Windows.Forms.Label
    Friend WithEvents btnTeacherList As System.Windows.Forms.Button
    Friend WithEvents btnMonitoring As System.Windows.Forms.Button
    Friend WithEvents pcbSeeChart As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents tmrTime As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnNote1 As System.Windows.Forms.Button
    Friend WithEvents btnNote5 As System.Windows.Forms.Button
    Friend WithEvents btnNote4 As System.Windows.Forms.Button
    Friend WithEvents btnNote3 As System.Windows.Forms.Button
    Friend WithEvents btnNote2 As System.Windows.Forms.Button
    Friend WithEvents lblStatus5 As System.Windows.Forms.Button
    Friend WithEvents lblStatus4 As System.Windows.Forms.Button
    Friend WithEvents lblStatus3 As System.Windows.Forms.Button
    Friend WithEvents lblStatus2 As System.Windows.Forms.Button
    Friend WithEvents lblStatus1 As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblLogDateNote As System.Windows.Forms.Label
    Friend WithEvents rtxtNote As System.Windows.Forms.RichTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblLogStatusNote As System.Windows.Forms.Label
    Friend WithEvents lblTimeInTimeOutNote As System.Windows.Forms.Label
    Friend WithEvents btnEditNote As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpFilterDateNote As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnAddNote As System.Windows.Forms.Button
    Friend WithEvents btnSaveNote As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
