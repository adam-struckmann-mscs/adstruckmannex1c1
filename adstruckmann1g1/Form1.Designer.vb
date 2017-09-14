<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Me.lbltest1 = New System.Windows.Forms.Label()
        Me.lbltest2 = New System.Windows.Forms.Label()
        Me.lbltest3 = New System.Windows.Forms.Label()
        Me.lblavgscore = New System.Windows.Forms.Label()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.txttest1 = New System.Windows.Forms.TextBox()
        Me.txttest2 = New System.Windows.Forms.TextBox()
        Me.txttest3 = New System.Windows.Forms.TextBox()
        Me.lblavgscore1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbltest1
        '
        Me.lbltest1.AutoSize = True
        Me.lbltest1.Location = New System.Drawing.Point(27, 77)
        Me.lbltest1.Name = "lbltest1"
        Me.lbltest1.Size = New System.Drawing.Size(89, 20)
        Me.lbltest1.TabIndex = 1
        Me.lbltest1.Text = "Test score 1:"
        '
        'lbltest2
        '
        Me.lbltest2.AutoSize = True
        Me.lbltest2.Location = New System.Drawing.Point(27, 119)
        Me.lbltest2.Name = "lbltest2"
        Me.lbltest2.Size = New System.Drawing.Size(89, 20)
        Me.lbltest2.TabIndex = 5
        Me.lbltest2.Text = "Test score 2:"
        '
        'lbltest3
        '
        Me.lbltest3.AutoSize = True
        Me.lbltest3.Location = New System.Drawing.Point(27, 163)
        Me.lbltest3.Name = "lbltest3"
        Me.lbltest3.Size = New System.Drawing.Size(89, 20)
        Me.lbltest3.TabIndex = 6
        Me.lbltest3.Text = "Test score 3:"
        '
        'lblavgscore
        '
        Me.lblavgscore.AutoSize = True
        Me.lblavgscore.Location = New System.Drawing.Point(33, 319)
        Me.lblavgscore.Name = "lblavgscore"
        Me.lblavgscore.Size = New System.Drawing.Size(134, 20)
        Me.lblavgscore.TabIndex = 10
        Me.lblavgscore.Text = "Average test score:"
        '
        'btncalc
        '
        Me.btncalc.Location = New System.Drawing.Point(262, 74)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(90, 28)
        Me.btncalc.TabIndex = 7
        Me.btncalc.Text = "Calculate"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(262, 116)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(90, 28)
        Me.btnclear.TabIndex = 8
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(262, 160)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(90, 28)
        Me.btnexit.TabIndex = 9
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'txttest1
        '
        Me.txttest1.Location = New System.Drawing.Point(131, 74)
        Me.txttest1.Name = "txttest1"
        Me.txttest1.Size = New System.Drawing.Size(100, 27)
        Me.txttest1.TabIndex = 2
        Me.txttest1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttest2
        '
        Me.txttest2.Location = New System.Drawing.Point(131, 116)
        Me.txttest2.Name = "txttest2"
        Me.txttest2.Size = New System.Drawing.Size(100, 27)
        Me.txttest2.TabIndex = 3
        Me.txttest2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txttest3
        '
        Me.txttest3.Location = New System.Drawing.Point(131, 160)
        Me.txttest3.Name = "txttest3"
        Me.txttest3.Size = New System.Drawing.Size(100, 27)
        Me.txttest3.TabIndex = 4
        Me.txttest3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblavgscore1
        '
        Me.lblavgscore1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblavgscore1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblavgscore1.Location = New System.Drawing.Point(183, 318)
        Me.lblavgscore1.Name = "lblavgscore1"
        Me.lblavgscore1.Size = New System.Drawing.Size(99, 22)
        Me.lblavgscore1.TabIndex = 0
        Me.lblavgscore1.Text = "0.00"
        Me.lblavgscore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 402)
        Me.Controls.Add(Me.lblavgscore1)
        Me.Controls.Add(Me.txttest3)
        Me.Controls.Add(Me.txttest2)
        Me.Controls.Add(Me.txttest1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.lblavgscore)
        Me.Controls.Add(Me.lbltest3)
        Me.Controls.Add(Me.lbltest2)
        Me.Controls.Add(Me.lbltest1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmmain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbltest1 As Label
    Friend WithEvents lbltest2 As Label
    Friend WithEvents lbltest3 As Label
    Friend WithEvents lblavgscore As Label
    Friend WithEvents btncalc As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents txttest1 As TextBox
    Friend WithEvents txttest2 As TextBox
    Friend WithEvents txttest3 As TextBox
    Friend WithEvents lblavgscore1 As Label
End Class
