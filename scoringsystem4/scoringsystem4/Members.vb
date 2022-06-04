Public Class Members
    Dim maxRows As Integer = 0
    Dim maxColumns As Integer = 0
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim sql As String
    Dim rcrd As Boolean

    Dim curRow As Integer

    Dim intMembers As Integer

    Private Sub Members_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Open connection to the Access File / Database
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\U4 A2\scoringsystem4\Database\scoringSystemDatabase.accdb"
        'con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\scoringSystem4\scoringsystem4\Database\scoringSystemDatabase.accdb"
        'con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\U4 A2\scoringsystem4\Database\scoringSystemDatabase.accdb"
        con.Open()
        ' SQL command to fetch data from the database
        sql = "SELECT * FROM tblMembers"
        ' Access Data in Database using SQL Query
        da = New OleDb.OleDbDataAdapter(sql, con)
        'Fill DataSet with data
        da.Fill(ds, "DSStudents")
        'Close the connection
        con.Close()

        'Get the amount of roles in the DataSet
        maxRows = ds.Tables("DSStudents").Rows.Count
        'MsgBox("The number of max rows are " & maxRows)
        'Get the amount of columns in the DataSet
        maxColumns = ds.Tables("DSStudents").Columns.Count
        'MsgBox("The number of columns are " & maxColumns)
        curRow = 0



        txtBxMemberID.Text = ds.Tables("DSStudents").Rows(curRow).Item(0)
        txtBxUsername.Text = ds.Tables("DSStudents").Rows(curRow).Item(1)
        cmbDOB.Text = ds.Tables("DSStudents").Rows(curRow).Item(3)
        txtBxFirstName.Text = ds.Tables("DSStudents").Rows(curRow).Item(6)
        txtBxLastName.Text = ds.Tables("DSStudents").Rows(curRow).Item(7)
        txtBxEmail.Text = ds.Tables("DSStudents").Rows(curRow).Item(4)
        txtBxMobile.Text = ds.Tables("DSStudents").Rows(curRow).Item(5)
        txtBxEmergContact.Text = ds.Tables("DSStudents").Rows(curRow).Item(9)
        cmbBxGender.Text = ds.Tables("DSStudents").Rows(curRow).Item(8)
        txtBxAddress.Text = ds.Tables("DSStudents").Rows(curRow).Item(10)
        txtBxPoints.Text = ds.Tables("DSStudents").Rows(curRow).Item(12)
        txtBxGamesWon.Text = ds.Tables("DSStudents").Rows(curRow).Item(13)
        txtBxGamesOnPodium.Text = ds.Tables("DSStudents").Rows(curRow).Item(14)
        txtBxTeam.Text = ds.Tables("DSStudents").Rows(curRow).Item(15)

        Try
            txtBxMedical.Text = ds.Tables("DSStudents").Rows(curRow).Item(16)
        Catch ex As Exception
            txtBxMedical.Text = ""
        End Try


        intMembers = ds.Tables("DSStudents").Rows.Count

        If Login.isAdminLoggedIn = True Then
            txtBxPoints.BackColor = Color.FromArgb(70, 70, 70)
            txtBxPoints.ForeColor = Color.FromArgb(255, 255, 255)
            txtBxPoints.ReadOnly = False
            txtBxPoints.Enabled = True

            txtBxGamesOnPodium.BackColor = Color.FromArgb(70, 70, 70)
            txtBxGamesOnPodium.ForeColor = Color.FromArgb(255, 255, 255)
            txtBxGamesOnPodium.ReadOnly = False
            txtBxGamesOnPodium.Enabled = True

            txtBxGamesWon.BackColor = Color.FromArgb(70, 70, 70)
            txtBxGamesWon.ForeColor = Color.FromArgb(255, 255, 255)
            txtBxGamesWon.ReadOnly = False
            txtBxGamesWon.Enabled = True

            btnNewRcrd.Enabled = True
            btnNewRcrd.BackColor = Color.FromArgb(180, 40, 40)
            btnNewRcrd.ForeColor = Color.FromArgb(255, 255, 255)

            btnUpdateRecord.Enabled = True

            btnDeleteRecord.Enabled = True

        Else

            btnNewRcrd.Enabled = False
            btnNewRcrd.BackColor = Color.FromArgb(50, 50, 50)
            btnNewRcrd.ForeColor = Color.FromArgb(100, 100, 100)


            btnUpdateRecord.Enabled = False

            btnDeleteRecord.Enabled = False



        End If



    End Sub

    Private Sub endAdd()
        funcTblUpdate(False)
        funcTblUpdate(True)
        btnNewRcrd.Text = "New Record"

        btnAddRecord.BackColor = Color.FromArgb(50, 50, 50)
        btnAddRecord.ForeColor = Color.FromArgb(100, 100, 100)
        btnAddRecord.Enabled = False

        btnUpdateRecord.Enabled = True

        btnDeleteRecord.Enabled = True

        btnNextRecord.Enabled = True

        btnPrevRecord.Enabled = True
    End Sub

    Private Sub startAdd()
        btnAddRecord.BackColor = Color.FromArgb(40, 80, 150)
        btnAddRecord.ForeColor = Color.FromArgb(255, 255, 255)
        btnAddRecord.Enabled = True

        btnDeleteRecord.Enabled = False

        btnUpdateRecord.Enabled = False

        btnPrevRecord.Enabled = False

        btnNextRecord.Enabled = False
    End Sub


    Private Sub updateBoxInfo()
        'Update text box information
        txtBxMemberID.Text = ds.Tables("DSStudents").Rows(curRow).Item(0)
        txtBxUsername.Text = ds.Tables("DSStudents").Rows(curRow).Item(1)
        cmbDOB.Text = ds.Tables("DSStudents").Rows(curRow).Item(3)
        txtBxFirstName.Text = ds.Tables("DSStudents").Rows(curRow).Item(6)
        txtBxLastName.Text = ds.Tables("DSStudents").Rows(curRow).Item(7)
        txtBxEmail.Text = ds.Tables("DSStudents").Rows(curRow).Item(4)
        txtBxMobile.Text = ds.Tables("DSStudents").Rows(curRow).Item(5)
        txtBxEmergContact.Text = ds.Tables("DSStudents").Rows(curRow).Item(9)
        cmbBxGender.Text = ds.Tables("DSStudents").Rows(curRow).Item(8)
        txtBxAddress.Text = ds.Tables("DSStudents").Rows(curRow).Item(10)
        txtBxPoints.Text = ds.Tables("DSStudents").Rows(curRow).Item(12)
        txtBxGamesWon.Text = ds.Tables("DSStudents").Rows(curRow).Item(13)
        txtBxGamesOnPodium.Text = ds.Tables("DSStudents").Rows(curRow).Item(14)
        txtBxTeam.Text = ds.Tables("DSStudents").Rows(curRow).Item(15)

        Try
            txtBxMedical.Text = ds.Tables("DSStudents").Rows(curRow).Item(16)
        Catch ex As Exception
            txtBxMedical.Text = ""
        End Try

    End Sub

    Private Sub funcTblUpdate(prevNext As Boolean)

        If rcrd = True Then
            If MessageBox.Show("Would you like to cancel creating a new record?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                rcrd = False
            Else
                Exit Sub
            End If

        End If

        If prevNext = False Then

            'If current row is euqal to 0 then set current row to the row count - 1 (maximum row)
            If curRow = 0 Then
                curRow = ds.Tables("DSStudents").Rows.Count - 1
            Else
                curRow = curRow - 1
            End If

            updateBoxInfo()


        Else
            'If current row is at the row count -1 (maximum row), set row index to 0
            If curRow = ds.Tables("DSStudents").Rows.Count - 1 Then
                curRow = 0
            Else
                curRow = curRow + 1
            End If

            updateBoxInfo()

        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        If rcrd = True Then
            If MessageBox.Show("Cancel creating a new record?", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                rcrd = False
                endAdd()
                HomePage.Show()
                Me.Close()
            End If
        Else
            HomePage.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Are you sure you want to log out?", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            rcrd = False
            endAdd()


            Me.Hide()

            Login.Show()
            Login.txtBxUsername.Clear()
            Login.txtBxPassword.Clear()
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub cmbBxGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBxGender.SelectedIndexChanged

    End Sub

    Private Sub txtBxMemberID_TextChanged(sender As Object, e As EventArgs) Handles txtBxMemberID.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        funcTblUpdate(True)
    End Sub

    Private Sub btnPrevRecord_Click(sender As Object, e As EventArgs)
        funcTblUpdate(False)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnNewRcrd.Click
        If rcrd = True Then
            If MessageBox.Show("Cancel creating a new record?", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                rcrd = False

                endAdd()

            End If
        Else
            If MessageBox.Show("Create a new record?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                txtBxMemberID.Text = "New Rcrd"

                rcrd = True

                startAdd()

                txtBxUsername.Text = ""
                txtBxFirstName.Text = ""
                txtBxLastName.Text = ""
                txtBxEmail.Text = ""
                txtBxMobile.Text = ""
                txtBxEmergContact.Text = ""
                cmbBxGender.Text = ""
                txtBxAddress.Text = ""
                txtBxPoints.Text = ""
                txtBxGamesWon.Text = ""
                txtBxGamesOnPodium.Text = ""
                txtBxTeam.Text = ""
                txtBxMedical.Text = ""
                cmbDOB.Text = "1/1/2000"

                If Login.isAdminLoggedIn = True Then
                    txtBxPoints.Text = ""
                    txtBxGamesWon.Text = ""
                    txtBxGamesOnPodium.Text = ""
                End If


                btnNewRcrd.Text = "Cancel"


            End If


        End If


    End Sub

    Private Sub txtBxUsername_TextChanged(sender As Object, e As EventArgs) Handles txtBxUsername.TextChanged

    End Sub

    Private Sub btnUpdateRecord_Click(sender As Object, e As EventArgs)
        For i = 0 To ds.Tables("DSStudents").Rows.Count - 1
            If ds.Tables("DSStudents").Rows(i).Item(1) = txtBxUsername.Text And ds.Tables("DSStudents").Rows(i).Item(0) <> txtBxMemberID.Text Then
                MsgBox("Username already taken!")
                Exit Sub
            End If
        Next

        ds.Tables("DSStudents").Rows(curRow).Item(0) = txtBxMemberID.Text
        ds.Tables("DSStudents").Rows(curRow).Item(1) = txtBxUsername.Text
        ds.Tables("DSStudents").Rows(curRow).Item(6) = txtBxFirstName.Text
        ds.Tables("DSStudents").Rows(curRow).Item(7) = txtBxLastName.Text
        ds.Tables("DSStudents").Rows(curRow).Item(4) = txtBxEmail.Text
        ds.Tables("DSStudents").Rows(curRow).Item(5) = txtBxMobile.Text
        ds.Tables("DSStudents").Rows(curRow).Item(9) = txtBxEmergContact.Text
        ds.Tables("DSStudents").Rows(curRow).Item(8) = cmbBxGender.Text
        ds.Tables("DSStudents").Rows(curRow).Item(10) = txtBxAddress.Text
        ds.Tables("DSStudents").Rows(curRow).Item(12) = txtBxPoints.Text
        ds.Tables("DSStudents").Rows(curRow).Item(13) = txtBxGamesWon.Text
        ds.Tables("DSStudents").Rows(curRow).Item(14) = txtBxGamesOnPodium.Text
        ds.Tables("DSStudents").Rows(curRow).Item(15) = txtBxTeam.Text
        ds.Tables("DSStudents").Rows(curRow).Item(16) = txtBxMedical.Text

        If Login.isAdminLoggedIn = True Then
            ds.Tables("DSStudents").Rows(curRow).Item(12) = txtBxPoints.Text
            ds.Tables("DSStudents").Rows(curRow).Item(13) = txtBxGamesWon.Text
            ds.Tables("DSStudents").Rows(curRow).Item(14) = txtBxGamesOnPodium.Text
        End If


        Dim cb As New OleDb.OleDbCommandBuilder(da)

        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"

        da.Update(ds, "DSStudents")

        MsgBox("Student data has been updated")


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBxMedical.TextChanged

    End Sub

    Function checkRequiredFields()
        If txtBxUsername.Text = "" Then
            Return False
        End If
        If txtBxFirstName.Text = "" Then
            Return False
        End If
        If txtBxLastName.Text = "" Then
            Return False
        End If
        If txtBxMobile.Text = "" Then
            Return False
        End If
        If txtBxEmergContact.Text = "" Then
            Return False
        End If
        If txtBxAddress.Text = "" Then
            Return False
        End If
        If cmbBxGender.Text = "" Then
            Return False
        End If
        Return True
    End Function

    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click
        Dim cbuilder As New OleDb.OleDbCommandBuilder(da)
        Dim dsNewRow As DataRow

        For i = 0 To ds.Tables("DSStudents").Rows.Count - 1
            If ds.Tables("DSStudents").Rows(i).Item(1) = txtBxUsername.Text Then
                MsgBox("Username already taken!")
                Exit Sub
            End If
        Next

        'Run function to check if any required fields are blank
        If checkRequiredFields() = True Then

            If MessageBox.Show("Add this record to the database?", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                dsNewRow = ds.Tables("DSStudents").NewRow()

                'Append data here
                dsNewRow.Item("MemberID") = intMembers + 1
                dsNewRow.Item("Username") = txtBxUsername.Text
                dsNewRow.Item("DateOfBirth") = cmbDOB.Text
                dsNewRow.Item("Email") = txtBxEmail.Text
                dsNewRow.Item("Mobile") = txtBxMobile.Text
                dsNewRow.Item("EmergencyContact") = txtBxEmergContact.Text
                dsNewRow.Item("FN") = txtBxFirstName.Text
                dsNewRow.Item("LN") = txtBxLastName.Text
                dsNewRow.Item("Gender") = cmbBxGender.Text
                dsNewRow.Item("Address") = txtBxAddress.Text
                dsNewRow.Item("MedicalConditions") = txtBxMedical.Text
                dsNewRow.Item("Points") = 0
                dsNewRow.Item("GamesWon") = 0
                dsNewRow.Item("GamesOnPodium") = 0
                dsNewRow.Item("TeamID") = 0

                'Add new row to the rows
                ds.Tables("DSStudents").Rows.Add(dsNewRow)


                'Add Prefix/Suffix
                cbuilder.QuotePrefix = "["
                cbuilder.QuoteSuffix = "]"

                'Update Database
                da.Update(ds, "DSStudents")
                ds.AcceptChanges()

                MsgBox("Member has been added to the database")
                'Count Members 
                intMembers = ds.Tables("DSStudents").Rows.Count

                rcrd = False

                endAdd()

                maxRows = maxRows + 1

            End If
        Else
            MsgBox("Please check you have entered information into the required fields")
        End If


    End Sub

    Private Sub cmbDOB_ValueChanged(sender As Object, e As EventArgs) Handles cmbDOB.ValueChanged

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub

    Private Sub btnDeleteRecord_Click(sender As Object, e As EventArgs)
        Dim cbuilder As New OleDb.OleDbCommandBuilder(da)

        If MessageBox.Show("Are you sure you would like to delete this record?", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim intRowToDelete As Integer = curRow

            Dim intIterate As Integer = 0


            cbuilder.QuotePrefix = "["
            cbuilder.QuoteSuffix = "]"
            ds.Tables("DSStudents").Rows(intRowToDelete).Delete()
            da.Update(ds, "DSStudents")
            ds.AcceptChanges()

            MsgBox("Member has been removed from the database")

            Dim memberIDIndex As Integer
            memberIDIndex = 0
            Dim intForIndex As Integer

            For intForIndex = 0 To ds.Tables("DSStudents").Rows.Count - 1
                ds.Tables("DSStudents").Rows(intForIndex).Item(0) = intForIndex + 1
                memberIDIndex = memberIDIndex + 1
            Next


            curRow = 0
            funcTblUpdate(False)
            funcTblUpdate(True)
            'Count Members 
            intMembers = ds.Tables("DSStudents").Rows.Count

            maxRows = maxRows - 1
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnLogOut_Click_1(sender As Object, e As EventArgs)
        If rcrd = True Then
            If MessageBox.Show("Are you sure you want to log out? This will end 'New Record' and entered data will be lost", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                rcrd = False
                endAdd()


                Me.Close()

                Login.Show()
                Login.txtBxUsername.Clear()
                Login.txtBxPassword.Clear()
            End If
        Else
            If MessageBox.Show("Are you sure you want to log out?", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                rcrd = False
                endAdd()


                Me.Close()

                Login.Show()
                Login.txtBxUsername.Clear()
                Login.txtBxPassword.Clear()
            End If
        End If
    End Sub

    Private Sub lblAdminAccount_Click(sender As Object, e As EventArgs) Handles lblAdminAccount.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        If rcrd = True Then
            If MessageBox.Show("Are you sure you want to log out? This will end 'New Record' and entered data will be lost", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                rcrd = False
                endAdd()


                Me.Close()

                Login.Show()
                Login.txtBxUsername.Clear()
                Login.txtBxPassword.Clear()
            End If
        Else
            If MessageBox.Show("Are you sure you want to log out?", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                rcrd = False
                endAdd()


                Me.Close()

                Login.Show()
                Login.txtBxUsername.Clear()
                Login.txtBxPassword.Clear()
                End
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If rcrd = True Then
            If MessageBox.Show("Are you sure you want to log out? This will end 'New Record' and entered data will be lost", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                rcrd = False
                Me.Close()
                Login.Show()
                Login.txtBxUsername.Clear()
                Login.txtBxPassword.Clear()
            End If
        Else
            If MessageBox.Show("Are you sure you want to log out?", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                rcrd = False
                Me.Close()

                Login.Show()
                Login.txtBxUsername.Clear()
                Login.txtBxPassword.Clear()
            End If
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If rcrd = True Then
            If MessageBox.Show("Cancel creating a new record?", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                rcrd = False
                endAdd()
                HomePage.Show()
                Me.Close()
            End If
        Else
            HomePage.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNextRecord.Click
        funcTblUpdate(True)
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrevRecord.Click
        funcTblUpdate(False)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdateRecord.Click
        For i = 0 To ds.Tables("DSStudents").Rows.Count - 1
            If ds.Tables("DSStudents").Rows(i).Item(1) = txtBxUsername.Text And ds.Tables("DSStudents").Rows(i).Item(0) <> txtBxMemberID.Text Then
                MsgBox("Username already taken!")
                Exit Sub
            End If
        Next

        ds.Tables("DSStudents").Rows(curRow).Item(0) = txtBxMemberID.Text
        ds.Tables("DSStudents").Rows(curRow).Item(1) = txtBxUsername.Text
        ds.Tables("DSStudents").Rows(curRow).Item(6) = txtBxFirstName.Text
        ds.Tables("DSStudents").Rows(curRow).Item(7) = txtBxLastName.Text
        ds.Tables("DSStudents").Rows(curRow).Item(4) = txtBxEmail.Text
        ds.Tables("DSStudents").Rows(curRow).Item(5) = txtBxMobile.Text
        ds.Tables("DSStudents").Rows(curRow).Item(9) = txtBxEmergContact.Text
        ds.Tables("DSStudents").Rows(curRow).Item(8) = cmbBxGender.Text
        ds.Tables("DSStudents").Rows(curRow).Item(10) = txtBxAddress.Text
        ds.Tables("DSStudents").Rows(curRow).Item(12) = txtBxPoints.Text
        ds.Tables("DSStudents").Rows(curRow).Item(13) = txtBxGamesWon.Text
        ds.Tables("DSStudents").Rows(curRow).Item(14) = txtBxGamesOnPodium.Text
        ds.Tables("DSStudents").Rows(curRow).Item(15) = txtBxTeam.Text
        ds.Tables("DSStudents").Rows(curRow).Item(16) = txtBxMedical.Text

        If Login.isAdminLoggedIn = True Then
            ds.Tables("DSStudents").Rows(curRow).Item(12) = txtBxPoints.Text
            ds.Tables("DSStudents").Rows(curRow).Item(13) = txtBxGamesWon.Text
            ds.Tables("DSStudents").Rows(curRow).Item(14) = txtBxGamesOnPodium.Text
        End If


        Dim cb As New OleDb.OleDbCommandBuilder(da)

        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"

        da.Update(ds, "DSStudents")

        MsgBox("Student data has been updated")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDeleteRecord.Click
        Dim cbuilder As New OleDb.OleDbCommandBuilder(da)

        If MessageBox.Show("Are you sure you would like to delete this record?", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim intRowToDelete As Integer = curRow

            Dim intIterate As Integer = 0


            cbuilder.QuotePrefix = "["
            cbuilder.QuoteSuffix = "]"
            ds.Tables("DSStudents").Rows(intRowToDelete).Delete()
            da.Update(ds, "DSStudents")
            ds.AcceptChanges()

            MsgBox("Member has been removed from the database")

            Dim memberIDIndex As Integer
            memberIDIndex = 0
            Dim intForIndex As Integer

            For intForIndex = 0 To ds.Tables("DSStudents").Rows.Count - 1
                ds.Tables("DSStudents").Rows(intForIndex).Item(0) = intForIndex + 1
                memberIDIndex = memberIDIndex + 1
            Next


            curRow = 0
            funcTblUpdate(False)
            funcTblUpdate(True)
            'Count Members 
            intMembers = ds.Tables("DSStudents").Rows.Count

            maxRows = maxRows - 1
        End If
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub
End Class