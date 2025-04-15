<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ball = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Paddle2 = New System.Windows.Forms.Label()
        Me.Paddle1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DifficultyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EasyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FunSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Player1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaddleSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LargeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaddleColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Player2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaddleSizeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SmallToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LargeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaddleCoorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BallSpeedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SlowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FastToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BallColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurpleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkBlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlKeysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BallTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Paddle2Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Paddle1Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ScoredTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PaddleAI = New System.Windows.Forms.Timer(Me.components)
        Me.Dir = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Ball)
        Me.Panel1.Controls.Add(Me.lblScore)
        Me.Panel1.Controls.Add(Me.Paddle2)
        Me.Panel1.Controls.Add(Me.Paddle1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1263, 680)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.Label1.Location = New System.Drawing.Point(480, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 46)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "PlaceHolder"
        Me.Label1.Visible = False
        '
        'Ball
        '
        Me.Ball.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Ball.Location = New System.Drawing.Point(616, 320)
        Me.Ball.Name = "Ball"
        Me.Ball.Size = New System.Drawing.Size(25, 25)
        Me.Ball.TabIndex = 2
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.lblScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblScore.Location = New System.Drawing.Point(543, 624)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(101, 48)
        Me.lblScore.TabIndex = 4
        Me.lblScore.Text = "0 - 0"
        '
        'Paddle2
        '
        Me.Paddle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Paddle2.Location = New System.Drawing.Point(1225, 240)
        Me.Paddle2.Name = "Paddle2"
        Me.Paddle2.Size = New System.Drawing.Size(15, 200)
        Me.Paddle2.TabIndex = 1
        '
        'Paddle1
        '
        Me.Paddle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Paddle1.Location = New System.Drawing.Point(25, 240)
        Me.Paddle1.Name = "Paddle1"
        Me.Paddle1.Size = New System.Drawing.Size(15, 200)
        Me.Paddle1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem, Me.FunSettingsToolStripMenuItem, Me.HelpToolStripMenuItem, Me.StartToolStripMenuItem1, Me.EndGameToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1263, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.DifficultyToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.GameToolStripMenuItem.Text = "Game"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayerToolStripMenuItem, Me.PlayerToolStripMenuItem1})
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.StartToolStripMenuItem.Text = "Players"
        '
        'PlayerToolStripMenuItem
        '
        Me.PlayerToolStripMenuItem.Name = "PlayerToolStripMenuItem"
        Me.PlayerToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.PlayerToolStripMenuItem.Text = "2 player"
        '
        'PlayerToolStripMenuItem1
        '
        Me.PlayerToolStripMenuItem1.Name = "PlayerToolStripMenuItem1"
        Me.PlayerToolStripMenuItem1.Size = New System.Drawing.Size(115, 22)
        Me.PlayerToolStripMenuItem1.Text = "1 player"
        '
        'DifficultyToolStripMenuItem
        '
        Me.DifficultyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HardToolStripMenuItem, Me.EasyToolStripMenuItem})
        Me.DifficultyToolStripMenuItem.Name = "DifficultyToolStripMenuItem"
        Me.DifficultyToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.DifficultyToolStripMenuItem.Text = "Difficulty (1 Player Only)"
        '
        'HardToolStripMenuItem
        '
        Me.HardToolStripMenuItem.Name = "HardToolStripMenuItem"
        Me.HardToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.HardToolStripMenuItem.Text = "Hard"
        '
        'EasyToolStripMenuItem
        '
        Me.EasyToolStripMenuItem.Name = "EasyToolStripMenuItem"
        Me.EasyToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.EasyToolStripMenuItem.Text = "Easy"
        '
        'FunSettingsToolStripMenuItem
        '
        Me.FunSettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Player1ToolStripMenuItem, Me.Player2ToolStripMenuItem, Me.BallSpeedToolStripMenuItem, Me.BallColorToolStripMenuItem})
        Me.FunSettingsToolStripMenuItem.Name = "FunSettingsToolStripMenuItem"
        Me.FunSettingsToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.FunSettingsToolStripMenuItem.Text = "Fun Settings"
        '
        'Player1ToolStripMenuItem
        '
        Me.Player1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaddleSizeToolStripMenuItem, Me.PaddleColorToolStripMenuItem})
        Me.Player1ToolStripMenuItem.Name = "Player1ToolStripMenuItem"
        Me.Player1ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Player1ToolStripMenuItem.Text = "Player 1"
        '
        'PaddleSizeToolStripMenuItem
        '
        Me.PaddleSizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SmallToolStripMenuItem, Me.NormalToolStripMenuItem1, Me.LargeToolStripMenuItem})
        Me.PaddleSizeToolStripMenuItem.Name = "PaddleSizeToolStripMenuItem"
        Me.PaddleSizeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PaddleSizeToolStripMenuItem.Text = "Paddle Size"
        '
        'SmallToolStripMenuItem
        '
        Me.SmallToolStripMenuItem.Name = "SmallToolStripMenuItem"
        Me.SmallToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SmallToolStripMenuItem.Text = "Small"
        '
        'NormalToolStripMenuItem1
        '
        Me.NormalToolStripMenuItem1.Name = "NormalToolStripMenuItem1"
        Me.NormalToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.NormalToolStripMenuItem1.Text = "Normal"
        '
        'LargeToolStripMenuItem
        '
        Me.LargeToolStripMenuItem.Name = "LargeToolStripMenuItem"
        Me.LargeToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.LargeToolStripMenuItem.Text = "Large"
        '
        'PaddleColorToolStripMenuItem
        '
        Me.PaddleColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RedToolStripMenuItem, Me.ClueToolStripMenuItem, Me.GreenToolStripMenuItem})
        Me.PaddleColorToolStripMenuItem.Name = "PaddleColorToolStripMenuItem"
        Me.PaddleColorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PaddleColorToolStripMenuItem.Text = "Paddle Color"
        '
        'RedToolStripMenuItem
        '
        Me.RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        Me.RedToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RedToolStripMenuItem.Text = "Red"
        '
        'ClueToolStripMenuItem
        '
        Me.ClueToolStripMenuItem.Name = "ClueToolStripMenuItem"
        Me.ClueToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClueToolStripMenuItem.Text = "Blue"
        '
        'GreenToolStripMenuItem
        '
        Me.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        Me.GreenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GreenToolStripMenuItem.Text = "Green"
        '
        'Player2ToolStripMenuItem
        '
        Me.Player2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaddleSizeToolStripMenuItem1, Me.PaddleCoorToolStripMenuItem})
        Me.Player2ToolStripMenuItem.Name = "Player2ToolStripMenuItem"
        Me.Player2ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Player2ToolStripMenuItem.Text = "Player 2"
        '
        'PaddleSizeToolStripMenuItem1
        '
        Me.PaddleSizeToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SmallToolStripMenuItem1, Me.NormalToolStripMenuItem2, Me.LargeToolStripMenuItem1})
        Me.PaddleSizeToolStripMenuItem1.Name = "PaddleSizeToolStripMenuItem1"
        Me.PaddleSizeToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.PaddleSizeToolStripMenuItem1.Text = "Paddle Size"
        '
        'SmallToolStripMenuItem1
        '
        Me.SmallToolStripMenuItem1.Name = "SmallToolStripMenuItem1"
        Me.SmallToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.SmallToolStripMenuItem1.Text = "Small"
        '
        'NormalToolStripMenuItem2
        '
        Me.NormalToolStripMenuItem2.Name = "NormalToolStripMenuItem2"
        Me.NormalToolStripMenuItem2.Size = New System.Drawing.Size(114, 22)
        Me.NormalToolStripMenuItem2.Text = "Normal"
        '
        'LargeToolStripMenuItem1
        '
        Me.LargeToolStripMenuItem1.Name = "LargeToolStripMenuItem1"
        Me.LargeToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.LargeToolStripMenuItem1.Text = "Large"
        '
        'PaddleCoorToolStripMenuItem
        '
        Me.PaddleCoorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RedToolStripMenuItem1, Me.BlueToolStripMenuItem, Me.GreenToolStripMenuItem1})
        Me.PaddleCoorToolStripMenuItem.Name = "PaddleCoorToolStripMenuItem"
        Me.PaddleCoorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PaddleCoorToolStripMenuItem.Text = "Paddle Color"
        '
        'RedToolStripMenuItem1
        '
        Me.RedToolStripMenuItem1.Name = "RedToolStripMenuItem1"
        Me.RedToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.RedToolStripMenuItem1.Text = "Red"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'GreenToolStripMenuItem1
        '
        Me.GreenToolStripMenuItem1.Name = "GreenToolStripMenuItem1"
        Me.GreenToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.GreenToolStripMenuItem1.Text = "Green"
        '
        'BallSpeedToolStripMenuItem
        '
        Me.BallSpeedToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SlowToolStripMenuItem, Me.NormalToolStripMenuItem, Me.FastToolStripMenuItem})
        Me.BallSpeedToolStripMenuItem.Name = "BallSpeedToolStripMenuItem"
        Me.BallSpeedToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BallSpeedToolStripMenuItem.Text = "Ball Speed"
        '
        'SlowToolStripMenuItem
        '
        Me.SlowToolStripMenuItem.Name = "SlowToolStripMenuItem"
        Me.SlowToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SlowToolStripMenuItem.Text = "Slow"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.NormalToolStripMenuItem.Text = "Normal"
        '
        'FastToolStripMenuItem
        '
        Me.FastToolStripMenuItem.Name = "FastToolStripMenuItem"
        Me.FastToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.FastToolStripMenuItem.Text = "Fast"
        '
        'BallColorToolStripMenuItem
        '
        Me.BallColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PinkToolStripMenuItem, Me.PurpleToolStripMenuItem, Me.DarkBlueToolStripMenuItem})
        Me.BallColorToolStripMenuItem.Name = "BallColorToolStripMenuItem"
        Me.BallColorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BallColorToolStripMenuItem.Text = "Ball Color"
        '
        'PinkToolStripMenuItem
        '
        Me.PinkToolStripMenuItem.Name = "PinkToolStripMenuItem"
        Me.PinkToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.PinkToolStripMenuItem.Text = "Pink"
        '
        'PurpleToolStripMenuItem
        '
        Me.PurpleToolStripMenuItem.Name = "PurpleToolStripMenuItem"
        Me.PurpleToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.PurpleToolStripMenuItem.Text = "Purple"
        '
        'DarkBlueToolStripMenuItem
        '
        Me.DarkBlueToolStripMenuItem.Name = "DarkBlueToolStripMenuItem"
        Me.DarkBlueToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.DarkBlueToolStripMenuItem.Text = "Teal"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ControlKeysToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ControlKeysToolStripMenuItem
        '
        Me.ControlKeysToolStripMenuItem.Name = "ControlKeysToolStripMenuItem"
        Me.ControlKeysToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ControlKeysToolStripMenuItem.Text = "Control Keys"
        '
        'StartToolStripMenuItem1
        '
        Me.StartToolStripMenuItem1.Name = "StartToolStripMenuItem1"
        Me.StartToolStripMenuItem1.Size = New System.Drawing.Size(43, 20)
        Me.StartToolStripMenuItem1.Text = "Start"
        '
        'EndGameToolStripMenuItem
        '
        Me.EndGameToolStripMenuItem.Name = "EndGameToolStripMenuItem"
        Me.EndGameToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.EndGameToolStripMenuItem.Text = "End Game"
        '
        'BallTimer
        '
        Me.BallTimer.Enabled = True
        Me.BallTimer.Interval = 1
        '
        'Paddle2Timer
        '
        Me.Paddle2Timer.Interval = 1
        '
        'Paddle1Timer
        '
        Me.Paddle1Timer.Interval = 1
        '
        'ScoredTimer
        '
        Me.ScoredTimer.Interval = 2000
        '
        'PaddleAI
        '
        Me.PaddleAI.Enabled = True
        Me.PaddleAI.Interval = 1
        '
        'Dir
        '
        Me.Dir.Enabled = True
        Me.Dir.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Pong"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Ball As Label
    Friend WithEvents Paddle2 As Label
    Friend WithEvents Paddle1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FunSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlayerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlayerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DifficultyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EasyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlKeysToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BallTimer As Timer
    Friend WithEvents Paddle2Timer As Timer
    Friend WithEvents Paddle1Timer As Timer
    Friend WithEvents EndGameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblScore As Label
    Friend WithEvents ScoredTimer As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents PaddleAI As Timer
    Friend WithEvents Dir As Timer
    Friend WithEvents Player1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaddleSizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SmallToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LargeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaddleColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Player2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaddleSizeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PaddleCoorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BallSpeedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SlowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FastToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BallColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PinkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurpleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DarkBlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SmallToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents LargeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem1 As ToolStripMenuItem
End Class
