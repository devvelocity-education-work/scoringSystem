Imports System.Net.Mail

Public Class Email

    Dim toggleSendAll = False

    Dim maxRows As Integer
    Dim curRow As Integer
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim emailAddress() As String

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        HomePage.Show()
    End Sub

    Private myMsg As New MailMessage
    Private smtpSender As New SmtpClient


    Private Sub btnSendEmail_Click(sender As Object, e As EventArgs) Handles btnSendEmail.Click
        If toggleSendAll = True Then
            If txtBxFrom.Text = "" Then
                MsgBox("'From' field cannot be blank")
            Else
                If txtBxPassword.Text = "" Then
                    MsgBox("'Password' field cannot be blank")
                Else

                    Try
                        Dim myMsg As New MailMessage
                        Dim smtpSender As New SmtpClient
                        Dim attachment As System.Net.Mail.Attachment


                        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\U4 A2\scoringsystem4\Database\scoringSystemDatabase.accdb"

                        con.Open()


                        sql = "SELECT MemberID, FN, LN, Email FROM Customer"

                        da = New OleDb.OleDbDataAdapter(sql, con)

                        Dim ds As New DataSet
                        da.Fill(ds, "Members")

                        con.Close()

                        maxRows = ds.Tables("Members").Rows.Count
                        ReDim emailAddress(maxRows - 1)

                        For i = 0 To maxRows - 1
                            emailAddress(i) = ds.Tables("Members").Rows(i).Item(3)
                        Next


                        myMsg.From = New MailAddress(txtBxFrom.Text.Trim)
                        myMsg.To.Add(txtBxTo.Text.Trim)
                        myMsg.Subject = txtBxBody.Text
                        myMsg.Priority = MailPriority.Normal
                        smtpSender.Credentials = New Net.NetworkCredential(txtBxFrom.Text.Trim, txtBxPassword.Text.Trim)
                        smtpSender.EnableSsl = True
                        smtpSender.Host = "smtp.live.com"
                        smtpSender.Port = "587"
                        attachment = New System.Net.Mail.Attachment(txtBxAttachment.Text.Trim)
                        myMsg.Attachments.Add(attachment)

                        For i = 0 To emailAddress.Length
                            myMsg.To.Add(i)
                            smtpSender.Send(myMsg)
                        Next

                        MsgBox("Mail sent")

                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            End If
        Else
            If txtBxFrom.Text = "" Then
                MsgBox("'From' field cannot be blank")
            Else
                If txtBxPassword.Text = "" Then
                    MsgBox("'Password' field cannot be blank")
                Else

                    Try
                        Dim myMsg As New MailMessage
                        Dim smtpSender As New SmtpClient
                        Dim attachment As System.Net.Mail.Attachment
                        myMsg.From = New MailAddress(txtBxFrom.Text.Trim)
                        myMsg.To.Add(txtBxTo.Text.Trim)
                        myMsg.Subject = txtBxSubject.Text.Trim
                        myMsg.Body = txtBxBody.Text.Trim
                        myMsg.Priority = MailPriority.Normal
                        smtpSender.Credentials = New Net.NetworkCredential(txtBxFrom.Text.Trim, txtBxPassword.Text.Trim)
                        smtpSender.EnableSsl = True
                        smtpSender.Host = "smtp.live.com"
                        smtpSender.Port = 587
                        If txtBxAttachment.Text <> "" Then
                            attachment = New System.Net.Mail.Attachment(txtBxAttachment.Text.Trim)
                            myMsg.Attachments.Add(attachment)
                        End If
                        smtpSender.Send(myMsg)
                        MsgBox("Mail sent")

                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            End If
        End If


    End Sub

    Private Sub btnSendALL_Click(sender As Object, e As EventArgs) Handles btnSendALL.Click
        If toggleSendAll = False Then
            toggleSendAll = True

            btnSendALL.BackColor = Color.FromArgb(180, 40, 40)
            btnSendALL.Text = "Untoggle Send All"

            txtBxTo.BackColor = Color.FromArgb(50, 50, 50)
            txtBxTo.ForeColor = Color.FromArgb(100, 100, 100)
            txtBxTo.Enabled = False
            txtBxTo.Text = ""
        Else
            toggleSendAll = False

            btnSendALL.BackColor = Color.FromArgb(40, 80, 150)
            btnSendALL.Text = "Toggle Send All"

            txtBxTo.BackColor = Color.FromArgb(70, 70, 70)
            txtBxTo.ForeColor = Color.FromArgb(255, 255, 255)
            txtBxTo.Enabled = True
        End If
    End Sub

    Private Sub Email_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        If MessageBox.Show("Are you sure you want to log out?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Login.Show()
            Login.txtBxUsername.Clear()
            Login.txtBxPassword.Clear()
            Me.Close()
        End If
    End Sub
End Class