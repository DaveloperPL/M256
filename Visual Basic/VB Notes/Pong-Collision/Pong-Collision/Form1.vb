Public Class Form1
    Dim dirx As Integer
    Dim score As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'key preview in form1 must be true for keypress
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.W Then
            lblPaddle.Top = lblPaddle.Top - 10
        End If
        If e.KeyCode = Keys.S Then
            lblPaddle.Top = lblPaddle.Top + 10
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dirx = 1
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblBall.Left = lblBall.Left + dirx

        'If lblBall.Right >= lblPaddle.Left And lblBall.Top < lblPaddle.Bottom And lblBall.Bottom > lblPaddle.Top Then
        '    dirx = dirx * -1
        'End If

        'I use collision code instead of all the inequalitys
        If lblBall.Bounds.IntersectsWith(lblPaddle.Bounds) Then
            dirx = dirx * -1
        End If


        If lblBall.Right >= Panel1.Right Then
            score = score + 1
            MsgBox(score)
            Timer1.Stop()
        End If


    End Sub
End Class
