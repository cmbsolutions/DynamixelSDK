'========================================================================
' This conversion was produced by the Free Edition of
' Instant VB courtesy of Tangible Software Solutions.
' Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
'========================================================================

'''*****************************************************************************
'''* Copyright 2017 ROBOTIS CO., LTD.
'''*
'''* Licensed under the Apache License, Version 2.0 (the "License");
'''* you may not use this file except in compliance with the License.
'''* You may obtain a copy of the License at
'''*
'''*     http://www.apache.org/licenses/LICENSE-2.0
'''*
'''* Unless required by applicable law or agreed to in writing, software
'''* distributed under the License is distributed on an "AS IS" BASIS,
'''* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
'''* See the License for the specific language governing permissions and
'''* limitations under the License.
'''******************************************************************************

' Author: Ryu Woon Jung (Leon) 

'
' *********     Read and Write Example      *********
'
'
' Available DXL model on this example : All models using Protocol 1.0
' This example is designed for using a Dynamixel MX-28, and an USB2DYNAMIXEL.
' To use another Dynamixel model, such as X series, see their details in E-Manual(emanual.robotis.com) and edit below variables yourself.
' Be sure that Dynamixel MX properties are already set as %% ID : 1 / Baudnum : 34 (Baudrate : 57600)
'

Imports System
Imports System.Runtime.InteropServices
Imports dynamixel_sdk

Namespace read_write
  Friend Class ReadWrite
	' Control table address
	Public Const ADDR_MX_TORQUE_ENABLE As Integer = 24 ' Control table address is different in Dynamixel model
	Public Const ADDR_MX_GOAL_POSITION As Integer = 30
	Public Const ADDR_MX_PRESENT_POSITION As Integer = 36

	' Protocol version
	Public Const PROTOCOL_VERSION As Integer = 1 ' See which protocol version is used in the Dynamixel

	' Default setting
	Public Const DXL_ID As Integer = 1 ' Dynamixel ID: 1
	Public Const BAUDRATE As Integer = 57600
	Public Const DEVICENAME As String = "COM1" ' Check which port is being used on your controller
																			' ex) Windows: "COM1"   Linux: "/dev/ttyUSB0" Mac: "/dev/tty.usbserial-*"

	Public Const TORQUE_ENABLE As Integer = 1 ' Value for enabling the torque
	Public Const TORQUE_DISABLE As Integer = 0 ' Value for disabling the torque
	Public Const DXL_MINIMUM_POSITION_VALUE As Integer = 100 ' Dynamixel will rotate between this value
	Public Const DXL_MAXIMUM_POSITION_VALUE As Integer = 4000 ' and this value (note that the Dynamixel would not move when the position value is out of movable range. Check e-manual about the range of the Dynamixel you use.)
	Public Const DXL_MOVING_STATUS_THRESHOLD As Integer = 10 ' Dynamixel moving status threshold

	Public Const ESC_ASCII_VALUE As Byte = &H1b

	Public Const COMM_SUCCESS As Integer = 0 ' Communication Success result value
	Public Const COMM_TX_FAIL As Integer = -1001 ' Communication Tx Failed

	Shared Sub Main(ByVal args() As String)
	  ' Initialize PortHandler Structs
	  ' Set the port path
	  ' Get methods and members of PortHandlerLinux or PortHandlerWindows
	  Dim port_num As Integer = dynamixel.portHandler(DEVICENAME)

	  ' Initialize PacketHandler Structs
	  dynamixel.packetHandler()

	  Dim index As Integer = 0
	  Dim dxl_comm_result As Integer = COMM_TX_FAIL ' Communication result
	  Dim dxl_goal_position() As UInt16 = { DXL_MINIMUM_POSITION_VALUE, DXL_MAXIMUM_POSITION_VALUE } ' Goal position

	  Dim dxl_error As Byte = 0 ' Dynamixel error
	  Dim dxl_present_position As UInt16 = 0 ' Present position

	  ' Open port
	  If dynamixel.openPort(port_num) Then
		Console.WriteLine("Succeeded to open the port!")
	  Else
		Console.WriteLine("Failed to open the port!")
		Console.WriteLine("Press any key to terminate...")
		Console.ReadKey()
		Return
	  End If

	  ' Set port baudrate
	  If dynamixel.setBaudRate(port_num, BAUDRATE) Then
		Console.WriteLine("Succeeded to change the baudrate!")
	  Else
		Console.WriteLine("Failed to change the baudrate!")
		Console.WriteLine("Press any key to terminate...")
		Console.ReadKey()
		Return
	  End If

	  ' Enable Dynamixel Torque
	  dynamixel.write1ByteTxRx(port_num, PROTOCOL_VERSION, DXL_ID, ADDR_MX_TORQUE_ENABLE, TORQUE_ENABLE)
	  dxl_comm_result = dynamixel.getLastTxRxResult(port_num, PROTOCOL_VERSION)
'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
'ORIGINAL LINE: if ((dxl_comm_result = dynamixel.getLastTxRxResult(port_num, PROTOCOL_VERSION)) != COMM_SUCCESS)
	  If dxl_comm_result <> COMM_SUCCESS Then
		Console.WriteLine(Marshal.PtrToStringAnsi(dynamixel.getTxRxResult(PROTOCOL_VERSION, dxl_comm_result)))
	  Else
		  dxl_error = dynamixel.getLastRxPacketError(port_num, PROTOCOL_VERSION)
'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
'ORIGINAL LINE: else if ((dxl_error = dynamixel.getLastRxPacketError(port_num, PROTOCOL_VERSION)) != 0)
		  If dxl_error <> 0 Then
			Console.WriteLine(Marshal.PtrToStringAnsi(dynamixel.getRxPacketError(PROTOCOL_VERSION, dxl_error)))
		  Else
			Console.WriteLine("Dynamixel has been successfully connected")
		  End If
	  End If

	  Do
		Console.WriteLine("Press any key to continue! (or press ESC to quit!)")
		If AscW(Console.ReadKey().KeyChar) = ESC_ASCII_VALUE Then
		  Exit Do
		End If

		' Write goal position
		dynamixel.write2ByteTxRx(port_num, PROTOCOL_VERSION, DXL_ID, ADDR_MX_GOAL_POSITION, dxl_goal_position(index))
		dxl_comm_result = dynamixel.getLastTxRxResult(port_num, PROTOCOL_VERSION)
'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
'ORIGINAL LINE: if ((dxl_comm_result = dynamixel.getLastTxRxResult(port_num, PROTOCOL_VERSION)) != COMM_SUCCESS)
		If dxl_comm_result <> COMM_SUCCESS Then
		  Console.WriteLine(Marshal.PtrToStringAnsi(dynamixel.getTxRxResult(PROTOCOL_VERSION, dxl_comm_result)))
		Else
			dxl_error = dynamixel.getLastRxPacketError(port_num, PROTOCOL_VERSION)
'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
'ORIGINAL LINE: else if ((dxl_error = dynamixel.getLastRxPacketError(port_num, PROTOCOL_VERSION)) != 0)
			If dxl_error <> 0 Then
			  Console.WriteLine(Marshal.PtrToStringAnsi(dynamixel.getRxPacketError(PROTOCOL_VERSION, dxl_error)))
		End If
		End If

		Do
		  ' Read present position
		  dxl_present_position = dynamixel.read2ByteTxRx(port_num, PROTOCOL_VERSION, DXL_ID, ADDR_MX_PRESENT_POSITION)
		  dxl_comm_result = dynamixel.getLastTxRxResult(port_num, PROTOCOL_VERSION)
'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
'ORIGINAL LINE: if ((dxl_comm_result = dynamixel.getLastTxRxResult(port_num, PROTOCOL_VERSION)) != COMM_SUCCESS)
		  If dxl_comm_result <> COMM_SUCCESS Then
			Console.WriteLine(Marshal.PtrToStringAnsi(dynamixel.getTxRxResult(PROTOCOL_VERSION, dxl_comm_result)))
		  Else
			  dxl_error = dynamixel.getLastRxPacketError(port_num, PROTOCOL_VERSION)
'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
'ORIGINAL LINE: else if ((dxl_error = dynamixel.getLastRxPacketError(port_num, PROTOCOL_VERSION)) != 0)
			  If dxl_error <> 0 Then
				Console.WriteLine(Marshal.PtrToStringAnsi(dynamixel.getRxPacketError(PROTOCOL_VERSION, dxl_error)))
		  End If
		  End If

		  Console.WriteLine("[ID: {0}] GoalPos: {1}  PresPos: {2}", DXL_ID, dxl_goal_position(index), dxl_present_position)

		Loop While (Math.Abs(dxl_goal_position(index) - dxl_present_position) > DXL_MOVING_STATUS_THRESHOLD)

		' Change goal position
		If index = 0 Then
		  index = 1
		Else
		  index = 0
		End If
	  Loop

	  ' Disable Dynamixel Torque
	  dynamixel.write1ByteTxRx(port_num, PROTOCOL_VERSION, DXL_ID, ADDR_MX_TORQUE_ENABLE, TORQUE_DISABLE)
	  dxl_comm_result = dynamixel.getLastTxRxResult(port_num, PROTOCOL_VERSION)
'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
'ORIGINAL LINE: if ((dxl_comm_result = dynamixel.getLastTxRxResult(port_num, PROTOCOL_VERSION)) != COMM_SUCCESS)
	  If dxl_comm_result <> COMM_SUCCESS Then
		Console.WriteLine(Marshal.PtrToStringAnsi(dynamixel.getTxRxResult(PROTOCOL_VERSION, dxl_comm_result)))
	  Else
		  dxl_error = dynamixel.getLastRxPacketError(port_num, PROTOCOL_VERSION)
'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
'ORIGINAL LINE: else if ((dxl_error = dynamixel.getLastRxPacketError(port_num, PROTOCOL_VERSION)) != 0)
		  If dxl_error <> 0 Then
			Console.WriteLine(Marshal.PtrToStringAnsi(dynamixel.getRxPacketError(PROTOCOL_VERSION, dxl_error)))
	  End If
	  End If

	  ' Close port
	  dynamixel.closePort(port_num)

	  Return
	End Sub
  End Class
End Namespace
