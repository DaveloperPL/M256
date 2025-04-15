Public Class Form1
    Dim name1 As String
    Dim x As Integer
    Dim y As Double 'Use for decimals
    Dim LightsOn As Boolean
    Dim ans1 As String
    Dim ans2 As Integer
    Dim numCorrect As Integer



    Private Sub bntVar_Click(sender As Object, e As EventArgs) Handles bntVar.Click
        name1 = InputBox("What Is Your Name?")
        x = 10
        x = x + 10
        lblChange.Text = name1 & " and his number is " & x
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "What month are we in?"
        Label4.Text = "What is 10+10"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ans1 = TextBox1.Text
        If ans1.ToLower = "october" Then
            Label2.Text = "Correct"
            Label2.ForeColor = Color.Green
            numCorrect = numCorrect + 1
            Label5.Text = numCorrect
        Else
            Label2.Text = "Incorrect"
            Label2.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ans2 = TextBox2.Text
        If ans2 = "20" Then
            Label3.Text = "Correct"
            Label3.ForeColor = Color.Green
            numCorrect = numCorrect + 1
            Label5.Text = numCorrect
        Else
            Label3.Text = "Incorrect"
            Label3.ForeColor = Color.Red
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
