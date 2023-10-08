<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtConfirmpasswordEdit = New System.Windows.Forms.TextBox
        Me.txtNewpasswordEdit = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button24 = New System.Windows.Forms.Button
        Me.Button23 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(68, 165)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 50)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "CHANGE PASSWORD"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtConfirmpasswordEdit
        '
        Me.txtConfirmpasswordEdit.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmpasswordEdit.Location = New System.Drawing.Point(11, 102)
        Me.txtConfirmpasswordEdit.Name = "txtConfirmpasswordEdit"
        Me.txtConfirmpasswordEdit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmpasswordEdit.Size = New System.Drawing.Size(245, 39)
        Me.txtConfirmpasswordEdit.TabIndex = 40
        '
        'txtNewpasswordEdit
        '
        Me.txtNewpasswordEdit.Font = New System.Drawing.Font("Yu Gothic UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewpasswordEdit.Location = New System.Drawing.Point(11, 39)
        Me.txtNewpasswordEdit.Name = "txtNewpasswordEdit"
        Me.txtNewpasswordEdit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewpasswordEdit.Size = New System.Drawing.Size(245, 39)
        Me.txtNewpasswordEdit.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 18)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Confirm Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 18)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "New Password"
        '
        'Button24
        '
        Me.Button24.FlatAppearance.BorderSize = 0
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button24.Image = Global.capstoneSystem.My.Resources.Resources.eye_fill_icon
        Me.Button24.Location = New System.Drawing.Point(262, 102)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(52, 39)
        Me.Button24.TabIndex = 43
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.FlatAppearance.BorderSize = 0
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button23.Image = Global.capstoneSystem.My.Resources.Resources.eye_fill_icon
        Me.Button23.Location = New System.Drawing.Point(262, 39)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(52, 39)
        Me.Button23.TabIndex = 42
        Me.Button23.UseVisualStyleBackColor = True
        '
        'frmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(316, 268)
        Me.Controls.Add(Me.Button24)
        Me.Controls.Add(Me.Button23)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtConfirmpasswordEdit)
        Me.Controls.Add(Me.txtNewpasswordEdit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtConfirmpasswordEdit As System.Windows.Forms.TextBox
    Friend WithEvents txtNewpasswordEdit As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
