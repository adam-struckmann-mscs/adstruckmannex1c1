
' Adam Struckmann on 10/31/2017

Option Strict On
Option Infer Off
Option Explicit On

Public Class frmcommission

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub txtsales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsales.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
               e.KeyChar <> ControlChars.Back AndAlso
               e.KeyChar <> "." Then
            'cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub btncalcifthen_Click(sender As Object, e As EventArgs) Handles btncalcifthen.Click
        lblcommission.Text = String.Empty
        lbladditional.Text = String.Empty
        lbltotal.Text = String.Empty

        Dim dblsales As Double = 0.0
        Dim dblcommission As Double = 0.0
        Dim dbladditional As Double = 0.0
        Dim dbltotal As Double = 0.0
        Dim boolsalesok As Boolean =
            Double.TryParse(txtsales.Text, dblsales)

        If Not boolsalesok Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        If boolsalesok AndAlso dblsales < 1.0 Then
            dblcommission = 0.0
        End If

        If boolsalesok AndAlso dblsales >= 1.0 AndAlso dblsales < 6000.0 Then
            dblcommission = dblsales * 0.1
        End If

        If boolsalesok AndAlso dblsales >= 6000.0 AndAlso dblsales < 30000.0 Then
            dblcommission = 120.0 + (dblsales - 6000.0) * 0.13
        End If

        If boolsalesok AndAlso dblsales >= 30000.0 Then
            dblcommission = 3120.0 + (dblsales - 30000.0) * 0.14
        End If

        If chk10years.Checked Then
            dbladditional = dbladditional + 500.0
        End If

        If chktraveling.Checked Then
            dbladditional = dbladditional + 700.0
        End If

        dbltotal = dblcommission + dbladditional

        If boolsalesok Then
            lblcommission.Text = dblcommission.ToString("C2")
            lbladditional.Text = dbladditional.ToString("C2")
            lbltotal.Text = dbltotal.ToString("C2")
        End If

        txtsales.Focus()
    End Sub

    Private Sub btncalcnested_Click(sender As Object, e As EventArgs) Handles btncalcnested.Click
        lblcommission.Text = String.Empty
        lbladditional.Text = String.Empty
        lbltotal.Text = String.Empty

        Dim dblsales As Double = 0.0
        Dim dblcommission As Double = 0.0
        Dim dbladditional As Double = 0.0
        Dim dbltotal As Double = 0.0
        Dim boolsalesok As Boolean =
            Double.TryParse(txtsales.Text, dblsales)

        If Not boolsalesok Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        If boolsalesok AndAlso dblsales < 1.0 Then
            dblcommission = 0.0
        Else
            If dblsales < 6000.0 Then
                dblcommission = dblsales * 0.1
            Else
                If dblsales < 30000.0 Then
                    dblcommission = 120.0 + (dblsales - 6000.0) * 0.13
                Else
                    If dblsales >= 30000.0 Then
                        dblcommission = 3120.0 + (dblsales - 30000.0) * 0.14
                    End If
                End If
            End If
        End If

        If chk10years.Checked Then
            dbladditional = dbladditional + 500.0
        End If

        If chktraveling.Checked Then
            dbladditional = dbladditional + 700.0
        End If

        dbltotal = dblcommission + dbladditional

        lblcommission.Text = dblcommission.ToString("C2")
        lbladditional.Text = dbladditional.ToString("C2")
        lbltotal.Text = dbltotal.ToString("C2")

        txtsales.Focus()
    End Sub

    Private Sub btnifelse_Click(sender As Object, e As EventArgs) Handles btnifelse.Click
        lblcommission.Text = String.Empty
        lbladditional.Text = String.Empty
        lbltotal.Text = String.Empty

        Dim dblsales As Double = 0.0
        Dim dblcommission As Double = 0.0
        Dim dbladditional As Double = 0.0
        Dim dbltotal As Double = 0.0
        Dim boolsalesok As Boolean =
            Double.TryParse(txtsales.Text, dblsales)

        If Not boolsalesok Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        If boolsalesok AndAlso dblsales < 1.0 Then
            dblcommission = 0.0
        ElseIf dblsales < 6000.0 Then
            dblcommission = dblsales * 0.1
        ElseIf dblsales < 30000.0 Then
            dblcommission = 120.0 + (dblsales - 6000.0) * 0.13
        ElseIf dblsales >= 30000.0 Then
            dblcommission = 3120.0 + (dblsales - 30000.0) * 0.14
        End If

        If chk10years.Checked Then
            dbladditional = dbladditional + 500.0
        End If

        If chktraveling.Checked Then
            dbladditional = dbladditional + 700.0
        End If

        dbltotal = dblcommission + dbladditional

        lblcommission.Text = dblcommission.ToString("C2")
        lbladditional.Text = dbladditional.ToString("C2")
        lbltotal.Text = dbltotal.ToString("C2")

        txtsales.Focus()
    End Sub

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        lblcommission.Text = String.Empty
        lbladditional.Text = String.Empty
        lbltotal.Text = String.Empty

        Dim dblsales As Double = 0.0
        Dim dblcommission As Double = 0.0
        Dim dbladditional As Double = 0.0
        Dim dbltotal As Double = 0.0
        Dim boolsalesok As Boolean =
            Double.TryParse(txtsales.Text, dblsales)

        If Not boolsalesok Then
            MessageBox.Show("Invalid input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Select Case dblsales
            Case 0.0 To 0.99
                dblcommission = 0.0
            Case 1.0 To 5999.99
                dblcommission = dblsales * 0.1
            Case 6000.0 To 29999.99
                dblcommission = 120.0 + (dblsales - 6000.0) * 0.13
            Case > 30000.0
                dblcommission = 3120.0 + (dblsales - 30000.0) * 0.14
        End Select

        If chk10years.Checked Then
            dbladditional = dbladditional + 500.0
        End If

        If chktraveling.Checked Then
            dbladditional = dbladditional + 700.0
        End If

        dbltotal = dblcommission + dbladditional

        lblcommission.Text = dblcommission.ToString("C2")
        lbladditional.Text = dbladditional.ToString("C2")
        lbltotal.Text = dbltotal.ToString("C2")

        txtsales.Focus()
    End Sub

    Private Sub ClearCommission(sender As Object, e As EventArgs) Handles txtsales.TextChanged, chk10years.CheckedChanged, chktraveling.CheckedChanged
        lblcommission.Text = String.Empty
        lbladditional.Text = String.Empty
        lbltotal.Text = String.Empty

    End Sub
End Class
