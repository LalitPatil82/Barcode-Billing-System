Imports System.Data.SqlClient
Public Class Supplier
    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loaddata()
    End Sub

    Public Sub loaddata()
        Dim ds As New Data.DataSet
        Dim d As New Dao
        ds = d.loaddata("select GST_No,Supplier_Name,Brand,Address,State,City,Contact_no,Payment_Duration,Bank_Name from Supplier order by Supplier_Name")
        Supplier_DataGridView.DataSource = ds.Tables(0)
    End Sub



    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Dim query As String = ("select GST_No,Supplier_Name,Brand,Address,State,City,Contact_no,Payment_Duration,Bank_Name from Supplier where Supplier_Name like '%" & TextBox1.Text & "%'")
        Using con As SqlConnection = New SqlConnection("Data Source=(local);Initial Catalog=data_stu16;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            Supplier_DataGridView.DataSource = dt
                        Else

                            MessageBox.Show("No Record Found", "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            TextBox1.Text = ""
                            loaddata()


                        End If
                    End Using
                End Using
            End Using
        End Using

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

        Me.Close()

    End Sub

    Private Sub Label9_MouseHover(sender As Object, e As EventArgs) Handles Label9.MouseHover

        Label9.BackColor = Color.Red
    End Sub

    Private Sub Label9_MouseLeave(sender As Object, e As EventArgs) Handles Label9.MouseLeave

        Label9.BackColor = Color.Transparent
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text = ""
        loaddata()

    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover

        Button1.BackColor = Color.Orange
        Button1.ForeColor = Color.White
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave

        Button1.BackColor = Color.White
        Button1.ForeColor = Color.Black
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dashboard.SupplierEntryToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover

        Button2.BackColor = Color.GreenYellow

    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave

        Button2.BackColor = Color.White

    End Sub
End Class