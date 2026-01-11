Imports MySqlConnector

Public Class FromPinjambuku

    Dim idBuku As Integer = 0
    Private Sub FromPinjambuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilBukuTersedia()
        dtPinjam.Value = Date.Today
        dtSelesai.Value = Date.Today.AddDays(7)
    End Sub
    Sub TampilBukuTersedia()
        Call Koneksi()
        Dim da As New MySqlDataAdapter(
            "SELECT id_buku, kode_buku, judul, pengarang
             FROM buku
             WHERE status='Tersedia'", conn)

        Dim dt As New DataTable
        da.Fill(dt)
        dgvBuku.DataSource = dt
        dgvBuku.Columns("id_buku").Visible = False
    End Sub

    ' =============================
    ' PILIH BUKU
    ' =============================
    Private Sub dgvBuku_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBuku.CellClick
        If e.RowIndex >= 0 Then
            idBuku = dgvBuku.Rows(e.RowIndex).Cells("id_buku").Value
        End If
    End Sub

    ' =============================
    ' CARI BUKU
    ' =============================
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Call Koneksi()
        Dim da As New MySqlDataAdapter(
            "SELECT id_buku, kode_buku, judul, pengarang
             FROM buku
             WHERE status='Tersedia'
               AND (judul LIKE @c OR kode_buku LIKE @c)", conn)

        da.SelectCommand.Parameters.AddWithValue("@c", "%" & txtCari.Text & "%")

        Dim dt As New DataTable
        da.Fill(dt)
        dgvBuku.DataSource = dt
        dgvBuku.Columns("id_buku").Visible = False
    End Sub

    ' =============================
    ' PINJAM BUKU
    ' =============================
    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        If idBuku = 0 Or txtNama.Text = "" Or txtNIM.Text = "" Or txtProdi.Text = "" Then
            MessageBox.Show("Lengkapi data dan pilih buku terlebih dahulu",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        If dtSelesai.Value <= dtPinjam.Value Then
            MessageBox.Show("Tanggal selesai harus lebih besar dari tanggal pinjam",
                            "Kesalahan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Exit Sub
        End If

        Call Koneksi()

        ' simpan peminjaman
        Dim cmd As New MySqlCommand(
            "INSERT INTO peminjaman
            (id_buku, nama_peminjam, nim, prodi, tanggal_pinjam, tanggal_selesai)
            VALUES (@b,@n,@nim,@p,@tp,@ts)", conn)

        cmd.Parameters.AddWithValue("@b", idBuku)
        cmd.Parameters.AddWithValue("@n", txtNama.Text)
        cmd.Parameters.AddWithValue("@nim", txtNIM.Text)
        cmd.Parameters.AddWithValue("@p", txtProdi.Text)
        cmd.Parameters.AddWithValue("@tp", dtPinjam.Value.Date)
        cmd.Parameters.AddWithValue("@ts", dtSelesai.Value.Date)
        cmd.ExecuteNonQuery()

        ' update status buku
        Dim cmd2 As New MySqlCommand(
            "UPDATE buku SET status='Dipinjam' WHERE id_buku=@id", conn)
        cmd2.Parameters.AddWithValue("@id", idBuku)
        cmd2.ExecuteNonQuery()

        MessageBox.Show("Buku berhasil dipinjam",
                        "Sukses",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

        ' reset
        txtNama.Clear()
        txtNIM.Clear()
        txtProdi.Clear()
        txtCari.Clear()
        idBuku = 0
        TampilBukuTersedia()
    End Sub

    ' =============================
    ' KEMBALI
    ' =============================
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        FormDashboard.Show()
        Me.Close()
    End Sub
End Class