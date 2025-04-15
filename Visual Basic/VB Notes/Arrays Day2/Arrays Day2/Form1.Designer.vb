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
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl0 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnask = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl3
        '
        Me.lbl3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl3.Location = New System.Drawing.Point(517, 234)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(100, 23)
        Me.lbl3.TabIndex = 0
        '
        'lbl0
        '
        Me.lbl0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl0.Location = New System.Drawing.Point(193, 234)
        Me.lbl0.Name = "lbl0"
        Me.lbl0.Size = New System.Drawing.Size(100, 23)
        Me.lbl0.TabIndex = 1
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl1.Location = New System.Drawing.Point(301, 234)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(100, 23)
        Me.lbl1.TabIndex = 2
        '
        'lbl2
        '
        Me.lbl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl2.Location = New System.Drawing.Point(409, 234)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(100, 23)
        Me.lbl2.TabIndex = 3
        '
        'btnHide
        '
        Me.btnHide.Location = New System.Drawing.Point(289, 89)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(220, 46)
        Me.btnHide.TabIndex = 4
        Me.btnHide.Text = "Hide labels"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'btnask
        '
        Me.btnask.Location = New System.Drawing.Point(618, 94)
        Me.btnask.Name = "btnask"
        Me.btnask.Size = New System.Drawing.Size(120, 41)
        Me.btnask.TabIndex = 5
        Me.btnask.Text = "Ask names"
        Me.btnask.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(46, 89)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(156, 28)
        Me.btnDisplay.TabIndex = 6
        Me.btnDisplay.Text = "Display Names"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(46, 262)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(75, 23)
        Me.btn.TabIndex = 7
        Me.btn.Text = "search"
        Me.btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnask)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lbl0)
        Me.Controls.Add(Me.lbl3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl0 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents btnHide As Button
    Friend WithEvents btnask As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btn As Button
End Class
