Public Class frmPackingVI
    Inherits DevExpress.XtraEditors.XtraForm
    Dim dt As New DataTable
    Public strcheck As String
    Friend WithEvents cmdADDFG As DevExpress.XtraEditors.SimpleButton
    Dim blnSterilize As Boolean
    Dim arrFID As New ArrayList
    Dim arrBatchNo As New ArrayList
    Friend WithEvents dtPackingVI As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPackVINo As System.Windows.Forms.Label
    Friend WithEvents txtPackingVINo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtExpDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtMfgDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblMFgDate As System.Windows.Forms.Label
    Dim arrQC_No As New ArrayList
    Friend WithEvents txtRejectionCompID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblrejectionCompID As System.Windows.Forms.Label
    Dim expirationPeriod As Integer

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
    Friend WithEvents gvqc As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grpqc As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdclose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlQCDetail As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblDrCheckno As System.Windows.Forms.Label
    Friend WithEvents lkupFGName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtinspecno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblrejecqty As System.Windows.Forms.Label
    Friend WithEvents lblinspecno As System.Windows.Forms.Label
    Friend WithEvents txtqcno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblqcno As System.Windows.Forms.Label
    Friend WithEvents gdqc As DevExpress.XtraGrid.GridControl
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblRaw As System.Windows.Forms.Label
    Friend WithEvents txtrejqty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDimen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbMIS As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSrNo As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.gvqc = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gdqc = New DevExpress.XtraGrid.GridControl()
        Me.grpqc = New DevExpress.XtraEditors.GroupControl()
        Me.dtPackingVI = New DevExpress.XtraEditors.DateEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPackVINo = New System.Windows.Forms.Label()
        Me.txtPackingVINo = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSrNo = New DevExpress.XtraEditors.TextEdit()
        Me.cmdsave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdclose = New DevExpress.XtraEditors.SimpleButton()
        Me.pnlQCDetail = New DevExpress.XtraEditors.PanelControl()
        Me.txtRejectionCompID = New DevExpress.XtraEditors.TextEdit()
        Me.lblrejectionCompID = New System.Windows.Forms.Label()
        Me.dtExpDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtMfgDate = New DevExpress.XtraEditors.DateEdit()
        Me.lblMFgDate = New System.Windows.Forms.Label()
        Me.cmdADDFG = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbMIS = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDimen = New DevExpress.XtraEditors.TextEdit()
        Me.lblDrCheckno = New System.Windows.Forms.Label()
        Me.lkupFGName = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtinspecno = New DevExpress.XtraEditors.TextEdit()
        Me.lblrejecqty = New System.Windows.Forms.Label()
        Me.lblinspecno = New System.Windows.Forms.Label()
        Me.txtqcno = New DevExpress.XtraEditors.TextEdit()
        Me.lblqcno = New System.Windows.Forms.Label()
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.lblRaw = New System.Windows.Forms.Label()
        Me.txtrejqty = New DevExpress.XtraEditors.TextEdit()
        CType(Me.gvqc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdqc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpqc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpqc.SuspendLayout()
        CType(Me.dtPackingVI.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtPackingVI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPackingVINo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSrNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlQCDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlQCDetail.SuspendLayout()
        CType(Me.txtRejectionCompID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtExpDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtExpDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMfgDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMfgDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMIS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDimen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupFGName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtinspecno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtqcno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrejqty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvqc
        '
        Me.gvqc.GridControl = Me.gdqc
        Me.gvqc.Name = "gvqc"
        Me.gvqc.OptionsBehavior.Editable = False
        Me.gvqc.OptionsCustomization.AllowFilter = False
        Me.gvqc.OptionsView.ShowGroupPanel = False
        '
        'gdqc
        '
        Me.gdqc.Font = New System.Drawing.Font("Tahoma", 8.25!)
        GridLevelNode1.RelationName = "Level1"
        Me.gdqc.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gdqc.Location = New System.Drawing.Point(8, 143)
        Me.gdqc.MainView = Me.gvqc
        Me.gdqc.Name = "gdqc"
        Me.gdqc.Size = New System.Drawing.Size(1087, 224)
        Me.gdqc.TabIndex = 15
        Me.gdqc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvqc})
        '
        'grpqc
        '
        Me.grpqc.Controls.Add(Me.dtPackingVI)
        Me.grpqc.Controls.Add(Me.Label6)
        Me.grpqc.Controls.Add(Me.lblPackVINo)
        Me.grpqc.Controls.Add(Me.txtPackingVINo)
        Me.grpqc.Controls.Add(Me.Label4)
        Me.grpqc.Controls.Add(Me.txtSrNo)
        Me.grpqc.Controls.Add(Me.cmdsave)
        Me.grpqc.Controls.Add(Me.cmdclose)
        Me.grpqc.Controls.Add(Me.pnlQCDetail)
        Me.grpqc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpqc.Location = New System.Drawing.Point(0, 0)
        Me.grpqc.Name = "grpqc"
        Me.grpqc.Size = New System.Drawing.Size(1115, 475)
        Me.grpqc.TabIndex = 0
        '
        'dtPackingVI
        '
        Me.dtPackingVI.EditValue = Nothing
        Me.dtPackingVI.Location = New System.Drawing.Point(821, 32)
        Me.dtPackingVI.Name = "dtPackingVI"
        Me.dtPackingVI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtPackingVI.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtPackingVI.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.dtPackingVI.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtPackingVI.Size = New System.Drawing.Size(128, 20)
        Me.dtPackingVI.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(718, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Packing VI Date"
        '
        'lblPackVINo
        '
        Me.lblPackVINo.AutoSize = True
        Me.lblPackVINo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPackVINo.Location = New System.Drawing.Point(425, 33)
        Me.lblPackVINo.Name = "lblPackVINo"
        Me.lblPackVINo.Size = New System.Drawing.Size(95, 16)
        Me.lblPackVINo.TabIndex = 36
        Me.lblPackVINo.Text = "Packing VI No.:"
        '
        'txtPackingVINo
        '
        Me.txtPackingVINo.Location = New System.Drawing.Point(576, 30)
        Me.txtPackingVINo.Name = "txtPackingVINo"
        Me.txtPackingVINo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPackingVINo.Properties.Appearance.Options.UseFont = True
        Me.txtPackingVINo.Size = New System.Drawing.Size(128, 22)
        Me.txtPackingVINo.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Serial No.:"
        '
        'txtSrNo
        '
        Me.txtSrNo.EditValue = ""
        Me.txtSrNo.Location = New System.Drawing.Point(93, 30)
        Me.txtSrNo.Name = "txtSrNo"
        Me.txtSrNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSrNo.Properties.Appearance.Options.UseFont = True
        Me.txtSrNo.Properties.ReadOnly = True
        Me.txtSrNo.Size = New System.Drawing.Size(152, 22)
        Me.txtSrNo.TabIndex = 34
        Me.txtSrNo.TabStop = False
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(974, 442)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(64, 25)
        Me.cmdsave.TabIndex = 13
        Me.cmdsave.Text = "&Save"
        '
        'cmdclose
        '
        Me.cmdclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdclose.Location = New System.Drawing.Point(1046, 442)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(64, 25)
        Me.cmdclose.TabIndex = 14
        Me.cmdclose.Text = "&Close"
        '
        'pnlQCDetail
        '
        Me.pnlQCDetail.Controls.Add(Me.txtRejectionCompID)
        Me.pnlQCDetail.Controls.Add(Me.lblrejectionCompID)
        Me.pnlQCDetail.Controls.Add(Me.dtExpDate)
        Me.pnlQCDetail.Controls.Add(Me.Label5)
        Me.pnlQCDetail.Controls.Add(Me.dtMfgDate)
        Me.pnlQCDetail.Controls.Add(Me.lblMFgDate)
        Me.pnlQCDetail.Controls.Add(Me.cmdADDFG)
        Me.pnlQCDetail.Controls.Add(Me.cmbMIS)
        Me.pnlQCDetail.Controls.Add(Me.Label1)
        Me.pnlQCDetail.Controls.Add(Me.txtDimen)
        Me.pnlQCDetail.Controls.Add(Me.lblDrCheckno)
        Me.pnlQCDetail.Controls.Add(Me.lkupFGName)
        Me.pnlQCDetail.Controls.Add(Me.txtinspecno)
        Me.pnlQCDetail.Controls.Add(Me.lblrejecqty)
        Me.pnlQCDetail.Controls.Add(Me.lblinspecno)
        Me.pnlQCDetail.Controls.Add(Me.txtqcno)
        Me.pnlQCDetail.Controls.Add(Me.lblqcno)
        Me.pnlQCDetail.Controls.Add(Me.gdqc)
        Me.pnlQCDetail.Controls.Add(Me.cmdAdd)
        Me.pnlQCDetail.Controls.Add(Me.cmdDelete)
        Me.pnlQCDetail.Controls.Add(Me.lblRaw)
        Me.pnlQCDetail.Controls.Add(Me.txtrejqty)
        Me.pnlQCDetail.Location = New System.Drawing.Point(8, 58)
        Me.pnlQCDetail.Name = "pnlQCDetail"
        Me.pnlQCDetail.Size = New System.Drawing.Size(1102, 374)
        Me.pnlQCDetail.TabIndex = 3
        '
        'txtRejectionCompID
        '
        Me.txtRejectionCompID.Location = New System.Drawing.Point(867, 47)
        Me.txtRejectionCompID.Name = "txtRejectionCompID"
        Me.txtRejectionCompID.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRejectionCompID.Properties.Appearance.Options.UseFont = True
        Me.txtRejectionCompID.Size = New System.Drawing.Size(58, 22)
        Me.txtRejectionCompID.TabIndex = 53
        '
        'lblrejectionCompID
        '
        Me.lblrejectionCompID.AutoSize = True
        Me.lblrejectionCompID.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrejectionCompID.Location = New System.Drawing.Point(710, 50)
        Me.lblrejectionCompID.Name = "lblrejectionCompID"
        Me.lblrejectionCompID.Size = New System.Drawing.Size(151, 16)
        Me.lblrejectionCompID.TabIndex = 54
        Me.lblrejectionCompID.Text = "Rejection Component ID:"
        '
        'dtExpDate
        '
        Me.dtExpDate.EditValue = ""
        Me.dtExpDate.Location = New System.Drawing.Point(979, 9)
        Me.dtExpDate.Name = "dtExpDate"
        Me.dtExpDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtExpDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtExpDate.Properties.DisplayFormat.FormatString = "MM/yyyy"
        Me.dtExpDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtExpDate.Properties.Mask.EditMask = "MM/yyyy"
        Me.dtExpDate.Properties.NullDate = ""
        Me.dtExpDate.Properties.ReadOnly = True
        Me.dtExpDate.Size = New System.Drawing.Size(116, 20)
        Me.dtExpDate.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(910, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Exp. Date"
        '
        'dtMfgDate
        '
        Me.dtMfgDate.EditValue = ""
        Me.dtMfgDate.Location = New System.Drawing.Point(778, 9)
        Me.dtMfgDate.Name = "dtMfgDate"
        Me.dtMfgDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtMfgDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.dtMfgDate.Properties.DisplayFormat.FormatString = "MM/yyyy"
        Me.dtMfgDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtMfgDate.Properties.Mask.EditMask = "MM/yyyy"
        Me.dtMfgDate.Properties.NullDate = ""
        Me.dtMfgDate.Size = New System.Drawing.Size(102, 20)
        Me.dtMfgDate.TabIndex = 50
        '
        'lblMFgDate
        '
        Me.lblMFgDate.AutoSize = True
        Me.lblMFgDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMFgDate.Location = New System.Drawing.Point(709, 10)
        Me.lblMFgDate.Name = "lblMFgDate"
        Me.lblMFgDate.Size = New System.Drawing.Size(63, 16)
        Me.lblMFgDate.TabIndex = 49
        Me.lblMFgDate.Text = "Mfg. Date"
        '
        'cmdADDFG
        '
        Me.cmdADDFG.Location = New System.Drawing.Point(11, 106)
        Me.cmdADDFG.Name = "cmdADDFG"
        Me.cmdADDFG.Size = New System.Drawing.Size(95, 25)
        Me.cmdADDFG.TabIndex = 47
        Me.cmdADDFG.Text = "&New Finish Good"
        '
        'cmbMIS
        '
        Me.cmbMIS.EditValue = ""
        Me.cmbMIS.Location = New System.Drawing.Point(104, 80)
        Me.cmbMIS.Name = "cmbMIS"
        Me.cmbMIS.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMIS.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbMIS.Size = New System.Drawing.Size(112, 20)
        Me.cmbMIS.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "MIS No."
        '
        'txtDimen
        '
        Me.txtDimen.EditValue = ""
        Me.txtDimen.Location = New System.Drawing.Point(567, 7)
        Me.txtDimen.Name = "txtDimen"
        Me.txtDimen.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDimen.Properties.Appearance.Options.UseFont = True
        Me.txtDimen.Size = New System.Drawing.Size(129, 22)
        Me.txtDimen.TabIndex = 5
        '
        'lblDrCheckno
        '
        Me.lblDrCheckno.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrCheckno.Location = New System.Drawing.Point(416, 6)
        Me.lblDrCheckno.Name = "lblDrCheckno"
        Me.lblDrCheckno.Size = New System.Drawing.Size(145, 35)
        Me.lblDrCheckno.TabIndex = 45
        Me.lblDrCheckno.Text = "Drawing && Specification check no"
        '
        'lkupFGName
        '
        Me.lkupFGName.EditValue = ""
        Me.lkupFGName.Location = New System.Drawing.Point(104, 9)
        Me.lkupFGName.Name = "lkupFGName"
        Me.lkupFGName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupFGName.Properties.NullText = ""
        Me.lkupFGName.Size = New System.Drawing.Size(296, 20)
        Me.lkupFGName.TabIndex = 4
        '
        'txtinspecno
        '
        Me.txtinspecno.EditValue = ""
        Me.txtinspecno.Location = New System.Drawing.Point(104, 47)
        Me.txtinspecno.Name = "txtinspecno"
        Me.txtinspecno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinspecno.Properties.Appearance.Options.UseFont = True
        Me.txtinspecno.Size = New System.Drawing.Size(104, 22)
        Me.txtinspecno.TabIndex = 6
        '
        'lblrejecqty
        '
        Me.lblrejecqty.AutoSize = True
        Me.lblrejecqty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrejecqty.Location = New System.Drawing.Point(416, 47)
        Me.lblrejecqty.Name = "lblrejecqty"
        Me.lblrejecqty.Size = New System.Drawing.Size(85, 16)
        Me.lblrejecqty.TabIndex = 34
        Me.lblrejecqty.Text = "Rejected Qty."
        '
        'lblinspecno
        '
        Me.lblinspecno.AutoSize = True
        Me.lblinspecno.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinspecno.Location = New System.Drawing.Point(8, 47)
        Me.lblinspecno.Name = "lblinspecno"
        Me.lblinspecno.Size = New System.Drawing.Size(91, 16)
        Me.lblinspecno.TabIndex = 26
        Me.lblinspecno.Text = "Inspected Qty:"
        '
        'txtqcno
        '
        Me.txtqcno.EditValue = ""
        Me.txtqcno.Location = New System.Drawing.Point(288, 47)
        Me.txtqcno.Name = "txtqcno"
        Me.txtqcno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqcno.Properties.Appearance.Options.UseFont = True
        Me.txtqcno.Size = New System.Drawing.Size(112, 22)
        Me.txtqcno.TabIndex = 7
        '
        'lblqcno
        '
        Me.lblqcno.AutoSize = True
        Me.lblqcno.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqcno.Location = New System.Drawing.Point(224, 47)
        Me.lblqcno.Name = "lblqcno"
        Me.lblqcno.Size = New System.Drawing.Size(50, 16)
        Me.lblqcno.TabIndex = 24
        Me.lblqcno.Text = "QC OK:"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(975, 106)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(56, 27)
        Me.cmdAdd.TabIndex = 12
        Me.cmdAdd.Text = "&Add"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(1039, 106)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(56, 27)
        Me.cmdDelete.TabIndex = 15
        Me.cmdDelete.Text = "&Delete"
        '
        'lblRaw
        '
        Me.lblRaw.AutoSize = True
        Me.lblRaw.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaw.Location = New System.Drawing.Point(8, 9)
        Me.lblRaw.Name = "lblRaw"
        Me.lblRaw.Size = New System.Drawing.Size(88, 16)
        Me.lblRaw.TabIndex = 21
        Me.lblRaw.Text = "Finish Product"
        '
        'txtrejqty
        '
        Me.txtrejqty.EditValue = ""
        Me.txtrejqty.Location = New System.Drawing.Point(568, 47)
        Me.txtrejqty.Name = "txtrejqty"
        Me.txtrejqty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrejqty.Properties.Appearance.Options.UseFont = True
        Me.txtrejqty.Properties.ReadOnly = True
        Me.txtrejqty.Size = New System.Drawing.Size(128, 22)
        Me.txtrejqty.TabIndex = 8
        '
        'frmPackingVI
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1115, 475)
        Me.Controls.Add(Me.grpqc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPackingVI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Packing Visual Inspection of Final Product"
        CType(Me.gvqc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdqc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpqc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpqc.ResumeLayout(False)
        Me.grpqc.PerformLayout()
        CType(Me.dtPackingVI.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtPackingVI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPackingVINo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSrNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlQCDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlQCDetail.ResumeLayout(False)
        Me.pnlQCDetail.PerformLayout()
        CType(Me.txtRejectionCompID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtExpDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtExpDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtMfgDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtMfgDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMIS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDimen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupFGName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtinspecno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtqcno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrejqty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private Sub frmPackingVI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FillLookupWithMultipleValues("select fgname,fid,Draw_no,ExpirationPeriod from fgmaster", "FGmaster", "Product Name", "FID", lkupFGName)
        'FillCombox("reason", "reason", cmbreason)

        Dim strSql As String = " Material_Issue_Master LEFT JOIN PackingVI_Detail ON Material_Issue_Master.MIS_NO = PackingVI_Detail.MIS_NO" _
        & " WHERE (((PackingVI_Detail.Inspected_No) Is Null)) OR (((PackingVI_Detail.Inspected_No)<[Material_Issue_Master]![FG_QTY]));"

        FillCombox(strSql, "Distinct(Material_Issue_Master.MIS_NO)", cmbMIS)

        'cmbMIS.Properties.Items.Add("X")

        dt.Columns.Add("FID", System.Type.GetType("System.String"))
        dt.Columns.Add("Finish_Good", System.Type.GetType("System.String"))

        dt.Columns.Add("Dimension_check", System.Type.GetType("System.String"))
        dt.Columns.Add("Inspected_No", System.Type.GetType("System.String"))
        dt.Columns.Add("QC_No", System.Type.GetType("System.String"))
        dt.Columns.Add("Reject_Qty", System.Type.GetType("System.String"))

        'dt.Columns.Add("Reason", System.Type.GetType("System.String"))
        dt.Columns.Add("MIS_NO", System.Type.GetType("System.String"))
        'dt.Columns.Add("Batch_NO", System.Type.GetType("System.String"))
        dt.Columns.Add("MFG_Date", System.Type.GetType("System.DateTime"))
        dt.Columns.Add("Exp_Date", System.Type.GetType("System.DateTime"))

        If strcheck = "Add" Then
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            Dim intMax As Integer
            cmd.CommandText = "select max(Sr_No) from PackingVI_Master where cy ='" & strCY.Trim & "'"
            If IsDBNull(cmd.ExecuteScalar) = True Then
                txtSrNo.Text = 1
            Else
                txtSrNo.Text = Val(cmd.ExecuteScalar + 1)
            End If
            cmd.Dispose()

        End If

        If strcheck = "Edit" Then
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "select * from PackingVI_Master where Packing_VI_No = '" & strgridid & "'" ' and CY ='" & strCY.Trim & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            bind_data()
            dr.Close()
            cmd.Dispose()
        End If
    End Sub
    Private Sub bind_data()

        Try
            If IsDBNull(dr("Sr_No")) = True Then
                txtSrNo.Text = ""
            Else
                txtSrNo.Text = dr("SR_NO")
            End If

            If IsDBNull(dr("Packing_VI_No")) = True Then
                txtPackingVINo.Text = String.Empty
            Else
                txtPackingVINo.Text = dr("Packing_VI_No")
            End If

            If IsDBNull(dr("PKG_VI_Date")) = True Then
                dtPackingVI.EditValue = ""
            Else
                dtPackingVI.EditValue = dr("PKG_VI_Date")
            End If
            dr.Close()

            Dim adp = New OleDb.OleDbDataAdapter("SELECT PackingVI_Detail.FID,FGMaster.FGName as Finish_Good, PackingVI_Detail.Dim_Check as Dimension_Check, PackingVI_Detail.Inspected_No, PackingVI_Detail.QC_No, PackingVI_Detail.Reject_Qty,  PackingVI_Detail.MIS_NO " _
                          & " ,PackingVI_Detail.MFG_Date, PackingVI_Detail.Exp_Date FROM PackingVI_Detail INNER JOIN FGMaster ON PackingVI_Detail.FID = FGMaster.FID " _
                          & " WHERE (((PackingVI_Detail.PACKING_VI_NO)='" & strgridid & "'))", conn) 'and PackingVI_Detail.CY ='" & strCY.Trim & "'
            adp.fill(dt)
            gdqc.DataSource = dt
            gvqc.Columns("FID").Visible = False
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub txtinspecno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtinspecno.KeyPress
        Try
            If InStr(txtinspecno.Text, ".") <> 0 And Asc(e.KeyChar) = 46 Then
                e.Handled = True
                Exit Sub
            End If
            e.Handled = IsDecimalNumber(e.KeyChar)
        Catch ex As Exception
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub txtqcno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqcno.KeyPress
        Try
            If InStr(txtqcno.Text, ".") <> 0 And Asc(e.KeyChar) = 46 Then
                e.Handled = True
                Exit Sub
            End If
            e.Handled = IsDecimalNumber(e.KeyChar)
        Catch ex As Exception
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub lkupFGName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupFGName.EditValueChanged
        Try
            If lkupFGName.EditValue <> "" Then
                Dim row As DataRowView = lkupFGName.Properties.GetDataSourceRowByKeyValue(lkupFGName.EditValue)
                lkupFGName.Tag = row(1).ToString
                txtDimen.Text = row(2).ToString
                Integer.TryParse(row(3).ToString(), expirationPeriod)
                If strcheck = "Add" Then
                    dtMfgDate.DateTime = Date.Now.Date
                End If
                setExpirationDate()
            End If
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub setExpirationDate()
        If expirationPeriod > 0 Then
            dtExpDate.DateTime = DateAdd(DateInterval.Month, expirationPeriod, dtMfgDate.DateTime)
        Else
            dtExpDate.Text = String.Empty
        End If
    End Sub


    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If gvqc.GetSelectedRows.Length > 0 Then
                If MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    'Write code for delete from fgstock.
                    'cmd.CommandText = "Insert into FGStock values('" & gvqc.GetRowCellValue(i, "FID") & "','" & dtinspection.Text & "','" & gvqc.GetRowCellValue(i, "Batch_NO") & "','Inward'," & gvqc.GetRowCellValue(i, "QC_No") & ",0,0," & gvqc.GetRowCellValue(i, "QC_No") & ",'" & strCY.Trim & "')"
                    arrFID.Add(gvqc.GetRowCellValue(gvqc.FocusedRowHandle, "FID"))
                    arrBatchNo.Add(gvqc.GetRowCellValue(gvqc.FocusedRowHandle, "Batch_NO"))
                    arrQC_No.Add(gvqc.GetRowCellValue(gvqc.FocusedRowHandle, "QC_No"))

                    gvqc.DeleteRow(gvqc.FocusedRowHandle)
                    gvqc.RefreshData()
                End If
            End If
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try

            If (isRejectionIDEnterd() = False) Then
                MessageBox.Show("Please enter valid Rejection Component ID for rejected qty.", "Invalid Rejection Component ID", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim dr As DataRow
            Dim blnDup As Boolean = False
            For i As Int16 = 0 To gvqc.RowCount - 1
                If gvqc.GetRowCellValue(i, gvqc.Columns(1)).ToString = lkupFGName.Text Then
                    blnDup = True
                    Exit For
                End If
            Next
            If blnDup = False Then

                dr = dt.NewRow
                dr.Item(0) = lkupFGName.Tag
                dr.Item(1) = lkupFGName.Text
                dr.Item(2) = txtDimen.Text
                dr.Item(3) = txtinspecno.Text
                dr.Item(4) = txtqcno.Text
                dr.Item(5) = txtrejqty.Text
                dr.Item(6) = cmbMIS.Text
                'dr.Item(8) = txtBatchNo.Text
                dr.Item(7) = dtMfgDate.DateTime
                dr.Item(8) = dtExpDate.DateTime
                dt.Rows.Add(dr)
                gdqc.DataSource = dt
            End If

        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Try
            If strcheck = "Add" Then
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                Dim inspectionDt As New Date

                cmd.CommandText = "insert into PackingVI_Master values ('" & txtSrNo.Text.Trim & "','" & strCY.Trim & "','" & Replace(txtPackingVINo.Text, "''", "'") & "','" & dtPackingVI.Text & "')"
                cmd.Transaction = conn.BeginTransaction
                cmd.ExecuteNonQuery()

                For i As Int16 = 0 To gvqc.RowCount - 1
                    'Packing VI Details
                    cmd.CommandText = "insert into PackingVI_Detail values('" & txtPackingVINo.Text & "','" & gvqc.GetRowCellValue(i, "FID") & "','" & gvqc.GetRowCellValue(i, "Dimension_check") & "'," & gvqc.GetRowCellValue(i, "Inspected_No") & "," & gvqc.GetRowCellValue(i, "QC_No") & "," & gvqc.GetRowCellValue(i, "Reject_Qty") & ",'" & gvqc.GetRowCellValue(i, "MIS_NO") & "','" & strCY.Trim &
                         "','" & dtMfgDate.DateTime & "','" & dtExpDate.DateTime & "')"
                    cmd.ExecuteNonQuery()
                Next
                cmd.Transaction.Commit()
                cmd.Dispose()
            ElseIf strcheck = "Edit" Then

                cmd = New OleDb.OleDbCommand
                cmd.CommandText = "Update PackingVI_Master set Packing_VI_No = '" & txtPackingVINo.Text & "', PKG_VI_DATE='" & dtPackingVI.Text & "' where SR_No =" & txtSrNo.Text   '& "' and CY ='" & strCY.Trim & "'"
                cmd.Connection = conn
                cmd.Transaction = conn.BeginTransaction
                cmd.ExecuteNonQuery()
                cmd.CommandText = "delete from PackingVI_Detail where Packing_VI_No = '" & txtPackingVINo.Text & "'" ' and CY ='" & strCY.Trim & "'"
                cmd.Connection = conn
                cmd.ExecuteNonQuery()

                For i As Int16 = 0 To gvqc.RowCount - 1
                    cmd.CommandText = "insert into PackingVI_Detail values('" & txtPackingVINo.Text & "','" & gvqc.GetRowCellValue(i, "FID") & "','" & gvqc.GetRowCellValue(i, "Dimension_check") & "'," & gvqc.GetRowCellValue(i, "Inspected_No") & "," & gvqc.GetRowCellValue(i, "QC_No") & "," & gvqc.GetRowCellValue(i, "Reject_Qty") & ",'" & gvqc.GetRowCellValue(i, "MIS_NO") & "','" & strCY.Trim &
                       "','" & gvqc.GetRowCellValue(i, "MFG_Date") & "','" & gvqc.GetRowCellValue(i, "Exp_Date") & "')"
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

    Private Sub txtPacking_VI_No_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPackingVINo.Validating
        Try
            If strcheck = "Add" Then
                Dim str As String
                str = IsDuplicate("select count(Packing_VI_No) from PackingVI_Master where Packing_VI_No ='" & txtPackingVINo.Text & "' and CY ='" & strCY.Trim & "'")
                If str = True Then
                    MessageBox.Show("This Packing Visual Inspection Number already exist", "Duplicate Value Error", MessageBoxButtons.OK)
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub txtqcno_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtqcno.Validating
        Try
            If Val(txtqcno.Text) > Val(txtinspecno.Text) Then
                MessageBox.Show("Accepted Quantity Cannot Exceed The Inspected Quantity", "Check Rejeted Quantity", MessageBoxButtons.OK)
                e.Cancel = True
                'txtqcno.Text = ""
                'txtqcno.Select()
                'Exit Sub

            Else
                txtrejqty.Text = Val(txtinspecno.Text) - Val(txtqcno.Text)
            End If
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try

    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub

    Private Sub cmdADDFG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdADDFG.Click
        Try
            Dim myFrm As New frmfgmaster
            myFrm.ShowDialog()
            myFrm.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmbMIS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMIS.SelectedIndexChanged
        Try
            If cmbMIS.Text <> "" Then
                Dim strSql As String
                strSql = "Select FGID FROM Material_Issue_Master " _
                & " WHERE (((Material_Issue_Master.MIS_NO)='" & cmbMIS.Text & "'));"

                Dim cmd As New OleDb.OleDbCommand(strSql, conn)
                If lkupFGName.Text = "" Then
                    MessageBox.Show("Before selecting MIS No make sure you have enter Finish Product.", "Select Product", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cmbMIS.Text = ""
                    Exit Sub
                End If
                If cmd.ExecuteScalar.ToString <> lkupFGName.Tag Then
                    MessageBox.Show("Selected MIS no is not valid for " & lkupFGName.Text & ".", "Invalid MIS", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    cmbMIS.Text = ""
                Else
                    strSql = "SELECT (Material_Issue_Master.FG_QTY - Sum(PackingVI_Detail.Inspected_No)) AS SumOfInspected_No " _
                        & " FROM Material_Issue_Master INNER JOIN PackingVI_Detail ON Material_Issue_Master.MIS_NO = PackingVI_Detail.MIS_NO " _
                        & " WHERE(((Material_Issue_Master.MIS_NO) = '" & cmbMIS.Text & "')) GROUP BY Material_Issue_Master.FG_QTY;"
                    cmd.CommandText = strSql
                    Dim intQCQty As Integer
                    intQCQty = IIf(IsDBNull(cmd.ExecuteScalar), 0, cmd.ExecuteScalar)
                    If intQCQty > 0 Then
                        If intQCQty < txtinspecno.Text Then
                            MessageBox.Show("Inspected qty is not allowed to be more then MIS qty. Select different MIS number or first change inspected qty.", "Qty Missmatch", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            cmbMIS.Text = ""
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub dtMfgDate_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtMfgDate.EditValueChanged
        setExpirationDate()
    End Sub

    Private Function isRejectionIDEnterd() As Boolean
        If txtrejqty.Text > 0 And txtRejectionCompID.Text = "" Then
            Return False
        ElseIf txtrejqty.Text > 0 And txtRejectionCompID.Text <> "" Then

            If (cmbMIS.Text = "") Then
                MessageBox.Show("Please select MIS No first.")
                cmbMIS.Focus()
                txtRejectionCompID.Text = ""
                Return False
            End If

            Dim strSql As String

            strSql = "SELECT Count(MIS_Return_Master.ID) AS CountOfID " _
            & " FROM(MIS_Return_Master) " _
            & " WHERE (((MIS_Return_Master.ID) =" & txtRejectionCompID.Text & ") AND ((MIS_Return_Master.MIS_NO)='" & cmbMIS.Text & "'));"

            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = strSql

            Dim rowcount As Integer = cmd.ExecuteScalar()
            If rowcount = 0 Then
                MessageBox.Show("Invalid Rejection Component ID", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return False
            Else
                Return True
            End If
        Else
            Return True
        End If
    End Function

    Private Sub txtrejqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrejqty.TextChanged
        If (txtrejqty.Text = "0" Or txtrejqty.Text = "") Then
            txtRejectionCompID.Enabled = False
        Else
            txtRejectionCompID.Enabled = True
        End If
    End Sub

    Private Sub txtRejectionCompID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRejectionCompID.EditValueChanged

    End Sub

    Private Sub txtRejectionCompID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRejectionCompID.LostFocus
        If (cmbMIS.Text = "") Then
            MessageBox.Show("Please select MIS No first.")
            cmbMIS.Focus()
            txtRejectionCompID.Text = ""
            Return
        End If
        If (txtRejectionCompID.Text <> "" And txtrejqty.Text <> 0) Then
            Dim strSql As String

            strSql = "SELECT Count(MIS_Return_Master.ID) AS CountOfID " _
            & " FROM(MIS_Return_Master) " _
            & " WHERE (((MIS_Return_Master.ID) =" & txtRejectionCompID.Text & ") AND ((MIS_Return_Master.MIS_NO)='" & cmbMIS.Text & "'));"

            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = strSql

            Dim rowcount As Integer = cmd.ExecuteScalar
            If rowcount = 0 Then
                MessageBox.Show("Invalid Rejection Component ID", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'txtRejectionCompID.Focus()
            End If
        End If
    End Sub
End Class

