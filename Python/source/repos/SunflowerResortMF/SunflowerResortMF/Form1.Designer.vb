<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SunflowerResortMF
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
        Me.LBLRooms = New System.Windows.Forms.Label()
        Me.TxbRooms = New System.Windows.Forms.TextBox()
        Me.LblNights = New System.Windows.Forms.Label()
        Me.TxbNights = New System.Windows.Forms.TextBox()
        Me.LblAdults = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxbAdults = New System.Windows.Forms.TextBox()
        Me.TxbKids = New System.Windows.Forms.TextBox()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.LblTotalDue = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBLRooms
        '
        Me.LBLRooms.AutoSize = True
        Me.LBLRooms.Location = New System.Drawing.Point(43, 47)
        Me.LBLRooms.Name = "LBLRooms"
        Me.LBLRooms.Size = New System.Drawing.Size(56, 17)
        Me.LBLRooms.TabIndex = 0
        Me.LBLRooms.Text = "Rooms:"
        '
        'TxbRooms
        '
        Me.TxbRooms.Location = New System.Drawing.Point(105, 44)
        Me.TxbRooms.Name = "TxbRooms"
        Me.TxbRooms.Size = New System.Drawing.Size(100, 22)
        Me.TxbRooms.TabIndex = 1
        '
        'LblNights
        '
        Me.LblNights.AutoSize = True
        Me.LblNights.Location = New System.Drawing.Point(244, 47)
        Me.LblNights.Name = "LblNights"
        Me.LblNights.Size = New System.Drawing.Size(52, 17)
        Me.LblNights.TabIndex = 2
        Me.LblNights.Text = "Nights:"
        '
        'TxbNights
        '
        Me.TxbNights.Location = New System.Drawing.Point(301, 44)
        Me.TxbNights.Name = "TxbNights"
        Me.TxbNights.Size = New System.Drawing.Size(100, 22)
        Me.TxbNights.TabIndex = 3
        '
        'LblAdults
        '
        Me.LblAdults.AutoSize = True
        Me.LblAdults.Location = New System.Drawing.Point(46, 105)
        Me.LblAdults.Name = "LblAdults"
        Me.LblAdults.Size = New System.Drawing.Size(51, 17)
        Me.LblAdults.TabIndex = 4
        Me.LblAdults.Text = "Adults:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Kids:"
        '
        'TxbAdults
        '
        Me.TxbAdults.Location = New System.Drawing.Point(103, 105)
        Me.TxbAdults.Name = "TxbAdults"
        Me.TxbAdults.Size = New System.Drawing.Size(100, 22)
        Me.TxbAdults.TabIndex = 6
        '
        'TxbKids
        '
        Me.TxbKids.Location = New System.Drawing.Point(301, 105)
        Me.TxbKids.Name = "TxbKids"
        Me.TxbKids.Size = New System.Drawing.Size(100, 22)
        Me.TxbKids.TabIndex = 7
        '
        'BtnCalc
        '
        Me.BtnCalc.Location = New System.Drawing.Point(125, 206)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(80, 33)
        Me.BtnCalc.TabIndex = 9
        Me.BtnCalc.Text = "Calc"
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'LblTotalDue
        '
        Me.LblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTotalDue.Location = New System.Drawing.Point(503, 188)
        Me.LblTotalDue.Name = "LblTotalDue"
        Me.LblTotalDue.Size = New System.Drawing.Size(100, 23)
        Me.LblTotalDue.TabIndex = 10
        '
        'SunflowerResortMF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblTotalDue)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.TxbKids)
        Me.Controls.Add(Me.TxbAdults)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblAdults)
        Me.Controls.Add(Me.TxbNights)
        Me.Controls.Add(Me.LblNights)
        Me.Controls.Add(Me.TxbRooms)
        Me.Controls.Add(Me.LBLRooms)
        Me.Name = "SunflowerResortMF"
        Me.Text = "Sunflower Resort"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLRooms As Label
    Friend WithEvents TxbRooms As TextBox
    Friend WithEvents LblNights As Label
    Friend WithEvents TxbNights As TextBox
    Friend WithEvents LblAdults As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxbAdults As TextBox
    Friend WithEvents TxbKids As TextBox
    Friend WithEvents BtnCalc As Button
    Friend WithEvents LblTotalDue As Label
End Class
