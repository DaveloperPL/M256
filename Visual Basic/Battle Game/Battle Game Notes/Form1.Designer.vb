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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVillian = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblHeroHP = New System.Windows.Forms.Label()
        Me.lblHeroOffense = New System.Windows.Forms.Label()
        Me.lblHeroDefense = New System.Windows.Forms.Label()
        Me.lblEnemyOffense = New System.Windows.Forms.Label()
        Me.lblEnemyDefense = New System.Windows.Forms.Label()
        Me.lblEnemyHP = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnBattle = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FightTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Batman"
        '
        'lblVillian
        '
        Me.lblVillian.AutoSize = True
        Me.lblVillian.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVillian.Location = New System.Drawing.Point(550, 78)
        Me.lblVillian.Name = "lblVillian"
        Me.lblVillian.Size = New System.Drawing.Size(67, 25)
        Me.lblVillian.TabIndex = 1
        Me.lblVillian.Text = "villian"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "HP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Defense"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 335)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Offense"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(555, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Offense"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(555, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Defense"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(552, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "HP"
        '
        'lblHeroHP
        '
        Me.lblHeroHP.AutoSize = True
        Me.lblHeroHP.Location = New System.Drawing.Point(145, 209)
        Me.lblHeroHP.Name = "lblHeroHP"
        Me.lblHeroHP.Size = New System.Drawing.Size(13, 13)
        Me.lblHeroHP.TabIndex = 8
        Me.lblHeroHP.Text = "0"
        '
        'lblHeroOffense
        '
        Me.lblHeroOffense.AutoSize = True
        Me.lblHeroOffense.Location = New System.Drawing.Point(145, 335)
        Me.lblHeroOffense.Name = "lblHeroOffense"
        Me.lblHeroOffense.Size = New System.Drawing.Size(13, 13)
        Me.lblHeroOffense.TabIndex = 9
        Me.lblHeroOffense.Text = "0"
        '
        'lblHeroDefense
        '
        Me.lblHeroDefense.AutoSize = True
        Me.lblHeroDefense.Location = New System.Drawing.Point(145, 271)
        Me.lblHeroDefense.Name = "lblHeroDefense"
        Me.lblHeroDefense.Size = New System.Drawing.Size(13, 13)
        Me.lblHeroDefense.TabIndex = 10
        Me.lblHeroDefense.Text = "0"
        '
        'lblEnemyOffense
        '
        Me.lblEnemyOffense.AutoSize = True
        Me.lblEnemyOffense.Location = New System.Drawing.Point(626, 335)
        Me.lblEnemyOffense.Name = "lblEnemyOffense"
        Me.lblEnemyOffense.Size = New System.Drawing.Size(13, 13)
        Me.lblEnemyOffense.TabIndex = 11
        Me.lblEnemyOffense.Text = "0"
        '
        'lblEnemyDefense
        '
        Me.lblEnemyDefense.AutoSize = True
        Me.lblEnemyDefense.Location = New System.Drawing.Point(626, 271)
        Me.lblEnemyDefense.Name = "lblEnemyDefense"
        Me.lblEnemyDefense.Size = New System.Drawing.Size(13, 13)
        Me.lblEnemyDefense.TabIndex = 12
        Me.lblEnemyDefense.Text = "0"
        '
        'lblEnemyHP
        '
        Me.lblEnemyHP.AutoSize = True
        Me.lblEnemyHP.Location = New System.Drawing.Point(626, 209)
        Me.lblEnemyHP.Name = "lblEnemyHP"
        Me.lblEnemyHP.Size = New System.Drawing.Size(13, 13)
        Me.lblEnemyHP.TabIndex = 13
        Me.lblEnemyHP.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 60)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Set Stats"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"The Riddler", "Joker", "Scarecrow", "Penguin", "Bane", "Mr. Freeze"})
        Me.ListBox1.Location = New System.Drawing.Point(684, 30)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 15
        '
        'btnBattle
        '
        Me.btnBattle.Location = New System.Drawing.Point(339, 101)
        Me.btnBattle.Name = "btnBattle"
        Me.btnBattle.Size = New System.Drawing.Size(75, 23)
        Me.btnBattle.TabIndex = 16
        Me.btnBattle.Text = "Battle"
        Me.btnBattle.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(97, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(560, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 18
        '
        'FightTimer
        '
        Me.FightTimer.Interval = 300
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(329, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 32)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "To The Store"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(563, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 45)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Reset Villans"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(86, 135)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(150, 25)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 25
        Me.ProgressBar1.Value = 100
        '
        'ProgressBar2
        '
        Me.ProgressBar2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ProgressBar2.Location = New System.Drawing.Point(515, 135)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(150, 25)
        Me.ProgressBar2.TabIndex = 26
        Me.ProgressBar2.Value = 100
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnBattle)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblEnemyHP)
        Me.Controls.Add(Me.lblEnemyDefense)
        Me.Controls.Add(Me.lblEnemyOffense)
        Me.Controls.Add(Me.lblHeroDefense)
        Me.Controls.Add(Me.lblHeroOffense)
        Me.Controls.Add(Me.lblHeroHP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblVillian)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblVillian As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblHeroHP As Label
    Friend WithEvents lblHeroOffense As Label
    Friend WithEvents lblHeroDefense As Label
    Friend WithEvents lblEnemyOffense As Label
    Friend WithEvents lblEnemyDefense As Label
    Friend WithEvents lblEnemyHP As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnBattle As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents FightTimer As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBar2 As ProgressBar
End Class
