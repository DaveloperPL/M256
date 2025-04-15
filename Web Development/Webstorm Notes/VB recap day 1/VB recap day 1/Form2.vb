Public Class Form2
    Dim rnum1 As New Random
    Dim rnum2 As New Random
    Dim x As Integer
    Dim y As Integer
    Dim ans As Integer
    Dim ans2 As String
    Dim numCorrect As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ans = x + y
        If TextBox1.Text = ans Then
            MsgBox("Correct!")
            numCorrect = numCorrect + 1
        Else
            MsgBox("Incorrect")
        End If
        ans2 = "no"
        If ans2 = "no" Then
            MsgBox("Correct")
            numCorrect = numCorrect + 1
        Else
            MsgBox("Inccorect")
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        x = rnum1.Next(0, 10)
        y = rnum2.Next(-5, 6)
        Label1.Text = "What is " & x & " + " & y & "?"
        Label2.Text = "Are you exited about todays snow?"
    End Sub
End Class