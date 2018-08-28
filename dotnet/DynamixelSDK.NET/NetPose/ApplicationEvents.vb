Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Try
                FormHelpers.upgradeMySettings()

                'If My.Settings.CheckUpdates Then

                '    Dim currentVersion As String = String.Format("{0}.{1}.{2}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build)

                '    If IO.Directory.Exists(My.Settings.UpdateLocation) Then
                '        Dim doUpdate As Boolean = False

                '        ' Find latest setup
                '        Dim latestSetup As String = (From f In IO.Directory.EnumerateFiles(My.Settings.updateLocation, "SentiManSetup*.exe", IO.SearchOption.TopDirectoryOnly) Order By f Select f).LastOrDefault

                '        Dim major, minor, build As Integer
                '        Dim RegexObj As New Regex("SentiManSetup(\d+).(\d+).(\d+).exe$", RegexOptions.IgnoreCase Or RegexOptions.Multiline)
                '        Dim updateVersion As String = currentVersion

                '        If RegexObj.IsMatch(latestSetup) Then
                '            major = Convert.ToInt32(RegexObj.Match(latestSetup).Groups(1).Value)
                '            minor = Convert.ToInt32(RegexObj.Match(latestSetup).Groups(2).Value)
                '            build = Convert.ToInt32(RegexObj.Match(latestSetup).Groups(3).Value)

                '            If major > My.Application.Info.Version.Major Then doUpdate = True
                '            If major >= My.Application.Info.Version.Major And minor > My.Application.Info.Version.Minor Then doUpdate = True
                '            If major >= My.Application.Info.Version.Major And minor >= My.Application.Info.Version.Minor And build > My.Application.Info.Version.Build Then doUpdate = True

                '            updateVersion = String.Format("{0}.{1}.{2}", major, minor, build)

                '            If updateVersion = My.Settings.lastUpdate Then doUpdate = False
                '        End If

                '        If doUpdate AndAlso My.Settings.AutoUpdate Then
                '            My.Settings.lastUpdate = updateVersion
                '            My.Settings.Save()

                '            Dim pinfo As New ProcessStartInfo(latestSetup, "/VERYSILENT /SUPPRESSMSGBOXES /NOCANCEL /NORESTART /CLOSEAPPLICATIONS /FORCECLOSEAPPLICATIONS /RESTARTAPPLICATIONS")
                '            Dim p As New Process()
                '            p.StartInfo = pinfo

                '            p.Start()
                '        End If
                '    End If
                'End If
            Catch ex As Exception
                FormHelpers.dumpException(ex)
            End Try
        End Sub
    End Class
End Namespace
