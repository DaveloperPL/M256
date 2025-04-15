Public Class Form1
    Dim rNum As New Random
    Dim x As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Generate a random number between 0 and 1
        '0 Up
        '1 Down
        x = rNum.Next(0, 2)
        If x = 0 Then
            lblCP.Top = lblCP.Top - 10
        Else
            lblCP.Top = lblCP.Top + 10
        End If
    End Sub
End Class
