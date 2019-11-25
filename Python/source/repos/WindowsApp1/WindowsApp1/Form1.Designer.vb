<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRect = New System.Windows.Forms.Button()
        Me.BtnCirc = New System.Windows.Forms.Button()
        Me.BtnTriangle = New System.Windows.Forms.Button()
        Me.BtnPara = New System.Windows.Forms.Button()
        Me.LblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(606, 331)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(104, 28)
        Me.exitButton.TabIndex = 0
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Formulas"
        '
        'BtnRect
        '
        Me.BtnRect.Location = New System.Drawing.Point(606, 83)
        Me.BtnRect.Name = "BtnRect"
        Me.BtnRect.Size = New System.Drawing.Size(104, 33)
        Me.BtnRect.TabIndex = 3
        Me.BtnRect.Text = "Rectangle"
        Me.BtnRect.UseVisualStyleBackColor = True
        '
        'BtnCirc
        '
        Me.BtnCirc.Location = New System.Drawing.Point(606, 150)
        Me.BtnCirc.Name = "BtnCirc"
        Me.BtnCirc.Size = New System.Drawing.Size(104, 30)
        Me.BtnCirc.TabIndex = 4
        Me.BtnCirc.Text = "Circle"
        Me.BtnCirc.UseVisualStyleBackColor = True
        '
        'BtnTriangle
        '
        Me.BtnTriangle.Location = New System.Drawing.Point(606, 212)
        Me.BtnTriangle.Name = "BtnTriangle"
        Me.BtnTriangle.Size = New System.Drawing.Size(104, 29)
        Me.BtnTriangle.TabIndex = 5
        Me.BtnTriangle.Text = "Triangle"
        Me.BtnTriangle.UseVisualStyleBackColor = True
        '
        'BtnPara
        '
        Me.BtnPara.Location = New System.Drawing.Point(606, 272)
        Me.BtnPara.Name = "BtnPara"
        Me.BtnPara.Size = New System.Drawing.Size(104, 32)
        Me.BtnPara.TabIndex = 6
        Me.BtnPara.Text = "Parallelogram"
        Me.BtnPara.UseVisualStyleBackColor = True
        '
        'LblAnswer
        '
        Me.LblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAnswer.Location = New System.Drawing.Point(93, 131)
        Me.LblAnswer.Name = "LblAnswer"
        Me.LblAnswer.Size = New System.Drawing.Size(300, 39)
        Me.LblAnswer.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 429)
        Me.Controls.Add(Me.LblAnswer)
        Me.Controls.Add(Me.BtnPara)
        Me.Controls.Add(Me.BtnTriangle)
        Me.Controls.Add(Me.BtnCirc)
        Me.Controls.Add(Me.BtnRect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Formula Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnRect As Button
    Friend WithEvents BtnCirc As Button
    Friend WithEvents BtnTriangle As Button
    Friend WithEvents BtnPara As Button
    Friend WithEvents LblAnswer As Label
End Class
