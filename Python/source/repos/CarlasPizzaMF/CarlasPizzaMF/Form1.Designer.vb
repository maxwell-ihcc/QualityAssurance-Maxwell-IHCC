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
        Me.LblMCTotal = New System.Windows.Forms.Label()
        Me.LblMC = New System.Windows.Forms.Label()
        Me.CBDiscount = New System.Windows.Forms.CheckBox()
        Me.TxbMamaPizza = New System.Windows.Forms.TextBox()
        Me.LblPG = New System.Windows.Forms.Label()
        Me.ChBoxMC = New System.Windows.Forms.CheckBox()
        Me.ChBoxPG = New System.Windows.Forms.CheckBox()
        Me.TxbPapaPizza = New System.Windows.Forms.TextBox()
        Me.LblCV = New System.Windows.Forms.Label()
        Me.ChBoxCV = New System.Windows.Forms.CheckBox()
        Me.TxbClassicPizza = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblPGTotal = New System.Windows.Forms.Label()
        Me.LblCVTotal = New System.Windows.Forms.Label()
        Me.LblSubTotal = New System.Windows.Forms.Label()
        Me.TxbDiscount = New System.Windows.Forms.TextBox()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblTax = New System.Windows.Forms.Label()
        Me.LblGrandTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblMCTotal
        '
        Me.LblMCTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblMCTotal.Location = New System.Drawing.Point(497, 38)
        Me.LblMCTotal.Name = "LblMCTotal"
        Me.LblMCTotal.Size = New System.Drawing.Size(106, 23)
        Me.LblMCTotal.TabIndex = 0
        '
        'LblMC
        '
        Me.LblMC.AutoSize = True
        Me.LblMC.Location = New System.Drawing.Point(87, 37)
        Me.LblMC.Name = "LblMC"
        Me.LblMC.Size = New System.Drawing.Size(32, 17)
        Me.LblMC.TabIndex = 1
        Me.LblMC.Text = "MC:"
        '
        'CBDiscount
        '
        Me.CBDiscount.AutoSize = True
        Me.CBDiscount.Location = New System.Drawing.Point(324, 195)
        Me.CBDiscount.Name = "CBDiscount"
        Me.CBDiscount.Size = New System.Drawing.Size(93, 21)
        Me.CBDiscount.TabIndex = 2
        Me.CBDiscount.Text = "Discount?"
        Me.CBDiscount.UseVisualStyleBackColor = True
        '
        'TxbMamaPizza
        '
        Me.TxbMamaPizza.Location = New System.Drawing.Point(125, 37)
        Me.TxbMamaPizza.Name = "TxbMamaPizza"
        Me.TxbMamaPizza.Size = New System.Drawing.Size(100, 22)
        Me.TxbMamaPizza.TabIndex = 3
        '
        'LblPG
        '
        Me.LblPG.AutoSize = True
        Me.LblPG.Location = New System.Drawing.Point(87, 77)
        Me.LblPG.Name = "LblPG"
        Me.LblPG.Size = New System.Drawing.Size(32, 17)
        Me.LblPG.TabIndex = 4
        Me.LblPG.Text = "PG:"
        '
        'ChBoxMC
        '
        Me.ChBoxMC.AutoSize = True
        Me.ChBoxMC.Location = New System.Drawing.Point(272, 38)
        Me.ChBoxMC.Name = "ChBoxMC"
        Me.ChBoxMC.Size = New System.Drawing.Size(147, 21)
        Me.ChBoxMC.TabIndex = 5
        Me.ChBoxMC.Text = "Gluten Free? (MC)"
        Me.ChBoxMC.UseVisualStyleBackColor = True
        '
        'ChBoxPG
        '
        Me.ChBoxPG.AutoSize = True
        Me.ChBoxPG.Location = New System.Drawing.Point(272, 76)
        Me.ChBoxPG.Name = "ChBoxPG"
        Me.ChBoxPG.Size = New System.Drawing.Size(147, 21)
        Me.ChBoxPG.TabIndex = 6
        Me.ChBoxPG.Text = "Gluten Free? (PG)"
        Me.ChBoxPG.UseVisualStyleBackColor = True
        '
        'TxbPapaPizza
        '
        Me.TxbPapaPizza.Location = New System.Drawing.Point(125, 77)
        Me.TxbPapaPizza.Name = "TxbPapaPizza"
        Me.TxbPapaPizza.Size = New System.Drawing.Size(100, 22)
        Me.TxbPapaPizza.TabIndex = 7
        '
        'LblCV
        '
        Me.LblCV.AutoSize = True
        Me.LblCV.Location = New System.Drawing.Point(87, 114)
        Me.LblCV.Name = "LblCV"
        Me.LblCV.Size = New System.Drawing.Size(30, 17)
        Me.LblCV.TabIndex = 8
        Me.LblCV.Text = "CV:"
        '
        'ChBoxCV
        '
        Me.ChBoxCV.AutoSize = True
        Me.ChBoxCV.Location = New System.Drawing.Point(272, 115)
        Me.ChBoxCV.Name = "ChBoxCV"
        Me.ChBoxCV.Size = New System.Drawing.Size(145, 21)
        Me.ChBoxCV.TabIndex = 9
        Me.ChBoxCV.Text = "Gluten Free? (CV)"
        Me.ChBoxCV.UseVisualStyleBackColor = True
        '
        'TxbClassicPizza
        '
        Me.TxbClassicPizza.Location = New System.Drawing.Point(125, 114)
        Me.TxbClassicPizza.Name = "TxbClassicPizza"
        Me.TxbClassicPizza.Size = New System.Drawing.Size(100, 22)
        Me.TxbClassicPizza.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(341, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Subtotal:"
        '
        'LblPGTotal
        '
        Me.LblPGTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblPGTotal.Location = New System.Drawing.Point(497, 76)
        Me.LblPGTotal.Name = "LblPGTotal"
        Me.LblPGTotal.Size = New System.Drawing.Size(106, 23)
        Me.LblPGTotal.TabIndex = 13
        '
        'LblCVTotal
        '
        Me.LblCVTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblCVTotal.Location = New System.Drawing.Point(497, 115)
        Me.LblCVTotal.Name = "LblCVTotal"
        Me.LblCVTotal.Size = New System.Drawing.Size(106, 23)
        Me.LblCVTotal.TabIndex = 14
        '
        'LblSubTotal
        '
        Me.LblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblSubTotal.Location = New System.Drawing.Point(497, 153)
        Me.LblSubTotal.Name = "LblSubTotal"
        Me.LblSubTotal.Size = New System.Drawing.Size(106, 23)
        Me.LblSubTotal.TabIndex = 15
        '
        'TxbDiscount
        '
        Me.TxbDiscount.Location = New System.Drawing.Point(497, 195)
        Me.TxbDiscount.Name = "TxbDiscount"
        Me.TxbDiscount.ReadOnly = True
        Me.TxbDiscount.Size = New System.Drawing.Size(106, 22)
        Me.TxbDiscount.TabIndex = 16
        '
        'BtnCalc
        '
        Me.BtnCalc.Location = New System.Drawing.Point(305, 307)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(114, 35)
        Me.BtnCalc.TabIndex = 17
        Me.BtnCalc.Text = "Calculate Total"
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(425, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(425, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Tax:"
        '
        'LblTax
        '
        Me.LblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTax.Location = New System.Drawing.Point(497, 238)
        Me.LblTax.Name = "LblTax"
        Me.LblTax.Size = New System.Drawing.Size(106, 23)
        Me.LblTax.TabIndex = 21
        '
        'LblGrandTotal
        '
        Me.LblGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblGrandTotal.Location = New System.Drawing.Point(497, 307)
        Me.LblGrandTotal.Name = "LblGrandTotal"
        Me.LblGrandTotal.Size = New System.Drawing.Size(106, 23)
        Me.LblGrandTotal.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 401)
        Me.Controls.Add(Me.LblGrandTotal)
        Me.Controls.Add(Me.LblTax)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.TxbDiscount)
        Me.Controls.Add(Me.LblSubTotal)
        Me.Controls.Add(Me.LblCVTotal)
        Me.Controls.Add(Me.LblPGTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxbClassicPizza)
        Me.Controls.Add(Me.ChBoxCV)
        Me.Controls.Add(Me.LblCV)
        Me.Controls.Add(Me.TxbPapaPizza)
        Me.Controls.Add(Me.ChBoxPG)
        Me.Controls.Add(Me.ChBoxMC)
        Me.Controls.Add(Me.LblPG)
        Me.Controls.Add(Me.TxbMamaPizza)
        Me.Controls.Add(Me.CBDiscount)
        Me.Controls.Add(Me.LblMC)
        Me.Controls.Add(Me.LblMCTotal)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblMCTotal As Label
    Friend WithEvents LblMC As Label
    Friend WithEvents CBDiscount As CheckBox
    Friend WithEvents TxbMamaPizza As TextBox
    Friend WithEvents LblPG As Label
    Friend WithEvents ChBoxMC As CheckBox
    Friend WithEvents ChBoxPG As CheckBox
    Friend WithEvents TxbPapaPizza As TextBox
    Friend WithEvents LblCV As Label
    Friend WithEvents ChBoxCV As CheckBox
    Friend WithEvents TxbClassicPizza As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LblPGTotal As Label
    Friend WithEvents LblCVTotal As Label
    Friend WithEvents LblSubTotal As Label
    Friend WithEvents TxbDiscount As TextBox
    Friend WithEvents BtnCalc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblTax As Label
    Friend WithEvents LblGrandTotal As Label
End Class
