Public Class FlowerHillMF


    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxbChildren.Clear()
        TxbNights.Clear()
        TxbAdults.Clear()
        TxbResortFee.Clear()
        TxbRoomPrice.Clear()
        TxbRooms.Clear()
        TxbTax.Clear()
        TxbTotalDue.Clear()


    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click


        Dim IRoom As Integer
        Dim INight As Integer
        Const CROOMRATE As Double = 255.5
        Const CRESORTRATE As Double = 22.5
        Const CTAXRATE As Double = 0.1075
        Dim CTotalDue As Double
        Dim CRoomCharge As Double
        Dim CTaxCharge As Double
        Dim CResortCharge As Double
        Dim ORoomCharge As Double
        Dim OTaxCharge As Double
        Dim OResortCharge As Double
        Dim OTotalDue As Double
        Integer.TryParse(TxbRooms.Text, IRoom)
        Double.TryParse(TxbNights.Text, INight)
        CRoomCharge = INight * IRoom * CROOMRATE
        CTaxCharge = CRoomCharge * CTAXRATE
        CResortCharge = IRoom * INight * CRESORTRATE
        CTotalDue = CRoomCharge + CTaxCharge + CResortCharge
        TxbRoomPrice.Text = CRoomCharge.ToString("N2")
        TxbTax.Text = CTaxCharge.ToString("N2")
        TxbResortFee.Text = CResortCharge.ToString("N2")
        TxbTotalDue.Text = CTotalDue.ToString("C2")

    End Sub

    Private Sub TxbRooms_TextChanged(sender As Object, e As EventArgs) Handles TxbRooms.TextChanged

    End Sub

    Private Sub TxbRoomPrice_TextChanged(sender As Object, e As EventArgs) Handles TxbRoomPrice.TextChanged

    End Sub
End Class
