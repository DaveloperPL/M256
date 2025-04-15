Public Class Form1
    Dim spaces() As Label '() tells pc that its a array

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spaces = {Label4, Label3, Label5, Label2, Label1}
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'spaces(2).Text = "Hello"
        'spaces(0).Text = 6
        'spaces(4).BackColor = Color.Red
        For i = 0 To 4
            spaces(i).Text = "Pogg"
        Next
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For i = 0 To 4
            spaces(i).Top = spaces(i).Top + 1
        Next
    End Sub
End Class
