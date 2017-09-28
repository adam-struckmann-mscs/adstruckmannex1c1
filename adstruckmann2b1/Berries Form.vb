<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBerries
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btncalc = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.lblgross = New System.Windows.Forms.Label()
        Me.lblemployeecont = New System.Windows.Forms.Label()
        Me.lblemployercont = New System.Windows.Forms.Label()
        Me.lblemployeeannual = New System.Windows.Forms.Label()
        Me.lblemployerannual = New System.Windows.Forms.Label()
        Me.lbltotalcont = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtgross = New System.Windows.Forms.TextBox()
        Me.txtemployeecont = New System.Windows.Forms.TextBox()
        Me.txtemployercont = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btncalc
        '
        Me.btncalc.Location = New System.Drawing.Point(295, 323)
        Me.btncalc.Name = "btncalc"
        Me.btncalc.Size = New System.Drawing.Size(145, 78)
        Me.btncalc.TabIndex = 0
        Me.btncalc.Text = "Calculate"
        Me.btncalc.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(468, 326)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(136, 75)
        Me.btnexit.TabIndex = 1
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'lblgross
        '
        Me.lblgross.AutoSize = True
        Me.lblgross.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgross.Location = New System.Drawing.Point(57, 20)
        Me.lblgross.Name = "lblgross"
        Me.lblgross.Size = New System.Drawing.Size(134, 21)
        Me.lblgross.TabIndex = 2
        Me.lblgross.Text = "Gross weekly pay:"
        '
        'lblemployeecont
        '
        Me.lblemployeecont.AutoSize = True
        Me.lblemployeecont.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemployeecont.Location = New System.Drawing.Point(57, 66)
        Me.lblemployeecont.Name = "lblemployeecont"
        Me.lblemployeecont.Size = New System.Drawing.Size(307, 21)
        Me.lblemployeecont.TabIndex = 3
        Me.lblemployeecont.Text = "Employee contribution rate (decimal form):"
        '
        'lblemployercont
        '
        Me.lblemployercont.AutoSize = True
        Me.lblemployercont.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemployercont.Location = New System.Drawing.Point(57, 103)
        Me.lblemployercont.Name = "lblemployercont"
        Me.lblemployercont.Size = New System.Drawing.Size(305, 21)
        Me.lblemployercont.TabIndex = 4
        Me.lblemployercont.Text = "Employer contribution rate (decimal form):"
        '
        'lblemployeeannual
        '
        Me.lblemployeeannual.AutoSize = True
        Me.lblemployeeannual.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemployeeannual.Location = New System.Drawing.Point(57, 170)
        Me.lblemployeeannual.Name = "lblemployeeannual"
        Me.lblemployeeannual.Size = New System.Drawing.Size(218, 21)
        Me.lblemployeeannual.TabIndex = 5
        Me.lblemployeeannual.Text = "Employee annual contribution"
        '
        'lblemployerannual
        '
        Me.lblemployerannual.AutoSize = True
        Me.lblemployerannual.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemployerannual.Location = New System.Drawing.Point(57, 220)
        Me.lblemployerannual.Name = "lblemployerannual"
        Me.lblemployerannual.Size = New System.Drawing.Size(216, 21)
        Me.lblemployerannual.TabIndex = 6
        Me.lblemployerannual.Text = "Employer annual contribution"
        '
        'lbltotalcont
        '
        Me.lbltotalcont.AutoSize = True
        Me.lbltotalcont.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalcont.Location = New System.Drawing.Point(57, 263)
        Me.lbltotalcont.Name = "lbltotalcont"
        Me.lbltotalcont.Size = New System.Drawing.Size(185, 21)
        Me.lbltotalcont.TabIndex = 7
        Me.lbltotalcont.Text = "Total annual contribution:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(423, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 33)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = " "
        '
        'txtgross
        '
        Me.txtgross.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgross.Location = New System.Drawing.Point(423, 12)
        Me.txtgross.Name = "txtgross"
        Me.txtgross.Size = New System.Drawing.Size(156, 29)
        Me.txtgross.TabIndex = 11
        '
        'txtemployeecont
        '
        Me.txtemployeecont.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemployeecont.Location = New System.Drawing.Point(479, 58)
        Me.txtemployeecont.Name = "txtemployeecont"
        Me.txtemployeecont.Size = New System.Drawing.Size(100, 29)
        Me.txtemployeecont.TabIndex = 12
        '
        'txtemployercont
        '
        Me.txtemployercont.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemployercont.Location = New System.Drawing.Point(479, 103)
        Me.txtemployercont.Name = "txtemployercont"
        Me.txtemployercont.Size = New System.Drawing.Size(100, 29)
        Me.txtemployercont.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(423, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 33)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = " "
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(423, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 33)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = " "
        '
        'frmRetirement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 426)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtemployercont)
        Me.Controls.Add(Me.txtemployeecont)
        Me.Controls.Add(Me.txtgross)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbltotalcont)
        Me.Controls.Add(Me.lblemployerannual)
        Me.Controls.Add(Me.lblemployeeannual)
        Me.Controls.Add(Me.lblemployercont)
        Me.Controls.Add(Me.lblemployeecont)
        Me.Controls.Add(Me.lblgross)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btncalc)
        Me.Name = "frmRetirement"
        Me.Text = "Retirement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncalc As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents lblgross As Label
    Friend WithEvents lblemployeecont As Label
    Friend WithEvents lblemployercont As Label
    Friend WithEvents lblemployeeannual As Label
    Friend WithEvents lblemployerannual As Label
    Friend WithEvents lbltotalcont As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtgross As TextBox
    Friend WithEvents txtemployeecont As TextBox
    Friend WithEvents txtemployercont As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
End Class
