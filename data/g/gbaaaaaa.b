Public Class frmDayBook
    Dim ds As New DataSet
    Private Sub frmDayBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkAll.Checked = True
    End Sub

    Private Sub cmdShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShow.Click
        Try
            If chkTI.Checked = False Then
                BindDate(CDate(dtpFrom.EditValue), CDate(dtpTo.EditValue))
            Else
                BindDate(CDate(dtpFrom.EditValue), CDate(dtpTo.EditValue), True)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub BindDate(ByVal date1 As Date, ByVal date2 As Date, Optional ByVal blnAll As Boolean = False)

        Dim da As OleDb.OleDbDataAdapter
        '(1)Purchase_Master(Purchase Order,PO_NO)
        '(2)QCMaster(RMVI)
        '(3)ReqMaster(REQID)
        '(4)Material_Issue_Master (MIS_NO)
        '(5)FinishGoods_QCMaster(FGVI_NO)
        '(6)Order Memo(InvoiceMaster,Order_No)
        '(7)Challan(Challan_Master,Challan_No)
        '(8)Demo Issue(JW_ISSUE_Master,JWID)
        '(9)Demo Return(JW_Ret_Master,JW_Ret_ID)
        '(10)Disposition Status(Disposition_Status,Sr_No)
        '(11)Trading Inward(TI_Rec_Master,Rec_No)
        '(12)Goods Return(FG_Ret_Master,RetNo)

        Try
            da = New OleDb.OleDbDataAdapter
            da.SelectCommand = New OleDb.OleDbCommand
            da.SelectCommand.Connection = conn

            If ds.Tables.Count > 0 Then
                ds.Tables.Clear()
            End If

            'Purchase Order
            If blnAll = True Or chkPO.Checked = True Then
                da.SelectCommand.CommandText = "select 'Purchase Order' as Type,PO_NO as [Transaction No],PO_Date as [Transaction Date],SupplierMaster.SuppName as [Supplier/Customer/Product] " _
                & " from Purchase_Master, SupplierMaster where  supplierMaster.SID = purchase_Master.SuppID and  PO_Date between #" & Format(date1, "MM/dd/yyyy") & "# and #" & Format(date2, "MM/dd/yyyy") & "# order by PO_Date,PO_NO"
                da.Fill(ds, "Trans")
            End If

            'QCMaster(RMVI)
            If blnAll = True Or chkRMVI.Checked = True Then
                da.SelectCommand.CommandText = "select 'RMVI' as Type, RMVI_No as [Transaction No],Date  as [Transaction Date],CY as [Supplier/Customer/Product]  from QCMaster where Date between #" & Format(date1, "MM/dd/yyyy") & "# and #" & Format(date2, "MM/dd/yyyy") & "# order by Date,RMVI_NO"
                da.Fill(ds, "Trans")
            End If

            'Order Memo 
            If blnAll = True Or chkOrder.Checked = True Then
                da.SelectCommand.CommandText = "select 'Order' as Type, Order_No as [Transaction No],Order_Date  as [Transaction Date],CustomerMaster.CustName as [Supplier/Customer/Product] " _
                & " from InvoiceMaster,CustomerMaster where CustomerMaster.CID = InvoiceMaster.CID AND  Order_Date between #" & Format(date1, "MM/dd/yyyy") & "# and #" & Format(date2, "MM/dd/yyyy") & "# order by Order_Date,Order_NO"
                da.Fill(ds, "Trans")
            End If


            'Challan
            If blnAll = True Or chkChallan.Checked = True Then
                da.SelectCommand.CommandText = "select 'Challan' as Type, Challan_No as [Transaction No],Challan_Dt  as [Transaction Date],CustomerMaster.CustName as [Supplier/Customer/Product] " _
                & " from ChallanMaster,CustomerMaster where CustomerMaster.CID = ChallanMaster.CID AND  Challan_Dt between #" & Format(date1, "MM/dd/yyyy") & "# and #" & Format(date2, "MM/dd/yyyy") & "# order by Challan_Dt,Challan_NO"
                da.Fill(ds, "Trans")
            End If

            'REQMASTER
            If blnAll = True Or chkReqMast.Checked = True Then
                da.SelectCommand.CommandText = "select 'Requisition' as Type, ReqID as [Transaction No],ReqDate  as [Transaction Date],FGMaster.FGName as [Supplier/Customer/Product] " _
                & " from REQMaster,FGMaster where ReqMaster.FID = FGMaster.FID AND  ReqDate between #" & Format(date1, "MM/dd/yyyy") & "# and #" & Format(date2, "MM/dd/yyyy") & "# order by ReqDate,ReqID"
                da.Fill(ds, "Trans")
            End If

            'Material_Issue_Master
            If blnAll = True Or chkMIS.Checked = True Then
                da.SelectCommand.CommandText = "select 'MIS' as Type, MIS_No as [Transaction No],MIS_Date  as [Transaction Date],FGMaster.FGName as [Supplier/Customer/Product] " _
                & " from Material_Issue_Master,FGMaster where Material_Issue_Master.FGID = FGMaster.FID AND  MIS_Date between #" & Format(date1, "MM/dd/yyyy") & "# and #" & Format(date2, "MM/dd/yyyy") & "# order by MIS_Date,MIS_No"
                da.Fill(ds, "Trans")
            End If

            'Finish Good QC
            If blnAll = True Or chkFGQC.Checked = True Then
                da.SelectCommand.CommandText = "select 'Finish Good QC' as Type, FGVI_No as [Transaction No],VI_Date  as [Transaction Date],CY as [Supplier/Customer/Product] " _
                & " from FinishGoods_QCMaster where VI_Date between #" & Format(date1, "MM/dd/yyyy") & "# and #" & Format(date2, "MM/dd/yyyy") & "# order by VI_Date,FGVI_No"
                da.Fill(ds, "Trans")
            End If

            'Demo(Issue(JW_ISSUE_Master, JWID))
            If blnAll = True Or chkDemoIssue.Checked = True Then
                da.SelectCommand.CommandText = "select 'Demo Issue' as Type, JWID as [Transaction No],JWDate  as [Transaction Date],JW_Name as [Supplier/Customer/Product] " _
                & " from  JW_ISSUE_Master where JWDate between #" & Format(date1, "MM/dd/yyyy") & "# and #" & Format(date2, "MM/dd/yyyy") & "# order by JWDate,JWID"
                da.Fill(ds, "Trans")
            End If

            'Demo Return(JW_Ret_Master,JW_Ret_ID)
            If blnAll = True Or chkDemoRet.Checked = True Then
                da.SelectCommand.CommandText = "select 'Demo Return' as Type, JW_Ret_ID as [Transaction No],JW_Ret_Dt  as [Transaction Date],JW_Issue_ID as [Supplier/Customer/Product] " _
                & " from  JW_RET_Master where JW_Ret_Dt between #" & Format(date1, "MM/dd/yyyy") & "# and #" & Format(date2, "MM/dd/yyyy") & "# order by JW_Ret_Dt,JW_Ret_ID"
                da.Fill(ds, "Trans")
            End If

            'Disposition Status(Disposition_Status,Sr_No)
            'If blnAll = True Or chkdi.Checked = True Then
            '    da.SelectCommand.CommandText = "select 'Finish Good QC' as Type, FGVI_No as [Transaction No],VI_Date  as [Transaction Date],FGMaster.FGName as [Supplier/Customer/Product] " _
            '                    & " from FinishGoods_QCMaster,FGMaster where FinishGoods_QCMaster.FID = FGMaster.FID AND  VI_Date between #" & Format(date1, "MM/dd/yyyy") & "# and #" & Format(date2, "MM/dd/yyyy") & "# order by VI_Date,FGVI_No"
            '    da.Fill(ds, "Trans")
            'End If

            'Trading(Inward(TI_Rec_Master, Rec_No))
            If blnAll = True Or chkTI.Checked = True Then
                da.SelectCommand.CommandText = "select 'Trading Inward' as Type, RecNo as [Transaction No],RECDate  as [Transaction Date],SupplierMaster.SuppName as [Supplier/Customer/Product] " _
                & " from TI_REC_MASTER,SupplierMaster where TI_REC_MASTER.SID = SUPPLIERMASTER.SID AND  RECDate between #" & Format(date1, "MM/dd/yyyy") & "# and #" & Format(date2, "MM/dd/yyyy") & "# order by RECDate,RECNO"
                da.Fill(ds, "Trans")
            End If

            'Goods Return(FG_Ret_Master,RetNo)
            If blnAll = True Or chkGoodsRet.Checked = True Then
                da.SelectCommand.CommandText = "select 'Goods Return' as Type, RetNo as [Transaction No],RetDate  as [Transaction Date],Challan_NO as [Supplier/Customer/Product] " _
                & " from FG_Ret_MASTER where RetDate between #" & Format(date1, "MM/dd/yyyy") & "# and #" & Format(date2, "MM/dd/yyyy") & "# order by RetDate,RetNO"
                da.Fill(ds, "Trans")
            End If


            grdTrans.DataSource = ds.Tables(0)
            grdTrans.Refresh()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
        If chkAll.Checked = True Then
            Dim myctrl As Control
            For Each myctrl In Me.Controls
                GetControls(myctrl, chkAll.Checked)
            Next
        End If
    End Sub

    Private Sub GetControls(ByVal myCtrl As Control, ByVal blnFlg As Boolean)
        Try
            Dim myCont As Control
            For Each myCont In myCtrl.Controls
                'If myCont.HasChildren = True Then
                If TypeOf (myCont) Is DevExpress.XtraEditors.CheckEdit Then
                    Dim mycheck As DevExpress.XtraEditors.CheckEdit = myCont
                    mycheck.Checked = blnFlg
                Else
                    GetControls(myCont, blnFlg)
                End If
                'End If
            Next
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try

    End Sub

    Private Sub lnkToday_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkToday.LinkClicked
        Try
            BindDate(Now.ToShortDateString, Now.ToShortDateString, True)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lnkYesterday_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkYesterday.LinkClicked
        Try
            BindDate(DateAdd(DateInterval.Day, -1, Now), Now.ToShortDateString, True)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lnkWeek_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkWeek.LinkClicked
        Try
            BindDate(DateAdd(DateInterval.Day, -7, Now), Now.ToShortDateString, True)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lnk15Days_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnk15Days.Click
        Try
            BindDate(DateAdd(DateInterval.Day, -15, Now), Now.ToShortDateString, True)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lnk15Days_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnk15Days.LinkClicked
        Try
            BindDate(DateAdd(DateInterval.Day, -15, Now), Now.ToShortDateString, True)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lnkOneMonth_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkOneMonth.LinkClicked
        Try
            BindDate(DateAdd(DateInterval.Month, -1, Now), Now.ToShortDateString, True)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lnkOneYear_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkOneYear.LinkClicked
        Try
            BindDate(DateAdd(DateInterval.Year, -1, Now), Now.ToShortDateString, True)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub chkPO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPO.CheckedChanged
        If chkPO.Checked = False Then
            chkAll.Checked = False
        End If
    End Sub

    Private Sub chkRMVI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRMVI.CheckedChanged
        If chkRMVI.Checked = False Then
            chkAll.Checked = False
        End If
    End Sub

    Private Sub chkChallan_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkChallan.CheckedChanged
        If chkChallan.Checked = False Then
            chkAll.Checked = False
        End If
    End Sub

    Private Sub chkDemoIssue_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDemoIssue.CheckedChanged
        If chkDemoIssue.Checked = False Then
            chkAll.Checked = False
        End If
    End Sub

    Private Sub chkDemoRet_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDemoRet.CheckedChanged
        If chkDemoRet.Checked = False Then
            chkAll.Checked = False
        End If
    End Sub

    Private Sub chkFGQC_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkFGQC.CheckedChanged
        If chkFGQC.Checked = False Then
            chkAll.Checked = False
        End If
    End Sub

    Private Sub chkGoodsRet_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkGoodsRet.CheckedChanged
        If chkGoodsRet.Checked = False Then
            chkAll.Checked = False
        End If
    End Sub

    Private Sub chkMIS_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMIS.CheckedChanged
        If chkMIS.Checked = False Then
            chkAll.Checked = False
        End If
    End Sub

    Private Sub chkOrder_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkOrder.CheckedChanged
        If chkOrder.Checked = False Then
            chkAll.Checked = False
        End If
    End Sub

    Private Sub chkReqMast_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkReqMast.CheckedChanged
        If chkReqMast.Checked = False Then
            chkAll.Checked = False
        End If
    End Sub

    Private Sub chkTI_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkTI.CheckedChanged
        If chkTI.Checked = False Then
            chkAll.Checked = False
        End If
    End Sub

    Private Sub cmdReport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdReport.Click
        Try
            Dim myrpt As New rptDaybook
            myrpt.DataSource = ds.Tables("Trans")

            myrpt.XrTableCell1.DataBindings.Add("Text", ds, "Trans.Transaction No")
            myrpt.XrTableCell2.DataBindings.Add("Text", ds, "Trans.Transaction Date")
            myrpt.XrTableCell3.DataBindings.Add("Text", ds, "Trans.Supplier/Customer/Product")
            myrpt.XrLabel6.DataBindings.Add("Text", ds, "Trans.Type")
            Dim da As New OleDb.OleDbDataAdapter("Select CompanyName from companyMaster", conn)
            da.Fill(ds, "Company")
            myrpt.XrLabel5.DataBindings.Add("Text", ds, "Company.CompanyName")
            myrpt.XrLabel2.Text = Today.Date

            myrpt.GroupHeader1.GroupFields.Item(0).FieldName = "Type"
            myrpt.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "Trans.Type", "")})
            myrpt.ShowPreview()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub grdTrans_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdTrans.DoubleClick
        Dim strID As String
        Dim strType As String
        Try
            strID = gvTrans.GetRowCellValue(gvTrans.FocusedRowHandle, "Transaction No")
            strType = gvTrans.GetRowCellValue(gvTrans.FocusedRowHandle, "Type")
            Me.Cursor = Cursors.WaitCursor
            Select Case strType
                Case "Purchase Order"
                    ModMain.strgridid = strID
                    Dim frmPOObj As New FrmPurchaseOrder
                    frmPOObj.strcheck = "Edit"
                    frmPOObj.ShowDialog()
                Case "RMVI"
                    ModMain.strgridid = strID
                    Dim frmQCObj As New frmQC
                    frmQCObj.strcheck = "Edit"
                    frmQCObj.Show()
                Case "Order"
                    ModMain.strgridid = strID
                    Dim frmInvoiceobj As New frmInvoicenew
                    frmInvoiceobj.strcheck = "Edit"
                    frmInvoiceobj.ShowDialog()
                Case "Challan"
                    ModMain.strgridid = strID
                    Dim frmChallanObj As New frmChallan
                    frmChallanObj.strCheck = "Edit"
                    frmChallanObj.ShowDialog()
                Case "Requisition"
                    Dim cmd As New OleDb.OleDbCommand("Select RQID from REQMASTER where ReqID ='" & strID & "'", conn)
                    ModMain.strgridid = cmd.ExecuteScalar()
                    Dim frmobj As New frmBatchGenerator
                    frmobj.strcheck = "Edit"
                    frmobj.Show()
                Case "MIS"

                    ModMain.strgridid = strID
                    Dim frmobj As New frmSemiFG_Mat_Issue
                    frmobj.strcheck = "Edit"
                    frmobj.ShowDialog()

                Case "Finish Good QC"
                    ModMain.strgridid = strID
                    Dim frmobj As New frmFinishGoodQC
                    frmobj.strcheck = "Edit"
                    frmobj.ShowDialog()
                Case "Demo Issue"
                    ModMain.strgridid = strID
                    Dim frmobj As New frmJobWorkIssue
                    frmobj.strcheck = "Edit"
                    frmobj.ShowDialog()
                Case "Demo Return"
                    ModMain.strgridid = strID
                    Dim frmobj As New frmJWReturn
                    frmobj.strCheck = "Edit"
                    frmobj.ShowDialog()
                Case "Trading Inward"
                    ModMain.strgridid = strID
                    Dim frmobj As New frmTradingItemInward
                    frmobj.strcheck = "Edit"
                    frmobj.ShowDialog()
                Case "Goods Return"
                    ModMain.strgridid = strID
                    Dim frmobj As New frmGoodsReturn
                    frmobj.strCheck = "Edit"
                    frmobj.ShowDialog()
            End Select
        Catch ex As Exception
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class