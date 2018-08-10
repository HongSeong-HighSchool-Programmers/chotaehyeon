Public Class Form1

    Dim num As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        num = MsgBox("안녕하세요", vbAbortRetryIgnore + vbInformation, "hello world!")

        If num = 6 Then
            MsgBox("yes", vbYesNo, "hello world!")

        ElseIf num = 7 Then
            MsgBox("no", vbYesNo, "hello world!")
        End If
    End Sub
End Class
