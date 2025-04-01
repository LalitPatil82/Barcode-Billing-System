Imports CrystalDecisions.CrystalReports.Engine

Public Class Purchase_Summary_view_rtp
    Private Sub Purchase_Summary_view_rtp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If r_type = "Purchase_rpt" Then

            Dim d As New Purchase_reports_rpt

            d.Load()

            Dim orpt As New ReportDocument

            orpt.Load(d.FileName)
            orpt.SetDataSource(dk.Tables(0))
            CrystalReportViewer1.ReportSource = orpt
            d.Dispose()

        ElseIf r_type = "Stock_rpt" Then

            Dim d As New Stock_rpt

            d.Load()

            Dim orpt As New ReportDocument

            orpt.Load(d.FileName)
            orpt.SetDataSource(dk.Tables(0))
            orpt.SetParameterValue("tot_qty", tot_qty)
            CrystalReportViewer1.ReportSource = orpt
            d.Dispose()
        ElseIf r_type = "Purchase_detail_rpt" Then

            Dim d As New Purchase_det_rpt

            d.Load()

            Dim orpt As New ReportDocument

            orpt.Load(d.FileName)
            orpt.SetDataSource(dk.Tables(0))
            CrystalReportViewer1.ReportSource = orpt
            d.Dispose()
        ElseIf r_type = "Sales_rpt" Then

            Dim d As New Sales_rpt

            d.Load()

            Dim orpt As New ReportDocument

            orpt.Load(d.FileName)
            orpt.SetDataSource(dk.Tables(0))
            CrystalReportViewer1.ReportSource = orpt
            d.Dispose()
        ElseIf r_type = "Sales_detail_rpt" Then

            Dim d As New Sales_detail_rpt

            d.Load()

            Dim orpt As New ReportDocument

            orpt.Load(d.FileName)
            orpt.SetDataSource(dk.Tables(0))
            orpt.SetParameterValue("qty_det_tbl", qty_det_tbl)
            CrystalReportViewer1.ReportSource = orpt
            d.Dispose()
        ElseIf r_type = "Sales_bill_rpt" Then

            Dim d As New Sales_bill_rpt

            d.Load()

            Dim orpt As New ReportDocument

            orpt.Load(d.FileName)
            orpt.SetDataSource(dk.Tables(0))
            orpt.SetParameterValue("IMEI_No", IMEI)
            orpt.SetParameterValue("Product_Name", P_Name)
            orpt.SetParameterValue("Quantity", Quanty)
            orpt.SetParameterValue("Rate", P_rate)
            orpt.SetParameterValue("CGST", P_cgst)
            orpt.SetParameterValue("SGST", P_sgst)
            orpt.SetParameterValue("Taxable_amt", P_taxamt)
            orpt.SetParameterValue("Amount_words", P_words)
            orpt.SetParameterValue("Tax_amt", Tax_amt)

            CrystalReportViewer1.ReportSource = orpt
            d.Dispose()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hide()

    End Sub

End Class