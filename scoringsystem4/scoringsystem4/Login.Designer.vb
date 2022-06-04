<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.txtBxUsername = New System.Windows.Forms.TextBox()
        Me.txtBxPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnForgotPassword = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBxUsername
        '
        Me.txtBxUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtBxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxUsername.ForeColor = System.Drawing.Color.White
        Me.txtBxUsername.Location = New System.Drawing.Point(49, 196)
        Me.txtBxUsername.Name = "txtBxUsername"
        Me.txtBxUsername.Size = New System.Drawing.Size(240, 22)
        Me.txtBxUsername.TabIndex = 0
        '
        'txtBxPassword
        '
        Me.txtBxPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtBxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxPassword.ForeColor = System.Drawing.Color.White
        Me.txtBxPassword.Location = New System.Drawing.Point(49, 246)
        Me.txtBxPassword.Name = "txtBxPassword"
        Me.txtBxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBxPassword.Size = New System.Drawing.Size(240, 22)
        Me.txtBxPassword.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(48, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(48, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.scoringsystem4.My.Resources.Resources.ES
        Me.PictureBox1.Location = New System.Drawing.Point(627, 214)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'btnForgotPassword
        '
        Me.btnForgotPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnForgotPassword.FlatAppearance.BorderSize = 0
        Me.btnForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForgotPassword.ForeColor = System.Drawing.Color.White
        Me.btnForgotPassword.Location = New System.Drawing.Point(49, 316)
        Me.btnForgotPassword.Name = "btnForgotPassword"
        Me.btnForgotPassword.Size = New System.Drawing.Size(241, 23)
        Me.btnForgotPassword.TabIndex = 5
        Me.btnForgotPassword.Text = "Forgot Password?"
        Me.btnForgotPassword.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.Location = New System.Drawing.Point(172, 287)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(118, 23)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(49, 287)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(117, 23)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnForgotPassword)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBxPassword)
        Me.Controls.Add(Me.txtBxUsername)
        Me.Name = "Login"
        Me.Text = "Events"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBxUsername As TextBox
    Friend WithEvents txtBxPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnForgotPassword As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnLogin As Button
End Class
