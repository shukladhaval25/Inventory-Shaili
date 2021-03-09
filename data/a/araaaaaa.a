Public Class FileLogger
    Implements ILogger
    Dim loggerFilePath As String = System.IO.Path.Combine(Application.StartupPath, "Logs\AppLog.log")
    Public Sub ClearLog() Implements ILogger.ClearLog

    End Sub

    Public Function GetLog() As String Implements ILogger.GetLog

    End Function

    Public Sub WriteLog(ByVal logs As Logs) Implements ILogger.WriteLog
        validateLoggerFile()
        Dim errorinfo As String = convertLogsToString(logs)
        System.IO.File.AppendAllText(loggerFilePath, errorinfo)
    End Sub

    Private Sub validateLoggerFile()
        If (System.IO.File.Exists(loggerFilePath) = False) Then
            If (System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(loggerFilePath)) = False) Then
                System.IO.Directory.CreateDirectory(Application.StartupPath & "/Logs")
                System.IO.File.Create(loggerFilePath)
            End If
        End If
    End Sub
    Private Function convertLogsToString(ByVal logs As Logs) As String
        Dim errorInfo As String = String.Empty
        errorInfo += "*************************************************************************" + System.Environment.NewLine
        errorInfo += "Date :" + logs.LogDate + System.Environment.NewLine
        errorInfo += "Machine Name :" + logs.MachineName + System.Environment.NewLine
        errorInfo += "Product Version :" + logs.ProductVersion + System.Environment.NewLine
        errorInfo += "Method :" + logs.Method + System.Environment.NewLine
        errorInfo += "User :" + logs.User + System.Environment.NewLine
        errorInfo += "Error Message :" + logs.ErrorMessage + System.Environment.NewLine
        errorInfo += "Details :" + logs.Details + System.Environment.NewLine
        Return errorInfo
    End Function
End Class
