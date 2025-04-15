Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Money >= 1000 Then
            Multiplyer = Multiplyer + 40
            Money = Money - 1000
        Else
            MsgBox("Not enough Coins! You need " & 1000 - Money & " more Coins!")
        End If
    End Sub
End Class