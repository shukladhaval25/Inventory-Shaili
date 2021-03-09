Public Class LineClearance
    Implements IReport

    Dim frmpara As frmPara1

    Public Sub ShowReport() Implements IReport.ShowReport
        frmpara = New frmPara1
        frmpara.strReport = stractivetable
        If (frmpara.ShowDialog() = DialogResult.OK) Then
            showLineClearanceReport()
        End If
    End Sub

    Private Sub showLineClearanceReport()
        Dim strSql As String
        strSql = "SELECT REQMASTER.WORKORDERNO, REQMASTER.FID, FGMaster.FGName, FinishGoods_QCMaster.FGVI_NO,FinishGoods_QCDetail.Batch_No," _
            & " FinishGoods_QCMaster.PKG_VI_NO, format(FinishGoods_QCMaster.PKG_VI_Date,'dd/MM/yyyy') as PKG_VI_Date, FinishGoods_QCMaster.St_Check," _
            & " FinishGoods_QCMaster.St_Date FROM FGMaster INNER JOIN " _
            & " ((REQMASTER INNER JOIN Material_Issue_Master ON REQMASTER.RQID = Material_Issue_Master.RQID) " _
            & " INNER JOIN (FinishGoods_QCMaster INNER JOIN FinishGoods_QCDetail ON FinishGoods_QCMaster.FGVI_NO = " _
            & " FinishGoods_QCDetail.FGVI_NO) ON Material_Issue_Master.MIS_NO = FinishGoods_QCDetail.MIS_NO) ON " _
            & " (FGMaster.FID = FinishGoods_QCDetail.FID) AND (FGMaster.FID = REQMASTER.FID) " _
            & " WHERE (((REQMASTER.WORKORDERNO)='" & frmpara.strID & "'));"

        Dim ds As New DataSet
        Dim myrpt As New rptLineclearance
        cmd = New OleDb.OleDbCommand
        cmd.Connection = conn

        Dim adp As New OleDb.OleDbDataAdapter
        adp.SelectCommand = New OleDb.OleDbCommand
        adp.SelectCommand.Connection = conn
        adp.SelectCommand.CommandText = strSql

        adp.Fill(ds, "LineClearance")

       
        myrpt.DataSource = ds
        myrpt.lblFGVal.DataBindings.Add("Text", ds, "LineClearance.FGName")
        myrpt.lblWONoVal.DataBindings.Add("Text", ds, "LineClearance.WORKORDERNO")
        myrpt.xrlblDateVal.Text = Now.Date
        myrpt.xrTabCellProductName.DataBindings.Add("Text", ds, "LineClearance.PKG_VI_NO")
        myrpt.xrTabCellQty.DataBindings.Add("Text", ds, "LineClearance.PKG_VI_Date")
        myrpt.xrTabBatchNo.DataBindings.Add("Text", ds, "LineClearance.Batch_No")

        myrpt.GroupHeader1.GroupFields.Item(0).FieldName = "FGName"
        myrpt.lblFGVal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RejectComponent.FGName", "")})

        'myrpt.ReportTitle.Text = myrpt.ReportTitle.Text & String.Format(" (From {0} To {1})", frmpara.dtpFrom.Text, frmpara.dtpTo.Text)


        '        myrpt.ShowPreview()
        Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
        printingSystem.ShowRibbonPreview()
        adp.Dispose()
    End Sub

End Class
