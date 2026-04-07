Public Class FormKartuKomunitas
    Private dataKartu As Dictionary(Of String, Object)

    Public Sub New(ByVal data As Dictionary(Of String, Object))
        InitializeComponent()
        dataKartu = data
    End Sub

    Private Sub FormKartuKomunitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanKartu()
        TampilkanRingkasan()
    End Sub

    Private Sub TampilkanKartu()
        Try
            LabelNama.Text = "Nama: " & dataKartu("nama").ToString()
            LabelID.Text = "ID: " & dataKartu("id").ToString()
            LabelKomunitas.Text = "Komunitas: " & dataKartu("divisi").ToString()
            LabelPeran.Text = "Peran: " & dataKartu("peran").ToString()
            LabelEmail.Text = "Email: " & dataKartu("email").ToString()
            LabelKontak.Text = "Kontak: " & dataKartu("telepon").ToString()
            LabelHobby.Text = "Hobby: " & dataKartu("hobby").ToString()
            LabelAlamat.Text = "Alamat: " & dataKartu("alamat").ToString()

            If dataKartu.ContainsKey("foto") AndAlso File.Exists(dataKartu("foto").ToString()) Then
                PictureBoxFoto.Image = Image.FromFile(dataKartu("foto").ToString())
                PictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage
            End If


            MessageBox.Show("Error menampilkan kartu: " & ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TampilkanRingkasan()
        Dim ringkasan As String = BuatRingkasanKartu(
            dataKartu("nama").ToString(),
            dataKartu("id").ToString(),
            dataKartu("divisi").ToString(),
            dataKartu("telepon").ToString(),
            dataKartu("email").ToString(),
            dataKartu("alamat").ToString(),
            dataKartu("peran").ToString(),
            dataKartu("hobby").ToString()
        )

    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Dim result As DialogResult = MessageBox.Show(
            "Apakah Anda ingin menyimpan kartu ini sebagai gambar?",
            "Konfirmasi Cetak",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            Using bmp As New Bitmap(Me.Width, Me.Height)
                Me.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))

                Dim saveDialog As New SaveFileDialog()
                saveDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg"
                saveDialog.Title = "Simpan Kartu sebagai Gambar"
                saveDialog.FileName = "KartuKomunitas_" & dataKartu("id").ToString() & ".png"

                If saveDialog.ShowDialog() = DialogResult.OK Then
                    bmp.Save(saveDialog.FileName)
                    MessageBox.Show("Kartu berhasil disimpan sebagai gambar!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub
End Class