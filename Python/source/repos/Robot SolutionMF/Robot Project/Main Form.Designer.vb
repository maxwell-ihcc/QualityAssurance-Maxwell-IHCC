<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.door1PictureBox = New System.Windows.Forms.PictureBox()
        Me.door2PictureBox = New System.Windows.Forms.PictureBox()
        Me.door3PictureBox = New System.Windows.Forms.PictureBox()
        Me.openPictureBox = New System.Windows.Forms.PictureBox()
        Me.robotPictureBox = New System.Windows.Forms.PictureBox()
        Me.closedPictureBox = New System.Windows.Forms.PictureBox()
        Me.hideButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.LblCounter = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.door5PictureBox = New System.Windows.Forms.PictureBox()
        Me.door4PictureBox = New System.Windows.Forms.PictureBox()
        Me.door6PictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.door1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.door2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.door3PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.openPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.robotPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closedPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.door5PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.door4PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.door6PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'door1PictureBox
        '
        Me.door1PictureBox.Image = Global.Robot_Project.My.Resources.Resources.OpenDoor
        Me.door1PictureBox.Location = New System.Drawing.Point(126, 218)
        Me.door1PictureBox.Name = "door1PictureBox"
        Me.door1PictureBox.Size = New System.Drawing.Size(119, 130)
        Me.door1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.door1PictureBox.TabIndex = 0
        Me.door1PictureBox.TabStop = False
        '
        'door2PictureBox
        '
        Me.door2PictureBox.Image = Global.Robot_Project.My.Resources.Resources.Robot
        Me.door2PictureBox.Location = New System.Drawing.Point(263, 218)
        Me.door2PictureBox.Name = "door2PictureBox"
        Me.door2PictureBox.Size = New System.Drawing.Size(119, 130)
        Me.door2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.door2PictureBox.TabIndex = 1
        Me.door2PictureBox.TabStop = False
        '
        'door3PictureBox
        '
        Me.door3PictureBox.Image = Global.Robot_Project.My.Resources.Resources.OpenDoor
        Me.door3PictureBox.Location = New System.Drawing.Point(401, 218)
        Me.door3PictureBox.Name = "door3PictureBox"
        Me.door3PictureBox.Size = New System.Drawing.Size(119, 130)
        Me.door3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.door3PictureBox.TabIndex = 2
        Me.door3PictureBox.TabStop = False
        '
        'openPictureBox
        '
        Me.openPictureBox.Image = Global.Robot_Project.My.Resources.Resources.OpenDoor
        Me.openPictureBox.Location = New System.Drawing.Point(138, 12)
        Me.openPictureBox.Name = "openPictureBox"
        Me.openPictureBox.Size = New System.Drawing.Size(119, 130)
        Me.openPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.openPictureBox.TabIndex = 3
        Me.openPictureBox.TabStop = False
        Me.openPictureBox.Visible = False
        '
        'robotPictureBox
        '
        Me.robotPictureBox.Image = Global.Robot_Project.My.Resources.Resources.Robot
        Me.robotPictureBox.Location = New System.Drawing.Point(263, 12)
        Me.robotPictureBox.Name = "robotPictureBox"
        Me.robotPictureBox.Size = New System.Drawing.Size(119, 130)
        Me.robotPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.robotPictureBox.TabIndex = 4
        Me.robotPictureBox.TabStop = False
        Me.robotPictureBox.Visible = False
        '
        'closedPictureBox
        '
        Me.closedPictureBox.Image = Global.Robot_Project.My.Resources.Resources.ClosedDoor
        Me.closedPictureBox.Location = New System.Drawing.Point(388, 12)
        Me.closedPictureBox.Name = "closedPictureBox"
        Me.closedPictureBox.Size = New System.Drawing.Size(119, 130)
        Me.closedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closedPictureBox.TabIndex = 5
        Me.closedPictureBox.TabStop = False
        Me.closedPictureBox.Visible = False
        '
        'hideButton
        '
        Me.hideButton.Location = New System.Drawing.Point(906, 14)
        Me.hideButton.Name = "hideButton"
        Me.hideButton.Size = New System.Drawing.Size(84, 37)
        Me.hideButton.TabIndex = 0
        Me.hideButton.Text = "&Hide"
        Me.hideButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(50, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(658, 40)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Click the Hide button to hide the robot. Then click the doors to find him."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(996, 14)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(84, 37)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'LblCounter
        '
        Me.LblCounter.AutoSize = True
        Me.LblCounter.Location = New System.Drawing.Point(1024, 54)
        Me.LblCounter.Name = "LblCounter"
        Me.LblCounter.Size = New System.Drawing.Size(23, 28)
        Me.LblCounter.TabIndex = 6
        Me.LblCounter.Text = "0"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(886, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 28)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "# Of Guesses:"
        '
        'door5PictureBox
        '
        Me.door5PictureBox.Image = Global.Robot_Project.My.Resources.Resources.OpenDoor
        Me.door5PictureBox.Location = New System.Drawing.Point(681, 218)
        Me.door5PictureBox.Name = "door5PictureBox"
        Me.door5PictureBox.Size = New System.Drawing.Size(119, 130)
        Me.door5PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.door5PictureBox.TabIndex = 8
        Me.door5PictureBox.TabStop = False
        '
        'door4PictureBox
        '
        Me.door4PictureBox.Image = Global.Robot_Project.My.Resources.Resources.OpenDoor
        Me.door4PictureBox.Location = New System.Drawing.Point(539, 218)
        Me.door4PictureBox.Name = "door4PictureBox"
        Me.door4PictureBox.Size = New System.Drawing.Size(119, 130)
        Me.door4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.door4PictureBox.TabIndex = 9
        Me.door4PictureBox.TabStop = False
        '
        'door6PictureBox
        '
        Me.door6PictureBox.Image = Global.Robot_Project.My.Resources.Resources.OpenDoor
        Me.door6PictureBox.Location = New System.Drawing.Point(832, 219)
        Me.door6PictureBox.Name = "door6PictureBox"
        Me.door6PictureBox.Size = New System.Drawing.Size(107, 130)
        Me.door6PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.door6PictureBox.TabIndex = 10
        Me.door6PictureBox.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Robot_Project.My.Resources.Resources.Room
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1086, 465)
        Me.Controls.Add(Me.door6PictureBox)
        Me.Controls.Add(Me.door4PictureBox)
        Me.Controls.Add(Me.door5PictureBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblCounter)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hideButton)
        Me.Controls.Add(Me.closedPictureBox)
        Me.Controls.Add(Me.robotPictureBox)
        Me.Controls.Add(Me.openPictureBox)
        Me.Controls.Add(Me.door3PictureBox)
        Me.Controls.Add(Me.door2PictureBox)
        Me.Controls.Add(Me.door1PictureBox)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find the Robot"
        CType(Me.door1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.door2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.door3PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.openPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.robotPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closedPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.door5PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.door4PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.door6PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents door1PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents door2PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents door3PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents openPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents robotPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents closedPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents hideButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents LblCounter As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents door5PictureBox As PictureBox
    Friend WithEvents door4PictureBox As PictureBox
    Friend WithEvents door6PictureBox As PictureBox
End Class
