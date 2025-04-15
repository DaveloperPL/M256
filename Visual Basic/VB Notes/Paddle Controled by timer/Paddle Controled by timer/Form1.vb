Public Class Form1
    Dim mUp As Boolean
    Dim mDown As Boolean


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.W Then
            mUp = True
        End If
        If e.KeyCode = Keys.S Then
            mDown = True
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If mUp = True Then
            lblPaddle.Top = lblPaddle.Top - 2
        End If
        If mDown = True Then
            lblPaddle.Top = lblPaddle.Top + 2
        End If

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        mUp = False
        mDown = False
    End Sub

    Private Sub HelloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelloToolStripMenuItem.Click
        MsgBox("MenuStrip Is Just Like A Button")
    End Sub
End Class
