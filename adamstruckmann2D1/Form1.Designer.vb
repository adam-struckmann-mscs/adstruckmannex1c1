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
        Me.btnconvert1 = New System.Windows.Forms.Button()
        Me.btnconvert2 = New System.Windows.Forms.Button()
        Me.txtdollar = New System.Windows.Forms.TextBox()
        Me.lbldollar = New System.Windows.Forms.Label()
        Me.lbleuro2 = New System.Windows.Forms.Label()
        Me.lbleuro1 = New System.Windows.Forms.Label()
        Me.lblpound1 = New System.Windows.Forms.Label()
        Me.lblrand1 = New System.Windows.Forms.Label()
        Me.lblpound2 = New System.Windows.Forms.Label()
        Me.lblrand2 = New System.Windows.Forms.Label()
        Me.lblteapounds = New System.Windows.Forms.Label()
        Me.lblteaprice = New System.Windows.Forms.Label()
        Me.lblteatotal1 = New System.Windows.Forms.Label()
        Me.btnteacalc = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtteapounds = New System.Windows.Forms.TextBox()
        Me.txtteaprice = New System.Windows.Forms.TextBox()
        Me.lblteatotal2 = New System.Windows.Forms.Label()
        Me.lblmonthlybill2 = New System.Windows.Forms.Label()
        Me.txtcurrent = New System.Windows.Forms.TextBox()
        Me.txtprevious = New System.Windows.Forms.TextBox()
        Me.btncalc3 = New System.Windows.Forms.Button()
        Me.lblmonthlybill1 = New System.Windows.Forms.Label()
        Me.lblcurrent = New System.Windows.Forms.Label()
        Me.lblprevious = New System.Windows.Forms.Label()
        Me.lblquot = New System.Windows.Forms.Label()
        Me.txtsecond = New System.Windows.Forms.TextBox()
        Me.txtfirst = New System.Windows.Forms.TextBox()
        Me.btncalcquot = New System.Windows.Forms.Button()
        Me.lblquot1 = New System.Windows.Forms.Label()
        Me.lblsecond = New System.Windows.Forms.Label()
        Me.lblfirst = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnconvert1
        '
        Me.btnconvert1.Location = New System.Drawing.Point(143, 40)
        Me.btnconvert1.Name = "btnconvert1"
        Me.btnconvert1.Size = New System.Drawing.Size(75, 23)
        Me.btnconvert1.TabIndex = 0
        Me.btnconvert1.Text = "Convert ="
        Me.btnconvert1.UseVisualStyleBackColor = True
        '
        'btnconvert2
        '
        Me.btnconvert2.Location = New System.Drawing.Point(143, 71)
        Me.btnconvert2.Name = "btnconvert2"
        Me.btnconvert2.Size = New System.Drawing.Size(75, 23)
        Me.btnconvert2.TabIndex = 1
        Me.btnconvert2.Text = "Convert <>"
        Me.btnconvert2.UseVisualStyleBackColor = True
        '
        'txtdollar
        '
        Me.txtdollar.Location = New System.Drawing.Point(22, 54)
        Me.txtdollar.Name = "txtdollar"
        Me.txtdollar.Size = New System.Drawing.Size(100, 20)
        Me.txtdollar.TabIndex = 2
        '
        'lbldollar
        '
        Me.lbldollar.AutoSize = True
        Me.lbldollar.Location = New System.Drawing.Point(29, 29)
        Me.lbldollar.Name = "lbldollar"
        Me.lbldollar.Size = New System.Drawing.Size(84, 13)
        Me.lbldollar.TabIndex = 3
        Me.lbldollar.Text = "American Dollar:"
        '
        'lbleuro2
        '
        Me.lbleuro2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbleuro2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbleuro2.Location = New System.Drawing.Point(247, 54)
        Me.lbleuro2.Name = "lbleuro2"
        Me.lbleuro2.Size = New System.Drawing.Size(100, 23)
        Me.lbleuro2.TabIndex = 4
        Me.lbleuro2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbleuro1
        '
        Me.lbleuro1.AutoSize = True
        Me.lbleuro1.Location = New System.Drawing.Point(283, 29)
        Me.lbleuro1.Name = "lbleuro1"
        Me.lbleuro1.Size = New System.Drawing.Size(32, 13)
        Me.lbleuro1.TabIndex = 5
        Me.lbleuro1.Text = "Euro:"
        '
        'lblpound1
        '
        Me.lblpound1.AutoSize = True
        Me.lblpound1.Location = New System.Drawing.Point(368, 29)
        Me.lblpound1.Name = "lblpound1"
        Me.lblpound1.Size = New System.Drawing.Size(72, 13)
        Me.lblpound1.TabIndex = 6
        Me.lblpound1.Text = "British Pound:"
        '
        'lblrand1
        '
        Me.lblrand1.AutoSize = True
        Me.lblrand1.Location = New System.Drawing.Point(459, 29)
        Me.lblrand1.Name = "lblrand1"
        Me.lblrand1.Size = New System.Drawing.Size(103, 13)
        Me.lblrand1.TabIndex = 7
        Me.lblrand1.Text = "South African Rand:"
        '
        'lblpound2
        '
        Me.lblpound2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblpound2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblpound2.Location = New System.Drawing.Point(353, 54)
        Me.lblpound2.Name = "lblpound2"
        Me.lblpound2.Size = New System.Drawing.Size(100, 23)
        Me.lblpound2.TabIndex = 8
        Me.lblpound2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblrand2
        '
        Me.lblrand2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblrand2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblrand2.Location = New System.Drawing.Point(459, 54)
        Me.lblrand2.Name = "lblrand2"
        Me.lblrand2.Size = New System.Drawing.Size(100, 23)
        Me.lblrand2.TabIndex = 9
        Me.lblrand2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblteapounds
        '
        Me.lblteapounds.AutoSize = True
        Me.lblteapounds.Location = New System.Drawing.Point(34, 185)
        Me.lblteapounds.Name = "lblteapounds"
        Me.lblteapounds.Size = New System.Drawing.Size(46, 13)
        Me.lblteapounds.TabIndex = 10
        Me.lblteapounds.Text = "Pounds:"
        '
        'lblteaprice
        '
        Me.lblteaprice.AutoSize = True
        Me.lblteaprice.Location = New System.Drawing.Point(140, 185)
        Me.lblteaprice.Name = "lblteaprice"
        Me.lblteaprice.Size = New System.Drawing.Size(47, 13)
        Me.lblteaprice.TabIndex = 11
        Me.lblteaprice.Text = "Price/lb:"
        '
        'lblteatotal1
        '
        Me.lblteatotal1.AutoSize = True
        Me.lblteatotal1.Location = New System.Drawing.Point(337, 182)
        Me.lblteatotal1.Name = "lblteatotal1"
        Me.lblteatotal1.Size = New System.Drawing.Size(57, 13)
        Me.lblteatotal1.TabIndex = 12
        Me.lblteatotal1.Text = "Total Due:"
        '
        'btnteacalc
        '
        Me.btnteacalc.Location = New System.Drawing.Point(244, 198)
        Me.btnteacalc.Name = "btnteacalc"
        Me.btnteacalc.Size = New System.Drawing.Size(90, 23)
        Me.btnteacalc.TabIndex = 13
        Me.btnteacalc.Text = "Calculate"
        Me.btnteacalc.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(337, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 14
        '
        'txtteapounds
        '
        Me.txtteapounds.Location = New System.Drawing.Point(37, 201)
        Me.txtteapounds.Name = "txtteapounds"
        Me.txtteapounds.Size = New System.Drawing.Size(100, 20)
        Me.txtteapounds.TabIndex = 15
        '
        'txtteaprice
        '
        Me.txtteaprice.Location = New System.Drawing.Point(143, 201)
        Me.txtteaprice.Name = "txtteaprice"
        Me.txtteaprice.Size = New System.Drawing.Size(95, 20)
        Me.txtteaprice.TabIndex = 16
        '
        'lblteatotal2
        '
        Me.lblteatotal2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblteatotal2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblteatotal2.Location = New System.Drawing.Point(340, 198)
        Me.lblteatotal2.Name = "lblteatotal2"
        Me.lblteatotal2.Size = New System.Drawing.Size(100, 23)
        Me.lblteatotal2.TabIndex = 17
        Me.lblteatotal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblmonthlybill2
        '
        Me.lblmonthlybill2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblmonthlybill2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblmonthlybill2.Location = New System.Drawing.Point(340, 300)
        Me.lblmonthlybill2.Name = "lblmonthlybill2"
        Me.lblmonthlybill2.Size = New System.Drawing.Size(100, 23)
        Me.lblmonthlybill2.TabIndex = 24
        Me.lblmonthlybill2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtcurrent
        '
        Me.txtcurrent.Location = New System.Drawing.Point(143, 303)
        Me.txtcurrent.Name = "txtcurrent"
        Me.txtcurrent.Size = New System.Drawing.Size(95, 20)
        Me.txtcurrent.TabIndex = 23
        '
        'txtprevious
        '
        Me.txtprevious.Location = New System.Drawing.Point(37, 303)
        Me.txtprevious.Name = "txtprevious"
        Me.txtprevious.Size = New System.Drawing.Size(100, 20)
        Me.txtprevious.TabIndex = 22
        '
        'btncalc3
        '
        Me.btncalc3.Location = New System.Drawing.Point(244, 300)
        Me.btncalc3.Name = "btncalc3"
        Me.btncalc3.Size = New System.Drawing.Size(90, 23)
        Me.btncalc3.TabIndex = 21
        Me.btncalc3.Text = "Calculate"
        Me.btncalc3.UseVisualStyleBackColor = True
        '
        'lblmonthlybill1
        '
        Me.lblmonthlybill1.AutoSize = True
        Me.lblmonthlybill1.Location = New System.Drawing.Point(337, 284)
        Me.lblmonthlybill1.Name = "lblmonthlybill1"
        Me.lblmonthlybill1.Size = New System.Drawing.Size(63, 13)
        Me.lblmonthlybill1.TabIndex = 20
        Me.lblmonthlybill1.Text = "Monthly Bill:"
        '
        'lblcurrent
        '
        Me.lblcurrent.AutoSize = True
        Me.lblcurrent.Location = New System.Drawing.Point(140, 287)
        Me.lblcurrent.Name = "lblcurrent"
        Me.lblcurrent.Size = New System.Drawing.Size(44, 13)
        Me.lblcurrent.TabIndex = 19
        Me.lblcurrent.Text = "Current:"
        '
        'lblprevious
        '
        Me.lblprevious.AutoSize = True
        Me.lblprevious.Location = New System.Drawing.Point(34, 287)
        Me.lblprevious.Name = "lblprevious"
        Me.lblprevious.Size = New System.Drawing.Size(51, 13)
        Me.lblprevious.TabIndex = 18
        Me.lblprevious.Text = "Previous:"
        '
        'lblquot
        '
        Me.lblquot.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblquot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblquot.Location = New System.Drawing.Point(340, 412)
        Me.lblquot.Name = "lblquot"
        Me.lblquot.Size = New System.Drawing.Size(100, 23)
        Me.lblquot.TabIndex = 31
        Me.lblquot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtsecond
        '
        Me.txtsecond.Location = New System.Drawing.Point(143, 415)
        Me.txtsecond.Name = "txtsecond"
        Me.txtsecond.Size = New System.Drawing.Size(95, 20)
        Me.txtsecond.TabIndex = 30
        '
        'txtfirst
        '
        Me.txtfirst.Location = New System.Drawing.Point(37, 415)
        Me.txtfirst.Name = "txtfirst"
        Me.txtfirst.Size = New System.Drawing.Size(100, 20)
        Me.txtfirst.TabIndex = 29
        '
        'btncalcquot
        '
        Me.btncalcquot.Location = New System.Drawing.Point(244, 412)
        Me.btncalcquot.Name = "btncalcquot"
        Me.btncalcquot.Size = New System.Drawing.Size(90, 23)
        Me.btncalcquot.TabIndex = 28
        Me.btncalcquot.Text = "Calculate"
        Me.btncalcquot.UseVisualStyleBackColor = True
        '
        'lblquot1
        '
        Me.lblquot1.AutoSize = True
        Me.lblquot1.Location = New System.Drawing.Point(337, 396)
        Me.lblquot1.Name = "lblquot1"
        Me.lblquot1.Size = New System.Drawing.Size(50, 13)
        Me.lblquot1.TabIndex = 27
        Me.lblquot1.Text = "Quotient:"
        '
        'lblsecond
        '
        Me.lblsecond.AutoSize = True
        Me.lblsecond.Location = New System.Drawing.Point(140, 399)
        Me.lblsecond.Name = "lblsecond"
        Me.lblsecond.Size = New System.Drawing.Size(54, 13)
        Me.lblsecond.TabIndex = 26
        Me.lblsecond.Text = "Second#:"
        '
        'lblfirst
        '
        Me.lblfirst.AutoSize = True
        Me.lblfirst.Location = New System.Drawing.Point(34, 399)
        Me.lblfirst.Name = "lblfirst"
        Me.lblfirst.Size = New System.Drawing.Size(36, 13)
        Me.lblfirst.TabIndex = 25
        Me.lblfirst.Text = "First#:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 475)
        Me.Controls.Add(Me.lblquot)
        Me.Controls.Add(Me.txtsecond)
        Me.Controls.Add(Me.txtfirst)
        Me.Controls.Add(Me.btncalcquot)
        Me.Controls.Add(Me.lblquot1)
        Me.Controls.Add(Me.lblsecond)
        Me.Controls.Add(Me.lblfirst)
        Me.Controls.Add(Me.lblmonthlybill2)
        Me.Controls.Add(Me.txtcurrent)
        Me.Controls.Add(Me.txtprevious)
        Me.Controls.Add(Me.btncalc3)
        Me.Controls.Add(Me.lblmonthlybill1)
        Me.Controls.Add(Me.lblcurrent)
        Me.Controls.Add(Me.lblprevious)
        Me.Controls.Add(Me.lblteatotal2)
        Me.Controls.Add(Me.txtteaprice)
        Me.Controls.Add(Me.txtteapounds)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnteacalc)
        Me.Controls.Add(Me.lblteatotal1)
        Me.Controls.Add(Me.lblteaprice)
        Me.Controls.Add(Me.lblteapounds)
        Me.Controls.Add(Me.lblrand2)
        Me.Controls.Add(Me.lblpound2)
        Me.Controls.Add(Me.lblrand1)
        Me.Controls.Add(Me.lblpound1)
        Me.Controls.Add(Me.lbleuro1)
        Me.Controls.Add(Me.lbleuro2)
        Me.Controls.Add(Me.lbldollar)
        Me.Controls.Add(Me.txtdollar)
        Me.Controls.Add(Me.btnconvert2)
        Me.Controls.Add(Me.btnconvert1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnconvert1 As Button
    Friend WithEvents btnconvert2 As Button
    Friend WithEvents txtdollar As TextBox
    Friend WithEvents lbldollar As Label
    Friend WithEvents lbleuro2 As Label
    Friend WithEvents lbleuro1 As Label
    Friend WithEvents lblpound1 As Label
    Friend WithEvents lblrand1 As Label
    Friend WithEvents lblpound2 As Label
    Friend WithEvents lblrand2 As Label
    Friend WithEvents lblteapounds As Label
    Friend WithEvents lblteaprice As Label
    Friend WithEvents lblteatotal1 As Label
    Friend WithEvents btnteacalc As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtteapounds As TextBox
    Friend WithEvents txtteaprice As TextBox
    Friend WithEvents lblteatotal2 As Label
    Friend WithEvents lblmonthlybill2 As Label
    Friend WithEvents txtcurrent As TextBox
    Friend WithEvents txtprevious As TextBox
    Friend WithEvents btncalc3 As Button
    Friend WithEvents lblmonthlybill1 As Label
    Friend WithEvents lblcurrent As Label
    Friend WithEvents lblprevious As Label
    Friend WithEvents lblquot As Label
    Friend WithEvents txtsecond As TextBox
    Friend WithEvents txtfirst As TextBox
    Friend WithEvents btncalcquot As Button
    Friend WithEvents lblquot1 As Label
    Friend WithEvents lblsecond As Label
    Friend WithEvents lblfirst As Label
End Class
