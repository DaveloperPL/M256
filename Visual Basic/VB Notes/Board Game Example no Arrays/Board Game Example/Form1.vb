Public Class Form1
    Dim roll As Integer
    Dim rnum As New Random


    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click

        Timer1.Start()
        Timer1.Interval = 50
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        roll = rnum.Next(1, 7)
        Label1.Text = roll
        'Timer1.Interval = Timer1.Interval - 50
        'If Timer1.Interval < 100 Then
        '    Timer1.Stop()
        'End If

        'set interval to 50
        Timer1.Interval = Timer1.Interval + 50
        If Timer1.Interval > 400 Then
            Timer1.Stop()
        End If


        'when doing roll in your project, comment out the random number and put roll =1
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
