<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CLForm
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
        Me.BtnIHCC = New System.Windows.Forms.Button()
        Me.BtnPekin = New System.Windows.Forms.Button()
        Me.BtnOttumwa = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PicLogos = New System.Windows.Forms.PictureBox()
        Me.LblMascot = New System.Windows.Forms.Label()
        Me.LblCtr = New System.Windows.Forms.Label()
        Me.TxbPekinEnroll = New System.Windows.Forms.TextBox()
        Me.LblEnrollment = New System.Windows.Forms.Label()
        Me.TxbIhccEnroll = New System.Windows.Forms.TextBox()
        Me.TxbOttumwaEnroll = New System.Windows.Forms.TextBox()
        Me.LblTotalEnroll = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        CType(Me.PicLogos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnIHCC
        '
        Me.BtnIHCC.Location = New System.Drawing.Point(51, 312)
        Me.BtnIHCC.Name = "BtnIHCC"
        Me.BtnIHCC.Size = New System.Drawing.Size(81, 39)
        Me.BtnIHCC.TabIndex = 0
        Me.BtnIHCC.Text = "&IHCC"
        Me.BtnIHCC.UseVisualStyleBackColor = True
        '
        'BtnPekin
        '
        Me.BtnPekin.Location = New System.Drawing.Point(222, 312)
        Me.BtnPekin.Name = "BtnPekin"
        Me.BtnPekin.Size = New System.Drawing.Size(75, 39)
        Me.BtnPekin.TabIndex = 1
        Me.BtnPekin.Text = "&Pekin"
        Me.BtnPekin.UseVisualStyleBackColor = True
        '
        'BtnOttumwa
        '
        Me.BtnOttumwa.Location = New System.Drawing.Point(387, 312)
        Me.BtnOttumwa.Name = "BtnOttumwa"
        Me.BtnOttumwa.Size = New System.Drawing.Size(75, 39)
        Me.BtnOttumwa.TabIndex = 2
        Me.BtnOttumwa.Text = "&Ottumwa"
        Me.BtnOttumwa.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(210, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 15)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "COOL LOGOS"
        '
        'PicLogos
        '
        Me.PicLogos.Image = Global.MFPictureForm.My.Resources.Resources.pekin
        Me.PicLogos.Location = New System.Drawing.Point(192, 100)
        Me.PicLogos.Name = "PicLogos"
        Me.PicLogos.Size = New System.Drawing.Size(145, 87)
        Me.PicLogos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PicLogos.TabIndex = 4
        Me.PicLogos.TabStop = False
        '
        'LblMascot
        '
        Me.LblMascot.AutoSize = True
        Me.LblMascot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblMascot.Location = New System.Drawing.Point(409, 131)
        Me.LblMascot.Name = "LblMascot"
        Me.LblMascot.Size = New System.Drawing.Size(53, 19)
        Me.LblMascot.TabIndex = 5
        Me.LblMascot.Text = "Label1"
        '
        'LblCtr
        '
        Me.LblCtr.AutoSize = True
        Me.LblCtr.Location = New System.Drawing.Point(91, 131)
        Me.LblCtr.Name = "LblCtr"
        Me.LblCtr.Size = New System.Drawing.Size(16, 17)
        Me.LblCtr.TabIndex = 6
        Me.LblCtr.Text = "0"
        '
        'TxbPekinEnroll
        '
        Me.TxbPekinEnroll.Location = New System.Drawing.Point(222, 284)
        Me.TxbPekinEnroll.Name = "TxbPekinEnroll"
        Me.TxbPekinEnroll.Size = New System.Drawing.Size(75, 22)
        Me.TxbPekinEnroll.TabIndex = 7
        '
        'LblEnrollment
        '
        Me.LblEnrollment.AutoSize = True
        Me.LblEnrollment.Location = New System.Drawing.Point(224, 224)
        Me.LblEnrollment.Name = "LblEnrollment"
        Me.LblEnrollment.Size = New System.Drawing.Size(79, 17)
        Me.LblEnrollment.TabIndex = 8
        Me.LblEnrollment.Text = "Enrollment:"
        '
        'TxbIhccEnroll
        '
        Me.TxbIhccEnroll.Location = New System.Drawing.Point(51, 284)
        Me.TxbIhccEnroll.Name = "TxbIhccEnroll"
        Me.TxbIhccEnroll.Size = New System.Drawing.Size(81, 22)
        Me.TxbIhccEnroll.TabIndex = 9
        '
        'TxbOttumwaEnroll
        '
        Me.TxbOttumwaEnroll.Location = New System.Drawing.Point(387, 284)
        Me.TxbOttumwaEnroll.Name = "TxbOttumwaEnroll"
        Me.TxbOttumwaEnroll.Size = New System.Drawing.Size(77, 22)
        Me.TxbOttumwaEnroll.TabIndex = 10
        '
        'LblTotalEnroll
        '
        Me.LblTotalEnroll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTotalEnroll.Location = New System.Drawing.Point(192, 390)
        Me.LblTotalEnroll.Name = "LblTotalEnroll"
        Me.LblTotalEnroll.Size = New System.Drawing.Size(123, 32)
        Me.LblTotalEnroll.TabIndex = 11
        Me.LblTotalEnroll.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(50, 379)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 43)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "&Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(358, 390)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(105, 31)
        Me.BtnClear.TabIndex = 13
        Me.BtnClear.Text = "&Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'CLForm
        '
        Me.AcceptButton = Me.BtnIHCC
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 477)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblTotalEnroll)
        Me.Controls.Add(Me.TxbOttumwaEnroll)
        Me.Controls.Add(Me.TxbIhccEnroll)
        Me.Controls.Add(Me.LblEnrollment)
        Me.Controls.Add(Me.TxbPekinEnroll)
        Me.Controls.Add(Me.LblCtr)
        Me.Controls.Add(Me.LblMascot)
        Me.Controls.Add(Me.PicLogos)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BtnOttumwa)
        Me.Controls.Add(Me.BtnPekin)
        Me.Controls.Add(Me.BtnIHCC)
        Me.Name = "CLForm"
        Me.Text = "Cool Logos"
        CType(Me.PicLogos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnIHCC As Button
    Friend WithEvents BtnPekin As Button
    Friend WithEvents BtnOttumwa As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PicLogos As PictureBox
    Friend WithEvents LblMascot As Label
    Friend WithEvents LblCtr As Label
    Friend WithEvents TxbPekinEnroll As TextBox
    Friend WithEvents LblEnrollment As Label
    Friend WithEvents TxbIhccEnroll As TextBox
    Friend WithEvents TxbOttumwaEnroll As TextBox
    Friend WithEvents LblTotalEnroll As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnClear As Button
End Class
