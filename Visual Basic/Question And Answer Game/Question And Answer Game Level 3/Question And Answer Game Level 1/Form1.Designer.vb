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
        Me.lblQ1 = New System.Windows.Forms.Label()
        Me.lblQ2 = New System.Windows.Forms.Label()
        Me.lblQ3 = New System.Windows.Forms.Label()
        Me.lblQ4 = New System.Windows.Forms.Label()
        Me.txtbxQ1 = New System.Windows.Forms.TextBox()
        Me.txtbxQ2 = New System.Windows.Forms.TextBox()
        Me.txtbxQ3 = New System.Windows.Forms.TextBox()
        Me.txtbxQ4 = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lbl = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.lblAnimation = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblQ1
        '
        Me.lblQ1.AutoSize = True
        Me.lblQ1.Location = New System.Drawing.Point(351, 183)
        Me.lblQ1.Name = "lblQ1"
        Me.lblQ1.Size = New System.Drawing.Size(21, 13)
        Me.lblQ1.TabIndex = 0
        Me.lblQ1.Text = "Q1"
        '
        'lblQ2
        '
        Me.lblQ2.AutoSize = True
        Me.lblQ2.Location = New System.Drawing.Point(489, 183)
        Me.lblQ2.Name = "lblQ2"
        Me.lblQ2.Size = New System.Drawing.Size(89, 13)
        Me.lblQ2.TabIndex = 1
        Me.lblQ2.Text = "What month is it?"
        '
        'lblQ3
        '
        Me.lblQ3.AutoSize = True
        Me.lblQ3.Location = New System.Drawing.Point(641, 167)
        Me.lblQ3.Name = "lblQ3"
        Me.lblQ3.Size = New System.Drawing.Size(172, 13)
        Me.lblQ3.TabIndex = 2
        Me.lblQ3.Text = "What's the most valuable company"
        Me.lblQ3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQ4
        '
        Me.lblQ4.AutoSize = True
        Me.lblQ4.Location = New System.Drawing.Point(839, 183)
        Me.lblQ4.Name = "lblQ4"
        Me.lblQ4.Size = New System.Drawing.Size(21, 13)
        Me.lblQ4.TabIndex = 3
        Me.lblQ4.Text = "Q4"
        '
        'txtbxQ1
        '
        Me.txtbxQ1.Location = New System.Drawing.Point(338, 199)
        Me.txtbxQ1.Name = "txtbxQ1"
        Me.txtbxQ1.Size = New System.Drawing.Size(100, 20)
        Me.txtbxQ1.TabIndex = 4
        '
        'txtbxQ2
        '
        Me.txtbxQ2.Location = New System.Drawing.Point(482, 200)
        Me.txtbxQ2.Name = "txtbxQ2"
        Me.txtbxQ2.Size = New System.Drawing.Size(100, 20)
        Me.txtbxQ2.TabIndex = 5
        '
        'txtbxQ3
        '
        Me.txtbxQ3.Location = New System.Drawing.Point(673, 199)
        Me.txtbxQ3.Name = "txtbxQ3"
        Me.txtbxQ3.Size = New System.Drawing.Size(100, 20)
        Me.txtbxQ3.TabIndex = 6
        '
        'txtbxQ4
        '
        Me.txtbxQ4.Location = New System.Drawing.Point(826, 199)
        Me.txtbxQ4.Name = "txtbxQ4"
        Me.txtbxQ4.Size = New System.Drawing.Size(100, 20)
        Me.txtbxQ4.TabIndex = 7
        '
        'btnSubmit
        '
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnSubmit.Location = New System.Drawing.Point(461, 21)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(322, 92)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "Submit to see if you are correct!"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl.Location = New System.Drawing.Point(365, 221)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(46, 31)
        Me.lbl.TabIndex = 9
        Me.lbl.Text = "✔"
        Me.lbl.Visible = False
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl2.Location = New System.Drawing.Point(514, 222)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(46, 31)
        Me.lbl2.TabIndex = 10
        Me.lbl2.Text = "✔"
        Me.lbl2.Visible = False
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl3.Location = New System.Drawing.Point(703, 221)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(46, 31)
        Me.lbl3.TabIndex = 11
        Me.lbl3.Text = "✔"
        Me.lbl3.Visible = False
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl4.Location = New System.Drawing.Point(855, 221)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(46, 31)
        Me.lbl4.TabIndex = 12
        Me.lbl4.Text = "✔"
        Me.lbl4.Visible = False
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.BackColor = System.Drawing.Color.Transparent
        Me.lblPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.5!)
        Me.lblPercent.Location = New System.Drawing.Point(394, 271)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(286, 55)
        Me.lblPercent.TabIndex = 15
        Me.lblPercent.Text = "PlaceHolder"
        Me.lblPercent.Visible = False
        '
        'lblAnimation
        '
        Me.lblAnimation.AutoSize = True
        Me.lblAnimation.BackColor = System.Drawing.Color.Transparent
        Me.lblAnimation.Font = New System.Drawing.Font("Microsoft Sans Serif", 65.0!)
        Me.lblAnimation.Location = New System.Drawing.Point(558, 326)
        Me.lblAnimation.Name = "lblAnimation"
        Me.lblAnimation.Size = New System.Drawing.Size(516, 98)
        Me.lblAnimation.TabIndex = 16
        Me.lblAnimation.Text = "PlaceHolder"
        Me.lblAnimation.Visible = False
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.btnReset.Location = New System.Drawing.Point(559, 557)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(141, 50)
        Me.btnReset.TabIndex = 17
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        Me.btnReset.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(695, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "in America?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblAnimation)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtbxQ4)
        Me.Controls.Add(Me.txtbxQ3)
        Me.Controls.Add(Me.txtbxQ2)
        Me.Controls.Add(Me.txtbxQ1)
        Me.Controls.Add(Me.lblQ4)
        Me.Controls.Add(Me.lblQ3)
        Me.Controls.Add(Me.lblQ2)
        Me.Controls.Add(Me.lblQ1)
        Me.Name = "Form1"
        Me.Text = "Quiz"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQ1 As Label
    Friend WithEvents lblQ2 As Label
    Friend WithEvents lblQ3 As Label
    Friend WithEvents lblQ4 As Label
    Friend WithEvents txtbxQ1 As TextBox
    Friend WithEvents txtbxQ2 As TextBox
    Friend WithEvents txtbxQ3 As TextBox
    Friend WithEvents txtbxQ4 As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lbl As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lblPercent As Label
    Friend WithEvents lblAnimation As Label
	Friend WithEvents btnReset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
End Class
