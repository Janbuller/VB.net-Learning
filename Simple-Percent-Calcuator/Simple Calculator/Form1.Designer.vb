<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SMPLPCTCALC
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
        Me.TXT_Plus1 = New System.Windows.Forms.TextBox()
        Me.TXT_Plus2 = New System.Windows.Forms.TextBox()
        Me.TXT_Minus1 = New System.Windows.Forms.TextBox()
        Me.TXT_Between1 = New System.Windows.Forms.TextBox()
        Me.TXT_Between2 = New System.Windows.Forms.TextBox()
        Me.TXT_Minus2 = New System.Windows.Forms.TextBox()
        Me.LBL_Plus = New System.Windows.Forms.Label()
        Me.LBL_Minus = New System.Windows.Forms.Label()
        Me.LBL_Between = New System.Windows.Forms.Label()
        Me.LBL_Result2 = New System.Windows.Forms.Label()
        Me.LBL_Result1 = New System.Windows.Forms.Label()
        Me.LBL_Result3 = New System.Windows.Forms.Label()
        Me.BTN_Calc1 = New System.Windows.Forms.Button()
        Me.BTN_Calc3 = New System.Windows.Forms.Button()
        Me.BTN_Calc2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TXT_Plus1
        '
        Me.TXT_Plus1.Location = New System.Drawing.Point(12, 12)
        Me.TXT_Plus1.MaxLength = 308
        Me.TXT_Plus1.Name = "TXT_Plus1"
        Me.TXT_Plus1.Size = New System.Drawing.Size(142, 20)
        Me.TXT_Plus1.TabIndex = 0
        '
        'TXT_Plus2
        '
        Me.TXT_Plus2.Location = New System.Drawing.Point(184, 12)
        Me.TXT_Plus2.MaxLength = 308
        Me.TXT_Plus2.Name = "TXT_Plus2"
        Me.TXT_Plus2.Size = New System.Drawing.Size(194, 20)
        Me.TXT_Plus2.TabIndex = 1
        '
        'TXT_Minus1
        '
        Me.TXT_Minus1.Location = New System.Drawing.Point(12, 38)
        Me.TXT_Minus1.MaxLength = 308
        Me.TXT_Minus1.Name = "TXT_Minus1"
        Me.TXT_Minus1.Size = New System.Drawing.Size(142, 20)
        Me.TXT_Minus1.TabIndex = 3
        '
        'TXT_Between1
        '
        Me.TXT_Between1.Location = New System.Drawing.Point(13, 64)
        Me.TXT_Between1.MaxLength = 308
        Me.TXT_Between1.Name = "TXT_Between1"
        Me.TXT_Between1.Size = New System.Drawing.Size(142, 20)
        Me.TXT_Between1.TabIndex = 6
        '
        'TXT_Between2
        '
        Me.TXT_Between2.Location = New System.Drawing.Point(239, 65)
        Me.TXT_Between2.MaxLength = 308
        Me.TXT_Between2.Name = "TXT_Between2"
        Me.TXT_Between2.Size = New System.Drawing.Size(139, 20)
        Me.TXT_Between2.TabIndex = 7
        '
        'TXT_Minus2
        '
        Me.TXT_Minus2.Location = New System.Drawing.Point(184, 38)
        Me.TXT_Minus2.MaxLength = 308
        Me.TXT_Minus2.Name = "TXT_Minus2"
        Me.TXT_Minus2.Size = New System.Drawing.Size(194, 20)
        Me.TXT_Minus2.TabIndex = 4
        '
        'LBL_Plus
        '
        Me.LBL_Plus.AutoSize = True
        Me.LBL_Plus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Plus.Location = New System.Drawing.Point(160, 11)
        Me.LBL_Plus.Name = "LBL_Plus"
        Me.LBL_Plus.Size = New System.Drawing.Size(18, 20)
        Me.LBL_Plus.TabIndex = 6
        Me.LBL_Plus.Text = "+"
        '
        'LBL_Minus
        '
        Me.LBL_Minus.AutoSize = True
        Me.LBL_Minus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Minus.Location = New System.Drawing.Point(161, 36)
        Me.LBL_Minus.Name = "LBL_Minus"
        Me.LBL_Minus.Size = New System.Drawing.Size(14, 20)
        Me.LBL_Minus.TabIndex = 7
        Me.LBL_Minus.Text = "-"
        '
        'LBL_Between
        '
        Me.LBL_Between.AutoSize = True
        Me.LBL_Between.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Between.Location = New System.Drawing.Point(161, 64)
        Me.LBL_Between.Name = "LBL_Between"
        Me.LBL_Between.Size = New System.Drawing.Size(72, 20)
        Me.LBL_Between.TabIndex = 8
        Me.LBL_Between.Text = "Between"
        '
        'LBL_Result2
        '
        Me.LBL_Result2.AutoSize = True
        Me.LBL_Result2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Result2.Location = New System.Drawing.Point(450, 38)
        Me.LBL_Result2.Name = "LBL_Result2"
        Me.LBL_Result2.Size = New System.Drawing.Size(0, 20)
        Me.LBL_Result2.TabIndex = 9
        '
        'LBL_Result1
        '
        Me.LBL_Result1.AutoSize = True
        Me.LBL_Result1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Result1.Location = New System.Drawing.Point(450, 12)
        Me.LBL_Result1.Name = "LBL_Result1"
        Me.LBL_Result1.Size = New System.Drawing.Size(0, 20)
        Me.LBL_Result1.TabIndex = 10
        '
        'LBL_Result3
        '
        Me.LBL_Result3.AutoSize = True
        Me.LBL_Result3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Result3.Location = New System.Drawing.Point(450, 64)
        Me.LBL_Result3.Name = "LBL_Result3"
        Me.LBL_Result3.Size = New System.Drawing.Size(0, 20)
        Me.LBL_Result3.TabIndex = 11
        '
        'BTN_Calc1
        '
        Me.BTN_Calc1.Location = New System.Drawing.Point(384, 12)
        Me.BTN_Calc1.Name = "BTN_Calc1"
        Me.BTN_Calc1.Size = New System.Drawing.Size(60, 20)
        Me.BTN_Calc1.TabIndex = 2
        Me.BTN_Calc1.Text = "Calculate"
        Me.BTN_Calc1.UseVisualStyleBackColor = True
        '
        'BTN_Calc3
        '
        Me.BTN_Calc3.Location = New System.Drawing.Point(384, 64)
        Me.BTN_Calc3.Name = "BTN_Calc3"
        Me.BTN_Calc3.Size = New System.Drawing.Size(60, 20)
        Me.BTN_Calc3.TabIndex = 8
        Me.BTN_Calc3.Text = "Calculate"
        Me.BTN_Calc3.UseVisualStyleBackColor = True
        '
        'BTN_Calc2
        '
        Me.BTN_Calc2.Location = New System.Drawing.Point(384, 38)
        Me.BTN_Calc2.Name = "BTN_Calc2"
        Me.BTN_Calc2.Size = New System.Drawing.Size(60, 20)
        Me.BTN_Calc2.TabIndex = 5
        Me.BTN_Calc2.Text = "Calculate"
        Me.BTN_Calc2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(357, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "%"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(357, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(357, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "%"
        '
        'SMPLPCTCALC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 97)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_Calc2)
        Me.Controls.Add(Me.BTN_Calc3)
        Me.Controls.Add(Me.BTN_Calc1)
        Me.Controls.Add(Me.LBL_Result3)
        Me.Controls.Add(Me.LBL_Result1)
        Me.Controls.Add(Me.LBL_Result2)
        Me.Controls.Add(Me.LBL_Between)
        Me.Controls.Add(Me.LBL_Minus)
        Me.Controls.Add(Me.LBL_Plus)
        Me.Controls.Add(Me.TXT_Minus2)
        Me.Controls.Add(Me.TXT_Between2)
        Me.Controls.Add(Me.TXT_Between1)
        Me.Controls.Add(Me.TXT_Minus1)
        Me.Controls.Add(Me.TXT_Plus2)
        Me.Controls.Add(Me.TXT_Plus1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SMPLPCTCALC"
        Me.Text = "Simple Percent Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_Plus1 As TextBox
    Friend WithEvents TXT_Plus2 As TextBox
    Friend WithEvents TXT_Minus1 As TextBox
    Friend WithEvents TXT_Between1 As TextBox
    Friend WithEvents TXT_Between2 As TextBox
    Friend WithEvents TXT_Minus2 As TextBox
    Friend WithEvents LBL_Plus As Label
    Friend WithEvents LBL_Minus As Label
    Friend WithEvents LBL_Between As Label
    Friend WithEvents LBL_Result2 As Label
    Friend WithEvents LBL_Result1 As Label
    Friend WithEvents LBL_Result3 As Label
    Friend WithEvents BTN_Calc1 As Button
    Friend WithEvents BTN_Calc3 As Button
    Friend WithEvents BTN_Calc2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
