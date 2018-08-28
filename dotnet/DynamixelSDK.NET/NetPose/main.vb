Imports DynamixelSDK.NET.dynamixel_sdk

Public Class main
    Private robo As robotController
    Private _acts As List(Of Assemblies.servo_ui)
    Private _legs As List(Of Assemblies.legassembly)
    Private _tracelistener As customTextTraceListener

    Private Sub Legassembly1_Load(sender As Object, e As EventArgs) Handles Legassembly1.Load
        Legassembly1.setIds(8, 10, 12, Assemblies.eLegLocation.RightRear)
    End Sub

    Private Sub Legassembly2_Load(sender As Object, e As EventArgs) Handles Legassembly2.Load
        Legassembly2.setIds(7, 9, 11, Assemblies.eLegLocation.LeftRear)
    End Sub

    Private Sub Legassembly3_Load(sender As Object, e As EventArgs) Handles Legassembly3.Load
        Legassembly3.setIds(14, 16, 18, Assemblies.eLegLocation.RightMiddle)
    End Sub

    Private Sub Legassembly4_Load(sender As Object, e As EventArgs) Handles Legassembly4.Load
        Legassembly4.setIds(13, 15, 17, Assemblies.eLegLocation.LeftMiddle)
    End Sub

    Private Sub Legassembly6_Load(sender As Object, e As EventArgs) Handles Legassembly6.Load
        Legassembly6.setIds(19, 3, 5, Assemblies.eLegLocation.LeftFront)
    End Sub

    Private Sub Legassembly5_Load(sender As Object, e As EventArgs) Handles Legassembly5.Load
        Legassembly5.setIds(2, 4, 6, Assemblies.eLegLocation.RightFront)
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            _tracelistener = New customTextTraceListener(RichTextBox1)
            Trace.Listeners.Add(_tracelistener)

            Text = FormHelpers.ApplicationTitle

            ' upgrade my.settings if needed (basicly uprades on each new version of the app
            FormHelpers.upgradeMySettings()

            _acts = New List(Of Assemblies.servo_ui)
            _acts.AddRange(Legassembly1.getServos)
            _acts.AddRange(Legassembly2.getServos)
            _acts.AddRange(Legassembly3.getServos)
            _acts.AddRange(Legassembly4.getServos)
            _acts.AddRange(Legassembly5.getServos)
            _acts.AddRange(Legassembly6.getServos)

            _legs = New List(Of Assemblies.legassembly)({Legassembly1, Legassembly2, Legassembly3, Legassembly4, Legassembly5, Legassembly6})

            cboBaud.Items.AddRange({"9600", "19200", "38400", "57600", "115200", "250000", "1000000"})
            FillCommPorts()

            If cboPort.Items.Contains(My.Settings.lastPort) Then
                cboPort.SelectedIndex = cboPort.Items.IndexOf(My.Settings.lastPort)
            End If

            If cboBaud.Items.Contains(My.Settings.lastBaud) Then
                cboBaud.SelectedIndex = cboBaud.Items.IndexOf(My.Settings.lastBaud)
            End If

        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub

    Private Sub FillCommPorts()
        Try
            cboPort.Items.Clear()

            For Each sp As String In My.Computer.Ports.SerialPortNames
                cboPort.Items.Add(sp)
            Next
        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FillCommPorts()
    End Sub

    Private Sub ConnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Try
            robo = New robotController(My.Settings.lastPort, CInt(My.Settings.lastBaud), _acts, _legs)

            If Not robo.Connect() Then
                robo = Nothing
            End If
        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub

    Private Sub cmdReadPosAll_Click(sender As Object, e As EventArgs) Handles cmdReadPosAll.Click
        robo.ReadPositions()
    End Sub

    Private Sub cmdTorqueOn_Click(sender As Object, e As EventArgs) Handles cmdTorqueOn.Click
        robo.TorqueOn()
    End Sub

    Private Sub cmdTorqueOff_Click(sender As Object, e As EventArgs) Handles cmdTorqueOff.Click
        robo.TorqueOff()
    End Sub

    Private Sub btnReloadPorts_Click(sender As Object, e As EventArgs) Handles btnReloadPorts.Click
        FillCommPorts()
    End Sub

    Private Sub cboPort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPort.SelectedIndexChanged
        My.Settings.lastPort = cboPort.SelectedItem.ToString
        My.Settings.Save()
    End Sub

    Private Sub cboBaud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBaud.SelectedIndexChanged
        My.Settings.lastBaud = cboBaud.SelectedItem.ToString
        My.Settings.Save()
    End Sub

    Private Sub btnMirrorLR2RR_Click(sender As Object, e As EventArgs) Handles btnMirrorLR2RR.Click
        Try
            For Each servo In Legassembly2.getServos
                Dim otherServo = Legassembly1.getServos.FirstOrDefault(Function(x) x.servoJoint = servo.servoJoint)

                If otherServo IsNot Nothing Then
                    otherServo.servoPosition = 512 + (512 - servo.servoPosition)
                End If
            Next
        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub

    Private Sub btnMirrorRR2LR_Click(sender As Object, e As EventArgs) Handles btnMirrorRR2LR.Click
        Try
            For Each servo In Legassembly1.getServos
                Dim otherServo = Legassembly2.getServos.FirstOrDefault(Function(x) x.servoJoint = servo.servoJoint)

                If otherServo IsNot Nothing Then
                    otherServo.servoPosition = 512 + (512 - servo.servoPosition)
                End If
            Next
        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub
End Class
