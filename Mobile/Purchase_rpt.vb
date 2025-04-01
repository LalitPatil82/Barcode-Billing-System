Public Class Purchase_rpt
    Private Sub Purchase_rpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmb_supname.Focus()
        load_supplier()

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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try

            Dim d As New Dao
            Dim ds As New Data.DataSet

            If cmb_supname.Text <> "" Then

                'all ledger Purchase between date

                ds = d.loaddata("Select Bill_Date,Invoice_No,Ledger_Name,Round_Off,Total_pgst,Total_Amount from Purchase_Summary where Bill_Date between '" & DateTimePicker1.Value.ToShortDateString() & "' and '" & DateTimePicker2.Value.ToShortDateString() & "' and Ledger_Name = '" & cmb_supname.Text & "'")
            Else

                'all Purchase between date

                ds = d.loaddata("Select Bill_Date,Invoice_No,Ledger_Name,Round_Off,Total_pgst,Total_Amount from Purchase_Summary where Bill_Date between '" & DateTimePicker1.Value.ToShortDateString() & "' and '" & DateTimePicker2.Value.ToShortDateString() & "'")
            End If

            DataGridView1.DataSource = ds.Tables(0)

            'Lode into Dataset

            dk = ds
            'Calculate the totals of DataGridView

            count_total()
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Public Sub count_total()

        Dim d As Integer = DataGridView1.Rows.Count - 1
        Dim gst_tot As Double = 0
        Dim tot_amt As Double = 0

        While d >= 0

            gst_tot += Math.Round(Val(DataGridView1.Item("Total_pgst", d).Value), 2)
            tot_amt += Math.Round(Val(DataGridView1.Item("Total_Amount", d).Value), 2)

            d -= 1
        End While

        txt_gst_tot.Text = gst_tot
        txt_tot_amt.Text = tot_amt
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick



        If DataGridView1.Rows.Count > 0 Then

            invno = DataGridView1.Item("Invoice_No", DataGridView1.CurrentCell.RowIndex).Value

            If invno <> "" Then

                Dim d As New Add_Purchase

                d.MdiParent = Me.MdiParent

                d.Show()

            End If
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If DataGridView1.Rows.Count > 0 Then

            r_type = "Purchase_rpt"

            Dim d As New Purchase_Summary_view_rtp

            d.MdiParent = Me.MdiParent

            d.Show()
        End If
    End Sub
End Class

