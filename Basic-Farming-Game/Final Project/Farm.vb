Public Class Farm
    Dim Tiles() As Label
    Dim Growing(83) As Boolean
    Dim Direction As String
    Dim MousePosT As Integer
    Dim MousePosL As Integer
    Dim TileNum As Integer
    Dim TileStage(83) As Integer
    Dim TileWater(83) As Boolean
    Dim Justincase As Boolean = False
    Dim HotbarNum As Integer
    Dim MouseClickType As String
    Dim TTOOW(83) As Integer
    Public money As Integer
    Public SeedSelected As String = "None"
    Public SeedAmounts As Integer = 0
    Dim TOSU(83) As String
    Dim NumberPlaceholder As Label
    Dim labelNumber As Integer
    Dim TUG(83) As Integer
    Dim placeholder As Integer
    Dim LabelMove As Label
    Dim TUPG(83) As Integer
    Dim BooleanPlaceholder(83) As Boolean
    Dim AnotherPlaceholder As Integer
    Dim PRTH(83) As Boolean
    Dim plant1(83) As Label
    Dim plant2(83) As Label
    Dim plant3(83) As Label
    Dim plant4(83) As Label
    Dim seed(83) As Label
    Dim plant5(83) As Label
    Dim plant6(83) As Label
    Dim plant7(83) As Label
    Dim plant8(83) As Label
    Dim plant9(83) As Label
    Dim plant10(83) As Label
    Dim TUGB As Integer
    Dim TimeSubtracted(11) As Integer
    Dim MoneyMade(83) As Label
    Dim TileOccupied(83) As Boolean
    Dim Sprinkler(83) As Boolean
    Dim PH As Integer

    'Gets mouse position
    Dim mousePosX As Integer = Farm.MousePosition.X
    Dim mousePosY As Integer = Farm.MousePosition.Y


    Private Sub Farm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tiles = {a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12}
        Justincase = True
        For i = 0 To 83
            Sprinkler(TileNum) = False
            TileOccupied(TileNum) = False
            Growing(i) = False
            TileStage(i) = 0
            Tiles(i).BackColor = Color.FromArgb(0, 192, 0)
            TOSU(i) = "None"
            BooleanPlaceholder(i) = False

            'Makes the seeds
            Dim lbl4 As New Label
            Dim locationx As Integer = Tiles(i).Left + 48
            Dim locationy As Integer = Tiles(i).Top + 10
            lbl4.Size = New System.Drawing.Size(4, 4)
            lbl4.Location = New System.Drawing.Point(locationx, locationy)
            lbl4.Text = ""
            Me.Controls.Add(lbl4)
            lbl4.BackColor = Color.FromArgb(227, 164, 82)
            lbl4.SendToBack()
            lbl4.Name = "Stage1Seed" & i
            seed(i) = lbl4

            'Makes Plants
            'Lower stem
            Dim lbl As New Label
            Dim locationx1 As Integer = Tiles(i).Left + 48
            Dim locationy1 As Integer = Tiles(i).Top + 48
            lbl.Size = New System.Drawing.Size(4, 4)
            lbl.Location = New System.Drawing.Point(locationx1, locationy1)
            lbl.Text = ""
            Me.Controls.Add(lbl)
            lbl.BackColor = Color.FromArgb(0, 192, 0)
            lbl.SendToBack()
            lbl.Name = "Stage2Plant1" & i
            plant1(i) = lbl
            'Upper stem
            Dim lbl2 As New Label
            Dim locationx2 As Integer = Tiles(i).Left + 48
            Dim locationy2 As Integer = Tiles(i).Top + 44
            lbl2.Size = New System.Drawing.Size(4, 4)
            lbl2.Location = New System.Drawing.Point(locationx2, locationy2)
            lbl2.Text = ""
            Me.Controls.Add(lbl2)
            lbl2.BackColor = Color.FromArgb(0, 192, 0)
            lbl2.SendToBack()
            lbl2.Name = "Stage2Plant2" & i
            BooleanPlaceholder(TileNum) = True
            plant2(i) = lbl2
            'Left leaf
            Dim lbl3 As New Label
            Dim locationx3 As Integer = Tiles(i).Left + 44
            Dim locationy3 As Integer = Tiles(i).Top + 40
            lbl3.Size = New System.Drawing.Size(4, 4)
            lbl3.Location = New System.Drawing.Point(locationx3, locationy3)
            lbl3.Text = ""
            Me.Controls.Add(lbl3)
            lbl3.BackColor = Color.FromArgb(0, 192, 0)
            lbl3.SendToBack()
            lbl3.Name = "Stage2Plant3" & i
            plant3(i) = lbl3
            'Right leaf
            Dim lbl5 As New Label
            Dim locationx4 As Integer = Tiles(i).Left + 52
            Dim locationy4 As Integer = Tiles(i).Top + 38
            lbl5.Size = New System.Drawing.Size(4, 4)
            lbl5.Location = New System.Drawing.Point(locationx4, locationy4)
            lbl5.Text = ""
            Me.Controls.Add(lbl5)
            lbl5.BackColor = Color.FromArgb(0, 192, 0)
            lbl5.SendToBack()
            lbl5.Name = "Stage2Plant4" & i
            plant4(i) = lbl5


            'Adds Labels for fully grown plant

            'Left left stem
            Dim lbl6 As New Label
            Dim locationx5 As Integer = Tiles(i).Left + 40
            Dim locationy5 As Integer = Tiles(i).Top + 40
            lbl6.Size = New System.Drawing.Size(4, 4)
            lbl6.Location = New System.Drawing.Point(locationx5, locationy5)
            lbl6.Text = ""
            Me.Controls.Add(lbl6)
            lbl6.BackColor = Color.FromArgb(0, 192, 0)
            lbl6.SendToBack()
            lbl6.Name = "Stage2Plant5" & i
            plant5(i) = lbl6
            'Lower left stem
            Dim lbl7 As New Label
            Dim locationx7 As Integer = Tiles(i).Left + 36
            Dim locationy7 As Integer = Tiles(i).Top + 44
            lbl7.Size = New System.Drawing.Size(4, 4)
            lbl7.Location = New System.Drawing.Point(locationx7, locationy7)
            lbl7.Text = ""
            Me.Controls.Add(lbl7)
            lbl7.BackColor = Color.FromArgb(0, 192, 0)
            lbl7.SendToBack()
            lbl7.Name = "Stage2Plant6" & i
            plant6(i) = lbl7
            'Right right stem
            Dim lbl8 As New Label
            Dim locationx8 As Integer = Tiles(i).Left + 56
            Dim locationy8 As Integer = Tiles(i).Top + 38
            lbl8.Size = New System.Drawing.Size(4, 4)
            lbl8.Location = New System.Drawing.Point(locationx8, locationy8)
            lbl8.Text = ""
            Me.Controls.Add(lbl8)
            lbl8.BackColor = Color.FromArgb(0, 192, 0)
            lbl8.SendToBack()
            lbl8.Name = "Stage2Plant7" & i
            plant7(i) = lbl8
            'Lower right stem
            Dim lbl9 As New Label
            Dim locationx9 As Integer = Tiles(i).Left + 60
            Dim locationy9 As Integer = Tiles(i).Top + 42
            lbl9.Size = New System.Drawing.Size(4, 4)
            lbl9.Location = New System.Drawing.Point(locationx9, locationy9)
            lbl9.Text = ""
            Me.Controls.Add(lbl9)
            lbl9.BackColor = Color.FromArgb(0, 192, 0)
            lbl9.SendToBack()
            lbl9.Name = "Stage2Plant8" & i
            plant8(i) = lbl9
            'Stem parts
            Dim lbl10 As New Label
            Dim locationx10 As Integer = Tiles(i).Left
            Dim locationy10 As Integer = Tiles(i).Top
            lbl10.Size = New System.Drawing.Size(4, 4)
            lbl10.Location = New System.Drawing.Point(locationx10, locationy10)
            lbl10.Text = ""
            Me.Controls.Add(lbl10)
            lbl10.BackColor = Color.FromArgb(0, 192, 0)
            lbl10.SendToBack()
            lbl10.Name = "Stage2Plant9" & i
            plant9(i) = lbl10

            Dim lbl11 As New Label
            Dim locationx11 As Integer = Tiles(i).Left
            Dim locationy11 As Integer = Tiles(i).Top
            lbl11.Size = New System.Drawing.Size(4, 4)
            lbl11.Location = New System.Drawing.Point(locationx11, locationy11)
            lbl11.Text = ""
            Me.Controls.Add(lbl11)
            lbl11.BackColor = Color.FromArgb(0, 192, 0)
            lbl11.SendToBack()
            lbl11.Name = "Stage2Plant10" & i
            plant10(i) = lbl11

            Dim lbl12 As New Label
            Dim locationx12 As Integer = Tiles(i).Left + 60
            Dim locationy12 As Integer = Tiles(i).Top + 40
            lbl12.Size = New System.Drawing.Size(40, 12)
            lbl12.Location = New System.Drawing.Point(locationx12, locationy12)
            lbl12.Text = ""
            Me.Controls.Add(lbl12)
            lbl12.BackColor = Color.FromArgb(148, 76, 4)
            lbl12.ForeColor = Color.White
            lbl12.SendToBack()
            lbl12.Name = "Stage2Plant10" & i
            MoneyMade(i) = lbl12

        Next
        For Each c As Control In Controls
            AddHandler c.MouseClick, AddressOf ClickHandler
        Next
        money = 10
    End Sub

    Private Sub GrowTimer_Tick(sender As Object, e As EventArgs) Handles GrowTimer.Tick
        For i = 0 To 83
            If TOSU(i) = "Wheat" Then
                TUGB = 11
                For ok = 1 To 11
                    TimeSubtracted(ok) = ok
                Next
            ElseIf TOSU(i) = "BlueBerry" Then
                TUGB = 22
                For ok = 1 To 11
                    TimeSubtracted(ok) = ok * 2
                Next
            ElseIf TOSU(i) = "StrawBerry" Then
                TUGB = 33
                For ok = 1 To 11
                    TimeSubtracted(ok) = ok * 3
                Next
            End If
            If TTOOW(i) > 0 Then
                TUG(i) = TUG(i) - 1
                Label17.Text = "Time Until Plant Grows: " & TUG(i)
                If TUG(i) > 0 Then
                    If TUG(i) = TUGB Then
                        plant1(i).BringToFront()
                        seed(i).SendToBack()
                    End If
                    If TUG(i) = TUGB - TimeSubtracted(0) Then
                        plant2(i).BringToFront()
                    End If
                    If TUG(i) = TUGB - TimeSubtracted(1) Then
                        plant3(i).BringToFront()
                    End If
                    If TUG(i) = TUGB - TimeSubtracted(2) Then
                        plant4(i).BringToFront()
                    End If
                    If TUG(i) = TUGB - TimeSubtracted(3) Then
                        plant5(i).BringToFront()
                    End If
                    If TUG(i) = TUGB - TimeSubtracted(4) Then
                        plant6(i).BringToFront()
                    End If
                    If TUG(i) = TUGB - TimeSubtracted(5) Then
                        plant7(i).BringToFront()
                    End If
                    If TUG(i) = TUGB - TimeSubtracted(6) Then
                        plant8(i).BringToFront()
                    End If
                    If TUG(i) = TUGB - TimeSubtracted(7) Then
                        plant9(i).Top = plant2(i).Top - 4
                        plant9(i).Left = plant2(i).Left
                        plant3(i).Top = plant3(i).Top - 4
                        plant4(i).Top = plant4(i).Top - 4
                        plant5(i).Top = plant5(i).Top - 4
                        plant6(i).Top = plant6(i).Top - 4
                        plant7(i).Top = plant7(i).Top - 4
                        plant8(i).Top = plant8(i).Top - 4
                        plant9(i).BringToFront()
                    End If
                    If TUG(i) = TUGB - TimeSubtracted(8) Then
                        plant10(i).Top = plant9(i).Top - 4
                        plant10(i).Left = plant9(i).Left
                        plant3(i).Top = plant3(i).Top - 4
                        plant4(i).Top = plant4(i).Top - 4
                        plant5(i).Top = plant5(i).Top - 4
                        plant6(i).Top = plant6(i).Top - 4
                        plant7(i).Top = plant7(i).Top - 4
                        plant8(i).Top = plant8(i).Top - 4
                        plant10(i).BringToFront()
                    End If
                    If TUG(i) = TUGB - TimeSubtracted(9) Then
                        If TOSU(i) = "Wheat" Then
                            plant5(i).BackColor = Color.Beige
                        ElseIf TOSU(i) = "BlueBerry" Then
                            plant5(i).BackColor = Color.BlueViolet
                        ElseIf TOSU(i) = "StrawBerry" Then
                            plant5(i).BackColor = Color.OrangeRed
                        End If
                    End If
                    If TUG(i) = TUGB - TimeSubtracted(10) Then
                        If TOSU(i) = "Wheat" Then
                            plant7(i).BackColor = Color.Beige
                        ElseIf TOSU(i) = "BlueBerry" Then
                            plant7(i).BackColor = Color.BlueViolet
                        ElseIf TOSU(i) = "StrawBerry" Then
                            plant7(i).BackColor = Color.OrangeRed
                        End If
                        PRTH(i) = True
                    End If
                End If
                If TUG(i) < 0 Then
                    TUG(i) = 0
                End If
            End If
        Next
    End Sub

    Private Sub Farm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Hide()
            MainMenu.Show()
        End If



        If e.KeyCode = Keys.W Then
            Direction = "w"
        ElseIf e.KeyCode = Keys.S Then
            Direction = "s"
        ElseIf e.KeyCode = Keys.A Then
            Direction = "a"
        ElseIf e.KeyCode = Keys.D Then
            Direction = "d"
        End If
        MoveTimer.Start()

        If e.KeyCode = Keys.D1 And HotbarNum <> 1 Then
            Panel2.BackColor = Color.White
            Panel4.BackColor = Color.FromArgb(255, 255, 128)
            Panel3.BackColor = Color.FromArgb(255, 255, 128)
            Panel1.BackColor = Color.FromArgb(255, 255, 128)
            HotbarNum = 1
        End If
        If e.KeyCode = Keys.D2 And HotbarNum <> 2 Then
            Panel3.BackColor = Color.White
            Panel4.BackColor = Color.FromArgb(255, 255, 128)
            Panel2.BackColor = Color.FromArgb(255, 255, 128)
            Panel1.BackColor = Color.FromArgb(255, 255, 128)
            HotbarNum = 2
        End If
        If e.KeyCode = Keys.D3 And HotbarNum <> 3 Then
            Panel4.BackColor = Color.White
            Panel3.BackColor = Color.FromArgb(255, 255, 128)
            Panel2.BackColor = Color.FromArgb(255, 255, 128)
            Panel1.BackColor = Color.FromArgb(255, 255, 128)
            HotbarNum = 3
        End If
        If e.KeyCode = Keys.D4 And HotbarNum <> 4 Then
            Panel1.BackColor = Color.White
            Panel3.BackColor = Color.FromArgb(255, 255, 128)
            Panel2.BackColor = Color.FromArgb(255, 255, 128)
            Panel4.BackColor = Color.FromArgb(255, 255, 128)
            HotbarNum = 4
        End If

    End Sub

    Private Sub Farm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

        If e.KeyCode = Keys.W And Direction = "w" Then
            Direction = ""
        ElseIf e.KeyCode = Keys.S And Direction = "s" Then
            Direction = ""
        ElseIf e.KeyCode = Keys.A And Direction = "a" Then
            Direction = ""
        ElseIf e.KeyCode = Keys.D And Direction = "d" Then
            Direction = ""
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If Justincase = False Then
            Tiles = {a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12}
            Justincase = True
        End If
        MousePosT = Cursor.Position.Y - Me.Top - 30
        MousePosL = Cursor.Position.X - Me.Left - 8
        For i = 0 To 83
            If Tiles(i).Left < MousePosL And Tiles(i).Right > MousePosL And Tiles(i).Top < MousePosT And Tiles(i).Bottom > MousePosT Then
                Tiles(i).BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
                TileNum = i
            Else
                Tiles(i).BorderStyle = System.Windows.Forms.BorderStyle.None

            End If
        Next
        WaterTime.Text = "Time until water runs out: " & TTOOW(TileNum)
        Label17.Text = "Time Until Plant Grows: " & TUG(TileNum)

    End Sub

    Private Sub ClickHandler(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Select Case e.Button
            Case MouseButtons.Left
                MouseClickType = "Left"
                Actions()
            Case MouseButtons.Right
                MouseClickType = "Right"
                Remove()
        End Select
    End Sub

    Private Sub Remove()
        If HotbarNum = 5 And TileOccupied(TileNum) = True And Sprinkler(TileNum) = True Then
            plant1(TileNum).SendToBack()
            plant2(TileNum).SendToBack()
            plant3(TileNum).SendToBack()
            plant4(TileNum).SendToBack()
            TileOccupied(TileNum) = False
            Sprinkler(TileNum) = False
        End If
    End Sub

    Private Sub Actions()
        If HotbarNum = 1 And TileStage(TileNum) = 0 Then
            TileStage(TileNum) = 1
            Tiles(TileNum).BackColor = Color.FromArgb(128, 64, 64)
        End If
        If HotbarNum = 2 And TTOOW(TileNum) < 61 And TileStage(TileNum) = 1 Then
            TileWater(TileNum) = True
            Tiles(TileNum).BackColor = Color.FromArgb(148, 76, 4)
            TTOOW(TileNum) = 60
        End If
        If HotbarNum = 3 And PRTH(TileNum) = True And TOSU(TileNum) <> "None" Then
            If PRTH(TileNum) = True Then
                plant1(TileNum).SendToBack()
                plant2(TileNum).SendToBack()
                plant3(TileNum).SendToBack()
                plant4(TileNum).SendToBack()
                plant5(TileNum).SendToBack()
                plant6(TileNum).SendToBack()
                plant7(TileNum).SendToBack()
                plant8(TileNum).SendToBack()
                plant9(TileNum).SendToBack()
                plant10(TileNum).SendToBack()
                If TOSU(TileNum) = "Wheat" Then
                    MoneyMade(TileNum).Text = "$5+"
                End If
                If TOSU(TileNum) = "BlueBerry" Then
                    MoneyMade(TileNum).Text = "$50+"
                End If
                If TOSU(TileNum) = "StrawBerry" Then
                    MoneyMade(TileNum).Text = "$100+"
                End If
                MoneyMade(TileNum).BringToFront()
                LabelMoveMoney.Start()
                TileOccupied(TileNum) = False
            End If
        End If
        If HotbarNum = 4 And TileOccupied(TileNum) = False And TileWater(TileNum) = True Then
            plant5(TileNum).BackColor = Color.FromArgb(0, 192, 0)
            plant7(TileNum).BackColor = Color.FromArgb(0, 192, 0)
            plant1(TileNum).BackColor = Color.FromArgb(0, 192, 0)
            plant2(TileNum).BackColor = Color.FromArgb(0, 192, 0)
            plant3(TileNum).BackColor = Color.FromArgb(0, 192, 0)
            plant4(TileNum).BackColor = Color.FromArgb(0, 192, 0)

            seed(TileNum).Left = Tiles(TileNum).Left + 48
            seed(TileNum).Top = Tiles(TileNum).Top + 10

            plant1(TileNum).Left = Tiles(TileNum).Left + 48
            plant1(TileNum).Top = Tiles(TileNum).Top + 48

            plant2(TileNum).Left = Tiles(TileNum).Left + 48
            plant2(TileNum).Top = Tiles(TileNum).Top + 44

            plant3(TileNum).Left = Tiles(TileNum).Left + 44
            plant3(TileNum).Top = Tiles(TileNum).Top + 40

            plant4(TileNum).Left = Tiles(TileNum).Left + 52
            plant4(TileNum).Top = Tiles(TileNum).Top + 38

            plant5(TileNum).Left = Tiles(TileNum).Left + 40
            plant5(TileNum).Top = Tiles(TileNum).Top + 40

            plant6(TileNum).Left = Tiles(TileNum).Left + 36
            plant6(TileNum).Top = Tiles(TileNum).Top + 44

            plant7(TileNum).Left = Tiles(TileNum).Left + 56
            plant7(TileNum).Top = Tiles(TileNum).Top + 38

            plant8(TileNum).Left = Tiles(TileNum).Left + 60
            plant8(TileNum).Top = Tiles(TileNum).Top + 42

            plant9(TileNum).Left = Tiles(TileNum).Left
            plant9(TileNum).Top = Tiles(TileNum).Top

            plant9(TileNum).Left = Tiles(TileNum).Left
            plant9(TileNum).Top = Tiles(TileNum).Top

            plant10(TileNum).Left = Tiles(TileNum).Left
            plant10(TileNum).Top = Tiles(TileNum).Top

            MoneyMade(TileNum).Left = Tiles(TileNum).Left + 60
            MoneyMade(TileNum).Top = Tiles(TileNum).Top + 40

            If SeedSelected = "Wheat" And SeedSelector.Wheat > 0 Then
                TUG(TileNum) = 15
                seed(TileNum).BackColor = Color.FromArgb(227, 164, 82)
                seed(TileNum).BringToFront()
                AnotherPlaceholder = TileNum
                SeedMoveTimer.Start()
                SeedSelector.Wheat = SeedSelector.Wheat - 1
                TOSU(TileNum) = "Wheat"
                TileOccupied(TileNum) = True
            ElseIf SeedSelected = "BlueBerry" And SeedSelector.BlueBerry > 0 Then
                TUG(TileNum) = 30
                seed(TileNum).BackColor = Color.FromArgb(82, 154, 227)
                seed(TileNum).BringToFront()
                AnotherPlaceholder = TileNum
                SeedMoveTimer.Start()
                SeedSelector.BlueBerry = SeedSelector.BlueBerry - 1
                TOSU(TileNum) = "BlueBerry"
                TileOccupied(TileNum) = True
            ElseIf SeedSelected = "StrawBerry" And SeedSelector.StrawBerry > 0 Then
                TUG(TileNum) = 45
                seed(TileNum).BackColor = Color.FromArgb(227, 108, 82)
                seed(TileNum).BringToFront()
                AnotherPlaceholder = TileNum
                SeedMoveTimer.Start()
                SeedSelector.StrawBerry = SeedSelector.StrawBerry - 1
                TOSU(TileNum) = "StrawBerry"
                TileOccupied(TileNum) = True
            Else
                MsgBox("Please Select A Seed By Right Clicking Slot 4!")
            End If

        End If
    End Sub

    Private Sub WaterTimer_Tick(sender As Object, e As EventArgs) Handles WaterTimer.Tick
        For i = 0 To 83
            If TTOOW(i) <> 0 Then
                TTOOW(i) = TTOOW(i) - 1
                Tiles(i).BackColor = Color.FromArgb(148, 76, 4)
            ElseIf TileStage(i) = 1 Then
                Tiles(i).BackColor = Color.FromArgb(128, 64, 64)
                TileWater(i) = False
            ElseIf TileWater(i) = False Then
                Tiles(i).BackColor = Color.FromArgb(0, 192, 0)
            End If
        Next
    End Sub

    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
        If e.Button = MouseButtons.Right Then
            Me.Hide()
            SeedSelector.Show()
        ElseIf e.Button = MouseButtons.Left Then
            Panel1.BackColor = Color.White
            Panel3.BackColor = Color.FromArgb(255, 255, 128)
            Panel2.BackColor = Color.FromArgb(255, 255, 128)
            Panel4.BackColor = Color.FromArgb(255, 255, 128)
            HotbarNum = 4
        End If
    End Sub

    Private Sub SeedMoveTimer_Tick(sender As Object, e As EventArgs) Handles SeedMoveTimer.Tick
        If seed(AnotherPlaceholder).Top = Tiles(AnotherPlaceholder).Top + 48 Then
            Timer.Start()
            SeedMoveTimer.Stop()
        Else
            Timer.Stop()
            seed(AnotherPlaceholder).Top = seed(AnotherPlaceholder).Top + 2
        End If

    End Sub

    Private Sub LabelMoveMoney_Tick(sender As Object, e As EventArgs) Handles LabelMoveMoney.Tick
        Timer.Stop()
        MoneyMade(TileNum).Top = MoneyMade(TileNum).Top - 2
        If MoneyMade(TileNum).Top = Tiles(TileNum).Top + 2 Then
            Timer.Start()
            PRTH(TileNum) = False
            MoneyMade(TileNum).SendToBack()
            If TOSU(TileNum) = "Wheat" Then
                money = money + 5
            ElseIf TOSU(TileNum) = "BlueBerry" Then
                money = money + 50
            ElseIf TOSU(TileNum) = "StrawBerry" Then
                money = money + 100
            End If
            LabelMoveMoney.Stop()
        End If
    End Sub

    Private Sub Panel4_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel4.MouseClick
        If e.Button = MouseButtons.Right Then

        ElseIf e.Button = MouseButtons.Left Then
            Panel4.BackColor = Color.White
            Panel3.BackColor = Color.FromArgb(255, 255, 128)
            Panel2.BackColor = Color.FromArgb(255, 255, 128)
            Panel1.BackColor = Color.FromArgb(255, 255, 128)
            HotbarNum = 3
        End If
    End Sub

    Private Sub Panel3_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel3.MouseClick
        If e.Button = MouseButtons.Right Then

        ElseIf e.Button = MouseButtons.Left Then
            Panel3.BackColor = Color.White
            Panel4.BackColor = Color.FromArgb(255, 255, 128)
            Panel2.BackColor = Color.FromArgb(255, 255, 128)
            Panel1.BackColor = Color.FromArgb(255, 255, 128)
            HotbarNum = 2
        End If
    End Sub

    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel2.MouseClick
        If e.Button = MouseButtons.Right Then

        ElseIf e.Button = MouseButtons.Left Then
            Panel2.BackColor = Color.White
            Panel4.BackColor = Color.FromArgb(255, 255, 128)
            Panel3.BackColor = Color.FromArgb(255, 255, 128)
            Panel1.BackColor = Color.FromArgb(255, 255, 128)
            HotbarNum = 1
        End If
    End Sub
End Class