'Adam Struckmann on 10/16/17

Public Class Form1
    Private Sub btncalcand_Click(sender As Object, e As EventArgs) Handles btncalcand.Click

        Dim dblorder As Double
        Dim strsavannah As String = "y"
        Dim shipping As Decimal = 9
        Dim decshipping As Decimal

        Double.TryParse(txtorder.Text, dblorder)


        If dblorder >= "100" And strsavannah = True Then
            shipping = 0
        End If






        decshipping = shipping
        lblshipping.Text = decshipping.ToString("C2")
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()

    End Sub
End Class
