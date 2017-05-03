Public Class FRM_Normal
    Dim Player_CHOOSE As Integer
    Dim COM_CHOOSE As Integer
    Dim Hard_COM_CHOOSE As Integer
    Public Impossible As Integer = 0
    Private Sub Me_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        FRM_Difficulty.Show()
    End Sub
    Private Sub BTN_Rock_Click(sender As Object, e As EventArgs) Handles BTN_Rock.Click
        Player_CHOOSE = 1
        AI(2, 3, 1)
    End Sub

    Private Sub BTN_Paper_Click(sender As Object, e As EventArgs) Handles BTN_Paper.Click
        Player_CHOOSE = 2
        AI(3, 1, 2)
    End Sub

    Private Sub BTN_Scissors_Click(sender As Object, e As EventArgs) Handles BTN_Scissors.Click
        Player_CHOOSE = 3
        AI(1, 2, 3)
    End Sub
    Function AI(WinMove As Integer, LoseMove As Integer, TieMove As Integer)
        If Impossible = 0 Then
            COM_CHOOSE = CInt(Int((3 * Rnd()) + 1))
            Won_TEST_Normal()
        ElseIf Impossible = 1 Then
            Hard_COM_CHOOSE = CInt(Int((2 * Rnd()) + 1))
            If Hard_COM_CHOOSE = 1 Then
                COM_CHOOSE = LoseMove
            ElseIf Hard_COM_CHOOSE = 2 Then
                COM_CHOOSE = TieMove
            End If
            Won_TEST_Normal()
        ElseIf Impossible = 2 Then
            Hard_COM_CHOOSE = CInt(Int((11 * Rnd()) + 1))
            If Hard_COM_CHOOSE <= 5 Then
                COM_CHOOSE = TieMove
            ElseIf Hard_COM_CHOOSE <= 10 Then
                COM_CHOOSE = LoseMove
            ElseIf Hard_COM_CHOOSE = 11 Then
                COM_CHOOSE = WinMove
            End If
            Won_TEST_Normal()
        End If
    End Function
    Function Won_TEST_Normal()
        If COM_CHOOSE = 1 Then
            LBL_COM_CHOOSE.Text = "The computer chooses Rock"
        ElseIf COM_CHOOSE = 2 Then
            LBL_COM_CHOOSE.Text = "The computer chooses Paper"
        ElseIf COM_CHOOSE = 3 Then
            LBL_COM_CHOOSE.Text = "The computer chooses Scissors"
        End If
        If Player_CHOOSE = 1 Then
            If COM_CHOOSE = 3 Then
                LBL_Won.Text = "You Have Won!"
            End If
            If COM_CHOOSE = 2 Then
                LBL_Won.Text = "You Have Lost!"
            End If
            If COM_CHOOSE = 1 Then
                LBL_Won.Text = "You Have Tied!"
            End If
        ElseIf Player_CHOOSE = 2 Then
            If COM_CHOOSE = 1 Then
                LBL_Won.Text = "You Have Won!"
            End If
            If COM_CHOOSE = 2 Then
                LBL_Won.Text = "You Have Tied!"
            End If
            If COM_CHOOSE = 3 Then
                LBL_Won.Text = "You Have Lost!"
            End If
        ElseIf Player_CHOOSE = 3 Then
            If COM_CHOOSE = 2 Then
                LBL_Won.Text = "You Have Won!"
            End If
            If COM_CHOOSE = 3 Then
                LBL_Won.Text = "You Have Tied!"
            End If
            If COM_CHOOSE = 1 Then
                LBL_Won.Text = "You Have Lost!"
            End If
        End If
    End Function
End Class