Public Class CountdownTimerv3
    Public Target(4) As Date
    Public StartFlag(4) As Boolean
	Public CalenderValue As Date

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		CalenderValue = dtpCalender.Value
		If Target(1) <> Nothing Then
			Label1.Text = "The target is: " & Format(Target(1), "dddd, MMMM dd, yyyy, hh:mm:ss tt.")
			Dim Remaining As TimeSpan
			Remaining = Target(1) - Now
			SortTargets()
			TimerDisplay1.UpdateDisplay(Remaining)
		Else
			Label1.Text = ""
		End If
		ToggleCheck()
	End Sub

	Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
		If Target(2) <> Nothing Then
			Label2.Text = "The target is: " & Format(Target(2), "dddd, MMMM dd, yyyy, hh:mm:ss tt.")
			Dim Remaining As TimeSpan
			Remaining = Target(2) - Now
			SortTargets()
			TimerDisplay2.UpdateDisplay(Remaining)
		Else
			Label2.Text = ""
		End If
		ToggleCheck()
	End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
		If Target(3) <> Nothing Then
			Label3.Text = "The target is: " & Format(Target(3), "dddd, MMMM dd, yyyy, hh:mm:ss tt.")
			Dim Remaining As TimeSpan
			Remaining = Target(3) - Now
			SortTargets()
			TimerDisplay3.UpdateDisplay(Remaining)
		Else
			Label3.Text = ""
		End If
		ToggleCheck()
	End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
		If Target(4) <> Nothing Then
			Label4.Text = "The target is: " & Format(Target(4), "dddd, MMMM dd, yyyy, hh:mm:ss tt.")
			Dim Remaining As TimeSpan
			Remaining = Target(4) - Now
			SortTargets()
			TimerDisplay4.UpdateDisplay(Remaining)
		Else
			Label4.Text = ""
		End If
		ToggleCheck()
	End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub rbnTime_CheckedChanged(sender As Object, e As EventArgs) Handles rbnTime.CheckedChanged
        If rbnTime.Checked Then
			dtpCalender.Enabled = True
			btnClearCalender.Enabled = True
			'grpTime.Enabled = True
			'grpDuration.Enabled = False
			Label5.Enabled = False
			Label6.Enabled = False
			Label7.Enabled = False
			Label8.Enabled = False
			Label9.Enabled = False
			Label10.Enabled = False
			txtYears.Enabled = False
			txtWeeks.Enabled = False
			txtDays.Enabled = False
			txtHours.Enabled = False
			txtMinutes.Enabled = False
			txtSeconds.Enabled = False
		Else
			dtpCalender.Enabled = False
			btnClearCalender.Enabled = False
			'grpTime.Enabled = False
			'grpDuration.Enabled = True
			Label5.Enabled = True
			Label6.Enabled = True
			Label7.Enabled = True
			Label8.Enabled = True
			Label9.Enabled = True
			Label10.Enabled = True
			txtYears.Enabled = True
			txtWeeks.Enabled = True
			txtDays.Enabled = True
			txtHours.Enabled = True
			txtMinutes.Enabled = True
			txtSeconds.Enabled = True
		End If
    End Sub

    Private Sub ClearDate()
        Dim Current As Date = Now.Date
        dtpCalender.Value = Current
    End Sub

    Private Sub CountdownTimerv3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If My.Settings.Location <> New Point(0, 0) Then
			Me.Location = My.Settings.Location
		End If
		Target(1) = My.Settings.Target1
        Target(2) = My.Settings.Target2
        Target(3) = My.Settings.Target3
        Target(4) = My.Settings.Target4
		For a As Integer = 1 To 4
			StartFlag(a) = False
		Next
		SortTargets()
		ToggleTimerDisplay()
		ClearDate()
	End Sub

    Private Sub CountdownTimerv3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        My.Settings.Location = Me.Location
    End Sub

    Private Sub btnSetTimer_Click(sender As Object, e As EventArgs) Handles btnSetTimer.Click
		If rbnTime.Checked Then
			If rbnTimer1.Checked Then
				Target(1) = dtpCalender.Value
				My.Settings.Target1 = Target(1)
			ElseIf rbnTimer2.Checked Then
				Target(2) = dtpCalender.Value
				My.Settings.Target2 = Target(2)
			ElseIf rbnTimer3.Checked Then
				Target(3) = dtpCalender.Value
				My.Settings.Target3 = Target(3)
			ElseIf rbnTimer4.Checked Then
				Target(4) = dtpCalender.Value
				My.Settings.Target4 = Target(4)
			End If
		Else
			Dim iDays As Integer = 0
			If txtYears.Text <> "" Then iDays = txtYears.Text * 365
			If txtWeeks.Text <> "" Then iDays = iDays + txtWeeks.Text * 7
			If txtDays.Text <> "" Then iDays = iDays + txtDays.Text
			Dim iHours As Integer = 0
			If txtHours.Text <> "" Then iHours = txtHours.Text
			Dim iMinutes As Integer = 0
			If txtMinutes.Text <> "" Then iMinutes = txtMinutes.Text
			Dim iSeconds As Integer = 0
			If txtSeconds.Text <> "" Then iSeconds = txtSeconds.Text
			Dim sDuration As String = iDays & ":" & Format(iHours, "0#") & ":" & Format(iMinutes, "0#") & ":" & Format(iSeconds, "0#")
			Dim Duration As TimeSpan = TimeSpan.Parse(sDuration)
			Dim tempTarget As Date = Now + Duration
			txtYears.Text = ""
			txtWeeks.Text = ""
			txtDays.Text = ""
			txtHours.Text = ""
			txtMinutes.Text = ""
			txtSeconds.Text = ""

			If rbnTimer1.Checked Then
				Target(1) = tempTarget
				My.Settings.Target1 = Target(1)
			ElseIf rbnTimer2.Checked Then
				Target(2) = tempTarget
				My.Settings.Target2 = Target(2)
			ElseIf rbnTimer3.Checked Then
				Target(3) = tempTarget
				My.Settings.Target3 = Target(3)
			ElseIf rbnTimer4.Checked Then
				Target(4) = tempTarget
				My.Settings.Target4 = Target(4)
			End If
		End If
		SortTargets()
		ToggleTimerDisplay()
	End Sub

	Private Sub btnClearTimer_Click(sender As Object, e As EventArgs) Handles btnClearTimer.Click
		If rbnTimer1.Checked Then
			Target(1) = Nothing
			My.Settings.Target1 = Nothing
			Label1.Text = ""
			TimerDisplay1.UpdateDisplay(Nothing)
		ElseIf rbnTimer2.Checked Then
			Target(2) = Nothing
			My.Settings.Target2 = Nothing
			Label2.Text = ""
			TimerDisplay2.UpdateDisplay(Nothing)
		ElseIf rbnTimer3.Checked Then
			Target(3) = Nothing
			My.Settings.Target3 = Nothing
			Label3.Text = ""
			TimerDisplay3.UpdateDisplay(Nothing)
		ElseIf rbnTimer4.Checked Then
			Target(4) = Nothing
			My.Settings.Target4 = Nothing
			Label4.Text = ""
			TimerDisplay4.UpdateDisplay(Nothing)
		End If
		SortTargets()
		ToggleTimerDisplay()
	End Sub

	Private Sub txtYears_TextAlignChanged(sender As Object, e As EventArgs) Handles txtYears.TextAlignChanged
		If txtYears.Text = "" Then Exit Sub
		If Not IsNumeric(txtYears.Text) Then txtYears.Text = ""
	End Sub

	Private Sub txtWeeks_TextChanged(sender As Object, e As EventArgs) Handles txtWeeks.TextChanged
		If txtWeeks.Text = "" Then Exit Sub
		If Not IsNumeric(txtWeeks.Text) Then txtWeeks.Text = ""
		If txtWeeks.Text > 51 Then txtWeeks.Text = 51
	End Sub

	Private Sub txtDays_TextChanged(sender As Object, e As EventArgs) Handles txtDays.TextChanged
		If txtDays.Text = "" Then Exit Sub
		If Not IsNumeric(txtDays.Text) Then txtDays.Text = ""
	End Sub

	Private Sub txtHours_TextChanged(sender As Object, e As EventArgs) Handles txtHours.TextChanged
		If txtHours.Text = "" Then Exit Sub
		If Not IsNumeric(txtHours.Text) Then txtHours.Text = ""
		If txtHours.Text > 23 Then txtHours.Text = 23
	End Sub

	Private Sub txtMinutes_TextChanged(sender As Object, e As EventArgs) Handles txtMinutes.TextChanged
		If txtMinutes.Text = "" Then Exit Sub
		If Not IsNumeric(txtMinutes.Text) Then txtMinutes.Text = ""
		If txtMinutes.Text > 59 Then txtMinutes.Text = 59
	End Sub

	Private Sub txtSeconds_TextChanged(sender As Object, e As EventArgs) Handles txtSeconds.TextChanged
		If txtSeconds.Text = "" Then Exit Sub
		If Not IsNumeric(txtSeconds.Text) Then txtSeconds.Text = ""
		If txtSeconds.Text > 59 Then txtSeconds.Text = 59
	End Sub

	Private Sub btnClearCalender_Click(sender As Object, e As EventArgs) Handles btnClearCalender.Click
		ClearDate()
	End Sub

	Private Sub ToggleTimerDisplay()
		If Target(1) = Nothing Then TimerDisplay1.IsOn = False Else TimerDisplay1.IsOn = True
		If Target(2) = Nothing Then TimerDisplay2.IsOn = False Else TimerDisplay2.IsOn = True
		If Target(3) = Nothing Then TimerDisplay3.IsOn = False Else TimerDisplay3.IsOn = True
		If Target(4) = Nothing Then TimerDisplay4.IsOn = False Else TimerDisplay4.IsOn = True
		TimerDisplay1.ToggleOnOff()
		TimerDisplay2.ToggleOnOff()
		TimerDisplay3.ToggleOnOff()
		TimerDisplay4.ToggleOnOff()
	End Sub

	Private Sub SortTargets()
		For a As Integer = 1 To 5
			If Target(4) < Target(3) Then
				Dim temp As Date = Target(3)
				Target(3) = Target(4)
				Target(4) = temp
			End If
			If Target(3) < Target(2) Then
				Dim temp As Date = Target(2)
				Target(2) = Target(3)
				Target(3) = temp
			End If
			If Target(2) < Target(1) Then
				Dim temp As Date = Target(1)
				Target(1) = Target(2)
				Target(2) = temp
			End If
		Next
		For a As Integer = 1 To 5
			If Target(3) = Nothing Then
				Target(3) = Target(4)
				Target(4) = Nothing
			End If
			If Target(2) = Nothing Then
				Target(2) = Target(3)
				Target(3) = Target(4)
				Target(4) = Nothing
			End If
			If Target(1) = Nothing Then
				Target(1) = Target(2)
				Target(2) = Target(3)
				Target(3) = Target(4)
				Target(4) = Nothing
			End If
		Next
		My.Settings.Target1 = Target(1)
		My.Settings.Target2 = Target(2)
		My.Settings.Target3 = Target(3)
		My.Settings.Target4 = Target(4)
	End Sub

	Private Sub chkShowYearsWeeks_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowYearsWeeks.CheckedChanged
		If chkShowYearsWeeks.Checked Then
			TimerDisplay1.ShowYearsWeeks = True
			TimerDisplay2.ShowYearsWeeks = True
			TimerDisplay3.ShowYearsWeeks = True
			TimerDisplay4.ShowYearsWeeks = True
		Else
			TimerDisplay1.ShowYearsWeeks = False
			TimerDisplay2.ShowYearsWeeks = False
			TimerDisplay3.ShowYearsWeeks = False
			TimerDisplay4.ShowYearsWeeks = False
		End If
	End Sub

	Private Sub ToggleCheck()
		If (TimerDisplay1.ShowYearsWeeks And TimerDisplay2.ShowYearsWeeks And TimerDisplay3.ShowYearsWeeks And TimerDisplay4.ShowYearsWeeks) Then
			chkShowYearsWeeks.CheckState = CheckState.Checked
		ElseIf Not (TimerDisplay1.ShowYearsWeeks And TimerDisplay2.ShowYearsWeeks And TimerDisplay3.ShowYearsWeeks And TimerDisplay4.ShowYearsWeeks) Then
			chkShowYearsWeeks.CheckState = CheckState.Unchecked
		Else
			chkShowYearsWeeks.CheckState = CheckState.Indeterminate
		End If
	End Sub
End Class
