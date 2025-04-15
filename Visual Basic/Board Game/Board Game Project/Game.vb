Public Class Game
    Dim die() As Label
    Dim rNum As New Random
    Dim Placeholder As Integer
    Dim RBlocker As Boolean
    Dim players() As Label
    Dim Turn As Integer
    Dim PlayerNum As Integer
    Dim Spots() As Label
    Dim NumSpot() As Integer
    Dim Placeholder1 As Integer
    Dim TimerStarted As Boolean
    Dim Dirx() As Integer
    Dim Diry() As Integer
    Dim Points() As Integer
    Dim Multiplyer() As Label
    Dim PointLbl() As Label
    Dim NumMultiplyer() As Double
    Dim rEvent As Integer
    Dim placeholder2 As Integer
    Dim skip(3) As Boolean
    Dim idk As String
    Dim MovingB As Boolean
    Dim miss As Boolean
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DieOutline.Image = ImageList1.Images(0)
        die = {D1, D2, D3, D4, D5, D6, D7}
        PlayerNum = 3
        Turn = 0
        NumSpot = {0, 0, 0, 0}
        players = {P1, P2, P3, P4}
        Spots = {S1, S2, S3, S4, S5, S6, S7, S8, S9, S10, S11, S12, S13, S14, S15, S16, S17, S18, S19, S20, S21, S22, S23, S24, S25, S26, S27, S28, S29, S30, S31, S32}
        TimerStarted = False
        Dirx = {0, 50, 0, 50}
        Diry = {0, 0, 50, 50}
        Points = {0, 0, 0, 0}
        PointLbl = {lbl1, Lbl2, Lbl3, Lbl4}
        NumMultiplyer = {1, 1, 1, 1}
        Multiplyer = {Label6, Label7, Label8, Label9}
    End Sub

    Private Sub RollTimer_Tick(sender As Object, e As EventArgs) Handles RollTimer.Tick
        RBlocker = True
        Placeholder = rNum.Next(1, 7)

        RollTimer.Interval = RollTimer.Interval + 10
        If Placeholder = 1 Then
            die(0).Visible = False
            die(1).Visible = False
            die(2).Visible = False
            die(3).Visible = True
            die(4).Visible = False
            die(5).Visible = False
            die(6).Visible = False
        End If
        If Placeholder = 2 Then
            die(0).Visible = True
            die(1).Visible = False
            die(2).Visible = False
            die(3).Visible = False
            die(4).Visible = False
            die(5).Visible = False
            die(6).Visible = True
        End If
        If Placeholder = 3 Then
            die(0).Visible = True
            die(1).Visible = False
            die(2).Visible = False
            die(3).Visible = True
            die(4).Visible = False
            die(5).Visible = False
            die(6).Visible = True
        End If
        If Placeholder = 4 Then
            die(0).Visible = True
            die(1).Visible = True
            die(2).Visible = False
            die(3).Visible = False
            die(4).Visible = False
            die(5).Visible = True
            die(6).Visible = True
        End If
        If Placeholder = 5 Then
            die(0).Visible = True
            die(1).Visible = True
            die(2).Visible = False
            die(3).Visible = True
            die(4).Visible = False
            die(5).Visible = True
            die(6).Visible = True
        End If
        If Placeholder = 6 Then
            die(0).Visible = True
            die(1).Visible = True
            die(2).Visible = True
            die(3).Visible = False
            die(4).Visible = True
            die(5).Visible = True
            die(6).Visible = True
        End If
        If RollTimer.Interval > 300 Then
            RollTimer.Stop()
            RandomEvent()
            MoveTimer.Start()
        End If
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        If RBlocker = False Then
            RollTimer.Start()
            RollTimer.Interval = 50
            RBlocker = True
        End If
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click

    End Sub

    Private Sub MoveTimer_Tick(sender As Object, e As EventArgs) Handles MoveTimer.Tick
        If miss = True Then

            miss = False
            MoveTimer.Stop()
            TurnChange()
            TimerStarted = False
            RBlocker = False

        Else
            If TimerStarted = False Then
                Placeholder1 = NumSpot(Turn) + Placeholder
                If Placeholder1 < 0 Then
                    MovingB = True
                End If
                If Placeholder1 = -1 Then
                    NumSpot(Turn) = 31
                    Placeholder1 = 31
                    players(Turn).Left = Spots(NumSpot(Turn)).Left + Dirx(Turn)
                    players(Turn).Top = Spots(NumSpot(Turn)).Top + Diry(Turn)
                End If
                If Placeholder1 = -2 Then
                    NumSpot(Turn) = 31
                    players(Turn).Left = Spots(NumSpot(Turn)).Left + Dirx(Turn)
                    players(Turn).Top = Spots(NumSpot(Turn)).Top + Diry(Turn)
                    Threading.Thread.Sleep(1000)
                    NumSpot(Turn) = 30
                    Placeholder1 = 30
                    players(Turn).Left = Spots(NumSpot(Turn)).Left + Dirx(Turn)
                    players(Turn).Top = Spots(NumSpot(Turn)).Top + Diry(Turn)
                End If
                TimerStarted = True

            End If

            Label15.Text = NumSpot(Turn)
            Label16.Text = Placeholder1
            If MovingB = False Then
                NumSpot(Turn) = NumSpot(Turn) + 1
                If NumSpot(Turn) = 32 Then
                    NumSpot(Turn) = 0
                End If
            End If
            players(Turn).Left = Spots(NumSpot(Turn)).Left + Dirx(Turn)
                players(Turn).Top = Spots(NumSpot(Turn)).Top + Diry(Turn)

                If NumSpot(Turn) = Placeholder1 Then
                    RBlocker = False
                    MoveTimer.Stop()
                    PointManager()
                    MultiplyerManager()
                    TurnChange()
                TimerStarted = False
                MovingB = False
            End If
            End If
    End Sub

    Private Sub TurnChange()
        Turn = Turn + 1
        If Turn = 4 Then
            Turn = 0
        End If
    End Sub
    Private Sub PointManager()
        If Points(Turn) = 100 Then
            MsgBox("Player " & Turn & " Wins!")
        End If

        Points(Turn) = Points(Turn) + Placeholder * NumMultiplyer(Turn)
        PointLbl(Turn).Text = Points(Turn)
    End Sub
    Private Sub MultiplyerManager()
        If NumSpot(Turn) = 1 Or NumSpot(Turn) = 13 Or NumSpot(Turn) = 32 Then
            NumMultiplyer(Turn) = 2
        End If
        If NumSpot(Turn) = 3 Or NumSpot(Turn) = 17 Or NumSpot(Turn) = 26 Then
            NumMultiplyer(Turn) = 1.5
        End If
        If NumSpot(Turn) = 6 Or NumSpot(Turn) = 10 Or NumSpot(Turn) = 23 Then
            NumMultiplyer(Turn) = 0.5
        End If
        If NumSpot(Turn) = 11 Then
            NumSpot(Turn) = 27
            Placeholder = 0
        ElseIf NumSpot(Turn) = 27 Then
            NumSpot(Turn) = 11
            Placeholder = 0
        End If
        Multiplyer(Turn).Text = NumMultiplyer(Turn)
    End Sub

    Private Sub RandomEvent()
        MoveTimer.Stop()
        rEvent = rNum.Next(5, 7)
        If rEvent = 6 Then
            placeholder2 = rNum.Next(1, 4)
            If placeholder2 = 1 Then
                Placeholder = -2
                Label14.Text = "Move back 2 spaces"
            End If
            If placeholder2 = 2 Then
                Placeholder = 0
                miss = True
                Label14.Text = "Miss a turn"
            End If
            If placeholder2 = 3 Then
                Placeholder = -1
                Label14.Text = "Move Back 1 Space"
            End If
        Else
            Label14.Text = "None"
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        idk = InputBox("Are you sure you want to quit? Yes/No?")
        If idk.ToLower = "yes" Then
            Application.Exit()
        End If
    End Sub
End Class