Public Class Form1
    Public Numbers(75) As Label
    Public chosen(75) As Boolean
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Numbers(1) = Label1
        Numbers(2) = Label2
        Numbers(3) = Label4
        Numbers(4) = Label3
        Numbers(5) = Label6
        Numbers(6) = Label5
        Numbers(7) = Label12
        Numbers(8) = Label11
        Numbers(9) = Label10
        Numbers(10) = Label9
        Numbers(11) = Label8
        Numbers(12) = Label7
        Numbers(13) = Label18
        Numbers(14) = Label17
        Numbers(15) = Label16
        Numbers(16) = Label30
        Numbers(17) = Label29
        Numbers(18) = Label28
        Numbers(19) = Label27
        Numbers(20) = Label26
        Numbers(21) = Label25
        Numbers(22) = Label24
        Numbers(23) = Label23
        Numbers(24) = Label22
        Numbers(25) = Label21
        Numbers(26) = Label20
        Numbers(27) = Label19
        Numbers(28) = Label15
        Numbers(29) = Label14
        Numbers(30) = Label13
        Numbers(31) = Label45
        Numbers(32) = Label44
        Numbers(33) = Label43
        Numbers(34) = Label42
        Numbers(35) = Label41
        Numbers(36) = Label40
        Numbers(37) = Label39
        Numbers(38) = Label38
        Numbers(39) = Label37
        Numbers(40) = Label36
        Numbers(41) = Label35
        Numbers(42) = Label34
        Numbers(43) = Label33
        Numbers(44) = Label32
        Numbers(45) = Label31
        Numbers(46) = Label60
        Numbers(47) = Label59
        Numbers(48) = Label58
        Numbers(49) = Label57
        Numbers(50) = Label56
        Numbers(51) = Label55
        Numbers(52) = Label54
        Numbers(53) = Label53
        Numbers(54) = Label52
        Numbers(55) = Label51
        Numbers(56) = Label50
        Numbers(57) = Label49
        Numbers(58) = Label48
        Numbers(59) = Label47
        Numbers(60) = Label46
        Numbers(61) = Label75
        Numbers(62) = Label74
        Numbers(63) = Label73
        Numbers(64) = Label72
        Numbers(65) = Label71
        Numbers(66) = Label70
        Numbers(67) = Label69
        Numbers(68) = Label68
        Numbers(69) = Label67
        Numbers(70) = Label66
        Numbers(71) = Label65
        Numbers(72) = Label64
        Numbers(73) = Label63
        Numbers(74) = Label62
        Numbers(75) = Label61

        For x = 1 To 75
            Numbers(x).Text = x
        Next
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
