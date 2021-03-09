Public Class frmQC
    Inherits DevExpress.XtraEditors.XtraForm

    Dim cmd As OleDb.OleDbCommand
    Dim dr As OleDb.OleDbDataReader
    Public strcheck As String
    Dim dt As New DataTable
    Dim dblPOQTY As Double
    Public strUnitId As String
    Friend WithEvents cmdAddItem As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents cmdsave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdclose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblVI As System.Windows.Forms.Label
    Friend WithEvents txtVI_No As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grpqc As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lblLotno As System.Windows.Forms.Label
    Friend WithEvents dtinspection As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtinspecno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblrejecqty As System.Windows.Forms.Label
    Friend WithEvents lblinspecno As System.Windows.Forms.Label
    Friend WithEvents txtqcno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblqcno As System.Windows.Forms.Label
    Friend WithEvents gdqc As DevExpress.XtraGrid.GridControl
    Friend WithEvents cmbRMItem As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblRaw As System.Windows.Forms.Label
    Friend WithEvents lbltcno As System.Windows.Forms.Label
    Friend WithEvents txtrejqty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtrcvd As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gvqc As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmbreason As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents pnlQCDetail As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RGInscheck As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPONo As System.Windows.Forms.Label
    Friend WithEvents cmblotno As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lkupItemName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblDrCheckno As System.Windows.Forms.Label
    Friend WithEvents cmbPONo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtTCNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSrNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSuppName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtChallanNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtChallanDt As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtDr_Check As DevExpress.XtraEditors.TextEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.grpqc = New DevExpress.XtraEditors.GroupControl
        Me.txtSrNo = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnReport = New DevExpress.XtraEditors.SimpleButton
        Me.dtinspection = New DevExpress.XtraEditors.DateEdit
        Me.lbldate = New System.Windows.Forms.Label
        Me.cmdsave = New DevExpress.XtraEditors.SimpleButton
        Me.cmdclose = New DevExpress.XtraEditors.SimpleButton
        Me.pnlQCDetail = New DevExpress.XtraEditors.PanelControl
        Me.dtChallanDt = New DevExpress.XtraEditors.DateEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtChallanNo = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTCNo = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbPONo = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtDr_Check = New DevExpress.XtraEditors.TextEdit
        Me.lblDrCheckno = New System.Windows.Forms.Label
        Me.txtSuppName = New DevExpress.XtraEditors.TextEdit
        Me.lkupItemName = New DevExpress.XtraEditors.LookUpEdit
        Me.lblPONo = New System.Windows.Forms.Label
        Me.RGInscheck = New DevExpress.XtraEditors.RadioGroup
        Me.cmbreason = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtinspecno = New DevExpress.XtraEditors.TextEdit
        Me.lblrejecqty = New System.Windows.Forms.Label
        Me.lblinspecno = New System.Windows.Forms.Label
        Me.txtqcno = New DevExpress.XtraEditors.TextEdit
        Me.lblqcno = New System.Windows.Forms.Label
        Me.gdqc = New DevExpress.XtraGrid.GridControl
        Me.gvqc = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmbRMItem = New System.Windows.Forms.ComboBox
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.lblRaw = New System.Windows.Forms.Label
        Me.lbltcno = New System.Windows.Forms.Label
        Me.txtrejqty = New DevExpress.XtraEditors.TextEdit
        Me.txtrcvd = New DevExpress.XtraEditors.TextEdit
        Me.lblLotno = New System.Windows.Forms.Label
        Me.cmblotno = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblVI = New System.Windows.Forms.Label
        Me.txtVI_No = New DevExpress.XtraEditors.TextEdit
        Me.cmdAddItem = New DevExpress.XtraEditors.SimpleButton
        CType(Me.grpqc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpqc.SuspendLayout()
        CType(Me.txtSrNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtinspection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlQCDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlQCDetail.SuspendLayout()
        CType(Me.dtChallanDt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChallanNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTCNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPONo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDr_Check.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSuppName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupItemName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RGInscheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbreason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtinspecno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtqcno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdqc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvqc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrejqty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtrcvd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmblotno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVI_No.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpqc
        '
        Me.grpqc.Controls.Add(Me.txtSrNo)
        Me.grpqc.Controls.Add(Me.Label4)
        Me.grpqc.Controls.Add(Me.btnReport)
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
        Me.grpqc.Size = New System.Drawing.Size(546, 496)
        Me.grpqc.TabIndex = 0
        Me.grpqc.Text = "Quality Control "
        '
        'txtSrNo
        '
        Me.txtSrNo.EditValue = ""
        Me.txtSrNo.Location = New System.Drawing.Point(112, 32)
        Me.txtSrNo.Name = "txtSrNo"
        '
        '
        '
        Me.txtSrNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSrNo.Properties.Appearance.Options.UseFont = True
        Me.txtSrNo.Properties.ReadOnly = True
        Me.txtSrNo.Size = New System.Drawing.Size(152, 22)
        Me.txtSrNo.TabIndex = 46
        Me.txtSrNo.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Serial No.:"
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(16, 464)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(75, 25)
        Me.btnReport.TabIndex = 44
        Me.btnReport.Text = "&Report"
        '
        'dtinspection
        '
        Me.dtinspection.EditValue = Nothing
        Me.dtinspection.Location = New System.Drawing.Point(352, 56)
        Me.dtinspection.Name = "dtinspection"
        '
        '
        '
        Me.dtinspection.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtinspection.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtinspection.Size = New System.Drawing.Size(88, 20)
        Me.dtinspection.TabIndex = 2
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(288, 56)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(39, 16)
        Me.lbldate.TabIndex = 30
        Me.lbldate.Text = "Date:"
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(416, 464)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(56, 25)
        Me.cmdsave.TabIndex = 16
        Me.cmdsave.Text = "&Save"
        '
        'cmdclose
        '
        Me.cmdclose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdclose.Location = New System.Drawing.Point(480, 464)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(56, 25)
        Me.cmdclose.TabIndex = 17
        Me.cmdclose.Text = "&Close"
        '
        'pnlQCDetail
        '
        Me.pnlQCDetail.Controls.Add(Me.cmdAddItem)
        Me.pnlQCDetail.Controls.Add(Me.dtChallanDt)
        Me.pnlQCDetail.Controls.Add(Me.Label6)
        Me.pnlQCDetail.Controls.Add(Me.txtChallanNo)
        Me.pnlQCDetail.Controls.Add(Me.Label5)
        Me.pnlQCDetail.Controls.Add(Me.txtTCNo)
        Me.pnlQCDetail.Controls.Add(Me.Label3)
        Me.pnlQCDetail.Controls.Add(Me.cmbPONo)
        Me.pnlQCDetail.Controls.Add(Me.txtDr_Check)
        Me.pnlQCDetail.Controls.Add(Me.lblDrCheckno)
        Me.pnlQCDetail.Controls.Add(Me.txtSuppName)
        Me.pnlQCDetail.Controls.Add(Me.lkupItemName)
        Me.pnlQCDetail.Controls.Add(Me.lblPONo)
        Me.pnlQCDetail.Controls.Add(Me.RGInscheck)
        Me.pnlQCDetail.Controls.Add(Me.cmbreason)
        Me.pnlQCDetail.Controls.Add(Me.Label2)
        Me.pnlQCDetail.Controls.Add(Me.txtinspecno)
        Me.pnlQCDetail.Controls.Add(Me.lblrejecqty)
        Me.pnlQCDetail.Controls.Add(Me.lblinspecno)
        Me.pnlQCDetail.Controls.Add(Me.txtqcno)
        Me.pnlQCDetail.Controls.Add(Me.lblqcno)
        Me.pnlQCDetail.Controls.Add(Me.gdqc)
        Me.pnlQCDetail.Controls.Add(Me.cmbRMItem)
        Me.pnlQCDetail.Controls.Add(Me.cmdAdd)
        Me.pnlQCDetail.Controls.Add(Me.cmdDelete)
        Me.pnlQCDetail.Controls.Add(Me.lblRaw)
        Me.pnlQCDetail.Controls.Add(Me.lbltcno)
        Me.pnlQCDetail.Controls.Add(Me.txtrejqty)
        Me.pnlQCDetail.Controls.Add(Me.txtrcvd)
        Me.pnlQCDetail.Controls.Add(Me.lblLotno)
        Me.pnlQCDetail.Controls.Add(Me.cmblotno)
        Me.pnlQCDetail.Controls.Add(Me.Label1)
        Me.pnlQCDetail.Location = New System.Drawing.Point(8, 88)
        Me.pnlQCDetail.Name = "pnlQCDetail"
        Me.pnlQCDetail.Size = New System.Drawing.Size(528, 368)
        Me.pnlQCDetail.TabIndex = 3
        Me.pnlQCDetail.Text = "PanelControl1"
        '
        'dtChallanDt
        '
        Me.dtChallanDt.EditValue = Nothing
        Me.dtChallanDt.Location = New System.Drawing.Point(312, 144)
        Me.dtChallanDt.Name = "dtChallanDt"
        '
        '
        '
        Me.dtChallanDt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtChallanDt.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtChallanDt.Size = New System.Drawing.Size(88, 20)
        Me.dtChallanDt.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(216, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Challan Date:"
        '
        'txtChallanNo
        '
        Me.txtChallanNo.EditValue = ""
        Me.txtChallanNo.Location = New System.Drawing.Point(104, 144)
        Me.txtChallanNo.Name = "txtChallanNo"
        '
        '
        '
        Me.txtChallanNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChallanNo.Properties.Appearance.Options.UseFont = True
        Me.txtChallanNo.Size = New System.Drawing.Size(104, 22)
        Me.txtChallanNo.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Challan No:"
        '
        'txtTCNo
        '
        Me.txtTCNo.EditValue = ""
        Me.txtTCNo.Location = New System.Drawing.Point(344, 118)
        Me.txtTCNo.Name = "txtTCNo"
        '
        '
        '
        Me.txtTCNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTCNo.Properties.Appearance.Options.UseFont = True
        Me.txtTCNo.Size = New System.Drawing.Size(48, 22)
        Me.txtTCNo.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(288, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "T.C.No.:"
        '
        'cmbPONo
        '
        Me.cmbPONo.EditValue = ""
        Me.cmbPONo.Location = New System.Drawing.Point(312, 12)
        Me.cmbPONo.Name = "cmbPONo"
        '
        '
        '
        Me.cmbPONo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPONo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbPONo.Size = New System.Drawing.Size(120, 20)
        Me.cmbPONo.TabIndex = 5
        '
        'txtDr_Check
        '
        Me.txtDr_Check.EditValue = ""
        Me.txtDr_Check.Location = New System.Drawing.Point(104, 64)
        Me.txtDr_Check.Name = "txtDr_Check"
        '
        '
        '
        Me.txtDr_Check.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDr_Check.Properties.Appearance.Options.UseFont = True
        Me.txtDr_Check.Size = New System.Drawing.Size(104, 22)
        Me.txtDr_Check.TabIndex = 7
        '
        'lblDrCheckno
        '
        Me.lblDrCheckno.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrCheckno.Location = New System.Drawing.Point(9, 64)
        Me.lblDrCheckno.Name = "lblDrCheckno"
        Me.lblDrCheckno.Size = New System.Drawing.Size(88, 32)
        Me.lblDrCheckno.TabIndex = 45
        Me.lblDrCheckno.Text = "Drawing && Specification check no"
        '
        'txtSuppName
        '
        Me.txtSuppName.EditValue = ""
        Me.txtSuppName.Location = New System.Drawing.Point(312, 12)
        Me.txtSuppName.Name = "txtSuppName"
        '
        '
        '
        Me.txtSuppName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuppName.Properties.Appearance.Options.UseFont = True
        Me.txtSuppName.Size = New System.Drawing.Size(120, 22)
        Me.txtSuppName.TabIndex = 6
        Me.txtSuppName.Visible = False
        '
        'lkupItemName
        '
        Me.lkupItemName.EditValue = ""
        Me.lkupItemName.Location = New System.Drawing.Point(104, 38)
        Me.lkupItemName.Name = "lkupItemName"
        '
        '
        '
        Me.lkupItemName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupItemName.Properties.NullText = ""
        Me.lkupItemName.Size = New System.Drawing.Size(328, 20)
        Me.lkupItemName.TabIndex = 6
        '
        'lblPONo
        '
        Me.lblPONo.AutoSize = True
        Me.lblPONo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPONo.Location = New System.Drawing.Point(232, 11)
        Me.lblPONo.Name = "lblPONo"
        Me.lblPONo.Size = New System.Drawing.Size(52, 16)
        Me.lblPONo.TabIndex = 41
        Me.lblPONo.Text = "PO No.:"
        '
        'RGInscheck
        '
        Me.RGInscheck.EditValue = "P"
        Me.RGInscheck.Location = New System.Drawing.Point(104, 8)
        Me.RGInscheck.Name = "RGInscheck"
        '
        '
        '
        Me.RGInscheck.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RGInscheck.Properties.Appearance.Options.UseBackColor = True
        Me.RGInscheck.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RGInscheck.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.RGInscheck.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("P", "PO "), New DevExpress.XtraEditors.Controls.RadioGroupItem("V", "Verbal")})
        Me.RGInscheck.Size = New System.Drawing.Size(120, 32)
        Me.RGInscheck.TabIndex = 4
        '
        'cmbreason
        '
        Me.cmbreason.EditValue = ""
        Me.cmbreason.Location = New System.Drawing.Point(104, 118)
        Me.cmbreason.Name = "cmbreason"
        '
        '
        '
        Me.cmbreason.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbreason.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbreason.Size = New System.Drawing.Size(176, 20)
        Me.cmbreason.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Reason"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtinspecno
        '
        Me.txtinspecno.EditValue = ""
        Me.txtinspecno.Location = New System.Drawing.Point(312, 64)
        Me.txtinspecno.Name = "txtinspecno"
        '
        '
        '
        Me.txtinspecno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinspecno.Properties.Appearance.Options.UseFont = True
        Me.txtinspecno.Size = New System.Drawing.Size(120, 22)
        Me.txtinspecno.TabIndex = 9
        '
        'lblrejecqty
        '
        Me.lblrejecqty.AutoSize = True
        Me.lblrejecqty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrejecqty.Location = New System.Drawing.Point(216, 96)
        Me.lblrejecqty.Name = "lblrejecqty"
        Me.lblrejecqty.Size = New System.Drawing.Size(85, 16)
        Me.lblrejecqty.TabIndex = 34
        Me.lblrejecqty.Text = "Rejected Qty."
        '
        'lblinspecno
        '
        Me.lblinspecno.AutoSize = True
        Me.lblinspecno.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinspecno.Location = New System.Drawing.Point(216, 64)
        Me.lblinspecno.Name = "lblinspecno"
        Me.lblinspecno.Size = New System.Drawing.Size(91, 16)
        Me.lblinspecno.TabIndex = 26
        Me.lblinspecno.Text = "Inspected Qty:"
        '
        'txtqcno
        '
        Me.txtqcno.EditValue = ""
        Me.txtqcno.Location = New System.Drawing.Point(104, 90)
        Me.txtqcno.Name = "txtqcno"
        '
        '
        '
        Me.txtqcno.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqcno.Properties.Appearance.Options.UseFont = True
        Me.txtqcno.Size = New System.Drawing.Size(104, 22)
        Me.txtqcno.TabIndex = 10
        '
        'lblqcno
        '
        Me.lblqcno.AutoSize = True
        Me.lblqcno.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqcno.Location = New System.Drawing.Point(48, 96)
        Me.lblqcno.Name = "lblqcno"
        Me.lblqcno.Size = New System.Drawing.Size(50, 16)
        Me.lblqcno.TabIndex = 24
        Me.lblqcno.Text = "QC OK:"
        '
        'gdqc
        '
        '
        '
        '
        Me.gdqc.EmbeddedNavigator.Name = ""
        Me.gdqc.Font = New System.Drawing.Font("Tahoma", 8.25!)
        GridLevelNode2.RelationName = "Level1"
        Me.gdqc.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.gdqc.Location = New System.Drawing.Point(8, 176)
        Me.gdqc.MainView = Me.gvqc
        Me.gdqc.Name = "gdqc"
        Me.gdqc.Size = New System.Drawing.Size(512, 184)
        Me.gdqc.TabIndex = 15
        Me.gdqc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvqc})
        '
        'gvqc
        '
        Me.gvqc.GridControl = Me.gdqc
        Me.gvqc.Name = "gvqc"
        Me.gvqc.OptionsBehavior.Editable = False
        Me.gvqc.OptionsView.ShowGroupPanel = False
        '
        'cmbRMItem
        '
        Me.cmbRMItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRMItem.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.cmbRMItem.ItemHeight = 13
        Me.cmbRMItem.Location = New System.Drawing.Point(504, 16)
        Me.cmbRMItem.Name = "cmbRMItem"
        Me.cmbRMItem.Size = New System.Drawing.Size(152, 21)
        Me.cmbRMItem.TabIndex = 4
        Me.cmbRMItem.Visible = False
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(408, 144)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(56, 25)
        Me.cmdAdd.TabIndex = 16
        Me.cmdAdd.Text = "&Add"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(464, 144)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(56, 25)
        Me.cmdDelete.TabIndex = 17
        Me.cmdDelete.Text = "&Delete"
        '
        'lblRaw
        '
        Me.lblRaw.AutoSize = True
        Me.lblRaw.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaw.Location = New System.Drawing.Point(60, 40)
        Me.lblRaw.Name = "lblRaw"
        Me.lblRaw.Size = New System.Drawing.Size(39, 16)
        Me.lblRaw.TabIndex = 21
        Me.lblRaw.Text = "Item:"
        '
        'lbltcno
        '
        Me.lbltcno.AutoSize = True
        Me.lbltcno.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltcno.Location = New System.Drawing.Point(592, 88)
        Me.lbltcno.Name = "lbltcno"
        Me.lbltcno.Size = New System.Drawing.Size(63, 16)
        Me.lbltcno.TabIndex = 34
        Me.lbltcno.Text = "Rcvd No.:"
        '
        'txtrejqty
        '
        Me.txtrejqty.EditValue = "0"
        Me.txtrejqty.Location = New System.Drawing.Point(312, 90)
        Me.txtrejqty.Name = "txtrejqty"
        '
        '
        '
        Me.txtrejqty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrejqty.Properties.Appearance.Options.UseFont = True
        Me.txtrejqty.Properties.ReadOnly = True
        Me.txtrejqty.Size = New System.Drawing.Size(120, 22)
        Me.txtrejqty.TabIndex = 11
        '
        'txtrcvd
        '
        Me.txtrcvd.EditValue = ""
        Me.txtrcvd.Location = New System.Drawing.Point(536, 80)
        Me.txtrcvd.Name = "txtrcvd"
        '
        '
        '
        Me.txtrcvd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrcvd.Properties.Appearance.Options.UseFont = True
        Me.txtrcvd.Size = New System.Drawing.Size(40, 22)
        Me.txtrcvd.TabIndex = 8
        '
        'lblLotno
        '
        Me.lblLotno.AutoSize = True
        Me.lblLotno.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLotno.Location = New System.Drawing.Point(440, 40)
        Me.lblLotno.Name = "lblLotno"
        Me.lblLotno.Size = New System.Drawing.Size(59, 16)
        Me.lblLotno.TabIndex = 2
        Me.lblLotno.Text = "LOT No.:"
        Me.lblLotno.Visible = False
        '
        'cmblotno
        '
        Me.cmblotno.EditValue = ""
        Me.cmblotno.Location = New System.Drawing.Point(504, 40)
        Me.cmblotno.Name = "cmblotno"
        '
        '
        '
        Me.cmblotno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmblotno.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmblotno.Size = New System.Drawing.Size(152, 20)
        Me.cmblotno.TabIndex = 3
        Me.cmblotno.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Inspection Aga."
        '
        'lblVI
        '
        Me.lblVI.AutoSize = True
        Me.lblVI.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVI.Location = New System.Drawing.Point(16, 56)
        Me.lblVI.Name = "lblVI"
        Me.lblVI.Size = New System.Drawing.Size(75, 16)
        Me.lblVI.TabIndex = 1
        Me.lblVI.Text = "R.M.V.I.NO."
        '
        'txtVI_No
        '
        Me.txtVI_No.EditValue = ""
        Me.txtVI_No.Location = New System.Drawing.Point(112, 56)
        Me.txtVI_No.Name = "txtVI_No"
        '
        '
        '
        Me.txtVI_No.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVI_No.Properties.Appearance.Options.UseFont = True
        Me.txtVI_No.Size = New System.Drawing.Size(152, 22)
        Me.txtVI_No.TabIndex = 1
        '
        'cmdAddItem
        '
        Me.cmdAddItem.Location = New System.Drawing.Point(437, 38)
        Me.cmdAddItem.Name = "cmdAddItem"
        Me.cmdAddItem.Size = New System.Drawing.Size(83, 25)
        Me.cmdAddItem.TabIndex = 51
        Me.cmdAddItem.Text = "&New Item"
        '
        'frmQC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(546, 496)
        Me.Controls.Add(Me.grpqc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quality check"
        CType(Me.grpqc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpqc.ResumeLayout(False)
        Me.grpqc.PerformLayout()
        CType(Me.txtSrNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtinspection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlQCDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlQCDetail.ResumeLayout(False)
        Me.pnlQCDetail.PerformLayout()
        CType(Me.dtChallanDt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChallanNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTCNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPONo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDr_Check.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSuppName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupItemName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RGInscheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbreason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtinspecno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtqcno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdqc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvqc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrejqty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtrcvd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmblotno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVI_No.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    
    Private Sub frmQC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtinspection.DateTime = Today
        Try
            'dt.Columns.Add("Lot_No", System.Type.GetType("System.String"))
            dt.Columns.Add("ItemID", System.Type.GetType("System.String"))
            dt.Columns.Add("ItemName", System.Type.GetType("System.String"))
            'dt.Columns.Add("Date", System.Type.GetType("System.String"))
            dt.Columns.Add("DR_CHECK", System.Type.GetType("System.String"))
            dt.Columns.Add("Inspected No", System.Type.GetType("System.String"))
            dt.Columns.Add("QC Ok", System.Type.GetType("System.String"))
            dt.Columns.Add("Rejected Qty", System.Type.GetType("System.String"))
            dt.Columns.Add("Accepted Qty", System.Type.GetType("System.String"))
            dt.Columns.Add("Reason", System.Type.GetType("System.String"))
            dt.Columns.Add("QC Type", System.Type.GetType("System.String"))
            dt.Columns.Add("PO No", System.Type.GetType("System.String"))
            dt.Columns.Add("TCNO", System.Type.GetType("System.String"))
            dt.Columns.Add("Challan No", System.Type.GetType("System.String"))
            dt.Columns.Add("Challan Date", System.Type.GetType("System.String"))
            dt.Columns.Add("Supplier", System.Type.GetType("System.String"))

            ' FillCombox("Purchase_detail", "LOT_No", cmblotno)
            FillCombox("Reason", "Reason", cmbreason)
            If strcheck = "Add" Then

                pnlQCDetail.Enabled = False
                cmdsave.Enabled = False
                cmdclose.Enabled = False
                btnReport.Visible = False
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                cmd.CommandText = "select max(Sr_No) from QCMaster where CY ='" & strCY.Trim & "'"
                If IsDBNull(cmd.ExecuteScalar) = True Then
                    txtSrNo.Text = 1
                Else
                    txtSrNo.Text = Val(cmd.ExecuteScalar + 1)
                End If
                cmd.Dispose()
                dtinspection.EditValue = Today
            End If


            If strcheck = "Edit" Then
                txtVI_No.Properties.ReadOnly = True

                cmblotno.Properties.ReadOnly = True
                txtqcno.Properties.ReadOnly = True
                txtinspecno.Properties.ReadOnly = True
                txtrejqty.Properties.ReadOnly = True
                txtrcvd.Properties.ReadOnly = True
                cmbreason.Properties.ReadOnly = True

                cmd = New OleDb.OleDbCommand
                cmd.CommandText = "select * from QCMaster where RMVI_NO= '" & ModMain.strgridid & "'" ' and CY ='" & strCY.Trim & "'"
                cmd.Connection = conn
                dr = cmd.ExecuteReader
                dr.Read()
                bind_data()
                dr.Close()
                cmd.Dispose()
                cmdDelete.Enabled = False
            End If
            cmbPONo.Properties.ReadOnly = False
            FillCombox("Purchase_Detail", "Distinct(PO_No)", cmbPONo)
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub bind_data()
        Try

            'SrNo
            If IsDBNull(dr("SR_No")) = True Then
                txtSrNo.Text = ""
            Else
                txtSrNo.Text = dr("SR_NO")
            End If

            'IME_No
            If IsDBNull(dr("RMVI_NO")) = True Then
                txtVI_No.Text = ""
            Else
                txtVI_No.Text = dr("RMVI_NO").ToString

            End If

            If IsDBNull(dr("Date")) = True Then
                dtinspection.EditValue = ""
            Else
                dtinspection.EditValue = dr("date").ToString

            End If

            dr.Close()

            'code to display record in detail sec in edit mode

            'adp = New OleDb.OleDbDataAdapter("SELECT  QCDetail.Rid as ItemId, RMItemMaster.RMItemName as ItemName, " _
            '        & " QCDetail.Inspected_No as [Inspected Qty] , QCDetail.QC_No,QCDetail.QC_Type,QCDetail.PO_No, " _
            '        & " QCDetail.Reject_Qty as [Rejected Qty], QCDetail.Accepted_Qty as [Accepted Qty], QCDetail.Reason,  QCDetail.RMVI_NO " _
            '        & " FROM QCDetail INNER JOIN RMItemMaster ON QCDetail.RMItemId = RMItemMaster.Rid " _
            '        & " WHERE (((QCDetail.RMVI_NO)= '" & ModMain.strgridid & "'))", conn)


            adp = New OleDb.OleDbDataAdapter("SELECT QCDetail.Rid as ItemId, RMItemMaster.RMItemName as ItemName, " _
                & " QCDetail.Inspected_No as [Inspected Qty], QCDetail.QC_No as [QC Ok], QCDetail.QC_Type as [QC Type], " _
                & " QCDetail.PO_NO as [PO No], QCDetail.Reject_Qty as [Rejected Qty] , QCDetail.Accepted_Qty as [Accepted Qty], " _
                & " QCDetail.Reason, QCDetail.RMVI_NO,QCDetail.TCNO ,QCDetail.Challan_No As [Challan No],QCDetail.Challan_Dt as [Challan Date] ,QCDetail.Supp_Name as Supplier " _
                & " FROM QCDetail INNER JOIN RMItemMaster ON QCDetail.RID = RMItemMaster.Rid " _
                & " WHERE (((QCDetail.RMVI_NO)='" & ModMain.strgridid & "')) ", conn)  'and QCDetail.CY ='" & strCY.Trim & "'"

            adp.Fill(dt)
            gdqc.DataSource = dt
            gvqc.Columns("ItemID").Visible = False
            gvqc.Columns("PO No").Visible = False
            gvqc.Columns("QC Type").Visible = False
            gvqc.Columns("Accepted Qty").Visible = False
            gvqc.Columns("Challan Date").Visible = False

        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try

    End Sub



    Private Sub cmblotno_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmblotno.Validating
        'cmd = New OleDb.OleDbCommand
        'Fillcmb("SELECT  RMItemMaster.Rid, RMItemMaster.RMItemName, Purchase_Detail.Lot_No " _
        '        & "FROM Purchase_Detail INNER JOIN RMItemMaster ON Purchase_Detail.RMItemID = RMItemMaster.Rid " _
        '        & "WHERE (((Purchase_Detail.Lot_No)= '" & cmblotno.Text & "'))", "RMItemMaster", "RID", "RMItemName", cmbRMItem)

    End Sub


    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click

        Dim dr As DataRow
        Try
            Dim blnDup As Boolean = False
            For i As Int16 = 0 To gvqc.RowCount - 1
                If gvqc.GetRowCellValue(i, gvqc.Columns(2)).ToString = cmbRMItem.Text Then
                    blnDup = True
                    Exit For
                End If
            Next
            If blnDup = False Then
                dr = dt.NewRow

                dr.Item("ItemID") = lkupItemName.EditValue
                dr.Item("ItemName") = lkupItemName.Text
                dr.Item("DR_CHECK") = txtDr_Check.Text
                dr.Item("Inspected No") = txtinspecno.Text
                dr.Item("QC Ok") = txtqcno.Text
                dr.Item("Rejected Qty") = txtrejqty.Text
                dr.Item("Accepted Qty") = txtqcno.Text                      'Val(dblPOQTY) - Val(txtrejqty.Text)
                'MsgBox(Val(strresult) - Val(txtrejqty.Text))
                dr.Item("Reason") = cmbreason.Text
                dr.Item("QC Type") = RGInscheck.EditValue
                dr.Item("PO No") = cmbPONo.Text
                dr.Item("TCNO") = txtTCNo.Text
                dr.Item("Challan No") = txtChallanNo.Text
                dr.Item("Challan Date") = dtChallanDt.Text
                dr.Item("Supplier") = txtSuppName.Text

                dt.Rows.Add(dr)
                gdqc.DataSource = dt
                gvqc.Columns("ItemID").Visible = False
                gvqc.Columns("DR_CHECK").Visible = False
                gvqc.Columns("PO No").Visible = False
                gvqc.Columns("QC Type").Visible = False
                gvqc.Columns("Accepted Qty").Visible = False
                gvqc.Columns("Challan Date").Visible = False

                If strcheck = "Edit" Then
                    cmblotno.Properties.ReadOnly = True
                    txtqcno.Properties.ReadOnly = True
                    txtinspecno.Properties.ReadOnly = True
                    txtrejqty.Properties.ReadOnly = True
                    txtrcvd.Properties.ReadOnly = True
                    cmbreason.Properties.ReadOnly = True
                End If
            End If
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmbRMItem_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbRMItem.Validating
        Try
            cmd = New OleDb.OleDbCommand
            cmd.CommandText = "Select qty from purchase_detail where rmitemname = '" & cmbRMItem.Text & "'"

            cmd.CommandText = "SELECT Purchase_Detail.Qty, RMItemMaster.RMItemName " _
            & "FROM Purchase_Detail INNER JOIN RMItemMaster ON Purchase_Detail.RMItemID = RMItemMaster.Rid " _
            & "WHERE (((RMItemMaster.RMItemName)= '" & cmbRMItem.Text & "'))"
            cmd.Connection = conn

            dblPOQTY = cmd.ExecuteScalar
            cmd.CommandText = "SELECT Purchase_Detail.Qty,purchase_Detal.UnitId, RMItemMaster.RMItemName " _
                        & "FROM Purchase_Detail INNER JOIN RMItemMaster ON Purchase_Detail.RMItemID = RMItemMaster.Rid " _
                        & "WHERE (((RMItemMaster.RMItemName)= '" & cmbRMItem.Text & "'))"

            cmd.Connection = conn
            dr = cmd.ExecuteReader
            dr.Read()
            dblPOQTY = dr(0).ToString
            strUnitId = dr(2).ToString


            cmd.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        Try

            If strcheck = "Add" Then
                cmd = New OleDb.OleDbCommand("insert into QCMaster values ( '" & txtSrNo.Text & "','" & txtVI_No.Text & "','" & dtinspection.Text & "','" & strCY.Trim & "')")
                cmd.Connection = conn
                cmd.Transaction = conn.BeginTransaction
                cmd.ExecuteNonQuery()

                Dim i As Int16
                For i = 0 To gvqc.RowCount - 1
                    cmd.CommandText = "insert into QCDetail values ('" & txtVI_No.Text & "','" & gvqc.GetRowCellValue(i, "ItemID") & "','" & _
                         IIf(IsDBNull(gvqc.GetRowCellValue(i, "DR_CHECK")) = True, "", gvqc.GetRowCellValue(i, "DR_CHECK")) & "'," & _
                         IIf(IsDBNull(gvqc.GetRowCellValue(i, "Inspected No")) = True, 0, gvqc.GetRowCellValue(i, "Inspected No")) & "," & gvqc.GetRowCellValue(i, "QC Ok") & "," & _
                         gvqc.GetRowCellValue(i, "Rejected Qty") & ",'" & gvqc.GetRowCellValue(i, "Accepted Qty") & "','" & _
                         gvqc.GetRowCellValue(i, "Reason") & "','" & gvqc.GetRowCellValue(i, "QC Type") & "','" & gvqc.GetRowCellValue(i, "PO No") & "','" & _
                         gvqc.GetRowCellValue(i, "TCNO") & "','" & gvqc.GetRowCellValue(i, "Challan No") & "','" & gvqc.GetRowCellValue(i, "Challan Date") & "','" & gvqc.GetRowCellValue(i, "Supplier") & "','" & strCY.Trim & "')"
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "Insert into RMStock values ('" & gvqc.GetRowCellValue(i, "ItemID") & "','" & _
                         dtinspection.Text & "','" & txtVI_No.Text & "','Inward'," & gvqc.GetRowCellValue(i, "Accepted Qty") & ",0," & gvqc.GetRowCellValue(i, "Accepted Qty") & ",'" & strCY.Trim & "')"
                    cmd.ExecuteNonQuery()
                Next
                cmd.Transaction.Commit()
                MessageBox.Show("Save Data Successfully in QCDetail")
                btnReport.Visible = True
            ElseIf strcheck = "Edit" Then
                Dim cmddetail As New OleDb.OleDbCommand

                Dim i As Int16
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                cmd.Transaction = conn.BeginTransaction
                cmd.CommandText = "delete from QCDetail where RMVI_No = '" & txtVI_No.Text & "'" ' AND CY='" & strCY.Trim & "'"
                cmd.ExecuteNonQuery()
                For i = 0 To gvqc.RowCount - 1
                    'cmd.CommandText = "insert into QCDetail values ('" & txtVI_No.Text & "','" & gvqc.GetRowCellValue(i, "ItemID") & "','" & _
                    '      gvqc.GetRowCellValue(i, "DR_CHECK") & "'," & _
                    '      gvqc.GetRowCellValue(i, "Inspected No") & "," & gvqc.GetRowCellValue(i, "QC Ok") & "," & _
                    '      gvqc.GetRowCellValue(i, "Rejected Qty") & ",'" & gvqc.GetRowCellValue(i, "Accepted Qty") & "','" & _
                    '      gvqc.GetRowCellValue(i, "Reason") & "','" & gvqc.GetRowCellValue(i, "QC Type") & "','" & gvqc.GetRowCellValue(i, "PO No") & "','" & _
                    '      gvqc.GetRowCellValue(i, "TCNO") & "','" & gvqc.GetRowCellValue(i, "Challan No") & "','" & gvqc.GetRowCellValue(i, "Challan Date") & "','" & gvqc.GetRowCellValue(i, "Supplier") & "','" & strCY.Trim & "')"
                    'cmd.ExecuteNonQuery()


                    Dim dblIsseQty As Double
                    cmd.CommandText = "Select Issue_Qty from RMStock where RMVI_No ='" & txtVI_No.Text & "' and RID ='" & gvqc.GetRowCellValue(i, "ItemID") & "'"
                    dblIsseQty = IIf(IsDBNull(cmd.ExecuteScalar()) = True, 0, cmd.ExecuteScalar)
                    If dblIsseQty > 0 Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("You have issue qty from this RMVI_No so you can not edit this record", "Not Edit", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        cmd.Transaction.Rollback()
                        cmd.Dispose()
                        Exit Sub
                    End If
                    cmd.CommandText = "Delete From RMStock where RMVI_No='" & txtVI_No.Text & "'"
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "insert into QCDetail values ('" & txtVI_No.Text & "','" & gvqc.GetRowCellValue(i, "ItemID") & "','" & _
                         IIf(IsDBNull(gvqc.GetRowCellValue(i, "DR_CHECK")) = True, "", gvqc.GetRowCellValue(i, "DR_CHECK")) & "'," & _
                         IIf(IsDBNull(gvqc.GetRowCellValue(i, "Inspected No")) = True, 0, gvqc.GetRowCellValue(i, "Inspected No")) & "," & gvqc.GetRowCellValue(i, "QC Ok") & "," & _
                         gvqc.GetRowCellValue(i, "Rejected Qty") & ",'" & gvqc.GetRowCellValue(i, "Accepted Qty") & "','" & _
                         gvqc.GetRowCellValue(i, "Reason") & "','" & gvqc.GetRowCellValue(i, "QC Type") & "','" & gvqc.GetRowCellValue(i, "PO No") & "','" & _
                         gvqc.GetRowCellValue(i, "TCNO") & "','" & gvqc.GetRowCellValue(i, "Challan No") & "','" & gvqc.GetRowCellValue(i, "Challan Date") & "','" & gvqc.GetRowCellValue(i, "Supplier") & "','" & strCY.Trim & "')"
                    cmd.ExecuteNonQuery()

                    cmd.CommandText = "Insert into RMStock values ('" & gvqc.GetRowCellValue(i, "ItemID") & "','" & _
                         dtinspection.Text & "','" & txtVI_No.Text & "','Inward'," & gvqc.GetRowCellValue(i, "Accepted Qty") & ",0," & gvqc.GetRowCellValue(i, "Accepted Qty") & ",'" & strCY.Trim & "')"
                    cmd.ExecuteNonQuery()

                Next
                'MsgBox("Record Updated in Qcdetail")
                cmd.Transaction.Commit()
                cmddetail.Dispose()
            End If
            cmd.Dispose()
            Me.Close()
        Catch ex As Exception
            cmd.Transaction.Rollback()
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Me.Close()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If gvqc.GetSelectedRows.Length > 0 Then
                If MessageBox.Show("Are you sure you want to delete this record ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    gvqc.DeleteRow(gvqc.FocusedRowHandle)
                    gvqc.RefreshData()
                End If
            Else
                Exit Sub
            End If
            If strcheck = "Edit" Then
                cmblotno.Properties.ReadOnly = False
                txtqcno.Properties.ReadOnly = False
                txtinspecno.Properties.ReadOnly = False
                txtrejqty.Properties.ReadOnly = False
                txtrcvd.Properties.ReadOnly = False
                cmbreason.Properties.ReadOnly = False
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub txtrejqty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrejqty.KeyPress
        Try
            If strUnitId.ToUpper = "NOS" Then
                e.Handled = IsOnlyNumber(e.KeyChar)
            Else
                e.Handled = IsDecimalNumber(e.KeyChar)
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub dtinspection_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtinspection.GotFocus
        pnlQCDetail.Enabled = True
        cmdsave.Enabled = True
        cmdclose.Enabled = True
    End Sub

    Private Sub RGInscheck_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RGInscheck.SelectedIndexChanged
        Try
            If RGInscheck.SelectedIndex = 0 Then
                cmbPONo.Properties.ReadOnly = False
                lblPONo.Text = "PO NO:"
                FillCombox("Purchase_Detail", "Distinct(PO_No)", cmbPONo)
                txtSuppName.Visible = False
                cmbPONo.Visible = True
            ElseIf RGInscheck.SelectedIndex = 1 Then
                cmbPONo.Properties.Items.Clear()
                lblPONo.Text = "Supplier Name:"
                cmbPONo.Text = ""
                txtSuppName.Visible = True
                cmbPONo.Visible = False
                'lkupItemName.EditValue = ""
                cmbPONo.Properties.ReadOnly = True
                'FillLookup("SELECT RMItemMaster.RMItemName, RMItemMaster.Rid, UnitMaster.UnitName " _
                '      & " FROM RMItemMaster INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID", "RMItem", "Item Name", "ItemID", lkupItemName)
                'FillLookup("select RMItemMaster.Rid, RMItemMaster.RMItemName,RMItemMaster. FROM RMItemMaster
                'Fillcmb("SELECT RMItemMaster.Rid, RMItemMaster.RMItemName FROM RMItemMaster", "RMItemMaster", "RID", "RMItemName", cmbRMItem)
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmbPONo_Validating1(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbPONo.Validating
        'Fillcmb("SELECT RMItemMaster.Rid, RMItemMaster.RMItemName, Purchase_Detail.PO_No " _
        '              & "FROM Purchase_Detail INNER JOIN RMItemMaster ON Purchase_Detail.RMItemID = RMItemMaster.Rid " _
        '              & "WHERE (((Purchase_Detail.PO_No)='" & cmbPONo.Text & "'))", "RMItemMaster", "RID", "RMItemName", cmbRMItem)
        'FillLookup("SELECT RMItemMaster.RMItemName,RMItemMaster.Rid, Purchase_Detail.PO_No " _
        '              & "FROM Purchase_Detail INNER JOIN RMItemMaster ON Purchase_Detail.RMItemID = RMItemMaster.Rid " _
        '              & "WHERE (((Purchase_Detail.PO_No)='" & cmbPONo.Text & "'))", "RMItemMaster", "Item Name", "ID", lkupItemName)
    End Sub
    Private Sub txtrejqty_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtrejqty.Validating
        'Try
        '    If Val(txtrejqty.Text) > Val(strresult) Then
        '        MessageBox.Show("Rejected Quantity can not exceed Quantity on hand", "Check Rejected Qty", MessageBoxButtons.OK)
        '        e.Cancel = True
        '    End If
        'Catch ex As Exception
        '    If show_error Then
        '        MsgBox(ex.ToString)
        '    End If
        'End Try
    End Sub

    Private Sub lkupItemName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupItemName.EditValueChanged
        Try
            If lkupItemName.EditValue = "" Then Exit Sub
            If lkupItemName.EditValue <> "<Null>" Or Not lkupItemName.EditValue = Nothing Then
                Dim row As DataRowView = lkupItemName.Properties.GetDataSourceRowByKeyValue(lkupItemName.EditValue)
                strItemID = row(1).ToString
                strUnitId = row(2).ToString
                If RGInscheck.SelectedIndex = 0 Then
                    txtinspecno.Text = row(3).ToString
                End If
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub lkupItemName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lkupItemName.GotFocus
        Try
            lkupItemName.Properties.Columns.Clear()
            If RGInscheck.SelectedIndex = 0 Then
                If cmbPONo.Text <> "" Then

                    FillLookup("SELECT RMItemMaster.RMItemName, RMItemMaster.Rid, UnitMaster.UnitName,Purchase_Detail.Qty " _
                      & " FROM (RMItemMaster INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID) INNER JOIN Purchase_Detail ON (Purchase_Detail.RMItemID = RMItemMaster.Rid) AND (UnitMaster.UnitID = Purchase_Detail.UnitID) " _
                      & " WHERE (((Purchase_Detail.PO_No)='" & cmbPONo.Text & "'));", "RMItemMaster", "Item Name", "ID", lkupItemName)

                    'FillLookup("SELECT RMItemMaster.RMItemName,RMItemMaster.Rid, Purchase_Detail.PO_No " _
                    '        & "FROM Purchase_Detail INNER JOIN RMItemMaster ON Purchase_Detail.RMItemID = RMItemMaster.Rid " _
                    '        & "WHERE (((Purchase_Detail.PO_No)='" & cmbPONo.Text & "'))", "RMItemMaster", "Item Name", "ID", lkupItemName)
                End If
            ElseIf RGInscheck.SelectedIndex = 1 Then
                FillLookup("SELECT RMItemMaster.RMItemName, RMItemMaster.Rid, UnitMaster.UnitName " _
                          & " FROM RMItemMaster INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID", "RMItem", "Item Name", "ItemID", lkupItemName)
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub lkupItemName_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lkupItemName.Validating
        Try
            If lkupItemName.Text <> "" Then
                cmd = New OleDb.OleDbCommand
                If RGInscheck.SelectedIndex = 0 Then
                    cmd.CommandText = "SELECT Purchase_Detail.Qty,Purchase_Detail.UnitId, RMItemMaster.RMItemName " _
                       & "FROM Purchase_Detail INNER JOIN RMItemMaster ON Purchase_Detail.RMItemID = RMItemMaster.Rid " _
                       & "WHERE (((RMItemMaster.RMItemName)= '" & lkupItemName.Text & "'))"

                    cmd.Connection = conn
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If Not dr(0) Is Nothing Then
                        dblPOQTY = dr(0).ToString
                        strUnitId = dr(2).ToString
                    End If
                Else
                    cmd.CommandText = "SELECT UnitId,RMItemName " _
                        & "FROM RMItemMaster  " _
                        & "WHERE RMItemMaster.RMItemName= '" & lkupItemName.Text & "'"

                    cmd.Connection = conn
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If Not dr(0) Is Nothing Then
                        strUnitId = dr(0).ToString
                    End If
                End If
                dr.Close()
                cmd.Dispose()
            End If
        Catch ex As Exception
            dr.Close()
            cmd.Dispose()
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Try
            Dim myPara As New frmPara
            myPara.showInwardTriplicate(ModMain.strgridid & "'")
            myPara.Close()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub txtinspecno_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtinspecno.EditValueChanged
        Try
            txtrejqty.Text = Val(txtinspecno.Text) - Val(txtqcno.Text)
        Catch EX As Exception
            If show_error Then
                MsgBox(EX.ToString)
            End If
        End Try
    End Sub

    Private Sub txtqcno_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqcno.EditValueChanged
        Try
            txtrejqty.Text = Val(txtinspecno.Text) - Val(txtqcno.Text)
        Catch EX As Exception
            If show_error Then
                MsgBox(EX.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddItem.Click
        Try
            Dim myfrm As New frmitem
            myfrm.ShowDialog()
            myfrm.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
End Class
