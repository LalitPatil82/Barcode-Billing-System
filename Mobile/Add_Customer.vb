Imports System.ComponentModel
Public Class Add_Customer
    Dim flag = 0
    Private Sub btn_clr_Click(sender As Object, e As EventArgs) Handles btn_clr.Click
        reset()
        flag = 0
        btn_del.Enabled = False
        txt_cname.Focus()
    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txt_cname.Text <> "" Then

            If txt_add.Text <> "" Then

                If txt_Cno.Text <> "" Then

                    If flag = 0 Then
                        'insert

                        Dim f As Integer = 0
                        Dim dao As New Dao

                        f = dao.validate("Select Customer_Name from Customer where Customer_Name='" & txt_cname.Text & "'")
                        dao.close_conn()
                        If f = 1 Then
                            MessageBox.Show("Unable to Create Customer it is already Created")

                            txt_cname.Focus()
                        Else
                            dao.modifyData("insert into Customer (Customer_Name,Address,Contact) values('" & txt_cname.Text & "','" & txt_add.Text & "','" & txt_Cno.Text & "')")
                            MessageBox.Show("Customer is Created")

                            btn_clr_Click(sender, e)
                        End If
                    Else
                        'update

                        Dim dao As New Dao
                        dao.modifyData("update Customer set Customer_Name='" & txt_cname.Text & "',Address='" & txt_add.Text & "',Contact='" & txt_Cno.Text & "'where Customer_ID='" & txt_id.Text & "'")
                        MessageBox.Show("Customer is Updated")
                        btn_clr_Click(sender, e)
                    End If



                    MessageBox.Show("Customer Added Successfully")
                    reset()
                Else
                    MsgBox("Enter Contact Number", MsgBoxStyle.Critical)

                    txt_Cno.Focus()
                End If
            Else
                MsgBox("Enter Address", MsgBoxStyle.Critical)

                txt_add.Focus()
            End If
        Else
            MsgBox("Enter Customer Name", MsgBoxStyle.Critical)


        End If
        loaddata()
        txt_cname.Focus()
        btn_del.Enabled = False
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Customer_DataGridView.CellContentDoubleClick
        If Customer_DataGridView.Rows.Count > 0 Then
            'Customer id

            txt_id.Text = Customer_DataGridView.Item("Customer_ID", Customer_DataGridView.CurrentCell.RowIndex).Value

            'Customer name

            txt_cname.Text = Customer_DataGridView.Item("Customer_Name", Customer_DataGridView.CurrentCell.RowIndex).Value

            'Customer Address

            txt_add.Text = Customer_DataGridView.Item("Address", Customer_DataGridView.CurrentCell.RowIndex).Value

            'Customer Contact Number

            txt_Cno.Text = Customer_DataGridView.Item("Contact", Customer_DataGridView.CurrentCell.RowIndex).Value
            flag = 1
        End If
        btn_del.Enabled = True
    End Sub
    Public Sub loaddata()
        Dim ds As New Data.DataSet
        Dim d As New Dao
        ds = d.loaddata("select * from Customer")
        Customer_DataGridView.DataSource = ds.Tables(0)
    End Sub

    Private Sub Add_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
        txt_cname.Focus()
        btn_del.Enabled = False
    End Sub
    Public Sub reset()
        txt_id.Text = ""
        txt_cname.Text = ""
        txt_add.Text = ""
        txt_Cno.Text = ""
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        Me.Close()

    End Sub

    Private Sub Label4_MouseHover(sender As Object, e As EventArgs) Handles Label4.MouseHover

        Label4.BackColor = Color.Red
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave

        Label4.BackColor = Color.White
    End Sub

    Private Sub btn_clr_MouseHover(sender As Object, e As EventArgs) Handles btn_clr.MouseHover

        btn_clr.BackColor = Color.Orange
        btn_clr.ForeColor = Color.White
    End Sub

    Private Sub btn_clr_MouseLeave(sender As Object, e As EventArgs) Handles btn_clr.MouseLeave

        btn_clr.BackColor = Color.Transparent
        btn_clr.ForeColor = Color.Black
    End Sub

    Private Sub btn_add_MouseHover(sender As Object, e As EventArgs) Handles btn_add.MouseHover

        btn_add.BackColor = Color.GreenYellow
        btn_add.ForeColor = Color.Black
    End Sub

    Private Sub btn_add_MouseLeave(sender As Object, e As EventArgs) Handles btn_add.MouseLeave

        btn_add.BackColor = Color.Transparent
        btn_add.ForeColor = Color.Black
    End Sub

    Private Sub btn_del_MouseHover(sender As Object, e As EventArgs) Handles btn_del.MouseHover

        btn_del.BackColor = Color.Tomato
        btn_del.ForeColor = Color.White
    End Sub

    Private Sub btn_del_MouseLeave(sender As Object, e As EventArgs) Handles btn_del.MouseLeave

        btn_del.BackColor = Color.Transparent
        btn_del.ForeColor = Color.Black
    End Sub

    Private Sub txt_cname_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If sender.name = txt_cname.Name Then
                txt_add.Focus()
            ElseIf sender.name = txt_add.Name Then
                txt_Cno.Focus()
            ElseIf sender.name = txt_Cno.Name Then
                btn_add_Click(sender, e)
            End If
        End If
        Dim d As New Dao
        d.char_validate(e)
    End Sub

    Private Sub txt_Cno_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txt_Cno.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        Dim c As Integer = MessageBox.Show("Do you Really want to Delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If c = 6 Then
            Dim d As New Dao
            d.modifyData("delete from Customer where Customer_ID=" & txt_id.Text)
            loaddata()
            btn_clr_Click(sender, e)
            MsgBox("Customer Deleted Successfully", MsgBoxStyle.Information)
        End If
        btn_del.Enabled = False
    End Sub

    Private Sub txt_cname_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txt_Cno.KeyDown, txt_cname.KeyDown, txt_add.KeyDown
        If e.KeyCode = Keys.Enter Then
            If sender.name = txt_cname.Name Then
                txt_add.Focus()
            ElseIf sender.name = txt_add.Name Then
                txt_Cno.Focus()
            ElseIf sender.name = txt_Cno.Name Then
                btn_add_Click(sender, e)
            End If
        End If
    End Sub
End Class