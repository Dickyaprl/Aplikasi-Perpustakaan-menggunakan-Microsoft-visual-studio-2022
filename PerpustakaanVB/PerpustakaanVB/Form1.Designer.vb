<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblJudul = New Label()
        btnLogin = New Button()
        btnDaftar = New Button()
        Panel1 = New Panel()
        PanelCard = New Panel()
        Label3 = New Label()
        Panel3 = New Panel()
        password = New Label()
        txtPassword = New TextBox()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        txtUsername = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(components)
        PictureBox3 = New PictureBox()
        Label4 = New Label()
        Label5 = New Label()
        Panel1.SuspendLayout()
        PanelCard.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(20, 30)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(95, 38)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Hello!"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        btnLogin.Location = New Point(43, 318)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(157, 58)
        btnLogin.TabIndex = 5
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnDaftar
        ' 
        btnDaftar.BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        btnDaftar.Location = New Point(227, 318)
        btnDaftar.Name = "btnDaftar"
        btnDaftar.Size = New Size(151, 58)
        btnDaftar.TabIndex = 6
        btnDaftar.Text = "DAFTAR"
        btnDaftar.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        Panel1.Controls.Add(PanelCard)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(468, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(632, 650)
        Panel1.TabIndex = 7
        ' 
        ' PanelCard
        ' 
        PanelCard.BackColor = Color.White
        PanelCard.Controls.Add(Label3)
        PanelCard.Controls.Add(Panel3)
        PanelCard.Controls.Add(Panel2)
        PanelCard.Controls.Add(btnDaftar)
        PanelCard.Controls.Add(lblJudul)
        PanelCard.Controls.Add(btnLogin)
        PanelCard.Location = New Point(132, 101)
        PanelCard.Name = "PanelCard"
        PanelCard.Size = New Size(427, 459)
        PanelCard.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(29, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(290, 28)
        Label3.TabIndex = 12
        Label3.Text = "Silahkan Login terlebih dahulu"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(password)
        Panel3.Controls.Add(txtPassword)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(PictureBox2)
        Panel3.Location = New Point(40, 231)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(349, 48)
        Panel3.TabIndex = 11
        ' 
        ' password
        ' 
        password.AutoSize = True
        password.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        password.Location = New Point(51, 17)
        password.Name = "password"
        password.Size = New Size(76, 20)
        password.TabIndex = 11
        password.Text = "password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(133, 11)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(208, 27)
        txtPassword.TabIndex = 10
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(54, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 20)
        Label2.TabIndex = 9
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = My.Resources.Resources.asaasas
        PictureBox2.Image = My.Resources.Resources.ASASASASAS
        PictureBox2.Location = New Point(3, 10)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(45, 35)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(txtUsername)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(40, 148)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(349, 48)
        Panel2.TabIndex = 7
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(133, 11)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(208, 27)
        txtUsername.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(51, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 9
        Label1.Text = "Username"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.asaasas
        PictureBox1.Image = My.Resources.Resources.asaasas
        PictureBox1.Location = New Point(3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(45, 40)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.bku
        PictureBox3.Location = New Point(109, 171)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(209, 247)
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(124, 439)
        Label4.Name = "Label4"
        Label4.Size = New Size(194, 38)
        Label4.TabIndex = 9
        Label4.Text = "Perpustakaan"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(157, 477)
        Label5.Name = "Label5"
        Label5.Size = New Size(123, 28)
        Label5.TabIndex = 10
        Label5.Text = "kelompok 5"
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1100, 650)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(PictureBox3)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel1.ResumeLayout(False)
        PanelCard.ResumeLayout(False)
        PanelCard.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnDaftar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelCard As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents password As Label
    Friend WithEvents Label5 As Label

End Class
