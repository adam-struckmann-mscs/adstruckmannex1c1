' Name:         Conversion Solution
' Purpose:      Convert a measurement to either centimeters or inches
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtMeasurement_Enter(sender As Object, e As EventArgs) Handles txtMeasurement.Enter
        txtMeasurement.SelectAll()
    End Sub

    Private Sub txtMeasurement_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMeasurement.KeyPress
        ' allow only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub InputChanged(sender As Object, e As EventArgs) _
        Handles txtMeasurement.TextChanged, radsubCentimeters.CheckedChanged,
        radsubInches.CheckedChanged, radfunccentimeters.CheckedChanged, radfuncinches.CheckedChanged
        Dim dblmeasurement As Double = 0.0
        Dim dblresult As Double = 0.0

        Double.TryParse(txtMeasurement.Text, dblmeasurement)

        If radsubCentimeters.Checked Then
            'dblresult = 1.11
            calcCentimeterssub(dblmeasurement, dblresult)
        ElseIf radsubInches.Checked Then
            'dblresult = 2.22
            CalcInchesSub(dblmeasurement, dblresult)
        ElseIf radfunccentimeters.Checked Then
            'dblresult = 3.33
            dblresult = CalcCentimetersFunc(dblmeasurement)
        ElseIf radfuncinches.Checked Then
            'dblresult = 4.44
            dblresult = CalcInchesFunc(dblmeasurement)
        End If

        lblResult.Text = dblresult.ToString("N2")
    End Sub

    Private Sub CalcCentimetersSub(ByVal dblMeas As Double, ByRef dblres As Double)
        dblres = dblMeas * 2.54
    End Sub

    Private Sub CalcInchesSub(ByVal dblMeas As Double, ByRef dblres As Double)
        dblres = dblMeas / 2.54
    End Sub

    Private Function CalcCentimetersFunc(ByVal dblMeas As Double) As Double
        Return dblMeas * 2.54
    End Function

    Private Function CalcInchesFunc(ByVal dblMeas As Double) As Double
        Return dblMeas / 2.54
    End Function

    Private Sub txtweight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtweight.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtweight_Enter(sender As Object, e As EventArgs) Handles txtweight.Enter
        txtweight.SelectAll()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboplanet.SelectedItem = "Earth"
        cboplanet.Items.Add("Mars")
        cboplanet.Items.Add("Mercury")
        cboplanet.Items.Add("Venus")
        cboplanet.Items.Add("Earth")
        cboplanet.Items.Add("Jupiter")
        cboplanet.Items.Add("Saturn")
        cboplanet.Items.Add("Uranus")
        cboplanet.Items.Add("Neptune")
        cboplanet.Items.Add("Pluto")


    End Sub

    Private Sub CalculateRadSub(ByVal dblWeight As Double, ByRef dbltotal As Double)
        Dim dblgravity As Double
        Double.TryParse(txtweight.Text, dblWeight)
        Select Case cboplanet.SelectedIndex.ToString
            Case "Mercury", "Mars"
                dblgravity = 0.38
            Case "Venus"
                dblgravity = 0.91
            Case "Earth"
                dblgravity = 1.0
            Case "Jupiter"
                dblgravity = 2.34
            Case "Saturn"
                dblgravity = 1.06
            Case "Uranus"
                dblgravity = 0.92
            Case "Neptune"
                dblgravity = 1.14
            Case "Pluto"
                dblgravity = 0.06
        End Select
        dbltotal = dblgravity * dblWeight
    End Sub
    Private Function CalculateRadFunc(ByVal dblweight As Double, ByVal dbltotal As Double) As Double
        Dim dblgravity As Double
        Double.TryParse(txtweight.Text, dblweight)
        Select Case cboplanet.SelectedIndex.ToString
            Case "Mercury", "Mars"
                dblgravity = 0.38
            Case "Venus"
                dblgravity = 0.91
            Case "Earth"
                dblgravity = 1.0
            Case "Jupiter"
                dblgravity = 2.34
            Case "Saturn"
                dblgravity = 1.06
            Case "Uranus"
                dblgravity = 0.92
            Case "Neptune"
                dblgravity = 1.14
            Case "Pluto"
                dblgravity = 0.06
        End Select
        dbltotal = dblgravity * dblweight
        Return dbltotal
    End Function

    Private Sub WeightInputChanged(sender As Object, e As EventArgs) Handles radsub.CheckedChanged, radfunc.CheckedChanged
        Dim dbltotal As Double
        Dim dblweight As Double

        If radsub.Checked Then
            CalculateRadSub(dblweight, dbltotal)
        ElseIf radfunc.Checked Then
            CalculateRadFunc(dblweight, dbltotal)
        End If
        lbltotal.Text = dbltotal.ToString("N2")
    End Sub
End Class
