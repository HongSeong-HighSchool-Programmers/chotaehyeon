Public Class Form1

    Dim num2 As Integer
    Dim num1 As Integer
    Dim i As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text

        i = num1 + num2

        TextBox3.Text = i
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        num1 = TextBox1.Text
        num2 = TextBox2.Text

        i = num1 - num2

        TextBox3.Text = i
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text

        i = num1 * num2

        TextBox3.Text = i
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text

        i = num1 / num2

        TextBox3.Text = i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        num1 = TextBox1.Text

        For i = num1 - 1 To 1 Step -1
            i = num1 * i
        Next

        TextBox3.Text = i
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
