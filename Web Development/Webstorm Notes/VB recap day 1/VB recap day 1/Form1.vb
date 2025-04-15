Public Class Form1
    Dim ans As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lbl1.Visible = False
        MsgBox("you just hid the box")
        Me.BackColor = Color.Blue
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ans = TextBox1.Text
        If ans = 5 Then
            Label1.Text = "Correct"
        Else
            MsgBox("Wrong")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
