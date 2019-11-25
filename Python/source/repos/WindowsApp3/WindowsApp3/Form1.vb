Public Class Form1


    Private Sub TxbBox_TextChanged(sender As Object, e As EventArgs) Handles TxbBox.TextChanged

    End Sub

    Private Sub LblLabel_Click(sender As Object, e As EventArgs) Handles LblLabel.Click
        LblLabel.Text = "city" & ", " & "state"
    End Sub
End Class
