<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventsPG
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtBxRecordID = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnDeleteRecord = New System.Windows.Forms.Button()
        Me.btnUpdateRecord = New System.Windows.Forms.Button()
        Me.btnAddRecord = New System.Windows.Forms.Button()
        Me.btnPrevRecord = New System.Windows.Forms.Button()
        Me.btnNextRecord = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBxEventName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbBxTeam = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBxMaxPoints = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBxLocation = New System.Windows.Forms.TextBox()
        Me.chcBxCompleted = New System.Windows.Forms.CheckBox()
        Me.btnNewRecord = New System.Windows.Forms.Button()
        Me.dtEventDate = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAdminAccount = New System.Windows.Forms.Label()
        Me.lblLoggedInAs = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(34, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 45)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Events"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(42, 42)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(117, 23)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "< Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.scoringsystem4.My.Resources.Resources.Event_Scoring_logos_white
        Me.PictureBox1.Location = New System.Drawing.Point(399, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 103)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'txtBxRecordID
        '
        Me.txtBxRecordID.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtBxRecordID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxRecordID.Cursor = System.Windows.Forms.Cursors.No
        Me.txtBxRecordID.Enabled = False
        Me.txtBxRecordID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxRecordID.ForeColor = System.Drawing.Color.White
        Me.txtBxRecordID.Location = New System.Drawing.Point(491, 205)
        Me.txtBxRecordID.Name = "txtBxRecordID"
        Me.txtBxRecordID.Size = New System.Drawing.Size(79, 22)
        Me.txtBxRecordID.TabIndex = 59
        Me.txtBxRecordID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(497, 179)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 19)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Event ID"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDeleteRecord
        '
        Me.btnDeleteRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnDeleteRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteRecord.FlatAppearance.BorderSize = 0
        Me.btnDeleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteRecord.ForeColor = System.Drawing.Color.White
        Me.btnDeleteRecord.Location = New System.Drawing.Point(471, 373)
        Me.btnDeleteRecord.Name = "btnDeleteRecord"
        Me.btnDeleteRecord.Size = New System.Drawing.Size(117, 23)
        Me.btnDeleteRecord.TabIndex = 57
        Me.btnDeleteRecord.Text = "Delete Record"
        Me.btnDeleteRecord.UseVisualStyleBackColor = False
        '
        'btnUpdateRecord
        '
        Me.btnUpdateRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnUpdateRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateRecord.FlatAppearance.BorderSize = 0
        Me.btnUpdateRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateRecord.ForeColor = System.Drawing.Color.White
        Me.btnUpdateRecord.Location = New System.Drawing.Point(471, 344)
        Me.btnUpdateRecord.Name = "btnUpdateRecord"
        Me.btnUpdateRecord.Size = New System.Drawing.Size(117, 23)
        Me.btnUpdateRecord.TabIndex = 56
        Me.btnUpdateRecord.Text = "Update Record"
        Me.btnUpdateRecord.UseVisualStyleBackColor = False
        '
        'btnAddRecord
        '
        Me.btnAddRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAddRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddRecord.Enabled = False
        Me.btnAddRecord.FlatAppearance.BorderSize = 0
        Me.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRecord.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnAddRecord.Location = New System.Drawing.Point(471, 476)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.Size = New System.Drawing.Size(117, 23)
        Me.btnAddRecord.TabIndex = 55
        Me.btnAddRecord.Text = "Add Record"
        Me.btnAddRecord.UseVisualStyleBackColor = False
        '
        'btnPrevRecord
        '
        Me.btnPrevRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnPrevRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrevRecord.FlatAppearance.BorderSize = 0
        Me.btnPrevRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevRecord.ForeColor = System.Drawing.Color.White
        Me.btnPrevRecord.Location = New System.Drawing.Point(471, 286)
        Me.btnPrevRecord.Name = "btnPrevRecord"
        Me.btnPrevRecord.Size = New System.Drawing.Size(117, 23)
        Me.btnPrevRecord.TabIndex = 54
        Me.btnPrevRecord.Text = "Prev Record"
        Me.btnPrevRecord.UseVisualStyleBackColor = False
        '
        'btnNextRecord
        '
        Me.btnNextRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnNextRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNextRecord.FlatAppearance.BorderSize = 0
        Me.btnNextRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextRecord.ForeColor = System.Drawing.Color.White
        Me.btnNextRecord.Location = New System.Drawing.Point(471, 257)
        Me.btnNextRecord.Name = "btnNextRecord"
        Me.btnNextRecord.Size = New System.Drawing.Size(117, 23)
        Me.btnNextRecord.TabIndex = 53
        Me.btnNextRecord.Text = "Next Record"
        Me.btnNextRecord.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 19)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Event Name"
        '
        'txtBxEventName
        '
        Me.txtBxEventName.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtBxEventName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxEventName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxEventName.ForeColor = System.Drawing.Color.White
        Me.txtBxEventName.Location = New System.Drawing.Point(42, 205)
        Me.txtBxEventName.Name = "txtBxEventName"
        Me.txtBxEventName.Size = New System.Drawing.Size(292, 22)
        Me.txtBxEventName.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(38, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 19)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Event Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(38, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 19)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Individual/Team"
        '
        'cmbBxTeam
        '
        Me.cmbBxTeam.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.cmbBxTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBxTeam.ForeColor = System.Drawing.Color.White
        Me.cmbBxTeam.FormattingEnabled = True
        Me.cmbBxTeam.Items.AddRange(New Object() {"Individual", "Team", "Both"})
        Me.cmbBxTeam.Location = New System.Drawing.Point(42, 314)
        Me.cmbBxTeam.Name = "cmbBxTeam"
        Me.cmbBxTeam.Size = New System.Drawing.Size(292, 21)
        Me.cmbBxTeam.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(38, 391)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 19)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Max Points"
        '
        'txtBxMaxPoints
        '
        Me.txtBxMaxPoints.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtBxMaxPoints.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxMaxPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxMaxPoints.ForeColor = System.Drawing.Color.White
        Me.txtBxMaxPoints.Location = New System.Drawing.Point(42, 413)
        Me.txtBxMaxPoints.Name = "txtBxMaxPoints"
        Me.txtBxMaxPoints.Size = New System.Drawing.Size(101, 22)
        Me.txtBxMaxPoints.TabIndex = 66
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(38, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 19)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Event Location"
        '
        'txtBxLocation
        '
        Me.txtBxLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtBxLocation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxLocation.ForeColor = System.Drawing.Color.White
        Me.txtBxLocation.Location = New System.Drawing.Point(42, 366)
        Me.txtBxLocation.Name = "txtBxLocation"
        Me.txtBxLocation.Size = New System.Drawing.Size(292, 22)
        Me.txtBxLocation.TabIndex = 68
        '
        'chcBxCompleted
        '
        Me.chcBxCompleted.AutoSize = True
        Me.chcBxCompleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chcBxCompleted.ForeColor = System.Drawing.Color.White
        Me.chcBxCompleted.Location = New System.Drawing.Point(42, 476)
        Me.chcBxCompleted.Name = "chcBxCompleted"
        Me.chcBxCompleted.Size = New System.Drawing.Size(134, 21)
        Me.chcBxCompleted.TabIndex = 70
        Me.chcBxCompleted.Text = "Event Completed"
        Me.chcBxCompleted.UseVisualStyleBackColor = True
        '
        'btnNewRecord
        '
        Me.btnNewRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnNewRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewRecord.FlatAppearance.BorderSize = 0
        Me.btnNewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewRecord.ForeColor = System.Drawing.Color.White
        Me.btnNewRecord.Location = New System.Drawing.Point(471, 447)
        Me.btnNewRecord.Name = "btnNewRecord"
        Me.btnNewRecord.Size = New System.Drawing.Size(117, 23)
        Me.btnNewRecord.TabIndex = 71
        Me.btnNewRecord.Text = "New Record"
        Me.btnNewRecord.UseVisualStyleBackColor = False
        '
        'dtEventDate
        '
        Me.dtEventDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtEventDate.Location = New System.Drawing.Point(42, 259)
        Me.dtEventDate.Name = "dtEventDate"
        Me.dtEventDate.Size = New System.Drawing.Size(292, 23)
        Me.dtEventDate.TabIndex = 72
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblAdminAccount)
        Me.Panel1.Controls.Add(Me.lblLoggedInAs)
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Location = New System.Drawing.Point(0, 616)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(631, 68)
        Me.Panel1.TabIndex = 73
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
        Me.btnLogOut.Location = New System.Drawing.Point(491, 14)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(117, 38)
        Me.btnLogOut.TabIndex = 4
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'EventsPG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(629, 683)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtEventDate)
        Me.Controls.Add(Me.btnNewRecord)
        Me.Controls.Add(Me.chcBxCompleted)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBxLocation)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBxMaxPoints)
        Me.Controls.Add(Me.cmbBxTeam)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBxRecordID)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnDeleteRecord)
        Me.Controls.Add(Me.btnUpdateRecord)
        Me.Controls.Add(Me.btnAddRecord)
        Me.Controls.Add(Me.btnPrevRecord)
        Me.Controls.Add(Me.btnNextRecord)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBxEventName)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EventsPG"
        Me.Text = "LoginReg"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents txtBxRecordID As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnDeleteRecord As Button
    Friend WithEvents btnUpdateRecord As Button
    Friend WithEvents btnAddRecord As Button
    Friend WithEvents btnPrevRecord As Button
    Friend WithEvents btnNextRecord As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBxEventName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbBxTeam As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBxMaxPoints As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtBxLocation As TextBox
    Friend WithEvents chcBxCompleted As CheckBox
    Friend WithEvents btnNewRecord As Button
    Friend WithEvents dtEventDate As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAdminAccount As Label
    Friend WithEvents lblLoggedInAs As Label
    Friend WithEvents btnLogOut As Button
End Class
