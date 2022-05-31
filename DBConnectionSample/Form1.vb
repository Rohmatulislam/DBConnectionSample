Imports MySql.Data.MySqlClient

Public Class Form1

    Dim dataAdapter As MySqlDataAdapter
    Dim dataSet As DataSet


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReloadData()
    End Sub


    Sub ReloadData()
        Try
            DBConnectionModule.OpenConnection()

            dataAdapter = New MySqlDataAdapter("select * from tabel_login", DBConnectionModule.CONN)
            dataSet = New DataSet
            dataAdapter.Fill(dataSet)
            dgv_sample.DataSource = dataSet.Tables(0)
            dgv_sample.ReadOnly = True
            DBConnectionModule.CloseConnection()
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message)
        End Try
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        DBConnectionModule.OpenConnection()
        Dim command = New MySqlCommand("INSERT INTO tabel_login values(3,'user','pass','member')", DBConnectionModule.CONN)
        command.ExecuteNonQuery()
        DBConnectionModule.CloseConnection()
        ReloadData()
    End Sub

    Private Sub btn_hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click
        DBConnectionModule.OpenConnection()
        Dim command = New MySqlCommand("DELETE from tabel_login where id_login = 3", DBConnectionModule.CONN)
        command.ExecuteNonQuery()
        DBConnectionModule.CloseConnection()
        ReloadData()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        DBConnectionModule.OpenConnection()
        Dim command = New MySqlCommand("UPDATE tabel_login set Username='updated user'  where id_login = 3", DBConnectionModule.CONN)
        command.ExecuteNonQuery()
        DBConnectionModule.CloseConnection()
        ReloadData()
    End Sub
End Class
