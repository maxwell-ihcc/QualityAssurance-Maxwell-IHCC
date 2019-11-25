Public Class Form1
    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim aug1 As Double
        Dim aug2 As Double
        Dim zeroind As Boolean = False
        Dim answerdiv As Double
        Dim answermod As Double
        Dim answerintdiv As Double
        Double.TryParse(TxbAug1.Text, aug1)
        Double.TryParse(TxbAug2.Text, aug2)
        If (aug1 = 0) Then
            MsgBox("Dont even think about dividing by zero, you don't know the consequences of doing so..(Change First Value)")
            zeroind = True
        End If
        If (aug2 = 0) Then
            MsgBox("Dont even think about dividing by zero, you don't know the consequences of doing so..(Change Second Value)")
            zeroind = True
        End If
        If (zeroind) Then
            MsgBox("Cannot perform calculation")
        Else
            answerdiv = aug1 / aug2
            answermod = aug1 Mod aug2
            answerintdiv = aug1 \ aug2
            LblDivision.Text = Convert.ToString(answerdiv)
            LblMod.Text = Convert.ToString(answermod)
            LblIntDivision.Text = Convert.ToString(answerintdiv)
        End If
    End Sub
End Class
