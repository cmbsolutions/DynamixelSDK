Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

<Serializable>
Public Class SerializableBindingList(Of T)
    Inherits BindingList(Of T)

    Public Sub SaveToFile(file As IO.FileInfo)
        Try
            Dim formatter As New BinaryFormatter

            If Not file.Directory.Exists Then file.Directory.Create()

            If file.Exists Then
                While file.InUse
                    If MessageBox.Show(String.Format("File {0} is used by someone else.", file.Name), "Can't save file", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) = DialogResult.Cancel Then
                        Exit Sub
                    End If
                End While
            End If

            Using data As New FileStream(file.FullName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite)
                formatter.Serialize(data, Items)
            End Using

            formatter = Nothing
        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub

    Public Sub LoadFromFile(file As IO.FileInfo)
        Try
            If file.Exists Then
                Dim formatter As New BinaryFormatter

                If file.Extension <> "cm2" Then formatter.Binder = New BinaryTypeConverter


                Dim localList As IList(Of T)
                Using data As New FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                    localList = DirectCast(formatter.Deserialize(data), IList(Of T))
                End Using
                formatter = Nothing

                For Each itm In localList
                    Add(itm)
                Next
            End If
        Catch ex As Exception
            FormHelpers.dumpException(ex)
        End Try
    End Sub

    Public Sub AddRange(items As List(Of T))
        For Each itm In items
            Add(itm)
        Next
    End Sub
End Class
