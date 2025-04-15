Public Class Form1
    Dim spaces(10) As Label
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To 3
            spaces(i).Text = "9 School days left till break"
            spaces(i).Left = spaces(i).Left + 5
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spaces = {Label1, Label2, Label3, Label4}
    End Sub
End Class
