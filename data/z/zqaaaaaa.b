Public Class Logs
    Property LogDate As Date = Now
    Property Method As String
    Property ErrorMessage As String
    Property Details As String
    Property MachineName As String = System.Environment.MachineName
    Property User As String = strGVUserID
    Property ProductVersion As String = Application.ProductVersion
End Class
