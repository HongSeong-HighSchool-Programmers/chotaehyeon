Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True And TextBox1.Text = "chosangkuk" And TextBox2.Text = "hadasjk12" Then
            Me.Hide()
            Form2.Show()
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class
