' Name:         Multiplication Project
' Purpose:      Display a multiplication table that shows
'               the multiplicand, multiplier, and product
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Dim dblTAXRATE As Double = 0.05

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        ' displays a multiplication table
        Dim number, product, count As Integer
        lstmulttable.Items.Clear()
        lstmulttable.Items.Add("Do Loop")
        Integer.TryParse(txtNumber.Text, number)
        'do loop
        count = 0

        Do Until count = 9
            count = count + 1
            product = number * count


            Dim stroutput As String = "    " & number.ToString() & " * " & count.ToString & " = " & product.ToString
            lstmulttable.Items.Add(stroutput)
        Loop
    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' displays a multiplication table
        Dim number, product, count As Integer
        lstmulttable.Items.Clear()
        lstmulttable.Items.Add("For Loop")
        Integer.TryParse(txtNumber.Text, number)
        'for loop
        count = 0
        For intcount As Integer = 1 To 9
            count = count + 1
            product = number * (intcount)
            Dim stroutput As String = "    " & number.ToString() & " * " & count.ToString & " = " & product.ToString
            lstmulttable.Items.Add(stroutput)
        Next


    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        ' allows only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        lstmulttable.Text = String.Empty
    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstprices.Items.Add("1.00")
        lstprices.Items.Add("2.00")
        lstprices.Items.Add("3.00")
        lstprices.Items.Add("4.00")

        Dim dblpretaxtotal As Double = 0.00
        Dim dblselectedprice As Double
        Dim dbltax As Double
        Dim dbltotal As Double

        For index As Integer = 0 To lstprices.Items.Count - 1
            index = lstprices.SelectedIndex
            Dim strSelectedItem As String = lstprices.SelectedItem.ToString
            Double.TryParse(lstprices.SelectedItem.ToString, dblselectedprice)
            dblpretaxtotal = dblpretaxtotal + dblselectedprice

        Next

        lblpretax.Text = dblpretaxtotal.ToString("N2")
        dbltax = dblpretaxtotal * dblTAXRATE
        lbltax.Text = dbltax.ToString("N2")
        dbltotal = dblpretaxtotal + dbltax
        lbltotal.Text = dbltotal.ToString("N2")


    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click



    End Sub
End Class
