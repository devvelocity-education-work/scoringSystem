
Imports System.Windows.Forms.DataVisualization.Charting
Public Class Scoreboard

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        HomePage.Show()
        Me.Close()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Are you sure you want to log out?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Login.Show()
            Login.txtBxUsername.Clear()
            Login.txtBxPassword.Clear()
            Me.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGIndividuals.CellContentClick

    End Sub


    Private Sub Scoreboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim maxRows As Integer = 0
        Dim maxColumns As Integer = 0
        Dim con As New OleDb.OleDbConnection
        Dim dsMembers As New DataSet
        Dim daMembers As New OleDb.OleDbDataAdapter
        Dim sqlMembers As String

        Dim curRowMembers As Integer = 0
        Dim curRowTeams As Integer = 0

        Dim dsTeams As New DataSet
        Dim daTeams As New OleDb.OleDbDataAdapter
        Dim sqlTeams As String

        ' Open connection to the Access File / Database
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\U4 A2\scoringsystem4\Database\scoringSystemDatabase.accdb"
        'con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\U4 A2\scoringsystem4\Database\scoringSystemDatabase.accdb"
        'con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\scoringSystem4\scoringsystem4\Database\scoringSystemDatabase.accdb"
        con.Open()

        sqlMembers = "SELECT * FROM tblMembers"
        sqlTeams = "SELECT * FROM tblTeams"

        daMembers = New OleDb.OleDbDataAdapter(sqlMembers, con)
        daTeams = New OleDb.OleDbDataAdapter(sqlTeams, con)
        'Fill DataSet with data
        daMembers.Fill(dsMembers, "Members")
        daTeams.Fill(dsTeams, "Teams")


        Dim sqlTeamPoints As String = "SELECT TeamName, Points FROM tblTeams WHERE TeamID <> 0"
        Dim sqlMemberPoints As String = "SELECT Username, Points FROM tblMembers WHERE TeamID = 0"

        Dim daTeamPoints As OleDb.OleDbDataAdapter
        Dim daMemberPoints As OleDb.OleDbDataAdapter
        Dim dsTeamPoints As New DataSet()
        Dim dsMemberPoints As New DataSet()

        daTeamPoints = New OleDb.OleDbDataAdapter(sqlTeamPoints, con)
        daMemberPoints = New OleDb.OleDbDataAdapter(sqlMemberPoints, con)

        daTeamPoints.Fill(dsTeamPoints, "TeamPoints")
        daMemberPoints.Fill(dsMemberPoints, "MemberPoints")

        'Close the connection
        con.Close()

        ' Run through data

        Dim maxRowsMembers As Integer
        maxRowsMembers = dsMembers.Tables("Members").Rows.Count
        Dim maxColumnsMembers As Integer
        maxColumnsMembers = dsMembers.Tables("Members").Columns.Count
        Dim maxRowsTeams As Integer
        maxRowsTeams = dsTeams.Tables("Teams").Rows.Count
        Dim maxColumnsTeams As Integer
        maxColumnsTeams = dsTeams.Tables("Teams").Columns.Count

        'MsgBox(maxRowsMembers)

        Dim emptyCheck As Integer = 0

        For i = 0 To maxRowsMembers - 1
            'MsgBox(dsMembers.Tables("Members").Rows(i).Item(15))
            Dim valueToCheck = dsMembers.Tables("Members").Rows(i).Item(15)

            ' Add a count each time a row is skipped and to add the rows on that

            If valueToCheck = 0 Then
                DGIndividuals.Rows.Add()

                DGIndividuals.Rows(i - emptyCheck).Cells(0).Value = dsMembers.Tables("Members").Rows(i).Item(0)
                DGIndividuals.Rows(i - emptyCheck).Cells(1).Value = dsMembers.Tables("Members").Rows(i).Item(1)
                DGIndividuals.Rows(i - emptyCheck).Cells(2).Value = dsMembers.Tables("Members").Rows(i).Item(12)
                DGIndividuals.Rows(i - emptyCheck).Cells(3).Value = dsMembers.Tables("Members").Rows(i).Item(13)
                DGIndividuals.Rows(i - emptyCheck).Cells(4).Value = dsMembers.Tables("Members").Rows(i).Item(14)
            Else
                emptyCheck = emptyCheck + 1
            End If

        Next

        emptyCheck = 0

        For i = 0 To maxRowsTeams - 1
            Dim valueToCheck = dsTeams.Tables("Teams").Rows(i).Item(0)

            ' Add a count each time a row is skipped and to add the rows on that

            If valueToCheck <> 0 Then
                DGTeams.Rows.Add()

                DGTeams.Rows(i - emptyCheck).Cells(0).Value = dsTeams.Tables("Teams").Rows(i).Item(0)
                DGTeams.Rows(i - emptyCheck).Cells(1).Value = dsTeams.Tables("Teams").Rows(i).Item(1)
                DGTeams.Rows(i - emptyCheck).Cells(2).Value = dsTeams.Tables("Teams").Rows(i).Item(2)
                DGTeams.Rows(i - emptyCheck).Cells(3).Value = dsTeams.Tables("Teams").Rows(i).Item(3)
                DGTeams.Rows(i - emptyCheck).Cells(4).Value = dsTeams.Tables("Teams").Rows(i).Item(4)
            Else
                emptyCheck = emptyCheck + 1
            End If

        Next

        'Graph

        Dim ChartArea1 As ChartArea = New ChartArea()
        Dim Legend1 As Legend = New Legend()
        Dim Series1 As Series = New Series()
        Dim Chart1 = New Chart()
        Me.Controls.Add(Chart1)
        Series1.ChartType = SeriesChartType.Bar
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New System.Drawing.Point(600, 510)
        Chart1.Name = "Team Points Chart"
        Chart1.Titles.Add("Team Points Chart")
        Series1.Name = "Points"
        Chart1.Series.Add(Series1)
        Chart1.Size = New System.Drawing.Size(300, 200)

        Chart1.Series("Points").XValueMember = "TeamName"
        Chart1.Series("Points").YValueMembers = "Points"

        Chart1.DataSource = dsTeamPoints.Tables("TeamPoints")

        Dim ChartArea2 As ChartArea = New ChartArea()
        Dim Legend2 As Legend = New Legend()
        Dim Series2 As Series = New Series()
        Dim Chart2 = New Chart()
        Me.Controls.Add(Chart2)
        Series2.ChartType = SeriesChartType.Bar
        ChartArea2.Name = "ChartArea1"
        Chart2.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend2"
        Chart2.Legends.Add(Legend2)
        Chart2.Location = New System.Drawing.Point(600, 225)
        Chart2.Name = "Member Points Chart"
        Chart2.Titles.Add("Member Points Chart")
        Series2.Name = "Points"
        Chart2.Series.Add(Series2)
        Chart2.Size = New System.Drawing.Size(300, 200)

        Chart2.Series("Points").XValueMember = "Username"
        Chart2.Series("Points").YValueMembers = "Points"

        Chart2.DataSource = dsMemberPoints.Tables("MemberPoints")

























    End Sub

    Private Sub btnLogOut_Click_1(sender As Object, e As EventArgs) Handles btnLogOut.Click
        If MessageBox.Show("Are you sure you want to log out?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Login.Show()
            Login.txtBxUsername.Clear()
            Login.txtBxPassword.Clear()
            Me.Close()
        End If
    End Sub
End Class