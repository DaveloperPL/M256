Public Class SeedSelector
    Public Wheat As Integer
    Public BlueBerry As Integer
    Public StrawBerry As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label30.Text = "Money: $" & Farm.money
        If Farm.SeedSelected = "Wheat" Then
            Farm.SeedAmount.Text = Wheat
        End If
        If Farm.SeedSelected = "BlueBerry" Then
            Farm.SeedAmount.Text = BlueBerry
        End If
        If Farm.SeedSelected = "StrawBerry" Then
            Farm.SeedAmount.Text = StrawBerry
        End If
        Label31.Text = "Seed Amount: " & Wheat
        Label32.Text = "Seed Amount: " & BlueBerry
        Label33.Text = "Seed Amount: " & StrawBerry

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Farm.money >= 1 Then
            Farm.money = Farm.money - 1
            Wheat = Wheat + 1
        Else
            MsgBox("Not enough Money!")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Farm.SeedSelected = "Wheat"
        Farm.SeedAmounts = Wheat
        Me.Hide()
        Farm.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Farm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Farm.money >= 10 Then
            Farm.money = Farm.money - 10
            BlueBerry = BlueBerry + 1
        Else
            MsgBox("Not enough Money!")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Farm.money >= 25 Then
            Farm.money = Farm.money - 25
            StrawBerry = StrawBerry + 1
        Else
            MsgBox("Not enough Money!")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Farm.SeedSelected = "BlueBerry"
        Farm.SeedAmount.Text = BlueBerry
        Me.Hide()
        Farm.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Farm.SeedSelected = "StrawBerry"
        Farm.SeedAmount.Text = StrawBerry
        Me.Hide()
        Farm.Show()
    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click

    End Sub
End Class