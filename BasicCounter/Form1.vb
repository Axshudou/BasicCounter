Public Class Form1

    Private Sub decrement_Click(sender As Object, e As EventArgs) Handles decrement.Click
        If (Counter.Text > 0) Then
            Counter.Text = Counter.Text - 1
        End If

    End Sub

    Private Sub increment_Click(sender As Object, e As EventArgs) Handles increment.Click
        Counter.Text = Counter.Text + 1
    End Sub

    Private Sub RAZ_Click(sender As Object, e As EventArgs) Handles RAZ.Click
        Counter.Text = 0
    End Sub
End Class
