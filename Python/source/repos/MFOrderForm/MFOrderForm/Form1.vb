Public Class OrderForm1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxbState.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxbName.Clear()
        TxbAddress.Clear()
        TxbCity.Clear()
        TxbState.Clear()
        TxbZIP.Clear()
        TxbSmall.Clear()
        TxbMedium.Clear()
        TxbLarge.Clear()
        TxbTO.Clear()
        TxbTP.Clear()

    End Sub

    Private Sub OrderForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
