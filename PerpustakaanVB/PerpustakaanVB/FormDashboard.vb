Imports System.Drawing.Drawing2D
Imports MySqlConnector


Public Class FormDashboard
    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundedControl(PanelBuku, 25)
        RefreshDashboard()
        lblTotalBuku.Text = GetTotalBuku().ToString()
        lblBukuTersedia.Text = GetBukuTersedia().ToString()
        lblBukuDipinjam.Text = GetBukuDipinjam().ToString()
        lblHariIni.Text = GetPeminjamanHariIni().ToString()
    End Sub
    Private Sub RoundedControl(ctrl As Control, radius As Integer)
        Dim path As New GraphicsPath()
        path.StartFigure()

        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(ctrl.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(ctrl.Width - radius, ctrl.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, ctrl.Height - radius, radius, radius, 90, 90)

        path.CloseFigure()
        ctrl.Region = New Region(path)
    End Sub
    Sub RefreshDashboard()
        lblTotalBuku.Text = GetTotalBuku().ToString()
        lblBukuTersedia.Text = GetBukuTersedia().ToString()
        lblBukuDipinjam.Text = GetBukuDipinjam().ToString()
        lblHariIni.Text = GetPeminjamanHariIni().ToString()
    End Sub

    Private Sub btnBuku_Click(sender As Object, e As EventArgs) Handles btnBuku.Click
        Dim f As New FormBuku
        f.Show
        Hide '
    End Sub

    Function GetTotalBuku() As Integer
        Call Koneksi()
        Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM buku", conn)
        Return Convert.ToInt32(cmd.ExecuteScalar())
    End Function
    Function GetBukuTersedia() As Integer
        Call Koneksi()
        Dim cmd As New MySqlCommand(
        "SELECT COUNT(*) FROM buku WHERE status='Tersedia'", conn)
        Return Convert.ToInt32(cmd.ExecuteScalar())
    End Function
    Function GetBukuDipinjam() As Integer
        Call Koneksi()
        Dim cmd As New MySqlCommand(
        "SELECT COUNT(*) FROM buku WHERE status='Dipinjam'", conn)
        Return Convert.ToInt32(cmd.ExecuteScalar())
    End Function
    Function GetPeminjamanHariIni() As Integer
        Call Koneksi()
        Dim cmd As New MySqlCommand(
        "SELECT COUNT(*) FROM peminjaman WHERE tanggal_pinjam=CURDATE()", conn)
        Return Convert.ToInt32(cmd.ExecuteScalar())
    End Function

    Private Sub panelTersedia_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub panelHariIni_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub panelDipinjam_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub lblTotalBuku_Click(sender As Object, e As EventArgs) Handles lblTotalBuku.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New FromPinjambuku
        f.Show()
        Hide() '
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As New FormPengembalianBuku
        f.Show()
        Hide()
    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshDashboard()
        MessageBox.Show("Data dashboard berhasil diperbarui",
                        "Refresh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f As New FormDataTerlambat
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show(
       "Apakah Anda yakin ingin logout?",
       "Konfirmasi Logout",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Kembali ke Form Login
            FormLogin.Show()
            Me.Close()
        End If
    End Sub
End Class
