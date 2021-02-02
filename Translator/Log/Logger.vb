Public Class Logger

    Private LOG_PATH = Environment.CurrentDirectory + "/log.txt"

    Public Sub Logout(Log_Data As String)

        If My.Settings.LOG_Switch = True Then

            Dim SW = New IO.StreamWriter(Environment.CurrentDirectory + "\log.txt", True, Text.Encoding.Default)

            If Not IO.File.Exists(LOG_PATH) Then

                IO.File.Create(LOG_PATH)

            End If

            SW.WriteLine(Log_Data)

            SW.Flush()

            SW.Close()

        End If

    End Sub

End Class
