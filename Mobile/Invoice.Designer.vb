<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Invoice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invoice))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cust_no = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cust_address = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_invoice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_imei = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_pname = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_hsn = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_unit_price = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Btn_new = New System.Windows.Forms.Button()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Btn_search = New System.Windows.Forms.Button()
        Me.Btn_print = New System.Windows.Forms.Button()
        Me.Btn_delete = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_cgst_per = New System.Windows.Forms.TextBox()
        Me.txt_txab_amt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_dis = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_grd_tot = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_tot_cgst = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_tot_sgst = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Sales_Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMEI_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HSN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CGST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SGST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Taxable_amt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_totamt = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_sgst_per = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_cust_name = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_tot_gst = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_word_amt = New System.Windows.Forms.TextBox()
        Me.txt_round = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Btn_add_list = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(642, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 59)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Invoice (Bill)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1342, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 26)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Invoice No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1002, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 26)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Purchase Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(62, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 26)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Customer Name"
        '
        'txt_cust_no
        '
        Me.txt_cust_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cust_no.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cust_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cust_no.Location = New System.Drawing.Point(284, 102)
        Me.txt_cust_no.Name = "txt_cust_no"
        Me.txt_cust_no.Size = New System.Drawing.Size(300, 35)
        Me.txt_cust_no.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(326, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(211, 26)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Customer Mobile No"
        '
        'txt_cust_address
        '
        Me.txt_cust_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cust_address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cust_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cust_address.Location = New System.Drawing.Point(608, 102)
        Me.txt_cust_address.Multiline = True
        Me.txt_cust_address.Name = "txt_cust_address"
        Me.txt_cust_address.Size = New System.Drawing.Size(314, 34)
        Me.txt_cust_address.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(147, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 26)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "IMEI No"
        '
        'txt_invoice
        '
        Me.txt_invoice.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_invoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_invoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_invoice.Location = New System.Drawing.Point(1274, 102)
        Me.txt_invoice.Name = "txt_invoice"
        Me.txt_invoice.ReadOnly = True
        Me.txt_invoice.Size = New System.Drawing.Size(252, 35)
        Me.txt_invoice.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(483, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 26)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Product Name"
        '
        'txt_imei
        '
        Me.txt_imei.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_imei.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_imei.Location = New System.Drawing.Point(22, 106)
        Me.txt_imei.Name = "txt_imei"
        Me.txt_imei.Size = New System.Drawing.Size(326, 35)
        Me.txt_imei.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(735, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 26)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "HSN Code"
        '
        'txt_pname
        '
        Me.txt_pname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pname.Location = New System.Drawing.Point(398, 108)
        Me.txt_pname.Name = "txt_pname"
        Me.txt_pname.Size = New System.Drawing.Size(312, 35)
        Me.txt_pname.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(905, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 26)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Qty"
        '
        'txt_hsn
        '
        Me.txt_hsn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hsn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hsn.Location = New System.Drawing.Point(727, 106)
        Me.txt_hsn.Name = "txt_hsn"
        Me.txt_hsn.Size = New System.Drawing.Size(131, 35)
        Me.txt_hsn.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1052, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 26)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Rate"
        '
        'txt_qty
        '
        Me.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.Location = New System.Drawing.Point(877, 106)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(108, 35)
        Me.txt_qty.TabIndex = 13
        Me.txt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1187, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 26)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "CGST(%)"
        '
        'txt_unit_price
        '
        Me.txt_unit_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_unit_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_unit_price.Location = New System.Drawing.Point(1012, 106)
        Me.txt_unit_price.Name = "txt_unit_price"
        Me.txt_unit_price.Size = New System.Drawing.Size(149, 35)
        Me.txt_unit_price.TabIndex = 14
        Me.txt_unit_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(951, 102)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(292, 35)
        Me.DateTimePicker1.TabIndex = 8
        '
        'Btn_new
        '
        Me.Btn_new.BackColor = System.Drawing.Color.White
        Me.Btn_new.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_new.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_new.Location = New System.Drawing.Point(1459, 618)
        Me.Btn_new.Name = "Btn_new"
        Me.Btn_new.Size = New System.Drawing.Size(208, 54)
        Me.Btn_new.TabIndex = 19
        Me.Btn_new.Text = "New"
        Me.Btn_new.UseVisualStyleBackColor = False
        '
        'Btn_Save
        '
        Me.Btn_Save.BackColor = System.Drawing.Color.White
        Me.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Save.Location = New System.Drawing.Point(1459, 688)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(208, 54)
        Me.Btn_Save.TabIndex = 20
        Me.Btn_Save.Text = "Save"
        Me.Btn_Save.UseVisualStyleBackColor = False
        '
        'Btn_search
        '
        Me.Btn_search.BackColor = System.Drawing.Color.White
        Me.Btn_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_search.Location = New System.Drawing.Point(1459, 761)
        Me.Btn_search.Name = "Btn_search"
        Me.Btn_search.Size = New System.Drawing.Size(208, 54)
        Me.Btn_search.TabIndex = 21
        Me.Btn_search.Text = "Search"
        Me.Btn_search.UseVisualStyleBackColor = False
        '
        'Btn_print
        '
        Me.Btn_print.BackColor = System.Drawing.Color.White
        Me.Btn_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_print.Location = New System.Drawing.Point(1459, 831)
        Me.Btn_print.Name = "Btn_print"
        Me.Btn_print.Size = New System.Drawing.Size(208, 54)
        Me.Btn_print.TabIndex = 22
        Me.Btn_print.Text = "Print"
        Me.Btn_print.UseVisualStyleBackColor = False
        '
        'Btn_delete
        '
        Me.Btn_delete.BackColor = System.Drawing.Color.White
        Me.Btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_delete.Location = New System.Drawing.Point(1459, 902)
        Me.Btn_delete.Name = "Btn_delete"
        Me.Btn_delete.Size = New System.Drawing.Size(208, 54)
        Me.Btn_delete.TabIndex = 23
        Me.Btn_delete.Text = "Delete"
        Me.Btn_delete.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1010, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Taxable Amount"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(254, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(141, 29)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "CGST Total"
        '
        'txt_cgst_per
        '
        Me.txt_cgst_per.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_cgst_per.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cgst_per.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cgst_per.Location = New System.Drawing.Point(1191, 106)
        Me.txt_cgst_per.Name = "txt_cgst_per"
        Me.txt_cgst_per.ReadOnly = True
        Me.txt_cgst_per.Size = New System.Drawing.Size(118, 35)
        Me.txt_cgst_per.TabIndex = 15
        Me.txt_cgst_per.Text = "9"
        Me.txt_cgst_per.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_txab_amt
        '
        Me.txt_txab_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_txab_amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_txab_amt.Location = New System.Drawing.Point(1202, 17)
        Me.txt_txab_amt.Name = "txt_txab_amt"
        Me.txt_txab_amt.Size = New System.Drawing.Size(180, 35)
        Me.txt_txab_amt.TabIndex = 22
        Me.txt_txab_amt.Text = "0"
        Me.txt_txab_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1022, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 29)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Discount (%)"
        '
        'txt_dis
        '
        Me.txt_dis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_dis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dis.Location = New System.Drawing.Point(1202, 63)
        Me.txt_dis.Name = "txt_dis"
        Me.txt_dis.Size = New System.Drawing.Size(180, 35)
        Me.txt_dis.TabIndex = 23
        Me.txt_dis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(632, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(124, 29)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Total GST"
        '
        'txt_grd_tot
        '
        Me.txt_grd_tot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_grd_tot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_grd_tot.Location = New System.Drawing.Point(1202, 111)
        Me.txt_grd_tot.Name = "txt_grd_tot"
        Me.txt_grd_tot.Size = New System.Drawing.Size(180, 35)
        Me.txt_grd_tot.TabIndex = 24
        Me.txt_grd_tot.Text = "0"
        Me.txt_grd_tot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(640, 112)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(121, 29)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Round Off"
        '
        'txt_tot_cgst
        '
        Me.txt_tot_cgst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tot_cgst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tot_cgst.Location = New System.Drawing.Point(418, 18)
        Me.txt_tot_cgst.Name = "txt_tot_cgst"
        Me.txt_tot_cgst.Size = New System.Drawing.Size(188, 35)
        Me.txt_tot_cgst.TabIndex = 18
        Me.txt_tot_cgst.Text = "0"
        Me.txt_tot_cgst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(1022, 112)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(140, 29)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Grand Total"
        '
        'txt_tot_sgst
        '
        Me.txt_tot_sgst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tot_sgst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tot_sgst.Location = New System.Drawing.Point(790, 17)
        Me.txt_tot_sgst.Name = "txt_tot_sgst"
        Me.txt_tot_sgst.Size = New System.Drawing.Size(188, 35)
        Me.txt_tot_sgst.TabIndex = 19
        Me.txt_tot_sgst.Text = "0"
        Me.txt_tot_sgst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sales_Id, Me.IMEI_No, Me.HSN, Me.Product_Name, Me.Quantity, Me.Rate, Me.CGST, Me.SGST, Me.Taxable_amt})
        Me.DataGridView1.Location = New System.Drawing.Point(34, 532)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1412, 314)
        Me.DataGridView1.TabIndex = 20
        '
        'Sales_Id
        '
        Me.Sales_Id.DataPropertyName = "Sales_Id"
        Me.Sales_Id.HeaderText = "Sales Id"
        Me.Sales_Id.Name = "Sales_Id"
        Me.Sales_Id.ReadOnly = True
        Me.Sales_Id.Visible = False
        '
        'IMEI_No
        '
        Me.IMEI_No.DataPropertyName = "IMEI_No"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.IMEI_No.DefaultCellStyle = DataGridViewCellStyle2
        Me.IMEI_No.HeaderText = "IMEI Number"
        Me.IMEI_No.Name = "IMEI_No"
        Me.IMEI_No.ReadOnly = True
        '
        'HSN
        '
        Me.HSN.DataPropertyName = "HSN_code"
        Me.HSN.HeaderText = "HSN"
        Me.HSN.Name = "HSN"
        Me.HSN.ReadOnly = True
        Me.HSN.Visible = False
        '
        'Product_Name
        '
        Me.Product_Name.DataPropertyName = "Product_Name"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.Product_Name.DefaultCellStyle = DataGridViewCellStyle3
        Me.Product_Name.HeaderText = "Product Name"
        Me.Product_Name.Name = "Product_Name"
        Me.Product_Name.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.DataPropertyName = "Quantity"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.Quantity.DefaultCellStyle = DataGridViewCellStyle4
        Me.Quantity.HeaderText = "Qty"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'Rate
        '
        Me.Rate.DataPropertyName = "Rate"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.Rate.DefaultCellStyle = DataGridViewCellStyle5
        Me.Rate.HeaderText = "Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.ReadOnly = True
        '
        'CGST
        '
        Me.CGST.DataPropertyName = "CGST"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.CGST.DefaultCellStyle = DataGridViewCellStyle6
        Me.CGST.HeaderText = "CGST"
        Me.CGST.Name = "CGST"
        Me.CGST.ReadOnly = True
        '
        'SGST
        '
        Me.SGST.DataPropertyName = "SGST"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.SGST.DefaultCellStyle = DataGridViewCellStyle7
        Me.SGST.HeaderText = "SGST"
        Me.SGST.Name = "SGST"
        Me.SGST.ReadOnly = True
        '
        'Taxable_amt
        '
        Me.Taxable_amt.DataPropertyName = "Taxable_amt"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.Taxable_amt.DefaultCellStyle = DataGridViewCellStyle8
        Me.Taxable_amt.HeaderText = "Total Amount"
        Me.Taxable_amt.Name = "Taxable_amt"
        Me.Taxable_amt.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_totamt)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txt_sgst_per)
        Me.GroupBox2.Controls.Add(Me.txt_unit_price)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txt_qty)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txt_hsn)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_pname)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_cgst_per)
        Me.GroupBox2.Controls.Add(Me.txt_imei)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(31, 351)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1703, 175)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add Product Details"
        '
        'txt_totamt
        '
        Me.txt_totamt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_totamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totamt.Location = New System.Drawing.Point(1480, 105)
        Me.txt_totamt.Name = "txt_totamt"
        Me.txt_totamt.Size = New System.Drawing.Size(168, 35)
        Me.txt_totamt.TabIndex = 17
        Me.txt_totamt.Text = "0"
        Me.txt_totamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(1507, 55)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(141, 26)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Total Amount"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(1345, 55)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(105, 26)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "SGST(%)"
        '
        'txt_sgst_per
        '
        Me.txt_sgst_per.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_sgst_per.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sgst_per.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sgst_per.Location = New System.Drawing.Point(1333, 105)
        Me.txt_sgst_per.Name = "txt_sgst_per"
        Me.txt_sgst_per.ReadOnly = True
        Me.txt_sgst_per.Size = New System.Drawing.Size(118, 35)
        Me.txt_sgst_per.TabIndex = 16
        Me.txt_sgst_per.Text = "9"
        Me.txt_sgst_per.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(46, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(36, 28)
        Me.ComboBox1.TabIndex = 27
        Me.ComboBox1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txt_cust_name)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txt_cust_address)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_cust_no)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_invoice)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(34, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1633, 183)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Invoice Details"
        '
        'txt_cust_name
        '
        Me.txt_cust_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cust_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_cust_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cust_name.Location = New System.Drawing.Point(28, 102)
        Me.txt_cust_name.Name = "txt_cust_name"
        Me.txt_cust_name.Size = New System.Drawing.Size(236, 35)
        Me.txt_cust_name.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(662, 54)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(193, 26)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Customer Address"
        '
        'txt_tot_gst
        '
        Me.txt_tot_gst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tot_gst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tot_gst.Location = New System.Drawing.Point(790, 63)
        Me.txt_tot_gst.Name = "txt_tot_gst"
        Me.txt_tot_gst.Size = New System.Drawing.Size(188, 35)
        Me.txt_tot_gst.TabIndex = 20
        Me.txt_tot_gst.Text = "0"
        Me.txt_tot_gst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.txt_word_amt)
        Me.Panel1.Controls.Add(Me.txt_tot_gst)
        Me.Panel1.Controls.Add(Me.txt_round)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.txt_txab_amt)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txt_tot_sgst)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.txt_grd_tot)
        Me.Panel1.Controls.Add(Me.txt_tot_cgst)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txt_dis)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Location = New System.Drawing.Point(34, 871)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1412, 160)
        Me.Panel1.TabIndex = 19
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(16, 45)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(183, 29)
        Me.Label22.TabIndex = 34
        Me.Label22.Text = "Amount In Word"
        '
        'txt_word_amt
        '
        Me.txt_word_amt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_word_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_word_amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_word_amt.Location = New System.Drawing.Point(22, 89)
        Me.txt_word_amt.Multiline = True
        Me.txt_word_amt.Name = "txt_word_amt"
        Me.txt_word_amt.ReadOnly = True
        Me.txt_word_amt.Size = New System.Drawing.Size(562, 56)
        Me.txt_word_amt.TabIndex = 33
        '
        'txt_round
        '
        Me.txt_round.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_round.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_round.Location = New System.Drawing.Point(790, 109)
        Me.txt_round.Name = "txt_round"
        Me.txt_round.Size = New System.Drawing.Size(188, 35)
        Me.txt_round.TabIndex = 21
        Me.txt_round.Text = "0"
        Me.txt_round.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(628, 18)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(140, 29)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "SGST Total"
        '
        'Btn_add_list
        '
        Me.Btn_add_list.BackColor = System.Drawing.Color.White
        Me.Btn_add_list.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_add_list.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_add_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_add_list.Location = New System.Drawing.Point(1459, 547)
        Me.Btn_add_list.Name = "Btn_add_list"
        Me.Btn_add_list.Size = New System.Drawing.Size(208, 54)
        Me.Btn_add_list.TabIndex = 25
        Me.Btn_add_list.Text = "Add to List"
        Me.Btn_add_list.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button7.Location = New System.Drawing.Point(1008, -40)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(122, 40)
        Me.Button7.TabIndex = 25
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(-22, -22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1414, 43)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(208, 54)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Add to List"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1016, 1038)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 35)
        Me.TextBox1.TabIndex = 35
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox1.Visible = False
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label23.Image = CType(resources.GetObject("Label23.Image"), System.Drawing.Image)
        Me.Label23.Location = New System.Drawing.Point(1754, 68)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 48)
        Me.Label23.TabIndex = 61
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(353, 335)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 26)
        Me.txt_id.TabIndex = 62
        Me.txt_id.Visible = False
        '
        'Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(2, 3)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.CancelButton = Me.Button7
        Me.ClientSize = New System.Drawing.Size(1875, 1106)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Btn_add_list)
        Me.Controls.Add(Me.Btn_delete)
        Me.Controls.Add(Me.Btn_print)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btn_search)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_new)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Invoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cust_no As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_cust_address As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_qty As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_hsn As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_pname As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_imei As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_invoice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_unit_price As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Btn_new As Button
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Btn_search As Button
    Friend WithEvents Btn_print As Button
    Friend WithEvents Btn_delete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_cgst_per As TextBox
    Friend WithEvents txt_txab_amt As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_dis As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_grd_tot As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_tot_cgst As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_tot_sgst As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_tot_gst As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_add_list As Button
    Friend WithEvents txt_totamt As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_sgst_per As TextBox
    Friend WithEvents txt_round As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txt_cust_name As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txt_word_amt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Sales_Id As DataGridViewTextBoxColumn
    Friend WithEvents IMEI_No As DataGridViewTextBoxColumn
    Friend WithEvents HSN As DataGridViewTextBoxColumn
    Friend WithEvents Product_Name As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents CGST As DataGridViewTextBoxColumn
    Friend WithEvents SGST As DataGridViewTextBoxColumn
    Friend WithEvents Taxable_amt As DataGridViewTextBoxColumn
End Class
