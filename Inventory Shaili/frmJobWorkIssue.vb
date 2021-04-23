Public Class frmJobWorkIssue
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents grpJobwMAIN As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpJobDet As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lkupFG As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdJB As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvJB As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtJBID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtJBDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUnit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lkupBatch As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOpeningStock As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAddFG As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtName As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpJobwMAIN = New DevExpress.XtraEditors.GroupControl
        Me.txtName = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtJBDate = New DevExpress.XtraEditors.DateEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtJBID = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpJobDet = New DevExpress.XtraEditors.GroupControl
        Me.cmdOpeningStock = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAddFG = New DevExpress.XtraEditors.SimpleButton
        Me.lkupBatch = New DevExpress.XtraEditors.LookUpEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtQty = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.grdJB = New DevExpress.XtraGrid.GridControl
        Me.gvJB = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.txtUnit = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.lkupFG = New DevExpress.XtraEditors.LookUpEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdReport = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grpJobwMAIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpJobwMAIN.SuspendLayout()
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtJBDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtJBID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpJobDet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpJobDet.SuspendLayout()
        CType(Me.lkupBatch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdJB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvJB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupFG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpJobwMAIN
        '
        Me.grpJobwMAIN.Controls.Add(Me.txtName)
        Me.grpJobwMAIN.Controls.Add(Me.Label7)
        Me.grpJobwMAIN.Controls.Add(Me.dtJBDate)
        Me.grpJobwMAIN.Controls.Add(Me.Label2)
        Me.grpJobwMAIN.Controls.Add(Me.txtJBID)
        Me.grpJobwMAIN.Controls.Add(Me.Label1)
        Me.grpJobwMAIN.Location = New System.Drawing.Point(8, 8)
        Me.grpJobwMAIN.Name = "grpJobwMAIN"
        Me.grpJobwMAIN.Size = New System.Drawing.Size(440, 72)
        Me.grpJobwMAIN.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.EditValue = ""
        Me.txtName.Location = New System.Drawing.Point(112, 48)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(320, 20)
        Me.txtName.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Name:"
        '
        'dtJBDate
        '
        Me.dtJBDate.EditValue = Nothing
        Me.dtJBDate.Location = New System.Drawing.Point(336, 24)
        Me.dtJBDate.Name = "dtJBDate"
        Me.dtJBDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtJBDate.Size = New System.Drawing.Size(96, 20)
        Me.dtJBDate.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(224, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Demo Issue Date:"
        '
        'txtJBID
        '
        Me.txtJBID.EditValue = ""
        Me.txtJBID.Location = New System.Drawing.Point(112, 24)
        Me.txtJBID.Name = "txtJBID"
        Me.txtJBID.Size = New System.Drawing.Size(104, 20)
        Me.txtJBID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Demo Issue ID:"
        '
        'grpJobDet
        '
        Me.grpJobDet.Controls.Add(Me.cmdOpeningStock)
        Me.grpJobDet.Controls.Add(Me.cmdAddFG)
        Me.grpJobDet.Controls.Add(Me.lkupBatch)
        Me.grpJobDet.Controls.Add(Me.Label6)
        Me.grpJobDet.Controls.Add(Me.txtQty)
        Me.grpJobDet.Controls.Add(Me.Label5)
        Me.grpJobDet.Controls.Add(Me.grdJB)
        Me.grpJobDet.Controls.Add(Me.cmdAdd)
        Me.grpJobDet.Controls.Add(Me.cmdDelete)
        Me.grpJobDet.Controls.Add(Me.txtUnit)
        Me.grpJobDet.Controls.Add(Me.Label4)
        Me.grpJobDet.Controls.Add(Me.lkupFG)
        Me.grpJobDet.Controls.Add(Me.Label3)
        Me.grpJobDet.Location = New System.Drawing.Point(8, 80)
        Me.grpJobDet.Name = "grpJobDet"
        Me.grpJobDet.Size = New System.Drawing.Size(440, 265)
        Me.grpJobDet.TabIndex = 1
        '
        'cmdOpeningStock
        '
        Me.cmdOpeningStock.Location = New System.Drawing.Point(111, 86)
        Me.cmdOpeningStock.Name = "cmdOpeningStock"
        Me.cmdOpeningStock.Size = New System.Drawing.Size(153, 25)
        Me.cmdOpeningStock.TabIndex = 26
        Me.cmdOpeningStock.Text = "Add &Opening Stock of Product"
        '
        'cmdAddFG
        '
        Me.cmdAddFG.Location = New System.Drawing.Point(8, 86)
        Me.cmdAddFG.Name = "cmdAddFG"
        Me.cmdAddFG.Size = New System.Drawing.Size(97, 25)
        Me.cmdAddFG.TabIndex = 25
        Me.cmdAddFG.Text = "&Add New Product"
        '
        'lkupBatch
        '
        Me.lkupBatch.Location = New System.Drawing.Point(321, 28)
        Me.lkupBatch.Name = "lkupBatch"
        Me.lkupBatch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupBatch.Properties.NullText = ""
        Me.lkupBatch.Size = New System.Drawing.Size(112, 20)
        Me.lkupBatch.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(161, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Qty:"
        '
        'txtQty
        '
        Me.txtQty.EditValue = ""
        Me.txtQty.Location = New System.Drawing.Point(201, 52)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(64, 20)
        Me.txtQty.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(273, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Batch"
        '
        'grdJB
        '
        Me.grdJB.EmbeddedNavigator.Name = ""
        Me.grdJB.Location = New System.Drawing.Point(8, 117)
        Me.grdJB.MainView = Me.gvJB
        Me.grdJB.Name = "grdJB"
        Me.grdJB.Size = New System.Drawing.Size(424, 143)
        Me.grdJB.TabIndex = 22
        Me.grdJB.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvJB})
        '
        'gvJB
        '
        Me.gvJB.GridControl = Me.grdJB
        Me.gvJB.Name = "gvJB"
        Me.gvJB.OptionsBehavior.Editable = False
        Me.gvJB.OptionsCustomization.AllowGroup = False
        Me.gvJB.OptionsCustomization.AllowSort = False
        Me.gvJB.OptionsView.ShowGroupPanel = False
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(321, 52)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(56, 25)
        Me.cmdAdd.TabIndex = 6
        Me.cmdAdd.Text = "&Add"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(377, 52)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(56, 25)
        Me.cmdDelete.TabIndex = 21
        Me.cmdDelete.Text = "&Delete"
        '
        'txtUnit
        '
        Me.txtUnit.EditValue = ""
        Me.txtUnit.Location = New System.Drawing.Point(89, 52)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(64, 20)
        Me.txtUnit.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(57, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Unit:"
        '
        'lkupFG
        '
        Me.lkupFG.Location = New System.Drawing.Point(89, 28)
        Me.lkupFG.Name = "lkupFG"
        Me.lkupFG.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupFG.Properties.NullText = ""
        Me.lkupFG.Size = New System.Drawing.Size(176, 20)
        Me.lkupFG.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(9, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Product Name:"
        '
        'cmdClose
        '
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(392, 351)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(56, 25)
        Me.cmdClose.TabIndex = 20
        Me.cmdClose.Text = "&Close"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(328, 351)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(56, 25)
        Me.cmdSave.TabIndex = 19
        Me.cmdSave.Text = "&Save"
        '
        'cmdReport
        '
        Me.cmdReport.Location = New System.Drawing.Point(8, 351)
        Me.cmdReport.Name = "cmdReport"
        Me.cmdReport.Size = New System.Drawing.Size(56, 25)
        Me.cmdReport.TabIndex = 21
        Me.cmdReport.Text = "&Report"
        '
        'frmJobWorkIssue
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(456, 388)
        Me.Controls.Add(Me.cmdReport)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.grpJobDet)
        Me.Controls.Add(Me.grpJobwMAIN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmJobWorkIssue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Demo Issue"
        CType(Me.grpJobwMAIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpJobwMAIN.ResumeLayout(False)
        CType(Me.txtName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtJBDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtJBID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpJobDet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpJobDet.ResumeLayout(False)
        CType(Me.lkupBatch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdJB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvJB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupFG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public strcheck As String
    Dim dt As New DataTable

    Private Sub frmJobWorkIssue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dt.Columns.Add("FID", System.Type.GetType("System.String"))
            dt.Columns.Add("Product", System.Type.GetType("System.String"))

            dt.Columns.Add("UnitID", System.Type.GetType("System.String"))
            dt.Columns.Add("Unit", System.Type.GetType("System.String"))
            dt.Columns.Add("Batch No", System.Type.GetType("System.String"))
            dt.Columns.Add("QTY", System.Type.GetType("System.Double"))

            FillLookup("SELECT  FGMaster.FGName,FGMaster.FID, FGMaster.UnitID, UnitMaster.UnitName " _
                & " FROM FGMaster INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID " _
                & " GROUP BY FGMaster.FID, FGMaster.FGName, FGMaster.UnitID, UnitMaster.UnitName;", "FGmaster", "Product Name", "FID", lkupFG)

            If strcheck = "Add" Then
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                cmd.CommandText = "select max(JID) from JW_ISSUE_Master"
                If IsDBNull(cmd.ExecuteScalar) = True Then
                    txtJBID.Tag = 1
                Else
                    txtJBID.Tag = Val(cmd.ExecuteScalar + 1)
                End If
                dtJBDate.EditValue = Now
                cmd.Dispose()
                cmdReport.Visible = False
            Else
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                cmd.CommandText = "Select * from JW_ISSUE_MASTER where JID =" & ModMain.strgridid  ' & " and CY ='" & strCY.Trim & "'"
                dr = cmd.ExecuteReader
                Do While dr.Read
                    Bind_Data()
                Loop
                dr.Close()
                cmd.Dispose()

                Dim sql As String

                sql = " SELECT FGMaster.FID, FGMaster.FGName as Product, FGMaster.UnitID, UnitMaster.UnitName as Unit,JW_ISSUE_DET.BATCH_NO as [Batch No], JW_ISSUE_DET.QTY " _
                    & " FROM (JW_ISSUE_DET INNER JOIN FGMaster ON JW_ISSUE_DET.FID = FGMaster.FID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID " _
                    & " WHERE (((JW_ISSUE_DET.JID)=" & ModMain.strgridid & "))"

                dt.Rows.Clear()
                Dim Adpt As New OleDb.OleDbDataAdapter(sql, conn)
                Adpt.Fill(dt)
                grdJB.DataSource = dt
                gvJB.Columns("FID").VisibleIndex = -1
                gvJB.Columns("UnitID").VisibleIndex = -1

                'gvJB.Columns("FID").Visible = False
                'gvJB.Columns("UnitID").Visible = False
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub Bind_Data()
        Try
            If IsDBNull(dr("JID")) = False Then
                txtJBID.Tag = dr("JID")
            End If

            If IsDBNull(dr("JWID")) = False Then
                txtJBID.Text = dr("JWID")
            End If

            If IsDBNull(dr("JWDate")) = False Then
                dtJBDate.EditValue = dr("JWDate")
            End If

            If IsDBNull(dr("JW_NAME")) = False Then
                txtName.Text = dr("JW_NAME")
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub lkupFG_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupFG.EditValueChanged
        Try
            If lkupFG.EditValue <> "" Then
                Dim row As DataRowView = lkupFG.Properties.GetDataSourceRowByKeyValue(lkupFG.EditValue)
                lkupFG.Tag = row(1).ToString
                txtUnit.Tag = row(2).ToString
                txtUnit.Text = row(3).ToString
            End If
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            If lkupFG.Text = "" Or txtQty.Text = "" Or lkupBatch.Text = "" Then
                MsgBox("Select product and enter batch no and qty.")
            Else
                If CDbl(Trim(txtQty.Text)) > CDbl(lkupBatch.Tag.Trim) Then
                    MessageBox.Show("Not allowed to issue more then balance batch qty.", "Invalid Qty", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtQty.Focus()
                Else
                    Dim dr As DataRow
                    Dim blnDup As Boolean = False
                    'For i As Int16 = 0 To gvJB.RowCount - 1
                    '    If gvJB.GetRowCellValue(i, gvJB.Columns(1)).ToString = lkupFG.Text Then
                    '        blnDup = True
                    '        Exit For
                    '    End If
                    'Next
                    If blnDup = False Then
                        dr = dt.NewRow
                        dr.Item(0) = lkupFG.Tag
                        dr.Item(1) = lkupFG.Text
                        dr.Item(2) = txtUnit.Tag
                        dr.Item(3) = txtUnit.Text
                        dr.Item(4) = lkupBatch.Text
                        dr.Item(5) = txtQty.Text
                        dt.Rows.Add(dr)
                        grdJB.DataSource = dt
                        gvJB.Columns("FID").Visible = False
                        gvJB.Columns("UnitID").Visible = False
                        'lkupBatch.Text = ""
                        lkupFG.EditValue = ""
                        txtUnit.Text = ""
                        txtQty.Text = ""
                    End If
                End If
            End If

        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If gvJB.GetSelectedRows.Length > 0 Then
                If MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    gvJB.DeleteRow(gvJB.FocusedRowHandle)
                    gvJB.RefreshData()
                End If
            End If
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If CheckValidate() = True Then
                If strcheck = "Add" Then
                    cmd = New OleDb.OleDbCommand("insert into JW_ISSUE_Master values ( " & txtJBID.Tag & ",'" & Replace(txtJBID.Text.Trim, "'", "''") & "','" & dtJBDate.Text & "','" & IIf(txtName.Text.Trim <> "", txtName.Text, "") & "','" & strCY.Trim & "')")
                    cmd.Connection = conn
                    cmd.Transaction = conn.BeginTransaction
                    cmd.ExecuteNonQuery()

                    For i As Int16 = 0 To gvJB.RowCount - 1
                        cmd.CommandText = "Insert into JW_ISSUE_DET values (" & txtJBID.Tag & ",'" & gvJB.GetRowCellValue(i, "FID") & "'," & gvJB.GetRowCellValue(i, "QTY") & ",'" & gvJB.GetRowCellValue(i, "Batch No") & "','" & strCY.Trim & "')"
                        cmd.ExecuteNonQuery()
                    Next
                    cmd.Transaction.Commit()
                ElseIf strcheck = "Edit" Then
                    cmd = New OleDb.OleDbCommand("update JW_ISSUE_Master set JWID = '" & Replace(txtJBID.Text.Trim, "'", "''") & "', jwdate = '" & dtJBDate.Text & "',jw_Name ='" & txtName.Text & "' where jid = " & txtJBID.Tag & " and CY ='" & strCY.Trim & "'")
                    cmd.Connection = conn
                    cmd.Transaction = conn.BeginTransaction
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "Delete From JW_ISSUE_DET WHERE JID =" & txtJBID.Tag & " and CY ='" & strCY.Trim & "'"
                    cmd.ExecuteNonQuery()

                    For i As Int16 = 0 To gvJB.RowCount - 1
                        cmd.CommandText = "Insert into JW_ISSUE_DET values (" & txtJBID.Tag & ",'" & gvJB.GetRowCellValue(i, "FID") & "'," & gvJB.GetRowCellValue(i, "QTY") & ",'" & gvJB.GetRowCellValue(i, "Batch No") & "','" & strCY.Trim & "')"
                        cmd.ExecuteNonQuery()
                    Next
                    cmd.Transaction.Commit()
                End If
                cmdSave.Enabled = False
            Else
                Exit Sub
            End If
            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Save Data Successfully", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            cmd.Transaction.Rollback()
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        Finally
        End Try
    End Sub
    Private Function CheckValidate() As Boolean
        Dim strItemName As String
        Try
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            If strcheck = "Add" Then
                cmd.CommandText = "select JwID from JW_ISSUE_Master where jwid = '" & Replace(txtJBID.Text, "'", "''") & "' and CY ='" & strCY.Trim & "'"
                strItemName = cmd.ExecuteScalar
            End If

            If strItemName <> "" And strcheck = "Add" Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "This Job Work Id already exists", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
                Exit Function
            End If
            If txtJBID.Text = "" Or dtJBDate.Text = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Check either Job Work ID or Job Work Date is not left blank", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            End If
            Return True
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
            Return False
        End Try
    End Function
    Private Sub gvJB_CustomRowCellEdit(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvJB.CustomRowCellEdit
        Try
            If e.Column.FieldName = "QTY" Then
                gvJB.Columns("QTY").OptionsColumn.AllowEdit = True
            Else
                gvJB.Columns(e.Column.FieldName).OptionsColumn.AllowEdit = False
            End If
        Catch ex As Exception
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub lkupBatch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lkupBatch.GotFocus
        Try
            'If Not lkupBatch.Tag Is Nothing Then
            FillLookup("select Batch_No,Balance_Qty from FGStock where FID='" & lkupFG.Tag.Trim & "' and Balance_Qty >0", "FGStock", "Batch No", "Balance Qty", lkupBatch) 'and CY ='" & strCY.Trim & "'
            lkupBatch.Properties.Columns(1).Visible = True
            'End If
        Catch ex As Exception
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub lkupBatch_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupBatch.EditValueChanged
        Try
            If lkupBatch.EditValue.ToString <> "" Then
                Dim row As DataRowView = lkupBatch.Properties.GetDataSourceRowByKeyValue(lkupBatch.EditValue)
                lkupBatch.Tag = row(1).ToString
                'txtUnit.Tag = row(2).ToString
                'txtUnit.Text = row(3).ToString
            End If
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        Try
            e.Handled = IsDecimalNumber(e.KeyChar)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReport.Click
        Try
            Dim mypara As New frmPara
            mypara.showDemoIssue(txtJBID.Text.Trim)
            mypara.Dispose()
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdAddFG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddFG.Click
        Try
            Dim myFrm As New frmfgmaster
            myFrm.ShowDialog()
            myFrm.Dispose()
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdOpeningStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpeningStock.Click
        Try
            Dim myFrm As New frmFG_OpeningStock1
            myFrm.ShowDialog()
            myFrm.Dispose()
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
End Class
