Imports System.Data.SqlClient

Public Class Stock
    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        load_data()
    End Sub

    Public Sub load_data()

        Dim d As New Dao
        Dim ds As New Data.DataSet

        ds = d.loaddata("Select Invoice_No,IMEI_NUMBER,Product_Name,HSN_Code,Quantity from Stock")

        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim query As String = "select Product_Name,IMEI_NUMBER,HSN_Code,Quantity from Stock where IMEI_NUMBER like '%" & TextBox1.Text & "%'"
        Using con As SqlConnection = New SqlConnection("Data Source=(local);Initial Catalog=data_stu16;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then

                            DataGridView1.DataSource = dt

                        Else
                            MessageBox.Show("No Record Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            TextBox1.Text = ""



                        End If

                    End Using
                End Using
            End Using
        End Using
    End Sub


End Class