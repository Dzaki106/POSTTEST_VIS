Imports System.IO
Imports System.Text

Module ValidationModule
    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse
           Char.IsWhiteSpace(e.KeyChar) OrElse
           Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiMaskedTextBox(ep As ErrorProvider, mtb As MaskedTextBox, pesan As String) As Boolean
        If Not mtb.MaskCompleted Then
            ep.SetError(mtb, pesan)
            Return False
        Else
            ep.SetError(mtb, "")
            Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cbo As ComboBox, pesan As String) As Boolean
        If cbo.SelectedIndex = -1 OrElse cbo.Text.Trim() = "" Then
            ep.SetError(cbo, pesan)
            Return False
        Else
            ep.SetError(cbo, "")
            Return True
        End If
    End Function

    Public Function ValidasiRadioButton(ep As ErrorProvider, rb1 As RadioButton, rb2 As RadioButton, pesan As String) As Boolean
        If Not rb1.Checked AndAlso Not rb2.Checked Then
            ep.SetError(rb1, pesan)
            Return False
        Else
            ep.SetError(rb1, "")
            Return True
        End If
    End Function

    Public Function ValidasiCheckBox(ep As ErrorProvider, gb As GroupBox, pesan As String) As Boolean
        Dim adaYangDipilih As Boolean = False
        For Each ctrl As Control In gb.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = DirectCast(ctrl, CheckBox)
                If chk.Checked Then
                    adaYangDipilih = True
                    Exit For
                End If
            End If
        Next

        If Not adaYangDipilih Then
            ep.SetError(gb, pesan)
            Return False
        Else
            ep.SetError(gb, "")
            Return True
        End If
    End Function
End Module