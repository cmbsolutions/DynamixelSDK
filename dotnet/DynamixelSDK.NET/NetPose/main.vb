Public Class main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Panel1.Width = 32 Then
            Panel1.Width = 492
            Panel1.Left = Width - 17 - Panel1.Width
        Else
            Panel1.Width = 32
            Panel1.Left = Width - 17 - Panel1.Width
        End If
    End Sub
End Class
