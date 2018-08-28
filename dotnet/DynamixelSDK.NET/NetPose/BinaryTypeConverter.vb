Imports System.Reflection
Imports System.Runtime.Serialization
Imports System.Text.RegularExpressions

Public Class BinaryTypeConverter
    Inherits SerializationBinder

    Public Overrides Function BindToType(assemblyName As String, typeName As String) As Type
        Dim returnType As Type = Nothing

        If typeName.Contains("NetPose.") Then
            typeName = typeName.Replace("SentiMan.", "SentiMan.v2.")
        End If

        Dim RegexObj As New Regex("NetPose, Version=(?:\d+|\.)+, Culture=neutral, PublicKeyToken=null", RegexOptions.IgnoreCase)

        If RegexObj.IsMatch(assemblyName) Then
            assemblyName = Assembly.GetExecutingAssembly.FullName

            returnType = Type.GetType(String.Format("{0}, {1}", typeName, assemblyName))
        End If

        If RegexObj.IsMatch(typeName) Then
            typeName = RegexObj.Replace(typeName, Assembly.GetExecutingAssembly.FullName)

            returnType = Type.GetType(String.Format("{0}, {1}", typeName, assemblyName))
        End If
        Return returnType
    End Function
End Class