<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.radsubCentimeters = New System.Windows.Forms.RadioButton()
        Me.radsubInches = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMeasurement = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.radfuncinches = New System.Windows.Forms.RadioButton()
        Me.radfunccentimeters = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.radfunc = New System.Windows.Forms.RadioButton()
        Me.radsub = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboplanet = New System.Windows.Forms.ComboBox()
        Me.txtweight = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'radsubCentimeters
        '
        Me.radsubCentimeters.Checked = True
        Me.radsubCentimeters.Location = New System.Drawing.Point(102, 44)
        Me.radsubCentimeters.Margin = New System.Windows.Forms.Padding(2)
        Me.radsubCentimeters.Name = "radsubCentimeters"
        Me.radsubCentimeters.Size = New System.Drawing.Size(246, 26)
        Me.radsubCentimeters.TabIndex = 2
        Me.radsubCentimeters.TabStop = True
        Me.radsubCentimeters.Text = "Sub: Inches to &Centimeters"
        '
        'radsubInches
        '
        Me.radsubInches.Location = New System.Drawing.Point(102, 81)
        Me.radsubInches.Margin = New System.Windows.Forms.Padding(2)
        Me.radsubInches.Name = "radsubInches"
        Me.radsubInches.Size = New System.Drawing.Size(246, 26)
        Me.radsubInches.TabIndex = 3
        Me.radsubInches.Text = "Sub: Centimeters to &Inches"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Measurement:"
        '
        'txtMeasurement
        '
        Me.txtMeasurement.Location = New System.Drawing.Point(8, 29)
        Me.txtMeasurement.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMeasurement.Name = "txtMeasurement"
        Me.txtMeasurement.Size = New System.Drawing.Size(55, 27)
        Me.txtMeasurement.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Result:"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(8, 105)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(81, 30)
        Me.lblResult.TabIndex = 7
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(9, 164)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(72, 30)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        '
        'radfuncinches
        '
        Me.radfuncinches.Location = New System.Drawing.Point(102, 156)
        Me.radfuncinches.Margin = New System.Windows.Forms.Padding(2)
        Me.radfuncinches.Name = "radfuncinches"
        Me.radfuncinches.Size = New System.Drawing.Size(246, 26)
        Me.radfuncinches.TabIndex = 9
        Me.radfuncinches.Text = "Func: Centimeters to &Inches"
        '
        'radfunccentimeters
        '
        Me.radfunccentimeters.Location = New System.Drawing.Point(102, 119)
        Me.radfunccentimeters.Margin = New System.Windows.Forms.Padding(2)
        Me.radfunccentimeters.Name = "radfunccentimeters"
        Me.radfunccentimeters.Size = New System.Drawing.Size(246, 26)
        Me.radfunccentimeters.TabIndex = 8
        Me.radfunccentimeters.Text = "Func: Inches to &Centimeters"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.radfuncinches)
        Me.GroupBox1.Controls.Add(Me.lblResult)
        Me.GroupBox1.Controls.Add(Me.radfunccentimeters)
        Me.GroupBox1.Controls.Add(Me.radsubInches)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.radsubCentimeters)
        Me.GroupBox1.Controls.Add(Me.txtMeasurement)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 207)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbltotal)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.radfunc)
        Me.GroupBox2.Controls.Add(Me.radsub)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cboplanet)
        Me.GroupBox2.Controls.Add(Me.txtweight)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 236)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(372, 200)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Weight on different planets"
        '
        'lbltotal
        '
        Me.lbltotal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbltotal.Location = New System.Drawing.Point(274, 54)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(92, 50)
        Me.lbltotal.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(143, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Weight on:"
        '
        'radfunc
        '
        Me.radfunc.AutoSize = True
        Me.radfunc.Location = New System.Drawing.Point(25, 148)
        Me.radfunc.Name = "radfunc"
        Me.radfunc.Size = New System.Drawing.Size(83, 24)
        Me.radfunc.TabIndex = 5
        Me.radfunc.Text = "Function"
        Me.radfunc.UseVisualStyleBackColor = True
        '
        'radsub
        '
        Me.radsub.AutoSize = True
        Me.radsub.Checked = True
        Me.radsub.Location = New System.Drawing.Point(25, 118)
        Me.radsub.Name = "radsub"
        Me.radsub.Size = New System.Drawing.Size(52, 24)
        Me.radsub.TabIndex = 4
        Me.radsub.TabStop = True
        Me.radsub.Text = "Sub"
        Me.radsub.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Calculate Using:"
        '
        'cboplanet
        '
        Me.cboplanet.FormattingEnabled = True
        Me.cboplanet.Location = New System.Drawing.Point(138, 64)
        Me.cboplanet.Name = "cboplanet"
        Me.cboplanet.Size = New System.Drawing.Size(117, 28)
        Me.cboplanet.TabIndex = 2
        Me.cboplanet.Text = "Earth"
        '
        'txtweight
        '
        Me.txtweight.Location = New System.Drawing.Point(9, 65)
        Me.txtweight.Name = "txtweight"
        Me.txtweight.Size = New System.Drawing.Size(100, 27)
        Me.txtweight.TabIndex = 1
        Me.txtweight.Text = "100"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Earth Weight:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 443)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Measurement Converter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents radsubCentimeters As System.Windows.Forms.RadioButton
    Friend WithEvents radsubInches As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMeasurement As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents radfuncinches As RadioButton
    Friend WithEvents radfunccentimeters As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents radfunc As RadioButton
    Friend WithEvents radsub As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents cboplanet As ComboBox
    Friend WithEvents txtweight As TextBox
    Friend WithEvents Label3 As Label
End Class
