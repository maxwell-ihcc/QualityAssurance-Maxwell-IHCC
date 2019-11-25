Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AgeCalc_Click(sender As Object, e As EventArgs) Handles AgeCalc.Click
        Dim accumAges As Integer = 0
        Dim Age As Integer = 1
        Dim Name As String = " "
        Do While Name <> ""
            Name = InputBox("Enter Name", "Name")
            If Name <> vbNullString Then
                Integer.TryParse(InputBox("Enter " & Name & " 's Age", "Age"), Age)
                ListBox1.Items.Add(Name & ", " & Age)
                accumAges = accumAges + Age
            End If
        Loop
        LblAges.Text = accumAges.ToString
    End Sub
End Class
