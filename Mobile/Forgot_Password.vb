Imports System.Net.Mail
Imports System.Runtime.InteropServices

Public Class Forgot_Password

    Public Shared random As String

    Private Sub Btn_send_Click(sender As Object, e As EventArgs) Handles Btn_send.Click


        Dim from, pass, mes As String
        Dim rand As Random = New Random()

        random = (rand.Next(9999)).ToString()

        Try

            Dim mail As MailMessage = New MailMessage()
            Dim smtpServer As New SmtpClient("smtp.gmail.com")

            from = ("tfgpghanshyam@gmail.com")
            pass = ("rflswtkgrrryovku")
            mail.To.Add(txt_user.Text)

            mail.From = New MailAddress(from)

            mes = "Verification Code" + " " + random

            mail.Body = mes

            mail.Subject = "Password Reset Code"


            smtpServer.EnableSsl = True

            smtpServer.Port = 587
            ' smtpServer.DeliveryMethod = smtpServer.DeliveryMethod.Network
            smtpServer.Credentials = New System.Net.NetworkCredential(from, pass)


            smtpServer.Send(mail)

            MsgBox("Mail has been send", MsgBoxStyle.Information)

            Me.Hide()

            Verify_code.Show()


        Catch ex As Exception

            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Forgot_Password_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Me.Hide()
    End Sub

    Private Sub txt_user_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_user.KeyDown
        If e.KeyCode = Keys.Enter Then
            Btn_send_Click(sender, e)
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Login.Show()
        txt_user.Text = ""
    End Sub
End Class