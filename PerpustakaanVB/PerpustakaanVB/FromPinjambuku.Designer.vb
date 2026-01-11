<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FromPinjambuku
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
        dgvBuku = New DataGridView()
        PictureBox1 = New PictureBox()
        MySqlCommand1 = New MySqlConnector.MySqlCommand()
        Label1 = New Label()
        txtNama = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        txtNIM = New TextBox()
        txtProdi = New TextBox()
        btnPinjam = New Button()
        btnKembali = New Button()
        Label4 = New Label()
        txtCari = New TextBox()
        dtPinjam = New DateTimePicker()
        dtSelesai = New DateTimePicker()
        Label5 = New Label()
        Label6 = New Label()
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvBuku
        ' 
        dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBuku.BackgroundColor = Color.White
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Location = New Point(114, 170)
        dgvBuku.Name = "dgvBuku"
        dgvBuku.ReadOnly = True
        dgvBuku.RowHeadersWidth = 51
        dgvBuku.Size = New Size(855, 301)
        dgvBuku.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.bku
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(28, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(186, 121)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CommandTimeout = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.Transaction = Nothing
        MySqlCommand1.UpdatedRowSource = UpdateRowSource.None
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(240, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 20)
        Label1.TabIndex = 2
        Label1.Text = "Nama Peminjam"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(364, 40)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(187, 27)
        txtNama.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(557, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 20)
        Label2.TabIndex = 4
        Label2.Text = "NIM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(731, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 5
        Label3.Text = "Prodi"
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(600, 40)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(125, 27)
        txtNIM.TabIndex = 6
        ' 
        ' txtProdi
        ' 
        txtProdi.Location = New Point(781, 43)
        txtProdi.Name = "txtProdi"
        txtProdi.Size = New Size(125, 27)
        txtProdi.TabIndex = 7
        ' 
        ' btnPinjam
        ' 
        btnPinjam.BackColor = Color.Yellow
        btnPinjam.Location = New Point(364, 126)
        btnPinjam.Name = "btnPinjam"
        btnPinjam.Size = New Size(94, 29)
        btnPinjam.TabIndex = 8
        btnPinjam.Text = "Pinjam"
        btnPinjam.UseVisualStyleBackColor = False
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.White
        btnKembali.Location = New Point(12, 468)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(94, 29)
        btnKembali.TabIndex = 9
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(323, 81)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 20)
        Label4.TabIndex = 10
        Label4.Text = "Cari"
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(364, 84)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(164, 27)
        txtCari.TabIndex = 11
        ' 
        ' dtPinjam
        ' 
        dtPinjam.Enabled = False
        dtPinjam.Format = DateTimePickerFormat.Short
        dtPinjam.Location = New Point(661, 84)
        dtPinjam.Name = "dtPinjam"
        dtPinjam.Size = New Size(89, 27)
        dtPinjam.TabIndex = 12
        ' 
        ' dtSelesai
        ' 
        dtSelesai.Format = DateTimePickerFormat.Short
        dtSelesai.Location = New Point(866, 82)
        dtSelesai.Name = "dtSelesai"
        dtSelesai.Size = New Size(89, 27)
        dtSelesai.TabIndex = 13
        dtSelesai.Value = New Date(2025, 12, 28, 0, 0, 0, 0)
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(545, 87)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 20)
        Label5.TabIndex = 14
        Label5.Text = "Tanggal Pinjam"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(756, 87)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 20)
        Label6.TabIndex = 15
        Label6.Text = "Selesai Pinjam"
        ' 
        ' FromPinjambuku
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        ClientSize = New Size(1046, 509)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(dtSelesai)
        Controls.Add(dtPinjam)
        Controls.Add(txtCari)
        Controls.Add(Label4)
        Controls.Add(btnKembali)
        Controls.Add(btnPinjam)
        Controls.Add(txtProdi)
        Controls.Add(txtNIM)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtNama)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(dgvBuku)
        FormBorderStyle = FormBorderStyle.None
        Name = "FromPinjambuku"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FromPinjambuku"
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MySqlCommand1 As MySqlConnector.MySqlCommand
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents txtProdi As TextBox
    Friend WithEvents btnPinjam As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents dtPinjam As DateTimePicker
    Friend WithEvents dtSelesai As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
