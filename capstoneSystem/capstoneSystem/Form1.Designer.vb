<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblForgotPassword = New System.Windows.Forms.Label
        Me.lblInvalidUsername = New System.Windows.Forms.Label
        Me.lblInvalidPassword = New System.Windows.Forms.Label
        Me.lblInvalid = New System.Windows.Forms.Label
        Me.tmrLoginRestrict = New System.Windows.Forms.Timer(Me.components)
        Me.btnLogin = New System.Windows.Forms.Button
        Me.rdbClockIn = New System.Windows.Forms.RadioButton
        Me.rdbLogIn = New System.Windows.Forms.RadioButton
        Me.grbLoginType = New System.Windows.Forms.GroupBox
        Me.tmrDBcheckerUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.txtBarcodeReader = New System.Windows.Forms.TextBox
        Me.grbLoginType.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(852, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUsername.Location = New System.Drawing.Point(858, 309)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(371, 62)
        Me.txtUsername.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(858, 432)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(371, 62)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(852, 386)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'lblForgotPassword
        '
        Me.lblForgotPassword.AutoSize = True
        Me.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblForgotPassword.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForgotPassword.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblForgotPassword.Location = New System.Drawing.Point(1083, 497)
        Me.lblForgotPassword.Name = "lblForgotPassword"
        Me.lblForgotPassword.Size = New System.Drawing.Size(146, 21)
        Me.lblForgotPassword.TabIndex = 4
        Me.lblForgotPassword.Text = "Forgot password?"
        '
        'lblInvalidUsername
        '
        Me.lblInvalidUsername.AutoSize = True
        Me.lblInvalidUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidUsername.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidUsername.Location = New System.Drawing.Point(862, 294)
        Me.lblInvalidUsername.Name = "lblInvalidUsername"
        Me.lblInvalidUsername.Size = New System.Drawing.Size(132, 20)
        Me.lblInvalidUsername.TabIndex = 6
        Me.lblInvalidUsername.Text = "Invalid Username"
        Me.lblInvalidUsername.Visible = False
        '
        'lblInvalidPassword
        '
        Me.lblInvalidPassword.AutoSize = True
        Me.lblInvalidPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalidPassword.ForeColor = System.Drawing.Color.Red
        Me.lblInvalidPassword.Location = New System.Drawing.Point(862, 417)
        Me.lblInvalidPassword.Name = "lblInvalidPassword"
        Me.lblInvalidPassword.Size = New System.Drawing.Size(127, 20)
        Me.lblInvalidPassword.TabIndex = 7
        Me.lblInvalidPassword.Text = "Invalid Password"
        Me.lblInvalidPassword.Visible = False
        '
        'lblInvalid
        '
        Me.lblInvalid.AutoSize = True
        Me.lblInvalid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvalid.ForeColor = System.Drawing.Color.Red
        Me.lblInvalid.Location = New System.Drawing.Point(968, 543)
        Me.lblInvalid.Name = "lblInvalid"
        Me.lblInvalid.Size = New System.Drawing.Size(127, 20)
        Me.lblInvalid.TabIndex = 8
        Me.lblInvalid.Text = "Invalid Password"
        Me.lblInvalid.Visible = False
        '
        'tmrLoginRestrict
        '
        Me.tmrLoginRestrict.Interval = 1000
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.btn2
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Haettenschweiler", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.Location = New System.Drawing.Point(858, 566)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(371, 86)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'rdbClockIn
        '
        Me.rdbClockIn.AutoSize = True
        Me.rdbClockIn.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbClockIn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rdbClockIn.Location = New System.Drawing.Point(44, 52)
        Me.rdbClockIn.Name = "rdbClockIn"
        Me.rdbClockIn.Size = New System.Drawing.Size(147, 42)
        Me.rdbClockIn.TabIndex = 9
        Me.rdbClockIn.TabStop = True
        Me.rdbClockIn.Text = "Clock In"
        Me.rdbClockIn.UseVisualStyleBackColor = True
        '
        'rdbLogIn
        '
        Me.rdbLogIn.AutoSize = True
        Me.rdbLogIn.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbLogIn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rdbLogIn.Location = New System.Drawing.Point(262, 52)
        Me.rdbLogIn.Name = "rdbLogIn"
        Me.rdbLogIn.Size = New System.Drawing.Size(256, 42)
        Me.rdbLogIn.TabIndex = 10
        Me.rdbLogIn.TabStop = True
        Me.rdbLogIn.Text = "Attendance Log"
        Me.rdbLogIn.UseVisualStyleBackColor = True
        '
        'grbLoginType
        '
        Me.grbLoginType.BackColor = System.Drawing.Color.Transparent
        Me.grbLoginType.Controls.Add(Me.rdbClockIn)
        Me.grbLoginType.Controls.Add(Me.rdbLogIn)
        Me.grbLoginType.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbLoginType.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.grbLoginType.Location = New System.Drawing.Point(12, 645)
        Me.grbLoginType.Name = "grbLoginType"
        Me.grbLoginType.Size = New System.Drawing.Size(567, 111)
        Me.grbLoginType.TabIndex = 11
        Me.grbLoginType.TabStop = False
        Me.grbLoginType.Text = "LOGIN TYPE"
        '
        'tmrDBcheckerUpdater
        '
        Me.tmrDBcheckerUpdater.Interval = 60000
        '
        'txtBarcodeReader
        '
        Me.txtBarcodeReader.Location = New System.Drawing.Point(585, 770)
        Me.txtBarcodeReader.MaxLength = 50
        Me.txtBarcodeReader.Name = "txtBarcodeReader"
        Me.txtBarcodeReader.Size = New System.Drawing.Size(129, 20)
        Me.txtBarcodeReader.TabIndex = 12
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.loginBG1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.txtBarcodeReader)
        Me.Controls.Add(Me.grbLoginType)
        Me.Controls.Add(Me.lblForgotPassword)
        Me.Controls.Add(Me.lblInvalid)
        Me.Controls.Add(Me.lblInvalidPassword)
        Me.Controls.Add(Me.lblInvalidUsername)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Automated Attendance Logbook System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grbLoginType.ResumeLayout(False)
        Me.grbLoginType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblForgotPassword As System.Windows.Forms.Label
    Friend WithEvents lblInvalidUsername As System.Windows.Forms.Label
    Friend WithEvents lblInvalidPassword As System.Windows.Forms.Label
    Friend WithEvents lblInvalid As System.Windows.Forms.Label
    Friend WithEvents tmrLoginRestrict As System.Windows.Forms.Timer
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents rdbClockIn As System.Windows.Forms.RadioButton
    Friend WithEvents rdbLogIn As System.Windows.Forms.RadioButton
    Friend WithEvents grbLoginType As System.Windows.Forms.GroupBox
    Friend WithEvents tmrDBcheckerUpdater As System.Windows.Forms.Timer
    Friend WithEvents txtBarcodeReader As System.Windows.Forms.TextBox

End Class
