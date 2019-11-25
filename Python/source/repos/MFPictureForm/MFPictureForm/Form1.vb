Public Class CLForm
    Dim ctr As Integer = 0


    Private Sub BtnIHCC_Click(sender As Object, e As EventArgs) Handles BtnIHCC.Click
        Dim IhccMascot As String = "Warriors"
        PicLogos.Image = My.Resources.ihcc
        Me.BackColor = Color.Azure
        LblMascot.Text = IhccMascot
        LblMascot.ForeColor = Color.Black
        ctr = ctr + 1
        LblCtr.Text = ctr
        LblCtr.ForeColor = Color.Black

    End Sub

    Private Sub BtnPekin_Click(sender As Object, e As EventArgs) Handles BtnPekin.Click
        Dim PekinMascot As String = "Panthers"
        PicLogos.Image = My.Resources.pekin
        Me.BackColor = Color.Firebrick
        LblMascot.Text = PekinMascot
        LblMascot.ForeColor = Color.White
        ctr = ctr + 1
        LblCtr.Text = ctr
        LblCtr.ForeColor = Color.White
    End Sub

    Private Sub BtnOttumwa_Click(sender As Object, e As EventArgs) Handles BtnOttumwa.Click
        Dim OttumwaMascot As String = "Bulldogs"
        PicLogos.Image = My.Resources.ottumwa
        Me.BackColor = Color.Red
        LblMascot.Text = OttumwaMascot
        ctr = ctr + 1
        LblCtr.Text = ctr
        LblCtr.ForeColor = Color.Black

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub LblMascot_Click(sender As Object, e As EventArgs) Handles LblMascot.Click

    End Sub

    Private Sub LblCtr_Click(sender As Object, e As EventArgs) Handles LblCtr.Click

    End Sub

    Private Sub CLForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TxbPekinEnroll.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim IhccEnroll As Integer
        Dim PekinEnroll As Integer
        Dim OttumwaEnroll As Integer
        Dim Totalenroll As Integer
        Integer.TryParse(TxbIhccEnroll.Text, IhccEnroll)
        Integer.TryParse(TxbPekinEnroll.Text, PekinEnroll)
        Integer.TryParse(TxbOttumwaEnroll.Text, OttumwaEnroll)
        Totalenroll = IhccEnroll + PekinEnroll + OttumwaEnroll
        LblTotalEnroll.Text = Totalenroll.ToString("N20")
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Const IHCCMASCOT As String = "Warriors"
        TxbIhccEnroll.Text = String.Empty
        TxbOttumwaEnroll.Text = String.Empty
        TxbPekinEnroll.Text = String.Empty
        LblCtr.Text = "0"
        ctr = 0

    End Sub
End Class
