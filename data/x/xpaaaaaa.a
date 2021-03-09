Public Class ReportService
    Implements IReportService

    Private _report As IReport
    Public Sub New(ByVal report As IReport)
        _report = report
    End Sub
    Public Sub ShowReportParameters() Implements IReportService.ShowReportParameters
        _report.ShowReport()
    End Sub
End Class
