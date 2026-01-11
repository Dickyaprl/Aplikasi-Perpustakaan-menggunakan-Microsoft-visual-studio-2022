<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegister
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
        PanelCard = New Panel()
        btnKembali = New Button()
        btnDaftar = New Button()
        txtKonfirmasi = New TextBox()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PanelCard.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelCard
        ' 
        PanelCard.BackColor = Color.White
        PanelCard.Controls.Add(btnKembali)
        PanelCard.Controls.Add(btnDaftar)
        PanelCard.Controls.Add(txtKonfirmasi)
        PanelCard.Controls.Add(txtPassword)
        PanelCard.Controls.Add(txtUsername)
        PanelCard.Controls.Add(Label4)
        PanelCard.Controls.Add(Label3)
        PanelCard.Controls.Add(Label2)
        PanelCard.Controls.Add(Label1)
        PanelCard.Location = New Point(282, 47)
        PanelCard.Name = "PanelCard"
        PanelCard.Size = New Size(408, 491)
        PanelCard.TabIndex = 0
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.Cyan
        btnKembali.Location = New Point(248, 358)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(94, 29)
        btnKembali.TabIndex = 8
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' btnDaftar
        ' 
        btnDaftar.BackColor = Color.Lime
        btnDaftar.Location = New Point(117, 358)
        btnDaftar.Name = "btnDaftar"
        btnDaftar.Size = New Size(94, 29)
        btnDaftar.TabIndex = 7
        btnDaftar.Text = "Daftar"
        btnDaftar.UseVisualStyleBackColor = False
        ' 
        ' txtKonfirmasi
        ' 
        txtKonfirmasi.Location = New Point(145, 269)
        txtKonfirmasi.Name = "txtKonfirmasi"
        txtKonfirmasi.Size = New Size(197, 27)
        txtKonfirmasi.TabIndex = 6
        txtKonfirmasi.UseSystemPasswordChar = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(145, 183)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(197, 27)
        txtPassword.TabIndex = 5
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(145, 100)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(197, 27)
        txtUsername.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(44, 272)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 3
        Label4.Text = "Konfirmasi"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(54, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 20)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(54, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 20)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Alef", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(145, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 31)
        Label1.TabIndex = 0
        Label1.Text = "Buat Akun"
        ' 
        ' FormRegister
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        ClientSize = New Size(1100, 650)
        Controls.Add(PanelCard)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormRegister"
        PanelCard.ResumeLayout(False)
        PanelCard.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelCard As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKonfirmasi As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnKembali As Button
    Friend WithEvents btnDaftar As Button
End Class
