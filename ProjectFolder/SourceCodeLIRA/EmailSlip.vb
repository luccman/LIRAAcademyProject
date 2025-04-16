Imports System.Net.Mail
Public Class EmailSlip
    Public Property stringpass As String
    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If EmailTextBox.Text = "" Then
            MsgBox("Kindly enter your email address", MsgBoxStyle.RetryCancel, "Error")
            EmailTextBox.Focus()
        ElseIf PasswordTextBox.Text = "" Then
            MsgBox("Kindly enter your password", MsgBoxStyle.RetryCancel, "Error")
            PasswordTextBox.Focus()
        Else
            Try
                Dim emailString As String = EmailTextBox.Text
                Dim receiverString As String = ReceiverTextBox.Text
                Dim mail As New MailMessage()
                Dim SmtpServer As New SmtpClient("smtp.gmail.com")
                mail.From = New MailAddress("" & emailString & "")
                mail.To.Add("" & receiverString & "")
                mail.Subject = "" & SubjectTextBox.Text & ""
                mail.Body = "" & CommentTextBox.Text & ""

                Dim attachment As System.Net.Mail.Attachment
                attachment = New System.Net.Mail.Attachment("" & AttachmentTextBox.Text & "")
                mail.Attachments.Add(attachment)

                SmtpServer.Port = 587
                SmtpServer.Credentials = New System.Net.NetworkCredential("" & emailString & "", "" & PasswordTextBox.Text & "")
                SmtpServer.EnableSsl = True
                SmtpServer.Send(mail)

                MsgBox("Have successfully send !", MsgBoxStyle.Information, "Information")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        AttachmentTextBox.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub EmailSlip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReceiverTextBox.Text = stringpass
    End Sub
End Class