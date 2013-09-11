Option Strict On

Public Class Form1

    Private Sub btnCalcBMI_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcBMI.Click

        Dim weight As Double    ' Stores the weight variable entered by the user
        Dim height As Double    ' Stores the height variable entered by the user
        Dim bmi As Double       ' Stores the bmi variable entered by the user

        weight = CDbl(txtWeight.Text)               ' Converts the text in the weight text box into a double stored in the weight variable
        height = CDbl(txtHeight.Text)               ' Converts the text in the height text box into a double stored in the weight variable
        bmi = (weight * 703) / (height ^ 2)         ' Runs the formula for calculating bmi and stores it in the bmi variable
        bmi = Math.Round(bmi, 2)                    ' Rounds the bmi variable to 2 decimal places
        TextBox1.Text = Convert.ToString(bmi)       ' Displays the bmi variable in String format in the bmi text box

    End Sub
End Class
