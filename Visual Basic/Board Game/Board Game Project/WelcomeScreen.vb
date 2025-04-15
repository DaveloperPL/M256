Public Class WelcomeScreen
    Dim die() As Label
    Dim rNum As New Random
    Dim Placeholder As Integer
    Dim RBlocker As Boolean
    Dim idk As String
    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        If RBlocker = False Then
            RollTimer.Start()
            RollTimer.Interval = 50
        End If
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
            RBlocker = False
        End If
    End Sub

    Private Sub WelcomeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = ImageList1.Images(0)
        die = {D1, D2, D3, D4, D5, D6, D7}
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        Instructions.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        idk = InputBox("Are you sure you want to quit? Yes/No?")
        If idk.ToLower = "yes" Then
            Application.Exit()
        End If
    End Sub
End Class
