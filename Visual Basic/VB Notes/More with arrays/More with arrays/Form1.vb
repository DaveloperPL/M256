Public Class Form1
    Dim Names(3) As String
    Dim pturn As Integer

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Names(0) = "A"
        Names(1) = "B"
        Names(2) = "C"
        Names(3) = InputBox("What is your name?")
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        lbl.Text = Names(pturn)
        pturn = pturn + 1
        If pturn = 4 Then
            pturn = 0
        End If

    End Sub
End Class
