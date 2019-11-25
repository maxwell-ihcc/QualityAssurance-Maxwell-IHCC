<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TxbAug1 = New System.Windows.Forms.TextBox()
        Me.TxbAug2 = New System.Windows.Forms.TextBox()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.LblDivision = New System.Windows.Forms.Label()
        Me.LblMod = New System.Windows.Forms.Label()
        Me.LblIntDivision = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxbAug1
        '
        Me.TxbAug1.Location = New System.Drawing.Point(84, 39)
        Me.TxbAug1.Name = "TxbAug1"
        Me.TxbAug1.Size = New System.Drawing.Size(128, 22)
        Me.TxbAug1.TabIndex = 0
        '
        'TxbAug2
        '
        Me.TxbAug2.Location = New System.Drawing.Point(485, 38)
        Me.TxbAug2.Name = "TxbAug2"
        Me.TxbAug2.Size = New System.Drawing.Size(154, 22)
        Me.TxbAug2.TabIndex = 1
        '
        'BtnCalc
        '
        Me.BtnCalc.Location = New System.Drawing.Point(312, 37)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(90, 24)
        Me.BtnCalc.TabIndex = 2
        Me.BtnCalc.Text = "Calculate"
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'LblDivision
        '
        Me.LblDivision.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblDivision.Location = New System.Drawing.Point(88, 100)
        Me.LblDivision.Name = "LblDivision"
        Me.LblDivision.Size = New System.Drawing.Size(124, 24)
        Me.LblDivision.TabIndex = 3
        '
        'LblMod
        '
        Me.LblMod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblMod.Location = New System.Drawing.Point(296, 100)
        Me.LblMod.Name = "LblMod"
        Me.LblMod.Size = New System.Drawing.Size(106, 24)
        Me.LblMod.TabIndex = 4
        '
        'LblIntDivision
        '
        Me.LblIntDivision.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblIntDivision.Location = New System.Drawing.Point(485, 100)
        Me.LblIntDivision.Name = "LblIntDivision"
        Me.LblIntDivision.Size = New System.Drawing.Size(120, 24)
        Me.LblIntDivision.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblIntDivision)
        Me.Controls.Add(Me.LblMod)
        Me.Controls.Add(Me.LblDivision)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.TxbAug2)
        Me.Controls.Add(Me.TxbAug1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxbAug1 As TextBox
    Friend WithEvents TxbAug2 As TextBox
    Friend WithEvents BtnCalc As Button
    Friend WithEvents LblDivision As Label
    Friend WithEvents LblMod As Label
    Friend WithEvents LblIntDivision As Label
End Class
