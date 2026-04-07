<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInputData
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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ComboBoxDivisi = New System.Windows.Forms.ComboBox()
        Me.LabelDivisi = New System.Windows.Forms.Label()
        Me.RadioPerempuan = New System.Windows.Forms.RadioButton()
        Me.RadioLaki = New System.Windows.Forms.RadioButton()
        Me.LabelJK = New System.Windows.Forms.Label()
        Me.DateTimePickerTglLahir = New System.Windows.Forms.DateTimePicker()
        Me.LabelTglLahir = New System.Windows.Forms.Label()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MaskedTextBoxTelepon = New System.Windows.Forms.MaskedTextBox()
        Me.TextBoxAlamat = New System.Windows.Forms.TextBox()
        Me.LabelAlamat = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelTelepon = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpanCetak = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.PictureBoxFoto = New System.Windows.Forms.PictureBox()
        Me.GroupBoxHobby = New System.Windows.Forms.GroupBox()
        Me.CheckBoxFotografi = New System.Windows.Forms.CheckBox()
        Me.CheckBoxGaming = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCoding = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMenari = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMenyanyi = New System.Windows.Forms.CheckBox()
        Me.CheckBoxOlahraga = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTraveling = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMemancing = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMembaca = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMenulis = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMenggambar = New System.Windows.Forms.CheckBox()
        Me.GroupBoxPeran = New System.Windows.Forms.GroupBox()
        Me.ComboBoxPeran = New System.Windows.Forms.ComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBoxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxHobby.SuspendLayout()
        Me.GroupBoxPeran.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' TabControl1
        ' 
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(620, 400)
        Me.TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        Me.TabPage1.Controls.Add(Me.ComboBoxDivisi)
        Me.TabPage1.Controls.Add(Me.LabelDivisi)
        Me.TabPage1.Controls.Add(Me.RadioPerempuan)
        Me.TabPage1.Controls.Add(Me.RadioLaki)
        Me.TabPage1.Controls.Add(Me.LabelJK)
        Me.TabPage1.Controls.Add(Me.DateTimePickerTglLahir)
        Me.TabPage1.Controls.Add(Me.LabelTglLahir)
        Me.TabPage1.Controls.Add(Me.TextBoxID)
        Me.TabPage1.Controls.Add(Me.LabelID)
        Me.TabPage1.Controls.Add(Me.TextBoxNama)
        Me.TabPage1.Controls.Add(Me.LabelNama)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(612, 374)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data Utama"
        Me.TabPage1.UseVisualStyleBackColor = True
        ' 
        ' ComboBoxDivisi
        ' 
        Me.ComboBoxDivisi.FormattingEnabled = True
        Me.ComboBoxDivisi.Location = New System.Drawing.Point(150, 210)
        Me.ComboBoxDivisi.Name = "ComboBoxDivisi"
        Me.ComboBoxDivisi.Size = New System.Drawing.Size(250, 21)
        Me.ComboBoxDivisi.TabIndex = 10
        ' 
        ' LabelDivisi
        ' 
        Me.LabelDivisi.AutoSize = True
        Me.LabelDivisi.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LabelDivisi.Location = New System.Drawing.Point(50, 213)
        Me.LabelDivisi.Name = "LabelDivisi"
        Me.LabelDivisi.Size = New System.Drawing.Size(89, 16)
        Me.LabelDivisi.TabIndex = 9
        Me.LabelDivisi.Text = "Komunitas:"
        ' 
        ' RadioPerempuan
        ' 
        Me.RadioPerempuan.AutoSize = True
        Me.RadioPerempuan.Location = New System.Drawing.Point(250, 170)
        Me.RadioPerempuan.Name = "RadioPerempuan"
        Me.RadioPerempuan.Size = New System.Drawing.Size(85, 17)
        Me.RadioPerempuan.TabIndex = 8
        Me.RadioPerempuan.TabStop = True
        Me.RadioPerempuan.Text = "Perempuan"
        Me.RadioPerempuan.UseVisualStyleBackColor = True
        ' 
        ' RadioLaki
        ' 
        Me.RadioLaki.AutoSize = True
        Me.RadioLaki.Location = New System.Drawing.Point(150, 170)
        Me.RadioLaki.Name = "RadioLaki"
        Me.RadioLaki.Size = New System.Drawing.Size(80, 17)
        Me.RadioLaki.TabIndex = 7
        Me.RadioLaki.TabStop = True
        Me.RadioLaki.Text = "Laki-laki"
        Me.RadioLaki.UseVisualStyleBackColor = True
        ' 
        ' LabelJK
        ' 
        Me.LabelJK.AutoSize = True
        Me.LabelJK.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LabelJK.Location = New System.Drawing.Point(50, 170)
        Me.LabelJK.Name = "LabelJK"
        Me.LabelJK.Size = New System.Drawing.Size(88, 16)
        Me.LabelJK.TabIndex = 6
        Me.LabelJK.Text = "Jenis Kelamin:"
        ' 
        ' DateTimePickerTglLahir
        ' 
        Me.DateTimePickerTglLahir.Location = New System.Drawing.Point(150, 130)
        Me.DateTimePickerTglLahir.Name = "DateTimePickerTglLahir"
        Me.DateTimePickerTglLahir.Size = New System.Drawing.Size(250, 20)
        Me.DateTimePickerTglLahir.TabIndex = 5
        ' 
        ' LabelTglLahir
        ' 
        Me.LabelTglLahir.AutoSize = True
        Me.LabelTglLahir.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LabelTglLahir.Location = New System.Drawing.Point(50, 133)
        Me.LabelTglLahir.Name = "LabelTglLahir"
        Me.LabelTglLahir.Size = New System.Drawing.Size(90, 16)
        Me.LabelTglLahir.TabIndex = 4
        Me.LabelTglLahir.Text = "Tanggal Lahir:"
        ' 
        ' TextBoxID
        ' 
        Me.TextBoxID.Location = New System.Drawing.Point(150, 90)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(250, 20)
        Me.TextBoxID.TabIndex = 3
        ' 
        ' LabelID
        ' 
        Me.LabelID.AutoSize = True
        Me.LabelID.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LabelID.Location = New System.Drawing.Point(50, 93)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(74, 16)
        Me.LabelID.TabIndex = 2
        Me.LabelID.Text = "ID Anggota:"
        ' 
        ' TextBoxNama
        ' 
        Me.TextBoxNama.Location = New System.Drawing.Point(150, 50)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(250, 20)
        Me.TextBoxNama.TabIndex = 1
        ' 
        ' LabelNama
        ' 
        Me.LabelNama.AutoSize = True
        Me.LabelNama.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LabelNama.Location = New System.Drawing.Point(50, 53)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(49, 16)
        Me.LabelNama.TabIndex = 0
        Me.LabelNama.Text = "Nama:"
        ' 
        ' TabPage2
        ' 
        Me.TabPage2.Controls.Add(Me.MaskedTextBoxTelepon)
        Me.TabPage2.Controls.Add(Me.TextBoxAlamat)
        Me.TabPage2.Controls.Add(Me.LabelAlamat)
        Me.TabPage2.Controls.Add(Me.TextBoxEmail)
        Me.TabPage2.Controls.Add(Me.LabelEmail)
        Me.TabPage2.Controls.Add(Me.LabelTelepon)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(612, 374)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Kontak & Info"
        Me.TabPage2.UseVisualStyleBackColor = True
        ' 
        ' MaskedTextBoxTelepon
        ' 
        Me.MaskedTextBoxTelepon.Location = New System.Drawing.Point(150, 50)
        Me.MaskedTextBoxTelepon.Name = "MaskedTextBoxTelepon"
        Me.MaskedTextBoxTelepon.Size = New System.Drawing.Size(250, 20)
        Me.MaskedTextBoxTelepon.TabIndex = 6
        ' 
        ' TextBoxAlamat
        ' 
        Me.TextBoxAlamat.Location = New System.Drawing.Point(150, 130)
        Me.TextBoxAlamat.Multiline = True
        Me.TextBoxAlamat.Name = "TextBoxAlamat"
        Me.TextBoxAlamat.Size = New System.Drawing.Size(250, 60)
        Me.TextBoxAlamat.TabIndex = 5
        ' 
        ' LabelAlamat
        ' 
        Me.LabelAlamat.AutoSize = True
        Me.LabelAlamat.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LabelAlamat.Location = New System.Drawing.Point(50, 133)
        Me.LabelAlamat.Name = "LabelAlamat"
        Me.LabelAlamat.Size = New System.Drawing.Size(55, 16)
        Me.LabelAlamat.TabIndex = 4
        Me.LabelAlamat.Text = "Alamat:"
        ' 
        ' TextBoxEmail
        ' 
        Me.TextBoxEmail.Location = New System.Drawing.Point(150, 90)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(250, 20)
        Me.TextBoxEmail.TabIndex = 3
        ' 
        ' LabelEmail
        ' 
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LabelEmail.Location = New System.Drawing.Point(50, 93)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(46, 16)
        Me.LabelEmail.TabIndex = 2
        Me.LabelEmail.Text = "Email:"
        ' 
        ' LabelTelepon
        ' 
        Me.LabelTelepon.AutoSize = True
        Me.LabelTelepon.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LabelTelepon.Location = New System.Drawing.Point(50, 53)
        Me.LabelTelepon.Name = "LabelTelepon"
        Me.LabelTelepon.Size = New System.Drawing.Size(96, 16)
        Me.LabelTelepon.TabIndex = 0
        Me.LabelTelepon.Text = "Nomor Telepon:"
        ' 
        ' TabPage3
        ' 
        Me.TabPage3.Controls.Add(Me.btnBatal)
        Me.TabPage3.Controls.Add(Me.btnSimpanCetak)
        Me.TabPage3.Controls.Add(Me.btnBrowse)
        Me.TabPage3.Controls.Add(Me.PictureBoxFoto)
        Me.TabPage3.Controls.Add(Me.GroupBoxHobby)
        Me.TabPage3.Controls.Add(Me.GroupBoxPeran)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(612, 374)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Profil & Aktivitas"
        Me.TabPage3.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        Me.btnBatal.BackColor = System.Drawing.Color.Red
        Me.btnBatal.ForeColor = System.Drawing.Color.White
        Me.btnBatal.Location = New System.Drawing.Point(480, 320)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(100, 35)
        Me.btnBatal.TabIndex = 8
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnSimpanCetak
        ' 
        Me.btnSimpanCetak.BackColor = System.Drawing.Color.Green
        Me.btnSimpanCetak.ForeColor = System.Drawing.Color.White
        Me.btnSimpanCetak.Location = New System.Drawing.Point(360, 320)
        Me.btnSimpanCetak.Name = "btnSimpanCetak"
        Me.btnSimpanCetak.Size = New System.Drawing.Size(110, 35)
        Me.btnSimpanCetak.TabIndex = 7
        Me.btnSimpanCetak.Text = "Simpan & Cetak"
        Me.btnSimpanCetak.UseVisualStyleBackColor = False
        ' 
        ' btnBrowse
        ' 
        Me.btnBrowse.Location = New System.Drawing.Point(360, 190)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(100, 30)
        Me.btnBrowse.TabIndex = 6
        Me.btnBrowse.Text = "Browse Foto"
        Me.btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' PictureBoxFoto
        ' 
        Me.PictureBoxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxFoto.Location = New System.Drawing.Point(360, 30)
        Me.PictureBoxFoto.Name = "PictureBoxFoto"
        Me.PictureBoxFoto.Size = New System.Drawing.Size(150, 150)
        Me.PictureBoxFoto.TabIndex = 5
        Me.PictureBoxFoto.TabStop = False
        ' 
        ' GroupBoxHobby
        ' 
        Me.GroupBoxHobby.Controls.Add(Me.CheckBoxFotografi)
        Me.GroupBoxHobby.Controls.Add(Me.CheckBoxGaming)
        Me.GroupBoxHobby.Controls.Add(Me.CheckBoxCoding)
        Me.GroupBoxHobby.Controls.Add(Me.CheckBoxMenari)
        Me.GroupBoxHobby.Controls.Add(Me.CheckBoxMenyanyi)
        Me.GroupBoxHobby.Controls.Add(Me.CheckBoxOlahraga)
        Me.GroupBoxHobby.Controls.Add(Me.CheckBoxTraveling)
        Me.GroupBoxHobby.Controls.Add(Me.CheckBoxMemancing)
        Me.GroupBoxHobby.Controls.Add(Me.CheckBoxMembaca)
        Me.GroupBoxHobby.Controls.Add(Me.CheckBoxMenulis)
        Me.GroupBoxHobby.Controls.Add(Me.CheckBoxMenggambar)
        Me.GroupBoxHobby.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxHobby.Location = New System.Drawing.Point(20, 120)
        Me.GroupBoxHobby.Name = "GroupBoxHobby"
        Me.GroupBoxHobby.Size = New System.Drawing.Size(320, 200)
        Me.GroupBoxHobby.TabIndex = 4
        Me.GroupBoxHobby.TabStop = False
        Me.GroupBoxHobby.Text = "Hobby & Aktivitas (minimal 1)"
        ' 
        ' CheckBoxFotografi
        ' 
        Me.CheckBoxFotografi.AutoSize = True
        Me.CheckBoxFotografi.Location = New System.Drawing.Point(150, 150)
        Me.CheckBoxFotografi.Name = "CheckBoxFotografi"
        Me.CheckBoxFotografi.Size = New System.Drawing.Size(77, 19)
        Me.CheckBoxFotografi.TabIndex = 10
        Me.CheckBoxFotografi.Text = "Fotografi"
        Me.CheckBoxFotografi.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxGaming
        ' 
        Me.CheckBoxGaming.AutoSize = True
        Me.CheckBoxGaming.Location = New System.Drawing.Point(150, 125)
        Me.CheckBoxGaming.Name = "CheckBoxGaming"
        Me.CheckBoxGaming.Size = New System.Drawing.Size(70, 19)
        Me.CheckBoxGaming.TabIndex = 9
        Me.CheckBoxGaming.Text = "Gaming"
        Me.CheckBoxGaming.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxCoding
        ' 
        Me.CheckBoxCoding.AutoSize = True
        Me.CheckBoxCoding.Location = New System.Drawing.Point(150, 100)
        Me.CheckBoxCoding.Name = "CheckBoxCoding"
        Me.CheckBoxCoding.Size = New System.Drawing.Size(68, 19)
        Me.CheckBoxCoding.TabIndex = 8
        Me.CheckBoxCoding.Text = "Coding"
        Me.CheckBoxCoding.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxMenari
        ' 
        Me.CheckBoxMenari.AutoSize = True
        Me.CheckBoxMenari.Location = New System.Drawing.Point(150, 75)
        Me.CheckBoxMenari.Name = "CheckBoxMenari"
        Me.CheckBoxMenari.Size = New System.Drawing.Size(65, 19)
        Me.CheckBoxMenari.TabIndex = 7
        Me.CheckBoxMenari.Text = "Menari"
        Me.CheckBoxMenari.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxMenyanyi
        ' 
        Me.CheckBoxMenyanyi.AutoSize = True
        Me.CheckBoxMenyanyi.Location = New System.Drawing.Point(150, 50)
        Me.CheckBoxMenyanyi.Name = "CheckBoxMenyanyi"
        Me.CheckBoxMenyanyi.Size = New System.Drawing.Size(77, 19)
        Me.CheckBoxMenyanyi.TabIndex = 6
        Me.CheckBoxMenyanyi.Text = "Menyanyi"
        Me.CheckBoxMenyanyi.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxOlahraga
        ' 
        Me.CheckBoxOlahraga.AutoSize = True
        Me.CheckBoxOlahraga.Location = New System.Drawing.Point(150, 25)
        Me.CheckBoxOlahraga.Name = "CheckBoxOlahraga"
        Me.CheckBoxOlahraga.Size = New System.Drawing.Size(79, 19)
        Me.CheckBoxOlahraga.TabIndex = 5
        Me.CheckBoxOlahraga.Text = "Olahraga"
        Me.CheckBoxOlahraga.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxTraveling
        ' 
        Me.CheckBoxTraveling.AutoSize = True
        Me.CheckBoxTraveling.Location = New System.Drawing.Point(20, 150)
        Me.CheckBoxTraveling.Name = "CheckBoxTraveling"
        Me.CheckBoxTraveling.Size = New System.Drawing.Size(82, 19)
        Me.CheckBoxTraveling.TabIndex = 4
        Me.CheckBoxTraveling.Text = "Traveling"
        Me.CheckBoxTraveling.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxMemancing
        ' 
        Me.CheckBoxMemancing.AutoSize = True
        Me.CheckBoxMemancing.Location = New System.Drawing.Point(20, 125)
        Me.CheckBoxMemancing.Name = "CheckBoxMemancing"
        Me.CheckBoxMemancing.Size = New System.Drawing.Size(87, 19)
        Me.CheckBoxMemancing.TabIndex = 3
        Me.CheckBoxMemancing.Text = "Memancing"
        Me.CheckBoxMemancing.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxMembaca
        ' 
        Me.CheckBoxMembaca.AutoSize = True
        Me.CheckBoxMembaca.Location = New System.Drawing.Point(20, 100)
        Me.CheckBoxMembaca.Name = "CheckBoxMembaca"
        Me.CheckBoxMembaca.Size = New System.Drawing.Size(79, 19)
        Me.CheckBoxMembaca.TabIndex = 2
        Me.CheckBoxMembaca.Text = "Membaca"
        Me.CheckBoxMembaca.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxMenulis
        ' 
        Me.CheckBoxMenulis.AutoSize = True
        Me.CheckBoxMenulis.Location = New System.Drawing.Point(20, 75)
        Me.CheckBoxMenulis.Name = "CheckBoxMenulis"
        Me.CheckBoxMenulis.Size = New System.Drawing.Size(69, 19)
        Me.CheckBoxMenulis.TabIndex = 1
        Me.CheckBoxMenulis.Text = "Menulis"
        Me.CheckBoxMenulis.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxMenggambar
        ' 
        Me.CheckBoxMenggambar.AutoSize = True
        Me.CheckBoxMenggambar.Location = New System.Drawing.Point(20, 50)
        Me.CheckBoxMenggambar.Name = "CheckBoxMenggambar"
        Me.CheckBoxMenggambar.Size = New System.Drawing.Size(92, 19)
        Me.CheckBoxMenggambar.TabIndex = 0
        Me.CheckBoxMenggambar.Text = "Menggambar"
        Me.CheckBoxMenggambar.UseVisualStyleBackColor = True
        ' 
        ' GroupBoxPeran
        ' 
        Me.GroupBoxPeran.Controls.Add(Me.ComboBoxPeran)
        Me.GroupBoxPeran.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxPeran.Location = New System.Drawing.Point(20, 20)
        Me.GroupBoxPeran.Name = "GroupBoxPeran"
        Me.GroupBoxPeran.Size = New System.Drawing.Size(320, 80)
        Me.GroupBoxPeran.TabIndex = 3
        Me.GroupBoxPeran.TabStop = False
        Me.GroupBoxPeran.Text = "Pilihan Peran"
        ' 
        ' ComboBoxPeran
        ' 
        Me.ComboBoxPeran.FormattingEnabled = True
        Me.ComboBoxPeran.Location = New System.Drawing.Point(20, 30)
        Me.ComboBoxPeran.Name = "ComboBoxPeran"
        Me.ComboBoxPeran.Size = New System.Drawing.Size(280, 23)
        Me.ComboBoxPeran.TabIndex = 0
        ' 
        ' ErrorProvider1
        ' 
        Me.ErrorProvider1.ContainerControl = Me
        ' 
        ' FormInputData
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 441)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormInputData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Data Kartu Komunitas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.PictureBoxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxHobby.ResumeLayout(False)
        Me.GroupBoxHobby.PerformLayout()
        Me.GroupBoxPeran.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents LabelNama As Label
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents LabelID As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents LabelTglLahir As Label
    Friend WithEvents DateTimePickerTglLahir As DateTimePicker
    Friend WithEvents LabelJK As Label
    Friend WithEvents RadioLaki As RadioButton
    Friend WithEvents RadioPerempuan As RadioButton
    Friend WithEvents LabelDivisi As Label
    Friend WithEvents ComboBoxDivisi As ComboBox
    Friend WithEvents LabelTelepon As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents LabelAlamat As Label
    Friend WithEvents TextBoxAlamat As TextBox
    Friend WithEvents MaskedTextBoxTelepon As MaskedTextBox
    Friend WithEvents GroupBoxPeran As GroupBox
    Friend WithEvents ComboBoxPeran As ComboBox
    Friend WithEvents GroupBoxHobby As GroupBox
    Friend WithEvents CheckBoxMenggambar As CheckBox
    Friend WithEvents CheckBoxMenulis As CheckBox
    Friend WithEvents CheckBoxMembaca As CheckBox
    Friend WithEvents CheckBoxMemancing As CheckBox
    Friend WithEvents CheckBoxTraveling As CheckBox
    Friend WithEvents CheckBoxOlahraga As CheckBox
    Friend WithEvents CheckBoxMenyanyi As CheckBox
    Friend WithEvents CheckBoxMenari As CheckBox
    Friend WithEvents CheckBoxCoding As CheckBox
    Friend WithEvents CheckBoxGaming As CheckBox
    Friend WithEvents CheckBoxFotografi As CheckBox
    Friend WithEvents PictureBoxFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
