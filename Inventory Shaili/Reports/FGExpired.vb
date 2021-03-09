﻿Public Class FGExpired
    Implements IReport

    Public Sub ShowReport() Implements IReport.ShowReport
        Dim myRpt As New rptFG_Expired
        Dim strSql As String
        Dim ds As New DataSet

        strSql = "SELECT FinishGoods_QCDetail.FID, FGMaster.FGName, FinishGoods_QCDetail.Batch_NO, format(FinishGoods_QCDetail.MFG_Date,'mm/yyyy') as MFG_Date," _
            & " Format(FinishGoods_QCDetail.Exp_Date,'mm/yyyy') as Exp_Date, FinishGoods_QCDetail.QC_No, FGStock.Balance_Qty " _
            & " FROM FGMaster INNER JOIN (FinishGoods_QCDetail INNER JOIN FGStock ON (FinishGoods_QCDetail.FID = FGStock.FID) " _
            & " AND (FinishGoods_QCDetail.Batch_NO = FGStock.Batch_No)) ON (FGMaster.FID = FinishGoods_QCDetail.FID) AND (FGMaster.FID = FGStock.FID) " _
            & " WHERE (((FinishGoods_QCDetail.Exp_Date)< Date()) AND ((FGStock.Balance_Qty) > 0) AND ((FGStock.CY)='" & strCY & "') AND (FinishGoods_QCDetail.Exp_Date <> #30/12/1899 00:00:00#))"

        Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
        adp.Fill(ds, "FGExpired")

        myRpt.DataSource = ds

        myRpt.xrlblDateVal.Text = Now.Date
        myRpt.xrTabCellFGID.DataBindings.Add("Text", ds.Tables(0), "FID")

        myRpt.xrTabCellFGName.DataBindings.Add("Text", ds, "FGName")
        myRpt.xrTabCellBatchNo.DataBindings.Add("Text", ds, "Batch_NO")

        myRpt.xrTabCellMfgDate.DataBindings.Add("Text", ds, "MFG_Date")
        myRpt.xrTabCellExpDate.DataBindings.Add("Text", ds, "Exp_Date")
        myRpt.xrTabCellBatchQty.DataBindings.Add("Text", ds, "QC_No")
        myRpt.xrTabCellBalanceQty.DataBindings.Add("Text", ds, "Balance_Qty")

        'myRpt.ShowPreview()
        Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
        printingSystem.ShowRibbonPreview()
        adp.Dispose()
    End Sub
End Class
