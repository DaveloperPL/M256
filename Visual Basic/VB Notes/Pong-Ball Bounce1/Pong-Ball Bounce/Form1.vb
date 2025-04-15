Public Class Form1
    Dim dirx As Integer 'Storing moving Left/Right
    Dim rNum As New Random 'Random Number
    Dim diry As Integer 'Storing moving Up/Down


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        lblBall.Left = 340
        lblBall.Top = 171 'Sets ball to start location

        dirx = rNum.Next(-5, 6)
        diry = rNum.Next(-5, 6)
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'lblBall.Left = lblBall.Left + 1 'Move Right
        'lblBall.Top = lblBall.Top + 1 'Move Down

        lblBall.Left = lblBall.Left + diry
        lblBall.Top = lblBall.Top + dirx

        'Coding to get the ball to bounce off panel walls
        If lblBall.Left < Panel1.Left Then
            dirx = dirx * -1 'moves left to right when i hit the lw
        End If
        If lblBall.Right > Panel1.Right Then
            dirx = dirx * -1
        End If
        If lblBall.Top < Panel1.Top Then
            diry = diry * -1
        End If
        If lblBall.Bottom > Panel1.Bottom Then
            diry = diry * -1
        End If
    End Sub
End Class
