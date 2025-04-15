<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lblQ1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnQ1 = New System.Windows.Forms.Button()
        Me.lblCheck1 = New System.Windows.Forms.Label()
        Me.lblCheck2 = New System.Windows.Forms.Label()
        Me.btnQ2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblQ2 = New System.Windows.Forms.Label()
        Me.lblNumCorrect = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'lblQ1
        '
        Me.lblQ1.AutoSize = True
        Me.lblQ1.Location = New System.Drawing.Point(48, 37)
        Me.lblQ1.Name = "lblQ1"
        Me.lblQ1.Size = New System.Drawing.Size(39, 13)
        Me.lblQ1.TabIndex = 0
        Me.lblQ1.Text = "Label1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(51, 80)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'btnQ1
        '
        Me.btnQ1.Location = New System.Drawing.Point(51, 133)
        Me.btnQ1.Name = "btnQ1"
        Me.btnQ1.Size = New System.Drawing.Size(75, 23)
        Me.btnQ1.TabIndex = 2
        Me.btnQ1.Text = "Submit"
        Me.btnQ1.UseVisualStyleBackColor = True
        '
        'lblCheck1
        '
        Me.lblCheck1.AutoSize = True
        Me.lblCheck1.Location = New System.Drawing.Point(51, 184)
        Me.lblCheck1.Name = "lblCheck1"
        Me.lblCheck1.Size = New System.Drawing.Size(0, 13)
        Me.lblCheck1.TabIndex = 3
        '
        'lblCheck2
        '
        Me.lblCheck2.AutoSize = True
        Me.lblCheck2.Location = New System.Drawing.Point(458, 184)
        Me.lblCheck2.Name = "lblCheck2"
        Me.lblCheck2.Size = New System.Drawing.Size(0, 13)
        Me.lblCheck2.TabIndex = 7
        '
        'btnQ2
        '
        Me.btnQ2.Location = New System.Drawing.Point(458, 133)
        Me.btnQ2.Name = "btnQ2"
        Me.btnQ2.Size = New System.Drawing.Size(75, 23)
        Me.btnQ2.TabIndex = 6
        Me.btnQ2.Text = "Submit"
        Me.btnQ2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(458, 80)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 5
        '
        'lblQ2
        '
        Me.lblQ2.AutoSize = True
        Me.lblQ2.Location = New System.Drawing.Point(455, 37)
        Me.lblQ2.Name = "lblQ2"
        Me.lblQ2.Size = New System.Drawing.Size(39, 13)
        Me.lblQ2.TabIndex = 4
        Me.lblQ2.Text = "Label1"
        '
        'lblNumCorrect
        '
        Me.lblNumCorrect.AutoSize = True
        Me.lblNumCorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumCorrect.Location = New System.Drawing.Point(348, 317)
        Me.lblNumCorrect.Name = "lblNumCorrect"
        Me.lblNumCorrect.Size = New System.Drawing.Size(35, 37)
        Me.lblNumCorrect.TabIndex = 8
        Me.lblNumCorrect.Text = "0"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(260, 225)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 9
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.lblNumCorrect)
        Me.Controls.Add(Me.lblCheck2)
        Me.Controls.Add(Me.btnQ2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblQ2)
        Me.Controls.Add(Me.lblCheck1)
        Me.Controls.Add(Me.btnQ1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblQ1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQ1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnQ1 As Button
    Friend WithEvents lblCheck1 As Label
    Friend WithEvents lblCheck2 As Label
    Friend WithEvents btnQ2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblQ2 As Label
    Friend WithEvents lblNumCorrect As Label
    Friend WithEvents RadioButton1 As RadioButton
End Class
