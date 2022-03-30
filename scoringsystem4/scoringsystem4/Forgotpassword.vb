Public Class forgotpassword

    Dim maxRows As Integer = 0
    Dim maxColumns As Integer = 0
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDb.OleDbDataAdapter
    Dim sql As String
    Dim rcrd As Boolean

    Dim curRow As Integer

    Dim intMembers As Integer

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim found As Boolean = False

        For i = 0 To maxRows - 1
            If ds.Tables("DSMembers").Rows(i).Item(4) = txtBxEmail.Text Then
                MsgBox("Password email has been sent")
                found = True
                ' code to send a reset password email here
                Exit For
            End If
        Next

        If found = False Then
            MsgBox("Your email was not found as an account registered")
        End If
    End Sub

    Private Sub forgotpassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Open connection to the Access File / Database
        'con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\U4 A2\scoringsystem4\Database\scoringSystemDatabase.accdb"
        'con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\U4 A2\scoringsystem4\Database\scoringSystemDatabase.accdb"
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\scoringSystem4\scoringsystem4\Database\scoringSystemDatabase.accdb"
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
End Class