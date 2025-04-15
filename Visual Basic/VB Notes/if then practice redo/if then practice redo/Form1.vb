Public Class Form1
    Dim question As Integer


    Private Sub btnQuestions_Click(sender As Object, e As EventArgs) Handles btnQuestions.Click
        question = InputBox("What is 2+2?")
        If question = 4 Then
            lblCheck.BackColor = Color.Green
        Else
            lblCheck.BackColor = Color.Red
        End If

        question = InputBox("What is 20-10?")
        If question = 10 Then
            lblCheck.BackColor = Color.Green
        Else
            lblCheck.BackColor = Color.Red
        End If
    End Sub
End Class
