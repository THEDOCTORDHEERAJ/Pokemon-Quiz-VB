﻿Public Class Q7
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Move
        Label2.Text = "What is the name of the Sun legendary in Alola"
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
        Q6.Close()
        Me.Close()
        Q8.Show()

    End Sub
End Class