﻿Public Class Q11
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Move
        Label2.Text = "Which was the first legendary Ash saw in the TV series"
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
        Q10.Close()
        Me.Close()
        Q12.Show()
    End Sub
End Class