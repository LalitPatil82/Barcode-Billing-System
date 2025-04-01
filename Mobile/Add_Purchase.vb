Imports System.ComponentModel
Public Class Add_Purchase

    Private Sub Add_Purchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmb_supname.Focus()
        load_supplier()
        ComboBox1.Text = ""

        If invno <> "" Then

            txt_invoice.Text = invno

            invno = ""

            load_invoice_data()
        End If
        load_product()
        load_imei()
        ' loaddata()







    End Sub
    Public Sub load_imei()
        Try
            Dim d As New Dao
            Dim ds As New Data.DataSet

            ds = d.loaddata("select * from IMEI_NUM")

            ComboBox1.DisplayMember = "IMEI_NUMBER"
            ComboBox1.ValueMember = "Purchase_id"
            ComboBox1.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub load_supplier()

        Try
            Dim d As New Dao
            Dim ds As New Data.DataSet

            ds = d.loaddata("Select distinct(Supplier_Name),Sup_id from Supplier")

            cmb_supname.DisplayMember = "Supplier_Name"
            cmb_supname.ValueMember = "Sup_id"
            cmb_supname.DataSource = ds.Tables(0)



        Catch ex As Exception



        End Try
    End Sub

    Private Sub load_product()

        Try
            Dim d As New Dao
            Dim ds As New Data.DataSet

            ds = d.loaddata("Select distinct(Product_Name),Product_id from Product")

            cmb_pname.DisplayMember = "Product_Name"
            cmb_pname.ValueMember = "Product_id"
            cmb_pname.DataSource = ds.Tables(0)



        Catch ex As Exception



        End Try
    End Sub

    Private Sub txt_supname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_supname.SelectedIndexChanged

        If cmb_supname.Text <> "" Then

            'load gst number in txt_gst_no

            Dim d As New Dao
            Dim ds As New Data.DataSet

            ds = d.loaddata("Select GST_No,Brand from Supplier where Sup_Id =" & cmb_supname.SelectedValue)

            If ds.Tables(0).Rows.Count > 0 Then

                txt_gst_no.Text = ds.Tables(0).Rows(0).Item(0)
                txt_brand.Text = ds.Tables(0).Rows(0).Item(1)

            End If
        End If
    End Sub





    Private Sub txt_supname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_supname.KeyPress, DateTimePicker2.KeyPress, DateTimePicker1.KeyPress, txt_hsn.KeyPress

        If e.KeyChar.GetHashCode = 851981 Then

            If sender.Name = cmb_supname.Name Then

                DateTimePicker2.Focus()

            ElseIf sender.Name = DateTimePicker2.Name Then

                DateTimePicker1.Focus()

            ElseIf sender.Name = DateTimePicker1.Name Then

                txt_hsn.Focus()

            ElseIf sender.Name = txt_hsn.Name Then

                txt_qty.Focus()

            ElseIf sender.Name = txt_qty.Name Then

                txt_rate.Focus()

            ElseIf sender.Name = txt_rate.Name Then

                txt_amt.Focus()



            End If
        End If

        If sender.Name = cmb_supname.Name Then

        End If
    End Sub

    Private Sub Btn_add_list_Click(sender As Object, e As EventArgs) Handles Btn_add_list.Click

        txt_qty.Text = qty


        If cmb_supname.Text <> "" Then

            If txt_gst_no.Text <> "" Then

                If txt_brand.Text <> "" Then

                    If txt_invoice.Text <> "" Then

                        If cmb_pname.Text <> "" Then

                            If txt_hsn.Text <> "" Then

                                If txt_qty.Text <> "" Then

                                    If txt_rate.Text <> "" Then

                                        If txt_cgst.Text <> "" Then

                                            If txt_sgst.Text <> "" Then

                                                If txt_amt.Text <> "" Then

                                                    If txt_tot_amt.Text <> "" Then

                                                        If txt_pgst_tot.Text <> "" Then

                                                            'Insert into Purchase Detail

                                                            Dim d As New Dao

                                                            d.modifyData("insert into Purchase_detail(Invoice_No,Product_Name,HSN_Code,Quantity,Rate,P_CGST,P_SGST,P_Total) values('" & txt_invoice.Text & "','" & cmb_pname.Text & "','" & txt_hsn.Text & "','" & txt_qty.Text & "'," & txt_rate.Text & "," & txt_cgst.Text & "," & txt_sgst.Text & "," & txt_tot_amt.Text & ")")
                                                            MessageBox.Show("Added Successfuly", "Message")

                                                            load_invoice_data()


                                                            If DataGridView1.Rows.Count = 1 Then
                                                                'Insert into Purchase Summary
                                                                d.modifyData("Insert into Purchase_summary(Bill_Date,Due_Date,Invoice_No,Ledger_Name,Round_Off,Total_pgst,Total_Amount) values('" & DateTimePicker1.Value.ToShortDateString() & "','" & DateTimePicker2.Value.ToShortDateString() & "','" & txt_invoice.Text & "','" & cmb_supname.Text & "'," & txt_round.Text & "," & txt_pgst_tot.Text & "," & txt_grd_tot.Text & ")")

                                                                'Insert into Stock Master
                                                                Try
                                                                    Dim con As New SqlClient.SqlConnection("Data Source=(local);Initial Catalog=data_stu16;Integrated Security=True")

                                                                    Dim cm As Integer = ComboBox1.Items.Count

                                                                    For i As Integer = 0 To cm

                                                                        Using cmd As New SqlClient.SqlCommand("insert into Stock(Invoice_No,Product_Name,IMEI_NUMBER,HSN_Code,Quantity) values(@Invoice_No,@Product_Name,@IMEI_NUMBER,@HSN_Code,@Quantity)", con)

                                                                            cmd.Parameters.AddWithValue("@Invoice_No", txt_invoice.Text)
                                                                            cmd.Parameters.AddWithValue("@Product_Name", cmb_pname.Text)
                                                                            cmd.Parameters.AddWithValue("@IMEI_NUMBER", ComboBox1.Text.ToString())
                                                                            cmd.Parameters.AddWithValue("@HSN_Code", txt_hsn.Text)
                                                                            cmd.Parameters.AddWithValue("@Quantity", TextBox3.Text)

                                                                            cm -= 1
                                                                            If ComboBox1.SelectedIndex < cm Then

                                                                                ComboBox1.SelectedIndex = ComboBox1.SelectedIndex + 1
                                                                            End If
                                                                            i += 1

                                                                            con.Open()
                                                                            cmd.ExecuteNonQuery()
                                                                            con.Close()
                                                                        End Using
                                                                    Next

                                                                    MessageBox.Show("Inserted into Stock", "Message")
                                                                Catch ex As Exception

                                                                    MessageBox.Show(ex.Message)
                                                                End Try

                                                                load_imei()

                                                                'Delete from Temp table

                                                                Dim da As New Dao

                                                                Try

                                                                    da.modifyData("Delete  from IMEI_NUM")
                                                                Catch ex As Exception

                                                                    MessageBox.Show(ex.Message)
                                                                End Try
                                                                clear()
                                                            Else

                                                                'Update Totals

                                                                d.modifyData("update Purchase_summary set Total_pgst=" & txt_tot_gst.Text & ",Total_Amount = " & txt_grd_tot.Text & ",Round_Off = " & txt_round.Text & " where Invoice_No = '" & txt_invoice.Text & "'")



                                                            End If


                                                        Else

                                                            MessageBox.Show("Enter Total GST Per Product Amount ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                        End If



                                                    Else

                                                        MessageBox.Show("Enter Total Amount ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                                        txt_tot_amt.Focus()
                                                    End If

                                                Else

                                                    MessageBox.Show("Enter Amount ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                                    txt_amt.Focus()
                                                End If

                                            Else
                                                MessageBox.Show("Enter SGST ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                                txt_sgst.Focus()

                                            End If

                                        Else

                                            MessageBox.Show("Enter CGST ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                            txt_cgst.Focus()

                                        End If
                                    Else

                                        MessageBox.Show("Enter Rate", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                        txt_rate.Focus()

                                    End If
                                Else

                                    MessageBox.Show("Enter Qty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                    txt_qty.Focus()

                                End If

                            Else

                                MessageBox.Show("Enter HNS Code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                txt_hsn.Focus()

                            End If
                        Else

                            MessageBox.Show("Select Product Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            cmb_pname.Focus()

                        End If
                    Else

                        MessageBox.Show("Enter Invoice no", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        txt_invoice.Focus()

                    End If
                Else
                    MessageBox.Show("Enter Brand", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    txt_brand.Focus()


                End If
            Else
                MessageBox.Show("Enter Ledger GST No", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                txt_gst_no.Focus()


            End If
        Else
            MessageBox.Show("Enter Ledger Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cmb_supname.Focus()

        End If
    End Sub

    Private Sub load_invoice_data()

        Try

            Dim d As New Dao
            Dim dd As New Data.DataSet

            dd = d.loaddata("Select * from Purchase_summary where Invoice_No = '" & txt_invoice.Text & "'")

            If dd.Tables(0).Rows.Count > 0 Then

                DateTimePicker1.Value = dd.Tables(0).Rows(0).Item("Bill_Date")
                DateTimePicker2.Value = dd.Tables(0).Rows(0).Item("Due_Date")
                txt_invoice.Text = dd.Tables(0).Rows(0).Item("Invoice_No")
                cmb_supname.Text = dd.Tables(0).Rows(0).Item("Ledger_Name")
                txt_round.Text = dd.Tables(0).Rows(0).Item("Round_Off")
                txt_pgst_tot.Text = dd.Tables(0).Rows(0).Item("Total_pgst")
                txt_tot_amt.Text = dd.Tables(0).Rows(0).Item("Total_Amount")
            End If

            Dim ds As New Data.DataSet

            ds = d.loaddata("Select Purchase_Id,Product_Name,HSN_Code,Rate,Quantity,P_CGST,P_SGST,P_Total from Purchase_Detail where Invoice_No = '" & txt_invoice.Text & "'")

            DataGridView1.DataSource = ds.Tables(0)

            'calculate totals
            Dim c As Integer = DataGridView1.Rows.Count - 1
            Dim tot As Double = 0
            Dim cgsttot As Double = 0
            Dim sgsttot As Double = 0
            Dim gtot As Double = 0
            While c >= 0

                cgsttot += Math.Round(((Val(DataGridView1.Rows(c).Cells("Quantity").Value) * Val(DataGridView1.Rows(c).Cells("Rate").Value)) * Val(DataGridView1.Rows(c).Cells("P_CGST").Value)) / 100, 2)

                sgsttot += Math.Round(((Val(DataGridView1.Rows(c).Cells("Quantity").Value) * Val(DataGridView1.Rows(c).Cells("Rate").Value)) * Val(DataGridView1.Rows(c).Cells("P_SGST").Value)) / 100, 2)

                gtot += Val(DataGridView1.Rows(c).Cells("P_Total").Value)

                c -= 1
            End While

            txt_cgst_amt.Text = cgsttot
            txt_sgst_amt.Text = sgsttot
            txt_tot_gst.Text = cgsttot + sgsttot
            txt_grd_tot.Text = Math.Round(gtot + Val(txt_round.Text), 2)
        Catch ex As Exception

            MessageBox.Show(ex.Message)


        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Btn_search.Click

        Dim ino As String = InputBox("Enter Invoice No", "Invoice Search")
        If ino <> "" And ino <> "0" Then
            txt_invoice.Text = ino
            load_invoice_data()
        End If
    End Sub



    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

        Me.Close()
    End Sub

    Private Sub Label22_MouseHover(sender As Object, e As EventArgs) Handles Label22.MouseHover

        Label22.BackColor = Color.Red
    End Sub

    Private Sub Label22_MouseLeave(sender As Object, e As EventArgs) Handles Label22.MouseLeave

        Label22.BackColor = Color.White
    End Sub

    Private Sub txt_qty_Enter(sender As Object, e As EventArgs) Handles txt_qty.Enter

        Dim imei As New IMEI_store

            imei.Show()



    End Sub


    Private Sub txt_rate_TextChanged(sender As Object, e As EventArgs) Handles txt_rate.TextChanged


        'If sender.text <> "" And IsNumeric(sender.text) Then
        'calculate the amount according to qty 


        Dim rate As Double = Val(txt_rate.Text)

        txt_amt.Text = Math.Round(qty * rate, 2)

        'calculate the total amount with cgst and sgst

        Dim cgst As Double = Math.Round(Val(txt_cgst.Text) * Val(txt_amt.Text) / 100, 2)
        Dim sgst As Double = Math.Round(Val(txt_sgst.Text) * Val(txt_amt.Text) / 100, 2)

        txt_cgst_amtper.Text = cgst
        txt_sgst_amtper.Text = sgst
        txt_pgst_tot.Text = cgst + sgst

        txt_tot_amt.Text = Val(txt_amt.Text) + Val(txt_pgst_tot.Text)

        load_imei()

    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Btn_delete.Enabled = True

        Dim index As Integer

        index = e.RowIndex

        Dim selected As DataGridViewRow

        selected = DataGridView1.Rows(index)

        TextBox1.Text = selected.Cells(0).Value.ToString()
        cmb_pname.Text = selected.Cells(1).Value.ToString()
        txt_hsn.Text = selected.Cells(2).Value.ToString()
        txt_rate.Text = selected.Cells(3).Value.ToString()
        txt_qty.Text = selected.Cells(4).Value.ToString()
        txt_cgst.Text = selected.Cells(5).Value.ToString()
        txt_sgst.Text = selected.Cells(6).Value.ToString()
        txt_tot_amt.Text = selected.Cells(7).Value.ToString()

        txt_amt.Text = Val(txt_qty.Text) * Val(txt_rate.Text)
        'txt_grd_tot.Text = Math.Round(Val(txt_grd_tot.Text))

        '  txt_round.Text = Math.Round(Val(txt_grd_tot.Text) - Val(txt_tot_amt.Text), 2)


    End Sub

    Private Sub txt_amt_TextChanged(sender As Object, e As EventArgs) Handles txt_amt.TextChanged

        txt_cgst_amtper.Text = Math.Round(Val(txt_amt.Text) * Val(txt_cgst.Text) / 100, 2)
        txt_sgst_amtper.Text = Math.Round(Val(txt_amt.Text) * Val(txt_sgst.Text) / 100, 2)

        txt_pgst_tot.Text = Val(txt_cgst_amtper.Text) + Val(txt_sgst_amtper.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_delete.Click

        'Delete the Data


        Dim d As Integer = MessageBox.Show("Do you want to delete " & DataGridView1.Item("Product_Name", DataGridView1.CurrentCell.RowIndex).Value & "?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        txt_grd_tot.Text = Val(txt_grd_tot.Text) - Val(txt_tot_amt.Text)

        If d = 6 Then

            Dim id As Integer = DataGridView1.Item("Purchase_ID", DataGridView1.CurrentCell.RowIndex).Value
            Dim dp As New Dao
            dp.modifyData("delete from Purchase_detail where Purchase_ID=" & TextBox1.Text)


            load_invoice_data()


            If DataGridView1.Rows.Count = 0 Then
                dp.modifyData("delete from Purchase_summary where Invoice_No='" & txt_invoice.Text & "'")
            Else
                'UPDATE TOTALS
                dp.modifyData("update Purchase_summary set  Round_Off = " & txt_round.Text & ",Total_pgst = " & txt_tot_gst.Text & ",Total_Amount = " & txt_grd_tot.Text & " where Invoice_No ='" & txt_invoice.Text & "'")
            End If

            Dim delete_imei As New Delete_IMEI

            delete_imei.Show()

            Btn_delete.Enabled = False

        End If



    End Sub
    Private Sub clear()
        txt_hsn.Text = ""
        txt_qty.Text = ""
        txt_rate.Text = ""
        txt_amt.Text = ""
        txt_tot_amt.Text = ""
        txt_cgst_amtper.Text = ""
        txt_sgst_amtper.Text = ""
        txt_cgst_amt.Text = ""
        txt_sgst_amt.Text = ""
        txt_grd_tot.Text = ""
        txt_tot_gst.Text = ""
        txt_pgst_tot.Text = ""
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_new.Click

        txt_invoice.Text = ""
        clear
        'DataGridView1.Rows.Clear()
        DataGridView1.Refresh()

        load_imei()



    End Sub


    Private Sub txt_amt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_tot_gst.KeyPress, txt_tot_amt.KeyPress, txt_sgst_amtper.KeyPress, txt_sgst_amt.KeyPress, txt_sgst.KeyPress, txt_round.KeyPress, txt_rate.KeyPress, txt_pgst_tot.KeyPress, txt_hsn.KeyPress, txt_grd_tot.KeyPress, txt_cgst_amtper.KeyPress, txt_cgst_amt.KeyPress, txt_cgst.KeyPress, txt_amt.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmb_supname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_supname.KeyPress, cmb_pname.KeyPress
        If sender.name = cmb_supname.Name Then
            AutoSearch(sender, e, True)
        ElseIf sender.name = cmb_pname.Name Then
            AutoSearch(sender, e, True)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Btn_save.Click

        Dim c As Integer = MessageBox.Show("Do you want to Save Invoice?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If c = 6 Then
            Dim d As New Dao
            'UPDATE TOTALS
            d.modifyData("update Purchase_summary set Round_Off=" & txt_round.Text & ",Total_pgst=" & txt_tot_gst.Text & ",Tota_Amount=" & txt_grd_tot.Text & "where Invoice_No='" & txt_invoice.Text & "'")

            MessageBox.Show("Updated", "Message")


        End If


    End Sub

    Private Sub txt_sgst_amtper_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_tot_gst.KeyPress, txt_tot_amt.KeyPress, txt_sgst_amtper.KeyPress, txt_sgst_amt.KeyPress, txt_sgst.KeyPress, txt_round.KeyPress, txt_rate.KeyPress, txt_qty.KeyPress, txt_pgst_tot.KeyPress, txt_invoice.KeyPress, txt_hsn.KeyPress, txt_gst_no.KeyPress, txt_grd_tot.KeyPress, txt_cgst_amtper.KeyPress, txt_cgst_amt.KeyPress, txt_cgst.KeyPress, txt_brand.KeyPress, txt_amt.KeyPress, DateTimePicker2.KeyPress, DateTimePicker1.KeyPress, cmb_supname.KeyPress, cmb_pname.KeyPress, Btn_save.KeyPress, Btn_search.KeyPress, Btn_delete.KeyPress, Btn_new.KeyPress, Btn_add_list.KeyPress
        If e.KeyChar.GetHashCode = 851981 Then
            If sender.name = cmb_supname.Name Then
                txt_brand.Focus()
            ElseIf sender.name = txt_brand.Name Then
                DateTimePicker1.Focus()
            ElseIf sender.name = DateTimePicker1.Name Then
                txt_gst_no.Focus()
            ElseIf sender.name = txt_gst_no.Name Then
                DateTimePicker2.Focus()
            ElseIf sender.name = DateTimePicker2.Name Then
                txt_invoice.Focus()
            ElseIf sender.name = txt_invoice.Name Then
                cmb_pname.Focus()
            ElseIf sender.name = cmb_pname.Name Then
                txt_hsn.Focus()
            ElseIf sender.name = txt_rate.Name Then
                txt_cgst.Focus()
            ElseIf sender.name = txt_cgst.Name Then
                txt_sgst.Focus()
            ElseIf sender.name = txt_sgst.Name Then
                txt_amt.Focus()
            ElseIf sender.name = txt_amt.Name Then
                txt_tot_amt.Focus()
            ElseIf sender.name = txt_tot_amt.Name Then
                txt_tot_gst.Focus()
            ElseIf sender.name = txt_tot_gst.Name Then
                txt_round.Focus()
            ElseIf sender.name = txt_round.Name Then
                txt_grd_tot.Focus()
            ElseIf sender.name = txt_grd_tot.Name Then
                Btn_add_list_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub Btn_add_list_MouseHover(sender As Object, e As EventArgs) Handles Btn_add_list.MouseHover

        Btn_add_list.BackColor = Color.GreenYellow
    End Sub

    Private Sub Btn_add_list_MouseLeave(sender As Object, e As EventArgs) Handles Btn_add_list.MouseLeave

        Btn_add_list.BackColor = Color.White
    End Sub

    Private Sub Btn_new_MouseHover(sender As Object, e As EventArgs) Handles Btn_new.MouseHover

        Btn_new.BackColor = Color.Orange
        Btn_new.ForeColor = Color.White
    End Sub

    Private Sub Btn_new_MouseLeave(sender As Object, e As EventArgs) Handles Btn_new.MouseLeave

        Btn_new.BackColor = Color.White
        Btn_new.ForeColor = Color.Black
    End Sub


End Class