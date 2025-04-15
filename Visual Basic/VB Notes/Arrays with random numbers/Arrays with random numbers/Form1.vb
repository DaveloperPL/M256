Public Class Form1
    Dim rNum As New Random
    Dim MyNums(9) As Integer
    Dim myRNums As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myRNums = " "
        For i = 0 To 9
            MyNums(i) = rNum.Next(1, 11)
            'Label1.Text = MyNums(i)
            'MsgBox(MyNums(i))
            myRNums = myRNums & MyNums(i) & ", "
            Label1.Text = myRNums
        Next
    End Sub
End Class
