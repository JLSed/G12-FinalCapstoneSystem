<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminMenu
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
        Me.tlp = New System.Windows.Forms.TableLayoutPanel
        Me.btnRecoverTeacher = New System.Windows.Forms.Button
        Me.btnMainPage = New System.Windows.Forms.Button
        Me.btnEditTeacher = New System.Windows.Forms.Button
        Me.btnRemoveTeacher = New System.Windows.Forms.Button
        Me.btnAddTeacher = New System.Windows.Forms.Button
        Me.tmrOpenMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCloseMenu = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tbpTeacherList = New System.Windows.Forms.TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.btnClearFilterTL = New System.Windows.Forms.Button
        Me.Label27 = New System.Windows.Forms.Label
        Me.cmbPositionFilterTL = New System.Windows.Forms.ComboBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblBarcodeTL = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.picbBarcodeTL = New System.Windows.Forms.PictureBox
        Me.pcbProfile = New System.Windows.Forms.PictureBox
        Me.lblPosition = New System.Windows.Forms.Label
        Me.lblSex = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblID = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lstvwTeacherList = New System.Windows.Forms.ListView
        Me.btnMenu = New System.Windows.Forms.Button
        Me.tbpEditTeacher = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnClearFilterET = New System.Windows.Forms.Button
        Me.Label28 = New System.Windows.Forms.Label
        Me.cmbPositionFilterET = New System.Windows.Forms.ComboBox
        Me.lblmnholder = New System.Windows.Forms.Label
        Me.lblfnholder = New System.Windows.Forms.Label
        Me.lbllnholder = New System.Windows.Forms.Label
        Me.lblFilePathHolderET = New System.Windows.Forms.Label
        Me.lblLastSelectholder = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.btnResetpassET = New System.Windows.Forms.Button
        Me.cmbPostionET = New System.Windows.Forms.ComboBox
        Me.btnEditProfileET = New System.Windows.Forms.Button
        Me.cmbSexET = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnMakeChangesET = New System.Windows.Forms.Button
        Me.pcbProfileET = New System.Windows.Forms.PictureBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblPositionET = New System.Windows.Forms.Label
        Me.lblSexET = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtMiddleNET = New System.Windows.Forms.TextBox
        Me.txtLastNET = New System.Windows.Forms.TextBox
        Me.lblIDET = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtFirstNET = New System.Windows.Forms.TextBox
        Me.lblNameET = New System.Windows.Forms.Label
        Me.btnSaveEditET = New System.Windows.Forms.Button
        Me.btnGoBackET = New System.Windows.Forms.Button
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.lstvwEditTeacher = New System.Windows.Forms.ListView
        Me.tbpAddTeacher = New System.Windows.Forms.TabPage
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.lblTBarcode = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.lblTpassword = New System.Windows.Forms.Label
        Me.lblTusername = New System.Windows.Forms.Label
        Me.lblTposition = New System.Windows.Forms.Label
        Me.lblTsex = New System.Windows.Forms.Label
        Me.pcbTProfile = New System.Windows.Forms.PictureBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.lblTname = New System.Windows.Forms.Label
        Me.txtTphotoPath = New System.Windows.Forms.TextBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.btnBMPBarcode = New System.Windows.Forms.Button
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.btnPrintBarcode = New System.Windows.Forms.Button
        Me.btnGenerateBarcode = New System.Windows.Forms.Button
        Me.pcbBarcode = New System.Windows.Forms.PictureBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.cmbNposition = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.btnBrowseFile = New System.Windows.Forms.Button
        Me.btnChangeAccount = New System.Windows.Forms.Button
        Me.txtNpassword = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtNusername = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdbFemale = New System.Windows.Forms.RadioButton
        Me.rdbMale = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNfirstname = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNmiddlename = New System.Windows.Forms.TextBox
        Me.txtNlastname = New System.Windows.Forms.TextBox
        Me.btnGoBackANT = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnAddnewTeacher = New System.Windows.Forms.Button
        Me.tbpRemoveTeacher = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnClearFilterRT = New System.Windows.Forms.Button
        Me.Label29 = New System.Windows.Forms.Label
        Me.cmbPositionFilterRT = New System.Windows.Forms.ComboBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.btnRemoveTeacherRT = New System.Windows.Forms.Button
        Me.picbProfileRT = New System.Windows.Forms.PictureBox
        Me.lblPositionRT = New System.Windows.Forms.Label
        Me.lblSexRT = New System.Windows.Forms.Label
        Me.lblNameRT = New System.Windows.Forms.Label
        Me.lblIDRT = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.lstvwRemoveTeacher = New System.Windows.Forms.ListView
        Me.btnGoBackRT = New System.Windows.Forms.Button
        Me.tbpRecoverTeacher = New System.Windows.Forms.TabPage
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.btnGoBackRCT = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.btnRecoverTeacherRCT = New System.Windows.Forms.Button
        Me.picbProfileRCT = New System.Windows.Forms.PictureBox
        Me.lblPositionRCT = New System.Windows.Forms.Label
        Me.lblSexRCT = New System.Windows.Forms.Label
        Me.lblNameRCT = New System.Windows.Forms.Label
        Me.lblIDRCT = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.lstvwRecoverTeacher = New System.Windows.Forms.ListView
        Me.StatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ABSENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ONTIMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ONBREAKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem31 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem32 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem33 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem34 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem35 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem36 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem37 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem38 = New System.Windows.Forms.ToolStripMenuItem
        Me.GenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MaleToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.FemaleToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem39 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem40 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem41 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem42 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem43 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem44 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem45 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem46 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem47 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem48 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem49 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem50 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem51 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem52 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem53 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem54 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem55 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem56 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem57 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem58 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem59 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem60 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem61 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem62 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem63 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem64 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem65 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem69 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem70 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem71 = New System.Windows.Forms.ToolStripMenuItem
        Me.FilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DescendingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearSortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FilterByToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem
        Me.SexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FemaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem19 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem20 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem21 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem22 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem23 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem24 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem25 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem26 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem27 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem28 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem29 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem30 = New System.Windows.Forms.ToolStripMenuItem
        Me.tlp.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbpTeacherList.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.picbBarcodeTL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.tbpEditTeacher.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.pcbProfileET, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.tbpAddTeacher.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.pcbTProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.pcbBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.tbpRemoveTeacher.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.picbProfileRT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.tbpRecoverTeacher.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.picbProfileRCT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlp
        '
        Me.tlp.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.tlp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.tlp.ColumnCount = 8
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178.0!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186.0!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 543.0!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
        Me.tlp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.tlp.Controls.Add(Me.btnRecoverTeacher, 4, 0)
        Me.tlp.Controls.Add(Me.btnMainPage, 6, 0)
        Me.tlp.Controls.Add(Me.btnEditTeacher, 3, 0)
        Me.tlp.Controls.Add(Me.btnRemoveTeacher, 2, 0)
        Me.tlp.Controls.Add(Me.btnAddTeacher, 1, 0)
        Me.tlp.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlp.Location = New System.Drawing.Point(3, 3)
        Me.tlp.Name = "tlp"
        Me.tlp.RowCount = 1
        Me.tlp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp.Size = New System.Drawing.Size(1370, 40)
        Me.tlp.TabIndex = 14
        '
        'btnRecoverTeacher
        '
        Me.btnRecoverTeacher.BackColor = System.Drawing.Color.Transparent
        Me.btnRecoverTeacher.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.btn2
        Me.btnRecoverTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRecoverTeacher.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecoverTeacher.FlatAppearance.BorderSize = 0
        Me.btnRecoverTeacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRecoverTeacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRecoverTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecoverTeacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnRecoverTeacher.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRecoverTeacher.Image = Global.capstoneSystem.My.Resources.Resources.Refresh_icon
        Me.btnRecoverTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecoverTeacher.Location = New System.Drawing.Point(489, 3)
        Me.btnRecoverTeacher.Name = "btnRecoverTeacher"
        Me.btnRecoverTeacher.Size = New System.Drawing.Size(179, 33)
        Me.btnRecoverTeacher.TabIndex = 22
        Me.btnRecoverTeacher.Text = "Recover Teacher"
        Me.btnRecoverTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRecoverTeacher.UseVisualStyleBackColor = False
        '
        'btnMainPage
        '
        Me.btnMainPage.BackColor = System.Drawing.Color.Transparent
        Me.btnMainPage.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.btn2
        Me.btnMainPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMainPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMainPage.FlatAppearance.BorderSize = 0
        Me.btnMainPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMainPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMainPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnMainPage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMainPage.Image = Global.capstoneSystem.My.Resources.Resources.Home_icon
        Me.btnMainPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMainPage.Location = New System.Drawing.Point(1218, 3)
        Me.btnMainPage.Name = "btnMainPage"
        Me.btnMainPage.Size = New System.Drawing.Size(121, 33)
        Me.btnMainPage.TabIndex = 6
        Me.btnMainPage.Text = "Main Page"
        Me.btnMainPage.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnMainPage.UseVisualStyleBackColor = False
        '
        'btnEditTeacher
        '
        Me.btnEditTeacher.BackColor = System.Drawing.Color.Transparent
        Me.btnEditTeacher.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.btn2
        Me.btnEditTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditTeacher.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditTeacher.FlatAppearance.BorderSize = 0
        Me.btnEditTeacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEditTeacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnEditTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditTeacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnEditTeacher.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEditTeacher.Image = Global.capstoneSystem.My.Resources.Resources.profile_edit_icon
        Me.btnEditTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditTeacher.Location = New System.Drawing.Point(339, 3)
        Me.btnEditTeacher.Name = "btnEditTeacher"
        Me.btnEditTeacher.Size = New System.Drawing.Size(144, 33)
        Me.btnEditTeacher.TabIndex = 7
        Me.btnEditTeacher.Text = "Edit Teacher"
        Me.btnEditTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditTeacher.UseVisualStyleBackColor = False
        '
        'btnRemoveTeacher
        '
        Me.btnRemoveTeacher.BackColor = System.Drawing.Color.Transparent
        Me.btnRemoveTeacher.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.btn2
        Me.btnRemoveTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRemoveTeacher.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveTeacher.FlatAppearance.BorderSize = 0
        Me.btnRemoveTeacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRemoveTeacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRemoveTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveTeacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnRemoveTeacher.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRemoveTeacher.Image = Global.capstoneSystem.My.Resources.Resources.Delete_user_icon
        Me.btnRemoveTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveTeacher.Location = New System.Drawing.Point(161, 3)
        Me.btnRemoveTeacher.Name = "btnRemoveTeacher"
        Me.btnRemoveTeacher.Size = New System.Drawing.Size(172, 33)
        Me.btnRemoveTeacher.TabIndex = 11
        Me.btnRemoveTeacher.Text = "Remove Teacher"
        Me.btnRemoveTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemoveTeacher.UseVisualStyleBackColor = False
        '
        'btnAddTeacher
        '
        Me.btnAddTeacher.BackColor = System.Drawing.Color.Transparent
        Me.btnAddTeacher.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.btn2
        Me.btnAddTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddTeacher.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddTeacher.FlatAppearance.BorderSize = 0
        Me.btnAddTeacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAddTeacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAddTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTeacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnAddTeacher.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAddTeacher.Image = Global.capstoneSystem.My.Resources.Resources.Add_user_icon
        Me.btnAddTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddTeacher.Location = New System.Drawing.Point(11, 3)
        Me.btnAddTeacher.Name = "btnAddTeacher"
        Me.btnAddTeacher.Size = New System.Drawing.Size(144, 33)
        Me.btnAddTeacher.TabIndex = 10
        Me.btnAddTeacher.Text = "Add Teacher"
        Me.btnAddTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddTeacher.UseVisualStyleBackColor = True
        '
        'tmrOpenMenu
        '
        Me.tmrOpenMenu.Interval = 10
        '
        'tmrCloseMenu
        '
        Me.tmrCloseMenu.Interval = 10
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbpTeacherList)
        Me.TabControl1.Controls.Add(Me.tbpEditTeacher)
        Me.TabControl1.Controls.Add(Me.tbpAddTeacher)
        Me.TabControl1.Controls.Add(Me.tbpRemoveTeacher)
        Me.TabControl1.Controls.Add(Me.tbpRecoverTeacher)
        Me.TabControl1.Location = New System.Drawing.Point(-12, -25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1384, 799)
        Me.TabControl1.TabIndex = 0
        '
        'tbpTeacherList
        '
        Me.tbpTeacherList.AutoScroll = True
        Me.tbpTeacherList.Controls.Add(Me.Panel1)
        Me.tbpTeacherList.Controls.Add(Me.tlp)
        Me.tbpTeacherList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpTeacherList.Location = New System.Drawing.Point(4, 22)
        Me.tbpTeacherList.Name = "tbpTeacherList"
        Me.tbpTeacherList.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTeacherList.Size = New System.Drawing.Size(1376, 773)
        Me.tbpTeacherList.TabIndex = 0
        Me.tbpTeacherList.Text = "Teacher List"
        Me.tbpTeacherList.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnMenu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 727)
        Me.Panel1.TabIndex = 16
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.btnClearFilterTL)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.cmbPositionFilterTL)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Location = New System.Drawing.Point(11, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(649, 68)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FILTERS"
        '
        'ComboBox2
        '
        Me.ComboBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBox2.Location = New System.Drawing.Point(6, 21)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(178, 36)
        Me.ComboBox2.TabIndex = 49
        '
        'btnClearFilterTL
        '
        Me.btnClearFilterTL.FlatAppearance.BorderSize = 0
        Me.btnClearFilterTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearFilterTL.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearFilterTL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClearFilterTL.Image = Global.capstoneSystem.My.Resources.Resources.ClearSort_icon
        Me.btnClearFilterTL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClearFilterTL.Location = New System.Drawing.Point(494, 15)
        Me.btnClearFilterTL.Name = "btnClearFilterTL"
        Me.btnClearFilterTL.Size = New System.Drawing.Size(149, 48)
        Me.btnClearFilterTL.TabIndex = 48
        Me.btnClearFilterTL.Text = "Clear Filter"
        Me.btnClearFilterTL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClearFilterTL.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(297, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(69, 20)
        Me.Label27.TabIndex = 47
        Me.Label27.Text = "Position:"
        '
        'cmbPositionFilterTL
        '
        Me.cmbPositionFilterTL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbPositionFilterTL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPositionFilterTL.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPositionFilterTL.FormattingEnabled = True
        Me.cmbPositionFilterTL.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbPositionFilterTL.Location = New System.Drawing.Point(301, 21)
        Me.cmbPositionFilterTL.Name = "cmbPositionFilterTL"
        Me.cmbPositionFilterTL.Size = New System.Drawing.Size(178, 36)
        Me.cmbPositionFilterTL.TabIndex = 46
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.white_roundedBorder
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.lblBarcodeTL)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.picbBarcodeTL)
        Me.Panel3.Controls.Add(Me.pcbProfile)
        Me.Panel3.Controls.Add(Me.lblPosition)
        Me.Panel3.Controls.Add(Me.lblSex)
        Me.Panel3.Controls.Add(Me.lblName)
        Me.Panel3.Controls.Add(Me.lblID)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(765, 136)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(574, 534)
        Me.Panel3.TabIndex = 20
        '
        'lblBarcodeTL
        '
        Me.lblBarcodeTL.AutoSize = True
        Me.lblBarcodeTL.BackColor = System.Drawing.Color.Transparent
        Me.lblBarcodeTL.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarcodeTL.Location = New System.Drawing.Point(131, 330)
        Me.lblBarcodeTL.Name = "lblBarcodeTL"
        Me.lblBarcodeTL.Size = New System.Drawing.Size(0, 32)
        Me.lblBarcodeTL.TabIndex = 44
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(7, 330)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(135, 32)
        Me.Label21.TabIndex = 45
        Me.Label21.Text = "Barcode:"
        '
        'picbBarcodeTL
        '
        Me.picbBarcodeTL.BackColor = System.Drawing.Color.Transparent
        Me.picbBarcodeTL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picbBarcodeTL.Location = New System.Drawing.Point(28, 365)
        Me.picbBarcodeTL.Name = "picbBarcodeTL"
        Me.picbBarcodeTL.Size = New System.Drawing.Size(223, 82)
        Me.picbBarcodeTL.TabIndex = 43
        Me.picbBarcodeTL.TabStop = False
        '
        'pcbProfile
        '
        Me.pcbProfile.BackColor = System.Drawing.SystemColors.Control
        Me.pcbProfile.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.User_icon
        Me.pcbProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pcbProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbProfile.Location = New System.Drawing.Point(28, 32)
        Me.pcbProfile.Name = "pcbProfile"
        Me.pcbProfile.Size = New System.Drawing.Size(221, 191)
        Me.pcbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbProfile.TabIndex = 34
        Me.pcbProfile.TabStop = False
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPosition.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(7, 256)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(150, 32)
        Me.lblPosition.TabIndex = 26
        Me.lblPosition.Text = "Position:"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.BackColor = System.Drawing.Color.Transparent
        Me.lblSex.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.Location = New System.Drawing.Point(7, 288)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(75, 32)
        Me.lblSex.TabIndex = 25
        Me.lblSex.Text = "Sex:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(8, 227)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(89, 29)
        Me.lblName.TabIndex = 24
        Me.lblName.Text = "Name:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(255, 32)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(180, 32)
        Me.lblID.TabIndex = 23
        Me.lblID.Text = "ID: 00-0000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(178, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 29)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "TEACHER INFO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Orange
        Me.Label5.Location = New System.Drawing.Point(82, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(414, 59)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "TEACHER LIST"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.lstviewBG1
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.lstvwTeacherList)
        Me.Panel2.Location = New System.Drawing.Point(3, 136)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(657, 624)
        Me.Panel2.TabIndex = 19
        '
        'lstvwTeacherList
        '
        Me.lstvwTeacherList.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lstvwTeacherList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstvwTeacherList.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwTeacherList.ForeColor = System.Drawing.SystemColors.Window
        Me.lstvwTeacherList.Location = New System.Drawing.Point(0, 71)
        Me.lstvwTeacherList.Name = "lstvwTeacherList"
        Me.lstvwTeacherList.Size = New System.Drawing.Size(654, 513)
        Me.lstvwTeacherList.TabIndex = 18
        Me.lstvwTeacherList.UseCompatibleStateImageBehavior = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnMenu.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.bg1b2
        Me.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Location = New System.Drawing.Point(1297, 6)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(44, 32)
        Me.btnMenu.TabIndex = 15
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'tbpEditTeacher
        '
        Me.tbpEditTeacher.BackColor = System.Drawing.SystemColors.Highlight
        Me.tbpEditTeacher.Controls.Add(Me.GroupBox3)
        Me.tbpEditTeacher.Controls.Add(Me.lblmnholder)
        Me.tbpEditTeacher.Controls.Add(Me.lblfnholder)
        Me.tbpEditTeacher.Controls.Add(Me.lbllnholder)
        Me.tbpEditTeacher.Controls.Add(Me.lblFilePathHolderET)
        Me.tbpEditTeacher.Controls.Add(Me.lblLastSelectholder)
        Me.tbpEditTeacher.Controls.Add(Me.Label19)
        Me.tbpEditTeacher.Controls.Add(Me.Panel6)
        Me.tbpEditTeacher.Controls.Add(Me.btnSaveEditET)
        Me.tbpEditTeacher.Controls.Add(Me.btnGoBackET)
        Me.tbpEditTeacher.Controls.Add(Me.Panel7)
        Me.tbpEditTeacher.Location = New System.Drawing.Point(4, 22)
        Me.tbpEditTeacher.Name = "tbpEditTeacher"
        Me.tbpEditTeacher.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpEditTeacher.Size = New System.Drawing.Size(1376, 759)
        Me.tbpEditTeacher.TabIndex = 1
        Me.tbpEditTeacher.Text = "Edit Teacher"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnClearFilterET)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.cmbPositionFilterET)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Location = New System.Drawing.Point(14, 65)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(649, 68)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "FILTERS"
        '
        'btnClearFilterET
        '
        Me.btnClearFilterET.FlatAppearance.BorderSize = 0
        Me.btnClearFilterET.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearFilterET.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearFilterET.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClearFilterET.Image = Global.capstoneSystem.My.Resources.Resources.ClearSort_icon
        Me.btnClearFilterET.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClearFilterET.Location = New System.Drawing.Point(494, 15)
        Me.btnClearFilterET.Name = "btnClearFilterET"
        Me.btnClearFilterET.Size = New System.Drawing.Size(149, 48)
        Me.btnClearFilterET.TabIndex = 48
        Me.btnClearFilterET.Text = "Clear Filter"
        Me.btnClearFilterET.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClearFilterET.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(297, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(69, 20)
        Me.Label28.TabIndex = 47
        Me.Label28.Text = "Position:"
        '
        'cmbPositionFilterET
        '
        Me.cmbPositionFilterET.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbPositionFilterET.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPositionFilterET.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPositionFilterET.FormattingEnabled = True
        Me.cmbPositionFilterET.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbPositionFilterET.Location = New System.Drawing.Point(301, 21)
        Me.cmbPositionFilterET.Name = "cmbPositionFilterET"
        Me.cmbPositionFilterET.Size = New System.Drawing.Size(178, 36)
        Me.cmbPositionFilterET.TabIndex = 46
        '
        'lblmnholder
        '
        Me.lblmnholder.AutoSize = True
        Me.lblmnholder.BackColor = System.Drawing.SystemColors.Control
        Me.lblmnholder.Location = New System.Drawing.Point(789, 3)
        Me.lblmnholder.Name = "lblmnholder"
        Me.lblmnholder.Size = New System.Drawing.Size(100, 13)
        Me.lblmnholder.TabIndex = 49
        Me.lblmnholder.Text = "MNNAMEHOLDER"
        Me.lblmnholder.Visible = False
        '
        'lblfnholder
        '
        Me.lblfnholder.AutoSize = True
        Me.lblfnholder.BackColor = System.Drawing.SystemColors.Control
        Me.lblfnholder.Location = New System.Drawing.Point(686, 16)
        Me.lblfnholder.Name = "lblfnholder"
        Me.lblfnholder.Size = New System.Drawing.Size(97, 13)
        Me.lblfnholder.TabIndex = 48
        Me.lblfnholder.Text = "FNNAMEHOLDER"
        Me.lblfnholder.Visible = False
        '
        'lbllnholder
        '
        Me.lbllnholder.AutoSize = True
        Me.lbllnholder.BackColor = System.Drawing.SystemColors.Control
        Me.lbllnholder.Location = New System.Drawing.Point(686, 3)
        Me.lbllnholder.Name = "lbllnholder"
        Me.lbllnholder.Size = New System.Drawing.Size(97, 13)
        Me.lbllnholder.TabIndex = 47
        Me.lbllnholder.Text = "LNNAMEHOLDER"
        Me.lbllnholder.Visible = False
        '
        'lblFilePathHolderET
        '
        Me.lblFilePathHolderET.AutoSize = True
        Me.lblFilePathHolderET.BackColor = System.Drawing.SystemColors.Control
        Me.lblFilePathHolderET.Location = New System.Drawing.Point(577, 16)
        Me.lblFilePathHolderET.Name = "lblFilePathHolderET"
        Me.lblFilePathHolderET.Size = New System.Drawing.Size(103, 13)
        Me.lblFilePathHolderET.TabIndex = 45
        Me.lblFilePathHolderET.Text = "FILEPATHHOLDER"
        Me.lblFilePathHolderET.Visible = False
        '
        'lblLastSelectholder
        '
        Me.lblLastSelectholder.AutoSize = True
        Me.lblLastSelectholder.BackColor = System.Drawing.SystemColors.Control
        Me.lblLastSelectholder.Location = New System.Drawing.Point(584, 3)
        Me.lblLastSelectholder.Name = "lblLastSelectholder"
        Me.lblLastSelectholder.Size = New System.Drawing.Size(90, 13)
        Me.lblLastSelectholder.TabIndex = 46
        Me.lblLastSelectholder.Text = "LASTIDHOLDER"
        Me.lblLastSelectholder.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label19.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Orange
        Me.Label19.Location = New System.Drawing.Point(71, 3)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(414, 59)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "TEACHER LIST"
        '
        'Panel6
        '
        Me.Panel6.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.white_roundedBorder
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Controls.Add(Me.btnResetpassET)
        Me.Panel6.Controls.Add(Me.cmbPostionET)
        Me.Panel6.Controls.Add(Me.btnEditProfileET)
        Me.Panel6.Controls.Add(Me.cmbSexET)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.btnMakeChangesET)
        Me.Panel6.Controls.Add(Me.pcbProfileET)
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Controls.Add(Me.lblPositionET)
        Me.Panel6.Controls.Add(Me.lblSexET)
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Controls.Add(Me.txtMiddleNET)
        Me.Panel6.Controls.Add(Me.txtLastNET)
        Me.Panel6.Controls.Add(Me.lblIDET)
        Me.Panel6.Controls.Add(Me.Label17)
        Me.Panel6.Controls.Add(Me.txtFirstNET)
        Me.Panel6.Controls.Add(Me.lblNameET)
        Me.Panel6.Location = New System.Drawing.Point(743, 140)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(523, 476)
        Me.Panel6.TabIndex = 24
        '
        'btnResetpassET
        '
        Me.btnResetpassET.BackColor = System.Drawing.Color.Transparent
        Me.btnResetpassET.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResetpassET.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnResetpassET.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnResetpassET.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetpassET.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResetpassET.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnResetpassET.Image = Global.capstoneSystem.My.Resources.Resources.Refresh_icon
        Me.btnResetpassET.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResetpassET.Location = New System.Drawing.Point(94, 403)
        Me.btnResetpassET.Name = "btnResetpassET"
        Me.btnResetpassET.Size = New System.Drawing.Size(215, 70)
        Me.btnResetpassET.TabIndex = 54
        Me.btnResetpassET.Text = "Reset password " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to default"
        Me.btnResetpassET.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnResetpassET.UseVisualStyleBackColor = False
        Me.btnResetpassET.Visible = False
        '
        'cmbPostionET
        '
        Me.cmbPostionET.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbPostionET.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPostionET.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPostionET.FormattingEnabled = True
        Me.cmbPostionET.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbPostionET.Location = New System.Drawing.Point(159, 315)
        Me.cmbPostionET.Name = "cmbPostionET"
        Me.cmbPostionET.Size = New System.Drawing.Size(178, 36)
        Me.cmbPostionET.TabIndex = 45
        Me.cmbPostionET.Visible = False
        '
        'btnEditProfileET
        '
        Me.btnEditProfileET.BackColor = System.Drawing.Color.Transparent
        Me.btnEditProfileET.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditProfileET.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEditProfileET.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEditProfileET.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditProfileET.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditProfileET.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEditProfileET.Image = Global.capstoneSystem.My.Resources.Resources.Edit_icon
        Me.btnEditProfileET.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditProfileET.Location = New System.Drawing.Point(86, 192)
        Me.btnEditProfileET.Name = "btnEditProfileET"
        Me.btnEditProfileET.Size = New System.Drawing.Size(109, 23)
        Me.btnEditProfileET.TabIndex = 37
        Me.btnEditProfileET.Text = "Edit Profile"
        Me.btnEditProfileET.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditProfileET.UseVisualStyleBackColor = False
        Me.btnEditProfileET.Visible = False
        '
        'cmbSexET
        '
        Me.cmbSexET.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbSexET.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexET.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSexET.FormattingEnabled = True
        Me.cmbSexET.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbSexET.Location = New System.Drawing.Point(94, 361)
        Me.cmbSexET.Name = "cmbSexET"
        Me.cmbSexET.Size = New System.Drawing.Size(117, 36)
        Me.cmbSexET.TabIndex = 38
        Me.cmbSexET.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(341, 282)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 13)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Last Name"
        Me.Label12.Visible = False
        '
        'btnMakeChangesET
        '
        Me.btnMakeChangesET.BackColor = System.Drawing.Color.Transparent
        Me.btnMakeChangesET.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.blue_button_2
        Me.btnMakeChangesET.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMakeChangesET.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMakeChangesET.FlatAppearance.BorderSize = 0
        Me.btnMakeChangesET.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMakeChangesET.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMakeChangesET.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnMakeChangesET.Location = New System.Drawing.Point(383, 427)
        Me.btnMakeChangesET.Name = "btnMakeChangesET"
        Me.btnMakeChangesET.Size = New System.Drawing.Size(110, 29)
        Me.btnMakeChangesET.TabIndex = 35
        Me.btnMakeChangesET.Text = "Make Changes"
        Me.btnMakeChangesET.UseVisualStyleBackColor = False
        '
        'pcbProfileET
        '
        Me.pcbProfileET.BackColor = System.Drawing.SystemColors.Control
        Me.pcbProfileET.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.User_icon
        Me.pcbProfileET.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pcbProfileET.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbProfileET.Location = New System.Drawing.Point(41, 41)
        Me.pcbProfileET.Name = "pcbProfileET"
        Me.pcbProfileET.Size = New System.Drawing.Size(200, 185)
        Me.pcbProfileET.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbProfileET.TabIndex = 34
        Me.pcbProfileET.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(312, 282)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 13)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Mi"
        Me.Label13.Visible = False
        '
        'lblPositionET
        '
        Me.lblPositionET.AutoSize = True
        Me.lblPositionET.BackColor = System.Drawing.Color.Transparent
        Me.lblPositionET.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPositionET.Location = New System.Drawing.Point(36, 318)
        Me.lblPositionET.Name = "lblPositionET"
        Me.lblPositionET.Size = New System.Drawing.Size(129, 28)
        Me.lblPositionET.TabIndex = 26
        Me.lblPositionET.Text = "Position:"
        '
        'lblSexET
        '
        Me.lblSexET.AutoSize = True
        Me.lblSexET.BackColor = System.Drawing.Color.Transparent
        Me.lblSexET.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexET.Location = New System.Drawing.Point(36, 364)
        Me.lblSexET.Name = "lblSexET"
        Me.lblSexET.Size = New System.Drawing.Size(129, 28)
        Me.lblSexET.TabIndex = 25
        Me.lblSexET.Text = "Sex: Male"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(125, 282)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "First Name"
        Me.Label14.Visible = False
        '
        'txtMiddleNET
        '
        Me.txtMiddleNET.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleNET.Location = New System.Drawing.Point(315, 237)
        Me.txtMiddleNET.MaxLength = 1
        Me.txtMiddleNET.Name = "txtMiddleNET"
        Me.txtMiddleNET.Size = New System.Drawing.Size(23, 38)
        Me.txtMiddleNET.TabIndex = 40
        Me.txtMiddleNET.Visible = False
        '
        'txtLastNET
        '
        Me.txtLastNET.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastNET.Location = New System.Drawing.Point(344, 237)
        Me.txtLastNET.MaxLength = 50
        Me.txtLastNET.Name = "txtLastNET"
        Me.txtLastNET.Size = New System.Drawing.Size(163, 38)
        Me.txtLastNET.TabIndex = 41
        Me.txtLastNET.Visible = False
        '
        'lblIDET
        '
        Me.lblIDET.AutoSize = True
        Me.lblIDET.BackColor = System.Drawing.Color.Transparent
        Me.lblIDET.Font = New System.Drawing.Font("Consolas", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDET.Location = New System.Drawing.Point(248, 41)
        Me.lblIDET.Name = "lblIDET"
        Me.lblIDET.Size = New System.Drawing.Size(215, 37)
        Me.lblIDET.TabIndex = 23
        Me.lblIDET.Text = "ID: 00-0000"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(186, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(155, 29)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "EDIT INFO"
        '
        'txtFirstNET
        '
        Me.txtFirstNET.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstNET.Location = New System.Drawing.Point(128, 237)
        Me.txtFirstNET.MaxLength = 50
        Me.txtFirstNET.Name = "txtFirstNET"
        Me.txtFirstNET.Size = New System.Drawing.Size(181, 38)
        Me.txtFirstNET.TabIndex = 39
        Me.txtFirstNET.Visible = False
        '
        'lblNameET
        '
        Me.lblNameET.AutoSize = True
        Me.lblNameET.BackColor = System.Drawing.Color.Transparent
        Me.lblNameET.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameET.Location = New System.Drawing.Point(37, 240)
        Me.lblNameET.Name = "lblNameET"
        Me.lblNameET.Size = New System.Drawing.Size(99, 31)
        Me.lblNameET.TabIndex = 24
        Me.lblNameET.Text = "Name:"
        '
        'btnSaveEditET
        '
        Me.btnSaveEditET.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveEditET.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSaveEditET.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSaveEditET.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveEditET.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveEditET.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSaveEditET.Image = Global.capstoneSystem.My.Resources.Resources.Save_icon
        Me.btnSaveEditET.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveEditET.Location = New System.Drawing.Point(934, 622)
        Me.btnSaveEditET.Name = "btnSaveEditET"
        Me.btnSaveEditET.Size = New System.Drawing.Size(141, 64)
        Me.btnSaveEditET.TabIndex = 36
        Me.btnSaveEditET.Text = "Save Edit"
        Me.btnSaveEditET.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaveEditET.UseVisualStyleBackColor = True
        Me.btnSaveEditET.Visible = False
        '
        'btnGoBackET
        '
        Me.btnGoBackET.BackColor = System.Drawing.Color.Transparent
        Me.btnGoBackET.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.btn2
        Me.btnGoBackET.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGoBackET.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGoBackET.FlatAppearance.BorderSize = 0
        Me.btnGoBackET.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGoBackET.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGoBackET.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoBackET.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnGoBackET.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGoBackET.Image = Global.capstoneSystem.My.Resources.Resources.Back_icon
        Me.btnGoBackET.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGoBackET.Location = New System.Drawing.Point(1218, 3)
        Me.btnGoBackET.Name = "btnGoBackET"
        Me.btnGoBackET.Size = New System.Drawing.Size(105, 33)
        Me.btnGoBackET.TabIndex = 35
        Me.btnGoBackET.Text = "Go Back"
        Me.btnGoBackET.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGoBackET.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.lstviewBG1
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel7.Controls.Add(Me.lstvwEditTeacher)
        Me.Panel7.Location = New System.Drawing.Point(6, 140)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(657, 621)
        Me.Panel7.TabIndex = 23
        '
        'lstvwEditTeacher
        '
        Me.lstvwEditTeacher.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lstvwEditTeacher.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstvwEditTeacher.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwEditTeacher.ForeColor = System.Drawing.SystemColors.Window
        Me.lstvwEditTeacher.Location = New System.Drawing.Point(-3, 62)
        Me.lstvwEditTeacher.Name = "lstvwEditTeacher"
        Me.lstvwEditTeacher.Size = New System.Drawing.Size(660, 559)
        Me.lstvwEditTeacher.TabIndex = 22
        Me.lstvwEditTeacher.UseCompatibleStateImageBehavior = False
        '
        'tbpAddTeacher
        '
        Me.tbpAddTeacher.BackColor = System.Drawing.SystemColors.Highlight
        Me.tbpAddTeacher.Controls.Add(Me.Panel5)
        Me.tbpAddTeacher.Controls.Add(Me.Panel4)
        Me.tbpAddTeacher.Controls.Add(Me.btnGoBackANT)
        Me.tbpAddTeacher.Controls.Add(Me.Label3)
        Me.tbpAddTeacher.Controls.Add(Me.btnAddnewTeacher)
        Me.tbpAddTeacher.Location = New System.Drawing.Point(4, 22)
        Me.tbpAddTeacher.Name = "tbpAddTeacher"
        Me.tbpAddTeacher.Size = New System.Drawing.Size(1376, 759)
        Me.tbpAddTeacher.TabIndex = 2
        Me.tbpAddTeacher.Text = "Add Teacher"
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.white_roundedBorder
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.lblTBarcode)
        Me.Panel5.Controls.Add(Me.Label25)
        Me.Panel5.Controls.Add(Me.lblTpassword)
        Me.Panel5.Controls.Add(Me.lblTusername)
        Me.Panel5.Controls.Add(Me.lblTposition)
        Me.Panel5.Controls.Add(Me.lblTsex)
        Me.Panel5.Controls.Add(Me.pcbTProfile)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.lblTname)
        Me.Panel5.Controls.Add(Me.txtTphotoPath)
        Me.Panel5.Location = New System.Drawing.Point(869, 84)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(423, 416)
        Me.Panel5.TabIndex = 33
        '
        'lblTBarcode
        '
        Me.lblTBarcode.AutoSize = True
        Me.lblTBarcode.BackColor = System.Drawing.Color.Transparent
        Me.lblTBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTBarcode.Location = New System.Drawing.Point(8, 274)
        Me.lblTBarcode.Name = "lblTBarcode"
        Me.lblTBarcode.Size = New System.Drawing.Size(86, 24)
        Me.lblTBarcode.TabIndex = 40
        Me.lblTBarcode.Text = "Barcode:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label25.Location = New System.Drawing.Point(8, 289)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(406, 23)
        Me.Label25.TabIndex = 39
        Me.Label25.Text = "____________________________________"
        '
        'lblTpassword
        '
        Me.lblTpassword.AutoSize = True
        Me.lblTpassword.BackColor = System.Drawing.Color.Transparent
        Me.lblTpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTpassword.Location = New System.Drawing.Point(29, 357)
        Me.lblTpassword.Name = "lblTpassword"
        Me.lblTpassword.Size = New System.Drawing.Size(112, 25)
        Me.lblTpassword.TabIndex = 37
        Me.lblTpassword.Text = "Password:"
        '
        'lblTusername
        '
        Me.lblTusername.AutoSize = True
        Me.lblTusername.BackColor = System.Drawing.Color.Transparent
        Me.lblTusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTusername.Location = New System.Drawing.Point(25, 317)
        Me.lblTusername.Name = "lblTusername"
        Me.lblTusername.Size = New System.Drawing.Size(116, 25)
        Me.lblTusername.TabIndex = 36
        Me.lblTusername.Text = "Username:"
        '
        'lblTposition
        '
        Me.lblTposition.AutoSize = True
        Me.lblTposition.BackColor = System.Drawing.Color.Transparent
        Me.lblTposition.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTposition.Location = New System.Drawing.Point(8, 239)
        Me.lblTposition.Name = "lblTposition"
        Me.lblTposition.Size = New System.Drawing.Size(81, 24)
        Me.lblTposition.TabIndex = 35
        Me.lblTposition.Text = "Position:"
        '
        'lblTsex
        '
        Me.lblTsex.AutoSize = True
        Me.lblTsex.BackColor = System.Drawing.Color.Transparent
        Me.lblTsex.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTsex.Location = New System.Drawing.Point(8, 210)
        Me.lblTsex.Name = "lblTsex"
        Me.lblTsex.Size = New System.Drawing.Size(48, 24)
        Me.lblTsex.TabIndex = 34
        Me.lblTsex.Text = "Sex:"
        '
        'pcbTProfile
        '
        Me.pcbTProfile.BackColor = System.Drawing.SystemColors.Control
        Me.pcbTProfile.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.User_icon
        Me.pcbTProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pcbTProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbTProfile.Location = New System.Drawing.Point(136, 26)
        Me.pcbTProfile.Name = "pcbTProfile"
        Me.pcbTProfile.Size = New System.Drawing.Size(151, 146)
        Me.pcbTProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbTProfile.TabIndex = 33
        Me.pcbTProfile.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(104, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(208, 23)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "TEACHER PROFILE"
        '
        'lblTname
        '
        Me.lblTname.AutoSize = True
        Me.lblTname.BackColor = System.Drawing.Color.Transparent
        Me.lblTname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTname.Location = New System.Drawing.Point(8, 180)
        Me.lblTname.Name = "lblTname"
        Me.lblTname.Size = New System.Drawing.Size(66, 24)
        Me.lblTname.TabIndex = 4
        Me.lblTname.Text = "Name:"
        '
        'txtTphotoPath
        '
        Me.txtTphotoPath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTphotoPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTphotoPath.Location = New System.Drawing.Point(12, 116)
        Me.txtTphotoPath.Name = "txtTphotoPath"
        Me.txtTphotoPath.Size = New System.Drawing.Size(100, 13)
        Me.txtTphotoPath.TabIndex = 38
        Me.txtTphotoPath.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.white_roundedBorder
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.btnBMPBarcode)
        Me.Panel4.Controls.Add(Me.txtBarcode)
        Me.Panel4.Controls.Add(Me.btnPrintBarcode)
        Me.Panel4.Controls.Add(Me.btnGenerateBarcode)
        Me.Panel4.Controls.Add(Me.pcbBarcode)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.Label26)
        Me.Panel4.Controls.Add(Me.cmbNposition)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.btnBrowseFile)
        Me.Panel4.Controls.Add(Me.btnChangeAccount)
        Me.Panel4.Controls.Add(Me.txtNpassword)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.txtNusername)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.txtNfirstname)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txtNmiddlename)
        Me.Panel4.Controls.Add(Me.txtNlastname)
        Me.Panel4.Location = New System.Drawing.Point(34, 84)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(710, 625)
        Me.Panel4.TabIndex = 19
        '
        'btnBMPBarcode
        '
        Me.btnBMPBarcode.BackColor = System.Drawing.Color.SeaShell
        Me.btnBMPBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBMPBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBMPBarcode.Location = New System.Drawing.Point(399, 545)
        Me.btnBMPBarcode.Name = "btnBMPBarcode"
        Me.btnBMPBarcode.Size = New System.Drawing.Size(113, 52)
        Me.btnBMPBarcode.TabIndex = 46
        Me.btnBMPBarcode.Text = "SAVE AS .bmp"
        Me.btnBMPBarcode.UseVisualStyleBackColor = False
        '
        'txtBarcode
        '
        Me.txtBarcode.Enabled = False
        Me.txtBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(147, 580)
        Me.txtBarcode.MaxLength = 15
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(223, 35)
        Me.txtBarcode.TabIndex = 45
        '
        'btnPrintBarcode
        '
        Me.btnPrintBarcode.BackColor = System.Drawing.Color.SeaShell
        Me.btnPrintBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintBarcode.Location = New System.Drawing.Point(535, 545)
        Me.btnPrintBarcode.Name = "btnPrintBarcode"
        Me.btnPrintBarcode.Size = New System.Drawing.Size(113, 52)
        Me.btnPrintBarcode.TabIndex = 44
        Me.btnPrintBarcode.Text = "PRINT"
        Me.btnPrintBarcode.UseVisualStyleBackColor = False
        '
        'btnGenerateBarcode
        '
        Me.btnGenerateBarcode.BackColor = System.Drawing.Color.SeaShell
        Me.btnGenerateBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateBarcode.Location = New System.Drawing.Point(471, 492)
        Me.btnGenerateBarcode.Name = "btnGenerateBarcode"
        Me.btnGenerateBarcode.Size = New System.Drawing.Size(113, 29)
        Me.btnGenerateBarcode.TabIndex = 43
        Me.btnGenerateBarcode.Text = "GENERATE"
        Me.btnGenerateBarcode.UseVisualStyleBackColor = False
        '
        'pcbBarcode
        '
        Me.pcbBarcode.BackColor = System.Drawing.Color.Transparent
        Me.pcbBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pcbBarcode.Location = New System.Drawing.Point(147, 492)
        Me.pcbBarcode.Name = "pcbBarcode"
        Me.pcbBarcode.Size = New System.Drawing.Size(223, 82)
        Me.pcbBarcode.TabIndex = 42
        Me.pcbBarcode.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(183, 445)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(329, 32)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "GENERATE BARCODE"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label26.Location = New System.Drawing.Point(3, 260)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(703, 23)
        Me.Label26.TabIndex = 40
        Me.Label26.Text = "_______________________________________________________________"
        '
        'cmbNposition
        '
        Me.cmbNposition.BackColor = System.Drawing.Color.White
        Me.cmbNposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNposition.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNposition.FormattingEnabled = True
        Me.cmbNposition.Location = New System.Drawing.Point(445, 207)
        Me.cmbNposition.Name = "cmbNposition"
        Me.cmbNposition.Size = New System.Drawing.Size(231, 45)
        Me.cmbNposition.TabIndex = 35
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(201, 180)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(125, 24)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Profile Picture"
        '
        'btnBrowseFile
        '
        Me.btnBrowseFile.BackColor = System.Drawing.Color.SeaShell
        Me.btnBrowseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseFile.Image = Global.capstoneSystem.My.Resources.Resources.Folder_icon
        Me.btnBrowseFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBrowseFile.Location = New System.Drawing.Point(202, 207)
        Me.btnBrowseFile.Name = "btnBrowseFile"
        Me.btnBrowseFile.Size = New System.Drawing.Size(213, 45)
        Me.btnBrowseFile.TabIndex = 33
        Me.btnBrowseFile.Text = "BROWSE FILE"
        Me.btnBrowseFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBrowseFile.UseVisualStyleBackColor = False
        '
        'btnChangeAccount
        '
        Me.btnChangeAccount.BackColor = System.Drawing.Color.SeaShell
        Me.btnChangeAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangeAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeAccount.Location = New System.Drawing.Point(387, 346)
        Me.btnChangeAccount.Name = "btnChangeAccount"
        Me.btnChangeAccount.Size = New System.Drawing.Size(160, 71)
        Me.btnChangeAccount.TabIndex = 32
        Me.btnChangeAccount.Text = "CHANGE USERNAME"
        Me.btnChangeAccount.UseVisualStyleBackColor = False
        '
        'txtNpassword
        '
        Me.txtNpassword.Enabled = False
        Me.txtNpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNpassword.Location = New System.Drawing.Point(58, 407)
        Me.txtNpassword.Name = "txtNpassword"
        Me.txtNpassword.Size = New System.Drawing.Size(304, 35)
        Me.txtNpassword.TabIndex = 31
        Me.txtNpassword.Text = "yasc@123"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(54, 382)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 24)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Password"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(54, 317)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 24)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Username"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(205, 289)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(307, 32)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "DEFAULT ACCOUNT"
        '
        'txtNusername
        '
        Me.txtNusername.Enabled = False
        Me.txtNusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNusername.Location = New System.Drawing.Point(58, 344)
        Me.txtNusername.MaxLength = 15
        Me.txtNusername.Name = "txtNusername"
        Me.txtNusername.Size = New System.Drawing.Size(304, 35)
        Me.txtNusername.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(441, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 24)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Position"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdbFemale)
        Me.GroupBox1.Controls.Add(Me.rdbMale)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 89)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sex"
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.Location = New System.Drawing.Point(10, 53)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(92, 28)
        Me.rdbFemale.TabIndex = 1
        Me.rdbFemale.TabStop = True
        Me.rdbFemale.Text = "Female"
        Me.rdbFemale.UseVisualStyleBackColor = True
        '
        'rdbMale
        '
        Me.rdbMale.AutoSize = True
        Me.rdbMale.Location = New System.Drawing.Point(10, 19)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(69, 28)
        Me.rdbMale.TabIndex = 0
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        Me.rdbMale.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(421, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 24)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Last Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(383, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 24)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Mi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(141, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(415, 35)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "DEMOGRAPHIC PROFILE"
        '
        'txtNfirstname
        '
        Me.txtNfirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNfirstname.Location = New System.Drawing.Point(23, 97)
        Me.txtNfirstname.MaxLength = 30
        Me.txtNfirstname.Name = "txtNfirstname"
        Me.txtNfirstname.Size = New System.Drawing.Size(358, 44)
        Me.txtNfirstname.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "First Name"
        '
        'txtNmiddlename
        '
        Me.txtNmiddlename.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNmiddlename.Location = New System.Drawing.Point(387, 97)
        Me.txtNmiddlename.MaxLength = 1
        Me.txtNmiddlename.Name = "txtNmiddlename"
        Me.txtNmiddlename.Size = New System.Drawing.Size(32, 44)
        Me.txtNmiddlename.TabIndex = 1
        '
        'txtNlastname
        '
        Me.txtNlastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNlastname.Location = New System.Drawing.Point(425, 97)
        Me.txtNlastname.MaxLength = 30
        Me.txtNlastname.Name = "txtNlastname"
        Me.txtNlastname.Size = New System.Drawing.Size(269, 44)
        Me.txtNlastname.TabIndex = 2
        '
        'btnGoBackANT
        '
        Me.btnGoBackANT.BackColor = System.Drawing.Color.Transparent
        Me.btnGoBackANT.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.btn2
        Me.btnGoBackANT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGoBackANT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGoBackANT.FlatAppearance.BorderSize = 0
        Me.btnGoBackANT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGoBackANT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGoBackANT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoBackANT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnGoBackANT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGoBackANT.Image = Global.capstoneSystem.My.Resources.Resources.Back_icon
        Me.btnGoBackANT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGoBackANT.Location = New System.Drawing.Point(1218, 3)
        Me.btnGoBackANT.Name = "btnGoBackANT"
        Me.btnGoBackANT.Size = New System.Drawing.Size(104, 33)
        Me.btnGoBackANT.TabIndex = 34
        Me.btnGoBackANT.Text = "Go Back"
        Me.btnGoBackANT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGoBackANT.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(105, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(551, 59)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "ADD NEW TEACHER"
        '
        'btnAddnewTeacher
        '
        Me.btnAddnewTeacher.BackColor = System.Drawing.Color.Transparent
        Me.btnAddnewTeacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAddnewTeacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAddnewTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddnewTeacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddnewTeacher.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAddnewTeacher.Image = Global.capstoneSystem.My.Resources.Resources.Add_user_icon
        Me.btnAddnewTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddnewTeacher.Location = New System.Drawing.Point(977, 522)
        Me.btnAddnewTeacher.Name = "btnAddnewTeacher"
        Me.btnAddnewTeacher.Size = New System.Drawing.Size(220, 83)
        Me.btnAddnewTeacher.TabIndex = 32
        Me.btnAddnewTeacher.Text = "ADD TEACHER"
        Me.btnAddnewTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddnewTeacher.UseVisualStyleBackColor = False
        '
        'tbpRemoveTeacher
        '
        Me.tbpRemoveTeacher.BackColor = System.Drawing.SystemColors.Highlight
        Me.tbpRemoveTeacher.Controls.Add(Me.GroupBox4)
        Me.tbpRemoveTeacher.Controls.Add(Me.Label24)
        Me.tbpRemoveTeacher.Controls.Add(Me.Panel8)
        Me.tbpRemoveTeacher.Controls.Add(Me.Panel9)
        Me.tbpRemoveTeacher.Controls.Add(Me.btnGoBackRT)
        Me.tbpRemoveTeacher.Location = New System.Drawing.Point(4, 22)
        Me.tbpRemoveTeacher.Name = "tbpRemoveTeacher"
        Me.tbpRemoveTeacher.Size = New System.Drawing.Size(1376, 759)
        Me.tbpRemoveTeacher.TabIndex = 3
        Me.tbpRemoveTeacher.Text = "Remove Teacher"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnClearFilterRT)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.cmbPositionFilterRT)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox4.Location = New System.Drawing.Point(14, 64)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(649, 68)
        Me.GroupBox4.TabIndex = 51
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "FILTERS"
        '
        'btnClearFilterRT
        '
        Me.btnClearFilterRT.FlatAppearance.BorderSize = 0
        Me.btnClearFilterRT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearFilterRT.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearFilterRT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClearFilterRT.Image = Global.capstoneSystem.My.Resources.Resources.ClearSort_icon
        Me.btnClearFilterRT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClearFilterRT.Location = New System.Drawing.Point(494, 15)
        Me.btnClearFilterRT.Name = "btnClearFilterRT"
        Me.btnClearFilterRT.Size = New System.Drawing.Size(149, 48)
        Me.btnClearFilterRT.TabIndex = 48
        Me.btnClearFilterRT.Text = "Clear Filter"
        Me.btnClearFilterRT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClearFilterRT.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(297, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(69, 20)
        Me.Label29.TabIndex = 47
        Me.Label29.Text = "Position:"
        '
        'cmbPositionFilterRT
        '
        Me.cmbPositionFilterRT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbPositionFilterRT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPositionFilterRT.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPositionFilterRT.FormattingEnabled = True
        Me.cmbPositionFilterRT.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbPositionFilterRT.Location = New System.Drawing.Point(301, 21)
        Me.cmbPositionFilterRT.Name = "cmbPositionFilterRT"
        Me.cmbPositionFilterRT.Size = New System.Drawing.Size(178, 36)
        Me.cmbPositionFilterRT.TabIndex = 46
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label24.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Orange
        Me.Label24.Location = New System.Drawing.Point(99, 2)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(414, 59)
        Me.Label24.TabIndex = 36
        Me.Label24.Text = "TEACHER LIST"
        '
        'Panel8
        '
        Me.Panel8.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.white_roundedBorder
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel8.Controls.Add(Me.btnRemoveTeacherRT)
        Me.Panel8.Controls.Add(Me.picbProfileRT)
        Me.Panel8.Controls.Add(Me.lblPositionRT)
        Me.Panel8.Controls.Add(Me.lblSexRT)
        Me.Panel8.Controls.Add(Me.lblNameRT)
        Me.Panel8.Controls.Add(Me.lblIDRT)
        Me.Panel8.Controls.Add(Me.Label23)
        Me.Panel8.Location = New System.Drawing.Point(788, 140)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(574, 534)
        Me.Panel8.TabIndex = 38
        '
        'btnRemoveTeacherRT
        '
        Me.btnRemoveTeacherRT.BackColor = System.Drawing.Color.Transparent
        Me.btnRemoveTeacherRT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemoveTeacherRT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRemoveTeacherRT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRemoveTeacherRT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveTeacherRT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveTeacherRT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRemoveTeacherRT.Image = Global.capstoneSystem.My.Resources.Resources.Edit_icon
        Me.btnRemoveTeacherRT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveTeacherRT.Location = New System.Drawing.Point(191, 468)
        Me.btnRemoveTeacherRT.Name = "btnRemoveTeacherRT"
        Me.btnRemoveTeacherRT.Size = New System.Drawing.Size(211, 51)
        Me.btnRemoveTeacherRT.TabIndex = 52
        Me.btnRemoveTeacherRT.Text = "Remove Teacher"
        Me.btnRemoveTeacherRT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRemoveTeacherRT.UseVisualStyleBackColor = False
        '
        'picbProfileRT
        '
        Me.picbProfileRT.BackColor = System.Drawing.SystemColors.Control
        Me.picbProfileRT.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.User_icon
        Me.picbProfileRT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picbProfileRT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picbProfileRT.Location = New System.Drawing.Point(28, 32)
        Me.picbProfileRT.Name = "picbProfileRT"
        Me.picbProfileRT.Size = New System.Drawing.Size(221, 191)
        Me.picbProfileRT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbProfileRT.TabIndex = 34
        Me.picbProfileRT.TabStop = False
        '
        'lblPositionRT
        '
        Me.lblPositionRT.AutoSize = True
        Me.lblPositionRT.BackColor = System.Drawing.Color.Transparent
        Me.lblPositionRT.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPositionRT.Location = New System.Drawing.Point(7, 256)
        Me.lblPositionRT.Name = "lblPositionRT"
        Me.lblPositionRT.Size = New System.Drawing.Size(150, 32)
        Me.lblPositionRT.TabIndex = 26
        Me.lblPositionRT.Text = "Position:"
        '
        'lblSexRT
        '
        Me.lblSexRT.AutoSize = True
        Me.lblSexRT.BackColor = System.Drawing.Color.Transparent
        Me.lblSexRT.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexRT.Location = New System.Drawing.Point(7, 288)
        Me.lblSexRT.Name = "lblSexRT"
        Me.lblSexRT.Size = New System.Drawing.Size(75, 32)
        Me.lblSexRT.TabIndex = 25
        Me.lblSexRT.Text = "Sex:"
        '
        'lblNameRT
        '
        Me.lblNameRT.AutoSize = True
        Me.lblNameRT.BackColor = System.Drawing.Color.Transparent
        Me.lblNameRT.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameRT.Location = New System.Drawing.Point(8, 227)
        Me.lblNameRT.Name = "lblNameRT"
        Me.lblNameRT.Size = New System.Drawing.Size(89, 29)
        Me.lblNameRT.TabIndex = 24
        Me.lblNameRT.Text = "Name:"
        '
        'lblIDRT
        '
        Me.lblIDRT.AutoSize = True
        Me.lblIDRT.BackColor = System.Drawing.Color.Transparent
        Me.lblIDRT.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDRT.Location = New System.Drawing.Point(255, 32)
        Me.lblIDRT.Name = "lblIDRT"
        Me.lblIDRT.Size = New System.Drawing.Size(180, 32)
        Me.lblIDRT.TabIndex = 23
        Me.lblIDRT.Text = "ID: 00-0000"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label23.Location = New System.Drawing.Point(124, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(333, 29)
        Me.Label23.TabIndex = 21
        Me.Label23.Text = "REMOVE TEACHER INFO"
        '
        'Panel9
        '
        Me.Panel9.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.lstviewBG1
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel9.Controls.Add(Me.lstvwRemoveTeacher)
        Me.Panel9.Location = New System.Drawing.Point(6, 140)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(657, 624)
        Me.Panel9.TabIndex = 37
        '
        'lstvwRemoveTeacher
        '
        Me.lstvwRemoveTeacher.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lstvwRemoveTeacher.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstvwRemoveTeacher.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwRemoveTeacher.ForeColor = System.Drawing.SystemColors.Window
        Me.lstvwRemoveTeacher.Location = New System.Drawing.Point(0, 71)
        Me.lstvwRemoveTeacher.Name = "lstvwRemoveTeacher"
        Me.lstvwRemoveTeacher.Size = New System.Drawing.Size(654, 548)
        Me.lstvwRemoveTeacher.TabIndex = 18
        Me.lstvwRemoveTeacher.UseCompatibleStateImageBehavior = False
        '
        'btnGoBackRT
        '
        Me.btnGoBackRT.BackColor = System.Drawing.Color.Transparent
        Me.btnGoBackRT.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.btn2
        Me.btnGoBackRT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGoBackRT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGoBackRT.FlatAppearance.BorderSize = 0
        Me.btnGoBackRT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGoBackRT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGoBackRT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoBackRT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnGoBackRT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGoBackRT.Image = Global.capstoneSystem.My.Resources.Resources.Back_icon
        Me.btnGoBackRT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGoBackRT.Location = New System.Drawing.Point(1218, 3)
        Me.btnGoBackRT.Name = "btnGoBackRT"
        Me.btnGoBackRT.Size = New System.Drawing.Size(104, 33)
        Me.btnGoBackRT.TabIndex = 35
        Me.btnGoBackRT.Text = "Go Back"
        Me.btnGoBackRT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGoBackRT.UseVisualStyleBackColor = False
        '
        'tbpRecoverTeacher
        '
        Me.tbpRecoverTeacher.Controls.Add(Me.Panel10)
        Me.tbpRecoverTeacher.Location = New System.Drawing.Point(4, 22)
        Me.tbpRecoverTeacher.Name = "tbpRecoverTeacher"
        Me.tbpRecoverTeacher.Size = New System.Drawing.Size(1376, 759)
        Me.tbpRecoverTeacher.TabIndex = 4
        Me.tbpRecoverTeacher.Text = "Recover Teacher"
        Me.tbpRecoverTeacher.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel10.Controls.Add(Me.btnGoBackRCT)
        Me.Panel10.Controls.Add(Me.GroupBox5)
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Controls.Add(Me.Label32)
        Me.Panel10.Controls.Add(Me.Panel12)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1376, 759)
        Me.Panel10.TabIndex = 17
        '
        'btnGoBackRCT
        '
        Me.btnGoBackRCT.BackColor = System.Drawing.Color.Transparent
        Me.btnGoBackRCT.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.btn2
        Me.btnGoBackRCT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGoBackRCT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGoBackRCT.FlatAppearance.BorderSize = 0
        Me.btnGoBackRCT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGoBackRCT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGoBackRCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoBackRCT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnGoBackRCT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGoBackRCT.Image = Global.capstoneSystem.My.Resources.Resources.Back_icon
        Me.btnGoBackRCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGoBackRCT.Location = New System.Drawing.Point(1218, 3)
        Me.btnGoBackRCT.Name = "btnGoBackRCT"
        Me.btnGoBackRCT.Size = New System.Drawing.Size(104, 33)
        Me.btnGoBackRCT.TabIndex = 36
        Me.btnGoBackRCT.Text = "Go Back"
        Me.btnGoBackRCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGoBackRCT.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.ComboBox1)
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox5.Location = New System.Drawing.Point(11, 62)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(649, 68)
        Me.GroupBox5.TabIndex = 21
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "FILTERS"
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Image = Global.capstoneSystem.My.Resources.Resources.ClearSort_icon
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(494, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 48)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "Clear Filter"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(297, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 20)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "Position:"
        '
        'ComboBox1
        '
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Male", "Female"})
        Me.ComboBox1.Location = New System.Drawing.Point(301, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(178, 36)
        Me.ComboBox1.TabIndex = 46
        '
        'Panel11
        '
        Me.Panel11.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.white_roundedBorder
        Me.Panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel11.Controls.Add(Me.btnRecoverTeacherRCT)
        Me.Panel11.Controls.Add(Me.picbProfileRCT)
        Me.Panel11.Controls.Add(Me.lblPositionRCT)
        Me.Panel11.Controls.Add(Me.lblSexRCT)
        Me.Panel11.Controls.Add(Me.lblNameRCT)
        Me.Panel11.Controls.Add(Me.lblIDRCT)
        Me.Panel11.Controls.Add(Me.Label31)
        Me.Panel11.Location = New System.Drawing.Point(765, 136)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(574, 534)
        Me.Panel11.TabIndex = 20
        '
        'btnRecoverTeacherRCT
        '
        Me.btnRecoverTeacherRCT.BackColor = System.Drawing.Color.Transparent
        Me.btnRecoverTeacherRCT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecoverTeacherRCT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRecoverTeacherRCT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnRecoverTeacherRCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecoverTeacherRCT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecoverTeacherRCT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRecoverTeacherRCT.Image = Global.capstoneSystem.My.Resources.Resources.Refresh_icon
        Me.btnRecoverTeacherRCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecoverTeacherRCT.Location = New System.Drawing.Point(199, 460)
        Me.btnRecoverTeacherRCT.Name = "btnRecoverTeacherRCT"
        Me.btnRecoverTeacherRCT.Size = New System.Drawing.Size(211, 51)
        Me.btnRecoverTeacherRCT.TabIndex = 53
        Me.btnRecoverTeacherRCT.Text = "Recover Teacher"
        Me.btnRecoverTeacherRCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRecoverTeacherRCT.UseVisualStyleBackColor = False
        '
        'picbProfileRCT
        '
        Me.picbProfileRCT.BackColor = System.Drawing.SystemColors.Control
        Me.picbProfileRCT.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.User_icon
        Me.picbProfileRCT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picbProfileRCT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picbProfileRCT.Location = New System.Drawing.Point(28, 32)
        Me.picbProfileRCT.Name = "picbProfileRCT"
        Me.picbProfileRCT.Size = New System.Drawing.Size(221, 191)
        Me.picbProfileRCT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbProfileRCT.TabIndex = 34
        Me.picbProfileRCT.TabStop = False
        '
        'lblPositionRCT
        '
        Me.lblPositionRCT.AutoSize = True
        Me.lblPositionRCT.BackColor = System.Drawing.Color.Transparent
        Me.lblPositionRCT.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPositionRCT.Location = New System.Drawing.Point(7, 256)
        Me.lblPositionRCT.Name = "lblPositionRCT"
        Me.lblPositionRCT.Size = New System.Drawing.Size(150, 32)
        Me.lblPositionRCT.TabIndex = 26
        Me.lblPositionRCT.Text = "Position:"
        '
        'lblSexRCT
        '
        Me.lblSexRCT.AutoSize = True
        Me.lblSexRCT.BackColor = System.Drawing.Color.Transparent
        Me.lblSexRCT.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexRCT.Location = New System.Drawing.Point(7, 288)
        Me.lblSexRCT.Name = "lblSexRCT"
        Me.lblSexRCT.Size = New System.Drawing.Size(75, 32)
        Me.lblSexRCT.TabIndex = 25
        Me.lblSexRCT.Text = "Sex:"
        '
        'lblNameRCT
        '
        Me.lblNameRCT.AutoSize = True
        Me.lblNameRCT.BackColor = System.Drawing.Color.Transparent
        Me.lblNameRCT.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameRCT.Location = New System.Drawing.Point(8, 227)
        Me.lblNameRCT.Name = "lblNameRCT"
        Me.lblNameRCT.Size = New System.Drawing.Size(89, 29)
        Me.lblNameRCT.TabIndex = 24
        Me.lblNameRCT.Text = "Name:"
        '
        'lblIDRCT
        '
        Me.lblIDRCT.AutoSize = True
        Me.lblIDRCT.BackColor = System.Drawing.Color.Transparent
        Me.lblIDRCT.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDRCT.Location = New System.Drawing.Point(255, 32)
        Me.lblIDRCT.Name = "lblIDRCT"
        Me.lblIDRCT.Size = New System.Drawing.Size(180, 32)
        Me.lblIDRCT.TabIndex = 23
        Me.lblIDRCT.Text = "ID: 00-0000"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label31.Location = New System.Drawing.Point(127, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(346, 29)
        Me.Label31.TabIndex = 21
        Me.Label31.Text = "RECOVER TEACHER INFO"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label32.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Orange
        Me.Label32.Location = New System.Drawing.Point(82, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(414, 59)
        Me.Label32.TabIndex = 17
        Me.Label32.Text = "TEACHER LIST"
        '
        'Panel12
        '
        Me.Panel12.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.lstviewBG1
        Me.Panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel12.Controls.Add(Me.lstvwRecoverTeacher)
        Me.Panel12.Location = New System.Drawing.Point(3, 136)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(657, 624)
        Me.Panel12.TabIndex = 19
        '
        'lstvwRecoverTeacher
        '
        Me.lstvwRecoverTeacher.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lstvwRecoverTeacher.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstvwRecoverTeacher.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwRecoverTeacher.ForeColor = System.Drawing.SystemColors.Window
        Me.lstvwRecoverTeacher.Location = New System.Drawing.Point(0, 71)
        Me.lstvwRecoverTeacher.Name = "lstvwRecoverTeacher"
        Me.lstvwRecoverTeacher.Size = New System.Drawing.Size(654, 513)
        Me.lstvwRecoverTeacher.TabIndex = 18
        Me.lstvwRecoverTeacher.UseCompatibleStateImageBehavior = False
        '
        'StatusToolStripMenuItem
        '
        Me.StatusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABSENTToolStripMenuItem, Me.LATEToolStripMenuItem, Me.ONTIMEToolStripMenuItem, Me.ONBREAKToolStripMenuItem})
        Me.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem"
        Me.StatusToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.StatusToolStripMenuItem.Text = "Status"
        '
        'ABSENTToolStripMenuItem
        '
        Me.ABSENTToolStripMenuItem.Name = "ABSENTToolStripMenuItem"
        Me.ABSENTToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ABSENTToolStripMenuItem.Text = "ABSENT"
        '
        'LATEToolStripMenuItem
        '
        Me.LATEToolStripMenuItem.Name = "LATEToolStripMenuItem"
        Me.LATEToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.LATEToolStripMenuItem.Text = "LATE"
        '
        'ONTIMEToolStripMenuItem
        '
        Me.ONTIMEToolStripMenuItem.Name = "ONTIMEToolStripMenuItem"
        Me.ONTIMEToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ONTIMEToolStripMenuItem.Text = "ON-TIME"
        '
        'ONBREAKToolStripMenuItem
        '
        Me.ONBREAKToolStripMenuItem.Name = "ONBREAKToolStripMenuItem"
        Me.ONBREAKToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ONBREAKToolStripMenuItem.Text = "ON-BREAK"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(106, 22)
        Me.ToolStripMenuItem1.Text = "Status"
        '
        'ToolStripMenuItem31
        '
        Me.ToolStripMenuItem31.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem32, Me.ToolStripMenuItem33, Me.ToolStripMenuItem34})
        Me.ToolStripMenuItem31.Image = Global.capstoneSystem.My.Resources.Resources.Filter_Filled_icon
        Me.ToolStripMenuItem31.Name = "ToolStripMenuItem31"
        Me.ToolStripMenuItem31.Size = New System.Drawing.Size(135, 41)
        Me.ToolStripMenuItem31.Text = "Sort by:"
        '
        'ToolStripMenuItem32
        '
        Me.ToolStripMenuItem32.Image = Global.capstoneSystem.My.Resources.Resources.ascending_icon
        Me.ToolStripMenuItem32.Name = "ToolStripMenuItem32"
        Me.ToolStripMenuItem32.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItem32.Text = "Ascending"
        '
        'ToolStripMenuItem33
        '
        Me.ToolStripMenuItem33.Image = Global.capstoneSystem.My.Resources.Resources.descending_icon
        Me.ToolStripMenuItem33.Name = "ToolStripMenuItem33"
        Me.ToolStripMenuItem33.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItem33.Text = "Descending"
        '
        'ToolStripMenuItem34
        '
        Me.ToolStripMenuItem34.Image = Global.capstoneSystem.My.Resources.Resources.ClearSort_icon
        Me.ToolStripMenuItem34.Name = "ToolStripMenuItem34"
        Me.ToolStripMenuItem34.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItem34.Text = "Clear Sort"
        '
        'ToolStripMenuItem35
        '
        Me.ToolStripMenuItem35.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem36, Me.GenderToolStripMenuItem})
        Me.ToolStripMenuItem35.Image = Global.capstoneSystem.My.Resources.Resources.filter_variant_icon
        Me.ToolStripMenuItem35.Name = "ToolStripMenuItem35"
        Me.ToolStripMenuItem35.Size = New System.Drawing.Size(146, 41)
        Me.ToolStripMenuItem35.Text = "Filter by:"
        '
        'ToolStripMenuItem36
        '
        Me.ToolStripMenuItem36.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem37, Me.ToolStripMenuItem38})
        Me.ToolStripMenuItem36.Name = "ToolStripMenuItem36"
        Me.ToolStripMenuItem36.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem36.Text = "Status"
        '
        'ToolStripMenuItem37
        '
        Me.ToolStripMenuItem37.Name = "ToolStripMenuItem37"
        Me.ToolStripMenuItem37.Size = New System.Drawing.Size(124, 22)
        Me.ToolStripMenuItem37.Text = "Active"
        '
        'ToolStripMenuItem38
        '
        Me.ToolStripMenuItem38.Name = "ToolStripMenuItem38"
        Me.ToolStripMenuItem38.Size = New System.Drawing.Size(124, 22)
        Me.ToolStripMenuItem38.Text = "On-Break"
        '
        'GenderToolStripMenuItem
        '
        Me.GenderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaleToolStripMenuItem1, Me.FemaleToolStripMenuItem1})
        Me.GenderToolStripMenuItem.Name = "GenderToolStripMenuItem"
        Me.GenderToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.GenderToolStripMenuItem.Text = "Gender"
        '
        'MaleToolStripMenuItem1
        '
        Me.MaleToolStripMenuItem1.Name = "MaleToolStripMenuItem1"
        Me.MaleToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.MaleToolStripMenuItem1.Text = "Male"
        '
        'FemaleToolStripMenuItem1
        '
        Me.FemaleToolStripMenuItem1.Name = "FemaleToolStripMenuItem1"
        Me.FemaleToolStripMenuItem1.Size = New System.Drawing.Size(112, 22)
        Me.FemaleToolStripMenuItem1.Text = "Female"
        '
        'ToolStripMenuItem39
        '
        Me.ToolStripMenuItem39.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem40, Me.ToolStripMenuItem41, Me.ToolStripMenuItem42})
        Me.ToolStripMenuItem39.Image = Global.capstoneSystem.My.Resources.Resources.Filter_Filled_icon
        Me.ToolStripMenuItem39.Name = "ToolStripMenuItem39"
        Me.ToolStripMenuItem39.Size = New System.Drawing.Size(135, 41)
        Me.ToolStripMenuItem39.Text = "Sort by:"
        '
        'ToolStripMenuItem40
        '
        Me.ToolStripMenuItem40.Image = Global.capstoneSystem.My.Resources.Resources.ascending_icon
        Me.ToolStripMenuItem40.Name = "ToolStripMenuItem40"
        Me.ToolStripMenuItem40.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItem40.Text = "Ascending"
        '
        'ToolStripMenuItem41
        '
        Me.ToolStripMenuItem41.Image = Global.capstoneSystem.My.Resources.Resources.descending_icon
        Me.ToolStripMenuItem41.Name = "ToolStripMenuItem41"
        Me.ToolStripMenuItem41.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItem41.Text = "Descending"
        '
        'ToolStripMenuItem42
        '
        Me.ToolStripMenuItem42.Image = Global.capstoneSystem.My.Resources.Resources.ClearSort_icon
        Me.ToolStripMenuItem42.Name = "ToolStripMenuItem42"
        Me.ToolStripMenuItem42.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItem42.Text = "Clear Sort"
        '
        'ToolStripMenuItem43
        '
        Me.ToolStripMenuItem43.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem44, Me.ToolStripMenuItem47})
        Me.ToolStripMenuItem43.Image = Global.capstoneSystem.My.Resources.Resources.filter_variant_icon
        Me.ToolStripMenuItem43.Name = "ToolStripMenuItem43"
        Me.ToolStripMenuItem43.Size = New System.Drawing.Size(146, 41)
        Me.ToolStripMenuItem43.Text = "Filter by:"
        '
        'ToolStripMenuItem44
        '
        Me.ToolStripMenuItem44.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem45, Me.ToolStripMenuItem46})
        Me.ToolStripMenuItem44.Name = "ToolStripMenuItem44"
        Me.ToolStripMenuItem44.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem44.Text = "Status"
        '
        'ToolStripMenuItem45
        '
        Me.ToolStripMenuItem45.Name = "ToolStripMenuItem45"
        Me.ToolStripMenuItem45.Size = New System.Drawing.Size(124, 22)
        Me.ToolStripMenuItem45.Text = "Active"
        '
        'ToolStripMenuItem46
        '
        Me.ToolStripMenuItem46.Name = "ToolStripMenuItem46"
        Me.ToolStripMenuItem46.Size = New System.Drawing.Size(124, 22)
        Me.ToolStripMenuItem46.Text = "On-Break"
        '
        'ToolStripMenuItem47
        '
        Me.ToolStripMenuItem47.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem48, Me.ToolStripMenuItem49})
        Me.ToolStripMenuItem47.Name = "ToolStripMenuItem47"
        Me.ToolStripMenuItem47.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem47.Text = "Gender"
        '
        'ToolStripMenuItem48
        '
        Me.ToolStripMenuItem48.Name = "ToolStripMenuItem48"
        Me.ToolStripMenuItem48.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem48.Text = "Male"
        '
        'ToolStripMenuItem49
        '
        Me.ToolStripMenuItem49.Name = "ToolStripMenuItem49"
        Me.ToolStripMenuItem49.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem49.Text = "Female"
        '
        'ToolStripMenuItem50
        '
        Me.ToolStripMenuItem50.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem51, Me.ToolStripMenuItem52, Me.ToolStripMenuItem53})
        Me.ToolStripMenuItem50.Image = Global.capstoneSystem.My.Resources.Resources.Filter_Filled_icon
        Me.ToolStripMenuItem50.Name = "ToolStripMenuItem50"
        Me.ToolStripMenuItem50.Size = New System.Drawing.Size(135, 41)
        Me.ToolStripMenuItem50.Text = "Sort by:"
        '
        'ToolStripMenuItem51
        '
        Me.ToolStripMenuItem51.Image = Global.capstoneSystem.My.Resources.Resources.ascending_icon
        Me.ToolStripMenuItem51.Name = "ToolStripMenuItem51"
        Me.ToolStripMenuItem51.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItem51.Text = "Ascending"
        '
        'ToolStripMenuItem52
        '
        Me.ToolStripMenuItem52.Image = Global.capstoneSystem.My.Resources.Resources.descending_icon
        Me.ToolStripMenuItem52.Name = "ToolStripMenuItem52"
        Me.ToolStripMenuItem52.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItem52.Text = "Descending"
        '
        'ToolStripMenuItem53
        '
        Me.ToolStripMenuItem53.Image = Global.capstoneSystem.My.Resources.Resources.ClearSort_icon
        Me.ToolStripMenuItem53.Name = "ToolStripMenuItem53"
        Me.ToolStripMenuItem53.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItem53.Text = "Clear Sort"
        '
        'ToolStripMenuItem54
        '
        Me.ToolStripMenuItem54.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem55, Me.ToolStripMenuItem58})
        Me.ToolStripMenuItem54.Image = Global.capstoneSystem.My.Resources.Resources.filter_variant_icon
        Me.ToolStripMenuItem54.Name = "ToolStripMenuItem54"
        Me.ToolStripMenuItem54.Size = New System.Drawing.Size(146, 41)
        Me.ToolStripMenuItem54.Text = "Filter by:"
        '
        'ToolStripMenuItem55
        '
        Me.ToolStripMenuItem55.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem56, Me.ToolStripMenuItem57})
        Me.ToolStripMenuItem55.Name = "ToolStripMenuItem55"
        Me.ToolStripMenuItem55.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem55.Text = "Status"
        '
        'ToolStripMenuItem56
        '
        Me.ToolStripMenuItem56.Name = "ToolStripMenuItem56"
        Me.ToolStripMenuItem56.Size = New System.Drawing.Size(124, 22)
        Me.ToolStripMenuItem56.Text = "Active"
        '
        'ToolStripMenuItem57
        '
        Me.ToolStripMenuItem57.Name = "ToolStripMenuItem57"
        Me.ToolStripMenuItem57.Size = New System.Drawing.Size(124, 22)
        Me.ToolStripMenuItem57.Text = "On-Break"
        '
        'ToolStripMenuItem58
        '
        Me.ToolStripMenuItem58.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem59, Me.ToolStripMenuItem60})
        Me.ToolStripMenuItem58.Name = "ToolStripMenuItem58"
        Me.ToolStripMenuItem58.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem58.Text = "Gender"
        '
        'ToolStripMenuItem59
        '
        Me.ToolStripMenuItem59.Name = "ToolStripMenuItem59"
        Me.ToolStripMenuItem59.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem59.Text = "Male"
        '
        'ToolStripMenuItem60
        '
        Me.ToolStripMenuItem60.Name = "ToolStripMenuItem60"
        Me.ToolStripMenuItem60.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem60.Text = "Female"
        '
        'ToolStripMenuItem61
        '
        Me.ToolStripMenuItem61.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem62, Me.ToolStripMenuItem63, Me.ToolStripMenuItem64})
        Me.ToolStripMenuItem61.Image = Global.capstoneSystem.My.Resources.Resources.Filter_Filled_icon
        Me.ToolStripMenuItem61.Name = "ToolStripMenuItem61"
        Me.ToolStripMenuItem61.Size = New System.Drawing.Size(135, 41)
        Me.ToolStripMenuItem61.Text = "Sort by:"
        '
        'ToolStripMenuItem62
        '
        Me.ToolStripMenuItem62.Image = Global.capstoneSystem.My.Resources.Resources.ascending_icon
        Me.ToolStripMenuItem62.Name = "ToolStripMenuItem62"
        Me.ToolStripMenuItem62.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItem62.Text = "Ascending"
        '
        'ToolStripMenuItem63
        '
        Me.ToolStripMenuItem63.Image = Global.capstoneSystem.My.Resources.Resources.descending_icon
        Me.ToolStripMenuItem63.Name = "ToolStripMenuItem63"
        Me.ToolStripMenuItem63.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItem63.Text = "Descending"
        '
        'ToolStripMenuItem64
        '
        Me.ToolStripMenuItem64.Image = Global.capstoneSystem.My.Resources.Resources.ClearSort_icon
        Me.ToolStripMenuItem64.Name = "ToolStripMenuItem64"
        Me.ToolStripMenuItem64.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItem64.Text = "Clear Sort"
        '
        'ToolStripMenuItem65
        '
        Me.ToolStripMenuItem65.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem69})
        Me.ToolStripMenuItem65.Image = Global.capstoneSystem.My.Resources.Resources.filter_variant_icon
        Me.ToolStripMenuItem65.Name = "ToolStripMenuItem65"
        Me.ToolStripMenuItem65.Size = New System.Drawing.Size(146, 41)
        Me.ToolStripMenuItem65.Text = "Filter by:"
        '
        'ToolStripMenuItem69
        '
        Me.ToolStripMenuItem69.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem70, Me.ToolStripMenuItem71})
        Me.ToolStripMenuItem69.Name = "ToolStripMenuItem69"
        Me.ToolStripMenuItem69.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem69.Text = "Gender"
        '
        'ToolStripMenuItem70
        '
        Me.ToolStripMenuItem70.Name = "ToolStripMenuItem70"
        Me.ToolStripMenuItem70.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem70.Text = "Male"
        '
        'ToolStripMenuItem71
        '
        Me.ToolStripMenuItem71.Name = "ToolStripMenuItem71"
        Me.ToolStripMenuItem71.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem71.Text = "Female"
        '
        'FilterToolStripMenuItem
        '
        Me.FilterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AToolStripMenuItem, Me.DescendingToolStripMenuItem1, Me.ClearSortToolStripMenuItem})
        Me.FilterToolStripMenuItem.Image = Global.capstoneSystem.My.Resources.Resources.Filter_Filled_icon
        Me.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem"
        Me.FilterToolStripMenuItem.Size = New System.Drawing.Size(135, 41)
        Me.FilterToolStripMenuItem.Text = "Sort by:"
        '
        'AToolStripMenuItem
        '
        Me.AToolStripMenuItem.Image = Global.capstoneSystem.My.Resources.Resources.ascending_icon
        Me.AToolStripMenuItem.Name = "AToolStripMenuItem"
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.AToolStripMenuItem.Text = "Ascending"
        '
        'DescendingToolStripMenuItem1
        '
        Me.DescendingToolStripMenuItem1.Image = Global.capstoneSystem.My.Resources.Resources.descending_icon
        Me.DescendingToolStripMenuItem1.Name = "DescendingToolStripMenuItem1"
        Me.DescendingToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.DescendingToolStripMenuItem1.Text = "Descending"
        '
        'ClearSortToolStripMenuItem
        '
        Me.ClearSortToolStripMenuItem.Image = Global.capstoneSystem.My.Resources.Resources.ClearSort_icon
        Me.ClearSortToolStripMenuItem.Name = "ClearSortToolStripMenuItem"
        Me.ClearSortToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ClearSortToolStripMenuItem.Text = "Clear Sort"
        '
        'FilterByToolStripMenuItem
        '
        Me.FilterByToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem6, Me.SexToolStripMenuItem})
        Me.FilterByToolStripMenuItem.Image = Global.capstoneSystem.My.Resources.Resources.filter_variant_icon
        Me.FilterByToolStripMenuItem.Name = "FilterByToolStripMenuItem"
        Me.FilterByToolStripMenuItem.Size = New System.Drawing.Size(146, 41)
        Me.FilterByToolStripMenuItem.Text = "Filter by:"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.ToolStripMenuItem8})
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem6.Text = "Status"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(132, 22)
        Me.ToolStripMenuItem7.Text = "ACTIVE"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(132, 22)
        Me.ToolStripMenuItem8.Text = "ON-BREAK"
        '
        'SexToolStripMenuItem
        '
        Me.SexToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaleToolStripMenuItem, Me.FemaleToolStripMenuItem})
        Me.SexToolStripMenuItem.Name = "SexToolStripMenuItem"
        Me.SexToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.SexToolStripMenuItem.Text = "Gender"
        '
        'MaleToolStripMenuItem
        '
        Me.MaleToolStripMenuItem.Name = "MaleToolStripMenuItem"
        Me.MaleToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.MaleToolStripMenuItem.Text = "Male"
        '
        'FemaleToolStripMenuItem
        '
        Me.FemaleToolStripMenuItem.Name = "FemaleToolStripMenuItem"
        Me.FemaleToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.FemaleToolStripMenuItem.Text = "Female"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem10, Me.ToolStripMenuItem11, Me.ToolStripMenuItem12})
        Me.ToolStripMenuItem9.Image = Global.capstoneSystem.My.Resources.Resources.Filter_Filled_icon
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(135, 41)
        Me.ToolStripMenuItem9.Text = "Sort by:"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Image = Global.capstoneSystem.My.Resources.Resources.ascending_icon
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItem10.Text = "Ascending"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Image = Global.capstoneSystem.My.Resources.Resources.descending_icon
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItem11.Text = "Descending"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Image = Global.capstoneSystem.My.Resources.Resources.ClearSort_icon
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItem12.Text = "Clear Sort"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem14, Me.ToolStripMenuItem17})
        Me.ToolStripMenuItem13.Image = Global.capstoneSystem.My.Resources.Resources.filter_variant_icon
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(146, 41)
        Me.ToolStripMenuItem13.Text = "Filter by:"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem15, Me.ToolStripMenuItem16})
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem14.Text = "Status"
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(132, 22)
        Me.ToolStripMenuItem15.Text = "ACTIVE"
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(132, 22)
        Me.ToolStripMenuItem16.Text = "ON-BREAK"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem18, Me.ToolStripMenuItem19})
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem17.Text = "Gender"
        '
        'ToolStripMenuItem18
        '
        Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
        Me.ToolStripMenuItem18.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem18.Text = "Male"
        '
        'ToolStripMenuItem19
        '
        Me.ToolStripMenuItem19.Name = "ToolStripMenuItem19"
        Me.ToolStripMenuItem19.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem19.Text = "Female"
        '
        'ToolStripMenuItem20
        '
        Me.ToolStripMenuItem20.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem21, Me.ToolStripMenuItem22, Me.ToolStripMenuItem23})
        Me.ToolStripMenuItem20.Image = Global.capstoneSystem.My.Resources.Resources.Filter_Filled_icon
        Me.ToolStripMenuItem20.Name = "ToolStripMenuItem20"
        Me.ToolStripMenuItem20.Size = New System.Drawing.Size(135, 41)
        Me.ToolStripMenuItem20.Text = "Sort by:"
        '
        'ToolStripMenuItem21
        '
        Me.ToolStripMenuItem21.Image = Global.capstoneSystem.My.Resources.Resources.ascending_icon
        Me.ToolStripMenuItem21.Name = "ToolStripMenuItem21"
        Me.ToolStripMenuItem21.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItem21.Text = "Ascending"
        '
        'ToolStripMenuItem22
        '
        Me.ToolStripMenuItem22.Image = Global.capstoneSystem.My.Resources.Resources.descending_icon
        Me.ToolStripMenuItem22.Name = "ToolStripMenuItem22"
        Me.ToolStripMenuItem22.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItem22.Text = "Descending"
        '
        'ToolStripMenuItem23
        '
        Me.ToolStripMenuItem23.Image = Global.capstoneSystem.My.Resources.Resources.ClearSort_icon
        Me.ToolStripMenuItem23.Name = "ToolStripMenuItem23"
        Me.ToolStripMenuItem23.Size = New System.Drawing.Size(136, 22)
        Me.ToolStripMenuItem23.Text = "Clear Sort"
        '
        'ToolStripMenuItem24
        '
        Me.ToolStripMenuItem24.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem25, Me.ToolStripMenuItem28})
        Me.ToolStripMenuItem24.Image = Global.capstoneSystem.My.Resources.Resources.filter_variant_icon
        Me.ToolStripMenuItem24.Name = "ToolStripMenuItem24"
        Me.ToolStripMenuItem24.Size = New System.Drawing.Size(146, 41)
        Me.ToolStripMenuItem24.Text = "Filter by:"
        '
        'ToolStripMenuItem25
        '
        Me.ToolStripMenuItem25.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem26, Me.ToolStripMenuItem27})
        Me.ToolStripMenuItem25.Name = "ToolStripMenuItem25"
        Me.ToolStripMenuItem25.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem25.Text = "Status"
        '
        'ToolStripMenuItem26
        '
        Me.ToolStripMenuItem26.Name = "ToolStripMenuItem26"
        Me.ToolStripMenuItem26.Size = New System.Drawing.Size(132, 22)
        Me.ToolStripMenuItem26.Text = "ACTIVE"
        '
        'ToolStripMenuItem27
        '
        Me.ToolStripMenuItem27.Name = "ToolStripMenuItem27"
        Me.ToolStripMenuItem27.Size = New System.Drawing.Size(132, 22)
        Me.ToolStripMenuItem27.Text = "ON-BREAK"
        '
        'ToolStripMenuItem28
        '
        Me.ToolStripMenuItem28.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem29, Me.ToolStripMenuItem30})
        Me.ToolStripMenuItem28.Name = "ToolStripMenuItem28"
        Me.ToolStripMenuItem28.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem28.Text = "Gender"
        '
        'ToolStripMenuItem29
        '
        Me.ToolStripMenuItem29.Name = "ToolStripMenuItem29"
        Me.ToolStripMenuItem29.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem29.Text = "Male"
        '
        'ToolStripMenuItem30
        '
        Me.ToolStripMenuItem30.Name = "ToolStripMenuItem30"
        Me.ToolStripMenuItem30.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem30.Text = "Female"
        '
        'frmAdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmAdminMenu"
        Me.Text = "Admin Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tlp.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tbpTeacherList.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.picbBarcodeTL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.tbpEditTeacher.ResumeLayout(False)
        Me.tbpEditTeacher.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.pcbProfileET, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.tbpAddTeacher.ResumeLayout(False)
        Me.tbpAddTeacher.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.pcbTProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.pcbBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tbpRemoveTeacher.ResumeLayout(False)
        Me.tbpRemoveTeacher.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.picbProfileRT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.tbpRecoverTeacher.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.picbProfileRCT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlp As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnMainPage As System.Windows.Forms.Button
    Friend WithEvents btnEditTeacher As System.Windows.Forms.Button
    Friend WithEvents btnRemoveTeacher As System.Windows.Forms.Button
    Friend WithEvents btnAddTeacher As System.Windows.Forms.Button
    Friend WithEvents tmrOpenMenu As System.Windows.Forms.Timer
    Friend WithEvents tmrCloseMenu As System.Windows.Forms.Timer
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbpTeacherList As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pcbProfile As System.Windows.Forms.PictureBox
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstvwTeacherList As System.Windows.Forms.ListView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents tbpEditTeacher As System.Windows.Forms.TabPage
    Friend WithEvents tbpAddTeacher As System.Windows.Forms.TabPage
    Friend WithEvents btnGoBackANT As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblTpassword As System.Windows.Forms.Label
    Friend WithEvents lblTusername As System.Windows.Forms.Label
    Friend WithEvents lblTposition As System.Windows.Forms.Label
    Friend WithEvents lblTsex As System.Windows.Forms.Label
    Friend WithEvents pcbTProfile As System.Windows.Forms.PictureBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblTname As System.Windows.Forms.Label
    Friend WithEvents txtTphotoPath As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnBrowseFile As System.Windows.Forms.Button
    Friend WithEvents txtNpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNusername As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMale As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNfirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNmiddlename As System.Windows.Forms.TextBox
    Friend WithEvents txtNlastname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAddnewTeacher As System.Windows.Forms.Button
    Friend WithEvents btnGoBackET As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents pcbProfileET As System.Windows.Forms.PictureBox
    Friend WithEvents lblPositionET As System.Windows.Forms.Label
    Friend WithEvents lblSexET As System.Windows.Forms.Label
    Friend WithEvents lblNameET As System.Windows.Forms.Label
    Friend WithEvents lblIDET As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lstvwEditTeacher As System.Windows.Forms.ListView
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnMakeChangesET As System.Windows.Forms.Button
    Friend WithEvents cmbSexET As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtFirstNET As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtMiddleNET As System.Windows.Forms.TextBox
    Friend WithEvents txtLastNET As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveEditET As System.Windows.Forms.Button
    Friend WithEvents btnEditProfileET As System.Windows.Forms.Button
    Friend WithEvents lblFilePathHolderET As System.Windows.Forms.Label
    Friend WithEvents lblLastSelectholder As System.Windows.Forms.Label
    Friend WithEvents lblmnholder As System.Windows.Forms.Label
    Friend WithEvents lblfnholder As System.Windows.Forms.Label
    Friend WithEvents lbllnholder As System.Windows.Forms.Label
    Friend WithEvents cmbNposition As System.Windows.Forms.ComboBox
    Friend WithEvents tbpRemoveTeacher As System.Windows.Forms.TabPage
    Friend WithEvents btnGoBackRT As System.Windows.Forms.Button
    Friend WithEvents cmbPostionET As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents picbProfileRT As System.Windows.Forms.PictureBox
    Friend WithEvents lblPositionRT As System.Windows.Forms.Label
    Friend WithEvents lblSexRT As System.Windows.Forms.Label
    Friend WithEvents lblNameRT As System.Windows.Forms.Label
    Friend WithEvents lblIDRT As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents lstvwRemoveTeacher As System.Windows.Forms.ListView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents StatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABSENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LATEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ONTIMEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ONBREAKToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescendingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearSortToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilterByToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FemaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cmbPositionFilterTL As System.Windows.Forms.ComboBox
    Friend WithEvents btnClearFilterTL As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClearFilterET As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents cmbPositionFilterET As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem17 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem18 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem19 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClearFilterRT As System.Windows.Forms.Button
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cmbPositionFilterRT As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripMenuItem20 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem21 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem22 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem23 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem24 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem25 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem26 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem27 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem28 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem29 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem30 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRemoveTeacherRT As System.Windows.Forms.Button
    Friend WithEvents btnRecoverTeacher As System.Windows.Forms.Button
    Friend WithEvents tbpRecoverTeacher As System.Windows.Forms.TabPage
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents picbProfileRCT As System.Windows.Forms.PictureBox
    Friend WithEvents lblPositionRCT As System.Windows.Forms.Label
    Friend WithEvents lblSexRCT As System.Windows.Forms.Label
    Friend WithEvents lblNameRCT As System.Windows.Forms.Label
    Friend WithEvents lblIDRCT As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents lstvwRecoverTeacher As System.Windows.Forms.ListView
    Friend WithEvents ToolStripMenuItem31 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem32 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem33 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem34 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem35 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem36 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem37 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem38 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaleToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FemaleToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem39 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem40 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem41 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem42 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem43 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem44 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem45 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem46 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem47 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem48 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem49 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem50 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem51 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem52 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem53 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem54 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem55 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem56 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem57 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem58 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem59 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem60 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem61 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem62 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem63 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem64 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem65 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem69 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem70 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem71 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRecoverTeacherRCT As System.Windows.Forms.Button
    Friend WithEvents btnGoBackRCT As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents pcbBarcode As System.Windows.Forms.PictureBox
    Friend WithEvents btnGenerateBarcode As System.Windows.Forms.Button
    Friend WithEvents btnChangeAccount As System.Windows.Forms.Button
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents btnPrintBarcode As System.Windows.Forms.Button
    Friend WithEvents lblTBarcode As System.Windows.Forms.Label
    Friend WithEvents btnBMPBarcode As System.Windows.Forms.Button
    Friend WithEvents lblBarcodeTL As System.Windows.Forms.Label
    Friend WithEvents picbBarcodeTL As System.Windows.Forms.PictureBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnResetpassET As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
End Class
