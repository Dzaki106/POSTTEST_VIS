Imports System.IO
Imports System.Text

Module DataModule
    Public Function BuatRingkasanKartu(
        nama As String,
        idAnggota As String,
        divisi As String,
        telepon As String,
        email As String,
        alamat As String,
        peran As String,
        hobby As String
    ) As String
        Return "=== RINGKASAN KARTU KOMUNITAS ===" & Environment.NewLine &
               "Nama            : " & nama & Environment.NewLine &
               "ID Anggota      : " & idAnggota & Environment.NewLine &
               "Komunitas/Divisi: " & divisi & Environment.NewLine &
               "Nomor Telepon   : " & telepon & Environment.NewLine &
               "Email           : " & email & Environment.NewLine &
               "Alamat          : " & alamat & Environment.NewLine &
               "Peran           : " & peran & Environment.NewLine &
               "Hobby/Aktivitas : " & hobby & Environment.NewLine &
               "==================================="
    End Function

    Public Function BuatIsiFileKartu(
        nama As String,
        idAnggota As String,
        tglLahir As DateTime,
        jk As String,
        divisi As String,
        telepon As String,
        email As String,
        alamat As String,
        peran As String,
        hobby As String,
        fotoPath As String
    ) As String
        Dim sb As New StringBuilder()

        sb.AppendLine("Nama=" & nama.Trim())
        sb.AppendLine("IDAnggota=" & idAnggota.Trim())
        sb.AppendLine("TanggalLahir=" & tglLahir.ToString("dd/MM/yyyy"))
        sb.AppendLine("JenisKelamin=" & jk)
        sb.AppendLine("Divisi=" & divisi)
        sb.AppendLine("Telepon=" & telepon)
        sb.AppendLine("Email=" & email)
        sb.AppendLine("Alamat=" & alamat.Trim())
        sb.AppendLine("Peran=" & peran)
        sb.AppendLine("Hobby=" & hobby)
        sb.AppendLine("FotoPath=" & fotoPath)

        Return sb.ToString()
    End Function

    Public Function SimpanDataKeFile(sfd As SaveFileDialog, isi As String, defaultNama As String) As Boolean
        sfd.Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
        sfd.Title = "Simpan Data Kartu Komunitas"
        sfd.FileName = defaultNama

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                File.WriteAllText(sfd.FileName, isi, Encoding.UTF8)
                Return True
            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan file: " & ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End If
        Return False
    End Function

    Public Function BukaDataDariFile(ofd As OpenFileDialog) As Dictionary(Of String, String)
        ofd.Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv|All Files (*.*)|*.*"
        ofd.Title = "Buka Data Kartu Komunitas"

        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                Dim data As New Dictionary(Of String, String)()
                Dim lines As String() = File.ReadAllLines(ofd.FileName, Encoding.UTF8)

                For Each line As String In lines
                    If line.Contains("=") Then
                        Dim parts As String() = line.Split(New Char() {"="c}, 2)
                        If parts.Length = 2 Then
                            data(parts(0)) = parts(1)
                        End If
                    End If
                Next

                Return data
            Catch ex As Exception
                MessageBox.Show("Gagal membuka file: " & ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End Try
        End If
        Return Nothing
    End Function

    Public Function AmbilNilai(data As Dictionary(Of String, String), key As String) As String
        If data.ContainsKey(key) Then
            Return data(key)
        End If
        Return ""
    End Function
End Module