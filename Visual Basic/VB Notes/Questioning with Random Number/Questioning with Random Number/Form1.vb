Public Class Form1
    Dim ans1 As String
    Dim rnum1 As New Random
    Dim rnum2 As New Random
    Dim x As Integer ' I will save rnum1 here
    Dim y As Integer  ' I will save rnum2 here
    Dim ans2 As Integer
    Dim numCorrect As Integer



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblQ1.Text = "Who is the best golfer at Conant?"
        x = rnum1.Next(-5, 6)
        y = rnum2.Next(0, 11)
        lblQ2.Text = "What is " & x & " + " & y & " ?"

    End Sub

    Private Sub btnQ1_Click(sender As Object, e As EventArgs) Handles btnQ1.Click
        ans1 = TextBox1.Text
        If ans1.ToLower = "nicolas" Then
            lblCheck1.Text = "correct"
            numCorrect = numCorrect + 1
            lblNumCorrect.Text = numCorrect
            lblCheck1.ForeColor = Color.Green
        Else
            lblCheck1.Text = "Incorrect"
            lblCheck1.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnQ2_Click(sender As Object, e As EventArgs) Handles btnQ2.Click
        ans2 = TextBox2.Text
        If ans2 = x + y Then
            lblCheck2.Text = "Correct"
            lblCheck2.ForeColor = Color.Green
            numCorrect = numCorrect + 1
            lblNumCorrect.Text = numCorrect
        Else
            lblCheck2.Text = "Incorrect"
            lblCheck2.ForeColor = Color.Red
        End If
    End Sub
End Class
