Public Class legassembly
    Private Sub tbCoxa_Scroll(sender As Object, e As EventArgs) Handles tbCoxa.Scroll
        nudCoxa.Value = tbCoxa.Value
    End Sub

    Private Sub nudCoxa_ValueChanged(sender As Object, e As EventArgs) Handles nudCoxa.ValueChanged
        tbCoxa.Value = nudCoxa.Value
    End Sub

    Private Sub tbFemur_Scroll(sender As Object, e As EventArgs) Handles tbFemur.Scroll
        nudFemur.Value = tbFemur.Value
    End Sub

    Private Sub nudFemur_ValueChanged(sender As Object, e As EventArgs) Handles nudFemur.ValueChanged
        tbFemur.Value = nudFemur.Value
    End Sub

    Private Sub tbTibia_Scroll(sender As Object, e As EventArgs) Handles tbTibia.Scroll
        nudTibia.Value = tbTibia.Value
    End Sub

    Private Sub nudTibia_ValueChanged(sender As Object, e As EventArgs) Handles nudTibia.ValueChanged
        tbTibia.Value = nudTibia.Value
    End Sub
End Class
