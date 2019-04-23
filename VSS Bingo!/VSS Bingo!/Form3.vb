Public Class Form3
    Public BingoBoard(25) As Label
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BingoBoard(1) = Label1
        BingoBoard(2) = Label2
        BingoBoard(3) = Label3
        BingoBoard(4) = Label4
        BingoBoard(5) = Label5
        BingoBoard(6) = Label6
        BingoBoard(7) = Label7
        BingoBoard(8) = Label8
        BingoBoard(9) = Label9
        BingoBoard(10) = Label10
        BingoBoard(11) = Label11
        BingoBoard(12) = Label12
        BingoBoard(13) = Label13
        BingoBoard(14) = Label14
        BingoBoard(15) = Label15
        BingoBoard(16) = Label16
        BingoBoard(17) = Label17
        BingoBoard(18) = Label18
        BingoBoard(19) = Label19
        BingoBoard(20) = Label20
        BingoBoard(21) = Label21
        BingoBoard(22) = Label22
        BingoBoard(23) = Label23
        BingoBoard(24) = Label24
        BingoBoard(25) = Label25
        Me.Location = New Point(2000, 100)
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class