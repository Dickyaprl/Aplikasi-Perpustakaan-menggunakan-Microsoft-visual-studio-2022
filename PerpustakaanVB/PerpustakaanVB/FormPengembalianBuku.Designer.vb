<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPengembalianBuku
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
        dgvPeminjaman = New DataGridView()
        Label1 = New Label()
        btnKembalikan = New Button()
        btnKembali = New Button()
        PictureBox1 = New PictureBox()
        CType(dgvPeminjaman, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvPeminjaman
        ' 
        dgvPeminjaman.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPeminjaman.BackgroundColor = Color.White
        dgvPeminjaman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPeminjaman.Location = New Point(359, -2)
        dgvPeminjaman.Name = "dgvPeminjaman"
        dgvPeminjaman.ReadOnly = True
        dgvPeminjaman.RowHeadersWidth = 51
        dgvPeminjaman.Size = New Size(671, 465)
        dgvPeminjaman.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(33, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(287, 28)
        Label1.TabIndex = 1
        Label1.Text = "DATA PENGEMBALIAN BUKU"
        ' 
        ' btnKembalikan
        ' 
        btnKembalikan.BackColor = Color.Yellow
        btnKembalikan.Location = New Point(67, 316)
        btnKembalikan.Name = "btnKembalikan"
        btnKembalikan.Size = New Size(204, 29)
        btnKembalikan.TabIndex = 2
        btnKembalikan.Text = "Kembalikan Buku"
        btnKembalikan.UseVisualStyleBackColor = False
        ' 
        ' btnKembali
        ' 
        btnKembali.Location = New Point(12, 421)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(94, 29)
        btnKembali.TabIndex = 3
        btnKembali.Text = "kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.bku
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(67, 121)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(204, 180)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' FormPengembalianBuku
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        ClientSize = New Size(1028, 462)
        Controls.Add(PictureBox1)
        Controls.Add(btnKembali)
        Controls.Add(btnKembalikan)
        Controls.Add(Label1)
        Controls.Add(dgvPeminjaman)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormPengembalianBuku"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormPengembalianBuku"
        CType(dgvPeminjaman, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvPeminjaman As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnKembalikan As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
