<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlowerHillMF
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
        Me.GrBNumberof = New System.Windows.Forms.GroupBox()
        Me.TxbChildren = New System.Windows.Forms.TextBox()
        Me.LblChildren = New System.Windows.Forms.Label()
        Me.TxbNights = New System.Windows.Forms.TextBox()
        Me.LblNights = New System.Windows.Forms.Label()
        Me.TxbAdults = New System.Windows.Forms.TextBox()
        Me.LblAdults = New System.Windows.Forms.Label()
        Me.TxbRooms = New System.Windows.Forms.TextBox()
        Me.LblRooms = New System.Windows.Forms.Label()
        Me.GrBCharges = New System.Windows.Forms.GroupBox()
        Me.TxbTotalDue = New System.Windows.Forms.TextBox()
        Me.TxbResortFee = New System.Windows.Forms.TextBox()
        Me.TxbTax = New System.Windows.Forms.TextBox()
        Me.TxbRoomPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblResortFee = New System.Windows.Forms.Label()
        Me.LblTax = New System.Windows.Forms.Label()
        Me.LblRoom = New System.Windows.Forms.Label()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.GrBNumberof.SuspendLayout()
        Me.GrBCharges.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrBNumberof
        '
        Me.GrBNumberof.Controls.Add(Me.TxbChildren)
        Me.GrBNumberof.Controls.Add(Me.LblChildren)
        Me.GrBNumberof.Controls.Add(Me.TxbNights)
        Me.GrBNumberof.Controls.Add(Me.LblNights)
        Me.GrBNumberof.Controls.Add(Me.TxbAdults)
        Me.GrBNumberof.Controls.Add(Me.LblAdults)
        Me.GrBNumberof.Controls.Add(Me.TxbRooms)
        Me.GrBNumberof.Controls.Add(Me.LblRooms)
        Me.GrBNumberof.Location = New System.Drawing.Point(50, 35)
        Me.GrBNumberof.Name = "GrBNumberof"
        Me.GrBNumberof.Size = New System.Drawing.Size(272, 261)
        Me.GrBNumberof.TabIndex = 0
        Me.GrBNumberof.TabStop = False
        Me.GrBNumberof.Text = "Number of"
        '
        'TxbChildren
        '
        Me.TxbChildren.Location = New System.Drawing.Point(162, 165)
        Me.TxbChildren.Name = "TxbChildren"
        Me.TxbChildren.Size = New System.Drawing.Size(54, 22)
        Me.TxbChildren.TabIndex = 7
        '
        'LblChildren
        '
        Me.LblChildren.AutoSize = True
        Me.LblChildren.Location = New System.Drawing.Point(164, 134)
        Me.LblChildren.Name = "LblChildren"
        Me.LblChildren.Size = New System.Drawing.Size(64, 17)
        Me.LblChildren.TabIndex = 6
        Me.LblChildren.Text = "&Children:"
        '
        'TxbNights
        '
        Me.TxbNights.Location = New System.Drawing.Point(162, 76)
        Me.TxbNights.Name = "TxbNights"
        Me.TxbNights.Size = New System.Drawing.Size(53, 22)
        Me.TxbNights.TabIndex = 5
        '
        'LblNights
        '
        Me.LblNights.AutoSize = True
        Me.LblNights.Location = New System.Drawing.Point(164, 49)
        Me.LblNights.Name = "LblNights"
        Me.LblNights.Size = New System.Drawing.Size(52, 17)
        Me.LblNights.TabIndex = 4
        Me.LblNights.Text = "&Nights:"
        '
        'TxbAdults
        '
        Me.TxbAdults.Location = New System.Drawing.Point(41, 165)
        Me.TxbAdults.Name = "TxbAdults"
        Me.TxbAdults.Size = New System.Drawing.Size(52, 22)
        Me.TxbAdults.TabIndex = 3
        '
        'LblAdults
        '
        Me.LblAdults.AutoSize = True
        Me.LblAdults.Location = New System.Drawing.Point(6, 134)
        Me.LblAdults.Name = "LblAdults"
        Me.LblAdults.Size = New System.Drawing.Size(89, 17)
        Me.LblAdults.TabIndex = 2
        Me.LblAdults.Text = "&Adults (18+):"
        '
        'TxbRooms
        '
        Me.TxbRooms.Location = New System.Drawing.Point(43, 76)
        Me.TxbRooms.Name = "TxbRooms"
        Me.TxbRooms.Size = New System.Drawing.Size(51, 22)
        Me.TxbRooms.TabIndex = 1
        '
        'LblRooms
        '
        Me.LblRooms.AutoSize = True
        Me.LblRooms.Location = New System.Drawing.Point(39, 49)
        Me.LblRooms.Name = "LblRooms"
        Me.LblRooms.Size = New System.Drawing.Size(56, 17)
        Me.LblRooms.TabIndex = 0
        Me.LblRooms.Text = "&Rooms:"
        '
        'GrBCharges
        '
        Me.GrBCharges.Controls.Add(Me.TxbTotalDue)
        Me.GrBCharges.Controls.Add(Me.TxbResortFee)
        Me.GrBCharges.Controls.Add(Me.TxbTax)
        Me.GrBCharges.Controls.Add(Me.TxbRoomPrice)
        Me.GrBCharges.Controls.Add(Me.Label1)
        Me.GrBCharges.Controls.Add(Me.LblResortFee)
        Me.GrBCharges.Controls.Add(Me.LblTax)
        Me.GrBCharges.Controls.Add(Me.LblRoom)
        Me.GrBCharges.Location = New System.Drawing.Point(380, 35)
        Me.GrBCharges.Name = "GrBCharges"
        Me.GrBCharges.Size = New System.Drawing.Size(326, 260)
        Me.GrBCharges.TabIndex = 1
        Me.GrBCharges.TabStop = False
        Me.GrBCharges.Text = "Charges"
        '
        'TxbTotalDue
        '
        Me.TxbTotalDue.Location = New System.Drawing.Point(100, 153)
        Me.TxbTotalDue.Name = "TxbTotalDue"
        Me.TxbTotalDue.Size = New System.Drawing.Size(84, 22)
        Me.TxbTotalDue.TabIndex = 7
        '
        'TxbResortFee
        '
        Me.TxbResortFee.Location = New System.Drawing.Point(100, 114)
        Me.TxbResortFee.Name = "TxbResortFee"
        Me.TxbResortFee.Size = New System.Drawing.Size(84, 22)
        Me.TxbResortFee.TabIndex = 6
        '
        'TxbTax
        '
        Me.TxbTax.Location = New System.Drawing.Point(100, 81)
        Me.TxbTax.Name = "TxbTax"
        Me.TxbTax.Size = New System.Drawing.Size(84, 22)
        Me.TxbTax.TabIndex = 5
        '
        'TxbRoomPrice
        '
        Me.TxbRoomPrice.Location = New System.Drawing.Point(100, 49)
        Me.TxbRoomPrice.Name = "TxbRoomPrice"
        Me.TxbRoomPrice.Size = New System.Drawing.Size(84, 22)
        Me.TxbRoomPrice.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "To&tal due:"
        '
        'LblResortFee
        '
        Me.LblResortFee.AutoSize = True
        Me.LblResortFee.Location = New System.Drawing.Point(15, 114)
        Me.LblResortFee.Name = "LblResortFee"
        Me.LblResortFee.Size = New System.Drawing.Size(78, 17)
        Me.LblResortFee.TabIndex = 2
        Me.LblResortFee.Text = "Re&sort fee:"
        '
        'LblTax
        '
        Me.LblTax.AutoSize = True
        Me.LblTax.Location = New System.Drawing.Point(62, 81)
        Me.LblTax.Name = "LblTax"
        Me.LblTax.Size = New System.Drawing.Size(35, 17)
        Me.LblTax.TabIndex = 1
        Me.LblTax.Text = "Ta&x:"
        '
        'LblRoom
        '
        Me.LblRoom.AutoSize = True
        Me.LblRoom.Location = New System.Drawing.Point(48, 49)
        Me.LblRoom.Name = "LblRoom"
        Me.LblRoom.Size = New System.Drawing.Size(49, 17)
        Me.LblRoom.TabIndex = 0
        Me.LblRoom.Text = "R&oom:"
        '
        'BtnCalc
        '
        Me.BtnCalc.Location = New System.Drawing.Point(220, 324)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(102, 31)
        Me.BtnCalc.TabIndex = 2
        Me.BtnCalc.Text = "Ca&lculate"
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(377, 324)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(96, 31)
        Me.BtnClear.TabIndex = 3
        Me.BtnClear.Text = "Cl&ear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(535, 324)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(98, 31)
        Me.BtnExit.TabIndex = 4
        Me.BtnExit.Text = "Ex&it"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'FlowerHillMF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 381)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.GrBCharges)
        Me.Controls.Add(Me.GrBNumberof)
        Me.Name = "FlowerHillMF"
        Me.Text = "Flowerhill Resort"
        Me.GrBNumberof.ResumeLayout(False)
        Me.GrBNumberof.PerformLayout()
        Me.GrBCharges.ResumeLayout(False)
        Me.GrBCharges.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GrBNumberof As GroupBox
    Friend WithEvents TxbChildren As TextBox
    Friend WithEvents LblChildren As Label
    Friend WithEvents TxbNights As TextBox
    Friend WithEvents LblNights As Label
    Friend WithEvents TxbAdults As TextBox
    Friend WithEvents LblAdults As Label
    Friend WithEvents TxbRooms As TextBox
    Friend WithEvents LblRooms As Label
    Friend WithEvents GrBCharges As GroupBox
    Friend WithEvents LblRoom As Label
    Friend WithEvents LblTax As Label
    Friend WithEvents TxbResortFee As TextBox
    Friend WithEvents TxbTax As TextBox
    Friend WithEvents TxbRoomPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblResortFee As Label
    Friend WithEvents TxbTotalDue As TextBox
    Friend WithEvents BtnCalc As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnExit As Button
End Class
