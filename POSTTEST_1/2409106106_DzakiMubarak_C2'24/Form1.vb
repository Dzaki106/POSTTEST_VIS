Public Class Form1
    Private daftarIPSemester As New List(Of Double)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.ReadOnly = True
        TextBox2.Text = "0.00"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            TextBox1.Focus()
            Return
        End If

        Dim ipSemester As Double
        If Not Double.TryParse(TextBox1.Text, ipSemester) Then
            TextBox1.Clear()
            TextBox1.Focus()
            Return
        End If

        If ipSemester < 0 Or ipSemester > 4 Then
            TextBox1.Clear()
            TextBox1.Focus()
            Return
        End If

        daftarIPSemester.Add(ipSemester)

        Dim total As Double = 0
        For i As Integer = 0 To daftarIPSemester.Count - 1
            total = total + daftarIPSemester(i)
        Next

        Dim ipKumulatif As Double = total / daftarIPSemester.Count

        TextBox2.Text = ipKumulatif.ToString("0.00")

        If ipKumulatif >= 2.0 And ipKumulatif <= 2.75 Then
            Label3.Text = "Cukup"
        ElseIf ipKumulatif >= 2.76 And ipKumulatif <= 3.0 Then
            Label3.Text = "Memuaskan"
        ElseIf ipKumulatif >= 3.01 Then
            Label3.Text = "Sangat Memuaskan"
        Else
            Label3.Text = "-"
        End If

        TextBox1.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        daftarIPSemester.Clear()
        TextBox1.Clear()
        TextBox2.Text = "0.00"
        Label3.Text = ""
        TextBox1.Focus()
    End Sub
End Class