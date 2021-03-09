﻿Imports DevExpress.XtraEditors.Repository

Public Class frmSemiRejectionComponent
    Public strcheck As String
    Dim cmbOperationType As New RepositoryItemComboBox
    Dim lkupMIS = New RepositoryItemLookUpEdit

    Private Sub frmRejectionComponent_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If strcheck = "Add" Then
            Dim strSql As String = " Semi_Material_Issue_Master LEFT JOIN  SEMI_FinishGoods_QCDetail ON Semi_Material_Issue_Master.MIS_NO = SEMI_FinishGoods_QCDetail.MIS_NO" _
               & " WHERE (((SEMI_FinishGoods_QCDetail.Inspected_No) Is Null)) OR (((SEMI_FinishGoods_QCDetail.Inspected_No)<[Semi_Material_Issue_Master]![SFG_QTY]));"

            FillCombox(strSql, "Distinct(Semi_Material_Issue_Master.MIS_NO)", cmbMIS)
        ElseIf strcheck = "Edit" Then
            Dim strsql = "SELECT Semi_MIS_Return_Master.ID, Semi_MIS_Return_Master.MIS_NO, Semi_MIS_Return_Master.Return_Date " _
                & " FROM(Semi_MIS_Return_Master) WHERE (((Semi_MIS_Return_Master.ID)=" & ModMain.strgridid & "));"

            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = strsql
            dr = cmd.ExecuteReader
            dr.Read()

            cmbMIS.Text = dr("MIS_NO")
            cmbMIS.Enabled = False
            dtpRejectionDate.EditValue = dr("Return_Date").ToString
            dtpRejectionDate.Enabled = False
            getMISInformation(dr("MIS_NO"))
            dr.Close()
            cmd.Dispose()
            bind_DataFromMaterialReturn()
            cmdsave.Visible = False
        End If
    End Sub

    Private Sub cmbMIS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMIS.SelectedIndexChanged
        getMISInformation(cmbMIS.Text)
    End Sub
    Private Sub getMISInformation(ByVal misno As String)
        Dim strsql As String = "SELECT Semi_Material_Issue_Master.MIS_NO, Semi_Material_Issue_Master.MIS_DATE," _
            & " SemiFGMaster.FGName, SemiFGMaster.SFID, Semi_Material_Issue_Master.SFG_QTY" _
            & " FROM Semi_Material_Issue_Master INNER JOIN SemiFGMaster ON Semi_Material_Issue_Master.SFGID = SemiFGMaster.SFID " _
            & "WHERE (((Semi_Material_Issue_Master.MIS_NO)='" + cmbMIS.Text + "'))"

        cmd = New OleDb.OleDbCommand
        cmd.Connection = conn
        cmd.CommandText = strsql
        dr = cmd.ExecuteReader
        dr.Read()
        bind_Masterdata(dr)
        bind_DetailsData(getRawMaterial, getSemiFGMaterial)
        dr.Close()

        cmd.Dispose()
    End Sub
    Private Function getRawMaterial() As DataTable
        Dim sqlstr As String = "SELECT Semi_Material_Issue_Master.MIS_NO, Semi_Material_Issue_Detail.RID, RMItemMaster.RMItemName, Semi_Material_Issue_Detail.RMVI_NO, Semi_Material_Issue_Detail.Issued_Qty,'RM' as ProductType" _
            & " FROM (Semi_Material_Issue_Master INNER JOIN Semi_Material_Issue_Detail ON Semi_Material_Issue_Master.MIS_NO = Semi_Material_Issue_Detail.MIS_NO) INNER JOIN RMItemMaster ON Semi_Material_Issue_Detail.RID = RMItemMaster.Rid " _
            & " WHERE (((Semi_Material_Issue_Master.MIS_NO)='" + cmbMIS.Text + "'))"
        Dim adp = New OleDb.OleDbDataAdapter(sqlstr, conn)
        Dim dttemp As New DataTable
        adp.fill(dttemp)
        Return dttemp
    End Function
    Private Function getSemiFGMaterial() As DataTable
        Dim sqlstr As String = "SELECT Semi_Material_Issue_Master.MIS_NO, Semi_Material_Issue_Detail.RID, SemiFGMaster.FGName as RMItemName, Semi_Material_Issue_Detail.RMVI_NO, Semi_Material_Issue_Detail.Issued_Qty,'SFG' as ProductType" _
            & " FROM (Semi_Material_Issue_Master INNER JOIN Semi_Material_Issue_Detail ON Semi_Material_Issue_Master.MIS_NO = Semi_Material_Issue_Detail.MIS_NO) INNER JOIN SemiFGMaster ON Semi_Material_Issue_Detail.RID = SemiFGMaster.SFID " _
            & " WHERE (((Semi_Material_Issue_Master.MIS_NO)='" + cmbMIS.Text + "'))"
        Dim adp = New OleDb.OleDbDataAdapter(sqlstr, conn)
        Dim dttemp As New DataTable
        adp.fill(dttemp)
        Return dttemp
    End Function

    Private Sub bind_Masterdata(ByVal dr As OleDb.OleDbDataReader)
        lblMISDateVal.Text = dr("mis_date").ToString()
        lblFGVal.Text = dr("FGName").ToString()
        lblFGVal.Tag = dr("SFID").ToString()
        lblQtyVal.Text = dr("SFG_QTY").ToString()
    End Sub
    Private Sub bind_DetailsData(ByVal dtRMDetail As DataTable, ByVal dtSFG As DataTable)
        dtRMDetail.Merge(dtSFG)
        dtRMDetail.Columns.Add("Operation Type")
        dtRMDetail.Columns.Add("Operation_RMVI_NO")
        dtRMDetail.Columns.Add("Operation_Qty", GetType(Double))

        grdMatIssue.DataSource = dtRMDetail
        gvMatIssue.Columns("Operation Type").Caption = "Operation"
        gvMatIssue.Columns("Operation_RMVI_NO").Caption = "RMVI_No"
        gvMatIssue.Columns("Operation_Qty").Caption = "Qty"

    End Sub

    Private Sub bind_DataFromMaterialReturn()
        For i As Int16 = 0 To gvMatIssue.RowCount - 1

            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "Select * from Semi_MIS_Return_Detail where MIS_NO ='" & gvMatIssue.GetRowCellValue(i, "MIS_NO") & _
                "' and RID ='" & gvMatIssue.GetRowCellValue(i, "RID") & "' and RMVI_NO ='" & gvMatIssue.GetRowCellValue(i, "RMVI_NO") & "'" & _
                " and ReturnID = " & ModMain.strgridid
            dr = cmd.ExecuteReader
            Try
                dr.Read()
                If (IsDBNull(dr("Type")) = False) Then
                    gvMatIssue.SetRowCellValue(i, "Operation Type", dr("Type"))
                End If
                If (IsDBNull(dr("RMVI_NO")) = False) Then
                    gvMatIssue.SetRowCellValue(i, "Operation_RMVI_NO", dr("RMVI_NO"))
                End If
                If (IsDBNull(dr("Qty")) = False) Then
                    gvMatIssue.SetRowCellValue(i, "Operation_Qty", dr("Qty"))
                End If
            Catch exception As Exception
                If exception.Message <> "No data exists for the row/column." Then
                    Throw
                End If
            End Try






            'If (IsDBNull(gvMatIssue.GetRowCellValue(i, "Operation Type")) = False AndAlso IsDBNull(gvMatIssue.GetRowCellValue(i, "Operation_RMVI_NO")) = False AndAlso IsDBNull(gvMatIssue.GetRowCellValue(i, "Operation_Qty")) = False) Then

            '    cmd.CommandText = "insert into Semi_MIS_Return_Detail values(" & maxId & ",'" & cmbMIS.Text & "','" & gvMatIssue.GetRowCellValue(i, "RID") & "','" & gvMatIssue.GetRowCellValue(i, "Operation Type") & _
            '        "','" & gvMatIssue.GetRowCellValue(i, "Operation_RMVI_NO") & "'," & gvMatIssue.GetRowCellValue(i, "Operation_Qty") & ",'" & strCY.Trim & "')"
            '    cmd.ExecuteNonQuery()

            '    If (gvMatIssue.GetRowCellValue(i, "Operation Type") = "Return") Then
            '        cmd.CommandText = "Update RMStock set Return_Qty = " & gvMatIssue.GetRowCellValue(i, "Operation_Qty") & ",Balance_Qty = Balance_Qty + " & gvMatIssue.GetRowCellValue(i, "Operation_Qty") & _
            '            " where RID ='" & gvMatIssue.GetRowCellValue(i, "RID") & "' and RMVI_NO ='" & gvMatIssue.GetRowCellValue(i, "RMVI_NO") & "'"
            '        cmd.ExecuteNonQuery()
            '    ElseIf (gvMatIssue.GetRowCellValue(i, "Operation Type") = "Reissue") Then
            '        cmd.CommandText = "Update RMStock set Issue_Qty = Issue_Qty + " & gvMatIssue.GetRowCellValue(i, "Operation_Qty") & ",Balance_Qty = Balance_Qty - " & gvMatIssue.GetRowCellValue(i, "Operation_Qty") & _
            '           " where RID ='" & gvMatIssue.GetRowCellValue(i, "RID") & "' and RMVI_NO ='" & gvMatIssue.GetRowCellValue(i, "Operation_RMVI_NO") & "'"
            '        cmd.ExecuteNonQuery()
            '    End If
            'End If
        Next
    End Sub

    Private Sub gvMatIssue_CustomRowCellEdit(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvMatIssue.CustomRowCellEdit
        If e.Column.FieldName = "Operation Type" Then
            cmbOperationType.Items.Clear()
            cmbOperationType.Items.Add("Return")
            cmbOperationType.Items.Add("Reissue")
            e.RepositoryItem = cmbOperationType
        ElseIf e.Column.FieldName = "Operation_RMVI_NO" Then
            If IsDBNull(gvMatIssue.GetRowCellValue(e.RowHandle, gvMatIssue.Columns("Operation Type"))) = False AndAlso _
                gvMatIssue.GetRowCellValue(e.RowHandle, gvMatIssue.Columns("Operation Type")) = "Return" Then
                gvMatIssue.SetRowCellValue(e.RowHandle, "Operation_RMVI_NO", gvMatIssue.GetRowCellValue(e.RowHandle, gvMatIssue.Columns(3)))
                gvMatIssue.Columns(e.Column.FieldName).OptionsColumn.AllowEdit = False
            Else
                gvMatIssue.Columns(e.Column.FieldName).OptionsColumn.AllowEdit = True
                'gvMatIssue.SetRowCellValue(e.RowHandle, "Operation_RMVI_NO", String.Empty)
                Dim strSql As String


                lkupMIS.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor

                Dim fbReader As OleDb.OleDbDataReader
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                Dim strTemp() As String = strCY.Split("-")
                Dim strPY As String
                strPY = strTemp(0).Trim - 1 & "-" & strTemp(1).Trim - 1
                If (gvMatIssue.GetRowCellValue(e.RowHandle, gvMatIssue.Columns("ProductType")) = "RM") Then
                    strSql = "SELECT RMStock.RMVI_NO, RMStock.Balance_Qty,RMStock.RMVI_NO " _
                        & " FROM RMStock INNER JOIN RMItemMaster ON RMStock.RID = RMItemMaster.Rid " _
                        & " WHERE RMStock.RID='" & gvMatIssue.GetRowCellValue(e.RowHandle, gvMatIssue.Columns(1)) & "' and " _
                        & " RMStock.Balance_Qty > 0 " 'and RMStock.Type <> 'Opening' "    AND (RMSTOCK.CY ='" & strCY.Trim & "' or RMStock.CY ='" & strPY.Trim & "')
                Else
                    strSql = "SELECT SemiFGStock.Batch_No as RMVI_NO, SemiFGStock.Balance_Qty,SemiFGStock.Batch_No " _
                      & " FROM SemiFGStock INNER JOIN SemiFGMaster ON SemiFGStock.SFID = SemiFGMaster.SFid " _
                      & " WHERE SemiFGStock.SFID='" & gvMatIssue.GetRowCellValue(e.RowHandle, gvMatIssue.Columns(1)) & "' and " _
                      & " SemiFGStock.Balance_Qty > 0 "
                End If
                Dim adpt As New OleDb.OleDbDataAdapter
                Dim ds As New DataSet

                'ds.Tables.Add("MIS")
                'ds.Tables(0).Columns.Add("RMVI_NO", System.Type.GetType("System.String"))
                'ds.Tables(0).Columns.Add("Qty", System.Type.GetType("System.Double"))

                'ds.Tables(0).Columns(0).Unique = True


                adpt.SelectCommand = New OleDb.OleDbCommand
                adpt.SelectCommand.CommandText = strSql
                adpt.SelectCommand.Connection = conn
                adpt.Fill(ds, "MIS")
                Dim intFirstCount As Integer = ds.Tables(0).Rows.Count

                If (gvMatIssue.GetRowCellValue(e.RowHandle, gvMatIssue.Columns("ProductType")) = "RM") Then
                    strSql = "SELECT RM_Opening_Stock.RMVI_NO, RMStock.Balance_Qty, RM_Opening_Stock.RMVI_NO" _
                        & " FROM RM_Opening_Stock INNER JOIN RMStock ON (RM_Opening_Stock.RID = RMStock.RID) AND (RM_Opening_Stock.RMVI_NO = RMStock.RMVI_No) " _
                        & " WHERE (((RM_Opening_Stock.RID)='" & gvMatIssue.GetRowCellValue(e.RowHandle, gvMatIssue.Columns(1)) & "') AND ((RMStock.CY)='" & strCY.Trim & "')) " _
                        & "  GROUP BY RM_Opening_Stock.RMVI_NO, RMStock.Balance_Qty, RM_Opening_Stock.RMVI_NO " _
                        & " HAVING (((RMStock.Balance_Qty)>=0));"

                Else
                    strSql = "SELECT Semi_FG_Opening_Stock.SFGVI_NO as Expr1000 , RMStock.Balance_Qty, Semi_FG_Opening_Stock.SFGVI_NO as [RMVI_NO]" _
                       & " FROM Semi_FG_Opening_Stock INNER JOIN RMStock ON (Semi_FG_Opening_Stock.SFID = RMStock.SFID) AND (Semi_FG_Opening_Stock.SFGVI_NO = RMStock.Batch_no) " _
                       & " WHERE (((Semi_FG_Opening_Stock.SFID)='" & gvMatIssue.GetRowCellValue(e.RowHandle, gvMatIssue.Columns(1)) & "') AND ((RMStock.CY)='" & strCY.Trim & "')) " _
                       & "  GROUP BY Semi_FG_Opening_Stock.SFGVI_NO, RMStock.Balance_Qty, Semi_FG_Opening_Stock.SFGVI_NO " _
                       & " HAVING (((RMStock.Balance_Qty)>=0));"

                    strSql = "SELECT RMStock.Batch_No, RMStock.Batch_No, RMStock.Balance_Qty " _
                    & " FROM(RMStock) WHERE(((RMStock.CY) = '" & strCY.Trim & "') And ((RMStock.SFID) = '" & gvMatIssue.GetRowCellValue(e.RowHandle, gvMatIssue.Columns(0)) & "'))" _
                    & " GROUP BY RMStock.Balance_Qty, RMStock.Batch_No, RMStock.Batch_No, RMStock.Balance_Qty " _
                    & " HAVING (((RMStock.Balance_Qty)>=0));"

                End If

                adpt.SelectCommand.CommandText = strSql
                adpt.Fill(ds, "MIS")
                Dim intSecCount As Integer = ds.Tables(0).Rows.Count

                Try
                    For i As Integer = intFirstCount To intSecCount - 1
                        For j As Integer = 0 To intFirstCount - 1
                            If ds.Tables(0).Rows(j).Item(0) = ds.Tables(0).Rows(i).Item(0) Then
                                ds.Tables(0).Rows(i).Delete()
                            End If
                        Next
                    Next

                Catch exTemp As Exception
                End Try

                lkupMIS.NullText = ""

                lkupMIS.Columns.Clear()

                lkupMIS.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(ds.Tables(0).Columns(0).ToString))
                lkupMIS.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo(ds.Tables(0).Columns(1).ToString))

                lkupMIS.DataSource = ds.Tables(0)
                lkupMIS.DisplayMember = ds.Tables(0).Columns(0).ToString
                lkupMIS.ValueMember = ds.Tables(0).Columns(0).ToString

                lkupMIS.Columns(0).Caption = "RMVI_NO"
                lkupMIS.Columns(1).Caption = "Balance Qty"
                'lkupRep.Columns(ds.Tables(0).Columns(1).ToString).Visible = False
                lkupMIS.GetDataSourceRowByDisplayValue(lkupMIS.EditValueChangedFiringMode)
                e.RepositoryItem = lkupMIS
            End If
        ElseIf e.Column.FieldName = "Operation_Qty" Then
            gvMatIssue.Columns(e.Column.FieldName).OptionsColumn.AllowEdit = True
        Else
            gvMatIssue.Columns(e.Column.FieldName).OptionsColumn.AllowEdit = False
        End If
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Try
            If strcheck = "Add" Then
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                cmd.CommandText = "insert into Semi_MIS_Return_Master ( MIS_NO, Return_Date, CY ) values ('" + cmbMIS.Text + "','" + dtpRejectionDate.Text + "','" + strCY + "')"
                cmd.Transaction = conn.BeginTransaction
                cmd.ExecuteNonQuery()

                cmd.CommandText = "Select Max(ID) from Semi_MIS_Return_Master"
                Dim maxId As Integer = cmd.ExecuteScalar()

                For i As Int16 = 0 To gvMatIssue.RowCount - 1
                    If (IsDBNull(gvMatIssue.GetRowCellValue(i, "Operation Type")) = False AndAlso IsDBNull(gvMatIssue.GetRowCellValue(i, "Operation_RMVI_NO")) = False AndAlso IsDBNull(gvMatIssue.GetRowCellValue(i, "Operation_Qty")) = False) Then

                        cmd.CommandText = "insert into Semi_MIS_Return_Detail values(" & maxId & ",'" & cmbMIS.Text & "','" & gvMatIssue.GetRowCellValue(i, "RID") & "','" & gvMatIssue.GetRowCellValue(i, "Operation Type") & _
                            "','" & gvMatIssue.GetRowCellValue(i, "Operation_RMVI_NO") & "'," & gvMatIssue.GetRowCellValue(i, "Operation_Qty") & ",'" & strCY.Trim & "')"
                        cmd.ExecuteNonQuery()
                        If (gvMatIssue.GetRowCellValue(i, "RID").ToString.StartsWith("RM")) Then
                            If (gvMatIssue.GetRowCellValue(i, "Operation Type") = "Return") Then
                                cmd.CommandText = "Update RMStock set Return_Qty = Return_Qty + " & gvMatIssue.GetRowCellValue(i, "Operation_Qty") & ",Balance_Qty = Balance_Qty + " & gvMatIssue.GetRowCellValue(i, "Operation_Qty") & _
                                    " where RID ='" & gvMatIssue.GetRowCellValue(i, "RID") & "' and RMVI_NO ='" & gvMatIssue.GetRowCellValue(i, "RMVI_NO") & "'"
                                cmd.ExecuteNonQuery()
                            ElseIf (gvMatIssue.GetRowCellValue(i, "Operation Type") = "Reissue") Then
                                cmd.CommandText = "Update RMStock set Issue_Qty = Issue_Qty + " & gvMatIssue.GetRowCellValue(i, "Operation_Qty") & ",Balance_Qty = Balance_Qty - " & gvMatIssue.GetRowCellValue(i, "Operation_Qty") & _
                                   " where RID ='" & gvMatIssue.GetRowCellValue(i, "RID") & "' and RMVI_NO ='" & gvMatIssue.GetRowCellValue(i, "Operation_RMVI_NO") & "'"
                                cmd.ExecuteNonQuery()
                            End If
                        ElseIf (gvMatIssue.GetRowCellValue(i, "RID").ToString.StartsWith("SFG")) Then
                            If (gvMatIssue.GetRowCellValue(i, "Operation Type") = "Return") Then
                                cmd.CommandText = "Update SemiFGStock set Ret_Qty = Ret_Qty + " & gvMatIssue.GetRowCellValue(i, "Operation_Qty") & ",Balance_Qty = Balance_Qty + " & gvMatIssue.GetRowCellValue(i, "Operation_Qty") & _
                                    " where SFID ='" & gvMatIssue.GetRowCellValue(i, "RID") & "' and Batch_No ='" & gvMatIssue.GetRowCellValue(i, "RMVI_NO") & "'"
                                cmd.ExecuteNonQuery()
                            ElseIf (gvMatIssue.GetRowCellValue(i, "Operation Type") = "Reissue") Then
                                cmd.CommandText = "Update SemiFGStock set Issue_Qty = Issue_Qty + " & gvMatIssue.GetRowCellValue(i, "Operation_Qty") & ",Balance_Qty = Balance_Qty - " & gvMatIssue.GetRowCellValue(i, "Operation_Qty") & _
                                   " where SFID ='" & gvMatIssue.GetRowCellValue(i, "RID") & "' and Batch_No ='" & gvMatIssue.GetRowCellValue(i, "Operation_RMVI_NO") & "'"
                                cmd.ExecuteNonQuery()
                            End If
                        End If
                    End If
                Next
                cmd.Transaction.Commit()
                cmd.Dispose()
            End If
            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Save Data Successfully", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)           
            Me.Close()
        Catch ex As Exception
            cmd.Transaction.Rollback()
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdReport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdReport.Click
        Try
            Dim myPara As New frmPara
            myPara.showSemiMISRejectionReport(ModMain.strgridid.Trim)
            myPara.Close()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
End Class