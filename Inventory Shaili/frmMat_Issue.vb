Imports DevExpress.XtraEditors.Repository
Public Class frmMat_Issue
    Inherits DevExpress.XtraEditors.XtraForm
    Dim strRID As String
    Dim cmbTemp As RepositoryItemComboBox
    Dim lkupMIS As RepositoryItemLookUpEdit
    Dim dt As New DataTable
    Dim dblQOH As Double
    Friend WithEvents txtWorkOrderVal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public strcheck As String
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
    Friend WithEvents grpMat_Issue As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMatIssNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtpMatIssDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtFG As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grdMatIssue As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMatIssue As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdcancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFgQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkVIReq As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lkupReqNo As DevExpress.XtraEditors.LookUpEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpMat_Issue = New DevExpress.XtraEditors.GroupControl()
        Me.txtWorkOrderVal = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lkupReqNo = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkVIReq = New DevExpress.XtraEditors.CheckEdit()
        Me.txtFgQty = New DevExpress.XtraEditors.TextEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grdMatIssue = New DevExpress.XtraGrid.GridControl()
        Me.gvMatIssue = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dtpMatIssDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMatIssNo = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFG = New DevExpress.XtraEditors.TextEdit()
        Me.cmdcancel = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdsave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdReport = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grpMat_Issue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMat_Issue.SuspendLayout()
        CType(Me.txtWorkOrderVal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupReqNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkVIReq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFgQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grdMatIssue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMatIssue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpMatIssDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpMatIssDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMatIssNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpMat_Issue
        '
        Me.grpMat_Issue.Controls.Add(Me.txtWorkOrderVal)
        Me.grpMat_Issue.Controls.Add(Me.Label4)
        Me.grpMat_Issue.Controls.Add(Me.lkupReqNo)
        Me.grpMat_Issue.Controls.Add(Me.chkVIReq)
        Me.grpMat_Issue.Controls.Add(Me.txtFgQty)
        Me.grpMat_Issue.Controls.Add(Me.Label8)
        Me.grpMat_Issue.Controls.Add(Me.GroupControl1)
        Me.grpMat_Issue.Controls.Add(Me.dtpMatIssDate)
        Me.grpMat_Issue.Controls.Add(Me.Label2)
        Me.grpMat_Issue.Controls.Add(Me.txtMatIssNo)
        Me.grpMat_Issue.Controls.Add(Me.Label1)
        Me.grpMat_Issue.Controls.Add(Me.Label7)
        Me.grpMat_Issue.Controls.Add(Me.Label3)
        Me.grpMat_Issue.Controls.Add(Me.txtFG)
        Me.grpMat_Issue.Location = New System.Drawing.Point(8, 8)
        Me.grpMat_Issue.Name = "grpMat_Issue"
        Me.grpMat_Issue.Size = New System.Drawing.Size(670, 336)
        Me.grpMat_Issue.TabIndex = 0
        '
        'txtWorkOrderVal
        '
        Me.txtWorkOrderVal.Enabled = False
        Me.txtWorkOrderVal.Location = New System.Drawing.Point(584, 56)
        Me.txtWorkOrderVal.Name = "txtWorkOrderVal"
        Me.txtWorkOrderVal.Properties.ReadOnly = True
        Me.txtWorkOrderVal.Size = New System.Drawing.Size(81, 20)
        Me.txtWorkOrderVal.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(515, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Work Order :"
        '
        'lkupReqNo
        '
        Me.lkupReqNo.Location = New System.Drawing.Point(72, 56)
        Me.lkupReqNo.Name = "lkupReqNo"
        Me.lkupReqNo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupReqNo.Size = New System.Drawing.Size(104, 20)
        Me.lkupReqNo.TabIndex = 3
        '
        'chkVIReq
        '
        Me.chkVIReq.Location = New System.Drawing.Point(16, 80)
        Me.chkVIReq.Name = "chkVIReq"
        Me.chkVIReq.Properties.Caption = "Visual Inspection Required"
        Me.chkVIReq.Size = New System.Drawing.Size(168, 19)
        Me.chkVIReq.TabIndex = 20
        '
        'txtFgQty
        '
        Me.txtFgQty.Location = New System.Drawing.Point(456, 56)
        Me.txtFgQty.Name = "txtFgQty"
        Me.txtFgQty.Properties.ReadOnly = True
        Me.txtFgQty.Size = New System.Drawing.Size(40, 20)
        Me.txtFgQty.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(424, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Qty:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grdMatIssue)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 104)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(657, 224)
        Me.GroupControl1.TabIndex = 4
        '
        'grdMatIssue
        '
        Me.grdMatIssue.Location = New System.Drawing.Point(8, 16)
        Me.grdMatIssue.MainView = Me.gvMatIssue
        Me.grdMatIssue.Name = "grdMatIssue"
        Me.grdMatIssue.Size = New System.Drawing.Size(644, 200)
        Me.grdMatIssue.TabIndex = 10
        Me.grdMatIssue.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMatIssue})
        '
        'gvMatIssue
        '
        Me.gvMatIssue.GridControl = Me.grdMatIssue
        Me.gvMatIssue.Name = "gvMatIssue"
        Me.gvMatIssue.OptionsCustomization.AllowColumnMoving = False
        Me.gvMatIssue.OptionsCustomization.AllowFilter = False
        Me.gvMatIssue.OptionsCustomization.AllowGroup = False
        Me.gvMatIssue.OptionsCustomization.AllowRowSizing = True
        Me.gvMatIssue.OptionsCustomization.AllowSort = False
        Me.gvMatIssue.OptionsView.ShowGroupPanel = False
        '
        'dtpMatIssDate
        '
        Me.dtpMatIssDate.EditValue = New Date(2007, 2, 18, 0, 0, 0, 0)
        Me.dtpMatIssDate.Location = New System.Drawing.Point(360, 30)
        Me.dtpMatIssDate.Name = "dtpMatIssDate"
        Me.dtpMatIssDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpMatIssDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtpMatIssDate.Size = New System.Drawing.Size(136, 20)
        Me.dtpMatIssDate.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(248, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Material Issue Date:"
        '
        'txtMatIssNo
        '
        Me.txtMatIssNo.Location = New System.Drawing.Point(112, 30)
        Me.txtMatIssNo.Name = "txtMatIssNo"
        Me.txtMatIssNo.Size = New System.Drawing.Size(128, 20)
        Me.txtMatIssNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Material Issue No:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Req. No."
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(184, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Finish Good:"
        '
        'txtFG
        '
        Me.txtFG.Location = New System.Drawing.Point(256, 56)
        Me.txtFG.Name = "txtFG"
        Me.txtFG.Properties.ReadOnly = True
        Me.txtFG.Size = New System.Drawing.Size(160, 20)
        Me.txtFG.TabIndex = 4
        '
        'cmdcancel
        '
        Me.cmdcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdcancel.Location = New System.Drawing.Point(614, 350)
        Me.cmdcancel.Name = "cmdcancel"
        Me.cmdcancel.Size = New System.Drawing.Size(64, 25)
        Me.cmdcancel.TabIndex = 14
        Me.cmdcancel.Text = "&Cancel"
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(542, 350)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(64, 25)
        Me.cmdsave.TabIndex = 13
        Me.cmdsave.Text = "&Save"
        '
        'cmdReport
        '
        Me.cmdReport.Location = New System.Drawing.Point(24, 352)
        Me.cmdReport.Name = "cmdReport"
        Me.cmdReport.Size = New System.Drawing.Size(64, 25)
        Me.cmdReport.TabIndex = 15
        Me.cmdReport.Text = "&Report"
        '
        'frmMat_Issue
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(690, 384)
        Me.Controls.Add(Me.cmdReport)
        Me.Controls.Add(Me.cmdcancel)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.grpMat_Issue)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMat_Issue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Material Issue"
        CType(Me.grpMat_Issue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMat_Issue.ResumeLayout(False)
        CType(Me.txtWorkOrderVal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupReqNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkVIReq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFgQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grdMatIssue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMatIssue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpMatIssDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpMatIssDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMatIssNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cboReqNo_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    'FillCombox("REqMaster", "rqid", cboReqNo)
        '    cboReqNo.Properties.Items.Clear()
        '    Dim dr As OleDb.OleDbDataReader
        '    cmd = New OleDb.OleDbCommand
        '    cmd.Connection = conn

        '    cmd.CommandText = "Select count(*) from Material_Issue_Master "
        '    If cmd.ExecuteScalar > 0 Then
        '        cmd.CommandText = "SELECT REQMASTER.RQID " _
        '            & " FROM REQMASTER INNER JOIN Material_Issue_Master ON REQMASTER.RQID <> Material_Issue_Master.RQID " _
        '            & " GROUP BY REQMASTER.RQID ORDER BY REQMASTER.RQID "
        '    Else
        '        cmd.CommandText = "SELECT REQMASTER.RQID FROM REQMASTER ORDER BY REQID "
        '    End If
        '    dr = cmd.ExecuteReader
        '    Do While dr.Read()
        '        cboReqNo.Properties.Items.Add(dr.Item(0))
        '    Loop
        '    dr.Close()
        '    cmd.Dispose()
        'Catch ex As Exception
        '    If show_error Then
        '        MsgBox(ex.ToString)
        '    End If
        'End Try
    End Sub

    'Private Sub cboRMVINO_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        cboRMVINO.Properties.Items.Clear()
    '        Dim dr As OleDb.OleDbDataReader
    '        cmd = New OleDb.OleDbCommand
    '        cmd.Connection = conn
    '        cmd.CommandText = "Select RMVI_NO from QCDetail"
    '        dr = cmd.ExecuteReader
    '        Do While dr.Read()
    '            cboRMVINO.Properties.Items.Add(dr.Item(0))
    '        Loop
    '        dr.Close()
    '        cmd.Dispose()
    '    Catch ex As Exception
    '        If show_error Then
    '            MsgBox(ex.ToString)
    '        End If
    '    End Try
    'End Sub
    'Private Sub lkupItem_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        'DHAVAL
    '        FillLookup("SELECT  RMItemMaster.RMItemName,QCDetail.RID,QCDetail.RMVI_NO" _
    '                    & " FROM QCDetail INNER JOIN RMItemMaster ON QCDetail.RID = RMItemMaster.Rid " _
    '                    & " WHERE (((QCDetail.RMVI_NO)= '" & cboRMVINO.Text & "'))", "RMItem", "Item Name", "RId", lkupItem)

    '    Catch ex As Exception
    '        If show_error Then
    '            MsgBox(ex.ToString)
    '        End If
    '    End Try
    'End Sub

    'Private Sub lkupItem_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'DHAVAL
    '    Try

    '        If lkupItem.EditValue <> "" Then

    '            Dim row As DataRowView = lkupItem.Properties.GetDataSourceRowByKeyValue(lkupItem.EditValue)
    '            strRID = row(1).ToString

    '        End If
    '    Catch ex As Exception
    '        If show_error Then
    '            MsgBox(ex.ToString)
    '        End If
    '    End Try
    'End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'DHAVAL
        Try
            'Dim dr As DataRow
            'Dim dblBalQty As Double
            gvMatIssue.RefreshData()

            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn

            'cmd.CommandText = "SELECT RMStock.Balance_Qty FROM RMStock" _
            '& " WHERE RMStock.RMVI_No='" & cboRMVINO.Text & "' AND RMStock.RID ='" & strRID & "'"

            'dblBalQty = cmd.ExecuteScalar

            'If Val(txtQty.Text) > dblBalQty Then
            '    DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Issue Quantity cannot exceed the Balance Quantity", "Insufficient Stock", MessageBoxButtons.OK)
            '    txtQty.Text = ""
            '    txtQty.Focus()
            '    Exit Sub
            'End If

            'dblQOH = dblBalQty - Val(txtQty.Text)

            'If cboReqNo.Text = "" Or cboRMVINO.Text = "" Or lkupItem.Text = "" Or txtQty.Text = "" Then
            '    DevExpress.XtraEditors.XtraMessageBox.Show("Check either Requisition Number or Raw Materail Number or Item Name or Issued Quantity is left blank", "Blank Field Error", _
            '        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Exit Sub
            'End If
            'dr = dt.NewRow

            'dr.Item(0) = cboReqNo.Text
            'dr.Item(1) = txtFG.Tag
            'dr.Item(2) = txtFG.Text
            'dr.Item(3) = cboRMVINO.Text
            'dr.Item(4) = strRID
            'dr.Item(5) = lkupItem.Text
            'dr.Item(6) = txtQty.Text

            'dt.Rows.Add(dr)

            'grdMatIssue.DataSource = dt
            'gvMatIssue.Columns(1).Visible = False
            'gvMatIssue.Columns(4).Visible = False
            'gvMatIssue.RefreshData()

            'cmd.Dispose()

            'cboReqNo.Text = ""
            'txtFG.Text = ""
            'cboRMVINO.Text = ""
            'lkupItem.EditValue = ""
            'txtQty.Text = ""

        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub frmMat_Issue_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DHAVAL
        Try
            'dt.Columns.Add("MIS_No", System.Type.GetType("System.String"))
            dt.Columns.Add("RID", System.Type.GetType("System.String"))
            dt.Columns.Add("Item Name", System.Type.GetType("System.String"))
            dt.Columns.Add("RMVI_NO", System.Type.GetType("System.String"))
            dt.Columns.Add("UID", System.Type.GetType("System.String"))
            dt.Columns.Add("Unit", System.Type.GetType("System.String"))
            dt.Columns.Add("Req Qty", System.Type.GetType("System.Double"))
            dt.Columns.Add("Issued Qty", System.Type.GetType("System.Double"))
            dt.Columns.Add("Available Qty", System.Type.GetType("System.Double"))
            dt.Columns.Add("ProductType", System.Type.GetType("System.String"))

            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn

            If strcheck = "Add" Then

                Dim strSql As String
                cmd.CommandText = "Select count(*) from Material_Issue_Master "
                If cmd.ExecuteScalar > 0 Then
                    'strSql = "SELECT  REQMASTER.REQID, REQMASTER.RQID " _
                    '    & " FROM REQMASTER INNER JOIN Material_Issue_Master ON REQMASTER.RQID <> Material_Issue_Master.RQID where REQMASTER.CY ='" & strCY.Trim & "'" _
                    '    & " and Material_Issue_Master.CY ='" & strCY.Trim & "'" _
                    '    & " GROUP BY REQMASTER.RQID,REQMASTER.REQID ORDER BY REQMASTER.RQID "

                    'This is original logic
                    'strSql = "SELECT REQMASTER.REQID, REQMASTER.RQID " _
                    '      & " FROM REQMASTER LEFT JOIN Material_Issue_Master ON (REQMASTER.CY = Material_Issue_Master.CY) AND (REQMASTER.RQID <> Material_Issue_Master.RQID) " _
                    '      & " GROUP BY REQMASTER.REQID, REQMASTER.RQID, REQMASTER.CY, Material_Issue_Master.CY " _
                    '      & " HAVING (((REQMASTER.CY)='" & strCY.Trim & "'))ORDER BY REQMASTER.RQID"

                    strSql = "SELECT REQMASTER.REQID, REQMASTER.RQID " _
                        & " FROM REQMASTER LEFT JOIN Material_Issue_Master ON (REQMASTER.RQID = Material_Issue_Master.RQID) AND (REQMASTER.CY = Material_Issue_Master.CY) " _
                        & " GROUP BY REQMASTER.REQID, REQMASTER.RQID, REQMASTER.CY, Material_Issue_Master.CY " _
                        & " HAVING (((REQMASTER.CY)='" & strCY.Trim & "')) ORDER BY REQMASTER.RQID"



                    '                    SELECT REQMASTER.REQID, REQMASTER.RQID
                    'FROM REQMASTER LEFT JOIN Material_Issue_Master ON (REQMASTER.CY = Material_Issue_Master.CY) AND (REQMASTER.RQID <> Material_Issue_Master.RQID) " _
                    'GROUP BY REQMASTER.REQID, REQMASTER.RQID, REQMASTER.CY, Material_Issue_Master.CY
                    'HAVING (((REQMASTER.CY)='2017-18'))
                    'ORDER BY REQMASTER.RQID;



                    'check code for CY related Join Query
                    'SELECT REQMASTER.REQID, REQMASTER.RQID
                    'FROM REQMASTER INNER JOIN Material_Issue_Master ON (REQMASTER.CY = Material_Issue_Master.CY) AND  (REQMASTER.RQID <> Material_Issue_Master.RQID)
                    'GROUP BY REQMASTER.REQID, REQMASTER.RQID
                    'ORDER BY REQMASTER.RQID;

                Else
                    strSql = "SELECT REQMASTER.REQID,REQMASTER.RQID FROM REQMASTER ORDER BY REQID"
                End If
                FillLookup(strSql, "REQMASTER", "Requisition No", "Req ID", lkupReqNo)
                cmd.Dispose()


                dtpMatIssDate.EditValue = Now
            End If

            If strcheck = "Edit" Then

                Dim strSql As String
                cmd.CommandText = "Select count(*) from Material_Issue_Master "
                If cmd.ExecuteScalar > 0 Then
                    'strSql = "SELECT  REQMASTER.REQID, REQMASTER.RQID " _
                    '    & " FROM REQMASTER INNER JOIN Material_Issue_Master ON REQMASTER.RQID <> Material_Issue_Master.RQID " _
                    '    & " GROUP BY REQMASTER.RQID,REQMASTER.REQID ORDER BY REQMASTER.RQID "

                    strSql = "SELECT REQMASTER.REQID, REQMASTER.RQID " _
                       & " FROM REQMASTER LEFT JOIN Material_Issue_Master ON (REQMASTER.RQID = Material_Issue_Master.RQID) AND (REQMASTER.CY = Material_Issue_Master.CY) " _
                       & " GROUP BY REQMASTER.REQID, REQMASTER.RQID ORDER BY REQMASTER.RQID"

                    'check code for CY related Join Query
                    'SELECT REQMASTER.REQID, REQMASTER.RQID
                    'FROM REQMASTER INNER JOIN Material_Issue_Master ON (REQMASTER.CY = Material_Issue_Master.CY) AND  (REQMASTER.RQID <> Material_Issue_Master.RQID)
                    'GROUP BY REQMASTER.REQID, REQMASTER.RQID
                    'ORDER BY REQMASTER.RQID;

                Else
                    strSql = "SELECT REQMASTER.REQID,REQMASTER.RQID FROM REQMASTER ORDER BY REQID"
                End If
                FillLookup(strSql, "REQMASTER", "Requisition No", "Req ID", lkupReqNo)
                cmd.Dispose()

                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                cmd.CommandText = "SELECT Material_Issue_Master.*, FGMaster.FGName " _
                    & " FROM Material_Issue_Master INNER JOIN FGMaster ON " _
                    & " Material_Issue_Master.FGID = FGMaster.FID where Material_Issue_Master.mis_no = '" & ModMain.strgridid & "'" ' and Material_Issue_Master.CY ='" & strCY.Trim & "'"
                dr = cmd.ExecuteReader
                dr.Read()
                bind_data()
                dr.Close()
                cmd.Dispose()
                lkupReqNo.Properties.ReadOnly = True
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub bind_data()
        'DHAVAL
        Try
            If IsDBNull(dr(0)) = True Then
                txtMatIssNo.Text = ""
            Else
                txtMatIssNo.Text = dr(0).ToString
            End If

            If IsDBNull(dr(1)) = True Then
                dtpMatIssDate.EditValue = ""
            Else
                dtpMatIssDate.EditValue = dr(1).ToString
            End If

            Dim strReqNo As String
            If IsDBNull(dr("RQID")) = True Then
                strReqNo = ""
            Else
                strReqNo = dr("RQID").ToString
            End If

            If IsDBNull(dr("FGName")) = True Then
                txtFG.Text = ""
            Else
                txtFG.Text = dr("FGName")
                txtFG.Tag = dr("FGID")
            End If

            If dr("VI_Req") = True Then
                chkVIReq.Checked = True
            Else
                chkVIReq.Checked = False
            End If
            dr.Close()

            If strReqNo <> "" Then
                lkupReqNo.EditValue = strReqNo
            End If

            Dim adp As New OleDb.OleDbDataAdapter("SELECT Material_Issue_Detail.RID, RMItemMaster.RMItemName as [Item Name] , Material_Issue_Detail.RMVI_NO, UnitMaster.UnitName as Unit, " _
                 & " REQDETAIL.QTY as [Req Qty]," _
                 & " Material_Issue_Detail.Issued_Qty as [Issued Qty], Material_Issue_Detail.MIS_NO,'RM' as ProductType" _
                 & " FROM (((Material_Issue_Master INNER JOIN Material_Issue_Detail ON Material_Issue_Master.MIS_NO = Material_Issue_Detail.MIS_NO) INNER JOIN REQDETAIL ON (Material_Issue_Master.RQID = REQDETAIL.RQID) AND (Material_Issue_Detail.RID = REQDETAIL.RID)) " _
                 & " INNER JOIN UnitMaster ON REQDETAIL.UID = UnitMaster.UnitID) INNER JOIN RMItemMaster ON (UnitMaster.UnitID = RMItemMaster.UnitId) AND (Material_Issue_Detail.RID = RMItemMaster.Rid)" _
                 & " WHERE (((Material_Issue_Detail.MIS_NO)='" & ModMain.strgridid.Trim & "')) ", conn) 'and Material_issue_Master.CY ='" & strCY.Trim & "'

            dt.Rows.Clear()
            adp.Fill(dt)
            fillDataSetWithSemiFinishGood()
            grdMatIssue.DataSource = dt
            gvMatIssue.Columns("RID").VisibleIndex = -1
            gvMatIssue.Columns("UID").VisibleIndex = -1
            gvMatIssue.Columns("Available Qty").VisibleIndex = -1
            gvMatIssue.Columns("MIS_NO").VisibleIndex = -1
        Catch ex As Exception
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        'DHAVAL
        Try
            Dim str As String
            If strcheck = "Add" Then
                str = "select count(MIS_NO) from Material_Issue_Master where mis_No= '" & txtMatIssNo.Text & "' and cy ='" & strCY.Trim & "'"
                If IsDuplicate(str) = True Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("This MIS Number already exists ", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                cmd.Transaction = conn.BeginTransaction
                cmd.CommandText = "insert into Material_Issue_Master values ('" & Replace(txtMatIssNo.Text, "''", "'") & "','" & dtpMatIssDate.Text & "','" & lkupReqNo.Tag.Trim & "','" & txtFG.Tag & "'," & txtFgQty.Text & "," & chkVIReq.Checked & ",'" & strCY.Trim & "')"
                cmd.ExecuteNonQuery()

                For i As Int16 = 0 To gvMatIssue.RowCount - 1
                    cmd.CommandText = "insert into Material_Issue_Detail values('" & Replace(txtMatIssNo.Text, "''", "'") & "','" & gvMatIssue.GetRowCellValue(i, "RID") & "','" & gvMatIssue.GetRowCellValue(i, "RMVI_NO") & "'," & gvMatIssue.GetRowCellValue(i, "Issued Qty") & ",'" & strCY.Trim & "')"
                    cmd.ExecuteNonQuery()

                    'Unit Calculation
                    If (gvMatIssue.GetRowCellValue(i, "ProductType") = "RM") Then
                        cmd.CommandText = "update RMSTOCK set Issue_Qty = (Issue_Qty + " & gvMatIssue.GetRowCellValue(i, "Issued Qty") & "), Balance_Qty = (Balance_Qty - " & gvMatIssue.GetRowCellValue(i, "Issued Qty") & ") WHERE RMVI_No='" & gvMatIssue.GetRowCellValue(i, "RMVI_NO") & "' AND RID ='" & gvMatIssue.GetRowCellValue(i, "RID") & "'" ' and CY ='" & strCY.Trim & "'"
                    Else
                        cmd.CommandText = "update SemiFGStock set Issue_Qty = (Issue_Qty + " & gvMatIssue.GetRowCellValue(i, "Issued Qty") & "), Balance_Qty = (Balance_Qty - " & gvMatIssue.GetRowCellValue(i, "Issued Qty") & ") WHERE Batch_No ='" & gvMatIssue.GetRowCellValue(i, "RMVI_NO") & "' AND SFID ='" & gvMatIssue.GetRowCellValue(i, "RID") & "'" ' and CY ='" & strCY.Trim & "'"
                    End If
                    cmd.ExecuteNonQuery()
                Next
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Issue & Balance Quantity is successfully updated", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmd.Transaction.Commit()

            ElseIf strcheck = "Edit" Then
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                cmd.Transaction = conn.BeginTransaction
                cmd.CommandText = "update Material_Issue_Master set mis_no = '" & txtMatIssNo.Text.Trim & "', mis_date = '" & dtpMatIssDate.Text & "',vi_req = " & chkVIReq.Checked & " where mis_No = '" & ModMain.strgridid & "'" ' and CY ='" & strCY.Trim & "'"
                cmd.ExecuteNonQuery()

                cmd.CommandText = "delete from Material_Issue_detail where mis_No = '" & ModMain.strgridid & "' " ' and CY ='" & strCY.Trim & "'"
                cmd.ExecuteNonQuery()
                For i As Int16 = 0 To gvMatIssue.RowCount - 1
                    cmd.CommandText = "insert into Material_Issue_Detail values('" & Replace(txtMatIssNo.Text, "''", "'") & "','" & gvMatIssue.GetRowCellValue(i, "RID") & "','" & gvMatIssue.GetRowCellValue(i, "RMVI_NO") & "'," & gvMatIssue.GetRowCellValue(i, "Issued Qty") & ",'" & strCY.Trim & "')"
                    cmd.ExecuteNonQuery()

                    'Unit Calculation
                    'cmd.CommandText = "update RMSTOCK set Issue_Qty = (Issue_Qty + " & gvMatIssue.GetRowCellValue(i, "Issued Qty") & "), Balance_Qty = (Balance_Qty - " & gvMatIssue.GetRowCellValue(i, "Issued Qty") & ") WHERE RMVI_No='" & gvMatIssue.GetRowCellValue(i, "RMVI_NO") & "' AND RID ='" & gvMatIssue.GetRowCellValue(i, "RID") & "'"
                    'cmd.ExecuteNonQuery()
                Next
                cmd.Transaction.Commit()
            End If
            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Save Data Successfully", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            cmd.Dispose()
            Me.Close()
        Catch ex As Exception
            cmd.Transaction.Rollback()
            If show_error = True Then
                MsgBox(ex.ToString)
            End If
            'cmd.Transaction.Rollback()
        End Try
    End Sub


    'Private Sub txtQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    'DHAVAL
    '    If InStr(txtQty.Text, ".") <> 0 And Asc(e.KeyChar) = 46 Then
    '        e.Handled = True
    '        Exit Sub
    '    End If
    '    e.Handled = IsDecimalNumber(e.KeyChar)
    'End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'DHAVAL
        Try
            If gvMatIssue.GetSelectedRows.Length > 0 Then
                If DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Are you sure you want to delete the row", StrAppName, MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    gvMatIssue.DeleteRow(gvMatIssue.FocusedRowHandle)
                    gvMatIssue.RefreshData()
                End If
            End If

        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
        Me.Dispose()
    End Sub
    'Private Sub cboReqNo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboReqNo1.Validating
    '    Try
    '        Dim blnCheck As Boolean = False
    '        cmd = New OleDb.OleDbCommand
    '        Dim dr As OleDb.OleDbDataReader
    '        cmd.Connection = conn
    '        cmd.CommandText = "SELECT FGMaster.FID, FGMaster.FGName, REQMASTER.RQID,REQMASTER.QTY " _
    '            & " FROM REQMASTER INNER JOIN FGMaster ON REQMASTER.FID = FGMaster.FID " _
    '            & " WHERE (((REQMASTER.RQID)='" & cboReqNo.Text.Trim & "'));"
    '        dr = cmd.ExecuteReader
    '        Do While dr.Read
    '            blnCheck = True
    '            txtFG.Text = dr.Item("FGName").ToString.Trim
    '            txtFG.Tag = dr.Item("FID").ToString.Trim
    '            txtFgQty.Text = dr.Item("QTY").ToString.Trim
    '        Loop
    '        dr.Close()
    '        cmd.Dispose()
    '        If blnCheck = False Then
    '            txtFG.Text = ""
    '            txtFG.Tag = ""
    '            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Invalid Req. No", "Invalid No", MessageBoxButtons.OK)
    '            cboReqNo.Focus()
    '        Else
    '            Dim strSql As String
    '            If strcheck = "Add" Then
    '                strSql = "SELECT RMItemMaster.RID as RID, RMItemMaster.RMItemName as [Item Name], REQDETAIL.UID as UID, UnitMaster.UnitName as Unit, REQDETAIL.QTY as [Req Qty]" _
    '                    & " FROM (RMItemMaster INNER JOIN REQDETAIL ON RMItemMaster.Rid = REQDETAIL.RID) INNER JOIN UnitMaster ON REQDETAIL.UID = UnitMaster.UnitID where " _
    '                    & " REQDETAIL.RQID ='" & cboReqNo.Text.Trim & "'"
    '            ElseIf strcheck = "Edit" Then
    '                strSql = "SELECT Material_Issue_Detail.RID, RMItemMaster.RMItemName as [Item Name] , Material_Issue_Detail.RMVI_NO, UnitMaster.UnitName as Unit, " _
    '                     & " REQDETAIL.QTY as [Req Qty]," _
    '                     & " Material_Issue_Detail.Issued_Qty as [Issued Qty], Material_Issue_Detail.MIS_NO " _
    '                     & " FROM (((Material_Issue_Master INNER JOIN Material_Issue_Detail ON Material_Issue_Master.MIS_NO = Material_Issue_Detail.MIS_NO) INNER JOIN REQDETAIL ON (Material_Issue_Master.RQID = REQDETAIL.RQID) AND (Material_Issue_Detail.RID = REQDETAIL.RID)) " _
    '                     & " INNER JOIN UnitMaster ON REQDETAIL.UID = UnitMaster.UnitID) INNER JOIN RMItemMaster ON (UnitMaster.UnitID = RMItemMaster.UnitId) AND (Material_Issue_Detail.RID = RMItemMaster.Rid)" _
    '                     & " WHERE (((Material_Issue_Detail.MIS_NO)='" & txtMatIssNo.Text.Trim & "'))"

    '            End If

    '            dt.Rows.Clear()
    '            Dim adpt As New OleDb.OleDbDataAdapter(strSql, conn)
    '            adpt.Fill(dt)
    '            grdMatIssue.DataSource = dt
    '            gvMatIssue.Columns("RID").VisibleIndex = -1
    '            gvMatIssue.Columns("UID").VisibleIndex = -1
    '            gvMatIssue.Columns("Available Qty").VisibleIndex = -1
    '        End If

    '    Catch ex As Exception
    '        If show_error Then
    '            MsgBox(ex.ToString)
    '        End If
    '    End Try
    'End Sub

    Private Sub txtMatIssNo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMatIssNo.EditValueChanged
        Try


        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub txtMatIssNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMatIssNo.Validating
        Try
            If strcheck = "Add" Then
                If txtMatIssNo.Text.Trim <> "" Then
                    Dim strOrderNo As String
                    strOrderNo = IsDuplicate("Select count(MIS_NO) from Material_Issue_Master where MIS_NO = '" & txtMatIssNo.Text.Trim & "' and CY ='" & strCY.Trim & "'")
                    If strOrderNo = True Then
                        e.Cancel = True
                        DevExpress.XtraEditors.XtraMessageBox.Show("Duplicate MIS No.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'MessageBox.Show("This Order_No already exist", "Duplicate Value Error", MessageBoxButtons.OK)
                    End If
                Else
                    e.Cancel = True
                    DevExpress.XtraEditors.XtraMessageBox.Show("Invalid MIS No.", "Invalid No", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub gvMatIssue_CustomRowCellEdit(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvMatIssue.CustomRowCellEdit
        Try
            'If gvChallan.GetRowCellValue(e.RowHandle, gvChallan.Columns(2)) = "Qty" Then
            If e.Column.FieldName = "Issued Qty" Then
                gvMatIssue.Columns("Issued Qty").OptionsColumn.AllowEdit = True
            ElseIf e.Column.FieldName = "RMVI_NO" Then
                '''''''cmbTemp = New RepositoryItemComboBox
                '''''''cmbTemp.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
                Dim strSql As String
                lkupMIS = New RepositoryItemLookUpEdit

                lkupMIS.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor

                Dim fbReader As OleDb.OleDbDataReader
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                Dim strTemp() As String = strCY.Split("-")
                Dim strPY As String
                strPY = strTemp(0).Trim - 1 & "-" & strTemp(1).Trim - 1


                strSql = "SELECT RMStock.RMVI_NO, RMStock.Balance_Qty,RMStock.RMVI_NO " _
                    & " FROM RMStock INNER JOIN RMItemMaster ON RMStock.RID = RMItemMaster.Rid " _
                    & " WHERE RMStock.RID='" & gvMatIssue.GetRowCellValue(e.RowHandle, gvMatIssue.Columns(0)) & "' and " _
                    & " RMStock.Balance_Qty > 0 " 'and RMStock.Type <> 'Opening' "    AND (RMSTOCK.CY ='" & strCY.Trim & "' or RMStock.CY ='" & strPY.Trim & "')

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

                'strSql = "SELECT RM_Opening_Stock.RMVI_NO, RMStock.Balance_Qty, RM_Opening_Stock.RMVI_NO " _
                '    & " FROM RM_Opening_Stock INNER JOIN RMStock ON (RM_Opening_Stock.RMVI_NO = RMStock.RMVI_No) AND (RM_Opening_Stock.RID = RMStock.RID) " _
                '    & " WHERE (((RMStock.Balance_Qty)>= 0)" _
                '    & " AND ((RM_Opening_Stock.RID)='" & gvMatIssue.GetRowCellValue(e.RowHandle, gvMatIssue.Columns(0)) & "' AND RMSTOCK.CY ='" & strCY.Trim & "')); "

                If (gvMatIssue.GetRowCellValue(e.RowHandle, gvMatIssue.Columns("ProductType")) = "RM") Then
                    strSql = "SELECT RM_Opening_Stock.RMVI_NO, RMStock.Balance_Qty, RM_Opening_Stock.RMVI_NO" _
                        & " FROM RM_Opening_Stock INNER JOIN RMStock ON (RM_Opening_Stock.RID = RMStock.RID) AND (RM_Opening_Stock.RMVI_NO = RMStock.RMVI_No) " _
                        & " WHERE (((RM_Opening_Stock.RID)='" & gvMatIssue.GetRowCellValue(e.RowHandle, gvMatIssue.Columns(0)) & "') AND ((RMStock.CY)='" & strCY.Trim & "')) " _
                        & "  GROUP BY RM_Opening_Stock.RMVI_NO, RMStock.Balance_Qty, RM_Opening_Stock.RMVI_NO " _
                        & " HAVING (((RMStock.Balance_Qty)>=0));"

                Else
                    strSql = "SELECT Semi_FG_Opening_Stock.SFGVI_NO as Expr1000 , SemiFGStock.Balance_Qty, Semi_FG_Opening_Stock.SFGVI_NO as [RMVI_NO]" _
                       & " FROM Semi_FG_Opening_Stock INNER JOIN SemiFGStock ON (Semi_FG_Opening_Stock.SFID = SemiFGStock.SFID) AND (Semi_FG_Opening_Stock.SFGVI_NO = SemiFGStock.Batch_no) " _
                       & " WHERE (((Semi_FG_Opening_Stock.SFID)='" & gvMatIssue.GetRowCellValue(e.RowHandle, gvMatIssue.Columns(0)) & "') AND ((SemiFGStock.CY)='" & strCY.Trim & "')) " _
                       & "  GROUP BY Semi_FG_Opening_Stock.SFGVI_NO, SemiFGStock.Balance_Qty, Semi_FG_Opening_Stock.SFGVI_NO " _
                       & " HAVING (((SemiFGStock.Balance_Qty)>=0));"

                    strSql = "SELECT SemiFGStock.Batch_No, SemiFGStock.Batch_No, SemiFGStock.Balance_Qty " _
                    & " FROM(SemiFGStock) WHERE(((SemiFGStock.CY) = '" & strCY.Trim & "') And ((SemiFGStock.SFID) = '" & gvMatIssue.GetRowCellValue(e.RowHandle, gvMatIssue.Columns(0)) & "'))" _
                    & " GROUP BY SemiFGStock.Balance_Qty, SemiFGStock.Batch_No, SemiFGStock.Batch_No, SemiFGStock.Balance_Qty " _
                    & " HAVING (((SemiFGStock.Balance_Qty)>=0));"

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
                ''''''cmbTemp = New RepositoryItemComboBox
                ''''''cmbTemp.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor

                ''''''Dim fbReader As OleDb.OleDbDataReader
                ''''''cmd = New OleDb.OleDbCommand
                ''''''cmd.Connection = conn

                ''''''cmd.CommandText = "SELECT RMStock.RMVI_No, RMStock.Balance_Qty, RMStock.RID,RMItemMaster.RMItemName AS [Item Name] " _
                ''''''    & " FROM RMStock INNER JOIN RMItemMaster ON RMStock.RID = RMItemMaster.Rid " _
                ''''''    & " WHERE RMStock.RID='" & gvMatIssue.GetRowCellValue(e.RowHandle, gvMatIssue.Columns(0)) & "' and " _
                ''''''    & " RMStock.Balance_Qty >= " & IIf(IsDBNull(gvMatIssue.GetRowCellValue(e.RowHandle, gvMatIssue.Columns(5))), 0, gvMatIssue.GetRowCellValue(e.RowHandle, gvMatIssue.Columns(5)))
                ''''''fbReader = cmd.ExecuteReader()

                ''''''Do While fbReader.Read
                ''''''    cmbTemp.Items.Add(fbReader.Item("RMVI_NO"))
                ''''''Loop
                ''''''fbReader.Close()

                ''''''cmd.CommandText = "SELECT RM_Opening_Stock.RMVI_NO, RMStock.Balance_Qty, RM_Opening_Stock.RID " _
                ''''''    & " FROM RM_Opening_Stock INNER JOIN RMStock ON (RM_Opening_Stock.RMVI_NO = RMStock.RMVI_No) AND (RM_Opening_Stock.RID = RMStock.RID) " _
                ''''''    & " WHERE (((RMStock.Balance_Qty)>=" & IIf(IsDBNull(gvMatIssue.GetRowCellValue(e.RowHandle, gvMatIssue.Columns(5))), 0, gvMatIssue.GetRowCellValue(e.RowHandle, gvMatIssue.Columns(5))) & ") " _
                ''''''    & " AND ((RM_Opening_Stock.RID)='" & gvMatIssue.GetRowCellValue(e.RowHandle, gvMatIssue.Columns(0)) & "')); "
                ''''''fbReader = cmd.ExecuteReader
                ''''''Do While fbReader.Read
                ''''''    If cmbTemp.Items.Contains(fbReader.Item("RMVI_NO")) = False Then
                ''''''        cmbTemp.Items.Add(fbReader.Item("RMVI_NO"))
                ''''''    End If
                ''''''Loop
                ''''''fbReader.Close()
                ''''''e.RepositoryItem = cmbTemp

                ''''''cmd.Dispose()
            Else
                gvMatIssue.Columns(e.Column.FieldName).OptionsColumn.AllowEdit = False
            End If
        Catch ex As Exception
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReport.Click
        Try
            Dim myPara As New frmPara
            myPara.ShowMIS(ModMain.strgridid.Trim & "'")
            myPara.Close()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub lkupReqNo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupReqNo.EditValueChanged
        Try
            If lkupReqNo.EditValue <> "" Or Not lkupReqNo.EditValue = Nothing Then
                Dim row As DataRowView = lkupReqNo.Properties.GetDataSourceRowByKeyValue(lkupReqNo.EditValue)
                'lkupReqNo.Text = row(0).ToString
                lkupReqNo.Tag = row(1).ToString

            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub lkupReqNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lkupReqNo.TextChanged
        Try
            If lkupReqNo.Tag <> "" Then
                Dim blnCheck As Boolean = False
                cmd = New OleDb.OleDbCommand
                Dim dr As OleDb.OleDbDataReader
                cmd.Connection = conn
                cmd.CommandText = "SELECT FGMaster.FID, FGMaster.FGName, REQMASTER.RQID,REQMASTER.QTY,REQMASTER.WORKORDERNO " _
                    & " FROM REQMASTER INNER JOIN FGMaster ON REQMASTER.FID = FGMaster.FID " _
                    & " WHERE (((REQMASTER.RQID)='" & lkupReqNo.Tag.Trim & "')) and REQMASTER.CY ='" & strCY.Trim & "';"
                dr = cmd.ExecuteReader
                Do While dr.Read
                    blnCheck = True
                    txtFG.Text = dr.Item("FGName").ToString.Trim
                    txtFG.Tag = dr.Item("FID").ToString.Trim
                    txtFgQty.Text = dr.Item("QTY").ToString.Trim
                    txtWorkOrderVal.Text = dr.Item("WORKORDERNO").ToString.Trim()
                Loop
                dr.Close()
                cmd.Dispose()
                If blnCheck = False Then
                    txtFG.Text = ""
                    txtFG.Tag = ""
                    If strcheck = "Add" Then
                        DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Invalid Req. No", "Invalid No", MessageBoxButtons.OK)
                        lkupReqNo.Focus()
                    End If
                Else
                    Dim strSql As String
                    If strcheck = "Add" Then
                        strSql = "SELECT RMItemMaster.RID as RID, RMItemMaster.RMItemName as [Item Name], REQDETAIL.UID as UID, UnitMaster.UnitName as Unit, REQDETAIL.QTY as [Req Qty]," _
                            & " 'RM' as ProductType FROM (RMItemMaster INNER JOIN REQDETAIL ON RMItemMaster.Rid = REQDETAIL.RID) INNER JOIN UnitMaster ON REQDETAIL.UID = UnitMaster.UnitID where " _
                            & " REQDETAIL.RQID ='" & lkupReqNo.Tag.Trim & "' AND REQDETAIL.CY ='" & strCY.Trim & "'"
                    ElseIf strcheck = "Edit" Then
                        strSql = "SELECT Material_Issue_Detail.RID, RMItemMaster.RMItemName as [Item Name] , Material_Issue_Detail.RMVI_NO, UnitMaster.UnitName as Unit, " _
                             & " REQDETAIL.QTY as [Req Qty],'RM' as ProductType," _
                             & " Material_Issue_Detail.Issued_Qty as [Issued Qty], Material_Issue_Detail.MIS_NO " _
                             & " FROM (((Material_Issue_Master INNER JOIN Material_Issue_Detail ON Material_Issue_Master.MIS_NO = Material_Issue_Detail.MIS_NO) INNER JOIN REQDETAIL ON (Material_Issue_Master.RQID = REQDETAIL.RQID) AND (Material_Issue_Detail.RID = REQDETAIL.RID)) " _
                             & " INNER JOIN UnitMaster ON REQDETAIL.UID = UnitMaster.UnitID) INNER JOIN RMItemMaster ON (UnitMaster.UnitID = RMItemMaster.UnitId) AND (Material_Issue_Detail.RID = RMItemMaster.Rid)" _
                             & " WHERE (((Material_Issue_Detail.MIS_NO)='" & txtMatIssNo.Text.Trim & "')) AND MATERIAL_ISSUE_DETAIL.CY ='" & strCY.Trim & "'"
                    End If

                    dt.Rows.Clear()
                    Dim adpt As New OleDb.OleDbDataAdapter(strSql, conn)
                    adpt.Fill(dt)
                    fillDataSetWithSemiFinishGood()
                    grdMatIssue.DataSource = dt
                    gvMatIssue.Columns("RID").VisibleIndex = -1
                    gvMatIssue.Columns("UID").VisibleIndex = -1
                    gvMatIssue.Columns("Available Qty").VisibleIndex = -1

                End If
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Function fillDataSetWithSemiFinishGood() As DataTable
        Dim dtSemiFG As New DataTable
        Dim strSql As String
        If (strcheck = "Add") Then
            strSql = "SELECT SemiFGMaster.SFID as RID, SemiFGMaster.FGName as [Item Name], SEMI_REQDETAIL.UID as UID, UnitMaster.UnitName as Unit, SEMI_REQDETAIL.QTY as [Req Qty]" _
                & " FROM (SemiFGMaster INNER JOIN SEMI_REQDETAIL ON SemiFGMaster.SFid = SEMI_REQDETAIL.SFID) INNER JOIN UnitMaster ON SEMI_REQDETAIL.UID = UnitMaster.UnitID where " _
                & " SEMI_REQDETAIL.RQID ='" & lkupReqNo.Tag.Trim & "' AND SEMI_REQDETAIL.CY ='" & strCY.Trim & "'"

            Dim adpt As New OleDb.OleDbDataAdapter(strSql, conn)
            adpt.Fill(dtSemiFG)
            If (dtSemiFG.Rows.Count > 0) Then
                For i As Integer = 0 To dtSemiFG.Rows.Count - 1
                    Dim dr As DataRow
                    dr = dt.NewRow
                    dr.Item(0) = dtSemiFG.Rows(i).Item(0).ToString()
                    dr.Item(1) = dtSemiFG.Rows(i).Item(1).ToString()
                    dr.Item(3) = dtSemiFG.Rows(i).Item(2).ToString()
                    dr.Item(4) = dtSemiFG.Rows(i).Item(3).ToString()
                    dr.Item(5) = dtSemiFG.Rows(i).Item(4).ToString()
                    dr.Item(8) = "SFG"
                    dt.Rows.Add(dr)
                    i = i + 1
                Next
            End If
        Else
            strSql = "SELECT Material_Issue_Detail.RID, SemiFGMaster.FGName as [Item Name] , Material_Issue_Detail.RMVI_NO, UnitMaster.UnitName as Unit, " _
                             & " SEMI_REQDETAIL.QTY as [Req Qty]," _
                             & " Material_Issue_Detail.Issued_Qty as [Issued Qty], Material_Issue_Detail.MIS_NO " _
                             & " FROM (((Material_Issue_Master INNER JOIN Material_Issue_Detail ON Material_Issue_Master.MIS_NO = Material_Issue_Detail.MIS_NO) INNER JOIN SEMI_REQDETAIL ON (Material_Issue_Master.RQID = SEMI_REQDETAIL.RQID) AND (Material_Issue_Detail.RID = SEMI_REQDETAIL.SFID)) " _
                             & " INNER JOIN UnitMaster ON SEMI_REQDETAIL.UID = UnitMaster.UnitID) INNER JOIN SemiFGMaster ON (UnitMaster.UnitID = SemiFGMaster.UnitId) AND (Material_Issue_Detail.RID = SemiFGMaster.SFid)" _
                             & " WHERE (((Material_Issue_Detail.MIS_NO)='" & txtMatIssNo.Text.Trim & "')) AND MATERIAL_ISSUE_DETAIL.CY ='" & strCY.Trim & "'"

            Dim adpt As New OleDb.OleDbDataAdapter(strSql, conn)
            adpt.Fill(dtSemiFG)
            If (dtSemiFG.Rows.Count > 0) Then               
                For i As Integer = 0 To dtSemiFG.Rows.Count - 1
                    Dim dr As DataRow
                    dr = dt.NewRow
                    dr.Item(0) = dtSemiFG.Rows(i).Item(0).ToString()
                    dr.Item(1) = dtSemiFG.Rows(i).Item(1).ToString()
                    dr.Item(2) = dtSemiFG.Rows(i).Item(2).ToString()
                    dr.Item(4) = dtSemiFG.Rows(i).Item(3).ToString()
                    dr.Item(5) = dtSemiFG.Rows(i).Item(4).ToString()
                    dr.Item(6) = dtSemiFG.Rows(i).Item(5).ToString()
                    dr.Item(8) = "SFG"
                    dt.Rows.Add(dr)
                    i = i + 1
                Next
            End If
        End If
        Return dtSemiFG
    End Function
End Class

