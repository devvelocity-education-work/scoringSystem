<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Email
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAdminAccount = New System.Windows.Forms.Label()
        Me.lblLoggedInAs = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBxFrom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBxPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBxTo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBxAttachment = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBxSubject = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBxBody = New System.Windows.Forms.TextBox()
        Me.btnSendEmail = New System.Windows.Forms.Button()
        Me.btnSendALL = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblAdminAccount)
        Me.Panel1.Controls.Add(Me.lblLoggedInAs)
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Location = New System.Drawing.Point(0, 596)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(972, 70)
        Me.Panel1.TabIndex = 74
        '
        'lblAdminAccount
        '
        Me.lblAdminAccount.AutoSize = True
        Me.lblAdminAccount.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdminAccount.ForeColor = System.Drawing.Color.Gold
        Me.lblAdminAccount.Location = New System.Drawing.Point(28, 33)
        Me.lblAdminAccount.Name = "lblAdminAccount"
        Me.lblAdminAccount.Size = New System.Drawing.Size(111, 19)
        Me.lblAdminAccount.TabIndex = 81
        Me.lblAdminAccount.Text = "[Admin Account]"
        '
        'lblLoggedInAs
        '
        Me.lblLoggedInAs.AutoSize = True
        Me.lblLoggedInAs.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoggedInAs.ForeColor = System.Drawing.Color.White
        Me.lblLoggedInAs.Location = New System.Drawing.Point(27, 14)
        Me.lblLoggedInAs.Name = "lblLoggedInAs"
        Me.lblLoggedInAs.Size = New System.Drawing.Size(127, 19)
        Me.lblLoggedInAs.TabIndex = 6
        Me.lblLoggedInAs.Text = "Logged in as [User]"
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.Location = New System.Drawing.Point(829, 14)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(117, 38)
        Me.btnLogOut.TabIndex = 4
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(37, 35)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(117, 23)
        Me.btnBack.TabIndex = 75
        Me.btnBack.Text = "< Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(42, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 19)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "From"
        '
        'txtBxFrom
        '
        Me.txtBxFrom.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtBxFrom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxFrom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBxFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxFrom.ForeColor = System.Drawing.Color.White
        Me.txtBxFrom.Location = New System.Drawing.Point(46, 185)
        Me.txtBxFrom.Name = "txtBxFrom"
        Me.txtBxFrom.Size = New System.Drawing.Size(292, 22)
        Me.txtBxFrom.TabIndex = 76
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(366, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 19)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Password"
        '
        'txtBxPassword
        '
        Me.txtBxPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtBxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxPassword.ForeColor = System.Drawing.Color.White
        Me.txtBxPassword.Location = New System.Drawing.Point(370, 185)
        Me.txtBxPassword.Name = "txtBxPassword"
        Me.txtBxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBxPassword.Size = New System.Drawing.Size(292, 22)
        Me.txtBxPassword.TabIndex = 78
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(42, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 19)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "To"
        '
        'txtBxTo
        '
        Me.txtBxTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtBxTo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxTo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBxTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxTo.ForeColor = System.Drawing.Color.White
        Me.txtBxTo.Location = New System.Drawing.Point(46, 240)
        Me.txtBxTo.Name = "txtBxTo"
        Me.txtBxTo.Size = New System.Drawing.Size(292, 22)
        Me.txtBxTo.TabIndex = 80
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(366, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 19)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Attachment"
        '
        'txtBxAttachment
        '
        Me.txtBxAttachment.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtBxAttachment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxAttachment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBxAttachment.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxAttachment.ForeColor = System.Drawing.Color.White
        Me.txtBxAttachment.Location = New System.Drawing.Point(370, 240)
        Me.txtBxAttachment.Name = "txtBxAttachment"
        Me.txtBxAttachment.Size = New System.Drawing.Size(292, 22)
        Me.txtBxAttachment.TabIndex = 82
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(42, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 19)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Subject"
        '
        'txtBxSubject
        '
        Me.txtBxSubject.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtBxSubject.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxSubject.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBxSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxSubject.ForeColor = System.Drawing.Color.White
        Me.txtBxSubject.Location = New System.Drawing.Point(46, 293)
        Me.txtBxSubject.Name = "txtBxSubject"
        Me.txtBxSubject.Size = New System.Drawing.Size(616, 22)
        Me.txtBxSubject.TabIndex = 84
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(42, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 19)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Body"
        '
        'txtBxBody
        '
        Me.txtBxBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtBxBody.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxBody.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBxBody.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxBody.ForeColor = System.Drawing.Color.White
        Me.txtBxBody.Location = New System.Drawing.Point(46, 346)
        Me.txtBxBody.Multiline = True
        Me.txtBxBody.Name = "txtBxBody"
        Me.txtBxBody.Size = New System.Drawing.Size(616, 124)
        Me.txtBxBody.TabIndex = 86
        '
        'btnSendEmail
        '
        Me.btnSendEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnSendEmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSendEmail.FlatAppearance.BorderSize = 0
        Me.btnSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSendEmail.ForeColor = System.Drawing.Color.White
        Me.btnSendEmail.Location = New System.Drawing.Point(46, 500)
        Me.btnSendEmail.Name = "btnSendEmail"
        Me.btnSendEmail.Size = New System.Drawing.Size(117, 23)
        Me.btnSendEmail.TabIndex = 88
        Me.btnSendEmail.Text = "Send Email"
        Me.btnSendEmail.UseVisualStyleBackColor = False
        '
        'btnSendALL
        '
        Me.btnSendALL.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnSendALL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSendALL.FlatAppearance.BorderSize = 0
        Me.btnSendALL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSendALL.ForeColor = System.Drawing.Color.White
        Me.btnSendALL.Location = New System.Drawing.Point(774, 403)
        Me.btnSendALL.Name = "btnSendALL"
        Me.btnSendALL.Size = New System.Drawing.Size(117, 23)
        Me.btnSendALL.TabIndex = 89
        Me.btnSendALL.Text = "Toggle Send All"
        Me.btnSendALL.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(759, 377)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 19)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Send to every member"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.scoringsystem4.My.Resources.Resources.Event_Scoring_logos_white
        Me.PictureBox1.Location = New System.Drawing.Point(737, 185)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 103)
        Me.PictureBox1.TabIndex = 91
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(38, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 45)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Email"
        '
        'Email
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(968, 663)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnSendALL)
        Me.Controls.Add(Me.btnSendEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBxBody)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBxSubject)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBxAttachment)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBxTo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBxPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBxFrom)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Email"
        Me.Text = "Email"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAdminAccount As Label
    Friend WithEvents lblLoggedInAs As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBxFrom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBxPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBxTo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBxAttachment As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBxSubject As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBxBody As TextBox
    Friend WithEvents btnSendEmail As Button
    Friend WithEvents btnSendALL As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
End Class
