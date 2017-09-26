' Name:         Bakery Project
' Purpose:      Calculates the total number of
'               items sold and the total sales
' Programmer:   Adam Struckmann on 9/26/2017

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain

    'class-level variable for storing salesclerk's name
    Private strclerk As String

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate number of items sold and total sales
        Const decITEM_PRICE As Decimal = 0.5D
        Const decTax_RATE As Decimal = 0.02D
        Dim intDonuts As Integer
        Dim intMuffins As Integer
        Dim intTotalItems As Integer
        Dim decSubtotal As Decimal
        Dim decSalestax As Decimal
        Dim decTotalsales As Decimal

        Integer.TryParse(txtDonuts.Text, intDonuts)
        Integer.TryParse(txtMuffins.Text, intMuffins)
        intTotalItems = intDonuts + intMuffins

        'calculate subtotal
        decSubtotal = intTotalItems * decITEM_PRICE

        'calculate the sales tax
        decSalestax = decSubtotal * decTax_RATE

        'calculate the total sales
        decTotalsales = decSubtotal + decSalestax

        'display total amounts
        lblTotalItems.Text = Convert.ToString(intTotalItems)
        lblTotalSales.Text = decTotalsales.ToString("C2")

        'display tax and salesclerk's name
        lblMsg.Text = "The sales tax was " &
            decSalestax.ToString("C2") & "." &
            ControlChars.NewLine & strclerk

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare screen for the next sale

        txtDonuts.Text = String.Empty
        txtMuffins.Text = String.Empty
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        lblMsg.Text = String.Empty
        ' send the focus to the Doughnuts box
        txtDonuts.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'print btn deleted

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' get the salesclerk's name

        Const strprompt As String = "Salesclerk's Name:"
        Const strtitle As String = "Name Entry"
        ' assign name to class-level variable
        strclerk = InputBox(strprompt, strtitle)
    End Sub
End Class
