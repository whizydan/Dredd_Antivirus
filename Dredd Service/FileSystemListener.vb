Public Class FileSystemListener

    Protected Overrides Sub OnStart(ByVal args() As String)
        ' Add code here to start your service. This method should set things
        ' in motion so your service can do its work.
        Timer1.Enabled = True
    End Sub

    Protected Overrides Sub OnStop()
        ' Add code here to perform any tear-down necessary to stop your service.
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim MyLog As New EventLog() ' create a new event log

        ' Check if the the Event Log Exists
        If Not MyLog.SourceExists("MyService") Then
            MyLog.CreateEventSource("MyService", "Myservice Log") ' Create Log
        End If

        MyLog.Source = "MyService"

        ' Write to the Log
        MyLog.WriteEntry("MyService Log", "This is log on " &
                                    CStr(TimeOfDay), EventLogEntryType.Information)
    End Sub
End Class
