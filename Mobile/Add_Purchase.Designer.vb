<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_Purchase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Purchase))
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_supname = New System.Windows.Forms.ComboBox()
        Me.txt_gst_no = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.txt_invoice = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cmb_pname = New System.Windows.Forms.ComboBox()
        Me.txt_tot_amt = New System.Windows.Forms.TextBox()
        Me.txt_amt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_sgst = New System.Windows.Forms.TextBox()
        Me.txt_cgst = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_rate = New System.Windows.Forms.TextBox()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_hsn = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_sgst_amtper = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_cgst_amtper = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_pgst_tot = New System.Windows.Forms.TextBox()
        Me.txt_tot_gst = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_sgst_amt = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_cgst_amt = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_round = New System.Windows.Forms.TextBox()
        Me.txt_grd_tot = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Purchase_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HSN_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P_CGST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P_SGST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_add_list = New System.Windows.Forms.Button()
        Me.Btn_new = New System.Windows.Forms.Button()
        Me.Btn_delete = New System.Windows.Forms.Button()
        Me.Btn_search = New System.Windows.Forms.Button()
        Me.Btn_save = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1736, 88)
        Me.Panel1.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(1508, 17)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(54, 35)
        Me.TextBox3.TabIndex = 29
        Me.TextBox3.Text = "1"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox3.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(664, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Purchase Entry"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label22.Image = CType(resources.GetObject("Label22.Image"), System.Drawing.Image)
        Me.Label22.Location = New System.Drawing.Point(1568, 9)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 40)
        Me.Label22.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ledger Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 26)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Ledger GST/PAN No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(693, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 26)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Brand"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1244, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 26)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Bill Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(657, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(211, 26)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Due Date (Payment)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1262, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 26)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Invoice"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1336, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 26)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Amount"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 26)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Product Name"
        '
        'cmb_supname
        '
        Me.cmb_supname.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmb_supname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_supname.FormattingEnabled = True
        Me.cmb_supname.Location = New System.Drawing.Point(286, 43)
        Me.cmb_supname.Name = "cmb_supname"
        Me.cmb_supname.Size = New System.Drawing.Size(307, 37)
        Me.cmb_supname.TabIndex = 8
        '
        'txt_gst_no
        '
        Me.txt_gst_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_gst_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_gst_no.Location = New System.Drawing.Point(286, 114)
        Me.txt_gst_no.Name = "txt_gst_no"
        Me.txt_gst_no.Size = New System.Drawing.Size(306, 35)
        Me.txt_gst_no.TabIndex = 9
        '
        'txt_brand
        '
        Me.txt_brand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.Location = New System.Drawing.Point(900, 37)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(306, 35)
        Me.txt_brand.TabIndex = 10
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(900, 114)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(307, 35)
        Me.DateTimePicker2.TabIndex = 8
        '
        'txt_invoice
        '
        Me.txt_invoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_invoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_invoice.Location = New System.Drawing.Point(1358, 114)
        Me.txt_invoice.Name = "txt_invoice"
        Me.txt_invoice.Size = New System.Drawing.Size(278, 35)
        Me.txt_invoice.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.cmb_pname)
        Me.Panel3.Controls.Add(Me.txt_tot_amt)
        Me.Panel3.Controls.Add(Me.txt_amt)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.txt_sgst)
        Me.Panel3.Controls.Add(Me.txt_cgst)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.txt_rate)
        Me.Panel3.Controls.Add(Me.txt_qty)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.txt_hsn)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Location = New System.Drawing.Point(12, 317)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1670, 210)
        Me.Panel3.TabIndex = 13
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(282, 165)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 28
        Me.ComboBox1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(464, 157)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(64, 35)
        Me.TextBox1.TabIndex = 27
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox1.Visible = False
        '
        'cmb_pname
        '
        Me.cmb_pname.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmb_pname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_pname.FormattingEnabled = True
        Me.cmb_pname.Location = New System.Drawing.Point(219, 35)
        Me.cmb_pname.Name = "cmb_pname"
        Me.cmb_pname.Size = New System.Drawing.Size(307, 37)
        Me.cmb_pname.TabIndex = 13
        '
        'txt_tot_amt
        '
        Me.txt_tot_amt.BackColor = System.Drawing.SystemColors.HotTrack
        Me.txt_tot_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tot_amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tot_amt.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_tot_amt.Location = New System.Drawing.Point(1470, 102)
        Me.txt_tot_amt.Name = "txt_tot_amt"
        Me.txt_tot_amt.Size = New System.Drawing.Size(174, 44)
        Me.txt_tot_amt.TabIndex = 26
        Me.txt_tot_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_amt
        '
        Me.txt_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amt.Location = New System.Drawing.Point(1470, 35)
        Me.txt_amt.Name = "txt_amt"
        Me.txt_amt.Size = New System.Drawing.Size(174, 35)
        Me.txt_amt.TabIndex = 25
        Me.txt_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(1306, 115)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(141, 26)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Total Amount"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(534, 115)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(194, 78)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Rate (without tax)"
        '
        'txt_sgst
        '
        Me.txt_sgst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sgst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sgst.Location = New System.Drawing.Point(1095, 111)
        Me.txt_sgst.Name = "txt_sgst"
        Me.txt_sgst.Size = New System.Drawing.Size(184, 35)
        Me.txt_sgst.TabIndex = 22
        Me.txt_sgst.Text = "9"
        Me.txt_sgst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_cgst
        '
        Me.txt_cgst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cgst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cgst.Location = New System.Drawing.Point(1095, 35)
        Me.txt_cgst.Name = "txt_cgst"
        Me.txt_cgst.Size = New System.Drawing.Size(184, 35)
        Me.txt_cgst.TabIndex = 21
        Me.txt_cgst.Text = "9"
        Me.txt_cgst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(962, 115)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 26)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "SGST(%)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(962, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 26)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "CGST(%)"
        '
        'txt_rate
        '
        Me.txt_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rate.Location = New System.Drawing.Point(732, 111)
        Me.txt_rate.Name = "txt_rate"
        Me.txt_rate.Size = New System.Drawing.Size(184, 35)
        Me.txt_rate.TabIndex = 18
        Me.txt_rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_qty
        '
        Me.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.Location = New System.Drawing.Point(732, 35)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(184, 35)
        Me.txt_qty.TabIndex = 17
        Me.txt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(592, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 26)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Qty"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(64, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 26)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "HSN"
        '
        'txt_hsn
        '
        Me.txt_hsn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hsn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hsn.Location = New System.Drawing.Point(219, 111)
        Me.txt_hsn.Name = "txt_hsn"
        Me.txt_hsn.Size = New System.Drawing.Size(306, 35)
        Me.txt_hsn.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.txt_invoice)
        Me.Panel2.Controls.Add(Me.DateTimePicker2)
        Me.Panel2.Controls.Add(Me.txt_brand)
        Me.Panel2.Controls.Add(Me.txt_gst_no)
        Me.Panel2.Controls.Add(Me.cmb_supname)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(12, 95)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1670, 210)
        Me.Panel2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(1358, 37)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(278, 35)
        Me.DateTimePicker1.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txt_sgst_amtper)
        Me.Panel4.Controls.Add(Me.Label23)
        Me.Panel4.Controls.Add(Me.txt_cgst_amtper)
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.txt_pgst_tot)
        Me.Panel4.Controls.Add(Me.txt_tot_gst)
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Controls.Add(Me.txt_sgst_amt)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.txt_cgst_amt)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.txt_round)
        Me.Panel4.Controls.Add(Me.txt_grd_tot)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Location = New System.Drawing.Point(12, 832)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1450, 153)
        Me.Panel4.TabIndex = 27
        '
        'txt_sgst_amtper
        '
        Me.txt_sgst_amtper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sgst_amtper.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sgst_amtper.Location = New System.Drawing.Point(282, 54)
        Me.txt_sgst_amtper.Name = "txt_sgst_amtper"
        Me.txt_sgst_amtper.Size = New System.Drawing.Size(184, 35)
        Me.txt_sgst_amtper.TabIndex = 44
        Me.txt_sgst_amtper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(34, 63)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(200, 26)
        Me.Label23.TabIndex = 43
        Me.Label23.Text = "SGST (per product)"
        '
        'txt_cgst_amtper
        '
        Me.txt_cgst_amtper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cgst_amtper.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cgst_amtper.Location = New System.Drawing.Point(282, 12)
        Me.txt_cgst_amtper.Name = "txt_cgst_amtper"
        Me.txt_cgst_amtper.Size = New System.Drawing.Size(184, 35)
        Me.txt_cgst_amtper.TabIndex = 42
        Me.txt_cgst_amtper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(33, 15)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(201, 26)
        Me.Label24.TabIndex = 41
        Me.Label24.Text = "CGST (per product)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(22, 103)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(238, 26)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Total GST (per product)"
        '
        'txt_pgst_tot
        '
        Me.txt_pgst_tot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pgst_tot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pgst_tot.Location = New System.Drawing.Point(282, 98)
        Me.txt_pgst_tot.Name = "txt_pgst_tot"
        Me.txt_pgst_tot.Size = New System.Drawing.Size(184, 35)
        Me.txt_pgst_tot.TabIndex = 39
        Me.txt_pgst_tot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_tot_gst
        '
        Me.txt_tot_gst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tot_gst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tot_gst.Location = New System.Drawing.Point(698, 106)
        Me.txt_tot_gst.Name = "txt_tot_gst"
        Me.txt_tot_gst.Size = New System.Drawing.Size(184, 35)
        Me.txt_tot_gst.TabIndex = 38
        Me.txt_tot_gst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(560, 109)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(109, 26)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "Total GST"
        '
        'txt_sgst_amt
        '
        Me.txt_sgst_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sgst_amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sgst_amt.Location = New System.Drawing.Point(698, 58)
        Me.txt_sgst_amt.Name = "txt_sgst_amt"
        Me.txt_sgst_amt.Size = New System.Drawing.Size(184, 35)
        Me.txt_sgst_amt.TabIndex = 36
        Me.txt_sgst_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(560, 58)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(116, 26)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "Add SGST"
        '
        'txt_cgst_amt
        '
        Me.txt_cgst_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cgst_amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cgst_amt.Location = New System.Drawing.Point(698, 12)
        Me.txt_cgst_amt.Name = "txt_cgst_amt"
        Me.txt_cgst_amt.Size = New System.Drawing.Size(184, 35)
        Me.txt_cgst_amt.TabIndex = 33
        Me.txt_cgst_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(560, 12)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(117, 26)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Add CGST"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(1040, 63)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(125, 26)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Grand Total"
        '
        'txt_round
        '
        Me.txt_round.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_round.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_round.Location = New System.Drawing.Point(1202, 8)
        Me.txt_round.Name = "txt_round"
        Me.txt_round.Size = New System.Drawing.Size(184, 35)
        Me.txt_round.TabIndex = 30
        Me.txt_round.Text = "0"
        Me.txt_round.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_grd_tot
        '
        Me.txt_grd_tot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_grd_tot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_grd_tot.Location = New System.Drawing.Point(1202, 54)
        Me.txt_grd_tot.Name = "txt_grd_tot"
        Me.txt_grd_tot.Size = New System.Drawing.Size(184, 35)
        Me.txt_grd_tot.TabIndex = 29
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(1040, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 26)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Round off"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Purchase_id, Me.Product_Name, Me.HSN_Code, Me.Quantity, Me.Rate, Me.P_CGST, Me.P_SGST, Me.P_Total})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 531)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1450, 295)
        Me.DataGridView1.TabIndex = 28
        '
        'Purchase_id
        '
        Me.Purchase_id.DataPropertyName = "Purchase_id"
        Me.Purchase_id.HeaderText = "ID"
        Me.Purchase_id.Name = "Purchase_id"
        Me.Purchase_id.ReadOnly = True
        Me.Purchase_id.Visible = False
        '
        'Product_Name
        '
        Me.Product_Name.DataPropertyName = "Product_Name"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black
        Me.Product_Name.DefaultCellStyle = DataGridViewCellStyle18
        Me.Product_Name.HeaderText = "Product Name"
        Me.Product_Name.Name = "Product_Name"
        Me.Product_Name.ReadOnly = True
        '
        'HSN_Code
        '
        Me.HSN_Code.DataPropertyName = "HSN_Code"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black
        Me.HSN_Code.DefaultCellStyle = DataGridViewCellStyle19
        Me.HSN_Code.HeaderText = "HSN Code"
        Me.HSN_Code.Name = "HSN_Code"
        Me.HSN_Code.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.DataPropertyName = "Quantity"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black
        Me.Quantity.DefaultCellStyle = DataGridViewCellStyle20
        Me.Quantity.HeaderText = "Qty"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'Rate
        '
        Me.Rate.DataPropertyName = "Rate"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black
        Me.Rate.DefaultCellStyle = DataGridViewCellStyle21
        Me.Rate.HeaderText = "Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.ReadOnly = True
        '
        'P_CGST
        '
        Me.P_CGST.DataPropertyName = "P_CGST"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black
        Me.P_CGST.DefaultCellStyle = DataGridViewCellStyle22
        Me.P_CGST.HeaderText = "CGST"
        Me.P_CGST.Name = "P_CGST"
        Me.P_CGST.ReadOnly = True
        '
        'P_SGST
        '
        Me.P_SGST.DataPropertyName = "P_SGST"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black
        Me.P_SGST.DefaultCellStyle = DataGridViewCellStyle23
        Me.P_SGST.HeaderText = "SGST"
        Me.P_SGST.Name = "P_SGST"
        Me.P_SGST.ReadOnly = True
        '
        'P_Total
        '
        Me.P_Total.DataPropertyName = "P_Total"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black
        Me.P_Total.DefaultCellStyle = DataGridViewCellStyle24
        Me.P_Total.HeaderText = "Total"
        Me.P_Total.Name = "P_Total"
        Me.P_Total.ReadOnly = True
        '
        'Btn_add_list
        '
        Me.Btn_add_list.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_add_list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_add_list.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_add_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_add_list.Location = New System.Drawing.Point(1483, 562)
        Me.Btn_add_list.Name = "Btn_add_list"
        Me.Btn_add_list.Size = New System.Drawing.Size(189, 56)
        Me.Btn_add_list.TabIndex = 0
        Me.Btn_add_list.Text = "Add to List"
        Me.Btn_add_list.UseVisualStyleBackColor = False
        '
        'Btn_new
        '
        Me.Btn_new.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_new.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_new.Location = New System.Drawing.Point(1483, 644)
        Me.Btn_new.Name = "Btn_new"
        Me.Btn_new.Size = New System.Drawing.Size(189, 60)
        Me.Btn_new.TabIndex = 29
        Me.Btn_new.Text = "New"
        Me.Btn_new.UseVisualStyleBackColor = False
        '
        'Btn_delete
        '
        Me.Btn_delete.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_delete.Enabled = False
        Me.Btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_delete.Location = New System.Drawing.Point(1483, 899)
        Me.Btn_delete.Name = "Btn_delete"
        Me.Btn_delete.Size = New System.Drawing.Size(193, 64)
        Me.Btn_delete.TabIndex = 30
        Me.Btn_delete.Text = "Delete"
        Me.Btn_delete.UseVisualStyleBackColor = False
        '
        'Btn_search
        '
        Me.Btn_search.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_search.Location = New System.Drawing.Point(1483, 822)
        Me.Btn_search.Name = "Btn_search"
        Me.Btn_search.Size = New System.Drawing.Size(193, 55)
        Me.Btn_search.TabIndex = 31
        Me.Btn_search.Text = "Search"
        Me.Btn_search.UseVisualStyleBackColor = False
        '
        'Btn_save
        '
        Me.Btn_save.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_save.Location = New System.Drawing.Point(1483, 731)
        Me.Btn_save.Name = "Btn_save"
        Me.Btn_save.Size = New System.Drawing.Size(189, 57)
        Me.Btn_save.TabIndex = 32
        Me.Btn_save.Text = "Save"
        Me.Btn_save.UseVisualStyleBackColor = False
        '
        'Add_Purchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1832, 1035)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_save)
        Me.Controls.Add(Me.Btn_add_list)
        Me.Controls.Add(Me.Btn_search)
        Me.Controls.Add(Me.Btn_delete)
        Me.Controls.Add(Me.Btn_new)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Add_Purchase"
        Me.Text = "Add_Purchase"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_invoice As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents txt_gst_no As TextBox
    Friend WithEvents cmb_supname As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_qty As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_hsn As TextBox
    Friend WithEvents txt_sgst As TextBox
    Friend WithEvents txt_cgst As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_rate As TextBox
    Friend WithEvents txt_tot_amt As TextBox
    Friend WithEvents txt_amt As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Btn_add_list As Button
    Friend WithEvents Btn_new As Button
    Friend WithEvents Btn_delete As Button
    Friend WithEvents Btn_search As Button
    Friend WithEvents Btn_save As Button
    Friend WithEvents txt_cgst_amt As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_round As TextBox
    Friend WithEvents txt_grd_tot As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_tot_gst As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txt_sgst_amt As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cmb_pname As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label22 As Label
    Friend WithEvents txt_pgst_tot As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_sgst_amtper As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_cgst_amtper As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Purchase_id As DataGridViewTextBoxColumn
    Friend WithEvents Product_Name As DataGridViewTextBoxColumn
    Friend WithEvents HSN_Code As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents P_CGST As DataGridViewTextBoxColumn
    Friend WithEvents P_SGST As DataGridViewTextBoxColumn
    Friend WithEvents P_Total As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox3 As TextBox
End Class
