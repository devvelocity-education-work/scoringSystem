<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Teams
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLoggedInAs = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAdminAccount = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBxTeamName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBxPoints = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBxGamesWon = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBxGamePodium = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbBxM1ID = New System.Windows.Forms.ComboBox()
        Me.cmbBxM2ID = New System.Windows.Forms.ComboBox()
        Me.cmbBxM3ID = New System.Windows.Forms.ComboBox()
        Me.cmbBxM4ID = New System.Windows.Forms.ComboBox()
        Me.txtTeamID = New System.Windows.Forms.TextBox()
        Me.btnAddRecord = New System.Windows.Forms.Button()
        Me.btnNewRecord = New System.Windows.Forms.Button()
        Me.txtBxUserName1 = New System.Windows.Forms.TextBox()
        Me.txtBxUserName2 = New System.Windows.Forms.TextBox()
        Me.txtBxUserName3 = New System.Windows.Forms.TextBox()
        Me.txtBxUserName4 = New System.Windows.Forms.TextBox()
        Me.btnRemove1 = New System.Windows.Forms.Button()
        Me.btnRemove2 = New System.Windows.Forms.Button()
        Me.btnRemove3 = New System.Windows.Forms.Button()
        Me.btnRemove4 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLogOut = New System.Windows.Forms.PictureBox()
        Me.btnDeleteRecord = New System.Windows.Forms.PictureBox()
        Me.btnUpdateRecord = New System.Windows.Forms.PictureBox()
        Me.btnPrevRecord = New System.Windows.Forms.PictureBox()
        Me.btnNextRecord = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLogOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDeleteRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnUpdateRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnPrevRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNextRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(34, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 45)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Teams"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.lblAdminAccount)
        Me.Panel1.Controls.Add(Me.lblLoggedInAs)
        Me.Panel1.Location = New System.Drawing.Point(-2, 525)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(601, 73)
        Me.Panel1.TabIndex = 11
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
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(39, 164)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 19)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Team"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(34, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 19)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Team Name"
        '
        'txtBxTeamName
        '
        Me.txtBxTeamName.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.txtBxTeamName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxTeamName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxTeamName.ForeColor = System.Drawing.Color.White
        Me.txtBxTeamName.Location = New System.Drawing.Point(38, 237)
        Me.txtBxTeamName.Name = "txtBxTeamName"
        Me.txtBxTeamName.Size = New System.Drawing.Size(292, 22)
        Me.txtBxTeamName.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(34, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 19)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Points"
        '
        'txtBxPoints
        '
        Me.txtBxPoints.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtBxPoints.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxPoints.Cursor = System.Windows.Forms.Cursors.No
        Me.txtBxPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxPoints.ForeColor = System.Drawing.Color.White
        Me.txtBxPoints.Location = New System.Drawing.Point(38, 430)
        Me.txtBxPoints.Name = "txtBxPoints"
        Me.txtBxPoints.ReadOnly = True
        Me.txtBxPoints.Size = New System.Drawing.Size(67, 22)
        Me.txtBxPoints.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(129, 408)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 19)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Games Won"
        '
        'txtBxGamesWon
        '
        Me.txtBxGamesWon.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtBxGamesWon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxGamesWon.Cursor = System.Windows.Forms.Cursors.No
        Me.txtBxGamesWon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxGamesWon.ForeColor = System.Drawing.Color.White
        Me.txtBxGamesWon.Location = New System.Drawing.Point(133, 430)
        Me.txtBxGamesWon.Name = "txtBxGamesWon"
        Me.txtBxGamesWon.ReadOnly = True
        Me.txtBxGamesWon.Size = New System.Drawing.Size(67, 22)
        Me.txtBxGamesWon.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(236, 408)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 19)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Games on Podium"
        '
        'txtBxGamePodium
        '
        Me.txtBxGamePodium.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtBxGamePodium.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxGamePodium.Cursor = System.Windows.Forms.Cursors.No
        Me.txtBxGamePodium.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxGamePodium.ForeColor = System.Drawing.Color.White
        Me.txtBxGamePodium.Location = New System.Drawing.Point(240, 430)
        Me.txtBxGamePodium.Name = "txtBxGamePodium"
        Me.txtBxGamePodium.ReadOnly = True
        Me.txtBxGamePodium.Size = New System.Drawing.Size(67, 22)
        Me.txtBxGamePodium.TabIndex = 52
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(34, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 19)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Team Members"
        '
        'cmbBxM1ID
        '
        Me.cmbBxM1ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.cmbBxM1ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBxM1ID.ForeColor = System.Drawing.Color.White
        Me.cmbBxM1ID.FormattingEnabled = True
        Me.cmbBxM1ID.Location = New System.Drawing.Point(68, 291)
        Me.cmbBxM1ID.MaxDropDownItems = 100
        Me.cmbBxM1ID.Name = "cmbBxM1ID"
        Me.cmbBxM1ID.Size = New System.Drawing.Size(187, 21)
        Me.cmbBxM1ID.TabIndex = 56
        '
        'cmbBxM2ID
        '
        Me.cmbBxM2ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.cmbBxM2ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBxM2ID.ForeColor = System.Drawing.Color.White
        Me.cmbBxM2ID.FormattingEnabled = True
        Me.cmbBxM2ID.Location = New System.Drawing.Point(68, 318)
        Me.cmbBxM2ID.MaxDropDownItems = 100
        Me.cmbBxM2ID.Name = "cmbBxM2ID"
        Me.cmbBxM2ID.Size = New System.Drawing.Size(187, 21)
        Me.cmbBxM2ID.TabIndex = 58
        '
        'cmbBxM3ID
        '
        Me.cmbBxM3ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.cmbBxM3ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBxM3ID.ForeColor = System.Drawing.Color.White
        Me.cmbBxM3ID.FormattingEnabled = True
        Me.cmbBxM3ID.Location = New System.Drawing.Point(68, 345)
        Me.cmbBxM3ID.MaxDropDownItems = 100
        Me.cmbBxM3ID.Name = "cmbBxM3ID"
        Me.cmbBxM3ID.Size = New System.Drawing.Size(187, 21)
        Me.cmbBxM3ID.TabIndex = 60
        '
        'cmbBxM4ID
        '
        Me.cmbBxM4ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.cmbBxM4ID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBxM4ID.ForeColor = System.Drawing.Color.White
        Me.cmbBxM4ID.FormattingEnabled = True
        Me.cmbBxM4ID.Location = New System.Drawing.Point(68, 372)
        Me.cmbBxM4ID.MaxDropDownItems = 100
        Me.cmbBxM4ID.Name = "cmbBxM4ID"
        Me.cmbBxM4ID.Size = New System.Drawing.Size(187, 21)
        Me.cmbBxM4ID.TabIndex = 62
        '
        'txtTeamID
        '
        Me.txtTeamID.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtTeamID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTeamID.Cursor = System.Windows.Forms.Cursors.No
        Me.txtTeamID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeamID.ForeColor = System.Drawing.Color.White
        Me.txtTeamID.Location = New System.Drawing.Point(38, 186)
        Me.txtTeamID.Name = "txtTeamID"
        Me.txtTeamID.ReadOnly = True
        Me.txtTeamID.Size = New System.Drawing.Size(69, 22)
        Me.txtTeamID.TabIndex = 70
        Me.txtTeamID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAddRecord
        '
        Me.btnAddRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAddRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddRecord.Enabled = False
        Me.btnAddRecord.FlatAppearance.BorderSize = 0
        Me.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRecord.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnAddRecord.Location = New System.Drawing.Point(441, 399)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.Size = New System.Drawing.Size(117, 23)
        Me.btnAddRecord.TabIndex = 73
        Me.btnAddRecord.Text = "Add Record"
        Me.btnAddRecord.UseVisualStyleBackColor = False
        '
        'btnNewRecord
        '
        Me.btnNewRecord.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnNewRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewRecord.FlatAppearance.BorderSize = 0
        Me.btnNewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewRecord.ForeColor = System.Drawing.Color.White
        Me.btnNewRecord.Location = New System.Drawing.Point(441, 370)
        Me.btnNewRecord.Name = "btnNewRecord"
        Me.btnNewRecord.Size = New System.Drawing.Size(117, 23)
        Me.btnNewRecord.TabIndex = 76
        Me.btnNewRecord.Text = "New Record"
        Me.btnNewRecord.UseVisualStyleBackColor = False
        '
        'txtBxUserName1
        '
        Me.txtBxUserName1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtBxUserName1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxUserName1.Cursor = System.Windows.Forms.Cursors.No
        Me.txtBxUserName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxUserName1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.txtBxUserName1.Location = New System.Drawing.Point(270, 290)
        Me.txtBxUserName1.Name = "txtBxUserName1"
        Me.txtBxUserName1.ReadOnly = True
        Me.txtBxUserName1.Size = New System.Drawing.Size(37, 22)
        Me.txtBxUserName1.TabIndex = 77
        '
        'txtBxUserName2
        '
        Me.txtBxUserName2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtBxUserName2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxUserName2.Cursor = System.Windows.Forms.Cursors.No
        Me.txtBxUserName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxUserName2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.txtBxUserName2.Location = New System.Drawing.Point(270, 318)
        Me.txtBxUserName2.Name = "txtBxUserName2"
        Me.txtBxUserName2.ReadOnly = True
        Me.txtBxUserName2.Size = New System.Drawing.Size(37, 22)
        Me.txtBxUserName2.TabIndex = 78
        '
        'txtBxUserName3
        '
        Me.txtBxUserName3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtBxUserName3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxUserName3.Cursor = System.Windows.Forms.Cursors.No
        Me.txtBxUserName3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxUserName3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.txtBxUserName3.Location = New System.Drawing.Point(270, 345)
        Me.txtBxUserName3.Name = "txtBxUserName3"
        Me.txtBxUserName3.ReadOnly = True
        Me.txtBxUserName3.Size = New System.Drawing.Size(37, 22)
        Me.txtBxUserName3.TabIndex = 79
        '
        'txtBxUserName4
        '
        Me.txtBxUserName4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtBxUserName4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBxUserName4.Cursor = System.Windows.Forms.Cursors.No
        Me.txtBxUserName4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxUserName4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.txtBxUserName4.Location = New System.Drawing.Point(270, 372)
        Me.txtBxUserName4.Name = "txtBxUserName4"
        Me.txtBxUserName4.ReadOnly = True
        Me.txtBxUserName4.Size = New System.Drawing.Size(37, 22)
        Me.txtBxUserName4.TabIndex = 80
        '
        'btnRemove1
        '
        Me.btnRemove1.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnRemove1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove1.FlatAppearance.BorderSize = 0
        Me.btnRemove1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove1.ForeColor = System.Drawing.Color.White
        Me.btnRemove1.Location = New System.Drawing.Point(38, 289)
        Me.btnRemove1.Name = "btnRemove1"
        Me.btnRemove1.Size = New System.Drawing.Size(24, 23)
        Me.btnRemove1.TabIndex = 83
        Me.btnRemove1.Text = "X"
        Me.btnRemove1.UseVisualStyleBackColor = False
        '
        'btnRemove2
        '
        Me.btnRemove2.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnRemove2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove2.FlatAppearance.BorderSize = 0
        Me.btnRemove2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove2.ForeColor = System.Drawing.Color.White
        Me.btnRemove2.Location = New System.Drawing.Point(38, 318)
        Me.btnRemove2.Name = "btnRemove2"
        Me.btnRemove2.Size = New System.Drawing.Size(24, 23)
        Me.btnRemove2.TabIndex = 84
        Me.btnRemove2.Text = "X"
        Me.btnRemove2.UseVisualStyleBackColor = False
        '
        'btnRemove3
        '
        Me.btnRemove3.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnRemove3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove3.FlatAppearance.BorderSize = 0
        Me.btnRemove3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove3.ForeColor = System.Drawing.Color.White
        Me.btnRemove3.Location = New System.Drawing.Point(38, 345)
        Me.btnRemove3.Name = "btnRemove3"
        Me.btnRemove3.Size = New System.Drawing.Size(24, 23)
        Me.btnRemove3.TabIndex = 85
        Me.btnRemove3.Text = "X"
        Me.btnRemove3.UseVisualStyleBackColor = False
        '
        'btnRemove4
        '
        Me.btnRemove4.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnRemove4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove4.FlatAppearance.BorderSize = 0
        Me.btnRemove4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove4.ForeColor = System.Drawing.Color.White
        Me.btnRemove4.Location = New System.Drawing.Point(38, 372)
        Me.btnRemove4.Name = "btnRemove4"
        Me.btnRemove4.Size = New System.Drawing.Size(24, 23)
        Me.btnRemove4.TabIndex = 86
        Me.btnRemove4.Text = "X"
        Me.btnRemove4.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.scoringsystem4.My.Resources.Resources.backbutton
        Me.PictureBox3.Location = New System.Drawing.Point(38, 44)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(117, 25)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 99
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.scoringsystem4.My.Resources.Resources.ES
        Me.PictureBox1.Location = New System.Drawing.Point(454, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 87
        Me.PictureBox1.TabStop = False
        '
        'btnLogOut
        '
        Me.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogOut.Image = Global.scoringsystem4.My.Resources.Resources.log_out
        Me.btnLogOut.Location = New System.Drawing.Point(438, 14)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(151, 38)
        Me.btnLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnLogOut.TabIndex = 82
        Me.btnLogOut.TabStop = False
        '
        'btnDeleteRecord
        '
        Me.btnDeleteRecord.Image = Global.scoringsystem4.My.Resources.Resources.Delete
        Me.btnDeleteRecord.Location = New System.Drawing.Point(441, 307)
        Me.btnDeleteRecord.Name = "btnDeleteRecord"
        Me.btnDeleteRecord.Size = New System.Drawing.Size(117, 30)
        Me.btnDeleteRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnDeleteRecord.TabIndex = 107
        Me.btnDeleteRecord.TabStop = False
        '
        'btnUpdateRecord
        '
        Me.btnUpdateRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateRecord.Image = Global.scoringsystem4.My.Resources.Resources.update
        Me.btnUpdateRecord.Location = New System.Drawing.Point(441, 271)
        Me.btnUpdateRecord.Name = "btnUpdateRecord"
        Me.btnUpdateRecord.Size = New System.Drawing.Size(117, 30)
        Me.btnUpdateRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnUpdateRecord.TabIndex = 106
        Me.btnUpdateRecord.TabStop = False
        '
        'btnPrevRecord
        '
        Me.btnPrevRecord.Image = Global.scoringsystem4.My.Resources.Resources.prevbutton
        Me.btnPrevRecord.Location = New System.Drawing.Point(441, 220)
        Me.btnPrevRecord.Name = "btnPrevRecord"
        Me.btnPrevRecord.Size = New System.Drawing.Size(117, 28)
        Me.btnPrevRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnPrevRecord.TabIndex = 105
        Me.btnPrevRecord.TabStop = False
        '
        'btnNextRecord
        '
        Me.btnNextRecord.Image = Global.scoringsystem4.My.Resources.Resources.nextbutton
        Me.btnNextRecord.Location = New System.Drawing.Point(441, 186)
        Me.btnNextRecord.Name = "btnNextRecord"
        Me.btnNextRecord.Size = New System.Drawing.Size(117, 28)
        Me.btnNextRecord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnNextRecord.TabIndex = 104
        Me.btnNextRecord.TabStop = False
        '
        'Teams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(599, 593)
        Me.Controls.Add(Me.btnDeleteRecord)
        Me.Controls.Add(Me.btnUpdateRecord)
        Me.Controls.Add(Me.btnPrevRecord)
        Me.Controls.Add(Me.btnNextRecord)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnRemove4)
        Me.Controls.Add(Me.btnRemove3)
        Me.Controls.Add(Me.btnRemove2)
        Me.Controls.Add(Me.btnRemove1)
        Me.Controls.Add(Me.txtBxUserName4)
        Me.Controls.Add(Me.txtBxUserName3)
        Me.Controls.Add(Me.txtBxUserName2)
        Me.Controls.Add(Me.txtBxUserName1)
        Me.Controls.Add(Me.btnNewRecord)
        Me.Controls.Add(Me.btnAddRecord)
        Me.Controls.Add(Me.txtTeamID)
        Me.Controls.Add(Me.cmbBxM4ID)
        Me.Controls.Add(Me.cmbBxM3ID)
        Me.Controls.Add(Me.cmbBxM2ID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbBxM1ID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBxGamePodium)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBxGamesWon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBxPoints)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBxTeamName)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Teams"
        Me.Text = "5"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLogOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDeleteRecord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnUpdateRecord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnPrevRecord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNextRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblLoggedInAs As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBxTeamName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBxPoints As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBxGamesWon As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBxGamePodium As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbBxM1ID As ComboBox
    Friend WithEvents cmbBxM2ID As ComboBox
    Friend WithEvents cmbBxM3ID As ComboBox
    Friend WithEvents cmbBxM4ID As ComboBox
    Friend WithEvents txtTeamID As TextBox
    Friend WithEvents btnAddRecord As Button
    Friend WithEvents btnNewRecord As Button
    Friend WithEvents txtBxUserName1 As TextBox
    Friend WithEvents txtBxUserName2 As TextBox
    Friend WithEvents txtBxUserName3 As TextBox
    Friend WithEvents txtBxUserName4 As TextBox
    Friend WithEvents lblAdminAccount As Label
    Friend WithEvents btnRemove1 As Button
    Friend WithEvents btnRemove2 As Button
    Friend WithEvents btnRemove3 As Button
    Friend WithEvents btnRemove4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogOut As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnDeleteRecord As PictureBox
    Friend WithEvents btnUpdateRecord As PictureBox
    Friend WithEvents btnPrevRecord As PictureBox
    Friend WithEvents btnNextRecord As PictureBox
End Class
