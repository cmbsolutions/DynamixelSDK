Public Class legassembly
    Private _LegId As Integer
    Public Property LegId() As Integer
        Get
            Return _LegId
        End Get
        Set(ByVal value As Integer)
            _LegId = value
        End Set
    End Property
    Public Property LegLocation As eLegLocation

    Public Sub setIds(coxaID As Integer, femurID As Integer, tibiaID As Integer, LegLoc As eLegLocation)
        Servo1.servoId = coxaID
        Servo1.servoName = renameLegLocation() & " Coxa"
        Servo2.servoId = femurID
        Servo2.servoName = renameLegLocation() & " Femur"
        Servo3.servoId = tibiaID
        Servo3.servoName = renameLegLocation() & " Tibia"

        lblCaption.Text = "Legposition: " & LegLocation.ToString
    End Sub

    Public Function getServos() As List(Of servo_ui)
        Return New List(Of servo_ui)({Servo1, Servo2, Servo3})
    End Function

    Private Function renameLegLocation() As String
        Select Case LegLocation
            Case eLegLocation.LeftFront
                Return "LF"
            Case eLegLocation.LeftMiddle
                Return "LM"
            Case eLegLocation.LeftRear
                Return "LR"
            Case eLegLocation.RightFront
                Return "RF"
            Case eLegLocation.RightMiddle
                Return "RM"
            Case eLegLocation.RightRear
                Return "RR"
            Case Else
                Return ""
        End Select
    End Function

End Class

Public Enum eLegLocation
    LeftFront
    LeftMiddle
    LeftRear
    RightFront
    RightMiddle
    RightRear
End Enum