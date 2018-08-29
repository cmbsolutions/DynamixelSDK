Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports DynamixelSDK.NET.dynamixel_sdk
Public Class robotController
    Public Const ADDR_AX_TORQUE_ENABLE As Integer = 24 ' Control table address is different in Dynamixel model
    Public Const ADDR_AX_GOAL_POSITION As Integer = 30
    Public Const ADDR_AX_PRESENT_POSITION As Integer = 36

    ' Protocol version
    Public Const PROTOCOL_VERSION As Integer = 1 ' See which protocol version is used in the Dynamixel

    Public Const TORQUE_ENABLE As Integer = 1 ' Value for enabling the torque
    Public Const TORQUE_DISABLE As Integer = 0 ' Value for disabling the torque
    Public Const DXL_MINIMUM_POSITION_VALUE As Integer = 0 ' Dynamixel will rotate between this value
    Public Const DXL_MAXIMUM_POSITION_VALUE As Integer = 1023 ' and this value (note that the Dynamixel would not move when the position value is out of movable range. Check e-manual about the range of the Dynamixel you use.)
    Public Const DXL_MOVING_STATUS_THRESHOLD As Integer = 10 ' Dynamixel moving status threshold

    Public Const ESC_ASCII_VALUE As Byte = &H1B

    Public Const COMM_SUCCESS As Integer = 0 ' Communication Success result value
    Public Const COMM_TX_FAIL As Integer = -1001 ' Communication Tx Failed

    Public Property BaudRate As Integer = 57600
    Public Property CommPort As String = "COM1" ' Check which port is being used on your controller
    Public WithEvents acts As List(Of Assemblies.servo_ui)
    Public WithEvents lgs As List(Of Assemblies.legassembly)

    Private _bgWorker As BackgroundWorker


    Private dxl_port_num As Integer
    Private dxl_comm_result As Integer = COMM_TX_FAIL
    Private dxl_error As Byte = 0

    Sub New(ByVal port As String, ByVal baud As Integer, ByRef actuators As List(Of Assemblies.servo_ui), ByRef legs As List(Of Assemblies.legassembly))
        Try
            BaudRate = baud
            CommPort = port
            acts = actuators
            lgs = legs

            _bgWorker = New BackgroundWorker With {.WorkerReportsProgress = True, .WorkerSupportsCancellation = True}
            AddHandler _bgWorker.DoWork, AddressOf DoBackgroundPorcessing

            dxl_port_num = dynamixel.portHandler(CommPort)
            dynamixel.packetHandler()

        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub

    Private Sub DoBackgroundPorcessing(sender As Object, e As DoWorkEventArgs)
        Try
            Dim stillMoving As Boolean = True

            Do
                For Each actuator In acts.OrderBy(Function(x) x.servoId)
                    actuator.servoPresentPosition = dynamixel.read2ByteTxRx(dxl_port_num, PROTOCOL_VERSION, Convert.ToByte(actuator.servoId), ADDR_AX_PRESENT_POSITION)
                    dxl_comm_result = dynamixel.getLastTxRxResult(dxl_port_num, PROTOCOL_VERSION)

                    If dxl_comm_result <> COMM_SUCCESS Then
                        actuator.setError(Marshal.PtrToStringAnsi(dynamixel.getTxRxResult(PROTOCOL_VERSION, dxl_comm_result)))
                    Else
                        dxl_error = dynamixel.getLastRxPacketError(dxl_port_num, PROTOCOL_VERSION)
                        If dxl_error <> 0 Then
                            actuator.setError(Marshal.PtrToStringAnsi(dynamixel.getRxPacketError(PROTOCOL_VERSION, dxl_error)))
                        Else

                            If Math.Abs(actuator.servoGoalPosition - actuator.servoPresentPosition) > DXL_MOVING_STATUS_THRESHOLD Then
                                stillMoving = True
                            Else
                                stillMoving = False
                            End If
                            actuator.servoPosition = actuator.servoPresentPosition
                        End If
                    End If
                Next

            Loop While stillMoving
        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub

    Public Function Connect() As Boolean
        Try
            If dynamixel.openPort(dxl_port_num) Then
                FormHelpers.dumpException(New Exception(String.Format("Port {0} is open.", CommPort)))

                If dynamixel.setBaudRate(dxl_port_num, BaudRate) Then
                    FormHelpers.dumpException(New Exception(String.Format("Baudrate changed to {0}.", BaudRate)))
                Else
                    FormHelpers.dumpException(New Exception("Baudrate change failed!"))
                    Return False
                End If
            Else
                FormHelpers.dumpException(New Exception("Opening port has failed!"))
                Return False
            End If

            Return TestActuators()
        Catch ex As Exception
            FormHelpers.dumpException(ex)
            Return False
        End Try
    End Function

    Public Sub Disconnect()
        dynamixel.closePort(dxl_port_num)
    End Sub

    Private Function TestActuators() As Boolean
        Try
            For Each actuator In acts.OrderBy(Function(x) x.servoId)
                dynamixel.write1ByteTxRx(dxl_port_num, PROTOCOL_VERSION, Convert.ToByte(actuator.servoId), ADDR_AX_TORQUE_ENABLE, TORQUE_ENABLE)
                dxl_comm_result = dynamixel.getLastTxRxResult(dxl_port_num, PROTOCOL_VERSION)

                If dxl_comm_result <> COMM_SUCCESS Then
                    actuator.setError(Marshal.PtrToStringAnsi(dynamixel.getTxRxResult(PROTOCOL_VERSION, dxl_comm_result)))
                Else
                    dxl_error = dynamixel.getLastRxPacketError(dxl_port_num, PROTOCOL_VERSION)
                    If dxl_error <> 0 Then
                        actuator.setError(Marshal.PtrToStringAnsi(dynamixel.getRxPacketError(PROTOCOL_VERSION, dxl_error)))
                    Else
                        actuator.resetError()
                        actuator.setTorque(True)
                    End If
                End If
            Next

            Return True
        Catch ex As Exception
            FormHelpers.dumpException(ex)
            Return False
        End Try
    End Function

    Public Function ReadPositions() As Boolean
        Try
            For Each actuator In acts.OrderBy(Function(x) x.servoId)
                actuator.servoPresentPosition = dynamixel.read2ByteTxRx(dxl_port_num, PROTOCOL_VERSION, Convert.ToByte(actuator.servoId), ADDR_AX_PRESENT_POSITION)
                dxl_comm_result = dynamixel.getLastTxRxResult(dxl_port_num, PROTOCOL_VERSION)

                If dxl_comm_result <> COMM_SUCCESS Then
                    actuator.setError(Marshal.PtrToStringAnsi(dynamixel.getTxRxResult(PROTOCOL_VERSION, dxl_comm_result)))
                Else
                    dxl_error = dynamixel.getLastRxPacketError(dxl_port_num, PROTOCOL_VERSION)
                    If dxl_error <> 0 Then
                        actuator.setError(Marshal.PtrToStringAnsi(dynamixel.getRxPacketError(PROTOCOL_VERSION, dxl_error)))
                    Else
                        actuator.servoPosition = actuator.servoPresentPosition
                    End If
                End If
            Next
            Return True
        Catch ex As Exception
            FormHelpers.dumpException(ex)
            Return False
        End Try
    End Function

    Public Function WritePositions() As Boolean
        Try
            For Each actuator In acts.OrderBy(Function(x) x.servoId)
                actuator.servoGoalPosition = Convert.ToUInt16(actuator.servoPosition)
                dynamixel.write2ByteTxRx(dxl_port_num, PROTOCOL_VERSION, Convert.ToByte(actuator.servoId), ADDR_AX_GOAL_POSITION, actuator.servoGoalPosition)
                dxl_comm_result = dynamixel.getLastTxRxResult(dxl_port_num, PROTOCOL_VERSION)

                If dxl_comm_result <> COMM_SUCCESS Then
                    actuator.setError(Marshal.PtrToStringAnsi(dynamixel.getTxRxResult(PROTOCOL_VERSION, dxl_comm_result)))
                Else
                    dxl_error = dynamixel.getLastRxPacketError(dxl_port_num, PROTOCOL_VERSION)
                    If dxl_error <> 0 Then
                        actuator.setError(Marshal.PtrToStringAnsi(dynamixel.getRxPacketError(PROTOCOL_VERSION, dxl_error)))
                    End If
                End If
            Next

            If Not _bgWorker.IsBusy Then _bgWorker.RunWorkerAsync()

            Return True
        Catch ex As Exception
            FormHelpers.dumpException(ex)
            Return False
        End Try
    End Function

    Public Function TorqueOn() As Boolean
        Return TestActuators()
    End Function

    Public Function TorqueOff() As Boolean
        Try
            For Each actuator In acts.OrderBy(Function(x) x.servoId)
                dynamixel.write1ByteTxRx(dxl_port_num, PROTOCOL_VERSION, Convert.ToByte(actuator.servoId), ADDR_AX_TORQUE_ENABLE, TORQUE_DISABLE)
                dxl_comm_result = dynamixel.getLastTxRxResult(dxl_port_num, PROTOCOL_VERSION)

                If dxl_comm_result <> COMM_SUCCESS Then
                    actuator.setError(Marshal.PtrToStringAnsi(dynamixel.getTxRxResult(PROTOCOL_VERSION, dxl_comm_result)))
                Else
                    dxl_error = dynamixel.getLastRxPacketError(dxl_port_num, PROTOCOL_VERSION)
                    If dxl_error <> 0 Then
                        actuator.setError(Marshal.PtrToStringAnsi(dynamixel.getRxPacketError(PROTOCOL_VERSION, dxl_error)))
                    Else
                        actuator.resetError()
                        actuator.setTorque(False)
                    End If
                End If
            Next

            Return True
        Catch ex As Exception
            FormHelpers.dumpException(ex)
            Return False
        End Try
    End Function
End Class
