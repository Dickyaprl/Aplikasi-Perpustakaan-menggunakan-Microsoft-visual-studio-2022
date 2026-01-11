Imports MySqlConnector

Public Class FormPengembalianBuku

    Dim idPinjam As Integer = 0
    Dim idBuku As Integer = 0

    ' =============================
    ' FORM LOAD
    ' =============================
    Private Sub FormPengembalianBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilPeminjaman()
    End Sub

    ' =============================
    ' TAMPIL DATA PEMINJAMAN AKTIF
    ' =============================
    Sub TampilPeminjaman()
        Call Koneksi()
        Dim da As New MySqlDataAdapter(
            "SELECT p.id_pinjam, p.id_buku,
                    b.kode_buku, b.judul,
                    p.nama_peminjam, p.nim, p.prodi,
                    p.tanggal_pinjam, p.tanggal_selesai
             FROM peminjaman p
             JOIN buku b ON p.id_buku = b.id_buku
             WHERE p.status='Dipinjam'", conn)

        Dim dt As New DataTable
        da.Fill(dt)
        dgvPeminjaman.DataSource = dt

        dgvPeminjaman.Columns("id_pinjam").Visible = False
        dgvPeminjaman.Columns("id_buku").Visible = False
    End Sub

    ' =============================
    ' PILIH DATA PEMINJAMAN
    ' =============================
    Private Sub dgvPeminjaman_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPeminjaman.CellClick
        If e.RowIndex >= 0 Then
            idPinjam = dgvPeminjaman.Rows(e.RowIndex).Cells("id_pinjam").Value
            idBuku = dgvPeminjaman.Rows(e.RowIndex).Cells("id_buku").Value
        End If
    End Sub

    ' =============================
    ' KEMBALIKAN BUKU
    ' =============================
    Private Sub btnKembalikan_Click(sender As Object, e As EventArgs) Handles btnKembalikan.Click
        If idPinjam = 0 Then
            MessageBox.Show("Pilih data peminjaman terlebih dahulu",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MessageBox.Show("Yakin ingin mengembalikan buku ini?",
                           "Konfirmasi",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Call Koneksi()

        ' update status peminjaman
        Dim cmd As New MySqlCommand(
            "UPDATE peminjaman
             SET status='Dikembalikan'
             WHERE id_pinjam=@id", conn)
        cmd.Parameters.AddWithValue("@id", idPinjam)
        cmd.ExecuteNonQuery()

        ' update status buku
        Dim cmd2 As New MySqlCommand(
            "UPDATE buku
             SET status='Tersedia'
             WHERE id_buku=@b", conn)
        cmd2.Parameters.AddWithValue("@b", idBuku)
        cmd2.ExecuteNonQuery()

        MessageBox.Show("Buku berhasil dikembalikan",
                        "Sukses",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

        idPinjam = 0
        idBuku = 0
        TampilPeminjaman()
    End Sub

    ' =============================
    ' KEMBALI
    ' =============================
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        FormDashboard.Show()
        Me.Close()
    End Sub

End Class
