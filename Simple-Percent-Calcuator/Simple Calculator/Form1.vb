Public Class SMPLPCTCALC
    Private Sub BTN_Calc1_Click(sender As Object, e As EventArgs) Handles BTN_Calc1.Click
        Try
            LBL_Result1.Text = TXT_Plus1.Text + (TXT_Plus1.Text / 100) * TXT_Plus2.Text
        Catch ex As System.InvalidCastException
            MessageBox.Show("Please only type numbers!", "Error!")
        Catch ex As OverflowException
            MessageBox.Show("Please don't use that many numbers!", "Error")
        Catch ex As Exception
            MessageBox.Show("An unknown error occurred", "Error!")
        End Try
    End Sub
    Private Sub BTN_Calc2_Click(sender As Object, e As EventArgs) Handles BTN_Calc2.Click
        Try
            LBL_Result2.Text = TXT_Minus1.Text - (TXT_Minus1.Text / 100) * TXT_Minus2.Text
        Catch ex As System.InvalidCastException
            MessageBox.Show("Please only type numbers!", "Error!")
        Catch ex As OverflowException
            MessageBox.Show("Please don't use that many numbers!", "Error")
        Catch ex As Exception
            MessageBox.Show("An unknown error occurred", "Error!")
        End Try
    End Sub
    Private Sub BTN_Calc3_Click(sender As Object, e As EventArgs) Handles BTN_Calc3.Click
        Try
            LBL_Result3.Text = (TXT_Between1.Text / TXT_Between2.Text) * 100 & "%"
        Catch ex As System.InvalidCastException
            MessageBox.Show("Please only type numbers!", "Error!")
        Catch ex As OverflowException
            MessageBox.Show("Please don't use that many numbers!", "Error")
        Catch ex As Exception
            MessageBox.Show("An unknown error occurred", "Error!")
        End Try
    End Sub
End Class
