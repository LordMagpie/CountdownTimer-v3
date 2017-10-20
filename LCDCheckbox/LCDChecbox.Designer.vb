<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LCDChecbox
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.Black
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.Label1.Location = New System.Drawing.Point(0, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(32, 32)
		Me.Label1.TabIndex = 0
		'
		'LCDChecbox
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Transparent
		Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Controls.Add(Me.Label1)
		Me.Margin = New System.Windows.Forms.Padding(0)
		Me.Name = "LCDChecbox"
		Me.Size = New System.Drawing.Size(32, 32)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Label1 As Label
End Class
