Imports System.IO

Public Class FormMenuUtama
    Private dataKartu As Dictionary(Of String, Object)

    Public Sub New()
        InitializeComponent()
        dataKartu = New Dictionary(Of String, Object)()
    End Sub

    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PictureBoxLogo.Image = Image.FromFile("logo_komunitas.jpg")
            PictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage
        Catch
        End Try
    End Sub

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        Dim formInput As New FormInputData(dataKartu)
        formInput.ShowDialog()
        Me.BringToFront()
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        If dataKartu Is Nothing OrElse dataKartu.Count = 0 Then
            MessageBox.Show("Belum ada data kartu. Silakan input data terlebih dahulu!",
                "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim formKartu As New FormKartuKomunitas(dataKartu)
        formKartu.ShowDialog()
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        If dataKartu Is Nothing OrElse dataKartu.Count = 0 Then
            MessageBox.Show("Tidak ada data yang dapat disimpan!",
                "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim isiFile As String = BuatIsiFileKartu(
            dataKartu("nama").ToString(),
            dataKartu("id").ToString(),
            CType(dataKartu("tgl_lahir"), DateTime),
            dataKartu("jk").ToString(),
            dataKartu("divisi").ToString(),
            dataKartu("telepon").ToString(),
            dataKartu("email").ToString(),
            dataKartu("alamat").ToString(),
            dataKartu("peran").ToString(),
            dataKartu("hobby").ToString(),
            If(dataKartu.ContainsKey("foto"), dataKartu("foto").ToString(), "")
        )

        If SimpanDataKeFile(SaveFileDialog1, isiFile, "data_kartu_komunitas.txt") Then
            MessageBox.Show("Data berhasil disimpan!", "Sukses",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        Dim data As Dictionary(Of String, String) = BukaDataDariFile(OpenFileDialog1)

        If data Is Nothing Then
            Return
        End If

        dataKartu.Clear()

        dataKartu("nama") = AmbilNilai(data, "Nama")
        dataKartu("id") = AmbilNilai(data, "IDAnggota")

        Dim tglStr As String = AmbilNilai(data, "TanggalLahir")
        If DateTime.TryParse(tglStr, New DateTime()) Then
            dataKartu("tgl_lahir") = DateTime.Parse(tglStr)
        Else
            dataKartu("tgl_lahir") = DateTime.Now
        End If

        dataKartu("jk") = AmbilNilai(data, "JenisKelamin")
        dataKartu("divisi") = AmbilNilai(data, "Divisi")
        dataKartu("telepon") = AmbilNilai(data, "Telepon")
        dataKartu("email") = AmbilNilai(data, "Email")
        dataKartu("alamat") = AmbilNilai(data, "Alamat")
        dataKartu("peran") = AmbilNilai(data, "Peran")
        dataKartu("hobby") = AmbilNilai(data, "Hobby")
        dataKartu("foto") = AmbilNilai(data, "FotoPath")

        MessageBox.Show("Data berhasil dibuka! Silakan klik 'Lihat Kartu' untuk melihat hasil.",
            "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?",
            "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class