﻿Public Class ProductWiseRejectionReport
    Implements IReport
    Dim frmpara As frmPara1
    Public Sub ShowReport() Implements IReport.ShowReport
        frmpara = New frmPara1
        frmpara.strReport = stractivetable
        If (isReportForSemiFinishGood()) Then
            setParameterFormForSemiFinishGood()
        Else
            setParameterFormForFinishGood()
        End If

        frmpara.grpdate.Visible = True

        If (frmpara.ShowDialog() = DialogResult.OK) Then
            If (String.IsNullOrEmpty(frmpara.dtpFrom.ToString) Or String.IsNullOrEmpty(frmpara.dtpTo.ToString)) Then
                MessageBox.Show("Please enter valid date.", "Invalid Date")
                Return
            End If
            showProductWiseRejectionReport()
        End If
    End Sub

    Private Sub setParameterFormForSemiFinishGood()
        FillLookup("Select SemiFGMaster.FGName,SemiFGMaster.sfid from SemiFGMaster ", "FG", "Semi Finish Good Name", "Item ID", frmpara.lkupName)
        frmpara.lblName.Text = "Semi Finish Good Name"
        frmpara.lblGroup.Text = "Raw Material Name"
    End Sub

    Private Sub setParameterFormForFinishGood()
        FillLookup("Select FGMaster.FGName,FGMaster.fid from FGMaster ", "FG", "Finish Good Name", "Item ID", frmpara.lkupName)
        frmpara.lblName.Text = "Finish Good Name"
        frmpara.lblGroup.Text = "Raw Material Name"
    End Sub

    Private Sub showProductWiseRejectionReport()
        Dim strSql As String
        If (isDisplayForAll()) Then
            strSql = getStringForAllData()
        ElseIf (isDisplayWithAllBOM()) Then
            strSql = getStringForAllBOM()
        Else
            strSql = getStringForSelectiveRawMaterial()
        End If

        Dim ds As New DataSet
        Dim myrpt As New rptProductWiseRejection
        cmd = New OleDb.OleDbCommand
        cmd.Connection = conn

        Dim adp As New OleDb.OleDbDataAdapter
        adp.SelectCommand = New OleDb.OleDbCommand
        adp.SelectCommand.Connection = conn
        adp.SelectCommand.CommandText = strSql

        adp.Fill(ds, "RejectComponent")

        adp.SelectCommand.CommandText = "Select * from companyMaster"
        adp.Fill(ds, "Company")
        myrpt.DataSource = ds
        myrpt.lblFGVal.DataBindings.Add("Text", ds, "RejectComponent.FGName")
        myrpt.xrlblDateVal.Text = Now.Date
        myrpt.xrTabCellProductName.DataBindings.Add("Text", ds, "RejectComponent.RMItemName")
        myrpt.xrTabCellQty.DataBindings.Add("Text", ds, "RejectComponent.SumOfQty")

        myrpt.GroupHeader1.GroupFields.Item(0).FieldName = "FGName"
        myrpt.lblFGVal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RejectComponent.FGName", "")})

        myrpt.ReportTitle.Text = myrpt.ReportTitle.Text & String.Format(" (From {0} To {1})", frmpara.dtpFrom.Text, frmpara.dtpTo.Text)


        'myrpt.ShowPreview()
        Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
        printingSystem.ShowRibbonPreview()
        adp.Dispose()
    End Sub

    Private Function isDisplayForAll() As Boolean
        If (String.IsNullOrEmpty(frmpara.strID) And String.IsNullOrEmpty(frmpara.strGroupID)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function isDisplayWithAllBOM() As Boolean
        If (String.IsNullOrEmpty(frmpara.strGroupID)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function isReportForSemiFinishGood() As Boolean
        Return (stractivetable.Equals("SemiFG_Wise_RM_Rejection"))
    End Function

    Private Function getStringForAllData() As String
        Dim strString As String
        If (isReportForSemiFinishGood()) Then
            strString = "SELECT SemiFGMaster.FGName, RMItemMaster.RMItemName, Sum(Semi_MIS_Return_Detail.Qty) AS SumOfQty," _
                & " Semi_MIS_Return_Detail.CY" _
                & " FROM SemiFGMaster INNER JOIN ((Semi_MIS_Return_Master INNER JOIN (Semi_MIS_Return_Detail " _
                & " INNER JOIN RMItemMaster ON Semi_MIS_Return_Detail.RID = RMItemMaster.Rid) ON " _
                & " (Semi_MIS_Return_Master.MIS_NO = Semi_MIS_Return_Detail.MIS_NO) AND " _
                & " (Semi_MIS_Return_Master.ID = Semi_MIS_Return_Detail.ReturnID)) INNER JOIN " _
                & " SEMI_Material_Issue_Master ON Semi_MIS_Return_Master.MIS_NO = SEMI_Material_Issue_Master.MIS_NO)" _
                & " ON SemiFGMaster.SFID = SEMI_Material_Issue_Master.SFGID " _
                & " GROUP BY SemiFGMaster.FGName, RMItemMaster.RMItemName, Semi_MIS_Return_Detail.CY " _
                & " HAVING (((Semi_MIS_Return_Detail.CY)='" & strCY & "'));"
        Else
            strString = "SELECT FGMaster.FGName, RMItemMaster.RMItemName, Sum(MIS_Return_Detail.Qty) AS SumOfQty," _
                & " MIS_Return_Detail.CY " _
                & " FROM ((MIS_Return_Master INNER JOIN (MIS_Return_Detail INNER JOIN RMItemMaster ON " _
                & " MIS_Return_Detail.RID = RMItemMaster.Rid) ON (MIS_Return_Master.ID = MIS_Return_Detail.ReturnID) " _
                & " AND (MIS_Return_Master.MIS_NO = MIS_Return_Detail.MIS_NO)) INNER JOIN Material_Issue_Master ON " _
                & " MIS_Return_Master.MIS_NO = Material_Issue_Master.MIS_NO) INNER JOIN FGMaster ON Material_Issue_Master.FGID = FGMaster.FID" _
                & " GROUP BY FGMaster.FGName, RMItemMaster.RMItemName, MIS_Return_Detail.CY " _
                & " HAVING (((MIS_Return_Detail.CY)='" & strCY & "'));"
        End If
        Return strString
    End Function

    Private Function getStringForAllBOM() As String
        Dim strString As String

        If (isReportForSemiFinishGood()) Then
            strString = "SELECT SemiFGMaster.FGName, RMItemMaster.RMItemName, Sum(Semi_MIS_Return_Detail.Qty) AS SumOfQty," _
                & " Semi_MIS_Return_Detail.CY" _
                & " FROM SemiFGMaster INNER JOIN ((Semi_MIS_Return_Master INNER JOIN (Semi_MIS_Return_Detail " _
                & " INNER JOIN RMItemMaster ON Semi_MIS_Return_Detail.RID = RMItemMaster.Rid) ON " _
                & " (Semi_MIS_Return_Master.MIS_NO = Semi_MIS_Return_Detail.MIS_NO) AND " _
                & " (Semi_MIS_Return_Master.ID = Semi_MIS_Return_Detail.ReturnID)) INNER JOIN " _
                & " SEMI_Material_Issue_Master ON Semi_MIS_Return_Master.MIS_NO = SEMI_Material_Issue_Master.MIS_NO)" _
                & " ON SemiFGMaster.SFID = SEMI_Material_Issue_Master.SFGID " _
                & " WHERE(((SemiFGMaster.SFID) = '" & frmpara.strID & "')) " _
                & " GROUP BY SemiFGMaster.FGName, RMItemMaster.RMItemName, Semi_MIS_Return_Detail.CY " _
                & " HAVING (((Semi_MIS_Return_Detail.CY)='" & strCY & "'));"
        Else
            strString = "SELECT FGMaster.FGName, RMItemMaster.RMItemName, Sum(MIS_Return_Detail.Qty) AS SumOfQty, " _
                & " MIS_Return_Detail.CY " _
                & " FROM ((MIS_Return_Master INNER JOIN (MIS_Return_Detail INNER JOIN RMItemMaster ON  " _
                & " MIS_Return_Detail.RID = RMItemMaster.Rid) ON (MIS_Return_Master.ID = MIS_Return_Detail.ReturnID) " _
                & " AND (MIS_Return_Master.MIS_NO = MIS_Return_Detail.MIS_NO)) INNER JOIN Material_Issue_Master ON " _
                & " MIS_Return_Master.MIS_NO = Material_Issue_Master.MIS_NO) INNER JOIN FGMaster ON Material_Issue_Master.FGID = FGMaster.FID " _
                & " WHERE(((FGMaster.FID) = '" & frmpara.strID & "')) " _
                & " GROUP BY FGMaster.FGName, RMItemMaster.RMItemName, MIS_Return_Detail.CY " _
                & " HAVING (((MIS_Return_Detail.CY)='" & strCY & "')); "
        End If

        Return strString
    End Function

    Private Function getStringForSelectiveRawMaterial() As String
        'WHERE (((FGMaster.FID)="FG00000010") AND ((RMItemMaster.Rid)="RM00000047"))
        Dim strString As String

        If (isReportForSemiFinishGood()) Then
            strString = "SELECT SemiFGMaster.FGName, RMItemMaster.RMItemName, Sum(Semi_MIS_Return_Detail.Qty) AS SumOfQty," _
                & " Semi_MIS_Return_Detail.CY" _
                & " FROM SemiFGMaster INNER JOIN ((Semi_MIS_Return_Master INNER JOIN (Semi_MIS_Return_Detail " _
                & " INNER JOIN RMItemMaster ON Semi_MIS_Return_Detail.RID = RMItemMaster.Rid) ON " _
                & " (Semi_MIS_Return_Master.MIS_NO = Semi_MIS_Return_Detail.MIS_NO) AND " _
                & " (Semi_MIS_Return_Master.ID = Semi_MIS_Return_Detail.ReturnID)) INNER JOIN " _
                & " SEMI_Material_Issue_Master ON Semi_MIS_Return_Master.MIS_NO = SEMI_Material_Issue_Master.MIS_NO)" _
                & " ON SemiFGMaster.SFID = SEMI_Material_Issue_Master.SFGID " _
                & " WHERE(((SemiFGMaster.SFID) = '" & frmpara.strID & "') AND ((RMItemMaster.Rid) ='" & frmpara.strGroupID & "')) " _
                & " GROUP BY SemiFGMaster.FGName, RMItemMaster.RMItemName, Semi_MIS_Return_Detail.CY " _
                & " HAVING (((Semi_MIS_Return_Detail.CY)='" & strCY & "'));"
        Else
            strString = "SELECT FGMaster.FGName, RMItemMaster.RMItemName, Sum(MIS_Return_Detail.Qty) AS SumOfQty, " _
                & " MIS_Return_Detail.CY " _
                & " FROM ((MIS_Return_Master INNER JOIN (MIS_Return_Detail INNER JOIN RMItemMaster ON  " _
                & " MIS_Return_Detail.RID = RMItemMaster.Rid) ON (MIS_Return_Master.ID = MIS_Return_Detail.ReturnID) " _
                & " AND (MIS_Return_Master.MIS_NO = MIS_Return_Detail.MIS_NO)) INNER JOIN Material_Issue_Master ON " _
                & " MIS_Return_Master.MIS_NO = Material_Issue_Master.MIS_NO) INNER JOIN FGMaster ON Material_Issue_Master.FGID = FGMaster.FID " _
                & " WHERE(((FGMaster.FID) = '" & frmpara.strID & "') AND ((RMItemMaster.Rid) ='" & frmpara.strGroupID & "')) " _
                & " GROUP BY FGMaster.FGName, RMItemMaster.RMItemName, MIS_Return_Detail.CY " _
                & " HAVING (((MIS_Return_Detail.CY)='" & strCY & "')); "
        End If

        Return strString
    End Function

    

End Class
