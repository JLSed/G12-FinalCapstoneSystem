<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForgotPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmForgotPassword))
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnSearchUsername = New System.Windows.Forms.Button
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.grpbRecoverOption = New System.Windows.Forms.GroupBox
        Me.btnOTP = New System.Windows.Forms.Button
        Me.btnRequestRecovery = New System.Windows.Forms.Button
        Me.btnBackupCode = New System.Windows.Forms.Button
        Me.grpbBackupCode = New System.Windows.Forms.GroupBox
        Me.Button22 = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBackupPin4 = New System.Windows.Forms.TextBox
        Me.txtBackupPin3 = New System.Windows.Forms.TextBox
        Me.txtBackupPin2 = New System.Windows.Forms.TextBox
        Me.btnConfirmBackup = New System.Windows.Forms.Button
        Me.txtBackupPin1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpbOTP = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnVerifyOTP = New System.Windows.Forms.Button
        Me.lblRegisteredEmail = New System.Windows.Forms.Label
        Me.btnSendOTP = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtVerifyOTP = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.grpbRecoverOption.SuspendLayout()
        Me.grpbBackupCode.SuspendLayout()
        Me.grpbOTP.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(269, 52)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Enter your username to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "search for your account"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnSearchUsername)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(32, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 194)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Find your Account"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(24, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 21)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Account Found"
        Me.Label3.Visible = False
        '
        'btnSearchUsername
        '
        Me.btnSearchUsername.BackColor = System.Drawing.Color.Transparent
        Me.btnSearchUsername.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.blue_button_2
        Me.btnSearchUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearchUsername.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchUsername.FlatAppearance.BorderSize = 0
        Me.btnSearchUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchUsername.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSearchUsername.Location = New System.Drawing.Point(180, 144)
        Me.btnSearchUsername.Name = "btnSearchUsername"
        Me.btnSearchUsername.Size = New System.Drawing.Size(110, 29)
        Me.btnSearchUsername.TabIndex = 36
        Me.btnSearchUsername.Text = "Search"
        Me.btnSearchUsername.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(26, 94)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(264, 44)
        Me.txtUsername.TabIndex = 4
        '
        'grpbRecoverOption
        '
        Me.grpbRecoverOption.Controls.Add(Me.btnOTP)
        Me.grpbRecoverOption.Controls.Add(Me.btnRequestRecovery)
        Me.grpbRecoverOption.Controls.Add(Me.btnBackupCode)
        Me.grpbRecoverOption.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbRecoverOption.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.grpbRecoverOption.Location = New System.Drawing.Point(32, 212)
        Me.grpbRecoverOption.Name = "grpbRecoverOption"
        Me.grpbRecoverOption.Size = New System.Drawing.Size(312, 213)
        Me.grpbRecoverOption.TabIndex = 37
        Me.grpbRecoverOption.TabStop = False
        Me.grpbRecoverOption.Text = "Recover Account using the following options:"
        Me.grpbRecoverOption.Visible = False
        '
        'btnOTP
        '
        Me.btnOTP.FlatAppearance.BorderSize = 0
        Me.btnOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOTP.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOTP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnOTP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOTP.Location = New System.Drawing.Point(6, 159)
        Me.btnOTP.Name = "btnOTP"
        Me.btnOTP.Size = New System.Drawing.Size(300, 48)
        Me.btnOTP.TabIndex = 40
        Me.btnOTP.Text = "OTP"
        Me.btnOTP.UseVisualStyleBackColor = True
        '
        'btnRequestRecovery
        '
        Me.btnRequestRecovery.FlatAppearance.BorderSize = 0
        Me.btnRequestRecovery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRequestRecovery.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRequestRecovery.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRequestRecovery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRequestRecovery.Location = New System.Drawing.Point(6, 103)
        Me.btnRequestRecovery.Name = "btnRequestRecovery"
        Me.btnRequestRecovery.Size = New System.Drawing.Size(300, 48)
        Me.btnRequestRecovery.TabIndex = 39
        Me.btnRequestRecovery.Text = "Request Recovery"
        Me.btnRequestRecovery.UseVisualStyleBackColor = True
        '
        'btnBackupCode
        '
        Me.btnBackupCode.FlatAppearance.BorderSize = 0
        Me.btnBackupCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackupCode.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackupCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBackupCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBackupCode.Location = New System.Drawing.Point(6, 49)
        Me.btnBackupCode.Name = "btnBackupCode"
        Me.btnBackupCode.Size = New System.Drawing.Size(300, 48)
        Me.btnBackupCode.TabIndex = 38
        Me.btnBackupCode.Text = "Backup Code"
        Me.btnBackupCode.UseVisualStyleBackColor = True
        '
        'grpbBackupCode
        '
        Me.grpbBackupCode.Controls.Add(Me.Button22)
        Me.grpbBackupCode.Controls.Add(Me.Label6)
        Me.grpbBackupCode.Controls.Add(Me.Label5)
        Me.grpbBackupCode.Controls.Add(Me.Label2)
        Me.grpbBackupCode.Controls.Add(Me.txtBackupPin4)
        Me.grpbBackupCode.Controls.Add(Me.txtBackupPin3)
        Me.grpbBackupCode.Controls.Add(Me.txtBackupPin2)
        Me.grpbBackupCode.Controls.Add(Me.btnConfirmBackup)
        Me.grpbBackupCode.Controls.Add(Me.txtBackupPin1)
        Me.grpbBackupCode.Controls.Add(Me.Label1)
        Me.grpbBackupCode.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbBackupCode.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.grpbBackupCode.Location = New System.Drawing.Point(480, 12)
        Me.grpbBackupCode.Name = "grpbBackupCode"
        Me.grpbBackupCode.Size = New System.Drawing.Size(584, 194)
        Me.grpbBackupCode.TabIndex = 37
        Me.grpbBackupCode.TabStop = False
        Me.grpbBackupCode.Text = "Backup Code"
        Me.grpbBackupCode.Visible = False
        '
        'Button22
        '
        Me.Button22.FlatAppearance.BorderSize = 0
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button22.Image = Global.capstoneSystem.My.Resources.Resources.eye_fill_icon
        Me.Button22.Location = New System.Drawing.Point(524, 82)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(52, 39)
        Me.Button22.TabIndex = 43
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Matura MT Script Capitals", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(385, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 47)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Matura MT Script Capitals", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(246, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 47)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Matura MT Script Capitals", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 47)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "-"
        '
        'txtBackupPin4
        '
        Me.txtBackupPin4.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBackupPin4.Location = New System.Drawing.Point(423, 78)
        Me.txtBackupPin4.MaxLength = 4
        Me.txtBackupPin4.Name = "txtBackupPin4"
        Me.txtBackupPin4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBackupPin4.Size = New System.Drawing.Size(95, 44)
        Me.txtBackupPin4.TabIndex = 39
        '
        'txtBackupPin3
        '
        Me.txtBackupPin3.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBackupPin3.Location = New System.Drawing.Point(284, 78)
        Me.txtBackupPin3.MaxLength = 4
        Me.txtBackupPin3.Name = "txtBackupPin3"
        Me.txtBackupPin3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBackupPin3.Size = New System.Drawing.Size(95, 44)
        Me.txtBackupPin3.TabIndex = 38
        '
        'txtBackupPin2
        '
        Me.txtBackupPin2.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBackupPin2.Location = New System.Drawing.Point(145, 78)
        Me.txtBackupPin2.MaxLength = 4
        Me.txtBackupPin2.Name = "txtBackupPin2"
        Me.txtBackupPin2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBackupPin2.Size = New System.Drawing.Size(95, 44)
        Me.txtBackupPin2.TabIndex = 37
        '
        'btnConfirmBackup
        '
        Me.btnConfirmBackup.BackColor = System.Drawing.Color.Transparent
        Me.btnConfirmBackup.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.blue_button_2
        Me.btnConfirmBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConfirmBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirmBackup.FlatAppearance.BorderSize = 0
        Me.btnConfirmBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmBackup.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmBackup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnConfirmBackup.Location = New System.Drawing.Point(243, 144)
        Me.btnConfirmBackup.Name = "btnConfirmBackup"
        Me.btnConfirmBackup.Size = New System.Drawing.Size(110, 29)
        Me.btnConfirmBackup.TabIndex = 36
        Me.btnConfirmBackup.Text = "Confirm"
        Me.btnConfirmBackup.UseVisualStyleBackColor = False
        '
        'txtBackupPin1
        '
        Me.txtBackupPin1.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBackupPin1.Location = New System.Drawing.Point(6, 78)
        Me.txtBackupPin1.MaxLength = 4
        Me.txtBackupPin1.Name = "txtBackupPin1"
        Me.txtBackupPin1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBackupPin1.Size = New System.Drawing.Size(95, 44)
        Me.txtBackupPin1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Please Enter your Backup Code:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'grpbOTP
        '
        Me.grpbOTP.Controls.Add(Me.Label8)
        Me.grpbOTP.Controls.Add(Me.btnVerifyOTP)
        Me.grpbOTP.Controls.Add(Me.lblRegisteredEmail)
        Me.grpbOTP.Controls.Add(Me.btnSendOTP)
        Me.grpbOTP.Controls.Add(Me.Label7)
        Me.grpbOTP.Controls.Add(Me.txtVerifyOTP)
        Me.grpbOTP.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbOTP.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.grpbOTP.Location = New System.Drawing.Point(480, 212)
        Me.grpbOTP.Name = "grpbOTP"
        Me.grpbOTP.Size = New System.Drawing.Size(584, 260)
        Me.grpbOTP.TabIndex = 38
        Me.grpbOTP.TabStop = False
        Me.grpbOTP.Text = "One-Time-Password"
        Me.grpbOTP.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(220, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(159, 26)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Enter the OTP"
        '
        'btnVerifyOTP
        '
        Me.btnVerifyOTP.BackColor = System.Drawing.Color.Transparent
        Me.btnVerifyOTP.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.blue_button_2
        Me.btnVerifyOTP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVerifyOTP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerifyOTP.FlatAppearance.BorderSize = 0
        Me.btnVerifyOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerifyOTP.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerifyOTP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnVerifyOTP.Location = New System.Drawing.Point(234, 211)
        Me.btnVerifyOTP.Name = "btnVerifyOTP"
        Me.btnVerifyOTP.Size = New System.Drawing.Size(143, 29)
        Me.btnVerifyOTP.TabIndex = 45
        Me.btnVerifyOTP.Text = "Verify"
        Me.btnVerifyOTP.UseVisualStyleBackColor = False
        '
        'lblRegisteredEmail
        '
        Me.lblRegisteredEmail.AutoSize = True
        Me.lblRegisteredEmail.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisteredEmail.Location = New System.Drawing.Point(206, 61)
        Me.lblRegisteredEmail.Name = "lblRegisteredEmail"
        Me.lblRegisteredEmail.Size = New System.Drawing.Size(244, 16)
        Me.lblRegisteredEmail.TabIndex = 44
        Me.lblRegisteredEmail.Text = "exp***************@gmail.com"
        '
        'btnSendOTP
        '
        Me.btnSendOTP.BackColor = System.Drawing.Color.Transparent
        Me.btnSendOTP.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.blue_button_2
        Me.btnSendOTP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSendOTP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSendOTP.FlatAppearance.BorderSize = 0
        Me.btnSendOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSendOTP.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendOTP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSendOTP.Location = New System.Drawing.Point(234, 89)
        Me.btnSendOTP.Name = "btnSendOTP"
        Me.btnSendOTP.Size = New System.Drawing.Size(143, 29)
        Me.btnSendOTP.TabIndex = 43
        Me.btnSendOTP.Text = "Send OTP"
        Me.btnSendOTP.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(89, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(429, 26)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "An OTP will be sent to the email below:"
        '
        'txtVerifyOTP
        '
        Me.txtVerifyOTP.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVerifyOTP.Location = New System.Drawing.Point(130, 161)
        Me.txtVerifyOTP.MaxLength = 100
        Me.txtVerifyOTP.Name = "txtVerifyOTP"
        Me.txtVerifyOTP.Size = New System.Drawing.Size(347, 44)
        Me.txtVerifyOTP.TabIndex = 43
        '
        'frmForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1076, 534)
        Me.Controls.Add(Me.grpbOTP)
        Me.Controls.Add(Me.grpbBackupCode)
        Me.Controls.Add(Me.grpbRecoverOption)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmForgotPassword"
        Me.Text = "Forgot Password"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpbRecoverOption.ResumeLayout(False)
        Me.grpbBackupCode.ResumeLayout(False)
        Me.grpbBackupCode.PerformLayout()
        Me.grpbOTP.ResumeLayout(False)
        Me.grpbOTP.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchUsername As System.Windows.Forms.Button
    Friend WithEvents grpbRecoverOption As System.Windows.Forms.GroupBox
    Friend WithEvents btnOTP As System.Windows.Forms.Button
    Friend WithEvents btnBackupCode As System.Windows.Forms.Button
    Friend WithEvents btnRequestRecovery As System.Windows.Forms.Button
    Friend WithEvents grpbBackupCode As System.Windows.Forms.GroupBox
    Friend WithEvents btnConfirmBackup As System.Windows.Forms.Button
    Friend WithEvents txtBackupPin1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpbOTP As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBackupPin4 As System.Windows.Forms.TextBox
    Friend WithEvents txtBackupPin3 As System.Windows.Forms.TextBox
    Friend WithEvents txtBackupPin2 As System.Windows.Forms.TextBox
    Friend WithEvents btnSendOTP As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtVerifyOTP As System.Windows.Forms.TextBox
    Friend WithEvents btnVerifyOTP As System.Windows.Forms.Button
    Friend WithEvents lblRegisteredEmail As System.Windows.Forms.Label
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
