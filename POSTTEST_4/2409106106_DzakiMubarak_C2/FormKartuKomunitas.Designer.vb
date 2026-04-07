<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKartuKomunitas
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControlKartu = New System.Windows.Forms.TabControl()
        Me.TabPageKartu = New System.Windows.Forms.TabPage()
        Me.PanelKartu = New System.Windows.Forms.Panel()
        Me.LabelAlamat = New System.Windows.Forms.Label()
        Me.LabelHobby = New System.Windows.Forms.Label()
        Me.LabelKontak = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelPeran = New System.Windows.Forms.Label()
        Me.LabelKomunitas = New System.Windows.Forms.Label()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.LabelTanggal = New System.Windows.Forms.Label()
        Me.PictureBoxFoto = New System.Windows.Forms.PictureBox()
        Me.LabelJudul = New System.Windows.Forms.Label()
        Me.TabPageRingkasan = New System.Windows.Forms.TabPage()
        Me.TextBoxRingkasan = New System.Windows.Forms.TextBox()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.TabControlKartu.SuspendLayout()
        Me.TabPageKartu.SuspendLayout()
        Me.PanelKartu.SuspendLayout()
        CType(Me.PictureBoxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageRingkasan.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' TabControlKartu
        ' 
        Me.TabControlKartu.Controls.Add(Me.TabPageKartu)
        Me.TabControlKartu.Controls.Add(Me.TabPageRingkasan)
        Me.TabControlKartu.Location = New System.Drawing.Point(12, 12)
        Me.TabControlKartu.Name = "TabControlKartu"
        Me.TabControlKartu.SelectedIndex = 0
        Me.TabControlKartu.Size = New System.Drawing.Size(560, 400)
        Me.TabControlKartu.TabIndex = 0
        ' 
        ' TabPageKartu
        ' 
        Me.TabPageKartu.Controls.Add(Me.PanelKartu)
        Me.TabPageKartu.Location = New System.Drawing.Point(4, 22)
        Me.TabPageKartu.Name = "TabPageKartu"
        Me.TabPageKartu.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageKartu.Size = New System.Drawing.Size(552, 374)
        Me.TabPageKartu.TabIndex = 0
        Me.TabPageKartu.Text = "Kartu Digital"
        Me.TabPageKartu.UseVisualStyleBackColor = True
        ' 
        ' PanelKartu
        ' 
        Me.PanelKartu.BackColor = System.Drawing.Color.FromArgb(255, 255, 192)
        Me.PanelKartu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelKartu.Controls.Add(Me.LabelAlamat)
        Me.PanelKartu.Controls.Add(Me.LabelHobby)
        Me.PanelKartu.Controls.Add(Me.LabelKontak)
        Me.PanelKartu.Controls.Add(Me.LabelEmail)
        Me.PanelKartu.Controls.Add(Me.LabelPeran)
        Me.PanelKartu.Controls.Add(Me.LabelKomunitas)
        Me.PanelKartu.Controls.Add(Me.LabelID)
        Me.PanelKartu.Controls.Add(Me.LabelNama)
        Me.PanelKartu.Controls.Add(Me.LabelTanggal)
        Me.PanelKartu.Controls.Add(Me.PictureBoxFoto)
        Me.PanelKartu.Controls.Add(Me.LabelJudul)
        Me.PanelKartu.Location = New System.Drawing.Point(15, 15)
        Me.PanelKartu.Name = "PanelKartu"
        Me.PanelKartu.Size = New System.Drawing.Size(520, 340)
        Me.PanelKartu.TabIndex = 0
        ' 
        ' LabelAlamat
        ' 
        Me.LabelAlamat.AutoSize = True
        Me.LabelAlamat.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.LabelAlamat.Location = New System.Drawing.Point(30, 270)
        Me.LabelAlamat.MaximumSize = New System.Drawing.Size(400, 0)
        Me.LabelAlamat.Name = "LabelAlamat"
        Me.LabelAlamat.Size = New System.Drawing.Size(52, 15)
        Me.LabelAlamat.TabIndex = 10
        Me.LabelAlamat.Text = "Alamat: "
        ' 
        ' LabelHobby
        ' 
        Me.LabelHobby.AutoSize = True
        Me.LabelHobby.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.LabelHobby.Location = New System.Drawing.Point(30, 240)
        Me.LabelHobby.MaximumSize = New System.Drawing.Size(450, 0)
        Me.LabelHobby.Name = "LabelHobby"
        Me.LabelHobby.Size = New System.Drawing.Size(44, 15)
        Me.LabelHobby.TabIndex = 9
        Me.LabelHobby.Text = "Hobby:"
        ' 
        ' LabelKontak
        ' 
        Me.LabelKontak.AutoSize = True
        Me.LabelKontak.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.LabelKontak.Location = New System.Drawing.Point(30, 210)
        Me.LabelKontak.Name = "LabelKontak"
        Me.LabelKontak.Size = New System.Drawing.Size(49, 15)
        Me.LabelKontak.TabIndex = 8
        Me.LabelKontak.Text = "Kontak:"
        ' 
        ' LabelEmail
        ' 
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.LabelEmail.Location = New System.Drawing.Point(30, 180)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(42, 15)
        Me.LabelEmail.TabIndex = 7
        Me.LabelEmail.Text = "Email:"
        ' 
        ' LabelPeran
        ' 
        Me.LabelPeran.AutoSize = True
        Me.LabelPeran.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.LabelPeran.Location = New System.Drawing.Point(150, 150)
        Me.LabelPeran.Name = "LabelPeran"
        Me.LabelPeran.Size = New System.Drawing.Size(43, 15)
        Me.LabelPeran.TabIndex = 6
        Me.LabelPeran.Text = "Peran:"
        ' 
        ' LabelKomunitas
        ' 
        Me.LabelKomunitas.AutoSize = True
        Me.LabelKomunitas.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.LabelKomunitas.Location = New System.Drawing.Point(150, 120)
        Me.LabelKomunitas.Name = "LabelKomunitas"
        Me.LabelKomunitas.Size = New System.Drawing.Size(70, 15)
        Me.LabelKomunitas.TabIndex = 5
        Me.LabelKomunitas.Text = "Komunitas:"
        ' 
        ' LabelID
        ' 
        Me.LabelID.AutoSize = True
        Me.LabelID.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.LabelID.Location = New System.Drawing.Point(150, 90)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(23, 15)
        Me.LabelID.TabIndex = 4
        Me.LabelID.Text = "ID:"
        ' 
        ' LabelNama
        ' 
        Me.LabelNama.AutoSize = True
        Me.LabelNama.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelNama.Location = New System.Drawing.Point(150, 60)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(53, 16)
        Me.LabelNama.TabIndex = 3
        Me.LabelNama.Text = "Nama:"
        ' 
        ' LabelTanggal
        ' 
        Me.LabelTanggal.AutoSize = True
        Me.LabelTanggal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Italic)
        Me.LabelTanggal.Location = New System.Drawing.Point(30, 310)
        Me.LabelTanggal.Name = "LabelTanggal"
        Me.LabelTanggal.Size = New System.Drawing.Size(0, 14)
        Me.LabelTanggal.TabIndex = 2
        ' 
        ' PictureBoxFoto
        ' 
        Me.PictureBoxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxFoto.Location = New System.Drawing.Point(30, 60)
        Me.PictureBoxFoto.Name = "PictureBoxFoto"
        Me.PictureBoxFoto.Size = New System.Drawing.Size(100, 100)
        Me.PictureBoxFoto.TabIndex = 1
        Me.PictureBoxFoto.TabStop = False
        ' 
        ' LabelJudul
        ' 
        Me.LabelJudul.AutoSize = True
        Me.LabelJudul.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LabelJudul.ForeColor = System.Drawing.Color.DarkBlue
        Me.LabelJudul.Location = New System.Drawing.Point(150, 20)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(210, 26)
        Me.LabelJudul.TabIndex = 0
        Me.LabelJudul.Text = "KARTU KOMUNITAS"
        ' 
        ' TabPageRingkasan
        ' 
        Me.TabPageRingkasan.Controls.Add(Me.TextBoxRingkasan)
        Me.TabPageRingkasan.Location = New System.Drawing.Point(4, 22)
        Me.TabPageRingkasan.Name = "TabPageRingkasan"
        Me.TabPageRingkasan.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageRingkasan.Size = New System.Drawing.Size(552, 374)
        Me.TabPageRingkasan.TabIndex = 1
        Me.TabPageRingkasan.Text = "Ringkasan Data"
        Me.TabPageRingkasan.UseVisualStyleBackColor = True
        ' 
        ' TextBoxRingkasan
        ' 
        Me.TextBoxRingkasan.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.TextBoxRingkasan.Location = New System.Drawing.Point(20, 20)
        Me.TextBoxRingkasan.Multiline = True
        Me.TextBoxRingkasan.Name = "TextBoxRingkasan"
        Me.TextBoxRingkasan.ReadOnly = True
        Me.TextBoxRingkasan.Size = New System.Drawing.Size(512, 330)
        Me.TextBoxRingkasan.TabIndex = 0
        ' 
        ' btnCetak
        ' 
        Me.btnCetak.BackColor = System.Drawing.Color.Green
        Me.btnCetak.ForeColor = System.Drawing.Color.White
        Me.btnCetak.Location = New System.Drawing.Point(180, 430)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(100, 35)
        Me.btnCetak.TabIndex = 1
        Me.btnCetak.Text = "Cetak Kartu"
        Me.btnCetak.UseVisualStyleBackColor = False
        ' 
        ' btnTutup
        ' 
        Me.btnTutup.BackColor = System.Drawing.Color.Red
        Me.btnTutup.ForeColor = System.Drawing.Color.White
        Me.btnTutup.Location = New System.Drawing.Point(300, 430)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(100, 35)
        Me.btnTutup.TabIndex = 2
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = False
        ' 
        ' FormKartuKomunitas
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 481)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.TabControlKartu)
        Me.Name = "FormKartuKomunitas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kartu Komunitas"
        Me.TabControlKartu.ResumeLayout(False)
        Me.TabPageKartu.ResumeLayout(False)
        Me.PanelKartu.ResumeLayout(False)
        Me.PanelKartu.PerformLayout()
        CType(Me.PictureBoxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageRingkasan.ResumeLayout(False)
        Me.TabPageRingkasan.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents TabControlKartu As TabControl
    Friend WithEvents TabPageKartu As TabPage
    Friend WithEvents TabPageRingkasan As TabPage
    Friend WithEvents PanelKartu As Panel
    Friend WithEvents LabelJudul As Label
    Friend WithEvents PictureBoxFoto As PictureBox
    Friend WithEvents LabelTanggal As Label
    Friend WithEvents LabelNama As Label
    Friend WithEvents LabelID As Label
    Friend WithEvents LabelKomunitas As Label
    Friend WithEvents LabelPeran As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelKontak As Label
    Friend WithEvents LabelHobby As Label
    Friend WithEvents LabelAlamat As Label
    Friend WithEvents TextBoxRingkasan As TextBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnTutup As Button
End Class
