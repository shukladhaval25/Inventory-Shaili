Public Class frmInvoicenew
    Inherits DevExpress.XtraEditors.XtraForm
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
    Friend WithEvents gvInvoice As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grpInvoice As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblacutualdate As System.Windows.Forms.Label
    Friend WithEvents DtActualDelDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblcourierdoc As System.Windows.Forms.Label
    Friend WithEvents txtCouDocNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtChallanNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbChallanNo As System.Windows.Forms.Label
    Friend WithEvents txtCourierName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtQtnNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCourier As System.Windows.Forms.Label
    Friend WithEvents lblQtnNo As System.Windows.Forms.Label
    Friend WithEvents lblCustName As System.Windows.Forms.Label
    Friend WithEvents lblOrderNo As System.Windows.Forms.Label
    Friend WithEvents txtOrderNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pnInvoice As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblRemarks As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtqty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblqty As System.Windows.Forms.Label
    Friend WithEvents gdInvoice As DevExpress.XtraGrid.GridControl
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblRaw As System.Windows.Forms.Label
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbldeldate As System.Windows.Forms.Label
    Friend WithEvents grDesDeatails As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dtOrderdate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtDeldate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lkupCustName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkupFG As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtRemark As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdCustadd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRefBy As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tdDelTime As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents lblType As System.Windows.Forms.Label
    Friend WithEvents cmbType As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtType As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBalQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdReport As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gvInvoice = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gdInvoice = New DevExpress.XtraGrid.GridControl
        Me.grpInvoice = New DevExpress.XtraEditors.GroupControl
        Me.cmdReport = New DevExpress.XtraEditors.SimpleButton
        Me.cmbType = New DevExpress.XtraEditors.ComboBoxEdit
        Me.lblType = New System.Windows.Forms.Label
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtRefBy = New DevExpress.XtraEditors.TextEdit
        Me.cmdCustadd = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtOrderdate = New DevExpress.XtraEditors.DateEdit
        Me.lkupCustName = New DevExpress.XtraEditors.LookUpEdit
        Me.txtChallanNo = New DevExpress.XtraEditors.TextEdit
        Me.lbChallanNo = New System.Windows.Forms.Label
        Me.lblCustName = New System.Windows.Forms.Label
        Me.lblOrderNo = New System.Windows.Forms.Label
        Me.txtOrderNo = New DevExpress.XtraEditors.TextEdit
        Me.pnInvoice = New DevExpress.XtraEditors.PanelControl
        Me.txtType = New DevExpress.XtraEditors.TextEdit
        Me.txtRemark = New DevExpress.XtraEditors.TextEdit
        Me.lblRemarks = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtqty = New DevExpress.XtraEditors.TextEdit
        Me.lblqty = New System.Windows.Forms.Label
        Me.lkupFG = New DevExpress.XtraEditors.LookUpEdit
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.lblRaw = New System.Windows.Forms.Label
        Me.txtBalQty = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton
        Me.grDesDeatails = New DevExpress.XtraEditors.GroupControl
        Me.lbldeldate = New System.Windows.Forms.Label
        Me.dtDeldate = New DevExpress.XtraEditors.DateEdit
        Me.lblQtnNo = New System.Windows.Forms.Label
        Me.txtCouDocNo = New DevExpress.XtraEditors.TextEdit
        Me.lblcourierdoc = New System.Windows.Forms.Label
        Me.txtQtnNo = New DevExpress.XtraEditors.TextEdit
        Me.tdDelTime = New DevExpress.XtraEditors.TimeEdit
        Me.DtActualDelDate = New DevExpress.XtraEditors.DateEdit
        Me.lblacutualdate = New System.Windows.Forms.Label
        Me.lblCourier = New System.Windows.Forms.Label
        Me.txtCourierName = New DevExpress.XtraEditors.TextEdit
        CType(Me.gvInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInvoice.SuspendLayout()
        CType(Me.cmbType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtOrderdate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupCustName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChallanNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrderNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnInvoice.SuspendLayout()
        CType(Me.txtType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtqty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupFG.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBalQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grDesDeatails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grDesDeatails.SuspendLayout()
        CType(Me.dtDeldate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCouDocNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtnNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdDelTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtActualDelDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCourierName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvInvoice
        '
        Me.gvInvoice.GridControl = Me.gdInvoice
        Me.gvInvoice.Name = "gvInvoice"
        Me.gvInvoice.OptionsBehavior.Editable = False
        Me.gvInvoice.OptionsCustomization.AllowColumnMoving = False
        Me.gvInvoice.OptionsCustomization.AllowFilter = False
        Me.gvInvoice.OptionsCustomization.AllowGroup = False
        Me.gvInvoice.OptionsMenu.EnableFooterMenu = False
        Me.gvInvoice.OptionsMenu.EnableGroupPanelMenu = False
        Me.gvInvoice.OptionsNavigation.UseTabKey = False
        Me.gvInvoice.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvInvoice.OptionsView.ShowGroupPanel = False
        '
        'gdInvoice
        '
        '
        '
        '
        Me.gdInvoice.EmbeddedNavigator.Name = ""
        Me.gdInvoice.Location = New System.Drawing.Point(16, 72)
        Me.gdInvoice.MainView = Me.gvInvoice
        Me.gdInvoice.Name = "gdInvoice"
        Me.gdInvoice.Size = New System.Drawing.Size(608, 184)
        Me.gdInvoice.TabIndex = 16
        Me.gdInvoice.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvInvoice})
        '
        'grpInvoice
        '
        Me.grpInvoice.Controls.Add(Me.cmdReport)
        Me.grpInvoice.Controls.Add(Me.cmbType)
        Me.grpInvoice.Controls.Add(Me.lblType)
        Me.grpInvoice.Controls.Add(Me.SimpleButton3)
        Me.grpInvoice.Controls.Add(Me.cmdSave)
        Me.grpInvoice.Controls.Add(Me.Label3)
        Me.grpInvoice.Controls.Add(Me.txtRefBy)
        Me.grpInvoice.Controls.Add(Me.cmdCustadd)
        Me.grpInvoice.Controls.Add(Me.SimpleButton1)
        Me.grpInvoice.Controls.Add(Me.Label1)
        Me.grpInvoice.Controls.Add(Me.dtOrderdate)
        Me.grpInvoice.Controls.Add(Me.lkupCustName)
        Me.grpInvoice.Controls.Add(Me.txtChallanNo)
        Me.grpInvoice.Controls.Add(Me.lbChallanNo)
        Me.grpInvoice.Controls.Add(Me.lblCustName)
        Me.grpInvoice.Controls.Add(Me.lblOrderNo)
        Me.grpInvoice.Controls.Add(Me.txtOrderNo)
        Me.grpInvoice.Controls.Add(Me.pnInvoice)
        Me.grpInvoice.Controls.Add(Me.cmdClose)
        Me.grpInvoice.Controls.Add(Me.grDesDeatails)
        Me.grpInvoice.Location = New System.Drawing.Point(5, 5)
        Me.grpInvoice.Name = "grpInvoice"
        Me.grpInvoice.Size = New System.Drawing.Size(643, 507)
        Me.grpInvoice.TabIndex = 20
        Me.grpInvoice.Text = "INVOICE DETAILS"
        '
        'cmdReport
        '
        Me.cmdReport.Location = New System.Drawing.Point(8, 472)
        Me.cmdReport.Name = "cmdReport"
        Me.cmdReport.Size = New System.Drawing.Size(56, 25)
        Me.cmdReport.TabIndex = 56
        Me.cmdReport.Text = "&Report"
        '
        'cmbType
        '
        Me.cmbType.EditValue = ""
        Me.cmbType.Location = New System.Drawing.Point(104, 112)
        Me.cmbType.Name = "cmbType"
        '
        '
        '
        Me.cmbType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbType.Size = New System.Drawing.Size(200, 20)
        Me.cmbType.TabIndex = 4
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(8, 112)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(45, 16)
        Me.lblType.TabIndex = 55
        Me.lblType.Text = "Type :"
        Me.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SimpleButton3
        '
        Me.SimpleButton3.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton3.Location = New System.Drawing.Point(568, 472)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(56, 25)
        Me.SimpleButton3.TabIndex = 18
        Me.SimpleButton3.Text = "&Close"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(504, 472)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(56, 25)
        Me.cmdSave.TabIndex = 17
        Me.cmdSave.Text = "&Save"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Order by:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRefBy
        '
        Me.txtRefBy.EditValue = ""
        Me.txtRefBy.Location = New System.Drawing.Point(104, 171)
        Me.txtRefBy.Name = "txtRefBy"
        '
        '
        '
        Me.txtRefBy.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefBy.Properties.Appearance.Options.UseFont = True
        Me.txtRefBy.Properties.MaxLength = 15
        Me.txtRefBy.Size = New System.Drawing.Size(200, 22)
        Me.txtRefBy.TabIndex = 6
        '
        'cmdCustadd
        '
        Me.cmdCustadd.Location = New System.Drawing.Point(264, 144)
        Me.cmdCustadd.Name = "cmdCustadd"
        Me.cmdCustadd.Size = New System.Drawing.Size(40, 20)
        Me.cmdCustadd.TabIndex = 48
        Me.cmdCustadd.Text = "&Add..."
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(464, 577)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 29)
        Me.SimpleButton1.TabIndex = 16
        Me.SimpleButton1.Text = "&Save"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Order Date:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtOrderdate
        '
        Me.dtOrderdate.EditValue = Nothing
        Me.dtOrderdate.Location = New System.Drawing.Point(104, 55)
        Me.dtOrderdate.Name = "dtOrderdate"
        '
        '
        '
        Me.dtOrderdate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtOrderdate.Size = New System.Drawing.Size(200, 20)
        Me.dtOrderdate.TabIndex = 2
        '
        'lkupCustName
        '
        Me.lkupCustName.EditValue = ""
        Me.lkupCustName.Location = New System.Drawing.Point(104, 144)
        Me.lkupCustName.Name = "lkupCustName"
        '
        '
        '
        Me.lkupCustName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupCustName.Properties.NullText = ""
        Me.lkupCustName.Size = New System.Drawing.Size(155, 20)
        Me.lkupCustName.TabIndex = 5
        '
        'txtChallanNo
        '
        Me.txtChallanNo.EditValue = ""
        Me.txtChallanNo.Location = New System.Drawing.Point(104, 80)
        Me.txtChallanNo.Name = "txtChallanNo"
        '
        '
        '
        Me.txtChallanNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChallanNo.Properties.Appearance.Options.UseFont = True
        Me.txtChallanNo.Properties.MaxLength = 20
        Me.txtChallanNo.Size = New System.Drawing.Size(200, 22)
        Me.txtChallanNo.TabIndex = 3
        '
        'lbChallanNo
        '
        Me.lbChallanNo.AutoSize = True
        Me.lbChallanNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbChallanNo.Location = New System.Drawing.Point(8, 80)
        Me.lbChallanNo.Name = "lbChallanNo"
        Me.lbChallanNo.Size = New System.Drawing.Size(78, 16)
        Me.lbChallanNo.TabIndex = 32
        Me.lbChallanNo.Text = "Challan No.:"
        Me.lbChallanNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustName.Location = New System.Drawing.Point(8, 144)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(105, 16)
        Me.lblCustName.TabIndex = 2
        Me.lblCustName.Text = "Customer Name:"
        Me.lblCustName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOrderNo
        '
        Me.lblOrderNo.AutoSize = True
        Me.lblOrderNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderNo.Location = New System.Drawing.Point(8, 26)
        Me.lblOrderNo.Name = "lblOrderNo"
        Me.lblOrderNo.Size = New System.Drawing.Size(69, 16)
        Me.lblOrderNo.TabIndex = 1
        Me.lblOrderNo.Text = "Order No.:"
        Me.lblOrderNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOrderNo
        '
        Me.txtOrderNo.EditValue = ""
        Me.txtOrderNo.Location = New System.Drawing.Point(104, 26)
        Me.txtOrderNo.Name = "txtOrderNo"
        '
        '
        '
        Me.txtOrderNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderNo.Properties.Appearance.Options.UseFont = True
        Me.txtOrderNo.Properties.MaxLength = 15
        Me.txtOrderNo.Size = New System.Drawing.Size(200, 22)
        Me.txtOrderNo.TabIndex = 1
        '
        'pnInvoice
        '
        Me.pnInvoice.Controls.Add(Me.txtType)
        Me.pnInvoice.Controls.Add(Me.txtRemark)
        Me.pnInvoice.Controls.Add(Me.lblRemarks)
        Me.pnInvoice.Controls.Add(Me.Label2)
        Me.pnInvoice.Controls.Add(Me.txtqty)
        Me.pnInvoice.Controls.Add(Me.lblqty)
        Me.pnInvoice.Controls.Add(Me.lkupFG)
        Me.pnInvoice.Controls.Add(Me.gdInvoice)
        Me.pnInvoice.Controls.Add(Me.cmdAdd)
        Me.pnInvoice.Controls.Add(Me.cmdDelete)
        Me.pnInvoice.Controls.Add(Me.lblRaw)
        Me.pnInvoice.Controls.Add(Me.txtBalQty)
        Me.pnInvoice.Controls.Add(Me.Label4)
        Me.pnInvoice.Location = New System.Drawing.Point(8, 200)
        Me.pnInvoice.Name = "pnInvoice"
        Me.pnInvoice.Size = New System.Drawing.Size(624, 264)
        Me.pnInvoice.TabIndex = 12
        Me.pnInvoice.Text = "PanelControl1"
        '
        'txtType
        '
        Me.txtType.EditValue = ""
        Me.txtType.Location = New System.Drawing.Point(376, 8)
        Me.txtType.Name = "txtType"
        '
        '
        '
        Me.txtType.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtType.Properties.Appearance.Options.UseFont = True
        Me.txtType.Properties.MaxLength = 50
        Me.txtType.Size = New System.Drawing.Size(112, 22)
        Me.txtType.TabIndex = 14
        '
        'txtRemark
        '
        Me.txtRemark.EditValue = ""
        Me.txtRemark.Location = New System.Drawing.Point(376, 39)
        Me.txtRemark.Name = "txtRemark"
        '
        '
        '
        Me.txtRemark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemark.Properties.Appearance.Options.UseFont = True
        Me.txtRemark.Properties.MaxLength = 255
        Me.txtRemark.Size = New System.Drawing.Size(240, 22)
        Me.txtRemark.TabIndex = 15
        '
        'lblRemarks
        '
        Me.lblRemarks.AutoSize = True
        Me.lblRemarks.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemarks.Location = New System.Drawing.Point(320, 39)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(58, 16)
        Me.lblRemarks.TabIndex = 51
        Me.lblRemarks.Text = "Remarks"
        Me.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(320, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 16)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Type"
        '
        'txtqty
        '
        Me.txtqty.EditValue = ""
        Me.txtqty.Location = New System.Drawing.Point(224, 39)
        Me.txtqty.Name = "txtqty"
        '
        '
        '
        Me.txtqty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.Properties.Appearance.Options.UseFont = True
        Me.txtqty.Properties.MaxLength = 5
        Me.txtqty.Size = New System.Drawing.Size(72, 22)
        Me.txtqty.TabIndex = 13
        '
        'lblqty
        '
        Me.lblqty.AutoSize = True
        Me.lblqty.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqty.Location = New System.Drawing.Point(184, 39)
        Me.lblqty.Name = "lblqty"
        Me.lblqty.Size = New System.Drawing.Size(32, 16)
        Me.lblqty.TabIndex = 48
        Me.lblqty.Text = "Qty:"
        '
        'lkupFG
        '
        Me.lkupFG.EditValue = ""
        Me.lkupFG.Location = New System.Drawing.Point(96, 10)
        Me.lkupFG.Name = "lkupFG"
        '
        '
        '
        Me.lkupFG.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupFG.Properties.NullText = ""
        Me.lkupFG.Size = New System.Drawing.Size(200, 20)
        Me.lkupFG.TabIndex = 12
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(496, 9)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(56, 23)
        Me.cmdAdd.TabIndex = 16
        Me.cmdAdd.Text = "&Add"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(560, 9)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(56, 23)
        Me.cmdDelete.TabIndex = 19
        Me.cmdDelete.Text = "&Delete"
        '
        'lblRaw
        '
        Me.lblRaw.AutoSize = True
        Me.lblRaw.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaw.Location = New System.Drawing.Point(7, 12)
        Me.lblRaw.Name = "lblRaw"
        Me.lblRaw.Size = New System.Drawing.Size(39, 16)
        Me.lblRaw.TabIndex = 21
        Me.lblRaw.Text = "Item:"
        '
        'txtBalQty
        '
        Me.txtBalQty.EditValue = ""
        Me.txtBalQty.Location = New System.Drawing.Point(96, 39)
        Me.txtBalQty.Name = "txtBalQty"
        '
        '
        '
        Me.txtBalQty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBalQty.Properties.Appearance.Options.UseFont = True
        Me.txtBalQty.Properties.MaxLength = 5
        Me.txtBalQty.Properties.ReadOnly = True
        Me.txtBalQty.Size = New System.Drawing.Size(72, 22)
        Me.txtBalQty.TabIndex = 56
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Balance Qty:"
        '
        'cmdClose
        '
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(552, 577)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 29)
        Me.cmdClose.TabIndex = 17
        Me.cmdClose.Text = "&Cancel"
        '
        'grDesDeatails
        '
        Me.grDesDeatails.Controls.Add(Me.lbldeldate)
        Me.grDesDeatails.Controls.Add(Me.dtDeldate)
        Me.grDesDeatails.Controls.Add(Me.lblQtnNo)
        Me.grDesDeatails.Controls.Add(Me.txtCouDocNo)
        Me.grDesDeatails.Controls.Add(Me.lblcourierdoc)
        Me.grDesDeatails.Controls.Add(Me.txtQtnNo)
        Me.grDesDeatails.Controls.Add(Me.tdDelTime)
        Me.grDesDeatails.Controls.Add(Me.DtActualDelDate)
        Me.grDesDeatails.Controls.Add(Me.lblacutualdate)
        Me.grDesDeatails.Controls.Add(Me.lblCourier)
        Me.grDesDeatails.Controls.Add(Me.txtCourierName)
        Me.grDesDeatails.Location = New System.Drawing.Point(320, 24)
        Me.grDesDeatails.Name = "grDesDeatails"
        Me.grDesDeatails.ShowCaption = False
        Me.grDesDeatails.Size = New System.Drawing.Size(312, 168)
        Me.grDesDeatails.TabIndex = 20
        Me.grDesDeatails.Text = "DESPATCH DETAILS"
        '
        'lbldeldate
        '
        Me.lbldeldate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldeldate.Location = New System.Drawing.Point(9, 17)
        Me.lbldeldate.Name = "lbldeldate"
        Me.lbldeldate.Size = New System.Drawing.Size(104, 21)
        Me.lbldeldate.TabIndex = 41
        Me.lbldeldate.Text = "Delivery Time:"
        Me.lbldeldate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtDeldate
        '
        Me.dtDeldate.EditValue = Nothing
        Me.dtDeldate.Location = New System.Drawing.Point(120, 17)
        Me.dtDeldate.Name = "dtDeldate"
        '
        '
        '
        Me.dtDeldate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtDeldate.Size = New System.Drawing.Size(184, 20)
        Me.dtDeldate.TabIndex = 7
        '
        'lblQtnNo
        '
        Me.lblQtnNo.AutoSize = True
        Me.lblQtnNo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQtnNo.Location = New System.Drawing.Point(8, 102)
        Me.lblQtnNo.Name = "lblQtnNo"
        Me.lblQtnNo.Size = New System.Drawing.Size(60, 16)
        Me.lblQtnNo.TabIndex = 7
        Me.lblQtnNo.Text = "Qtn. No.:"
        Me.lblQtnNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCouDocNo
        '
        Me.txtCouDocNo.EditValue = ""
        Me.txtCouDocNo.Location = New System.Drawing.Point(120, 130)
        Me.txtCouDocNo.Name = "txtCouDocNo"
        '
        '
        '
        Me.txtCouDocNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCouDocNo.Properties.Appearance.Options.UseFont = True
        Me.txtCouDocNo.Properties.MaxLength = 25
        Me.txtCouDocNo.Size = New System.Drawing.Size(184, 22)
        Me.txtCouDocNo.TabIndex = 11
        '
        'lblcourierdoc
        '
        Me.lblcourierdoc.AutoSize = True
        Me.lblcourierdoc.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcourierdoc.Location = New System.Drawing.Point(8, 130)
        Me.lblcourierdoc.Name = "lblcourierdoc"
        Me.lblcourierdoc.Size = New System.Drawing.Size(78, 16)
        Me.lblcourierdoc.TabIndex = 38
        Me.lblcourierdoc.Text = "Cr Doc. No.:"
        Me.lblcourierdoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtQtnNo
        '
        Me.txtQtnNo.EditValue = ""
        Me.txtQtnNo.Location = New System.Drawing.Point(120, 102)
        Me.txtQtnNo.Name = "txtQtnNo"
        '
        '
        '
        Me.txtQtnNo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtnNo.Properties.Appearance.Options.UseFont = True
        Me.txtQtnNo.Properties.MaxLength = 20
        Me.txtQtnNo.Size = New System.Drawing.Size(184, 22)
        Me.txtQtnNo.TabIndex = 10
        '
        'tdDelTime
        '
        Me.tdDelTime.EditValue = "1/17/2007 12:00:00 AM"
        Me.tdDelTime.Location = New System.Drawing.Point(96, 128)
        Me.tdDelTime.Name = "tdDelTime"
        '
        '
        '
        Me.tdDelTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tdDelTime.Properties.EditFormat.FormatString = "hh:mm"
        Me.tdDelTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.tdDelTime.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.tdDelTime.Properties.Mask.EditMask = "hh:mm tt"
        Me.tdDelTime.Properties.UseCtrlIncrement = False
        Me.tdDelTime.Size = New System.Drawing.Size(16, 20)
        Me.tdDelTime.TabIndex = 21
        Me.tdDelTime.Visible = False
        '
        'DtActualDelDate
        '
        Me.DtActualDelDate.EditValue = Nothing
        Me.DtActualDelDate.Location = New System.Drawing.Point(120, 48)
        Me.DtActualDelDate.Name = "DtActualDelDate"
        '
        '
        '
        Me.DtActualDelDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtActualDelDate.Size = New System.Drawing.Size(184, 20)
        Me.DtActualDelDate.TabIndex = 8
        '
        'lblacutualdate
        '
        Me.lblacutualdate.AutoSize = True
        Me.lblacutualdate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacutualdate.Location = New System.Drawing.Point(8, 48)
        Me.lblacutualdate.Name = "lblacutualdate"
        Me.lblacutualdate.Size = New System.Drawing.Size(86, 16)
        Me.lblacutualdate.TabIndex = 43
        Me.lblacutualdate.Text = "Dispatch Date"
        Me.lblacutualdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCourier
        '
        Me.lblCourier.AutoSize = True
        Me.lblCourier.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourier.Location = New System.Drawing.Point(8, 74)
        Me.lblCourier.Name = "lblCourier"
        Me.lblCourier.Size = New System.Drawing.Size(92, 16)
        Me.lblCourier.TabIndex = 8
        Me.lblCourier.Text = "Courier Name:"
        Me.lblCourier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCourierName
        '
        Me.txtCourierName.EditValue = ""
        Me.txtCourierName.Location = New System.Drawing.Point(120, 74)
        Me.txtCourierName.Name = "txtCourierName"
        '
        '
        '
        Me.txtCourierName.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourierName.Properties.Appearance.Options.UseFont = True
        Me.txtCourierName.Properties.MaxLength = 20
        Me.txtCourierName.Size = New System.Drawing.Size(184, 22)
        Me.txtCourierName.TabIndex = 9
        '
        'frmInvoicenew
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(656, 518)
        Me.Controls.Add(Me.grpInvoice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvoicenew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Order"
        CType(Me.gvInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInvoice.ResumeLayout(False)
        Me.grpInvoice.PerformLayout()
        CType(Me.cmbType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtOrderdate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupCustName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChallanNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrderNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnInvoice.ResumeLayout(False)
        Me.pnInvoice.PerformLayout()
        CType(Me.txtType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRemark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtqty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupFG.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBalQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grDesDeatails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grDesDeatails.ResumeLayout(False)
        Me.grDesDeatails.PerformLayout()
        CType(Me.dtDeldate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCouDocNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtnNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdDelTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtActualDelDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCourierName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public strcheck As String
    Dim cmd As OleDb.OleDbCommand
    Dim dr As OleDb.OleDbDataReader
    Dim strCustID As String

    Dim dt As New DataTable
    Public intBalanceQty As Double
    Private Sub frmInvoicenew_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtOrderdate.DateTime = Today()

            DtActualDelDate.DateTime = Today()

            dtDeldate.DateTime = Today()


            ' FillLookup("select fgname, fid from fgmaster", "FGMaster", "Finish Product", "FID", lkupFG)
            'NEW
            FillLookup("SELECT FGMaster.FGName, FGStock.FID, Sum(FGStock.Balance_Qty) AS SumOfBalance_Qty " _
                        & " FROM FGStock INNER JOIN FGMaster ON FGStock.FID = FGMaster.FID " _
                        & " GROUP BY FGMaster.FGName, FGStock.FID ", "FGStock", "Finish Product", "FID", lkupFG)

            FillLookup("Select CustName,CID from CustomerMaster", "CustomerMaster", "Cust Name", "CID", lkupCustName)

            dt.Columns.Add("FID", System.Type.GetType("System.String"))
            dt.Columns.Add("FGName", System.Type.GetType("System.String"))
            dt.Columns.Add("Type", System.Type.GetType("System.String"))

            dt.Columns.Add("Qty", System.Type.GetType("System.String"))
            dt.Columns.Add("Remarks", System.Type.GetType("System.String"))

            If strcheck = "Add" Then
                txtOrderNo.Text = (GetMaxNo("Order_No", "InvoiceMaster", "", 6, strCY))
                dtOrderdate.EditValue = Now
                dtDeldate.EditValue = Now
                DtActualDelDate.EditValue = Now
            End If

            If strcheck = "Edit" Then
                cmd = New OleDb.OleDbCommand

                cmd.CommandText = "Select * from invoicemaster where order_no = '" & ModMain.strgridid & "'" ' AND CY ='" & strCY.Trim & "'"

                cmd.Connection = conn
                dr = cmd.ExecuteReader
                dr.Read()
                bind_data()
                dr.Close()
                cmd.Dispose()
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub lkupCustName_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lkupCustName.EditValueChanged
        Try
            If lkupCustName.EditValue <> "" Then
                Dim row As DataRowView = lkupCustName.Properties.GetDataSourceRowByKeyValue(lkupCustName.EditValue)
                If row(1) Is Nothing Then Exit Sub
                strCustID = row(1).ToString
               
            End If

        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub lkupFG_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lkupFG.EditValueChanged
        Try
            If lkupFG.EditValue = "" Then
                Exit Sub
            End If

            If Not lkupFG.EditValue.ToString Is Nothing Or lkupFG.EditValue.ToString <> "" Then
                Dim row As DataRowView = lkupFG.Properties.GetDataSourceRowByKeyValue(lkupFG.EditValue)
                lkupFG.Tag = row(1).ToString
                intBalanceQty = row(2).ToString
                txtBalQty.Text = row(2).ToString

            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim dr As DataRow
        Try
            Dim blnDup As Boolean = False
            For i As Int16 = 0 To gvInvoice.RowCount - 1
                If gvInvoice.GetRowCellValue(i, gvInvoice.Columns(1)).ToString = lkupFG.Text Then
                    blnDup = True
                    Exit For
                End If
            Next
            If blnDup = False Then
                If lkupFG.Text = "" Or txtqty.Text = "" Or txtqty.Text = "" Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("Check either FinishGoodName or Qty is left blank", "Blank Field Error", _
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                dr = dt.NewRow
                dr.Item(0) = lkupFG.Tag
                dr.Item(1) = lkupFG.Text
                dr.Item(2) = txtType.Text
                dr.Item(3) = txtqty.Text
                dr.Item(4) = txtRemark.Text
                dt.Rows.Add(dr)
                gdInvoice.DataSource = dt
                gvInvoice.Columns(0).Visible = False

            End If
            lkupFG.EditValue = ""
            txtType.Text = ""
            txtqty.Text = ""
            txtRemark.Text = ""


        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub txtqty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqty.KeyPress
        e.Handled = IsDecimalNumber(e.KeyChar)
    End Sub

    Private Sub cmdCustadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCustadd.Click
        Dim frmcustobj As New FrmCustomer
        stractivetable = "Customer"
        frmcustobj.strcheck = "Add"
        frmcustobj.ShowDialog()
        stractivetable = "Invoice"
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            'NEW
            If Checkvalidate() = False Then
                Exit Sub
            End If
            'END NEW
            If strcheck = "Add" Then
                cmd = New OleDb.OleDbCommand

                cmd.CommandText = "insert into InvoiceMaster values('" & Replace(txtOrderNo.Text.Trim, "'", "''") & "','" & dtOrderdate.Text & "','" & Replace(txtChallanNo.Text.Trim, "'", "''") & "','" & Replace(txtRefBy.Text.Trim, "'", "''") & "','" & cmbType.Text & "','" & strCustID & "','" & dtDeldate.Text & "','" & DtActualDelDate.Text & "','" & Replace(txtQtnNo.Text.Trim, "'", "''") & "','" & Replace(txtCourierName.Text.Trim, "'", "''") & "','" & Replace(txtCouDocNo.Text.Trim, "'", "''") & "','" & strCY.Trim & "')"

                cmd.Connection = conn
                cmd.Transaction = conn.BeginTransaction
                cmd.ExecuteNonQuery()

                'new
                If gvInvoice.SelectedRowsCount = 0 Then
                    DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Details of item sold is not entered for the selected CUSTOMER", "StrAppName", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cmd.Transaction.Rollback()
                    Exit Sub

                Else
                    'end new
                    Dim i As Int16
                    For i = 0 To gvInvoice.RowCount - 1
                        cmd.CommandText = "insert into InvoiceDetail values('" & txtOrderNo.Text & "','" & gvInvoice.GetRowCellValue(i, "FID") & "','" & gvInvoice.GetRowCellValue(i, "Type") & "'," & gvInvoice.GetRowCellValue(i, "Qty") & ",'" & Replace(gvInvoice.GetRowCellValue(i, "Remarks"), "'", "''") & "','" & strCY.Trim & "')"
                        cmd.Connection = conn
                        cmd.ExecuteNonQuery()
                    Next

                    cmd.Transaction.Commit()
                End If

            ElseIf strcheck = "Edit" Then

                txtOrderNo.Properties.ReadOnly = True

                cmd = New OleDb.OleDbCommand

                cmd.CommandText = "Update InvoiceMaster set order_date = '" & dtOrderdate.Text & "', challan_No = '" & Replace(txtChallanNo.Text.Trim, "'", "''") & "', ref_by = '" & Replace(txtRefBy.Text.Trim, "'", "''") & "', type = '" & cmbType.Text & "', CID = '" & strCustID & "', Del_Time = '" & dtDeldate.Text & "', A_Des_Date= '" & DtActualDelDate.Text & "', Qtn_No = '" & Replace(txtQtnNo.Text.Trim, "'", "''") & "', Cour_Name = '" & Replace(txtCourierName.Text.Trim, "'", "''") & "', Cour_D_No = '" & Replace(txtCouDocNo.Text.Trim, "'", "''") & "' where order_No = '" & txtOrderNo.Text & "' AND CY ='" & strCY.Trim & "'"
                cmd.Connection = conn

                cmd.Transaction = conn.BeginTransaction
                cmd.ExecuteNonQuery()

                cmd.CommandText = "delete from InvoiceDetail where order_No= '" & ModMain.strgridid & "' AND CY ='" & strCY.Trim & "'"
                cmd.ExecuteNonQuery()

                Dim i As Int16
                For i = 0 To gvInvoice.RowCount - 1
                    cmd.CommandText = "insert into InvoiceDetail values('" & txtOrderNo.Text & "','" & gvInvoice.GetRowCellValue(i, "FID") & "','" & gvInvoice.GetRowCellValue(i, "Type") & "'," & gvInvoice.GetRowCellValue(i, "Qty") & ",'" & gvInvoice.GetRowCellValue(i, "Remarks") & "','" & strCY.Trim & "')"
                    cmd.Connection = conn
                    cmd.ExecuteNonQuery()
                Next
                cmd.Transaction.Commit()


            End If
            cmd.Dispose()
            DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Save Data Successfully", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
            cmd.Transaction.Rollback()
        End Try

    End Sub

    Private Sub txtqty_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtqty.Validating
        Try
            If txtqty.Text = "" OrElse txtqty.Text <= 0 Then
                e.Cancel = True
                'ElseIf Val(txtqty.Text) > Val(txtBalQty.Text) Then
                '    DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Quantity is no available in Required Stock ", "StrAppName", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    e.Cancel = True
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub bind_data()
        txtOrderNo.Text = ModMain.strgridid

        If IsDBNull(dr("Order_date")) = True Then
            dtOrderdate.EditValue = ""
        Else
            dtOrderdate.EditValue = dr("Order_date").ToString
        End If


        'challan no
        If IsDBNull(dr("Challan_No")) = True Then
            txtChallanNo.Text = ""
        Else
            txtChallanNo.Text = dr("Challan_No").ToString
        End If
        'ref by
        If IsDBNull(dr("Ref_By")) = True Then
            txtRefBy.Text = ""
        Else
            txtRefBy.Text = dr("Ref_By").ToString
        End If

        'Type
        If IsDBNull(dr("Type")) = True Then
            cmbType.Text = ""
        Else
            cmbType.Text = dr("Type").ToString
        End If

        'del_time
        If IsDBNull(dr("Del_Time")) = True Then
            dtDeldate.EditValue = ""
        Else
            dtDeldate.EditValue = dr("Del_Time").ToString
        End If

        'del time through TIME EDIT CONTROL
        'If IsDBNull(dr("Del_Time")) = True Then
        '    tdDelTime.EditValue = ""
        'Else
        '    tdDelTime.EditValue = dr("Del_Time").ToString
        'End If

        'actual despatch date
        If IsDBNull(dr("A_Des_Date")) = True Then
            DtActualDelDate.EditValue = ""
        Else
            DtActualDelDate.EditValue = dr("A_Des_Date").ToString
        End If

        'qtn no
        If IsDBNull(dr("Qtn_No")) = True Then
            txtQtnNo.Text = ""
        Else
            txtQtnNo.Text = dr("Qtn_No").ToString
        End If

        'cour Name
        If IsDBNull(dr("Cour_Name")) = True Then
            txtCourierName.Text = ""
        Else
            txtCourierName.Text = dr("Cour_Name").ToString
        End If

        'cour doc no
        If IsDBNull(dr("Cour_D_No")) = True Then
            txtCouDocNo.Text = ""
        Else
            txtCouDocNo.Text = dr("Cour_D_No").ToString
        End If


        'code to find custname inrespect to customerid
        Dim strcustid1 As String
        strcustid1 = dr("CID").ToString
        dr.Close()
        If strcustid1 <> "" Then

            Dim cmdtemp As New OleDb.OleDbCommand
            cmdtemp.CommandType = CommandType.Text
            cmdtemp.Connection = conn
            cmdtemp.CommandText = "select Custname, CID from Customermaster where cid = '" & strcustid1 & "'"
            Dim strUName As String
            dr = cmdtemp.ExecuteReader
            dr.Read()
            If dr("CustName").ToString Is Nothing Then
                lkupCustName.EditValue = ""
            Else
                'lkupCustGroup.EditValue = dr("CustGRno").ToString
                lkupCustName.EditValue = dr("CID").ToString
                ' strUName.ToString
                dr.Close()
            End If
            'dr.Close()
            cmdtemp.Dispose()
        Else
            lkupCustName.EditValue = ""
        End If

        cmd.Dispose()

        dr.Close()

        adp = New OleDb.OleDbDataAdapter("SELECT InvoiceDetail.FID, FGMaster.FGName, InvoiceDetail.Type, InvoiceDetail.Qty, InvoiceDetail.Remarks, InvoiceDetail.Order_No " _
            & " FROM (InvoiceDetail INNER JOIN FGMaster ON InvoiceDetail.FID = FGMaster.FID)  " _
            & " WHERE (((InvoiceDetail.Order_No)= '" & ModMain.strgridid & "'))", conn) ' AND CY ='" & strCY.Trim & "'
        adp.Fill(dt)
        gdInvoice.DataSource = dt
        gvInvoice.Columns("FID").VisibleIndex = -1

        gvInvoice.Columns("Order_No").VisibleIndex = -1



    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If gvInvoice.GetSelectedRows.Length > 0 Then
                If MessageBox.Show("Are you sure you want to delete this record ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    gvInvoice.DeleteRow(gvInvoice.FocusedRowHandle)
                    gvInvoice.RefreshData()
                End If
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub dtDeldate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtDeldate.Validating
        If dtDeldate.EditValue < dtOrderdate.EditValue Then
            e.Cancel = True
            MessageBox.Show("Delivery Date cannot be less then Order_Date", "Date Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub DtActualDelDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DtActualDelDate.Validating
        If DtActualDelDate.EditValue < dtOrderdate.EditValue Then
            e.Cancel = True
            MessageBox.Show("Despatch Date cannot be less then Order_Date", "Date Error", MessageBoxButtons.OK)
        End If
    End Sub


    Private Sub txtOrderNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtOrderNo.Validating
        Try
            If strcheck = "Add" Then
                Dim strOrderNo As String
                strOrderNo = IsDuplicate("Select count(Order_No) from InvoiceMaster where order_No = '" & txtOrderNo.Text & "' and CY ='" & strCY.Trim & "'")
                If strOrderNo = True Then
                    e.Cancel = True
                    MessageBox.Show("This Order_No already exist", "Duplicate Value Error", MessageBoxButtons.OK)
                End If
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub


    Private Sub lkupCustName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles lkupCustName.GotFocus
        Try
            FillLookup("Select CustName,CID from CustomerMaster", "CustomerMaster", "Cust Name", "CID", lkupCustName)
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub


    Private Sub cmbType_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.GotFocus

        Try
            cmbType.Properties.Items.Clear()
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "select distinct(Type) from invoicemaster"
            dr = cmd.ExecuteReader()
            Do While dr.Read()
                cmbType.Properties.Items.Add(dr(0))
            Loop
            dr.Close()
            cmd.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try


    End Sub

    Public Function Checkvalidate() As Boolean
        'NEW
        Try
            If txtOrderNo.Text.Trim = "" Or dtOrderdate.Text = "" Or lkupCustName.EditValue = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Check Either Order Numer or Order Date or Customer Name is left blank", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Checkvalidate = False
                Exit Function
            End If
            If gvInvoice.SelectedRowsCount = 0 Then
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Details of item sold is not entered for the selected CUSTOMER", "StrAppName", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Checkvalidate = False
                Exit Function
            End If
            Checkvalidate = True
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Function

    Private Sub cmdReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReport.Click
        Try
            Dim mypara As New frmPara
            mypara.showInvoiceReport(ModMain.strgridid & "'")
            mypara.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class
