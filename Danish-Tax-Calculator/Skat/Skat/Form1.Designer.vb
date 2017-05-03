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
        Me.LBL_PENGE = New System.Windows.Forms.Label()
        Me.LBL_FRADRAG = New System.Windows.Forms.Label()
        Me.LBL_TRKPCT = New System.Windows.Forms.Label()
        Me.TXT_PENGE = New System.Windows.Forms.TextBox()
        Me.TXT_FRADRAG = New System.Windows.Forms.TextBox()
        Me.TXT_TRKPCT = New System.Windows.Forms.TextBox()
        Me.LBL_TILBAGE = New System.Windows.Forms.Label()
        Me.BTN_OK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBL_PENGE
        '
        Me.LBL_PENGE.AutoSize = True
        Me.LBL_PENGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PENGE.Location = New System.Drawing.Point(11, 9)
        Me.LBL_PENGE.Name = "LBL_PENGE"
        Me.LBL_PENGE.Size = New System.Drawing.Size(59, 20)
        Me.LBL_PENGE.TabIndex = 0
        Me.LBL_PENGE.Text = "Penge:"
        '
        'LBL_FRADRAG
        '
        Me.LBL_FRADRAG.AutoSize = True
        Me.LBL_FRADRAG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_FRADRAG.Location = New System.Drawing.Point(11, 35)
        Me.LBL_FRADRAG.Name = "LBL_FRADRAG"
        Me.LBL_FRADRAG.Size = New System.Drawing.Size(65, 20)
        Me.LBL_FRADRAG.TabIndex = 1
        Me.LBL_FRADRAG.Text = "Fradrag"
        '
        'LBL_TRKPCT
        '
        Me.LBL_TRKPCT.AutoSize = True
        Me.LBL_TRKPCT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TRKPCT.Location = New System.Drawing.Point(11, 61)
        Me.LBL_TRKPCT.Name = "LBL_TRKPCT"
        Me.LBL_TRKPCT.Size = New System.Drawing.Size(104, 20)
        Me.LBL_TRKPCT.TabIndex = 2
        Me.LBL_TRKPCT.Text = "Trækprocent:"
        '
        'TXT_PENGE
        '
        Me.TXT_PENGE.Location = New System.Drawing.Point(76, 9)
        Me.TXT_PENGE.Name = "TXT_PENGE"
        Me.TXT_PENGE.Size = New System.Drawing.Size(196, 20)
        Me.TXT_PENGE.TabIndex = 3
        '
        'TXT_FRADRAG
        '
        Me.TXT_FRADRAG.Location = New System.Drawing.Point(82, 35)
        Me.TXT_FRADRAG.Name = "TXT_FRADRAG"
        Me.TXT_FRADRAG.Size = New System.Drawing.Size(190, 20)
        Me.TXT_FRADRAG.TabIndex = 4
        '
        'TXT_TRKPCT
        '
        Me.TXT_TRKPCT.Location = New System.Drawing.Point(121, 61)
        Me.TXT_TRKPCT.Name = "TXT_TRKPCT"
        Me.TXT_TRKPCT.Size = New System.Drawing.Size(151, 20)
        Me.TXT_TRKPCT.TabIndex = 5
        '
        'LBL_TILBAGE
        '
        Me.LBL_TILBAGE.AutoSize = True
        Me.LBL_TILBAGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TILBAGE.Location = New System.Drawing.Point(12, 110)
        Me.LBL_TILBAGE.Name = "LBL_TILBAGE"
        Me.LBL_TILBAGE.Size = New System.Drawing.Size(111, 31)
        Me.LBL_TILBAGE.TabIndex = 6
        Me.LBL_TILBAGE.Text = "Tilbage:"
        '
        'BTN_OK
        '
        Me.BTN_OK.Location = New System.Drawing.Point(12, 84)
        Me.BTN_OK.Name = "BTN_OK"
        Me.BTN_OK.Size = New System.Drawing.Size(75, 23)
        Me.BTN_OK.TabIndex = 7
        Me.BTN_OK.Text = "OK"
        Me.BTN_OK.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 150)
        Me.Controls.Add(Me.BTN_OK)
        Me.Controls.Add(Me.LBL_TILBAGE)
        Me.Controls.Add(Me.TXT_TRKPCT)
        Me.Controls.Add(Me.TXT_FRADRAG)
        Me.Controls.Add(Me.TXT_PENGE)
        Me.Controls.Add(Me.LBL_TRKPCT)
        Me.Controls.Add(Me.LBL_FRADRAG)
        Me.Controls.Add(Me.LBL_PENGE)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Skat Udregning"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_PENGE As Label
    Friend WithEvents LBL_FRADRAG As Label
    Friend WithEvents LBL_TRKPCT As Label
    Friend WithEvents TXT_PENGE As TextBox
    Friend WithEvents TXT_FRADRAG As TextBox
    Friend WithEvents TXT_TRKPCT As TextBox
    Friend WithEvents LBL_TILBAGE As Label
    Friend WithEvents BTN_OK As Button
End Class
