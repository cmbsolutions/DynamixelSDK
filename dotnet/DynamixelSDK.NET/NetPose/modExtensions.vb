Imports System.Runtime.CompilerServices

Module FileInfoExtensions

    <Extension()>
    Public Function InUse(ByVal f As IO.FileInfo) As Boolean
        Try
            Using fs As New IO.FileStream(f.FullName, IO.FileMode.Open, IO.FileAccess.ReadWrite, IO.FileShare.ReadWrite)

            End Using
        Catch ex As IO.IOException
            Return True
        Catch ex As Exception
            Return True
        End Try
        Return False
    End Function
End Module

Module ExceptionExtensions

    <Extension()>
    Public Function GetLineNumber(e As Exception) As ExceptionData
        Try

            Dim trace = New StackTrace(e, True)
            Dim x As New ExceptionData

            For Each frame In trace.GetFrames
                If frame.GetFileLineNumber > 0 OrElse frame.GetFileColumnNumber > 0 Then

                    x.FileLineNumber = frame.GetFileLineNumber
                    x.FileColumnNumber = frame.GetFileColumnNumber
                    x.FileName = frame.GetFileName
                    x.FileMethod = frame.GetMethod.Name

                    Exit For
                End If
            Next

            Return x
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Module

Class ExceptionData
    Public Property FileLineNumber As Integer = 0
    Public Property FileColumnNumber As Integer = 0
    Public Property FileName As String = ""
    Public Property FileMethod As String = ""

    Public Overrides Function ToString() As String
        Dim str = String.Format("{4} : File: {0}, Method: {1}, Line: {2}, Column: {3}", FileName, FileMethod, FileLineNumber.ToString, FileColumnNumber.ToString, Now.ToString("yyyy-MM-dd HH:mm:ss"))
        Return str
    End Function
End Class