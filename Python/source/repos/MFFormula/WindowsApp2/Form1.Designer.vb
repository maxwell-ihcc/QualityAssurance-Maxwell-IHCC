<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MFFormula
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
        Me.BtnRect = New System.Windows.Forms.Button()
        Me.BtnCirc = New System.Windows.Forms.Button()
        Me.BtnTri = New System.Windows.Forms.Button()
        Me.BtnPara = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.LblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnRect
        '
        Me.BtnRect.Location = New System.Drawing.Point(632, 55)
        Me.BtnRect.Name = "BtnRect"
        Me.BtnRect.Size = New System.Drawing.Size(102, 39)
        Me.BtnRect.TabIndex = 1
        Me.BtnRect.Text = "Rectangle"
        Me.BtnRect.UseVisualStyleBackColor = True
        '
        'BtnCirc
        '
        Me.BtnCirc.Location = New System.Drawing.Point(632, 114)
        Me.BtnCirc.Name = "BtnCirc"
        Me.BtnCirc.Size = New System.Drawing.Size(102, 39)
        Me.BtnCirc.TabIndex = 2
        Me.BtnCirc.Text = "Circle"
        Me.BtnCirc.UseVisualStyleBackColor = True
        '
        'BtnTri
        '
        Me.BtnTri.Location = New System.Drawing.Point(632, 171)
        Me.BtnTri.Name = "BtnTri"
        Me.BtnTri.Size = New System.Drawing.Size(102, 37)
        Me.BtnTri.TabIndex = 3
        Me.BtnTri.Text = "Triangle"
        Me.BtnTri.UseVisualStyleBackColor = True
        '
        'BtnPara
        '
        Me.BtnPara.Location = New System.Drawing.Point(627, 225)
        Me.BtnPara.Name = "BtnPara"
        Me.BtnPara.Size = New System.Drawing.Size(106, 38)
        Me.BtnPara.TabIndex = 4
        Me.BtnPara.Text = "Parallelogram"
        Me.BtnPara.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Formulas"
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(632, 281)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(101, 41)
        Me.ExitBtn.TabIndex = 5
        Me.ExitBtn.Text = "E&xit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'LblAnswer
        '
        Me.LblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAnswer.Location = New System.Drawing.Point(63, 134)
        Me.LblAnswer.Name = "LblAnswer"
        Me.LblAnswer.Size = New System.Drawing.Size(158, 37)
        Me.LblAnswer.TabIndex = 7
        '
        'MFFormula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblAnswer)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnPara)
        Me.Controls.Add(Me.BtnTri)
        Me.Controls.Add(Me.BtnCirc)
        Me.Controls.Add(Me.BtnRect)
        Me.Name = "MFFormula"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnRect As Button
    Friend WithEvents BtnCirc As Button
    Friend WithEvents BtnTri As Button
    Friend WithEvents BtnPara As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ExitBtn As Button
    Friend WithEvents LblAnswer As Label
End Class
