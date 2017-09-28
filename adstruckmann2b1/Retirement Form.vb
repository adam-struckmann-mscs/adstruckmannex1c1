' Adam Struckmann on 9/27/2017

Option Strict On
Option Explicit On
Option Infer Off

Public Class Retirement_Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncalc.Click

        Const decemp1 As Decimal = 0.05
        Const decemp2 As Decimal = 0.07
        Dim intgross As Integer
        Dim decannual1 As Decimal
        Dim decannual2 As Decimal
        Dim decannualcont As Decimal

        Integer.TryParse(txtgross.Text, intgross)
        Decimal.TryParse(txtemp1.Text, decemp1)
        Decimal.TryParse(txtemp2.Text, decemp2)

        decannual1 = (intgross * decemp1) * 52
        decannual2 = (intgross * decemp2) * 52
        decannualcont = decannual1 + decannual2


        lblannual1.Text = decannual1.ToString("C2")
        lblannual2.Text = decannual2.ToString("C2")
        lblannualcont.Text = decannualcont.ToString("C2")
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class