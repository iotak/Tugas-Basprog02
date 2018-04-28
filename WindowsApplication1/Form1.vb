Public Class Form1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim z, x, c, v As Single
        z = TextBox2.Text
        x = TextBox3.Text
        c = TextBox4.Text
        v = (z + x + c) / 3
        Label7.Text = v
        If v > 80 Then
            Label8.Text = "Rp. 10.000.000"
            MsgBox("Selemat Anda Mendapatkan Hadiah Rp. 10.000.000", MsgBoxStyle.Information, "Pesan")
        ElseIf v > 70 Then
            Label8.Text = "Rp. 7.500.000"
            MsgBox("Selemat Anda Mendapatkan Hadiah Rp. 7.500.000", MsgBoxStyle.Information, "Pesan")
        Else
            Label8.Text = "Sertifikat"
            MsgBox("Selemat Anda Mendapatkan Sertifikat", MsgBoxStyle.Information, "Pesan")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        Label7.Text = "........................................"
        Label8.Text = "........................................"
    End Sub
End Class
