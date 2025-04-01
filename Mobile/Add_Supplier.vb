Imports System.ComponentModel
Public Class Add_Supplier
    Dim flag = 0
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            If txt_GST.Text <> "" Then
                If txt_sname.Text <> "" Then
                    If txt_bname.Text <> "" Then
                        If txt_Cno.Text <> "" Then
                            If txt_Pd.Text <> "" Then
                                If txt_add.Text <> "" Then
                                    If txt_st.Text <> "" Then
                                        If txt_city.Text <> "" Then
                                            If txt_bank_name.Text <> "" Then
                                                If flag = 0 Then
                                                    'insert
                                                    Dim f As Integer = 0
                                                    Dim dao As New Dao


                                                    f = dao.validate("Select Supplier_Name from Supplier where Supplier_Name='" & txt_sname.Text & "'")

                                                    dao.close_conn()
                                                    If f = 1 Then
                                                        MessageBox.Show("Unable to Create User it is already Created")

                                                        txt_sname.Focus()
                                                    Else
                                                        dao.modifyData("insert into supplier (GST_No,Supplier_Name,Brand,Address,State,City,Contact_no,Payment_Duration,Bank_Name) values('" & txt_GST.Text & "','" & txt_sname.Text & "','" & txt_bname.Text & "','" & txt_add.Text & "','" & txt_st.Text & "','" & txt_city.Text & "','" & txt_Cno.Text & "','" & txt_Pd.Text & "','" & txt_bank_name.Text & "')")
                                                        MsgBox("Supplier Added Successfully", MsgBoxStyle.Information)
                                                        reset()
                                                    End If
                                                Else
                                                    'update
                                                    Dim dao As New Dao
                                                    dao.modifyData("update Supplier set Supplier_Name='" & txt_sname.Text & "',GST_No='" & txt_GST.Text & "',Brand='" & txt_bname.Text & "',Address='" & txt_add.Text & "',State='" & txt_st.Text & "',City='" & txt_city.Text & "',Contact_no='" & txt_Cno.Text & "',Payment_Duration='" & txt_Pd.Text & "',Bank_Name='" & txt_bank_name.Text & "'where Sup_Id='" & txt_id.Text & "'")
                                                    MessageBox.Show("User is Updated")
                                                    btn_clr_Click(sender, e)
                                                End If




                                            Else
                                                MsgBox("Enter Bank Name", MsgBoxStyle.Critical)
                                                txt_bank_name.Focus()
                                            End If
                                        Else
                                            MsgBox("Enter City", MsgBoxStyle.Critical)
                                            txt_city.Focus()
                                        End If
                                    Else
                                        MsgBox("Enter State", MsgBoxStyle.Critical)
                                        txt_st.Focus()
                                    End If
                                Else
                                    MsgBox("Enter Address", MsgBoxStyle.Critical)
                                    txt_add.Focus()
                                End If
                            Else
                                MsgBox("Enter Payment Duration", MsgBoxStyle.Critical)
                                txt_Pd.Focus()
                            End If
                        Else
                            MsgBox("Enter Contact Number", MsgBoxStyle.Critical)
                            txt_city.Focus()
                        End If
                    Else
                        MsgBox("Enter Brand Name", MsgBoxStyle.Critical)
                        txt_bname.Focus()
                    End If
                Else
                    MsgBox("Enter Supplier Name", MsgBoxStyle.Critical)
                    txt_sname.Focus()
                End If
            Else
                MsgBox("Enter GST Number", MsgBoxStyle.Critical)
                txt_GST.Focus()
            End If
            loaddata()
            btn_del.Enabled = False
        Catch ex As Exception

        End Try
    End Sub
    Public Sub loaddata()
        Dim ds As New Data.DataSet
        Dim d As New Dao
        ds = d.loaddata("select * from Supplier")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        If DataGridView1.Rows.Count > 0 Then
            'Supplier ID
            txt_id.Text = DataGridView1.Item("Supplier_ID", DataGridView1.CurrentCell.RowIndex).Value

            'Supplier Name
            txt_sname.Text = DataGridView1.Item("Supplier_Name", DataGridView1.CurrentCell.RowIndex).Value

            'GST Number
            txt_GST.Text = DataGridView1.Item("GST_No", DataGridView1.CurrentCell.RowIndex).Value

            'Brand Name
            txt_bname.Text = DataGridView1.Item("Brand", DataGridView1.CurrentCell.RowIndex).Value

            'Contact Number
            txt_Cno.Text = DataGridView1.Item("Contact_no", DataGridView1.CurrentCell.RowIndex).Value

            'Payment Duration
            txt_Pd.Text = DataGridView1.Item("Payment_Duration", DataGridView1.CurrentCell.RowIndex).Value

            'Address
            txt_add.Text = DataGridView1.Item("Address", DataGridView1.CurrentCell.RowIndex).Value

            'State
            txt_st.Text = DataGridView1.Item("State", DataGridView1.CurrentCell.RowIndex).Value

            'City
            txt_city.Text = DataGridView1.Item("City", DataGridView1.CurrentCell.RowIndex).Value

            'Bank Name
            txt_bank_name.Text = DataGridView1.Item("Bank_Name", DataGridView1.CurrentCell.RowIndex).Value

            flag = 1
        End If
        btn_del.Enabled = True
    End Sub

    Private Sub Add_Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_sname.Focus()
        loaddata()
        btn_del.Enabled = False
    End Sub
    Public Sub reset()
        txt_id.Text = ""
        txt_sname.Text = ""
        txt_GST.Text = ""
        txt_bname.Text = ""
        txt_Cno.Text = ""
        txt_Pd.Text = ""
        txt_add.Text = ""
        txt_st.Text = ""
        txt_city.Text = ""
        txt_bank_name.Text = ""
    End Sub
    Private Sub btn_clr_Click(sender As Object, e As EventArgs) Handles btn_clr.Click
        reset()
        flag = 0
        btn_del.Enabled = False
        txt_sname.Focus()
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        Dim c As Integer = MessageBox.Show("Do you Really want to Delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If c = 6 Then
            Dim d As New Dao
            d.modifyData("delete from Supplier where Sup_Id=" & txt_id.Text)
            loaddata()
            btn_clr_Click(sender, e)
        End If
    End Sub

    Private Sub Add_Supplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Pd.KeyPress, MyBase.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then

                e.Handled = True

            End If
        End If
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Me.Close()

    End Sub

    Private Sub Label12_MouseHover(sender As Object, e As EventArgs) Handles Label12.MouseHover

        Label12.BackColor = Color.Red
    End Sub

    Private Sub Label12_MouseLeave(sender As Object, e As EventArgs) Handles Label12.MouseLeave

        Label12.BackColor = Color.White
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

    Private Sub txt_id_TextChanged(sender As Object, e As EventArgs) Handles txt_id.TextChanged

    End Sub

    Private Sub txt_s(sender As Object, e As KeyEventArgs) Handles txt_id.KeyDown, btn_add.KeyDown


    End Sub



    Private Sub txt_sname_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_st.KeyDown, txt_sname.KeyDown, txt_Pd.KeyDown, txt_GST.KeyDown, txt_Cno.KeyDown, txt_city.KeyDown, txt_bname.KeyDown, txt_bank_name.KeyDown, txt_add.KeyDown
        If e.KeyCode = Keys.Enter Then
            If sender.name = txt_sname.Name Then
                txt_GST.Focus()
            ElseIf sender.name = txt_GST.Name Then
                txt_bname.Focus()
            ElseIf sender.name = txt_bname.Name Then
                txt_Cno.Focus()
            ElseIf sender.name = txt_Cno.Name Then
                txt_Pd.Focus()
            ElseIf sender.name = txt_Pd.Name Then
                txt_add.Focus()
            ElseIf sender.name = txt_add.Name Then
                txt_st.Focus()
            ElseIf sender.name = txt_st.Name Then
                txt_city.Focus()
            ElseIf sender.name = txt_city.Name Then
                txt_bank_name.Focus()
            ElseIf sender.name = txt_bank_name.Name Then
                btn_add_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub txt_Cno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Cno.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_sname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_st.KeyPress, txt_sname.KeyPress, txt_city.KeyPress, txt_bname.KeyPress, txt_bank_name.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = (Chr(Keys.Back)) And Not e.KeyChar = Chr(Keys.Space) Then

            e.Handled = True

        End If
    End Sub
End Class