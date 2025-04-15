﻿Public Class Form2
    Dim roll As Integer
    Dim spaces() As Label
    'Dim p1spot As Integer  'keeping track Of where 1St player Is
    'Dim p2spot As Integer
    Dim pturn As Integer
    Dim spots(3) As Integer
    Dim answer As String

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        'roll = 1 'eventually make this random
        roll = TextBox1.Text 'great for debugging, NOT FOR TURNED IN PROJECT
        lblRoll.Text = roll
        'p1spot = p1spot + roll
        'If pturn = 0 Then
        '   p1spot = p1spot + roll
        'ElseIf pturn = 1 Then
        '   p2spot = p2spot + roll
        'End If

        spots(pturn) = spots(pturn) + roll

        CheckWinEnd()
        movePiece()
        checkSpace()
        changeTurns()


        'need to move p0 by using top and left!!!!

        'p0.Left = s4.Left
        'p0.Top = s4.Top            way tooooooooooooo specific

        'p0.Left = spaces(4).Left
        'p0.Top = spaces(4).Top     too specific
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spaces = {s0, s1, s2, s3, s4, s5, s6, s7, s8, s9, s10}
        pturn = 0 'this means its player 1's turn . can randomize later

    End Sub

    Private Sub movePiece()
        If pturn = 0 Then
            p1.Left = spaces(spots(pturn)).Left
            p1.Top = spaces(spots(pturn)).Top
        ElseIf pturn = 1 Then
            p2.Left = spaces(spots(pturn)).Left + spaces(spots(pturn)).Width - p2.Width
            p2.Top = spaces(spots(pturn)).Top
        End If



        'p1.Left = spaces(p1spot).Left
        'p1.Top = spaces(p1spot).Top          this is for the top/left piece

        'p1.Left = spaces(p1spot).Left + spaces(p1spot).Width - p1.Width
        'p1.Top = spaces(p1spot).Top           this is for the top/right piece


        'p1.Left = spaces(p1spot).Left + spaces(p1spot).Width - p1.Width
        'p1.Top = spaces(p1spot).Top + spaces(p1spot).Height - p1.Height    bottom/right piece

        'p1.Left = spaces(p1spot).Left
        'p1.Top = spaces(p1spot).Top + spaces(p1spot).Height - p1.Height    bottom/left

    End Sub

    Private Sub checkSpace()
        If spots(pturn) = 3 Then
            s3.BackColor = Color.Pink
        ElseIf spots(pturn) = 5 Or spots(pturn) = 8 Then
            spots(pturn) = spots(pturn) + 2
            waitSec()
            movePiece()
        ElseIf spots(pturn) = 10 Then
            answer = InputBox("What month are we in?")
            If answer.ToLower = "december" Then
                spots(pturn) = spots(pturn) + 1
            End If
        End If

        'If pturn = 0 Then
        '    If p1spot = 3 Then
        '        s3.BackColor = Color.Pink
        '    ElseIf p1spot = 5 Or p1spot = 8 Then
        '        p1spot = p1spot + 2
        '        movePiece()
        '    End If
        'ElseIf pturn = 1 Then
        '    If p2spot = 3 Then
        '        s3.BackColor = Color.Pink
        '    ElseIf p2spot = 5 Or p2spot = 8 Then
        '        p2spot = p2spot + 2
        '        movePiece()
        '    End If
        'End If
    End Sub

    Private Sub changeTurns()
        pturn = pturn + 1
        If pturn > 1 Then
            pturn = 0
        End If
    End Sub

    Private Sub CheckWinEnd()
        If spots(pturn) > 10 Then
            MsgBox("Player " & pturn & " Wins!")
            spots(pturn) = spots(pturn) - 11
        End If

        'If pturn = 0 Then
        '    If p1spot > 10 Then
        '        'MsgBox("Player 1 wins!")
        '        p1spot = p1spot - 11
        '    End If
        'ElseIf pturn = 1 Then
        '    If p2spot > 10 Then
        '        'MsgBox("Player 2 wins!")
        '        p2spot = p2spot - 11
        '    End If
        'End If
    End Sub

    Private Sub waitSec()
        Threading.Thread.Sleep(1000)
    End Sub
End Class