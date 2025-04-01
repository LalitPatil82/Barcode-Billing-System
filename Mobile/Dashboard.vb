Imports System.ComponentModel


Public Class Dashboard

    Private Sub Btn_Product_Click(sender As Object, e As EventArgs) Handles Btn_Product.Click

        closeall()
        Dim product As New Product
        product.MdiParent = Me
        product.Show()
        product.Dock = DockStyle.Fill

        product.TextBox1.Focus()


    End Sub

    Private Sub Btn_Supplier_Click(sender As Object, e As EventArgs) Handles Btn_Supplier.Click

        closeall()
        Dim supplier As New Supplier

        supplier.MdiParent = Me

        supplier.Show()

        supplier.Dock = DockStyle.Fill


    End Sub

    Private Sub Btn_Customer_Click(sender As Object, e As EventArgs) Handles Btn_Customer.Click

        closeall()
        Dim customer As New Customer

        customer.MdiParent = Me

        customer.Show()

        customer.Dock = DockStyle.Fill

    End Sub

    Private Sub Btn_Purchase_Click(sender As Object, e As EventArgs) Handles Btn_Purchase.Click

        closeall()
        Dim purchase As New Purchase

        purchase.MdiParent = Me

        purchase.Show()

        purchase.Dock = DockStyle.Fill

    End Sub


    Private Sub Dashboard_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Me.Dispose()
    End Sub



    Private Sub AddProductToolStripMenuItem_Click(sender As Object, e As EventArgs)

        closeall()
        Dim pr As New Add_product

        pr.MdiParent = Me

        pr.Show()

        pr.Dock = DockStyle.Fill

    End Sub
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property



    Private Sub AddProductToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

        closeall()
        Dim add_product As New Add_product

        add_product.MdiParent = Me

        add_product.Show()

        add_product.Dock = DockStyle.Fill
    End Sub



    Private Sub Btn_Stock_Click(sender As Object, e As EventArgs) Handles Btn_Stock.Click

        closeall()
        Dim stock As New Stock

        stock.MdiParent = Me

        stock.Show()

        stock.Dock = DockStyle.Fill
    End Sub

    Private Sub Btn_Invoice_Click(sender As Object, e As EventArgs) Handles Btn_Invoice.Click

        closeall()
        Dim bill As New Invoice


        bill.MdiParent = Me

        bill.Show()


    End Sub


    'Private Sub AddSalesInvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSalesInvoiceToolStripMenuItem.Click
    '    Dim add_Sales_Invoice As New Bill

    '    add_Sales_Invoice.MdiParent = Me

    '    add_Sales_Invoice.Show()

    '    add_Sales_Invoice.Dock = DockStyle.Fill
    'End Sub

    Private Sub closeall()
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub ProductMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductMasterToolStripMenuItem.Click

        closeall()
        Dim product As New Product
        product.MdiParent = Me
        product.Show()
        product.Dock = DockStyle.Fill

        product.TextBox1.Focus()

    End Sub

    Private Sub SupplierMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierMasterToolStripMenuItem.Click

        closeall()
        Dim supplier As New Supplier

        supplier.MdiParent = Me

        supplier.Show()

        supplier.Dock = DockStyle.Fill

    End Sub

    Private Sub CustomerMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerMasterToolStripMenuItem.Click

        closeall()
        Dim customer As New Customer

        customer.MdiParent = Me

        customer.Show()

        customer.Dock = DockStyle.Fill
    End Sub

    Private Sub PurchaseMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseMasterToolStripMenuItem.Click

        closeall()
        Dim purchase As New Purchase

        purchase.MdiParent = Me

        purchase.Show()

        purchase.Dock = DockStyle.Fill
    End Sub



    Public Sub ProductEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductEntryToolStripMenuItem.Click

        closeall()
        Dim add_product As New Add_product

        add_product.MdiParent = Me

        add_product.Show()

        'add_product.Dock = DockStyle.Fill

    End Sub


    Public Sub SupplierEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierEntryToolStripMenuItem.Click

        Dim add_Supplier As New Add_Supplier

        closeall()
        add_Supplier.MdiParent = Me

        add_Supplier.Show()

        add_Supplier.Dock = DockStyle.Fill
    End Sub


    Public Sub CustomerEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerEntryToolStripMenuItem.Click

        closeall()
        Dim add_Customer As New Add_Customer

        add_Customer.MdiParent = Me

        add_Customer.Show()

        add_Customer.Dock = DockStyle.Fill
    End Sub

    Public Sub PurchaseEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseEntryToolStripMenuItem.Click

        closeall()
        Dim add_Purchase As New Add_Purchase

        add_Purchase.MdiParent = Me

        add_Purchase.Show()

        add_Purchase.Dock = DockStyle.Fill
    End Sub

    Private Sub NewInvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewInvoiceToolStripMenuItem.Click


        closeall()
        Dim New_Invoice As New Invoice

        New_Invoice.MdiParent = Me

        New_Invoice.Show()

        New_Invoice.Dock = DockStyle.Fill
    End Sub


    Private Sub Purchase_rpt_toolstrip_Click(sender As Object, e As EventArgs) Handles Purchase_rpt_toolstrip.Click

        closeall()
        Dim pur_rpt As New Purchase_rpt

        pur_rpt.MdiParent = Me

        pur_rpt.Show()

        pur_rpt.Dock = DockStyle.Fill
    End Sub

    Private Sub Invoice_toolstrip_Click(sender As Object, e As EventArgs) Handles Invoice_toolstrip.Click

    End Sub

    Private Sub PurchaseDetailReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchaseDetailReportToolStripMenuItem.Click

        closeall()
        Dim pur_rpt As New Purchase_detail_rpt

        pur_rpt.MdiParent = Me

        pur_rpt.Show()

        pur_rpt.Dock = DockStyle.Fill
    End Sub

    Private Sub SalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesReportToolStripMenuItem.Click
        closeall()
        Dim Stocks_rpt As New Stock_report

        Stocks_rpt.MdiParent = Me

        Stocks_rpt.Show()

        Stocks_rpt.Dock = DockStyle.Fill
    End Sub

    Private Sub SalesSummaryReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesSummaryReportToolStripMenuItem.Click
        closeall()
        Dim Sale_rpt As New Sales_report

        Sale_rpt.MdiParent = Me

        Sale_rpt.Show()

        Sale_rpt.Dock = DockStyle.Fill
    End Sub

    Private Sub SalesDetailReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesDetailReportToolStripMenuItem.Click
        closeall()
        Dim Sale_rpt1 As New Sales_Detail_report

        Sale_rpt1.MdiParent = Me

        Sale_rpt1.Show()

        Sale_rpt1.Dock = DockStyle.Fill
    End Sub

End Class