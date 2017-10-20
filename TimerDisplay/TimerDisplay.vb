Public Class TimerDisplay
	Private iYears, iWeeks, iDays, iHours, iMinutes, iSeconds As Integer
	Private bShowYearsWeeks As Boolean, bIsOn As Boolean = True

	Public Property IsOn() As Boolean
		Get
			Return bIsOn
		End Get
		Set(value As Boolean)
			bIsOn = value
			UpdateLabel()
		End Set
	End Property

	Public Property ShowYearsWeeks() As Boolean
		Get
			Return bShowYearsWeeks
		End Get
		Set(value As Boolean)
			bShowYearsWeeks = value
			UpdateLabel()
			LcdChecbox1.Checked = value
		End Set
	End Property

	Public Property Years() As Integer
		Get
			Return iYears
		End Get
		Set(value As Integer)
			iYears = value
			UpdateLabel()
		End Set
	End Property

	Public Property Weeks() As Integer
		Get
			Return iWeeks
		End Get
		Set(value As Integer)
			iWeeks = value
			UpdateLabel()
		End Set
	End Property

	Public Property Days() As Integer
		Get
			Return iDays
		End Get
		Set(value As Integer)
			iDays = value
			UpdateLabel()
		End Set
	End Property

	Public Property Hours() As Integer
		Get
			Return iHours
		End Get
		Set(value As Integer)
			iHours = value
			UpdateLabel()
		End Set
	End Property

	Public Property Minute() As Integer
		Get
			Return iMinutes
		End Get
		Set(value As Integer)
			iMinutes = value
			UpdateLabel()
		End Set
	End Property

	Public Property Seconds As Integer
		Get
			Return iSeconds
		End Get
		Set(value As Integer)
			iSeconds = value
			UpdateLabel()
		End Set
	End Property

	Public Sub UpdateDisplay(ByVal value As TimeSpan)
		iDays = value.Days
		iHours = value.Hours
		iMinutes = value.Minutes
		iSeconds = value.Seconds
		If LcdChecbox1.Checked Then
			If iDays > 364 Then
				iYears = iDays \ 365
				iDays = iDays Mod 365
			Else
				iYears = 0
			End If
			If iDays > 6 Then
				iWeeks = iDays \ 7
				iDays = iDays Mod 7
			Else
				iWeeks = 0
			End If
			Label1.Visible = True
			Label2.Visible = True
		Else
			iYears = 0
			iWeeks = 0
			Label1.Visible = False
			Label2.Visible = False
		End If

		If value.Ticks < 0 Then
			iYears = 0
			iWeeks = 0
			iDays = 0
			iHours = 0
			iMinutes = 0
			iSeconds = 0
			If lblTimer.ForeColor = Color.SeaGreen Then
				lblTimer.ForeColor = Color.Red
			Else
				lblTimer.ForeColor = Color.SeaGreen
			End If
		Else
			lblTimer.ForeColor = Color.Black
		End If
		ShowYearsWeeks = LcdChecbox1.Checked
		UpdateLabel()
	End Sub

	Public Sub UpdateLabel()
		Dim text As String
		If iSeconds > 0 Then text = Format(iSeconds, "#") Else text = "000:00:00:00:00:00"
		If iMinutes > 0 Then text = Format(iMinutes, "#") & ":" & Format(iSeconds, "0#")
		If iHours > 0 Then text = Format(iHours, "#") & ":" & Format(iMinutes, "0#") & ":" & Format(iSeconds, "0#")
		If iDays > 0 Then text = Format(iDays, "#") & ":" & Format(iHours, "0#") & ":" & Format(iMinutes, "0#") & ":" & Format(iSeconds, "0#")
		If iWeeks > 0 Then text = Format(iWeeks, "#") & ":" & Format(iDays, "0#") & ":" & Format(iHours, "0#") & ":" & Format(iMinutes, "0#") & ":" & Format(iSeconds, "0#")
		If iYears > 0 Then text = Format(iYears, "#") & ":" & Format(iWeeks, "0#") & ":" & Format(iDays, "0#") & ":" & Format(iHours, "0#") & ":" & Format(iMinutes, "0#") & ":" & Format(iSeconds, "0#")
		lblTimer.Text = text
	End Sub

	Public Sub ToggleOnOff()
		If bIsOn Then
			lblTimer.Visible = True
			Label1.Visible = True
			Label2.Visible = True
			Label3.Visible = True
			Label4.Visible = True
			Label5.Visible = True
			Label6.Visible = True
		Else
			lblTimer.Visible = False
			Label1.Visible = False
			Label2.Visible = False
			Label3.Visible = False
			Label4.Visible = False
			Label5.Visible = False
			Label6.Visible = False
		End If
	End Sub
End Class
