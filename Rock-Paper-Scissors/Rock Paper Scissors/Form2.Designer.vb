<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Normal
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
        Me.BTN_Rock = New System.Windows.Forms.Button()
        Me.BTN_Paper = New System.Windows.Forms.Button()
        Me.BTN_Scissors = New System.Windows.Forms.Button()
        Me.LBL_Won = New System.Windows.Forms.Label()
        Me.LBL_COM_CHOOSE = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN_Rock
        '
        Me.BTN_Rock.Location = New System.Drawing.Point(13, 12)
        Me.BTN_Rock.Name = "BTN_Rock"
        Me.BTN_Rock.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Rock.TabIndex = 0
        Me.BTN_Rock.Text = "Rock"
        Me.BTN_Rock.UseVisualStyleBackColor = True
        '
        'BTN_Paper
        '
        Me.BTN_Paper.Location = New System.Drawing.Point(94, 12)
        Me.BTN_Paper.Name = "BTN_Paper"
        Me.BTN_Paper.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Paper.TabIndex = 1
        Me.BTN_Paper.Text = "Paper"
        Me.BTN_Paper.UseVisualStyleBackColor = True
        '
        'BTN_Scissors
        '
        Me.BTN_Scissors.Location = New System.Drawing.Point(175, 12)
        Me.BTN_Scissors.Name = "BTN_Scissors"
        Me.BTN_Scissors.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Scissors.TabIndex = 2
        Me.BTN_Scissors.Text = "Scissors"
        Me.BTN_Scissors.UseVisualStyleBackColor = True
        '
        'LBL_Won
        '
        Me.LBL_Won.AutoSize = True
        Me.LBL_Won.Location = New System.Drawing.Point(12, 60)
        Me.LBL_Won.Name = "LBL_Won"
        Me.LBL_Won.Size = New System.Drawing.Size(0, 13)
        Me.LBL_Won.TabIndex = 3
        '
        'LBL_COM_CHOOSE
        '
        Me.LBL_COM_CHOOSE.AutoSize = True
        Me.LBL_COM_CHOOSE.Location = New System.Drawing.Point(12, 38)
        Me.LBL_COM_CHOOSE.Name = "LBL_COM_CHOOSE"
        Me.LBL_COM_CHOOSE.Size = New System.Drawing.Size(0, 13)
        Me.LBL_COM_CHOOSE.TabIndex = 4
        '
        'FRM_Normal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 81)
        Me.Controls.Add(Me.LBL_COM_CHOOSE)
        Me.Controls.Add(Me.LBL_Won)
        Me.Controls.Add(Me.BTN_Scissors)
        Me.Controls.Add(Me.BTN_Paper)
        Me.Controls.Add(Me.BTN_Rock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FRM_Normal"
        Me.Text = "Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_Rock As Button
    Friend WithEvents BTN_Paper As Button
    Friend WithEvents BTN_Scissors As Button
    Friend WithEvents LBL_Won As Label
    Friend WithEvents LBL_COM_CHOOSE As Label
End Class
