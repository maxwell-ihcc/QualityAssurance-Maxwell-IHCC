Public Class Form1
    Private Sub BtnDEWIT_Click(sender As Object, e As EventArgs) Handles BtnDEWIT.Click
        TxbFirstName.Text = TxbFirstName.Text.ToUpper
        TxbLastName.Text = TxbLastName.Text.ToUpper
        If TxbFirstName.Text = TxbLastName.Text Then


            MsgBox("They Match")

            MsgBox("They Do Not Match")
        End If
    End Sub
End Class
