<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderForm1
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
        Me.TxbName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxbAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxbCity = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxbState = New System.Windows.Forms.TextBox()
        Me.TxbZIP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxbLarge = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxbMedium = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxbSmall = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxbTP = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxbTO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Name:"
        '
        'TxbName
        '
        Me.TxbName.Location = New System.Drawing.Point(11, 35)
        Me.TxbName.Name = "TxbName"
        Me.TxbName.Size = New System.Drawing.Size(180, 22)
        Me.TxbName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(312, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Address:"
        '
        'TxbAddress
        '
        Me.TxbAddress.Location = New System.Drawing.Point(315, 35)
        Me.TxbAddress.Name = "TxbAddress"
        Me.TxbAddress.Size = New System.Drawing.Size(207, 22)
        Me.TxbAddress.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ci&ty:"
        '
        'TxbCity
        '
        Me.TxbCity.Location = New System.Drawing.Point(11, 89)
        Me.TxbCity.Name = "TxbCity"
        Me.TxbCity.Size = New System.Drawing.Size(180, 22)
        Me.TxbCity.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(249, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "&State:"
        '
        'TxbState
        '
        Me.TxbState.Location = New System.Drawing.Point(252, 89)
        Me.TxbState.Name = "TxbState"
        Me.TxbState.Size = New System.Drawing.Size(53, 22)
        Me.TxbState.TabIndex = 7
        '
        'TxbZIP
        '
        Me.TxbZIP.Location = New System.Drawing.Point(375, 89)
        Me.TxbZIP.Name = "TxbZIP"
        Me.TxbZIP.Size = New System.Drawing.Size(102, 22)
        Me.TxbZIP.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(372, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "&ZIP:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxbLarge)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.TxbMedium)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TxbSmall)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TxbZIP)
        Me.Panel1.Controls.Add(Me.TxbState)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxbCity)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxbAddress)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxbName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(28, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(572, 190)
        Me.Panel1.TabIndex = 0
        '
        'TxbLarge
        '
        Me.TxbLarge.Location = New System.Drawing.Point(304, 142)
        Me.TxbLarge.Name = "TxbLarge"
        Me.TxbLarge.Size = New System.Drawing.Size(100, 22)
        Me.TxbLarge.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(249, 145)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 17)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "&Large:"
        '
        'TxbMedium
        '
        Me.TxbMedium.Location = New System.Drawing.Point(197, 142)
        Me.TxbMedium.Name = "TxbMedium"
        Me.TxbMedium.Size = New System.Drawing.Size(46, 22)
        Me.TxbMedium.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(130, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "M&edium:"
        '
        'TxbSmall
        '
        Me.TxbSmall.Location = New System.Drawing.Point(83, 142)
        Me.TxbSmall.Name = "TxbSmall"
        Me.TxbSmall.Size = New System.Drawing.Size(35, 22)
        Me.TxbSmall.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "S&mall:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.BtnCalc, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnPrint, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnClear, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnExit, 4, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(28, 295)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(572, 49)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'BtnCalc
        '
        Me.BtnCalc.Location = New System.Drawing.Point(3, 3)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(139, 38)
        Me.BtnCalc.TabIndex = 0
        Me.BtnCalc.Text = "&Calculate"
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(148, 3)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(141, 38)
        Me.BtnPrint.TabIndex = 1
        Me.BtnPrint.Text = "&Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(295, 3)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(144, 38)
        Me.BtnClear.TabIndex = 2
        Me.BtnClear.Text = "Clea&r"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(445, 3)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(124, 38)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "E&xit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TxbTP)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.TxbTO)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(28, 215)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(572, 63)
        Me.Panel2.TabIndex = 2
        '
        'TxbTP
        '
        Me.TxbTP.Location = New System.Drawing.Point(414, 19)
        Me.TxbTP.Name = "TxbTP"
        Me.TxbTP.Size = New System.Drawing.Size(62, 22)
        Me.TxbTP.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(325, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Total Price:"
        '
        'TxbTO
        '
        Me.TxbTO.Location = New System.Drawing.Point(118, 19)
        Me.TxbTO.Name = "TxbTO"
        Me.TxbTO.Size = New System.Drawing.Size(54, 22)
        Me.TxbTO.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Total Ordered:"
        '
        'OrderForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "OrderForm1"
        Me.Text = "Just Shirts"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxbName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxbAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxbCity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxbState As TextBox
    Friend WithEvents TxbZIP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxbMedium As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxbSmall As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnCalc As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxbTP As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxbTO As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxbLarge As TextBox
    Friend WithEvents Label10 As Label
End Class
