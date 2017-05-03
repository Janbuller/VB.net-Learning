Public Class Form1
    Private Sub BTN_OK_Click(sender As Object, e As EventArgs) Handles BTN_OK.Click
        Try
            Dim Penge As Decimal = TXT_PENGE.Text
            Dim Fradrag As Decimal = TXT_FRADRAG.Text
            Dim Trækprocent As Decimal = (Penge - Fradrag) / 100 * TXT_TRKPCT.Text
            LBL_TILBAGE.Text = "Tilbage: " & Penge - Fradrag - Trækprocent + Fradrag
        Catch ex As System.InvalidCastException
            MessageBox.Show("Please only type numbers.", "Error")
        Catch ex As Exception
            MessageBox.Show("An unknown error occurred", "Error")
        End Try
    End Sub
End Class