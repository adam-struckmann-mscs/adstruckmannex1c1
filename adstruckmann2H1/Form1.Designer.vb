<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcommission
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
        Me.lblsales = New System.Windows.Forms.Label()
        Me.txtsales = New System.Windows.Forms.TextBox()
        Me.lblcommission1 = New System.Windows.Forms.Label()
        Me.lblcommission = New System.Windows.Forms.Label()
        Me.lbladditional1 = New System.Windows.Forms.Label()
        Me.lbladditional = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.btncalcifthen = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.lbltotal1 = New System.Windows.Forms.Label()
        Me.chk10years = New System.Windows.Forms.CheckBox()
        Me.chktraveling = New System.Windows.Forms.CheckBox()
        Me.btncalcnested = New System.Windows.Forms.Button()
        Me.btnifelse = New System.Windows.Forms.Button()
        Me.btnselect = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblsales
        '
        Me.lblsales.AutoSize = True
        Me.lblsales.Location = New System.Drawing.Point(31, 48)
        Me.lblsales.Name = "lblsales"
        Me.lblsales.Size = New System.Drawing.Size(36, 13)
        Me.lblsales.TabIndex = 0
        Me.lblsales.Text = "&Sales:"
        '
        'txtsales
        '
        Me.txtsales.Location = New System.Drawing.Point(36, 79)
        Me.txtsales.Name = "txtsales"
        Me.txtsales.Size = New System.Drawing.Size(100, 20)
        Me.txtsales.TabIndex = 1
        '
        'lblcommission1
        '
        Me.lblcommission1.AutoSize = True
        Me.lblcommission1.Location = New System.Drawing.Point(34, 165)
        Me.lblcommission1.Name = "lblcommission1"
        Me.lblcommission1.Size = New System.Drawing.Size(89, 13)
        Me.lblcommission1.TabIndex = 2
        Me.lblcommission1.Text = "Commission Only:"
        '
        'lblcommission
        '
        Me.lblcommission.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lblcommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcommission.Location = New System.Drawing.Point(37, 200)
        Me.lblcommission.Name = "lblcommission"
        Me.lblcommission.Size = New System.Drawing.Size(99, 31)
        Me.lblcommission.TabIndex = 3
        Me.lblcommission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbladditional1
        '
        Me.lbladditional1.AutoSize = True
        Me.lbladditional1.Location = New System.Drawing.Point(33, 259)
        Me.lbladditional1.Name = "lbladditional1"
        Me.lbladditional1.Size = New System.Drawing.Size(95, 13)
        Me.lbladditional1.TabIndex = 4
        Me.lbladditional1.Text = "Additional Amount:"
        '
        'lbladditional
        '
        Me.lbladditional.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lbladditional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbladditional.Location = New System.Drawing.Point(37, 282)
        Me.lbladditional.Name = "lbladditional"
        Me.lbladditional.Size = New System.Drawing.Size(99, 31)
        Me.lbladditional.TabIndex = 5
        Me.lbladditional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltotal
        '
        Me.lbltotal.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotal.Location = New System.Drawing.Point(151, 259)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(147, 54)
        Me.lbltotal.TabIndex = 6
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncalcifthen
        '
        Me.btncalcifthen.Location = New System.Drawing.Point(200, 73)
        Me.btncalcifthen.Name = "btncalcifthen"
        Me.btncalcifthen.Size = New System.Drawing.Size(75, 23)
        Me.btncalcifthen.TabIndex = 7
        Me.btncalcifthen.Text = "If then"
        Me.btncalcifthen.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(200, 190)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 8
        Me.btnexit.Text = "E&xit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'lbltotal1
        '
        Me.lbltotal1.AutoSize = True
        Me.lbltotal1.Location = New System.Drawing.Point(159, 243)
        Me.lbltotal1.Name = "lbltotal1"
        Me.lbltotal1.Size = New System.Drawing.Size(92, 13)
        Me.lbltotal1.TabIndex = 9
        Me.lbltotal1.Text = "Total Commission:"
        '
        'chk10years
        '
        Me.chk10years.AutoSize = True
        Me.chk10years.Location = New System.Drawing.Point(37, 131)
        Me.chk10years.Name = "chk10years"
        Me.chk10years.Size = New System.Drawing.Size(94, 17)
        Me.chk10years.TabIndex = 10
        Me.chk10years.Text = "&Over 10 Years"
        Me.chk10years.UseVisualStyleBackColor = True
        '
        'chktraveling
        '
        Me.chktraveling.AutoSize = True
        Me.chktraveling.Location = New System.Drawing.Point(37, 108)
        Me.chktraveling.Name = "chktraveling"
        Me.chktraveling.Size = New System.Drawing.Size(70, 17)
        Me.chktraveling.TabIndex = 11
        Me.chktraveling.Text = "&Traveling"
        Me.chktraveling.UseVisualStyleBackColor = True
        '
        'btncalcnested
        '
        Me.btncalcnested.Location = New System.Drawing.Point(200, 102)
        Me.btncalcnested.Name = "btncalcnested"
        Me.btncalcnested.Size = New System.Drawing.Size(75, 23)
        Me.btncalcnested.TabIndex = 12
        Me.btncalcnested.Text = "Nested if"
        Me.btncalcnested.UseVisualStyleBackColor = True
        '
        'btnifelse
        '
        Me.btnifelse.Location = New System.Drawing.Point(200, 131)
        Me.btnifelse.Name = "btnifelse"
        Me.btnifelse.Size = New System.Drawing.Size(75, 23)
        Me.btnifelse.TabIndex = 13
        Me.btnifelse.Text = "If Else"
        Me.btnifelse.UseVisualStyleBackColor = True
        '
        'btnselect
        '
        Me.btnselect.Location = New System.Drawing.Point(200, 162)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.Size = New System.Drawing.Size(75, 23)
        Me.btnselect.TabIndex = 14
        Me.btnselect.Text = "Select Case"
        Me.btnselect.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(304, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 258)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Commission Calculations"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(24, 208)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(145, 23)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Traveling                  $700"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(24, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 23)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Additional Amounts:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(130, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(203, 23)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "$3,120 plus 14% of the sales over 30,000"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(130, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(203, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "$120 plus 13% of the sales over 6,000"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(130, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(203, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "10% of sales"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(24, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = ">10 years                 $500"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(24, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "> 30,000"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "6,0000 - 29,999.99"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(21, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "1 - 5,999.99"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(178, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Commission"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(24, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales ($)"
        '
        'frmcommission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 375)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnselect)
        Me.Controls.Add(Me.btnifelse)
        Me.Controls.Add(Me.btncalcnested)
        Me.Controls.Add(Me.chktraveling)
        Me.Controls.Add(Me.chk10years)
        Me.Controls.Add(Me.lbltotal1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btncalcifthen)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lbladditional)
        Me.Controls.Add(Me.lbladditional1)
        Me.Controls.Add(Me.lblcommission)
        Me.Controls.Add(Me.lblcommission1)
        Me.Controls.Add(Me.txtsales)
        Me.Controls.Add(Me.lblsales)
        Me.Name = "frmcommission"
        Me.Text = "Marshall Sales Corporation"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblsales As Label
    Friend WithEvents txtsales As TextBox
    Friend WithEvents lblcommission1 As Label
    Friend WithEvents lblcommission As Label
    Friend WithEvents lbladditional1 As Label
    Friend WithEvents lbladditional As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents btncalcifthen As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents lbltotal1 As Label
    Friend WithEvents chk10years As CheckBox
    Friend WithEvents chktraveling As CheckBox
    Friend WithEvents btncalcnested As Button
    Friend WithEvents btnifelse As Button
    Friend WithEvents btnselect As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
