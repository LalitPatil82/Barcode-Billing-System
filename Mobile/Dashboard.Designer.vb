<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Product_Master_toolstrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Supplier_Master_toolstrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Customer_Master_toolstrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Purchase_Master_toolstrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Invoice_toolstrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewInvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Purchase_rpt_toolstrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseDetailReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesSummaryReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesDetailReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Loading = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Btn_Product = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Btn_Supplier = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Btn_Customer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Btn_Purchase = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.Btn_Stock = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Btn_Invoice = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.Product_Master_toolstrip, Me.Supplier_Master_toolstrip, Me.Customer_Master_toolstrip, Me.Purchase_Master_toolstrip, Me.Invoice_toolstrip, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(913, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductMasterToolStripMenuItem, Me.SupplierMasterToolStripMenuItem, Me.CustomerMasterToolStripMenuItem, Me.PurchaseMasterToolStripMenuItem})
        Me.MasterToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'ProductMasterToolStripMenuItem
        '
        Me.ProductMasterToolStripMenuItem.Name = "ProductMasterToolStripMenuItem"
        Me.ProductMasterToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.ProductMasterToolStripMenuItem.Text = "Product Master"
        '
        'SupplierMasterToolStripMenuItem
        '
        Me.SupplierMasterToolStripMenuItem.Name = "SupplierMasterToolStripMenuItem"
        Me.SupplierMasterToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.SupplierMasterToolStripMenuItem.Text = "Supplier Master"
        '
        'CustomerMasterToolStripMenuItem
        '
        Me.CustomerMasterToolStripMenuItem.Name = "CustomerMasterToolStripMenuItem"
        Me.CustomerMasterToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.CustomerMasterToolStripMenuItem.Text = "Customer Master"
        '
        'PurchaseMasterToolStripMenuItem
        '
        Me.PurchaseMasterToolStripMenuItem.Name = "PurchaseMasterToolStripMenuItem"
        Me.PurchaseMasterToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.PurchaseMasterToolStripMenuItem.Text = "Purchase Master"
        '
        'Product_Master_toolstrip
        '
        Me.Product_Master_toolstrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductEntryToolStripMenuItem})
        Me.Product_Master_toolstrip.Name = "Product_Master_toolstrip"
        Me.Product_Master_toolstrip.Size = New System.Drawing.Size(126, 24)
        Me.Product_Master_toolstrip.Text = "Product Master"
        '
        'ProductEntryToolStripMenuItem
        '
        Me.ProductEntryToolStripMenuItem.Name = "ProductEntryToolStripMenuItem"
        Me.ProductEntryToolStripMenuItem.Size = New System.Drawing.Size(173, 24)
        Me.ProductEntryToolStripMenuItem.Text = "Product Entry"
        '
        'Supplier_Master_toolstrip
        '
        Me.Supplier_Master_toolstrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupplierEntryToolStripMenuItem})
        Me.Supplier_Master_toolstrip.Name = "Supplier_Master_toolstrip"
        Me.Supplier_Master_toolstrip.Size = New System.Drawing.Size(129, 24)
        Me.Supplier_Master_toolstrip.Text = "Supplier Master"
        '
        'SupplierEntryToolStripMenuItem
        '
        Me.SupplierEntryToolStripMenuItem.Name = "SupplierEntryToolStripMenuItem"
        Me.SupplierEntryToolStripMenuItem.Size = New System.Drawing.Size(176, 24)
        Me.SupplierEntryToolStripMenuItem.Text = "Supplier Entry"
        '
        'Customer_Master_toolstrip
        '
        Me.Customer_Master_toolstrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerEntryToolStripMenuItem})
        Me.Customer_Master_toolstrip.Name = "Customer_Master_toolstrip"
        Me.Customer_Master_toolstrip.Size = New System.Drawing.Size(137, 24)
        Me.Customer_Master_toolstrip.Text = "Customer Master"
        '
        'CustomerEntryToolStripMenuItem
        '
        Me.CustomerEntryToolStripMenuItem.Name = "CustomerEntryToolStripMenuItem"
        Me.CustomerEntryToolStripMenuItem.Size = New System.Drawing.Size(184, 24)
        Me.CustomerEntryToolStripMenuItem.Text = "Customer Entry"
        '
        'Purchase_Master_toolstrip
        '
        Me.Purchase_Master_toolstrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchaseEntryToolStripMenuItem})
        Me.Purchase_Master_toolstrip.Name = "Purchase_Master_toolstrip"
        Me.Purchase_Master_toolstrip.Size = New System.Drawing.Size(134, 24)
        Me.Purchase_Master_toolstrip.Text = "Purchase Master"
        '
        'PurchaseEntryToolStripMenuItem
        '
        Me.PurchaseEntryToolStripMenuItem.Name = "PurchaseEntryToolStripMenuItem"
        Me.PurchaseEntryToolStripMenuItem.Size = New System.Drawing.Size(181, 24)
        Me.PurchaseEntryToolStripMenuItem.Text = "Purchase Entry"
        '
        'Invoice_toolstrip
        '
        Me.Invoice_toolstrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewInvoiceToolStripMenuItem})
        Me.Invoice_toolstrip.Name = "Invoice_toolstrip"
        Me.Invoice_toolstrip.Size = New System.Drawing.Size(106, 24)
        Me.Invoice_toolstrip.Text = "Sales Master"
        '
        'NewInvoiceToolStripMenuItem
        '
        Me.NewInvoiceToolStripMenuItem.Name = "NewInvoiceToolStripMenuItem"
        Me.NewInvoiceToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.NewInvoiceToolStripMenuItem.Text = "New Invoice"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Purchase_rpt_toolstrip, Me.PurchaseDetailReportToolStripMenuItem, Me.SalesReportToolStripMenuItem, Me.SalesSummaryReportToolStripMenuItem, Me.SalesDetailReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'Purchase_rpt_toolstrip
        '
        Me.Purchase_rpt_toolstrip.Name = "Purchase_rpt_toolstrip"
        Me.Purchase_rpt_toolstrip.Size = New System.Drawing.Size(262, 24)
        Me.Purchase_rpt_toolstrip.Text = "Purchase_Summary Report"
        '
        'PurchaseDetailReportToolStripMenuItem
        '
        Me.PurchaseDetailReportToolStripMenuItem.Name = "PurchaseDetailReportToolStripMenuItem"
        Me.PurchaseDetailReportToolStripMenuItem.Size = New System.Drawing.Size(262, 24)
        Me.PurchaseDetailReportToolStripMenuItem.Text = "Purchase_Detail Report"
        '
        'SalesReportToolStripMenuItem
        '
        Me.SalesReportToolStripMenuItem.Name = "SalesReportToolStripMenuItem"
        Me.SalesReportToolStripMenuItem.Size = New System.Drawing.Size(262, 24)
        Me.SalesReportToolStripMenuItem.Text = "Stock_Report"
        '
        'SalesSummaryReportToolStripMenuItem
        '
        Me.SalesSummaryReportToolStripMenuItem.Name = "SalesSummaryReportToolStripMenuItem"
        Me.SalesSummaryReportToolStripMenuItem.Size = New System.Drawing.Size(262, 24)
        Me.SalesSummaryReportToolStripMenuItem.Text = "Sales_Summary Report"
        '
        'SalesDetailReportToolStripMenuItem
        '
        Me.SalesDetailReportToolStripMenuItem.Name = "SalesDetailReportToolStripMenuItem"
        Me.SalesDetailReportToolStripMenuItem.Size = New System.Drawing.Size(262, 24)
        Me.SalesDetailReportToolStripMenuItem.Text = "Sales_Detail_Report"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Loading})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 702)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 9, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(913, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Loading
        '
        Me.Loading.BackColor = System.Drawing.Color.Silver
        Me.Loading.ForeColor = System.Drawing.SystemColors.Control
        Me.Loading.Name = "Loading"
        Me.Loading.Size = New System.Drawing.Size(119, 17)
        Me.Loading.Text = "ToolStripStatusLabel1"
        Me.Loading.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btn_Product, Me.ToolStripSeparator1, Me.Btn_Supplier, Me.ToolStripSeparator3, Me.Btn_Customer, Me.ToolStripSeparator4, Me.Btn_Purchase, Me.ToolStripSeparator5, Me.Btn_Stock, Me.ToolStripSeparator6, Me.Btn_Invoice})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 26)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(127, 676)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Btn_Product
        '
        Me.Btn_Product.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Product.Image = CType(resources.GetObject("Btn_Product.Image"), System.Drawing.Image)
        Me.Btn_Product.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Product.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Product.Name = "Btn_Product"
        Me.Btn_Product.Size = New System.Drawing.Size(125, 89)
        Me.Btn_Product.Text = "Product"
        Me.Btn_Product.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(125, 6)
        '
        'Btn_Supplier
        '
        Me.Btn_Supplier.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Supplier.Image = CType(resources.GetObject("Btn_Supplier.Image"), System.Drawing.Image)
        Me.Btn_Supplier.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Supplier.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Supplier.Name = "Btn_Supplier"
        Me.Btn_Supplier.Size = New System.Drawing.Size(125, 89)
        Me.Btn_Supplier.Text = "Supplier Info"
        Me.Btn_Supplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(125, 6)
        '
        'Btn_Customer
        '
        Me.Btn_Customer.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Customer.Image = CType(resources.GetObject("Btn_Customer.Image"), System.Drawing.Image)
        Me.Btn_Customer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Customer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Customer.Name = "Btn_Customer"
        Me.Btn_Customer.Size = New System.Drawing.Size(125, 89)
        Me.Btn_Customer.Text = "Customer Info"
        Me.Btn_Customer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(125, 6)
        '
        'Btn_Purchase
        '
        Me.Btn_Purchase.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Purchase.Image = CType(resources.GetObject("Btn_Purchase.Image"), System.Drawing.Image)
        Me.Btn_Purchase.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Purchase.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Purchase.Name = "Btn_Purchase"
        Me.Btn_Purchase.Size = New System.Drawing.Size(125, 89)
        Me.Btn_Purchase.Text = "Purchase"
        Me.Btn_Purchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(125, 6)
        '
        'Btn_Stock
        '
        Me.Btn_Stock.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Stock.Image = CType(resources.GetObject("Btn_Stock.Image"), System.Drawing.Image)
        Me.Btn_Stock.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Stock.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Stock.Name = "Btn_Stock"
        Me.Btn_Stock.Size = New System.Drawing.Size(125, 89)
        Me.Btn_Stock.Text = "Stocks"
        Me.Btn_Stock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(125, 6)
        '
        'Btn_Invoice
        '
        Me.Btn_Invoice.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Invoice.Image = CType(resources.GetObject("Btn_Invoice.Image"), System.Drawing.Image)
        Me.Btn_Invoice.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Invoice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Invoice.Name = "Btn_Invoice"
        Me.Btn_Invoice.Size = New System.Drawing.Size(125, 89)
        Me.Btn_Invoice.Text = "Invoice"
        Me.Btn_Invoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip2.Location = New System.Drawing.Point(887, 26)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(26, 676)
        Me.ToolStrip2.TabIndex = 9
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(913, 724)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Btn_Supplier As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents Btn_Customer As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents Btn_Purchase As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents Btn_Stock As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents Btn_Invoice As ToolStripButton
    Friend WithEvents Btn_Product As ToolStripButton
    Friend WithEvents Product_Master_toolstrip As ToolStripMenuItem
    Friend WithEvents Loading As ToolStripStatusLabel
    Friend WithEvents Supplier_Master_toolstrip As ToolStripMenuItem
    Friend WithEvents Customer_Master_toolstrip As ToolStripMenuItem
    Friend WithEvents Purchase_Master_toolstrip As ToolStripMenuItem
    Friend WithEvents Invoice_toolstrip As ToolStripMenuItem
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ProductMasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupplierMasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerMasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchaseMasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupplierEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchaseEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewInvoiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Purchase_rpt_toolstrip As ToolStripMenuItem
    Friend WithEvents PurchaseDetailReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesSummaryReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesDetailReportToolStripMenuItem As ToolStripMenuItem
End Class
