Public Class Register

    Dim maxRows As Integer = 0
    Dim maxColumns As Integer = 0
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim sql As String
    Dim rcrd As Boolean
    Dim intMembers As Integer

    Dim curRow As Integer
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Open connection to the Access File / Database
        'con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\U4 A2\scoringsystem4\Database\scoringSystemDatabase.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\U4 A2\scoringsystem4\Database\scoringSystemDatabase.accdb"
        'con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\scoringSystem4\scoringsystem4\Database\scoringSystemDatabase.accdb"
        con.Open()
        ' SQL command to fetch data from the database
        sql = "SELECT * FROM tblMembers"
        ' Access Data in Database using SQL Query
        da = New OleDb.OleDbDataAdapter(Sql, con)
        'Fill DataSet with data
        da.Fill(ds, "DSMembers")
        'Close the connection
        con.Close()

        'Get the amount of roles in the DataSet
        maxRows = ds.Tables("DSMembers").Rows.Count
        'MsgBox("The number of max rows are " & maxRows)
        'Get the amount of columns in the DataSet
        maxColumns = ds.Tables("DSMembers").Columns.Count
        'MsgBox("The number of columns are " & maxColumns)
        curRow = 0



    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If txtBxPassword.Text = txtBxPasswordConfirm.Text And txtBxEmail.Text <> "" And txtBxUsername.Text <> "" And txtBxFirstName.Text <> "" And txtBxLastName.Text <> "" Then
            If Len(txtBxPassword.Text) >= 8 Then

            Else
                MsgBox("Password must be 8 characters")
                Exit Sub
            End If

            For i = 0 To ds.Tables("DSMembers").Rows.Count - 1
                If ds.Tables("DSMembers").Rows(i).Item(4) = txtBxEmail.Text Then
                    MsgBox("Email already exists!")
                    Exit Sub
                End If
            Next

            For i = 0 To ds.Tables("DSMembers").Rows.Count - 1
                If ds.Tables("DSMembers").Rows(i).Item(1) = txtBxUsername.Text Then
                    MsgBox("Username already exists!")
                    Exit Sub
                End If
            Next


            Dim cbuilder As New OleDb.OleDbCommandBuilder(da)
            Dim dsNewRow As DataRow
            dsNewRow = ds.Tables("DSMembers").NewRow()

            dsNewRow.Item("MemberID") = maxRows + 1
            dsNewRow.Item("Username") = txtBxUsername.Text
            dsNewRow.Item("Password") = txtBxPassword.Text
            dsNewRow.Item("DateOfBirth") = DOBPicker.Text
            dsNewRow.Item("Email") = txtBxEmail.Text
            dsNewRow.Item("Mobile") = txtBxMobile.Text
            dsNewRow.Item("FN") = txtBxFirstName.Text
            dsNewRow.Item("LN") = txtBxLastName.Text
            dsNewRow.Item("Gender") = cmbGender.Text
            dsNewRow.Item("EmergencyContact") = txtBxEmergencyContact.Text
            dsNewRow.Item("Address") = txtBxAddress.Text
            dsNewRow.Item("Points") = 0
            dsNewRow.Item("GamesWon") = 0
            dsNewRow.Item("GamesOnPodium") = 0
            dsNewRow.Item("TeamID") = 0
            dsNewRow.Item("MedicalConditions") = txtBxMedical.Text

            ds.Tables("DSMembers").Rows.Add(dsNewRow)

            'Add Prefix/Suffix
            cbuilder.QuotePrefix = "["
            cbuilder.QuoteSuffix = "]"

            'Update Database
            da.Update(ds, "DSMembers")

            MsgBox("You have now registered as " & txtBxUsername.Text)

            txtBxUsername.Clear()
            txtBxPassword.Clear()
            txtBxEmail.Clear()
            txtBxFirstName.Clear()
            txtBxLastName.Clear()
            txtBxMedical.Clear()
            txtBxAddress.Clear()
            cmbGender.Text = ""
            DOBPicker.ResetText()
            txtBxEmergencyContact.Clear()
            txtBxMobile.Clear()
            txtBxEmail.Clear()

            Login.Show()
            Me.Hide()
            'Count Members 
            intMembers = ds.Tables("DSMembers").Rows.Count

            maxRows = maxRows + 1



        Else
            MsgBox("Username, Email, First Name and Last Name must be present. Passwords must also match, please try again.")
        End If


    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtBxEmail_TextChanged(sender As Object, e As EventArgs) Handles txtBxEmail.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtBxMobile_TextChanged(sender As Object, e As EventArgs) Handles txtBxMobile.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub DOBPicker_ValueChanged(sender As Object, e As EventArgs) Handles DOBPicker.ValueChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txtBxEmergencyContact_TextChanged(sender As Object, e As EventArgs) Handles txtBxEmergencyContact.TextChanged

    End Sub
End Class