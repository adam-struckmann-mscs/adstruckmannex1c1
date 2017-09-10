<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.txtprojincrease = New System.Windows.Forms.TextBox()
        Me.txtstraw = New System.Windows.Forms.TextBox()
        Me.txtblue = New System.Windows.Forms.TextBox()
        Me.txtrasp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblsales = New System.Windows.Forms.Label()
        Me.lblprojsales = New System.Windows.Forms.Label()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.btnprint = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblprojincrease = New System.Windows.Forms.Label()
        Me.lbldecimalfrm = New System.Windows.Forms.Label()
        Me.lblprojstraw = New System.Windows.Forms.Label()
        Me.lblprojblue = New System.Windows.Forms.Label()
        Me.lblprojrasp = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtprojincrease
        '
        Me.txtprojincrease.Location = New System.Drawing.Point(280, 26)
        Me.txtprojincrease.Name = "txtprojincrease"
        Me.txtprojincrease.Size = New System.Drawing.Size(84, 20)
        Me.txtprojincrease.TabIndex = 0
        Me.txtprojincrease.Text = "0.05"
        Me.txtprojincrease.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtstraw
        '
        Me.txtstraw.Location = New System.Drawing.Point(171, 132)
        Me.txtstraw.Name = "txtstraw"
        Me.txtstraw.Size = New System.Drawing.Size(102, 20)
        Me.txtstraw.TabIndex = 2
        '
        'txtblue
        '
        Me.txtblue.Location = New System.Drawing.Point(171, 168)
        Me.txtblue.Name = "txtblue"
        Me.txtblue.Size = New System.Drawing.Size(102, 20)
        Me.txtblue.TabIndex = 4
        '
        'txtrasp
        '
        Me.txtrasp.Location = New System.Drawing.Point(171, 204)
        Me.txtrasp.Name = "txtrasp"
        Me.txtrasp.Size = New System.Drawing.Size(102, 20)
        Me.txtrasp.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Strawberries"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(94, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Blueberries"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(94, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Raspberries"
        '
        'lblsales
        '
        Me.lblsales.AutoSize = True
        Me.lblsales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsales.Location = New System.Drawing.Point(171, 92)
        Me.lblsales.Name = "lblsales"
        Me.lblsales.Size = New System.Drawing.Size(94, 17)
        Me.lblsales.TabIndex = 12
        Me.lblsales.Text = "Current Sales"
        '
        'lblprojsales
        '
        Me.lblprojsales.AutoSize = True
        Me.lblprojsales.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprojsales.Location = New System.Drawing.Point(285, 92)
        Me.lblprojsales.Name = "lblprojsales"
        Me.lblprojsales.Size = New System.Drawing.Size(107, 17)
        Me.lblprojsales.TabIndex = 13
        Me.lblprojsales.Text = "Projected Sales"
        '
        'btncalc
        '
        Me.btncalc.Location = New System.Drawing.Point(51, 272)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(75, 23)
        Me.btncalc.TabIndex = 7
        Me.btncalc.Text = "Calculate"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(134, 272)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(75, 23)
        Me.btnprint.TabIndex = 14
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(215, 272)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 8
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(303, 272)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 9
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.adstruckmann1f1.My.Resources.Resources.berries
        Me.PictureBox1.Location = New System.Drawing.Point(15, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'lblprojincrease
        '
        Me.lblprojincrease.AutoSize = True
        Me.lblprojincrease.Location = New System.Drawing.Point(156, 29)
        Me.lblprojincrease.Name = "lblprojincrease"
        Me.lblprojincrease.Size = New System.Drawing.Size(109, 13)
        Me.lblprojincrease.TabIndex = 10
        Me.lblprojincrease.Text = "Projected increase %:"
        '
        'lbldecimalfrm
        '
        Me.lbldecimalfrm.AutoSize = True
        Me.lbldecimalfrm.Location = New System.Drawing.Point(168, 42)
        Me.lbldecimalfrm.Name = "lbldecimalfrm"
        Me.lbldecimalfrm.Size = New System.Drawing.Size(83, 13)
        Me.lbldecimalfrm.TabIndex = 11
        Me.lbldecimalfrm.Text = "(in decimal form)"
        '
        'lblprojstraw
        '
        Me.lblprojstraw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblprojstraw.Location = New System.Drawing.Point(303, 132)
        Me.lblprojstraw.Name = "lblprojstraw"
        Me.lblprojstraw.Size = New System.Drawing.Size(75, 20)
        Me.lblprojstraw.TabIndex = 20
        Me.lblprojstraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblprojblue
        '
        Me.lblprojblue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblprojblue.Location = New System.Drawing.Point(303, 168)
        Me.lblprojblue.Name = "lblprojblue"
        Me.lblprojblue.Size = New System.Drawing.Size(75, 20)
        Me.lblprojblue.TabIndex = 21
        Me.lblprojblue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblprojrasp
        '
        Me.lblprojrasp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblprojrasp.Location = New System.Drawing.Point(303, 204)
        Me.lblprojrasp.Name = "lblprojrasp"
        Me.lblprojrasp.Size = New System.Drawing.Size(75, 20)
        Me.lblprojrasp.TabIndex = 22
        Me.lblprojrasp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 316)
        Me.Controls.Add(Me.lblprojrasp)
        Me.Controls.Add(Me.lblprojblue)
        Me.Controls.Add(Me.lblprojstraw)
        Me.Controls.Add(Me.lbldecimalfrm)
        Me.Controls.Add(Me.lblprojincrease)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btncalc)
        Me.Controls.Add(Me.lblprojsales)
        Me.Controls.Add(Me.lblsales)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtrasp)
        Me.Controls.Add(Me.txtblue)
        Me.Controls.Add(Me.txtstraw)
        Me.Controls.Add(Me.txtprojincrease)
        Me.Name = "frmMain"
        Me.Text = "Cranston Berries"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtprojincrease As TextBox
    Friend WithEvents txtstraw As TextBox
    Friend WithEvents txtblue As TextBox
    Friend WithEvents txtrasp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblsales As Label
    Friend WithEvents lblprojsales As Label
    Friend WithEvents btncalc As Button
    Friend WithEvents btnprint As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblprojincrease As Label
    Friend WithEvents lbldecimalfrm As Label
    Friend WithEvents lblprojstraw As Label
    Friend WithEvents lblprojblue As Label
    Friend WithEvents lblprojrasp As Label
End Class
