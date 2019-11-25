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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.AgeCalc = New System.Windows.Forms.Button()
        Me.LblAges = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Ages:"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(369, 39)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(160, 148)
        Me.ListBox1.TabIndex = 1
        '
        'AgeCalc
        '
        Me.AgeCalc.Location = New System.Drawing.Point(150, 173)
        Me.AgeCalc.Name = "AgeCalc"
        Me.AgeCalc.Size = New System.Drawing.Size(96, 32)
        Me.AgeCalc.TabIndex = 2
        Me.AgeCalc.Text = "Add Ages:"
        Me.AgeCalc.UseVisualStyleBackColor = True
        '
        'LblAges
        '
        Me.LblAges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblAges.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblAges.Location = New System.Drawing.Point(108, 103)
        Me.LblAges.Name = "LblAges"
        Me.LblAges.Size = New System.Drawing.Size(100, 23)
        Me.LblAges.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblAges)
        Me.Controls.Add(Me.AgeCalc)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents AgeCalc As Button
    Friend WithEvents LblAges As Label
End Class
