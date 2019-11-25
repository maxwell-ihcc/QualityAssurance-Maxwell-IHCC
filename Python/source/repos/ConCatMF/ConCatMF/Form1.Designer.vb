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
        Me.TxbFirstName = New System.Windows.Forms.TextBox()
        Me.TxbLastName = New System.Windows.Forms.TextBox()
        Me.BtnDEWIT = New System.Windows.Forms.Button()
        Me.LblResult = New System.Windows.Forms.Label()
        Me.LblResult2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxbFirstName
        '
        Me.TxbFirstName.Location = New System.Drawing.Point(122, 67)
        Me.TxbFirstName.Name = "TxbFirstName"
        Me.TxbFirstName.Size = New System.Drawing.Size(100, 22)
        Me.TxbFirstName.TabIndex = 0
        '
        'TxbLastName
        '
        Me.TxbLastName.Location = New System.Drawing.Point(554, 67)
        Me.TxbLastName.Name = "TxbLastName"
        Me.TxbLastName.Size = New System.Drawing.Size(100, 22)
        Me.TxbLastName.TabIndex = 1
        '
        'BtnDEWIT
        '
        Me.BtnDEWIT.Location = New System.Drawing.Point(329, 120)
        Me.BtnDEWIT.Name = "BtnDEWIT"
        Me.BtnDEWIT.Size = New System.Drawing.Size(114, 35)
        Me.BtnDEWIT.TabIndex = 2
        Me.BtnDEWIT.Text = "&Do It!"
        Me.BtnDEWIT.UseVisualStyleBackColor = True
        '
        'LblResult
        '
        Me.LblResult.AutoSize = True
        Me.LblResult.Location = New System.Drawing.Point(160, 245)
        Me.LblResult.Name = "LblResult"
        Me.LblResult.Size = New System.Drawing.Size(51, 17)
        Me.LblResult.TabIndex = 3
        Me.LblResult.Text = "Label1"
        '
        'LblResult2
        '
        Me.LblResult2.AutoSize = True
        Me.LblResult2.Location = New System.Drawing.Point(554, 245)
        Me.LblResult2.Name = "LblResult2"
        Me.LblResult2.Size = New System.Drawing.Size(51, 17)
        Me.LblResult2.TabIndex = 4
        Me.LblResult2.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblResult2)
        Me.Controls.Add(Me.LblResult)
        Me.Controls.Add(Me.BtnDEWIT)
        Me.Controls.Add(Me.TxbLastName)
        Me.Controls.Add(Me.TxbFirstName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxbFirstName As TextBox
    Friend WithEvents TxbLastName As TextBox
    Friend WithEvents BtnDEWIT As Button
    Friend WithEvents LblResult As Label
    Friend WithEvents LblResult2 As Label
End Class
