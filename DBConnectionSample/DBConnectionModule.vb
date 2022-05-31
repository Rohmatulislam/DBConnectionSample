Imports MySql.Data.MySqlClient

Module DBConnectionModule
    Public CONN As MySqlConnection = New MySqlConnection()

    Sub OpenConnection()
        CONN.ConnectionString = "server=localhost;user id=root;password=;database=menjual"
        CONN.Open()
    End Sub

    Sub CloseConnection()
        CONN.Close()
    End Sub
End Module
