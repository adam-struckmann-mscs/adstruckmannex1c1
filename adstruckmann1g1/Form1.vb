' Name:         average project
' Purpose:      displays the average of 3 test scores
' Programmer:   Adam Struckmann on 9/13/2017


Public Class frmmain
    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click
        lblavgscore1.Text = Format(((Val(txttest1.Text) + Val(txttest2.Text) + Val(txttest3.Text)) * 1 / 3), "0.00")

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txttest1.Text = String.Empty
        txttest2.Text = String.Empty
        txttest3.Text = String.Empty
        lblavgscore1.Text = String.Empty

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class
