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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Time1 = New System.Windows.Forms.Label()
        Me.lblTimes = New System.Windows.Forms.Label()
        Me.finishLine = New System.Windows.Forms.Label()
        Me.Car1 = New System.Windows.Forms.Label()
        Me.Car3 = New System.Windows.Forms.Label()
        Me.Time3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Place3 = New System.Windows.Forms.Label()
        Me.Place1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Car2 = New System.Windows.Forms.Label()
        Me.Car4 = New System.Windows.Forms.Label()
        Me.Place4 = New System.Windows.Forms.Label()
        Me.Time4 = New System.Windows.Forms.Label()
        Me.Time2 = New System.Windows.Forms.Label()
        Me.Place2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(36, 36)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 14
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Time1
        '
        Me.Time1.AutoSize = True
        Me.Time1.Location = New System.Drawing.Point(700, 105)
        Me.Time1.Name = "Time1"
        Me.Time1.Size = New System.Drawing.Size(13, 13)
        Me.Time1.TabIndex = 13
        Me.Time1.Text = "0"
        '
        'lblTimes
        '
        Me.lblTimes.AutoSize = True
        Me.lblTimes.Location = New System.Drawing.Point(690, 21)
        Me.lblTimes.Name = "lblTimes"
        Me.lblTimes.Size = New System.Drawing.Size(30, 13)
        Me.lblTimes.TabIndex = 12
        Me.lblTimes.Text = "Time"
        '
        'finishLine
        '
        Me.finishLine.BackColor = System.Drawing.Color.Black
        Me.finishLine.Location = New System.Drawing.Point(628, 41)
        Me.finishLine.Name = "finishLine"
        Me.finishLine.Size = New System.Drawing.Size(10, 216)
        Me.finishLine.TabIndex = 11
        Me.finishLine.Text = "Label1"
        '
        'Car1
        '
        Me.Car1.BackColor = System.Drawing.Color.Red
        Me.Car1.Location = New System.Drawing.Point(52, 95)
        Me.Car1.Name = "Car1"
        Me.Car1.Size = New System.Drawing.Size(59, 23)
        Me.Car1.TabIndex = 10
        Me.Car1.Text = "Car 1"
        '
        'Car3
        '
        Me.Car3.BackColor = System.Drawing.Color.Red
        Me.Car3.Location = New System.Drawing.Point(52, 171)
        Me.Car3.Name = "Car3"
        Me.Car3.Size = New System.Drawing.Size(59, 23)
        Me.Car3.TabIndex = 15
        Me.Car3.Text = "Car 3"
        '
        'Time3
        '
        Me.Time3.AutoSize = True
        Me.Time3.Location = New System.Drawing.Point(700, 195)
        Me.Time3.Name = "Time3"
        Me.Time3.Size = New System.Drawing.Size(13, 13)
        Me.Time3.TabIndex = 16
        Me.Time3.Text = "0"
        '
        'Timer1
        '
        '
        'Place3
        '
        Me.Place3.AutoSize = True
        Me.Place3.Location = New System.Drawing.Point(811, 195)
        Me.Place3.Name = "Place3"
        Me.Place3.Size = New System.Drawing.Size(13, 13)
        Me.Place3.TabIndex = 17
        Me.Place3.Text = "0"
        '
        'Place1
        '
        Me.Place1.AutoSize = True
        Me.Place1.Location = New System.Drawing.Point(811, 105)
        Me.Place1.Name = "Place1"
        Me.Place1.Size = New System.Drawing.Size(13, 13)
        Me.Place1.TabIndex = 18
        Me.Place1.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(811, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Place"
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Car2
        '
        Me.Car2.BackColor = System.Drawing.Color.Red
        Me.Car2.Location = New System.Drawing.Point(52, 138)
        Me.Car2.Name = "Car2"
        Me.Car2.Size = New System.Drawing.Size(59, 23)
        Me.Car2.TabIndex = 20
        Me.Car2.Text = "Car 2"
        '
        'Car4
        '
        Me.Car4.BackColor = System.Drawing.Color.Red
        Me.Car4.Location = New System.Drawing.Point(52, 217)
        Me.Car4.Name = "Car4"
        Me.Car4.Size = New System.Drawing.Size(59, 23)
        Me.Car4.TabIndex = 21
        Me.Car4.Text = "Car 4"
        '
        'Place4
        '
        Me.Place4.AutoSize = True
        Me.Place4.Location = New System.Drawing.Point(811, 237)
        Me.Place4.Name = "Place4"
        Me.Place4.Size = New System.Drawing.Size(13, 13)
        Me.Place4.TabIndex = 22
        Me.Place4.Text = "0"
        '
        'Time4
        '
        Me.Time4.AutoSize = True
        Me.Time4.Location = New System.Drawing.Point(700, 237)
        Me.Time4.Name = "Time4"
        Me.Time4.Size = New System.Drawing.Size(13, 13)
        Me.Time4.TabIndex = 23
        Me.Time4.Text = "0"
        '
        'Time2
        '
        Me.Time2.AutoSize = True
        Me.Time2.Location = New System.Drawing.Point(700, 148)
        Me.Time2.Name = "Time2"
        Me.Time2.Size = New System.Drawing.Size(13, 13)
        Me.Time2.TabIndex = 24
        Me.Time2.Text = "0"
        '
        'Place2
        '
        Me.Place2.AutoSize = True
        Me.Place2.Location = New System.Drawing.Point(811, 148)
        Me.Place2.Name = "Place2"
        Me.Place2.Size = New System.Drawing.Size(13, 13)
        Me.Place2.TabIndex = 25
        Me.Place2.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 487)
        Me.Controls.Add(Me.Place2)
        Me.Controls.Add(Me.Time2)
        Me.Controls.Add(Me.Time4)
        Me.Controls.Add(Me.Place4)
        Me.Controls.Add(Me.Car4)
        Me.Controls.Add(Me.Car2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Place1)
        Me.Controls.Add(Me.Place3)
        Me.Controls.Add(Me.Time3)
        Me.Controls.Add(Me.Car3)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Time1)
        Me.Controls.Add(Me.lblTimes)
        Me.Controls.Add(Me.finishLine)
        Me.Controls.Add(Me.Car1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents Time1 As Label
    Friend WithEvents finishLine As Label
    Friend WithEvents Car1 As Label
    Friend WithEvents lblTimes As Label
    Friend WithEvents Car3 As Label
    Friend WithEvents Time3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Place3 As Label
    Friend WithEvents Place1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Car2 As Label
    Friend WithEvents Car4 As Label
    Friend WithEvents Place4 As Label
    Friend WithEvents Time4 As Label
    Friend WithEvents Time2 As Label
    Friend WithEvents Place2 As Label
End Class
