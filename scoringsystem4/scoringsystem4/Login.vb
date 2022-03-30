Public Class Login

    Public isAdminLoggedIn = False

    Dim maxRows As Integer = 0
    Dim maxColumns As Integer = 0
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim sql As String
    Dim rcrd As Boolean

    Dim curRow As Integer

    Dim intMembers As Integer
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBxPassword.TextChanged

    End Sub

    Private Sub txtBxUsername_TextChanged(sender As Object, e As EventArgs) Handles txtBxUsername.TextChanged

    End Sub

    Private Sub Events_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Open connection to the Access File / Database
        'con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\U4 A2\scoringsystem4\Database\scoringSystemDatabase.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\U4 A2\scoringsystem4\Database\scoringSystemDatabase.accdb"
        'con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\scoringSystem4\scoringsystem4\Database\scoringSystemDatabase.accdb"
        con.Open()
        ' SQL command to fetch data from the database
        sql = "SELECT * FROM tblMembers"
        ' Access Data in Database using SQL Query
        da = New OleDb.OleDbDataAdapter(Sql, con)
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

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Public loggedInAs As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtBxPassword.Text = "" Or txtBxUsername.Text = "" Then
            MsgBox("Please enter a email and password")
        Else
            Dim boolUNameFound = False
            Dim boolPWordFound = False

            For i = 0 To ds.Tables("DSStudents").Rows.Count - 1
                If ds.Tables("DSStudents").Rows(i).Item(4) = txtBxUsername.Text Then
                    boolUNameFound = True
                    If ds.Tables("DSStudents").Rows(i).Item(2) = txtBxPassword.Text Then
                        boolPWordFound = True
                        MsgBox("Welcome to the system")
                        HomePage.Show()
                        loggedInAs = ds.Tables("DSStudents").Rows(i).Item(1)
                        HomePage.lblLoggedInAs.Text = "Logged in as " & loggedInAs
                        Members.lblLoggedInAs.Text = "Logged in as " & loggedInAs
                        Scoreboard.lblLoggedInAs.Text = "Logged in as " & loggedInAs
                        Teams.lblLoggedInAs.Text = "Logged in as " & loggedInAs
                        EventsPG.lblLoggedInAs.Text = "Logged in as " & loggedInAs
                        Email.lblLoggedInAs.Text = "Logged in as " & loggedInAs

                        If ds.Tables("DSStudents").Rows(i).Item(11) = True Then
                            isAdminLoggedIn = True
                            HomePage.btnEmail.Show()
                        Else
                            isAdminLoggedIn = False
                            HomePage.btnEmail.Hide()
                        End If

                        Me.Hide()

                    End If

                End If


            Next

            If boolUNameFound = False Or boolPWordFound = False Then
                MsgBox("Email/Password incorect, please double check and try again")
            End If

        End If

        If isAdminLoggedIn = False Then
            HomePage.lblAdminAccount.Text = ""
            EventsPG.lblAdminAccount.Text = ""
            Teams.lblAdminAccount.Text = ""
            Scoreboard.lblAdminAccount.Text = ""
            Email.lblAdminAccount.Text = ""
            EventsPG.lblAdminAccount.Text = ""
            Members.lblAdminAccount.Text = ""
            HomePage.lblLoggedInAs.Location = New Point(HomePage.lblLoggedInAs.Location.X, 23)
            EventsPG.lblLoggedInAs.Location = New Point(EventsPG.lblLoggedInAs.Location.X, 23)
            Teams.lblLoggedInAs.Location = New Point(Teams.lblLoggedInAs.Location.X, 23)
            Scoreboard.lblLoggedInAs.Location = New Point(Scoreboard.lblLoggedInAs.Location.X, 23)
            Email.lblLoggedInAs.Location = New Point(Email.lblLoggedInAs.Location.X, 23)
            EventsPG.lblLoggedInAs.Location = New Point(EventsPG.lblLoggedInAs.Location.X, 23)
            Members.lblLoggedInAs.Location = New Point(Members.lblLoggedInAs.Location.X, 23)
        Else
            HomePage.lblAdminAccount.Text = "[ Admin Account ]"
            EventsPG.lblAdminAccount.Text = "[ Admin Account ]"
            Teams.lblAdminAccount.Text = "[ Admin Account ]"
            Scoreboard.lblAdminAccount.Text = "[ Admin Account ]"
            Email.lblAdminAccount.Text = "[ Admin Account ]"
            EventsPG.lblAdminAccount.Text = "[ Admin Account ]"
            Members.lblAdminAccount.Text = "[ Admin Account ]"

            HomePage.lblLoggedInAs.Location = New Point(HomePage.lblLoggedInAs.Location.X, 14)
            EventsPG.lblLoggedInAs.Location = New Point(EventsPG.lblLoggedInAs.Location.X, 14)
            Teams.lblLoggedInAs.Location = New Point(Teams.lblLoggedInAs.Location.X, 14)
            Scoreboard.lblLoggedInAs.Location = New Point(Scoreboard.lblLoggedInAs.Location.X, 14)
            Email.lblLoggedInAs.Location = New Point(Email.lblLoggedInAs.Location.X, 14)
            EventsPG.lblLoggedInAs.Location = New Point(EventsPG.lblLoggedInAs.Location.X, 14)
            Members.lblLoggedInAs.Location = New Point(Members.lblLoggedInAs.Location.X, 14)


        End If
    End Sub

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        Me.Hide()
        forgotpassword.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Register.Show()
        Me.Hide()
    End Sub
End Class