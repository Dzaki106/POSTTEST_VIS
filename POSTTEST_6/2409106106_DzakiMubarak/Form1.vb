Public Class Form1
    Private idEdit As Integer = -1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not TestConnection() Then
            MessageBox.Show("Tidak dapat terhubung ke database. Program akan ditutup.",
                "Error Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End If

        ComboBoxSkala.Items.AddRange(New String() {
            "1/144", "1/100", "1/60", "1/72", "1/48",
            "1/35", "1/32", "1/24", "1/20", "1/12", "Non-Scale"
        })

        ComboBoxMerek.Items.AddRange(New String() {
            "Bandai", "Kotobukiya", "Wave", "Hasegawa", "Tamiya",
            "Aoshima", "Good Smile Company", "Moderoid", "Plum",
            "Max Factory", "Revell", "Trumpeter"
        })

        TampilData()
        KosongkanForm()
    End Sub

    Private Sub TampilData()
        dgvModelKit.DataSource = GetAllModelKit()
        If dgvModelKit.Rows.Count > 0 Then
            dgvModelKit.Columns("id").Visible = False
            dgvModelKit.Columns("nama_model").HeaderText = "Nama Model"
            dgvModelKit.Columns("skala").HeaderText = "Skala"
            dgvModelKit.Columns("merek").HeaderText = "Merek"
            dgvModelKit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub

    Private Sub KosongkanForm()
        txtNamaModel.Clear()
        ComboBoxSkala.SelectedIndex = -1
        ComboBoxMerek.SelectedIndex = -1
        ErrorProvider1.Clear()
        idEdit = -1
        btnSimpan.Text = "SIMPAN"
        btnSimpan.BackColor = Color.LightGreen
        txtNamaModel.Focus()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()

        If Not ValidasiSemuaInput(ErrorProvider1, txtNamaModel, ComboBoxSkala, ComboBoxMerek) Then
            MessageBox.Show("Masih ada input yang belum valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim namaModel As String = txtNamaModel.Text.Trim()
        Dim skala As String = ComboBoxSkala.Text
        Dim merek As String = ComboBoxMerek.Text

        If idEdit = -1 Then
            If TambahModelKit(namaModel, skala, merek) Then
                MessageBox.Show("Data berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                KosongkanForm()
            End If
        Else
            If UbahModelKit(idEdit, namaModel, skala, merek) Then
                MessageBox.Show("Data berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                KosongkanForm()
            Else
                MessageBox.Show("Data tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvModelKit.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?",
            "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim id As Integer = Convert.ToInt32(dgvModelKit.SelectedRows(0).Cells("id").Value)
            If HapusModelKit(id) Then
                MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                KosongkanForm()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        KosongkanForm()
        TampilData()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?",
            "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub dgvModelKit_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvModelKit.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvModelKit.Rows(e.RowIndex)
            idEdit = Convert.ToInt32(row.Cells("id").Value)
            txtNamaModel.Text = row.Cells("nama_model").Value.ToString()
            ComboBoxSkala.Text = row.Cells("skala").Value.ToString()
            ComboBoxMerek.Text = row.Cells("merek").Value.ToString()

            btnSimpan.Text = "UPDATE"
            btnSimpan.BackColor = Color.LightBlue
        End If
    End Sub

    Private Sub txtNamaModel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNamaModel.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtNamaModel_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNamaModel.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBoxSkala.Focus()
        End If
    End Sub

    Private Sub ComboBoxSkala_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBoxSkala.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBoxMerek.Focus()
        End If
    End Sub

    Private Sub ComboBoxMerek_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBoxMerek.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSimpan.Focus()
        End If
    End Sub
    Private Sub btnPencarian_Click(sender As Object, e As EventArgs) Handles btnPencarian.Click
        Dim formPencarian As New FormPencarian()
        formPencarian.ShowDialog()
    End Sub
End Class