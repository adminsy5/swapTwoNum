Public Class Form1
    Dim a, b As Integer
    Private Sub swap_Click(sender As Object, e As EventArgs) Handles swap.Click
        a = Val(num1.Text)
        b = Val(num2.Text)

        num1.Text = b
        num2.Text = a
    End Sub
End Class
