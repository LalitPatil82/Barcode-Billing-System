Imports System.Data.SqlClient

Public Class Dao

    Private con As SqlClient.SqlConnection


    Public Sub New()

        con = New SqlConnection("Data Source=(local);Initial Catalog=data_stu16;Integrated Security=True")

        Try

            con.Open()
            con.Close()
        Catch ex As Exception

            MessageBox.Show("Please Check Database Connectivity......")

        End Try
    End Sub

    Public Sub close_conn()



        If con.State = ConnectionState.Open Then

            con.Close()

        End If

    End Sub

    Public Function getdata(ByVal str As String) As SqlDataReader

        Dim obj As SqlDataReader
        con.Open()
        Dim cmd As New SqlCommand(str, con)


        obj = cmd.ExecuteReader

        Return obj

        con.Close()
    End Function

    Public Function validate(ByVal str As String) As Integer



        Dim f As Integer = 0
        Dim obj As SqlDataReader


        obj = getdata(str)

        While obj.Read

            f = 1

        End While

        Return f

        con.Close()

    End Function

    Public Sub modifyData(ByVal str As String)
        Try

            con.Open()

            Dim cmd As New SqlCommand(str, con)

            cmd.ExecuteNonQuery()

            con.Close()
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub
    Public Function datagrid(ByVal str As String) As DataSet


        Dim cmd As SqlCommand
        Dim ds As DataSet
        Dim da As SqlDataAdapter

        cmd = New SqlCommand(str, con)
        con.Open()
        da = New SqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds)
        Return ds
        con.Close()
        'DataGridView1.DataSource = ds.Tables(0)
    End Function
    Public Sub press_enter(e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub
    Public Function loaddata(ByVal str As String) As System.Data.DataSet
        Dim ds As New Data.DataSet
        Dim da As New SqlClient.SqlDataAdapter(str, con)
        con.Open()
        da.SelectCommand.ExecuteReader()
        con.Close()
        da.Fill(ds)
        Return ds

    End Function
    Public Sub char_validate(e As KeyEventArgs)
        'assci of a to z and A to Z is used
        'space,backspace,dot is used
        If (e.KeyCode >= Asc("a") And e.KeyCode <= Asc("z")) Or e.KeyCode = Keys.Space Or e.KeyCode = Keys.Back Then
            e.SuppressKeyPress = False
        Else
            e.SuppressKeyPress = True
        End If

        If (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) Or (e.KeyCode >= Asc("0") And e.KeyCode <= Asc("9")) Then
            e.SuppressKeyPress = True
        Else
            e.SuppressKeyPress = False
        End If
    End Sub




End Class
