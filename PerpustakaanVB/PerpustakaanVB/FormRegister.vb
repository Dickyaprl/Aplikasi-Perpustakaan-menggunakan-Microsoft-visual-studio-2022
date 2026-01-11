Imports System.Drawing.Drawing2D
Imports MySqlConnector

Public Class FormRegister
    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Or txtKonfirmasi.Text = "" Then
            MessageBox.Show("Lengkapi semua data",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtPassword.Text <> txtKonfirmasi.Text Then
            MessageBox.Show("Password tidak sama",
                            "Kesalahan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Exit Sub
        End If
        Call Koneksi()

        Try
            Dim cmd As New MySqlCommand(
                "INSERT INTO users (username, password) VALUES (@u,@p)", conn)

            cmd.Parameters.AddWithValue("@u", txtUsername.Text)
            cmd.Parameters.AddWithValue("@p", txtPassword.Text) ' (nanti bisa di-hash)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Akun berhasil dibuat",
                            "Sukses",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            ' kembali ke login
            FormLogin.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Username sudah digunakan",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundedPanel(PanelCard, 30)
    End Sub
    Sub RoundedPanel(ByVal panel As Panel, ByVal radius As Integer)
        Dim path As New GraphicsPath
        path.StartFigure()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, panel.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()
        panel.Region = New Region(path)
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        FormLogin.Show()
        Me.Close()
    End Sub
End Class