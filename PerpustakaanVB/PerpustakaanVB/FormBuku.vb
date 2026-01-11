Imports MySqlConnector

Public Class FormBuku

    Dim idBuku As Integer = 0
    Dim modeTambah As Boolean = False

    ' =============================
    ' FORM LOAD
    ' =============================
    Private Sub FormBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilBuku()
        SetInput(False)
    End Sub

    ' =============================
    ' TAMPIL SEMUA BUKU
    ' =============================
    Sub TampilBuku()
        Call Koneksi()
        Dim da As New MySqlDataAdapter(
            "SELECT id_buku, kode_buku, judul, pengarang, penerbit, tahun_terbit, stok, status FROM buku", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        dgvBuku.DataSource = dt
        dgvBuku.Columns("id_buku").Visible = False
    End Sub

    ' =============================
    ' AKTIF / NONAKTIF INPUT
    ' =============================
    Sub SetInput(status As Boolean)
        txtKode.Enabled = status
        txtJudul.Enabled = status
        txtPengarang.Enabled = status
        txtPenerbit.Enabled = status
        txtTahun.Enabled = status
        txtStok.Enabled = status
    End Sub

    ' =============================
    ' BERSIHKAN INPUT
    ' =============================
    Sub Bersih()
        txtKode.Clear()
        txtJudul.Clear()
        txtPengarang.Clear()
        txtPenerbit.Clear()
        txtTahun.Clear()
        txtStok.Clear()
        idBuku = 0
    End Sub

    ' =============================
    ' KLIK GRID → AMBIL DATA
    ' =============================
    Private Sub dgvBuku_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBuku.CellClick
        If e.RowIndex >= 0 Then
            Dim r = dgvBuku.Rows(e.RowIndex)
            idBuku = r.Cells("id_buku").Value
            txtKode.Text = r.Cells("kode_buku").Value.ToString()
            txtJudul.Text = r.Cells("judul").Value.ToString()
            txtPengarang.Text = r.Cells("pengarang").Value.ToString()
            txtPenerbit.Text = r.Cells("penerbit").Value.ToString()
            txtTahun.Text = r.Cells("tahun_terbit").Value.ToString()
            txtStok.Text = r.Cells("stok").Value.ToString()
        End If
    End Sub

    ' =============================
    ' TOMBOL CARI
    ' =============================
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If txtCari.Text.Trim() = "" Then
            TampilBuku()
            Exit Sub
        End If

        Call Koneksi()
        Dim da As New MySqlDataAdapter(
            "SELECT id_buku, kode_buku, judul, pengarang, penerbit, tahun_terbit, stok, status
             FROM buku
             WHERE judul LIKE @c OR kode_buku LIKE @c OR pengarang LIKE @c", conn)

        da.SelectCommand.Parameters.AddWithValue("@c", "%" & txtCari.Text & "%")
        Dim dt As New DataTable
        da.Fill(dt)
        dgvBuku.DataSource = dt
        dgvBuku.Columns("id_buku").Visible = False
    End Sub

    ' =============================
    ' TOMBOL TAMBAH / SIMPAN
    ' =============================
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Not modeTambah Then
            modeTambah = True
            btnTambah.Text = "SIMPAN"
            SetInput(True)
            Bersih()
            txtKode.Focus()
        Else
            If txtKode.Text = "" Or txtJudul.Text = "" Then
                MessageBox.Show("Data belum lengkap")
                Exit Sub
            End If

            Call Koneksi()
            Dim cmd As New MySqlCommand(
                "INSERT INTO buku (kode_buku, judul, pengarang, penerbit, tahun_terbit, stok, status)
                 VALUES (@k,@j,@pg,@pb,@t,@s,'Tersedia')", conn)

            cmd.Parameters.AddWithValue("@k", txtKode.Text)
            cmd.Parameters.AddWithValue("@j", txtJudul.Text)
            cmd.Parameters.AddWithValue("@pg", txtPengarang.Text)
            cmd.Parameters.AddWithValue("@pb", txtPenerbit.Text)
            cmd.Parameters.AddWithValue("@t", txtTahun.Text)
            cmd.Parameters.AddWithValue("@s", txtStok.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data berhasil ditambahkan")

            modeTambah = False
            btnTambah.Text = "Tambah"
            SetInput(False)
            Bersih()
            TampilBuku()
        End If
    End Sub

    ' =============================
    ' TOMBOL EDIT
    ' =============================
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If idBuku = 0 Then
            MessageBox.Show("Pilih data terlebih dahulu")
            Exit Sub
        End If

        Call Koneksi()
        Dim cmd As New MySqlCommand(
            "UPDATE buku SET kode_buku=@k, judul=@j, pengarang=@pg,
             penerbit=@pb, tahun_terbit=@t, stok=@s
             WHERE id_buku=@id", conn)

        cmd.Parameters.AddWithValue("@id", idBuku)
        cmd.Parameters.AddWithValue("@k", txtKode.Text)
        cmd.Parameters.AddWithValue("@j", txtJudul.Text)
        cmd.Parameters.AddWithValue("@pg", txtPengarang.Text)
        cmd.Parameters.AddWithValue("@pb", txtPenerbit.Text)
        cmd.Parameters.AddWithValue("@t", txtTahun.Text)
        cmd.Parameters.AddWithValue("@s", txtStok.Text)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Data berhasil diubah")
        TampilBuku()
        Bersih()
    End Sub

    ' =============================
    ' TOMBOL HAPUS
    ' =============================
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If idBuku = 0 Then
            MessageBox.Show("Pilih data terlebih dahulu")
            Exit Sub
        End If

        If MessageBox.Show("Yakin hapus data ini?", "Konfirmasi",
                           MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Call Koneksi()
            Dim cmd As New MySqlCommand(
                "DELETE FROM buku WHERE id_buku=@id", conn)
            cmd.Parameters.AddWithValue("@id", idBuku)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data berhasil dihapus")
            TampilBuku()
            Bersih()
        End If
    End Sub

    ' =============================
    ' TOMBOL KEMBALI
    ' =============================
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        FormDashboard.Show()
        Me.Close()
    End Sub

End Class
