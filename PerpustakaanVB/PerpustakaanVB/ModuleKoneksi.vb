Imports MySqlConnector


Module ModuleKoneksi
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader

    Sub Koneksi()
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=db_perpustakaan")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
