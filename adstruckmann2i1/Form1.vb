'adam struckmann on 11/2/17

Option Strict On
Option Infer Off
Option Explicit On

Public Class Form1
    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        '03 insert
        Dim strword As String = txt03.Text
        strword = strword.Remove(0, 1)
        strword = strword.Insert(0, "cr")
        lbl03.Text = strword

        '05a length
        Dim str05a As String = txt05a.Text
        Dim int05a As Integer
        int05a = (str05a.Length)
        lbl05a.Text = int05a.ToString

        '05b trim
        Dim str05b As String = txt05b.Text
        str05b = str05b.Trim
        lbl05b.Text = str05b

        '04 substring
        Dim stritem As String = txt04.Text
        Dim strcolor As String = stritem.Substring(2, 4)
        lbl04.Text = strcolor

        '05c insert
        Dim str05c As String = txt05c.Text
        str05c = str05c.Remove(1, 1)
        str05c = str05c.Insert(1, "rit")
        lbl05c.Text = str05c

        '05d insert
        Dim str05d As String = txt05d.Text
        str05d = str05d.Insert(0, "Mon")
        lbl05d.Text = str05d

        '05e Pad
        Dim str05e As String = txt05e.Text
        str05e = str05e.PadLeft(10, "*"c)
        lbl05e.Text = str05e

        '06 remove
        Dim str06 As String = txt06.Text
        Dim str06a As String
        str06a = str06.Remove(1, 1)
        lbl06.Text = str06a.Remove(4, 1)

        '07 contains
        Dim str07 As String = txt07.Text
        Dim bool07 As Boolean = str07.Contains("308 JEfFeRsOn StReEt S.")

        If Not bool07 Then
            lbl07.Text = "Jeff St. Not Found"
        End If

        If bool07 Then
            lbl07.Text = "Jeff St. Found"
        End If

        '12 len/remove
        Dim str12a As String = txt12.Text
        Dim str12b As String
        Dim dbl12 As Double
        str12a = (str12a.Substring(0, str12a.Length - 2))
        dbl12 = Convert.ToDouble(str12a)
        str12b = ((dbl12 * 0.01) * 1000).ToString
        lbl12.Text = str12b

        '13 Like
        Dim str13 As String = txt13.Text
        Dim bool13 As Boolean = str13 Like "605##"

        If Not bool13 Then
            lbl13.Text = "Invalid Zip"
        End If
        If bool13 Then
            lbl13.Text = "Shipping = $30"
        End If
    End Sub


End Class
