' Name:         Treeline Project
' Purpose:      Display the total room charge, tax, 
'               total resort fee, and total due
' Programmer:   adam struckmann on 10/18/17

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtRooms.TextChanged, txtNights.TextChanged,
        txtAdults.TextChanged, txtChildren.TextChanged,
        rdbtnqueen.CheckedChanged, rdbtnking.CheckedChanged, rdbtnstandard.CheckedChanged, rdbtnatrium.CheckedChanged, chkparking.CheckedChanged
        ' clear calculated amounts

        lblRoomChg.Text = String.Empty
        lblTax.Text = String.Empty
        lblResortFee.Text = String.Empty
        lblparkingfee.Text = String.Empty
        lblTotalDue.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Const intmax_per_room As Integer = 6
        'Const dbldaily_room_charge As Double = 225.5
        Const dbldaily_room_charge_queen_stand As Double = 225.5
        Const dbldaily_room_charge_queen_atrium As Double = 275
        Const dbldaily_room_charge_King_Stand As Double = 245.5
        Const dbldaily_room_charge_King_atrium As Double = 325
        Const dbldaily_parking_fee As Double = 8.5
        Const dbltax_rate As Double = 0.1625
        Const dbldaily_resort_fee As Double = 12.5
        Const strmsg As String = "you have exceeded the maximum guests per room."
        Dim Introomsreserved As Integer
        Dim intnights As Integer
        Dim intadults As Integer
        Dim intchildren As Integer
        Dim intnumguests As Integer
        Dim dblroomsrequired As Double
        Dim dblparkingfee As Double
        Dim dblDAILYroomcharge As Double
        Dim dbltax As Double
        Dim dbltotalroomcharge As Double
        Dim dbltotalresortfee As Double
        Dim dbltotaldue As Double

        'store input in variables
        Integer.TryParse(txtRooms.Text, Introomsreserved)
        Integer.TryParse(txtNights.Text, intnights)
        Integer.TryParse(txtAdults.Text, intadults)
        Integer.TryParse(txtChildren.Text, intchildren)

        'calculate # of guests
        intnumguests = intadults + intchildren
        'calculate # of rooms required
        dblroomsrequired = intnumguests / intmax_per_room

        ' make sure there is enough rooms for # of guests
        If Introomsreserved < dblroomsrequired Then
            MessageBox.Show(strmsg, "Treeline Resort",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'calculate charges

            If rdbtnqueen.Checked Then
                If rdbtnstandard.Checked Then
                    dblDAILYroomcharge = dbldaily_room_charge_queen_stand
                Else
                    dblDAILYroomcharge = dbldaily_room_charge_queen_atrium
                End If
            Else
                If rdbtnstandard.Checked Then
                    dblDAILYroomcharge = dbldaily_room_charge_King_Stand
                Else
                    dblDAILYroomcharge = dbldaily_room_charge_King_atrium
                End If
            End If

            dbltotalroomcharge = Introomsreserved *
                intnights * dblDAILYroomcharge
            dbltax = dbltotalroomcharge * dbltax_rate
            dbltotalresortfee = Introomsreserved *
                intnights * dbldaily_resort_fee


            If chkparking.Checked Then
                dblparkingfee = intnights * dbldaily_parking_fee
            End If
            dbltotaldue = dbltotalroomcharge +
                dbltax + dbltotalresortfee + dblparkingfee

            'display charges
            lblRoomChg.Text = dbltotalroomcharge.ToString("n2")
            lblTax.Text = dbltax.ToString("n2")
            lblResortFee.Text = dbltotalresortfee.ToString("n2")
            lblparkingfee.Text = dblparkingfee.ToString("n2")
            lblTotalDue.Text = dbltotaldue.ToString("c2")
        End If
    End Sub

    Private Sub CancelKeys(sender As Object, e As KeyPressEventArgs) _
                        Handles txtRooms.KeyPress, txtNights.KeyPress,
                           txtAdults.KeyPress, txtChildren.KeyPress
        ' only numbers and backspace
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            'cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub txtRooms_Enter(sender As Object, e As EventArgs) Handles txtRooms.Enter
        txtRooms.SelectAll()
    End Sub

    Private Sub txtNights_Enter(sender As Object, e As EventArgs) Handles txtNights.Enter
        txtNights.SelectAll()
    End Sub

    Private Sub txtAdults_Enter(sender As Object, e As EventArgs) Handles txtAdults.Enter
        txtAdults.SelectAll()
    End Sub

    Private Sub txtChildren_Enter(sender As Object, e As EventArgs) Handles txtChildren.Enter
        txtChildren.SelectAll()
    End Sub
End Class
