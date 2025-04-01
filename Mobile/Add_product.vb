Imports System.ComponentModel
Public Class Add_product

    Dim flag = 0
    'Dim table As New DataTable
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            If txt_pname.Text <> "" Then
                If txt_GST.Text <> "" Then
                    If txt_cgst_sgst.Text <> "" Then
                        If txt_brate.Text <> "" Then
                            If txt_sales_rate.Text <> "" Then
                                If flag = 0 Then
                                    'insert
                                    Dim f As Integer = 0
                                    Dim dao As New Dao
                                    f = dao.validate("Select Product_Name from Product where Product_Name='" & txt_pname.Text & "'")
                                    dao.close_conn()
                                    If f = 1 Then
                                        MessageBox.Show("Unable to add Product it is already Created")
                                        txt_pname.Focus()
                                    Else
                                        dao.modifyData("insert into Product (Product_Name,Rate,GST,[CGST/SGST],Amount,Sales_Rate) values('" & txt_pname.Text & "','" & txt_rate.Text & "','" & txt_GST.Text & "','" & txt_cgst_sgst.Text & "','" & txt_brate.Text & "','" & txt_sales_rate.Text & "')")
                                        MsgBox("Product Added Successfully", MsgBoxStyle.Information)
                                        btn_clr_Click(sender, e)
                                    End If
                                Else
                                    'update
                                    Dim dao As New Dao
                                    dao.modifyData("update Product set Product_Name='" & txt_pname.Text & "',Rate='" & txt_rate.Text & "',GST='" & txt_GST.Text & "',[CGST/SGST]='" & txt_cgst_sgst.Text & "',Amount='" & txt_brate.Text & "',Sales_Rate='" & txt_sales_rate.Text & "'where Product_id='" & txt_id.Text & "'")
                                    MessageBox.Show("Product is Updated")
                                    btn_clr_Click(sender, e)
                                End If
                            Else
                                MsgBox("Ente Sales Price", MsgBoxStyle.Critical)

                                txt_sales_rate.Focus()
                            End If
                        Else

                            MsgBox("Enter Basic Price", MsgBoxStyle.Critical)

                            txt_brate.Focus()
                        End If
                    Else

                        MsgBox("Enter CGST/SGST", MsgBoxStyle.Critical)

                        txt_cgst_sgst.Focus()
                    End If
                Else

                    MsgBox("Enter GST", MsgBoxStyle.Critical)

                    txt_GST.Focus()
                End If
            Else

                MsgBox("Enter Product Name", MsgBoxStyle.Critical)

                txt_pname.Focus()
            End If
            loaddata()
            txt_rate.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub loaddata()
        Dim ds As New Data.DataSet
        Dim d As New Dao
        ds = d.loaddata("select * from Product")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub



    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Try
            If DataGridView1.Rows.Count > 0 Then
                'Product id

                txt_id.Text = DataGridView1.Item("p_id", DataGridView1.CurrentCell.RowIndex).Value

                'Product_name

                txt_pname.Text = DataGridView1.Item("p_name", DataGridView1.CurrentCell.RowIndex).Value

                'GST

                txt_GST.Text = DataGridView1.Item("GST", DataGridView1.CurrentCell.RowIndex).Value

                'CGST/SGST

                txt_cgst_sgst.Text = DataGridView1.Item("CGST_SGST", DataGridView1.CurrentCell.RowIndex).Value

                'Basic Price

                txt_brate.Text = DataGridView1.Item("Amount", DataGridView1.CurrentCell.RowIndex).Value

                'Sales Rate

                txt_sales_rate.Text = DataGridView1.Item("Sales_Rate", DataGridView1.CurrentCell.RowIndex).Value

                flag = 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btn_del.Enabled = True
    End Sub

    Private Sub Add_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loaddata()
        txt_pname.Focus()
        btn_del.Enabled = False
        txt_pname.Focus()
        If Pname <> "" Then
            txt_pname.Text = Pname
        End If
    End Sub

    Private Sub txt_brate_TextChanged(sender As Object, e As EventArgs) Handles txt_brate.TextChanged
        ' Don't Remove Try Catch Block From This Section 

        Try
            txt_cgst_sgst.Text = Val(txt_brate.Text - (txt_brate.Text * (100 / (100 + txt_GST.Text))))
            txt_rate.Text = Val(txt_brate.Text - txt_cgst_sgst.Text)
        Catch ex As Exception

        End Try
        If txt_brate.Text = "" Then
            txt_cgst_sgst.Text = "0"
            txt_rate.Text = "0"
        End If
    End Sub

    Private Sub btn_clr_Click(sender As Object, e As EventArgs) Handles btn_clr.Click
        reset()
        flag = 0
        txt_pname.Focus()
        btn_del.Enabled = False
    End Sub

    Private Sub txt_cgst_sgst_Enter(sender As Object, e As EventArgs) Handles txt_cgst_sgst.Enter
        'Don't remove Try Catch Blocks
        Try
            txt_cgst_sgst.Text = Val(txt_brate.Text - (txt_brate.Text * (100 / (100 + txt_GST.Text))))
        Catch ex As Exception

        End Try
    End Sub
    Public Sub reset()
        txt_id.Text = ""
        txt_pname.Text = ""
        txt_brate.Text = ""
        txt_sales_rate.Text = ""
        txt_cgst_sgst.Text = ""
        txt_rate.Text = ""
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        Dim c As Integer = MessageBox.Show("Do you Really want to Delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If c = 6 Then
            Dim d As New Dao
            d.modifyData("delete from Product where Product_id=" & txt_id.Text)
            loaddata()
            btn_clr_Click(sender, e)
        End If
        btn_del.Enabled = False
    End Sub
    Private Sub txt_GST_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sales_rate.KeyPress, txt_rate.KeyPress, txt_GST.KeyPress, txt_cgst_sgst.KeyPress, txt_brate.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_rate_TextChanged(sender As Object, e As EventArgs) Handles txt_rate.TextChanged
        txt_rate.Text = Math.Round(Val(txt_rate.Text), 2)
    End Sub

    Private Sub txt_cgst_sgst_TextChanged(sender As Object, e As EventArgs) Handles txt_cgst_sgst.TextChanged

        txt_cgst_sgst.Text = Math.Round(Val(txt_cgst_sgst.Text), 2)
    End Sub



    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

        Me.Close()

    End Sub

    Private Sub Label9_MouseHover(sender As Object, e As EventArgs) Handles Label9.MouseHover

        Label9.BackColor = Color.Red
    End Sub

    Private Sub Label9_MouseLeave(sender As Object, e As EventArgs) Handles Label9.MouseLeave
        Label9.BackColor = Color.White
    End Sub

    Private Sub btn_clr_MouseHover(sender As Object, e As EventArgs) Handles btn_clr.MouseHover

        btn_clr.BackColor = Color.DarkOrange
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

    Private Sub DataGridView1_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles DataGridView1.ColumnAdded

        'Column ke click par hum sort nahi kar sakte
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub txt_pname_GotFocus(sender As Object, e As EventArgs) Handles txt_pname.GotFocus
        txt_pname.Focus()
    End Sub

    Private Sub txt_pname_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_sales_rate.KeyDown, txt_rate.KeyDown, txt_pname.KeyDown, txt_GST.KeyDown, txt_cgst_sgst.KeyDown, txt_brate.KeyDown
        If e.KeyCode = Keys.Enter Then
            If sender.name = txt_pname.Name Then
                txt_GST.Focus()
            ElseIf sender.name = txt_GST.name Then
                txt_brate.Focus()
            ElseIf sender.name = txt_brate.Name Then
                txt_cgst_sgst.Focus()
            ElseIf sender.name = txt_cgst_sgst.Name Then
                txt_rate.Focus()
            ElseIf sender.name = txt_rate.Name Then
                txt_sales_rate.Focus()
            ElseIf sender.name = txt_sales_rate.name Then
                btn_add_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub txt_GST_TextChanged(sender As Object, e As EventArgs) Handles txt_GST.TextChanged
        Try
            If txt_GST.Text > 100 Then
                MessageBox.Show("GST cannot be greater than 100")
                txt_GST.Text = 0
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class