Public Class frmSemiFinishGoodQC
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
    Friend WithEvents dtinspection As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents cmdsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdclose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnlQCDetail As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblDrCheckno As System.Windows.Forms.Label
    Friend WithEvents lkupFGName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbreason As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
    Friend WithEvents lblLotno As System.Windows.Forms.Label
    Friend WithEvents lblVI As System.Windows.Forms.Label
    Friend WithEvents txtVI_No As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDimen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBatchNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbMIS As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents chkSCheck As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtST_Check As DevExpress.XtraEditors.DateEdit
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
        Me.dtST_Check = New DevExpress.XtraEditors.DateEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkSCheck = New DevExpress.XtraEditors.CheckEdit()
        Me.dtinspection = New DevExpress.XtraEditors.DateEdit()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.cmdsave = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdclose = New DevExpress.XtraEditors.SimpleButton()
        Me.pnlQCDetail = New DevExpress.XtraEditors.PanelControl()
        Me.dtExpDate = New DevExpress.XtraEditors.DateEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtMfgDate = New DevExpress.XtraEditors.DateEdit()
        Me.lblMFgDate = New System.Windows.Forms.Label()
        Me.cmdADDFG = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbMIS = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDimen = New DevExpress.XtraEditors.TextEdit()
        Me.lblDrCheckno = New System.Windows.Forms.Label()
        Me.txtBatchNo = New DevExpress.XtraEditors.TextEdit()
        Me.lkupFGName = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbreason = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtinspecno = New DevExpress.XtraEditors.TextEdit()
        Me.lblrejecqty = New System.Windows.Forms.Label()
        Me.lblinspecno = New System.Windows.Forms.Label()
        Me.txtqcno = New DevExpress.XtraEditors.TextEdit()
        Me.lblqcno = New System.Windows.Forms.Label()
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.lblRaw = New System.Windows.Forms.Label()
        Me.txtrejqty = New DevExpress.XtraEditors.TextEdit()
        Me.lblLotno = New System.Windows.Forms.Label()
        Me.lblVI = New System.Windows.Forms.Label()
        Me.txtVI_No = New DevExpress.XtraEditors.TextEdit()
        CType(Me.gvqc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdqc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpqc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpqc.SuspendLayout()
        CType(Me.dtPackingVI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPackingVINo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSrNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtST_Check.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtinspection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlQCDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlQCDetail.SuspendLayout()
        CType(Me.dtExpDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMfgDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbMIS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDimen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBatchNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupFGName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbreason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtinspecno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtqcno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrejqty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVI_No.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        '
        '
        '
        Me.gdqc.Font = New System.Drawing.Font("Tahoma", 8.25!)
        GridLevelNode1.RelationName = "Level1"
        Me.gdqc.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gdqc.Location = New System.Drawing.Point(8, 136)
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
        Me.grpqc.Controls.Add(Me.dtST_Check)
        Me.grpqc.Controls.Add(Me.Label3)
        Me.grpqc.Controls.Add(Me.chkSCheck)
        Me.grpqc.Controls.Add(Me.dtinspection)
        Me.grpqc.Controls.Add(Me.lbldate)
        Me.grpqc.Controls.Add(Me.cmdsave)
        Me.grpqc.Controls.Add(Me.cmdclose)
        Me.grpqc.Controls.Add(Me.pnlQCDetail)
        Me.grpqc.Controls.Add(Me.lblVI)
        Me.grpqc.Controls.Add(Me.txtVI_No)
        Me.grpqc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpqc.Location = New System.Drawing.Point(0, 0)
        Me.grpqc.Name = "grpqc"
        Me.grpqc.Size = New System.Drawing.Size(1115, 512)
        Me.grpqc.TabIndex = 0
        '
        'dtPackingVI
        '
        Me.dtPackingVI.EditValue = Nothing
        Me.dtPackingVI.Location = New System.Drawing.Point(821, 32)
        Me.dtPackingVI.Name = "dtPackingVI"
        Me.dtPackingVI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtPackingVI.Properties.EditFormat.FormatString = "d"
        Me.dtPackingVI.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.dtPackingVI.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtPackingVI.Size = New System.Drawing.Size(128, 20)
        Me.dtPackingVI.TabIndex = 38
        Me.dtPackingVI.Visible = False
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
        Me.Label6.Visible = False
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
        Me.lblPackVINo.Visible = False
        '
        'txtPackingVINo
        '
        Me.txtPackingVINo.Location = New System.Drawing.Point(576, 30)
        Me.txtPackingVINo.Name = "txtPackingVINo"
        Me.txtPackingVINo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPackingVINo.Properties.Appearance.Options.UseFont = True
        Me.txtPackingVINo.Size = New System.Drawing.Size(128, 22)
        Me.txtPackingVINo.TabIndex = 37
        Me.txtPackingVINo.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Serial No.:"
        '
        'txtSrNo
        '
        Me.txtSrNo.Location = New System.Drawing.Point(152, 24)
        Me.txtSrNo.Name = "txtSrNo"
        Me.txtSrNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSrNo.Properties.Appearance.Options.UseFont = True
        Me.txtSrNo.Properties.ReadOnly = True
        Me.txtSrNo.Size = New System.Drawing.Size(152, 22)
        Me.txtSrNo.TabIndex = 34
        Me.txtSrNo.TabStop = False
        '
        'dtST_Check
        '
        Me.dtST_Check.EditValue = New Date(2016, 4, 16, 0, 0, 0, 0)
        Me.dtST_Check.Location = New System.Drawing.Point(576, 80)
        Me.dtST_Check.Name = "dtST_Check"
        Me.dtST_Check.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtST_Check.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtST_Check.Size = New System.Drawing.Size(128, 20)
        Me.dtST_Check.TabIndex = 33
        Me.dtST_Check.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(424, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Sterilization Check Date"
        Me.Label3.Visible = False
        '
        'chkSCheck
        '
        Me.chkSCheck.Location = New System.Drawing.Point(152, 80)
        Me.chkSCheck.Name = "chkSCheck"
        Me.chkSCheck.Properties.Caption = "Sterilization Required"
        Me.chkSCheck.Size = New System.Drawing.Size(256, 19)
        Me.chkSCheck.TabIndex = 31
        Me.chkSCheck.Visible = False
        '
        'dtinspection
        '
        Me.dtinspection.EditValue = Nothing
        Me.dtinspection.Location = New System.Drawing.Point(576, 56)
        Me.dtinspection.Name = "dtinspection"
        Me.dtinspection.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtinspection.Properties.EditFormat.FormatString = "d"
        Me.dtinspection.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.dtinspection.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtinspection.Size = New System.Drawing.Size(128, 20)
        Me.dtinspection.TabIndex = 2
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(424, 56)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(134, 16)
        Me.lbldate.TabIndex = 30
        Me.lbldate.Text = "Visual Inspection Date"
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(974, 478)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(64, 25)
        Me.cmdsave.TabIndex = 13
        Me.cmdsave.Text = "&Save"
        '
        'cmdclose
        '
        Me.cmdclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdclose.Location = New System.Drawing.Point(1046, 478)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(64, 25)
        Me.cmdclose.TabIndex = 14
        Me.cmdclose.Text = "&Close"
        '
        'pnlQCDetail
        '
        Me.pnlQCDetail.Controls.Add(Me.dtExpDate)
        Me.pnlQCDetail.Controls.Add(Me.Label5)
        Me.pnlQCDetail.Controls.Add(Me.dtMfgDate)
        Me.pnlQCDetail.Controls.Add(Me.lblMFgDate)
        Me.pnlQCDetail.Controls.Add(Me.cmdADDFG)
        Me.pnlQCDetail.Controls.Add(Me.cmbMIS)
        Me.pnlQCDetail.Controls.Add(Me.Label1)
        Me.pnlQCDetail.Controls.Add(Me.txtDimen)
        Me.pnlQCDetail.Controls.Add(Me.lblDrCheckno)
        Me.pnlQCDetail.Controls.Add(Me.txtBatchNo)
        Me.pnlQCDetail.Controls.Add(Me.lkupFGName)
        Me.pnlQCDetail.Controls.Add(Me.cmbreason)
        Me.pnlQCDetail.Controls.Add(Me.Label2)
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
        Me.pnlQCDetail.Controls.Add(Me.lblLotno)
        Me.pnlQCDetail.Location = New System.Drawing.Point(8, 104)
        Me.pnlQCDetail.Name = "pnlQCDetail"
        Me.pnlQCDetail.Size = New System.Drawing.Size(1102, 368)
        Me.pnlQCDetail.TabIndex = 3
        Me.pnlQCDetail.Text = "PanelControl1"
        '
        'dtExpDate
        '
        Me.dtExpDate.EditValue = New Date(2016, 4, 16, 0, 0, 0, 0)
        Me.dtExpDate.Location = New System.Drawing.Point(779, 42)
        Me.dtExpDate.Name = "dtExpDate"
        Me.dtExpDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtExpDate.Properties.DisplayFormat.FormatString = "MM/yyyy"
        Me.dtExpDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtExpDate.Properties.Mask.EditMask = "MM/yyyy"
        Me.dtExpDate.Properties.ReadOnly = True
        Me.dtExpDate.Size = New System.Drawing.Size(128, 20)
        Me.dtExpDate.TabIndex = 52
        Me.dtExpDate.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(710, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 16)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Exp. Date"
        Me.Label5.Visible = False
        '
        'dtMfgDate
        '
        Me.dtMfgDate.EditValue = New Date(2016, 4, 16, 0, 0, 0, 0)
        Me.dtMfgDate.Location = New System.Drawing.Point(779, 8)
        Me.dtMfgDate.Name = "dtMfgDate"
        Me.dtMfgDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtMfgDate.Properties.DisplayFormat.FormatString = "MM/yyyy"
        Me.dtMfgDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtMfgDate.Properties.Mask.EditMask = "MM/yyyy"
        Me.dtMfgDate.Size = New System.Drawing.Size(128, 20)
        Me.dtMfgDate.TabIndex = 50
        Me.dtMfgDate.Visible = False
        '
        'lblMFgDate
        '
        Me.lblMFgDate.AutoSize = True
        Me.lblMFgDate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMFgDate.Location = New System.Drawing.Point(710, 9)
        Me.lblMFgDate.Name = "lblMFgDate"
        Me.lblMFgDate.Size = New System.Drawing.Size(63, 16)
        Me.lblMFgDate.TabIndex = 49
        Me.lblMFgDate.Text = "Mfg. Date"
        Me.lblMFgDate.Visible = False
        '
        'cmdADDFG
        '
        Me.cmdADDFG.Location = New System.Drawing.Point(11, 106)
        Me.cmdADDFG.Name = "cmdADDFG"
        Me.cmdADDFG.Size = New System.Drawing.Size(135, 25)
        Me.cmdADDFG.TabIndex = 47
        Me.cmdADDFG.Text = "&New Semi Finish Good"
        '
        'cmbMIS
        '
        Me.cmbMIS.Location = New System.Drawing.Point(288, 72)
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
        Me.Label1.Location = New System.Drawing.Point(231, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "MIS No."
        '
        'txtDimen
        '
        Me.txtDimen.Location = New System.Drawing.Point(568, 9)
        Me.txtDimen.Name = "txtDimen"
        Me.txtDimen.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDimen.Properties.Appearance.Options.UseFont = True
        Me.txtDimen.Size = New System.Drawing.Size(128, 22)
        Me.txtDimen.TabIndex = 5
        '
        'lblDrCheckno
        '
        Me.lblDrCheckno.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrCheckno.Location = New System.Drawing.Point(416, 9)
        Me.lblDrCheckno.Name = "lblDrCheckno"
        Me.lblDrCheckno.Size = New System.Drawing.Size(152, 32)
        Me.lblDrCheckno.TabIndex = 45
        Me.lblDrCheckno.Text = "Drawing && Specification check no"
        '
        'txtBatchNo
        '
        Me.txtBatchNo.Location = New System.Drawing.Point(121, 72)
        Me.txtBatchNo.Name = "txtBatchNo"
        Me.txtBatchNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBatchNo.Properties.Appearance.Options.UseFont = True
        Me.txtBatchNo.Size = New System.Drawing.Size(104, 22)
        Me.txtBatchNo.TabIndex = 9
        '
        'lkupFGName
        '
        Me.lkupFGName.Location = New System.Drawing.Point(121, 9)
        Me.lkupFGName.Name = "lkupFGName"
        Me.lkupFGName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupFGName.Size = New System.Drawing.Size(279, 20)
        Me.lkupFGName.TabIndex = 4
        '
        'cmbreason
        '
        Me.cmbreason.Location = New System.Drawing.Point(568, 72)
        Me.cmbreason.Name = "cmbreason"
        Me.cmbreason.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbreason.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbreason.Size = New System.Drawing.Size(128, 20)
        Me.cmbreason.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(416, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Reason for Rej"
        '
        'txtinspecno
        '
        Me.txtinspecno.Location = New System.Drawing.Point(121, 40)
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
        Me.lblrejecqty.Location = New System.Drawing.Point(416, 40)
        Me.lblrejecqty.Name = "lblrejecqty"
        Me.lblrejecqty.Size = New System.Drawing.Size(85, 16)
        Me.lblrejecqty.TabIndex = 34
        Me.lblrejecqty.Text = "Rejected Qty."
        '
        'lblinspecno
        '
        Me.lblinspecno.AutoSize = True
        Me.lblinspecno.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinspecno.Location = New System.Drawing.Point(8, 40)
        Me.lblinspecno.Name = "lblinspecno"
        Me.lblinspecno.Size = New System.Drawing.Size(91, 16)
        Me.lblinspecno.TabIndex = 26
        Me.lblinspecno.Text = "Inspected Qty:"
        '
        'txtqcno
        '
        Me.txtqcno.Location = New System.Drawing.Point(288, 40)
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
        Me.lblqcno.Location = New System.Drawing.Point(231, 40)
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
        Me.lblRaw.Size = New System.Drawing.Size(107, 16)
        Me.lblRaw.TabIndex = 21
        Me.lblRaw.Text = "Semi Finish Good"
        '
        'txtrejqty
        '
        Me.txtrejqty.Location = New System.Drawing.Point(568, 40)
        Me.txtrejqty.Name = "txtrejqty"
        Me.txtrejqty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrejqty.Properties.Appearance.Options.UseFont = True
        Me.txtrejqty.Properties.ReadOnly = True
        Me.txtrejqty.Size = New System.Drawing.Size(128, 22)
        Me.txtrejqty.TabIndex = 8
        '
        'lblLotno
        '
        Me.lblLotno.AutoSize = True
        Me.lblLotno.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLotno.Location = New System.Drawing.Point(8, 72)
        Me.lblLotno.Name = "lblLotno"
        Me.lblLotno.Size = New System.Drawing.Size(71, 16)
        Me.lblLotno.TabIndex = 2
        Me.lblLotno.Text = " Batch No.:"
        '
        'lblVI
        '
        Me.lblVI.AutoSize = True
        Me.lblVI.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVI.Location = New System.Drawing.Point(16, 48)
        Me.lblVI.Name = "lblVI"
        Me.lblVI.Size = New System.Drawing.Size(132, 16)
        Me.lblVI.TabIndex = 1
        Me.lblVI.Text = "Visual Insepction No.:"
        '
        'txtVI_No
        '
        Me.txtVI_No.Location = New System.Drawing.Point(152, 48)
        Me.txtVI_No.Name = "txtVI_No"
        Me.txtVI_No.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVI_No.Properties.Appearance.Options.UseFont = True
        Me.txtVI_No.Size = New System.Drawing.Size(152, 22)
        Me.txtVI_No.TabIndex = 1
        '
        'frmSemiFinishGoodQC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1115, 512)
        Me.Controls.Add(Me.grpqc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSemiFinishGoodQC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visual Inspection of Semi Final Product"
        CType(Me.gvqc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdqc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpqc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpqc.ResumeLayout(False)
        Me.grpqc.PerformLayout()
        CType(Me.dtPackingVI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPackingVINo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSrNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtST_Check.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtinspection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlQCDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlQCDetail.ResumeLayout(False)
        Me.pnlQCDetail.PerformLayout()
        CType(Me.dtExpDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtMfgDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbMIS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDimen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBatchNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupFGName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbreason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtinspecno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtqcno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrejqty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVI_No.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private Sub frmFinishGoodQC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FillLookupWithMultipleValues("select fgname,sfid,Draw_no,ExpirationPeriod from SemiFGMaster", "SemiFGMaster", "Product Name", "SFID", lkupFGName)
        FillCombox("reason", "reason", cmbreason)

        Dim strSql As String = " SEMI_Material_Issue_Master LEFT JOIN SEMI_FinishGoods_QCDetail ON SEMI_Material_Issue_Master.MIS_NO = SEMI_FinishGoods_QCDetail.MIS_NO" _
        & " WHERE (((SEMI_FinishGoods_QCDetail.Inspected_No) Is Null)) OR (((SEMI_FinishGoods_QCDetail.Inspected_No)<[SEMI_Material_Issue_Master]![SFG_QTY]));"

        FillCombox(strSql, "Distinct(SEMI_Material_Issue_Master.MIS_NO)", cmbMIS)

        'cmbMIS.Properties.Items.Add("X")

        dt.Columns.Add("SFID", System.Type.GetType("System.String"))
        dt.Columns.Add("Semi_Finish_Good", System.Type.GetType("System.String"))

        dt.Columns.Add("Dimension_check", System.Type.GetType("System.String"))
        dt.Columns.Add("Inspected_No", System.Type.GetType("System.String"))
        dt.Columns.Add("QC_No", System.Type.GetType("System.String"))
        dt.Columns.Add("Reject_Qty", System.Type.GetType("System.String"))

        dt.Columns.Add("Reason", System.Type.GetType("System.String"))
        dt.Columns.Add("MIS_NO", System.Type.GetType("System.String"))
        dt.Columns.Add("Batch_NO", System.Type.GetType("System.String"))
        dt.Columns.Add("MFG_Date", System.Type.GetType("System.DateTime"))
        dt.Columns.Add("Exp_Date", System.Type.GetType("System.DateTime"))

        If strcheck = "Add" Then
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            Dim intMax As Integer
            cmd.CommandText = "select max(Sr_No) from SEMI_finishgoods_qcmaster where cy ='" & strCY.Trim & "'"
            If IsDBNull(cmd.ExecuteScalar) = True Then
                txtSrNo.Text = 1
            Else
                txtSrNo.Text = Val(cmd.ExecuteScalar + 1)
            End If
            cmd.Dispose()
            dtinspection.EditValue = Now
            dtST_Check.Properties.ReadOnly = True
        End If

        If strcheck = "Edit" Then
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "select * from SEMI_finishgoods_qcmaster where SFGVI_NO = '" & strgridid & "'" ' and CY ='" & strCY.Trim & "'"
            dr = cmd.ExecuteReader
            dr.Read()
            bind_data()
            dr.Close()
            cmd.Dispose()
            'chkSCheck.Enabled = False
            If chkSCheck.Checked = True Then
                blnSterilize = True
            Else
                blnSterilize = False
            End If
        End If
    End Sub
    Private Sub bind_data()

        Try
            If IsDBNull(dr("Sr_No")) = True Then
                txtSrNo.Text = ""
            Else
                txtSrNo.Text = dr("SR_NO")
            End If
            If IsDBNull(dr("SFGVI_NO")) = True Then
                txtVI_No.Text = ""
            Else
                txtVI_No.Text = dr("SFGVI_NO").ToString
            End If

            If IsDBNull(dr("VI_Date")) = True Then
                dtinspection.EditValue = ""
            Else
                dtinspection.EditValue = dr("VI_Date").ToString
            End If

            'If dr("ST_CHECK") = True Then
            '    chkSCheck.Checked = True
            'Else
            '    chkSCheck.Checked = False
            'End If

            'If IsDBNull(dr("ST_DATE")) = True Then
            '    dtST_Check.EditValue = ""
            'Else
            '    dtST_Check.EditValue = dr("ST_DATE")
            'End If

            'If IsDBNull(dr("PKG_VI_NO")) = True Then
            '    txtPackingVINo.Text = String.Empty
            'Else
            '    txtPackingVINo.Text = dr("PKG_VI_NO")
            'End If

            'If IsDBNull(dr("PKG_VI_Date")) = True Then
            '    dtPackingVI.EditValue = ""
            'Else
            '    dtPackingVI.EditValue = dr("PKG_VI_Date")
            'End If
            dr.Close()

            Dim adp = New OleDb.OleDbDataAdapter("SELECT SEMI_FinishGoods_QCDetail.SFID,SEMIFGMaster.FGName as Semi_Finish_Good, SEMI_FinishGoods_QCDetail.Dim_Check as Dimension_Check, SEMI_FinishGoods_QCDetail.Inspected_No, SEMI_FinishGoods_QCDetail.QC_No, SEMI_FinishGoods_QCDetail.Reject_Qty, SEMI_FinishGoods_QCDetail.Reason, SEMI_FinishGoods_QCDetail.MIS_NO, SEMI_FinishGoods_QCDetail.Batch_NO " _
                          & " FROM SEMI_FinishGoods_QCDetail INNER JOIN SEMIFGMaster ON SEMI_FinishGoods_QCDetail.SFID = SEMIFGMaster.SFID " _
                          & " WHERE (((SEMI_FinishGoods_QCDetail.SFGVI_NO)='" & strgridid & "'))", conn) 'and SEMI_FinishGoods_QCDetail.CY ='" & strCY.Trim & "'
            adp.fill(dt)
            gdqc.DataSource = dt
            gvqc.Columns("SFID").Visible = False
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
                    'Write code for delete from SemiFGStock.
                    'cmd.CommandText = "Insert into SemiFGStock values('" & gvqc.GetRowCellValue(i, "SFID") & "','" & dtinspection.Text & "','" & gvqc.GetRowCellValue(i, "Batch_NO") & "','Inward'," & gvqc.GetRowCellValue(i, "QC_No") & ",0,0," & gvqc.GetRowCellValue(i, "QC_No") & ",'" & strCY.Trim & "')"
                    arrFID.Add(gvqc.GetRowCellValue(gvqc.FocusedRowHandle, "SFID"))
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
            Dim dr As DataRow
            Dim blnDup As Boolean = False
            For i As Int16 = 0 To gvqc.RowCount - 1
                If gvqc.GetRowCellValue(i, gvqc.Columns(1)).ToString = lkupFGName.Text Then
                    blnDup = True
                    Exit For
                End If
            Next
            If blnDup = False Then
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                cmd.CommandText = "SELECT Count(SEMI_FinishGoods_QCDetail.Batch_NO) AS CountOfBatch_NO, SEMI_FinishGoods_QCDetail.SFID, SEMI_FinishGoods_QCDetail.Batch_NO " _
                    & " FROM SEMI_finishgoods_qcmaster INNER JOIN SEMI_FinishGoods_QCDetail ON SEMI_finishgoods_qcmaster.SFGVI_NO = SEMI_FinishGoods_QCDetail.SFGVI_NO " _
                    & " GROUP BY SEMI_FinishGoods_QCDetail.SFID, SEMI_FinishGoods_QCDetail.Batch_NO " _
                    & " HAVING (((SEMI_FinishGoods_QCDetail.SFID)='" & lkupFGName.Tag & "') AND ((SEMI_FinishGoods_QCDetail.Batch_NO)='" & txtBatchNo.Text & "'))"
                If cmd.ExecuteScalar = 0 Then
                    dr = dt.NewRow
                    dr.Item(0) = lkupFGName.Tag
                    dr.Item(1) = lkupFGName.Text
                    dr.Item(2) = txtDimen.Text
                    dr.Item(3) = txtinspecno.Text
                    dr.Item(4) = txtqcno.Text
                    dr.Item(5) = txtrejqty.Text
                    dr.Item(6) = cmbreason.Text
                    dr.Item(7) = cmbMIS.Text
                    dr.Item(8) = txtBatchNo.Text
                    dt.Rows.Add(dr)
                    gdqc.DataSource = dt
                    gvqc.Columns("SFID").Visible = False
                End If
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show("Duplicate batch no for this product.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
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
                cmd.CommandText = "insert into SEMI_finishgoods_qcmaster values ('" & txtSrNo.Text.Trim & "','" & Replace(txtVI_No.Text, "''", "'") & "','" & dtinspection.Text & "','" & strCY.Trim & "')"
                cmd.Transaction = conn.BeginTransaction
                cmd.ExecuteNonQuery()

                For i As Int16 = 0 To gvqc.RowCount - 1
                    'Finish Good QC
                    cmd.CommandText = "insert into SEMI_FinishGoods_QCDetail values('" & txtVI_No.Text & "','" & gvqc.GetRowCellValue(i, "SFID") & "','" & gvqc.GetRowCellValue(i, "Dimension_check") & "'," & gvqc.GetRowCellValue(i, "Inspected_No") & "," & gvqc.GetRowCellValue(i, "QC_No") & "," & gvqc.GetRowCellValue(i, "Reject_Qty") & ",'" & gvqc.GetRowCellValue(i, "Reason") & "','" & gvqc.GetRowCellValue(i, "MIS_NO") & "','" & gvqc.GetRowCellValue(i, "Batch_NO") & "','" & strCY.Trim & _
                         "',NULL,NULL)"
                    cmd.ExecuteNonQuery()

                    If chkSCheck.Checked = False Then
                        'Finish Good Stock
                        cmd.CommandText = "Insert into SemiFGStock values('" & gvqc.GetRowCellValue(i, "SFID") & "','" & dtinspection.Text & "','" & gvqc.GetRowCellValue(i, "Batch_NO") & "','Inward'," & gvqc.GetRowCellValue(i, "QC_No") & ",0,0," & gvqc.GetRowCellValue(i, "QC_No") & ",'" & strCY.Trim & "')"
                        cmd.ExecuteNonQuery()
                    End If
                Next
                cmd.Transaction.Commit()
                cmd.Dispose()
            ElseIf strcheck = "Edit" Then
                If chkSCheck.Checked = True And dtST_Check.Text = "" Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("You have to give Sterilization Check Date", "Sterilization Check Date", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                cmd = New OleDb.OleDbCommand
                cmd.CommandText = "Update SEMI_finishgoods_qcmaster set PKG_VI_NO ='" & txtPackingVINo.Text & "',PKG_VI_DATE='" & dtPackingVI.Text & "', VI_Date ='" & dtinspection.Text & "',ST_CHECK =" & chkSCheck.Checked & ", ST_DATE =" & IIf(dtST_Check.Text = "", "Null", "'" & dtST_Check.Text & "'") & " where SFGVI_NO= '" & txtVI_No.Text & "' and SR_No =" & txtSrNo.Text   '& "' and CY ='" & strCY.Trim & "'"
                cmd.Connection = conn
                cmd.Transaction = conn.BeginTransaction
                cmd.ExecuteNonQuery()
                cmd.CommandText = "delete from SEMI_FinishGoods_QCDetail where SFGVI_NO = '" & txtVI_No.Text & "'" ' and CY ='" & strCY.Trim & "'"
                cmd.Connection = conn
                cmd.ExecuteNonQuery()

                For i As Int16 = 0 To gvqc.RowCount - 1
                    'cmd.CommandText = "insert into SEMI_FinishGoods_QCDetail values('" & txtVI_No.Text & "','" & gvqc.GetRowCellValue(i, "SFID") & "','" & gvqc.GetRowCellValue(i, "Dimension_check") & "'," & gvqc.GetRowCellValue(i, "Inspected_No") & "," & gvqc.GetRowCellValue(i, "QC_No") & "," & gvqc.GetRowCellValue(i, "Reject_Qty") & ",'" & gvqc.GetRowCellValue(i, "Reason") & "','" & gvqc.GetRowCellValue(i, "MIS_NO") & "','" & gvqc.GetRowCellValue(i, "SFGVI_NO") & "','" & strCY.Trim & "')"
                    cmd.CommandText = "insert into SEMI_FinishGoods_QCDetail values('" & txtVI_No.Text & "','" & gvqc.GetRowCellValue(i, "SFID") & "','" & gvqc.GetRowCellValue(i, "Dimension_check") & "'," & gvqc.GetRowCellValue(i, "Inspected_No") & "," & gvqc.GetRowCellValue(i, "QC_No") & "," & gvqc.GetRowCellValue(i, "Reject_Qty") & ",'" & gvqc.GetRowCellValue(i, "Reason") & "','" & gvqc.GetRowCellValue(i, "MIS_NO") & "','" & gvqc.GetRowCellValue(i, "SFGVI_NO") & "','" & strCY.Trim & _
                       "','" & dtMfgDate.DateTime & "','" & dtExpDate.DateTime & "')"
                    cmd.Connection = conn
                    cmd.ExecuteNonQuery()

                    If chkSCheck.Checked = True And dtST_Check.Text <> "" And blnSterilize = True Then
                        Dim strCount As String
                        cmd.CommandText = "Select count(*) from SemiFGStock where SFID ='" & gvqc.GetRowCellValue(i, "SFID") & "' and  SFGVI_NO ='" & gvqc.GetRowCellValue(i, "SFGVI_NO") & "' and Type ='Inward' and Received_Qty =" & gvqc.GetRowCellValue(i, "QC_No") & " and CY ='" & strCY.Trim & "'"
                        strCount = cmd.ExecuteScalar
                        If strCount = 0 Then
                            'Finish Good Stock
                            cmd.CommandText = "Insert into SemiFGStock values('" & gvqc.GetRowCellValue(i, "SFID") & "','" & dtST_Check.Text & "','" & gvqc.GetRowCellValue(i, "SFGVI_NO") & "','Inward'," & gvqc.GetRowCellValue(i, "QC_No") & ",0,0," & gvqc.GetRowCellValue(i, "QC_No") & ",'" & strCY.Trim & "')"
                            cmd.ExecuteNonQuery()
                        End If
                    ElseIf chkSCheck.Checked = False And blnSterilize = True Then
                        Dim strCount As String
                        cmd.CommandText = "Select count(*) from SemiFGStock where SFID ='" & gvqc.GetRowCellValue(i, "SFID") & "' and  SFGVI_NO ='" & gvqc.GetRowCellValue(i, "SFGVI_NO") & "' and Type ='Inward' and Received_Qty =" & gvqc.GetRowCellValue(i, "QC_No") & " and CY ='" & strCY.Trim & "'"
                        strCount = cmd.ExecuteScalar
                        If strCount = 0 Then
                            'Finish Good Stock
                            cmd.CommandText = "Insert into SemiFGStock values('" & gvqc.GetRowCellValue(i, "SFID") & "','" & dtinspection.Text & "','" & gvqc.GetRowCellValue(i, "SFGVI_NO") & "','Inward'," & gvqc.GetRowCellValue(i, "QC_No") & ",0,0," & gvqc.GetRowCellValue(i, "QC_No") & ",'" & strCY.Trim & "')"
                            cmd.ExecuteNonQuery()
                        End If
                    ElseIf chkSCheck.Checked = False Then
                        cmd.CommandText = "Insert into SemiFGStock values('" & gvqc.GetRowCellValue(i, "SFID") & "','" & dtinspection.Text & "','" & gvqc.GetRowCellValue(i, "SFGVI_NO") & "','Inward'," & gvqc.GetRowCellValue(i, "QC_No") & ",0,0," & gvqc.GetRowCellValue(i, "QC_No") & ",'" & strCY.Trim & "')"
                        cmd.ExecuteNonQuery()
                    End If
                Next
                For i As Integer = 0 To arrFID.Count - 1
                    cmd.CommandText = "Delete from SemiFGStock where SFID ='" & arrFID.Item(i).ToString & "' and SFGVI_NO ='" & arrBatchNo.Item(i) & "' and Type = 'Inward' and Received_Qty = " & arrQC_No.Item(i)     '& " and CY ='" & strCY.Trim & "'"
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

    Private Sub txtVI_No_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtVI_No.Validating
        Try
            If strcheck = "Add" Then
                Dim str As String
                str = IsDuplicate("select count(SFGVI_NO) from SEMI_finishgoods_qcmaster where SFGVI_NO ='" & txtVI_No.Text & "' and CY ='" & strCY.Trim & "'")
                If str = True Then
                    MessageBox.Show("This Visual Inspection Number already exist", "Duplicate Value Error", MessageBoxButtons.OK)
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
                If Val(txtrejqty.Text) = 0 Then
                    cmbreason.Properties.ReadOnly = True
                End If
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

    Private Sub dtST_Check_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtST_Check.Validating
        Try
            If chkSCheck.Checked = False Then
                DevExpress.XtraEditors.XtraMessageBox.Show("You can not enter sterilization date untile you have selected sterilization required")
                dtST_Check.EditValue = ""
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub txtVI_No_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVI_No.EditValueChanged

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

    Private Sub cmbMIS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMIS.SelectedIndexChanged
        Try
            If cmbMIS.Text <> "" Then
                Dim strSql As String
                strSql = "Select SFGID FROM SEMI_Material_Issue_Master " _
                & " WHERE (((SEMI_Material_Issue_Master.MIS_NO)='" & cmbMIS.Text & "'));"

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
                    strSql = "SELECT (SEMI_Material_Issue_Master.SFG_QTY - Sum(SEMI_FinishGoods_QCDetail.Inspected_No)) AS SumOfInspected_No " _
                        & " FROM SEMI_Material_Issue_Master INNER JOIN SEMI_FinishGoods_QCDetail ON SEMI_Material_Issue_Master.MIS_NO = SEMI_FinishGoods_QCDetail.MIS_NO " _
                        & " WHERE(((SEMI_Material_Issue_Master.MIS_NO) = '" & cmbMIS.Text & "')) GROUP BY SEMI_Material_Issue_Master.SFG_QTY;"
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
End Class

               