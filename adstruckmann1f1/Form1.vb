' Name: Cranston Berries Project
' Purpose: Calculates projected sales
'Programmer: Adam Struckmann on 9/10/2017


Public Class frmMain
    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click
        lblprojstraw.Text = Format((1 + Val(txtprojincrease.Text)) * Val(txtstraw.Text), "currency")
        lblprojblue.Text = Format((1 + Val(txtprojincrease.Text)) * Val(txtblue.Text), "currency")
        lblprojrasp.Text = Format((1 + Val(txtprojincrease.Text)) * Val(txtrasp.Text), "currency")
    End Sub

    Private Sub btnclear_click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtstraw.Text = String.Empty
        txtblue.Text = String.Empty
        txtrasp.Text = String.Empty
        lblprojstraw.Text = String.Empty
        lblprojblue.Text = String.Empty
        lblprojrasp.Text = String.Empty

    End Sub

    Private Sub btnexit_click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class
