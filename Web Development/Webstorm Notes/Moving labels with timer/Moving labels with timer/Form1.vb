Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        move.Top = move.Top - 10
        If move.Top <= 0 Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.W Then
            Label1.Top = Label1.Top - 10
        End If
        If e.KeyCode = Keys.S Then
            Label1.Top = Label1.Top + 10
        End If
        If e.KeyCode = Keys.A Then
            Label1.Left = Label1.Left - 10
        End If
        If e.KeyCode = Keys.D Then
            Label1.Left = Label1.Left + 10
        End If


        If Label1.Bounds.IntersectsWith(move.Bounds) Then
            MsgBox("Hi")
        End If
    End Sub
End Class
