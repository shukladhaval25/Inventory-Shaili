Public Class RejectionComponent
    Implements IReport
    Dim frmpara As frmPara1
    Public Sub ShowReport() Implements IReport.ShowReport
        frmpara = New frmPara1
        frmpara.strReport = stractivetable
        If (stractivetable.Equals("Rejection_Component_SFG")) Then
            FillLookup("Select SemiFGMaster.FGName,SemiFGMaster.sfid from SemiFGMaster ", "FG", "Semi Finish Good Name", "Item ID", frmpara.lkupName)
            frmpara.lblName.Text = "Semi Finish Good Name"
        ElseIf (stractivetable.Equals("Rejection_Component_FG")) Then
            FillLookup("Select FGMaster.FGName,FGMaster.fid from FGMaster ", "FG", "Finish Good Name", "Item ID", frmpara.lkupName)
            frmpara.lblName.Text = "Finish Good Name"
        End If

        frmpara.grpdate.Visible = True

        frmpara.lblGroup.Visible = False
        frmpara.lkupGroup.Visible = False
        If (frmpara.ShowDialog() = DialogResult.OK) Then
            If (String.IsNullOrEmpty(frmpara.dtpFrom.ToString) Or String.IsNullOrEmpty(frmpara.dtpTo.ToString)) Then
                MessageBox.Show("Please enter valid date.", "Invalid Date")
                Return
            End If
            ShowRejectionComponentReport()
        End If
    End Sub

    Private Sub ShowRejectionComponentReport()
        Dim strsql As String
        Dim ds As New DataSet
        Dim myrpt As New rptRejectionComponent
        cmd = New OleDb.OleDbCommand
        cmd.Connection = conn

        dsSub = New DataSet

        If (stractivetable.Equals("Rejection_Component_SFG")) Then
            strsql = getSemiFGRejectionQuery()
        ElseIf (stractivetable.Equals("Rejection_Component_FG")) Then
            strsql = getFGRejectionQuery()
        End If

        Dim adp As New OleDb.OleDbDataAdapter
        adp.SelectCommand = New OleDb.OleDbCommand
        adp.SelectCommand.Connection = conn
        adp.SelectCommand.CommandText = strsql

        adp.Fill(ds, "RejectComponent")

        adp.SelectCommand.CommandText = "Select * from companyMaster"
        adp.Fill(ds, "Company")
        myrpt.DataSource = ds
        myrpt.xrTabFG.DataBindings.Add("Text", ds, "RejectComponent.FGName")
        myrpt.xrTabProdut.DataBindings.Add("Text", ds, "RejectComponent.RMItemName")
        myrpt.xrTabMIS.DataBindings.Add("Text", ds, "RejectComponent.MIS_NO")
        myrpt.xrTabMISDateVal.DataBindings.Add("Text", ds, "RejectComponent.MIS_DATE")
        myrpt.xrTabRetDateVal.DataBindings.Add("Text", ds, "RejectComponent.Return_Date")
        myrpt.xrTabRMVINoVal.DataBindings.Add("Text", ds, "RejectComponent.RMVI_NO")
        myrpt.xrTabCellQty.DataBindings.Add("Text", ds, "RejectComponent.Qty")
        myrpt.ReportTitle.Text = myrpt.ReportTitle.Text & String.Format(" (From {0} To {1})", frmpara.dtpFrom.Text, frmpara.dtpTo.Text)

        'myrpt.GroupHeader1.GroupFields.Item(0).FieldName = "PKG_VI_Date"
        'myrpt.xrlblPVIDateVal.DataBindings.Add("Text", ds, "DWPVI.PKG_VI_Date")
        'myrpt.xrTabCellVINO.DataBindings.Add("Text", ds, "DWPVI.FGVI_NO")
        'myrpt.xrTabCellVIDate.DataBindings.Add("Text", ds, "DWPVI.VI_Date")
        'myrpt.xrTabCellProduct.DataBindings.Add("Text", ds, "DWPVI.FGName")
        'myrpt.xrTabCellBatchNo.DataBindings.Add("Text", ds, "DWPVI.Batch_NO")
        'myrpt.xrTabCellPackingVINo.DataBindings.Add("Text", ds, "DWPVI.PKG_VI_NO")
        'myrpt.xrTabCellQCQty.DataBindings.Add("Text", ds, "DWPVI.QC_No")
        'myrpt.xrTabCellExpDate.DataBindings.Add("Text", ds, "DWPVI.ExpDate")

        'myrpt.xrlblCompanytitle.DataBindings.Add("Text", ds, "Company.CompanyName")
        'myrpt.xrlblDateValue.Text = Format(Today.Date, "dd/MM/yyyy")
        'myrpt.xrlblReportTitle.Text = String.Format(myrpt.xrlblReportTitle.Text, Format(frmpara.dtpFrom.EditValue, "dd/MM/yyyy"), Format(frmpara.dtpTo.EditValue, "dd/MM/yyyy"))


        myrpt.ShowPreview()
        adp.Dispose()

    End Sub
    Private Function searchByDateOnly() As Boolean
        Return String.IsNullOrEmpty(frmpara.lkupName.Text)
    End Function

    Private Function getSemiFGRejectionQuery() As String
        Dim strsql As String
        If (searchByDateOnly()) Then
            strsql = "SELECT SemiFGMaster.FGName, Semi_MIS_Return_Master.MIS_NO,Semi_Material_Issue_Master.MIS_DATE," _
                & " Semi_MIS_Return_Master.Return_Date, RMItemMaster.RMItemName," _
                & "Semi_MIS_Return_Detail.RMVI_NO, Semi_MIS_Return_Detail.Qty, Semi_MIS_Return_Master.CY " _
                & "FROM (((Semi_MIS_Return_Master INNER JOIN Semi_Material_Issue_Master ON Semi_MIS_Return_Master.MIS_NO = Semi_Material_Issue_Master.MIS_NO) " _
                & "INNER JOIN Semi_MIS_Return_Detail ON Semi_MIS_Return_Master.ID = Semi_MIS_Return_Detail.ReturnID) INNER JOIN " _
                & "RMItemMaster ON Semi_MIS_Return_Detail.RID = RMItemMaster.Rid) INNER JOIN SemiFGMaster ON " _
                & "Semi_Material_Issue_Master.SFGID = SemiFGMaster.SFID " _
                & "WHERE (((Semi_MIS_Return_Master.Return_Date) Between #" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(frmpara.dtpTo.EditValue, "MM/dd/yyyy") & "#)" _
                & " AND ((Semi_MIS_Return_Master.CY)='" & strCY & "'));"
        Else
            strsql = "SELECT SemiFGMaster.FGName, Semi_MIS_Return_Master.MIS_NO,Semi_Material_Issue_Master.MIS_DATE," _
                & " Semi_MIS_Return_Master.Return_Date, RMItemMaster.RMItemName," _
                & "Semi_MIS_Return_Detail.RMVI_NO, Semi_MIS_Return_Detail.Qty, Semi_MIS_Return_Master.CY " _
                & "FROM (((Semi_MIS_Return_Master INNER JOIN Semi_Material_Issue_Master ON Semi_MIS_Return_Master.MIS_NO = Semi_Material_Issue_Master.MIS_NO) " _
                & "INNER JOIN Semi_MIS_Return_Detail ON Semi_MIS_Return_Master.ID = Semi_MIS_Return_Detail.ReturnID) INNER JOIN " _
                & "RMItemMaster ON Semi_MIS_Return_Detail.RID = RMItemMaster.Rid) INNER JOIN SemiFGMaster ON " _
                & "Semi_Material_Issue_Master.SFGID = SemiFGMaster.SFID " _
                & "WHERE (((Semi_MIS_Return_Master.Return_Date) Between #" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(frmpara.dtpTo.EditValue, "MM/dd/yyyy") & "#)" _
                & " AND  ((Semi_Material_Issue_Master.SFGID)='" & frmpara.strID & "') and ((Semi_MIS_Return_Master.CY)='" & strCY & "'));"
        End If
        Return strsql
    End Function

    Private Function getFGRejectionQuery() As String
        Dim strsql As String
        If (searchByDateOnly()) Then
            strsql = "SELECT FGMaster.FGName, MIS_Return_Master.MIS_NO,Material_Issue_Master.MIS_DATE, MIS_Return_Master.Return_Date, RMItemMaster.RMItemName," _
                & "MIS_Return_Detail.RMVI_NO, MIS_Return_Detail.Qty, MIS_Return_Master.CY " _
                & "FROM (((MIS_Return_Master INNER JOIN Material_Issue_Master ON MIS_Return_Master.MIS_NO = Material_Issue_Master.MIS_NO) " _
                & "INNER JOIN MIS_Return_Detail ON MIS_Return_Master.ID = MIS_Return_Detail.ReturnID) INNER JOIN " _
                & "RMItemMaster ON MIS_Return_Detail.RID = RMItemMaster.Rid) INNER JOIN FGMaster ON " _
                & "Material_Issue_Master.FGID = FGMaster.FID " _
                & "WHERE (((MIS_Return_Master.Return_Date) Between #" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(frmpara.dtpTo.EditValue, "MM/dd/yyyy") & "#)" _
                & " AND ((MIS_Return_Master.CY)='" & strCY & "'));"
        Else
            strsql = "SELECT FGMaster.FGName, MIS_Return_Master.MIS_NO,Material_Issue_Master.MIS_DATE, MIS_Return_Master.Return_Date, RMItemMaster.RMItemName," _
                & "MIS_Return_Detail.RMVI_NO, MIS_Return_Detail.Qty, MIS_Return_Master.CY " _
                & "FROM (((MIS_Return_Master INNER JOIN Material_Issue_Master ON MIS_Return_Master.MIS_NO = Material_Issue_Master.MIS_NO) " _
                & "INNER JOIN MIS_Return_Detail ON MIS_Return_Master.ID = MIS_Return_Detail.ReturnID) INNER JOIN " _
                & "RMItemMaster ON MIS_Return_Detail.RID = RMItemMaster.Rid) INNER JOIN FGMaster ON " _
                & "Material_Issue_Master.FGID = FGMaster.FID " _
                & "WHERE (((MIS_Return_Master.Return_Date) Between #" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(frmpara.dtpTo.EditValue, "MM/dd/yyyy") & "#)" _
                & " AND  ((Material_Issue_Master.FGID)='" & frmpara.strID & "') and ((MIS_Return_Master.CY)='" & strCY & "'));"
        End If
        Return strsql
    End Function
End Class
