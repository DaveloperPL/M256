Public Class Form1
    'Your goal is to transition this code into arrays. You will need to make 2 new arrays
    Dim Cars(4) As String
    Dim MoveCar() As Label
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To 4
            MoveCar(i).Text = Cars(i)
        Next
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For i = 0 To 4
            MoveCar(i).Left = MoveCar(i).Left + 1
            If MoveCar(i).Right > Label6.Left Then
                Timer1.Stop()
            End If
        Next
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Start()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MoveCar = {Label1, Label2, Label3, Label4, Label5}
        Cars = {"Acura", "Ford", "Toyota", "Tesla", "Hyundai"}
    End Sub
End Class