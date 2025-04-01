Public Class Delete_IMEI
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text <> "" Then

            Dim d As New Dao

            d.modifyData("Delete from Stock where IMEI_NUMBER = '" & TextBox1.Text & "'")

            MessageBox.Show("Deleted the Product", "Message")
        End If

        Me.Dispose()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub
End Class