Public Class Form2
    Dim secret As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        hero.HP = hero.MaxHP
        Form1.lblHeroHP.Text = hero.HP
        MsgBox("You are now max HP")
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Money >= 100 Then
            hero.MaxHP = hero.MaxHP + 50
            Money = Money - 100
            Label2.Text = Money
        Else
            MsgBox("Not enough Coins! You need " & 100 - Money & " more Coins!")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Money >= 50 Then
            hero.offense = hero.offense + 5
            Money = Money - 50
            Label2.Text = Money
        Else
            MsgBox("Not enough Coins! You need " & 50 - Money & " more Coins!")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Money >= 100 Then
            hero.offense = hero.offense + 10
            Money = Money - 100
            Label2.Text = Money
        Else
            MsgBox("Not enough Coins! You need " & 100 - Money & " more Coins!")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Money >= 50 Then
            hero.defense = hero.defense + 5
            Money = Money - 50
            Label2.Text = Money
        Else
            MsgBox("Not enough Coins! You need " & 50 - Money & " more Coins!")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Money >= 100 Then
            hero.defense = hero.defense + 10
            Money = Money - 100
            Label2.Text = Money
        Else
            MsgBox("Not enough Coins! You need " & 100 - Money & " more Coins!")
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Money >= 50 Then
            Multiplyer = Multiplyer + 2
            Money = Money - 50
            Label2.Text = Money
        Else
            MsgBox("Not enough Coins! You need " & 50 - Money & " more Coins!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.lblHeroHP.Text = hero.HP
        Form1.lblHeroOffense.Text = hero.offense
        Form1.lblHeroDefense.Text = hero.defense
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        secret = secret + 1
        If secret > 5 Then
            Me.Hide()
            Form3.Show()
        End If
    End Sub
End Class