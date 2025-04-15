<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.txtbxQuestion = New System.Windows.Forms.TextBox()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblNumCorrect1 = New System.Windows.Forms.Label()
        Me.lblNumCorrect = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.lblWelcome.Location = New System.Drawing.Point(322, 30)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(543, 46)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to the bonus round!"
        '
        'btnBegin
        '
        Me.btnBegin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnBegin.Location = New System.Drawing.Point(481, 79)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(198, 50)
        Me.btnBegin.TabIndex = 1
        Me.btnBegin.Text = "Click To begin"
        Me.btnBegin.UseVisualStyleBackColor = True
        '
        'txtbxQuestion
        '
        Me.txtbxQuestion.Location = New System.Drawing.Point(516, 234)
        Me.txtbxQuestion.Name = "txtbxQuestion"
        Me.txtbxQuestion.Size = New System.Drawing.Size(100, 20)
        Me.txtbxQuestion.TabIndex = 2
        Me.txtbxQuestion.Visible = False
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblQuestion.Location = New System.Drawing.Point(511, 206)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(115, 25)
        Me.lblQuestion.TabIndex = 3
        Me.lblQuestion.Text = "Placeholder"
        Me.lblQuestion.Visible = False
        '
        'lblNumCorrect1
        '
        Me.lblNumCorrect1.AutoSize = True
        Me.lblNumCorrect1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblNumCorrect1.Location = New System.Drawing.Point(91, 182)
        Me.lblNumCorrect1.Name = "lblNumCorrect1"
        Me.lblNumCorrect1.Size = New System.Drawing.Size(242, 31)
        Me.lblNumCorrect1.TabIndex = 4
        Me.lblNumCorrect1.Text = "Questions Correct:"
        Me.lblNumCorrect1.Visible = False
        '
        'lblNumCorrect
        '
        Me.lblNumCorrect.AutoSize = True
        Me.lblNumCorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.lblNumCorrect.Location = New System.Drawing.Point(194, 213)
        Me.lblNumCorrect.Name = "lblNumCorrect"
        Me.lblNumCorrect.Size = New System.Drawing.Size(42, 46)
        Me.lblNumCorrect.TabIndex = 5
        Me.lblNumCorrect.Text = "0"
        Me.lblNumCorrect.Visible = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblTime.Location = New System.Drawing.Point(822, 191)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(82, 31)
        Me.lblTime.TabIndex = 6
        Me.lblTime.Text = "Time:"
        Me.lblTime.Visible = False
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.lblTimer.Location = New System.Drawing.Point(832, 222)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(64, 46)
        Me.lblTimer.TabIndex = 7
        Me.lblTimer.Text = "30"
        Me.lblTimer.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblNumCorrect)
        Me.Controls.Add(Me.lblNumCorrect1)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.txtbxQuestion)
        Me.Controls.Add(Me.btnBegin)
        Me.Controls.Add(Me.lblWelcome)
        Me.KeyPreview = True
        Me.Name = "Form2"
        Me.Text = "Bonus Round!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnBegin As Button
    Friend WithEvents txtbxQuestion As TextBox
    Friend WithEvents lblQuestion As Label
    Friend WithEvents lblNumCorrect1 As Label
    Friend WithEvents lblNumCorrect As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
