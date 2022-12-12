Public Class MenghitungJarak
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim kecepatan, waktuTempuh, jarak As Double

        jarak = txtJarak.Text
        kecepatan = txtKecepatan.Text
        'waktuTempuh = txtWaktu.Text

        'jarak = kecepatan * waktuTempuh
        'kecepatan = jarak / waktuTempuh
        waktuTempuh = jarak / kecepatan

        'txtJarak.Text = jarak
        'txtKecepatan.Text = kecepatan
        txtWaktu.Text = waktuTempuh


        'ListBox1.Items.Add(jarak)
        'ListBox1.Items.Add(kecepatan)
        ListBox1.Items.Add(waktuTempuh)
    End Sub
End Class