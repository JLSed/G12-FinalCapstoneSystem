<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.btnTimeOut = New System.Windows.Forms.Button
        Me.lblDate = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.btnTimeIn = New System.Windows.Forms.Button
        Me.lblWarning = New System.Windows.Forms.Label
        Me.tmrDateTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(262, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 39)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "ID:"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.Control
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(314, 69)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(216, 47)
        Me.txtID.TabIndex = 16
        '
        'btnTimeOut
        '
        Me.btnTimeOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeOut.Location = New System.Drawing.Point(488, 206)
        Me.btnTimeOut.Name = "btnTimeOut"
        Me.btnTimeOut.Size = New System.Drawing.Size(265, 94)
        Me.btnTimeOut.TabIndex = 15
        Me.btnTimeOut.Text = "Time Out"
        Me.btnTimeOut.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(507, 9)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(125, 39)
        Me.lblDate.TabIndex = 14
        Me.lblDate.Text = "lblDate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(203, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 39)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Control
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(314, 122)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(475, 47)
        Me.txtName.TabIndex = 12
        '
        'btnTimeIn
        '
        Me.btnTimeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeIn.Location = New System.Drawing.Point(58, 206)
        Me.btnTimeIn.Name = "btnTimeIn"
        Me.btnTimeIn.Size = New System.Drawing.Size(265, 94)
        Me.btnTimeIn.TabIndex = 11
        Me.btnTimeIn.Text = "Time In"
        Me.btnTimeIn.UseVisualStyleBackColor = True
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.ForeColor = System.Drawing.Color.Red
        Me.lblWarning.Location = New System.Drawing.Point(320, 60)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(141, 13)
        Me.lblWarning.TabIndex = 18
        Me.lblWarning.Text = "Please Input the teacher ID*"
        '
        'tmrDateTime
        '
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(12, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(130, 39)
        Me.lblTime.TabIndex = 19
        Me.lblTime.Text = "lblTime"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 391)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnTimeOut)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnTimeIn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnTimeOut As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnTimeIn As System.Windows.Forms.Button
    Friend WithEvents lblWarning As System.Windows.Forms.Label
    Friend WithEvents tmrDateTime As System.Windows.Forms.Timer
    Friend WithEvents lblTime As System.Windows.Forms.Label

End Class
