Public Class servo_ui
    ReadOnly Property InError As Boolean = False
    ReadOnly Property TorqueEnabled As Boolean = False
    Private _servoName As String
    Private _servoPosition As Integer
    Public Property servoId() As Integer

    Public Property servoJoint As eJoint

    Public Property servoName() As String
        Get
            Return _servoName
        End Get
        Set
            _servoName = Value
            lblServoName.Text = String.Format("{0} ID {1}", servoName, servoId)
        End Set
    End Property

    Public Property servoPosition() As Integer
        Get
            Return _servoPosition
        End Get
        Set
            If Value < 0 Then Value = 0
            If Value > 1024 Then Value = 1024

            _servoPosition = Value
            tbPositionSlider.Value = servoPosition
            positionField.Value = servoPosition
        End Set
    End Property

    Public Event PositionChanged(ByVal sender As Object, ByVal e As PositionChangedEventArgs)
    Public Event StateChanged(ByVal sender As Object, ByVal e As EventArgs)

    Private Sub tbPositionSlider_Scroll(sender As Object, e As EventArgs) Handles tbPositionSlider.Scroll
        positionField.Value = tbPositionSlider.Value
        servoPosition = tbPositionSlider.Value
        RaiseEvent PositionChanged(Me, New PositionChangedEventArgs(servoPosition))
    End Sub

    Private Sub positionField_ValueChanged(sender As Object, e As EventArgs) Handles positionField.ValueChanged
        tbPositionSlider.Value = CInt(positionField.Value)
        servoPosition = CInt(positionField.Value)
        RaiseEvent PositionChanged(Me, New PositionChangedEventArgs(servoPosition))
    End Sub

    Private Sub chkServoOnOff_CheckedChanged(sender As Object, e As EventArgs) Handles chkServoOnOff.CheckedChanged
        If chkServoOnOff.Checked Then
            BackColor = Color.FromArgb(128, 255, 128)
        Else
            BackColor = Color.FromArgb(255, 128, 128)
        End If

        RaiseEvent StateChanged(Me, New EventArgs())
    End Sub

    Public Sub setError(msg As String)
        errorIcon.Visible = True
        ToolTip1.SetToolTip(errorIcon, msg)
        BackColor = Color.FromArgb(255, 192, 128)
        _InError = True
    End Sub

    Public Sub resetError()
        errorIcon.Visible = False
        _InError = False
    End Sub

    Public Sub setTorque(ByVal enabled As Boolean)
        _TorqueEnabled = enabled
        torque.Visible = enabled
    End Sub

End Class

Public Class PositionChangedEventArgs
    ReadOnly Property position As Integer

    Sub New(pos As Integer)
        _position = pos
    End Sub
End Class
