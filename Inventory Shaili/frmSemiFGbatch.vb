Public Class frmSemiFGBatch
    Inherits System.Windows.Forms.Form
    Public strcheck As String
    Dim cmd As OleDb.OleDbCommand
    Dim cmd1 As OleDb.OleDbCommand
    Dim dr As OleDb.OleDbDataReader
    Dim strfgid As String
    Dim dt As New DataTable
    'Dim dsBatch As New DataSet
    Dim batchmasterid As String
    Friend WithEvents cmdADDFG As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdBatch As DevExpress.XtraEditors.SimpleButton
    Dim strItemID As String


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
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblRaw As System.Windows.Forms.Label
    Friend WithEvents txtqty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtfgqty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtbatchid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents gdbatchdetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents lblfgqty As System.Windows.Forms.Label
    Friend WithEvents lblfgname As System.Windows.Forms.Label
    Friend WithEvents lblbatchid As System.Windows.Forms.Label
    Friend WithEvents cbofgname As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gvbatch As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdclose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lkupItemName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents grpbatch As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lkupUOM As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cboUOM As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnReport As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpbatch = New DevExpress.XtraEditors.GroupControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdBatch = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdADDFG = New DevExpress.XtraEditors.SimpleButton()
        Me.btnReport = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdsave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdclose = New DevExpress.XtraEditors.SimpleButton()
        Me.cbofgname = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cboUOM = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lkupItemName = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtqty = New DevExpress.XtraEditors.TextEdit()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.gdbatchdetail = New DevExpress.XtraGrid.GridControl()
        Me.gvbatch = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.lblRaw = New System.Windows.Forms.Label()
        Me.txtfgqty = New DevExpress.XtraEditors.TextEdit()
        Me.lblfgqty = New System.Windows.Forms.Label()
        Me.lblfgname = New System.Windows.Forms.Label()
        Me.lblbatchid = New System.Windows.Forms.Label()
        Me.txtbatchid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.grpbatch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbatch.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbofgname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cboUOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupItemName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtqty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdbatchdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvbatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfgqty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtbatchid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpbatch
        '
        Me.grpbatch.Controls.Add(Me.GroupBox1)
        Me.grpbatch.Controls.Add(Me.btnReport)
        Me.grpbatch.Controls.Add(Me.cmdsave)
        Me.grpbatch.Controls.Add(Me.cmdclose)
        Me.grpbatch.Controls.Add(Me.cbofgname)
        Me.grpbatch.Controls.Add(Me.PanelControl1)
        Me.grpbatch.Controls.Add(Me.txtfgqty)
        Me.grpbatch.Controls.Add(Me.lblfgqty)
        Me.grpbatch.Controls.Add(Me.lblfgname)
        Me.grpbatch.Controls.Add(Me.lblbatchid)
        Me.grpbatch.Controls.Add(Me.txtbatchid)
        Me.grpbatch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpbatch.Location = New System.Drawing.Point(0, 0)
        Me.grpbatch.Name = "grpbatch"
        Me.grpbatch.Size = New System.Drawing.Size(488, 390)
        Me.grpbatch.TabIndex = 14
        Me.grpbatch.Text = "Batch Details"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdBatch)
        Me.GroupBox1.Controls.Add(Me.cmdADDFG)
        Me.GroupBox1.Location = New System.Drawing.Point(382, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(101, 72)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'cmdBatch
        '
        Me.cmdBatch.Location = New System.Drawing.Point(4, 43)
        Me.cmdBatch.Name = "cmdBatch"
        Me.cmdBatch.Size = New System.Drawing.Size(95, 25)
        Me.cmdBatch.TabIndex = 27
        Me.cmdBatch.Text = "&New Batch"
        '
        'cmdADDFG
        '
        Me.cmdADDFG.Location = New System.Drawing.Point(4, 12)
        Me.cmdADDFG.Name = "cmdADDFG"
        Me.cmdADDFG.Size = New System.Drawing.Size(95, 25)
        Me.cmdADDFG.TabIndex = 26
        Me.cmdADDFG.Text = "&New Semi FG"
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(16, 360)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(75, 25)
        Me.btnReport.TabIndex = 25
        Me.btnReport.Text = "&Report"
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(328, 360)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(75, 25)
        Me.cmdsave.TabIndex = 10
        Me.cmdsave.Text = "&Save"
        '
        'cmdclose
        '
        Me.cmdclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdclose.Location = New System.Drawing.Point(408, 360)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(75, 25)
        Me.cmdclose.TabIndex = 11
        Me.cmdclose.Text = "&Close"
        '
        'cbofgname
        '
        Me.cbofgname.EditValue = ""
        Me.cbofgname.Location = New System.Drawing.Point(128, 64)
        Me.cbofgname.Name = "cbofgname"
        Me.cbofgname.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbofgname.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbofgname.Size = New System.Drawing.Size(248, 20)
        Me.cbofgname.TabIndex = 2
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.cboUOM)
        Me.PanelControl1.Controls.Add(Me.lkupItemName)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.txtqty)
        Me.PanelControl1.Controls.Add(Me.lblqty)
        Me.PanelControl1.Controls.Add(Me.gdbatchdetail)
        Me.PanelControl1.Controls.Add(Me.cmdAdd)
        Me.PanelControl1.Controls.Add(Me.cmdDelete)
        Me.PanelControl1.Controls.Add(Me.lblRaw)
        Me.PanelControl1.Location = New System.Drawing.Point(8, 128)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(475, 224)
        Me.PanelControl1.TabIndex = 24
        Me.PanelControl1.Text = "-**"
        '
        'cboUOM
        '
        Me.cboUOM.EditValue = ""
        Me.cboUOM.Location = New System.Drawing.Point(288, 16)
        Me.cboUOM.Name = "cboUOM"
        Me.cboUOM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUOM.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboUOM.Size = New System.Drawing.Size(80, 20)
        Me.cboUOM.TabIndex = 5
        '
        'lkupItemName
        '
        Me.lkupItemName.EditValue = ""
        Me.lkupItemName.Location = New System.Drawing.Point(48, 16)
        Me.lkupItemName.Name = "lkupItemName"
        Me.lkupItemName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupItemName.Properties.NullText = ""
        Me.lkupItemName.Size = New System.Drawing.Size(192, 20)
        Me.lkupItemName.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Unit:"
        '
        'txtqty
        '
        Me.txtqty.EditValue = ""
        Me.txtqty.Location = New System.Drawing.Point(416, 16)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Properties.Appearance.Options.UseFont = True
        Me.txtqty.Properties.MaxLength = 4
        Me.txtqty.Size = New System.Drawing.Size(48, 22)
        Me.txtqty.TabIndex = 6
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.Location = New System.Drawing.Point(384, 16)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(32, 16)
        Me.lblqty.TabIndex = 24
        Me.lblqty.Text = "Qty:"
        '
        'gdbatchdetail
        '
        '
        '
        '
        Me.gdbatchdetail.EmbeddedNavigator.Name = ""
        Me.gdbatchdetail.Location = New System.Drawing.Point(8, 72)
        Me.gdbatchdetail.MainView = Me.gvbatch
        Me.gdbatchdetail.Name = "gdbatchdetail"
        Me.gdbatchdetail.Size = New System.Drawing.Size(456, 144)
        Me.gdbatchdetail.TabIndex = 9
        Me.gdbatchdetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvbatch})
        '
        'gvbatch
        '
        Me.gvbatch.GridControl = Me.gdbatchdetail
        Me.gvbatch.Name = "gvbatch"
        Me.gvbatch.OptionsBehavior.Editable = False
        Me.gvbatch.OptionsCustomization.AllowColumnMoving = False
        Me.gvbatch.OptionsCustomization.AllowGroup = False
        Me.gvbatch.OptionsMenu.EnableFooterMenu = False
        Me.gvbatch.OptionsMenu.EnableGroupPanelMenu = False
        Me.gvbatch.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvbatch.OptionsView.ShowGroupPanel = False
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(360, 40)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(48, 25)
        Me.cmdAdd.TabIndex = 7
        Me.cmdAdd.Text = "&Add"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(416, 40)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(48, 25)
        Me.cmdDelete.TabIndex = 8
        Me.cmdDelete.Text = "&Delete"
        '
        'lblRaw
        '
        Me.lblRaw.AutoSize = True
        Me.lblRaw.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaw.Location = New System.Drawing.Point(8, 16)
        Me.lblRaw.Name = "lblRaw"
        Me.lblRaw.Size = New System.Drawing.Size(39, 16)
        Me.lblRaw.TabIndex = 21
        Me.lblRaw.Text = "Item:"
        '
        'txtfgqty
        '
        Me.txtfgqty.EditValue = ""
        Me.txtfgqty.Location = New System.Drawing.Point(128, 96)
        Me.txtfgqty.Name = "txtfgqty"
        Me.txtfgqty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfgqty.Properties.Appearance.Options.UseFont = True
        Me.txtfgqty.Size = New System.Drawing.Size(248, 22)
        Me.txtfgqty.TabIndex = 3
        '
        'lblfgqty
        '
        Me.lblfgqty.AutoSize = True
        Me.lblfgqty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfgqty.Location = New System.Drawing.Point(16, 96)
        Me.lblfgqty.Name = "lblfgqty"
        Me.lblfgqty.Size = New System.Drawing.Size(60, 16)
        Me.lblfgqty.TabIndex = 4
        Me.lblfgqty.Text = "Quantity:"
        '
        'lblfgname
        '
        Me.lblfgname.AutoSize = True
        Me.lblfgname.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfgname.Location = New System.Drawing.Point(16, 64)
        Me.lblfgname.Name = "lblfgname"
        Me.lblfgname.Size = New System.Drawing.Size(116, 16)
        Me.lblfgname.TabIndex = 2
        Me.lblfgname.Text = "Semi Finish Name:"
        '
        'lblbatchid
        '
        Me.lblbatchid.AutoSize = True
        Me.lblbatchid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbatchid.Location = New System.Drawing.Point(16, 32)
        Me.lblbatchid.Name = "lblbatchid"
        Me.lblbatchid.Size = New System.Drawing.Size(60, 16)
        Me.lblbatchid.TabIndex = 1
        Me.lblbatchid.Text = "Batch ID:"
        '
        'txtbatchid
        '
        Me.txtbatchid.EditValue = ""
        Me.txtbatchid.Location = New System.Drawing.Point(128, 32)
        Me.txtbatchid.Name = "txtbatchid"
        Me.txtbatchid.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbatchid.Properties.Appearance.Options.UseFont = True
        Me.txtbatchid.Size = New System.Drawing.Size(248, 22)
        Me.txtbatchid.TabIndex = 1
        '
        'frmSemiFGBatch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(488, 390)
        Me.Controls.Add(Me.grpbatch)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSemiFGBatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Semi Finish Good Batch Detail"
        CType(Me.grpbatch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbatch.ResumeLayout(False)
        Me.grpbatch.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.cbofgname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cboUOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupItemName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtqty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdbatchdetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvbatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfgqty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtbatchid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmbatch_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'following code will add columns in the table and "itemid" and so on are column header
            dt.Columns.Add("ItemID", System.Type.GetType("System.String"))
            dt.Columns.Add("Item Name", System.Type.GetType("System.String"))
            dt.Columns.Add("UnitID", System.Type.GetType("System.String"))
            dt.Columns.Add("Unit", System.Type.GetType("System.String"))
            dt.Columns.Add("Qty", System.Type.GetType("System.String"))
            dt.Columns.Add("RID", System.Type.GetType("System.String"))


            If strcheck = "Add" Then
                txtbatchid.Text = GetMaxNo("batchid", "SemiFGBatchMaster", "SGBP", 10)
                batchmasterid = txtbatchid.Text
                btnReport.Visible = False
            End If
            If strcheck = "Edit" Then
                batchmasterid = txtbatchid.Text
                cmd = New OleDb.OleDbCommand

                cmd.CommandText = "SELECT SemiFGBatchMaster.BatchID, SemiFGMaster.FGName, SemiFGBatchMaster.Qty,SemiFGBatchMaster.SFID " _
                    & " FROM SemiFGBatchMaster INNER JOIN SemiFGMaster ON SemiFGBatchMaster.SFID = SemiFGMaster.SFID " _
                    & " WHERE (((SemiFGBatchMaster.BatchID)='" & ModMain.strgridid & "'))"

                cmd.Connection = conn
                dr = cmd.ExecuteReader()
                dr.Read()
                bind_data()
                dr.Close()
                cmd.Dispose()

                gvbatch.Columns.Clear()
                Dim adp As New OleDb.OleDbDataAdapter("SELECT  SemiFGBatchdetail.RID, RMItemMaster.RMItemName as [Item Name], SemiFGBatchdetail.UnitID, UnitMaster.UnitName as Unit, " _
                                & " SemiFGBatchdetail.Qty " _
                                & " FROM ((SemiFGBatchMaster INNER JOIN SemiFGBatchdetail ON SemiFGBatchMaster.BatchID = SemiFGBatchdetail.BatchID) INNER JOIN RMItemMaster ON SemiFGBatchdetail.RID = RMItemMaster.RId) INNER JOIN UnitMaster ON SemiFGBatchdetail.UnitID = UnitMaster.UnitID " _
                                & " WHERE SemiFGBatchMaster.BatchID='" & ModMain.strgridid & "'", conn)
                adp.Fill(dt)

                gdbatchdetail.DataSource = dt     ' dsBatch.Tables("Batchdetail")
                gvbatch.Columns(0).Visible = False
                gvbatch.Columns(2).Visible = False
                gvbatch.Columns(5).Visible = False
                gdbatchdetail.Enabled = True
            End If


            FillLookup("Select RMItemName,Rid from RMItemMaster", "RMItemMaster", "Item Name", "RID", lkupItemName)

            'Fillcmb("Select UnitID,UnitName from UnitMaster", "UnitMaster", "UnitID", "UnitName", cbounit)

        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Public Sub bind_data()
        'batchid
        If IsDBNull(dr(0).ToString) = True Then
            txtbatchid.Text = ""
        Else
            txtbatchid.Text = dr(0).ToString
            batchmasterid = txtbatchid.Text
        End If

        'rawitemid
        If IsDBNull(dr(1).ToString) = True Then
            cbofgname.Text = ""
        Else
            cbofgname.Text = dr(1).ToString
            strfgid = dr(3).ToString
        End If


        'qty()
        If IsDBNull(dr(2).ToString) = True Then
            txtfgqty.Text = ""
        Else
            txtfgqty.Text = dr(2).ToString
        End If
    End Sub

    Private Sub cbofgname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbofgname.GotFocus
        Try
            FillCombox("Semifgmaster", "fgname", cbofgname)
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cbofgname_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbofgname.Validating
        Dim strSql As String
        'strSql = "SELECT Count(Batchmaster.BatchID) AS CountOfBatchID " _
        '    & " FROM Batchmaster INNER JOIN FGMaster ON Batchmaster.FGID = FGMaster.FGID " _
        '    & " WHERE (((FGMaster.FGName)='" & cbofgname.Text & "'))"


        strSql = "SELECT Count(SemiFGBatchmaster.BatchID) AS CountOfBatchID " _
              & " FROM SemiFGBatchmaster INNER JOIN SemiFGMaster ON SemiFGBatchmaster.SFID = SemiFGMaster.SFID " _
              & " WHERE (((SemiFGMaster.FGName)='" & cbofgname.Text & "'))"
        If IsDuplicate(strSql) = False Then
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "select sfid from semifgmaster where fgname = '" & cbofgname.Text & "'"
            strfgid = cmd.ExecuteScalar
            cmd.Dispose()
        Else
            DevExpress.XtraEditors.XtraMessageBox.Show("Duplicate Entery for " & cbofgname.Text, "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Cancel = True
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim dr As DataRow
        Try
            gvbatch.RefreshData()
            Dim blnDup As Boolean = False
            For i As Int16 = 0 To gvbatch.RowCount - 1
                If gvbatch.GetRowCellValue(i, gvbatch.Columns(1)).ToString = lkupItemName.Text Then
                    blnDup = True
                    Exit For
                End If
            Next
            If blnDup = False Then
                If lkupItemName.Text <> "" And cboUOM.Text <> "" And txtqty.Text <> "" Then
                    dr = dt.NewRow
                    dr.Item(0) = ""
                    dr.Item(1) = lkupItemName.Text
                    cmd = New OleDb.OleDbCommand
                    cmd.Connection = conn
                    cmd.CommandText = "Select UnitID from UnitMaster where UnitName ='" & cboUOM.Text & "'"
                    dr.Item(2) = cmd.ExecuteScalar
                    cmd.Dispose()
                    dr.Item(3) = cboUOM.Text
                    dr.Item(4) = txtqty.Text
                    dr.Item(5) = strItemID
                    dt.Rows.Add(dr)
                    gdbatchdetail.DataSource = dt
                    gvbatch.Columns(0).VisibleIndex = -1
                    gvbatch.Columns(2).VisibleIndex = -1
                    gvbatch.Columns(5).VisibleIndex = -1
                    gvbatch.RefreshData()

                End If
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show("This item is all ready added", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            lkupItemName.EditValue = ""
            cboUOM.Text = ""
            txtqty.Text = ""
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Private Function ISVALIDATE() As Boolean
        Try
            If cbofgname.Text = "" Or txtfgqty.Text = "" Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Function
    Private Sub cmdsave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Try
            If strcheck = "Add" Then
                If ISVALIDATE() = True Then
                    Dim strSql As String
                    strSql = "SELECT Count(SemiFGBatchmaster.BatchID) AS CountOfBatchID " _
                        & " FROM SemiFGBatchmaster INNER JOIN SemiFGMaster ON SemiFGBatchmaster.SFID = SemiFGMaster.SFID " _
                        & " WHERE (((SemiFGMaster.FGName)='" & cbofgname.Text & "'))"
                    If IsDuplicate(strSql) = True Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("Duplicate Entery for " & cbofgname.Text, "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    cmd.Dispose()

                    cmd = New OleDb.OleDbCommand
                    cmd.Transaction = conn.BeginTransaction
                    cmd.CommandText = "insert into SemiFGBatchmaster(batchid,sfid,qty)" & _
                    "values('" & batchmasterid & "','" & strfgid & _
                    "'," & Replace(txtfgqty.Text.Trim, "", "''") & ")"

                    cmd.Connection = conn
                    cmd.ExecuteNonQuery()

                    'code to save record in detail table
                    Dim i As Int16
                    For i = 0 To gvbatch.RowCount - 1
                        cmd.CommandText = "insert into semifgbatchdetail(batchid,SFID,Rid,unitid,qty)" & _
                        "values('" & batchmasterid & "','" & strfgid.Trim & "','" & gvbatch.GetRowCellValue(i, "RID") & "','" & gvbatch.GetRowCellValue(i, "UnitID") & "'," & gvbatch.GetRowCellValue(i, "Qty") & ")"
                        cmd.Connection = conn
                        cmd.ExecuteNonQuery()
                    Next
                    cmd.Transaction.Commit()
                End If
            ElseIf strcheck = "Edit" Then

                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn

                cmd.Transaction = conn.BeginTransaction
                cmd.CommandText = "Update SemiBatchmaster set qty = " & txtfgqty.Text & " where batchID ='" & txtbatchid.Text & "'"
                cmd.ExecuteNonQuery()


                cmd.CommandText = "Delete from semibatchdetail where BatchID = '" & txtbatchid.Text & "'"
                cmd.ExecuteNonQuery()
                Dim i As Int16
                For i = 0 To gvbatch.RowCount - 1
                    cmd.CommandText = "insert into semibatchdetail(batchid,SFID,Rid,unitid,qty)" & _
                    "values('" & batchmasterid & "','" & strfgid.Trim & "','" & gvbatch.GetRowCellValue(i, "RID") & "','" & gvbatch.GetRowCellValue(i, "UnitID") & "'," & gvbatch.GetRowCellValue(i, "Qty") & ")"
                    cmd.Connection = conn
                    cmd.ExecuteNonQuery()
                Next
                cmd.Transaction.Commit()
            End If
            cmd.Dispose()
            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Save Data Successfully", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            cmd.Transaction.Rollback()
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub


    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click

        Try
            If gvbatch.GetSelectedRows.Length > 0 Then
                If DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to delete this record ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    gvbatch.DeleteRow(gvbatch.FocusedRowHandle)
                    gvbatch.RefreshData()
                End If
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try


    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub

    Private Sub txtfgqty_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtfgqty.Validating
        If txtfgqty.Text = "" Then
            e.Cancel = True
        End If
    End Sub

    Private Sub txtqty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqty.KeyPress
        Try
            e.Handled = IsDecimalNumber(e.KeyChar)
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub


    Private Sub lkupItemName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupItemName.EditValueChanged
        Try
            If lkupItemName.EditValue <> "" Then
                '    If lkupItemName.EditValue <> "Null" Or Not lkupItemName.EditValue = Nothing Then
                Dim row As DataRowView = lkupItemName.Properties.GetDataSourceRowByKeyValue(lkupItemName.EditValue)
                strItemID = row(1).ToString
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub cboUOM_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboUOM.GotFocus
        Try
            Dim drTemp As OleDb.OleDbDataReader
            Dim blnUnitConv As Boolean = False
            If strItemID <> "" Then
                cboUOM.Properties.Items.Clear()
                cmd = New OleDb.OleDbCommand
                cmd.CommandText = "SELECT UnitMaster.UnitName, UnitConMaster.RMID " _
                    & " FROM UnitConMaster INNER JOIN UnitMaster ON UnitConMaster.SecUnitID = UnitMaster.UnitID " _
                    & " WHERE (((UnitConMaster.RMID)='" & strItemID & "'))"
                cmd.Connection = conn
                drTemp = cmd.ExecuteReader
                Do While drTemp.Read()
                    cboUOM.Properties.Items.Add(drTemp.Item("UnitName"))
                Loop
                drTemp.Close()
                cmd.CommandText = "SELECT UnitMaster.UnitName, RMItemMaster.Rid" _
                    & " FROM RMItemMaster INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID " _
                    & " WHERE (((RMItemMaster.Rid)='" & strItemID & "'))"
                drTemp = cmd.ExecuteReader
                Do While drTemp.Read
                    cboUOM.Properties.Items.Add(drTemp.Item("UnitName"))
                    cboUOM.Text = drTemp.Item("UnitName").ToString
                Loop
                drTemp.Close()
                cmd.Dispose()
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Try
            Dim objpara As New frmPara
            objpara.ShowBOM(strfgid)
            objpara.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdADDFG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdADDFG.Click
        Try
            Dim myFrm As New frmSemifgmaster
            myFrm.ShowDialog()
            myFrm.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdBatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBatch.Click
        Try
            Dim myFrm As New frmBatchGenerator
            myFrm.ShowDialog()
            myFrm.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
End Class
