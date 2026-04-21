Imports MySqlConnector

Module DataModule
    Public Function GetAllModelKit() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT id, nama_model, skala, merek FROM tb_modelkit ORDER BY id ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetModelKitById(id As Integer) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT id, nama_model, skala, merek FROM tb_modelkit WHERE id = @id"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", id)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function TambahModelKit(nama_model As String, skala As String, merek As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tb_modelkit (nama_model, skala, merek) VALUES (@nama_model, @skala, @merek)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nama_model", nama_model)
                    cmd.Parameters.AddWithValue("@skala", skala)
                    cmd.Parameters.AddWithValue("@merek", merek)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahModelKit(id As Integer, nama_model As String, skala As String, merek As String) As Boolean
        Try
            Dim query As String = "UPDATE tb_modelkit SET nama_model = @nama_model, skala = @skala, merek = @merek WHERE id = @id"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama_model", nama_model)
                    cmd.Parameters.AddWithValue("@skala", skala)
                    cmd.Parameters.AddWithValue("@merek", merek)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusModelKit(id As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM tb_modelkit WHERE id = @id"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Public Function SearchModelKit(keyword As String, filter As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = ""

            Select Case filter
                Case "Nama Model"
                    query = "SELECT id, nama_model, skala, merek FROM tb_modelkit WHERE nama_model LIKE @keyword ORDER BY id ASC"

                Case "Merek"
                    query = "SELECT id, nama_model, skala, merek FROM tb_modelkit WHERE merek LIKE @keyword ORDER BY id ASC"

                Case "Skala"
                    query = "SELECT id, nama_model, skala, merek FROM tb_modelkit WHERE skala LIKE @keyword ORDER BY id ASC"

                Case Else
                    query = "SELECT id, nama_model, skala, merek FROM tb_modelkit WHERE nama_model LIKE @keyword OR merek LIKE @keyword OR skala LIKE @keyword ORDER BY id ASC"
            End Select

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function
End Module