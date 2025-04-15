Public Class Form1
    Private Sub BtnStuff_Click(sender As Object, e As EventArgs) Handles BtnStuff.Click
        lblChange.Text = "i am glad you are back!"
        lblChange.ForeColor = Color.Yellow
        lblChange.BackColor = Color.Black
        MsgBox("Happy Monday!")
    End Sub

    Private Sub bntNext_Click(sender As Object, e As EventArgs) Handles bntNext.Click
        Me.Hide()
        Form2.Show()

    End Sub
End Class
