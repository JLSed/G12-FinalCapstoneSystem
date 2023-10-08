<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClockIn
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
        Me.lblTime = New System.Windows.Forms.Label
        Me.btnTimeOut = New System.Windows.Forms.Button
        Me.lblDate = New System.Windows.Forms.Label
        Me.btnTimeIn = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.tmrDateTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblID = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.pcbProfile = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTemp = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnGoBackANT = New System.Windows.Forms.Button
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTime.Location = New System.Drawing.Point(502, 160)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(156, 61)
        Me.lblTime.TabIndex = 28
        Me.lblTime.Text = "lblTime"
        '
        'btnTimeOut
        '
        Me.btnTimeOut.BackColor = System.Drawing.Color.Transparent
        Me.btnTimeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnTimeOut.Location = New System.Drawing.Point(915, 639)
        Me.btnTimeOut.Name = "btnTimeOut"
        Me.btnTimeOut.Size = New System.Drawing.Size(275, 98)
        Me.btnTimeOut.TabIndex = 24
        Me.btnTimeOut.Text = "Time Out"
        Me.btnTimeOut.UseVisualStyleBackColor = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDate.Location = New System.Drawing.Point(59, 160)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(332, 61)
        Me.lblDate.TabIndex = 23
        Me.lblDate.Text = "February 2, 2023"
        '
        'btnTimeIn
        '
        Me.btnTimeIn.BackColor = System.Drawing.Color.Transparent
        Me.btnTimeIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnTimeIn.Location = New System.Drawing.Point(43, 639)
        Me.btnTimeIn.Name = "btnTimeIn"
        Me.btnTimeIn.Size = New System.Drawing.Size(275, 98)
        Me.btnTimeIn.TabIndex = 20
        Me.btnTimeIn.Text = "Time In"
        Me.btnTimeIn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(228, 387)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 39)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "ID:"
        '
        'tmrDateTime
        '
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Myanmar Text", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(280, 383)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(56, 62)
        Me.lblID.TabIndex = 29
        Me.lblID.Text = "id"
        '
        'lblName
        '
        Me.lblName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Century Schoolbook", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(349, 326)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(116, 44)
        Me.lblName.TabIndex = 30
        Me.lblName.Text = "name"
        '
        'pcbProfile
        '
        Me.pcbProfile.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pcbProfile.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.User_icon
        Me.pcbProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pcbProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbProfile.Location = New System.Drawing.Point(10, 281)
        Me.pcbProfile.Name = "pcbProfile"
        Me.pcbProfile.Size = New System.Drawing.Size(207, 197)
        Me.pcbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbProfile.TabIndex = 31
        Me.pcbProfile.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 328)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 42)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(334, 611)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 25)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Temperature"
        Me.Label3.Visible = False
        '
        'txtTemp
        '
        Me.txtTemp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 59.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtTemp.Location = New System.Drawing.Point(339, 639)
        Me.txtTemp.MaxLength = 4
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(130, 97)
        Me.txtTemp.TabIndex = 21
        Me.txtTemp.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Heavy", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(373, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(615, 81)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "ATTENDANCE FORM"
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
        Me.btnGoBackANT.Font = New System.Drawing.Font("UD Digi Kyokasho NK-B", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnGoBackANT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGoBackANT.Image = Global.capstoneSystem.My.Resources.Resources.Back_icon
        Me.btnGoBackANT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGoBackANT.Location = New System.Drawing.Point(1244, 12)
        Me.btnGoBackANT.Name = "btnGoBackANT"
        Me.btnGoBackANT.Size = New System.Drawing.Size(110, 50)
        Me.btnGoBackANT.TabIndex = 36
        Me.btnGoBackANT.Text = "Go Back"
        Me.btnGoBackANT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGoBackANT.UseVisualStyleBackColor = False
        '
        'frmClockIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.clockinBGs2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.btnGoBackANT)
        Me.Controls.Add(Me.btnTimeOut)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnTimeIn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.pcbProfile)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblID)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClockIn"
        Me.ShowInTaskbar = False
        Me.Text = " Attendance Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents btnTimeOut As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents btnTimeIn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tmrDateTime As System.Windows.Forms.Timer
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents pcbProfile As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTemp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnGoBackANT As System.Windows.Forms.Button
End Class
