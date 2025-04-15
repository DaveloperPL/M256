Public Class Form1
    Dim appetizers(3) As String
    Dim costApps(3) As Double
    Dim Entrees(4) As String
    Dim CostE(4) As Double
    Dim drinks(3) As String
    Dim costD(3) As Double
    Dim appButtons(3) As Button
    Dim EntreeButtons(4) As Button
    Dim DrinkButtons(3) As Button
    Dim Cost As Double
    Dim PaidWith As Double
    Dim Tax As Double
    Dim Total As Double
    Dim change As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        appetizers = {"mozz sticks", "Chips and guac.", "Bread sticks"}
        costApps = {"5", "8.50", "4.75"}
        Entrees = {"Burrito Bowl", "Pizza", "Burger", "Wings"}
        CostE = {"9.25", "15.75", "10.50", "12.50"}
        drinks = {"Small", "Medium", "Large"}
        costD = {"2.5", "3.50", "5"}
        appButtons = {Button1, Button2, Button3}
        EntreeButtons = {Button4, Button5, Button6, Button7}
        DrinkButtons = {Button8, Button9, Button10}
        For i = 0 To 2
            appButtons(i).Text = appetizers(i)
            DrinkButtons(i).Text = drinks(i)
        Next
        For i = 0 To 3
            EntreeButtons(i).Text = Entrees(i)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.BackColor = Color.Red
        Label4.Text = appetizers(0)
        Label7.Text = costApps(0)
        Cost = Cost + costApps(0)
        Label11.Text = Cost
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.BackColor = Color.Red
        Label4.Text = appetizers(1)
        Label7.Text = costApps(1)
        Cost = Cost + costApps(1)
        Label11.Text = Cost
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.BackColor = Color.Red
        Label4.Text = appetizers(2)
        Label7.Text = costApps(2)
        Cost = Cost + costApps(2)
        Label11.Text = Cost
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.BackColor = Color.Red
        Label5.Text = Entrees(0)
        Label8.Text = CostE(0)
        Cost = Cost + CostE(0)
        Label11.Text = Cost
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button5.BackColor = Color.Red
        Label5.Text = Entrees(1)
        Label8.Text = CostE(1)
        Cost = Cost + CostE(1)
        Label11.Text = Cost
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button6.BackColor = Color.Red
        Label5.Text = Entrees(2)
        Label8.Text = CostE(2)
        Cost = Cost + CostE(2)
        Label11.Text = Cost
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button7.BackColor = Color.Red
        Label5.Text = Entrees(3)
        Label8.Text = CostE(3)
        Cost = Cost + CostE(3)
        Label11.Text = Cost
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button8.BackColor = Color.Red
        Label6.Text = drinks(0)
        Label9.Text = costD(0)
        Cost = Cost + costD(0)
        Label11.Text = Cost
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Button9.BackColor = Color.Red
        Label6.Text = drinks(1)
        Label9.Text = costD(1)
        Cost = Cost + costD(1)
        Label11.Text = Cost
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Button10.BackColor = Color.Red
        Label6.Text = drinks(2)
        Label9.Text = costD(2)
        Cost = Cost + costD(2)
        Label11.Text = Cost
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        PaidWith = TextBox1.Text
        change = PaidWith - Total
        Label16.Text = Math.Round(change, 2)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Tax = 0.0775 * Cost
        Label13.Text = Math.Round(Tax, 2)

        Total = Cost + Tax
        Label15.Text = Math.Round(Total, 2)
    End Sub
End Class
