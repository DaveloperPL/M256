Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        name1 = InputBox("What is your name?")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To 4
            list = list & ", "
        Next
        Label1.Text = name1 & " you need to pack " & list
    End Sub
End Class