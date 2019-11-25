Public Class MFFormula



    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub LblAnswer_Click(sender As Object, e As EventArgs) Handles LblAnswer.Click

    End Sub

    Private Sub BtnRect_Click(sender As Object, e As EventArgs) Handles BtnRect.Click
        LblAnswer.Text = "Base X Height"
        BtnRect.BackColor = Color.LawnGreen
        BtnCirc.BackColor = Control.DefaultBackColor
        BtnPara.BackColor = Control.DefaultBackColor
        BtnTri.BackColor = Control.DefaultBackColor

    End Sub

    Private Sub BtnCirc_Click(sender As Object, e As EventArgs) Handles BtnCirc.Click
        LblAnswer.Text = "Pi X Radius to the second power"
        BtnCirc.BackColor = Color.LawnGreen
        BtnRect.BackColor = Control.DefaultBackColor
        BtnTri.BackColor = Control.DefaultBackColor
        BtnPara.BackColor = Control.DefaultBackColor

    End Sub

    Private Sub BtnTri_Click(sender As Object, e As EventArgs) Handles BtnTri.Click
        LblAnswer.Text = "1/2 Base X Height"
        BtnTri.BackColor = Color.LawnGreen
        BtnRect.BackColor = Control.DefaultBackColor
        BtnCirc.BackColor = Control.DefaultBackColor
        BtnPara.BackColor = Control.DefaultBackColor

    End Sub

    Private Sub BtnPara_Click(sender As Object, e As EventArgs) Handles BtnPara.Click
        LblAnswer.Text = "Base X Height"
        BtnPara.BackColor = Color.LawnGreen
        BtnTri.BackColor = Control.DefaultBackColor
        BtnRect.BackColor = Control.DefaultBackColor
        BtnCirc.BackColor = Control.DefaultBackColor

    End Sub
End Class
