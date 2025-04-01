
Public Class Invoice

    Public Sub load_invoice()

        Try

            Dim d As New Dao
            Dim ds As New Data.DataSet

            ds = d.loaddata("select * from configure_master")

            If (ds.Tables(0).Rows.Count > 0) Then

                txt_invoice.Text = "SCMS/" & set_zero(ds.Tables(0).Rows(0).Item(0))
            End If
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub




    Public Function set_zero(v As String) As String

        Dim d As Integer = v.Length
        Dim s As String = ""

        For i = d To 3

            s &= "0"
        Next

        s &= v

        Return s
    End Function

    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Button2_Click(sender, e)
        ' txt_cust_name.Focus()
        load_invoice()

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles txt_qty.TextChanged, txt_unit_price.TextChanged


        Dim qty As Double = Val(txt_qty.Text)
        Dim unit_price As Double = Val(txt_unit_price.Text)
        Dim cgst_amt As Double = Math.Round(Val(txt_cgst_per.Text) * unit_price / 100, 2)
        Dim sgst_amt As Double = Math.Round(Val(txt_sgst_per.Text) * unit_price / 100, 2)

        txt_totamt.Text = qty * unit_price + cgst_amt + sgst_amt
        txt_txab_amt.Text = qty * unit_price




    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Me.Hide()

    End Sub

    Private Sub txt_imei_TextChanged(sender As Object, e As EventArgs) Handles txt_imei.TextChanged

        load_imei_data()

        ComboBox1.Text = txt_imei.Text

        Try

            If txt_imei.Text <> "" Then


                'load data

                Dim d As New Dao
                Dim ds As New Data.DataSet

                ds = d.loaddata("Select Product_Name,HSN_Code,Quantity from Stock where Stock_id =" & ComboBox1.SelectedValue)

                If ds.Tables(0).Rows.Count > 0 Then

                    txt_pname.Text = ds.Tables(0).Rows(0).Item(0)
                    txt_hsn.Text = ds.Tables(0).Rows(0).Item(1)
                    txt_qty.Text = ds.Tables(0).Rows(0).Item(2)


                End If

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub load_imei_data()

        Dim d As New Dao
        Dim ds As New Data.DataSet

        ds = d.loaddata("Select distinct(IMEI_NUMBER),Stock_id from Stock")

        ComboBox1.DisplayMember = "IMEI_NUMBER"
        ComboBox1.ValueMember = "Stock_id"
        ComboBox1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_new.Click
        Dim d As New Dao
        Dim flag As Integer = d.validate("select Sales_Id from Sales_Summary where Invoice_No='" & txt_invoice.Text & "'")
        If flag = 1 Then

            'invoice is already created update invoice no and get new invoice no
            Dim invno As Integer = 0
            Dim obj As SqlClient.SqlDataReader
            d.close_conn()
            obj = d.getdata("select Invoice from configure_master")


            While obj.Read
                invno = obj.Item(0)
            End While
            d.close_conn()
            invno += 1
            d.modifyData("update configure_master set Invoice=" & invno)
            load_invoice()
            'DataGridView1.Rows.Clear()
            'DataGridView1.Refresh()
        Else
            'invoice is not created 
        End If

        txt_cust_name.Text = ""
        txt_cust_no.Text = ""
        txt_cust_address.Text = ""
        txt_dis.Text = 0
        txt_grd_tot.Text = 0
        txt_imei.Text = ""
        txt_hsn.Text = ""
        txt_qty.Text = ""
        txt_round.Text = 0
        txt_totamt.Text = 0
        txt_unit_price.Text = ""
        txt_pname.Text = ""

    End Sub

    Private Sub load_invoice_data()

        Try

            Dim d As New Dao
            Dim dd As New Data.DataSet

            dd = d.loaddata("Select * from Sales_summary where Invoice_No = '" & txt_invoice.Text & "'")

            If dd.Tables(0).Rows.Count > 0 Then

                txt_id.Text = dd.Tables(0).Rows(0).Item("Sales_Id")
                txt_cust_name.Text = dd.Tables(0).Rows(0).Item("Customer_Name")
                txt_cust_no.Text = dd.Tables(0).Rows(0).Item("Customer_Mobile_no")
                txt_cust_address.Text = dd.Tables(0).Rows(0).Item("Customer_address")
                DateTimePicker1.Value = dd.Tables(0).Rows(0).Item("Bill_Date")
                txt_invoice.Text = dd.Tables(0).Rows(0).Item("Invoice_No")
                txt_dis.Text = dd.Tables(0).Rows(0).Item("Discount")
                txt_round.Text = dd.Tables(0).Rows(0).Item("Round_Off")
                txt_tot_gst.Text = dd.Tables(0).Rows(0).Item("Total_gst")
                txt_grd_tot.Text = dd.Tables(0).Rows(0).Item("Total_Amount")

            End If

            Dim ds As New Data.DataSet


            ds = d.loaddata("Select Sales_id,IMEI_No,Product_Name,Rate,Quantity,CGST,SGST,Taxable_amt,HSN_code from Sales_Detail where Invoice_No = '" & txt_invoice.Text & "'")




            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try

        'calculate totals
        Dim c As Integer = DataGridView1.Rows.Count - 1
        Dim tot As Double = 0
        Dim cgsttot As Double = 0
        Dim sgsttot As Double = 0
        Dim gtot As Double = 0
        While c >= 0

            cgsttot += Math.Round(((Val(DataGridView1.Rows(c).Cells("Quantity").Value) * Val(DataGridView1.Rows(c).Cells("Rate").Value)) * Val(DataGridView1.Rows(c).Cells("CGST").Value)) / 100, 2)

            sgsttot += Math.Round(((Val(DataGridView1.Rows(c).Cells("Quantity").Value) * Val(DataGridView1.Rows(c).Cells("Rate").Value)) * Val(DataGridView1.Rows(c).Cells("SGST").Value)) / 100, 2)

            gtot += Val(DataGridView1.Rows(c).Cells("Taxable_amt").Value)

            If txt_dis.Text = "" Then

                txt_dis.Text = 0
                txt_grd_tot.Text = gtot
            End If

            c -= 1
        End While

        txt_tot_cgst.Text = cgsttot
        txt_tot_sgst.Text = sgsttot
        txt_tot_gst.Text = cgsttot + sgsttot
        txt_grd_tot.Text = Math.Round(gtot + Val(txt_round.Text), 2)

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Btn_Save.Enabled = True

        Dim index As Integer

        index = e.RowIndex

        Dim selected As DataGridViewRow

        selected = DataGridView1.Rows(index)

        txt_id.Text = selected.Cells(0).Value.ToString()
        txt_imei.Text = selected.Cells(1).Value.ToString()
        txt_pname.Text = selected.Cells(2).Value.ToString()
        txt_unit_price.Text = selected.Cells(3).Value.ToString()
        txt_qty.Text = selected.Cells(4).Value.ToString()
        txt_cgst_per.Text = selected.Cells(5).Value.ToString()
        txt_sgst_per.Text = selected.Cells(6).Value.ToString()
        txt_totamt.Text = selected.Cells(7).Value.ToString()
        txt_hsn.Text = selected.Cells(8).Value.ToString()

        ' txt_amt.Text = Val(txt_qty.Text) * Val(txt_rate.Text)
        'txt_grd_tot.Text = Math.Round(Val(txt_grd_tot.Text))

        '  txt_round.Text = Math.Round(Val(txt_grd_tot.Text) - Val(txt_tot_amt.Text), 2)

    End Sub

    Private Sub Btn_add_list_Click(sender As Object, e As EventArgs) Handles Btn_add_list.Click

        If txt_cust_name.Text <> "" Then

            If txt_cust_no.Text <> "" Then

                If txt_cust_address.Text <> "" Then

                    If txt_imei.Text <> "" Then

                        If txt_pname.Text <> "" Then

                            If txt_hsn.Text <> "" Then

                                If txt_qty.Text <> "" Then

                                    If txt_unit_price.Text <> "" Then

                                        If txt_cgst_per.Text <> "" Then

                                            If txt_sgst_per.Text <> "" Then

                                                If txt_totamt.Text <> "" Then

                                                    If DataGridView1.Rows.Count < 1 Then


                                                        'Insert into Sales_Detailes

                                                        Dim d As New Dao

                                                        d.modifyData("Insert into Sales_Detail(Invoice_No,IMEI_No,Product_Name,Quantity,Rate,CGST,SGST,Taxable_amt,HSN_code) values('" & txt_invoice.Text & "','" & txt_imei.Text & "','" & txt_pname.Text & "','" & txt_qty.Text & "'," & txt_unit_price.Text & "," & txt_cgst_per.Text & "," & txt_sgst_per.Text & "," & txt_totamt.Text & "," & txt_hsn.Text & ")")

                                                        MessageBox.Show("Add Successfully", "Message")

                                                        load_invoice_data()

                                                        If DataGridView1.Rows.Count = 1 Then

                                                            'Insert into Sales_Summary

                                                            d.modifyData("Insert into Sales_Summary(Invoice_no,Bill_date,Customer_Name,Customer_Mobile_no,Customer_address,Discount,Round_off,Total_gst,Total_Amount) values('" & txt_invoice.Text & "','" & DateTimePicker1.Value.ToShortDateString() & "','" & txt_cust_name.Text & "','" & txt_cust_no.Text & "','" & txt_cust_address.Text & "'," & txt_dis.Text & "," & txt_round.Text & "," & txt_tot_gst.Text & "," & txt_grd_tot.Text & ")")
                                                            'delete from stock
                                                            Try

                                                                Dim da As New Dao

                                                                da.modifyData("Delete from Stock where IMEI_NUMBER ='" & txt_imei.Text & "'")

                                                                MessageBox.Show("Deleted From Stock", "Meassage")

                                                            Catch ex As Exception

                                                                MessageBox.Show(ex.Message)

                                                            End Try

                                                        Else


                                                            d.modifyData("update Sales_Summary set Total_gst=" & txt_tot_gst.Text & ",Total_Amount = " & txt_grd_tot.Text & ",Round_Off = " & txt_round.Text & ",Discount = " & txt_dis.Text & " where Invoice_No = '" & txt_invoice.Text & "'")

                                                        End If

                                                    End If
                                                Else

                                                        MessageBox.Show("Enter Valid Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                    End If


                                                Else

                                                MessageBox.Show("Enter Valid SGST", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            End If

                                        Else

                                            MessageBox.Show("Enter Valid CGST", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        End If

                                    Else

                                        MessageBox.Show("Enter Valid Unit Price", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    End If

                                Else

                                    MessageBox.Show("Enter Valid Quantity", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If

                            Else

                                MessageBox.Show("Enter HSN Code", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If

                        Else

                            MessageBox.Show("Enter Product Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                    Else

                        MessageBox.Show("Enter IMEI Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Else

                    MessageBox.Show("Enter Customer Address", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.Show("Enter Customer Number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Enter Customer Name", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Btn_search_Click(sender As Object, e As EventArgs) Handles Btn_search.Click


        Dim ino As String = InputBox("Enter Invoice No", "Invoice Search", "SCMS/", MessageBoxButtons.OKCancel)
        If ino <> "" And ino <> "0" Then
            txt_invoice.Text = ino
            load_invoice_data()
        End If

    End Sub

    Private Sub txt_cust_no_TextChanged(sender As Object, e As EventArgs) Handles txt_cust_no.TextChanged

        If sender.text <> "" And IsNumeric(sender.text) Then

            txt_cust_no.Text = txt_cust_no.Text

        Else
            sender.text = 0
        End If

    End Sub

    Private Sub txt_dis_TextChanged(sender As Object, e As EventArgs) Handles txt_dis.TextChanged

        If txt_dis.Text <> "" Then

            Dim discount As Double = Val(txt_dis.Text)

            discount = Val(txt_dis.Text) * 100 / 100

            Dim taxable As Double = Val(txt_txab_amt.Text)

            Dim grand As Double

            grand = taxable - discount

            txt_txab_amt.Text = grand

            Dim total_gst As Double = Val(txt_tot_gst.Text)

            txt_grd_tot.Text = Val(txt_txab_amt.Text) + Val(txt_tot_gst.Text)



        ElseIf txt_dis.Text = "" Then

            txt_txab_amt.Text = Val(txt_unit_price.Text)
            txt_grd_tot.Text = Val(txt_totamt.Text)

        End If


    End Sub

    Private Sub txt_grd_tot_TextChanged(sender As Object, e As EventArgs) Handles txt_grd_tot.TextChanged

        txt_word_amt.Text = NumberInWords(Val(txt_grd_tot.Text))

        TextBox1.Text = Math.Round(Val(txt_grd_tot.Text), 2)

        txt_round.Text = Val(txt_grd_tot.Text) - Val(TextBox1.Text)



    End Sub

    Private Sub Btn_print_Click(sender As Object, e As EventArgs) Handles Btn_print.Click

        Try
            IMEI = txt_imei.Text
            P_Name = txt_pname.Text
            Quanty = Val(txt_qty.Text)
            P_rate = txt_unit_price.Text
            P_cgst = txt_cgst_per.Text
            P_sgst = txt_sgst_per.Text
            P_taxamt = txt_txab_amt.Text
            P_words = txt_word_amt.Text
            Tax_amt = txt_totamt.Text


            If DataGridView1.Rows.Count > 1 Then

                MsgBox("Not Allowed")

            ElseIf DataGridView1.Rows.Count > 0 Then

                r_type = "Sales_bill_rpt"
                Dim d As New Dao
                Dim ds As New Data.DataSet

                ds = d.loaddata("select Invoice_no,Bill_date,Customer_Name,Customer_Mobile_no,Customer_address,Discount,Round_off,Total_gst,Total_Amount from Sales_Summary where Invoice_no = '" & txt_invoice.Text & "'")
                '  IMEI_No = txt_imei.Text

                dk = ds


                Dim d1 As New Purchase_Summary_view_rtp

                d1.MdiParent = Me.MdiParent

                d1.Show()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try






    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click


        Dim c As Integer = MessageBox.Show("Do you want to Save Invoice?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If c = 6 Then
            Try
                Dim d As New Dao
                'UPDATE TOTALS
                d.modifyData("update Sales_Summary set Round_off=" & txt_round.Text & ",Total_gst=" & txt_tot_gst.Text & ",Total_Amount=" & txt_grd_tot.Text & "where Invoice_no='" & txt_invoice.Text & "'")

                MessageBox.Show("Updated", "Message")
            Catch ex As Exception

            End Try


        End If


    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        Me.Close()
    End Sub

    Private Sub Btn_delete_Click(sender As Object, e As EventArgs) Handles Btn_delete.Click


        Dim d As Integer = MessageBox.Show("Do you want to delete " & DataGridView1.Item("IMEI_No", DataGridView1.CurrentCell.RowIndex).Value & "?", "Delete IMEI Number", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        txt_grd_tot.Text = Val(txt_grd_tot.Text) - Val(txt_txab_amt.Text)

        If d = 6 Then

            Dim id As Integer = DataGridView1.Item("Sales_Id", DataGridView1.CurrentCell.RowIndex).Value
            Dim dp As New Dao
            dp.modifyData("delete from Sales_detail where Sales_Id=" & txt_id.Text)

            load_invoice_data()

            If DataGridView1.Rows.Count = 0 Then
                dp.modifyData("delete from Sales_summary where Invoice_no='" & txt_invoice.Text & "'")
            Else
                'UPDATE TOTALS
                dp.modifyData("update Sales_summary set  Round_Off = " & txt_round.Text & ",Total_gst = " & txt_tot_gst.Text & ",Total_Amount = " & txt_grd_tot.Text & " where Invoice_No ='" & txt_invoice.Text & "'")
            End If



            Btn_delete.Enabled = False

        End If



    End Sub
End Class