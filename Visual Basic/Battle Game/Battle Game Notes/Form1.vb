Public Class Form1
    Dim rnum As New Random
    Dim rnum2 As New Random
    Dim enemyNum As Integer
    Dim enemyNames(5) As String
    Dim Battling As Boolean
    Dim num1 As Integer
    Dim num2 As Integer
    Dim turn As Integer
    Dim dmg As Integer
    Dim enemyFought(5) As Boolean
    Dim MoneyAdded As Integer
    Dim total As Integer
    Dim HeroBar As Double
    Dim VillanBar As Double
    Dim placeholder As Integer
    Dim placeholder2 As Integer
    'you will probably make multipliers for many things



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'chooseEnemy()
        'setEnemy()
        'setStats()   'Use all of this if you want to randomly pick your enemy
        'setLabels()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hero.MaxHP = 250
        enemy(enemyNum).MaxHP = 200
        enemyNames = {"The Riddler", "Joker", "Scarecrow", "Penguin", "Bane", " Mr. Freeze"}
        For i = 0 To 5
            enemyFought(i) = False
        Next
        hero.HP = 250
        hero.defense = rnum.Next(2, 7)
        hero.offense = rnum.Next(2, 26)
        Multiplyer = 1
    End Sub

    Public Sub setEnemy()
        lblVillian.Text = enemyNames(enemyNum)
    End Sub

    Public Sub setStats()
        If enemyFought(enemyNum) = False Then
            enemy(enemyNum).HP = 200
            enemy(enemyNum).defense = rnum.Next(1, 6)
            enemy(enemyNum).offense = rnum.Next(1, 25)
        Else
            MsgBox(enemyNames(enemyNum) & " was already defeated! Pick a different Hero")
        End If
    End Sub
    Public Sub setLabels()
        lblHeroHP.Text = hero.HP
        lblHeroDefense.Text = hero.defense
        lblHeroOffense.Text = hero.offense
        lblEnemyHP.Text = enemy(enemyNum).HP
        lblEnemyDefense.Text = enemy(enemyNum).defense
        lblEnemyOffense.Text = enemy(enemyNum).offense

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        enemyNum = ListBox1.SelectedIndex  ' this replaces randomly picking enemy
        setEnemy()
        setStats()
        setLabels()
    End Sub

    Private Sub btnBattle_Click(sender As Object, e As EventArgs) Handles btnBattle.Click
        If enemyFought(enemyNum) = False Then
            FightTimer.Start()
        Else
            MsgBox("Choose a different Villan!")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles FightTimer.Tick
        Battling = True
        If Battling = True Then
            num1 = rnum.Next(2, 7)
            num2 = rnum2.Next(1, 8)
            If num2 = 7 Then
                num2 = num2 - 1
            End If
            Label8.Text = num1
            Label9.Text = num2
            If num1 < num2 Then
                dmg = num2 - num1
                turn = 2
            ElseIf num2 < num1 Then
                dmg = num1 - num2
                turn = 1
            End If
            FightTimer.Start()
        Else
            FightTimer.Stop()
        End If
        If turn = 1 Then
            dmg = dmg * hero.offense
            dmg = dmg / enemy(enemyNum).defense
            Math.Round(dmg)
            enemy(enemyNum).HP = enemy(enemyNum).HP - dmg
            lblEnemyHP.Text = enemy(enemyNum).HP
        ElseIf turn = 2 Then
            dmg = dmg * enemy(enemyNum).offense
            dmg = dmg / hero.defense
            Math.Round(dmg)
            hero.HP = hero.HP - dmg
            lblHeroHP.Text = hero.HP
        End If

        If hero.MaxHP <> hero.HP And hero.HP > 0 Then
            HeroBar = hero.HP / hero.MaxHP
            HeroBar = HeroBar * 100
            placeholder = Math.Floor(HeroBar)
            ProgressBar1.Value = placeholder
        End If

        If enemy(enemyNum).MaxHP <> enemy(enemyNum).HP And enemy(enemyNum).HP > 0 Then
            VillanBar = enemy(enemyNum).HP / 200
            VillanBar = VillanBar * 100
            placeholder2 = Math.Floor(VillanBar)
            ProgressBar2.Value = placeholder2
        End If

        If enemy(enemyNum).HP < 0 Then
            enemy(enemyNum).HP = 0
            lblEnemyHP.Text = enemy(enemyNum).HP
            Battling = False
            FightTimer.Stop()
            MsgBox("Batman wins")
            MoneyAdded = rnum.Next(25, 51)
            total = (MoneyAdded + 50) * Multiplyer
            MsgBox(enemyNames(enemyNum) & " dropped " & MoneyAdded & " coins!")
            MsgBox("Here are " & 50 * Multiplyer & " Coins for defeating " & enemyNames(enemyNum))
            Money = Money + total
            enemyFought(enemyNum) = True
        ElseIf hero.HP < 0 Then
            hero.HP = 0
            lblHeroHP.Text = hero.HP
            Battling = False
            MsgBox(enemyNames(enemyNum) & " wins")
            FightTimer.Stop()
        End If
        turn = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
        Form2.Label2.Text = Money
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If enemyFought(1) = True And enemyFought(2) = True And enemyFought(3) = True And enemyFought(4) = True And enemyFought(5) = True And enemyFought(0) = True Then
            For i = 0 To 5
                enemyFought(i) = False
                enemy(i).HP = 200
                enemy(i).defense = rnum.Next(1, 6)
                enemy(i).offense = rnum.Next(1, 25)
            Next
        End If
    End Sub
End Class
