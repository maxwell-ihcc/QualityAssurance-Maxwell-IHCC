Public Class SunflowerResortMF
    Dim TotalRoomPrice As Double
    Dim TotalAdultPrice As Double
    Dim TotalKidPrice As Double
    Dim TotalNightPrice As Double
    Dim IRooms As Integer
    Dim IRoomMax As Integer = 6
    Dim IRoomEnteredMax As Integer
    Dim GuestTotal As Integer
    Dim INights As Integer
    Dim IAdults As Integer
    Dim IKids As Integer
    Dim CRoomRate As Decimal
    Dim CTotalRoomTaxCharge As Double
    Dim CTotalResortFee As Integer
    Dim TotalCharge As Double





    Private Sub SunflowerResortMF_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub


    Private Sub TxbRooms_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbRooms.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Integer.TryParse(TxbRooms.Text, IRooms)
        Integer.TryParse(TxbNights.Text, INights)
        Integer.TryParse(TxbAdults.Text, IAdults)
        Integer.TryParse(TxbKids.Text, IKids)
        Dim CSalesTax As Double = 0.1525
        IRoomEnteredMax = IRooms * IRoomMax
        GuestTotal = IAdults + IKids
        If (GuestTotal > IRoomEnteredMax) Then
            MsgBox("You have exceeded the maximum number of guests per room.")
        Else
            CRoomRate = IRooms * INights * 284
            CTotalRoomTaxCharge = CRoomRate * CSalesTax
            CTotalResortFee = IRooms * INights * 15
            TotalCharge = CRoomRate + CSalesTax + CTotalResortFee
            LblTotalDue.Text = TotalCharge.ToString

        End If
    End Sub

    Private Sub TxbNights_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbNights.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxbAdults_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbAdults.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub


    Private Sub TxbKids_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxbKids.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub LblTotalDue_Click(sender As Object, e As EventArgs) Handles LblTotalDue.Click

    End Sub
End Class
