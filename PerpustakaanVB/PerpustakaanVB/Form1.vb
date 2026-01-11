
Imports System.Drawing.Drawing2D
Imports MySqlConnector


Public Class FormLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Username dan Password harus diisi", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Call Koneksi()
        cmd = New MySqlCommand(
        "SELECT * FROM users WHERE username=@u AND password=@p", conn)

        cmd.Parameters.AddWithValue("@u", txtUsername.Text)
        cmd.Parameters.AddWithValue("@p", txtPassword.Text)

        dr = cmd.ExecuteReader()

        If dr.Read() Then
            MessageBox.Show("Login berhasil", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' BUKA DASHBOARD
            Dim dash As New FormDashboard()
            dash.Show()

            ' TUTUP LOGIN
            Me.Hide()
        Else
            MessageBox.Show("Username atau Password salah", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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



    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        Dim f As New FormRegister
        f.Show()
        Hide()
    End Sub
End Class
