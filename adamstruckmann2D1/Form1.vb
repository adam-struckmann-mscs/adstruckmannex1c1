﻿' Adam Struckmann on 10/11/2017


Option Explicit On
Option Infer Off


Public Class Form1
    Private Sub btnconvert1_Click(sender As Object, e As EventArgs) Handles btnconvert1.Click

        Const dbleuro_rate As Double = 0.9
        Const dblpound_rate As Double = 0.79
        Const dblrand_rate As Double = 13.89
        Dim dbldollar As Double
        Dim dbleuro As Double
        Dim dblpound As Double
        Dim dblrand As Double

        lbleuro2.Text = String.Empty
        lblpound2.Text = String.Empty
        lblrand2.Text = String.Empty

        Double.TryParse(txtdollar.Text, dbldollar)
        Double.TryParse(lbleuro2.Text, dbleuro)
        Double.TryParse(lblpound2.Text, dblpound)
        Double.TryParse(lblrand2.Text, dblrand)

        dbleuro = dbleuro_rate * dbldollar
        dblpound = dblpound_rate * dbldollar
        dblrand = dblrand_rate * dbldollar

        lbleuro2.Text = dbleuro.ToString("C2")
        lblpound2.Text = dblpound.ToString("C2")
        lblrand2.Text = dblrand.ToString("C2")

        If txtdollar.Text = String.Empty Then
            MessageBox.Show("Please enter the number of American dollars.",
                            "Currency Converter", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Double.TryParse(txtdollar.Text, dbldollar)

        End If
    End Sub

    Private Sub btnteacalc_Click(sender As Object, e As EventArgs) Handles btnteacalc.Click

        MessageBox.Show("Charge for Shipping?", "Shipping",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If DialogResult = DialogResult.Yes Then
            Const shipping_rate As Decimal = 15
            Dim intpounds As Integer
            Dim intprice As Integer
            Dim dectotaldue As Decimal

            Decimal.TryParse(lblteatotal2.Text, dectotaldue)
            Integer.TryParse(txtteapounds.Text, intpounds)
            Integer.TryParse(txtteaprice.Text, intprice)

            dectotaldue = (intpounds * intprice + shipping_rate)

            lblteatotal2.Text = dectotaldue.ToString("C2")

        Else 'no button

            Dim intpounds As Integer
            Dim intprice As Integer
            Dim dectotaldue As Decimal

            Decimal.TryParse(lblteatotal2.Text, dectotaldue)
            Integer.TryParse(txtteapounds.Text, intpounds)
            Integer.TryParse(txtteaprice.Text, intprice)

            dectotaldue = intpounds * intprice

            lblteatotal2.Text = dectotaldue.ToString("C2")


        End If


    End Sub

    Private Sub btnconvert2_Click(sender As Object, e As EventArgs) Handles btnconvert2.Click
        Const dbleuro_rate As Double = 0.9
        Const dblpound_rate As Double = 0.79
        Const dblrand_rate As Double = 13.89
        Dim dbldollar As Double
        Dim dbleuro As Double
        Dim dblpound As Double
        Dim dblrand As Double

        lbleuro2.Text = String.Empty
        lblpound2.Text = String.Empty
        lblrand2.Text = String.Empty

        Double.TryParse(txtdollar.Text, dbldollar)
        Double.TryParse(lbleuro2.Text, dbleuro)
        Double.TryParse(lblpound2.Text, dblpound)
        Double.TryParse(lblrand2.Text, dblrand)

        dbleuro = dbleuro_rate * dbldollar
        dblpound = dblpound_rate * dbldollar
        dblrand = dblrand_rate * dbldollar

        lbleuro2.Text = dbleuro.ToString("C2")
        lblpound2.Text = dblpound.ToString("C2")
        lblrand2.Text = dblrand.ToString("C2")

        If txtdollar.Text = String.Empty Then
            MessageBox.Show("Please enter the number of American dollars.",
                            "Currency Converter", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Double.TryParse(txtdollar.Text, dbldollar)

        End If
    End Sub

    Private Sub btncalc3_Click(sender As Object, e As EventArgs) Handles btncalc3.Click

        Const electric_rate As Decimal = 0.13
        Dim intprevious As Integer
        Dim intcurrent As Integer
        Dim decmonthlybill As Decimal

        Integer.TryParse(txtprevious.Text, intprevious)
        Integer.TryParse(txtcurrent.Text, intcurrent)
        Decimal.TryParse(lblmonthlybill2.Text, decmonthlybill)

        decmonthlybill = (intcurrent - intprevious) * electric_rate

        lblmonthlybill2.Text = decmonthlybill.ToString("C2")

        If txtprevious.Text < txtcurrent.Text Then
            MessageBox.Show("The current reading must be greater than or equal to the previous reading.", "Tri County",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btncalcquot_Click(sender As Object, e As EventArgs) Handles btncalcquot.Click

        Dim intfirst As Integer
        Dim intsecond As Integer
        Dim intquot As Integer

        Integer.TryParse(txtfirst.Text, intfirst)
        Integer.TryParse(txtsecond.Text, intsecond)
        Integer.TryParse(lblquot.Text, intquot)

        intquot = intfirst / intsecond

        lblquot.Text = intquot.ToString()


        If intfirst > intsecond Then
            Dim intTemp As Integer
            intTemp = intfirst
            intfirst = intsecond
            intsecond = intTemp
        End If
        'display lowest and highest
        lblmessage.text = "lowest score: " &
            Convert.ToString(intfirst) & ControlChars.NewLine &
            "highest score: " & Convert.ToString(intsecond)

    End Sub
End Class

