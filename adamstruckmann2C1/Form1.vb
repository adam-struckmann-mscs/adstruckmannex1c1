' Adam Struckmann on 10/3/17

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmmain
    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private str1, str2, str3 As String
    Private byte1, byte2, byte3 As Byte
    Private short1, short2, short3 As Short
    Private integer1, integer2, integer3 As Integer
    Private long1, long2, long3 As Long
    Private single1, single2, single3 As Single
    Private double1, double2, double3 As Double
    Private decimal1, decimal2, decimal3 As Decimal
    Private date1, date2, date3 As DateTime
    Private timespan2 As TimeSpan

    Private Sub btnsubtract_Click(sender As Object, e As EventArgs) Handles btnsubtract.Click
        btndisplay_Click(Nothing, Nothing)
        On Error Resume Next
        'str3 = str1 - str2
        'lblstring3.Text = str3
        byte3 = byte1 - byte2
        lblbyte3.Text = (byte3).ToString()
        short3 = short1 - short2
        lblshort3.Text = (short3).ToString()
        integer3 = integer1 - integer2
        lblinteger3.Text = (integer3).ToString()
        long3 = long1 - long2
        lbllong3.Text = (long3).ToString()
        single3 = single1 - single2
        lblsingle3.Text = (single3).ToString()
        double3 = double1 - double2
        lbldouble3.Text = (double3).ToString()
        decimal3 = decimal1 - decimal2
        lbldecimal3.Text = (decimal3).ToString()
        lbldate3.Text = date1.Subtract(timespan2).ToString()
    End Sub

    Private Sub btnmultiply_Click(sender As Object, e As EventArgs) Handles btnmultiply.Click
        btndisplay_Click(Nothing, Nothing)
        On Error Resume Next
        'str3 = str1 * str2
        'lblstring3.Text = str3
        byte3 = byte1 * byte2
        lblbyte3.Text = byte3.ToString()
        short3 = short1 * short2
        lblshort3.Text = short3.ToString()
        integer3 = integer1 * integer2
        lblinteger3.Text = integer3.ToString()
        long3 = long1 * long2
        lbllong3.Text = long3.ToString()
        single3 = single1 * single2
        lblsingle3.Text = single3.ToString()
        double3 = double1 * double2
        lbldouble3.Text = double3.ToString()
        decimal3 = decimal1 * decimal2
        lbldecimal3.Text = decimal3.ToString()
    End Sub

    Private Sub btndivide_Click(sender As Object, e As EventArgs) Handles btndivide.Click
        btndisplay_Click(Nothing, Nothing)
        On Error Resume Next
        'str3 = str1 / str2
        'lblstring3.Text = str3
        byte3 = byte1 \ byte2
        lblbyte3.Text = (byte3).ToString()
        short3 = short1 \ short2
        lblshort3.Text = (short3).ToString()
        integer3 = integer1 \ integer2
        lblinteger3.Text = (integer3).ToString()
        long3 = long1 \ long2
        lbllong3.Text = (long3).ToString()
        single3 = single1 / single2
        lblsingle3.Text = (single3).ToString()
        double3 = double1 / double2
        lbldouble3.Text = (double3).ToString()
        decimal3 = decimal1 / decimal2
        lbldecimal3.Text = (decimal3).ToString()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        btndisplay_Click(Nothing, Nothing)
        On Error Resume Next
        str3 = str1 + str2
        lblstring3.Text = str1 + str2
        byte3 = byte1 + byte2
        lblbyte3.Text = (byte3).ToString()
        short3 = short1 + short2
        lblshort3.Text = (short3).ToString()
        integer3 = integer1 + integer2
        lblinteger3.Text = (integer3).ToString()
        long3 = long1 + long2
        lbllong3.Text = (long3).ToString()
        single3 = single1 + single2
        lblsingle3.Text = (single3).ToString()
        double3 = double1 + double2
        lbldouble3.Text = (double3).ToString()
        decimal3 = decimal1 + decimal2
        lbldecimal3.Text = (decimal3).ToString()
        lbldate3.Text = date1.Add(timespan2).ToString()


    End Sub

    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        str1 = String.Empty
        str2 = String.Empty
        str3 = String.Empty
        byte1 = 0
        byte2 = 0
        byte3 = 0
        short1 = 0S
        short2 = 0S
        short3 = 0S
        integer1 = 0
        integer2 = 0
        integer3 = 0
        long1 = 0L
        long2 = 0L
        long3 = 0L
        single1 = 0.0F
        single2 = 0.0F
        single3 = 0.0F
        double1 = 0.0
        double2 = 0.0
        double3 = 0.0
        decimal1 = 0D
        decimal2 = 0D
        decimal3 = 0D
        date1 = Date.MinValue
        date2 = Date.MinValue
        date3 = Date.MinValue

        lblstring3.Text = String.Empty
        lblbyte3.Text = String.Empty
        lblshort3.Text = String.Empty
        lblinteger3.Text = String.Empty
        lbllong3.Text = String.Empty
        lblsingle3.Text = String.Empty
        lbldouble3.Text = String.Empty
        lbldecimal3.Text = String.Empty
        lbldate3.Text = String.Empty

        str1 = txtinput1.Text
        str2 = txtinput2.Text
        lblstring1.Text = str1
        lblstring2.Text = str2

        Byte.TryParse(txtinput1.Text, byte1)
        Byte.TryParse(txtinput2.Text, byte2)
        lblbyte1.Text = byte1.ToString()
        lblbyte2.Text = byte2.ToString()

        Short.TryParse(txtinput1.Text, short1)
        Short.TryParse(txtinput2.Text, short2)
        lblshort1.Text = short1.ToString()
        lblshort2.Text = short2.ToString()

        Integer.TryParse(txtinput1.Text, integer1)
        Integer.TryParse(txtinput2.Text, integer2)
        lblinteger1.Text = integer1.ToString()
        lblinteger2.Text = integer2.ToString()

        Long.TryParse(txtinput1.Text, long1)
        Long.TryParse(txtinput2.Text, long2)
        lbllong1.Text = long1.ToString()
        lbllong2.Text = long2.ToString()

        Single.TryParse(txtinput1.Text, single1)
        Single.TryParse(txtinput2.Text, single2)
        lblsingle1.Text = single1.ToString()
        lblsingle2.Text = single2.ToString()

        Double.TryParse(txtinput1.Text, double1)
        Double.TryParse(txtinput2.Text, double2)
        lbldouble1.Text = double1.ToString()
        lbldouble2.Text = double2.ToString()

        Decimal.TryParse(txtinput1.Text, decimal1)
        Decimal.TryParse(txtinput2.Text, decimal2)
        lbldecimal1.Text = decimal1.ToString()
        lbldecimal2.Text = decimal2.ToString()

        Date.TryParse(txtinput1.Text, date1)
        Date.TryParse(txtinput2.Text, date2)
        TimeSpan.TryParse(txtinput2.Text, timespan2)
        lbldate1.Text = date1.ToString()
        lbldate2.Text = date2.ToString()

    End Sub









End Class
