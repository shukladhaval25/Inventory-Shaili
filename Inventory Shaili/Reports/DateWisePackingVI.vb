Public Class DateWisePackingVI
    Implements IReport
    Dim frmpara As frmPara1
    Public Sub ShowReport() Implements IReport.ShowReport
        frmpara = New frmPara1
        frmpara.strReport = "DW_PackingVI"
        If (frmpara.ShowDialog() = DialogResult.OK) Then
            ShowDateWisePackingVI()
        End If
    End Sub
    Public Sub ShowDateWisePackingVI()
        Dim strsql As String
        Dim ds As New DataSet
        Dim myrpt As New rptDateWisePackingVI
        cmd = New OleDb.OleDbCommand
        cmd.Connection = conn

        dsSub = New DataSet

     
        strsql = "SELECT FinishGoods_QCMaster.FGVI_NO, Format(FinishGoods_QCMaster.VI_Date,'dd/mm/yyyy') AS VI_Date, " _
            & " FGMaster.FGName, FinishGoods_QCMaster.PKG_VI_NO, Format(FinishGoods_QCMaster.PKG_VI_Date,'dd/mm/yyyy') AS PKG_VI_Date," _
            & " FinishGoods_QCDetail.QC_No, FinishGoods_QCDetail.MIS_NO, REQMASTER.WORKORDERNO, FinishGoods_QCDetail.Batch_NO, " _
            & " Format([Exp_Date],'mm/yyyy') AS ExpDate, FinishGoods_QCMaster.CY " _
            & " FROM ((FGMaster INNER JOIN (FinishGoods_QCMaster INNER JOIN FinishGoods_QCDetail ON FinishGoods_QCMaster.FGVI_NO " _
            & " = FinishGoods_QCDetail.FGVI_NO) ON FGMaster.FID = FinishGoods_QCDetail.FID) INNER JOIN REQMASTER ON FGMaster.FID = REQMASTER.FID) " _
            & " INNER JOIN Material_Issue_Master ON (FinishGoods_QCDetail.MIS_NO = Material_Issue_Master.MIS_NO) AND " _
            & " (REQMASTER.RQID = Material_Issue_Master.RQID)" _
            & " WHERE (((FinishGoods_QCMaster.CY)='" & strCY & "') AND ((FinishGoods_QCMaster.PKG_VI_Date) Between #" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(frmpara.dtpTo.EditValue, "MM/dd/yyyy") & "#));"


        Dim adp As New OleDb.OleDbDataAdapter
        adp.SelectCommand = New OleDb.OleDbCommand
        adp.SelectCommand.Connection = conn
        adp.SelectCommand.CommandText = strsql

        adp.Fill(ds, "DWPVI")

        adp.SelectCommand.CommandText = "Select * from companyMaster"
        adp.Fill(ds, "Company")
        myrpt.DataSource = ds
        myrpt.GroupHeader1.GroupFields.Item(0).FieldName = "PKG_VI_Date"
        myrpt.xrlblPVIDateVal.DataBindings.Add("Text", ds, "DWPVI.PKG_VI_Date")
        myrpt.xrTabCellVINO.DataBindings.Add("Text", ds, "DWPVI.FGVI_NO")
        myrpt.xrTabCellVIDate.DataBindings.Add("Text", ds, "DWPVI.VI_Date")
        myrpt.xrTabCellProduct.DataBindings.Add("Text", ds, "DWPVI.FGName")
        myrpt.xrTabCellBatchNo.DataBindings.Add("Text", ds, "DWPVI.Batch_NO")
        myrpt.xrTabCellPackingVINo.DataBindings.Add("Text", ds, "DWPVI.PKG_VI_NO")
        myrpt.xrTabCellQCQty.DataBindings.Add("Text", ds, "DWPVI.QC_No")
        myrpt.xrTabCellExpDate.DataBindings.Add("Text", ds, "DWPVI.ExpDate")
        myrpt.xrTabCellMISNo.DataBindings.Add("Text", ds, "DWPVI.MIS_NO")
        myrpt.xrTabCellWONo.DataBindings.Add("Text", ds, "DWPVI.WORKORDERNO")

        myrpt.xrlblCompanytitle.DataBindings.Add("Text", ds, "Company.CompanyName")
        myrpt.xrlblDateValue.Text = Format(Today.Date, "dd/MM/yyyy")
        myrpt.xrlblReportTitle.Text = String.Format(myrpt.xrlblReportTitle.Text, Format(frmpara.dtpFrom.EditValue, "dd/MM/yyyy"), Format(frmpara.dtpTo.EditValue, "dd/MM/yyyy"))


        'myrpt.ShowPreview()
        Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
        printingSystem.ShowRibbonPreview()
        adp.Dispose()
    End Sub
End Class
