Public Class FRM_Difficulty
    Private Sub BTN_Normal_Click(sender As Object, e As EventArgs) Handles BTN_Normal.Click
        FRM_Normal.Impossible = 0
        FRM_Normal.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_Impossible_Click(sender As Object, e As EventArgs) Handles BTN_Impossible.Click
        FRM_Normal.Impossible = 1
        FRM_Normal.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_Hard_Click(sender As Object, e As EventArgs) Handles BTN_Hard.Click
        FRM_Normal.Impossible = 2
        FRM_Normal.Show()
        Me.Hide()
    End Sub
End Class