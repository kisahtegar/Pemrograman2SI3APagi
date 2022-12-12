Imports System.IO

Public Class MenyimpanFileTXT
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim fileWriter As StreamWriter

        Try
            fileWriter = New StreamWriter("C:\My Data\Project\cpp\Testing\Pemrograman2SI3APagi\output\Biodata.txt")
            fileWriter.Write(txtNama.Text)
            fileWriter.Close()
            MessageBox.Show("DATA SUDAH DISIMPAN")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class