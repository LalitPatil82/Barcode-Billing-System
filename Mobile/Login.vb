Public Class Login


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Gif.Timer1.Stop()

    End Sub

    Private Sub btn_Log_Click(sender As Object, e As EventArgs) Handles Btn_Log.Click

        Dim d As New Dao
        Dim obj As SqlClient.SqlDataReader


        obj = d.getdata("Select * from login where User_name='" & txt_Name.Text & "' and Password='" & txt_Pass.Text & "'")

        If obj.HasRows Then

            Dim dash As New Dashboard

            Me.Hide()

            dash.Show()


        Else
            MsgBox("Enter Valid User name or Password", MsgBoxStyle.Exclamation
                   )
            txt_Pass.Text = ""
            txt_Name.Focus()

        End If

        d.close_conn()


    End Sub
    Private Sub Chk_Shw_Pass_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Shw_Pass.CheckedChanged
        If txt_Pass.UseSystemPasswordChar = True Then
            txt_Pass.UseSystemPasswordChar = False
        Else
            txt_Pass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Btn_Can_Click(sender As Object, e As EventArgs) Handles Btn_Can.Click

        txt_Name.Text = ""
        txt_Pass.Text = ""
        txt_Name.Focus()


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If txt_Name.Text = "" Then
            'If txt_Name.Text = U Then
            MsgBox("User name is requried", MsgBoxStyle.Exclamation
                   )
            Else
                Forgot_Password.Show()
            uname = txt_Name.Text
            Me.Hide()
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Add_acc.Show()

        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        Me.Close()
        Gif.Close()


    End Sub

    Private Sub txt_Name_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Name.KeyDown, txt_Pass.KeyDown, Btn_Log.KeyDown

        If e.KeyCode = Keys.Enter Then
            If sender.name = txt_Name.Name Then
                txt_Pass.Focus()
            ElseIf sender.Name = txt_Pass.Name Then
                btn_Log_Click(sender, e)
            End If

        End If
    End Sub
    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover

        Label1.BackColor = Color.Red
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave

        Label1.BackColor = Color.Transparent
    End Sub
End Class