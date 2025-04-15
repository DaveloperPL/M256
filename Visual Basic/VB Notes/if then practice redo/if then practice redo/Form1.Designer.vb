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
        Me.btnQuestions = New System.Windows.Forms.Button()
        Me.lblCheck = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnQuestions
        '
        Me.btnQuestions.Location = New System.Drawing.Point(12, 49)
        Me.btnQuestions.Name = "btnQuestions"
        Me.btnQuestions.Size = New System.Drawing.Size(218, 53)
        Me.btnQuestions.TabIndex = 0
        Me.btnQuestions.Text = "Ask Questions"
        Me.btnQuestions.UseVisualStyleBackColor = True
        '
        'lblCheck
        '
        Me.lblCheck.AutoSize = True
        Me.lblCheck.Location = New System.Drawing.Point(64, 121)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.Size = New System.Drawing.Size(41, 15)
        Me.lblCheck.TabIndex = 1
        Me.lblCheck.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblCheck)
        Me.Controls.Add(Me.btnQuestions)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnQuestions As Button
    Friend WithEvents lblCheck As Label
End Class
