<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutoClockIn
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.pcbProfile = New System.Windows.Forms.PictureBox
        Me.lblTime = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblID = New System.Windows.Forms.Label
        Me.lblAnnouncer = New System.Windows.Forms.RichTextBox
        Me.tmrFormTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Heavy", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(319, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(788, 81)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "AUTO ATTENDANCE FORM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(227, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 42)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Name:"
        '
        'lblName
        '
        Me.lblName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Century Schoolbook", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(349, 325)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(116, 44)
        Me.lblName.TabIndex = 40
        Me.lblName.Text = "name"
        '
        'pcbProfile
        '
        Me.pcbProfile.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pcbProfile.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.User_icon
        Me.pcbProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pcbProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbProfile.Location = New System.Drawing.Point(10, 280)
        Me.pcbProfile.Name = "pcbProfile"
        Me.pcbProfile.Size = New System.Drawing.Size(207, 197)
        Me.pcbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbProfile.TabIndex = 41
        Me.pcbProfile.TabStop = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTime.Location = New System.Drawing.Point(502, 159)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(156, 61)
        Me.lblTime.TabIndex = 38
        Me.lblTime.Text = "lblTime"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDate.Location = New System.Drawing.Point(59, 159)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(332, 61)
        Me.lblDate.TabIndex = 36
        Me.lblDate.Text = "February 2, 2023"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(228, 386)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 39)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "ID:"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Myanmar Text", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(280, 382)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(56, 62)
        Me.lblID.TabIndex = 39
        Me.lblID.Text = "id"
        '
        'lblAnnouncer
        '
        Me.lblAnnouncer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblAnnouncer.Enabled = False
        Me.lblAnnouncer.Font = New System.Drawing.Font("Bernard MT Condensed", 72.0!)
        Me.lblAnnouncer.Location = New System.Drawing.Point(48, 506)
        Me.lblAnnouncer.Name = "lblAnnouncer"
        Me.lblAnnouncer.ReadOnly = True
        Me.lblAnnouncer.Size = New System.Drawing.Size(1214, 250)
        Me.lblAnnouncer.TabIndex = 45
        Me.lblAnnouncer.Text = ""
        '
        'tmrFormTimer
        '
        Me.tmrFormTimer.Interval = 2000
        '
        'frmAutoClockIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BackgroundImage = Global.capstoneSystem.My.Resources.Resources.clockinBGs2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.lblAnnouncer)
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
        Me.Name = "frmAutoClockIn"
        Me.Text = "frmAutoClockIn"
        CType(Me.pcbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents pcbProfile As System.Windows.Forms.PictureBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblAnnouncer As System.Windows.Forms.RichTextBox
    Friend WithEvents tmrFormTimer As System.Windows.Forms.Timer
End Class
