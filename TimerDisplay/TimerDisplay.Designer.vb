<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TimerDisplay
	Inherits System.Windows.Forms.UserControl

	'UserControl1 overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.lblTimer = New System.Windows.Forms.Label()
		Me.LcdChecbox1 = New LCDCheckbox.LCDChecbox()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(23, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(42, 17)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Years"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(114, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(48, 17)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Weeks"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(181, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(39, 17)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "Days"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(251, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(44, 17)
		Me.Label4.TabIndex = 4
		Me.Label4.Text = "Hours"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(310, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(57, 17)
		Me.Label5.TabIndex = 5
		Me.Label5.Text = "Minutes"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(373, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(57, 17)
		Me.Label6.TabIndex = 6
		Me.Label6.Text = "Seconds"
		'
		'lblTimer
		'
		Me.lblTimer.BackColor = System.Drawing.Color.Transparent
		Me.lblTimer.Location = New System.Drawing.Point(0, 21)
		Me.lblTimer.Name = "lblTimer"
		Me.lblTimer.Size = New System.Drawing.Size(444, 40)
		Me.lblTimer.TabIndex = 0
		Me.lblTimer.Text = "000:00:00:00:00:00"
		Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'LcdChecbox1
		'
		Me.LcdChecbox1.BackColor = System.Drawing.Color.Transparent
		Me.LcdChecbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.LcdChecbox1.Checked = True
		Me.LcdChecbox1.Location = New System.Drawing.Point(451, 21)
		Me.LcdChecbox1.Margin = New System.Windows.Forms.Padding(0)
		Me.LcdChecbox1.Name = "LcdChecbox1"
		Me.LcdChecbox1.Size = New System.Drawing.Size(32, 32)
		Me.LcdChecbox1.TabIndex = 7
		'
		'TimerDisplay
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(112, Byte), Integer))
		Me.BackgroundImage = Global.TimerDisplay.My.Resources.Resources.LCD_Display_Tutorial
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Controls.Add(Me.LcdChecbox1)
		Me.Controls.Add(Me.lblTimer)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("DSEG7 Classic", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ForeColor = System.Drawing.Color.Black
		Me.Name = "TimerDisplay"
		Me.Size = New System.Drawing.Size(495, 65)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents lblTimer As Label
	Friend WithEvents LcdChecbox1 As LCDCheckbox.LCDChecbox
End Class
