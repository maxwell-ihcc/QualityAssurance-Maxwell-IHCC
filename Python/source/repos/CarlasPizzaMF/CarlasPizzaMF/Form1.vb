Public Class Form1

    Private Sub CBDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles CBDiscount.CheckedChanged
        Dim MamaPizza As Integer
        Dim PapaPizza As Integer
        If CBDiscount.Checked = True Then
            Integer.TryParse(TxbMamaPizza.Text, MamaPizza)
            Integer.TryParse(TxbPapaPizza.Text, PapaPizza)
            If MamaPizza > 0 Or PapaPizza > 0 Then
                TxbDiscount.Text = "3.00"
            Else
                TxbDiscount.Text = "0.00"
                MsgBox("Coupon is not Eligible or has expired")
            End If
        End If
    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim MamaPizza As Integer = 11.99
        Dim PapaPizza As Integer = 12.99
        Dim VeggiePizza As Integer = 9.99
        Dim TtlMamaPizza As Integer
        Dim TtlPapaPizza As Integer
        Dim TtlVeggiePizza As Integer
        Dim TtlTax As Integer
        Dim TtlSubtotal As Integer
        Dim MamaGluten As Integer = 2.0
        Dim PapaGluten As Integer = 2.0
        Dim VeggieGluten As Integer = 2.0
        Dim TtlMamaGluten As Double
        Dim TtlPapaGluten As Double
        Dim TtlVeggieGluten As Double

        Integer.TryParse(TxbMamaPizza.Text, MamaPizza)
        Integer.TryParse(TxbPapaPizza.Text, PapaPizza)
        Integer.TryParse(TxbClassicPizza.Text, VeggiePizza)
        Integer.TryParse(LblMCTotal.Text, TtlMamaPizza)
        Integer.TryParse(LblPGTotal.Text, TtlPapaPizza)
        Integer.TryParse(LblCVTotal.Text, TtlVeggiePizza)
        Integer.TryParse(TxbMamaPizza.Text, MamaGluten)
        Integer.TryParse(TxbPapaPizza.Text, PapaGluten)
        Integer.TryParse(TxbClassicPizza.Text, VeggieGluten)
        If ChBoxMC.Checked = True Then
            TtlMamaGluten = TxbMamaPizza.Text * 2.0
            TtlMamaPizza = TxbMamaPizza.Text * 11.99
            LblMCTotal.Text = TtlMamaPizza + TtlMamaGluten
        Else
            TtlMamaGluten = 0
            TtlMamaPizza = TxbMamaPizza.Text * 11.99
            LblMCTotal.Text = TtlMamaPizza
        End If
        If ChBoxPG.Checked = True Then
            TtlPapaGluten = TxbPapaPizza.Text * 2.0
            TtlPapaPizza = TxbPapaPizza.Text * 12.99
            LblPGTotal.Text = TtlPapaPizza + TtlPapaGluten
        Else
            TtlPapaGluten = 0
            TtlPapaPizza = TxbPapaPizza.Text * 12.99
            LblPGTotal.Text = TtlPapaPizza
        End If
        If ChBoxCV.Checked = True Then
            TtlVeggieGluten = TxbClassicPizza.Text * 2.0
            TtlVeggiePizza = TxbClassicPizza.Text * 9.99
            LblCVTotal.Text = TtlVeggiePizza + TtlVeggieGluten
        Else
            TtlVeggieGluten = 0
            TtlVeggiePizza = TxbClassicPizza.Text * 9.99
            LblCVTotal.Text = TtlVeggiePizza
        End If
        If CBDiscount.Checked = True Then
            LblSubTotal.Text = TtlMamaPizza + TtlMamaGluten + TtlPapaPizza + TtlPapaGluten + TtlVeggiePizza + TtlVeggieGluten - 3.0
        Else
            LblSubTotal.Text = TtlMamaPizza + TtlMamaGluten + TtlPapaPizza + TtlPapaGluten + TtlVeggiePizza + TtlVeggieGluten

        End If
        TtlSubtotal = LblSubTotal.Text
        LblTax.Text = TtlSubtotal * 0.06
        TtlTax = LblTax.Text
        LblGrandTotal.Text = TtlSubtotal + TtlTax
    End Sub

    Private Sub LblTax_Click(sender As Object, e As EventArgs) Handles LblTax.Click

    End Sub
End Class