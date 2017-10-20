<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CountdownTimerv3
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CountdownTimerv3))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.rbnTimer1 = New System.Windows.Forms.RadioButton()
		Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
		Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
		Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
		Me.rbnTimer2 = New System.Windows.Forms.RadioButton()
		Me.rbnTimer3 = New System.Windows.Forms.RadioButton()
		Me.rbnTimer4 = New System.Windows.Forms.RadioButton()
		Me.btnClearTimer = New System.Windows.Forms.Button()
		Me.btnSetTimer = New System.Windows.Forms.Button()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.rbnDuration = New System.Windows.Forms.RadioButton()
		Me.rbnTime = New System.Windows.Forms.RadioButton()
		Me.grpTime = New System.Windows.Forms.GroupBox()
		Me.btnClearCalender = New System.Windows.Forms.Button()
		Me.dtpCalender = New System.Windows.Forms.DateTimePicker()
		Me.grpDuration = New System.Windows.Forms.GroupBox()
		Me.txtSeconds = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.txtMinutes = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.txtHours = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.txtDays = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtWeeks = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtYears = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.chkShowYearsWeeks = New System.Windows.Forms.CheckBox()
		Me.TimerDisplay1 = New TimerDisplay.TimerDisplay()
		Me.TimerDisplay2 = New TimerDisplay.TimerDisplay()
		Me.TimerDisplay3 = New TimerDisplay.TimerDisplay()
		Me.TimerDisplay4 = New TimerDisplay.TimerDisplay()
		Me.GroupBox1.SuspendLayout()
		Me.grpTime.SuspendLayout()
		Me.grpDuration.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(13, 9)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(439, 66)
		Me.Label1.TabIndex = 0
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(13, 81)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(439, 66)
		Me.Label2.TabIndex = 2
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label3
		'
		Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(13, 153)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(439, 66)
		Me.Label3.TabIndex = 3
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label4
		'
		Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(16, 225)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(436, 66)
		Me.Label4.TabIndex = 4
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Timer1
		'
		Me.Timer1.Enabled = True
		Me.Timer1.Interval = 500
		'
		'rbnTimer1
		'
		Me.rbnTimer1.AutoSize = True
		Me.rbnTimer1.Checked = True
		Me.rbnTimer1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbnTimer1.Location = New System.Drawing.Point(184, 306)
		Me.rbnTimer1.Margin = New System.Windows.Forms.Padding(4)
		Me.rbnTimer1.Name = "rbnTimer1"
		Me.rbnTimer1.Size = New System.Drawing.Size(73, 21)
		Me.rbnTimer1.TabIndex = 9
		Me.rbnTimer1.TabStop = True
		Me.rbnTimer1.Text = "Timer 1"
		Me.rbnTimer1.UseVisualStyleBackColor = True
		'
		'Timer2
		'
		Me.Timer2.Enabled = True
		Me.Timer2.Interval = 500
		'
		'Timer3
		'
		Me.Timer3.Enabled = True
		Me.Timer3.Interval = 500
		'
		'Timer4
		'
		Me.Timer4.Enabled = True
		Me.Timer4.Interval = 500
		'
		'rbnTimer2
		'
		Me.rbnTimer2.AutoSize = True
		Me.rbnTimer2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbnTimer2.Location = New System.Drawing.Point(184, 335)
		Me.rbnTimer2.Margin = New System.Windows.Forms.Padding(4)
		Me.rbnTimer2.Name = "rbnTimer2"
		Me.rbnTimer2.Size = New System.Drawing.Size(73, 21)
		Me.rbnTimer2.TabIndex = 10
		Me.rbnTimer2.TabStop = True
		Me.rbnTimer2.Text = "Timer 2"
		Me.rbnTimer2.UseVisualStyleBackColor = True
		'
		'rbnTimer3
		'
		Me.rbnTimer3.AutoSize = True
		Me.rbnTimer3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbnTimer3.Location = New System.Drawing.Point(184, 364)
		Me.rbnTimer3.Margin = New System.Windows.Forms.Padding(4)
		Me.rbnTimer3.Name = "rbnTimer3"
		Me.rbnTimer3.Size = New System.Drawing.Size(73, 21)
		Me.rbnTimer3.TabIndex = 11
		Me.rbnTimer3.TabStop = True
		Me.rbnTimer3.Text = "Timer 3"
		Me.rbnTimer3.UseVisualStyleBackColor = True
		'
		'rbnTimer4
		'
		Me.rbnTimer4.AutoSize = True
		Me.rbnTimer4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rbnTimer4.Location = New System.Drawing.Point(184, 393)
		Me.rbnTimer4.Margin = New System.Windows.Forms.Padding(4)
		Me.rbnTimer4.Name = "rbnTimer4"
		Me.rbnTimer4.Size = New System.Drawing.Size(73, 21)
		Me.rbnTimer4.TabIndex = 12
		Me.rbnTimer4.TabStop = True
		Me.rbnTimer4.Text = "Timer 4"
		Me.rbnTimer4.UseVisualStyleBackColor = True
		'
		'btnClearTimer
		'
		Me.btnClearTimer.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClearTimer.Location = New System.Drawing.Point(265, 306)
		Me.btnClearTimer.Margin = New System.Windows.Forms.Padding(4)
		Me.btnClearTimer.Name = "btnClearTimer"
		Me.btnClearTimer.Size = New System.Drawing.Size(149, 44)
		Me.btnClearTimer.TabIndex = 13
		Me.btnClearTimer.Text = "Clear Timer"
		Me.btnClearTimer.UseVisualStyleBackColor = True
		'
		'btnSetTimer
		'
		Me.btnSetTimer.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSetTimer.Location = New System.Drawing.Point(265, 358)
		Me.btnSetTimer.Margin = New System.Windows.Forms.Padding(4)
		Me.btnSetTimer.Name = "btnSetTimer"
		Me.btnSetTimer.Size = New System.Drawing.Size(149, 44)
		Me.btnSetTimer.TabIndex = 14
		Me.btnSetTimer.Text = "Set Timer"
		Me.btnSetTimer.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.AutoSize = True
		Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.GroupBox1.Controls.Add(Me.rbnDuration)
		Me.GroupBox1.Controls.Add(Me.rbnTime)
		Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(21, 311)
		Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 3, 5, 3)
		Me.GroupBox1.Size = New System.Drawing.Size(123, 142)
		Me.GroupBox1.TabIndex = 16
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Select..."
		'
		'rbnDuration
		'
		Me.rbnDuration.AutoSize = True
		Me.rbnDuration.Location = New System.Drawing.Point(8, 97)
		Me.rbnDuration.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
		Me.rbnDuration.Name = "rbnDuration"
		Me.rbnDuration.Size = New System.Drawing.Size(105, 21)
		Me.rbnDuration.TabIndex = 9
		Me.rbnDuration.Text = "Set Duration"
		Me.rbnDuration.UseVisualStyleBackColor = True
		'
		'rbnTime
		'
		Me.rbnTime.AutoSize = True
		Me.rbnTime.Checked = True
		Me.rbnTime.Location = New System.Drawing.Point(8, 46)
		Me.rbnTime.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
		Me.rbnTime.Name = "rbnTime"
		Me.rbnTime.Size = New System.Drawing.Size(91, 21)
		Me.rbnTime.TabIndex = 9
		Me.rbnTime.TabStop = True
		Me.rbnTime.Text = "Set a Time"
		Me.rbnTime.UseVisualStyleBackColor = True
		'
		'grpTime
		'
		Me.grpTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.grpTime.Controls.Add(Me.btnClearCalender)
		Me.grpTime.Controls.Add(Me.dtpCalender)
		Me.grpTime.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpTime.Location = New System.Drawing.Point(451, 298)
		Me.grpTime.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
		Me.grpTime.Name = "grpTime"
		Me.grpTime.Padding = New System.Windows.Forms.Padding(5, 3, 5, 3)
		Me.grpTime.Size = New System.Drawing.Size(398, 78)
		Me.grpTime.TabIndex = 17
		Me.grpTime.TabStop = False
		Me.grpTime.Text = "Time"
		'
		'btnClearCalender
		'
		Me.btnClearCalender.AutoSize = True
		Me.btnClearCalender.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.btnClearCalender.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClearCalender.Location = New System.Drawing.Point(288, 44)
		Me.btnClearCalender.Margin = New System.Windows.Forms.Padding(4)
		Me.btnClearCalender.Name = "btnClearCalender"
		Me.btnClearCalender.Size = New System.Drawing.Size(96, 23)
		Me.btnClearCalender.TabIndex = 14
		Me.btnClearCalender.Text = "<- Set to Today"
		Me.btnClearCalender.UseVisualStyleBackColor = True
		'
		'dtpCalender
		'
		Me.dtpCalender.CalendarFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpCalender.CustomFormat = "ddd, MMM dd, yyyy hh:mm:ss tt"
		Me.dtpCalender.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpCalender.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.dtpCalender.Location = New System.Drawing.Point(8, 46)
		Me.dtpCalender.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
		Me.dtpCalender.Name = "dtpCalender"
		Me.dtpCalender.Size = New System.Drawing.Size(269, 22)
		Me.dtpCalender.TabIndex = 10
		'
		'grpDuration
		'
		Me.grpDuration.Controls.Add(Me.txtSeconds)
		Me.grpDuration.Controls.Add(Me.Label10)
		Me.grpDuration.Controls.Add(Me.txtMinutes)
		Me.grpDuration.Controls.Add(Me.Label9)
		Me.grpDuration.Controls.Add(Me.txtHours)
		Me.grpDuration.Controls.Add(Me.Label8)
		Me.grpDuration.Controls.Add(Me.txtDays)
		Me.grpDuration.Controls.Add(Me.Label7)
		Me.grpDuration.Controls.Add(Me.txtWeeks)
		Me.grpDuration.Controls.Add(Me.Label6)
		Me.grpDuration.Controls.Add(Me.txtYears)
		Me.grpDuration.Controls.Add(Me.Label5)
		Me.grpDuration.Location = New System.Drawing.Point(451, 389)
		Me.grpDuration.Name = "grpDuration"
		Me.grpDuration.Size = New System.Drawing.Size(326, 111)
		Me.grpDuration.TabIndex = 24
		Me.grpDuration.TabStop = False
		Me.grpDuration.Text = "Duration"
		'
		'txtSeconds
		'
		Me.txtSeconds.Enabled = False
		Me.txtSeconds.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSeconds.Location = New System.Drawing.Point(273, 70)
		Me.txtSeconds.MaxLength = 2
		Me.txtSeconds.Name = "txtSeconds"
		Me.txtSeconds.Size = New System.Drawing.Size(38, 25)
		Me.txtSeconds.TabIndex = 11
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Enabled = False
		Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(209, 73)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(58, 17)
		Me.Label10.TabIndex = 10
		Me.Label10.Text = "Seconds"
		'
		'txtMinutes
		'
		Me.txtMinutes.Enabled = False
		Me.txtMinutes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMinutes.Location = New System.Drawing.Point(165, 70)
		Me.txtMinutes.MaxLength = 2
		Me.txtMinutes.Name = "txtMinutes"
		Me.txtMinutes.Size = New System.Drawing.Size(38, 25)
		Me.txtMinutes.TabIndex = 9
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Enabled = False
		Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(101, 73)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(58, 17)
		Me.Label9.TabIndex = 8
		Me.Label9.Text = "Minutes"
		'
		'txtHours
		'
		Me.txtHours.Enabled = False
		Me.txtHours.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtHours.Location = New System.Drawing.Point(57, 70)
		Me.txtHours.MaxLength = 2
		Me.txtHours.Name = "txtHours"
		Me.txtHours.Size = New System.Drawing.Size(38, 25)
		Me.txtHours.TabIndex = 7
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Enabled = False
		Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(6, 73)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(45, 17)
		Me.Label8.TabIndex = 6
		Me.Label8.Text = "Hours"
		'
		'txtDays
		'
		Me.txtDays.Enabled = False
		Me.txtDays.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDays.Location = New System.Drawing.Point(273, 36)
		Me.txtDays.MaxLength = 4
		Me.txtDays.Name = "txtDays"
		Me.txtDays.Size = New System.Drawing.Size(38, 25)
		Me.txtDays.TabIndex = 5
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Enabled = False
		Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(229, 41)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(38, 17)
		Me.Label7.TabIndex = 4
		Me.Label7.Text = "Days"
		'
		'txtWeeks
		'
		Me.txtWeeks.Enabled = False
		Me.txtWeeks.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtWeeks.Location = New System.Drawing.Point(165, 38)
		Me.txtWeeks.MaxLength = 2
		Me.txtWeeks.Name = "txtWeeks"
		Me.txtWeeks.Size = New System.Drawing.Size(38, 25)
		Me.txtWeeks.TabIndex = 3
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Enabled = False
		Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(111, 39)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(48, 17)
		Me.Label6.TabIndex = 2
		Me.Label6.Text = "Weeks"
		'
		'txtYears
		'
		Me.txtYears.Enabled = False
		Me.txtYears.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtYears.Location = New System.Drawing.Point(57, 38)
		Me.txtYears.MaxLength = 3
		Me.txtYears.Name = "txtYears"
		Me.txtYears.Size = New System.Drawing.Size(38, 25)
		Me.txtYears.TabIndex = 1
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Enabled = False
		Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(6, 39)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(40, 17)
		Me.Label5.TabIndex = 0
		Me.Label5.Text = "Years"
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(783, 382)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(170, 118)
		Me.btnExit.TabIndex = 25
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'chkShowYearsWeeks
		'
		Me.chkShowYearsWeeks.AutoSize = True
		Me.chkShowYearsWeeks.Location = New System.Drawing.Point(265, 410)
		Me.chkShowYearsWeeks.Name = "chkShowYearsWeeks"
		Me.chkShowYearsWeeks.Size = New System.Drawing.Size(172, 21)
		Me.chkShowYearsWeeks.TabIndex = 30
		Me.chkShowYearsWeeks.Text = "Show Years and Weeks"
		Me.chkShowYearsWeeks.UseVisualStyleBackColor = True
		'
		'TimerDisplay1
		'
		Me.TimerDisplay1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(112, Byte), Integer))
		Me.TimerDisplay1.BackgroundImage = CType(resources.GetObject("TimerDisplay1.BackgroundImage"), System.Drawing.Image)
		Me.TimerDisplay1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.TimerDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.TimerDisplay1.Days = 0
		Me.TimerDisplay1.Font = New System.Drawing.Font("DSEG7 Classic", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TimerDisplay1.ForeColor = System.Drawing.Color.Black
		Me.TimerDisplay1.Hours = 0
		Me.TimerDisplay1.IsOn = True
		Me.TimerDisplay1.Location = New System.Drawing.Point(460, 9)
		Me.TimerDisplay1.Minute = 0
		Me.TimerDisplay1.Name = "TimerDisplay1"
		Me.TimerDisplay1.Seconds = 0
		Me.TimerDisplay1.ShowYearsWeeks = False
		Me.TimerDisplay1.Size = New System.Drawing.Size(495, 66)
		Me.TimerDisplay1.TabIndex = 31
		Me.TimerDisplay1.Weeks = 0
		Me.TimerDisplay1.Years = 0
		'
		'TimerDisplay2
		'
		Me.TimerDisplay2.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(112, Byte), Integer))
		Me.TimerDisplay2.BackgroundImage = CType(resources.GetObject("TimerDisplay2.BackgroundImage"), System.Drawing.Image)
		Me.TimerDisplay2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.TimerDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.TimerDisplay2.Days = 0
		Me.TimerDisplay2.Font = New System.Drawing.Font("DSEG7 Classic", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TimerDisplay2.ForeColor = System.Drawing.Color.Black
		Me.TimerDisplay2.Hours = 0
		Me.TimerDisplay2.IsOn = True
		Me.TimerDisplay2.Location = New System.Drawing.Point(460, 81)
		Me.TimerDisplay2.Minute = 0
		Me.TimerDisplay2.Name = "TimerDisplay2"
		Me.TimerDisplay2.Seconds = 0
		Me.TimerDisplay2.ShowYearsWeeks = False
		Me.TimerDisplay2.Size = New System.Drawing.Size(495, 66)
		Me.TimerDisplay2.TabIndex = 32
		Me.TimerDisplay2.Weeks = 0
		Me.TimerDisplay2.Years = 0
		'
		'TimerDisplay3
		'
		Me.TimerDisplay3.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(112, Byte), Integer))
		Me.TimerDisplay3.BackgroundImage = CType(resources.GetObject("TimerDisplay3.BackgroundImage"), System.Drawing.Image)
		Me.TimerDisplay3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.TimerDisplay3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.TimerDisplay3.Days = 0
		Me.TimerDisplay3.Font = New System.Drawing.Font("DSEG7 Classic", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TimerDisplay3.ForeColor = System.Drawing.Color.Black
		Me.TimerDisplay3.Hours = 0
		Me.TimerDisplay3.IsOn = True
		Me.TimerDisplay3.Location = New System.Drawing.Point(460, 153)
		Me.TimerDisplay3.Minute = 0
		Me.TimerDisplay3.Name = "TimerDisplay3"
		Me.TimerDisplay3.Seconds = 0
		Me.TimerDisplay3.ShowYearsWeeks = False
		Me.TimerDisplay3.Size = New System.Drawing.Size(495, 66)
		Me.TimerDisplay3.TabIndex = 33
		Me.TimerDisplay3.Weeks = 0
		Me.TimerDisplay3.Years = 0
		'
		'TimerDisplay4
		'
		Me.TimerDisplay4.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(112, Byte), Integer))
		Me.TimerDisplay4.BackgroundImage = CType(resources.GetObject("TimerDisplay4.BackgroundImage"), System.Drawing.Image)
		Me.TimerDisplay4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.TimerDisplay4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.TimerDisplay4.Days = 0
		Me.TimerDisplay4.Font = New System.Drawing.Font("DSEG7 Classic", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TimerDisplay4.ForeColor = System.Drawing.Color.Black
		Me.TimerDisplay4.Hours = 0
		Me.TimerDisplay4.IsOn = True
		Me.TimerDisplay4.Location = New System.Drawing.Point(460, 225)
		Me.TimerDisplay4.Minute = 0
		Me.TimerDisplay4.Name = "TimerDisplay4"
		Me.TimerDisplay4.Seconds = 0
		Me.TimerDisplay4.ShowYearsWeeks = False
		Me.TimerDisplay4.Size = New System.Drawing.Size(495, 66)
		Me.TimerDisplay4.TabIndex = 34
		Me.TimerDisplay4.Weeks = 0
		Me.TimerDisplay4.Years = 0
		'
		'CountdownTimerv3
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(965, 511)
		Me.Controls.Add(Me.TimerDisplay4)
		Me.Controls.Add(Me.TimerDisplay3)
		Me.Controls.Add(Me.TimerDisplay2)
		Me.Controls.Add(Me.TimerDisplay1)
		Me.Controls.Add(Me.chkShowYearsWeeks)
		Me.Controls.Add(Me.grpDuration)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.grpTime)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.btnSetTimer)
		Me.Controls.Add(Me.btnClearTimer)
		Me.Controls.Add(Me.rbnTimer4)
		Me.Controls.Add(Me.rbnTimer3)
		Me.Controls.Add(Me.rbnTimer2)
		Me.Controls.Add(Me.rbnTimer1)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.MaximizeBox = False
		Me.Name = "CountdownTimerv3"
		Me.Text = "Countdown Timer v3"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.grpTime.ResumeLayout(False)
		Me.grpTime.PerformLayout()
		Me.grpDuration.ResumeLayout(False)
		Me.grpDuration.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Timer1 As Timer
	Friend WithEvents rbnTimer1 As RadioButton
	Friend WithEvents Timer2 As Timer
	Friend WithEvents Timer3 As Timer
	Friend WithEvents Timer4 As Timer
	Friend WithEvents rbnTimer2 As RadioButton
	Friend WithEvents rbnTimer3 As RadioButton
	Friend WithEvents rbnTimer4 As RadioButton
	Friend WithEvents btnClearTimer As Button
	Friend WithEvents btnSetTimer As Button
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents rbnDuration As RadioButton
	Friend WithEvents rbnTime As RadioButton
	Friend WithEvents grpTime As GroupBox
	Friend WithEvents btnClearCalender As Button
	Friend WithEvents dtpCalender As DateTimePicker
	Friend WithEvents grpDuration As GroupBox
	Friend WithEvents txtSeconds As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents txtMinutes As TextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents txtHours As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents txtDays As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents txtWeeks As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents txtYears As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents btnExit As Button
	Friend WithEvents chkShowYearsWeeks As CheckBox
	Friend WithEvents TimerDisplay1 As TimerDisplay.TimerDisplay
	Friend WithEvents TimerDisplay2 As TimerDisplay.TimerDisplay
	Friend WithEvents TimerDisplay3 As TimerDisplay.TimerDisplay
	Friend WithEvents TimerDisplay4 As TimerDisplay.TimerDisplay
End Class
