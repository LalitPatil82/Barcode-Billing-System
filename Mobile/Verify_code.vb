Public Class Verify_code

    Dim rand As String = Forgot_Password.random

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_verify.Click

        If (txt_code.Text.Equals(rand)) Then

            Dim reset As Reset_pass = New Reset_pass

            Me.Hide()

            Reset_pass.Show()



        Else

            MsgBox("Entered Wrong Code")

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
        Forgot_Password.Show()
        txt_code.Text = ""
    End Sub
End Class