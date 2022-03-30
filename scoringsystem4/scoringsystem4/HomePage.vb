Public Class HomePage
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnMembers_Click(sender As Object, e As EventArgs) Handles btnMembers.Click
        Members.Show()
        Me.Hide()
    End Sub

    Private Sub btnScoreboard_Click(sender As Object, e As EventArgs) Handles btnScoreboard.Click
        Scoreboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnEvents_Click(sender As Object, e As EventArgs) Handles btnEvents.Click
        EventsPG.Show()
        Me.Hide()
    End Sub

    Private Sub btnTeams_Click(sender As Object, e As EventArgs) Handles btnTeams.Click
        Teams.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Are you sure you want to log out?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Login.Show()
            Login.txtBxUsername.Clear()
            Login.txtBxPassword.Clear()
            Me.Hide()
        End If
    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        If MessageBox.Show("Are you sure you want to log out?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Login.Show()
            Login.txtBxUsername.Clear()
            Login.txtBxPassword.Clear()
            Me.Close()
        End If
    End Sub

    Private Sub btnEmail_Click(sender As Object, e As EventArgs) Handles btnEmail.Click
        Me.Hide()
        Email.Show()
    End Sub
End Class