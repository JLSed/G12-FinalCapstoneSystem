<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChart
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtpDateR2 = New System.Windows.Forms.DateTimePicker
        Me.dtpDateR1 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DescendingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearSortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FilterByToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ABSENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ONTIMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ONBREAKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnClearAllFilter = New System.Windows.Forms.Button
        Me.btnMainPage = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lstvwAttendanceHistory = New System.Windows.Forms.ListView
        Me.SortByToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DescendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AscendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Orange
        Me.Label5.Location = New System.Drawing.Point(352, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(651, 59)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "ATTENDANCE HISTORY"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpDateR2)
        Me.GroupBox1.Controls.Add(Me.dtpDateR1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.MenuStrip1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnClearAllFilter)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(12, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1145, 81)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'dtpDateR2
        '
        Me.dtpDateR2.Location = New System.Drawing.Point(665, 28)
        Me.dtpDateR2.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.dtpDateR2.Name = "dtpDateR2"
        Me.dtpDateR2.Size = New System.Drawing.Size(249, 29)
        Me.dtpDateR2.TabIndex = 26
        '
        'dtpDateR1
        '
        Me.dtpDateR1.Location = New System.Drawing.Point(389, 28)
        Me.dtpDateR1.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.dtpDateR1.Name = "dtpDateR1"
        Me.dtpDateR1.Size = New System.Drawing.Size(249, 29)
        Me.dtpDateR1.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(385, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 24)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Date Range"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Highlight
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilterToolStripMenuItem, Me.FilterByToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(5, 23)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(289, 45)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
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
        Me.AToolStripMenuItem.Size = New System.Drawing.Size(233, 42)
        Me.AToolStripMenuItem.Text = "Ascending"
        '
        'DescendingToolStripMenuItem1
        '
        Me.DescendingToolStripMenuItem1.Image = Global.capstoneSystem.My.Resources.Resources.descending_icon
        Me.DescendingToolStripMenuItem1.Name = "DescendingToolStripMenuItem1"
        Me.DescendingToolStripMenuItem1.Size = New System.Drawing.Size(233, 42)
        Me.DescendingToolStripMenuItem1.Text = "Descending"
        '
        'ClearSortToolStripMenuItem
        '
        Me.ClearSortToolStripMenuItem.Image = Global.capstoneSystem.My.Resources.Resources.ClearSort_icon
        Me.ClearSortToolStripMenuItem.Name = "ClearSortToolStripMenuItem"
        Me.ClearSortToolStripMenuItem.Size = New System.Drawing.Size(233, 42)
        Me.ClearSortToolStripMenuItem.Text = "Clear Sort"
        '
        'FilterByToolStripMenuItem
        '
        Me.FilterByToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusToolStripMenuItem})
        Me.FilterByToolStripMenuItem.Image = Global.capstoneSystem.My.Resources.Resources.filter_variant_icon
        Me.FilterByToolStripMenuItem.Name = "FilterByToolStripMenuItem"
        Me.FilterByToolStripMenuItem.Size = New System.Drawing.Size(146, 41)
        Me.FilterByToolStripMenuItem.Text = "Filter by:"
        '
        'StatusToolStripMenuItem
        '
        Me.StatusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABSENTToolStripMenuItem, Me.LATEToolStripMenuItem, Me.ONTIMEToolStripMenuItem, Me.ONBREAKToolStripMenuItem})
        Me.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem"
        Me.StatusToolStripMenuItem.Size = New System.Drawing.Size(165, 42)
        Me.StatusToolStripMenuItem.Text = "Status"
        '
        'ABSENTToolStripMenuItem
        '
        Me.ABSENTToolStripMenuItem.Name = "ABSENTToolStripMenuItem"
        Me.ABSENTToolStripMenuItem.Size = New System.Drawing.Size(223, 42)
        Me.ABSENTToolStripMenuItem.Text = "ABSENT"
        '
        'LATEToolStripMenuItem
        '
        Me.LATEToolStripMenuItem.Name = "LATEToolStripMenuItem"
        Me.LATEToolStripMenuItem.Size = New System.Drawing.Size(223, 42)
        Me.LATEToolStripMenuItem.Text = "LATE"
        '
        'ONTIMEToolStripMenuItem
        '
        Me.ONTIMEToolStripMenuItem.Name = "ONTIMEToolStripMenuItem"
        Me.ONTIMEToolStripMenuItem.Size = New System.Drawing.Size(223, 42)
        Me.ONTIMEToolStripMenuItem.Text = "ON-TIME"
        '
        'ONBREAKToolStripMenuItem
        '
        Me.ONBREAKToolStripMenuItem.Name = "ONBREAKToolStripMenuItem"
        Me.ONBREAKToolStripMenuItem.Size = New System.Drawing.Size(223, 42)
        Me.ONBREAKToolStripMenuItem.Text = "ON-BREAK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(640, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 33)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "-"
        '
        'btnClearAllFilter
        '
        Me.btnClearAllFilter.FlatAppearance.BorderSize = 0
        Me.btnClearAllFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearAllFilter.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAllFilter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClearAllFilter.Image = Global.capstoneSystem.My.Resources.Resources.ClearSort_icon
        Me.btnClearAllFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClearAllFilter.Location = New System.Drawing.Point(970, 20)
        Me.btnClearAllFilter.Name = "btnClearAllFilter"
        Me.btnClearAllFilter.Size = New System.Drawing.Size(156, 48)
        Me.btnClearAllFilter.TabIndex = 28
        Me.btnClearAllFilter.Text = "Clear Filter"
        Me.btnClearAllFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClearAllFilter.UseVisualStyleBackColor = True
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
        Me.btnMainPage.Location = New System.Drawing.Point(1227, 9)
        Me.btnMainPage.Name = "btnMainPage"
        Me.btnMainPage.Size = New System.Drawing.Size(121, 33)
        Me.btnMainPage.TabIndex = 21
        Me.btnMainPage.Text = "Main Page"
        Me.btnMainPage.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnMainPage.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.white_roundedBorder
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.lstvwAttendanceHistory)
        Me.Panel1.Location = New System.Drawing.Point(12, 184)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1342, 646)
        Me.Panel1.TabIndex = 0
        '
        'lstvwAttendanceHistory
        '
        Me.lstvwAttendanceHistory.BackColor = System.Drawing.Color.White
        Me.lstvwAttendanceHistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstvwAttendanceHistory.Font = New System.Drawing.Font("Trebuchet MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwAttendanceHistory.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.lstvwAttendanceHistory.Location = New System.Drawing.Point(0, 69)
        Me.lstvwAttendanceHistory.Name = "lstvwAttendanceHistory"
        Me.lstvwAttendanceHistory.Size = New System.Drawing.Size(1336, 521)
        Me.lstvwAttendanceHistory.TabIndex = 19
        Me.lstvwAttendanceHistory.UseCompatibleStateImageBehavior = False
        '
        'SortByToolStripMenuItem
        '
        Me.SortByToolStripMenuItem.Image = Global.capstoneSystem.My.Resources.Resources.Email_icon
        Me.SortByToolStripMenuItem.Name = "SortByToolStripMenuItem"
        Me.SortByToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.SortByToolStripMenuItem.Text = "Sort by:"
        '
        'DescendingToolStripMenuItem
        '
        Me.DescendingToolStripMenuItem.Image = Global.capstoneSystem.My.Resources.Resources.ascending_icon
        Me.DescendingToolStripMenuItem.Name = "DescendingToolStripMenuItem"
        Me.DescendingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DescendingToolStripMenuItem.Text = "Ascending"
        '
        'AscendingToolStripMenuItem
        '
        Me.AscendingToolStripMenuItem.Image = Global.capstoneSystem.My.Resources.Resources.descending_icon
        Me.AscendingToolStripMenuItem.Name = "AscendingToolStripMenuItem"
        Me.AscendingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AscendingToolStripMenuItem.Text = "Descending"
        '
        'frmChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnMainPage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmChart"
        Me.Text = "Attendance History"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lstvwAttendanceHistory As System.Windows.Forms.ListView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnMainPage As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SortByToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescendingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AscendingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescendingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilterByToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearSortToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dtpDateR2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateR1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABSENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LATEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ONTIMEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ONBREAKToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClearAllFilter As System.Windows.Forms.Button
End Class
