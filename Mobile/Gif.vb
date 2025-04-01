Public Class Gif
    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick

        Me.Pbar.Value = Pbar.Value + 1

        If Pbar.Value >= 100 Then

            'Timer1.Stop()
            Login.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class