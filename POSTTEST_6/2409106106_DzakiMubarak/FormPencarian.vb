Imports MySqlConnector

Public Class FormPencarian
    Private Sub FormPencarian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilSemuaData()
        LoadComboBoxFilter()
    End Sub

    Private Sub LoadComboBoxFilter()
        ComboBoxCari.Items.Clear()
        ComboBoxCari.Items.AddRange(New String() {
            "Nama Model",
            "Merek",
            "Skala",
            "Semua"
        })
        ComboBoxCari.SelectedIndex = 3
    End Sub

    Private Sub TampilSemuaData()
        Try
            Dim query As String = "SELECT id, nama_model, skala, merek FROM tb_modelkit ORDER BY id ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    dgvHasil.DataSource = dt
                    AturDataGridView()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AturDataGridView()
        If dgvHasil.Rows.Count > 0 Then
            dgvHasil.Columns("id").Visible = False
            dgvHasil.Columns("nama_model").HeaderText = "Nama Model"
            dgvHasil.Columns("skala").HeaderText = "Skala"
            dgvHasil.Columns("merek").HeaderText = "Merek"
            dgvHasil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
        LabelJumlah.Text = "Jumlah Data: " & dgvHasil.Rows.Count
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If String.IsNullOrWhiteSpace(txtKeyword.Text) Then
            MessageBox.Show("Masukkan kata kunci pencarian!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKeyword.Focus()
            Return
        End If

        Dim keyword As String = txtKeyword.Text.Trim()
        Dim filter As String = ComboBoxCari.SelectedItem.ToString()
        Dim dt As DataTable = SearchModelKit(keyword, filter)
        dgvHasil.DataSource = dt
        AturDataGridView()

        If dgvHasil.Rows.Count = 0 Then
            MessageBox.Show("Data tidak ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtKeyword.Clear()
        ComboBoxCari.SelectedIndex = 3
        TampilSemuaData()
        txtKeyword.Focus()
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub txtKeyword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKeyword.KeyPress
        If e.KeyChar = ChrW(13) Then
            btnCari.PerformClick()
        End If
    End Sub
End Class