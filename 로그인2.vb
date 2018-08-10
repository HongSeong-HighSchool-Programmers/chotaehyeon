Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True And TextBox1.Text = "cereal67" And TextBox2.Text = "13031303" Then
            Me.Hide()
            form2.show()
        End If

    End Sub
End Class
