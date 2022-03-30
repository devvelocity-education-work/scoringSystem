Public Class EventsPG

    Dim curRow As Integer

    Dim maxRows As Integer = 0
    Dim maxColumns As Integer = 0
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim sql As String
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Events_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Open connection to the Access File / Database
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\U4 A2\scoringsystem4\Database\scoringSystemDatabase.accdb"
        'con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\U4 A2\scoringsystem4\Database\scoringSystemDatabase.accdb"
        'con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\scoringSystem4\scoringsystem4\Database\scoringSystemDatabase.accdb"
        con.Open()
        ' SQL command to fetch data from the database
        sql = "SELECT * FROM tblEvents"
        ' Access Data in Database using SQL Query
        da = New OleDb.OleDbDataAdapter(Sql, con)
        'Fill DataSet with data
        da.Fill(ds, "DSEvents")
        'Close the connection
        con.Close()

        'Get the amount of roles in the DataSet
        maxRows = ds.Tables("DSEvents").Rows.Count
        'MsgBox("The number of max rows are " & maxRows)
        'Get the amount of columns in the DataSet
        maxColumns = ds.Tables("DSEvents").Columns.Count
        'MsgBox("The number of columns are " & maxColumns)
        curRow = 0


        txtBxEventName.Text = ds.Tables("DSEvents").Rows(curRow).Item(1)
        txtBxRecordID.Text = ds.Tables("DSEvents").Rows(curRow).Item(0)
        dtEventDate.Text = ds.Tables("DSEvents").Rows(curRow).Item(2)
        cmbBxTeam.Text = ds.Tables("DSEvents").Rows(curRow).Item(3)
        txtBxLocation.Text = ds.Tables("DSEvents").Rows(curRow).Item(5)
        txtBxMaxPoints.Text = ds.Tables("DSEvents").Rows(curRow).Item(4)
        chcBxCompleted.Checked = ds.Tables("DSEvents").Rows(curRow).Item(6)


        If Login.isAdminLoggedIn = True Then

            txtBxMaxPoints.BackColor = Color.FromArgb(70, 70, 70)
            txtBxMaxPoints.Enabled = True

            btnNewRecord.Enabled = True
            btnNewRecord.BackColor = Color.FromArgb(180, 40, 40)
            btnNewRecord.ForeColor = Color.FromArgb(255, 255, 255)
            btnNewRecord.Cursor = Cursors.Hand

            btnUpdateRecord.Enabled = True
            btnUpdateRecord.BackColor = Color.FromArgb(40, 80, 150)
            btnUpdateRecord.ForeColor = Color.FromArgb(255, 255, 255)
            btnUpdateRecord.Cursor = Cursors.Hand

            btnDeleteRecord.Enabled = True
            btnDeleteRecord.BackColor = Color.FromArgb(40, 80, 150)
            btnDeleteRecord.ForeColor = Color.FromArgb(255, 255, 255)
            btnDeleteRecord.Cursor = Cursors.Hand

        Else

            txtBxMaxPoints.BackColor = Color.FromArgb(50, 50, 50)
            txtBxMaxPoints.Enabled = False

            btnNewRecord.Enabled = False
            btnNewRecord.BackColor = Color.FromArgb(50, 50, 50)
            btnNewRecord.ForeColor = Color.FromArgb(100, 100, 100)
            btnNewRecord.Cursor = Cursors.No

            btnUpdateRecord.Enabled = False
            btnUpdateRecord.BackColor = Color.FromArgb(50, 50, 50)
            btnUpdateRecord.ForeColor = Color.FromArgb(100, 100, 100)
            btnUpdateRecord.Cursor = Cursors.No

            btnDeleteRecord.Enabled = False
            btnDeleteRecord.BackColor = Color.FromArgb(50, 50, 50)
            btnDeleteRecord.ForeColor = Color.FromArgb(100, 100, 100)
            btnDeleteRecord.Cursor = Cursors.No


        End If


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If newRecordCreate = True Then
            If MessageBox.Show("Are you sure you want to go back and cancel creating a new record", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                btnAddRecord.BackColor = Color.FromArgb(50, 50, 50)
                btnAddRecord.Enabled = False
                btnAddRecord.ForeColor = Color.FromArgb(100, 100, 100)
                btnAddRecord.Cursor = Cursors.No

                btnNewRecord.Text = "New Record"

                btnUpdateRecord.Enabled = True
                btnUpdateRecord.BackColor = Color.FromArgb(40, 80, 150)
                btnUpdateRecord.ForeColor = Color.FromArgb(255, 255, 255)
                btnUpdateRecord.Cursor = Cursors.Arrow

                btnDeleteRecord.Enabled = True
                btnDeleteRecord.BackColor = Color.FromArgb(40, 80, 150)
                btnDeleteRecord.ForeColor = Color.FromArgb(255, 255, 255)
                btnDeleteRecord.Cursor = Cursors.Arrow

                btnNextRecord.Enabled = True
                btnNextRecord.BackColor = Color.FromArgb(40, 80, 150)
                btnNextRecord.ForeColor = Color.FromArgb(255, 255, 255)
                btnNextRecord.Cursor = Cursors.Arrow

                btnPrevRecord.Enabled = True
                btnPrevRecord.BackColor = Color.FromArgb(40, 80, 150)
                btnPrevRecord.ForeColor = Color.FromArgb(255, 255, 255)
                btnPrevRecord.Cursor = Cursors.Arrow

                updateRecords(True)
                updateRecords(False)
                newRecordCreate = False
            Else
                Exit Sub
            End If

        End If
        HomePage.Show()
        Me.Close()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Are you sure you want to log out?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Login.Show()
            Login.txtBxUsername.Clear()
            Login.txtBxPassword.Clear()
            Me.Hide()
        End If
    End Sub

    Function updateRecords(param)

        If param = True Then
            curRow = curRow + 1
            If curRow >= maxRows Then
                curRow = 0
            End If
        Else
            curRow = curRow - 1
            If curRow < 0 Then
                curRow = maxRows - 1
            End If
        End If

        txtBxEventName.Text = ds.Tables("DSEvents").Rows(curRow).Item(1)
        txtBxRecordID.Text = ds.Tables("DSEvents").Rows(curRow).Item(0)
        dtEventDate.Text = ds.Tables("DSEvents").Rows(curRow).Item(2)
        cmbBxTeam.Text = ds.Tables("DSEvents").Rows(curRow).Item(3)
        txtBxLocation.Text = ds.Tables("DSEvents").Rows(curRow).Item(5)
        txtBxMaxPoints.Text = ds.Tables("DSEvents").Rows(curRow).Item(4)
        chcBxCompleted.Checked = ds.Tables("DSEvents").Rows(curRow).Item(6)

    End Function

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnLogOut_Click_1(sender As Object, e As EventArgs) Handles btnLogOut.Click
        If newRecordCreate = True Then
            If MessageBox.Show("Are you sure you want to log out and cancel creating a new record", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                btnAddRecord.BackColor = Color.FromArgb(50, 50, 50)
                btnAddRecord.Enabled = False
                btnAddRecord.ForeColor = Color.FromArgb(100, 100, 100)
                btnAddRecord.Cursor = Cursors.No

                btnNewRecord.Text = "New Record"

                btnUpdateRecord.Enabled = True
                btnUpdateRecord.BackColor = Color.FromArgb(40, 80, 150)
                btnUpdateRecord.ForeColor = Color.FromArgb(255, 255, 255)
                btnUpdateRecord.Cursor = Cursors.Arrow

                btnDeleteRecord.Enabled = True
                btnDeleteRecord.BackColor = Color.FromArgb(40, 80, 150)
                btnDeleteRecord.ForeColor = Color.FromArgb(255, 255, 255)
                btnDeleteRecord.Cursor = Cursors.Arrow

                btnNextRecord.Enabled = True
                btnNextRecord.BackColor = Color.FromArgb(40, 80, 150)
                btnNextRecord.ForeColor = Color.FromArgb(255, 255, 255)
                btnNextRecord.Cursor = Cursors.Arrow

                btnPrevRecord.Enabled = True
                btnPrevRecord.BackColor = Color.FromArgb(40, 80, 150)
                btnPrevRecord.ForeColor = Color.FromArgb(255, 255, 255)
                btnPrevRecord.Cursor = Cursors.Arrow

                updateRecords(True)
                updateRecords(False)
                newRecordCreate = False
            Else
                Exit Sub
            End If

        End If

        If MessageBox.Show("Are you sure you want to log out?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
            Login.Show()
            Login.txtBxUsername.Clear()
            Login.txtBxPassword.Clear()
        End If
    End Sub

    Private Sub btnNextRecord_Click(sender As Object, e As EventArgs) Handles btnNextRecord.Click
        updateRecords(True)
    End Sub

    Private Sub btnPrevRecord_Click(sender As Object, e As EventArgs) Handles btnPrevRecord.Click
        updateRecords(False)
    End Sub

    Private Sub btnUpdateRecord_Click(sender As Object, e As EventArgs) Handles btnUpdateRecord.Click
        If MessageBox.Show("Please confirm you would like to update this record", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ds.Tables("DSEvents").Rows(curRow).Item(1) = txtBxEventName.Text
            ds.Tables("DSEvents").Rows(curRow).Item(2) = dtEventDate.Text
            ds.Tables("DSEvents").Rows(curRow).Item(3) = cmbBxTeam.Text
            ds.Tables("DSEvents").Rows(curRow).Item(5) = txtBxLocation.Text
            ds.Tables("DSEvents").Rows(curRow).Item(6) = chcBxCompleted.Checked

            If Login.isAdminLoggedIn = True Then
                ds.Tables("DSEvents").Rows(curRow).Item(4) = txtBxMaxPoints.Text
            End If

            Dim cb As New OleDb.OleDbCommandBuilder(da)

            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"

            da.Update(ds, "DSEvents")

            MsgBox("Event data has been updated")
        End If
    End Sub

    Private Sub btnDeleteRecord_Click(sender As Object, e As EventArgs) Handles btnDeleteRecord.Click
        If MessageBox.Show("Delete this record from the database?", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            Dim intRowToDelete As Integer = curRow

            Dim intIterate As Integer = 0

            Dim cb As New OleDb.OleDbCommandBuilder(da)


            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"
            ds.Tables("DSEvents").Rows(curRow).Delete()
            da.Update(ds, "DSEvents")
            ds.AcceptChanges()

            MsgBox("Event has been removed from the database")

            Dim memberIDIndex As Integer
            memberIDIndex = 0
            Dim intForIndex As Integer

            For intForIndex = 0 To ds.Tables("DSEvents").Rows.Count - 1
                ds.Tables("DSEvents").Rows(intForIndex).Item(0) = intForIndex + 1
                memberIDIndex = memberIDIndex + 1
            Next


            curRow = curRow - 1
            updateRecords(False)
            updateRecords(True)
            'Count Members 

            maxRows = maxRows - 1
        End If

    End Sub

    Dim newRecordCreate = False

    Private Sub btnNewRecord_Click(sender As Object, e As EventArgs) Handles btnNewRecord.Click
        If newRecordCreate = False Then
            If MessageBox.Show("Create new record?", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                btnAddRecord.BackColor = Color.FromArgb(40, 80, 150)
                btnAddRecord.Enabled = True
                btnAddRecord.ForeColor = Color.FromArgb(255, 255, 255)
                btnAddRecord.Cursor = Cursors.Default

                txtBxEventName.Text = ""
                cmbBxTeam.Text = ""
                txtBxLocation.Text = ""
                txtBxMaxPoints.Text = ""
                txtBxRecordID.Text = maxRows + 1
                chcBxCompleted.Checked = False

                btnUpdateRecord.Enabled = False
                btnUpdateRecord.BackColor = Color.FromArgb(50, 50, 50)
                btnUpdateRecord.ForeColor = Color.FromArgb(100, 100, 100)
                btnUpdateRecord.Cursor = Cursors.No

                btnDeleteRecord.Enabled = False
                btnDeleteRecord.BackColor = Color.FromArgb(50, 50, 50)
                btnDeleteRecord.ForeColor = Color.FromArgb(100, 100, 100)
                btnDeleteRecord.Cursor = Cursors.No

                btnNextRecord.Enabled = False
                btnNextRecord.BackColor = Color.FromArgb(50, 50, 50)
                btnNextRecord.ForeColor = Color.FromArgb(100, 100, 100)
                btnNextRecord.Cursor = Cursors.No

                btnPrevRecord.Enabled = False
                btnPrevRecord.BackColor = Color.FromArgb(50, 50, 50)
                btnPrevRecord.ForeColor = Color.FromArgb(100, 100, 100)
                btnPrevRecord.Cursor = Cursors.No

                btnNewRecord.Text = "Cancel"



                newRecordCreate = True



            End If
        Else
            If MessageBox.Show("Stop creating new record?", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                btnAddRecord.BackColor = Color.FromArgb(50, 50, 50)
                btnAddRecord.Enabled = False
                btnAddRecord.ForeColor = Color.FromArgb(100, 100, 100)
                btnAddRecord.Cursor = Cursors.No

                btnNewRecord.Text = "New Record"

                btnUpdateRecord.Enabled = True
                btnUpdateRecord.BackColor = Color.FromArgb(40, 80, 150)
                btnUpdateRecord.ForeColor = Color.FromArgb(255, 255, 255)
                btnUpdateRecord.Cursor = Cursors.Arrow

                btnDeleteRecord.Enabled = True
                btnDeleteRecord.BackColor = Color.FromArgb(40, 80, 150)
                btnDeleteRecord.ForeColor = Color.FromArgb(255, 255, 255)
                btnDeleteRecord.Cursor = Cursors.Arrow

                btnNextRecord.Enabled = True
                btnNextRecord.BackColor = Color.FromArgb(40, 80, 150)
                btnNextRecord.ForeColor = Color.FromArgb(255, 255, 255)
                btnNextRecord.Cursor = Cursors.Arrow

                btnPrevRecord.Enabled = True
                btnPrevRecord.BackColor = Color.FromArgb(40, 80, 150)
                btnPrevRecord.ForeColor = Color.FromArgb(255, 255, 255)
                btnPrevRecord.Cursor = Cursors.Arrow

                btnNewRecord.Text = "New Record"

                updateRecords(True)
                updateRecords(False)
                newRecordCreate = False
            End If
        End If
    End Sub

    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click

        If MessageBox.Show("Please confirm you would like to create this new record", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim dsNewRow = ds.Tables("DSEvents").NewRow()

            dsNewRow.Item("EventID") = maxRows + 1
            dsNewRow.Item("evName") = txtBxEventName.Text
            dsNewRow.Item("evDate") = dtEventDate.Text
            dsNewRow.Item("Individual/Team") = cmbBxTeam.Text
            dsNewRow.Item("MaxPoints") = txtBxMaxPoints.Text
            dsNewRow.Item("Location") = txtBxLocation.Text
            dsNewRow.Item("EventCompleted") = chcBxCompleted.Checked

            'Add new row to the rows
            ds.Tables("DSEvents").Rows.Add(dsNewRow)

            Dim cb As New OleDb.OleDbCommandBuilder(da)


            'Add Prefix/Suffix
            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"

            'Update Database
            da.Update(ds, "DSEvents")
            ds.AcceptChanges()

            MsgBox("Event has been added to the database")

            newRecordCreate = False

            maxRows = maxRows + 1
            curRow = 0

            btnAddRecord.BackColor = Color.FromArgb(50, 50, 50)
            btnAddRecord.Enabled = False
            btnAddRecord.ForeColor = Color.FromArgb(100, 100, 100)
            btnAddRecord.Cursor = Cursors.No

            btnNewRecord.Text = "New Record"

            btnUpdateRecord.Enabled = True
            btnUpdateRecord.BackColor = Color.FromArgb(40, 80, 150)
            btnUpdateRecord.ForeColor = Color.FromArgb(255, 255, 255)
            btnUpdateRecord.Cursor = Cursors.Arrow

            btnDeleteRecord.Enabled = True
            btnDeleteRecord.BackColor = Color.FromArgb(40, 80, 150)
            btnDeleteRecord.ForeColor = Color.FromArgb(255, 255, 255)
            btnDeleteRecord.Cursor = Cursors.Arrow

            btnNextRecord.Enabled = True
            btnNextRecord.BackColor = Color.FromArgb(40, 80, 150)
            btnNextRecord.ForeColor = Color.FromArgb(255, 255, 255)
            btnNextRecord.Cursor = Cursors.Arrow

            btnPrevRecord.Enabled = True
            btnPrevRecord.BackColor = Color.FromArgb(40, 80, 150)
            btnPrevRecord.ForeColor = Color.FromArgb(255, 255, 255)
            btnPrevRecord.Cursor = Cursors.Arrow

            updateRecords(True)
            updateRecords(False)
        Else
            Exit Sub
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class