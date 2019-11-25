<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PinkElephantMF
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
        Me.LblQuarterlySales = New System.Windows.Forms.Label()
        Me.TxbQuarterlySales = New System.Windows.Forms.TextBox()
        Me.LblStateTax = New System.Windows.Forms.Label()
        Me.LblCountysalestax = New System.Windows.Forms.Label()
        Me.LblCitysalestax = New System.Windows.Forms.Label()
        Me.LblTotalsalestax = New System.Windows.Forms.Label()
        Me.LblAstatesalestax = New System.Windows.Forms.Label()
        Me.LblAcountysalestax = New System.Windows.Forms.Label()
        Me.LblAcitysalestax = New System.Windows.Forms.Label()
        Me.LblAtotalsalestax = New System.Windows.Forms.Label()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblQuarterlySales
        '
        Me.LblQuarterlySales.AutoSize = True
        Me.LblQuarterlySales.Location = New System.Drawing.Point(25, 22)
        Me.LblQuarterlySales.Name = "LblQuarterlySales"
        Me.LblQuarterlySales.Size = New System.Drawing.Size(108, 17)
        Me.LblQuarterlySales.TabIndex = 0
        Me.LblQuarterlySales.Text = "&Quarterly sales:"
        '
        'TxbQuarterlySales
        '
        Me.TxbQuarterlySales.Location = New System.Drawing.Point(152, 22)
        Me.TxbQuarterlySales.Name = "TxbQuarterlySales"
        Me.TxbQuarterlySales.Size = New System.Drawing.Size(100, 22)
        Me.TxbQuarterlySales.TabIndex = 1
        '
        'LblStateTax
        '
        Me.LblStateTax.AutoSize = True
        Me.LblStateTax.Location = New System.Drawing.Point(25, 65)
        Me.LblStateTax.Name = "LblStateTax"
        Me.LblStateTax.Size = New System.Drawing.Size(104, 17)
        Me.LblStateTax.TabIndex = 2
        Me.LblStateTax.Text = "State sales tax:"
        '
        'LblCountysalestax
        '
        Me.LblCountysalestax.AutoSize = True
        Me.LblCountysalestax.Location = New System.Drawing.Point(25, 108)
        Me.LblCountysalestax.Name = "LblCountysalestax"
        Me.LblCountysalestax.Size = New System.Drawing.Size(115, 17)
        Me.LblCountysalestax.TabIndex = 3
        Me.LblCountysalestax.Text = "County sales tax:"
        '
        'LblCitysalestax
        '
        Me.LblCitysalestax.AutoSize = True
        Me.LblCitysalestax.Location = New System.Drawing.Point(25, 153)
        Me.LblCitysalestax.Name = "LblCitysalestax"
        Me.LblCitysalestax.Size = New System.Drawing.Size(94, 17)
        Me.LblCitysalestax.TabIndex = 4
        Me.LblCitysalestax.Text = "City sales tax:"
        '
        'LblTotalsalestax
        '
        Me.LblTotalsalestax.AutoSize = True
        Me.LblTotalsalestax.Location = New System.Drawing.Point(25, 200)
        Me.LblTotalsalestax.Name = "LblTotalsalestax"
        Me.LblTotalsalestax.Size = New System.Drawing.Size(103, 17)
        Me.LblTotalsalestax.TabIndex = 5
        Me.LblTotalsalestax.Text = "Total sales tax:"
        '
        'LblAstatesalestax
        '
        Me.LblAstatesalestax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAstatesalestax.Location = New System.Drawing.Point(152, 64)
        Me.LblAstatesalestax.Name = "LblAstatesalestax"
        Me.LblAstatesalestax.Size = New System.Drawing.Size(132, 25)
        Me.LblAstatesalestax.TabIndex = 6
        '
        'LblAcountysalestax
        '
        Me.LblAcountysalestax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAcountysalestax.Location = New System.Drawing.Point(152, 107)
        Me.LblAcountysalestax.Name = "LblAcountysalestax"
        Me.LblAcountysalestax.Size = New System.Drawing.Size(132, 25)
        Me.LblAcountysalestax.TabIndex = 7
        '
        'LblAcitysalestax
        '
        Me.LblAcitysalestax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAcitysalestax.Location = New System.Drawing.Point(152, 152)
        Me.LblAcitysalestax.Name = "LblAcitysalestax"
        Me.LblAcitysalestax.Size = New System.Drawing.Size(132, 25)
        Me.LblAcitysalestax.TabIndex = 8
        '
        'LblAtotalsalestax
        '
        Me.LblAtotalsalestax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAtotalsalestax.Location = New System.Drawing.Point(152, 199)
        Me.LblAtotalsalestax.Name = "LblAtotalsalestax"
        Me.LblAtotalsalestax.Size = New System.Drawing.Size(132, 25)
        Me.LblAtotalsalestax.TabIndex = 9
        '
        'BtnCalc
        '
        Me.BtnCalc.Location = New System.Drawing.Point(468, 28)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(122, 37)
        Me.BtnCalc.TabIndex = 10
        Me.BtnCalc.Text = "&Calculate"
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(468, 83)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(122, 42)
        Me.BtnClear.TabIndex = 11
        Me.BtnClear.Text = "C&lear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(467, 144)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(122, 38)
        Me.BtnExit.TabIndex = 12
        Me.BtnExit.Text = "E&xit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'PinkElephantMF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 345)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.LblAtotalsalestax)
        Me.Controls.Add(Me.LblAcitysalestax)
        Me.Controls.Add(Me.LblAcountysalestax)
        Me.Controls.Add(Me.LblAstatesalestax)
        Me.Controls.Add(Me.LblTotalsalestax)
        Me.Controls.Add(Me.LblCitysalestax)
        Me.Controls.Add(Me.LblCountysalestax)
        Me.Controls.Add(Me.LblStateTax)
        Me.Controls.Add(Me.TxbQuarterlySales)
        Me.Controls.Add(Me.LblQuarterlySales)
        Me.Name = "PinkElephantMF"
        Me.Text = "Pink Elephant Photo Studio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblQuarterlySales As Label
    Friend WithEvents TxbQuarterlySales As TextBox
    Friend WithEvents LblStateTax As Label
    Friend WithEvents LblCountysalestax As Label
    Friend WithEvents LblCitysalestax As Label
    Friend WithEvents LblTotalsalestax As Label
    Friend WithEvents LblAstatesalestax As Label
    Friend WithEvents LblAcountysalestax As Label
    Friend WithEvents LblAcitysalestax As Label
    Friend WithEvents LblAtotalsalestax As Label
    Friend WithEvents BtnCalc As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnExit As Button
End Class
