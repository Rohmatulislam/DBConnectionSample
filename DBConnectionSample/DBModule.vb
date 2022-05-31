Imports MySql.Data.MySqlClient

Public Class Form1

    Dim conn As MySqlConnection
    Dim dataAdapter As MySqlDataAdapter
    Dim dataSet As DataSet


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New MySqlConnection()
        conn.ConnectionString = "server=localhost;user id=root;password=;database=menjual"



        Try
            conn.Open()
            MessageBox.Show("Koneksi berhasil")

            dataAdapter = New MySqlDataAdapter("select * from tabel_login", conn)
            dataSet = New DataSet
            dataAdapter.Fill(dataSet)
            dgv_sample.DataSource = dataSet.Tables(0)
            dgv_sample.ReadOnly = True
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub
End Class
