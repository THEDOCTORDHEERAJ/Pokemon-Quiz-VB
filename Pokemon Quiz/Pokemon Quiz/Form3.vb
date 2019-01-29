Public Class Wrong_Answer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Move
        Label1.Text = "Sorry Wrong Answer" + "
" + "Better Luck Next Time"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Close()
        Q1.Close()
        Q2.Close()
        Q3.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form1.Show()
    End Sub
End Class