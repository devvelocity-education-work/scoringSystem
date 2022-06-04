<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePage))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAdminAccount = New System.Windows.Forms.Label()
        Me.lblLoggedInAs = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnLogOut = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.btnEmail = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnScore = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.btnLogOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 45)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Home Page"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.lblAdminAccount)
        Me.Panel1.Controls.Add(Me.lblLoggedInAs)
        Me.Panel1.Location = New System.Drawing.Point(-3, 433)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(596, 67)
        Me.Panel1.TabIndex = 14
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
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnLogOut
        '
        Me.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogOut.Image = Global.scoringsystem4.My.Resources.Resources.log_out
        Me.btnLogOut.Location = New System.Drawing.Point(433, 14)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(151, 38)
        Me.btnLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnLogOut.TabIndex = 22
        Me.btnLogOut.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(-23, -46)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox6.TabIndex = 21
        Me.PictureBox6.TabStop = False
        '
        'btnEmail
        '
        Me.btnEmail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmail.Image = Global.scoringsystem4.My.Resources.Resources.email
        Me.btnEmail.Location = New System.Drawing.Point(51, 338)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(200, 43)
        Me.btnEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnEmail.TabIndex = 20
        Me.btnEmail.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.scoringsystem4.My.Resources.Resources.teams
        Me.PictureBox5.Location = New System.Drawing.Point(51, 292)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(200, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 19
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.scoringsystem4.My.Resources.Resources.members
        Me.PictureBox4.Location = New System.Drawing.Point(51, 246)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(200, 40)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 18
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.scoringsystem4.My.Resources.Resources.events
        Me.PictureBox3.Location = New System.Drawing.Point(51, 200)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(200, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'btnScore
        '
        Me.btnScore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnScore.Image = Global.scoringsystem4.My.Resources.Resources.scoreboard
        Me.btnScore.Location = New System.Drawing.Point(51, 154)
        Me.btnScore.Name = "btnScore"
        Me.btnScore.Size = New System.Drawing.Size(200, 40)
        Me.btnScore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnScore.TabIndex = 16
        Me.btnScore.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.scoringsystem4.My.Resources.Resources.ES
        Me.PictureBox1.Location = New System.Drawing.Point(413, 226)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(74, 163)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(593, 497)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.btnEmail)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnScore)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HomePage"
        Me.Text = "HomePage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnLogOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAdminAccount As Label
    Friend WithEvents lblLoggedInAs As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnScore As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnEmail As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents btnLogOut As PictureBox
End Class
