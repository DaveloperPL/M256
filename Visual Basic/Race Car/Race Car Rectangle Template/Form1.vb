Public Class Form1
    Dim carRight(3) As Boolean
    Dim carLeft(3) As Boolean
    Dim carDown(3) As Boolean
    Dim carUp(3) As Boolean
    Dim dirx(3) As Integer
    Dim diry(3) As Integer
    Dim rNum As New Random
    Dim Cars() As Label
    Dim Laps(3) As Integer
    Dim lblsLaps() As Label
    Dim numPlaces As Integer
    Dim LblsPlace() As Label
    Dim lblsTime() As Label
    Dim carFinished(3) As Boolean
    Dim PlaceHolder As Integer
    Dim carNames(3) As String
    Dim NumLaps As Integer
    Dim CarColors(3) As String
    Dim lblCarLbls() As Label
    Dim FlatTire As Integer
    Dim PlaceHolder2 As Integer
    Dim Colors As Color
    Dim Placeholder3 As Integer
    Dim PdirX As Integer
    Dim PdirY As Integer
    Dim test As Integer
    Dim carDisable(4) As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCarLbls = {Label1, Label2, Label3, Label4}
        Cars = {Car1, Car2, Car3, Car4}
        For i = 0 To 3
            dirx(i) = rNum.Next(2, 5)
            diry(i) = rNum.Next(2, 5)
        Next
        RMultiplyer.Start()
        lblsLaps = {Laps1, Laps2, Laps3, Laps4}
        LblsPlace = {Place1, Place2, Place3, Place4}
        lblsTime = {Time1, Time2, Time3, Time4}
        NumLaps = 1
        CarColors = {"Red", "Orange", "Yellow", "Green"}
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        For i = 0 To 3
            carRight(i) = True
        Next
        Timer1.Start()
        Timer3.Start()
        TireTimer.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        For i = 0 To 3
            lblsLaps(i).Text = Laps(i)
        Next

        For i = 0 To 3
            If carRight(i) = True Then
                Cars(i).Left = Cars(i).Left + dirx(i)
                If Cars(i).Right >= RightBumper.Left Then
                    carRight(i) = False
                    carDown(i) = True
                End If
            End If

            If carDown(i) = True Then
                Cars(i).Top = Cars(i).Top + diry(i)
                If Cars(i).Bottom >= BottomBumper.Top Then
                    carDown(i) = False
                    carLeft(i) = True
                End If
            End If

            If carLeft(i) = True Then
                Cars(i).Left = Cars(i).Left - dirx(i)
                If Cars(i).Left <= LeftBumper.Right Then
                    carLeft(i) = False
                    carUp(i) = True
                End If
            End If

            If carUp(i) = True Then
                Cars(i).Top = Cars(i).Top - diry(i)
                If Cars(i).Top <= topBumper.Bottom Then
                    Laps(i) = Laps(i) + 1
                    If Laps(i) = NumLaps Then
                        carUp(i) = False
                        numPlaces = numPlaces + 1
                        LblsPlace(i).Text = numPlaces
                        carFinished(i) = True
                    Else
                        carUp(i) = False
                        carRight(i) = True
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles RMultiplyer.Tick
        For i = 0 To 3
            If carDisable(0) = False Then
                dirx(0) = rNum.Next(2, 5)
                diry(0) = rNum.Next(2, 5)
            End If
            If carDisable(1) = False Then
                dirx(1) = rNum.Next(2, 5)
                diry(1) = rNum.Next(2, 5)
            End If
            If carDisable(2) = False Then
                dirx(2) = rNum.Next(2, 5)
                diry(2) = rNum.Next(2, 5)
            End If
            If carDisable(3) = False Then
                dirx(3) = rNum.Next(2, 5)
                diry(3) = rNum.Next(2, 5)
            End If
        Next
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        For i = 0 To 3
            If carFinished(i) = False Then
                lblsTime(i).Text = lblsTime(i).Text + 0.01
            End If
        Next
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        For i = 0 To 3
            If carFinished(0) = True And carFinished(1) = True And carFinished(2) = True And carFinished(3) = True Then
                carRight(i) = True
                Laps(i) = 0
                numPlaces = 0
                lblsTime(i).Text = 0
                lblsLaps(i).Text = 0
                LblsPlace(i).Text = 0
                lblCarLbls(i).Text = CarColors(i)
            End If

        Next
        If carFinished(0) = True And carFinished(1) = True And carFinished(2) = True And carFinished(3) = True Then
            Timer1.Stop()
            Timer3.Stop()
            TireTimer.Stop()
        End If
        For i = 0 To 3
            carFinished(i) = False
        Next
    End Sub

    Private Sub RandomMultiplyer_Tick(sender As Object, e As EventArgs) Handles RandomMultiplyer.Tick
        For i = 0 To 3
            PlaceHolder = rNum.Next(1, 4)
            If PlaceHolder = 1 Then
                dirx(i) = dirx(i) * 0.5
                diry(i) = diry(i) * 0.5
            End If
            If PlaceHolder = 2 Then
                dirx(i) = dirx(i) * 1
                diry(i) = diry(i) * 1
            End If
            If PlaceHolder = 3 Then
                dirx(i) = dirx(i) * 2
                diry(i) = diry(i) * 2
            End If
        Next
    End Sub

    Private Sub Setlaps_Click(sender As Object, e As EventArgs) Handles Setlaps.Click
        NumLaps = InputBox("How many laps would you like the cars to do?")
    End Sub

    Private Sub SetcarNames_Click(sender As Object, e As EventArgs) Handles SetcarNames.Click
        For i = 0 To 3
            carNames(i) = InputBox("What name would you like for the " & CarColors(i) & " Car?")
            lblCarLbls(i).Text = carNames(i)
        Next
    End Sub

    Private Sub TireTimer_Tick(sender As Object, e As EventArgs) Handles TireTimer.Tick
        For i = 0 To 3
            If carFinished(i) = False Then
                FlatTire = rNum.Next(3, 6)
                If FlatTire = 5 Then
                    PlaceHolder2 = rNum.Next(0, 4)
                    Colors = Cars(PlaceHolder2).BackColor
                    PdirX = dirx(PlaceHolder2)
                    PdirY = diry(PlaceHolder2)
                    dirx(PlaceHolder2) = 0
                    diry(PlaceHolder2) = 0
                    Timer2.Start()
                    carDisable(PlaceHolder2) = True
                    Cars(PlaceHolder2).BackColor = Color.Black
                End If
            End If
        Next
    End Sub

    Private Sub Timer2_Tick_1(sender As Object, e As EventArgs) Handles Timer2.Tick
        carDisable(0) = False
        carDisable(1) = False
        carDisable(2) = False
        carDisable(3) = False
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        'carFinished(PlaceHolder2) = True
        'Colors = Cars(PlaceHolder2).BackColor
        'Cars(PlaceHolder2).BackColor = Color.Black
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If carDisable(0) = False Then
            dirx(0) = rNum.Next(2, 5)
            diry(0) = rNum.Next(2, 5)
            Cars(0).BackColor = Color.FromArgb(192, 255, 192)
        End If
        If carDisable(1) = False Then
            dirx(1) = rNum.Next(2, 5)
            diry(1) = rNum.Next(2, 5)
            Cars(1).BackColor = Color.FromArgb(255, 255, 192)
        End If
        If carDisable(2) = False Then
            dirx(2) = rNum.Next(2, 5)
            diry(2) = rNum.Next(2, 5)
            Cars(2).BackColor = Color.FromArgb(255, 224, 192)
        End If
        If carDisable(3) = False Then
            dirx(3) = rNum.Next(2, 5)
            diry(3) = rNum.Next(2, 5)
            Cars(3).BackColor = Color.FromArgb(255, 192, 192)
        End If
    End Sub
End Class
