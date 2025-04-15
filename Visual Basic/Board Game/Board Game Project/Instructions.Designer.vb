<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instructions
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
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.Rolls = New System.Windows.Forms.Label()
        Me.lblDie = New System.Windows.Forms.Label()
        Me.lblWin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 75.0!)
        Me.lblInstructions.Location = New System.Drawing.Point(304, 9)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(589, 113)
        Me.lblInstructions.TabIndex = 0
        Me.lblInstructions.Text = "Instructions "
        '
        'Rolls
        '
        Me.Rolls.AutoSize = True
        Me.Rolls.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Rolls.Location = New System.Drawing.Point(210, 148)
        Me.Rolls.Name = "Rolls"
        Me.Rolls.Size = New System.Drawing.Size(103, 39)
        Me.Rolls.TabIndex = 1
        Me.Rolls.Text = "Rolls:"
        '
        'lblDie
        '
        Me.lblDie.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDie.Location = New System.Drawing.Point(175, 199)
        Me.lblDie.Name = "lblDie"
        Me.lblDie.Size = New System.Drawing.Size(195, 72)
        Me.lblDie.TabIndex = 2
        Me.lblDie.Text = "All the sides of the die move your piece forward by their number except 3, Number" &
    " 3 Allows you to re-roll."
        '
        'lblWin
        '
        Me.lblWin.AutoSize = True
        Me.lblWin.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!)
        Me.lblWin.Location = New System.Drawing.Point(479, 145)
        Me.lblWin.Name = "lblWin"
        Me.lblWin.Size = New System.Drawing.Size(263, 54)
        Me.lblWin.TabIndex = 3
        Me.lblWin.Text = "How to win:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(405, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(410, 87)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "To win you have to reach 100 points. Points can be acquired by moving spaces or l" &
    "anding on a space that gives points or a multiplyer"
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnNext.Location = New System.Drawing.Point(1108, 605)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(144, 64)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label2.Location = New System.Drawing.Point(898, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 31)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Random Events"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(886, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 97)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "At the end of every turn there will be a chance of a random event happening, this" &
    " could be move back 2 spaces, move forward 2 spaces, or +/- 25 points"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(188, 439)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "Label4"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(344, 428)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 98
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Instructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblWin)
        Me.Controls.Add(Me.lblDie)
        Me.Controls.Add(Me.Rolls)
        Me.Controls.Add(Me.lblInstructions)
        Me.Name = "Instructions"
        Me.Text = "Instructions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstructions As Label
    Friend WithEvents Rolls As Label
    Friend WithEvents lblDie As Label
    Friend WithEvents lblWin As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
End Class
