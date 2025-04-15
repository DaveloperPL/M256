Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Welcome to the bonus round! Here you will answer math questions and you will be timed! Press Enter to submit answers! Good luck!")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBegin.Click
        lblNumCorrect.Visible = True
        lblNumCorrect1.Visible = True
        lblQuestion.Visible = True
        lblTime.Visible = True
        lblTimer.Visible = True
        lblWelcome.Visible = False
        btnBegin.Visible = False
        txtbxQuestion.Visible = True
        Time = 30
        Timer1.Start()

        Num3 = rNum.Next(1, 3)
        If Num3 = 1 Then
            Num1 = rNum.Next(0, 11)
            Num2 = rNum.Next(0, 11)
            Answer1 = Num1 * Num2
            lblQuestion.Text = "What Is " & Num1 & " X " & Num2 & "?"
            'Creates Random number 1-2 If its 1 its a multipication question
        Else
            Num1 = rNum.Next(0, 51)
            Num2 = rNum.Next(0, 51)
            lblQuestion.Text = "What Is " & Num1 & " + " & Num2 & "?"
            Answer1 = Num1 + Num2
        End If

    End Sub

    Private Sub lblTime_Click(sender As Object, e As EventArgs) Handles lblTime.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblNumCorrect.Text = Score
        Time = Time - 1
        lblTimer.Text = Time
        If Time <= 0 Then
            MsgBox("Times Up! You Got " & Score & " Questions Correct!")
            Timer1.Stop()
        End If
    End Sub

    Private Sub txtbxQuestion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxQuestion.KeyPress
        If Keys.Enter Then

        End If
    End Sub
    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtbxQuestion.Text = Empty Then
                MsgBox("Remember To Type Your Answer Into The Text Box!")
            Else
                If txtbxQuestion.Text = Answer1 Then
                    Score = Score + 1
                    Time = 30
                    lblTimer.Text = Time
                    Num3 = rNum.Next(1, 3)
                    If Num3 = 1 Then
                        Num1 = rNum.Next(0, 11)
                        Num2 = rNum.Next(0, 11)
                        Answer1 = Num1 * Num2
                        lblQuestion.Text = "What Is " & Num1 & " X " & Num2 & "?"
                        'Creates Random number 1-2 If its 1 its a multipication question
                    Else
                        Num1 = rNum.Next(0, 51)
                        Num2 = rNum.Next(0, 51)
                        lblQuestion.Text = "What Is " & Num1 & " + " & Num2 & "?"
                        Answer1 = Num1 + Num2
                    End If
                Else
                    Timer1.Stop()
                    MsgBox("Game Over! You Got " & Score & " Points")

                    txtbxQuestion.Enabled = False
                End If
            End If
        End If
    End Sub

End Class
