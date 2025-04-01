<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Customer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Customer))
        Me.btn_clr = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Customer_DataGridView = New System.Windows.Forms.DataGridView()
        Me.Customer_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_add = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.txt_Cno = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.Customer_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_clr
        '
        Me.btn_clr.BackColor = System.Drawing.Color.Transparent
        Me.btn_clr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clr.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_clr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clr.Location = New System.Drawing.Point(26, 28)
        Me.btn_clr.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_clr.Name = "btn_clr"
        Me.btn_clr.Size = New System.Drawing.Size(212, 55)
        Me.btn_clr.TabIndex = 57
        Me.btn_clr.Text = "Clear"
        Me.btn_clr.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.Transparent
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(26, 123)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(212, 55)
        Me.btn_add.TabIndex = 56
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'Customer_DataGridView
        '
        Me.Customer_DataGridView.AllowUserToAddRows = False
        Me.Customer_DataGridView.AllowUserToDeleteRows = False
        Me.Customer_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Customer_DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(240, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Customer_DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Customer_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Customer_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Customer_ID, Me.Customer_Name, Me.Address, Me.Contact})
        Me.Customer_DataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Customer_DataGridView.DefaultCellStyle = DataGridViewCellStyle6
        Me.Customer_DataGridView.Location = New System.Drawing.Point(30, 536)
        Me.Customer_DataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Customer_DataGridView.MultiSelect = False
        Me.Customer_DataGridView.Name = "Customer_DataGridView"
        Me.Customer_DataGridView.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Customer_DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.Customer_DataGridView.RowHeadersVisible = False
        Me.Customer_DataGridView.RowHeadersWidth = 45
        Me.Customer_DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Customer_DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.Customer_DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Customer_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Customer_DataGridView.Size = New System.Drawing.Size(1612, 486)
        Me.Customer_DataGridView.TabIndex = 55
        '
        'Customer_ID
        '
        Me.Customer_ID.DataPropertyName = "Customer_ID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_ID.DefaultCellStyle = DataGridViewCellStyle2
        Me.Customer_ID.HeaderText = "Customer_ID"
        Me.Customer_ID.Name = "Customer_ID"
        Me.Customer_ID.ReadOnly = True
        '
        'Customer_Name
        '
        Me.Customer_Name.DataPropertyName = "Customer_Name"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_Name.DefaultCellStyle = DataGridViewCellStyle3
        Me.Customer_Name.HeaderText = "Customer_Name"
        Me.Customer_Name.Name = "Customer_Name"
        Me.Customer_Name.ReadOnly = True
        '
        'Address
        '
        Me.Address.DataPropertyName = "Address"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.DefaultCellStyle = DataGridViewCellStyle4
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.Visible = False
        '
        'Contact
        '
        Me.Contact.DataPropertyName = "Contact"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contact.DefaultCellStyle = DataGridViewCellStyle5
        Me.Contact.HeaderText = "Contact"
        Me.Contact.Name = "Contact"
        Me.Contact.ReadOnly = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(732, 371)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 29)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Contact_no"
        '
        'txt_add
        '
        Me.txt_add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_add.Location = New System.Drawing.Point(892, 258)
        Me.txt_add.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_add.Name = "txt_add"
        Me.txt_add.Size = New System.Drawing.Size(324, 39)
        Me.txt_add.TabIndex = 52
        Me.txt_add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(764, 268)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 29)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 369)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 29)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Customer Name"
        '
        'txt_cname
        '
        Me.txt_cname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cname.Location = New System.Drawing.Point(284, 365)
        Me.txt_cname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_cname.Name = "txt_cname"
        Me.txt_cname.Size = New System.Drawing.Size(306, 39)
        Me.txt_cname.TabIndex = 50
        Me.txt_cname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(84, 262)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 29)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Customer_ID"
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.Color.White
        Me.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(284, 258)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(306, 39)
        Me.txt_id.TabIndex = 48
        Me.txt_id.TabStop = False
        Me.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(42, 46)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1454, 89)
        Me.Panel1.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(644, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(454, 72)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Entry"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(1758, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 48)
        Me.Label4.TabIndex = 60
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_del)
        Me.Panel2.Controls.Add(Me.btn_clr)
        Me.Panel2.Controls.Add(Me.btn_add)
        Me.Panel2.Location = New System.Drawing.Point(1310, 191)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(260, 306)
        Me.Panel2.TabIndex = 58
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.Transparent
        Me.btn_del.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del.Location = New System.Drawing.Point(26, 218)
        Me.btn_del.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(212, 55)
        Me.btn_del.TabIndex = 58
        Me.btn_del.Text = "Delete"
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'txt_Cno
        '
        Me.txt_Cno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Cno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cno.Location = New System.Drawing.Point(892, 371)
        Me.txt_Cno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_Cno.Name = "txt_Cno"
        Me.txt_Cno.Size = New System.Drawing.Size(324, 39)
        Me.txt_Cno.TabIndex = 61
        Me.txt_Cno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label10.Location = New System.Drawing.Point(26, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1810, 12)
        Me.Label10.TabIndex = 62
        '
        'Add_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1875, 1106)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_Cno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Customer_DataGridView)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_add)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_cname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Add_Customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add_Customer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Customer_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_clr As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents Customer_DataGridView As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_add As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_del As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Cno As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Customer_ID As DataGridViewTextBoxColumn
    Friend WithEvents Customer_Name As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents Contact As DataGridViewTextBoxColumn
End Class
