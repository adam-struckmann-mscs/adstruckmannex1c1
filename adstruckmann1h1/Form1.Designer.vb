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
        Me.btncalc = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txthours = New System.Windows.Forms.TextBox()
        Me.txtpay = New System.Windows.Forms.TextBox()
        Me.lblgross = New System.Windows.Forms.Label()
        Me.lblfwt = New System.Windows.Forms.Label()
        Me.lblfica = New System.Windows.Forms.Label()
        Me.lblstate = New System.Windows.Forms.Label()
        Me.lblnet = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblhours = New System.Windows.Forms.Label()
        Me.lblpay = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncalc
        '
        Me.btncalc.Location = New System.Drawing.Point(135, 233)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(110, 32)
        Me.btncalc.TabIndex = 7
        Me.btncalc.Text = "Calculate"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(247, 233)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(110, 32)
        Me.btnclear.TabIndex = 8
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(359, 233)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(110, 32)
        Me.btnexit.TabIndex = 9
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.adstruckmann1h1.My.Resources.Resources.photo
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(169, 44)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(176, 20)
        Me.txtname.TabIndex = 1
        '
        'txthours
        '
        Me.txthours.Location = New System.Drawing.Point(390, 43)
        Me.txthours.Name = "txthours"
        Me.txthours.Size = New System.Drawing.Size(75, 20)
        Me.txthours.TabIndex = 3
        '
        'txtpay
        '
        Me.txtpay.Location = New System.Drawing.Point(489, 43)
        Me.txtpay.Name = "txtpay"
        Me.txtpay.Size = New System.Drawing.Size(65, 20)
        Me.txtpay.TabIndex = 5
        '
        'lblgross
        '
        Me.lblgross.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblgross.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblgross.Location = New System.Drawing.Point(76, 162)
        Me.lblgross.Name = "lblgross"
        Me.lblgross.Size = New System.Drawing.Size(87, 23)
        Me.lblgross.TabIndex = 10
        Me.lblgross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblfwt
        '
        Me.lblfwt.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblfwt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblfwt.Location = New System.Drawing.Point(169, 162)
        Me.lblfwt.Name = "lblfwt"
        Me.lblfwt.Size = New System.Drawing.Size(82, 23)
        Me.lblfwt.TabIndex = 12
        Me.lblfwt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblfica
        '
        Me.lblfica.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblfica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblfica.Location = New System.Drawing.Point(262, 162)
        Me.lblfica.Name = "lblfica"
        Me.lblfica.Size = New System.Drawing.Size(95, 23)
        Me.lblfica.TabIndex = 14
        Me.lblfica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblstate
        '
        Me.lblstate.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblstate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblstate.Location = New System.Drawing.Point(363, 162)
        Me.lblstate.Name = "lblstate"
        Me.lblstate.Size = New System.Drawing.Size(85, 23)
        Me.lblstate.TabIndex = 16
        Me.lblstate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblnet
        '
        Me.lblnet.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblnet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblnet.Location = New System.Drawing.Point(454, 162)
        Me.lblnet.Name = "lblnet"
        Me.lblnet.Size = New System.Drawing.Size(100, 23)
        Me.lblnet.TabIndex = 18
        Me.lblnet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(169, 25)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(38, 13)
        Me.lblname.TabIndex = 2
        Me.lblname.Text = "Name:"
        '
        'lblhours
        '
        Me.lblhours.AutoSize = True
        Me.lblhours.Location = New System.Drawing.Point(390, 25)
        Me.lblhours.Name = "lblhours"
        Me.lblhours.Size = New System.Drawing.Size(38, 13)
        Me.lblhours.TabIndex = 4
        Me.lblhours.Text = "Hours:"
        '
        'lblpay
        '
        Me.lblpay.AutoSize = True
        Me.lblpay.Location = New System.Drawing.Point(489, 25)
        Me.lblpay.Name = "lblpay"
        Me.lblpay.Size = New System.Drawing.Size(49, 13)
        Me.lblpay.TabIndex = 6
        Me.lblpay.Text = "Pay rate:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(73, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Gross:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(166, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "FWT:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(259, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "FICA:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(360, 139)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "State:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(454, 139)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Net:"
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 309)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblpay)
        Me.Controls.Add(Me.lblhours)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblnet)
        Me.Controls.Add(Me.lblstate)
        Me.Controls.Add(Me.lblfica)
        Me.Controls.Add(Me.lblfwt)
        Me.Controls.Add(Me.lblgross)
        Me.Controls.Add(Me.txtpay)
        Me.Controls.Add(Me.txthours)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btncalc)
        Me.Name = "frmmain"
        Me.Text = "Photo Payroll"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncalc As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txthours As TextBox
    Friend WithEvents txtpay As TextBox
    Friend WithEvents lblgross As Label
    Friend WithEvents lblfwt As Label
    Friend WithEvents lblfica As Label
    Friend WithEvents lblstate As Label
    Friend WithEvents lblnet As Label
    Friend WithEvents lblname As Label
    Friend WithEvents lblhours As Label
    Friend WithEvents lblpay As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
