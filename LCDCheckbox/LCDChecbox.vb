Public Class LCDChecbox
	Private bChecked As Boolean = True

	Public Property Checked As Boolean
		Get
			Return bChecked
		End Get
		Set(value As Boolean)
			bChecked = value
			If bChecked Then
				Label1.BackColor = Color.Black
			Else
				Label1.BackColor = Color.Transparent
			End If
		End Set
	End Property

	Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
		Toggle()
	End Sub

	Private Sub LCDChecbox_Click(sender As Object, e As EventArgs) Handles Me.Click
		Toggle()
	End Sub

	Private Sub Toggle()
		If bChecked Then
			bChecked = False
			Label1.BackColor = Color.Transparent
		Else
			bChecked = True
			Label1.BackColor = Color.Black
		End If
	End Sub
End Class
