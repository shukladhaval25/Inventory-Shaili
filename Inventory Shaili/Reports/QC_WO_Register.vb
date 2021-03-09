Public Class QC_WO_Register
    Implements IReport

    Dim frmpara As frmPara1

    Public Sub ShowReport() Implements IReport.ShowReport
        frmpara = New frmPara1
        frmpara.strReport = stractivetable
        If (frmpara.ShowDialog() = DialogResult.OK) Then
            showQC_WO_Register()
        End If
    End Sub

    Private Sub showQC_WO_Register()
        Dim strSql As String
        If frmpara.strID = "" Then

            strSql = "SELECT FGMaster.FGName, REQMASTER.WORKORDERNO, Material_Issue_Master.MIS_NO, REQMASTER.REQDATE," _
                & " REQMASTER.QTY, Material_Issue_Master.FG_QTY, FinishGoods_QCDetail.Inspected_No, FinishGoods_QCDetail.QC_No," _
                & " FinishGoods_QCMaster.St_Date, FinishGoods_QCMaster.VI_Date, FinishGoods_QCMaster.FGVI_NO, FinishGoods_QCDetail.Batch_NO" _
                & " FROM ((FinishGoods_QCMaster INNER JOIN (FGMaster INNER JOIN FinishGoods_QCDetail " _
                & " ON FGMaster.FID = FinishGoods_QCDetail.FID) ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO) " _
                & " INNER JOIN REQMASTER ON FGMaster.FID = REQMASTER.FID) INNER JOIN Material_Issue_Master ON " _
                & " (FinishGoods_QCDetail.MIS_NO = Material_Issue_Master.MIS_NO) AND (REQMASTER.RQID = Material_Issue_Master.RQID);"
        Else
            strSql = "SELECT FGMaster.FGName, REQMASTER.WORKORDERNO, Material_Issue_Master.MIS_NO, REQMASTER.REQDATE," _
              & " REQMASTER.QTY, Material_Issue_Master.FG_QTY, FinishGoods_QCDetail.Inspected_No, FinishGoods_QCDetail.QC_No," _
              & " FinishGoods_QCMaster.St_Date, FinishGoods_QCMaster.VI_Date, FinishGoods_QCMaster.FGVI_NO, FinishGoods_QCDetail.Batch_NO" _
              & " FROM ((FinishGoods_QCMaster INNER JOIN (FGMaster INNER JOIN FinishGoods_QCDetail " _
              & " ON FGMaster.FID = FinishGoods_QCDetail.FID) ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO) " _
              & " INNER JOIN REQMASTER ON FGMaster.FID = REQMASTER.FID) INNER JOIN Material_Issue_Master ON " _
              & " (FinishGoods_QCDetail.MIS_NO = Material_Issue_Master.MIS_NO) AND (REQMASTER.RQID = Material_Issue_Master.RQID)" _
              & " WHERE (((REQMASTER.WORKORDERNO)='" & frmpara.strID & "'));"

         

        End If
        Dim ds As New DataSet
        Dim myrpt As New rptWORegister
        cmd = New OleDb.OleDbCommand
        cmd.Connection = conn

        Dim adp As New OleDb.OleDbDataAdapter
        adp.SelectCommand = New OleDb.OleDbCommand
        adp.SelectCommand.Connection = conn
        adp.SelectCommand.CommandText = strSql

        adp.Fill(ds, "WO_Register")


        myrpt.DataSource = ds

        myrpt.xrProductName.DataBindings.Add("Text", ds, "WO_Register.FGName")
        myrpt.xrWONo.DataBindings.Add("Text", ds, "WO_Register.WORKORDERNO")
        myrpt.xrWO_Opening_Dt.DataBindings.Add("Text", ds, "WO_Register.REQDATE")
        myrpt.xrMISNo.DataBindings.Add("Text", ds, "WO_Register.MIS_NO")
        myrpt.xrWOQty.DataBindings.Add("Text", ds, "WO_Register.QTY")
        myrpt.xrAssembleQty.DataBindings.Add("Text", ds, "WO_Register.Inspected_No")
        myrpt.xrSterilizedQty.DataBindings.Add("Text", ds, "WO_Register.QC_No")
        myrpt.xrActualQty.DataBindings.Add("Text", ds, "WO_Register.QC_No")
        myrpt.xrSterilizationDt.DataBindings.Add("Text", ds, "WO_Register.St_Date")
        myrpt.xrFGVIDate.DataBindings.Add("Text", ds, "WO_Register.VI_Date")
        myrpt.xrFGVIQty.DataBindings.Add("Text", ds, "WO_Register.QC_No")
        myrpt.xrVINo.DataBindings.Add("Text", ds, "WO_Register.FGVI_NO")
        myrpt.xrBatchNo.DataBindings.Add("Text", ds, "WO_Register.Batch_No")


        'myrpt.lblFGVal.DataBindings.Add("Text", ds, "LineClearance.FGName")
        'myrpt.lblWONoVal.DataBindings.Add("Text", ds, "LineClearance.WORKORDERNO")
        'myrpt.xrlblDateVal.Text = Now.Date
        'myrpt.xrTabCellProductName.DataBindings.Add("Text", ds, "LineClearance.PKG_VI_NO")
        'myrpt.xrTabCellQty.DataBindings.Add("Text", ds, "LineClearance.PKG_VI_Date")
        'myrpt.xrTabBatchNo.DataBindings.Add("Text", ds, "LineClearance.Batch_No")

        'myrpt.GroupHeader1.GroupFields.Item(0).FieldName = "FGName"
        'myrpt.lblFGVal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RejectComponent.FGName", "")})

        ''myrpt.ReportTitle.Text = myrpt.ReportTitle.Text & String.Format(" (From {0} To {1})", frmpara.dtpFrom.Text, frmpara.dtpTo.Text)


        'myrpt.ShowPreview()
        Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
        printingSystem.ShowRibbonPreview()
        adp.Dispose()

    End Sub

End Class
