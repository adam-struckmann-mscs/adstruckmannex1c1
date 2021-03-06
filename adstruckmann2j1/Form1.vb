﻿' Name:         Chapter 8, String functions, list boxes
' Purpose:      #2: Interprets color code
'               #5: Sets proper upper/lower case
'               #6: Interprets shipping code
' Programmer:   <your name> on <today's date>

Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ItemNumbers_TextChanged(sender As Object, e As EventArgs) _
            Handles txtItem1.TextChanged, txtItem2.TextChanged, txtItem3.TextChanged, txtItem4.TextChanged, txtItem5.TextChanged
        lstColors.Items.Clear()
    End Sub

    Private Sub btnDisplayColor_Click(sender As Object, e As EventArgs) Handles btnDisplayColor.Click
        DisplayColor(txtItem1.Text)
        DisplayColor(txtItem2.Text)
        DisplayColor(txtItem3.Text)
        DisplayColor(txtItem4.Text)
        DisplayColor(txtItem5.Text)
    End Sub

    Private Sub DisplayColor(ByVal itemNum As String)
        Dim stritemcolor As String
        Dim stritem1 As String = txtItem1.Text

        If Len(stritem1) <> 7 Then


            'Dim stritem2 As String = txtItem2.Text
            'Dim stritem3 As String = txtItem3.Text
            'Dim stritem4 As String = txtItem4.Text
            'Dim stritem5 As String = txtItem5.Text
            Dim strcolor1 As String = stritem1.Substring(3, 1)
            'Dim strcolor2 As String = stritem2.Substring(3, 1)
            'Dim strcolor3 As String = stritem3.Substring(3, 1)
            'Dim strcolor4 As String = stritem4.Substring(3, 1)
            'Dim strcolor5 As String = stritem5.Substring(3, 1)




            If strcolor1 = "b" Then
                stritemcolor = ": Blue"

            Else
                stritemcolor = ": invalid"


            End If
        End If
        lstColors.Items.Add(stritem1 & stritemcolor)
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        txtName.SelectAll()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        lblName.Text = String.Empty
    End Sub

    Private Sub btnDisplayDelivery_Click(sender As Object, e As EventArgs) Handles btnDisplayDelivery.Click
        DisplayDelivery(txtPartNum1.Text)
        DisplayDelivery(txtPartNum2.Text)
        DisplayDelivery(txtPartNum3.Text)
        DisplayDelivery(txtPartNum4.Text)
        DisplayDelivery(txtPartNum5.Text)
        DisplayDelivery(txtPartNum6.Text)
    End Sub

    Private Sub DisplayDelivery(ByVal partNum As String)
        lstDelivery.Items.Add("Mail - Standard")
    End Sub

    Private Sub PartNum_TextChanged(sender As Object, e As EventArgs) _
            Handles txtPartNum1.TextChanged, txtPartNum2.TextChanged, txtPartNum3.TextChanged, txtPartNum4.TextChanged, txtPartNum5.TextChanged, txtPartNum6.TextChanged
        lstDelivery.Items.Clear()
    End Sub

    'btnProper_Click pseudocode:
    '1) Convert txtName to lower case, store in strName
    '2) Use strName.Substring() to get first character of strName, convert to upper case, store in strFirstChar
    '3) Remove first character of strName
    '4) Insert strFirstChar at beginning of strName
    '5) Use strName.IndexOf() to find the space character. Add 1 and store in index
    '6) Repeat steps 2 - 4 to remove/insert first letter of last name

    Private Sub btnProper_Click(sender As Object, e As EventArgs) Handles btnProper.Click

    End Sub

End Class
