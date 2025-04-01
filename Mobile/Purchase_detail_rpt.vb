Public Class Purchase_detail_rpt
    Public Sub load_product()

        Try
            Dim d As New Dao
            Dim ds As New Data.DataSet

            ds = d.loaddata("Select distinct(Product_Name),Product_id from Product1")

            cmb_pname.DisplayMember = "Product_Name"
            cmb_pname.ValueMember = "Produce_id"
            cmb_pname.DataSource = ds.Tables(0)



        Catch ex As Exception



        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try

            Dim d As New Dao
            Dim ds As New Data.DataSet

            If cmb_pname.Text <> "" Then

                'all ledger Purchase between date

                ds = d.loaddata("Select Invoice_No,Product_Name,HSN_Code,Quantity,Rate,P_Total from Purchase_Detail where Product_Name = '" & cmb_pname.Text & "'")
            Else

                'all Purchase between date

                ds = d.loaddata("Select Invoice_No,Product_Name,HSN_Code,Quantity,Rate,P_Total from Purchase_Detail")
            End If

            DataGridView1.DataSource = ds.Tables(0)
            dk = ds
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Purchase_detail_rpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        load_product()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If DataGridView1.Rows.Count > 0 Then

            r_type = "Purchase_detail_rpt"

            Dim d As New Purchase_Summary_view_rtp

            d.MdiParent = Me.MdiParent

            d.Show()
        End If
    End Sub

End Class