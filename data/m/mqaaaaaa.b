﻿Public Class Semi_FG_Stock_Group
    Implements IReport
    Dim frmpara As frmPara
    Public Sub ShowReport() Implements IReport.ShowReport
        frmpara = New frmPara
        frmpara.strReport = "Semi_FG_Stock_Group"
        If (frmpara.ShowDialog() = DialogResult.OK) Then
            ShowSemi_FG_Stock()
        End If
    End Sub
    Public Sub ShowSemi_FG_Stock()
        Try
            Dim myRpt As New rptRMStock
            Dim ds As New DataSet
            ds.Clear()

            ds.Tables.Add("Semi_FG_Stock")
            ds.Tables(0).Columns.Add("FGName", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("TDate", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("GroupName", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("Batch_No", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("Type", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("Opn_Qty", System.Type.GetType("System.Double"))
            ds.Tables(0).Columns.Add("Rec_Qty", System.Type.GetType("System.Double"))
            ds.Tables(0).Columns.Add("Issue_Qty", System.Type.GetType("System.Double"))
            ds.Tables(0).Columns.Add("Ret_Qty", System.Type.GetType("System.Double"))
            ds.Tables(0).Columns.Add("Balance_Qty", System.Type.GetType("System.Double"))

            Dim adp As New OleDb.OleDbDataAdapter
            If frmpara.strID = "" Then
                adp.SelectCommand = New OleDb.OleDbCommand
                adp.SelectCommand.Connection = conn
                adp.SelectCommand.CommandText = "SELECT format(SemiFGStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, SemiFGMaster.FGName, SemiFGStock.Batch_No, SemiFGStock.Type, SemiFGStock.Received_Qty as Opn_Qty, SemiFGStock.Issue_Qty, " _
                    & " UnitMaster.UnitName,SemiFGStock.Balance_Qty " _
                    & " FROM ((SemiFGMaster INNER JOIN SemiFGStock ON SemiFGMaster.SFID = SemiFGStock.SFID) INNER JOIN GroupMaster ON SemiFGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON SemiFGMaster.UnitID = UnitMaster.UnitID " _
                    & " WHERE (((SemiFGStock.Date)<#" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "#) AND ((SemiFGStock.Balance_Qty)>0)) Order by SemiFGMaster.FGName,SemiFGStock.Date "
                adp.Fill(ds.Tables("Semi_FG_Stock"))


                adp.SelectCommand.CommandText = "SELECT format(SemiFGStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, SemiFGMaster.FGName, SemiFGStock.Batch_No, SemiFGStock.Type, SemiFGStock.Received_Qty as Opn_Qty, SemiFGStock.Issue_Qty, " _
                    & " UnitMaster.UnitName,SemiFGStock.Balance_Qty " _
                    & " FROM ((SemiFGMaster INNER JOIN SemiFGStock ON SemiFGMaster.SFID = SemiFGStock.SFID) INNER JOIN GroupMaster ON SemiFGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON SemiFGMaster.UnitID = UnitMaster.UnitID " _
                    & " WHERE (((SemiFGStock.Date) Between #" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(frmpara.dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((SemiFGStock.Type)='Opening')) Order by SemiFGMaster.FGName,SemiFGStock.Date "
                adp.Fill(ds.Tables("Semi_FG_Stock"))

                adp.SelectCommand.CommandText = "SELECT format(SemiFGStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, SemiFGMaster.FGName, SemiFGStock.Batch_No, SemiFGStock.Type, SemiFGStock.Received_Qty as Opn_Qty, SemiFGStock.Issue_Qty, " _
                    & " UnitMaster.UnitName,SemiFGStock.Balance_Qty " _
                    & " FROM ((SemiFGMaster INNER JOIN SemiFGStock ON SemiFGMaster.SFID = SemiFGStock.SFID) INNER JOIN GroupMaster ON SemiFGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON SemiFGMaster.UnitID = UnitMaster.UnitID " _
                    & " WHERE (((SemiFGStock.Date) Between #" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "# AND #" & Format(frmpara.dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((SemiFGStock.Type)='Inward')) Order by SemiFGMaster.FGName,SemiFGStock.Date "
                adp.Fill(ds.Tables("Semi_FG_Stock"))

            Else
                adp.SelectCommand = New OleDb.OleDbCommand
                adp.SelectCommand.Connection = conn
                Dim strID As String = String.Empty
                For i As Integer = 0 To frmpara.lstList.CheckedItems.Count - 1
                    If frmpara.strReport = "Semi_FG_Stock_Group" Then
                        'strID = strID.Replace("or A", "Or GroupMaster.GroupName") & "'"
                        strID = frmpara.lstList.CheckedItems(i).Text & "'"

                        adp.SelectCommand.CommandText = "SELECT format(SemiFGStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, SemiFGMaster.FGName, SemiFGStock.Batch_No, SemiFGStock.Type, SemiFGStock.Received_Qty as Opn_Qty, SemiFGStock.Issue_Qty, " _
                            & " UnitMaster.UnitName,SemiFGStock.Balance_Qty " _
                            & " FROM ((SemiFGMaster INNER JOIN SemiFGStock ON SemiFGMaster.SFID = SemiFGStock.SFID) INNER JOIN GroupMaster ON SemiFGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON SemiFGMaster.UnitID = UnitMaster.UnitID " _
                            & " WHERE (((SemiFGStock.Date)<#" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "#) AND ((SemiFGStock.Balance_Qty)>0)) and GroupMaster.GroupName ='" & strID & "  Order by SemiFGMaster.FGName,SemiFGStock.Date "
                        adp.Fill(ds.Tables("Semi_FG_Stock"))

                        'adp.SelectCommand.CommandText = "SELECT format(RMStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, RMItemMaster.RMItemName, RMStock.RMVI_No, RMStock.Type, RMStock.Received_Qty as Opn_Qty, RMStock.Issue_Qty, " _
                        '    & " UnitMaster.UnitName,RMStock.Balance_Qty " _
                        '    & " FROM ((RMItemMaster INNER JOIN RMStock ON RMItemMaster.RID = RMStock.RID) INNER JOIN GroupMaster ON RMItemMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON RMItemMaster.UnitID = UnitMaster.UnitID " _
                        '    & " WHERE (((RMStock.Date)<#" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "#) AND ((RMStock.Balance_Qty)>0)) and GroupMaster.GroupName ='" & strID & " Order by RMItemMaster.RMItemName,RMStock.Date "
                        'adp.Fill(ds.Tables("RMStock"))

                        'adp.SelectCommand.CommandText = "SELECT format(SemiFGStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, SemiFGMaster.FGName, SemiFGStock.Batch_No, SemiFGStock.Type, SemiFGStock.Received_Qty as Opn_Qty, SemiFGStock.Issue_Qty, " _
                        '   & " UnitMaster.UnitName,SemiFGStock.Balance_Qty " _
                        '   & " FROM ((SemiFGMaster INNER JOIN SemiFGStock ON RMItemMaster.RID = RMStock.RID) INNER JOIN GroupMaster ON SemiFGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON SemiFGMaster.UnitID = UnitMaster.UnitID " _
                        '   & " WHERE (((SemiFGStock.Date)<#" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "#) AND ((SemiFGStock.Balance_Qty)>0)) and GroupMaster.GroupName ='" & strID & "  Order by SemiFGMaster.FGName,SemiFGStock.Date "
                        'adp.Fill(ds.Tables("Semi_FG_Stock"))

                        adp.SelectCommand.CommandText = "SELECT format(SemiFGStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, SemiFGMaster.FGName, SemiFGStock.Batch_No, SemiFGStock.Type, SemiFGStock.Received_Qty as Opn_Qty, SemiFGStock.Issue_Qty, " _
                          & " UnitMaster.UnitName,SemiFGStock.Balance_Qty " _
                          & " FROM ((SemiFGMaster INNER JOIN SemiFGStock ONSemiFGMaster.SFID = SemiFGStock.SFID) INNER JOIN GroupMaster ON SemiFGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON SemiFGMaster.UnitID = UnitMaster.UnitID " _
                          & " WHERE (((SemiFGStock.Date) Between #" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "# AND #" & Format(frmpara.dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((SemiFGStock.Type)='Opening'))  and GroupMaster.GroupName ='" & strID & " Order by SemiFGMaster.FGName,SemiFGStock.Date "

                        adp.SelectCommand.CommandText = "SELECT format(SemiFGStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, SemiFGMaster.FGName, SemiFGStock.Batch_No, SemiFGStock.Type, SemiFGStock.Received_Qty as Opn_Qty, SemiFGStock.Issue_Qty, " _
                          & " UnitMaster.UnitName,SemiFGStock.Balance_Qty " _
                          & " FROM ((SemiFGMaster INNER JOIN SemiFGStock ON SemiFGMaster.SFID = SemiFGStock.SFID) INNER JOIN GroupMaster ON SemiFGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON SemiFGMaster.UnitID = UnitMaster.UnitID " _
                          & " WHERE (((SemiFGStock.Date) Between #" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "# AND #" & Format(frmpara.dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((SemiFGStock.Type)='Opening'))  and (GroupMaster.GroupName ='" & strID & ") Order by SemiFGMaster.FGName,SemiFGStock.Date "
                        adp.Fill(ds.Tables("Semi_FG_Stock"))

                        adp.SelectCommand.CommandText = "SELECT format(SemiFGStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, SemiFGMaster.FGName, SemiFGStock.Batch_No, SemiFGStock.Type, SemiFGStock.Received_Qty as Opn_Qty, SemiFGStock.Issue_Qty, " _
                           & " UnitMaster.UnitName,SemiFGStock.Balance_Qty " _
                           & " FROM ((SemiFGMaster INNER JOIN SemiFGStock ON SemiFGMaster.SFID = SemiFGStock.SFID) INNER JOIN GroupMaster ON SemiFGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON SemiFGMaster.UnitID = UnitMaster.UnitID " _
                           & " WHERE (((SemiFGStock.Date) Between #" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "# AND #" & Format(frmpara.dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((SemiFGStock.Type)='Inward'))  and (GroupMaster.GroupName ='" & strID & ") Order by SemiFGMaster.FGName,SemiFGStock.Date "
                        adp.Fill(ds.Tables("Semi_FG_Stock"))

                    Else
                        'strID = strID.Replace("or A", "Or RMItemMaster.RMItemName")
                        strID = frmpara.lstList.CheckedItems(i).Text & "'"

                        adp.SelectCommand.CommandText = "SELECT format(SemiFGStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, SemiFGMaster.FGName, SemiFGStock.Batch_No, SemiFGStock.Type, SemiFGStock.Received_Qty as Opn_Qty, SemiFGStock.Issue_Qty, " _
                           & " UnitMaster.UnitName,SemiFGStock.Balance_Qty " _
                           & " FROM ((SemiFGMaster INNER JOIN SemiFGStock ON SemiFGMaster.SFID = SemiFGStock.SFID) INNER JOIN GroupMaster ON SemiFGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON SemiFGMaster.UnitID = UnitMaster.UnitID " _
                           & " WHERE (((SemiFGStock.Date) <#" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "#) AND ((SemiFGStock.Balance_Qty)>0)) and SemiFGMaster.FGName ='" & strID & "  Order by SemiFGMaster.FGName,SemiFGStock.Date "
                        adp.Fill(ds.Tables("Semi_FG_Stock"))

                        'adp.SelectCommand.CommandText = "SELECT format(RMStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, RMItemMaster.RMItemName, RMStock.RMVI_No, RMStock.Type, RMStock.Received_Qty as Opn_Qty, RMStock.Issue_Qty, " _
                        '    & " UnitMaster.UnitName,RMStock.Balance_Qty " _
                        '    & " FROM ((RMItemMaster INNER JOIN RMStock ON RMItemMaster.RID = RMStock.RID) INNER JOIN GroupMaster ON RMItemMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON RMItemMaster.UnitID = UnitMaster.UnitID " _
                        '    & " WHERE (((RMStock.Date)<#" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "#) AND ((RMStock.Balance_Qty)>0)) and (RMItemMaster.RMItemName ='" & strID & ") Order by RMItemMaster.RMItemName,RMStock.Date "
                        'adp.Fill(ds.Tables("RMStock"))

                        adp.SelectCommand.CommandText = "SELECT format(SemiFGStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, SemiFGMaster.FGName, SemiFGStock.Batch_No, SemiFGStock.Type, SemiFGStock.Received_Qty as Opn_Qty, SemiFGStock.Issue_Qty, " _
                          & " UnitMaster.UnitName,SemiFGStock.Balance_Qty " _
                          & " FROM ((SemiFGMaster INNER JOIN SemiFGStock ON SemiFGMaster.SFID = SemiFGStock.SFID) INNER JOIN GroupMaster ON SemiFGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON SemiFGMaster.UnitID = UnitMaster.UnitID " _
                          & " WHERE (((SemiFGStock.Date) Between #" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "# AND #" & Format(frmpara.dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((SemiFGStock.Type)='Opening'))  and (SemiFGMaster.FGName ='" & strID & ") Order by SemiFGMaster.FGName,SemiFGStock.Date "
                        adp.Fill(ds.Tables("Semi_FG_Stock"))

                        adp.SelectCommand.CommandText = "SELECT format(SemiFGStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, SemiFGMaster.FGName, SemiFGStock.Batch_No, SemiFGStock.Type, SemiFGStock.Received_Qty as Opn_Qty, SemiFGStock.Issue_Qty, " _
                          & " UnitMaster.UnitName,SemiFGStock.Balance_Qty " _
                          & " FROM ((SemiFGMaster INNER JOIN SemiFGStock ON SemiFGMaster.SFID = SemiFGStock.SFID) INNER JOIN GroupMaster ON SemiFGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON SemiFGMaster.UnitID = UnitMaster.UnitID " _
                          & " WHERE (((SemiFGStock.Date) Between #" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "# AND #" & Format(frmpara.dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((SemiFGStock.Type)='Inwaard'))  and (SemiFGMaster.FGName ='" & strID & ") Order by SemiFGMaster.FGName,SemiFGStock.Date "
                        adp.Fill(ds.Tables("Semi_FG_Stock"))

                    End If
                Next
            End If

            'Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
            'adp.Fill(ds, "RMStock")

            adp.SelectCommand.CommandText = "Select CompanyName from companyMaster"
            adp.Fill(ds, "Company")

            myRpt.DataSource = ds.Tables(0)
            myRpt.XrLabel1.Text = "Semi Finish Good Stock Statement"
            myRpt.XrLabel5.Text = "Batch No"
            ' myRpt.XrLabel2.DataBindings.Add("Text", ds, "RMStock.RMItemName")
            myRpt.XrTableCell1.DataBindings.Add("Text", ds, "Semi_FG_Stock.TDATE")
            myRpt.XrTableCell2.DataBindings.Add("Text", ds, "Semi_FG_Stock.FGName")
            myRpt.XrTableCell3.DataBindings.Add("Text", ds, "Semi_FG_Stock.UnitName")
            myRpt.XrTableCell4.DataBindings.Add("Text", ds, "Semi_FG_Stock.Batch_No")
            myRpt.XrTableCell5.DataBindings.Add("Text", ds, "Semi_FG_Stock.Rec_Qty")
            myRpt.XrTableCell6.DataBindings.Add("Text", ds, "Semi_FG_Stock.Issue_Qty")
            myRpt.XrTableCell7.DataBindings.Add("Text", ds, "Semi_FG_Stock.Balance_Qty")
            myRpt.XrTableCell8.DataBindings.Add("Text", ds, "Semi_FG_Stock.Opn_Qty")
            myRpt.XrTableCell9.DataBindings.Add("Text", ds, "Semi_FG_Stock.Ret_Qty")

            myRpt.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.Balance_Qty", "")})
            myRpt.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.Issue_Qty", "")})
            myRpt.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.Rec_Qty", "")})
            myRpt.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.Opn_Qty", "")})
            myRpt.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.Ret_Qty", "")})

            myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "GroupName"
            myRpt.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.GroupName", "")})

            myRpt.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "Company.CompanyName", "")})
            myRpt.XrLabel1.Text = myRpt.XrLabel1.Text & " Between " & Format(frmpara.dtpFrom.EditValue, "dd/MM/yyyy") & " and " & Format(frmpara.dtpTo.EditValue, "dd/MM/yyyy")

            'myRpt.XrLabel9.Summary.Func.Sum()
            Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            'myrpt.PrintingSystem = printingSystem
            myRpt.ShowPreview()
            adp.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        Finally
        End Try
    End Sub

End Class
