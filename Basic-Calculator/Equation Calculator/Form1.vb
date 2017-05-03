Imports NCalc
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Calculate()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtEquation.Text = txtEquation.Text + "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtEquation.Text = txtEquation.Text + "2"
    End Sub
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtEquation.Text = txtEquation.Text + "3"
    End Sub
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtEquation.Text = txtEquation.Text + "4"
    End Sub
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtEquation.Text = txtEquation.Text + "5"
    End Sub
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtEquation.Text = txtEquation.Text + "6"
    End Sub
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtEquation.Text = txtEquation.Text + "7"
    End Sub
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtEquation.Text = txtEquation.Text + "8"
    End Sub
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtEquation.Text = txtEquation.Text + "9"
    End Sub
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtEquation.Text = txtEquation.Text + "0"
    End Sub
    Function Calculate()
        Try
            Dim TextBoxed As String = txtEquation.Text
            Dim Result As Expression = New Expression(TextBoxed)
            lblResult.Text = CStr(Result.Evaluate)
        Catch DBZ As DivideByZeroException
            MessageBox.Show("Cannot divide by zero", "Error")
        Catch ARGEX As System.ArgumentException
            MessageBox.Show("Please only type equations", "Error")
        Catch EXC As Exception
            MessageBox.Show("An unknown error occurred, Please try again", "Error")
        End Try
    End Function

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        Calculate()
    End Sub
    Private Sub btnAddition_Click(sender As Object, e As EventArgs) Handles btnAddition.Click
        txtEquation.Text = txtEquation.Text + "+"
    End Sub
    Private Sub btnSubtraction_Click(sender As Object, e As EventArgs) Handles btnSubtraction.Click
        txtEquation.Text = txtEquation.Text + "-"
    End Sub
    Private Sub btnMultiplication_Click(sender As Object, e As EventArgs) Handles btnMultiplication.Click
        txtEquation.Text = txtEquation.Text + "*"
    End Sub
    Private Sub bntDivision_Click(sender As Object, e As EventArgs) Handles bntDivision.Click
        txtEquation.Text = txtEquation.Text + "/"
    End Sub
    Private Sub btnParen1_Click(sender As Object, e As EventArgs) Handles btnParen1.Click
        txtEquation.Text = txtEquation.Text + ")"
    End Sub
    Private Sub btnParen2_Click(sender As Object, e As EventArgs) Handles btnParen2.Click
        txtEquation.Text = txtEquation.Text + "("
    End Sub
End Class
