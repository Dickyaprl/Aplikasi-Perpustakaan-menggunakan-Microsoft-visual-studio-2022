<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataTerlambat
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
        Label1 = New Label()
        MySqlDataAdapter1 = New MySqlConnector.MySqlDataAdapter()
        dgvTerlambat = New DataGridView()
        btnKembali = New Button()
        CType(dgvTerlambat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Palatino Linotype", 13.8F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(275, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(510, 31)
        Label1.TabIndex = 0
        Label1.Text = "DATA TERLAMBAT PENGEMBALIAN BUKU"
        ' 
        ' MySqlDataAdapter1
        ' 
        MySqlDataAdapter1.DeleteCommand = Nothing
        MySqlDataAdapter1.InsertCommand = Nothing
        MySqlDataAdapter1.SelectCommand = Nothing
        MySqlDataAdapter1.UpdateBatchSize = 0
        MySqlDataAdapter1.UpdateCommand = Nothing
        ' 
        ' dgvTerlambat
        ' 
        dgvTerlambat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvTerlambat.BackgroundColor = Color.White
        dgvTerlambat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTerlambat.Location = New Point(118, 108)
        dgvTerlambat.Name = "dgvTerlambat"
        dgvTerlambat.ReadOnly = True
        dgvTerlambat.RowHeadersWidth = 51
        dgvTerlambat.Size = New Size(791, 281)
        dgvTerlambat.TabIndex = 1
        ' 
        ' btnKembali
        ' 
        btnKembali.Location = New Point(21, 421)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(94, 29)
        btnKembali.TabIndex = 2
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' FormDataTerlambat
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(13), CByte(110), CByte(253))
        ClientSize = New Size(1028, 471)
        Controls.Add(btnKembali)
        Controls.Add(dgvTerlambat)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FormDataTerlambat"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormDataTerlambat"
        CType(dgvTerlambat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MySqlDataAdapter1 As MySqlConnector.MySqlDataAdapter
    Friend WithEvents dgvTerlambat As DataGridView
    Friend WithEvents btnKembali As Button
End Class
