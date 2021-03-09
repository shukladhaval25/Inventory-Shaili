Public Class frmBalCF

    Private Sub frmBalCF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            
            lblCYRec.Text = strCY
            dtClosingDate.DateTime = Today.Date
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub dtClosingDate_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtClosingDate.EditValueChanged
        Try
            lblOpDt.Text = DateAdd(DateInterval.Day, 1, dtClosingDate.DateTime.Date)
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

  
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            If txtCY.Text = "" Or dtClosingDate.Text = "" Then
                MessageBox.Show("All entry fields are required.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If MessageBox.Show("Are you sure you want to process for this operation?", "Balance Carry Forward", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If MessageBox.Show("Make sure you have read all important point and you want to continue with this process. Do you want to continue with process?", "Continue...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Call BalanceCF()
                    MessageBox.Show("Balance carry forwar process completed.", "Balance Carry Forward", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnOK.Enabled = False
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Due to some error balance carry forward process can not be compeleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
            'If show_error Then
            '    MsgBox(ex.ToString)
            'End If
        End Try
    End Sub
    Private Sub BalanceCF()

        cmd = New OleDb.OleDbCommand
        Try
            'Raw Material Transfer

            cmd.Connection = conn

            ''cmd.CommandText = "Update RMStock set RMStock.CY = '2007-2008' where CY ='2008-2009' and Date < #4/1/2008#"
            ''cmd.ExecuteNonQuery()

            ''Dim da As New OleDb.OleDbDataAdapter("SELECT RMStock.*, RMItemMaster.UnitId " _
            ''    & " FROM RMItemMaster INNER JOIN RMStock ON RMItemMaster.Rid = RMStock.RID " _
            ''    & " WHERE (((RMStock.Balance_Qty)>0) AND ((RMStock.CY)='" & strCY.Trim & "')); ", conn)
            ''Dim ds As New DataSet
            ''da.Fill(ds)
            ''cmd.Transaction = conn.BeginTransaction
            ''For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

            ''    'Dim strMaxID As String
            ''    'cmd.CommandText = "Select max(ID) from RM_Opening_Stock"
            ''    'strMaxID = IIf(IsDBNull(cmd.ExecuteScalar), 0, cmd.ExecuteScalar)
            ''    'strMaxID = strMaxID + 1
            ''    'cmd.CommandText = "insert into RM_Opening_stock values(" & strMaxID.Trim & ",'" & ds.Tables(0).Rows(i).Item("RID").ToString & "','" & ds.Tables(0).Rows(i).Item("UnitID").ToString & "','" & ds.Tables(0).Rows(i).Item("RMVI_NO") & "'," & ds.Tables(0).Rows(i).Item("Balance_Qty") & ",'" & lblOpDt.Text & "','" & txtCY.Text & "')"
            ''    'cmd.ExecuteNonQuery()

            ''    cmd.CommandText = "insert into RMSTock values('" & ds.Tables(0).Rows(i).Item("RID").ToString & "','" & lblOpDt.Text & "','" & ds.Tables(0).Rows(i).Item("RMVI_NO") & "','Opening'," & ds.Tables(0).Rows(i).Item("Balance_Qty") & ",0," & ds.Tables(0).Rows(i).Item("Balance_Qty") & ",'" & txtCY.Text & "')"
            ''    cmd.ExecuteNonQuery()
            ''Next

            ''cmd.CommandText = "Delete From RMStock where RMStock.CY <> '" & txtCY.Text.Trim & "'"
            ''cmd.ExecuteNonQuery()


            ''cmd.Transaction.Commit()
            ''ds.Tables.Clear()


            ' ''FG Stock Transfer

            ''cmd.CommandText = "Update FGStock set FGStock.CY = '2007-2008' where CY ='2008-2009' and Date < #4/1/2008#"
            ''cmd.ExecuteNonQuery()
            ''da.SelectCommand.CommandText = " SELECT FGStock.*, FGMaster.UnitID " _
            ''    & " FROM FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID " _
            ''    & " WHERE (((FGStock.Balance_Qty)>0) AND ((FGStock.CY)='" & strCY.Trim & "')); "
            ''da.Fill(ds)
            ''cmd.Transaction = conn.BeginTransaction
            ''For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            ''    'Dim strMaxID As String
            ''    'cmd.CommandText = "Select max(ID) from FG_Opening_Stock"
            ''    'strMaxID = IIf(IsDBNull(cmd.ExecuteScalar), 0, cmd.ExecuteScalar)
            ''    'strMaxID = strMaxID + 1

            ''    'cmd.CommandText = "insert into FG_Opening_stock values(" & strMaxID.Trim & ",'" & ds.Tables(0).Rows(i).Item("FID").ToString & "','" & ds.Tables(0).Rows(i).Item("UnitID").ToString & "','" & ds.Tables(0).Rows(i).Item("BATCH_NO") & "'," & ds.Tables(0).Rows(i).Item("Balance_Qty") & ",'" & lblOpDt.Text & "','" & txtCY.Text & "')"
            ''    'cmd.ExecuteNonQuery()

            ''    cmd.CommandText = "insert into FGSTock values('" & ds.Tables(0).Rows(i).Item("FID").ToString & "','" & lblOpDt.Text & "','" & ds.Tables(0).Rows(i).Item("BATCH_NO") & "','Opening'," & ds.Tables(0).Rows(i).Item("Balance_Qty") & ",0,0," & ds.Tables(0).Rows(i).Item("Balance_Qty") & ",'" & txtCY.Text & "')"
            ''    cmd.ExecuteNonQuery()
            ''Next

            cmd.CommandText = "Update CY set CurrentYear ='" & txtCY.Text & "'"
            cmd.ExecuteNonQuery()

            ''cmd.CommandText = "Delete From FGStock where FGStock.CY <> '" & txtCY.Text.Trim & "'"
            ''cmd.ExecuteNonQuery()

            ''cmd.Transaction.Commit()
            ''ds.Tables.Clear()

        Catch ex As Exception
            cmd.Transaction.Rollback()
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
            Throw ex
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            Me.Close()
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
End Class