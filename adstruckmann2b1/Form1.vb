' Name: Cranston Berries Project
' Purpose: Calculates projected sales
'Programmer: Adam Struckmann on 9/27/2017

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmBerries
    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click

        Dim decprojincrease As Decimal
        Dim intstraw As Integer
        Dim intblue As Integer
        Dim intrasp As Integer
        Dim decprojstraw As Decimal
        Dim decprojblue As Decimal
        Dim decprojrasp As Decimal

        Decimal.TryParse(txtprojincrease.Text, decprojincrease)
        Integer.TryParse(txtstraw.Text, intstraw)
        Integer.TryParse(txtblue.Text, intblue)
        Integer.TryParse(txtrasp.Text, intrasp)
        decprojstraw = intstraw * (1 + decprojincrease)
        decprojblue = intblue * (1 + decprojincrease)
        decprojrasp = intrasp * (1 + decprojincrease)


        lblprojstraw.Text = decprojstraw.ToString("C2")
        lblprojblue.Text = decprojblue.ToString("C2")
        lblprojrasp.Text = decprojrasp.ToString("C2")

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

    Private Sub btnretire_Click(sender As Object, e As EventArgs) Handles btnretire.Click
        Retirement_Form.Show()
    End Sub
End Class
