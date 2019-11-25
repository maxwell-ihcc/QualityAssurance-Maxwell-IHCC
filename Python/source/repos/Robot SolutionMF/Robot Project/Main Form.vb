' Project name:         Robot Project
' Project purpose:      Guess where a robot is hiding
' Created/revised by:   Maxwell Floyd on 10/10/2018


Public Class MainForm

    ' class-level variable 
    Dim Ctr As Integer = 0
    Private randomInteger As Integer

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub hideButton_Click(sender As Object, e As EventArgs) Handles hideButton.Click
        ' prepares the interface
        Ctr = 0
        LblCounter.Text = Ctr

        Dim randGen As New Random
        ' generate a random integer from 1 through 3
        randomInteger = randGen.Next(1, 7)
        ' display the closed door image
        door1PictureBox.Image = closedPictureBox.Image
        door2PictureBox.Image = closedPictureBox.Image
        door3PictureBox.Image = closedPictureBox.Image
        door4PictureBox.Image = closedPictureBox.Image
        door5PictureBox.Image = closedPictureBox.Image
        door6PictureBox.Image = closedPictureBox.Image
        door1PictureBox.Enabled = True
        door2PictureBox.Enabled = True
        door3PictureBox.Enabled = True
        door4PictureBox.Enabled = True
        door5PictureBox.Enabled = True
        door6PictureBox.Enabled = True
        LblCounter.Enabled = True
        MsgBox("Good luck!")
    End Sub

    Private Sub door1PictureBox_Click(sender As Object, e As EventArgs) Handles door1PictureBox.Click
        ' displays the appropriate image
        Ctr = Ctr + 1
        LblCounter.Text = Ctr
        If randomInteger = 1 Then
            door1PictureBox.Image = robotPictureBox.Image
            door2PictureBox.Enabled = False
            door3PictureBox.Enabled = False
            door4PictureBox.Enabled = False
            door5PictureBox.Enabled = False
            door6PictureBox.Enabled = False
            door1PictureBox.Enabled = False
            MsgBox("Good job! You found the robot in " & Ctr & " tries!")
        Else
            door1PictureBox.Image = openPictureBox.Image
        End If

    End Sub

    Private Sub door2PictureBox_Click(sender As Object, e As EventArgs) Handles door2PictureBox.Click
        ' displays the appropriate image
        Ctr = Ctr + 1
        LblCounter.Text = Ctr
        If randomInteger = 2 Then
            door2PictureBox.Image = robotPictureBox.Image
            door1PictureBox.Enabled = False
            door3PictureBox.Enabled = False
            door4PictureBox.Enabled = False
            door5PictureBox.Enabled = False
            door6PictureBox.Enabled = False
            door2PictureBox.Enabled = False
            MsgBox("Good job! You found the robot in " & Ctr & " tries!")
        Else
            door2PictureBox.Image = openPictureBox.Image
        End If
    End Sub

    Private Sub door3PictureBox_Click(sender As Object, e As EventArgs) Handles door3PictureBox.Click
        ' displays the appropriate image
        Ctr = Ctr + 1
        LblCounter.Text = Ctr
        If randomInteger = 3 Then
            door3PictureBox.Image = robotPictureBox.Image
            door1PictureBox.Enabled = False
            door2PictureBox.Enabled = False
            door4PictureBox.Enabled = False
            door5PictureBox.Enabled = False
            door6PictureBox.Enabled = False
            door3PictureBox.Enabled = False
            MsgBox("Good job! You found the robot in " & Ctr & " tries!")
        Else
            door3PictureBox.Image = openPictureBox.Image
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub door4PictureBox_Click(sender As Object, e As EventArgs) Handles door4PictureBox.Click
        ' displays the appropriate image
        Ctr = Ctr + 1
        LblCounter.Text = Ctr
        If randomInteger = 4 Then
            door4PictureBox.Image = robotPictureBox.Image
            door1PictureBox.Enabled = False
            door2PictureBox.Enabled = False
            door3PictureBox.Enabled = False
            door5PictureBox.Enabled = False
            door6PictureBox.Enabled = False
            door4PictureBox.Enabled = False
            MsgBox("Good job! You found the robot in " & Ctr & " tries!")
        Else
            door4PictureBox.Image = openPictureBox.Image
        End If
    End Sub

    Private Sub door5PictureBox_Click(sender As Object, e As EventArgs) Handles door5PictureBox.Click
        ' displays the appropriate image
        Ctr = Ctr + 1
        LblCounter.Text = Ctr
        If randomInteger = 5 Then
            door5PictureBox.Image = robotPictureBox.Image
            door1PictureBox.Enabled = False
            door2PictureBox.Enabled = False
            door3PictureBox.Enabled = False
            door4PictureBox.Enabled = False
            door6PictureBox.Enabled = False
            door5PictureBox.Enabled = False
            MsgBox("Good job! You found the robot in " & Ctr & " tries!")
        Else
            door5PictureBox.Image = openPictureBox.Image
        End If
    End Sub

    Private Sub door6PictureBox_Click(sender As Object, e As EventArgs) Handles door6PictureBox.Click
        ' displays the appropriate image
        Ctr = Ctr + 1
        LblCounter.Text = Ctr
        If randomInteger = 6 Then
            door6PictureBox.Image = robotPictureBox.Image
            door1PictureBox.Enabled = False
            door2PictureBox.Enabled = False
            door3PictureBox.Enabled = False
            door4PictureBox.Enabled = False
            door5PictureBox.Enabled = False
            door6PictureBox.Enabled = False
            MsgBox("Good job! You found the robot in " & Ctr & " tries!")
        Else
            door6PictureBox.Image = openPictureBox.Image
        End If
    End Sub
End Class
