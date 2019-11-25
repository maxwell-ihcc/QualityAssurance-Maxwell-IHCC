Public Class Form1
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub txbName_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BtnRect_Click() Handles BtnRect.Click
        LblAnswer.Text = "Base X Height"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LblAnswer_Click(sender As Object, e As EventArgs) Handles LblAnswer.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnTriangle_Click(sender As Object, e As EventArgs) Handles BtnTriangle.Click
        LblAnswer.Text = "1/2 Base X Height"

    End Sub

    Private Sub BtnTriangle_Click(v As Boolean)

    End Sub

    Private Sub BtnCirc_Click(sender As Object, e As EventArgs) Handles BtnCirc.Click
        LblAnswer.Text = "Pi X Radius to the second power"
    End Sub

    Private Sub BtnPara_Click(sender As Object, e As EventArgs) Handles BtnPara.Click
        LblAnswer.Text = "Base X Height"
    End Sub
End Class
