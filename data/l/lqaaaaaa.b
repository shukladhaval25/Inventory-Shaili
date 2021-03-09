Public Class Semi_FG_Stock_Cons
    Implements IReport
    Dim frmpara As frmPara
    Public Sub ShowReport() Implements IReport.ShowReport
        frmpara = New frmPara
        frmpara.strReport = "Semi_FG_Stock_Cons"
        If (frmpara.ShowDialog() = DialogResult.OK) Then
            ShowSemi_FG_Stock_Consolidated()           
        End If
    End Sub

    Public Sub ShowSemi_FG_Stock_Consolidated()
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
                'adp.SelectCommand.CommandText = "SELECT format(SemiFGStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, SemiFGMaster.FGName, SemiFGStock.Batch_No, SemiFGStock.Type, SemiFGStock.Received_Qty as Opn_Qty, SemiFGStock.Issue_Qty, " _
                '    & " UnitMaster.UnitName,SemiFGStock.Balance_Qty " _
                '    & " FROM ((SemiFGMaster INNER JOIN SemiFGStock ON SemiFGMaster.SFID = SemiFGStock.SFID) INNER JOIN GroupMaster ON SemiFGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON SemiFGMaster.UnitID = UnitMaster.UnitID " _
                '    & " WHERE (((SemiFGStock.Date)<#" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "#) AND ((SemiFGStock.Balance_Qty)>0)) Order by SemiFGMaster.FGName,SemiFGStock.Date "
                'adp.Fill(ds.Tables("Semi_FG_Stock"))

                'Opening Balance Before Given date
                adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, SemiFGMaster.FGName, UnitMaster.UnitName, Sum(SemiFGStock.Received_Qty) as Opn_Qty, Sum(SemiFGStock.Issue_Qty) AS Issue_Qty, Sum(SemiFGStock.Balance_Qty) AS Balance_Qty " _
                     & " FROM ((SemiFGMaster INNER JOIN SemiFGStock ON SemiFGMaster.SFid = SemiFGStock.SFID) INNER JOIN GroupMaster ON SemiFGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON SemiFGMaster.UnitId = UnitMaster.UnitID " _
                     & " WHERE (((SemiFGStock.Date)<#" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "#)) " _
                     & " GROUP BY GroupMaster.GroupName, SemiFGMaster.FGName, UnitMaster.UnitName" _
                     & " HAVING (((Sum(SemiFGStock.Balance_Qty))>0)); "
                adp.Fill(ds.Tables("Semi_FG_Stock"))

                'All transactions for opening between given date
                adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, SemiFGMaster.FGName, UnitMaster.UnitName, Sum(SemiFGStock.Received_Qty) as Opn_Qty, Sum(SemiFGStock.Issue_Qty) AS Issue_Qty, Sum(SemiFGStock.Balance_Qty) AS Balance_Qty " _
                  & " FROM ((SemiFGMaster INNER JOIN SemiFGStock ON SemiFGMaster.SFid = SemiFGStock.SFID) INNER JOIN GroupMaster ON SemiFGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON SemiFGMaster.UnitId = UnitMaster.UnitID " _
                  & " WHERE (((SemiFGStock.Date) Between #" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(frmpara.dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((SemiFGStock.Type)='Opening')) " _
                  & " GROUP BY GroupMaster.GroupName, SemiFGMaster.FGName, UnitMaster.UnitName; "
                adp.Fill(ds.Tables("Semi_FG_Stock"))

                'All inwards between given date
                adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, SemiFGMaster.FGName, UnitMaster.UnitName, Sum(SemiFGStock.Received_Qty) as Opn_Qty, Sum(SemiFGStock.Issue_Qty) AS Issue_Qty, Sum(SemiFGStock.Balance_Qty) AS Balance_Qty " _
                   & " FROM ((SemiFGMaster INNER JOIN SemiFGStock ON SemiFGMaster.SFid = SemiFGStock.SFID) INNER JOIN GroupMaster ON SemiFGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON SemiFGMaster.UnitId = UnitMaster.UnitID " _
                   & " WHERE (((SemiFGStock.Date) Between #" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(frmpara.dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((SemiFGStock.Type)='Inward')) " _
                   & " GROUP BY GroupMaster.GroupName, SemiFGMaster.FGName, UnitMaster.UnitName; "
                adp.Fill(ds.Tables("Semi_FG_Stock"))


            Else
                adp.SelectCommand = New OleDb.OleDbCommand
                adp.SelectCommand.Connection = conn
                Dim strID As String = String.Empty
                For i As Integer = 0 To frmpara.lstList.CheckedItems.Count - 1
                    strID = frmpara.lstList.CheckedItems(i).Text
                    'Opening Balance Before Given date
                    adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, SemiFGMaster.FGName, UnitMaster.UnitName, Sum(SemiFGStock.Received_Qty) as Opn_Qty, Sum(SemiFGStock.Issue_Qty) AS Issue_Qty, Sum(SemiFGStock.Balance_Qty) AS Balance_Qty " _
                         & " FROM ((SemiFGMaster INNER JOIN SemiFGStock ON SemiFGMaster.SFid = SemiFGStock.SFID) INNER JOIN GroupMaster ON SemiFGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON SemiFGMaster.UnitId = UnitMaster.UnitID " _
                         & " WHERE (((SemiFGStock.Date)<#" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "#)) " _
                         & " GROUP BY GroupMaster.GroupName, SemiFGMaster.FGName, UnitMaster.UnitName" _
                         & " HAVING (((Sum(SemiFGStock.Balance_Qty))>0)) and (((SemiFGMaster.FGName)='" & strID.Trim & "')); "
                    adp.Fill(ds.Tables("Semi_FG_Stock"))

                    'All transactions for opening between given date
                    adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, SemiFGMaster.FGName, UnitMaster.UnitName, Sum(SemiFGStock.Received_Qty) as Opn_Qty, Sum(SemiFGStock.Issue_Qty) AS Issue_Qty, Sum(SemiFGStock.Balance_Qty) AS Balance_Qty " _
                       & " FROM ((SemiFGMaster INNER JOIN SemiFGStock ON SemiFGMaster.SFid = SemiFGStock.SFID) INNER JOIN GroupMaster ON SemiFGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON SemiFGMaster.UnitId = UnitMaster.UnitID " _
                       & " WHERE (((SemiFGStock.Date) Between #" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(frmpara.dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((SemiFGStock.Type)='Opening')) " _
                       & " GROUP BY GroupMaster.GroupName, SemiFGMaster.FGName, UnitMaster.UnitName" _
                       & " HAVING (((SemiFGMaster.FGName)='" & strID.Trim & "')); "
                    adp.Fill(ds.Tables("Semi_FG_Stock"))

                    'All inwards between given date
                    adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, SemiFGMaster.FGName, UnitMaster.UnitName, Sum(SemiFGStock.Received_Qty) as Opn_Qty, Sum(SemiFGStock.Issue_Qty) AS Issue_Qty, Sum(SemiFGStock.Balance_Qty) AS Balance_Qty " _
                        & " FROM ((SemiFGMaster INNER JOIN SemiFGStock ON SemiFGMaster.SFid = SemiFGStock.SFID) INNER JOIN GroupMaster ON SemiFGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON SemiFGMaster.UnitId = UnitMaster.UnitID " _
                        & " WHERE (((SemiFGStock.Date) Between #" & Format(frmpara.dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(frmpara.dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((SemiFGStock.Type)='Inward')) " _
                        & " GROUP BY GroupMaster.GroupName, SemiFGMaster.FGName, UnitMaster.UnitName" _
                        & " HAVING (((SemiFGMaster.FGName)='" & strID.Trim & "')); "
                    adp.Fill(ds.Tables("Semi_FG_Stock"))
                Next
            End If

            'Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
            'adp.Fill(ds, "RMStock")
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            For i As Integer = 0 To ds.Tables("Semi_FG_Stock").Rows.Count - 1
                cmd.CommandText = "Insert into Temp_Cons values('" & ds.Tables(0).Rows(i).Item("FGName") & "','','" _
                    & ds.Tables(0).Rows(i).Item("GroupName") & "','','" & ds.Tables(0).Rows(i).Item("Type") & "'," _
                    & IIf(IsDBNull(ds.Tables(0).Rows(i).Item("Opn_Qty")), 0, ds.Tables(0).Rows(i).Item("Opn_Qty")) & "," _
                    & IIf(IsDBNull(ds.Tables(0).Rows(i).Item("Rec_Qty")), 0, ds.Tables(0).Rows(i).Item("Rec_Qty")) & "," _
                    & IIf(IsDBNull(ds.Tables(0).Rows(i).Item("Issue_Qty")), 0, ds.Tables(0).Rows(i).Item("Issue_Qty")) & "," _
                    & IIf(IsDBNull(ds.Tables(0).Rows(i).Item("Ret_Qty")), 0, ds.Tables(0).Rows(i).Item("Ret_Qty")) & "," _
                    & IIf(IsDBNull(ds.Tables(0).Rows(i).Item("Balance_Qty")), 0, ds.Tables(0).Rows(i).Item("Balance_Qty")) & ")"
                cmd.ExecuteNonQuery()
            Next
            cmd.Dispose()
            ds.Tables("Semi_FG_Stock").Rows.Clear()

            adp.SelectCommand.CommandText = "SELECT Temp_Cons.FGName, Temp_Cons.UnitName, Temp_Cons.GroupName, " _
                & " Temp_Cons.BatchNo, Sum(Temp_Cons.Opn_Qty) AS Opn_Qty, Sum(Temp_Cons.Rec_Qty) AS Rec_Qty, " _
                & " Sum(Temp_Cons.Issue_Qty) AS Issue_Qty, Sum(Temp_Cons.Ret_Qty) AS Ret_Qty, Sum(Temp_Cons.Balance_Qty) AS Balance_Qty" _
                & " FROM(Temp_Cons) GROUP BY Temp_Cons.FGName, Temp_Cons.UnitName, Temp_Cons.GroupName, Temp_Cons.BatchNo;"
            adp.Fill(ds, "Semi_FG_Stock")



            adp.SelectCommand.CommandText = "Select CompanyName from companyMaster"
            adp.Fill(ds, "Company")

            myRpt.DataSource = ds.Tables(0)
            ' myRpt.XrLabel2.DataBindings.Add("Text", ds, "RMStock.RMItemName")
            ' myRpt.XrTableCell1.DataBindings.Add("Text", ds, "RMStock.TDATE")
            myRpt.XrTableCell2.DataBindings.Add("Text", ds, "Semi_FG_Stock.FGName")
            myRpt.XrTableCell3.DataBindings.Add("Text", ds, "Semi_FG_Stock.UnitName")
            'myRpt.XrTableCell4.DataBindings.Add("Text", ds, "RMStock.RMVI_No")
            myRpt.XrTableCell5.DataBindings.Add("Text", ds, "Semi_FG_Stock.Rec_Qty")
            myRpt.XrTableCell6.DataBindings.Add("Text", ds, "Semi_FG_Stock.Issue_Qty")
            myRpt.XrTableCell7.DataBindings.Add("Text", ds, "Semi_FG_Stock.Balance_Qty")
            myRpt.XrTableCell8.DataBindings.Add("Text", ds, "Semi_FG_Stock.Opn_Qty")
            'myRpt.XrTableCell9.DataBindings.Add("Text", ds, "RMStock.Ret_Qty")

            myRpt.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.Balance_Qty", "")})
            myRpt.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.Issue_Qty", "")})
            myRpt.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.Rec_Qty", "")})
            myRpt.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.Opn_Qty", "")})
            myRpt.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.Ret_Qty", "")})

            myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "GroupName"
            myRpt.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.GroupName", "")})

            myRpt.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "Company.CompanyName", "")})
            myRpt.XrLabel4.Text = ""
            myRpt.XrLabel5.Text = ""
            Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            'myrpt.PrintingSystem = printingSystem
            myRpt.ShowPreview()
            adp.Dispose()
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "Delete from Temp_Cons"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        Finally
        End Try
    End Sub

End Class
