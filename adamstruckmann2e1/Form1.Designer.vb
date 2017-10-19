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
        Me.lblamount = New System.Windows.Forms.Label()
        Me.lblsavannah = New System.Windows.Forms.Label()
        Me.lblshipping1 = New System.Windows.Forms.Label()
        Me.btncalcand = New System.Windows.Forms.Button()
        Me.btnclacor = New System.Windows.Forms.Button()
        Me.btncalcequals = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.lblid = New System.Windows.Forms.Label()
        Me.lblsales = New System.Windows.Forms.Label()
        Me.lblcommission1 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtsales = New System.Windows.Forms.TextBox()
        Me.txtsavannah = New System.Windows.Forms.TextBox()
        Me.txtorder = New System.Windows.Forms.TextBox()
        Me.lblshipping = New System.Windows.Forms.Label()
        Me.btncalc4 = New System.Windows.Forms.Button()
        Me.lblcommission = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblamount
        '
        Me.lblamount.AutoSize = True
        Me.lblamount.Location = New System.Drawing.Point(20, 62)
        Me.lblamount.Name = "lblamount"
        Me.lblamount.Size = New System.Drawing.Size(74, 13)
        Me.lblamount.TabIndex = 0
        Me.lblamount.Text = "Order amount:"
        '
        'lblsavannah
        '
        Me.lblsavannah.AutoSize = True
        Me.lblsavannah.Location = New System.Drawing.Point(135, 64)
        Me.lblsavannah.Name = "lblsavannah"
        Me.lblsavannah.Size = New System.Drawing.Size(88, 13)
        Me.lblsavannah.TabIndex = 1
        Me.lblsavannah.Text = "Savannah (Y/N):"
        '
        'lblshipping1
        '
        Me.lblshipping1.AutoSize = True
        Me.lblshipping1.Location = New System.Drawing.Point(255, 64)
        Me.lblshipping1.Name = "lblshipping1"
        Me.lblshipping1.Size = New System.Drawing.Size(88, 13)
        Me.lblshipping1.TabIndex = 2
        Me.lblshipping1.Text = "Shipping Charge:"
        '
        'btncalcand
        '
        Me.btncalcand.Location = New System.Drawing.Point(399, 52)
        Me.btncalcand.Name = "btncalcand"
        Me.btncalcand.Size = New System.Drawing.Size(95, 23)
        Me.btncalcand.TabIndex = 3
        Me.btncalcand.Text = "Calculate (And)"
        Me.btncalcand.UseVisualStyleBackColor = True
        '
        'btnclacor
        '
        Me.btnclacor.Location = New System.Drawing.Point(399, 91)
        Me.btnclacor.Name = "btnclacor"
        Me.btnclacor.Size = New System.Drawing.Size(95, 23)
        Me.btnclacor.TabIndex = 4
        Me.btnclacor.Text = "Calculate (Or)"
        Me.btnclacor.UseVisualStyleBackColor = True
        '
        'btncalcequals
        '
        Me.btncalcequals.Location = New System.Drawing.Point(399, 142)
        Me.btncalcequals.Name = "btncalcequals"
        Me.btncalcequals.Size = New System.Drawing.Size(95, 23)
        Me.btncalcequals.TabIndex = 5
        Me.btncalcequals.Text = "Calculate (=)"
        Me.btncalcequals.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(245, 244)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 7
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Location = New System.Drawing.Point(20, 158)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(21, 13)
        Me.lblid.TabIndex = 8
        Me.lblid.Text = "ID:"
        '
        'lblsales
        '
        Me.lblsales.AutoSize = True
        Me.lblsales.Location = New System.Drawing.Point(135, 158)
        Me.lblsales.Name = "lblsales"
        Me.lblsales.Size = New System.Drawing.Size(36, 13)
        Me.lblsales.TabIndex = 9
        Me.lblsales.Text = "Sales:"
        '
        'lblcommission1
        '
        Me.lblcommission1.AutoSize = True
        Me.lblcommission1.Location = New System.Drawing.Point(255, 152)
        Me.lblcommission1.Name = "lblcommission1"
        Me.lblcommission1.Size = New System.Drawing.Size(65, 13)
        Me.lblcommission1.TabIndex = 10
        Me.lblcommission1.Text = "Commission:"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(23, 174)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 20)
        Me.txtid.TabIndex = 11
        '
        'txtsales
        '
        Me.txtsales.Location = New System.Drawing.Point(138, 174)
        Me.txtsales.Name = "txtsales"
        Me.txtsales.Size = New System.Drawing.Size(100, 20)
        Me.txtsales.TabIndex = 12
        '
        'txtsavannah
        '
        Me.txtsavannah.Location = New System.Drawing.Point(138, 80)
        Me.txtsavannah.Name = "txtsavannah"
        Me.txtsavannah.Size = New System.Drawing.Size(77, 20)
        Me.txtsavannah.TabIndex = 14
        '
        'txtorder
        '
        Me.txtorder.Location = New System.Drawing.Point(23, 80)
        Me.txtorder.Name = "txtorder"
        Me.txtorder.Size = New System.Drawing.Size(100, 20)
        Me.txtorder.TabIndex = 15
        '
        'lblshipping
        '
        Me.lblshipping.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblshipping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblshipping.Location = New System.Drawing.Point(258, 82)
        Me.lblshipping.Name = "lblshipping"
        Me.lblshipping.Size = New System.Drawing.Size(100, 32)
        Me.lblshipping.TabIndex = 16
        Me.lblshipping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btncalc4
        '
        Me.btncalc4.Location = New System.Drawing.Point(399, 171)
        Me.btncalc4.Name = "btncalc4"
        Me.btncalc4.Size = New System.Drawing.Size(95, 23)
        Me.btncalc4.TabIndex = 17
        Me.btncalc4.Text = "Calculate (<>)"
        Me.btncalc4.UseVisualStyleBackColor = True
        '
        'lblcommission
        '
        Me.lblcommission.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblcommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcommission.Location = New System.Drawing.Point(258, 171)
        Me.lblcommission.Name = "lblcommission"
        Me.lblcommission.Size = New System.Drawing.Size(100, 32)
        Me.lblcommission.TabIndex = 18
        Me.lblcommission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(504, 103)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Free shipping for orders over $100 with Savannah CC"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(10, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(504, 103)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "15% commission for sales > 25000 with codes A1, B2, C3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 291)
        Me.Controls.Add(Me.lblcommission)
        Me.Controls.Add(Me.btncalc4)
        Me.Controls.Add(Me.lblshipping)
        Me.Controls.Add(Me.txtorder)
        Me.Controls.Add(Me.txtsavannah)
        Me.Controls.Add(Me.txtsales)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.lblcommission1)
        Me.Controls.Add(Me.lblsales)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btncalcequals)
        Me.Controls.Add(Me.btnclacor)
        Me.Controls.Add(Me.btncalcand)
        Me.Controls.Add(Me.lblshipping1)
        Me.Controls.Add(Me.lblsavannah)
        Me.Controls.Add(Me.lblamount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "andalso, orelse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblamount As Label
    Friend WithEvents lblsavannah As Label
    Friend WithEvents lblshipping1 As Label
    Friend WithEvents btncalcand As Button
    Friend WithEvents btnclacor As Button
    Friend WithEvents btncalcequals As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents lblid As Label
    Friend WithEvents lblsales As Label
    Friend WithEvents lblcommission1 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtsales As TextBox
    Friend WithEvents txtsavannah As TextBox
    Friend WithEvents txtorder As TextBox
    Friend WithEvents lblshipping As Label
    Friend WithEvents btncalc4 As Button
    Friend WithEvents lblcommission As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
