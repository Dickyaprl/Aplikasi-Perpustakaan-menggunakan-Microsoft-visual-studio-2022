Imports MySqlConnector

Public Class FormDataTerlambat

    Const DENDA_PER_HARI As Integer = 2000

    ' =============================
    ' FORM LOAD
    ' =============================
    Private Sub FormDataTerlambat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilDataTerlambat()
    End Sub

    ' =============================
    ' TAMPIL DATA TERLAMBAT
    ' =============================
    Sub TampilDataTerlambat()
        Call Koneksi()
        Dim da As New MySqlDataAdapter(
            "SELECT 
                p.id_pinjam,
                b.kode_buku,
                b.judul,
                p.nama_peminjam,
                p.nim,
                p.prodi,
                p.tanggal_selesai,
                DATEDIFF(CURDATE(), p.tanggal_selesai) AS hari_terlambat,
                (DATEDIFF(CURDATE(), p.tanggal_selesai) * @denda) AS total_denda
             FROM peminjaman p
             JOIN buku b ON p.id_buku = b.id_buku
             WHERE p.status='Dipinjam'
               AND p.tanggal_selesai < CURDATE()", conn)

        da.SelectCommand.Parameters.AddWithValue("@denda", DENDA_PER_HARI)

        Dim dt As New DataTable
        da.Fill(dt)
        dgvTerlambat.DataSource = dt

        dgvTerlambat.Columns("id_pinjam").Visible = False
    End Sub

    ' =============================
    ' KEMBALI
    ' =============================
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        FormDashboard.Show()
        Me.Close()
    End Sub

End Class
