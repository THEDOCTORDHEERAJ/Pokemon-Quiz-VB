Public Class Thank_You
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Move
        Label1.Text = "Thank you for playing this game" + "
" + "Hope you enjoyed it :)"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Close()
    End Sub
End Class