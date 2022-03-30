<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scoreboard
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DGIndividuals = New System.Windows.Forms.DataGridView()
        Me.MemberID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Points = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GamesWon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GamesOnPodium = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGTeams = New System.Windows.Forms.DataGridView()
        Me.TeamID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeamName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PointsTeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GamesTeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GamesOnPodiumTeam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAdminAccount = New System.Windows.Forms.Label()
        Me.lblLoggedInAs = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGIndividuals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGTeams, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(42, 39)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(117, 23)
        Me.btnBack.TabIndex = 16
        Me.btnBack.Text = "< Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(34, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 45)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Scoreboard"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.scoringsystem4.My.Resources.Resources.Event_Scoring_logos_white
        Me.PictureBox1.Location = New System.Drawing.Point(807, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 103)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'DGIndividuals
        '
        Me.DGIndividuals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGIndividuals.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MemberID, Me.Username, Me.Points, Me.GamesWon, Me.GamesOnPodium})
        Me.DGIndividuals.Location = New System.Drawing.Point(42, 208)
        Me.DGIndividuals.Name = "DGIndividuals"
        Me.DGIndividuals.Size = New System.Drawing.Size(540, 229)
        Me.DGIndividuals.TabIndex = 20
        '
        'MemberID
        '
        Me.MemberID.HeaderText = "MemberID"
        Me.MemberID.Name = "MemberID"
        '
        'Username
        '
        Me.Username.HeaderText = "Username"
        Me.Username.Name = "Username"
        '
        'Points
        '
        Me.Points.HeaderText = "Points"
        Me.Points.Name = "Points"
        '
        'GamesWon
        '
        Me.GamesWon.HeaderText = "GamesWon"
        Me.GamesWon.Name = "GamesWon"
        '
        'GamesOnPodium
        '
        Me.GamesOnPodium.HeaderText = "GamesOnPodium"
        Me.GamesOnPodium.Name = "GamesOnPodium"
        '
        'DGTeams
        '
        Me.DGTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTeams.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TeamID, Me.TeamName, Me.PointsTeam, Me.GamesTeam, Me.GamesOnPodiumTeam})
        Me.DGTeams.Location = New System.Drawing.Point(42, 505)
        Me.DGTeams.Name = "DGTeams"
        Me.DGTeams.Size = New System.Drawing.Size(540, 225)
        Me.DGTeams.TabIndex = 21
        '
        'TeamID
        '
        Me.TeamID.HeaderText = "TeamID"
        Me.TeamID.Name = "TeamID"
        '
        'TeamName
        '
        Me.TeamName.HeaderText = "TeamName"
        Me.TeamName.Name = "TeamName"
        '
        'PointsTeam
        '
        Me.PointsTeam.HeaderText = "Points"
        Me.PointsTeam.Name = "PointsTeam"
        '
        'GamesTeam
        '
        Me.GamesTeam.HeaderText = "GamesWon"
        Me.GamesTeam.Name = "GamesTeam"
        '
        'GamesOnPodiumTeam
        '
        Me.GamesOnPodiumTeam.HeaderText = "GamesOnPoidium"
        Me.GamesOnPodiumTeam.Name = "GamesOnPodiumTeam"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(38, 186)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 19)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Individuals"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 483)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 19)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Teams"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblAdminAccount)
        Me.Panel1.Controls.Add(Me.lblLoggedInAs)
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Location = New System.Drawing.Point(-2, 804)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1051, 67)
        Me.Panel1.TabIndex = 54
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
        Me.lblLoggedInAs.Location = New System.Drawing.Point(28, 14)
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
        Me.btnLogOut.Location = New System.Drawing.Point(921, 14)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(117, 38)
        Me.btnLogOut.TabIndex = 4
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'Scoreboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1048, 869)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.DGTeams)
        Me.Controls.Add(Me.DGIndividuals)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Scoreboard"
        Me.Text = "Scoreboard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGIndividuals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGTeams, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DGIndividuals As DataGridView
    Friend WithEvents MemberID As DataGridViewTextBoxColumn
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents Points As DataGridViewTextBoxColumn
    Friend WithEvents GamesWon As DataGridViewTextBoxColumn
    Friend WithEvents GamesOnPodium As DataGridViewTextBoxColumn
    Friend WithEvents DGTeams As DataGridView
    Friend WithEvents TeamID As DataGridViewTextBoxColumn
    Friend WithEvents TeamName As DataGridViewTextBoxColumn
    Friend WithEvents PointsTeam As DataGridViewTextBoxColumn
    Friend WithEvents GamesTeam As DataGridViewTextBoxColumn
    Friend WithEvents GamesOnPodiumTeam As DataGridViewTextBoxColumn
    Friend WithEvents Label15 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAdminAccount As Label
    Friend WithEvents lblLoggedInAs As Label
    Friend WithEvents btnLogOut As Button
End Class
