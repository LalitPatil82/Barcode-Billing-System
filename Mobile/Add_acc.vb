Imports System.ComponentModel
Public Class Add_acc

    Dim flag = 0


    Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click

        reset()
        flag = 0
        Btn_Delete.Enabled = False
        txt_user.Focus()

    End Sub

    Private Sub Btn_add_Click(sender As Object, e As EventArgs) Handles Btn_add.Click

        If txt_user.Text <> "" Then

            If txt_pass.Text <> "" Then

                If flag = 0 Then
                    'insert

                    Dim f As Integer = 0
                    Dim dao As New Dao


                    f = dao.validate("Select User_name from login where User_name='" & txt_user.Text & "'")

                    dao.close_conn()

                    If f = 1 Then
                        MessageBox.Show("Unable to Create User it is already Created")

                        txt_user.Focus()
                    Else


                        dao.modifyData("insert into login (User_name,Password) values('" & txt_user.Text & "','" & txt_pass.Text & "')")



                        MsgBox("User is Created")

                        Btn_New_Click(sender, e)



                    End If
                Else
                    'update

                    Dim dao As New Dao
                    dao.modifyData("update login set User_name='" & txt_user.Text & "',Password='" & txt_pass.Text & "'where User_id='" & txt_id.Text & "'")
                    MessageBox.Show("User is Updated")
                    Btn_New_Click(sender, e)

                End If
            Else
                MessageBox.Show("Enter Valid Password")
                txt_pass.Focus()
            End If
        Else
            MsgBox("Enter Valid User Name")
            txt_user.Focus()
        End If
        loaddata()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If txt_pass.UseSystemPasswordChar = True Then

            txt_pass.UseSystemPasswordChar = False

        Else
            txt_pass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txt_user_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_user.KeyDown, txt_pass.KeyDown
        Dim d As New Dao
        d.press_enter(e)
        If e.KeyCode = Keys.Enter Then
            If sender.name = txt_user.Name Then
                txt_pass.Focus()
            ElseIf sender.name = txt_pass Then
                Btn_add_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub Add_acc_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Login.Show()

        Me.Hide()

    End Sub

    Private Sub Add_acc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.EnableHeadersVisualStyles = False

        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White



        loaddata()
        txt_user.Focus()
    End Sub

    Public Sub loaddata()
        Dim ds As New Data.DataSet
        Dim d As New Dao
        ds = d.loaddata("select * from login")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick


        If DataGridView1.Rows.Count > 0 Then
            txt_id.Text = DataGridView1.Item("ID", DataGridView1.CurrentCell.RowIndex).Value
            txt_user.Text = DataGridView1.Item("u_name", DataGridView1.CurrentCell.RowIndex).Value

            'uname1 = txt_user.Text

            txt_pass.Text = DataGridView1.Item("Password", DataGridView1.CurrentCell.RowIndex).Value
            flag = 1
            Btn_Delete.Enabled = True
        End If


    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        Dim c As Integer = MessageBox.Show("Do you Really want to Delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If c = 6 Then
            Dim d As New Dao
            d.modifyData("delete from login where User_id=" & txt_id.Text)
            loaddata()
            Btn_New_Click(sender, e)
        End If
    End Sub
    Public Sub reset()
        txt_id.Text = ""
        txt_pass.Text = ""
        txt_user.Text = ""
        If CheckBox1.Checked = True Then
            CheckBox1.Checked = False

        End If
    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

        Me.Close()

    End Sub

End Class