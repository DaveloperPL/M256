Public Class Form1
    Dim dirx As Integer
    Dim diry As Integer
    Dim PUD As Integer
    Dim Difficulty As String
    Dim numPlayer As Integer
    Dim UD As Integer
    Dim UD2 As Integer
    Dim Random As New Random
    Dim NP As Integer
    Dim GameStarted As Boolean
    Dim Score As Integer
    Dim Score2 As Integer
    Dim Scored As String
    Dim PlaceHolder As Integer
    Dim DirP As Integer
    Dim Num As Integer
    Dim BSpeed As Integer
    Dim HdirX As New Double
    Dim HdirY As New Double

    Private Sub StartToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StartToolStripMenuItem1.Click
        If numPlayer = 1 Or numPlayer = 2 Then
            If GameStarted = False Then
                lblScore.Text = "0 - 0"
                Score = 0
                Score2 = 0

                If BSpeed = 1 Then
                    HdirX = Random.Next(1, 2)
                    NP = Random.Next(1, 3)
                    If NP = 1 Then
                        HdirX = HdirX * -1
                    End If
                    HdirY = Random.Next(1, 2)
                    NP = Random.Next(1, 2)
                    If NP = 1 Then
                        HdirY = HdirY * -1
                    End If
                End If

                If BSpeed = 2 Then
                    dirx = Random.Next(1, 3)
                    NP = Random.Next(1, 3)
                    If NP = 1 Then
                        dirx = dirx * -1
                    End If
                    diry = Random.Next(1, 3)
                    NP = Random.Next(1, 3)
                    If NP = 1 Then
                        diry = diry * -1
                    End If
                End If

                If BSpeed = 3 Then
                    dirx = Random.Next(1, 3)
                    NP = Random.Next(1, 3)
                    If NP = 1 Then
                        dirx = dirx * -1
                    End If
                    diry = Random.Next(1, 3)
                    NP = Random.Next(1, 3)
                    If NP = 1 Then
                        diry = diry * -1
                    End If
                    dirx = dirx * 2
                    diry = diry * 2
                End If
                BallTimer.Start()
                GameStarted = True
            End If
        Else
            MsgBox("Remember To Set The Amount Of Players! Game > Players > 1Player/2Player")
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles BallTimer.Tick
        If Ball.Bounds.IntersectsWith(Paddle1.Bounds) Then
            If BSpeed = 2 Or BSpeed = 3 Then
                dirx = dirx * -1
            Else
                HdirX = HdirX * -1
            End If
        End If

        If Ball.Bounds.IntersectsWith(Paddle2.Bounds) Then
            If BSpeed = 2 Or BSpeed = 3 Then
                dirx = dirx * -1
            Else
                HdirX = HdirX * -1
            End If
        End If

            If BSpeed = 1 Then
            Ball.Top = Ball.Top + HdirY
            Ball.Left = Ball.Left + HdirX
        Else
            Ball.Top = Ball.Top + diry
            Ball.Left = Ball.Left + dirx
        End If

        If Ball.Top < Panel1.Top Then
            If BSpeed = 2 Or BSpeed = 3 Then
                diry = diry * -1
            Else
                HdirY = HdirY * -1
            End If
        End If

        If Ball.Bottom > Panel1.Bottom Then
            If BSpeed = 2 Or BSpeed = 3 Then
                diry = diry * -1
            Else
                HdirY = HdirY * -1
            End If
        End If

        If Ball.Left < Panel1.Left Then
            Ball.Left = 616
            Ball.Top = 320
            Score2 = Score2 + 1
            lblScore.Text = Score2 & " - " & Score

            If BSpeed = 1 Then
                dirx = Random.Next(1, 3)
                NP = Random.Next(1, 3)
                If NP = 1 Then
                    dirx = dirx * -1
                End If
                diry = Random.Next(1, 3)
                NP = Random.Next(1, 3)
                If NP = 1 Then
                    diry = diry * -1
                End If
                HdirX = dirx / 2
                HdirY = diry / 2
            End If

            If BSpeed = 2 Then
                dirx = Random.Next(1, 3)
                NP = Random.Next(1, 3)
                If NP = 1 Then
                    dirx = dirx * -1
                End If
                diry = Random.Next(1, 3)
                NP = Random.Next(1, 3)
                If NP = 1 Then
                    diry = diry * -1
                End If
            End If

            If BSpeed = 3 Then
                dirx = Random.Next(1, 3)
                NP = Random.Next(1, 3)
                If NP = 1 Then
                    dirx = dirx * -1
                End If
                diry = Random.Next(1, 3)
                NP = Random.Next(1, 3)
                If NP = 1 Then
                    diry = diry * -1
                End If
                dirx = dirx * 2
                diry = diry * 2
            End If

            Scored = "Player2"
            BallTimer.Stop()
            ScoredTimer.Start()
            Label1.Text = Scored & " Scored!"
            Label1.Visible = True

        End If

        If Ball.Right > Panel1.Right Then
            Ball.Left = 616
            Ball.Top = 320
            Score = Score + 1
            lblScore.Text = Score2 & " - " & Score

            If BSpeed = 1 Then
                dirx = Random.Next(1, 3)
                NP = Random.Next(1, 3)
                If NP = 1 Then
                    dirx = dirx * -1
                End If
                diry = Random.Next(1, 3)
                NP = Random.Next(1, 3)
                If NP = 1 Then
                    diry = diry * -1
                End If
                dirx = dirx / 2
                diry = diry / 2
            End If

            If BSpeed = 2 Then
                dirx = Random.Next(1, 3)
                NP = Random.Next(1, 3)
                If NP = 1 Then
                    dirx = dirx * -1
                End If
                diry = Random.Next(1, 3)
                NP = Random.Next(1, 3)
                If NP = 1 Then
                    diry = diry * -1
                End If
            End If

            If BSpeed = 3 Then
                dirx = Random.Next(1, 3)
                NP = Random.Next(1, 3)
                If NP = 1 Then
                    dirx = dirx * -1
                End If
                diry = Random.Next(1, 3)
                NP = Random.Next(1, 3)
                If NP = 1 Then
                    diry = diry * -1
                End If
                dirx = dirx * 2
                diry = diry * 2
            End If

            Scored = "Player1"
            BallTimer.Stop()
            ScoredTimer.Start()
            Paddle1.Top = 240
            Paddle1.Left = 25
            Paddle2.Top = 240
            Paddle2.Left = 1225
            Label1.Text = Scored & " Scored!"
            Label1.Visible = True


        End If

        If Score = 3 Then
            Label1.Visible = True
            Label1.Text = "Player1 Wins!"
            BallTimer.Stop()
            GameStarted = False
        End If

        If Score2 = 3 Then
            Label1.Visible = True
            Label1.Text = "Player2 Wins!"
            BallTimer.Stop()
            GameStarted = False
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up Then
            If numPlayer = 2 Then
                UD = 1
                Paddle2Timer.Start()
            End If
        End If
        If e.KeyCode = Keys.Down Then
            If numPlayer = 2 Then
                UD = 0
                Paddle2Timer.Start()
            End If
        End If
        If e.KeyCode = Keys.W Then
            If numPlayer = 1 Or numPlayer = 2 Then
                UD2 = 1
                Paddle1Timer.Start()
            End If
        End If
        If e.KeyCode = Keys.S Then
            If numPlayer = 1 Or numPlayer = 2 Then
                UD2 = 0
                Paddle1Timer.Start()
            End If
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

        If e.KeyCode = Keys.Up Then
            If numPlayer = 2 Then
                Paddle2Timer.Stop()
            End If
        End If
        If e.KeyCode = Keys.Down Then
            If numPlayer = 2 Then
                UD = 0
                Paddle2Timer.Stop()
            End If
        End If

        If e.KeyCode = Keys.W Then
            UD2 = 1
            Paddle1Timer.Stop()
        End If
        If e.KeyCode = Keys.S Then
            UD2 = 0
            Paddle1Timer.Stop()
        End If
    End Sub

    Private Sub Paddle2Timer_Tick(sender As Object, e As EventArgs) Handles Paddle2Timer.Tick
        If Paddle2.Top < Panel1.Top Then
            Paddle2Timer.Stop()
            Paddle2.Top = Paddle2.Top + 1
        End If

        If UD = 1 Then
            Paddle2.Top = Paddle2.Top - 1
        Else
            Paddle2.Top = Paddle2.Top + 1
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PaddleAI.Start()
        BSpeed = 2
    End Sub

    Private Sub Paddle1Timer_Tick(sender As Object, e As EventArgs) Handles Paddle1Timer.Tick
        If Paddle1.Top < Panel1.Top Then
            Paddle1Timer.Stop()
            Paddle1.Top = Paddle1.Top + 1
        End If

        If UD2 = 1 Then
            Paddle1.Top = Paddle1.Top - 1
        Else
            Paddle1.Top = Paddle1.Top + 1
        End If
    End Sub

    Private Sub WinTimer_Tick(sender As Object, e As EventArgs) Handles ScoredTimer.Tick
        Label1.Visible = False
        ScoredTimer.Stop()
        BallTimer.Start()
    End Sub

    Private Sub PlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayerToolStripMenuItem.Click
        numPlayer = 2
    End Sub

    Private Sub PlayerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PlayerToolStripMenuItem1.Click
        numPlayer = 1
    End Sub

    Private Sub EndGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndGameToolStripMenuItem.Click
        Ball.Left = 616
        Ball.Top = 320
        Label1.Visible = False
        GameStarted = False
        lblScore.Text = "0 - 0"
        BallTimer.Stop()
        Paddle1Timer.Stop()
        Paddle2Timer.Stop()

    End Sub

    Private Sub ChangePaddleColorToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ControlKeysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlKeysToolStripMenuItem.Click
        MsgBox("Welcome to Pong by David! Use W, S and Up arrow key and Down arrow key to move the paddles!")
    End Sub

    Private Sub PaddleAI_Tick(sender As Object, e As EventArgs) Handles PaddleAI.Tick
        Dir.Start()
        If Difficulty = "Easy" Or Difficulty = "Hard" Then

            If numPlayer = 1 And GameStarted = True And Difficulty = "Easy" Then
                'Determinds If the paddle goes up or down
                If PlaceHolder = 1 Then
                    Paddle2.Top = Paddle2.Top + 1
                End If
                If PlaceHolder = 2 Then
                    Paddle2.Top = Paddle2.Top - 1
                End If
                If Paddle2.Top < Panel1.Top Then
                    PlaceHolder = 1
                End If
                If Paddle2.Bottom > Panel1.Bottom Then
                    PlaceHolder = 2
                End If
            End If
            If numPlayer = 1 And GameStarted = True And Difficulty = "Hard" Then
                Paddle2.Top = Ball.Top - Num
                If Paddle2.Top < Panel1.Top Then
                    Num = 20
                End If
                If Paddle2.Bottom > Panel1.Bottom Then
                    Num = 180
                End If
            End If
        End If
    End Sub

    Private Sub Dir_Tick(sender As Object, e As EventArgs) Handles Dir.Tick
        PlaceHolder = Random.Next(1, 3)
    End Sub

    Private Sub EasyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EasyToolStripMenuItem.Click
        Difficulty = "Easy"
    End Sub

    Private Sub HardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HardToolStripMenuItem.Click
        Difficulty = "Hard"
        Num = 100
    End Sub

    Private Sub SmallToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SmallToolStripMenuItem.Click
        Paddle1.Height = 100
        Paddle1.Top = 290
    End Sub

    Private Sub NormalToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem1.Click
        Paddle1.Height = 200
        Paddle1.Top = 240
    End Sub

    Private Sub LargeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LargeToolStripMenuItem.Click
        Paddle1.Height = 400
        Paddle1.Top = 190
    End Sub

    Private Sub SmallToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SmallToolStripMenuItem1.Click
        Paddle1.Height = 100
        Paddle1.Top = 290
    End Sub

    Private Sub NormalToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem2.Click
        Paddle1.Height = 200
        Paddle1.Top = 240
    End Sub

    Private Sub LargeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LargeToolStripMenuItem1.Click
        Paddle1.Height = 400
        Paddle1.Top = 190
    End Sub

    Private Sub SlowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlowToolStripMenuItem.Click
        BSpeed = 1
    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        BSpeed = 2
    End Sub

    Private Sub FastToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FastToolStripMenuItem.Click
        BSpeed = 3
    End Sub

    Private Sub PinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem.Click
        Ball.BackColor = Color.FromArgb(255, 192, 255)
    End Sub

    Private Sub PurpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurpleToolStripMenuItem.Click
        Ball.BackColor = Color.FromArgb(192, 0, 192)
    End Sub

    Private Sub DarkBlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkBlueToolStripMenuItem.Click
        Ball.BackColor = Color.FromArgb(192, 255, 255)
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Paddle1.BackColor = Color.FromArgb(255, 192, 192)
    End Sub

    Private Sub ClueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClueToolStripMenuItem.Click
        Paddle1.BackColor = Color.Blue
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        Paddle1.BackColor = Color.Green
    End Sub

    Private Sub RedToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem1.Click
        Paddle2.BackColor = Color.FromArgb(255, 192, 192)
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        Paddle2.BackColor = Color.Blue
    End Sub

    Private Sub GreenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem1.Click
        Paddle2.BackColor = Color.Green
    End Sub
End Class
