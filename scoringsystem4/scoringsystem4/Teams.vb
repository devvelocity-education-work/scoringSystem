Public Class Teams

    Dim maxRows As Integer
    Dim maxColumns As Integer
    Dim con As New OleDb.OleDbConnection
    Dim dsMembers As New DataSet
    Dim daMembers As New OleDb.OleDbDataAdapter
    Dim daTeams As New OleDb.OleDbDataAdapter
    Dim sql As String

    Dim dsTeams As New DataSet
    Dim sqlTeams As String


    Dim teamsRow As Integer = 1

    Dim rcrdEditing = False

    Dim teamsCount As Integer = 0

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        HomePage.Show()
        Me.Close()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs)
        If rcrdEditing = True Then
            If MessageBox.Show("Are you sure you want to log out? This will end 'New Record' and entered data will be lost", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                rcrdEditing = False
                GetTeamInfo()
                Me.Close()
                Login.Show()
                Login.txtBxUsername.Clear()
                Login.txtBxPassword.Clear()
            End If
        Else
            If MessageBox.Show("Are you sure you want to log out?", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                rcrdEditing = False
                GetTeamInfo()
                Me.Close()

                Login.Show()
                Login.txtBxUsername.Clear()
                Login.txtBxPassword.Clear()
            End If
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtBxFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtBxTeamName.TextChanged

    End Sub

    Private Sub txtBxPoints_TextChanged(sender As Object, e As EventArgs) Handles txtBxPoints.TextChanged

    End Sub

    Private Sub txtBxGamesWon_TextChanged(sender As Object, e As EventArgs) Handles txtBxGamesWon.TextChanged

    End Sub

    Private Sub txtBxGamePodium_TextChanged(sender As Object, e As EventArgs) Handles txtBxGamePodium.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Function GetTeamMember(memberID As String)
        For intIndex = 0 To dsMembers.Tables("DSMembers").Rows.Count - 1
            If dsMembers.Tables("DSMembers").Rows(intIndex).Item(1) = memberID Then
                Return dsMembers.Tables("DSMembers").Rows(intIndex).Item(0)
            End If
        Next
    End Function

    Private Sub Teams_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Open connection to the Access File / Database
        'con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\U4 A2\scoringsystem4\Database\scoringSystemDatabase.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\U4 A2\scoringsystem4\Database\scoringSystemDatabase.accdb"
        'con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\scoringSystem4\scoringsystem4\Database\scoringSystemDatabase.accdb"
        con.Open()
        sql = "SELECT * FROM tblMembers"
        daMembers = New OleDb.OleDbDataAdapter(sql, con)
        daMembers.Fill(dsMembers, "DSMembers")

        'aaxRows = dsMembers.Tables("DSMembers").Rows.Count
        'MsgBox("The number of max rows are " & maxRows)
        'maxColumns = dsMembers.Tables("DSMembers").Columns.Count
        'MsgBox("The number of columns are " & maxColumns)


        sqlTeams = "SELECT * FROM tblTeams"
        daTeams = New OleDb.OleDbDataAdapter(sqlTeams, con)
        daTeams.Fill(dsTeams, "DSTeams")

        maxRows = dsTeams.Tables("DSTeams").Rows.Count
        maxColumns = dsMembers.Tables("DSMembers").Columns.Count

        'sgBox("Teams - The number of max rows are " & maxRows)

        teamsRow = 1
        ' txtTeamID.Text = dsTeams.Tables("DSTeams").Rows(teamsRow).Item(0)

        'Close the connection
        con.Close()


        Dim membersAdded As Integer

        membersAdded = 0

        Dim intIndex, intIndex2 As Integer


        ' Go through members table and find if the Team ID of a member matches one in the team selected
        For intIndex = 0 To dsMembers.Tables("DSMembers").Rows.Count - 1
            For intIndex2 = 0 To dsMembers.Tables("DSMembers").Rows(intIndex).ItemArray.Length
                Dim intTeamNumber = dsMembers.Tables("DSMembers").Rows(intIndex).Item(15)

                If intTeamNumber = dsTeams.Tables("DSTeams").Rows(teamsRow).Item(0) Then
                    If membersAdded = 0 Then
                        cmbBxM1ID.Text = dsMembers.Tables("DSMembers").Rows(intIndex2).Item(1)
                        txtBxUserName1.Text = dsMembers.Tables("DSMembers").Rows(intIndex2).Item(0)
                    ElseIf membersAdded = 1 Then
                        cmbBxM2ID.Text = dsMembers.Tables("DSMembers").Rows(intIndex2).Item(1)
                        txtBxUserName2.Text = dsMembers.Tables("DSMembers").Rows(intIndex2).Item(0)
                    ElseIf membersAdded = 2 Then
                        cmbBxM3ID.Text = dsMembers.Tables("DSMembers").Rows(intIndex2).Item(1)
                        txtBxUserName3.Text = dsMembers.Tables("DSMembers").Rows(intIndex2).Item(0)
                    ElseIf membersAdded = 3 Then
                        cmbBxM4ID.Text = dsMembers.Tables("DSMembers").Rows(intIndex2).Item(1)
                        txtBxUserName4.Text = dsMembers.Tables("DSMembers").Rows(intIndex2).Item(0)
                    End If
                    membersAdded = membersAdded + 1
                End If
            Next
        Next

        'Warning if more than 4 team members are in one team on accident 

        'Clear Member Choice Dropdowns
        cmbBxM1ID.Items.Clear()
        cmbBxM2ID.Items.Clear()
        cmbBxM3ID.Items.Clear()
        cmbBxM4ID.Items.Clear()

        ' Add Member Choices to Dropdown Boxes
        For intIndex = 0 To dsMembers.Tables("DSMembers").Rows.Count - 1
            cmbBxM1ID.Items.Add(dsMembers.Tables("DSMembers").Rows(intIndex).Item(1))
            cmbBxM2ID.Items.Add(dsMembers.Tables("DSMembers").Rows(intIndex).Item(1))
            cmbBxM3ID.Items.Add(dsMembers.Tables("DSMembers").Rows(intIndex).Item(1))
            cmbBxM4ID.Items.Add(dsMembers.Tables("DSMembers").Rows(intIndex).Item(1))
        Next

        txtBxTeamName.Text = dsTeams.Tables("DSTeams").Rows(teamsRow).Item(1)
        txtBxPoints.Text = dsTeams.Tables("DSTeams").Rows(teamsRow).Item(2)
        txtBxGamesWon.Text = dsTeams.Tables("DSTeams").Rows(teamsRow).Item(3)
        txtBxGamePodium.Text = dsTeams.Tables("DSTeams").Rows(teamsRow).Item(4)

        txtTeamID.Text = teamsCount + 1


        If Login.isAdminLoggedIn = True Then

            cmbBxM1ID.Enabled = True
            cmbBxM2ID.Enabled = True
            cmbBxM3ID.Enabled = True
            cmbBxM4ID.Enabled = True

            txtBxTeamName.Enabled = True


            txtBxPoints.BackColor = Color.FromArgb(70, 70, 70)
            txtBxPoints.Cursor = Cursors.IBeam
            txtBxPoints.ForeColor = Color.FromArgb(255, 255, 255)
            txtBxPoints.ReadOnly = False

            txtBxGamePodium.BackColor = Color.FromArgb(70, 70, 70)
            txtBxGamePodium.Cursor = Cursors.IBeam
            txtBxGamePodium.ForeColor = Color.FromArgb(255, 255, 255)
            txtBxGamePodium.ReadOnly = False

            txtBxGamesWon.BackColor = Color.FromArgb(70, 70, 70)
            txtBxGamesWon.Cursor = Cursors.IBeam
            txtBxGamesWon.ForeColor = Color.FromArgb(255, 255, 255)
            txtBxGamesWon.ReadOnly = False

            btnNewRecord.Enabled = True
            btnNewRecord.BackColor = Color.FromArgb(180, 40, 40)
            btnNewRecord.ForeColor = Color.FromArgb(255, 255, 255)
            btnNewRecord.Cursor = Cursors.Hand

            btnUpdateRecord.Enabled = True
            btnUpdateRecord.Cursor = Cursors.Hand

            btnDeleteRecord.Enabled = True
            btnDeleteRecord.Cursor = Cursors.Hand

            btnRemove1.Enabled = True
            btnRemove2.Enabled = True
            btnRemove3.Enabled = True
            btnRemove4.Enabled = True

            btnRemove1.BackColor = Color.FromArgb(180, 40, 40)
            btnRemove2.BackColor = Color.FromArgb(180, 40, 40)
            btnRemove3.BackColor = Color.FromArgb(180, 40, 40)
            btnRemove4.BackColor = Color.FromArgb(180, 40, 40)

            btnRemove1.ForeColor = Color.FromArgb(255, 255, 255)
            btnRemove2.ForeColor = Color.FromArgb(255, 255, 255)
            btnRemove3.ForeColor = Color.FromArgb(255, 255, 255)
            btnRemove4.ForeColor = Color.FromArgb(255, 255, 255)

            txtBxUserName1.Show()
            txtBxUserName2.Show()
            txtBxUserName3.Show()
            txtBxUserName4.Show()


        Else

            cmbBxM1ID.Enabled = False
            cmbBxM2ID.Enabled = False
            cmbBxM3ID.Enabled = False
            cmbBxM4ID.Enabled = False

            txtBxTeamName.Enabled = False



            btnNewRecord.Enabled = False
            btnNewRecord.BackColor = Color.FromArgb(50, 50, 50)
            btnNewRecord.ForeColor = Color.FromArgb(100, 100, 100)
            btnNewRecord.Cursor = Cursors.No

            btnUpdateRecord.Enabled = False
            btnUpdateRecord.Cursor = Cursors.No

            btnDeleteRecord.Enabled = False
            btnDeleteRecord.Cursor = Cursors.No

            btnRemove1.BackColor = Color.FromArgb(50, 50, 50)
            btnRemove2.BackColor = Color.FromArgb(50, 50, 50)
            btnRemove3.BackColor = Color.FromArgb(50, 50, 50)
            btnRemove4.BackColor = Color.FromArgb(50, 50, 50)

            btnRemove1.ForeColor = Color.FromArgb(100, 100, 100)
            btnRemove2.ForeColor = Color.FromArgb(100, 100, 100)
            btnRemove3.ForeColor = Color.FromArgb(100, 100, 100)
            btnRemove4.ForeColor = Color.FromArgb(100, 100, 100)

            btnRemove1.Enabled = False
            btnRemove2.Enabled = False
            btnRemove3.Enabled = False
            btnRemove4.Enabled = False

            txtBxUserName1.Hide()
            txtBxUserName2.Hide()
            txtBxUserName3.Hide()
            txtBxUserName4.Hide()



        End If





    End Sub

    Sub GetTeamInfo()


        ' Clear Team Dropdown Text Fields
        cmbBxM1ID.Text = ""
        cmbBxM2ID.Text = ""
        cmbBxM3ID.Text = ""
        cmbBxM4ID.Text = ""

        txtBxUserName1.Clear()
        txtBxUserName2.Clear()
        txtBxUserName3.Clear()
        txtBxUserName4.Clear()

        'Append Team Info
        txtTeamID.Text = dsTeams.Tables("DSTeams").Rows(teamsRow).Item(0)
        txtBxTeamName.Text = dsTeams.Tables("DSTeams").Rows(teamsRow).Item(1)
        txtBxPoints.Text = dsTeams.Tables("DSTeams").Rows(teamsRow).Item(2)
        txtBxGamesWon.Text = dsTeams.Tables("DSTeams").Rows(teamsRow).Item(3)
        txtBxGamePodium.Text = dsTeams.Tables("DSTeams").Rows(teamsRow).Item(4)

        Dim membersAdded As Integer

        membersAdded = 0

        Dim intIndex, intIndex2 As Integer


        'Clear Dropdown Boxes
        cmbBxM1ID.Items.Clear()
        cmbBxM2ID.Items.Clear()
        cmbBxM3ID.Items.Clear()
        cmbBxM4ID.Items.Clear()

        ' Go through members table and find if the Team ID of a member matches one in the team selected
        For intIndex = 0 To (dsMembers.Tables("DSMembers").Rows.Count) - 1
            Dim intTeamNumber = dsMembers.Tables("DSMembers").Rows(intIndex).Item(15)
            'MsgBox("int number: " & intTeamNumber & " member name: " & dsMembers.Tables("DSMembers").Rows(intIndex).Item(1) & " memberTeamID:" & dsTeams.Tables("DSTeams").Rows(teamsRow).Item(0))
            For intIndex2 = 0 To (dsMembers.Tables("DSMembers").Rows(intIndex).ItemArray.Length) - 1
                If dsTeams.Tables("DSTeams").Rows(teamsRow).Item(0) = intTeamNumber Then
                    Dim strMember As String = dsMembers.Tables("DSMembers").Rows(intIndex).Item(1)
                    Dim strID As Integer = dsMembers.Tables("DSMembers").Rows(intIndex).Item(0)
                    If membersAdded = 0 Then
                        cmbBxM1ID.Text = strMember
                        txtBxUserName1.Text = strID
                    ElseIf membersAdded = 1 Then
                        cmbBxM2ID.Text = strMember
                        txtBxUserName2.Text = strID
                    ElseIf membersAdded = 2 Then
                        cmbBxM3ID.Text = strMember
                        txtBxUserName3.Text = strID
                    ElseIf membersAdded = 3 Then
                        cmbBxM4ID.Text = strMember
                        txtBxUserName4.Text = strID
                    End If
                    membersAdded = membersAdded + 1
                    strMember = Nothing
                    Exit For
                End If
            Next
        Next

        'Warning if more than 4 team members are in one team on accident 
        If membersAdded > 4 Then
            MsgBox("Warning, there are more members in the team than can be shown in the boxes")
        End If

        ' Add Member Choices to Dropdown Boxes
        For intIndex = 0 To dsMembers.Tables("DSMembers").Rows.Count - 1
            cmbBxM1ID.Items.Add(dsMembers.Tables("DSMembers").Rows(intIndex).Item(1))
            cmbBxM2ID.Items.Add(dsMembers.Tables("DSMembers").Rows(intIndex).Item(1))
            cmbBxM3ID.Items.Add(dsMembers.Tables("DSMembers").Rows(intIndex).Item(1))
            cmbBxM4ID.Items.Add(dsMembers.Tables("DSMembers").Rows(intIndex).Item(1))
        Next
    End Sub

    Private Sub btnNextRecord_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click
        If MessageBox.Show("Please confirm you would like to create this new record - Warning: Any members already on a team will be overwritten if included in this record!", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            For i = 0 To dsMembers.Tables("DSMembers").Rows.Count - 1
                Try
                    If dsMembers.Tables("DSMembers").Rows(i).Item(15) = txtTeamID.Text Then
                        dsMembers.Tables("DSMembers").Rows(i).Item(15) = 0
                    End If
                Catch ex As Exception

                End Try
            Next

            Dim dsNewRow = dsTeams.Tables("DSTeams").NewRow()

            dsNewRow.Item("TeamID") = txtTeamID.Text
            dsNewRow.Item("TeamName") = txtBxTeamName.Text
            Try
                dsNewRow.Item("Points") = txtBxPoints.Text
            Catch ex As Exception
                dsNewRow.Item("Points") = 0
            End Try
            Try
                dsNewRow.Item("GamesWon") = txtBxGamesWon.Text
            Catch ex As Exception
                dsNewRow.Item("GamesWon") = 0
            End Try
            Try
                dsNewRow.Item("GamesOnPodium") = txtBxGamePodium.Text
            Catch ex As Exception
                dsNewRow.Item("GamesOnPodium") = 0
            End Try

            For i = 0 To dsMembers.Tables("DSMembers").Rows.Count - 1
                Try
                    If dsMembers.Tables("DSMembers").Rows(i).Item(0) = txtBxUserName1.Text Then
                        dsMembers.Tables("DSMembers").Rows(i).Item(15) = txtTeamID.Text
                    End If
                Catch ex As Exception

                End Try

                Try
                    If dsMembers.Tables("DSMembers").Rows(i).Item(0) = txtBxUserName2.Text Then
                        dsMembers.Tables("DSMembers").Rows(i).Item(15) = txtTeamID.Text
                    End If
                Catch ex As Exception

                End Try

                Try
                    If dsMembers.Tables("DSMembers").Rows(i).Item(0) = txtBxUserName3.Text Then
                        dsMembers.Tables("DSMembers").Rows(i).Item(15) = txtTeamID.Text
                    End If
                Catch ex As Exception

                End Try

                Try
                    If dsMembers.Tables("DSMembers").Rows(i).Item(0) = txtBxUserName4.Text Then
                        dsMembers.Tables("DSMembers").Rows(i).Item(15) = txtTeamID.Text
                    End If
                Catch ex As Exception

                End Try
            Next

            'Add new row to the rows
            dsTeams.Tables("DSTeams").Rows.Add(dsNewRow)

            Dim cb As New OleDb.OleDbCommandBuilder(daTeams)
            Dim cbMembers As New OleDb.OleDbCommandBuilder(daMembers)

            'Add Prefix/Suffix
            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"
            cbMembers.QuotePrefix = "["
            cbMembers.QuoteSuffix = "]"

            'Update Database
            daTeams.Update(dsTeams, "DSTeams")
            daMembers.Update(dsMembers, "DSMembers")
            dsTeams.AcceptChanges()
            dsMembers.AcceptChanges()

            MsgBox("Team has been added to the database")

            maxRows = maxRows + 1
            teamsRow = 0

            btnAddRecord.BackColor = Color.FromArgb(50, 50, 50)
            btnAddRecord.Enabled = False
            btnAddRecord.ForeColor = Color.FromArgb(100, 100, 100)
            btnAddRecord.Cursor = Cursors.No

            btnNewRecord.Text = "New Record"

            btnUpdateRecord.Enabled = True
            btnUpdateRecord.Cursor = Cursors.Arrow

            btnDeleteRecord.Enabled = True
            btnDeleteRecord.Cursor = Cursors.Arrow

            btnNextRecord.Enabled = True
            btnNextRecord.Cursor = Cursors.Arrow

            btnPrevRecord.Enabled = True
            btnPrevRecord.Cursor = Cursors.Arrow

            'set info to a data entry thats visible
            If teamsRow = maxRows - 1 Then
                teamsRow = 1
            Else
                teamsRow = teamsRow + 1
            End If

            If teamsRow = 1 Then
                teamsRow = maxRows - 1
            Else
                teamsRow = teamsRow - 1
            End If
            GetTeamInfo()


        End If
    End Sub

    Private Sub cmbBxTeam_SelectedIndexChanged(sender As Object, e As EventArgs)
        GetTeamInfo()
    End Sub

    Private Sub cmbBxM1ID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBxM1ID.SelectedIndexChanged
        txtBxUserName1.Text = GetTeamMember(cmbBxM1ID.Text)
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub btnNewRecord_Click(sender As Object, e As EventArgs) Handles btnNewRecord.Click
        If rcrdEditing = False Then
            If MessageBox.Show("Create a new record?", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                btnNewRecord.Text = "Cancel"
                btnAddRecord.Enabled = True
                btnAddRecord.BackColor = Color.FromArgb(40, 80, 150)
                btnAddRecord.ForeColor = Color.FromArgb(255, 255, 255)
                rcrdEditing = True
                txtBxTeamName.Text = ""
                cmbBxM1ID.Text = ""
                cmbBxM2ID.Text = ""
                cmbBxM3ID.Text = ""
                cmbBxM4ID.Text = ""

                txtBxUserName1.Text = ""
                txtBxUserName2.Text = ""
                txtBxUserName3.Text = ""
                txtBxUserName4.Text = ""
                txtTeamID.Text = ""
                txtBxPoints.Text = ""
                txtBxGamePodium.Text = ""
                txtBxGamesWon.Text = ""

                btnUpdateRecord.Enabled = False

                btnDeleteRecord.Enabled = False

                btnNextRecord.Enabled = False

                btnPrevRecord.Enabled = False

                txtTeamID.Text = maxRows

            End If
        ElseIf rcrdEditing = True Then
            If MessageBox.Show("Cancel creating a new record?", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                btnNewRecord.Text = "New Record"
                btnAddRecord.Enabled = False
                btnAddRecord.BackColor = Color.FromArgb(50, 50, 50)
                btnAddRecord.ForeColor = Color.FromArgb(100, 100, 100)

                btnNextRecord.Enabled = True

                btnPrevRecord.Enabled = True

                btnUpdateRecord.Enabled = True

                btnDeleteRecord.Enabled = True

                rcrdEditing = False
                GetTeamInfo()
            End If
        End If
    End Sub

    Private Sub cmbBxM2ID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBxM2ID.SelectedIndexChanged
        txtBxUserName2.Text = GetTeamMember(cmbBxM2ID.Text)
    End Sub

    Private Sub cmbBxM3ID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBxM3ID.SelectedIndexChanged
        txtBxUserName3.Text = GetTeamMember(cmbBxM3ID.Text)
    End Sub

    Private Sub cmbBxM4ID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBxM4ID.SelectedIndexChanged
        txtBxUserName4.Text = GetTeamMember(cmbBxM4ID.Text)
    End Sub

    Private Sub txtBxUserName1_TextChanged(sender As Object, e As EventArgs) Handles txtBxUserName1.TextChanged

    End Sub

    Private Sub btnUpdateRecord_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Please confirm you would like to update this record - Warning: Any members already on a team will be overwritten if included in this record!", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            dsTeams.Tables("DSTeams").Rows(teamsRow).Item(1) = txtBxTeamName.Text
            dsTeams.Tables("DSTeams").Rows(teamsRow).Item(2) = CInt(txtBxPoints.Text)
            dsTeams.Tables("DSTeams").Rows(teamsRow).Item(3) = CInt(txtBxGamesWon.Text)
            dsTeams.Tables("DSTeams").Rows(teamsRow).Item(4) = CInt(txtBxGamePodium.Text)

            Try
                dsTeams.Tables("DSTeams").Rows(teamsRow).Item(2) = txtBxPoints.Text
            Catch ex As Exception
                dsTeams.Tables("DSTeams").Rows(teamsRow).Item(2) = 0
            End Try
            Try
                dsTeams.Tables("DSTeams").Rows(teamsRow).Item(3) = txtBxGamesWon.Text
            Catch ex As Exception
                dsTeams.Tables("DSTeams").Rows(teamsRow).Item(3) = 0
            End Try
            Try
                dsTeams.Tables("DSTeams").Rows(teamsRow).Item(4) = txtBxGamePodium.Text
            Catch ex As Exception
                dsTeams.Tables("DSTeams").Rows(teamsRow).Item(4) = 0
            End Try

            For i = 0 To dsMembers.Tables("DSMembers").Rows.Count - 1
                Try
                    If dsMembers.Tables("DSMembers").Rows(i).Item(15) = txtTeamID.Text Then
                        dsMembers.Tables("DSMembers").Rows(i).Item(15) = 0
                    End If
                Catch ex As Exception

                End Try
            Next

            For i = 0 To dsMembers.Tables("DSMembers").Rows.Count - 1
                Try
                    If dsMembers.Tables("DSMembers").Rows(i).Item(0) = txtBxUserName1.Text Then
                        dsMembers.Tables("DSMembers").Rows(i).Item(15) = txtTeamID.Text
                    End If
                Catch ex As Exception

                End Try

                Try
                    If dsMembers.Tables("DSMembers").Rows(i).Item(0) = txtBxUserName2.Text Then
                        dsMembers.Tables("DSMembers").Rows(i).Item(15) = txtTeamID.Text
                    End If
                Catch ex As Exception

                End Try

                Try
                    If dsMembers.Tables("DSMembers").Rows(i).Item(0) = txtBxUserName3.Text Then
                        dsMembers.Tables("DSMembers").Rows(i).Item(15) = txtTeamID.Text
                    End If
                Catch ex As Exception

                End Try

                Try
                    If dsMembers.Tables("DSMembers").Rows(i).Item(0) = txtBxUserName4.Text Then
                        dsMembers.Tables("DSMembers").Rows(i).Item(15) = txtTeamID.Text
                    End If
                Catch ex As Exception

                End Try
            Next

            Dim cb As New OleDb.OleDbCommandBuilder(daTeams)
            Dim cbMembers As New OleDb.OleDbCommandBuilder(daMembers)

            'Add Prefix/Suffix
            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"
            cbMembers.QuotePrefix = "["
            cbMembers.QuoteSuffix = "]"

            'Update Database
            daTeams.Update(dsTeams, "DSTeams")
            daMembers.Update(dsMembers, "DSMembers")

            MsgBox("Team data has been updated")

        End If

    End Sub

    Private Sub btnDeleteRecord_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Delete this record from the database?", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            Dim intRowToDelete As Integer = teamsRow

            Dim intIterate As Integer = 0

            Dim cb As New OleDb.OleDbCommandBuilder(daTeams)


            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"
            dsTeams.Tables("DSTeams").Rows(teamsRow).Delete()
            daTeams.Update(dsTeams, "DSTeams")
            dsTeams.AcceptChanges()

            MsgBox("Team has been removed from the database")

            Dim memberIDIndex As Integer
            memberIDIndex = 0
            Dim intForIndex As Integer

            For intForIndex = 0 To dsTeams.Tables("DSTeams").Rows.Count - 1
                dsTeams.Tables("DSTeams").Rows(intForIndex).Item(0) = intForIndex
                memberIDIndex = memberIDIndex + 1
            Next

            teamsRow = teamsRow - 1

            'set info to a data entry thats visible
            If teamsRow = maxRows - 1 Then
                teamsRow = 1
            Else
                teamsRow = teamsRow + 1
            End If

            If teamsRow = 1 Then
                teamsRow = maxRows - 1
            Else
                teamsRow = teamsRow - 1
            End If
            GetTeamInfo()
            'Count Members 

            maxRows = maxRows - 1
        End If
    End Sub

    Private Sub btnNextRecord_Click_1(sender As Object, e As EventArgs)
        If teamsRow = maxRows - 1 Then
            teamsRow = 1
        Else
            teamsRow = teamsRow + 1
        End If
        GetTeamInfo()
    End Sub

    Private Sub btnPrevRecord_Click(sender As Object, e As EventArgs)
        If teamsRow = 1 Then
            teamsRow = maxRows - 1
        Else
            teamsRow = teamsRow - 1
        End If
        GetTeamInfo()

    End Sub

    Private Sub btnRemove1_Click(sender As Object, e As EventArgs) Handles btnRemove1.Click
        cmbBxM1ID.Text = ""
        txtBxUserName1.Text = ""
    End Sub

    Private Sub btnRemove2_Click(sender As Object, e As EventArgs) Handles btnRemove2.Click
        cmbBxM2ID.Text = ""
        txtBxUserName2.Text = ""
    End Sub

    Private Sub btnRemove3_Click(sender As Object, e As EventArgs) Handles btnRemove3.Click
        cmbBxM3ID.Text = ""
        txtBxUserName3.Text = ""
    End Sub

    Private Sub btnRemove4_Click(sender As Object, e As EventArgs) Handles btnRemove4.Click
        cmbBxM4ID.Text = ""
        txtBxUserName4.Text = ""
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        If rcrdEditing = True Then
            If MessageBox.Show("Are you sure you want to log out? This will end 'New Record' and entered data will be lost", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                rcrdEditing = False
                GetTeamInfo()
                Me.Close()
                Login.Show()
                Login.txtBxUsername.Clear()
                Login.txtBxPassword.Clear()
            End If
        Else
            If MessageBox.Show("Are you sure you want to log out?", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                rcrdEditing = False
                GetTeamInfo()
                Me.Close()

                Login.Show()
                Login.txtBxUsername.Clear()
                Login.txtBxPassword.Clear()
            End If
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        HomePage.Show()
        Me.Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNextRecord.Click
        If teamsRow = maxRows - 1 Then
            teamsRow = 1
        Else
            teamsRow = teamsRow + 1
        End If
        GetTeamInfo()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrevRecord.Click
        If teamsRow = 1 Then
            teamsRow = maxRows - 1
        Else
            teamsRow = teamsRow - 1
        End If
        GetTeamInfo()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdateRecord.Click
        If MessageBox.Show("Please confirm you would like to update this record - Warning: Any members already on a team will be overwritten if included in this record!", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            dsTeams.Tables("DSTeams").Rows(teamsRow).Item(1) = txtBxTeamName.Text
            dsTeams.Tables("DSTeams").Rows(teamsRow).Item(2) = CInt(txtBxPoints.Text)
            dsTeams.Tables("DSTeams").Rows(teamsRow).Item(3) = CInt(txtBxGamesWon.Text)
            dsTeams.Tables("DSTeams").Rows(teamsRow).Item(4) = CInt(txtBxGamePodium.Text)

            Try
                dsTeams.Tables("DSTeams").Rows(teamsRow).Item(2) = txtBxPoints.Text
            Catch ex As Exception
                dsTeams.Tables("DSTeams").Rows(teamsRow).Item(2) = 0
            End Try
            Try
                dsTeams.Tables("DSTeams").Rows(teamsRow).Item(3) = txtBxGamesWon.Text
            Catch ex As Exception
                dsTeams.Tables("DSTeams").Rows(teamsRow).Item(3) = 0
            End Try
            Try
                dsTeams.Tables("DSTeams").Rows(teamsRow).Item(4) = txtBxGamePodium.Text
            Catch ex As Exception
                dsTeams.Tables("DSTeams").Rows(teamsRow).Item(4) = 0
            End Try

            For i = 0 To dsMembers.Tables("DSMembers").Rows.Count - 1
                Try
                    If dsMembers.Tables("DSMembers").Rows(i).Item(15) = txtTeamID.Text Then
                        dsMembers.Tables("DSMembers").Rows(i).Item(15) = 0
                    End If
                Catch ex As Exception

                End Try
            Next

            For i = 0 To dsMembers.Tables("DSMembers").Rows.Count - 1
                Try
                    If dsMembers.Tables("DSMembers").Rows(i).Item(0) = txtBxUserName1.Text Then
                        dsMembers.Tables("DSMembers").Rows(i).Item(15) = txtTeamID.Text
                    End If
                Catch ex As Exception

                End Try

                Try
                    If dsMembers.Tables("DSMembers").Rows(i).Item(0) = txtBxUserName2.Text Then
                        dsMembers.Tables("DSMembers").Rows(i).Item(15) = txtTeamID.Text
                    End If
                Catch ex As Exception

                End Try

                Try
                    If dsMembers.Tables("DSMembers").Rows(i).Item(0) = txtBxUserName3.Text Then
                        dsMembers.Tables("DSMembers").Rows(i).Item(15) = txtTeamID.Text
                    End If
                Catch ex As Exception

                End Try

                Try
                    If dsMembers.Tables("DSMembers").Rows(i).Item(0) = txtBxUserName4.Text Then
                        dsMembers.Tables("DSMembers").Rows(i).Item(15) = txtTeamID.Text
                    End If
                Catch ex As Exception

                End Try
            Next

            Dim cb As New OleDb.OleDbCommandBuilder(daTeams)
            Dim cbMembers As New OleDb.OleDbCommandBuilder(daMembers)

            'Add Prefix/Suffix
            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"
            cbMembers.QuotePrefix = "["
            cbMembers.QuoteSuffix = "]"

            'Update Database
            daTeams.Update(dsTeams, "DSTeams")
            daMembers.Update(dsMembers, "DSMembers")

            MsgBox("Team data has been updated")

        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDeleteRecord.Click
        If MessageBox.Show("Delete this record from the database?", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            Dim intRowToDelete As Integer = teamsRow

            Dim intIterate As Integer = 0

            Dim cb As New OleDb.OleDbCommandBuilder(daTeams)


            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"
            dsTeams.Tables("DSTeams").Rows(teamsRow).Delete()
            daTeams.Update(dsTeams, "DSTeams")
            dsTeams.AcceptChanges()

            MsgBox("Team has been removed from the database")

            Dim memberIDIndex As Integer
            memberIDIndex = 0
            Dim intForIndex As Integer

            For intForIndex = 0 To dsTeams.Tables("DSTeams").Rows.Count - 1
                dsTeams.Tables("DSTeams").Rows(intForIndex).Item(0) = intForIndex
                memberIDIndex = memberIDIndex + 1
            Next

            teamsRow = teamsRow - 1

            'set info to a data entry thats visible
            If teamsRow = maxRows - 1 Then
                teamsRow = 1
            Else
                teamsRow = teamsRow + 1
            End If

            If teamsRow = 1 Then
                teamsRow = maxRows - 1
            Else
                teamsRow = teamsRow - 1
            End If
            GetTeamInfo()
            'Count Members 

            maxRows = maxRows - 1
        End If
    End Sub
End Class