Imports System.IO

Public Class FormInputData
    Private dataKartu As Dictionary(Of String, Object)
    Private fotoPath As String = ""

    Public Sub New(ByRef data As Dictionary(Of String, Object))
        InitializeComponent()
        dataKartu = data
    End Sub

    Private Sub FormInputData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePickerTglLahir.Format = DateTimePickerFormat.Custom
        DateTimePickerTglLahir.CustomFormat = "dd/MM/yyyy"
        DateTimePickerTglLahir.Value = DateTime.Now.AddYears(-20)

        MaskedTextBoxTelepon.Mask = "0000-0000-0000"
        MaskedTextBoxTelepon.TextMaskFormat = MaskFormat.IncludePrompt

        ComboBoxDivisi.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxDivisi.Items.AddRange(New Object() {
            "Teknologi & Inovasi",
            "Seni & Budaya",
            "Olahraga & Kesehatan",
            "Sosial & Kemanusiaan",
            "Lingkungan Hidup",
            "Kewirausahaan"
        })

        ComboBoxPeran.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxPeran.Items.AddRange(New Object() {
            "Ketua",
            "Wakil Ketua",
            "Sekretaris",
            "Bendahara",
            "Koordinator Divisi",
            "Anggota Aktif",
            "Anggota Biasa"
        })

        If dataKartu IsNot Nothing AndAlso dataKartu.ContainsKey("nama") Then
            TextBoxNama.Text = dataKartu("nama").ToString()
            TextBoxID.Text = dataKartu("id").ToString()
            DateTimePickerTglLahir.Value = CType(dataKartu("tgl_lahir"), DateTime)

            If dataKartu("jk").ToString() = "Laki-laki" Then
                RadioLaki.Checked = True
            ElseIf dataKartu("jk").ToString() = "Perempuan" Then
                RadioPerempuan.Checked = True
            End If

            ComboBoxDivisi.Text = dataKartu("divisi").ToString()
            MaskedTextBoxTelepon.Text = dataKartu("telepon").ToString()
            TextBoxEmail.Text = dataKartu("email").ToString()
            TextBoxAlamat.Text = dataKartu("alamat").ToString()
            ComboBoxPeran.Text = dataKartu("peran").ToString()

            If dataKartu.ContainsKey("hobby") Then
                Dim hobbyArray As String() = dataKartu("hobby").ToString().Split(",")
                For Each chk As CheckBox In GroupBoxHobby.Controls
                    For Each hobby As String In hobbyArray
                        If chk.Text.Trim() = hobby.Trim() Then
                            chk.Checked = True
                        End If
                    Next
                Next
            End If

            If dataKartu.ContainsKey("foto") AndAlso File.Exists(dataKartu("foto").ToString()) Then
                PictureBoxFoto.Image = Image.FromFile(dataKartu("foto").ToString())
                PictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage
                fotoPath = dataKartu("foto").ToString()
            End If
        End If
    End Sub

    Private Sub TextBoxNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNama.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub TextBoxNama_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNama.TextChanged
        ValidasiTextBox(ErrorProvider1, TextBoxNama, "Nama tidak boleh kosong")
    End Sub

    Private Sub TextBoxID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxID.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub TextBoxID_TextChanged(sender As Object, e As EventArgs) Handles TextBoxID.TextChanged
        ValidasiTextBox(ErrorProvider1, TextBoxID, "ID Anggota tidak boleh kosong")
    End Sub

    Private Sub ComboBoxDivisi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDivisi.SelectedIndexChanged
        ValidasiComboBox(ErrorProvider1, ComboBoxDivisi, "Pilih Komunitas/Divisi")
    End Sub

    Private Sub MaskedTextBoxTelepon_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBoxTelepon.TextChanged
        ValidasiMaskedTextBox(ErrorProvider1, MaskedTextBoxTelepon, "Nomor Telepon belum lengkap (format: 0000-0000-0000)")
    End Sub

    Private Sub TextBoxEmail_TextChanged(sender As Object, e As EventArgs) Handles TextBoxEmail.TextChanged
        ValidasiTextBox(ErrorProvider1, TextBoxEmail, "Email tidak boleh kosong")
    End Sub

    Private Sub TextBoxEmail_Leave(sender As Object, e As EventArgs) Handles TextBoxEmail.Leave
        If TextBoxEmail.Text <> "" AndAlso (Not TextBoxEmail.Text.Contains("@") OrElse Not TextBoxEmail.Text.Contains(".")) Then
            ErrorProvider1.SetError(TextBoxEmail, "Format email tidak valid! Contoh: nama@domain.com")
        Else
            ErrorProvider1.SetError(TextBoxEmail, "")
        End If
    End Sub

    Private Sub TextBoxAlamat_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAlamat.TextChanged
        ValidasiTextBox(ErrorProvider1, TextBoxAlamat, "Alamat tidak boleh kosong")
    End Sub

    Private Sub ComboBoxPeran_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxPeran.SelectedIndexChanged
        ValidasiComboBox(ErrorProvider1, ComboBoxPeran, "Pilih Peran dalam komunitas")
    End Sub

    Private Sub CheckBoxHobby_CheckedChanged(sender As Object, e As EventArgs) Handles _
        CheckBoxGaming.CheckedChanged, CheckBoxCoding.CheckedChanged, CheckBoxTraveling.CheckedChanged,
        CheckBoxMenggambar.CheckedChanged, CheckBoxMenulis.CheckedChanged, CheckBoxMemancing.CheckedChanged,
        CheckBoxMembaca.CheckedChanged, CheckBoxOlahraga.CheckedChanged, CheckBoxMenyanyi.CheckedChanged,
        CheckBoxMenari.CheckedChanged, CheckBoxFotografi.CheckedChanged

        ValidasiCheckBox(ErrorProvider1, GroupBoxHobby, "Pilih minimal 1 Hobby/Aktivitas")
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        openFileDialog.Title = "Pilih Foto Profil"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                PictureBoxFoto.Image = Image.FromFile(openFileDialog.FileName)
                PictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage
                fotoPath = openFileDialog.FileName
                ErrorProvider1.SetError(PictureBoxFoto, "")
            Catch ex As Exception
                MessageBox.Show("Gagal memuat gambar: " & ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Function ValidasiSemuaInputan() As Boolean
        Dim namaValid As Boolean = ValidasiTextBox(ErrorProvider1, TextBoxNama, "Nama tidak boleh kosong")
        Dim idValid As Boolean = ValidasiTextBox(ErrorProvider1, TextBoxID, "ID Anggota tidak boleh kosong")
        Dim jkValid As Boolean = ValidasiRadioButton(ErrorProvider1, RadioLaki, RadioPerempuan, "Pilih Jenis Kelamin")
        Dim divisiValid As Boolean = ValidasiComboBox(ErrorProvider1, ComboBoxDivisi, "Pilih Komunitas/Divisi")
        Dim teleponValid As Boolean = ValidasiMaskedTextBox(ErrorProvider1, MaskedTextBoxTelepon, "Nomor Telepon belum lengkap")
        Dim emailValid As Boolean = ValidasiTextBox(ErrorProvider1, TextBoxEmail, "Email tidak boleh kosong")
        Dim alamatValid As Boolean = ValidasiTextBox(ErrorProvider1, TextBoxAlamat, "Alamat tidak boleh kosong")
        Dim peranValid As Boolean = ValidasiComboBox(ErrorProvider1, ComboBoxPeran, "Pilih Peran dalam komunitas")
        Dim hobbyValid As Boolean = ValidasiCheckBox(ErrorProvider1, GroupBoxHobby, "Pilih minimal 1 Hobby/Aktivitas")

        Dim fotoValid As Boolean = True
        If PictureBoxFoto.Image Is Nothing Then
            ErrorProvider1.SetError(PictureBoxFoto, "Upload foto profil terlebih dahulu")
            fotoValid = False
        Else
            ErrorProvider1.SetError(PictureBoxFoto, "")
        End If

        Return namaValid And idValid And jkValid And divisiValid And
               teleponValid And emailValid And alamatValid And
               peranValid And hobbyValid And fotoValid
    End Function

    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        If Not ValidasiSemuaInputan() Then
            MessageBox.Show(
                "Masih ada input yang belum valid. Silakan lengkapi semua data!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return
        End If

        dataKartu("nama") = TextBoxNama.Text
        dataKartu("id") = TextBoxID.Text
        dataKartu("tgl_lahir") = DateTimePickerTglLahir.Value
        dataKartu("jk") = If(RadioLaki.Checked, "Laki-laki", "Perempuan")
        dataKartu("divisi") = ComboBoxDivisi.Text
        dataKartu("telepon") = MaskedTextBoxTelepon.Text
        dataKartu("email") = TextBoxEmail.Text
        dataKartu("alamat") = TextBoxAlamat.Text
        dataKartu("peran") = ComboBoxPeran.Text
        dataKartu("foto") = fotoPath

        Dim hobbyList As New List(Of String)()
        For Each chk As CheckBox In GroupBoxHobby.Controls
            If chk.Checked Then
                hobbyList.Add(chk.Text)
            End If
        Next
        dataKartu("hobby") = String.Join(", ", hobbyList)

        Dim result As DialogResult = MessageBox.Show(
            "Data berhasil disimpan!" & vbCrLf & "Apakah Anda ingin mencetak kartu sekarang?",
            "Sukses",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            Dim formKartu As New FormKartuKomunitas(dataKartu)
            formKartu.ShowDialog()
        End If

        Me.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Dim result As DialogResult = MessageBox.Show(
            "Apakah Anda yakin ingin membatalkan input data? Data tidak akan disimpan.",
            "Konfirmasi Batal",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class