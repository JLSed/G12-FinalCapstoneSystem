<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBreakNotice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBreakNotice))
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpStart = New System.Windows.Forms.DateTimePicker
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.rtxtReason = New System.Windows.Forms.RichTextBox
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(38, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(397, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MAKE A BREAK NOTICE"
        '
        'dtpStart
        '
        Me.dtpStart.Location = New System.Drawing.Point(6, 19)
        Me.dtpStart.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(200, 20)
        Me.dtpStart.TabIndex = 1
        Me.dtpStart.Value = New Date(2023, 1, 1, 0, 0, 0, 0)
        '
        'dtpEnd
        '
        Me.dtpEnd.Location = New System.Drawing.Point(246, 19)
        Me.dtpEnd.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(200, 20)
        Me.dtpEnd.TabIndex = 2
        Me.dtpEnd.Value = New Date(2023, 1, 1, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.OldLace
        Me.Label2.Location = New System.Drawing.Point(7, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "REASON:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpStart)
        Me.GroupBox1.Controls.Add(Me.dtpEnd)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 59)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "START"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(214, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 33)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(246, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "END"
        '
        'rtxtReason
        '
        Me.rtxtReason.BackColor = System.Drawing.Color.White
        Me.rtxtReason.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtxtReason.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.rtxtReason.Location = New System.Drawing.Point(12, 161)
        Me.rtxtReason.Name = "rtxtReason"
        Me.rtxtReason.Size = New System.Drawing.Size(455, 106)
        Me.rtxtReason.TabIndex = 5
        Me.rtxtReason.Text = ""
        '
        'btnSubmit
        '
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnSubmit.Image = Global.capstoneSystem.My.Resources.Resources.Email_icon
        Me.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSubmit.Location = New System.Drawing.Point(189, 273)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(99, 53)
        Me.btnSubmit.TabIndex = 37
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'frmBreakNotice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(481, 338)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.rtxtReason)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBreakNotice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Break Notice"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rtxtReason As System.Windows.Forms.RichTextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
