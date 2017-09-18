' Adam Struckmann
' 9/18/2017

Option Strict On

Public Class frmmain
    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click
        lblgross.Text = Format(Val(txthours.Text) * Val(txtpay.Text), "fixed")
        lblfwt.Text = Format(Val(lblgross.Text) * 0.2, "fixed")
        lblfica.Text = Format(Val(lblgross.Text) * 0.08, "fixed")
        lblstate.Text = Format(Val(lblgross.Text) * 0.03, "fixed")
        lblnet.Text = Val(lblgross.Text) - Format((Val(lblfwt.Text) + Val(lblfica.Text) + Val(lblstate.Text)), "fixed")
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtname.Text = String.Empty
        txthours.Text = String.Empty
        txtpay.Text = String.Empty
        lblgross.Text = String.Empty
        lblfwt.Text = String.Empty
        lblfica.Text = String.Empty
        lblstate.Text = String.Empty
        lblnet.Text = String.Empty

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class
