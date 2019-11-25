' Project name:         RockPaperScissors Project
' Project purpose:      Simulates the Rock, Paper, Scissors game
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub playerRockPictureBox_Click(sender As Object, e As EventArgs) Handles playerRockPictureBox.Click
        ' Determines the winner or a tie game

        Dim randGen As New Random
        Dim computerChoice As Integer

        ' Display the players choice
        playerPictureBox.Image = playerRockPictureBox.Image

        ' Generate a random integer from 1 to 4
        computerChoice = randGen.Next(1, 4)
        ' Display the Computer's choice and the outcome
        Select Case computerChoice
            Case 1
                computerPictureBox.Image = computerRockPictureBox.Image
                winnerLabel.Text = "It's a tie."
            Case 2
                computerPictureBox.Image = computerPaperPictureBox.Image
                winnerLabel.Text = "Computer wins because paper covers rock."
            Case 3
                computerPictureBox.Image = computerScissorsPictureBox.Image
                winnerLabel.Text = "Player wins because rock breaks scissors"
        End Select
    End Sub

    Private Sub playerPaperPictureBox_Click(sender As Object, e As EventArgs) Handles playerPaperPictureBox.Click
        ' Determines the winner or a tie game

        Dim randGen As New Random
        Dim computerChoice As Integer

        ' Display the players choice
        playerPictureBox.Image = playerPaperPictureBox.Image

        ' Generate a random integer from 1 to 4
        computerChoice = randGen.Next(1, 4)
        ' Display the Computer's choice and the outcome
        Select Case computerChoice
            Case 1
                computerPictureBox.Image = computerRockPictureBox.Image
                winnerLabel.Text = "Player wins because paper covers rock"
            Case 2
                computerPictureBox.Image = computerPaperPictureBox.Image
                winnerLabel.Text = "It's a tie"
            Case 3
                computerPictureBox.Image = computerScissorsPictureBox.Image
                winnerLabel.Text = "Computer wins because scissors cuts paper"
        End Select
    End Sub

    Private Sub playerScissorsPictureBox_Click(sender As Object, e As EventArgs) Handles playerScissorsPictureBox.Click
        ' Determines the winner or a tie game

        Dim randGen As New Random
        Dim computerChoice As Integer

        ' Display the players choice
        playerPictureBox.Image = playerScissorsPictureBox.Image

        ' Generate a random integer from 1 to 4
        computerChoice = randGen.Next(1, 4)
        ' Display the Computer's choice and the outcome
        Select Case computerChoice
            Case 1
                computerPictureBox.Image = computerRockPictureBox.Image
                winnerLabel.Text = "Computer wins because rock breaks scissors."
            Case 2
                computerPictureBox.Image = computerPaperPictureBox.Image
                winnerLabel.Text = "Player wins because scissors cuts paper."
            Case 3
                computerPictureBox.Image = computerScissorsPictureBox.Image
                winnerLabel.Text = "It's a tie."
        End Select
    End Sub
End Class
