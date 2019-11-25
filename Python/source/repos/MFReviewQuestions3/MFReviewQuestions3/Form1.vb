Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim jansales As Double = 20.0
        Dim febsales As Double = 20.34
        Dim Price As Double = 1.0
        Price += 10

        Dim Grade As String
        Select Case Grade
            Case "A"
                MsgBox("Awesome!")
            Case "B"
        End Select
    End Sub
End Class
