Public Class Form1
    Dim spaces() As Label
    Dim Names(10) As String
    Dim search As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spaces = {lbl0, lbl1, lbl2, lbl3}
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        For i = 0 To 3
            spaces(i).Hide()
        Next
    End Sub

    Private Sub btnask_Click(sender As Object, e As EventArgs) Handles btnask.Click
        For i = 0 To 3
            Names(i) = InputBox("What is your name?")
        Next
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        For i = 0 To 3
            spaces(i).Text = Names(i)
        Next
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        'For i = 0 To 3
        '    If Names(i) = "David" Then
        '        MsgBox("Hi")
        '    End If
        'Next
        search = InputBox("What name are you looking for?")
        For i = 0 To 3
            If Names(i) = search Then
                MsgBox("Hi")
            End If
        Next

    End Sub
End Class
