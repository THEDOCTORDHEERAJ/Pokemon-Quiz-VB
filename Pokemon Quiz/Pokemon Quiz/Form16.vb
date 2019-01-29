Public Class Q14
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Move
        Label2.Text = "Kyurem, Reshiram and Zekrom are legendaries from which region?"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Wrong_Answer.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Wrong_Answer.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Wrong_Answer.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Q13.Close()
        Me.Close()
        Q15.Show()
    End Sub
End Class