<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Retirement_Form
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
        Me.btncalc = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.lblgross = New System.Windows.Forms.Label()
        Me.lblemp1 = New System.Windows.Forms.Label()
        Me.lblemp2 = New System.Windows.Forms.Label()
        Me.lblempannual1 = New System.Windows.Forms.Label()
        Me.lblempannual2 = New System.Windows.Forms.Label()
        Me.lbltotalcont = New System.Windows.Forms.Label()
        Me.lblannual1 = New System.Windows.Forms.Label()
        Me.txtgross = New System.Windows.Forms.TextBox()
        Me.txtemp1 = New System.Windows.Forms.TextBox()
        Me.txtemp2 = New System.Windows.Forms.TextBox()
        Me.lblannual2 = New System.Windows.Forms.Label()
        Me.lblannualcont = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btncalc
        '
        Me.btncalc.Location = New System.Drawing.Point(349, 382)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(79, 31)
        Me.btncalc.TabIndex = 0
        Me.btncalc.Text = "Calculate"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(476, 382)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(101, 31)
        Me.btnexit.TabIndex = 1
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'lblgross
        '
        Me.lblgross.AutoSize = True
        Me.lblgross.Location = New System.Drawing.Point(90, 38)
        Me.lblgross.Name = "lblgross"
        Me.lblgross.Size = New System.Drawing.Size(93, 13)
        Me.lblgross.TabIndex = 2
        Me.lblgross.Text = "Gross weekly pay:"
        '
        'lblemp1
        '
        Me.lblemp1.AutoSize = True
        Me.lblemp1.Location = New System.Drawing.Point(90, 64)
        Me.lblemp1.Name = "lblemp1"
        Me.lblemp1.Size = New System.Drawing.Size(203, 13)
        Me.lblemp1.TabIndex = 3
        Me.lblemp1.Text = "Employee contribution rate (decimal form):"
        '
        'lblemp2
        '
        Me.lblemp2.AutoSize = True
        Me.lblemp2.Location = New System.Drawing.Point(90, 98)
        Me.lblemp2.Name = "lblemp2"
        Me.lblemp2.Size = New System.Drawing.Size(200, 13)
        Me.lblemp2.TabIndex = 4
        Me.lblemp2.Text = "Employer contribution rate (decimal form):"
        '
        'lblempannual1
        '
        Me.lblempannual1.AutoSize = True
        Me.lblempannual1.Location = New System.Drawing.Point(90, 230)
        Me.lblempannual1.Name = "lblempannual1"
        Me.lblempannual1.Size = New System.Drawing.Size(149, 13)
        Me.lblempannual1.TabIndex = 5
        Me.lblempannual1.Text = "Employee annual contribution:"
        '
        'lblempannual2
        '
        Me.lblempannual2.AutoSize = True
        Me.lblempannual2.Location = New System.Drawing.Point(90, 272)
        Me.lblempannual2.Name = "lblempannual2"
        Me.lblempannual2.Size = New System.Drawing.Size(146, 13)
        Me.lblempannual2.TabIndex = 6
        Me.lblempannual2.Text = "Employer annual contribution:"
        '
        'lbltotalcont
        '
        Me.lbltotalcont.AutoSize = True
        Me.lbltotalcont.Location = New System.Drawing.Point(90, 310)
        Me.lbltotalcont.Name = "lbltotalcont"
        Me.lbltotalcont.Size = New System.Drawing.Size(127, 13)
        Me.lbltotalcont.TabIndex = 7
        Me.lbltotalcont.Text = "Total annual contribution:"
        '
        'lblannual1
        '
        Me.lblannual1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblannual1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblannual1.Location = New System.Drawing.Point(469, 220)
        Me.lblannual1.Name = "lblannual1"
        Me.lblannual1.Size = New System.Drawing.Size(100, 23)
        Me.lblannual1.TabIndex = 8
        Me.lblannual1.Text = " "
        '
        'txtgross
        '
        Me.txtgross.Location = New System.Drawing.Point(469, 31)
        Me.txtgross.Name = "txtgross"
        Me.txtgross.Size = New System.Drawing.Size(100, 20)
        Me.txtgross.TabIndex = 9
        '
        'txtemp1
        '
        Me.txtemp1.Location = New System.Drawing.Point(469, 57)
        Me.txtemp1.Name = "txtemp1"
        Me.txtemp1.Size = New System.Drawing.Size(100, 20)
        Me.txtemp1.TabIndex = 10
        Me.txtemp1.Text = "0.05"
        Me.txtemp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtemp2
        '
        Me.txtemp2.Location = New System.Drawing.Point(469, 91)
        Me.txtemp2.Name = "txtemp2"
        Me.txtemp2.Size = New System.Drawing.Size(100, 20)
        Me.txtemp2.TabIndex = 11
        Me.txtemp2.Text = "0.07"
        Me.txtemp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblannual2
        '
        Me.lblannual2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblannual2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblannual2.Location = New System.Drawing.Point(469, 262)
        Me.lblannual2.Name = "lblannual2"
        Me.lblannual2.Size = New System.Drawing.Size(100, 23)
        Me.lblannual2.TabIndex = 12
        Me.lblannual2.Text = " "
        '
        'lblannualcont
        '
        Me.lblannualcont.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblannualcont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblannualcont.Location = New System.Drawing.Point(469, 300)
        Me.lblannualcont.Name = "lblannualcont"
        Me.lblannualcont.Size = New System.Drawing.Size(100, 23)
        Me.lblannualcont.TabIndex = 13
        Me.lblannualcont.Text = " "
        '
        'Retirement_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 433)
        Me.Controls.Add(Me.lblannualcont)
        Me.Controls.Add(Me.lblannual2)
        Me.Controls.Add(Me.txtemp2)
        Me.Controls.Add(Me.txtemp1)
        Me.Controls.Add(Me.txtgross)
        Me.Controls.Add(Me.lblannual1)
        Me.Controls.Add(Me.lbltotalcont)
        Me.Controls.Add(Me.lblempannual2)
        Me.Controls.Add(Me.lblempannual1)
        Me.Controls.Add(Me.lblemp2)
        Me.Controls.Add(Me.lblemp1)
        Me.Controls.Add(Me.lblgross)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btncalc)
        Me.Name = "Retirement_Form"
        Me.Text = "Retirement_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncalc As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents lblgross As Label
    Friend WithEvents lblemp1 As Label
    Friend WithEvents lblemp2 As Label
    Friend WithEvents lblempannual1 As Label
    Friend WithEvents lblempannual2 As Label
    Friend WithEvents lbltotalcont As Label
    Friend WithEvents lblannual1 As Label
    Friend WithEvents txtgross As TextBox
    Friend WithEvents txtemp1 As TextBox
    Friend WithEvents txtemp2 As TextBox
    Friend WithEvents lblannual2 As Label
    Friend WithEvents lblannualcont As Label
End Class
