﻿Public Class BWFG
    Implements IReport
    Dim frmpara As frmPara1
    Public Sub ShowReport() Implements IReport.ShowReport
        frmpara = New frmPara1
        frmpara.strReport = "BWFG"
        If (frmPara.ShowDialog() = DialogResult.OK) Then
            ShowBWFG()
        End If
    End Sub
    Private Sub ShowBWFG()
        Dim strsql As String
        Dim ds As New DataSet
        Dim myrpt As New rptBWFG
        cmd = New OleDb.OleDbCommand
        cmd.Connection = conn

        dsSub = New DataSet
        If frmpara.strID.Trim = "" And frmpara.strGroupID.Trim = "" Then
            'Current Year Batch Production
            strsql = "SELECT format(FinishGoods_QCMaster.VI_Date,'DD/MM/YYYY') as VDate, FinishGoods_QCDetail.Batch_NO,FinishGoods_QCDetail.FID, FGMaster.FGName, FinishGoods_QCDetail.QC_No,format(FinishGoods_QCDetail.Mfg_date,'MM/yyyy') as Mfg_Date,format(FinishGoods_QCDetail.Exp_date,'MM/yyyy') as Exp_Date " _
                & " FROM FGMaster INNER JOIN (FinishGoods_QCMaster INNER JOIN FinishGoods_QCDetail ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO) ON FGMaster.FID = FinishGoods_QCDetail.FID " _
                & " WHERE (((FinishGoods_QCMaster.VI_Date) Between #" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(frmpara.dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                & " ORDER BY FGMaster.FGName,FinishGoods_QCMaster.VI_Date; "

            
            adp.SelectCommand.CommandText = strsql
            adp.Fill(ds, "Batch")
        Else
            If frmpara.strGroupID.Trim <> "" And frmpara.strID.Trim = "" Then
                strsql = "SELECT format(FinishGoods_QCMaster.VI_Date,'DD/MM/YYYY') as VDate, FinishGoods_QCDetail.Batch_NO,FinishGoods_QCDetail.FID, FGMaster.FGName, FinishGoods_QCDetail.QC_No,format(FinishGoods_QCDetail.Mfg_date,'MM/yyyy') as Mfg_Date,format(FinishGoods_QCDetail.Exp_date,'MM/yyyy') as Exp_Date " _
                       & " FROM FGMaster INNER JOIN (FinishGoods_QCMaster INNER JOIN FinishGoods_QCDetail ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO) ON FGMaster.FID = FinishGoods_QCDetail.FID " _
                       & " WHERE (((FinishGoods_QCMaster.VI_Date) Between #" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(frmpara.dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                       & " AND  FinishGoods_QCDetail.FID = '" & frmpara.strGroupID.Trim & "'" _
                       & " ORDER BY FGMaster.FGName,FinishGoods_QCMaster.VI_Date; "
            ElseIf frmpara.strGroupID.Trim = "" And frmpara.strID.Trim <> "" Then
                strsql = "SELECT format(FinishGoods_QCMaster.VI_Date,'DD/MM/YYYY') as VDate, FinishGoods_QCDetail.Batch_NO,FinishGoods_QCDetail.FID, FGMaster.FGName, FinishGoods_QCDetail.QC_No,format(FinishGoods_QCDetail.Mfg_date,'MM/yyyy') as Mfg_Date,format(FinishGoods_QCDetail.Exp_date,'MM/yyyy') as Exp_Date " _
                       & " FROM FGMaster INNER JOIN (FinishGoods_QCMaster INNER JOIN FinishGoods_QCDetail ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO) ON FGMaster.FID = FinishGoods_QCDetail.FID " _
                       & " WHERE (((FinishGoods_QCMaster.VI_Date) Between #" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(frmpara.dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                       & " AND  FinishGoods_QCDetail.Batch_NO = '" & frmpara.strID.Trim & "'" _
                       & " ORDER BY FGMaster.FGName,FinishGoods_QCMaster.VI_Date; "
            Else
                strsql = "SELECT format(FinishGoods_QCMaster.VI_Date,'DD/MM/YYYY') as VDate, FinishGoods_QCDetail.Batch_NO,FinishGoods_QCDetail.FID, FGMaster.FGName, FinishGoods_QCDetail.QC_No,format(FinishGoods_QCDetail.Mfg_date,'MM/yyyy') as Mfg_Date,format(FinishGoods_QCDetail.Exp_date,'MM/yyyy') as Exp_Date " _
                       & " FROM FGMaster INNER JOIN (FinishGoods_QCMaster INNER JOIN FinishGoods_QCDetail ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO) ON FGMaster.FID = FinishGoods_QCDetail.FID " _
                       & " WHERE (((FinishGoods_QCMaster.VI_Date) Between #" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(frmpara.dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                       & " AND  FinishGoods_QCDetail.FID = '" & frmpara.strGroupID.Trim & "' and  FinishGoods_QCDetail.Batch_NO = '" & frmpara.strID.Trim & "'" _
                       & " ORDER BY FGMaster.FGName,FinishGoods_QCMaster.VI_Date; "
            End If
            adp.SelectCommand = New OleDb.OleDbCommand
            adp.SelectCommand.Connection = conn
            adp.SelectCommand.CommandText = strsql
            adp.Fill(ds, "Batch")

        End If

        adp.SelectCommand.CommandText = "Select * from companyMaster"
        adp.Fill(ds, "Company")

        myrpt.DataSource = ds

        myrpt.xrTabCellBatchNo.DataBindings.Add("Text", ds, "Batch_NO")
        myrpt.xrTabCellProductName.DataBindings.Add("Text", ds, "FGName")
        'myrpt.xrlblFGVal.DataBindings.Add("Text", ds, "FGName")
        myrpt.xrTabCellBatchDate.DataBindings.Add("Text", ds, "Batch.VDate")
        myrpt.xrTabCellMfgDate.DataBindings.Add("Text", ds, "Batch.Mfg_Date")
        myrpt.xrTabCellExpDate.DataBindings.Add("Text", ds, "Batch.Exp_Date")
        myrpt.xrTabCellQty.DataBindings.Add("Text", ds, "Batch.QC_No")

        myrpt.xrlblCompanytitle.DataBindings.Add("Text", ds, "Company.CompanyName")
        myrpt.xrlblDateValue.Text = Format(Today.Date, "dd/MM/yyyy")
        myrpt.xrlblReportTitle.Text = String.Format(myrpt.xrlblReportTitle.Text, Format(frmpara.dtpFrom.EditValue, "dd/MM/yyyy"), Format(frmpara.dtpTo.EditValue, "dd/MM/yyyy"))


        'myrpt.ShowPreview()
        Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
        printingSystem.ShowRibbonPreview()
        adp.Dispose()
    End Sub
End Class
