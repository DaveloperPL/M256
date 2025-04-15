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
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.lbl = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(392, 187)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(191, 68)
        Me.BtnAdd.TabIndex = 0
        Me.BtnAdd.Text = "Add Names"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(462, 269)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(39, 13)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "Label1"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(656, 187)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(191, 68)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "display names"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1267, 677)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.BtnAdd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAdd As Button
    Friend WithEvents lbl As Label
    Friend WithEvents btnDisplay As Button
End Class
