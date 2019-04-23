Public Class Form2
    Private Numbers(75) As CheckBox
    Private BingoBoard(25) As CheckBox
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Numbers(1) = CheckBox1
        Numbers(2) = CheckBox2
        Numbers(3) = CheckBox3
        Numbers(4) = CheckBox4
        Numbers(5) = CheckBox5
        Numbers(6) = CheckBox10
        Numbers(7) = CheckBox9
        Numbers(8) = CheckBox8
        Numbers(9) = CheckBox7
        Numbers(10) = CheckBox6
        Numbers(11) = CheckBox15
        Numbers(12) = CheckBox14
        Numbers(13) = CheckBox13
        Numbers(14) = CheckBox12
        Numbers(15) = CheckBox11

        Numbers(16) = CheckBox30
        Numbers(17) = CheckBox29
        Numbers(18) = CheckBox28
        Numbers(19) = CheckBox27
        Numbers(20) = CheckBox26
        Numbers(21) = CheckBox25
        Numbers(22) = CheckBox24
        Numbers(23) = CheckBox23
        Numbers(24) = CheckBox22
        Numbers(25) = CheckBox21
        Numbers(26) = CheckBox20
        Numbers(27) = CheckBox19
        Numbers(28) = CheckBox18
        Numbers(29) = CheckBox17
        Numbers(30) = CheckBox16

        Numbers(31) = CheckBox45
        Numbers(32) = CheckBox44
        Numbers(33) = CheckBox43
        Numbers(34) = CheckBox42
        Numbers(35) = CheckBox41
        Numbers(36) = CheckBox40
        Numbers(37) = CheckBox39
        Numbers(38) = CheckBox38
        Numbers(39) = CheckBox37
        Numbers(40) = CheckBox36
        Numbers(41) = CheckBox35
        Numbers(42) = CheckBox34
        Numbers(43) = CheckBox33
        Numbers(44) = CheckBox32
        Numbers(45) = CheckBox31

        Numbers(46) = CheckBox60
        Numbers(47) = CheckBox59
        Numbers(48) = CheckBox58
        Numbers(49) = CheckBox57
        Numbers(50) = CheckBox56
        Numbers(51) = CheckBox55
        Numbers(52) = CheckBox54
        Numbers(53) = CheckBox53
        Numbers(54) = CheckBox52
        Numbers(55) = CheckBox51
        Numbers(56) = CheckBox50
        Numbers(57) = CheckBox49
        Numbers(58) = CheckBox48
        Numbers(59) = CheckBox47
        Numbers(60) = CheckBox46

        Numbers(61) = CheckBox75
        Numbers(62) = CheckBox74
        Numbers(63) = CheckBox73
        Numbers(64) = CheckBox72
        Numbers(65) = CheckBox71
        Numbers(66) = CheckBox70
        Numbers(67) = CheckBox69
        Numbers(68) = CheckBox68
        Numbers(69) = CheckBox67
        Numbers(70) = CheckBox66
        Numbers(71) = CheckBox65
        Numbers(72) = CheckBox64
        Numbers(73) = CheckBox63
        Numbers(74) = CheckBox62
        Numbers(75) = CheckBox61

        BingoBoard(1) = CheckBoxBingo1
        BingoBoard(2) = CheckBoxBingo2
        BingoBoard(3) = CheckBoxBingo3
        BingoBoard(4) = CheckBoxBingo4
        BingoBoard(5) = CheckBoxBingo5
        BingoBoard(6) = CheckBoxBingo6
        BingoBoard(7) = CheckBoxBingo7
        BingoBoard(8) = CheckBoxBingo8
        BingoBoard(9) = CheckBoxBingo9
        BingoBoard(10) = CheckBoxBingo10
        BingoBoard(11) = CheckBoxBingo11
        BingoBoard(12) = CheckBoxBingo12
        BingoBoard(13) = CheckBoxBingo13
        BingoBoard(14) = CheckBoxBingo14
        BingoBoard(15) = CheckBoxBingo15
        BingoBoard(16) = CheckBoxBingo16
        BingoBoard(17) = CheckBoxBingo17
        BingoBoard(18) = CheckBoxBingo18
        BingoBoard(19) = CheckBoxBingo19
        BingoBoard(20) = CheckBoxBingo20
        BingoBoard(21) = CheckBoxBingo21
        BingoBoard(22) = CheckBoxBingo22
        BingoBoard(23) = CheckBoxBingo23
        BingoBoard(24) = CheckBoxBingo24
        BingoBoard(25) = CheckBoxBingo25

        For x = 1 To 75
            Numbers(x).Text = Numbers(x).Tag
        Next

        For i = 1 To 25
            If i < 6 Then BingoBoard(i).Text = ("1," + CStr(i))
            If i < 11 And i > 5 Then BingoBoard(i).Text = ("2," + CStr(i - 5))
            If i < 16 And i > 10 Then BingoBoard(i).Text = ("3," + CStr(i - 10))
            If i < 21 And i > 15 Then BingoBoard(i).Text = ("4," + CStr(i - 15))
            If i < 26 And i > 20 Then BingoBoard(i).Text = ("5," + CStr(i - 20))
        Next
        Form1.Show()
    End Sub

    Private Sub NewNumber(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged, CheckBox8.CheckedChanged, CheckBox75.CheckedChanged, CheckBox74.CheckedChanged, CheckBox73.CheckedChanged, CheckBox72.CheckedChanged, CheckBox71.CheckedChanged, CheckBox70.CheckedChanged, CheckBox7.CheckedChanged, CheckBox69.CheckedChanged, CheckBox68.CheckedChanged, CheckBox67.CheckedChanged, CheckBox66.CheckedChanged, CheckBox65.CheckedChanged, CheckBox64.CheckedChanged, CheckBox63.CheckedChanged, CheckBox62.CheckedChanged, CheckBox61.CheckedChanged, CheckBox60.CheckedChanged, CheckBox6.CheckedChanged, CheckBox59.CheckedChanged, CheckBox58.CheckedChanged, CheckBox57.CheckedChanged, CheckBox56.CheckedChanged, CheckBox55.CheckedChanged, CheckBox54.CheckedChanged, CheckBox53.CheckedChanged, CheckBox52.CheckedChanged, CheckBox51.CheckedChanged, CheckBox50.CheckedChanged, CheckBox5.CheckedChanged, CheckBox49.CheckedChanged, CheckBox48.CheckedChanged, CheckBox47.CheckedChanged, CheckBox46.CheckedChanged, CheckBox45.CheckedChanged, CheckBox44.CheckedChanged, CheckBox43.CheckedChanged, CheckBox42.CheckedChanged, CheckBox41.CheckedChanged, CheckBox40.CheckedChanged, CheckBox4.CheckedChanged, CheckBox39.CheckedChanged, CheckBox38.CheckedChanged, CheckBox37.CheckedChanged, CheckBox36.CheckedChanged, CheckBox35.CheckedChanged, CheckBox34.CheckedChanged, CheckBox33.CheckedChanged, CheckBox32.CheckedChanged, CheckBox31.CheckedChanged, CheckBox30.CheckedChanged, CheckBox3.CheckedChanged, CheckBox29.CheckedChanged, CheckBox28.CheckedChanged, CheckBox27.CheckedChanged, CheckBox26.CheckedChanged, CheckBox25.CheckedChanged, CheckBox24.CheckedChanged, CheckBox23.CheckedChanged, CheckBox22.CheckedChanged, CheckBox21.CheckedChanged, CheckBox20.CheckedChanged, CheckBox2.CheckedChanged, CheckBox19.CheckedChanged, CheckBox18.CheckedChanged, CheckBox17.CheckedChanged, CheckBox16.CheckedChanged, CheckBox15.CheckedChanged, CheckBox14.CheckedChanged, CheckBox13.CheckedChanged, CheckBox12.CheckedChanged, CheckBox11.CheckedChanged, CheckBox10.CheckedChanged, CheckBox1.CheckedChanged
        For i = 1 To 75
            If Numbers(i).Checked = True Then
                Form1.Numbers(i).BackColor = Color.Red
                Form1.Numbers(i).ForeColor = Color.Black
            End If
        Next

        If Numbers(sender.tag).Checked = True Then
            Form1.Numbers(sender.tag).BackColor = Color.Yellow
            Form1.Numbers(sender.tag).ForeColor = Color.Red
        Else
            Form1.Numbers(sender.tag).BackColor = Color.DarkBlue
            Form1.Numbers(sender.tag).ForeColor = Color.White
        End If
    End Sub

    Private Sub BingoChecked(sender As Object, e As EventArgs) Handles CheckBoxBingo9.CheckedChanged, CheckBoxBingo8.CheckedChanged, CheckBoxBingo7.CheckedChanged, CheckBoxBingo6.CheckedChanged, CheckBoxBingo5.CheckedChanged, CheckBoxBingo4.CheckedChanged, CheckBoxBingo3.CheckedChanged, CheckBoxBingo25.CheckedChanged, CheckBoxBingo24.CheckedChanged, CheckBoxBingo23.CheckedChanged, CheckBoxBingo22.CheckedChanged, CheckBoxBingo21.CheckedChanged, CheckBoxBingo20.CheckedChanged, CheckBoxBingo2.CheckedChanged, CheckBoxBingo19.CheckedChanged, CheckBoxBingo18.CheckedChanged, CheckBoxBingo17.CheckedChanged, CheckBoxBingo16.CheckedChanged, CheckBoxBingo15.CheckedChanged, CheckBoxBingo14.CheckedChanged, CheckBoxBingo13.CheckedChanged, CheckBoxBingo12.CheckedChanged, CheckBoxBingo11.CheckedChanged, CheckBoxBingo10.CheckedChanged, CheckBoxBingo1.CheckedChanged
        If BingoBoard(sender.tag).Checked = True Then
            Form3.BingoBoard(sender.tag).backcolor = Color.Yellow
        Else
            Form3.BingoBoard(sender.tag).BackColor = Color.DarkBlue
        End If
        If BingoBoard(13).Checked = True Then Form3.BingoBoard(13).ForeColor = Color.Black Else Form3.BingoBoard(13).ForeColor = Color.White
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 1 To 75
            Numbers(i).Checked = False
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i = 1 To 25
            BingoBoard(i).Checked = False
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i = 1 To 25
            BingoBoard(i).Checked = False
        Next
        Dim randomnumber As Integer = Int(Rnd() * 5 + 1)
        BingoBoard(randomnumber).Checked = True
        BingoBoard(randomnumber + 5).Checked = True
        BingoBoard(randomnumber + 10).Checked = True
        BingoBoard(randomnumber + 15).Checked = True
        BingoBoard(randomnumber + 20).Checked = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 1 To 25
            BingoBoard(i).Checked = False
        Next
        Dim randomnumber As Integer = Int(Rnd() * 5 + 1)
        If randomnumber = 1 Then
            BingoBoard(1).Checked = True
            BingoBoard(2).Checked = True
            BingoBoard(3).Checked = True
            BingoBoard(4).Checked = True
            BingoBoard(5).Checked = True
        End If
        If randomnumber = 2 Then
            BingoBoard(6).Checked = True
            BingoBoard(7).Checked = True
            BingoBoard(8).Checked = True
            BingoBoard(9).Checked = True
            BingoBoard(10).Checked = True
        End If
        If randomnumber = 3 Then
            BingoBoard(11).Checked = True
            BingoBoard(12).Checked = True
            BingoBoard(13).Checked = True
            BingoBoard(14).Checked = True
            BingoBoard(15).Checked = True
        End If
        If randomnumber = 4 Then
            BingoBoard(16).Checked = True
            BingoBoard(17).Checked = True
            BingoBoard(18).Checked = True
            BingoBoard(19).Checked = True
            BingoBoard(20).Checked = True
        End If
        If randomnumber = 5 Then
            BingoBoard(21).Checked = True
            BingoBoard(22).Checked = True
            BingoBoard(23).Checked = True
            BingoBoard(24).Checked = True
            BingoBoard(25).Checked = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For i = 1 To 25
            BingoBoard(i).Checked = False
        Next
        Dim randomnumber = Int(Rnd() * 2 + 1)
        If randomnumber = 1 Then
            BingoBoard(1).Checked = True
            BingoBoard(7).Checked = True
            BingoBoard(13).Checked = True
            BingoBoard(19).Checked = True
            BingoBoard(25).Checked = True
        End If
        If randomnumber = 2 Then
            BingoBoard(5).Checked = True
            BingoBoard(9).Checked = True
            BingoBoard(13).Checked = True
            BingoBoard(17).Checked = True
            BingoBoard(21).Checked = True
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For i = 1 To 25
            BingoBoard(i).Checked = False
        Next
        Dim randomnumber = Int(Rnd() * 4 + 1)
        If randomnumber = 1 Then
            BingoBoard(1).Checked = True
            BingoBoard(6).Checked = True
            BingoBoard(11).Checked = True
            BingoBoard(16).Checked = True
            BingoBoard(21).Checked = True

            BingoBoard(12).Checked = True
            BingoBoard(13).Checked = True
            BingoBoard(14).Checked = True
            BingoBoard(15).Checked = True
        End If
        If randomnumber = 2 Then
            BingoBoard(1).Checked = True
            BingoBoard(2).Checked = True
            BingoBoard(3).Checked = True
            BingoBoard(4).Checked = True
            BingoBoard(5).Checked = True

            BingoBoard(8).Checked = True
            BingoBoard(13).Checked = True
            BingoBoard(18).Checked = True
            BingoBoard(23).Checked = True
        End If
        If randomnumber = 3 Then
            BingoBoard(5).Checked = True
            BingoBoard(10).Checked = True
            BingoBoard(15).Checked = True
            BingoBoard(20).Checked = True
            BingoBoard(25).Checked = True

            BingoBoard(11).Checked = True
            BingoBoard(12).Checked = True
            BingoBoard(13).Checked = True
            BingoBoard(14).Checked = True
        End If
        If randomnumber = 4 Then
            BingoBoard(21).Checked = True
            BingoBoard(22).Checked = True
            BingoBoard(23).Checked = True
            BingoBoard(24).Checked = True
            BingoBoard(25).Checked = True

            BingoBoard(3).Checked = True
            BingoBoard(8).Checked = True
            BingoBoard(13).Checked = True
            BingoBoard(18).Checked = True
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        For i = 1 To 25
            BingoBoard(i).Checked = False
        Next
        Dim randomnumber = Int(Rnd() * 4 + 1)

        If randomnumber = 1 Then
            BingoBoard(1).Checked = True
            BingoBoard(2).Checked = True
            BingoBoard(6).Checked = True
            BingoBoard(7).Checked = True
        End If
        If randomnumber = 2 Then
            BingoBoard(4).Checked = True
            BingoBoard(5).Checked = True
            BingoBoard(9).Checked = True
            BingoBoard(10).Checked = True
        End If
        If randomnumber = 3 Then
            BingoBoard(19).Checked = True
            BingoBoard(20).Checked = True
            BingoBoard(24).Checked = True
            BingoBoard(25).Checked = True
        End If
        If randomnumber = 4 Then
            BingoBoard(16).Checked = True
            BingoBoard(17).Checked = True
            BingoBoard(21).Checked = True
            BingoBoard(22).Checked = True
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        For i = 1 To 25
            BingoBoard(i).Checked = False
        Next
        BingoBoard(1).Checked = True
        BingoBoard(2).Checked = True
        BingoBoard(3).Checked = True
        BingoBoard(4).Checked = True
        BingoBoard(5).Checked = True
        BingoBoard(6).Checked = True
        BingoBoard(10).Checked = True
        BingoBoard(11).Checked = True
        BingoBoard(15).Checked = True
        BingoBoard(16).Checked = True
        BingoBoard(20).Checked = True
        BingoBoard(21).Checked = True
        BingoBoard(22).Checked = True
        BingoBoard(23).Checked = True
        BingoBoard(24).Checked = True
        BingoBoard(25).Checked = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        For i = 1 To 25
            BingoBoard(i).Checked = False
        Next
        BingoBoard(7).Checked = True
        BingoBoard(8).Checked = True
        BingoBoard(9).Checked = True
        BingoBoard(12).Checked = True
        BingoBoard(13).Checked = True
        BingoBoard(14).Checked = True
        BingoBoard(17).Checked = True
        BingoBoard(18).Checked = True
        BingoBoard(19).Checked = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        For i = 1 To 25
            BingoBoard(i).Checked = True
        Next
        BingoBoard(13).Checked = False
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Button11.Text = "Show Board" Then
            Form3.Show()
            Button11.Text = "Hide Board"
        Else
            Form3.Hide()
            Button11.Text = "Show Board"
        End If
    End Sub
End Class