Imports System.Data.SqlClient
Public Class IMEI_store
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Textbox1.TextChanged

        DataGridView1.RowCount = Val(Textbox1.Text)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'load_imei()
        qty = Textbox1.Text


        Try
            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim constring As SqlClient.SqlConnection
                constring = New SqlConnection("Data Source=(local);Initial Catalog=data_stu16;Integrated Security=True")

                Using cmd As New SqlCommand("insert into IMEI_NUM(IMEI_NUMBER) values(@IMEI_NUMBER)", constring)
                    cmd.Parameters.AddWithValue("@IMEI_NUMBER", row.Cells("IMEI_NUMBER").Value)
                    constring.Open()
                    cmd.ExecuteNonQuery()
                    constring.Close()
                End Using
            Next
            MessageBox.Show("record saved")

            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Public Sub load_imei()
        Try
            Dim d As New Dao
            Dim ds As New Data.DataSet

            ds = d.loaddata("select * from IMEI_NUM")

            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub
End Class