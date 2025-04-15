Public Class Form2
    Dim rnum As New Random
    Dim roll As Integer
    Dim spaces() As Label
    Dim p1Spot As Integer
    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        roll = rnum.Next(1, 7)
        lblRoll.Text = roll
        p1Spot = roll + p1Spot
        If p1Spot > 1 Then
            p1Spot = 9
        End If
        movePiece()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spaces = {S0, S1, S2, S3, S4, S5, S6, S7, S8, S9, S10}

    End Sub

    Private Sub movePiece()
        P1.Left = spaces(p1Spot).Left
        P1.Top = spaces(p1Spot).Top
    End Sub
End Class