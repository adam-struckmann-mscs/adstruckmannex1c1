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
        Me.btndowhile = New System.Windows.Forms.Button()
        Me.btndountil = New System.Windows.Forms.Button()
        Me.btnloopwhile = New System.Windows.Forms.Button()
        Me.btnloopuntil = New System.Windows.Forms.Button()
        Me.btnfor = New System.Windows.Forms.Button()
        Me.btnsumwhile = New System.Windows.Forms.Button()
        Me.btnsumloop = New System.Windows.Forms.Button()
        Me.btnsumnext = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbleven = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblcount = New System.Windows.Forms.Label()
        Me.lblaverage = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtlist = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btndowhile
        '
        Me.btndowhile.Location = New System.Drawing.Point(157, 29)
        Me.btndowhile.Name = "btndowhile"
        Me.btndowhile.Size = New System.Drawing.Size(130, 23)
        Me.btndowhile.TabIndex = 1
        Me.btndowhile.Text = "Pretest: Do While"
        Me.btndowhile.UseVisualStyleBackColor = True
        '
        'btndountil
        '
        Me.btndountil.Location = New System.Drawing.Point(157, 68)
        Me.btndountil.Name = "btndountil"
        Me.btndountil.Size = New System.Drawing.Size(130, 23)
        Me.btndountil.TabIndex = 2
        Me.btndountil.Text = "Pretest: Do Until"
        Me.btndountil.UseVisualStyleBackColor = True
        '
        'btnloopwhile
        '
        Me.btnloopwhile.Location = New System.Drawing.Point(157, 107)
        Me.btnloopwhile.Name = "btnloopwhile"
        Me.btnloopwhile.Size = New System.Drawing.Size(130, 23)
        Me.btnloopwhile.TabIndex = 3
        Me.btnloopwhile.Text = "Posttest: Loop While"
        Me.btnloopwhile.UseVisualStyleBackColor = True
        '
        'btnloopuntil
        '
        Me.btnloopuntil.Location = New System.Drawing.Point(157, 145)
        Me.btnloopuntil.Name = "btnloopuntil"
        Me.btnloopuntil.Size = New System.Drawing.Size(130, 23)
        Me.btnloopuntil.TabIndex = 4
        Me.btnloopuntil.Text = "Posttest: Loop Until"
        Me.btnloopuntil.UseVisualStyleBackColor = True
        '
        'btnfor
        '
        Me.btnfor.Location = New System.Drawing.Point(157, 183)
        Me.btnfor.Name = "btnfor"
        Me.btnfor.Size = New System.Drawing.Size(130, 23)
        Me.btnfor.TabIndex = 5
        Me.btnfor.Text = "Pretest: For"
        Me.btnfor.UseVisualStyleBackColor = True
        '
        'btnsumwhile
        '
        Me.btnsumwhile.Location = New System.Drawing.Point(153, 112)
        Me.btnsumwhile.Name = "btnsumwhile"
        Me.btnsumwhile.Size = New System.Drawing.Size(117, 23)
        Me.btnsumwhile.TabIndex = 6
        Me.btnsumwhile.Text = "Sum, Do While"
        Me.btnsumwhile.UseVisualStyleBackColor = True
        '
        'btnsumloop
        '
        Me.btnsumloop.Location = New System.Drawing.Point(153, 141)
        Me.btnsumloop.Name = "btnsumloop"
        Me.btnsumloop.Size = New System.Drawing.Size(117, 23)
        Me.btnsumloop.TabIndex = 7
        Me.btnsumloop.Text = "Sum, Loop Until"
        Me.btnsumloop.UseVisualStyleBackColor = True
        '
        'btnsumnext
        '
        Me.btnsumnext.Location = New System.Drawing.Point(153, 170)
        Me.btnsumnext.Name = "btnsumnext"
        Me.btnsumnext.Size = New System.Drawing.Size(117, 23)
        Me.btnsumnext.TabIndex = 8
        Me.btnsumnext.Text = "Sum, For Next"
        Me.btnsumnext.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbleven)
        Me.GroupBox1.Controls.Add(Me.btnfor)
        Me.GroupBox1.Controls.Add(Me.btnloopuntil)
        Me.GroupBox1.Controls.Add(Me.btnloopwhile)
        Me.GroupBox1.Controls.Add(Me.btndountil)
        Me.GroupBox1.Controls.Add(Me.btndowhile)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 253)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "#13 loop 2-20"
        '
        'lbleven
        '
        Me.lbleven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbleven.Location = New System.Drawing.Point(15, 32)
        Me.lbleven.Name = "lbleven"
        Me.lbleven.Size = New System.Drawing.Size(127, 208)
        Me.lbleven.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtlist)
        Me.GroupBox2.Controls.Add(Me.lblcount)
        Me.GroupBox2.Controls.Add(Me.lblaverage)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnsumnext)
        Me.GroupBox2.Controls.Add(Me.btnsumloop)
        Me.GroupBox2.Controls.Add(Me.btnsumwhile)
        Me.GroupBox2.Location = New System.Drawing.Point(327, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(276, 271)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "#22 Addition"
        '
        'lblcount
        '
        Me.lblcount.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblcount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblcount.Location = New System.Drawing.Point(213, 54)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(57, 43)
        Me.lblcount.TabIndex = 13
        '
        'lblaverage
        '
        Me.lblaverage.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblaverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblaverage.Location = New System.Drawing.Point(150, 54)
        Me.lblaverage.Name = "lblaverage"
        Me.lblaverage.Size = New System.Drawing.Size(57, 43)
        Me.lblaverage.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(210, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Count:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Average:"
        '
        'txtlist
        '
        Me.txtlist.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtlist.Location = New System.Drawing.Point(18, 28)
        Me.txtlist.Multiline = True
        Me.txtlist.Name = "txtlist"
        Me.txtlist.Size = New System.Drawing.Size(122, 186)
        Me.txtlist.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 322)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Adstruckmann loops, sum, count"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btndowhile As Button
    Friend WithEvents btndountil As Button
    Friend WithEvents btnloopwhile As Button
    Friend WithEvents btnloopuntil As Button
    Friend WithEvents btnfor As Button
    Friend WithEvents btnsumwhile As Button
    Friend WithEvents btnsumloop As Button
    Friend WithEvents btnsumnext As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbleven As Label
    Friend WithEvents lblaverage As Label
    Friend WithEvents lblcount As Label
    Friend WithEvents txtlist As TextBox
End Class
