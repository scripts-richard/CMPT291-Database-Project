﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Login
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AccessAccount = New System.Windows.Forms.Button()
        Me.passwd = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label3.Location = New System.Drawing.Point(82, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 26)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "LOGIN"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(60, 178)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(123, 23)
        Me.BtnCancel.TabIndex = 26
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-1, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Username"
        '
        'AccessAccount
        '
        Me.AccessAccount.Location = New System.Drawing.Point(60, 149)
        Me.AccessAccount.Name = "AccessAccount"
        Me.AccessAccount.Size = New System.Drawing.Size(123, 23)
        Me.AccessAccount.TabIndex = 23
        Me.AccessAccount.Text = "Login"
        Me.AccessAccount.UseVisualStyleBackColor = True
        '
        'passwd
        '
        Me.passwd.Location = New System.Drawing.Point(60, 108)
        Me.passwd.Name = "passwd"
        Me.passwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwd.Size = New System.Drawing.Size(135, 20)
        Me.passwd.TabIndex = 22
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(60, 69)
        Me.username.MaxLength = 31
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(135, 20)
        Me.username.TabIndex = 21
        Me.username.WordWrap = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.username)
        Me.Panel1.Controls.Add(Me.BtnCancel)
        Me.Panel1.Controls.Add(Me.passwd)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.AccessAccount)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(460, 200)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 250)
        Me.Panel1.TabIndex = 28
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(60, 207)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(123, 23)
        Me.btnExit.TabIndex = 28
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Employee_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1200, 760)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Employee_Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AccessAccount As Button
    Friend WithEvents passwd As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
End Class
