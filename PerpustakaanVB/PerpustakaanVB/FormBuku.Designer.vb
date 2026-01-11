<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuku
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
        btnKembali = New Button()
        Label1 = New Label()
        btnHapus = New Button()
        btnEdit = New Button()
        btnTambah = New Button()
        lblCari = New Label()
        txtCari = New TextBox()
        btnCari = New Button()
        Label3 = New Label()
        txtJudul = New TextBox()
        txtPengarang = New TextBox()
        Label2 = New Label()
        txtPenerbit = New TextBox()
        Tex = New Label()
        txtTahun = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        txtStok = New TextBox()
        txtKode = New TextBox()
        Label6 = New Label()
        CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvBuku
        ' 
        dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvBuku.BackgroundColor = Color.WhiteSmoke
        dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBuku.Location = New Point(77, 191)
        dgvBuku.Name = "dgvBuku"
        dgvBuku.ReadOnly = True
        dgvBuku.RowHeadersWidth = 51
        dgvBuku.Size = New Size(882, 306)
        dgvBuku.TabIndex = 0
        ' 
        ' btnKembali
        ' 
        btnKembali.FlatStyle = FlatStyle.System
        btnKembali.Location = New Point(740, 515)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(94, 29)
        btnKembali.TabIndex = 1
        btnKembali.Text = "kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(430, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(206, 31)
        Label1.TabIndex = 2
        Label1.Text = "DATA DATA BUKU"
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        btnHapus.FlatStyle = FlatStyle.System
        btnHapus.ForeColor = Color.Black
        btnHapus.Location = New Point(341, 515)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 3
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(0))
        btnEdit.FlatStyle = FlatStyle.System
        btnEdit.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.ForeColor = Color.Black
        btnEdit.Location = New Point(210, 515)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(94, 29)
        btnEdit.TabIndex = 4
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnTambah
        ' 
        btnTambah.FlatStyle = FlatStyle.System
        btnTambah.Location = New Point(474, 515)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 5
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' lblCari
        ' 
        lblCari.AutoSize = True
        lblCari.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCari.Location = New Point(89, 80)
        lblCari.Name = "lblCari"
        lblCari.Size = New Size(76, 20)
        lblCari.TabIndex = 6
        lblCari.Text = "Cari Buku"
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(166, 76)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(176, 27)
        txtCari.TabIndex = 7
        ' 
        ' btnCari
        ' 
        btnCari.FlatStyle = FlatStyle.System
        btnCari.Location = New Point(610, 515)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(94, 29)
        btnCari.TabIndex = 8
        btnCari.Text = "Cari"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(348, 79)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 20)
        Label3.TabIndex = 11
        Label3.Text = "Judul Buku"
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(438, 75)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(176, 27)
        txtJudul.TabIndex = 12
        ' 
        ' txtPengarang
        ' 
        txtPengarang.Location = New Point(710, 75)
        txtPengarang.Name = "txtPengarang"
        txtPengarang.Size = New Size(176, 27)
        txtPengarang.TabIndex = 14
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(92, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 20)
        Label2.TabIndex = 15
        Label2.Text = "Penerbit"
        ' 
        ' txtPenerbit
        ' 
        txtPenerbit.Location = New Point(166, 132)
        txtPenerbit.Name = "txtPenerbit"
        txtPenerbit.Size = New Size(176, 27)
        txtPenerbit.TabIndex = 16
        ' 
        ' Tex
        ' 
        Tex.AutoSize = True
        Tex.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Tex.Location = New Point(348, 139)
        Tex.Name = "Tex"
        Tex.Size = New Size(52, 20)
        Tex.TabIndex = 17
        Tex.Text = "Tahun"
        ' 
        ' txtTahun
        ' 
        txtTahun.Location = New Point(406, 132)
        txtTahun.Name = "txtTahun"
        txtTahun.Size = New Size(113, 27)
        txtTahun.TabIndex = 18
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(620, 80)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 20)
        Label4.TabIndex = 13
        Label4.Text = "Pengarang"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(528, 135)
        Label5.Name = "Label5"
        Label5.Size = New Size(40, 20)
        Label5.TabIndex = 19
        Label5.Text = "Stok"
        ' 
        ' txtStok
        ' 
        txtStok.Location = New Point(574, 132)
        txtStok.Name = "txtStok"
        txtStok.Size = New Size(105, 27)
        txtStok.TabIndex = 20
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(736, 132)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(105, 27)
        txtKode.TabIndex = 21
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(685, 135)
        Label6.Name = "Label6"
        Label6.Size = New Size(45, 20)
        Label6.TabIndex = 22
        Label6.Text = "Kode"
        ' 
        ' FormBuku
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        ClientSize = New Size(1064, 556)
        Controls.Add(Label6)
        Controls.Add(txtKode)
        Controls.Add(txtStok)
        Controls.Add(Label5)
        Controls.Add(txtTahun)
        Controls.Add(Tex)
        Controls.Add(txtPenerbit)
        Controls.Add(Label2)
        Controls.Add(txtPengarang)
        Controls.Add(Label4)
        Controls.Add(txtJudul)
        Controls.Add(Label3)
        Controls.Add(btnCari)
        Controls.Add(txtCari)
        Controls.Add(lblCari)
        Controls.Add(btnTambah)
        Controls.Add(btnEdit)
        Controls.Add(btnHapus)
        Controls.Add(Label1)
        Controls.Add(btnKembali)
        Controls.Add(dgvBuku)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormBuku"
        StartPosition = FormStartPosition.CenterScreen
        Text = "x`"
        CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvBuku As DataGridView
    Friend WithEvents btnKembali As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents lblCari As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtPengarang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPenerbit As TextBox
    Friend WithEvents Tex As Label
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStok As TextBox
    Friend WithEvents txtKode As TextBox
    Friend WithEvents Label6 As Label
End Class
