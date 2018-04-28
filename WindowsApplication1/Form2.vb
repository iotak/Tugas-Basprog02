Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c, d, f, g, h, i, j, k As Double
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        d = TextBox4.Text
        f = TextBox5.Text
        g = TextBox6.Text
        h = TextBox7.Text
        i = TextBox8.Text

        k = f + g + h + i

        If k = 100 Then

            j = ((a * f / 100) + (b * g / 100) + (c * h / 100) + (d * i / 100))
            Label10.Text = j
            If j >= 80 Then
                Label11.Text = "A"
            ElseIf j >= 70 Then
                Label11.Text = "B"
            ElseIf j >= 60 Then
                Label11.Text = "C"
            ElseIf j >= 50 Then
                Label11.Text = "D"
            Else
                Label11.Text = "E"
            End If
        Else
            MsgBox("Bobot Tidak Sama Dengan 100%", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
