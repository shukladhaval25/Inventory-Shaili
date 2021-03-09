Public Class frmSemiBatchGenerator
    Inherits DevExpress.XtraEditors.XtraForm

    Dim strFGID As String
    Dim strUID As String
    Dim strItemID As String
    Dim dt As New DataTable
    Public strcheck As String
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdBatch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdADDFG As DevExpress.XtraEditors.SimpleButton
    Dim strRadioType As String
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
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lkupFG As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblReqID As System.Windows.Forms.Label
    Friend WithEvents txtReqID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rdoType As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents lblFG As System.Windows.Forms.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents gvbatch As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grpBatch As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gdbatch As DevExpress.XtraGrid.GridControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtfQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblUOM As System.Windows.Forms.Label
    Friend WithEvents grpItem As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cboUOM As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lkupItemName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtqty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnReport As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.grpBatch = New DevExpress.XtraEditors.GroupControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdBatch = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdADDFG = New DevExpress.XtraEditors.SimpleButton()
        Me.btnReport = New DevExpress.XtraEditors.SimpleButton()
        Me.txtReqID = New DevExpress.XtraEditors.TextEdit()
        Me.dtpDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblUOM = New System.Windows.Forms.Label()
        Me.txtfQty = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.grpItem = New DevExpress.XtraEditors.GroupControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboUOM = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblqty = New System.Windows.Forms.Label()
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.txtqty = New DevExpress.XtraEditors.TextEdit()
        Me.lkupItemName = New DevExpress.XtraEditors.LookUpEdit()
        Me.gdbatch = New DevExpress.XtraGrid.GridControl()
        Me.gvbatch = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblFG = New System.Windows.Forms.Label()
        Me.rdoType = New DevExpress.XtraEditors.RadioGroup()
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton()
        Me.lblReqID = New System.Windows.Forms.Label()
        Me.lkupFG = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.grpBatch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBatch.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtReqID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtfQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grpItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpItem.SuspendLayout()
        CType(Me.cboUOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtqty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupItemName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdbatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvbatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdoType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupFG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBatch
        '
        Me.grpBatch.Controls.Add(Me.GroupBox1)
        Me.grpBatch.Controls.Add(Me.btnReport)
        Me.grpBatch.Controls.Add(Me.txtReqID)
        Me.grpBatch.Controls.Add(Me.dtpDate)
        Me.grpBatch.Controls.Add(Me.Label4)
        Me.grpBatch.Controls.Add(Me.lblUOM)
        Me.grpBatch.Controls.Add(Me.txtfQty)
        Me.grpBatch.Controls.Add(Me.Label2)
        Me.grpBatch.Controls.Add(Me.PanelControl1)
        Me.grpBatch.Controls.Add(Me.lblFG)
        Me.grpBatch.Controls.Add(Me.rdoType)
        Me.grpBatch.Controls.Add(Me.cmdSave)
        Me.grpBatch.Controls.Add(Me.cmdClose)
        Me.grpBatch.Controls.Add(Me.lblReqID)
        Me.grpBatch.Controls.Add(Me.lkupFG)
        Me.grpBatch.Location = New System.Drawing.Point(8, 8)
        Me.grpBatch.Name = "grpBatch"
        Me.grpBatch.Size = New System.Drawing.Size(659, 400)
        Me.grpBatch.TabIndex = 1
        Me.grpBatch.Text = "Requisition Raise (Semi Finish Goods)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdBatch)
        Me.GroupBox1.Controls.Add(Me.cmdADDFG)
        Me.GroupBox1.Location = New System.Drawing.Point(126, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 41)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        '
        'cmdBatch
        '
        Me.cmdBatch.Location = New System.Drawing.Point(145, 10)
        Me.cmdBatch.Name = "cmdBatch"
        Me.cmdBatch.Size = New System.Drawing.Size(95, 25)
        Me.cmdBatch.TabIndex = 27
        Me.cmdBatch.Text = "&New Batch"
        '
        'cmdADDFG
        '
        Me.cmdADDFG.Location = New System.Drawing.Point(6, 10)
        Me.cmdADDFG.Name = "cmdADDFG"
        Me.cmdADDFG.Size = New System.Drawing.Size(133, 25)
        Me.cmdADDFG.TabIndex = 26
        Me.cmdADDFG.Text = "&New Semi Finish Good"
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(13, 367)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(75, 25)
        Me.btnReport.TabIndex = 43
        Me.btnReport.Text = "&Report"
        '
        'txtReqID
        '
        Me.txtReqID.EditValue = ""
        Me.txtReqID.Location = New System.Drawing.Point(126, 32)
        Me.txtReqID.Name = "txtReqID"
        Me.txtReqID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReqID.Properties.Appearance.Options.UseFont = True
        Me.txtReqID.Properties.MaxLength = 25
        Me.txtReqID.Size = New System.Drawing.Size(96, 22)
        Me.txtReqID.TabIndex = 1
        Me.txtReqID.TabStop = False
        '
        'dtpDate
        '
        Me.dtpDate.EditValue = New Date(CType(0, Long))
        Me.dtpDate.Location = New System.Drawing.Point(422, 32)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDate.Size = New System.Drawing.Size(88, 20)
        Me.dtpDate.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(382, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 16)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Date"
        '
        'lblUOM
        '
        Me.lblUOM.AutoSize = True
        Me.lblUOM.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUOM.Location = New System.Drawing.Point(479, 65)
        Me.lblUOM.Name = "lblUOM"
        Me.lblUOM.Size = New System.Drawing.Size(0, 16)
        Me.lblUOM.TabIndex = 41
        '
        'txtfQty
        '
        Me.txtfQty.EditValue = ""
        Me.txtfQty.Location = New System.Drawing.Point(422, 64)
        Me.txtfQty.Name = "txtfQty"
        Me.txtfQty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfQty.Properties.Appearance.Options.UseFont = True
        Me.txtfQty.Properties.MaxLength = 4
        Me.txtfQty.Size = New System.Drawing.Size(48, 22)
        Me.txtfQty.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(384, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Qty:"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.grpItem)
        Me.PanelControl1.Controls.Add(Me.gdbatch)
        Me.PanelControl1.Location = New System.Drawing.Point(13, 137)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(628, 224)
        Me.PanelControl1.TabIndex = 2
        Me.PanelControl1.Text = "-**"
        '
        'grpItem
        '
        Me.grpItem.Controls.Add(Me.Label1)
        Me.grpItem.Controls.Add(Me.cboUOM)
        Me.grpItem.Controls.Add(Me.cmdDelete)
        Me.grpItem.Controls.Add(Me.Label3)
        Me.grpItem.Controls.Add(Me.lblqty)
        Me.grpItem.Controls.Add(Me.cmdAdd)
        Me.grpItem.Controls.Add(Me.txtqty)
        Me.grpItem.Controls.Add(Me.lkupItemName)
        Me.grpItem.Location = New System.Drawing.Point(8, 8)
        Me.grpItem.Name = "grpItem"
        Me.grpItem.Size = New System.Drawing.Size(615, 56)
        Me.grpItem.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(328, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Unit:"
        '
        'cboUOM
        '
        Me.cboUOM.EditValue = ""
        Me.cboUOM.Location = New System.Drawing.Point(368, 24)
        Me.cboUOM.Name = "cboUOM"
        Me.cboUOM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboUOM.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboUOM.Size = New System.Drawing.Size(80, 20)
        Me.cboUOM.TabIndex = 6
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(562, 23)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(48, 25)
        Me.cmdDelete.TabIndex = 8
        Me.cmdDelete.Text = "&Delete"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Item:"
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.Location = New System.Drawing.Point(232, 24)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(32, 16)
        Me.lblqty.TabIndex = 24
        Me.lblqty.Text = "Qty:"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(506, 23)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(48, 25)
        Me.cmdAdd.TabIndex = 7
        Me.cmdAdd.Text = "&Add"
        '
        'txtqty
        '
        Me.txtqty.EditValue = ""
        Me.txtqty.Location = New System.Drawing.Point(264, 24)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Properties.Appearance.Options.UseFont = True
        Me.txtqty.Properties.MaxLength = 4
        Me.txtqty.Size = New System.Drawing.Size(48, 22)
        Me.txtqty.TabIndex = 5
        '
        'lkupItemName
        '
        Me.lkupItemName.EditValue = ""
        Me.lkupItemName.Location = New System.Drawing.Point(48, 24)
        Me.lkupItemName.Name = "lkupItemName"
        Me.lkupItemName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupItemName.Properties.NullText = ""
        Me.lkupItemName.Size = New System.Drawing.Size(176, 20)
        Me.lkupItemName.TabIndex = 4
        '
        'gdbatch
        '
        '
        '
        '
        Me.gdbatch.EmbeddedNavigator.Name = ""
        Me.gdbatch.Location = New System.Drawing.Point(8, 70)
        Me.gdbatch.MainView = Me.gvbatch
        Me.gdbatch.Name = "gdbatch"
        Me.gdbatch.Size = New System.Drawing.Size(615, 146)
        Me.gdbatch.TabIndex = 9
        Me.gdbatch.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvbatch})
        '
        'gvbatch
        '
        Me.gvbatch.GridControl = Me.gdbatch
        Me.gvbatch.Name = "gvbatch"
        Me.gvbatch.OptionsBehavior.Editable = False
        Me.gvbatch.OptionsCustomization.AllowColumnMoving = False
        Me.gvbatch.OptionsCustomization.AllowGroup = False
        Me.gvbatch.OptionsMenu.EnableFooterMenu = False
        Me.gvbatch.OptionsMenu.EnableGroupPanelMenu = False
        Me.gvbatch.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvbatch.OptionsView.ShowGroupPanel = False
        '
        'lblFG
        '
        Me.lblFG.AutoSize = True
        Me.lblFG.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFG.Location = New System.Drawing.Point(8, 64)
        Me.lblFG.Name = "lblFG"
        Me.lblFG.Size = New System.Drawing.Size(112, 16)
        Me.lblFG.TabIndex = 38
        Me.lblFG.Text = "Semi Finish Good:"
        '
        'rdoType
        '
        Me.rdoType.EditValue = "I"
        Me.rdoType.Location = New System.Drawing.Point(228, 26)
        Me.rdoType.Name = "rdoType"
        Me.rdoType.Properties.Appearance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.rdoType.Properties.Appearance.Options.UseForeColor = True
        Me.rdoType.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("I", "Repairing"), New DevExpress.XtraEditors.Controls.RadioGroupItem("B", "New")})
        Me.rdoType.Size = New System.Drawing.Size(144, 28)
        Me.rdoType.TabIndex = 2
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(486, 367)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 25)
        Me.cmdSave.TabIndex = 10
        Me.cmdSave.Text = "&Save"
        '
        'cmdClose
        '
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(566, 367)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 25)
        Me.cmdClose.TabIndex = 11
        Me.cmdClose.Text = "&Cancel"
        '
        'lblReqID
        '
        Me.lblReqID.AutoSize = True
        Me.lblReqID.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReqID.Location = New System.Drawing.Point(8, 32)
        Me.lblReqID.Name = "lblReqID"
        Me.lblReqID.Size = New System.Drawing.Size(91, 16)
        Me.lblReqID.TabIndex = 35
        Me.lblReqID.Text = "Requisition ID:"
        '
        'lkupFG
        '
        Me.lkupFG.EditValue = ""
        Me.lkupFG.Location = New System.Drawing.Point(126, 64)
        Me.lkupFG.Name = "lkupFG"
        Me.lkupFG.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupFG.Properties.NullText = ""
        Me.lkupFG.Size = New System.Drawing.Size(246, 20)
        Me.lkupFG.TabIndex = 4
        '
        'frmSemiBatchGenerator
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(679, 414)
        Me.Controls.Add(Me.grpBatch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSemiBatchGenerator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Requisition Raise (Semi Finish Goods)"
        CType(Me.grpBatch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBatch.ResumeLayout(False)
        Me.grpBatch.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtReqID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtfQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.grpItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpItem.ResumeLayout(False)
        Me.grpItem.PerformLayout()
        CType(Me.cboUOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtqty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupItemName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdbatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvbatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdoType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupFG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmBatchGenerator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dt.Columns.Add("ItemID", System.Type.GetType("System.String"))
            dt.Columns.Add("Item Name", System.Type.GetType("System.String"))
            dt.Columns.Add("UnitID", System.Type.GetType("System.String"))
            dt.Columns.Add("Unit", System.Type.GetType("System.String"))
            dt.Columns.Add("Qty", System.Type.GetType("System.String"))
            dt.Columns.Add("RQID", System.Type.GetType("System.String"))

            FillLookup("SELECT RMItemMaster.RMItemName, RMItemMaster.Rid, UnitMaster.UnitName, RMItemMaster.UnitId " _
                   & " FROM RMItemMaster INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID", "RMItemMaster", "RID", "RMItemName", lkupItemName)
            grpItem.Enabled = True
            txtfQty.Enabled = False
            'dt.Clear()
            If strcheck = "Add" Then
                'If strcheck = "Add" Then
                '    txtReqID.Text = Val(GetMaxNo("ReqID", "REQMASTER", "B", 5))
                'End If

                If rdoType.SelectedIndex = 0 Then
                    txtfQty.Text = 1
                End If
                dtpDate.EditValue = Now
                btnReport.Visible = False
            End If


            FillLookup("SELECT SemiFGMaster.FGName, SemiFGMaster.SFID, UnitMaster.UnitID, UnitMaster.UnitName " _
                & " FROM SemiFGMaster INNER JOIN UnitMaster ON SemiFGMaster.UnitID = UnitMaster.UnitID", "SemiFGMaster", "Semi Finish Good", "SFID", lkupFG)

            If strcheck = "Edit" Then
                txtReqID.Properties.ReadOnly = True
                rdoType.Enabled = False
                lkupFG.Properties.ReadOnly = True
                txtfQty.Properties.ReadOnly = True
                cmd = New OleDb.OleDbCommand
                cmd.CommandText = "SELECT SEMI_FG_REQMASTER.RQID , SEMI_FG_REQMASTER.REQID, SemiFGMaster.FGName, UnitMaster.UnitName, SEMI_FG_REQMASTER.QTY,SEMI_FG_REQMASTER.TYPE,SEMI_FG_REQMASTER.SFID,SEMI_FG_REQMASTER.REQDATE " _
                    & " FROM (SEMI_FG_REQMASTER INNER JOIN SemiFGMaster ON SEMI_FG_REQMASTER.SFID = SemiFGMaster.SFID) INNER JOIN UnitMaster ON SemiFGMaster.UnitID = UnitMaster.UnitID " _
                    & " WHERE (((SEMI_FG_REQMASTER.RQID)='" & ModMain.strgridid.Trim & "'))"
                cmd.Connection = conn
                dr = cmd.ExecuteReader()
                dr.Read()
                bind_data()
                dr.Close()


                gvbatch.Columns.Clear()
                'Dim adp As New OleDb.OleDbDataAdapter("SELECT  SEMI_FG_REQDETAIL.RID AS ITEMID, RMItemMaster.RMItemName AS [ITEM NAME], SEMI_FG_REQDETAIL.UID AS UNITID, " _
                '    & " UnitMaster.UnitName AS UNIT, SEMI_FG_REQDETAIL.QTY ,SEMI_FG_REQDETAIL.RQID AS RQID" _
                '    & " FROM (RMItemMaster INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID) " _
                '    & " INNER JOIN REQDETAIL ON SEMI_FG_REQMASTER.Rid = SEMI_FG_REQDETAIL.RID where SEMI_FG_REQDETAIL.RQID ='" & ModMain.strgridid.Trim & "'", conn) 'AND REQDETAIL.CY ='" & strCY.Trim & "'

                Dim adp As New OleDb.OleDbDataAdapter("SELECT SEMI_FG_REQDETAIL.RID AS ITEMID, RMItemMaster.RMItemName AS [ITEM NAME], SEMI_FG_REQDETAIL.UID AS UNITID, " _
                    & " UnitMaster.UnitName AS UNIT, SEMI_FG_REQDETAIL.QTY, SEMI_FG_REQDETAIL.RQID AS RQID" _
                    & " FROM (RMItemMaster INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID) " _
                    & " INNER JOIN (SEMI_FG_REQMASTER INNER JOIN SEMI_FG_REQDETAIL ON SEMI_FG_REQMASTER.RQID = SEMI_FG_REQDETAIL.RQID) ON RMItemMaster.Rid = SEMI_FG_REQDETAIL.RID" _
                    & " WHERE (((SEMI_FG_REQDETAIL.RQID)='" & ModMain.strgridid.Trim & "'))", conn)

                adp.Fill(dt)

                gdbatch.DataSource = dt
                gvbatch.Columns(0).Visible = False
                gvbatch.Columns(2).Visible = False
                gvbatch.Columns(5).Visible = False
                cmd.Dispose()
            End If

        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Public Sub bind_data()
        Try
            If IsDBNull(dr("ReqID").ToString) = True Then
                txtReqID.Text = ""
            Else
                txtReqID.Text = dr("ReqID").ToString
                txtReqID.Tag = ModMain.strgridid
            End If

            If IsDBNull(dr("TYPE").ToString) = False Then
                If dr("Type").ToString = "I" Then
                    rdoType.SelectedIndex = 0
                ElseIf dr("Type").ToString = "B" Then
                    rdoType.SelectedIndex = 1
                End If
            End If
            If IsDBNull(dr("REQDATE").ToString) = False Then
                dtpDate.EditValue = Format(dr("REQDATE"), "dd/MM/yyyy")
            Else
                dtpDate.EditValue = ""
            End If

            If IsDBNull(dr("SFID").ToString) = True Then
                lkupFG.EditValue = ""
            Else
                lkupFG.EditValue = dr("SFID").ToString
            End If

            'qty()
            If IsDBNull(dr("QTY").ToString) = True Then
                txtfQty.Text = ""
            Else
                txtfQty.Text = dr("QTY").ToString
            End If


        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub lkupFG_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupFG.EditValueChanged
        Try
            If lkupFG.EditValue = Nothing Then Exit Sub
            If lkupFG.EditValue <> "" Then

                Dim row As DataRowView = lkupFG.Properties.GetDataSourceRowByKeyValue(lkupFG.EditValue)
                If rdoType.SelectedIndex = 0 Then
                    'Dim row As DataRowView = lkupFG.Properties.GetDataSourceRowByKeyValue(lkupFG.EditValue)
                    strFGID = row(1).ToString
                    strUID = row(2).ToString
                    lblUOM.Text = row(3).ToString
                ElseIf rdoType.SelectedIndex = 1 Then
                    strFGID = row(1).ToString

                    FillGrid()   ' For Filling Grid
                End If
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub rdoType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoType.SelectedIndexChanged
        Try
            If rdoType.SelectedIndex = 0 Then
                FillLookup("SELECT RMItemMaster.RMItemName, RMItemMaster.Rid, UnitMaster.UnitName, RMItemMaster.UnitId " _
                    & " FROM RMItemMaster INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID", "RMItemMaster", "RID", "RMItemName", lkupItemName)
                grpItem.Enabled = True
                txtfQty.Enabled = False
                txtfQty.Text = ""
                dt.Clear()
            Else
                grpItem.Enabled = False
                txtfQty.Enabled = True
                FillGrid()   ' For Filling Grid
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub lkupItemName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupItemName.EditValueChanged
        Try
            If lkupItemName.EditValue = Nothing Then Exit Sub
            If lkupItemName.EditValue <> "" Then
                Dim row As DataRowView = lkupItemName.Properties.GetDataSourceRowByKeyValue(lkupItemName.EditValue)
                strItemID = row(1).ToString
                cboUOM.Text = row(2).ToString
                '                txtDefUnit.Tag = row(3).ToString
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

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            gvbatch.RefreshData()
            Dim dr As DataRow
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

                    cmd = New OleDb.OleDbCommand
                    cmd.Connection = conn
                    cmd.CommandText = "Select UnitID from UnitMaster where UnitName ='" & cboUOM.Text & "'"
                    dr.Item(2) = cmd.ExecuteScalar
                    cmd.Dispose()
                    dr.Item(0) = strItemID
                    dr.Item(1) = lkupItemName.Text
                    dr.Item(3) = cboUOM.Text
                    dr.Item(4) = txtqty.Text
                    dr.Item(5) = txtReqID.Tag
                    dt.Rows.Add(dr)
                    gdbatch.DataSource = dt
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
        Catch EX As Exception
            If show_error Then
                MsgBox(EX.ToString)
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

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If strcheck = "Add" Then
                If ISVALIDATE() = True Then
                    Dim strSql As String
                    strSql = "select count(reqid) from SEMI_FG_REQMASTER where reqid ='" & txtReqID.Text & "' and CY ='" & strCY.Trim & "'"
                    If IsDuplicate(strSql) = True Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("Duplicate Entery for " & txtReqID.Text, "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    'cmd.Dispose()

                    txtReqID.Tag = GetMaxNo("RqID", "SEMI_FG_REQMASTER", "RQ", 10)
                    If txtfQty.Text = "" Then
                        txtfQty.Text = 1
                    End If
                    cmd = New OleDb.OleDbCommand
                    cmd.Transaction = conn.BeginTransaction
                    cmd.CommandText = "insert into SEMI_FG_REQMASTER (rqid,rEQid,reqdate,sfid,type,qty,cy)" & _
                    "values('" & txtReqID.Tag & "','" & txtReqID.Text & "','" & dtpDate.Text & "','" _
                        & strFGID.Trim & "','" & rdoType.EditValue & "'," & txtfQty.Text.Trim & ",'" & strCY.Trim & "')"

                    cmd.Connection = conn
                    cmd.ExecuteNonQuery()

                    'code to save record in detail table
                    Dim i As Int16
                    For i = 0 To gvbatch.RowCount - 1
                        cmd.CommandText = "insert into SEMI_FG_REQDETAIL(RQID,Rid,uid,qty,cy)" & _
                        "values('" & txtReqID.Tag & "','" & gvbatch.GetRowCellValue(i, "ItemID") & "','" & gvbatch.GetRowCellValue(i, "UnitID") & "'," & gvbatch.GetRowCellValue(i, "Qty") & ",'" & strCY.Trim & "')"
                        cmd.Connection = conn
                        cmd.ExecuteNonQuery()
                    Next
                    cmd.Transaction.Commit()
                    cmd.Dispose()
                Else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Enter all required data", "Enter Date", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
            If strcheck = "Edit" Then

                'cmd.Transaction = conn.BeginTransaction
                'cmd.CommandText = "Update batchmaster set qty =" & txtfgqty.Text & " where batchID ='" & txtbatchid.Text & "'"
                'cmd.Transaction = conn.BeginTransaction
                'cmd.ExecuteNonQuery()

                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                cmd.CommandText = "Delete from SEMI_FG_REQDETAIL where RQID ='" & txtReqID.Tag & "'" ' and CY ='" & strCY.Trim & "'"
                cmd.Transaction = conn.BeginTransaction
                cmd.ExecuteNonQuery()

                Dim i As Int16
                For i = 0 To gvbatch.RowCount - 1
                    cmd.CommandText = "insert into SEMI_FG_REQDETAIL(RQID,Rid,uid,qty,CY)" & _
                                       "values('" & txtReqID.Tag & "','" & gvbatch.GetRowCellValue(i, "ItemID") & "','" & gvbatch.GetRowCellValue(i, "UnitID") & "'," & gvbatch.GetRowCellValue(i, "Qty") & ",'" & strCY.Trim & "')"
                    cmd.Connection = conn
                    cmd.ExecuteNonQuery()
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
    Private Function ISVALIDATE() As Boolean
        Try
            'DHAVAL

            If rdoType.SelectedIndex = 1 Then
                If txtReqID.Text.Trim = "" Or lkupFG.EditValue = "" Or txtfQty.Text.Trim = "" Then
                    Return False
                Else
                    Return True
                End If
            ElseIf rdoType.SelectedIndex = 0 Then
                If txtReqID.Text.Trim = "" Or lkupFG.EditValue = "" Then
                    Return False
                Else
                    Return True
                End If
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Function
    Private Sub FillGrid()
        Try
            If lkupFG.EditValue = "" OrElse txtfQty.Text = "" OrElse rdoType.SelectedIndex = 0 Then Exit Sub
            dt.Clear()
            'Dim adp As New OleDb.OleDbDataAdapter("SELECT Batchdetail.RID AS ITEMID," & _
            '                  " RMItemMaster.RMItemName AS [ITEM NAME]," & _
            '                   " Batchdetail.UnitID AS UNITID, UnitMaster.UnitName as UNIT,(Batchdetail.Qty * " & Val(txtfQty.Text) & ")/ AS Qty" & _
            '                   " FROM (Batchdetail INNER JOIN UnitMaster ON Batchdetail.UnitID = UnitMaster.UnitID)" & _
            '                   " INNER JOIN RMItemMaster ON (UnitMaster.UnitID = RMItemMaster.UnitId)" & _
            '                   " AND (Batchdetail.RID = RMItemMaster.Rid) where Batchdetail.FID ='" & _
            '                   lkupFG.Properties.GetKeyValueByDisplayText(lkupFG.Text) & "'", conn)

            Dim adp As New OleDb.OleDbDataAdapter("SELECT SemiFGBatchdetail.RID AS ITEMID, RMItemMaster.RMItemName AS [ITEM NAME]," _
                      & " SemiFGBatchdetail.UnitID AS UNITID, UnitMaster.UnitName AS UNIT, ([SemiFGBatchdetail]![Qty] * " & Val(txtfQty.Text) & ")/[SemiFGBatchMaster]![Qty] AS Qty " _
                      & " FROM ((SemiFGBatchMaster INNER JOIN SemiFGBatchdetail ON SemiFGBatchMaster.BatchID " _
                      & " = SemiFGBatchdetail.BatchID) INNER JOIN RMItemMaster ON SemiFGBatchdetail.RID = RMItemMaster.Rid) " _
                      & " INNER JOIN UnitMaster ON SemiFGBatchdetail.UnitID = UnitMaster.UnitID " _
                      & " WHERE (((SemiFGBatchMaster.SFID)='" & lkupFG.Properties.GetKeyValueByDisplayText(lkupFG.Text) & "')) ", conn)

            adp.Fill(dt)
            gdbatch.DataSource = dt
            gvbatch.Columns(0).Visible = False
            gvbatch.Columns(2).Visible = False
            gvbatch.Columns(5).Visible = False
            adp.Dispose()
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub txtfQty_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtfQty.Validating
        Try
            FillGrid()
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Try
            Dim myPara As New frmPara
            myPara.ShowMat_Req_SEMI_Finish_Good(txtReqID.Text & "'")
            myPara.Close()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
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
            Dim myFrm As New frmSemiBatchGenerator
            myFrm.ShowDialog()
            myFrm.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
End Class

