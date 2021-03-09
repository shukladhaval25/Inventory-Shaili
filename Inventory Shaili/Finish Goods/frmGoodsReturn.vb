Public Class frmGoodsReturn
    Inherits DevExpress.XtraEditors.XtraForm
    Dim dtChallan As New DataTable
    Dim dtRet As New DataTable
    Friend WithEvents cmdReport As DevExpress.XtraEditors.SimpleButton
    Public strCheck As String

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
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRetNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtRetDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GrpChallan As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdChallan As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvChallan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdReturn As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvRet As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtChallanDt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lkupChallan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtCustName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lkupProduct As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkupCust As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents grpReg As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtChallanNoLast As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lkupCustNameLast As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents rdoOption As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents grpOld As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GrpRegDet As System.Windows.Forms.GroupBox
    Friend WithEvents GrpDetLast As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdDelete_Prev As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdADD_Prev As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GrdRet_Prev As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvRet_Prev As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtRet_Qty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBatch_No As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lkupProd_Last As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtChallan_Dt_Last As DevExpress.XtraEditors.DateEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.grpOld = New DevExpress.XtraEditors.GroupControl
        Me.lkupCustNameLast = New DevExpress.XtraEditors.LookUpEdit
        Me.Label10 = New System.Windows.Forms.Label
        Me.dtChallan_Dt_Last = New DevExpress.XtraEditors.DateEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtChallanNoLast = New DevExpress.XtraEditors.TextEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.rdoOption = New DevExpress.XtraEditors.RadioGroup
        Me.grpReg = New DevExpress.XtraEditors.GroupControl
        Me.lkupChallan = New DevExpress.XtraEditors.LookUpEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.lkupCust = New DevExpress.XtraEditors.LookUpEdit
        Me.lkupProduct = New DevExpress.XtraEditors.LookUpEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtChallanDt = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCustName = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtRetDate = New DevExpress.XtraEditors.DateEdit
        Me.txtRetNo = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GrpChallan = New DevExpress.XtraEditors.GroupControl
        Me.grdChallan = New DevExpress.XtraGrid.GridControl
        Me.gvChallan = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.grdReturn = New DevExpress.XtraGrid.GridControl
        Me.gvRet = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSave = New DevExpress.XtraEditors.SimpleButton
        Me.GrpRegDet = New System.Windows.Forms.GroupBox
        Me.GrpDetLast = New DevExpress.XtraEditors.GroupControl
        Me.GrdRet_Prev = New DevExpress.XtraGrid.GridControl
        Me.gvRet_Prev = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmdDelete_Prev = New DevExpress.XtraEditors.SimpleButton
        Me.cmdADD_Prev = New DevExpress.XtraEditors.SimpleButton
        Me.txtRet_Qty = New DevExpress.XtraEditors.TextEdit
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtBatch_No = New DevExpress.XtraEditors.TextEdit
        Me.Label12 = New System.Windows.Forms.Label
        Me.lkupProd_Last = New DevExpress.XtraEditors.LookUpEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmdReport = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grpOld, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpOld.SuspendLayout()
        CType(Me.lkupCustNameLast.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtChallan_Dt_Last.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChallanNoLast.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdoOption.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpReg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpReg.SuspendLayout()
        CType(Me.lkupChallan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupCust.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChallanDt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtRetDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRetNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrpChallan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpChallan.SuspendLayout()
        CType(Me.grdChallan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvChallan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.grdReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpRegDet.SuspendLayout()
        CType(Me.GrpDetLast, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpDetLast.SuspendLayout()
        CType(Me.GrdRet_Prev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRet_Prev, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRet_Qty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBatch_No.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupProd_Last.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grpOld)
        Me.GroupControl1.Controls.Add(Me.rdoOption)
        Me.GroupControl1.Controls.Add(Me.grpReg)
        Me.GroupControl1.Controls.Add(Me.dtRetDate)
        Me.GroupControl1.Controls.Add(Me.txtRetNo)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(552, 160)
        Me.GroupControl1.TabIndex = 0
        '
        'grpOld
        '
        Me.grpOld.Controls.Add(Me.lkupCustNameLast)
        Me.grpOld.Controls.Add(Me.Label10)
        Me.grpOld.Controls.Add(Me.dtChallan_Dt_Last)
        Me.grpOld.Controls.Add(Me.Label9)
        Me.grpOld.Controls.Add(Me.txtChallanNoLast)
        Me.grpOld.Controls.Add(Me.Label8)
        Me.grpOld.Location = New System.Drawing.Point(8, 48)
        Me.grpOld.Name = "grpOld"
        Me.grpOld.Size = New System.Drawing.Size(376, 104)
        Me.grpOld.TabIndex = 17
        Me.grpOld.Visible = False
        '
        'lkupCustNameLast
        '
        Me.lkupCustNameLast.Location = New System.Drawing.Point(96, 72)
        Me.lkupCustNameLast.Name = "lkupCustNameLast"
        '
        '
        '
        Me.lkupCustNameLast.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupCustNameLast.Properties.NullText = ""
        Me.lkupCustNameLast.Size = New System.Drawing.Size(272, 20)
        Me.lkupCustNameLast.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Customer Name:"
        '
        'dtChallan_Dt_Last
        '
        Me.dtChallan_Dt_Last.EditValue = Nothing
        Me.dtChallan_Dt_Last.Location = New System.Drawing.Point(96, 48)
        Me.dtChallan_Dt_Last.Name = "dtChallan_Dt_Last"
        '
        '
        '
        Me.dtChallan_Dt_Last.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtChallan_Dt_Last.Size = New System.Drawing.Size(96, 20)
        Me.dtChallan_Dt_Last.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Challan Date:"
        '
        'txtChallanNoLast
        '
        Me.txtChallanNoLast.EditValue = ""
        Me.txtChallanNoLast.Location = New System.Drawing.Point(96, 24)
        Me.txtChallanNoLast.Name = "txtChallanNoLast"
        Me.txtChallanNoLast.Size = New System.Drawing.Size(96, 20)
        Me.txtChallanNoLast.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Challan No:"
        '
        'rdoOption
        '
        Me.rdoOption.Location = New System.Drawing.Point(392, 24)
        Me.rdoOption.Name = "rdoOption"
        '
        '
        '
        Me.rdoOption.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("C", "Current Year"), New DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Previous Year")})
        Me.rdoOption.Size = New System.Drawing.Size(152, 48)
        Me.rdoOption.TabIndex = 16
        '
        'grpReg
        '
        Me.grpReg.Controls.Add(Me.lkupChallan)
        Me.grpReg.Controls.Add(Me.Label3)
        Me.grpReg.Controls.Add(Me.lkupCust)
        Me.grpReg.Controls.Add(Me.lkupProduct)
        Me.grpReg.Controls.Add(Me.Label7)
        Me.grpReg.Controls.Add(Me.Label6)
        Me.grpReg.Controls.Add(Me.txtChallanDt)
        Me.grpReg.Controls.Add(Me.Label5)
        Me.grpReg.Controls.Add(Me.txtCustName)
        Me.grpReg.Controls.Add(Me.Label4)
        Me.grpReg.Location = New System.Drawing.Point(8, 48)
        Me.grpReg.Name = "grpReg"
        Me.grpReg.ShowCaption = False
        Me.grpReg.Size = New System.Drawing.Size(376, 106)
        Me.grpReg.TabIndex = 15
        '
        'lkupChallan
        '
        Me.lkupChallan.Location = New System.Drawing.Point(96, 56)
        Me.lkupChallan.Name = "lkupChallan"
        '
        '
        '
        Me.lkupChallan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupChallan.Properties.NullText = ""
        Me.lkupChallan.Size = New System.Drawing.Size(272, 20)
        Me.lkupChallan.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Challan No:"
        '
        'lkupCust
        '
        Me.lkupCust.Location = New System.Drawing.Point(96, 32)
        Me.lkupCust.Name = "lkupCust"
        '
        '
        '
        Me.lkupCust.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupCust.Properties.NullText = ""
        Me.lkupCust.Size = New System.Drawing.Size(272, 20)
        Me.lkupCust.TabIndex = 14
        '
        'lkupProduct
        '
        Me.lkupProduct.Location = New System.Drawing.Point(96, 8)
        Me.lkupProduct.Name = "lkupProduct"
        '
        '
        '
        Me.lkupProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupProduct.Properties.NullText = ""
        Me.lkupProduct.Size = New System.Drawing.Size(272, 20)
        Me.lkupProduct.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 24)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Customer Name:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Product:"
        '
        'txtChallanDt
        '
        Me.txtChallanDt.EditValue = ""
        Me.txtChallanDt.Location = New System.Drawing.Point(96, 80)
        Me.txtChallanDt.Name = "txtChallanDt"
        '
        '
        '
        Me.txtChallanDt.Properties.ReadOnly = True
        Me.txtChallanDt.Size = New System.Drawing.Size(96, 20)
        Me.txtChallanDt.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Challan Date:"
        '
        'txtCustName
        '
        Me.txtCustName.EditValue = ""
        Me.txtCustName.Location = New System.Drawing.Point(96, 80)
        Me.txtCustName.Name = "txtCustName"
        '
        '
        '
        Me.txtCustName.Properties.ReadOnly = True
        Me.txtCustName.Size = New System.Drawing.Size(272, 20)
        Me.txtCustName.TabIndex = 4
        Me.txtCustName.Visible = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Customer Name:"
        Me.Label4.Visible = False
        '
        'dtRetDate
        '
        Me.dtRetDate.EditValue = Nothing
        Me.dtRetDate.Location = New System.Drawing.Point(280, 24)
        Me.dtRetDate.Name = "dtRetDate"
        '
        '
        '
        Me.dtRetDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtRetDate.Size = New System.Drawing.Size(104, 20)
        Me.dtRetDate.TabIndex = 1
        '
        'txtRetNo
        '
        Me.txtRetNo.EditValue = ""
        Me.txtRetNo.Location = New System.Drawing.Point(104, 24)
        Me.txtRetNo.Name = "txtRetNo"
        Me.txtRetNo.Size = New System.Drawing.Size(88, 20)
        Me.txtRetNo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(208, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Return Date:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Return No:"
        '
        'GrpChallan
        '
        Me.GrpChallan.Controls.Add(Me.grdChallan)
        Me.GrpChallan.Location = New System.Drawing.Point(8, 16)
        Me.GrpChallan.Name = "GrpChallan"
        Me.GrpChallan.Size = New System.Drawing.Size(232, 200)
        Me.GrpChallan.TabIndex = 1
        Me.GrpChallan.Text = "Challan Details"
        '
        'grdChallan
        '
        '
        '
        '
        Me.grdChallan.EmbeddedNavigator.Name = ""
        Me.grdChallan.Location = New System.Drawing.Point(8, 24)
        Me.grdChallan.MainView = Me.gvChallan
        Me.grdChallan.Name = "grdChallan"
        Me.grdChallan.Size = New System.Drawing.Size(216, 168)
        Me.grdChallan.TabIndex = 5
        Me.grdChallan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvChallan})
        '
        'gvChallan
        '
        Me.gvChallan.GridControl = Me.grdChallan
        Me.gvChallan.Name = "gvChallan"
        Me.gvChallan.OptionsBehavior.Editable = False
        Me.gvChallan.OptionsView.ShowFilterPanel = False
        Me.gvChallan.OptionsView.ShowGroupedColumns = True
        Me.gvChallan.OptionsView.ShowGroupPanel = False
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(240, 88)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(40, 24)
        Me.cmdAdd.TabIndex = 6
        Me.cmdAdd.Text = ">"
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(240, 144)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(40, 24)
        Me.cmdDelete.TabIndex = 3
        Me.cmdDelete.Text = "<"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.grdReturn)
        Me.GroupControl3.Location = New System.Drawing.Point(280, 16)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(264, 200)
        Me.GroupControl3.TabIndex = 4
        Me.GroupControl3.Text = "Goods Return Details"
        '
        'grdReturn
        '
        '
        '
        '
        Me.grdReturn.EmbeddedNavigator.Name = ""
        Me.grdReturn.Location = New System.Drawing.Point(8, 24)
        Me.grdReturn.MainView = Me.gvRet
        Me.grdReturn.Name = "grdReturn"
        Me.grdReturn.Size = New System.Drawing.Size(248, 168)
        Me.grdReturn.TabIndex = 7
        Me.grdReturn.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvRet})
        '
        'gvRet
        '
        Me.gvRet.GridControl = Me.grdReturn
        Me.gvRet.Name = "gvRet"
        Me.gvRet.OptionsCustomization.AllowColumnMoving = False
        Me.gvRet.OptionsCustomization.AllowFilter = False
        Me.gvRet.OptionsCustomization.AllowGroup = False
        Me.gvRet.OptionsDetail.ShowDetailTabs = False
        Me.gvRet.OptionsView.ShowGroupPanel = False
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(504, 408)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(56, 24)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "&Cancel"
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(440, 408)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(56, 24)
        Me.cmdSave.TabIndex = 8
        Me.cmdSave.Text = "&Save"
        '
        'GrpRegDet
        '
        Me.GrpRegDet.Controls.Add(Me.GrpChallan)
        Me.GrpRegDet.Controls.Add(Me.GroupControl3)
        Me.GrpRegDet.Controls.Add(Me.cmdAdd)
        Me.GrpRegDet.Controls.Add(Me.cmdDelete)
        Me.GrpRegDet.Location = New System.Drawing.Point(8, 176)
        Me.GrpRegDet.Name = "GrpRegDet"
        Me.GrpRegDet.Size = New System.Drawing.Size(552, 224)
        Me.GrpRegDet.TabIndex = 10
        Me.GrpRegDet.TabStop = False
        '
        'GrpDetLast
        '
        Me.GrpDetLast.Controls.Add(Me.GrdRet_Prev)
        Me.GrpDetLast.Controls.Add(Me.cmdDelete_Prev)
        Me.GrpDetLast.Controls.Add(Me.cmdADD_Prev)
        Me.GrpDetLast.Controls.Add(Me.txtRet_Qty)
        Me.GrpDetLast.Controls.Add(Me.Label13)
        Me.GrpDetLast.Controls.Add(Me.txtBatch_No)
        Me.GrpDetLast.Controls.Add(Me.Label12)
        Me.GrpDetLast.Controls.Add(Me.lkupProd_Last)
        Me.GrpDetLast.Controls.Add(Me.Label11)
        Me.GrpDetLast.Location = New System.Drawing.Point(8, 168)
        Me.GrpDetLast.Name = "GrpDetLast"
        Me.GrpDetLast.Size = New System.Drawing.Size(552, 232)
        Me.GrpDetLast.TabIndex = 11
        Me.GrpDetLast.Visible = False
        '
        'GrdRet_Prev
        '
        '
        '
        '
        Me.GrdRet_Prev.EmbeddedNavigator.Name = ""
        Me.GrdRet_Prev.Location = New System.Drawing.Point(8, 80)
        Me.GrdRet_Prev.MainView = Me.gvRet_Prev
        Me.GrdRet_Prev.Name = "GrdRet_Prev"
        Me.GrdRet_Prev.Size = New System.Drawing.Size(536, 144)
        Me.GrdRet_Prev.TabIndex = 13
        Me.GrdRet_Prev.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvRet_Prev})
        '
        'gvRet_Prev
        '
        Me.gvRet_Prev.GridControl = Me.GrdRet_Prev
        Me.gvRet_Prev.Name = "gvRet_Prev"
        Me.gvRet_Prev.OptionsBehavior.Editable = False
        Me.gvRet_Prev.OptionsCustomization.AllowColumnMoving = False
        Me.gvRet_Prev.OptionsCustomization.AllowFilter = False
        Me.gvRet_Prev.OptionsCustomization.AllowGroup = False
        Me.gvRet_Prev.OptionsCustomization.AllowRowSizing = True
        Me.gvRet_Prev.OptionsView.ShowGroupPanel = False
        '
        'cmdDelete_Prev
        '
        Me.cmdDelete_Prev.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdDelete_Prev.Location = New System.Drawing.Point(488, 48)
        Me.cmdDelete_Prev.Name = "cmdDelete_Prev"
        Me.cmdDelete_Prev.Size = New System.Drawing.Size(56, 24)
        Me.cmdDelete_Prev.TabIndex = 12
        Me.cmdDelete_Prev.Text = "&Delete"
        '
        'cmdADD_Prev
        '
        Me.cmdADD_Prev.Location = New System.Drawing.Point(424, 48)
        Me.cmdADD_Prev.Name = "cmdADD_Prev"
        Me.cmdADD_Prev.Size = New System.Drawing.Size(56, 24)
        Me.cmdADD_Prev.TabIndex = 11
        Me.cmdADD_Prev.Text = "&Add"
        '
        'txtRet_Qty
        '
        Me.txtRet_Qty.EditValue = ""
        Me.txtRet_Qty.Location = New System.Drawing.Point(272, 48)
        Me.txtRet_Qty.Name = "txtRet_Qty"
        Me.txtRet_Qty.Size = New System.Drawing.Size(96, 20)
        Me.txtRet_Qty.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label13.Location = New System.Drawing.Point(216, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 16)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Qty:"
        '
        'txtBatch_No
        '
        Me.txtBatch_No.EditValue = ""
        Me.txtBatch_No.Location = New System.Drawing.Point(72, 48)
        Me.txtBatch_No.Name = "txtBatch_No"
        Me.txtBatch_No.Size = New System.Drawing.Size(96, 20)
        Me.txtBatch_No.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(16, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Batch No:"
        '
        'lkupProd_Last
        '
        Me.lkupProd_Last.Location = New System.Drawing.Point(72, 24)
        Me.lkupProd_Last.Name = "lkupProd_Last"
        '
        '
        '
        Me.lkupProd_Last.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupProd_Last.Properties.NullText = ""
        Me.lkupProd_Last.Size = New System.Drawing.Size(296, 20)
        Me.lkupProd_Last.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(16, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 16)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Product:"
        '
        'cmdReport
        '
        Me.cmdReport.Location = New System.Drawing.Point(8, 408)
        Me.cmdReport.Name = "cmdReport"
        Me.cmdReport.Size = New System.Drawing.Size(56, 24)
        Me.cmdReport.TabIndex = 12
        Me.cmdReport.Text = "&Report"
        '
        'frmGoodsReturn
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(570, 440)
        Me.Controls.Add(Me.cmdReport)
        Me.Controls.Add(Me.GrpDetLast)
        Me.Controls.Add(Me.GrpRegDet)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGoodsReturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Goods Return"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grpOld, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpOld.ResumeLayout(False)
        CType(Me.lkupCustNameLast.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtChallan_Dt_Last.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChallanNoLast.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdoOption.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpReg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpReg.ResumeLayout(False)
        CType(Me.lkupChallan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupCust.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChallanDt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtRetDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRetNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrpChallan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpChallan.ResumeLayout(False)
        CType(Me.grdChallan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvChallan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.grdReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpRegDet.ResumeLayout(False)
        CType(Me.GrpDetLast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpDetLast.ResumeLayout(False)
        CType(Me.GrdRet_Prev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRet_Prev, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRet_Qty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBatch_No.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupProd_Last.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmGoodsReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            dtChallan.Columns.Add("FID", System.Type.GetType("System.String"))
            dtChallan.Columns.Add("Product", System.Type.GetType("System.String"))
            dtChallan.Columns.Add("BatchID", System.Type.GetType("System.String"))
            dtChallan.Columns.Add("Qty", System.Type.GetType("System.Double"))

            dtRet.Columns.Add("FID", System.Type.GetType("System.String"))
            dtRet.Columns.Add("Product", System.Type.GetType("System.String"))
            dtRet.Columns.Add("BatchID", System.Type.GetType("System.String"))
            dtRet.Columns.Add("Ret_Qty", System.Type.GetType("System.Double"))

            FillLookup("SELECT FGMaster.FGName, ChallanDetail.FID " _
                    & " FROM ChallanDetail INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID " _
                    & " GROUP BY FGMaster.FGName, ChallanDetail.FID " _
                    & " ORDER BY FGMaster.FGName ", "Challan", "Product", "ID", lkupProduct)


            FillLookup("SELECT CustomerMaster.CustName, CustomerMaster.CID " _
                & " FROM CustomerMaster INNER JOIN (ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) ON " _
                & " CustomerMaster.CID = ChallanMaster.CID " _
                & " GROUP BY CustomerMaster.CustName, CustomerMaster.CID ORDER BY CustomerMaster.CUSTNAME " _
                , "Cust", "Customer", "ID", lkupCust)


            FillLookup("SELECT CustomerMaster.CustName, CustomerMaster.CID " _
                & " FROM CustomerMaster " _
                & " GROUP BY CustomerMaster.CustName, CustomerMaster.CID ORDER BY CustomerMaster.CUSTNAME " _
                , "Cust", "Customer", "ID", lkupCustNameLast)

            FillLookup("SELECT FGMaster.FGName, FGMaster.FID " _
                & " FROM FGMaster INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID", "FGMaster", "Finish Good", "FID", lkupProd_Last)

            FillLookup("SELECT ChallanMaster.Challan_No, ChallanMaster.Challan_No " _
                & " FROM ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID", "Challan", "Challan No", "Challan Date", lkupChallan)

            If strCheck = "Add" Then
                'cmd = New OleDb.OleDbCommand
                'cmd.Connection = conn
                'cmd.CommandText = "Select Max(RetNo) from FG_Ret_Master where CY ='" & strCY.Trim & "'"
                'If IsDBNull(cmd.ExecuteScalar) = True Then
                '    txtRetNo.Text = 1
                'Else
                '    txtRetNo.Text = Val(cmd.ExecuteScalar + 1)
                'End If
                'cmd.Dispose()

                txtRetNo.Text = (GetMaxNo("RetNo", "FG_Ret_Master", "", 6, strCY)) & "/" & strCY.Trim
                rdoOption.SelectedIndex = 0
                dtRetDate.EditValue = Now

            ElseIf strCheck = "Edit" Then
                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn
                cmd.CommandText = "Select * from FG_Ret_Master where RetNo ='" & ModMain.strgridid & "'" ' and CY ='" & strCY.Trim & "'"
                dr = cmd.ExecuteReader
                dr.Read()
                Bind_Data()
                cmd.Dispose()

                Dim sql As String
                sql = " SELECT FG_Ret_Det.FID, FGMaster.FGName as Product, FG_Ret_Det.BatchID, FG_Ret_Det.Ret_Qty as [Ret_Qty], FG_Ret_Det.RetNo " _
                    & " FROM (FG_Ret_Master INNER JOIN FG_Ret_Det ON FG_Ret_Master.RetNo = FG_Ret_Det.RetNo) INNER JOIN FGMaster ON FG_Ret_Det.FID = FGMaster.FID " _
                    & " WHERE (((FG_Ret_Det.RetNo)='" & ModMain.strgridid.Trim & "'));" ' and FG_Ret_Det.CY ='" & strCY.Trim & "'

                dtRet.Rows.Clear()
                Dim Adpt As New OleDb.OleDbDataAdapter(sql, conn)
                Adpt.Fill(dtRet)

                If rdoOption.SelectedIndex = 0 Then
                    grdReturn.DataSource = dtRet
                    gvRet.Columns("FID").VisibleIndex = -1
                    GroupControl3.Enabled = False
                    cmdAdd.Enabled = False
                    cmdDelete.Enabled = False
                Else
                    GrpDetLast.Visible = True
                    GrdRet_Prev.DataSource = dtRet
                    gvRet_Prev.Columns("FID").VisibleIndex = -1
                    cmdADD_Prev.Enabled = False
                    cmdDelete.Enabled = False
                End If
                cmdDelete_Prev.Enabled = False
            End If

        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub Bind_Data()
        Try
            txtRetNo.Text = ModMain.strgridid.Trim
            If IsDBNull(dr.Item("RetDate")) = True Then
                dtRetDate.EditValue = ""
            Else
                dtRetDate.EditValue = dr.Item("RetDate")
            End If

            rdoOption.EditValue = dr.Item("Year")
            Dim strChallaNo As String = dr.Item("Challan_No")
            Dim strCID As String
            If dr.Item("Year") = "P" Then
                txtChallanNoLast.Text = strChallaNo.Trim.Trim
                dtChallan_Dt_Last.EditValue = dr.Item("Challan_Dt")
                strCID = dr.Item("CID")
                grpOld.Visible = True
            End If
            dr.Close()


            If rdoOption.EditValue = "P" Then
                lkupCustNameLast.EditValue = strCID
            Else
                grpReg.Visible = True
                If strChallaNo.ToString = "" Then
                    lkupChallan.EditValue = ""
                Else
                    lkupChallan.EditValue = strChallaNo
                End If
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub lkupChallan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupChallan.EditValueChanged
        Try
            If lkupChallan.EditValue <> "" Then
                Dim row As DataRowView = lkupChallan.Properties.GetDataSourceRowByKeyValue(lkupChallan.EditValue)

                Dim strsql As String
                Dim ds As New DataSet
                strsql = "SELECT CustomerMaster.CustName, ChallanMaster.Challan_dt " _
                    & " FROM ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID " _
                    & " WHERE (((ChallanMaster.Challan_No)='" & lkupChallan.Text & "')) " 'and ChallanMaster.CY ='" & strCY.Trim & "';"
                Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
                adp.Fill(ds, "Challan")
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    txtChallanDt.Text = ds.Tables(0).Rows(i).Item("Challan_dt")
                    txtCustName.Text = ds.Tables(0).Rows(i).Item("CustName")
                Next
                adp.Dispose()

                strsql = "SELECT ChallanDetail.FID, FGMaster.FGName as Product, ChallanDetail.BatchID, ChallanDetail.Qty" _
                    & " FROM (ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID " _
                    & " WHERE (((ChallanDetail.Challan_No)='" & lkupChallan.Text & "')) " 'and ChallanDetail.CY ='" & strCY.Trim & "'"
                Dim adpt As New OleDb.OleDbDataAdapter(strsql, conn)
                dtChallan.Rows.Clear()
                adpt.Fill(ds, "ChallanDet")
                grdChallan.DataSource = ds.Tables(1)
                gvChallan.Columns("FID").Visible = False
                adpt.Dispose()
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try

            Dim blnDup As Boolean = False
            For i As Integer = 0 To gvRet.RowCount - 1
                If gvChallan.GetRowCellValue(gvChallan.FocusedRowHandle, gvChallan.Columns("Product")).ToString = gvRet.GetRowCellValue(i, "Product") And _
                   gvChallan.GetRowCellValue(gvChallan.FocusedRowHandle, "BatchID") = gvRet.GetRowCellValue(i, "BatchID") Then
                    blnDup = True
                    Exit For
                End If
            Next
            If blnDup = False Then
                If gvChallan.RowCount > 0 Then
                    Dim DRow As DataRow
                    DRow = dtRet.NewRow
                    DRow.Item("FID") = gvChallan.GetFocusedRowCellValue("FID")
                    DRow.Item("Product") = gvChallan.GetFocusedRowCellValue("Product")
                    DRow.Item("BatchID") = gvChallan.GetFocusedRowCellValue("BatchID")
                    DRow.Item("Ret_Qty") = gvChallan.GetFocusedRowCellValue("Qty")
                    dtRet.Rows.Add(DRow)
                    grdReturn.DataSource = dtRet
                    gvRet.Columns(0).Visible = False
                End If
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show("You have all ready added this product.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub gvRet_CustomRowCellEdit(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gvRet.CustomRowCellEdit
        Try
            If e.Column.FieldName = "Ret_Qty" Then
                gvRet.Columns("Ret_Qty").OptionsColumn.AllowEdit = True
            Else
                gvRet.Columns(e.Column.FieldName).OptionsColumn.AllowEdit = False
            End If
        Catch ex As Exception
            If show_error = True Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            gvRet.DeleteRow(gvRet.FocusedRowHandle)
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Try
            Me.Close()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If CheckData() = True Then
                If strCheck = "Add" Then
                    cmd = New OleDb.OleDbCommand
                    cmd.Connection = conn
                    cmd.Transaction = conn.BeginTransaction
                    If rdoOption.SelectedIndex = 0 Then
                        'MessageBox.Show("0")
                        cmd.CommandText = "Insert into FG_Ret_Master values ('" & txtRetNo.Text & "','" & dtRetDate.EditValue & "','" & lkupChallan.Text & "','" & txtChallanDt.Text & "','" & lkupCust.Tag & "','" & rdoOption.EditValue & "','" & strCY.Trim & "')"
                    Else
                        cmd.CommandText = "Insert into FG_Ret_Master values ('" & txtRetNo.Text & "','" & dtRetDate.EditValue & "','" & txtChallanNoLast.Text.Trim & "','" & dtChallan_Dt_Last.EditValue & "','" & lkupCustNameLast.Tag & "','" & rdoOption.EditValue & "','" & strCY.Trim & "')"
                    End If
                    cmd.ExecuteNonQuery()
                    If rdoOption.SelectedIndex = 0 Then

                        For i As Integer = 0 To gvRet.RowCount - 1
                            cmd.CommandText = "Insert into FG_Ret_Det values ('" & txtRetNo.Text & "','" & gvRet.GetRowCellValue(i, "FID") & "','" & gvRet.GetRowCellValue(i, "BatchID") & "'," & gvRet.GetRowCellValue(i, "Ret_Qty") & ",'" & strCY.Trim & "')"
                            cmd.ExecuteNonQuery()

                            cmd.CommandText = "Update FGStock set Ret_Qty = val(Ret_Qty + " & gvRet.GetRowCellValue(i, "Ret_Qty") & "),Balance_Qty = val(Balance_Qty + " & gvRet.GetRowCellValue(i, "Ret_Qty") & ") where FID= '" & gvRet.GetRowCellValue(i, "FID") & "' and Batch_No ='" & gvRet.GetRowCellValue(i, "BatchID") & "'" ' and CY ='" & strCY.Trim & "'"
                            cmd.ExecuteNonQuery()
                        Next
                    Else
                        For i As Integer = 0 To gvRet_Prev.RowCount - 1
                            cmd.CommandText = "Insert into FG_Ret_Det values ('" & txtRetNo.Text & "','" & gvRet_Prev.GetRowCellValue(i, "FID") & "','" & gvRet_Prev.GetRowCellValue(i, "BatchID") & "'," & gvRet_Prev.GetRowCellValue(i, "Ret_Qty") & ",'" & strCY.Trim & "')"
                            cmd.ExecuteNonQuery()

                            cmd.CommandText = "Select count(*) from FGStock where FID= '" & gvRet_Prev.GetRowCellValue(i, "FID") & "' and Batch_No ='" & gvRet_Prev.GetRowCellValue(i, "BatchID") & "' and CY ='" & strCY.Trim & "'"
                            Dim intCount As Integer
                            intCount = cmd.ExecuteScalar
                            If intCount = 0 Then
                                cmd.CommandText = "Insert into FGStock values('" & gvRet_Prev.GetRowCellValue(i, "FID") & "','" & dtRetDate.EditValue & "','" & gvRet_Prev.GetRowCellValue(i, "BatchID") & "','Return',0,0," & gvRet_Prev.GetRowCellValue(i, "Ret_Qty") & "," & gvRet_Prev.GetRowCellValue(i, "Ret_Qty") & ",'" & strCY.Trim & "')"
                                cmd.ExecuteNonQuery()
                            Else
                                cmd.CommandText = "Update FGStock set Ret_Qty = val(Ret_Qty + " & gvRet_Prev.GetRowCellValue(i, "Ret_Qty") & "),Balance_Qty = val(Balance_Qty + " & gvRet_Prev.GetRowCellValue(i, "Ret_Qty") & ") where FID= '" & gvRet_Prev.GetRowCellValue(i, "FID") & "' and Batch_No ='" & gvRet_Prev.GetRowCellValue(i, "BatchID") & "' and CY ='" & strCY.Trim & "'"
                                cmd.ExecuteNonQuery()
                            End If
                        Next
                    End If
                    cmd.Transaction.Commit()
                ElseIf strCheck = "Edit" Then
                    'Code for Edit
                End If
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Save Data Successfully", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                cmdSave.Enabled = False
                Me.Close()
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
            cmd.Transaction.Rollback()
        End Try
    End Sub
    Private Function CheckData() As Boolean
        Try
            If rdoOption.SelectedIndex = 0 Then
                If txtRetNo.Text = "" Or dtRetDate.Text = "" Or lkupChallan.Text = "" Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("Enter Return no or retrun date or challan no.")
                    Return False
                End If
            ElseIf rdoOption.SelectedIndex = 1 Then
                If txtRetNo.Text = "" Or dtRetDate.Text = "" Or txtChallanNoLast.Text.Trim = "" Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("Enter Return no or retrun date or challan no.")
                    Return False
                End If
            End If
            If strCheck = "Add" Then
                If IsDuplicate("Select count(RetNo) from FG_Ret_Master where Retno=" & txtRetNo.Text & " and CY ='" & strCY.Trim & "'") = True Then
                    DevExpress.XtraEditors.XtraMessageBox.Show("Duplicate Return No.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If
            End If
            Return True
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Function

    Private Sub lkupProduct_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupProduct.EditValueChanged
        Try
            If lkupProduct.EditValue <> "" Then
                Dim row As DataRowView = lkupProduct.Properties.GetDataSourceRowByKeyValue(lkupProduct.EditValue)
                If row(1) Is Nothing Then Exit Sub
                lkupProduct.Tag = row(1).ToString
                If lkupProduct.Tag <> "" Then
                    'FillLookup("SELECT ChallanDetail.Challan_No, ChallanMaster.CID " _
                    '  & " FROM ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No " _
                    '  & " GROUP BY ChallanDetail.Challan_No, ChallanMaster.CID, ChallanDetail.FID " _
                    '  & " HAVING (((ChallanMaster.FID)='" & lkupProduct.Tag & "'))", "Cust", "Customer", "ID", lkupCust)


                    FillLookup("SELECT CustomerMaster.CustName, CustomerMaster.CID " _
                        & " FROM CustomerMaster INNER JOIN (ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) ON " _
                        & " CustomerMaster.CID = ChallanMaster.CID " _
                        & " GROUP BY CustomerMaster.CustName, CustomerMaster.CID, ChallanDetail.FID " _
                        & " HAVING (((ChallanDetail.FID)='" & lkupProduct.Tag & "')) " _
                        & " ORDER BY CustomerMaster.CUSTNAME " _
                        , "Cust", "Customer", "ID", lkupCust)

                End If
                If lkupProduct.Tag <> "" And lkupCust.Tag <> "" Then
                    FillLookup("SELECT ChallanMaster.Challan_No,ChallanMaster.Challan_No " _
                        & " FROM ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No " _
                        & " Group by ChallanMaster.Challan_No,ChallanDetail.FID,ChallanMaster.CID " _
                        & " HAVING (((ChallanDetail.FID)='" & lkupProduct.Tag & "') AND ((ChallanMaster.CID)='" & lkupCust.Tag & "'))", "Challan", "Challan No", "", lkupChallan)
                ElseIf lkupProduct.Tag <> "" And lkupCust.Tag = Nothing Then
                    FillLookup("SELECT ChallanMaster.Challan_No, ChallanMaster.Challan_No" _
                       & " FROM ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No " _
                       & " GROUP BY ChallanMaster.Challan_No, ChallanDetail.FID ,ChallanMaster.CID " _
                       & " HAVING (((ChallanDetail.FID)='" & lkupProduct.Tag & "'))", "Cust", "Customer", "ID", lkupChallan)
                End If
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub lkupCust_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupCust.EditValueChanged
        Try
            If lkupCust.EditValue <> "" Then
                Dim row As DataRowView = lkupCust.Properties.GetDataSourceRowByKeyValue(lkupCust.EditValue)
                If row(1) Is Nothing Then Exit Sub
                lkupCust.Tag = row(1).ToString
                If lkupCust.Tag <> "" And lkupProduct.Tag <> "" Then
                    FillLookup("SELECT ChallanMaster.Challan_No,ChallanMaster.Challan_No " _
                        & " FROM ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No " _
                        & " Group by ChallanMaster.Challan_No,ChallanDetail.FID,ChallanMaster.CID " _
                        & " HAVING ChallanDetail.FID='" & lkupProduct.Tag & "' AND ChallanMaster.CID='" & lkupCust.Tag & "'", "Challan", "Challan No", "ID", lkupChallan)

                ElseIf lkupCust.Tag <> "" And lkupProduct.Tag = Nothing Then
                    FillLookup("SELECT ChallanMaster.Challan_No,ChallanMaster.Challan_No " _
                      & " FROM ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No " _
                      & " Group by ChallanMaster.Challan_No,ChallanMaster.CID " _
                      & " HAVING ((ChallanMaster.CID)='" & lkupCust.Tag & "')", "Challan", "Challan No", "ID", lkupChallan)
                End If
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub rdoOption_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoOption.SelectedIndexChanged
        Try
            If strCheck = "Add" Then
                If rdoOption.SelectedIndex = 0 Then
                    grpReg.Visible = True
                    grpOld.Visible = False
                    GrpDetLast.Visible = False

                Else
                    grpReg.Visible = False
                    grpOld.Visible = True
                    GrpDetLast.Visible = True
                End If
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdADD_Prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdADD_Prev.Click
        Try
            If lkupProd_Last.Text <> "" And txtBatch_No.Text.Trim <> "" And txtRet_Qty.Text.Trim <> "" Then
                Dim DRow As DataRow
                DRow = dtRet.NewRow
                DRow.Item("FID") = lkupProd_Last.Tag
                DRow.Item("Product") = lkupProd_Last.Text
                DRow.Item("BatchID") = txtBatch_No.Text
                DRow.Item("Ret_Qty") = txtRet_Qty.Text
                dtRet.Rows.Add(DRow)
                GrdRet_Prev.DataSource = dtRet
                gvRet_Prev.Columns(0).Visible = False
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show("Enter product and batch no and qty.", "Enter Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub txtRet_Qty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRet_Qty.KeyPress
        Try
            e.Handled = IsDecimalNumber(e.KeyChar)
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdDelete_Prev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete_Prev.Click
        Try
            'If gvRet_Prev.GetSelectedRows.Length > 0 Then
            'If DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to delete this record ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            '    gvRet_Prev.DeleteRow(gvRet_Prev.FocusedRowHandle)
            '    'gvRet_Prev.RefreshData()
            'End If
            'End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub lkupProd_Last_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupProd_Last.EditValueChanged
        Try
            If lkupProd_Last.EditValue = Nothing Then Exit Sub
            If lkupProd_Last.EditValue <> "" Then
                Dim row As DataRowView = lkupProd_Last.Properties.GetDataSourceRowByKeyValue(lkupProd_Last.EditValue)
                lkupProd_Last.Tag = row(1)
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub lkupCustNameLast_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupCustNameLast.EditValueChanged
        Try
            If lkupCustNameLast.EditValue = Nothing Then Exit Sub
            If lkupCustNameLast.EditValue <> "" Then
                Dim row As DataRowView = lkupCustNameLast.Properties.GetDataSourceRowByKeyValue(lkupCustNameLast.EditValue)
                lkupCustNameLast.Tag = row(1)
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReport.Click
        Try
            Dim myrpt As New frmPara
            myrpt.showGoodsRet(txtRetNo.Text)
            myrpt.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
End Class

