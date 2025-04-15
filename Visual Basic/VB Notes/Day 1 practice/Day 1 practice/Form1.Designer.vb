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
        Me.BtnStuff = New System.Windows.Forms.Button()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.bntNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnStuff
        '
        Me.BtnStuff.Location = New System.Drawing.Point(123, 104)
        Me.BtnStuff.Name = "BtnStuff"
        Me.BtnStuff.Size = New System.Drawing.Size(205, 47)
        Me.BtnStuff.TabIndex = 0
        Me.BtnStuff.Text = "Click to change things"
        Me.BtnStuff.UseVisualStyleBackColor = True
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Location = New System.Drawing.Point(151, 63)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(31, 13)
        Me.lblChange.TabIndex = 1
        Me.lblChange.Text = "Hello"
        '
        'bntNext
        '
        Me.bntNext.Location = New System.Drawing.Point(452, 181)
        Me.bntNext.Name = "bntNext"
        Me.bntNext.Size = New System.Drawing.Size(207, 61)
        Me.bntNext.TabIndex = 2
        Me.bntNext.Text = "Click for next form"
        Me.bntNext.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.bntNext)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.BtnStuff)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnStuff As Button
    Friend WithEvents lblChange As Label
    Friend WithEvents bntNext As Button
End Class
