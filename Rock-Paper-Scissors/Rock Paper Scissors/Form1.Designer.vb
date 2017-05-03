<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Difficulty
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
        Me.LBL_Difficulty = New System.Windows.Forms.Label()
        Me.BTN_Normal = New System.Windows.Forms.Button()
        Me.BTN_Impossible = New System.Windows.Forms.Button()
        Me.BTN_Hard = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBL_Difficulty
        '
        Me.LBL_Difficulty.AutoSize = True
        Me.LBL_Difficulty.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Difficulty.Location = New System.Drawing.Point(12, 9)
        Me.LBL_Difficulty.Name = "LBL_Difficulty"
        Me.LBL_Difficulty.Size = New System.Drawing.Size(260, 33)
        Me.LBL_Difficulty.TabIndex = 0
        Me.LBL_Difficulty.Text = "Choose a Diffculty:"
        '
        'BTN_Normal
        '
        Me.BTN_Normal.Location = New System.Drawing.Point(18, 45)
        Me.BTN_Normal.Name = "BTN_Normal"
        Me.BTN_Normal.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Normal.TabIndex = 1
        Me.BTN_Normal.Text = "Normal"
        Me.BTN_Normal.UseVisualStyleBackColor = True
        '
        'BTN_Impossible
        '
        Me.BTN_Impossible.Location = New System.Drawing.Point(180, 45)
        Me.BTN_Impossible.Name = "BTN_Impossible"
        Me.BTN_Impossible.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Impossible.TabIndex = 3
        Me.BTN_Impossible.Text = "Impossible"
        Me.BTN_Impossible.UseVisualStyleBackColor = True
        '
        'BTN_Hard
        '
        Me.BTN_Hard.Location = New System.Drawing.Point(99, 45)
        Me.BTN_Hard.Name = "BTN_Hard"
        Me.BTN_Hard.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Hard.TabIndex = 4
        Me.BTN_Hard.Text = "Hard"
        Me.BTN_Hard.UseVisualStyleBackColor = True
        '
        'FRM_Difficulty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 87)
        Me.Controls.Add(Me.BTN_Hard)
        Me.Controls.Add(Me.BTN_Impossible)
        Me.Controls.Add(Me.BTN_Normal)
        Me.Controls.Add(Me.LBL_Difficulty)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FRM_Difficulty"
        Me.Text = "Difficulty"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_Difficulty As Label
    Friend WithEvents BTN_Normal As Button
    Friend WithEvents BTN_Impossible As Button
    Friend WithEvents BTN_Hard As Button
End Class
