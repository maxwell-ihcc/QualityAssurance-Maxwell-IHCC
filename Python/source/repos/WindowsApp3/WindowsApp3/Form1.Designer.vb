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
        Me.TxbBox = New System.Windows.Forms.TextBox()
        Me.LblLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxbBox
        '
        Me.TxbBox.Location = New System.Drawing.Point(348, 86)
        Me.TxbBox.Name = "TxbBox"
        Me.TxbBox.Size = New System.Drawing.Size(100, 22)
        Me.TxbBox.TabIndex = 0
        '
        'LblLabel
        '
        Me.LblLabel.AutoSize = True
        Me.LblLabel.Location = New System.Drawing.Point(274, 203)
        Me.LblLabel.Name = "LblLabel"
        Me.LblLabel.Size = New System.Drawing.Size(51, 17)
        Me.LblLabel.TabIndex = 1
        Me.LblLabel.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblLabel)
        Me.Controls.Add(Me.TxbBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxbBox As TextBox
    Friend WithEvents LblLabel As Label
End Class
