<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtBxUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBxPassword = New System.Windows.Forms.TextBox()
        Me.txtBxPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBxEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBxMobile = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBxEmergencyContact = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DOBPicker = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBxFirstName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBxLastName = New System.Windows.Forms.TextBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBxAddress = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBxMedical = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(50, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 45)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Register"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-3, 590)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(958, 60)
        Me.Panel1.TabIndex = 20
        '
        'txtBxUsername
        '
        Me.txtBxUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtBxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxUsername.ForeColor = System.Drawing.Color.White
        Me.txtBxUsername.Location = New System.Drawing.Point(57, 170)
        Me.txtBxUsername.Name = "txtBxUsername"
        Me.txtBxUsername.Size = New System.Drawing.Size(309, 22)
        Me.txtBxUsername.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(54, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(413, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 19)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Password"
        '
        'txtBxPassword
        '
        Me.txtBxPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtBxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxPassword.ForeColor = System.Drawing.Color.White
        Me.txtBxPassword.Location = New System.Drawing.Point(418, 360)
        Me.txtBxPassword.Name = "txtBxPassword"
        Me.txtBxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBxPassword.Size = New System.Drawing.Size(309, 22)
        Me.txtBxPassword.TabIndex = 25
        '
        'txtBxPasswordConfirm
        '
        Me.txtBxPasswordConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtBxPasswordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxPasswordConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxPasswordConfirm.ForeColor = System.Drawing.Color.White
        Me.txtBxPasswordConfirm.Location = New System.Drawing.Point(419, 407)
        Me.txtBxPasswordConfirm.Name = "txtBxPasswordConfirm"
        Me.txtBxPasswordConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBxPasswordConfirm.Size = New System.Drawing.Size(309, 22)
        Me.txtBxPasswordConfirm.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(413, 385)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 19)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Confirm Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(55, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 19)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Email Address"
        '
        'txtBxEmail
        '
        Me.txtBxEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtBxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxEmail.ForeColor = System.Drawing.Color.White
        Me.txtBxEmail.Location = New System.Drawing.Point(58, 314)
        Me.txtBxEmail.Name = "txtBxEmail"
        Me.txtBxEmail.Size = New System.Drawing.Size(309, 22)
        Me.txtBxEmail.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(54, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 19)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Mobile Number"
        '
        'txtBxMobile
        '
        Me.txtBxMobile.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtBxMobile.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxMobile.ForeColor = System.Drawing.Color.White
        Me.txtBxMobile.Location = New System.Drawing.Point(58, 361)
        Me.txtBxMobile.Name = "txtBxMobile"
        Me.txtBxMobile.Size = New System.Drawing.Size(309, 22)
        Me.txtBxMobile.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(54, 433)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 19)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Emergency Contact Number"
        '
        'txtBxEmergencyContact
        '
        Me.txtBxEmergencyContact.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtBxEmergencyContact.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxEmergencyContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxEmergencyContact.ForeColor = System.Drawing.Color.White
        Me.txtBxEmergencyContact.Location = New System.Drawing.Point(57, 455)
        Me.txtBxEmergencyContact.Name = "txtBxEmergencyContact"
        Me.txtBxEmergencyContact.Size = New System.Drawing.Size(309, 22)
        Me.txtBxEmergencyContact.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(54, 386)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 19)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Date of Birth"
        '
        'DOBPicker
        '
        Me.DOBPicker.Location = New System.Drawing.Point(59, 409)
        Me.DOBPicker.Name = "DOBPicker"
        Me.DOBPicker.Size = New System.Drawing.Size(307, 20)
        Me.DOBPicker.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(53, 195)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 19)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "First Name"
        '
        'txtBxFirstName
        '
        Me.txtBxFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtBxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxFirstName.ForeColor = System.Drawing.Color.White
        Me.txtBxFirstName.Location = New System.Drawing.Point(56, 217)
        Me.txtBxFirstName.Name = "txtBxFirstName"
        Me.txtBxFirstName.Size = New System.Drawing.Size(309, 22)
        Me.txtBxFirstName.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(53, 243)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 19)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Last Name"
        '
        'txtBxLastName
        '
        Me.txtBxLastName.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtBxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxLastName.ForeColor = System.Drawing.Color.White
        Me.txtBxLastName.Location = New System.Drawing.Point(56, 265)
        Me.txtBxLastName.Name = "txtBxLastName"
        Me.txtBxLastName.Size = New System.Drawing.Size(309, 22)
        Me.txtBxLastName.TabIndex = 40
        '
        'cmbGender
        '
        Me.cmbGender.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbGender.ForeColor = System.Drawing.Color.White
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female", "Other", "PNTS"})
        Me.cmbGender.Location = New System.Drawing.Point(419, 217)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(309, 21)
        Me.cmbGender.TabIndex = 42
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(417, 195)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 19)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Gender"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(415, 148)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 19)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Address"
        '
        'txtBxAddress
        '
        Me.txtBxAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtBxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxAddress.ForeColor = System.Drawing.Color.White
        Me.txtBxAddress.Location = New System.Drawing.Point(419, 170)
        Me.txtBxAddress.Name = "txtBxAddress"
        Me.txtBxAddress.Size = New System.Drawing.Size(309, 22)
        Me.txtBxAddress.TabIndex = 44
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(417, 243)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 19)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Medical Conditions"
        '
        'txtBxMedical
        '
        Me.txtBxMedical.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtBxMedical.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxMedical.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxMedical.ForeColor = System.Drawing.Color.White
        Me.txtBxMedical.Location = New System.Drawing.Point(417, 265)
        Me.txtBxMedical.Multiline = True
        Me.txtBxMedical.Name = "txtBxMedical"
        Me.txtBxMedical.Size = New System.Drawing.Size(309, 70)
        Me.txtBxMedical.TabIndex = 46
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.scoringsystem4.My.Resources.Resources.register
        Me.PictureBox2.Location = New System.Drawing.Point(58, 501)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(134, 33)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 98
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.scoringsystem4.My.Resources.Resources.backbutton
        Me.PictureBox3.Location = New System.Drawing.Point(58, 39)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(117, 26)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 97
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.scoringsystem4.My.Resources.Resources.ES
        Me.PictureBox1.Location = New System.Drawing.Point(631, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(789, 648)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtBxMedical)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtBxAddress)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtBxLastName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtBxFirstName)
        Me.Controls.Add(Me.DOBPicker)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBxEmergencyContact)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBxMobile)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBxEmail)
        Me.Controls.Add(Me.txtBxPasswordConfirm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBxPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBxUsername)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Register"
        Me.Text = "Register"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtBxUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBxPassword As TextBox
    Friend WithEvents txtBxPasswordConfirm As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBxEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBxMobile As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBxEmergencyContact As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DOBPicker As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBxFirstName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBxLastName As TextBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBxAddress As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtBxMedical As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
