<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DayAction
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
        Me.timePicker = New System.Windows.Forms.DateTimePicker()
        Me.txtAction = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'timePicker
        '
        Me.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timePicker.Location = New System.Drawing.Point(22, 23)
        Me.timePicker.Name = "timePicker"
        Me.timePicker.Size = New System.Drawing.Size(168, 22)
        Me.timePicker.TabIndex = 0
        '
        'txtAction
        '
        Me.txtAction.AutoSize = True
        Me.txtAction.Location = New System.Drawing.Point(19, 58)
        Me.txtAction.Name = "txtAction"
        Me.txtAction.Size = New System.Drawing.Size(174, 17)
        Me.txtAction.TabIndex = 2
        Me.txtAction.Text = "State has not been set yet"
        '
        'DayAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 302)
        Me.Controls.Add(Me.txtAction)
        Me.Controls.Add(Me.timePicker)
        Me.Name = "DayAction"
        Me.Text = "Day Action"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timePicker As DateTimePicker
    Friend WithEvents txtAction As Label
End Class
