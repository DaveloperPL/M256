<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WelcomeScreen))
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.D6 = New System.Windows.Forms.Label()
        Me.D2 = New System.Windows.Forms.Label()
        Me.D7 = New System.Windows.Forms.Label()
        Me.D1 = New System.Windows.Forms.Label()
        Me.D4 = New System.Windows.Forms.Label()
        Me.D5 = New System.Windows.Forms.Label()
        Me.D3 = New System.Windows.Forms.Label()
        Me.RollTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblB = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 75.0!)
        Me.lblWelcome.Location = New System.Drawing.Point(342, 33)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(494, 113)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome!"
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnNext.Location = New System.Drawing.Point(1108, 605)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(144, 64)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(470, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Click next to begin!"
        '
        'btnRoll
        '
        Me.btnRoll.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnRoll.Location = New System.Drawing.Point(508, 530)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(100, 47)
        Me.btnRoll.TabIndex = 4
        Me.btnRoll.Text = "Roll"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'D6
        '
        Me.D6.BackColor = System.Drawing.Color.Black
        Me.D6.Location = New System.Drawing.Point(505, 452)
        Me.D6.Name = "D6"
        Me.D6.Size = New System.Drawing.Size(25, 25)
        Me.D6.TabIndex = 5
        Me.D6.Text = "Label2"
        '
        'D2
        '
        Me.D2.BackColor = System.Drawing.Color.Black
        Me.D2.Location = New System.Drawing.Point(583, 373)
        Me.D2.Name = "D2"
        Me.D2.Size = New System.Drawing.Size(25, 25)
        Me.D2.TabIndex = 6
        Me.D2.Text = "Label3"
        '
        'D7
        '
        Me.D7.BackColor = System.Drawing.Color.Black
        Me.D7.Location = New System.Drawing.Point(583, 452)
        Me.D7.Name = "D7"
        Me.D7.Size = New System.Drawing.Size(25, 25)
        Me.D7.TabIndex = 7
        Me.D7.Text = "Label4"
        '
        'D1
        '
        Me.D1.BackColor = System.Drawing.Color.Black
        Me.D1.Location = New System.Drawing.Point(505, 373)
        Me.D1.Name = "D1"
        Me.D1.Size = New System.Drawing.Size(25, 25)
        Me.D1.TabIndex = 8
        Me.D1.Text = "Label5"
        '
        'D4
        '
        Me.D4.BackColor = System.Drawing.Color.Black
        Me.D4.Location = New System.Drawing.Point(545, 414)
        Me.D4.Name = "D4"
        Me.D4.Size = New System.Drawing.Size(25, 25)
        Me.D4.TabIndex = 10
        Me.D4.Text = "Label7"
        '
        'D5
        '
        Me.D5.BackColor = System.Drawing.Color.Black
        Me.D5.Location = New System.Drawing.Point(583, 414)
        Me.D5.Name = "D5"
        Me.D5.Size = New System.Drawing.Size(25, 25)
        Me.D5.TabIndex = 11
        Me.D5.Text = "Label8"
        '
        'D3
        '
        Me.D3.BackColor = System.Drawing.Color.Black
        Me.D3.Location = New System.Drawing.Point(505, 414)
        Me.D3.Name = "D3"
        Me.D3.Size = New System.Drawing.Size(25, 25)
        Me.D3.TabIndex = 12
        Me.D3.Text = "Label9"
        '
        'RollTimer
        '
        Me.RollTimer.Interval = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(482, 351)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 167)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Dice-1-b.svg.png")
        '
        'lblB
        '
        Me.lblB.Location = New System.Drawing.Point(505, 373)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(119, 110)
        Me.lblB.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Button1.Location = New System.Drawing.Point(1142, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 39)
        Me.Button1.TabIndex = 96
        Me.Button1.Text = "Quit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WelcomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.D3)
        Me.Controls.Add(Me.D5)
        Me.Controls.Add(Me.D4)
        Me.Controls.Add(Me.D1)
        Me.Controls.Add(Me.D7)
        Me.Controls.Add(Me.D2)
        Me.Controls.Add(Me.D6)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "WelcomeScreen"
        Me.Text = "Welcome To My Board Game!"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRoll As Button
    Friend WithEvents D6 As Label
    Friend WithEvents D2 As Label
    Friend WithEvents D7 As Label
    Friend WithEvents D1 As Label
    Friend WithEvents D4 As Label
    Friend WithEvents D5 As Label
    Friend WithEvents D3 As Label
    Friend WithEvents RollTimer As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents lblB As Label
    Friend WithEvents Button1 As Button
End Class
