#Disable Warning BC42312 ' XML documentation comments must precede member or type declarations
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

Imports System
#Enable Warning BC42312 ' XML documentation comments must precede member or type declarations
Imports System.Runtime.InteropServices

Namespace dynamixel_sdk
    Public Class dynamixel
        Private Const dll_path As String = ".\Dynamixel\dxl_x64_c.dll"

#Region "PortHandler"
        <DllImport(dll_path)>
        Public Shared Function portHandler(ByVal port_name As String) As Integer
        End Function

        <DllImport(dll_path)>
        Public Shared Function openPort(ByVal port_num As Integer) As Boolean
        End Function
        <DllImport(dll_path)>
        Public Shared Sub closePort(ByVal port_num As Integer)
        End Sub
        <DllImport(dll_path)>
        Public Shared Sub clearPort(ByVal port_num As Integer)
        End Sub

        <DllImport(dll_path)>
        Public Shared Sub setPortName(ByVal port_num As Integer, ByVal port_name As String)
        End Sub
        <DllImport(dll_path)>
        Public Shared Function getPortName(ByVal port_num As Integer) As String
        End Function

        <DllImport(dll_path)>
        Public Shared Function setBaudRate(ByVal port_num As Integer, ByVal baudrate As Integer) As Boolean
        End Function
        <DllImport(dll_path)>
        Public Shared Function getBaudRate(ByVal port_num As Integer) As Integer
        End Function

        <DllImport(dll_path)>
        Public Shared Function readPort(ByVal port_num As Integer, ByVal packet() As Byte, ByVal length As Integer) As Integer
        End Function
        <DllImport(dll_path)>
        Public Shared Function writePort(ByVal port_num As Integer, ByVal packet() As Byte, ByVal length As Integer) As Integer
        End Function

        <DllImport(dll_path)>
        Public Shared Sub setPacketTimeout(ByVal port_num As Integer, ByVal packet_length As UInt16)
        End Sub
        <DllImport(dll_path)>
        Public Shared Sub setPacketTimeoutMSec(ByVal port_num As Integer, ByVal msec As Double)
        End Sub
        <DllImport(dll_path)>
        Public Shared Function isPacketTimeout(ByVal port_num As Integer) As Boolean
        End Function
#End Region

#Region "PacketHandler"
        <DllImport(dll_path)>
        Public Shared Sub packetHandler()
        End Sub

        <DllImport(dll_path)>
        Public Shared Function getTxRxResult(ByVal protocol_version As Integer, ByVal result As Integer) As IntPtr
        End Function
        <DllImport(dll_path)>
        Public Shared Function getRxPacketError(ByVal protocol_version As Integer, ByVal [error] As Byte) As IntPtr
        End Function

        <DllImport(dll_path)>
        Public Shared Function getLastTxRxResult(ByVal port_num As Integer, ByVal protocol_version As Integer) As Integer
        End Function
        <DllImport(dll_path)>
        Public Shared Function getLastRxPacketError(ByVal port_num As Integer, ByVal protocol_version As Integer) As Byte
        End Function

        <DllImport(dll_path)>
        Public Shared Sub setDataWrite(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal data_length As UInt16, ByVal data_pos As UInt16, ByVal data As UInt32)
        End Sub
        <DllImport(dll_path)>
        Public Shared Function getDataRead(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal data_length As UInt16, ByVal data_pos As UInt16) As UInt32
        End Function

        <DllImport(dll_path)>
        Public Shared Sub txPacket(ByVal port_num As Integer, ByVal protocol_version As Integer)
        End Sub

        <DllImport(dll_path)>
        Public Shared Sub rxPacket(ByVal port_num As Integer, ByVal protocol_version As Integer)
        End Sub

        <DllImport(dll_path)>
        Public Shared Sub txRxPacket(ByVal port_num As Integer, ByVal protocol_version As Integer)
        End Sub

        <DllImport(dll_path)>
        Public Shared Sub ping(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal id As Byte)
        End Sub

        <DllImport(dll_path)>
        Public Shared Function pingGetModelNum(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal id As Byte) As UInt16
        End Function

        <DllImport(dll_path)>
        Public Shared Sub broadcastPing(ByVal port_num As Integer, ByVal protocol_version As Integer)
        End Sub
        <DllImport(dll_path)>
        Public Shared Function getBroadcastPingResult(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal id As Integer) As Boolean
        End Function

        <DllImport(dll_path)>
        Public Shared Sub reboot(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal id As Byte)
        End Sub

        <DllImport(dll_path)>
        Public Shared Sub factoryReset(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal id As Byte, ByVal [option] As Byte)
        End Sub

        <DllImport(dll_path)>
        Public Shared Sub readTx(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal id As Byte, ByVal address As UInt16, ByVal length As UInt16)
        End Sub
        <DllImport(dll_path)>
        Public Shared Sub readRx(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal length As UInt16)
        End Sub
        <DllImport(dll_path)>
        Public Shared Sub readTxRx(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal id As Byte, ByVal address As UInt16, ByVal length As UInt16)
        End Sub

        <DllImport(dll_path)>
        Public Shared Sub read1ByteTx(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal id As Byte, ByVal address As UInt16)
        End Sub
        <DllImport(dll_path)>
        Public Shared Function read1ByteRx(ByVal port_num As Integer, ByVal protocol_version As Integer) As Byte
        End Function
        <DllImport(dll_path)>
        Public Shared Function read1ByteTxRx(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal id As Byte, ByVal address As UInt16) As Byte
        End Function

        <DllImport(dll_path)>
        Public Shared Sub read2ByteTx(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal id As Byte, ByVal address As UInt16)
        End Sub
        <DllImport(dll_path)>
        Public Shared Function read2ByteRx(ByVal port_num As Integer, ByVal protocol_version As Integer) As UInt16
        End Function
        <DllImport(dll_path)>
        Public Shared Function read2ByteTxRx(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal id As Byte, ByVal address As UInt16) As UInt16
        End Function

        <DllImport(dll_path)>
        Public Shared Sub read4ByteTx(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal id As Byte, ByVal address As UInt16)
        End Sub
        <DllImport(dll_path)>
        Public Shared Function read4ByteRx(ByVal port_num As Integer, ByVal protocol_version As Integer) As UInt32
        End Function
        <DllImport(dll_path)>
        Public Shared Function read4ByteTxRx(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal id As Byte, ByVal address As UInt16) As UInt32
        End Function

        <DllImport(dll_path)>
        Public Shared Sub writeTxOnly(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal id As Byte, ByVal address As UInt16, ByVal length As UInt16)
        End Sub
        <DllImport(dll_path)>
        Public Shared Sub writeTxRx(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal id As Byte, ByVal address As UInt16, ByVal length As UInt16)
        End Sub

        <DllImport(dll_path)>
        Public Shared Sub write1ByteTxOnly(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal id As Byte, ByVal address As UInt16, ByVal data As Byte)
        End Sub
        <DllImport(dll_path)>
        Public Shared Sub write1ByteTxRx(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal id As Byte, ByVal address As UInt16, ByVal data As Byte)
        End Sub

        <DllImport(dll_path)>
        Public Shared Sub write2ByteTxOnly(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal id As Byte, ByVal address As UInt16, ByVal data As UInt16)
        End Sub
        <DllImport(dll_path)>
        Public Shared Sub write2ByteTxRx(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal id As Byte, ByVal address As UInt16, ByVal data As UInt16)
        End Sub

        <DllImport(dll_path)>
        Public Shared Sub write4ByteTxOnly(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal id As Byte, ByVal address As UInt16, ByVal data As UInt32)
        End Sub
        <DllImport(dll_path)>
        Public Shared Sub write4ByteTxRx(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal id As Byte, ByVal address As UInt16, ByVal data As UInt32)
        End Sub

        <DllImport(dll_path)>
        Public Shared Sub regWriteTxOnly(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal id As Byte, ByVal address As UInt16, ByVal length As UInt16)
        End Sub
        <DllImport(dll_path)>
        Public Shared Sub regWriteTxRx(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal id As Byte, ByVal address As UInt16, ByVal length As UInt16)
        End Sub

        <DllImport(dll_path)>
        Public Shared Sub syncReadTx(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal start_address As UInt16, ByVal data_length As UInt16, ByVal param_length As UInt16)
        End Sub
        ' syncReadRx   -> GroupSyncRead
        ' syncReadTxRx -> GroupSyncRead

        <DllImport(dll_path)>
        Public Shared Sub syncWriteTxOnly(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal start_address As UInt16, ByVal data_length As UInt16, ByVal param_length As UInt16)
        End Sub

        <DllImport(dll_path)>
        Public Shared Sub bulkReadTx(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal param_length As UInt16)
        End Sub
        ' bulkReadRx   -> GroupBulkRead
        ' bulkReadTxRx -> GroupBulkRead

        <DllImport(dll_path)>
        Public Shared Sub bulkWriteTxOnly(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal param_length As UInt16)
        End Sub
#End Region

#Region "GroupBulkRead"
        <DllImport(dll_path)>
        Public Shared Function groupBulkRead(ByVal port_num As Integer, ByVal protocol_version As Integer) As Integer
        End Function

        <DllImport(dll_path)>
        Public Shared Function groupBulkReadAddParam(ByVal group_num As Integer, ByVal id As Byte, ByVal start_address As UInt16, ByVal data_length As UInt16) As Boolean
        End Function
        <DllImport(dll_path)>
        Public Shared Sub groupBulkReadRemoveParam(ByVal group_num As Integer, ByVal id As Byte)
        End Sub
        <DllImport(dll_path)>
        Public Shared Sub groupBulkReadClearParam(ByVal group_num As Integer)
        End Sub

        <DllImport(dll_path)>
        Public Shared Sub groupBulkReadTxPacket(ByVal group_num As Integer)
        End Sub
        <DllImport(dll_path)>
        Public Shared Sub groupBulkReadRxPacket(ByVal group_num As Integer)
        End Sub
        <DllImport(dll_path)>
        Public Shared Sub groupBulkReadTxRxPacket(ByVal group_num As Integer)
        End Sub

        <DllImport(dll_path)>
        Public Shared Function groupBulkReadIsAvailable(ByVal group_num As Integer, ByVal id As Byte, ByVal address As UInt16, ByVal data_length As UInt16) As Boolean
        End Function
        <DllImport(dll_path)>
        Public Shared Function groupBulkReadGetData(ByVal group_num As Integer, ByVal id As Byte, ByVal address As UInt16, ByVal data_length As UInt16) As UInt32
        End Function
#End Region

#Region "GroupBulkWrite"
        <DllImport(dll_path)>
        Public Shared Function groupBulkWrite(ByVal port_num As Integer, ByVal protocol_version As Integer) As Integer
        End Function

        <DllImport(dll_path)>
        Public Shared Function groupBulkWriteAddParam(ByVal group_num As Integer, ByVal id As Byte, ByVal start_address As UInt16, ByVal data_length As UInt16, ByVal data As UInt32, ByVal input_length As UInt16) As Boolean
        End Function
        <DllImport(dll_path)>
        Public Shared Sub groupBulkWriteRemoveParam(ByVal group_num As Integer, ByVal id As Byte)
        End Sub
        <DllImport(dll_path)>
        Public Shared Function groupBulkWriteChangeParam(ByVal group_num As Integer, ByVal id As Byte, ByVal start_address As UInt16, ByVal data_length As UInt16, ByVal data As UInt32, ByVal input_length As UInt16, ByVal data_pos As UInt16) As Boolean
        End Function
        <DllImport(dll_path)>
        Public Shared Sub groupBulkWriteClearParam(ByVal group_num As Integer)
        End Sub

        <DllImport(dll_path)>
        Public Shared Sub groupBulkWriteTxPacket(ByVal group_num As Integer)
        End Sub
#End Region

#Region "GroupSyncRead"
        <DllImport(dll_path)>
        Public Shared Function groupSyncRead(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal start_address As UInt16, ByVal data_length As UInt16) As Integer
        End Function

        <DllImport(dll_path)>
        Public Shared Function groupSyncReadAddParam(ByVal group_num As Integer, ByVal id As Byte) As Boolean
        End Function
        <DllImport(dll_path)>
        Public Shared Sub groupSyncReadRemoveParam(ByVal group_num As Integer, ByVal id As Byte)
        End Sub
        <DllImport(dll_path)>
        Public Shared Sub groupSyncReadClearParam(ByVal group_num As Integer)
        End Sub

        <DllImport(dll_path)>
        Public Shared Sub groupSyncReadTxPacket(ByVal group_num As Integer)
        End Sub
        <DllImport(dll_path)>
        Public Shared Sub groupSyncReadRxPacket(ByVal group_num As Integer)
        End Sub
        <DllImport(dll_path)>
        Public Shared Sub groupSyncReadTxRxPacket(ByVal group_num As Integer)
        End Sub

        <DllImport(dll_path)>
        Public Shared Function groupSyncReadIsAvailable(ByVal group_num As Integer, ByVal id As Byte, ByVal address As UInt16, ByVal data_length As UInt16) As Boolean
        End Function
        <DllImport(dll_path)>
        Public Shared Function groupSyncReadGetData(ByVal group_num As Integer, ByVal id As Byte, ByVal address As UInt16, ByVal data_length As UInt16) As UInt32
        End Function
#End Region

#Region "GroupSyncWrite"
        <DllImport(dll_path)>
        Public Shared Function groupSyncWrite(ByVal port_num As Integer, ByVal protocol_version As Integer, ByVal start_address As UInt16, ByVal data_length As UInt16) As Integer
        End Function

        <DllImport(dll_path)>
        Public Shared Function groupSyncWriteAddParam(ByVal group_num As Integer, ByVal id As Byte, ByVal data As UInt32, ByVal data_length As UInt16) As Boolean
        End Function
        <DllImport(dll_path)>
        Public Shared Sub groupSyncWriteRemoveParam(ByVal group_num As Integer, ByVal id As Byte)
        End Sub
        <DllImport(dll_path)>
        Public Shared Function groupSyncWriteChangeParam(ByVal group_num As Integer, ByVal id As Byte, ByVal data As UInt32, ByVal data_length As UInt16, ByVal data_pos As UInt16) As Boolean
        End Function
        <DllImport(dll_path)>
        Public Shared Sub groupSyncWriteClearParam(ByVal group_num As Integer)
        End Sub

        <DllImport(dll_path)>
        Public Shared Sub groupSyncWriteTxPacket(ByVal group_num As Integer)
        End Sub
#End Region
    End Class
End Namespace
