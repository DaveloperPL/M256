Public Class Form1
    Dim roll As Integer
    Dim rnum As New Random
    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        roll = rnum.Next(1, 7)
        Label1.Text = roll
        Timer1.Interval = Timer1.Interval + 5
        If Timer1.Interval > 250 Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
