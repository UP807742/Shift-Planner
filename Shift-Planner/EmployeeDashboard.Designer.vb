﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeDashboard
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstShifts = New System.Windows.Forms.ListBox()
        Me.calShifts = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstAnnouncements = New System.Windows.Forms.ListBox()
        Me.btnTimeOff = New System.Windows.Forms.Button()
        Me.btnOvertime = New System.Windows.Forms.Button()
        Me.btnChangePass = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lstShifts)
        Me.GroupBox1.Controls.Add(Me.calShifts)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(961, 290)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Shifts"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(335, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Shift Schedule:"
        '
        'lstShifts
        '
        Me.lstShifts.FormattingEnabled = True
        Me.lstShifts.ItemHeight = 16
        Me.lstShifts.Location = New System.Drawing.Point(339, 49)
        Me.lstShifts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstShifts.Name = "lstShifts"
        Me.lstShifts.Size = New System.Drawing.Size(607, 212)
        Me.lstShifts.TabIndex = 1
        '
        'calShifts
        '
        Me.calShifts.Location = New System.Drawing.Point(12, 50)
        Me.calShifts.MinDate = New Date(2018, 1, 1, 0, 0, 0, 0)
        Me.calShifts.Name = "calShifts"
        Me.calShifts.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstAnnouncements)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 308)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(961, 290)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Announcements"
        '
        'lstAnnouncements
        '
        Me.lstAnnouncements.FormattingEnabled = True
        Me.lstAnnouncements.ItemHeight = 16
        Me.lstAnnouncements.Location = New System.Drawing.Point(12, 27)
        Me.lstAnnouncements.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstAnnouncements.Name = "lstAnnouncements"
        Me.lstAnnouncements.Size = New System.Drawing.Size(935, 244)
        Me.lstAnnouncements.TabIndex = 2
        '
        'btnTimeOff
        '
        Me.btnTimeOff.Location = New System.Drawing.Point(773, 604)
        Me.btnTimeOff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTimeOff.Name = "btnTimeOff"
        Me.btnTimeOff.Size = New System.Drawing.Size(199, 33)
        Me.btnTimeOff.TabIndex = 3
        Me.btnTimeOff.Text = "Apply for time off"
        Me.btnTimeOff.UseVisualStyleBackColor = True
        '
        'btnOvertime
        '
        Me.btnOvertime.Location = New System.Drawing.Point(557, 604)
        Me.btnOvertime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOvertime.Name = "btnOvertime"
        Me.btnOvertime.Size = New System.Drawing.Size(199, 33)
        Me.btnOvertime.TabIndex = 4
        Me.btnOvertime.Text = "Overtime shifts"
        Me.btnOvertime.UseVisualStyleBackColor = True
        '
        'btnChangePass
        '
        Me.btnChangePass.Location = New System.Drawing.Point(12, 604)
        Me.btnChangePass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.Size = New System.Drawing.Size(199, 33)
        Me.btnChangePass.TabIndex = 5
        Me.btnChangePass.Text = "Change password"
        Me.btnChangePass.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(233, 604)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(199, 33)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'EmployeeDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 645)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnChangePass)
        Me.Controls.Add(Me.btnOvertime)
        Me.Controls.Add(Me.btnTimeOff)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "EmployeeDashboard"
        Me.Text = "Dashboard"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstShifts As ListBox
    Friend WithEvents calShifts As MonthCalendar
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnTimeOff As Button
    Friend WithEvents btnOvertime As Button
    Friend WithEvents lstAnnouncements As ListBox
    Friend WithEvents btnChangePass As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
End Class
