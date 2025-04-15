Public Class Form1
    Dim rnum As New Random
    Dim dirx As Integer  'this is where I am storing moving left/right
    Dim diry As Integer  'this is where I am storing moving up/down
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        lblBall.Left = 302 ' this resets our ball to the middle
        lblBall.Top = 181

        dirx = rnum.Next(-10, 11) '-# moves left, + # moves right
        diry = rnum.Next(-10, 11) ' -# moves down, + # moves up
        Timer1.Start()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'lblBall.Left = lblBall.Left + 5 'right
        'lblBall.Top = lblBall.Top + 5   ' down

        lblBall.Left = lblBall.Left + dirx
        lblBall.Top = lblBall.Top + diry

        'now coding to get ball to bounce off panel walls
        If lblBall.Left < Panel1.Left Then
            dirx = dirx * -1 ' moves from going left to right when I hit left wall
        End If

        If lblBall.Right > Panel1.Right Then
            dirx = dirx * -1 ' moves from going right to left when I hit right wall
        End If
        'code an inequality to bounce off of top of panel
        If lblBall.Top < Panel1.Top Then
            diry = diry * -1
        End If

        'code an inequality to bounce off of bottom of panel
        If lblBall.Bottom > Panel1.Bottom Then
            diry = diry * -1
        End If

        'in our actual pong game, we will NOT want the ball to bounce off the walls with paddles.

    End Sub
End Class
