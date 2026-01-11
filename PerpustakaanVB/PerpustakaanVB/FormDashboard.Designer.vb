<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PanelSidebar = New Panel()
        Panel7 = New Panel()
        Label9 = New Label()
        Button3 = New Button()
        Panel2 = New Panel()
        Label4 = New Label()
        Button2 = New Button()
        Panel1 = New Panel()
        Label3 = New Label()
        Button1 = New Button()
        PanelBuku = New Panel()
        Label2 = New Label()
        btnBuku = New Button()
        Label1 = New Label()
        Panel3 = New Panel()
        btnRefresh = New Button()
        Panel6 = New Panel()
        lblBukuDipinjam = New Label()
        Label7 = New Label()
        Panel5 = New Panel()
        lblHariIni = New Label()
        Label6 = New Label()
        Panel4 = New Panel()
        lblBukuTersedia = New Label()
        Label8 = New Label()
        panelTotalBuku = New Panel()
        lblTotalBuku = New Label()
        Label5 = New Label()
        btnLogout = New Button()
        PanelSidebar.SuspendLayout()
        Panel7.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        PanelBuku.SuspendLayout()
        Panel3.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        panelTotalBuku.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelSidebar
        ' 
        PanelSidebar.BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        PanelSidebar.Controls.Add(Panel7)
        PanelSidebar.Controls.Add(Panel2)
        PanelSidebar.Controls.Add(Panel1)
        PanelSidebar.Controls.Add(PanelBuku)
        PanelSidebar.Controls.Add(Label1)
        PanelSidebar.Dock = DockStyle.Left
        PanelSidebar.ForeColor = Color.White
        PanelSidebar.Location = New Point(0, 0)
        PanelSidebar.Name = "PanelSidebar"
        PanelSidebar.Size = New Size(561, 603)
        PanelSidebar.TabIndex = 0
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Panel7.Controls.Add(Label9)
        Panel7.Controls.Add(Button3)
        Panel7.Location = New Point(281, 353)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(170, 150)
        Panel7.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.DarkRed
        Label9.Location = New Point(14, 119)
        Label9.Name = "Label9"
        Label9.Size = New Size(131, 20)
        Label9.TabIndex = 1
        Label9.Text = "DATA TERLAMBAT"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.BackgroundImage = My.Resources.Resources.accident_book
        Button3.BackgroundImageLayout = ImageLayout.Zoom
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Navy
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(25, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(121, 104)
        Button3.TabIndex = 0
        Button3.TextAlign = ContentAlignment.BottomLeft
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkTurquoise
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Button2)
        Panel2.Location = New Point(53, 353)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(170, 150)
        Panel2.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.DarkRed
        Label4.Location = New Point(12, 119)
        Label4.Name = "Label4"
        Label4.Size = New Size(160, 20)
        Label4.TabIndex = 1
        Label4.Text = "PENGEMBALIAN BUKU"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImage = My.Resources.Resources.KEMBALI
        Button2.BackgroundImageLayout = ImageLayout.Zoom
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Navy
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(28, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(121, 104)
        Button2.TabIndex = 0
        Button2.TextAlign = ContentAlignment.BottomLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(53, 174)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(170, 150)
        Panel1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(41, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 20)
        Label3.TabIndex = 1
        Label3.Text = "PINJAM BUKU"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = My.Resources.Resources.PINJAM_BUKU
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Navy
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(25, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(121, 104)
        Button1.TabIndex = 0
        Button1.TextAlign = ContentAlignment.BottomLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PanelBuku
        ' 
        PanelBuku.BackColor = Color.Navy
        PanelBuku.Controls.Add(Label2)
        PanelBuku.Controls.Add(btnBuku)
        PanelBuku.Location = New Point(281, 174)
        PanelBuku.Name = "PanelBuku"
        PanelBuku.Size = New Size(170, 150)
        PanelBuku.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(41, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 20)
        Label2.TabIndex = 1
        Label2.Text = "DATA BUKU"
        ' 
        ' btnBuku
        ' 
        btnBuku.BackColor = Color.Transparent
        btnBuku.BackgroundImage = My.Resources.Resources.icons8_book_94
        btnBuku.BackgroundImageLayout = ImageLayout.Zoom
        btnBuku.FlatStyle = FlatStyle.Flat
        btnBuku.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuku.ForeColor = Color.Navy
        btnBuku.ImageAlign = ContentAlignment.MiddleLeft
        btnBuku.Location = New Point(25, 12)
        btnBuku.Name = "btnBuku"
        btnBuku.Size = New Size(121, 104)
        btnBuku.TabIndex = 0
        btnBuku.TextAlign = ContentAlignment.BottomLeft
        btnBuku.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(123, 70)
        Label1.Name = "Label1"
        Label1.Size = New Size(266, 32)
        Label1.TabIndex = 0
        Label1.Text = "PERPUSTAKAAN"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(btnLogout)
        Panel3.Controls.Add(btnRefresh)
        Panel3.Controls.Add(Panel6)
        Panel3.Controls.Add(Panel5)
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(panelTotalBuku)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(561, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(521, 603)
        Panel3.TabIndex = 1
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.Cyan
        btnRefresh.Location = New Point(143, 515)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(94, 29)
        btnRefresh.TabIndex = 6
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(lblBukuDipinjam)
        Panel6.Controls.Add(Label7)
        Panel6.Location = New Point(77, 353)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(130, 101)
        Panel6.TabIndex = 5
        ' 
        ' lblBukuDipinjam
        ' 
        lblBukuDipinjam.AutoSize = True
        lblBukuDipinjam.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBukuDipinjam.Location = New Point(44, 19)
        lblBukuDipinjam.Name = "lblBukuDipinjam"
        lblBukuDipinjam.Size = New Size(40, 46)
        lblBukuDipinjam.TabIndex = 1
        lblBukuDipinjam.Text = "0"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 79)
        Label7.Name = "Label7"
        Label7.Size = New Size(106, 20)
        Label7.TabIndex = 4
        Label7.Text = "Buku Dipinjam"
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(lblHariIni)
        Panel5.Controls.Add(Label6)
        Panel5.Location = New Point(281, 353)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(130, 101)
        Panel5.TabIndex = 4
        ' 
        ' lblHariIni
        ' 
        lblHariIni.AutoSize = True
        lblHariIni.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHariIni.Location = New Point(44, 19)
        lblHariIni.Name = "lblHariIni"
        lblHariIni.Size = New Size(40, 46)
        lblHariIni.TabIndex = 1
        lblHariIni.Text = "0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(17, 77)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 20)
        Label6.TabIndex = 4
        Label6.Text = "Peminjaman"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(lblBukuTersedia)
        Panel4.Controls.Add(Label8)
        Panel4.Location = New Point(281, 189)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(130, 101)
        Panel4.TabIndex = 2
        ' 
        ' lblBukuTersedia
        ' 
        lblBukuTersedia.AutoSize = True
        lblBukuTersedia.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBukuTersedia.Location = New Point(44, 19)
        lblBukuTersedia.Name = "lblBukuTersedia"
        lblBukuTersedia.Size = New Size(40, 46)
        lblBukuTersedia.TabIndex = 1
        lblBukuTersedia.Text = "0"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(17, 73)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 20)
        Label8.TabIndex = 3
        Label8.Text = "Buku Tersedia"
        ' 
        ' panelTotalBuku
        ' 
        panelTotalBuku.Controls.Add(lblTotalBuku)
        panelTotalBuku.Controls.Add(Label5)
        panelTotalBuku.Location = New Point(77, 189)
        panelTotalBuku.Name = "panelTotalBuku"
        panelTotalBuku.Size = New Size(130, 101)
        panelTotalBuku.TabIndex = 0
        ' 
        ' lblTotalBuku
        ' 
        lblTotalBuku.AutoSize = True
        lblTotalBuku.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalBuku.Location = New Point(44, 19)
        lblTotalBuku.Name = "lblTotalBuku"
        lblTotalBuku.Size = New Size(40, 46)
        lblTotalBuku.TabIndex = 1
        lblTotalBuku.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(26, 75)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 20)
        Label5.TabIndex = 0
        Label5.Text = "Total Buku"
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnLogout.Location = New Point(254, 515)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(94, 29)
        btnLogout.TabIndex = 7
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1082, 603)
        Controls.Add(Panel3)
        Controls.Add(PanelSidebar)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        PanelSidebar.ResumeLayout(False)
        PanelSidebar.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        PanelBuku.ResumeLayout(False)
        PanelBuku.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        panelTotalBuku.ResumeLayout(False)
        panelTotalBuku.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelSidebar As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuku As Button
    Friend WithEvents PanelBuku As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents panelTotalBuku As Panel
    Friend WithEvents lblTotalBuku As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblBukuTersedia As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblHariIni As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblBukuDipinjam As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnLogout As Button
End Class
