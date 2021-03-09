Public Class ReportManager
    Public Function GetReportInstance(ByVal reportName As String) As IReport
        Dim report As IReport
        Select Case reportName
            Case "Expiration"
                report = New FG_Expiration
            Case "Expired"
                report = New FGExpired
            Case "BWFG"
                report = New BWFG
            Case "Semi_FG_Stock"
                report = New Semi_FG_Stock
            Case "Semi_FG_Stock_Cons"
                report = New Semi_FG_Stock_Cons
            Case "Semi_FG_Stock_Group"
                report = New Semi_FG_Stock_Group
            Case "DW_PackingVI"
                report = New DateWisePackingVI
            Case "Rejection_Component_FG", "Rejection_Component_SFG"
                report = New RejectionComponent()
            Case "SemiFG_Wise_RM_Rejection", "FG_Wise_RM_Rejection"
                report = New ProductWiseRejectionReport
            Case "LineClearance"
                report = New LineClearance
            Case "QC_WO_Register"
                report = New QC_WO_Register
        End Select

        Return report
    End Function
End Class
