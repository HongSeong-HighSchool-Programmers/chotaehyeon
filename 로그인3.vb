Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True And TextBox1.Text = "zxdfrtgh" And TextBox2.Text = "12345678" Then
            Me.Hide()
            form2.show()
        End If

    End Sub
End Class
