Public Class FGExpired
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


        'strSql = "SELECT FG_Opening_Stock.FID,FGMaster.FGName, FG_Opening_Stock.FGVI_NO AS Batch_No, Format(FG_Opening_Stock.Mfg_Date,'mm/yyyy') AS MFG_Date, " _
        '    & " format(DateAdd('m',FGMaster.ExpirationPeriod,FG_Opening_Stock.Mfg_Date),'mm/yyyy') AS Exp_Date, 0 AS QC_No,FGStock.Balance_Qty " _
        '    & " FROM (FGMaster INNER JOIN FG_Opening_Stock ON FGMaster.FID = FG_Opening_Stock.FID) INNER JOIN FGStock ON FGMaster.FID = FGStock.FID " _
        '    & " WHERE (((DateAdd('m',FGMaster.ExpirationPeriod,FG_Opening_Stock.Mfg_Date)) < Date()) " _
        '    & " AND ((FGStock.Balance_Qty)>0) AND ((FGStock.CY)='" & strCY & "') AND ((FGStock.Type)='Opening'));"


        strSql = "SELECT FG_Opening_Stock.FID, FGMaster.FGName, FG_Opening_Stock.FGVI_NO AS Batch_No, Format(FG_Opening_Stock.Mfg_Date,'mm/yyyy') AS MFG_Date, " _
            & " Format(DateAdd('m',FGMaster.ExpirationPeriod,FG_Opening_Stock.Mfg_Date),'mm/yyyy') AS Exp_Date, 0 AS QC_No, FGStock.Balance_Qty " _
            & " FROM(FGMaster INNER JOIN FG_Opening_Stock On FGMaster.FID = FG_Opening_Stock.FID) INNER JOIN FGStock On  " _
            & " (FG_Opening_Stock.FGVI_NO = FGStock.Batch_No) And (FG_Opening_Stock.FID = FGStock.FID) And (FGMaster.FID = FGStock.FID) " _
            & " WHERE(((FGStock.Balance_Qty) > 0) And ((DateAdd('m',[FGMaster].[ExpirationPeriod],[FG_Opening_Stock].[Mfg_Date]))<Date()) " _
            & " And ((FGStock.Type)='Opening') AND ((FGMaster.ExpirationPeriod)<>0));"

        adp.SelectCommand.CommandText = strSql
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
