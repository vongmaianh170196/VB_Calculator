Public Class DayAction
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles timePicker.ValueChanged
        Me.Hour = timePicker.Value.Hour
    End Sub
    Private Enum Action As Integer
        Sleeping = 1
        Awake = 2
        Working = 3
        Eating = 4
        Resting = 5
        Gymming = 6
    End Enum
    'Private state As Action
    Private Property Hour() As Integer
        Get
            Return timePicker.Value.Hour
        End Get
        Set(value As Integer)
            timePicker.Value = New Date(Now.Year, Now.Month, Now.Day, value, 0, 0)
            Dim state As Action
            If value > 6 And value <= 8 Then
                state = Action.Awake
            ElseIf value > 8 And value < 13 Then
                state = Action.Eating
            ElseIf value >= 13 And value < 18 Then
                state = Action.Working
            ElseIf value >= 18 And value < 19 Then
                state = Action.Resting
            ElseIf value >= 19 And value < 22 Then
                state = Action.Gymming
            Else state = Action.Sleeping
            End If
            txtAction.Text = "At " & value & " :00, I am " & state.ToString()

        End Set
    End Property

    Private Sub DayAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hour = Now.Hour
    End Sub
End Class
