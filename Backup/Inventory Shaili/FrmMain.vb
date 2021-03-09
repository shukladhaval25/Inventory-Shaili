
Public Class FrmMain
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
    Private WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Private WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Private WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Private WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents Bar3 As DevExpress.XtraBars.Bar
    Private WithEvents tBtnCust As DevExpress.XtraBars.BarLargeButtonItem
    Private WithEvents BarManagerMain As DevExpress.XtraBars.BarManager
    Friend WithEvents DefaultLook As DevExpress.LookAndFeel.DefaultLookAndFeel
    Private WithEvents barBtnMaster As DevExpress.XtraBars.BarSubItem
    Private WithEvents BarCheckItem1 As DevExpress.XtraBars.BarCheckItem
    Private WithEvents tbtnUser As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tBtnCustomer As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tBtnSupplier As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tBtnUnit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tBtnRaw As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tBtnFinishGood As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tBtnItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pnlMain As DevExpress.XtraEditors.PanelControl
    Private WithEvents gdMain As DevExpress.XtraGrid.GridControl
    Private WithEvents gvMain As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents CmdEdit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAdd As DevExpress.XtraEditors.SimpleButton
    Private WithEvents tBtnExit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnBatch As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnGroup As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnPO As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnUnitConv As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnRejection As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tBTnInvoice As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tBtnchallan As DevExpress.XtraBars.BarSubItem
    Private WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tBtnChallanm As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnReport As DevExpress.XtraBars.BarSubItem
    Private WithEvents tbtnPOrpt As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tBTnOrderrpt As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblTableName As System.Windows.Forms.Label
    Private WithEvents tBTnDispose As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tBTnNonCon As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tBTnrptDisposition As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tBtnrptNonCon As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnRequisition As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnQC As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tBTnFGOpStock As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tBTnRMOpStock As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnRMStock As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnMatIssue As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tBtnQCFG As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tBtnFGQCRpt As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnFGStock As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnRMList As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnFGList As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnCustList As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnSuppList As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbrnChallan As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnMIS As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnSterilization As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnBOM As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnRMVI As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnPendingMIS As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnCompMaster As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Private WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Private WithEvents tbtnSales As DevExpress.XtraBars.BarSubItem
    Private WithEvents tbtnPurchase As DevExpress.XtraBars.BarSubItem
    Private WithEvents tbtnProduction As DevExpress.XtraBars.BarSubItem
    Private WithEvents tbtnMaster As DevExpress.XtraBars.BarSubItem
    Private WithEvents tbtnstatutory As DevExpress.XtraBars.BarSubItem
    Private WithEvents tbtnChangePass As DevExpress.XtraBars.BarButtonItem
    Private WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Private WithEvents tbtnLogoff As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnBatchReg As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnInwardTriplicate As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnRMCompReg As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnFGCompReg As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnCWPWSales As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnPWCWSales As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnRecall As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnJobWorkIssue As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnJobWorkRet As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnRMGroup As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtFGGroup As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnTRInward As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnGoodsRet As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnPurchaseReg As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnSalesReg As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnBatch_Stock_Reg As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnBackup As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnRMStockCons As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnFGStockCons As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnCW_BW_Sales As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnBW_CW_Sales As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnTradingInward As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnComChart As DevExpress.XtraEditors.SimpleButton
    Private WithEvents tbtnPendSterz As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnMinMax As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnPendingOrders As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnDemoSales As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnMinMaxRM As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnBalanceCF As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnGroupwiseRpt As DevExpress.XtraBars.BarSubItem
    Private WithEvents tbtnGroupWise As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnCWPW_Cons As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnPWCWSales_Cons As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtndemoIssue As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnDemoReturn As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnGoodRetRep As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents tbtnDailyBook As DevExpress.XtraBars.BarButtonItem
    Private WithEvents tbtnPWBW As DevExpress.XtraBars.BarButtonItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.BarManagerMain = New DevExpress.XtraBars.BarManager
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.barBtnMaster = New DevExpress.XtraBars.BarSubItem
        Me.tbtnUser = New DevExpress.XtraBars.BarButtonItem
        Me.tBtnCustomer = New DevExpress.XtraBars.BarButtonItem
        Me.tBtnSupplier = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnGroup = New DevExpress.XtraBars.BarButtonItem
        Me.tBtnUnit = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnUnitConv = New DevExpress.XtraBars.BarButtonItem
        Me.tBtnRaw = New DevExpress.XtraBars.BarButtonItem
        Me.tBtnFinishGood = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnBatch = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnRejection = New DevExpress.XtraBars.BarButtonItem
        Me.tBTnNonCon = New DevExpress.XtraBars.BarButtonItem
        Me.tBTnRMOpStock = New DevExpress.XtraBars.BarButtonItem
        Me.tBTnFGOpStock = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnCompMaster = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnBalanceCF = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnChangePass = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnBackup = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnLogoff = New DevExpress.XtraBars.BarButtonItem
        Me.tBtnchallan = New DevExpress.XtraBars.BarSubItem
        Me.tbtnPO = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnQC = New DevExpress.XtraBars.BarButtonItem
        Me.tBTnInvoice = New DevExpress.XtraBars.BarButtonItem
        Me.tBtnChallanm = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnRequisition = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnMatIssue = New DevExpress.XtraBars.BarButtonItem
        Me.tBtnQCFG = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnJobWorkIssue = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnJobWorkRet = New DevExpress.XtraBars.BarButtonItem
        Me.tBTnDispose = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnRecall = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnTRInward = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnGoodsRet = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnDailyBook = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnReport = New DevExpress.XtraBars.BarSubItem
        Me.tbtnSales = New DevExpress.XtraBars.BarSubItem
        Me.tBTnOrderrpt = New DevExpress.XtraBars.BarButtonItem
        Me.tbrnChallan = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnPendingOrders = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnPurchase = New DevExpress.XtraBars.BarSubItem
        Me.tbtnPOrpt = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnInwardTriplicate = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnTradingInward = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnProduction = New DevExpress.XtraBars.BarSubItem
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnMIS = New DevExpress.XtraBars.BarButtonItem
        Me.tBtnFGQCRpt = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnSterilization = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnMaster = New DevExpress.XtraBars.BarSubItem
        Me.tbtnCustList = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnSuppList = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnFGList = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnRMList = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnBOM = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnstatutory = New DevExpress.XtraBars.BarSubItem
        Me.tbtnRMStock = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnRMGroup = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnRMStockCons = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnFGStock = New DevExpress.XtraBars.BarButtonItem
        Me.tbtFGGroup = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnFGStockCons = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnRMCompReg = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnFGCompReg = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnRMVI = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnPendingMIS = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnPendSterz = New DevExpress.XtraBars.BarButtonItem
        Me.tBtnrptNonCon = New DevExpress.XtraBars.BarButtonItem
        Me.tBTnrptDisposition = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnBatchReg = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnPurchaseReg = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnSalesReg = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnMinMax = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnMinMaxRM = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnDemoSales = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnPWBW = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnGroupwiseRpt = New DevExpress.XtraBars.BarSubItem
        Me.tbtnCWPWSales = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnCWPW_Cons = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnCW_BW_Sales = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnPWCWSales = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnPWCWSales_Cons = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnBW_CW_Sales = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnBatch_Stock_Reg = New DevExpress.XtraBars.BarButtonItem
        Me.tbtndemoIssue = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnDemoReturn = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnGoodRetRep = New DevExpress.XtraBars.BarButtonItem
        Me.tBtnExit = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem
        Me.tBtnCust = New DevExpress.XtraBars.BarLargeButtonItem
        Me.BarCheckItem1 = New DevExpress.XtraBars.BarCheckItem
        Me.tBtnItem = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem
        Me.tbtnGroupWise = New DevExpress.XtraBars.BarButtonItem
        Me.DefaultLook = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.pnlMain = New DevExpress.XtraEditors.PanelControl
        Me.lblTableName = New System.Windows.Forms.Label
        Me.gdMain = New DevExpress.XtraGrid.GridControl
        Me.gvMain = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.btnComChart = New DevExpress.XtraEditors.SimpleButton
        Me.cmdDelete = New DevExpress.XtraEditors.SimpleButton
        Me.CmdEdit = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAdd = New DevExpress.XtraEditors.SimpleButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.BarManagerMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        CType(Me.gdMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarManagerMain
        '
        Me.BarManagerMain.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManagerMain.DockControls.Add(Me.barDockControlTop)
        Me.BarManagerMain.DockControls.Add(Me.barDockControlBottom)
        Me.BarManagerMain.DockControls.Add(Me.barDockControlLeft)
        Me.BarManagerMain.DockControls.Add(Me.barDockControlRight)
        Me.BarManagerMain.Form = Me
        Me.BarManagerMain.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarButtonItem1, Me.tBtnCust, Me.barBtnMaster, Me.BarCheckItem1, Me.tBtnchallan, Me.tbtnUser, Me.tBtnCustomer, Me.tBtnSupplier, Me.tBtnUnit, Me.tBtnRaw, Me.tBtnFinishGood, Me.tBtnItem, Me.tBtnExit, Me.tbtnBatch, Me.tbtnGroup, Me.tbtnPO, Me.BarButtonItem2, Me.tbtnQC, Me.tbtnUnitConv, Me.tbtnRejection, Me.tBTnInvoice, Me.BarButtonItem4, Me.tBtnChallanm, Me.tbtnReport, Me.tbtnPOrpt, Me.tBTnOrderrpt, Me.tBTnDispose, Me.tBTnNonCon, Me.tBTnrptDisposition, Me.tBtnrptNonCon, Me.tbtnRequisition, Me.tBTnRMOpStock, Me.tBTnFGOpStock, Me.tbtnRMStock, Me.tbtnMatIssue, Me.tBtnQCFG, Me.tBtnFGQCRpt, Me.tbtnBatchReg, Me.tbtnFGStock, Me.tbtnRMList, Me.tbtnFGList, Me.tbtnCustList, Me.tbtnSuppList, Me.tbrnChallan, Me.BarButtonItem5, Me.tbtnMIS, Me.tbtnSterilization, Me.BarButtonItem6, Me.tbtnBOM, Me.tbtnRMVI, Me.tbtnPendingMIS, Me.tbtnCompMaster, Me.BarEditItem1, Me.tbtnSales, Me.tbtnPurchase, Me.tbtnProduction, Me.tbtnMaster, Me.tbtnstatutory, Me.tbtnChangePass, Me.BarButtonItem7, Me.tbtnLogoff, Me.tbtnInwardTriplicate, Me.tbtnRMCompReg, Me.tbtnFGCompReg, Me.tbtnCWPWSales, Me.tbtnPWCWSales, Me.tbtnRecall, Me.tbtnJobWorkIssue, Me.tbtnJobWorkRet, Me.tbtnRMGroup, Me.tbtFGGroup, Me.tbtnTRInward, Me.tbtnGoodsRet, Me.tbtnPurchaseReg, Me.tbtnSalesReg, Me.tbtnBatch_Stock_Reg, Me.tbtnBackup, Me.tbtnRMStockCons, Me.tbtnFGStockCons, Me.tbtnCW_BW_Sales, Me.tbtnBW_CW_Sales, Me.tbtnTradingInward, Me.tbtnPendSterz, Me.tbtnMinMax, Me.tbtnPendingOrders, Me.tbtnDemoSales, Me.tbtnMinMaxRM, Me.tbtnPWBW, Me.tbtnBalanceCF, Me.tbtnGroupWise, Me.tbtnGroupwiseRpt, Me.tbtnCWPW_Cons, Me.tbtnPWCWSales_Cons, Me.tbtndemoIssue, Me.tbtnDemoReturn, Me.tbtnGoodRetRep, Me.tbtnDailyBook})
        Me.BarManagerMain.MaxItemId = 104
        Me.BarManagerMain.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        '
        'Bar3
        '
        Me.Bar3.BarName = "Custom 3"
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar3.FloatLocation = New System.Drawing.Point(68, 149)
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.barBtnMaster, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.tBtnchallan, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnReport), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.tBtnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar3.Text = "Custom 3"
        '
        'barBtnMaster
        '
        Me.barBtnMaster.Caption = "&Master"
        Me.barBtnMaster.Glyph = CType(resources.GetObject("barBtnMaster.Glyph"), System.Drawing.Image)
        Me.barBtnMaster.Id = 5
        Me.barBtnMaster.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.tbtnUser, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.tBtnCustomer), New DevExpress.XtraBars.LinkPersistInfo(Me.tBtnSupplier), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnGroup, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tBtnUnit), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnUnitConv), New DevExpress.XtraBars.LinkPersistInfo(Me.tBtnRaw), New DevExpress.XtraBars.LinkPersistInfo(Me.tBtnFinishGood), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnBatch), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnRejection, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tBTnNonCon), New DevExpress.XtraBars.LinkPersistInfo(Me.tBTnRMOpStock, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tBTnFGOpStock), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnCompMaster, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnBalanceCF), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnChangePass), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnBackup, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnLogoff)})
        Me.barBtnMaster.Name = "barBtnMaster"
        '
        'tbtnUser
        '
        Me.tbtnUser.Caption = "User"
        Me.tbtnUser.Id = 8
        Me.tbtnUser.Name = "tbtnUser"
        '
        'tBtnCustomer
        '
        Me.tBtnCustomer.Caption = "Customer"
        Me.tBtnCustomer.Id = 9
        Me.tBtnCustomer.Name = "tBtnCustomer"
        '
        'tBtnSupplier
        '
        Me.tBtnSupplier.Caption = "Supplier"
        Me.tBtnSupplier.Id = 10
        Me.tBtnSupplier.Name = "tBtnSupplier"
        '
        'tbtnGroup
        '
        Me.tbtnGroup.Caption = "&Group"
        Me.tbtnGroup.Id = 17
        Me.tbtnGroup.Name = "tbtnGroup"
        '
        'tBtnUnit
        '
        Me.tBtnUnit.Caption = "Unit"
        Me.tBtnUnit.Id = 11
        Me.tBtnUnit.Name = "tBtnUnit"
        '
        'tbtnUnitConv
        '
        Me.tbtnUnitConv.Caption = "Unit Conversion"
        Me.tbtnUnitConv.Id = 22
        Me.tbtnUnitConv.Name = "tbtnUnitConv"
        '
        'tBtnRaw
        '
        Me.tBtnRaw.Caption = "Raw material"
        Me.tBtnRaw.Id = 12
        Me.tBtnRaw.Name = "tBtnRaw"
        '
        'tBtnFinishGood
        '
        Me.tBtnFinishGood.Caption = "Finish Good"
        Me.tBtnFinishGood.Id = 13
        Me.tBtnFinishGood.Name = "tBtnFinishGood"
        '
        'tbtnBatch
        '
        Me.tbtnBatch.Caption = "&Bill of Material"
        Me.tbtnBatch.Id = 16
        Me.tbtnBatch.Name = "tbtnBatch"
        '
        'tbtnRejection
        '
        Me.tbtnRejection.Caption = "Reason for Rejection"
        Me.tbtnRejection.Id = 23
        Me.tbtnRejection.Name = "tbtnRejection"
        '
        'tBTnNonCon
        '
        Me.tBTnNonCon.Caption = "Non Conforming Product"
        Me.tBTnNonCon.Id = 31
        Me.tBTnNonCon.Name = "tBTnNonCon"
        '
        'tBTnRMOpStock
        '
        Me.tBTnRMOpStock.Caption = "Opening Stock of Raw Material"
        Me.tBTnRMOpStock.Id = 35
        Me.tBTnRMOpStock.Name = "tBTnRMOpStock"
        '
        'tBTnFGOpStock
        '
        Me.tBTnFGOpStock.Caption = "Opening Stock of Finish Goods"
        Me.tBTnFGOpStock.Id = 36
        Me.tBTnFGOpStock.Name = "tBTnFGOpStock"
        '
        'tbtnCompMaster
        '
        Me.tbtnCompMaster.Caption = "Company Master"
        Me.tbtnCompMaster.Id = 55
        Me.tbtnCompMaster.Name = "tbtnCompMaster"
        '
        'tbtnBalanceCF
        '
        Me.tbtnBalanceCF.Caption = "Closing Year"
        Me.tbtnBalanceCF.Id = 95
        Me.tbtnBalanceCF.Name = "tbtnBalanceCF"
        '
        'tbtnChangePass
        '
        Me.tbtnChangePass.Caption = "Change Password"
        Me.tbtnChangePass.Id = 63
        Me.tbtnChangePass.Name = "tbtnChangePass"
        '
        'tbtnBackup
        '
        Me.tbtnBackup.Caption = "&Back Up"
        Me.tbtnBackup.Id = 82
        Me.tbtnBackup.Name = "tbtnBackup"
        '
        'tbtnLogoff
        '
        Me.tbtnLogoff.Caption = "&Log off"
        Me.tbtnLogoff.Id = 66
        Me.tbtnLogoff.Name = "tbtnLogoff"
        '
        'tBtnchallan
        '
        Me.tBtnchallan.Caption = "&Transction"
        Me.tBtnchallan.Glyph = CType(resources.GetObject("tBtnchallan.Glyph"), System.Drawing.Image)
        Me.tBtnchallan.Id = 7
        Me.tBtnchallan.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnPO, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnQC), New DevExpress.XtraBars.LinkPersistInfo(Me.tBTnInvoice, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tBtnChallanm), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnRequisition, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnMatIssue), New DevExpress.XtraBars.LinkPersistInfo(Me.tBtnQCFG), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnJobWorkIssue, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnJobWorkRet), New DevExpress.XtraBars.LinkPersistInfo(Me.tBTnDispose, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnRecall), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnTRInward, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnGoodsRet), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnDailyBook)})
        Me.tBtnchallan.Name = "tBtnchallan"
        '
        'tbtnPO
        '
        Me.tbtnPO.Caption = "Purchase Order"
        Me.tbtnPO.Id = 19
        Me.tbtnPO.Name = "tbtnPO"
        '
        'tbtnQC
        '
        Me.tbtnQC.Caption = "&Inward Triplicate"
        Me.tbtnQC.Id = 21
        Me.tbtnQC.Name = "tbtnQC"
        '
        'tBTnInvoice
        '
        Me.tBTnInvoice.Caption = "&Order Memo"
        Me.tBTnInvoice.Id = 24
        Me.tBTnInvoice.Name = "tBTnInvoice"
        '
        'tBtnChallanm
        '
        Me.tBtnChallanm.Caption = "&Challan"
        Me.tBtnChallanm.Id = 26
        Me.tBtnChallanm.Name = "tBtnChallanm"
        '
        'tbtnRequisition
        '
        Me.tbtnRequisition.Caption = "&Production Requisition"
        Me.tbtnRequisition.Id = 34
        Me.tbtnRequisition.Name = "tbtnRequisition"
        '
        'tbtnMatIssue
        '
        Me.tbtnMatIssue.Caption = "&MIS"
        Me.tbtnMatIssue.Id = 38
        Me.tbtnMatIssue.Name = "tbtnMatIssue"
        '
        'tBtnQCFG
        '
        Me.tBtnQCFG.Caption = "&QC for Finish Goods"
        Me.tBtnQCFG.Id = 39
        Me.tBtnQCFG.Name = "tBtnQCFG"
        '
        'tbtnJobWorkIssue
        '
        Me.tbtnJobWorkIssue.Caption = "&Demo Issue"
        Me.tbtnJobWorkIssue.Id = 73
        Me.tbtnJobWorkIssue.Name = "tbtnJobWorkIssue"
        '
        'tbtnJobWorkRet
        '
        Me.tbtnJobWorkRet.Caption = "Demo &Return"
        Me.tbtnJobWorkRet.Id = 74
        Me.tbtnJobWorkRet.Name = "tbtnJobWorkRet"
        '
        'tBTnDispose
        '
        Me.tBTnDispose.Caption = "&Disposition Status"
        Me.tBTnDispose.Id = 30
        Me.tBTnDispose.Name = "tBTnDispose"
        '
        'tbtnRecall
        '
        Me.tbtnRecall.Caption = "R&ecall Register"
        Me.tbtnRecall.Id = 72
        Me.tbtnRecall.Name = "tbtnRecall"
        '
        'tbtnTRInward
        '
        Me.tbtnTRInward.Caption = "&Trading Item Inward"
        Me.tbtnTRInward.Id = 77
        Me.tbtnTRInward.Name = "tbtnTRInward"
        '
        'tbtnGoodsRet
        '
        Me.tbtnGoodsRet.Caption = "&Goods Return"
        Me.tbtnGoodsRet.Id = 78
        Me.tbtnGoodsRet.Name = "tbtnGoodsRet"
        '
        'tbtnDailyBook
        '
        Me.tbtnDailyBook.Caption = "&Day Book Register"
        Me.tbtnDailyBook.Id = 103
        Me.tbtnDailyBook.Name = "tbtnDailyBook"
        '
        'tbtnReport
        '
        Me.tbtnReport.Caption = "&Report"
        Me.tbtnReport.Id = 27
        Me.tbtnReport.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnSales), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnPurchase), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnProduction), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnMaster), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnstatutory), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnMinMax), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnMinMaxRM), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnDemoSales), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnPWBW), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnGroupwiseRpt), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtndemoIssue), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnDemoReturn), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnGoodRetRep)})
        Me.tbtnReport.Name = "tbtnReport"
        '
        'tbtnSales
        '
        Me.tbtnSales.Caption = "Sales"
        Me.tbtnSales.Id = 57
        Me.tbtnSales.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.tBTnOrderrpt), New DevExpress.XtraBars.LinkPersistInfo(Me.tbrnChallan), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnPendingOrders)})
        Me.tbtnSales.Name = "tbtnSales"
        '
        'tBTnOrderrpt
        '
        Me.tBTnOrderrpt.Caption = "Order Memo"
        Me.tBTnOrderrpt.Id = 29
        Me.tBTnOrderrpt.Name = "tBTnOrderrpt"
        '
        'tbrnChallan
        '
        Me.tbrnChallan.Caption = "C&hallan"
        Me.tbrnChallan.Id = 47
        Me.tbrnChallan.Name = "tbrnChallan"
        '
        'tbtnPendingOrders
        '
        Me.tbtnPendingOrders.Caption = "&Pending Order"
        Me.tbtnPendingOrders.Id = 90
        Me.tbtnPendingOrders.Name = "tbtnPendingOrders"
        '
        'tbtnPurchase
        '
        Me.tbtnPurchase.Caption = "P&urchase"
        Me.tbtnPurchase.Id = 58
        Me.tbtnPurchase.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnPOrpt), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnInwardTriplicate), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnTradingInward)})
        Me.tbtnPurchase.Name = "tbtnPurchase"
        '
        'tbtnPOrpt
        '
        Me.tbtnPOrpt.Caption = "&Purchase Order"
        Me.tbtnPOrpt.Id = 28
        Me.tbtnPOrpt.Name = "tbtnPOrpt"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Raw Material Visual Inspection"
        Me.BarButtonItem6.Id = 51
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'tbtnInwardTriplicate
        '
        Me.tbtnInwardTriplicate.Caption = "Inward Triplicate"
        Me.tbtnInwardTriplicate.Id = 67
        Me.tbtnInwardTriplicate.Name = "tbtnInwardTriplicate"
        '
        'tbtnTradingInward
        '
        Me.tbtnTradingInward.Caption = "Trading Item Inward"
        Me.tbtnTradingInward.Id = 87
        Me.tbtnTradingInward.Name = "tbtnTradingInward"
        '
        'tbtnProduction
        '
        Me.tbtnProduction.Caption = "&Production"
        Me.tbtnProduction.Id = 59
        Me.tbtnProduction.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnMIS), New DevExpress.XtraBars.LinkPersistInfo(Me.tBtnFGQCRpt), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnSterilization)})
        Me.tbtnProduction.Name = "tbtnProduction"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "&Material Indent Slip"
        Me.BarButtonItem5.Id = 48
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'tbtnMIS
        '
        Me.tbtnMIS.Caption = "Material &Issue Slip"
        Me.tbtnMIS.Id = 49
        Me.tbtnMIS.Name = "tbtnMIS"
        '
        'tBtnFGQCRpt
        '
        Me.tBtnFGQCRpt.Caption = "Visual Inspection of Final Product"
        Me.tBtnFGQCRpt.Id = 40
        Me.tBtnFGQCRpt.Name = "tBtnFGQCRpt"
        '
        'tbtnSterilization
        '
        Me.tbtnSterilization.Caption = "Ster&ilization"
        Me.tbtnSterilization.Id = 50
        Me.tbtnSterilization.Name = "tbtnSterilization"
        '
        'tbtnMaster
        '
        Me.tbtnMaster.Caption = "&Master"
        Me.tbtnMaster.Id = 61
        Me.tbtnMaster.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnCustList), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnSuppList), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnFGList), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnRMList), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnBOM)})
        Me.tbtnMaster.Name = "tbtnMaster"
        '
        'tbtnCustList
        '
        Me.tbtnCustList.Caption = "&Customer List"
        Me.tbtnCustList.Id = 45
        Me.tbtnCustList.Name = "tbtnCustList"
        '
        'tbtnSuppList
        '
        Me.tbtnSuppList.Caption = "&Supplier List"
        Me.tbtnSuppList.Id = 46
        Me.tbtnSuppList.Name = "tbtnSuppList"
        '
        'tbtnFGList
        '
        Me.tbtnFGList.Caption = "Finish Goods List"
        Me.tbtnFGList.Id = 44
        Me.tbtnFGList.Name = "tbtnFGList"
        '
        'tbtnRMList
        '
        Me.tbtnRMList.Caption = "Raw Material List"
        Me.tbtnRMList.Id = 43
        Me.tbtnRMList.Name = "tbtnRMList"
        '
        'tbtnBOM
        '
        Me.tbtnBOM.Caption = "Bill Of Material"
        Me.tbtnBOM.Id = 52
        Me.tbtnBOM.Name = "tbtnBOM"
        '
        'tbtnstatutory
        '
        Me.tbtnstatutory.Caption = "statutory "
        Me.tbtnstatutory.Id = 62
        Me.tbtnstatutory.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnRMStock), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnRMGroup), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnRMStockCons), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnFGStock, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtFGGroup), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnFGStockCons), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnRMCompReg, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnFGCompReg), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnRMVI, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnPendingMIS), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnPendSterz), New DevExpress.XtraBars.LinkPersistInfo(Me.tBtnrptNonCon, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tBTnrptDisposition), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnBatchReg), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnPurchaseReg, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnSalesReg)})
        Me.tbtnstatutory.Name = "tbtnstatutory"
        '
        'tbtnRMStock
        '
        Me.tbtnRMStock.Caption = "&Raw Material Stock"
        Me.tbtnRMStock.Id = 37
        Me.tbtnRMStock.Name = "tbtnRMStock"
        '
        'tbtnRMGroup
        '
        Me.tbtnRMGroup.Caption = "Raw Material Stock (Group wise)"
        Me.tbtnRMGroup.Id = 75
        Me.tbtnRMGroup.Name = "tbtnRMGroup"
        '
        'tbtnRMStockCons
        '
        Me.tbtnRMStockCons.Caption = "Raw Material Stock Consolidated"
        Me.tbtnRMStockCons.Id = 83
        Me.tbtnRMStockCons.Name = "tbtnRMStockCons"
        '
        'tbtnFGStock
        '
        Me.tbtnFGStock.Caption = "&Finish Good Stock"
        Me.tbtnFGStock.Id = 42
        Me.tbtnFGStock.Name = "tbtnFGStock"
        '
        'tbtFGGroup
        '
        Me.tbtFGGroup.Caption = "Finish Good Stock (Group wise)"
        Me.tbtFGGroup.Id = 76
        Me.tbtFGGroup.Name = "tbtFGGroup"
        '
        'tbtnFGStockCons
        '
        Me.tbtnFGStockCons.Caption = "Finish Good Stock Consolidated"
        Me.tbtnFGStockCons.Id = 84
        Me.tbtnFGStockCons.Name = "tbtnFGStockCons"
        '
        'tbtnRMCompReg
        '
        Me.tbtnRMCompReg.Caption = "Raw Material &Component Register"
        Me.tbtnRMCompReg.Id = 68
        Me.tbtnRMCompReg.Name = "tbtnRMCompReg"
        '
        'tbtnFGCompReg
        '
        Me.tbtnFGCompReg.Caption = "Finish Good Register"
        Me.tbtnFGCompReg.Id = 69
        Me.tbtnFGCompReg.Name = "tbtnFGCompReg"
        '
        'tbtnRMVI
        '
        Me.tbtnRMVI.Caption = "Pending RMVI"
        Me.tbtnRMVI.Id = 53
        Me.tbtnRMVI.Name = "tbtnRMVI"
        '
        'tbtnPendingMIS
        '
        Me.tbtnPendingMIS.Caption = "Pending MIS"
        Me.tbtnPendingMIS.Id = 54
        Me.tbtnPendingMIS.Name = "tbtnPendingMIS"
        '
        'tbtnPendSterz
        '
        Me.tbtnPendSterz.Caption = "Pending Ster&ilization"
        Me.tbtnPendSterz.Id = 88
        Me.tbtnPendSterz.Name = "tbtnPendSterz"
        '
        'tBtnrptNonCon
        '
        Me.tBtnrptNonCon.Caption = "Non Conforming Product Report"
        Me.tBtnrptNonCon.Id = 33
        Me.tBtnrptNonCon.Name = "tBtnrptNonCon"
        '
        'tBTnrptDisposition
        '
        Me.tBTnrptDisposition.Caption = "Dispositon Status"
        Me.tBTnrptDisposition.Id = 32
        Me.tBTnrptDisposition.Name = "tBTnrptDisposition"
        Me.tBTnrptDisposition.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'tbtnBatchReg
        '
        Me.tbtnBatchReg.Caption = "Batch Register"
        Me.tbtnBatchReg.Id = 41
        Me.tbtnBatchReg.Name = "tbtnBatchReg"
        '
        'tbtnPurchaseReg
        '
        Me.tbtnPurchaseReg.Caption = "Purchase Register"
        Me.tbtnPurchaseReg.Id = 79
        Me.tbtnPurchaseReg.Name = "tbtnPurchaseReg"
        '
        'tbtnSalesReg
        '
        Me.tbtnSalesReg.Caption = "Sales Register"
        Me.tbtnSalesReg.Id = 80
        Me.tbtnSalesReg.Name = "tbtnSalesReg"
        '
        'tbtnMinMax
        '
        Me.tbtnMinMax.Caption = "Min Max Qty Finish Good"
        Me.tbtnMinMax.Id = 89
        Me.tbtnMinMax.Name = "tbtnMinMax"
        '
        'tbtnMinMaxRM
        '
        Me.tbtnMinMaxRM.Caption = "Min Max Qty Raw Material"
        Me.tbtnMinMaxRM.Id = 92
        Me.tbtnMinMaxRM.Name = "tbtnMinMaxRM"
        '
        'tbtnDemoSales
        '
        Me.tbtnDemoSales.Caption = "&Demo Sales"
        Me.tbtnDemoSales.Id = 91
        Me.tbtnDemoSales.Name = "tbtnDemoSales"
        '
        'tbtnPWBW
        '
        Me.tbtnPWBW.Caption = "Product Wise Batch Wise Detail"
        Me.tbtnPWBW.Id = 94
        Me.tbtnPWBW.Name = "tbtnPWBW"
        '
        'tbtnGroupwiseRpt
        '
        Me.tbtnGroupwiseRpt.Caption = "Group Wise"
        Me.tbtnGroupwiseRpt.Id = 97
        Me.tbtnGroupwiseRpt.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnCWPWSales), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnCWPW_Cons), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnCW_BW_Sales), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnPWCWSales, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnPWCWSales_Cons), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnBW_CW_Sales, True), New DevExpress.XtraBars.LinkPersistInfo(Me.tbtnBatch_Stock_Reg)})
        Me.tbtnGroupwiseRpt.Name = "tbtnGroupwiseRpt"
        '
        'tbtnCWPWSales
        '
        Me.tbtnCWPWSales.Caption = "&Customer Wise Product Wise Sales"
        Me.tbtnCWPWSales.Id = 70
        Me.tbtnCWPWSales.Name = "tbtnCWPWSales"
        '
        'tbtnCWPW_Cons
        '
        Me.tbtnCWPW_Cons.Caption = "Customer Wise Product Wise Sales (Consolidated)"
        Me.tbtnCWPW_Cons.Id = 98
        Me.tbtnCWPW_Cons.Name = "tbtnCWPW_Cons"
        '
        'tbtnCW_BW_Sales
        '
        Me.tbtnCW_BW_Sales.Caption = "Customer wise Batch wise Sales"
        Me.tbtnCW_BW_Sales.Id = 85
        Me.tbtnCW_BW_Sales.Name = "tbtnCW_BW_Sales"
        '
        'tbtnPWCWSales
        '
        Me.tbtnPWCWSales.Caption = "&Product Wise Customer Wise Sales"
        Me.tbtnPWCWSales.Id = 71
        Me.tbtnPWCWSales.Name = "tbtnPWCWSales"
        '
        'tbtnPWCWSales_Cons
        '
        Me.tbtnPWCWSales_Cons.Caption = "Product Wise Customer Wise Sales (Consolidated)"
        Me.tbtnPWCWSales_Cons.Id = 99
        Me.tbtnPWCWSales_Cons.Name = "tbtnPWCWSales_Cons"
        '
        'tbtnBW_CW_Sales
        '
        Me.tbtnBW_CW_Sales.Caption = "Batch wise Customer wise Sales"
        Me.tbtnBW_CW_Sales.Id = 86
        Me.tbtnBW_CW_Sales.Name = "tbtnBW_CW_Sales"
        '
        'tbtnBatch_Stock_Reg
        '
        Me.tbtnBatch_Stock_Reg.Caption = "Batch Wise Stock Register"
        Me.tbtnBatch_Stock_Reg.Id = 81
        Me.tbtnBatch_Stock_Reg.Name = "tbtnBatch_Stock_Reg"
        '
        'tbtndemoIssue
        '
        Me.tbtndemoIssue.Caption = "Demo &Issue"
        Me.tbtndemoIssue.Id = 100
        Me.tbtndemoIssue.Name = "tbtndemoIssue"
        '
        'tbtnDemoReturn
        '
        Me.tbtnDemoReturn.Caption = "Demo &Return"
        Me.tbtnDemoReturn.Id = 101
        Me.tbtnDemoReturn.Name = "tbtnDemoReturn"
        '
        'tbtnGoodRetRep
        '
        Me.tbtnGoodRetRep.Caption = "&Goods Return"
        Me.tbtnGoodRetRep.Id = 102
        Me.tbtnGoodRetRep.Name = "tbtnGoodRetRep"
        '
        'tBtnExit
        '
        Me.tBtnExit.Caption = "Exit"
        Me.tBtnExit.Glyph = CType(resources.GetObject("tBtnExit.Glyph"), System.Drawing.Image)
        Me.tBtnExit.Id = 15
        Me.tBtnExit.Name = "tBtnExit"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Item"
        Me.BarButtonItem1.Id = 0
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'tBtnCust
        '
        Me.tBtnCust.Caption = "Customer"
        Me.tBtnCust.Id = 3
        Me.tBtnCust.LargeGlyph = CType(resources.GetObject("tBtnCust.LargeGlyph"), System.Drawing.Image)
        Me.tBtnCust.Name = "tBtnCust"
        '
        'BarCheckItem1
        '
        Me.BarCheckItem1.Caption = "Trancsaction"
        Me.BarCheckItem1.Id = 6
        Me.BarCheckItem1.Name = "BarCheckItem1"
        '
        'tBtnItem
        '
        Me.tBtnItem.Caption = "Item"
        Me.tBtnItem.Id = 14
        Me.tBtnItem.Name = "tBtnItem"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 20
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Challan"
        Me.BarButtonItem4.Id = 25
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Caption = "BarEditItem1"
        Me.BarEditItem1.Edit = Me.RepositoryItemTextEdit1
        Me.BarEditItem1.Id = 56
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "BarButtonItem7"
        Me.BarButtonItem7.Id = 65
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'tbtnGroupWise
        '
        Me.tbtnGroupWise.Caption = "Group Wise "
        Me.tbtnGroupWise.Id = 96
        Me.tbtnGroupWise.Name = "tbtnGroupWise"
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.lblTableName)
        Me.pnlMain.Controls.Add(Me.gdMain)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 38)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1030, 660)
        Me.pnlMain.TabIndex = 4
        Me.pnlMain.Text = "pnlMain"
        '
        'lblTableName
        '
        Me.lblTableName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTableName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblTableName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTableName.ForeColor = System.Drawing.Color.Navy
        Me.lblTableName.Location = New System.Drawing.Point(2, 2)
        Me.lblTableName.Name = "lblTableName"
        Me.lblTableName.Size = New System.Drawing.Size(1026, 28)
        Me.lblTableName.TabIndex = 12
        Me.lblTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gdMain
        '
        Me.gdMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gdMain.EmbeddedNavigator.Name = ""
        Me.gdMain.Location = New System.Drawing.Point(2, 2)
        Me.gdMain.MainView = Me.gvMain
        Me.gdMain.Name = "gdMain"
        Me.gdMain.Size = New System.Drawing.Size(1026, 656)
        Me.gdMain.TabIndex = 1
        Me.gdMain.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMain})
        '
        'gvMain
        '
        Me.gvMain.GridControl = Me.gdMain
        Me.gvMain.Name = "gvMain"
        Me.gvMain.OptionsBehavior.Editable = False
        Me.gvMain.OptionsMenu.EnableColumnMenu = False
        Me.gvMain.OptionsMenu.EnableFooterMenu = False
        Me.gvMain.OptionsSelection.EnableAppearanceFocusedCell = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnComChart)
        Me.PanelControl1.Controls.Add(Me.cmdDelete)
        Me.PanelControl1.Controls.Add(Me.CmdEdit)
        Me.PanelControl1.Controls.Add(Me.cmdAdd)
        Me.PanelControl1.Location = New System.Drawing.Point(2, 704)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1030, 40)
        Me.PanelControl1.TabIndex = 8
        Me.PanelControl1.Text = "PanelControl1"
        '
        'btnComChart
        '
        Me.btnComChart.Location = New System.Drawing.Point(8, 8)
        Me.btnComChart.Name = "btnComChart"
        Me.btnComChart.Size = New System.Drawing.Size(88, 24)
        Me.btnComChart.TabIndex = 11
        Me.btnComChart.Text = "Comparision"
        Me.btnComChart.Visible = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(941, 8)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 25)
        Me.cmdDelete.TabIndex = 10
        Me.cmdDelete.Text = "Delete"
        '
        'CmdEdit
        '
        Me.CmdEdit.Location = New System.Drawing.Point(861, 8)
        Me.CmdEdit.Name = "CmdEdit"
        Me.CmdEdit.Size = New System.Drawing.Size(75, 25)
        Me.CmdEdit.TabIndex = 9
        Me.CmdEdit.Text = "Edit"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(781, 8)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 25)
        Me.cmdAdd.TabIndex = 8
        Me.cmdAdd.Text = "Add"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'FrmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(1030, 748)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 0, 50)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManagerMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        CType(Me.gdMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub tBtnExit_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tBtnExit.ItemClick
        If DevExpress.XtraEditors.XtraMessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            End
        End If
    End Sub
    Private Sub tbtnUser_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnUser.ItemClick
        'Sopan 
        Try
            gvMain.Columns.Clear()
            dsMain = FillGrid("Select Uid,Userid,UserName as Name,userdepartment,userdesignation,useradd as address,usercity as city,userpin as pin,userphone as phone ,usermobile as mobile from UserMaster", "UserMaster")
            gdMain.DataSource = dsMain.Tables("UserMaster").DefaultView
            gvMain.Columns("Uid").Visible = False
            stractivetable = "User"
            lblTableName.Text = "User"
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub tBtnCustomer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tBtnCustomer.ItemClick
        'Sopan 
        Try

            gvMain.Columns.Clear()
            dsMain = FillGrid("Select Cid,Custid,CustName as Name,CustADD as Address,CustGSTno as GSTNO,CustCSTno as CSTNO," & _
            "Custexno as ExceiseNo,Custcity as City,CustPin as Pin,CustPhone As Phone," & _
             "CustMobile as Mobile from CustomerMaster", "CustomerMaster")
            gdMain.DataSource = dsMain.Tables("CustomerMaster").DefaultView
            gvMain.Columns("Cid").Visible = False
            stractivetable = "Customer"
            lblTableName.Text = "Customer"
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub tBtnSupplier_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tBtnSupplier.ItemClick
        'Sopan 
        Try

            gvMain.Columns.Clear()
            dsMain = FillGrid("Select Sid,Suppid,SuppName as Name,SuppADD as Address,suppGSTno as GSTNO,suppCSTno as CSTNO," & _
            "suppexno as ExceiseNo,suppcity as City,SuppPin as Pin,SuppPhone As Phone," & _
             "SuppMobile as Mobile from SupplierMaster", "SupplierMaster")
            gdMain.DataSource = dsMain.Tables("SupplierMaster")
            gvMain.Columns("Sid").Visible = False
            stractivetable = "Supplier"
            lblTableName.Text = "Supplier"
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tBtnUnit_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tBtnUnit.ItemClick
        ' Sopan
        Try
            gvMain.Columns.Clear()
            dsMain = FillGrid("Select Unitid,UnitName as Name,UnitDesc as Description from UnitMaster", "UnitMaster")
            gdMain.DataSource = dsMain.Tables("UnitMaster")
            gvMain.Columns("Unitid").Visible = False
            stractivetable = "Unit"
            lblTableName.Text = "Unit"
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try

    End Sub
    Private Sub tBtnRaw_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tBtnRaw.ItemClick
        ' Sopan
        Try
            gvMain.Columns.Clear()

            Dim strsql As String = "SELECT Rid,RMItemMaster.RMItemId, RMItemMaster.RMItemName, GroupMaster.Groupname, UnitMaster.UnitName, RMItemMaster.DrawNo, RMItemMaster.ModNo, RMItemMaster.ROL," _
                & " RMItemMaster.Min_qty, RMItemMaster.Notes " _
                & " FROM (RMItemMaster INNER JOIN GroupMaster ON RMItemMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID"

            dsMain = FillGrid(strsql, "RMItemMaster")
            gdMain.DataSource = dsMain.Tables("RMItemMaster")
            gvMain.Columns("Rid").Visible = False
            stractivetable = "Item"
            lblTableName.Text = "Raw Material"
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try

    End Sub

    Private Sub tBtnFinishGood_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tBtnFinishGood.ItemClick
        ' Sopan
        Try
            gvMain.Columns.Clear()
            Dim strsql As String
            strsql = "SELECT Fid,FGMaster.FGID, FGMaster.FGName, GroupMaster.Groupname, UnitMaster.UnitName, FGMaster.Notes" _
                & " FROM (FGMaster INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID "

            dsMain = FillGrid(strsql, "FGMaster")
            gdMain.DataSource = dsMain.Tables("FGMaster")
            gvMain.Columns("Fid").Visible = False
            'gvMain.Columns("UnitID").Visible = False
            stractivetable = "Finish_goods"
            lblTableName.Text = "Finish Goods"
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try


    End Sub



    Private Sub CmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEdit.Click
        ' sopan
        Dim p As DevExpress.XtraBars.ItemClickEventArgs
        Try
            Select Case stractivetable
                Case "Item"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("Rid")
                    Dim frmitemobj As New frmitem
                    frmitemobj.strcheck = "Edit"
                    frmitemobj.ShowDialog()
                    tBtnRaw_ItemClick(sender, p)
                Case "Finish_goods"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("Fid")
                    Dim frmgoods As New frmfgmaster
                    frmgoods.strcheck = "Edit"
                    frmgoods.ShowDialog()
                    tBtnFinishGood_ItemClick(sender, p)
                Case "Supplier"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("Sid")
                    Dim frmSupplier As New FrmSupplier
                    frmSupplier.strcheck = "Edit"
                    frmSupplier.ShowDialog()
                    tBtnSupplier_ItemClick(sender, p)
                Case "Customer"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("Cid")
                    Dim frmCustomer As New FrmCustomer
                    frmCustomer.strcheck = "Edit"
                    frmCustomer.ShowDialog()
                    tBtnCustomer_ItemClick(sender, p)
                Case "User"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("Uid")
                    Dim frmUser As New FrmUser
                    frmUser.strcheck = "Edit"
                    frmUser.ShowDialog()
                    tbtnUser_ItemClick(sender, p)
                Case "Unit"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("Unitid")
                    If ModMain.strgridid <> "" Then
                        Dim frmUnit As New FrmUnit
                        frmUnit.strCheck = "Edit"
                        frmUnit.ShowDialog()
                        tBtnUnit_ItemClick(sender, p)
                    End If
                Case "Batch"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("BatchID")
                    Dim frmbatchobj As New frmbatch
                    frmbatchobj.strcheck = "Edit"
                    frmbatchobj.ShowDialog()
                    tbtnBatch_ItemClick(sender, p)
                Case "Group"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("GroupID")
                    Dim frmgroupobj As New frmGroup
                    frmgroupobj.strcheck = "Edit"
                    frmgroupobj.ShowDialog()
                    tbtnGroup_ItemClick(sender, p)
                Case "Purchase"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("PO_No")
                    Dim frmPOObj As New FrmPurchaseOrder
                    frmPOObj.strcheck = "Edit"
                    frmPOObj.ShowDialog()
                    tbtnPO_ItemClick(sender, p)
                Case "UnitConMaster"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("RMID")
                    Dim frmUC As New frmUnitConversion
                    frmUC.strCheck = "Edit"
                    frmUC.ShowDialog()
                    tbtnUnitConv_ItemClick(sender, p)
                Case "QC"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("RMVI_NO")
                    Dim frmQCObj As New frmQC
                    frmQCObj.strcheck = "Edit"
                    frmQCObj.Show()
                    BarButtonItem3_ItemClick(sender, p)
                Case "Reason"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("Reason")
                    Dim frmReasonobj As New frmrejection
                    frmReasonobj.strCheck = "Edit"
                    frmReasonobj.ShowDialog()
                    tbtnRejection_ItemClick(sender, p)
                Case "Invoice"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("Order_No")
                    Dim frmInvoiceobj As New frmInvoicenew
                    frmInvoiceobj.strcheck = "Edit"
                    frmInvoiceobj.ShowDialog()
                    tBTnInvoice_ItemClick(sender, p)
                Case "Challan"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("Challan_No")
                    Dim frmChallanObj As New frmChallan
                    frmChallanObj.strCheck = "Edit"
                    frmChallanObj.ShowDialog()
                    tBtnChallanm_ItemClick(sender, p)
                Case "Dispose"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("Sr_No")
                    Dim frmDispose As New frmDispose_Staus
                    frmDispose.strcheck = "Edit"
                    frmDispose.ShowDialog()
                    tBTnDispose_ItemClick(sender, p)
                Case "Non_Con"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("Sr_No")
                    Dim frmNonConPro As New frmNonConProduct
                    frmNonConPro.strcheck = "Edit"
                    frmNonConPro.ShowDialog()
                    tBTnNonCon_ItemClick(sender, p)
                Case "Requisition"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("RQID")
                    Dim frmobj As New frmBatchGenerator
                    frmobj.strcheck = "Edit"
                    frmobj.Show()
                    tbtnRequisition_ItemClick(sender, p)
                Case "RM_OP_Stk"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("ID")
                    If ModMain.strgridid <> "" Then
                        Dim frmobj As New frmRM_Opening_Stock
                        frmobj.strcheck = "Edit"
                        frmobj.ShowDialog()
                        tBTnRMOpStock_ItemClick(sender, p)
                    End If
                Case "FG_OP_Stk"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("ID")
                    If ModMain.strgridid <> "" Then
                        Dim frmobj As New frmFG_OpeningStock
                        frmobj.strcheck = "Edit"
                        frmobj.ShowDialog()
                        tBTnFGOpStock_ItemClick(sender, p)
                    End If
                Case "Mat_Issue"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("MIS_NO")
                    Dim frmobj As New frmMat_Issue
                    frmobj.strcheck = "Edit"
                    frmobj.ShowDialog()
                    tbtnMatIssue_ItemClick(sender, p)
                Case "FG_QC"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("FGVI_NO")
                    Dim frmobj As New frmFinishGoodQC
                    frmobj.strcheck = "Edit"
                    frmobj.ShowDialog()
                    tBtnQCFG_ItemClick(sender, p)
                Case "CompanyMaster"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("CompanyID")
                    Dim frmobj As New frmCompany
                    frmobj.strCheck = "Edit"
                    frmobj.ShowDialog()
                    tbtnCompMaster_ItemClick(sender, p)
                Case "JW"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("JID")
                    Dim frmobj As New frmJobWorkIssue
                    frmobj.strcheck = "Edit"
                    frmobj.ShowDialog()
                    tbtnJobWorkIssue_ItemClick(sender, p)
                Case "JR"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("ID")
                    Dim frmobj As New frmJWReturn
                    frmobj.strCheck = "Edit"
                    frmobj.ShowDialog()
                    tbtnJobWorkRet_ItemClick(sender, p)
                Case "TR_Inward"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("RecID")
                    Dim frmobj As New frmTradingItemInward
                    frmobj.strcheck = "Edit"
                    frmobj.ShowDialog()
                    tbtnTRInward_ItemClick(sender, p)
                Case "FG_Ret"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("RetNo")
                    Dim frmobj As New frmGoodsReturn
                    frmobj.strCheck = "Edit"
                    frmobj.ShowDialog()
                    tbtnGoodsRet_ItemClick(sender, p)
            End Select
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        ' sopan
        Dim p As DevExpress.XtraBars.ItemClickEventArgs
        Try
            Select Case stractivetable
                Case "Item"
                    Dim frmitemobj As New frmitem
                    frmitemobj.strcheck = "Add"
                    frmitemobj.ShowDialog()
                    tBtnRaw_ItemClick(sender, p)
                Case "Finish_goods"
                    Dim frmgoods As New frmfgmaster
                    frmgoods.strcheck = "Add"
                    frmgoods.ShowDialog()
                    tBtnFinishGood_ItemClick(sender, p)
                Case "Supplier"
                    Dim frmsupplier As New FrmSupplier
                    frmsupplier.strcheck = "Add"
                    frmsupplier.ShowDialog()
                    tBtnSupplier_ItemClick(sender, p)
                Case "Customer"
                    Dim frmCustomer As New FrmCustomer
                    frmCustomer.strcheck = "Add"
                    frmCustomer.ShowDialog()
                    tBtnCustomer_ItemClick(sender, p)
                Case "User"
                    If strGVUserID.ToString = "UR00000001" Then
                        Dim frmUser As New FrmUser
                        frmUser.strcheck = "Add"
                        frmUser.ShowDialog()
                        tbtnUser_ItemClick(sender, p)
                    Else
                        DevExpress.XtraEditors.XtraMessageBox.Show("You do not have permission to add other user. Please contect to your Administrator.", "User", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Case "Unit"
                    Dim frmUnit As New FrmUnit
                    frmUnit.strCheck = "Add"
                    frmUnit.ShowDialog()
                    tBtnUnit_ItemClick(sender, p)
                Case "Batch"
                    Dim frmbatchobj As New frmbatch
                    frmbatchobj.strcheck = "Add"
                    frmbatchobj.ShowDialog()
                    tbtnBatch_ItemClick(sender, p)
                Case "Group"
                    Dim frmgroupobj As New frmGroup
                    frmgroupobj.strcheck = "Add"
                    frmgroupobj.ShowDialog()
                    tbtnGroup_ItemClick(sender, p)
                Case "Purchase"
                    Dim frmPOObj As New FrmPurchaseOrder
                    frmPOObj.strcheck = "Add"
                    frmPOObj.ShowDialog()
                    tbtnPO_ItemClick(sender, p)
                Case "QC"
                    Dim frmQCobj As New frmQC
                    frmQCobj.strcheck = "Add"
                    frmQCobj.ShowDialog()
                    BarButtonItem3_ItemClick(sender, p)
                Case "Reason"
                    Dim frmReasonobj As New frmrejection
                    frmReasonobj.strCheck = "Add"
                    frmReasonobj.ShowDialog()
                    tbtnRejection_ItemClick(sender, p)
                Case "UnitConMaster"
                    Dim frmUC As New frmUnitConversion
                    frmUC.strCheck = "Add"
                    frmUC.ShowDialog()
                    tbtnUnitConv_ItemClick(sender, p)
                Case "Invoice"
                    Dim frmInvoiceobj As New frmInvoicenew
                    frmInvoiceobj.strcheck = "Add"
                    frmInvoiceobj.ShowDialog()
                    tBTnInvoice_ItemClick(sender, p)
                Case "Challan"
                    Dim frmChallanObj As New frmChallan
                    frmChallanObj.strCheck = "Add"
                    frmChallanObj.ShowDialog()
                    tBtnChallanm_ItemClick(sender, p)
                Case "Dispose"
                    Dim frmDispose As New frmDispose_Staus
                    frmDispose.strcheck = "Add"
                    frmDispose.ShowDialog()
                    tBTnDispose_ItemClick(sender, p)
                Case "Non_Con"
                    Dim frmNonConPro As New frmNonConProduct
                    frmNonConPro.strcheck = "Add"
                    frmNonConPro.ShowDialog()
                    tBTnNonCon_ItemClick(sender, p)
                Case "Requisition"
                    Dim frmobj As New frmBatchGenerator
                    frmobj.strcheck = "Add"
                    frmobj.Show()
                    tbtnRequisition_ItemClick(sender, p)
                Case "RM_OP_Stk"
                    Dim frmobj As New frmRM_Opening_Stock
                    frmobj.strcheck = "Add"
                    frmobj.ShowDialog()
                    tBTnRMOpStock_ItemClick(sender, p)
                Case "FG_OP_Stk"
                    Dim frmobj As New frmFG_OpeningStock
                    frmobj.strcheck = "Add"
                    frmobj.ShowDialog()
                    tBTnFGOpStock_ItemClick(sender, p)
                Case "Mat_Issue"
                    Dim frmobj As New frmMat_Issue
                    frmobj.strcheck = "Add"
                    frmobj.Show()
                    tbtnMatIssue_ItemClick(sender, p)
                Case "FG_QC"
                    Dim frmobj As New frmFinishGoodQC
                    frmobj.strcheck = "Add"
                    frmobj.ShowDialog()
                    tBtnQCFG_ItemClick(sender, p)
                Case "CompanyMaster"
                    Dim frmobj As New frmCompany
                    frmobj.strCheck = "Add"
                    frmobj.ShowDialog()
                    tbtnCompMaster_ItemClick(sender, p)
                Case "JW"
                    Dim frmobj As New frmJobWorkIssue
                    frmobj.strcheck = "Add"
                    frmobj.ShowDialog()
                    tbtnJobWorkIssue_ItemClick(sender, p)
                Case "JR"
                    Dim frmobj As New frmJWReturn
                    frmobj.strCheck = "Add"
                    frmobj.ShowDialog()
                    tbtnJobWorkRet_ItemClick(sender, p)
                Case "TR_Inward"
                    Dim frmobj As New frmTradingItemInward
                    frmobj.strcheck = "Add"
                    frmobj.ShowDialog()
                    tbtnTRInward_ItemClick(sender, p)
                Case "FG_Ret"
                    Dim frmobj As New frmGoodsReturn
                    frmobj.strCheck = "Add"
                    frmobj.ShowDialog()
                    tbtnGoodsRet_ItemClick(sender, p)
            End Select
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        ' sopan
        Try
            Select Case stractivetable
                Case "Item"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("Rid")
                    deleteRow("RMItemMaster", "Rid")
                Case "Finish_goods"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("Fid")
                    deleteRow("FGMaster", "Fid")
                Case "Supplier"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("Sid")
                    deleteRow("SupplierMaster", "Sid")
                Case "Customer"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("Cid")
                    deleteRow("CustomerMaster", "Cid")
                Case "User"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("Uid")
                    If ModMain.strgridid = "UR00000001" Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("You can not delete administrator from user grod", "User", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    If strGVUserID = "UR00000001" Then
                        deleteRow("UserMaster", "Uid")
                    Else
                        DevExpress.XtraEditors.XtraMessageBox.Show("You do not have sufficient previlage to delete any user.Contect to administrator.", "User", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                Case "Unit"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("Unitid")
                    deleteRow("UnitMaster", "UnitId")
                Case "Batch"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("BatchID")
                    deleteRow("BatchMaster", "BatchID")
                Case "Group"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("GroupID")
                    deleteRow("GroupMaster", "GroupId")
                Case "Purchase"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("PO_No")
                    deleteRow("Purchase_Master", "PO_No", strCY)
                Case "UnitConMaster"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("UCID")
                    deleteRow("UnitConMaster", "UCID")
                Case "CompanyMaster"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("CompanyID")
                    deleteRow("CompanyMaster", "CompanyID")
                Case "QC"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("RMVI_NO")
                    Dim cmd As New OleDb.OleDbCommand
                    cmd.Connection = conn
                    Try
                        If DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Are you sure you wnat to delete the record", StrAppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            blnNo = False
                            cmd.Transaction = conn.BeginTransaction

                            cmd.CommandText = "Select Issue_Qty from RMSTOCK where RMVI_No='" & ModMain.strgridid & "'"
                            If cmd.ExecuteScalar > 0 Then
                                MsgBox("You can not delete this inward triplicate because some items has been issued from it's stock.")
                                cmd.Transaction.Rollback()
                                Exit Sub
                            End If
                            cmd.CommandText = "Delete from RMSTOCK where RMVI_No='" & ModMain.strgridid & "' AND CY ='" & strCY.Trim & "'"
                            cmd.ExecuteNonQuery()

                            cmd.CommandText = "Delete From QCMaster where RMVI_No ='" & ModMain.strgridid.Trim & "' AND CY ='" & strCY.Trim & "'"
                            cmd.ExecuteNonQuery()

                            cmd.Transaction.Commit()
                        Else
                            blnNo = True
                        End If
                    Catch ex1 As Exception
                        blnNo = False
                        cmd.Transaction.Rollback()
                        cmd.Dispose()
                    End Try
                Case "Reason"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("Reason")
                    deleteRow("Reason", "Reason")
                Case "Dispose"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("Sr_No")
                    deleteRow("Disposition_Status", "Sr_No")
                Case "Non_Con"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("Sr_No")
                    deleteRow("Non_Con_Products", "Sr_No")
                Case "Requisition"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("RQID")
                    deleteRow("REQMaster", "RQID", strCY)
                Case "RM_OP_Stk"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("ID")
                    Dim cmd As New OleDb.OleDbCommand
                    cmd.Connection = conn
                    Try
                        If DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Are you sure you wnat to delete the record", StrAppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            blnNo = False
                            cmd.Transaction = conn.BeginTransaction
                            cmd.CommandText = "Delete from RM_Opening_Stock where ID=" & ModMain.strgridid
                            cmd.ExecuteNonQuery()

                            cmd.CommandText = "Select Issue_Qty from RMSTOCK where RID='" & gvMain.GetFocusedRowCellValue("RID") & "' and " _
                                & "RMVI_NO ='" & gvMain.GetFocusedRowCellValue("RMVI_NO") & "' AND RECEIVED_QTY = " & gvMain.GetFocusedRowCellValue("Opening_Qty")
                            If cmd.ExecuteScalar > 0 Then
                                MsgBox("You can not delete opeing stock because some items has been issued from it's stock.")
                                cmd.Transaction.Rollback()
                                Exit Sub
                            End If
                            cmd.CommandText = "Delete from RMSTOCK where RID='" & gvMain.GetFocusedRowCellValue("RID") & "' and " _
                                & "RMVI_NO ='" & gvMain.GetFocusedRowCellValue("RMVI_NO") & "' AND RECEIVED_QTY = " & gvMain.GetFocusedRowCellValue("Opening_Qty")
                            cmd.ExecuteNonQuery()
                            cmd.Transaction.Commit()
                        Else
                            blnNo = True
                        End If
                    Catch ex1 As Exception
                        blnNo = False
                        cmd.Transaction.Rollback()
                        cmd.Dispose()
                    End Try
                Case "FG_OP_Stk"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("ID")
                    Dim cmd As New OleDb.OleDbCommand
                    cmd.Connection = conn
                    Try
                        If DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Are you sure you wnat to delete the record", StrAppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            blnNo = False
                            cmd.Transaction = conn.BeginTransaction
                            cmd.CommandText = "Delete from FG_Opening_Stock where ID=" & ModMain.strgridid
                            cmd.ExecuteNonQuery()

                            cmd.CommandText = "Select Issue_Qty from FGStock where FID='" & gvMain.GetFocusedRowCellValue("FID") & "' and " _
                                & "Batch_No ='" & gvMain.GetFocusedRowCellValue("FGVI_NO") & "' AND RECEIVED_QTY = " & gvMain.GetFocusedRowCellValue("Opening_Qty")
                            If cmd.ExecuteScalar > 0 Then
                                MsgBox("You can not delete opeing stock because some items has been issued from it's stock.")
                                cmd.Transaction.Rollback()
                                Exit Sub
                            End If
                            cmd.CommandText = "Delete from FGStock where FID='" & gvMain.GetFocusedRowCellValue("FID") & "' and " _
                                & "Batch_No ='" & gvMain.GetFocusedRowCellValue("FGVI_NO") & "' AND RECEIVED_QTY = " & gvMain.GetFocusedRowCellValue("Opening_Qty")

                            cmd.ExecuteNonQuery()
                            cmd.Transaction.Commit()
                        Else
                            blnNo = True
                        End If
                    Catch ex1 As Exception
                        blnNo = False
                        cmd.Transaction.Rollback()
                        cmd.Dispose()
                    End Try
                Case "Mat_Issue"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("MIS_NO")
                    RMStockRevUpdate(ModMain.strgridid)
                Case "FG_QC"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("FGVI_NO")
                    Dim cmd As New OleDb.OleDbCommand
                    cmd.Connection = conn
                    Try
                        If DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Are you sure you wnat to delete the record", StrAppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            blnNo = False
                            cmd.Transaction = conn.BeginTransaction
                            cmd.CommandText = "Select Issue_Qty from FGSTOCK where Batch_No=(Select Batch_No from FinishGoods_QCDetail where  FGVI_No='" & ModMain.strgridid & "' and CY ='" & strCY.Trim & "')"
                            If cmd.ExecuteScalar > 0 Then
                                MsgBox("You can not delete this inward triplicate because some items has been issued from it's stock.")
                                cmd.Transaction.Rollback()
                                Exit Sub
                            End If
                            cmd.CommandText = "Delete from FGSTOCK where Batch_No = (Select Batch_No from FinishGoods_QCDetail where  FGVI_No='" & ModMain.strgridid & "' AND cy ='" & strCY.Trim & "')"
                            cmd.ExecuteNonQuery()

                            cmd.CommandText = "Delete From FinishGoods_QCMaster where FGVI_No ='" & ModMain.strgridid.Trim & "' and cy ='" & strCY.Trim & "'"
                            cmd.ExecuteNonQuery()

                            cmd.Transaction.Commit()
                        Else
                            blnNo = True
                        End If
                    Catch ex1 As Exception
                        blnNo = False
                        cmd.Transaction.Rollback()
                        cmd.Dispose()
                    End Try
                Case "Invoice"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("Order_No")
                    deleteRow("InvoiceMaster", "Order_No", strCY)
                Case "Challan"
                    If DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Are you sure you wnat to delete the record", StrAppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        ModMain.strgridid = gvMain.GetFocusedRowCellValue("Challan_No")
                        FGStockRevUpdate(ModMain.strgridid)
                    Else
                        blnNo = True
                    End If
                Case "JW"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("JID")
                    deleteRow("JW_ISSUE_Master", "JID", strCY)
                Case "JR"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("ID")
                    deleteRow("JW_Ret_Master", "ID", strCY)
                Case "TR_Inward"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("RecID")
                    Dim cmd As New OleDb.OleDbCommand
                    cmd.Connection = conn
                    Try
                        If DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Are you sure you wnat to delete the record", StrAppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            blnNo = False
                            Dim adpt As New OleDb.OleDbDataAdapter("Select * from TI_Rec_Det where RecID=" & ModMain.strgridid.Trim & " and CY ='" & strCY.Trim & "'", conn)
                            Dim ds As New DataSet
                            adpt.Fill(ds, "Inward")
                            cmd = New OleDb.OleDbCommand
                            cmd.Connection = conn
                            cmd.Transaction = conn.BeginTransaction
                            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                                cmd.CommandText = "Select Issue_Qty from FGSTOCK where Batch_No='" & ds.Tables(0).Rows(i).Item("Batch_No") & "' " _
                                    & "and FID='" & ds.Tables(0).Rows(i).Item("FID") & "' and Date =#" & gvMain.GetFocusedRowCellValue("RecDate") & "# and Type ='Inward' and CY ='" & strCY.Trim & "'"
                                If cmd.ExecuteScalar > 0 Then
                                    DevExpress.XtraEditors.XtraMessageBox.Show("You can not delete this record because some items has been issued from it's stock.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    cmd.Transaction.Rollback()
                                    Exit Sub
                                End If

                                cmd.CommandText = "Delete from FGSTOCK where Batch_No='" & ds.Tables(0).Rows(i).Item("Batch_No") & "' and FID='" & ds.Tables(0).Rows(i).Item("FID") & "' and Date =#" & gvMain.GetFocusedRowCellValue("RecDate") & "# and Type ='Inward' and CY ='" & strCY.Trim & "'"
                                cmd.ExecuteNonQuery()
                            Next

                            cmd.CommandText = "Delete From TI_Rec_Master where RecID =" & ModMain.strgridid.Trim & " and CY ='" & strCY.Trim & "'"
                            cmd.ExecuteNonQuery()

                            cmd.Transaction.Commit()
                        Else
                            blnNo = True
                        End If
                    Catch ex1 As Exception
                        blnNo = False
                        cmd.Transaction.Rollback()
                        cmd.Dispose()
                    End Try
                Case "FG_Ret"
                    ModMain.strgridid = gvMain.GetFocusedRowCellValue("RetNo")
                    Try
                        If DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Are you sure you wnat to delete the record", StrAppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            blnNo = False
                            Dim adpt As New OleDb.OleDbDataAdapter("Select * from FG_Ret_Det where RetNo='" & ModMain.strgridid.Trim & "' and CY ='" & strCY.Trim & "'", conn)
                            Dim ds As New DataSet
                            adpt.Fill(ds, "ReturnFG")
                            cmd = New OleDb.OleDbCommand
                            cmd.Connection = conn
                            cmd.Transaction = conn.BeginTransaction
                            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                                cmd.CommandText = "Update FGSTOCK set Ret_Qty = (Ret_Qty - " & ds.Tables(0).Rows(i).Item("Ret_Qty") & ")," _
                                    & " Balance_Qty = (Balance_Qty - " & ds.Tables(0).Rows(i).Item("Ret_Qty") & ") where FID='" & ds.Tables(0).Rows(i).Item("FID") & "' and Batch_No ='" & ds.Tables(0).Rows(i).Item("BatchID") & "' and CY ='" & strCY.Trim & "'"
                                cmd.ExecuteNonQuery()
                            Next

                            cmd.CommandText = "Delete From FG_Ret_Master where RetNo ='" & ModMain.strgridid.Trim & "' and CY ='" & strCY.Trim & "'"
                            cmd.ExecuteNonQuery()

                            cmd.Transaction.Commit()
                        Else
                            blnNo = True
                        End If
                    Catch ex1 As Exception
                        blnNo = False
                        cmd.Transaction.Rollback()
                        cmd.Dispose()
                    End Try
            End Select
            If gvMain.FocusedRowHandle >= 0 And blnNo = False Then
                dsMain.Tables(0).Rows(gvMain.FocusedRowHandle).Delete()
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub RMStockRevUpdate(ByVal strMISNO As String)
        Dim cmdTemp As New OleDb.OleDbCommand
        Dim adpTemp As OleDb.OleDbDataAdapter
        Dim myDs As New DataSet
        Dim strSql As String
        Try
            If DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Are you sure you wnat to delete the record", StrAppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                strSql = "SELECT Material_Issue_Detail.MIS_NO, Material_Issue_Detail.RID, Material_Issue_Detail.RMVI_NO, Material_Issue_Detail.Issued_Qty " _
                    & " FROM Material_Issue_Detail INNER JOIN RMStock ON (Material_Issue_Detail.RMVI_NO = RMStock.RMVI_No) AND (Material_Issue_Detail.RID = RMStock.RID) " _
                    & " WHERE (((Material_Issue_Detail.MIS_NO)='" & strMISNO.Trim & "')) and Material_Issue_Detail.CY ='" & strCY.Trim & "'"

                adpTemp = New OleDb.OleDbDataAdapter(strSql, conn)
                adpTemp.Fill(myDs, "Stock")

                cmdTemp = New OleDb.OleDbCommand
                cmdTemp.Connection = conn
                cmdTemp.Transaction = conn.BeginTransaction

                For i As Integer = 0 To myDs.Tables(0).Rows.Count - 1
                    strSql = "Update RMStock set Issue_Qty = (Issue_Qty - " & myDs.Tables(0).Rows(i).Item("Issued_Qty") & "),Balance_Qty = (Balance_Qty + " & myDs.Tables(0).Rows(i).Item("Issued_Qty") & ") where " _
                        & " RID = '" & myDs.Tables(0).Rows(i).Item("RID") & "' and RMVI_NO = '" & myDs.Tables(0).Rows(i).Item("RMVI_NO") & "' and CY ='" & strCY.Trim & "'"
                    cmdTemp.CommandText = strSql
                    cmdTemp.ExecuteNonQuery()
                Next
                cmdTemp.CommandText = "Delete from Material_Issue_Master where MIS_No ='" & strMISNO.Trim & "' and CY ='" & strCY.Trim & "'"
                cmdTemp.ExecuteNonQuery()

                cmdTemp.Transaction.Commit()
                myDs.Dispose()
                adpTemp.Dispose()
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
            cmdTemp.Transaction.Rollback()
        Finally
            cmdTemp.Dispose()
        End Try
    End Sub
    Private Sub FGStockRevUpdate(ByVal strChallanID As String)
        Dim cmdTemp As New OleDb.OleDbCommand
        Dim adpTemp As OleDb.OleDbDataAdapter
        Dim myDs As New DataSet
        Dim strSql As String
        Try

            'Issue Qty from Production
            strSql = "SELECT ChallanDetail.FID, FinishGoods_QCDetail.FGVI_NO, ChallanDetail.BatchID, ChallanDetail.Challan_No, ChallanDetail.Qty " _
                & " FROM FinishGoods_QCDetail INNER JOIN ChallanDetail ON (FinishGoods_QCDetail.FID = ChallanDetail.FID) AND (FinishGoods_QCDetail.Batch_NO = ChallanDetail.BatchID) " _
                & " Where ChallanDetail.Challan_no ='" & strChallanID.Trim & "' and ChallanDetail.CY ='" & strCY.Trim & "'"
            adpTemp = New OleDb.OleDbDataAdapter(strSql, conn)
            adpTemp.Fill(myDs, "Stock")


            'Issue Qty from Opening Stock
            strSql = "SELECT ChallanDetail.FID, ChallanDetail.BatchID, ChallanDetail.Challan_No, ChallanDetail.Qty " _
                & " FROM ChallanDetail INNER JOIN FG_Opening_Stock ON (ChallanDetail.BatchID = FG_Opening_Stock.FGVI_NO) AND (ChallanDetail.FID = FG_Opening_Stock.FID) " _
                & " WHERE (((ChallanDetail.Challan_No)='" & strChallanID.Trim & "')) and ChallanDetail.CY ='" & strCY.Trim & "';"
            adpTemp.SelectCommand.CommandText = strSql
            adpTemp.Fill(myDs, "Op_Stock")


            'Issue Qty from Trading Item
            strSql = "SELECT ChallanDetail.FID, ChallanDetail.BatchID, ChallanMaster.Challan_No, ChallanDetail.Qty" _
                & " FROM (ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN TI_Rec_Det ON (ChallanDetail.FID = TI_Rec_Det.FID) AND (ChallanDetail.BatchID = TI_Rec_Det.Batch_No) " _
                & " WHERE (((ChallanMaster.Challan_No)='" & strChallanID.Trim & "')) and ChallanMaster.CY ='" & strCY.Trim & "';"
            adpTemp.SelectCommand.CommandText = strSql
            adpTemp.Fill(myDs, "Trading")


            'Issue Qty from previous year Return
            strSql = "SELECT ChallanDetail.FID, ChallanDetail.BatchID, ChallanMaster.Challan_No, ChallanDetail.Qty, FG_Ret_Master.Year " _
                & " FROM (ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN (FG_Ret_Master INNER JOIN FG_Ret_Det ON FG_Ret_Master.RetNo = FG_Ret_Det.RetNo) ON (ChallanDetail.BatchID = FG_Ret_Det.BatchID) AND (ChallanDetail.FID = FG_Ret_Det.FID) " _
                & " WHERE (((ChallanMaster.Challan_No)='" & strChallanID.Trim & "') AND ((FG_Ret_Master.Year)='P')) and ChallanMaster.CY ='" & strCY.Trim & "'; "
            adpTemp.SelectCommand.CommandText = strSql
            adpTemp.Fill(myDs, "Prev_Return")

            cmdTemp = New OleDb.OleDbCommand
            cmdTemp.Connection = conn
            cmdTemp.Transaction = conn.BeginTransaction
            For i As Integer = 0 To myDs.Tables(0).Rows.Count - 1
                strSql = "Update FGStock set Issue_Qty = (Issue_Qty - " & myDs.Tables(0).Rows(i).Item("Qty") & "),Balance_Qty = (Balance_Qty + " & myDs.Tables(0).Rows(i).Item("Qty") & ") where " _
                    & " FID = '" & myDs.Tables(0).Rows(i).Item("FID") & "' and Batch_No = '" & myDs.Tables(0).Rows(i).Item("BatchID") & "' and CY ='" & strCY.Trim & "'"
                cmdTemp.CommandText = strSql
                cmdTemp.ExecuteNonQuery()
            Next

            For i As Integer = 0 To myDs.Tables("Op_Stock").Rows.Count - 1
                strSql = "Update FGStock set Issue_Qty = (Issue_Qty - " & myDs.Tables(1).Rows(i).Item("Qty") & "),Balance_Qty = (Balance_Qty + " & myDs.Tables(1).Rows(i).Item("Qty") & ") where " _
                    & " FID = '" & myDs.Tables(1).Rows(i).Item("FID") & "' and Batch_No = '" & myDs.Tables(1).Rows(i).Item("BatchID") & "' and CY ='" & strCY.Trim & "'"
                cmdTemp.CommandText = strSql
                cmdTemp.ExecuteNonQuery()
            Next

            For i As Integer = 0 To myDs.Tables("Trading").Rows.Count - 1
                strSql = "Update FGStock set Issue_Qty = (Issue_Qty - " & myDs.Tables("Trading").Rows(i).Item("Qty") & "),Balance_Qty = (Balance_Qty + " & myDs.Tables("Trading").Rows(i).Item("Qty") & ") where " _
                    & " FID = '" & myDs.Tables("Trading").Rows(i).Item("FID") & "' and Batch_No = '" & myDs.Tables("Trading").Rows(i).Item("BatchID") & "' and CY ='" & strCY.Trim & "'"
                cmdTemp.CommandText = strSql
                cmdTemp.ExecuteNonQuery()
            Next

            For i As Integer = 0 To myDs.Tables("Prev_Return").Rows.Count - 1
                strSql = "Update FGStock set Issue_Qty = (Issue_Qty - " & myDs.Tables("Prev_Return").Rows(i).Item("Qty") & "),Balance_Qty = (Balance_Qty + " & myDs.Tables("Prev_Return").Rows(i).Item("Qty") & ") where " _
                    & " FID = '" & myDs.Tables("Prev_Return").Rows(i).Item("FID") & "' and Batch_No = '" & myDs.Tables("Prev_Return").Rows(i).Item("BatchID") & "' and CY ='" & strCY.Trim & "'"
                cmdTemp.CommandText = strSql
                cmdTemp.ExecuteNonQuery()
            Next

            adpTemp.Dispose()

            cmdTemp.CommandText = "Delete from ChallanMaster where Challan_No ='" & strChallanID.Trim & "' and CY ='" & strCY.Trim & "'"
            cmdTemp.ExecuteNonQuery()

            cmdTemp.Transaction.Commit()
            myDs.Dispose()
            adpTemp.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
            cmdTemp.Transaction.Rollback()
        Finally
            cmdTemp.Dispose()
        End Try
    End Sub
    Private Sub deleteRow(ByVal TabName As String, ByVal FieldName As String, Optional ByVal CURRENTYEAR As String = "")
        ' sopan
        Try
            If DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Are you sure you wnat to delete the record", StrAppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                blnNo = False
                If CURRENTYEAR.Trim = "" Then
                    cmd = New OleDb.OleDbCommand("Delete from " & TabName & " Where Cstr(" & FieldName & ") ='" & ModMain.strgridid & "'", conn)
                Else

                    cmd = New OleDb.OleDbCommand("Select CY from " & TabName & " where Cstr(" & FieldName & ") ='" & ModMain.strgridid & "'", conn)
                    Dim strYear As String
                    strYear = IIf(IsDBNull(cmd.ExecuteScalar) = True, "", cmd.ExecuteScalar)
                    If strYear <> strCY Then
                        DevExpress.XtraEditors.XtraMessageBox.Show(Me, "You can't delete previous year data", StrAppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        cmd = New OleDb.OleDbCommand("Delete from " & TabName & " Where Cstr(" & FieldName & ") ='" & ModMain.strgridid & "' AND CY='" & strCY.Trim & "'", conn)
                        cmd.ExecuteNonQuery()
                    End If
                End If
            Else
                blnNo = True
            End If
        Catch ex As Exception

            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnBatch_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnBatch.ItemClick
        Try
            gvMain.Columns.Clear()
            dsMain = FillGrid("SELECT Batchmaster.BatchID, FGMaster.FGName, Batchmaster.Qty " _
                & " FROM Batchmaster INNER JOIN FGMaster ON Batchmaster.FID = FGMaster.FID", "BatchMaster")

            gdMain.DataSource = dsMain.Tables("BatchMaster")
            stractivetable = "Batch"
            lblTableName.Text = "Bill of Material"
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnGroup_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnGroup.ItemClick
        Try
            gvMain.Columns.Clear()
            dsMain = FillGrid("Select * from groupMaster", "groupMaster")
            gdMain.DataSource = dsMain.Tables("groupMaster")
            stractivetable = "Group"
            lblTableName.Text = "Group"
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnPO_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnPO.ItemClick
        Try
            gvMain.Columns.Clear()
            dsMain = FillGrid("SELECT SupplierMaster.SuppName, Purchase_Master.PO_No, Purchase_Master.PO_Date, Purchase_Master.Qtn_No, Purchase_Master.Qtn_date FROM Purchase_Master INNER JOIN SupplierMaster ON Purchase_Master.SuppID = SupplierMaster.SID", "Purchase_Master")
            gdMain.DataSource = dsMain.Tables("Purchase_Master").DefaultView
            stractivetable = "Purchase"
            lblTableName.Text = "Purchase Order"
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnQC.ItemClick
        Try
            gvMain.Columns.Clear()
            dsMain = FillGrid("SELECT RMVI_NO,* FROM QCmaster", "QCmaster")
            gdMain.DataSource = dsMain.Tables("QCmaster").DefaultView
            stractivetable = "QC"
            lblTableName.Text = "Quality Check"
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
        stractivetable = "QC"
    End Sub

    Private Sub tbtnUnitConv_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnUnitConv.ItemClick
        Try
            gvMain.Columns.Clear()
            dsMain = FillGrid("SELECT UnitConMaster.RMID, RMItemMaster.RMItemName, UnitMaster.UnitName " _
                & " FROM (UnitConMaster INNER JOIN RMItemMaster ON UnitConMaster.RMID = RMItemMaster.Rid) INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID " _
                & " GROUP BY UnitConMaster.RMID, RMItemMaster.RMItemName, UnitMaster.UnitName", "UnitConMaster")
            gdMain.DataSource = dsMain.Tables("UnitConMaster").DefaultView
            stractivetable = "UnitConMaster"
            gvMain.Columns("RMID").Visible = False
            lblTableName.Text = "Unit Conversion"
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnRejection_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnRejection.ItemClick
        Try
            gvMain.Columns.Clear()
            dsMain = FillGrid("SELECT * FROM Reason", "Reason")
            gdMain.DataSource = dsMain.Tables("Reason").DefaultView
            stractivetable = "Reason"
            lblTableName.Text = "Reason for Rejaction"
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tBTnInvoice_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tBTnInvoice.ItemClick

        Try
            gvMain.Columns.Clear()

            dsMain = FillGrid("SELECT InvoiceMaster.Order_No, InvoiceMaster.Order_Date, InvoiceMaster.Challan_No, CustomerMaster.CustName " _
                  & "FROM (InvoiceMaster INNER JOIN CustomerMaster ON InvoiceMaster.CID = CustomerMaster.CID) order by VAL(InvoiceMaster.Order_No)", "InvoiceMaster")

            gdMain.DataSource = dsMain.Tables("InvoiceMaster").DefaultView
            stractivetable = "Invoice"
            lblTableName.Text = "Order Memo"
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub


    Private Sub tBtnChallanm_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tBtnChallanm.ItemClick
        Try
            gvMain.Columns.Clear()
            dsMain = FillGrid("SELECT ChallanMaster.Challan_No, ChallanMaster.Challan_dt, ChallanMaster.Order_No, ChallanMaster.Order_Date, CustomerMaster.CustName " _
                     & " FROM ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID order by VAL(ChallanMaster.Challan_No)", "Challan")
            gdMain.DataSource = dsMain.Tables("Challan").DefaultView
            stractivetable = "Challan"
            lblTableName.Text = "Challan"
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnPOrpt_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnPOrpt.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "PO"
            myobj.Show()
            'myobj.Dispose()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tBTnOrderrpt_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tBTnOrderrpt.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "InvoiceRpt"
            myobj.Show()
            'myobj.Dispose()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub tBTnNonCon_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tBTnNonCon.ItemClick
        Try
            gvMain.Columns.Clear()
            dsMain = FillGrid("SELECT Non_Con_Product.Sr_No, Non_Con_Product.Complain_Date, Non_Con_Product.ComPlain_No, RMItemMaster.RMItemName as Item_Name, Non_Con_Product.Qty,Non_Con_Product.Make, Non_Con_Product.Item_Sr_No, SupplierMaster.SuppName as Supplier_Name, " _
                & " Non_Con_Product.Reason_Defect, Non_Con_Product.Action_Taken " _
                & " FROM (RMItemMaster INNER JOIN Non_Con_Product ON RMItemMaster.Rid = Non_Con_Product.RID) INNER JOIN SupplierMaster ON Non_Con_Product.SID = SupplierMaster.SID", "Non_Con_Product")

            gdMain.DataSource = dsMain.Tables("Non_Con_Product").DefaultView
            gvMain.Columns(0).Visible = False
            stractivetable = "Non_Con"
            lblTableName.Text = "Non Confirming Product"
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub tBTnrptDisposition_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tBTnrptDisposition.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "DisposeRpt"
            myobj.Show()
            'myobj.Dispose()
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tBtnrptNonCon_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tBtnrptNonCon.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "NonConformRpt"
            myobj.Show()
            'myobj.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub


    Private Sub tBTnDispose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tBTnDispose.ItemClick
        Try
            gvMain.Columns.Clear()
            dsMain = FillGrid("SELECT * FROM Disposition_status", "Disposition")
            gdMain.DataSource = dsMain.Tables("Disposition").DefaultView
            gvMain.Columns(0).Visible = False
            stractivetable = "Dispose"
            lblTableName.Text = "Disposition Status"
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub


    Private Sub tbtnRequisition_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnRequisition.ItemClick
        Try
            gvMain.Columns.Clear()
            dsMain = FillGrid("SELECT REQMASTER.RQID, REQMASTER.REQID, FGMaster.FGName, UnitMaster.UnitName, REQMASTER.QTY " _
                & " FROM (REQMASTER INNER JOIN FGMaster ON REQMASTER.FID = FGMaster.FID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID order by REQMASTER.RQID", "REQESTION")
            gdMain.DataSource = dsMain.Tables("REQESTION").DefaultView
            stractivetable = "Requisition"
            lblTableName.Text = "Requisition"
            gvMain.Columns(0).Visible = False
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub tbtnReport_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnReport.ItemClick
        'CmdEdit.Enabled = False
        'cmdDelete.Enabled = False
    End Sub

    Private Sub tBTnRMOpStock_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tBTnRMOpStock.ItemClick
        Try
            gvMain.Columns.Clear()

            dsMain = FillGrid("SELECT RM_Opening_Stock.ID, RM_Opening_Stock.RID, RMItemMaster.RMItemName, UnitMaster.UnitName, GroupMaster.GroupName, RM_Opening_Stock.RMVI_NO, RM_Opening_Stock.Opening_Qty, RM_Opening_Stock.Register_Date" _
                 & " FROM ((RM_Opening_Stock INNER JOIN UnitMaster ON RM_Opening_Stock.UnitID = UnitMaster.UnitID) INNER JOIN RMItemMaster ON (RMItemMaster.Rid = RM_Opening_Stock.RID) AND (UnitMaster.UnitID = RMItemMaster.UnitId)) INNER JOIN GroupMaster ON RMItemMaster.GroupID = GroupMaster.GroupID", "RM_Op_Stock")

            gdMain.DataSource = dsMain.Tables("RM_Op_Stock").DefaultView
            stractivetable = "RM_OP_Stk"
            lblTableName.Text = "Raw Material Opening Stock"
            gvMain.Columns(0).Visible = False
            gvMain.Columns(1).Visible = False
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try


    End Sub

    Private Sub tBTnFGOpStock_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tBTnFGOpStock.ItemClick
        Try
            gvMain.Columns.Clear()
            'dsMain = FillGrid("SELECT FG_Opening_Stock.ID, FG_Opening_Stock.FID,FGMaster.FGName,UnitMaster.UnitName, FG_Opening_Stock.FGVI_NO, FG_Opening_Stock.Opening_Qty, FG_Opening_Stock.Register_Date " _
            '                & " FROM (FGMaster INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN FG_Opening_Stock ON (UnitMaster.UnitID = FG_Opening_Stock.UnitID) AND (FGMaster.FID = FG_Opening_Stock.FID)", "FG_OP_Stock")
            dsMain = FillGrid("SELECT FG_Opening_Stock.ID,FGMaster.FGName, FG_Opening_Stock.FID, UnitMaster.UnitName, GroupMaster.GroupName, FG_Opening_Stock.FGVI_NO, FG_Opening_Stock.Opening_Qty, FG_Opening_Stock.Register_Date " _
                 & " FROM GroupMaster INNER JOIN (FGMaster INNER JOIN (UnitMaster INNER JOIN FG_Opening_Stock ON UnitMaster.UnitID = FG_Opening_Stock.UnitID) ON FGMaster.FID = FG_Opening_Stock.FID) ON GroupMaster.GroupID = FGMaster.GroupID", "FG_OP_Stock")

            gdMain.DataSource = dsMain.Tables("FG_OP_Stock").DefaultView
            stractivetable = "FG_OP_Stk"
            lblTableName.Text = "Finish Goods Opening Stock"
            gvMain.Columns(0).Visible = False
            gvMain.Columns(2).Visible = False

        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnRMStock_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnRMStock.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "RM_Stock"
            myobj.Show()
            'myobj.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnMatIssue_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnMatIssue.ItemClick
        'DHAVAL
        Try
            'Dim myobj As New frmMat_Issue
            'myobj.ShowDialog()
            'myobj.Dispose()

            gvMain.Columns.Clear()
            dsMain = FillGrid("SELECT Material_Issue_Master.MIS_NO, Material_Issue_Master.MIS_DATE, Material_Issue_Master.RQID, FGMaster.FGName, Material_Issue_Master.FG_QTY " _
                & " FROM Material_Issue_Master INNER JOIN FGMaster ON Material_Issue_Master.FGID = FGMaster.FID order by VAL(Material_Issue_Master.MIS_NO)", "Mat_Issue")

            gdMain.DataSource = dsMain.Tables("Mat_Issue").DefaultView
            stractivetable = "Mat_Issue"
            lblTableName.Text = "Materail Issue Slip Details"

        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tBtnQCFG_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tBtnQCFG.ItemClick
        'DHAVAL
        Try
            gvMain.Columns.Clear()
            dsMain = FillGrid("SELECT FinishGoods_QCMaster.FGVI_NO, FinishGoods_QCMaster.VI_Date, FGMaster.FGName, FinishGoods_QCDetail.Inspected_No,  FinishGoods_QCDetail.MIS_NO as [MIS NO], FinishGoods_QCDetail.QC_No, FinishGoods_QCDetail.Reject_Qty " _
                            & " FROM (FinishGoods_QCMaster INNER JOIN FinishGoods_QCDetail ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO) INNER JOIN FGMaster ON FinishGoods_QCDetail.FID = FGMaster.FID order by FinishGoods_QCMaster.FGVI_NO", "FGQC")
            gdMain.DataSource = dsMain.Tables("FGQC").DefaultView

            stractivetable = "FG_QC"
            lblTableName.Text = "Quality Control of Finish Goods"

        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tBtnFGQCRpt_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tBtnFGQCRpt.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "FCQC_Rpt"
            myobj.Show()
            'myobj.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub BarButtonItem3_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnBatchReg.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "BatchReg_Rpt"
            myobj.Show()
            'myobj.Dispose()
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub


    Private Sub tbtnFGStock_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnFGStock.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "FG_Stock"
            myobj.Show()
            'myobj.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnRMList_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnRMList.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "RMList"
            myobj.Show()
            'myobj.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnFGList_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnFGList.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "FGList"
            myobj.Show()
            'myobj.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnCustList_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnCustList.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "CustList"
            myobj.Show()
            'myobj.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnSuppList_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnSuppList.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "SuppList"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbrnChallan_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbrnChallan.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "Challan"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "Mat_Req"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnMIS_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnMIS.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "MIS"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnSterilization_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnSterilization.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "Sterilization"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "RMQC"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnBOM_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnBOM.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "BOM"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnRMVI_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnRMVI.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "PendingRMVI"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnPendingMIS_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnPendingMIS.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "PendingMIS"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnCompMaster_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnCompMaster.ItemClick
        Try
            gvMain.Columns.Clear()
            dsMain = FillGrid("Select * from CompanyMaster", "CompanyMaster")
            gdMain.DataSource = dsMain.Tables("CompanyMaster").DefaultView
            stractivetable = "CompanyMaster"
            lblTableName.Text = "Company Deatails"
            gvMain.Columns(0).Visible = False
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub tbtnChangePass_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnChangePass.ItemClick
        Try
            Dim myObj As New frmChangePass
            myObj.ShowDialog()
            myObj.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub tbtnLogoff_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnLogoff.ItemClick
        Try
            myMain.Visible = False
            myMain.Close()
            myMain.Dispose()
            strGVUserID = ""
            myLogin = New frmLogin
            myLogin.ShowDialog()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnInwardTriplicate_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnInwardTriplicate.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "InwardTriplicate"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnRMCompReg_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnRMCompReg.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "RMCompReg"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnFGCompReg_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnFGCompReg.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "FGCompReg"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnCWPWSales_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnCWPWSales.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "CWPWS"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnPWCWSales_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnPWCWSales.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "PWCWS"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnRecall_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnRecall.ItemClick
        Try
            Dim myobj As New frmRecallReg
            myobj.ShowDialog()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnJobWorkIssue_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnJobWorkIssue.ItemClick
        Try
            gvMain.Columns.Clear()
            dsMain = FillGrid("Select JID,JWID as [Job Work ID],JWDATE as [Job Work Date] from JW_ISSUE_Master", "JW_Issue")
            gdMain.DataSource = dsMain.Tables("JW_Issue").DefaultView
            stractivetable = "JW"
            gvMain.Columns("JID").Visible = False
            lblTableName.Text = "Job Work Issue"
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnRMGroup_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnRMGroup.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "RM_Stock_Group"
            myobj.Show()
            'myobj.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtFGGroup_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtFGGroup.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "FG_Stock_Group"
            myobj.Show()
            'myobj.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnTRInward_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnTRInward.ItemClick
        Try
            gvMain.Columns.Clear()
            dsMain = FillGrid("SELECT  TI_Rec_Master.RecID,TI_Rec_Master.RecNo, TI_Rec_Master.RecDate, SupplierMaster.SuppName FROM TI_Rec_Master INNER JOIN SupplierMaster ON TI_Rec_Master.SID = SupplierMaster.SID;", "Trading")
            gdMain.DataSource = dsMain.Tables("Trading").DefaultView
            stractivetable = "TR_Inward"
            lblTableName.Text = "Trading Item Inward"
            gvMain.Columns(0).Visible = False
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnGoodsRet_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnGoodsRet.ItemClick
        Try

            gvMain.Columns.Clear()
            dsMain = FillGrid("Select * from FG_Ret_Master", "FGRet")
            gdMain.DataSource = dsMain.Tables("FGRet").DefaultView
            stractivetable = "FG_Ret"
            lblTableName.Text = "Finish Good Return"

        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnPurchaseReg_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnPurchaseReg.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "Purchase_Reg"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnSalesReg_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnSalesReg.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "Sales_Reg"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnBatch_Stock_Reg_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnBatch_Stock_Reg.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "Batch_Stock_Reg"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnBackup_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnBackup.ItemClick
        Try
            Dim strBackLoc As String
            Dim folDlg As New FolderBrowserDialog
            folDlg.ShowDialog()
            strBackLoc = folDlg.SelectedPath
            If System.IO.Directory.Exists(strBackLoc) = True Then
                System.IO.File.Copy(Application.StartupPath & "\Inventory Shaili.mdb", strBackLoc & "\Inventory Shaili.mdb", True)
            Else
                System.IO.File.Copy(Application.StartupPath & "\Inventory Shaili.mdb", strBackLoc & "\Inventory Shaili.mdb", True)
            End If
            DevExpress.XtraEditors.XtraMessageBox.Show("Back up taken successfully", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnRMStockCons_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnRMStockCons.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "RMStockCons"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnCW_BW_Sales_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnCW_BW_Sales.ItemClick
        Try
            Dim myobj As New frmPara1
            myobj.strReport = "CW_BW_Sales"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnBW_CW_Sales_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnBW_CW_Sales.ItemClick
        Try
            Dim myobj As New frmPara1
            myobj.strReport = "BW_CW_Sales"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnTradingInward_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnTradingInward.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "TI"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnFGStockCons_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnFGStockCons.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "FGStockCons"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub btnComChart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComChart.Click
        'Try
        '    Dim myObj As New frmCompChart
        '    myObj.ShowDialog()
        'Catch ex As Exception
        '    If show_error Then
        '        MsgBox(ex.ToString)
        '    End If
        'End Try
    End Sub

    Private Sub tbtnJobWorkRet_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnJobWorkRet.ItemClick
        'Try
        '    Dim myobj As New frmJWReturn
        '    myobj.ShowDialog()
        'Catch ex As Exception
        '    If show_error Then
        '        MsgBox(ex.ToString)
        '    End If
        'End Try


        Try
            gvMain.Columns.Clear()
            'dsMain = FillGrid("Select JID,JWID as [Job Work ID],JWDATE as [Job Work Date] from JW_ISSUE_Master", "JW_Issue")
            dsMain = FillGrid("SELECT JW_Ret_Master.ID, JW_Ret_Master.JW_Issue_ID AS [Job Work Issue ID], JW_Ret_Master.JW_Ret_ID as [Job Work Retrun ID], JW_Ret_Master.JW_Ret_Dt as [Job work Retrun Date] FROM JW_Ret_Master", "JW_Ret")

            gdMain.DataSource = dsMain.Tables("JW_Ret").DefaultView
            stractivetable = "JR"
            gvMain.Columns("ID").Visible = False
            lblTableName.Text = "Job Work Retrun"
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnPendSterz_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnPendSterz.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "PendingStrz"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SetUserLevel()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SetMasterMenu()
        Try
            tbtnUser.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            tbtnBackup.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        Catch ex As Exception

        End Try
    End Sub
    Private Sub SetUserLevel()
        Try
            If strGVUserID.ToString <> "UR00000001" Then
                cmd = New OleDb.OleDbCommand
                cmd.CommandText = "SELECT * FROM USER_RIGHTS WHERE UID ='" & strGVUserID & "'"
                cmd.Connection = conn
                dr = cmd.ExecuteReader

                tbtnPO.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                tbtnQC.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                tBTnInvoice.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                tBtnChallanm.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                tbtnRequisition.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                tbtnMatIssue.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                tBtnQCFG.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                tbtnJobWorkIssue.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                tbtnJobWorkRet.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                tBTnDispose.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                tbtnRecall.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                tbtnTRInward.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                tbtnGoodsRet.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                tBtnCustomer.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                tBtnSupplier.Visibility = DevExpress.XtraBars.BarItemVisibility.Never


                Do While dr.Read
                    If dr.Item(1).ToString = "PURCHASE ORDER" Then
                        tbtnPO.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        'tbtnPO.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If

                    If dr.Item(1).ToString = "INWARD TRIPLICATE" Then
                        tbtnQC.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        'tbtnQC.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If

                    If dr.Item(1).ToString = "ORDER MEMO" Then
                        tBTnInvoice.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        'tBTnInvoice.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If

                    If dr.Item(1).ToString = "CHALLAN" Then
                        tBtnChallanm.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        'tBtnChallanm.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If

                    If dr.Item(1).ToString = "PRODUCTION REQUISITION" Then
                        tbtnRequisition.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        'tbtnRequisition.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If

                    If dr.Item(1).ToString = "MIS" Then
                        tbtnMatIssue.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        'tbtnMIS.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If

                    If dr.Item(1).ToString = "QC FOR FINISH GOODS" Then
                        tBtnQCFG.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        'tBtnQCFG.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If

                    If dr.Item(1).ToString = "DEMO ISSUE" Then
                        tbtnJobWorkIssue.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        'tbtnJobWorkIssue.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If

                    If dr.Item(1).ToString = "DEMO RETURN" Then
                        tbtnJobWorkRet.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        'tbtnJobWorkRet.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If

                    If dr.Item(1).ToString = "DISPOSITION STATUS" Then
                        tBTnDispose.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        'tBTnDispose.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If

                    If dr.Item(1).ToString = "RECALL REGISTER" Then
                        tbtnRecall.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        'tbtnRecall.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If

                    If dr.Item(1).ToString = "TRADING ITEM INWARD" Then
                        tbtnTRInward.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        'tbtnTradingInward.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If

                    If dr.Item(1).ToString = "GOODS RETURN" Then
                        tbtnGoodsRet.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        'tbtnGoodsRet.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If

                    If dr.Item(1).ToString = "CUSTOMER" Then
                        tBtnCustomer.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        'tBtnCustomer.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If

                    If dr.Item(1).ToString = "SUPPLIER" Then
                        tBtnSupplier.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        'tBtnSupplier.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If
                Loop
                dr.Close()
                cmd.Dispose()

                tbtnUser.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                tbtnGroup.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                tBtnUnit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                tbtnUnitConv.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                tBtnRaw.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                tBtnFinishGood.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                tbtnBatch.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                tbtnRejection.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                tBTnNonCon.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                tBTnFGOpStock.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                tBTnRMOpStock.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                tbtnCompMaster.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                tbtnBackup.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

            End If


            'Select Case strUserLevel
            '    Case "ADMINISTRATOR"

            '    Case "PRODUCTION"
            '        tbtnPO.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnQC.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tBTnInvoice.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tBtnChallanm.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnRequisition.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            '        tbtnMatIssue.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tBtnQCFG.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnJobWorkIssue.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnJobWorkRet.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tBTnDispose.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnRecall.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnTRInward.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnGoodsRet.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '    Case "PURCHASE"
            '        tbtnPO.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            '        tbtnQC.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tBTnInvoice.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tBtnChallanm.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnRequisition.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnMatIssue.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tBtnQCFG.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnJobWorkIssue.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnJobWorkRet.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tBTnDispose.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnRecall.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnTRInward.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnGoodsRet.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '    Case "SALES"
            '        tBTnInvoice.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            '        tBtnchallan.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            '        tbtnPO.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnQC.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnRequisition.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnMatIssue.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tBtnQCFG.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnJobWorkIssue.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnJobWorkRet.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tBTnDispose.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnRecall.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnTRInward.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnGoodsRet.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '    Case "QC"
            '        tbtnPO.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tBTnInvoice.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tBtnChallanm.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnRequisition.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnMatIssue.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnQC.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            '        tbtnGoodsRet.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            '        tbtnTRInward.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            '        tBtnQCFG.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            '        tbtnJobWorkIssue.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnJobWorkRet.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tBTnDispose.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnRecall.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '    Case "STORE"
            '        tbtnPO.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnQC.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tBTnInvoice.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tBtnChallanm.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnRequisition.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnMatIssue.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            '        tbtnJobWorkIssue.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            '        tbtnJobWorkRet.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            '        tBtnQCFG.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        'tbtnJobWorkIssue.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        'tbtnJobWorkRet.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tBTnDispose.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnRecall.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnTRInward.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            '        tbtnGoodsRet.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            'End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tbtnMinMax_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnMinMax.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.Min_Max()
            myobj.Dispose()
            'myobj.strReport = "Min_Max"
            'myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnPendingOrders_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnPendingOrders.ItemClick
        Try
            Dim myrpt As New rptPendingOrders
            Dim strsql As String
            Dim ds As New DataSet

            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn

            strsql = "SELECT InvoiceMaster.Order_No, format(InvoiceMaster.Order_Date,'dd/MM/yyyy')as Order_Date, CustomerMaster.CustName, FGMaster.FGName, InvoiceDetail.Qty, Sum(ChallanDetail.Qty) AS Deli_Qty, " _
                & " InvoiceDetail.Qty-Sum(ChallanDetail.Qty) as Balance_Qty " _
                & " FROM FGMaster INNER JOIN ((((InvoiceMaster INNER JOIN InvoiceDetail ON InvoiceMaster.Order_No = InvoiceDetail.Order_No) INNER JOIN ChallanMaster ON InvoiceMaster.Order_No = ChallanMaster.Order_No) INNER JOIN ChallanDetail ON (InvoiceMaster.Order_No = ChallanDetail.Order_No) AND (ChallanMaster.Challan_No = ChallanDetail.Challan_No)) INNER JOIN CustomerMaster ON InvoiceMaster.CID = CustomerMaster.CID) ON (ChallanDetail.FID = FGMaster.FID) AND (FGMaster.FID = InvoiceDetail.FID) " _
                & " GROUP BY InvoiceMaster.Order_No, InvoiceMaster.Order_Date, CustomerMaster.CustName, FGMaster.FGName, InvoiceDetail.FID, InvoiceDetail.Qty " _
                & " HAVING (((Sum(ChallanDetail.Qty))<[InvoiceDetail]![Qty]));"

            Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
            adp.Fill(ds, "PendingOrders")
            adp.Dispose()

            strsql = "SELECT InvoiceMaster.Order_No, format(InvoiceMaster.Order_Date,'dd/MM/yyyy')as Order_Date, CustomerMaster.CustName, FGMaster.FGName, InvoiceDetail.Qty, InvoiceMaster.Challan_No, InvoiceDetail.Qty as Balance_Qty " _
                & " FROM FGMaster INNER JOIN ((InvoiceMaster INNER JOIN InvoiceDetail ON InvoiceMaster.Order_No = InvoiceDetail.Order_No) INNER JOIN CustomerMaster ON InvoiceMaster.CID = CustomerMaster.CID) ON FGMaster.FID = InvoiceDetail.FID " _
                & " GROUP BY InvoiceMaster.Order_No, InvoiceMaster.Order_Date, CustomerMaster.CustName, FGMaster.FGName, InvoiceDetail.Qty, InvoiceMaster.Challan_No,InvoiceDetail.Qty " _
                & " HAVING InvoiceMaster.Challan_No='' OR InvoiceMaster.Challan_No Is Null "

            adp = New OleDb.OleDbDataAdapter(strsql, conn)
            adp.Fill(ds, "PendingOrders")

            adp.SelectCommand.CommandText = "Select CompanyName,(Add1 + ',' + Add2 + ',' + City + ',' + State + ',' + Pincode + ',' + country +' Phone: ' + phone + ', Fax: ' + fax ) as Address from companyMaster"
            adp.Fill(ds, "Company")

            myrpt.DataSource = ds

            myrpt.XrTableCell1.DataBindings.Add("Text", ds, "PendingOrders.CustName")
            myrpt.XrTableCell2.DataBindings.Add("Text", ds, "PendingOrders.FGName")
            myrpt.XrTableCell3.DataBindings.Add("Text", ds, "PendingOrders.Qty")
            myrpt.XrTableCell4.DataBindings.Add("Text", ds, "PendingOrders.Deli_Qty")
            myrpt.XrTableCell5.DataBindings.Add("Text", ds, "PendingOrders.Balance_Qty")
            myrpt.XrLabel4.DataBindings.Add("Text", ds, "PendingOrders.Order_Date")

            myrpt.XrLabel5.DataBindings.Add("Text", ds, "Company.CompanyName")
            myrpt.XrLabel7.DataBindings.Add("Text", ds, "Company.Address")

            myrpt.XrLabel6.Text = myrpt.XrLabel6.Text & " " & Today.Date

            myrpt.GroupHeader1.GroupFields.Item(0).FieldName = "Order_No"
            myrpt.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "PendingOrders.Order_No", "")})

            Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            myrpt.PrintingSystem = printingSystem
            myrpt.ShowPreview()
            adp.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnDemoSales_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnDemoSales.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "DemoSales"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnMinMaxRM_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnMinMaxRM.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.Min_Max_RM()
            myobj.Dispose()
            'myobj.strReport = "Min_Max"
            'myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnPWBW_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnPWBW.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "PWBW"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnBalanceCF_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnBalanceCF.ItemClick
        Try
            Dim myBalCF As New frmBalCF
            myBalCF.ShowDialog()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnCWPW_Cons_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnCWPW_Cons.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "CWPWS_Cons"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnPWCWSales_Cons_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnPWCWSales_Cons.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "PWCWS_Cons"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtndemoIssue_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtndemoIssue.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "Demo Issue"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnDemoReturn_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnDemoReturn.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "Demo Ret"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub


    Private Sub tbtnGoodRetRep_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnGoodRetRep.ItemClick
        Try
            Dim myobj As New frmPara
            myobj.strReport = "Goods_Ret"
            myobj.Show()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub tbtnDailyBook_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles tbtnDailyBook.ItemClick
        Dim myFrm As New frmDayBook
        myFrm.Show()
    End Sub
End Class

