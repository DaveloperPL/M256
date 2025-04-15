Public Class Instructions
    Dim idk As String
    Dim rNum As New Random
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        Game.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        idk = InputBox("Are you sure you want to quit? Yes/No?")
        If idk.ToLower = "yes" Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label4.Text = rNum.Next(1, 7)
    End Sub
End Class