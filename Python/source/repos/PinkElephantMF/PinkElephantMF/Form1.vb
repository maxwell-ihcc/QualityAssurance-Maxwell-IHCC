Public Class PinkElephantMF
    Private Sub TxbQuarterlySales_TextChanged(sender As Object, e As EventArgs) Handles TxbQuarterlySales.TextChanged

    End Sub

    Private Sub PinkElephantMF_Load(sender As Object, e As EventArgs) Handles Me.Load
        TxbQuarterlySales.Focus()
        'ignore me pls'
    End Sub

    Private Sub LblTotalsalestax_Click(sender As Object, e As EventArgs) Handles LblTotalsalestax.Click

    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        Dim Quarterlysales As Double
        Const StateSalesTax As Double = 0.025
        Const CountySalesTax As Double = 0.005
        Const CitySalesTax As Double = 0.0025
        'Constant used to shortcut decimal multiplication for taxes'
        Dim StateTotal As Double
        Dim CountyTotal As Double
        Dim CityTotal As Double
        Dim TotalDue As Double
        'Setting variables for multiplication results'
        Double.TryParse(LblAtotalsalestax.Text, TotalDue)
        Double.TryParse(TxbQuarterlySales.Text, Quarterlysales)
        'joining two variables together'
        StateTotal = Quarterlysales * StateSalesTax
        CountyTotal = Quarterlysales * CountySalesTax
        CityTotal = Quarterlysales * CitySalesTax
        TotalDue = Quarterlysales + StateTotal + CountyTotal + CityTotal
        'Some Math here'
        LblAstatesalestax.Text = StateTotal.ToString("C2")
        LblAcountysalestax.Text = CountyTotal.ToString("C2")
        LblAcitysalestax.Text = CityTotal.ToString("C2")
        LblAtotalsalestax.Text = TotalDue.ToString("C2")
        'Setting Labels to display the results as Currency'
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxbQuarterlySales.Clear()
        LblAcitysalestax.ResetText()
        LblAcountysalestax.ResetText()
        LblAstatesalestax.ResetText()
        LblAtotalsalestax.ResetText()

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()
    End Sub
End Class
