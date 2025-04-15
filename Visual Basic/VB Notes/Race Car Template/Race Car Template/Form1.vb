Public Class Form1
    Dim Rnum As New Random
    Dim Finished(3) As Boolean
    Dim carPlace As Integer
    Dim Cars() As Label
    Dim Places() As Label
    Dim Time() As Label
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For i = 0 To 3
            If Cars(i).Right >= finishLine.Left And Finished(i) = False Then
                Finished(i) = True
                carPlace = carPlace + 1
                Places(i).Text = carPlace
            ElseIf Finished(i) = False Then
                Cars(i).Left = Cars(i).Left + Rnum.Next(5, 11)
            End If
        Next
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cars = {Car1, Car2, Car3, Car4}
        Time = {Time1, Time2, Time3, Time4}
        Places = {Place1, Place2, Place3, Place4}
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        For i = 0 To 3
            If Finished(i) = False Then
                Time(i).Text = Time(i).Text + 0.01
            End If
            If Finished(i) = False Then
                Time(i).Text = Time(i).Text + 0.01
            End If
        Next

    End Sub
End Class
