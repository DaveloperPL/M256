Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        x = rNum.Next(0, 11)
        y = rNum.Next(0, 11)
        lblQ1.Text = "What is " & x & " x " & y & "?"
        Q1Answer = x * y
        'Sets random number and Creates equation also, sets Q1Answer to the correct answer
        a = rNum.Next(0, 51)
        b = rNum.Next(0, 51)
        lblQ4.Text = "What is " & a & " + " & b & "?"
        Q4Answer = a + b
        'Sets random number and Creates equation also, sets Q4Answer to the correct answer

    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Correct = "0"
        Percent = "0"



        If txtbxQ1.Text = Empty Then
            lbl.ForeColor = Color.Red
            lbl.Text = "❌"
            lbl.Visible = True
        Else
            If txtbxQ1.Text = Q1Answer Then
                lbl.ForeColor = Color.Green
                lbl.Text = "✔"
                lbl.Visible = True
                Correct = Correct + 1
            Else
                lbl.ForeColor = Color.Red
                lbl.Text = "❌"
                lbl.Visible = True
            End If
        End If
            If txtbxQ2.Text.ToLower = "october" Then
            lbl2.ForeColor = Color.Green
            lbl2.Text = "✔"
            lbl2.Visible = True
            Correct = Correct + 1
        Else
            lbl2.ForeColor = Color.Red
            lbl2.Text = "❌"
            lbl2.Visible = True
        End If
        If txtbxQ3.Text.ToLower = "apple" Then
            lbl3.ForeColor = Color.Green
            lbl3.Text = "✔"
            lbl3.Visible = True
            Correct = Correct + 1
        Else
            lbl3.ForeColor = Color.Red
            lbl3.Text = "❌"
            lbl3.Visible = True
            Incorrect = Incorrect + 1
        End If
        If txtbxQ4.Text = Empty Then
            lbl4.ForeColor = Color.Red
            lbl4.Text = "❌"
            lbl4.Visible = True
        Else
            If txtbxQ4.Text = Q4Answer Then
                lbl4.ForeColor = Color.Green
                lbl4.Text = "✔"
                lbl4.Visible = True
                Correct = Correct + 1
            Else
                lbl4.ForeColor = Color.Red
                lbl4.Text = "Incorrect"
                lbl4.Visible = True
            End If
        End If

        Correct = Correct * 100
        Percent = Correct / 4
        If Percent <= 50 Then
            lblPercent.Text = Percent
            lblPercent.Visible = True
            lblPercent.ForeColor = Color.Red
            lblAnimation.Visible = True
            lblAnimation.Text = "😟"
            lblAnimation.ForeColor = Color.Red
        Else
            lblPercent.Text = Percent
            lblPercent.Visible = True
            lblPercent.ForeColor = Color.Green
            lblAnimation.Visible = True
            lblAnimation.Text = "😃"
            lblAnimation.ForeColor = Color.Green
        End If

        If Percent >= 75 Then
            lblPercent.Text = "Good Job! You Got " & Percent & "%"
        Else
            lblPercent.Text = "Try Again! You Got " & Percent & "%"
        End If

        btnSubmit.Enabled = False
        btnReset.Enabled = True
        btnReset.Visible = True

        'Checks if Percent = 100 If so then user gets sent to form 2
        If Percent = 100 Then
            Me.Hide()
            Form2.Show()
        End If

    End Sub

    Private Sub lblQ1_Click(sender As Object, e As EventArgs) Handles lblQ1.Click

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Prevents Anyone click the button after the first time
        btnReset.Enabled = False
        btnReset.Visible = False

        'When the reset Button is clicked, New numbers and questions generated. V
        x = rNum.Next(0, 11)
        y = rNum.Next(0, 11)
        lblQ1.Text = "What is " & x & " x " & y & "?"
        Q1Answer = x * y
        'Sets random number and Creates equation also, sets Q1Answer to the correct answer ^


        a = rNum.Next(0, 51)
        b = rNum.Next(0, 51)
        lblQ4.Text = "What is " & a & " + " & b & "?"
        Q4Answer = a + b
        'Sets random number and Creates equation also, sets Q4Answer to the correct answer ^

        'Sets all labels not visible
        lblAnimation.Visible = False
        lblPercent.Visible = False
        lbl.Visible = False
        lbl2.Visible = False
        lbl3.Visible = False
        lbl4.Visible = False

        'Sets all textboxes to nothing
        txtbxQ1.Text = ""
        txtbxQ2.Text = ""
        txtbxQ3.Text = ""
        txtbxQ4.Text = ""

        'Allows Submit to be clicked
        btnSubmit.Enabled = True
    End Sub

    Private Sub lbl4_Click(sender As Object, e As EventArgs) Handles lbl4.Click

    End Sub
End Class
