Public Class Q12
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Move
        Label2.Text = "What ability does Hoopa use?"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Wrong_Answer.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Wrong_Answer.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Wrong_Answer.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Q11.Close()
        Me.Close()
        Q13.Show()
    End Sub
End Class