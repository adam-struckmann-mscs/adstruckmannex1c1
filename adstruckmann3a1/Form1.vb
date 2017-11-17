Public Class Form1
    Private Sub btndowhile_Click(sender As Object, e As EventArgs) Handles btndowhile.Click
        lbleven.text = "Pretest Do While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do While i <= 20
            lbleven.Text = lbleven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop
    End Sub

    Private Sub btndountil_Click(sender As Object, e As EventArgs) Handles btndountil.Click
        lbleven.Text = "Pretest Do Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do Until i >= 22
            lbleven.Text = lbleven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop
    End Sub

    Private Sub btnloopwhile_Click(sender As Object, e As EventArgs) Handles btnloopwhile.Click
        lbleven.Text = "Posttest Loop While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lbleven.Text = lbleven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop While i <= 20
    End Sub

    Private Sub btnloopuntil_Click(sender As Object, e As EventArgs) Handles btnloopuntil.Click
        lbleven.Text = "Posttest Loop Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lbleven.Text = lbleven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop Until i = 22
    End Sub

    Private Sub btnfor_Click(sender As Object, e As EventArgs) Handles btnfor.Click
        lbleven.Text = "For Loop" & ControlChars.NewLine
        For i As Integer = 2 To 20 Step 1
            lbleven.Text = lbleven.Text & i.ToString & ControlChars.NewLine
            i += 1
        Next i
    End Sub

    Private Sub btnsumwhile_Click(sender As Object, e As EventArgs) Handles btnsumwhile.Click
        txtlist.text = String.Empty
        lblcount.text = String.Empty
        lblaverage.text = String.Empty

        Const strPROMPT As String =
            "Enter a number. " &
            ControlChars.NewLine &
            "Click Cancel of leave blank to end."
        Const strTITLE As String = "Number Entry"
        Dim strnum As String
        Dim intnum As Integer
        Dim intsum As Integer
        Dim intcount As Integer
        Dim dblavg As Double


        strnum = InputBox(strPROMPT, strTITLE, "0")
        'LOOP
        Do While strnum <> String.Empty


            Int32.TryParse(strnum, intnum)

            txtlist.Text = txtlist.Text & intnum.ToString & ControlChars.NewLine

            intcount = intcount + 1
            intsum = intsum + intnum
            strnum = InputBox(strPROMPT, strTITLE, "0")
        Loop

        lblcount.Text = intcount.ToString

        If intcount > 0 Then
            dblavg = intsum / intcount
            lblaverage.Text = dblavg.ToString("N2")
        Else
            lblaverage.Text = "N/A"
        End If


    End Sub

    Private Sub btnsumloop_Click(sender As Object, e As EventArgs) Handles btnsumloop.Click
        txtlist.Text = String.Empty
        lblcount.Text = String.Empty
        lblaverage.Text = String.Empty

        Const strPROMPT As String =
            "Enter a number. " &
            ControlChars.NewLine &
            "Click Cancel of leave blank to end."
        Const strTITLE As String = "Number Entry"
        Dim strnum As String
        Dim intnum As Integer
        Dim intsum As Integer
        Dim intcount As Integer
        Dim dblavg As Double


        strnum = InputBox(strPROMPT, strTITLE, "0")
        'LOOP
        Do
            Int32.TryParse(strnum, intnum)

            txtlist.Text = txtlist.Text & intnum.ToString & ControlChars.NewLine

            intcount = intcount + 1
            intsum = intsum + intnum
            strnum = InputBox(strPROMPT, strTITLE, "0")

        Loop Until strnum = String.Empty

        lblcount.Text = intcount.ToString

        If intcount > 0 Then
            dblavg = intsum / intcount
            lblaverage.Text = dblavg.ToString("N2")
        Else
            lblaverage.Text = "N/A"
        End If
    End Sub

    Private Sub btnsumnext_Click(sender As Object, e As EventArgs) Handles btnsumnext.Click
        txtlist.Text = String.Empty
        lblcount.Text = String.Empty
        lblaverage.Text = String.Empty

        Const strPROMPT As String =
            "Enter a quantity of numbers "
        Const strTITLE As String = "Number Entry"
        Dim strnum As String
        Dim intnum As Integer
        Dim intsum As Integer
        Dim intcount As Integer
        Dim dblavg As Double


        strnum = InputBox(strPROMPT, strTITLE, "0")
        'LOOP
        For 
            Int32.TryParse(strnum, intnum)

            txtlist.Text = txtlist.Text & intnum.ToString & ControlChars.NewLine

            intcount = intcount + 1
            intsum = intsum + intnum
            strnum = InputBox(strPROMPT, strTITLE, "0")

        Next strnum = String.Empty

        lblcount.Text = intcount.ToString

        If intcount > 0 Then
            dblavg = intsum / intcount
            lblaverage.Text = dblavg.ToString("N2")
        Else
            lblaverage.Text = "N/A"
        End If
    End Sub
End Class
