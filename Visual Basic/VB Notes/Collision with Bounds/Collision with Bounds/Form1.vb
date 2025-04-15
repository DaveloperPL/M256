Public Class Form1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.A Then
            Label1.Left = Label1.Left - 10
        End If
        If e.KeyCode = Keys.D Then
            Label1.Left = Label1.Left + 10
        End If
        If e.KeyCode = Keys.W Then
            Label1.Top = Label1.Top - 10
        End If
        If e.KeyCode = Keys.S Then
            Label1.Top = Label1.Top + 10
        End If

        If Label1.Bounds.IntersectsWith(Label2.Bounds) Then
            MsgBox("We Collided")
        End If


    End Sub
End Class
