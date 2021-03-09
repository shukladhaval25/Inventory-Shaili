Public Class frmPara
    Inherits DevExpress.XtraEditors.XtraForm

    Public strReport As String
    Friend WithEvents lstList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Public strID As String

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
    Friend WithEvents cmdOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lkupName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents grpdate As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dtpTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblName As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.lstList = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.grpdate = New DevExpress.XtraEditors.GroupControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpTo = New DevExpress.XtraEditors.DateEdit
        Me.dtpFrom = New DevExpress.XtraEditors.DateEdit
        Me.lkupName = New DevExpress.XtraEditors.LookUpEdit
        Me.lblName = New System.Windows.Forms.Label
        Me.cmdOK = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpdate.SuspendLayout()
        CType(Me.dtpTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lstList)
        Me.GroupControl1.Controls.Add(Me.grpdate)
        Me.GroupControl1.Controls.Add(Me.lkupName)
        Me.GroupControl1.Controls.Add(Me.lblName)
        Me.GroupControl1.Location = New System.Drawing.Point(3, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(344, 139)
        Me.GroupControl1.TabIndex = 0
        '
        'lstList
        '
        Me.lstList.CheckBoxes = True
        Me.lstList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstList.Location = New System.Drawing.Point(9, 23)
        Me.lstList.Name = "lstList"
        Me.lstList.Size = New System.Drawing.Size(329, 47)
        Me.lstList.TabIndex = 4
        Me.lstList.UseCompatibleStateImageBehavior = False
        Me.lstList.View = System.Windows.Forms.View.List
        Me.lstList.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = ""
        '
        'grpdate
        '
        Me.grpdate.Controls.Add(Me.Label3)
        Me.grpdate.Controls.Add(Me.Label2)
        Me.grpdate.Controls.Add(Me.dtpTo)
        Me.grpdate.Controls.Add(Me.dtpFrom)
        Me.grpdate.Location = New System.Drawing.Point(9, 76)
        Me.grpdate.Name = "grpdate"
        Me.grpdate.Size = New System.Drawing.Size(328, 56)
        Me.grpdate.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(176, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "From"
        '
        'dtpTo
        '
        Me.dtpTo.EditValue = New Date(2007, 1, 19, 0, 0, 0, 0)
        Me.dtpTo.Location = New System.Drawing.Point(216, 24)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpTo.Size = New System.Drawing.Size(96, 20)
        Me.dtpTo.TabIndex = 1
        '
        'dtpFrom
        '
        Me.dtpFrom.EditValue = New Date(2007, 1, 19, 0, 0, 0, 0)
        Me.dtpFrom.Location = New System.Drawing.Point(64, 24)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFrom.Properties.DisplayFormat.FormatString = "d"
        Me.dtpFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.dtpFrom.Size = New System.Drawing.Size(96, 20)
        Me.dtpFrom.TabIndex = 0
        '
        'lkupName
        '
        Me.lkupName.EditValue = ""
        Me.lkupName.Location = New System.Drawing.Point(105, 34)
        Me.lkupName.Name = "lkupName"
        Me.lkupName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupName.Properties.NullText = ""
        Me.lkupName.Size = New System.Drawing.Size(232, 20)
        Me.lkupName.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(17, 34)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(88, 24)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Label1"
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(100, 157)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(72, 23)
        Me.cmdOK.TabIndex = 1
        Me.cmdOK.Text = "&OK"
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(178, 157)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(72, 23)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "&Cancel"
        '
        'frmPara
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(352, 186)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPara"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Parameter"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpdate.ResumeLayout(False)
        CType(Me.dtpTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub SetFormDesign(Optional ByVal flg As Boolean = False)
        Try
            If flg = False Then
                Me.Height = 380
                lstList.Visible = True
                lblName.Visible = False
                lkupName.Visible = False
                grpdate.Visible = False
                GroupControl1.Height = 288
                lstList.Height = 260
                cmdOK.Top = 304
                cmdCancel.Top = 304
            Else
                Me.Height = 360
                lstList.Visible = True
                lblName.Visible = False
                lkupName.Visible = False
                GroupControl1.Height = 288
                grpdate.Visible = True
                grpdate.Top = 228
                lstList.Height = 199
                cmdOK.Top = 304
                cmdCancel.Top = 304
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub frmPara_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            lstList.View = View.Details

            Select Case strReport
                Case "PO"
                    'FillLookup("SELECT Purchase_Master.PO_No, SupplierMaster.SuppName " _
                    '& "FROM Purchase_Master INNER JOIN SupplierMaster ON Purchase_Master.SuppID = SupplierMaster.SID", "Purchase", "PO_No", "Supplier Name", lkupName)
                    'lkupName.Properties.Columns(1).Visible = True
                    SetFormDesign()
                    lstList.Columns(0).Width = (lstList.Width / 2) - 20
                    lstList.Columns(1).Width = lstList.Width - lstList.Columns(0).Width
                    FillList("SELECT Purchase_Master.PO_No, SupplierMaster.SuppName " _
                    & "FROM Purchase_Master INNER JOIN SupplierMaster ON Purchase_Master.SuppID = SupplierMaster.SID order by PO_No", "Purchase", "PO_No", "Supplier Name", lstList)
                    lstList.Columns(0).Text = "PO No."
                    lstList.Columns(1).Text = "Supplier"
                    grpdate.Visible = False
                    lblName.Text = "PO No."
                Case "InvoiceRpt"
                    SetFormDesign()
                    'FillLookup("SELECT InvoiceMaster.Order_No,InvoiceMaster.Order_No " _
                    '& "FROM InvoiceMaster INNER JOIN CustomerMaster ON InvoiceMaster.CID = CustomerMaster.CID", "Invoice", "Orer_No", "Challan No", lkupName)
                    'lkupName.Properties.Columns(1).Visible = True
                    lstList.Columns(0).Width = (lstList.Width / 2) - 20
                    lstList.Columns(1).Width = lstList.Width - lstList.Columns(0).Width
                    FillList("SELECT InvoiceMaster.Order_No,CustomerMaster.CustName " _
                    & "FROM InvoiceMaster INNER JOIN CustomerMaster ON InvoiceMaster.CID = CustomerMaster.CID order by Order_Date,Order_No", "Invoice", "Orer_No", "Challan No", lstList)
                    lstList.Columns(0).Text = "Order No"
                    lstList.Columns(1).Text = "Customer"
                    'lblName.Text = "Order No."
                    grpdate.Visible = False
                Case "DisposeRpt"
                    FillLookup("select distinct(Category),SR_No from disposition_status", "Dispose_Status", "Category", "Date", lkupName)
                    lblName.Text = "Category_Type"
                Case "RM_Stock", "RMCompReg", "RMStockCons", "RM_Rejection"
                    SetFormDesign(True)
                    lstList.Columns(0).Width = lstList.Width - 20
                    lstList.Columns(1).Width = 0
                    FillList("Select RMItemMaster.RMItemName,RMItemMaster.Rid from RMItemMaster order by RMItemMaster.RMItemName", "RMItem", "Item Name", "Item ID", lstList)
                    lstList.Columns(0).Text = "Item Name"
                Case "Semi_FG_Stock", "SemiFGCompReg", "Semi_FG_Stock_Cons"
                    SetFormDesign(True)
                    lstList.Columns(0).Width = lstList.Width - 20
                    lstList.Columns(1).Width = 0
                    FillList("Select FGName,SFID from SEMIFGMASTER order by FGName", "RMItem", "Item Name", "Item ID", lstList)
                    lstList.Columns(0).Text = "Item Name"
                Case "Semi_FG_Stock_Group"
                    FillList("SELECT GroupMaster.GroupName, SEMIFGMASTER.GroupID " _
                         & " FROM SEMIFGMASTER INNER JOIN GroupMaster ON SEMIFGMASTER.GroupID = GroupMaster.GroupID " _
                         & " GROUP BY GroupMaster.GroupName, SEMIFGMASTER.GroupID ", "Group", "Group", "GroupID", lstList)
                    SetFormDesign(True)
                    lstList.Columns(0).Width = lstList.Width - 20
                    lstList.Columns(1).Width = 0
                    lstList.Columns(0).Text = "Group"
                    grpdate.Visible = True
                    lblName.Text = "Group"
                Case "FCQC_Rpt"
                    FillLookup("SELECT FinishGoods_QCMaster.FGVI_NO, FGMaster.FGName,FinishGoods_QCMaster.FGVI_NO " _
                        & " FROM (FinishGoods_QCMaster INNER JOIN FinishGoods_QCDetail ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO) INNER JOIN FGMaster ON FinishGoods_QCDetail.FID = FGMaster.FID order by VI_Date,FinishGoods_QCMaster.FGVI_NO", "FinishQC", "Visual Inspection Number", "Finish Product", lkupName, "VI NO")
                    lblName.Text = "Visual Inspectin Number"
                    lkupName.Properties.Columns(1).Visible = True
                    lkupName.Properties.Columns(2).Visible = False
                Case "RMQC"
                    FillLookup("SELECT QCMaster.RMVI_NO,RMItemMaster.RMItemName, QCMaster.RMVI_NO " _
                        & " FROM RMItemMaster INNER JOIN (QCMaster INNER JOIN QCDetail ON QCMaster.RMVI_NO = QCDetail.RMVI_NO) ON RMItemMaster.Rid = QCDetail.RID", "RMQC", "RMVI No", "Item Name", lkupName, "RMVI NO")
                    lkupName.Properties.Columns(1).Visible = True
                    lkupName.Properties.Columns(2).Visible = False
                    lblName.Text = "Visual Inspectin Number"
                Case "BatchReg_Rpt"
                    SetFormDesign(True)
                    lstList.Columns(0).Width = lstList.Width - 20
                    lstList.Columns(1).Width = 0
                    FillList("SELECT FGMaster.FGName, FinishGoods_QCDetail.FID  " _
                               & " FROM FinishGoods_QCDetail INNER JOIN FGMaster ON FinishGoods_QCDetail.FID = FGMaster.FID Group by FGMaster.FGName, FinishGoods_QCDetail.FID ", "FG", "Final Product", "FID", lstList)
                    lstList.Columns(0).Text = "Finish Good"
                    'FillLookup("SELECT FGMaster.FGName, FinishGoods_QCDetail.FID  " _
                    '           & " FROM FinishGoods_QCDetail INNER JOIN FGMaster ON FinishGoods_QCDetail.FID = FGMaster.FID", "FG", "Final Product", "FID", lkupName)
                    'lblName.Text = "Final Product Name"
                    'grpdate.Visible = False
                Case "FGCompReg"
                    SetFormDesign(True)
                    lstList.Columns(0).Width = lstList.Width - 20
                    lstList.Columns(1).Width = 0
                    FillList("Select FGMaster.FGName,FGMaster.fid from FGMaster ", "FG", "Finish Good Name", "Item ID", lstList)
                    lstList.Columns(0).Text = "Finish Good"
                Case "FG_Stock", "PWCWS", "FGStockCons", "PWBW", "PWCWS_Cons"
                    FillLookup("Select FGMaster.FGName,FGMaster.fid from FGMaster ", "FG", "Finish Good Name", "Item ID", lkupName)
                    'lkupName.Properties.Columns(1).Visible = True
                    grpdate.Visible = True
                    lblName.Text = "Finish Good Name"
                Case "BOM"
                    FillLookup("SELECT FGMaster.FGName, FGMaster.FID " _
                        & " FROM FGMaster INNER JOIN BatchMaster ON FGMaster.FID = BatchMaster.FID", "FG", "Finish Good Name", "Item ID", lkupName)
                    grpdate.Visible = False
                    lblName.Text = "Finish Good Name"
                Case "RMList"
                    FillLookup("SELECT GroupMaster.GroupName, RMItemMaster.GroupID " _
                        & " FROM RMItemMaster INNER JOIN GroupMaster ON RMItemMaster.GroupID = GroupMaster.GroupID " _
                        & " GROUP BY GroupMaster.GroupName, RMItemMaster.GroupID ", "Group", "Group", "GroupID", lkupName)
                    grpdate.Visible = False
                    lblName.Text = "Group"
                Case "FGList"
                    FillLookup("SELECT GroupMaster.GroupName, FGMaster.GroupID " _
                         & " FROM FGMaster INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID " _
                         & " GROUP BY GroupMaster.GroupName, FGMaster.GroupID ", "Group", "Group", "GroupID", lkupName)
                    grpdate.Visible = False
                    lblName.Text = "Group"
                Case "FG_Stock_Group"
                    FillLookup("SELECT GroupMaster.GroupName, FGMaster.GroupID " _
                        & " FROM FGMaster INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID " _
                        & " GROUP BY GroupMaster.GroupName, FGMaster.GroupID ", "Group", "Group", "GroupID", lkupName)
                    grpdate.Visible = True
                    lblName.Text = "Group"
                Case "RM_Stock_Group"
                    FillList("SELECT GroupMaster.GroupName, RMItemMaster.GroupID " _
                         & " FROM RMItemMaster INNER JOIN GroupMaster ON RMItemMaster.GroupID = GroupMaster.GroupID " _
                         & " GROUP BY GroupMaster.GroupName, RMItemMaster.GroupID ", "Group", "Group", "GroupID", lstList)
                    SetFormDesign(True)
                    lstList.Columns(0).Width = lstList.Width - 20
                    lstList.Columns(1).Width = 0
                    lstList.Columns(0).Text = "Group"
                    grpdate.Visible = True
                    lblName.Text = "Group"
                Case "CustList"
                    FillLookup("SELECT CustomerMaster.CustName, CustomerMaster.CustID " _
                        & " FROM CustomerMaster INNER JOIN GroupMaster ON CustomerMaster.CustGRno = GroupMaster.GroupID " _
                        & " GROUP BY CustomerMaster.CustName, CustomerMaster.CustID ", "Customer", "Name", "CustID", lkupName)
                    grpdate.Visible = False
                    lblName.Text = "Customer Name"
                    If strReport = "CWPWS" Then
                        grpdate.Visible = True
                    End If
                Case "CWPWS", "CWPWS_Cons"
                    FillLookup("SELECT CustomerMaster.CustName, CustomerMaster.CID " _
                        & " FROM CustomerMaster INNER JOIN GroupMaster ON CustomerMaster.CustGRno = GroupMaster.GroupID " _
                        & " GROUP BY CustomerMaster.CustName, CustomerMaster.CID ", "Customer", "Name", "CustID", lkupName)
                    grpdate.Visible = False
                    lblName.Text = "Customer Name"
                    grpdate.Visible = True
                Case "SuppList"
                    'FillList("SELECT SupplierMaster.SuppName, SupplierMaster.SuppID " _
                    '    & " FROM SupplierMaster INNER JOIN GroupMaster ON SupplierMaster.SuppGRno = GroupMaster.GroupID " _
                    '    & " GROUP BY SupplierMaster.SuppName, SupplierMaster.SuppID ", "Supplier", "Name", "SuppID", lstList)
                    FillLookup("SELECT SupplierMaster.SuppName, SupplierMaster.SuppID " _
                        & " FROM SupplierMaster INNER JOIN GroupMaster ON SupplierMaster.SuppGRno = GroupMaster.GroupID " _
                        & " GROUP BY SupplierMaster.SuppName, SupplierMaster.SuppID ", "Supplier", "Name", "SuppID", lkupName)
                    grpdate.Visible = False
                    lblName.Text = "Supplier Name"
                Case "Challan"
                    SetFormDesign()
                    FillList("SELECT  ChallanMaster.Challan_No,CustomerMaster.CustName" _
                        & " FROM ChallanMaster INNER JOIN CustomerMaster ON " _
                        & " ChallanMaster.CID = CustomerMaster.CID Order by ChallanMaster.Challan_Dt,ChallanMaster.Challan_No ;", "Challan", "Challan No", "Customer", lstList)
                    lstList.Columns(0).Width = (lstList.Width / 2) - 20
                    lstList.Columns(1).Width = lstList.Width - lstList.Columns(0).Width
                    lstList.Columns(0).Text = "Challan No"
                    lstList.Columns(1).Text = "Customer"
                    'FillLookup("SELECT  ChallanMaster.Challan_No,ChallanMaster.Challan_No " _
                    '    & " FROM ChallanMaster INNER JOIN CustomerMaster ON " _
                    '    & " ChallanMaster.CID = CustomerMaster.CID;", "Challan", "Challan No", "Customer", lkupName)
                    grpdate.Visible = False
                    'lblName.Text = "Challan No"
                    'lkupName.Properties.Columns(1).Visible = True
                Case "Mat_Req"
                    SetFormDesign()
                    lstList.Columns(0).Width = lstList.Width - 20
                    lstList.Columns(1).Width = 0
                    lstList.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.None)

                    FillList("SELECT  REQMASTER.REQID,FGMaster.FGName,REQMASTER.REQID " _
                        & " FROM FGMaster INNER JOIN REQMASTER ON FGMaster.FID = REQMASTER.FID " _
                        & " GROUP BY  REQMASTER.REQID,FGMaster.FGName,REQMASTER.REQDATE order by REQMASTER.REQDATE,REQMASTER.REQID;", "Req", "Req. ID", "Finish Good", lstList)
                    grpdate.Visible = False
                    lstList.Columns(0).Text = "Requisition No."
                    'lblName.Text = "Requisition No."
                    'lkupName.Properties.Columns(1).Visible = True
                    'lkupName.Properties.Columns(2).Visible = False
                Case "MIS"
                    SetFormDesign()
                    lstList.Columns(0).Width = (lstList.Width / 2) - 20
                    lstList.Columns(1).Width = lstList.Width - lstList.Columns(0).Width
                    FillList("SELECT Material_Issue_Master.MIS_NO, FGMaster.FGName, Material_Issue_Master.MIS_NO " _
                        & " FROM Material_Issue_Master INNER JOIN FGMaster ON Material_Issue_Master.FGID = FGMaster.FID order by MIS_Date,MIS_No", "MIS", "MIS No", "Finish Good", lstList)
                    'grpdate.Visible = False
                    lstList.Columns(0).Text = "MIS No."
                    'lkupName.Properties.Columns(1).Visible = True
                    'lkupName.Properties.Columns(2).Visible = False
                Case "CMIS"
                    SetFormDesign()
                    lstList.Columns(0).Width = (lstList.Width / 2) - 20
                    lstList.Columns(1).Width = lstList.Width - lstList.Columns(0).Width
                    FillList("SELECT SEMI_Material_Issue_Master.MIS_NO, SEMIFGMaster.FGName, SEMI_Material_Issue_Master.MIS_NO " _
                        & " FROM SEMI_Material_Issue_Master INNER JOIN SEMIFGMaster ON SEMI_Material_Issue_Master.SFGID = SEMIFGMaster.SFID order by MIS_Date,MIS_No", "CMIS", "MIS No", "Semi Finish Good", lstList)
                    'grpdate.Visible = False
                    lstList.Columns(0).Text = "MIS No."
                Case "Sterilization", "PendingRMVI", "PendingMIS", "Purchase_Reg", "Sales_Reg", "Batch_Stock_Reg", "PendingStrz", "DemoSales", "PendingPackingVI"
                    lblName.Visible = False
                    lkupName.Visible = False
                Case "InwardTriplicate"
                    'FillLookup("SELECT Sr_No,RMVI_NO from QCMaster", "QC", "Sr. No", "RMVI NO", lkupName)
                    SetFormDesign()
                    FillList("SELECT Sr_No,RMVI_NO from QCMaster", "QC", "Sr. No", "RMVI NO", lstList)
                    lstList.Columns(0).Text = "Sr. No"
                    lstList.Columns(1).Text = "RMVI No"
                    lstList.Columns(0).Width = (lstList.Width / 2) - 20
                    lstList.Columns(1).Width = lstList.Width - lstList.Columns(0).Width
                    grpdate.Visible = False
                    'lblName.Text = "Sr No."
                    'lkupName.Properties.Columns(1).Visible = True
                Case "TI"
                    SetFormDesign()
                    lstList.Columns(0).Width = lstList.Width - 20
                    lstList.Columns(1).Width = 0
                    lstList.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.None)

                    'FillLookup("SELECT TI_Rec_Master.RecNo,TI_Rec_Master.RecNo FROM TI_Rec_Master " _
                    '    & " GROUP BY TI_Rec_Master.RecNo, TI_Rec_Master.RecID;", "TI", "Rec No", "RID", lkupName)
                    FillList("SELECT TI_Rec_Master.RecNo,TI_Rec_Master.RecNo FROM TI_Rec_Master " _
                        & " GROUP BY TI_Rec_Master.RecNo, TI_Rec_Master.RecID Order by RecNo;", "TI", "Rec No", "RID", lstList)
                    lstList.Columns(0).Text = "Receive No."
                    grpdate.Visible = False
                    lblName.Text = "Receipt No."
                Case "Min_Max"
                    lblName.Visible = False
                    lkupName.Visible = False
                    Label2.Visible = False
                    dtpFrom.Visible = False
                    Label3.Left = dtpFrom.Left - 50
                    Label3.Text = "Min qty report as on date:"
                    Label3.Width = 155
                Case "Demo Issue"
                    FillLookup("SELECT JWID,JWID FROM JW_ISSUE_Master WHERE CY='" & strCY.Trim & "' ORDER BY JWID", "JI", "Demo Issue ID", "Demo Issue ID", lkupName)
                    grpdate.Visible = False
                    lblName.Text = "Demo Issue ID:"
                Case "Demo Ret"
                    FillLookup("SELECT JW_Ret_ID,JW_Ret_ID FROM JW_Ret_Master WHERE CY='" & strCY.Trim & "' ORDER BY JW_Ret_ID", "JR", "Demo Return ID", "Demo Return ID", lkupName)
                    grpdate.Visible = False
                    lblName.Text = "Demo Return ID:"
                Case "Goods_Ret"
                    FillLookup("Select cstr(RetNo),cstr(RetNo) from FG_Ret_Master where CY ='" & strCY.Trim & "' order by RetNo", "RET", "Return No", "Return No", lkupName)
                    grpdate.Visible = False
                    lblName.Text = "Goods Return ID:"
            End Select
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub lkupName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupName.EditValueChanged
        Try
            If lkupName.EditValue <> "" Then
                Dim row As DataRowView = lkupName.Properties.GetDataSourceRowByKeyValue(lkupName.EditValue)
                If strReport = "BatchReg_Rpt" Or strReport = "RMList" Or strReport = "FGList" Or _
                   strReport = "CustList" Or strReport = "SuppList" Or strReport = "BOM" Or _
                   strReport = "RMCompReg" Or strReport = "FGCompReg" Or strReport = "CWPWS" Or _
                   strReport = "InwardTriplicate" Or strReport = "PWCWS" Or strReport = "CWPWS_Cons" Or _
                   strReport = "PWCWS_Cons" Or strReport = "SemiFGCompReg" Then
                    strID = row(1).ToString
                Else
                    strID = row(0).ToString
                End If
            End If
        Catch ex As Exception
            If show_error = True Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Try
            Select Case strReport
                Case "PO"
                    For i As Integer = 0 To lstList.CheckedItems.Count - 1
                        If i = 0 Then
                            strID = lstList.CheckedItems(i).Text & "'"
                        Else
                            strID = strID & " or Purchase_Master.PO_No = '" & lstList.CheckedItems(i).Text & "'"
                        End If
                    Next
                    ShowPOReport(strID)
                Case "InvoiceRpt"
                    For i As Integer = 0 To lstList.CheckedItems.Count - 1
                        If i = 0 Then
                            strID = lstList.CheckedItems(i).Text & "'"
                        Else
                            strID = strID & " or InvoiceMaster.Order_No = '" & lstList.CheckedItems(i).Text & "'"
                        End If
                    Next
                    showInvoiceReport(strID)
                Case "DisposeRpt"
                    If strID Is Nothing Then
                        DevExpress.XtraEditors.XtraMessageBox.Show("Invalid category type", "Invalid category type", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    Else
                        showDispostionReport(strID)
                    End If
                    'showDispostionReport("R", dtpFrom.Text, dtpTo.Text)
                Case "NonConformRpt"
                    showNonConProReport()
                Case "RM_Stock", "RM_Stock_Group"
                    For i As Integer = 0 To lstList.CheckedItems.Count - 1
                        If i = 0 Then
                            strID = lstList.CheckedItems(i).Text & "'"
                        Else
                            strID = strID & " or A = '" & lstList.CheckedItems(i).Text & "'"
                        End If
                    Next
                    showRMStock()
                Case "RMStockCons"
                    For i As Integer = 0 To lstList.CheckedItems.Count - 1
                        If i = 0 Then
                            strID = lstList.CheckedItems(i).Text & "'"
                        Else
                            strID = strID & " or A = '" & lstList.CheckedItems(i).Text & "'"
                        End If
                    Next
                    showRMStockCons()
                Case "RM_Rejection"
                    For i As Integer = 0 To lstList.CheckedItems.Count - 1
                        If i = 0 Then
                            strID = lstList.CheckedItems(i).Text & "'"
                        Else
                            strID = strID & " or A = '" & lstList.CheckedItems(i).Text & "'"
                        End If
                    Next
                    showRMRejection()
                Case "FGStockCons"
                    showFGStockCons()
                Case "FCQC_Rpt"
                    showFinishGoodQC()
                Case "RMQC"
                    showRMQC()
                Case "BatchReg_Rpt"
                    For i As Integer = 0 To lstList.CheckedItems.Count - 1
                        If i = 0 Then
                            strID = lstList.CheckedItems(i).SubItems(1).Text & "'"
                        Else
                            strID = strID & " or FinishGoods_QCDetail.FID = '" & lstList.CheckedItems(i).SubItems(1).Text & "'"
                        End If
                    Next
                    If strID <> "" Then
                        showbbatchRefFG(strID)
                    Else
                        showbatchReg()
                    End If
                Case "FG_Stock", "FG_Stock_Group"
                    showFGStock()
                Case "RMList"
                    showRMList(strID)
                Case "FGList"
                    showFGList(strID)
                Case "CustList"
                    showCustList(strID)
                Case "SuppList"
                    showSuppList(strID)
                Case "Challan"
                    For i As Integer = 0 To lstList.CheckedItems.Count - 1
                        If i = 0 Then
                            strID = lstList.CheckedItems(i).Text & "'"
                        Else
                            strID = strID & " or ChallanMaster.Challan_No = '" & lstList.CheckedItems(i).Text & "'"
                        End If
                    Next
                    ShowChallan(strID)
                Case "Mat_Req"
                    For i As Integer = 0 To lstList.CheckedItems.Count - 1
                        If i = 0 Then
                            strID = lstList.CheckedItems(i).Text & "'"
                        Else
                            strID = strID & " or REQMASTER.REQID = '" & lstList.CheckedItems(i).Text & "'"
                        End If
                    Next
                    ShowMat_Req(strID)
                Case "MIS"
                    For i As Integer = 0 To lstList.CheckedItems.Count - 1
                        If i = 0 Then
                            strID = lstList.CheckedItems(i).Text & "'"
                        Else
                            strID = strID & " or   Material_Issue_Master.MIS_NO = '" & lstList.CheckedItems(i).Text & "'"
                        End If
                    Next
                    ShowMIS(strID)
                Case "CMIS"
                    For i As Integer = 0 To lstList.CheckedItems.Count - 1
                        If i = 0 Then
                            strID = lstList.CheckedItems(i).Text & "'"
                        Else
                            strID = strID & " or   SEMI_Material_Issue_Master.MIS_NO = '" & lstList.CheckedItems(i).Text & "'"
                        End If
                    Next
                    ShowCMIS(strID)
                Case "Sterilization"
                    showSterilization()
                Case "BOM"
                    If strID <> "" Then
                        ShowBOM(strID)
                    Else
                        DevExpress.XtraEditors.XtraMessageBox.Show("Invalid Product for bill of material", "Invalid Product", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If
                Case "PendingRMVI"
                    showPendingRMVI()
                Case "PendingMIS"
                    'showPendingMIS()
                    PenDingMIS()
                Case "PendingPackingVI"
                    PendingPackingVI()
                Case "PendingStrz"
                    ShowPendingStrz()
                Case "InwardTriplicate"
                    For i As Integer = 0 To lstList.CheckedItems.Count - 1
                        If i = 0 Then
                            strID = lstList.CheckedItems(i).SubItems(1).Text & "'"
                        Else
                            strID = strID & " Or  QCMaster.RMVI_NO ='" & lstList.CheckedItems(i).SubItems(1).Text & "'"
                        End If
                    Next
                    showInwardTriplicate(strID)
                Case "RMCompReg"
                    For i As Integer = 0 To lstList.CheckedItems.Count - 1
                        If i = 0 Then
                            strID = lstList.CheckedItems(i).SubItems(1).Text & "'"
                        Else
                            strID = strID & " or RID = '" & lstList.CheckedItems(i).SubItems(1).Text & "'"
                        End If
                    Next
                    showRMCompReg(strID)
                Case "SemiFGCompReg"
                    getSelectedSemifinishGoodIds()
                    showSemiFinishCompReg(strID)
                Case "FGCompReg"
                    For i As Integer = 0 To lstList.CheckedItems.Count - 1
                        If i = 0 Then
                            strID = lstList.CheckedItems(i).SubItems(1).Text & "'"
                        Else
                            strID = strID & " or FID = '" & lstList.CheckedItems(i).SubItems(1).Text & "'"
                        End If
                    Next
                    showFGCompReg(strID)
                Case "CWPWS", "PWCWS", "CWPWS_Cons", "PWCWS_Cons"
                    showCWPWS()
                Case "Purchase_Reg"
                    showPurchase_Reg()
                Case "Sales_Reg"
                    showSales_Reg()
                Case "Batch_Stock_Reg"
                    ShowBatch_Stock_Reg()
                Case "TI"
                    For i As Integer = 0 To lstList.CheckedItems.Count - 1
                        If i = 0 Then
                            strID = lstList.CheckedItems(i).SubItems(1).Text & "'"
                        Else
                            strID = strID & " Or  TI_Rec_Master.RecNo ='" & lstList.CheckedItems(i).SubItems(1).Text & "'"
                        End If
                    Next
                    ShowTI(strID)
                Case "Min_Max"
                    Min_Max()
                Case "DemoSales"
                    DemoSales()
                Case "PWBW"
                    PWBW_Det()
                Case "Demo Issue"
                    showDemoIssue(strID)
                Case "Demo Ret"
                    showDemoRet(strID)
                Case "Goods_Ret"
                    showGoodsRet(strID)
                Case "Semi_FG_Stock", "Semi_FG_Stock_Cons", "Semi_FG_Stock_Group"
                    For i As Integer = 0 To lstList.CheckedItems.Count - 1
                        If i = 0 Then
                            strID = lstList.CheckedItems(i).Text & "'"
                        Else
                            strID = strID & " or A = '" & lstList.CheckedItems(i).Text & "'"
                        End If
                    Next
                    DialogResult = DialogResult.OK
                Case Else
                    DialogResult = DialogResult.OK
            End Select
            Me.Close()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        Finally
            'Me.Dispose()
        End Try
    End Sub


    Private Sub DemoSales()
        Try
            Dim myrpt As New rptDemoSales
            Dim strsql As String
            Dim ds As New DataSet

            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn


            'strsql = "SELECT JW_ISSUE_Master.JWID,format(JW_ISSUE_Master.JWDATE,'dd/MM/yyyy') as JWDATE, FGMaster.FGName, JW_ISSUE_DET.BATCH_NO, JW_ISSUE_DET.QTY " _
            '    & " FROM (JW_ISSUE_Master INNER JOIN (JW_ISSUE_DET INNER JOIN FGMaster ON JW_ISSUE_DET.FID = FGMaster.FID) ON JW_ISSUE_Master.JID = JW_ISSUE_DET.JID) INNER JOIN JW_Ret_Master ON JW_ISSUE_Master.JWID<> JW_Ret_Master.JW_Issue_ID " _
            '    & " WHERE (((JW_ISSUE_Master.JWDATE) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#));"

            'Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
            'adp.Fill(ds, "DemoSales")


            'strsql = "SELECT JW_ISSUE_Master.JWID,format(JW_ISSUE_Master.JWDATE,'dd/MM/yyyy') as JWDATE, FGMaster.FGName, JW_ISSUE_DET.BATCH_NO, JW_ISSUE_DET.QTY " _
            '    & " FROM JW_ISSUE_Master INNER JOIN (JW_Ret_Master INNER JOIN ((JW_ISSUE_DET INNER JOIN FGMaster ON JW_ISSUE_DET.FID = FGMaster.FID) " _
            '    & " INNER JOIN JW_Ret_Det ON (JW_ISSUE_DET.BATCH_NO <> JW_Ret_Det.Batch_No) AND (JW_ISSUE_DET.FID <> JW_Ret_Det.FID)) ON JW_Ret_Master.ID = JW_Ret_Det.ID) ON (JW_ISSUE_Master.JWID = JW_Ret_Master.JW_Issue_ID) AND (JW_ISSUE_Master.JID = JW_ISSUE_DET.JID)" _
            '    & " WHERE (((JW_ISSUE_Master.JWDATE) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#));"

            'adp.SelectCommand.CommandText = strsql
            'adp.Fill(ds, "DemoSales")

            strsql = "SELECT JW_ISSUE_Master.JWID,format(JW_ISSUE_Master.JWDATE,'dd/MM/yyyy') as JWDATE, FGMaster.FGName, JW_ISSUE_DET.BATCH_NO, JW_ISSUE_DET.QTY, " _
                & " JW_Ret_Det.Ret_Qty, JW_ISSUE_DET!QTY-JW_Ret_Det!Ret_Qty AS Sold_Qty " _
                & " FROM JW_ISSUE_Master INNER JOIN (JW_Ret_Master INNER JOIN " _
                & " ((JW_ISSUE_DET INNER JOIN FGMaster ON JW_ISSUE_DET.FID = FGMaster.FID) " _
                & " INNER JOIN JW_Ret_Det ON (FGMaster.FID = JW_Ret_Det.FID) AND (JW_ISSUE_DET.FID = JW_Ret_Det.FID) AND (JW_ISSUE_DET.BATCH_NO = JW_Ret_Det.Batch_No)) ON JW_Ret_Master.ID = JW_Ret_Det.ID) ON (JW_ISSUE_Master.JWID = JW_Ret_Master.JW_Issue_ID) AND (JW_ISSUE_Master.JID = JW_ISSUE_DET.JID)" _
                & " WHERE (((JW_ISSUE_Master.JWDATE) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) AND " _
                & " (JW_ISSUE_DET!QTY-JW_Ret_Det!Ret_Qty) > 0"

            Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
            adp.Fill(ds, "DemoSales")

            adp.SelectCommand.CommandText = "Select CompanyName from companyMaster"
            adp.Fill(ds, "Company")

            myrpt.DataSource = ds

            myrpt.XrTableCell1.DataBindings.Add("Text", ds, "DemoSales.JWID")
            myrpt.XrTableCell2.DataBindings.Add("Text", ds, "DemoSales.JWDATE")
            myrpt.XrTableCell3.DataBindings.Add("Text", ds, "DemoSales.FGNAME")
            myrpt.XrTableCell4.DataBindings.Add("Text", ds, "DemoSales.BATCH_NO")
            myrpt.XrTableCell5.DataBindings.Add("Text", ds, "DemoSales.QTY")
            myrpt.XrTableCell6.DataBindings.Add("Text", ds, "DemoSales.Ret_Qty")
            myrpt.XrTableCell7.DataBindings.Add("Text", ds, "DemoSales.Sold_Qty")


            myrpt.XrLabel10.DataBindings.Add("Text", ds, "Company.CompanyName")
            myrpt.XrLabel1.Text = "Demo Sales Report between " & dtpFrom.Text & " and " & dtpTo.Text

            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            'myrpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()

        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Public Sub Min_Max()
        Try

            Dim myrpt As New rptMinMaxQty
            Dim strsql As String
            Dim ds As New DataSet

            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn

            strsql = "SELECT FGMaster.FGName, UnitMaster.UnitName, FGMaster.Min_Qty, Sum(FGStock.Balance_Qty) AS Balance_Qty, FGMaster.Min_Qty-Sum(FGStock.Balance_Qty) AS Order_Qty " _
                    & " FROM (FGMaster INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN FGStock ON FGMaster.FID = FGStock.FID " _
                    & " GROUP BY FGMaster.FGName, UnitMaster.UnitName, FGMaster.Min_Qty" _
                    & " HAVING (((Sum(FGStock.Balance_Qty))<[FGMaster]![Min_Qty])); "

            Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
            adp.Fill(ds, "Min_Max")

            adp.SelectCommand.CommandText = "Select CompanyName from companyMaster"
            adp.Fill(ds, "Company")

            myrpt.DataSource = ds

            myrpt.XrTableCell1.DataBindings.Add("Text", ds, "Min_Max.FGName")
            myrpt.XrTableCell2.DataBindings.Add("Text", ds, "Min_Max.UnitName")
            myrpt.XrTableCell3.DataBindings.Add("Text", ds, "Min_Max.Min_Qty")
            ' myrpt.XrTableCell4.DataBindings.Add("Text", ds, "Sterilize.Batch_NO")
            myrpt.XrTableCell5.DataBindings.Add("Text", ds, "Min_Max.Balance_Qty")
            myrpt.XrTableCell6.DataBindings.Add("Text", ds, "Min_Max.Order_Qty")

            myrpt.XrLabel1.DataBindings.Add("Text", ds, "Company.CompanyName")
            myrpt.XrLabel2.Text = myrpt.XrLabel2.Text & " of finish goods as on: " & Today.Date
            'myrpt.XrLabel4.Text = Format(Today.Date, "dd/MM/yyyy")
            'myrpt.XrLabel6.Text = Format(dtpFrom.EditValue, "dd/MM/yyyy")
            'myrpt.XrLabel8.Text = Format(dtpTo.EditValue, "dd/MM/yyyy")


            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            'myrpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Public Sub Min_Max_RM()
        Try

            Dim myrpt As New rptMinMaxQty
            Dim strsql As String
            Dim ds As New DataSet

            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn

            strsql = "SELECT RMItemMaster.RMItemName, UnitMaster.UnitName, RMItemMaster.Min_Qty, Sum(RMStock.Balance_Qty) AS Balance_Qty, RMItemMaster.Min_Qty-Sum(RMStock.Balance_Qty) AS Order_Qty " _
                    & " FROM (RMItemMaster INNER JOIN UnitMaster ON RMItemMaster.UnitID = UnitMaster.UnitID) INNER JOIN RMStock ON RMItemMaster.RID = RMStock.RID " _
                    & " GROUP BY RMItemMaster.RMItemName, UnitMaster.UnitName, RMItemMaster.Min_Qty" _
                    & " HAVING (((Sum(RMStock.Balance_Qty))<[RMItemMaster]![Min_Qty])); "

            Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
            adp.Fill(ds, "Min_Max")

            adp.SelectCommand.CommandText = "Select CompanyName from companyMaster"
            adp.Fill(ds, "Company")

            myrpt.DataSource = ds

            myrpt.XrTableCell1.DataBindings.Add("Text", ds, "Min_Max.RMItemName")
            myrpt.XrTableCell2.DataBindings.Add("Text", ds, "Min_Max.UnitName")
            myrpt.XrTableCell3.DataBindings.Add("Text", ds, "Min_Max.Min_Qty")
            ' myrpt.XrTableCell4.DataBindings.Add("Text", ds, "Sterilize.Batch_NO")
            myrpt.XrTableCell5.DataBindings.Add("Text", ds, "Min_Max.Balance_Qty")
            myrpt.XrTableCell6.DataBindings.Add("Text", ds, "Min_Max.Order_Qty")

            myrpt.XrLabel1.DataBindings.Add("Text", ds, "Company.CompanyName")
            myrpt.XrLabel2.Text = myrpt.XrLabel2.Text & " of raw material as on: " & Today.Date
            'myrpt.XrLabel4.Text = Format(Today.Date, "dd/MM/yyyy")
            'myrpt.XrLabel6.Text = Format(dtpFrom.EditValue, "dd/MM/yyyy")
            'myrpt.XrLabel8.Text = Format(dtpTo.EditValue, "dd/MM/yyyy")


            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            '            myrpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub ShowPendingStrz()
        Try
            Dim myrpt As New rptPendingSterilization
            Dim strsql As String
            Dim ds As New DataSet

            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn

            strsql = "SELECT FinishGoods_QCMaster.FGVI_NO, format(FinishGoods_QCMaster.VI_Date,'dd/MM/yyyy') as VDATE, FGMaster.FGName, FinishGoods_QCDetail.Batch_NO," _
                & " FinishGoods_QCDetail.MIS_NO, PKG_VI_Date " _
                & " FROM FGMaster INNER JOIN (FinishGoods_QCMaster INNER JOIN FinishGoods_QCDetail ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO) ON FGMaster.FID = FinishGoods_QCDetail.FID " _
                & " WHERE (((FinishGoods_QCMaster.VI_Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((FinishGoods_QCMaster.St_Check)=Yes) " _
                & " AND ((FinishGoods_QCMaster.St_Date) = #30/12/1899 00:00:00#)); "

            Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
            adp.Fill(ds, "Sterilize")

            adp.SelectCommand.CommandText = "Select CompanyName from companyMaster"
            adp.Fill(ds, "Company")

            myrpt.DataSource = ds

            myrpt.XrTableCell1.DataBindings.Add("Text", ds, "Sterilize.FGVI_NO")
            myrpt.XrTableCell2.DataBindings.Add("Text", ds, "Sterilize.VDATE")
            myrpt.XrTableCell3.DataBindings.Add("Text", ds, "Sterilize.FGName")
            myrpt.XrTableCell7.DataBindings.Add("Text", ds, "Sterilize.Batch_NO")
            myrpt.XrTableCell9.DataBindings.Add("Text", ds, "Sterilize.MIS_NO")
            myrpt.xrTabCellPackingVIDate.DataBindings.Add("Text", ds, "Sterilize.PKG_VI_Date")

            myrpt.XrLabel2.DataBindings.Add("Text", ds, "Company.CompanyName")
            myrpt.XrLabel4.Text = Format(Today.Date, "dd/MM/yyyy")
            myrpt.XrLabel6.Text = Format(dtpFrom.EditValue, "dd/MM/yyyy")
            myrpt.XrLabel8.Text = Format(dtpTo.EditValue, "dd/MM/yyyy")


            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            'myrpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()



        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Public Sub showPurchase_Reg()
        Try
            Dim myrpt As New rptPurchaseReg
            Dim strsql As String
            Dim ds As New DataSet

            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn

            strsql = "SELECT Purchase_Master.PO_No, Purchase_Master.PO_Date, SupplierMaster.SuppName, RMItemMaster.RMItemName, UnitMaster.UnitName, Purchase_Detail.Qty, Sum(Purchase_Detail.Amount) AS SumOfAmount" _
                & " FROM (RMItemMaster INNER JOIN ((Purchase_Master INNER JOIN Purchase_Detail ON Purchase_Master.PO_No = Purchase_Detail.PO_No) INNER JOIN SupplierMaster ON Purchase_Master.SuppID = SupplierMaster.SID) ON RMItemMaster.Rid = Purchase_Detail.RMItemID) INNER JOIN UnitMaster ON Purchase_Detail.UnitID = UnitMaster.UnitID " _
                & " GROUP BY Purchase_Master.PO_No, Purchase_Master.PO_Date, SupplierMaster.SuppName, RMItemMaster.RMItemName, UnitMaster.UnitName, Purchase_Detail.Qty " _
                & " HAVING (((Purchase_Master.PO_Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) order by Purchase_Master.PO_Date,Purchase_Master.PO_No;"

            Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
            adp.Fill(ds, "Purchase")

            adp.SelectCommand.CommandText = "SELECT QCMaster.RMVI_NO AS PO_NO, format(QCMaster.Date,'DD/MM/YYYY') as PDATE, QCDetail.Supp_Name as SuppName, RMItemMaster.RMItemName, UnitMaster.UnitName, QCDetail.Accepted_Qty as Qty" _
                 & " FROM (RMItemMaster INNER JOIN (QCMaster INNER JOIN QCDetail ON QCMaster.RMVI_NO = QCDetail.RMVI_NO) ON RMItemMaster.Rid = QCDetail.RID) INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID " _
                 & " GROUP BY QCMaster.RMVI_NO, QCMaster.Date, QCDetail.Supp_Name, RMItemMaster.RMItemName, UnitMaster.UnitName, QCDetail.Accepted_Qty " _
                 & " HAVING (((QCMaster.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) order by QCMaster.Date,QCMaster.RMVI_NO ;"

            adp.Fill(ds, "Purchase")


            adp.SelectCommand.CommandText = "Select CompanyName from companyMaster"
            adp.Fill(ds, "Company")

            myrpt.DataSource = ds

            myrpt.XrTableCell1.DataBindings.Add("Text", ds, "Purchase.PDATE")
            myrpt.XrTableCell2.DataBindings.Add("Text", ds, "Purchase.PO_No")
            myrpt.XrTableCell3.DataBindings.Add("Text", ds, "Purchase.SuppName")
            myrpt.XrTableCell4.DataBindings.Add("Text", ds, "Purchase.SAmount")

            myrpt.XrLabel1.DataBindings.Add("Text", ds, "Company.CompanyName")
            myrpt.XrLabel7.Text = Format(Today.Date, "dd/MM/yyyy")
            myrpt.XrLabel3.Text = Format(dtpFrom.EditValue, "dd/MM/yyyy")
            myrpt.XrLabel5.Text = Format(dtpTo.EditValue, "dd/MM/yyyy")

            myrpt.XrLabel17.DataBindings.Add("Text", ds, "Purchase.RMItemName")
            myrpt.XrLabel18.DataBindings.Add("Text", ds, "Purchase.UnitName")
            myrpt.XrLabel19.DataBindings.Add("Text", ds, "Purchase.Qty")
            'myrpt.XrLabel20.DataBindings.Add("Text", ds, "Purchase.RMItemName")

            myrpt.GroupHeader1.GroupFields.Item(0).FieldName = "PO_No"
            myrpt.XrTableCell2.DataBindings.Add("Text", ds, "Purchase.PO_No")

            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            'myrpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()

        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Public Sub ShowTI(ByVal objID As String)
        Try
            If objID.Trim = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Select Receipt No.", "Receipt No", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Dim myrpt As New rptTI
                Dim strsql As String
                Dim ds As New DataSet

                cmd = New OleDb.OleDbCommand
                cmd.Connection = conn

                strsql = "SELECT TI_Rec_Master.RecID, TI_Rec_Master.RecNo, format(TI_Rec_Master.RecDate,'dd/MM/yyyy') as RDate, SupplierMaster.SuppName, FGMaster.FGName, UnitMaster.UnitName, TI_Rec_Det.Batch_No, TI_Rec_Det.QTY " _
                    & " FROM (((TI_Rec_Master INNER JOIN TI_Rec_Det ON TI_Rec_Master.RecID = TI_Rec_Det.RecID) INNER JOIN SupplierMaster ON TI_Rec_Master.SID = SupplierMaster.SID) " _
                    & " INNER JOIN FGMaster ON TI_Rec_Det.FID = FGMaster.FID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID " _
                    & " WHERE (((TI_Rec_Master.RecNo)='" & objID.Trim & "))"


                Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
                adp.Fill(ds, "TI")

                adp.SelectCommand.CommandText = "Select CompanyName from companyMaster"
                adp.Fill(ds, "Company")

                myrpt.DataSource = ds
                myrpt.GroupHeader1.GroupFields.Item(0).FieldName = "RecNo"
                myrpt.XrTableCell1.DataBindings.Add("Text", ds, "TI.FGName")
                myrpt.XrTableCell2.DataBindings.Add("Text", ds, "TI.UnitName")
                myrpt.XrTableCell3.DataBindings.Add("Text", ds, "TI.Batch_No")
                myrpt.XrTableCell4.DataBindings.Add("Text", ds, "TI.QTY")
                myrpt.XrLabel2.DataBindings.Add("Text", ds, "TI.RecNo")
                myrpt.XrLabel4.DataBindings.Add("Text", ds, "TI.RDate")
                myrpt.XrLabel6.DataBindings.Add("Text", ds, "TI.SuppName")

                myrpt.XrLabel8.DataBindings.Add("Text", ds, "Company.CompanyName")
                myrpt.XrLabel11.Text = Format(Now.Date, "dd/MM/yyyy")

                'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
                ''myrpt.PrintingSystem = printingSystem
                'myrpt.ShowPreview()
                Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
                printingSystem.ShowRibbonPreview()
                adp.Dispose()

            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub showSales_Reg()
        Try
            Dim myrpt As New rptSalesReg
            Dim strsql As String
            Dim ds As New DataSet

            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn

            'strsql = "SELECT format(ChallanMaster.Challan_dt,'DD/MM/YYYY') AS CDate, ChallanMaster.Challan_No, CustomerMaster.CustName, Sum([ChallanDetail]![Qty]*[ChallanDetail]![Rate]) AS Amount " _
            '   & " FROM (ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID " _
            '   & " GROUP BY ChallanMaster.Challan_dt, ChallanMaster.Challan_No, CustomerMaster.CustName" _
            '   & " HAVING (((ChallanMaster.Challan_dt)  Between #" & dtpFrom.Text & "# and #" & dtpTo.Text & "#)) ORDER BY ChallanMaster.Challan_dt"


            strsql = "SELECT ChallanMaster.Challan_No, format(ChallanMaster.Challan_dt,'DD/MM/YYYY') AS CDate, FGMaster.FGName, ChallanDetail.BatchID,CustomerMaster.CustName, Sum([ChallanDetail]![Qty]*[ChallanDetail]![Rate]) AS Amount, ChallanDetail.Qty " _
                & " FROM ((ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID " _
                & " GROUP BY ChallanMaster.Challan_No, ChallanMaster.Challan_dt, FGMaster.FGName, CustomerMaster.CustName, ChallanDetail.Qty,ChallanDetail.BatchID " _
                & " HAVING (((ChallanMaster.Challan_dt)   Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                & " ORDER BY ChallanMaster.Challan_dt,ChallanMaster.Challan_No"


            Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
            adp.Fill(ds, "Sales")

            adp.SelectCommand.CommandText = "Select CompanyName from companyMaster"
            adp.Fill(ds, "Company")

            myrpt.DataSource = ds

            myrpt.XrTableCell1.DataBindings.Add("Text", ds, "Sales.CDate")
            myrpt.XrTableCell2.DataBindings.Add("Text", ds, "Sales.Challan_No")
            myrpt.XrTableCell3.DataBindings.Add("Text", ds, "Sales.CustName")
            myrpt.XrTableCell4.DataBindings.Add("Text", ds, "Sales.Amount")
            myrpt.XrLabel15.DataBindings.Add("Text", ds, "Sales.FGName")
            myrpt.XrLabel16.DataBindings.Add("Text", ds, "Sales.Qty")
            myrpt.XrLabel18.DataBindings.Add("Text", ds, "Sales.BatchID")

            myrpt.GroupHeader1.GroupFields.Item(0).FieldName = "Challan_No"

            myrpt.XrLabel1.DataBindings.Add("Text", ds, "Company.CompanyName")
            myrpt.XrLabel7.Text = Format(Today.Date, "dd/MM/yyyy")
            myrpt.XrLabel3.Text = Format(dtpFrom.EditValue, "dd/MM/yyyy")
            myrpt.XrLabel5.Text = Format(dtpTo.EditValue, "dd/MM/yyyy")


            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            'myrpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()

        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub ShowBatch_Stock_Reg()
        Try
            Dim myrpt As New rptBatchReg
            Dim strsql As String
            Dim ds As New DataSet

            '''''' Create a Subreport.
            'Dim subreport As New DevExpress.XtraReports.UI.Subreport

            'subreport.ReportSource = SubReportBatchReg()
            'myrpt.Subreport1 = subreport

            SubReportBatchReg()

            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn




            strsql = "SELECT format(FinishGoods_QCMaster.VI_Date,'dd/MM/yyyy') as VDate, FinishGoods_QCDetail.Batch_NO, FGMaster.FGName, FinishGoods_QCDetail.QC_No " _
                & " FROM FGMaster INNER JOIN (FinishGoods_QCMaster INNER JOIN FinishGoods_QCDetail ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO) ON FGMaster.FID = FinishGoods_QCDetail.FID " _
                & " WHERE (FinishGoods_QCMaster.VI_Date Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "# " _
                & " AND ((FinishGoods_QCMaster.St_Check=True AND FinishGoods_QCMaster.St_Date Is Not Null) OR FinishGoods_QCMaster.St_Check=False))" _
                & " ORDER BY FinishGoods_QCMaster.VI_Date; "

            Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
            adp.Fill(ds, "Batch")

            strsql = "SELECT Format(TI_Rec_Master.RecDate,'dd/MM/yyyy') AS VDate, TI_Rec_Det.Batch_No, FGMaster.FGName, TI_Rec_Det.QTY AS QC_NO " _
                & " FROM TI_Rec_Master INNER JOIN (FGMaster INNER JOIN TI_Rec_Det ON FGMaster.FID = TI_Rec_Det.FID) ON TI_Rec_Master.RecID = TI_Rec_Det.RecID " _
                & " WHERE (((TI_Rec_Master.RecDate) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "# ))" _
                & " ORDER BY TI_Rec_Master.RecDate;"

            adp.SelectCommand.CommandText = strsql
            adp.Fill(ds, "Batch")



            adp.SelectCommand.CommandText = "Select CompanyName from companyMaster"
            adp.Fill(ds, "Company")

            myrpt.DataSource = ds

            myrpt.XrTableCell1.DataBindings.Add("Text", ds, "Batch.VDate")
            myrpt.XrTableCell2.DataBindings.Add("Text", ds, "Batch.Batch_NO")
            myrpt.XrTableCell3.DataBindings.Add("Text", ds, "Batch.FGName")
            myrpt.XrTableCell4.DataBindings.Add("Text", ds, "Batch.QC_No")

            myrpt.XrLabel1.DataBindings.Add("Text", ds, "Company.CompanyName")
            myrpt.XrLabel7.Text = Format(Today.Date, "dd/MM/yyyy")
            myrpt.XrLabel3.Text = Format(dtpFrom.EditValue, "dd/MM/yyyy")
            myrpt.XrLabel5.Text = Format(dtpTo.EditValue, "dd/MM/yyyy")


            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            myrpt.Subreport1.BackColor = Color.DimGray
            'myrpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()

        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub SubReportBatchReg()
        Try
            Dim strsql As String
            Dim ds As New DataSet
            Dim myrpt As New rptSubBatchStock

            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn

            dsSub = New DataSet

            'Opening Stock of FG
            strsql = "SELECT format(FG_Opening_Stock.Register_Date,'dd/MM/yyyy'), FG_Opening_Stock.FGVI_NO as Batch_NO, FGMaster.FID, FGMaster.FGName,FG_Opening_Stock.Opening_Qty as QC_No " _
                & " FROM FGMaster INNER JOIN FG_Opening_Stock ON FGMaster.FID = FG_Opening_Stock.FID order by FG_Opening_Stock.Register_Date; "

            Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
            adp.Fill(ds, "Batch")


            'Current Year Batch Production
            strsql = "SELECT format(FinishGoods_QCMaster.VI_Date,'DD/MM/YYYY') as VDate, FinishGoods_QCDetail.Batch_NO,FinishGoods_QCDetail.FID, FGMaster.FGName, FinishGoods_QCDetail.QC_No " _
                & " FROM FGMaster INNER JOIN (FinishGoods_QCMaster INNER JOIN FinishGoods_QCDetail ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO) ON FGMaster.FID = FinishGoods_QCDetail.FID " _
                & " WHERE (((FinishGoods_QCMaster.VI_Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                & " ORDER BY FGMaster.FGName,FinishGoods_QCMaster.VI_Date; "
            adp.SelectCommand.CommandText = strsql
            adp.Fill(ds, "Batch")


            'Trading Item Inward
            strsql = "SELECT Format(TI_Rec_Master.RecDate,'dd/mm/yyyy') AS VDate, TI_Rec_Det.Batch_No,TI_Rec_Det.FID, FGMaster.FGName, TI_Rec_Det.QTY AS QC_NO " _
                & " FROM TI_Rec_Master INNER JOIN (FGMaster INNER JOIN TI_Rec_Det ON FGMaster.FID = TI_Rec_Det.FID) ON TI_Rec_Master.RecID = TI_Rec_Det.RecID " _
                & " WHERE (((TI_Rec_Master.RecDate) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "# ))" _
                & " ORDER BY FGMaster.FGName, TI_Rec_Master.RecDate;"

            adp.SelectCommand.CommandText = strsql
            adp.Fill(ds, "Batch")

            For i As Integer = 0 To ds.Tables("Batch").Rows.Count - 1

                strsql = "SELECT FGMaster.FGName,FORMAT(FG_Opening_Stock.Register_Date) AS CHdate, FG_Opening_Stock.FGVI_NO, FGMaster.FID, Sum(FG_Opening_Stock.Opening_Qty) AS Received_Qty, FG_Opening_Stock.FGVI_NO AS BatchID" _
                    & " FROM FGMaster INNER JOIN FG_Opening_Stock ON FGMaster.FID = FG_Opening_Stock.FID " _
                    & " GROUP BY FGMaster.FGName, FG_Opening_Stock.Register_Date, FG_Opening_Stock.FGVI_NO, FGMaster.FID " _
                    & " HAVING (((FGMaster.FID)='" & ds.Tables("Batch").Rows(i).Item("FID") & "') AND ((FG_Opening_Stock.FGVI_NO)='" & ds.Tables("Batch").Rows(i).Item("Batch_NO") & "'));"
                adp.SelectCommand.CommandText = strsql
                adp.Fill(dsSub, "Sales")

                strsql = "SELECT CustomerMaster.CustName, FGMaster.FGName, Format(ChallanMaster.Challan_dt,'dd/mm/yyyy') AS CHdate, FGStock.Received_Qty, ChallanDetail.Qty, FGStock.Balance_Qty, ChallanMaster.Challan_No AS [Challan No], ChallanDetail.BatchID " _
                    & " FROM (ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN ((ChallanDetail INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID) INNER JOIN FGStock ON (ChallanDetail.FID = FGStock.FID) AND (ChallanDetail.BatchID = FGStock.Batch_No)) ON ChallanMaster.Challan_No = ChallanDetail.Challan_No " _
                    & " GROUP BY CustomerMaster.CustName, FGMaster.FGName, FGStock.Received_Qty, ChallanDetail.Qty, FGStock.Balance_Qty, ChallanMaster.Challan_No, ChallanDetail.BatchID, ChallanMaster.Challan_dt, ChallanDetail.FID, FGStock.Batch_No ,FGStock.Type,FGStock.Ret_Qty " _
                    & " HAVING (((ChallanDetail.FID)='" & ds.Tables("Batch").Rows(i).Item("FID") & "') AND ((FGStock.Batch_No)='" & ds.Tables("Batch").Rows(i).Item("Batch_NO") & "')) and FGStock.Type ='Opening' and FGStock.Ret_Qty<=0 ;"

                adp.SelectCommand.CommandText = strsql
                adp.Fill(dsSub, "Sales")


                strsql = "SELECT CustomerMaster.CustName, FGMaster.FGName, Format(ChallanMaster.Challan_dt,'dd/mm/yyyy') AS CHdate, FGStock.Received_Qty, ChallanDetail.Qty, FGStock.Balance_Qty, ChallanMaster.Challan_No AS [Challan No], ChallanDetail.BatchID " _
                    & " FROM (ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN ((ChallanDetail INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID) INNER JOIN FGStock ON (ChallanDetail.FID = FGStock.FID) AND (ChallanDetail.BatchID = FGStock.Batch_No)) ON ChallanMaster.Challan_No = ChallanDetail.Challan_No " _
                    & " GROUP BY CustomerMaster.CustName, FGMaster.FGName, FGStock.Received_Qty, ChallanDetail.Qty, FGStock.Balance_Qty, ChallanMaster.Challan_No, ChallanDetail.BatchID, ChallanMaster.Challan_dt, ChallanDetail.FID, FGStock.Batch_No ,FGStock.Type " _
                    & " HAVING (((ChallanDetail.FID)='" & ds.Tables("Batch").Rows(i).Item("FID") & "') AND ((FGStock.Batch_No)='" & ds.Tables("Batch").Rows(i).Item("Batch_NO") & "')) and FGStock.Type ='Inward';"

                adp.SelectCommand.CommandText = strsql
                adp.Fill(dsSub, "Sales")

                strsql = "SELECT CustomerMaster.CustName, FGMaster.FGName, format(FG_Ret_Master.RetDate,'dd/MM/yyyy') as CHdate, Sum(FG_Ret_Det.Ret_Qty) AS Return_Qty, FG_Ret_Master.Challan_No as [Challan No], FG_Ret_Det.BatchID" _
                    & " FROM (((FG_Ret_Master INNER JOIN FG_Ret_Det ON FG_Ret_Master.RetNo = FG_Ret_Det.RetNo) INNER JOIN ChallanMaster ON FG_Ret_Master.Challan_No = ChallanMaster.Challan_No) INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN FGMaster ON FG_Ret_Det.FID = FGMaster.FID" _
                    & " GROUP BY FG_Ret_Master.RetDate,CustomerMaster.CustName, FGMaster.FGName, ChallanMaster.Challan_Dt, FG_Ret_Master.Challan_No, FG_Ret_Det.BatchID, FGMaster.FID " _
                    & " HAVING (((FG_Ret_Det.BatchID)='" & ds.Tables("Batch").Rows(i).Item("Batch_NO") & "')) and FGMaster.FID ='" & ds.Tables("Batch").Rows(i).Item("FID") & "'"
                adp.SelectCommand.CommandText = strsql
                adp.Fill(dsSub, "Sales")
            Next

            '******************************************************************
            '                           Return for PY
            '******************************************************************

            'Previous year return
            strsql = "SELECT CustomerMaster.CustName, FGMaster.FGName, format(FG_Ret_Master.Challan_Dt,'dd/MM/yyyy') as CHdate, Sum(FG_Ret_Det.Ret_Qty) AS Return_Qty, FG_Ret_Master.Challan_No as [Challan No], FG_Ret_Det.BatchID, FG_Ret_Master.Year " _
                & " FROM ((FG_Ret_Master INNER JOIN FG_Ret_Det ON FG_Ret_Master.RetNo = FG_Ret_Det.RetNo) INNER JOIN FGMaster ON FG_Ret_Det.FID = FGMaster.FID) INNER JOIN CustomerMaster ON FG_Ret_Master.CID = CustomerMaster.CID " _
                & " GROUP BY CustomerMaster.CustName, FGMaster.FGName, FG_Ret_Master.Challan_Dt, FG_Ret_Master.Challan_No, FG_Ret_Det.BatchID, FG_Ret_Master.Year " _
                & " HAVING (((FG_Ret_Master.Year)='P'));"

            adp.SelectCommand.CommandText = strsql
            adp.Fill(dsSub, "Sales")


            'Sales from previous year return
            strsql = "SELECT CustomerMaster.CustName, FGMaster.FGName, Format(ChallanMaster.Challan_dt,'dd/mm/yyyy') AS CHdate, ChallanDetail.Qty, FGStock.Balance_Qty, ChallanMaster.Challan_No AS [Challan No], ChallanDetail.BatchID " _
                & " FROM FG_Ret_Master INNER JOIN (((ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN ((ChallanDetail INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID) INNER JOIN FGStock ON ChallanDetail.BatchID = FGStock.Batch_No) ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN FG_Ret_Det ON (FGStock.FID = FG_Ret_Det.FID) AND (FGStock.Batch_No = FG_Ret_Det.BatchID) AND (FGMaster.FID = FG_Ret_Det.FID)) ON FG_Ret_Master.RetNo = FG_Ret_Det.RetNo " _
                & " GROUP BY CustomerMaster.CustName, FGMaster.FGName, FGStock.Received_Qty, ChallanDetail.Qty, FGStock.Balance_Qty, ChallanMaster.Challan_No, ChallanDetail.BatchID, ChallanMaster.Challan_dt, ChallanDetail.FID, FGStock.Batch_No, FG_Ret_Master.Year " _
                & " HAVING (((FG_Ret_Master.Year)='P'));"

            adp.SelectCommand.CommandText = strsql
            adp.Fill(dsSub, "Sales")
            adp.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub




    Private Sub PWBW_Det()
        Try
            Dim myrpt As New rptBatchReg
            Dim strsql As String
            Dim ds As New DataSet

            If strID = "" Then
                SubReportBatchReg()
            Else
                PWBW()
            End If

            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn

            If strID = "" Then
                strsql = "SELECT format(FinishGoods_QCMaster.VI_Date,'DD/MM/YYYY') as VDate, FinishGoods_QCDetail.Batch_NO, FGMaster.FGName, FinishGoods_QCDetail.QC_No " _
                    & " FROM FGMaster INNER JOIN (FinishGoods_QCMaster INNER JOIN FinishGoods_QCDetail ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO) ON FGMaster.FID = FinishGoods_QCDetail.FID " _
                    & " WHERE (FinishGoods_QCMaster.VI_Date Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "# " _
                    & " AND ((FinishGoods_QCMaster.St_Check=True AND FinishGoods_QCMaster.St_Date Is Not Null) OR FinishGoods_QCMaster.St_Check=False))" _
                    & " ORDER BY FinishGoods_QCMaster.VI_Date; "
            Else
                strsql = "SELECT format(FinishGoods_QCMaster.VI_Date,'DD/MM/YYYY') as VDate, FinishGoods_QCDetail.Batch_NO, FGMaster.FGName, FinishGoods_QCDetail.QC_No " _
                    & " FROM FGMaster INNER JOIN (FinishGoods_QCMaster INNER JOIN FinishGoods_QCDetail ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO) ON FGMaster.FID = FinishGoods_QCDetail.FID " _
                    & " WHERE (FinishGoods_QCMaster.VI_Date Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "# " _
                    & " AND ((FinishGoods_QCMaster.St_Check=True AND FinishGoods_QCMaster.St_Date Is Not Null) OR FinishGoods_QCMaster.St_Check=False))" _
                    & " AND FGMaster.FGName ='" & strID.Trim & "'" _
                    & " ORDER BY FinishGoods_QCMaster.VI_Date; "
            End If


            Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
            adp.Fill(ds, "Batch")
            If strID = "" Then
                strsql = "SELECT Format(TI_Rec_Master.RecDate,'dd/mm/yyyy') AS VDate, TI_Rec_Det.Batch_No, FGMaster.FGName, TI_Rec_Det.QTY AS QC_NO " _
                    & " FROM TI_Rec_Master INNER JOIN (FGMaster INNER JOIN TI_Rec_Det ON FGMaster.FID = TI_Rec_Det.FID) ON TI_Rec_Master.RecID = TI_Rec_Det.RecID " _
                    & " WHERE (((TI_Rec_Master.RecDate) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "# ))" _
                    & " ORDER BY TI_Rec_Master.RecDate;"
            Else
                strsql = "SELECT Format(TI_Rec_Master.RecDate,'dd/mm/yyyy') AS VDate, TI_Rec_Det.Batch_No, FGMaster.FGName, TI_Rec_Det.QTY AS QC_NO " _
                    & " FROM TI_Rec_Master INNER JOIN (FGMaster INNER JOIN TI_Rec_Det ON FGMaster.FID = TI_Rec_Det.FID) ON TI_Rec_Master.RecID = TI_Rec_Det.RecID " _
                    & " WHERE (((TI_Rec_Master.RecDate) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "# ))" _
                    & " AND FGMaster.FGName ='" & strID.Trim & "'" _
                    & " ORDER BY TI_Rec_Master.RecDate;"
            End If

            adp.SelectCommand.CommandText = strsql
            adp.Fill(ds, "Batch")

            If strID = "" Then
                strsql = "SELECT format(FG_Opening_Stock.Register_Date,'dd/MM/yyyy') as VDate, FG_Opening_Stock.FGVI_NO as Batch_No, FGMaster.FGName, FG_Opening_Stock.Opening_Qty as QC_NO" _
                    & " FROM FGMaster INNER JOIN FG_Opening_Stock ON FGMaster.FID = FG_Opening_Stock.FID order by FG_Opening_Stock.Register_Date;"
            Else
                strsql = "SELECT format(FG_Opening_Stock.Register_Date,'dd/MM/yyyy') as VDate, FG_Opening_Stock.FGVI_NO as Batch_No, FGMaster.FGName, FG_Opening_Stock.Opening_Qty as QC_NO" _
                    & " FROM FGMaster INNER JOIN FG_Opening_Stock ON FGMaster.FID = FG_Opening_Stock.FID where FGMaster.FGName ='" & strID.Trim & "' order by FG_Opening_Stock.Register_Date;"
            End If
            adp.SelectCommand.CommandText = strsql
            adp.Fill(ds, "Batch")

            adp.SelectCommand.CommandText = "Select CompanyName from companyMaster"
            adp.Fill(ds, "Company")

            myrpt.DataSource = ds

            myrpt.XrTableCell1.DataBindings.Add("Text", ds, "Batch.VDate")
            myrpt.XrTableCell2.DataBindings.Add("Text", ds, "Batch.Batch_NO")
            myrpt.XrTableCell3.DataBindings.Add("Text", ds, "Batch.FGName")
            myrpt.XrTableCell4.DataBindings.Add("Text", ds, "Batch.QC_No")

            myrpt.XrLabel1.DataBindings.Add("Text", ds, "Company.CompanyName")
            myrpt.XrLabel7.Text = Format(Today.Date, "dd/MM/yyyy")
            myrpt.XrLabel3.Text = Format(dtpFrom.EditValue, "dd/MM/yyyy")
            myrpt.XrLabel5.Text = Format(dtpTo.EditValue, "dd/MM/yyyy")


            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            myrpt.Subreport1.BackColor = Color.DimGray
            'myrpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()

        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub PWBW()
        Try
            Dim strsql As String
            Dim ds As New DataSet
            Dim myrpt As New rptSubBatchStock
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn

            dsSub = New DataSet

            'Opening Stock of FG
            strsql = "SELECT format(FG_Opening_Stock.Register_Date,'dd/MM/yyyy'), FG_Opening_Stock.FGVI_NO as Batch_NO, FGMaster.FID, FGMaster.FGName,FG_Opening_Stock.Opening_Qty as QC_No " _
                & " FROM FGMaster INNER JOIN FG_Opening_Stock ON FGMaster.FID = FG_Opening_Stock.FID WHERE FGMaster.FGName = '" & strID.Trim & "' order by FG_Opening_Stock.Register_Date"

            Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
            adp.Fill(ds, "Batch")


            If strID.Trim = "" Then
                'Current Year Batch Production
                strsql = "SELECT format(FinishGoods_QCMaster.VI_Date,'DD/MM/YYYY') as VDate, FinishGoods_QCDetail.Batch_NO,FinishGoods_QCDetail.FID, FGMaster.FGName, FinishGoods_QCDetail.QC_No " _
                    & " FROM FGMaster INNER JOIN (FinishGoods_QCMaster INNER JOIN FinishGoods_QCDetail ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO) ON FGMaster.FID = FinishGoods_QCDetail.FID " _
                    & " WHERE (((FinishGoods_QCMaster.VI_Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                    & " ORDER BY FGMaster.FGName,FinishGoods_QCMaster.VI_Date; "

                'adp.SelectCommand = New OleDb.OleDbCommand
                'adp.SelectCommand.Connection = conn
                adp.SelectCommand.CommandText = strsql
                adp.Fill(ds, "Batch")

                'Trading Item Inward
                strsql = "SELECT Format(TI_Rec_Master.RecDate,'dd/mm/yyyy') AS VDate, TI_Rec_Det.Batch_No,TI_Rec_Det.FID, FGMaster.FGName, TI_Rec_Det.QTY AS QC_NO " _
                    & " FROM TI_Rec_Master INNER JOIN (FGMaster INNER JOIN TI_Rec_Det ON FGMaster.FID = TI_Rec_Det.FID) ON TI_Rec_Master.RecID = TI_Rec_Det.RecID " _
                    & " WHERE (((TI_Rec_Master.RecDate) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "# ))" _
                    & " ORDER BY FGMaster.FGName, TI_Rec_Master.RecDate;"

                adp.SelectCommand.CommandText = strsql
                adp.SelectCommand.Connection = conn
                adp.Fill(ds, "Batch")
            Else
                'Current Year Batch Production
                strsql = "SELECT format(FinishGoods_QCMaster.VI_Date,'DD/MM/YYYY') as VDate, FinishGoods_QCDetail.Batch_NO,FinishGoods_QCDetail.FID, FGMaster.FGName, FinishGoods_QCDetail.QC_No " _
                    & " FROM FGMaster INNER JOIN (FinishGoods_QCMaster INNER JOIN FinishGoods_QCDetail ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO) ON FGMaster.FID = FinishGoods_QCDetail.FID " _
                    & " WHERE (((FinishGoods_QCMaster.VI_Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                    & " AND  FGMaster.FGName = '" & strID.Trim & "'" _
                    & " ORDER BY FGMaster.FGName,FinishGoods_QCMaster.VI_Date; "

                adp.SelectCommand = New OleDb.OleDbCommand
                adp.SelectCommand.Connection = conn
                adp.SelectCommand.CommandText = strsql
                adp.Fill(ds, "Batch")

                'Trading Item Inward
                strsql = "SELECT Format(TI_Rec_Master.RecDate,'dd/mm/yyyy') AS VDate, TI_Rec_Det.Batch_No,TI_Rec_Det.FID, FGMaster.FGName, TI_Rec_Det.QTY AS QC_NO " _
                    & " FROM TI_Rec_Master INNER JOIN (FGMaster INNER JOIN TI_Rec_Det ON FGMaster.FID = TI_Rec_Det.FID) ON TI_Rec_Master.RecID = TI_Rec_Det.RecID " _
                    & " WHERE (((TI_Rec_Master.RecDate) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "# ))" _
                    & " AND FGMaster.FGName = '" & strID.Trim & "'" _
                    & " ORDER BY FGMaster.FGName, TI_Rec_Master.RecDate;"

                adp.SelectCommand = New OleDb.OleDbCommand
                adp.SelectCommand.CommandText = strsql
                adp.SelectCommand.Connection = conn
                adp.Fill(ds, "Batch")
            End If


            For i As Integer = 0 To ds.Tables("Batch").Rows.Count - 1

                strsql = "SELECT FGMaster.FGName,FORMAT(FG_Opening_Stock.Register_Date) AS CHdate, FG_Opening_Stock.FGVI_NO, FGMaster.FID, Sum(FG_Opening_Stock.Opening_Qty) AS Received_Qty, FG_Opening_Stock.FGVI_NO AS BatchID" _
                    & " FROM FGMaster INNER JOIN FG_Opening_Stock ON FGMaster.FID = FG_Opening_Stock.FID " _
                    & " GROUP BY FGMaster.FGName, FG_Opening_Stock.Register_Date, FG_Opening_Stock.FGVI_NO, FGMaster.FID " _
                    & " HAVING (((FGMaster.FID)='" & ds.Tables("Batch").Rows(i).Item("FID") & "') AND ((FG_Opening_Stock.FGVI_NO)='" & ds.Tables("Batch").Rows(i).Item("Batch_NO") & "')) ORDER BY FGMaster.FGName,FG_Opening_Stock.Register_Date ;"
                adp.SelectCommand.CommandText = strsql
                adp.Fill(dsSub, "Sales")

                strsql = "SELECT CustomerMaster.CustName, FGMaster.FGName, Format(ChallanMaster.Challan_dt,'dd/mm/yyyy') AS CHdate, FGStock.Received_Qty, ChallanDetail.Qty, FGStock.Balance_Qty, ChallanMaster.Challan_No AS [Challan No], ChallanDetail.BatchID " _
                    & " FROM (ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN ((ChallanDetail INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID) INNER JOIN FGStock ON (ChallanDetail.FID = FGStock.FID) AND (ChallanDetail.BatchID = FGStock.Batch_No)) ON ChallanMaster.Challan_No = ChallanDetail.Challan_No " _
                    & " GROUP BY CustomerMaster.CustName, FGMaster.FGName, FGStock.Received_Qty, ChallanDetail.Qty, FGStock.Balance_Qty, ChallanMaster.Challan_No, ChallanDetail.BatchID, ChallanMaster.Challan_dt, ChallanDetail.FID, FGStock.Batch_No ,FGStock.Type,FGStock.Ret_Qty " _
                    & " HAVING (((ChallanDetail.FID)='" & ds.Tables("Batch").Rows(i).Item("FID") & "') AND ((FGStock.Batch_No)='" & ds.Tables("Batch").Rows(i).Item("Batch_NO") & "')) and FGStock.Type ='Opening' ORDER BY FGMaster.FGName,ChallanMaster.Challan_dt ;"   'and FGStock.Ret_Qty<=0 ;"

                adp.SelectCommand.CommandText = strsql
                adp.Fill(dsSub, "Sales")


                strsql = "SELECT CustomerMaster.CustName, FGMaster.FGName, Format(ChallanMaster.Challan_dt,'dd/mm/yyyy') AS CHdate, FGStock.Received_Qty, ChallanDetail.Qty, FGStock.Balance_Qty, ChallanMaster.Challan_No AS [Challan No], ChallanDetail.BatchID " _
                    & " FROM (ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN ((ChallanDetail INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID) INNER JOIN FGStock ON (ChallanDetail.FID = FGStock.FID) AND (ChallanDetail.BatchID = FGStock.Batch_No)) ON ChallanMaster.Challan_No = ChallanDetail.Challan_No " _
                    & " GROUP BY CustomerMaster.CustName, FGMaster.FGName, FGStock.Received_Qty, ChallanDetail.Qty, FGStock.Balance_Qty, ChallanMaster.Challan_No, ChallanDetail.BatchID, ChallanMaster.Challan_dt, ChallanDetail.FID, FGStock.Batch_No ,FGStock.Type " _
                    & " HAVING (((ChallanDetail.FID)='" & ds.Tables("Batch").Rows(i).Item("FID") & "') AND ((FGStock.Batch_No)='" & ds.Tables("Batch").Rows(i).Item("Batch_NO") & "')) and FGStock.Type ='Inward' ORDER BY FGMaster.FGName,ChallanMaster.Challan_dt ;"

                adp.SelectCommand.CommandText = strsql
                adp.Fill(dsSub, "Sales")





                strsql = "SELECT CustomerMaster.CustName, FGMaster.FGName, format(FG_Ret_Master.RetDate,'dd/MM/yyyy') as CHdate, Sum(FG_Ret_Det.Ret_Qty) AS Return_Qty, FG_Ret_Master.Challan_No as [Challan No], FG_Ret_Det.BatchID" _
                    & " FROM (((FG_Ret_Master INNER JOIN FG_Ret_Det ON FG_Ret_Master.RetNo = FG_Ret_Det.RetNo) INNER JOIN ChallanMaster ON FG_Ret_Master.Challan_No = ChallanMaster.Challan_No) INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN FGMaster ON FG_Ret_Det.FID = FGMaster.FID" _
                    & " GROUP BY CustomerMaster.CustName, FGMaster.FGName,FG_Ret_Master.RetDate, FG_Ret_Master.Challan_No, FG_Ret_Det.BatchID, FGMaster.FID " _
                    & " HAVING (((FG_Ret_Det.BatchID)='" & ds.Tables("Batch").Rows(i).Item("Batch_NO") & "')) and FGMaster.FID ='" & ds.Tables("Batch").Rows(i).Item("FID") & "' ORDER BY FGMaster.FGName,FG_Ret_Master.RetDate ;"
                adp.SelectCommand.CommandText = strsql
                adp.Fill(dsSub, "Sales")



            Next

            '******************************************************************
            '                           Return for PY
            '******************************************************************
            'If strCY.Trim = "2008-2009" Then
            'Previous year return
            strsql = "SELECT CustomerMaster.CustName, FGMaster.FGName, format(FG_Ret_Master.RetDate,'dd/MM/yyyy') as CHdate, Sum(FG_Ret_Det.Ret_Qty) AS Return_Qty, FG_Ret_Master.Challan_No as [Challan No], FG_Ret_Det.BatchID, FG_Ret_Master.Year " _
                & " FROM ((FG_Ret_Master INNER JOIN FG_Ret_Det ON FG_Ret_Master.RetNo = FG_Ret_Det.RetNo) INNER JOIN FGMaster ON FG_Ret_Det.FID = FGMaster.FID) INNER JOIN CustomerMaster ON FG_Ret_Master.CID = CustomerMaster.CID " _
                & " GROUP BY CustomerMaster.CustName, FGMaster.FGName, FG_Ret_Master.RetDate, FG_Ret_Master.Challan_No, FG_Ret_Det.BatchID, FG_Ret_Master.Year " _
                & " HAVING (((FG_Ret_Master.Year)='P')) AND  FGMASTER.FGName = '" & strID.Trim & "'order by FGMaster.FGName,FG_Ret_Master.RetDate;"

            adp.SelectCommand = New OleDb.OleDbCommand
            adp.SelectCommand.CommandText = strsql
            adp.SelectCommand.Connection = conn
            adp.Fill(dsSub, "Sales")


            'Sales from previous year return
            strsql = "SELECT CustomerMaster.CustName, FGMaster.FGName, Format(ChallanMaster.Challan_dt,'dd/mm/yyyy') AS CHdate, ChallanDetail.Qty, FGStock.Balance_Qty, ChallanMaster.Challan_No AS [Challan No], ChallanDetail.BatchID " _
                & " FROM FG_Ret_Master INNER JOIN (((ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN ((ChallanDetail INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID) INNER JOIN FGStock ON ChallanDetail.BatchID = FGStock.Batch_No) ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN FG_Ret_Det ON (FGStock.FID = FG_Ret_Det.FID) AND (FGStock.Batch_No = FG_Ret_Det.BatchID) AND (FGMaster.FID = FG_Ret_Det.FID)) ON FG_Ret_Master.RetNo = FG_Ret_Det.RetNo " _
                & " GROUP BY CustomerMaster.CustName, FGMaster.FGName, FGStock.Received_Qty, ChallanDetail.Qty, FGStock.Balance_Qty, ChallanMaster.Challan_No, ChallanDetail.BatchID, ChallanMaster.Challan_dt, ChallanDetail.FID, FGStock.Batch_No, FG_Ret_Master.Year " _
                & " HAVING (((FG_Ret_Master.Year)='P')) AND  FGMASTER.FGName = '" & strID.Trim & "' Order by FGMaster.FGName,ChallanMaster.Challan_dt;"

            adp.SelectCommand = New OleDb.OleDbCommand
            adp.SelectCommand.CommandText = strsql
            adp.SelectCommand.Connection = conn
            adp.Fill(dsSub, "Sales")
            'End If
            adp.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Public Sub PenDingMIS()
        Dim myrpt As New rptPendingVI
        Dim strsql As String
        Dim ds As New DataSet

        cmd = New OleDb.OleDbCommand
        cmd.CommandText = "Select count(*) from FinishGoods_QCMaster"
        cmd.Connection = conn
        If cmd.ExecuteScalar > 0 Then
            '''strsql = "SELECT REQMASTER.REQID as MIS_NO, format(REQMASTER.REQDATE,'DD/MM/YYYY') AS MDATE, FGMaster.FGName, REQMASTER.QTY as FG_QTY " _
            '''    & " FROM FGMaster INNER JOIN (REQMASTER INNER JOIN Material_Issue_Master " _
            '''    & " ON REQMASTER.RQID <> Material_Issue_Master.RQID) ON FGMaster.FID = REQMASTER.FID " _
            '''    & " GROUP BY REQMASTER.REQID, Format(REQMASTER.REQDATE,'dd/mm/yyyy'), FGMaster.FGName, REQMASTER.QTY, REQMASTER.REQDATE " _
            '''    & " HAVING (((REQMASTER.REQDATE) Between #" & dtpFrom.Text & "# and #" & dtpTo.Text & "#));"
            '& " WHERE (((REQMASTER.REQDATE) Between #" & dtpFrom.Text & "# and #" & dtpTo.Text & "#))"
            'strsql = "SELECT format(Material_Issue_Master.MIS_DATE,'DD/MM/YYYY') AS MDATE, Material_Issue_Master.MIS_NO, FGMaster.FGName, Material_Issue_Master.FG_QTY, Material_Issue_Master.VI_Req " _
            '    & " FROM Material_Issue_Master INNER JOIN FGMaster ON Material_Issue_Master.FGID = FGMaster.FID " _
            '    & " WHERE (((Material_Issue_Master.MIS_NO) Not In (SELECT MIS_NO FROM FinishGoods_QCDetail))) order by Material_Issue_Master.MIS_NO "


            'strsql = "SELECT Format([Material_Issue_Master].[MIS_DATE],'dd/MM/yyyy') AS MDATE, Material_Issue_Master.MIS_NO, FGMaster.FGName, Material_Issue_Master.FG_QTY, Material_Issue_Master.VI_Req, REQMASTER.TYPE " _
            '    & " FROM (Material_Issue_Master INNER JOIN FGMaster ON Material_Issue_Master.FGID = FGMaster.FID) INNER JOIN REQMASTER ON (REQMASTER.RQID = Material_Issue_Master.RQID) AND (FGMaster.FID = REQMASTER.FID)" _
            '    & " WHERE (((Material_Issue_Master.MIS_NO) Not In (SELECT MIS_NO FROM FinishGoods_QCDetail)) AND ((REQMASTER.TYPE)='B') AND ((Material_Issue_Master.MIS_DATE) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))" _
            '    & " ORDER BY Material_Issue_Master.MIS_NO;"

            strsql = "SELECT Format(Material_Issue_Master.MIS_DATE,'dd/MM/yyyy') as MDATE, Material_Issue_Master.MIS_NO, FGMaster.FGName, (Material_Issue_Master.FG_QTY - [sumFG_QTY]![SumOfInspected_No]) as FG_QTY , Material_Issue_Master.VI_Req, REQMASTER.TYPE" _
                & " FROM (FGMaster INNER JOIN REQMASTER ON FGMaster.FID = REQMASTER.FID) INNER JOIN (Material_Issue_Master INNER JOIN sumFG_QTY ON Material_Issue_Master.MIS_NO = sumFG_QTY.MIS_NO) ON REQMASTER.RQID = Material_Issue_Master.RQID " _
                & " WHERE (((Material_Issue_Master.MIS_DATE) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ([sumFG_QTY]![SumOfInspected_No] < (Material_Issue_Master.FG_QTY)) AND ((REQMASTER.TYPE)='B')) " _
                & " ORDER BY Material_Issue_Master.MIS_NO;"



        Else
            strsql = "SELECT format(Material_Issue_Master.MIS_DATE,'DD/MM/YYYY') AS MDATE, Material_Issue_Master.MIS_NO, FGMaster.FGName, Material_Issue_Master.FG_QTY, Material_Issue_Master.VI_Req " _
                & " FROM Material_Issue_Master INNER JOIN FGMaster ON Material_Issue_Master.FGID = FGMaster.FID " _
                & " WHERE (((Material_Issue_Master.MIS_DATE) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((Material_Issue_Master.VI_Req)=True)) Material_Issue_Master.MIS_NO"
        End If

        Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
        adp.Fill(ds, "MIS")

        If cmd.ExecuteScalar > 0 Then
            strsql = "SELECT Format([Material_Issue_Master].[MIS_DATE],'dd/MM/yyyy') AS MDATE, Material_Issue_Master.MIS_NO, FGMaster.FGName, Material_Issue_Master.FG_QTY, Material_Issue_Master.VI_Req, REQMASTER.TYPE " _
                & " FROM (Material_Issue_Master INNER JOIN FGMaster ON Material_Issue_Master.FGID = FGMaster.FID) INNER JOIN REQMASTER ON (REQMASTER.RQID = Material_Issue_Master.RQID) AND (FGMaster.FID = REQMASTER.FID)" _
                & " WHERE (((Material_Issue_Master.MIS_NO) Not In (SELECT MIS_NO FROM FinishGoods_QCDetail)) AND ((REQMASTER.TYPE)='B') AND ((Material_Issue_Master.MIS_DATE) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))" _
                & " ORDER BY Material_Issue_Master.MIS_NO;"

            adp.SelectCommand.CommandText = strsql
            adp.Fill(ds, "MIS")
        End If

        adp.SelectCommand.CommandText = "Select CompanyName from companyMaster"
        adp.Fill(ds, "Company")

        myrpt.DataSource = ds

        myrpt.XrTableCell1.DataBindings.Add("Text", ds, "MIS.MDATE")
        myrpt.XrTableCell2.DataBindings.Add("Text", ds, "MIS.MIS_NO")
        myrpt.XrTableCell3.DataBindings.Add("Text", ds, "MIS.FGName")
        myrpt.XrTableCell4.DataBindings.Add("Text", ds, "MIS.FG_QTY")

        myrpt.XrLabel1.DataBindings.Add("Text", ds, "Company.CompanyName")
        myrpt.XrLabel4.Text = Format(Today.Date, "dd/MM/yyyy")
        myrpt.XrLabel6.Text = Format(dtpFrom.EditValue, "dd/MM/yyyy")
        myrpt.XrLabel8.Text = Format(dtpTo.EditValue, "dd/MM/yyyy")


        'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
        ''myrpt.PrintingSystem = printingSystem
        'myrpt.ShowPreview()
        Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
        printingSystem.ShowRibbonPreview()
        adp.Dispose()
    End Sub

    Public Sub PendingPackingVI()
        Dim myrpt As New rptPendingVI
        Dim strsql As String
        Dim ds As New DataSet
        myrpt.lblReportTitle.Text = "Pending packing visual inspection report"
        cmd = New OleDb.OleDbCommand
        cmd.CommandText = "Select count(*) from PackingVI_Master"
        cmd.Connection = conn
        If cmd.ExecuteScalar > 0 Then

            strsql = "SELECT Format(Material_Issue_Master.MIS_DATE,'dd/MM/yyyy') as MDATE, Material_Issue_Master.MIS_NO, FGMaster.FGName, (Material_Issue_Master.FG_QTY - [sumFG_QTY]![SumOfInspected_No]) as FG_QTY , Material_Issue_Master.VI_Req, REQMASTER.TYPE" _
                & " FROM (FGMaster INNER JOIN REQMASTER ON FGMaster.FID = REQMASTER.FID) INNER JOIN (Material_Issue_Master INNER JOIN sumFG_QTY ON Material_Issue_Master.MIS_NO = sumFG_QTY.MIS_NO) ON REQMASTER.RQID = Material_Issue_Master.RQID " _
                & " WHERE (((Material_Issue_Master.MIS_DATE) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ([sumFG_QTY]![SumOfInspected_No] < (Material_Issue_Master.FG_QTY)) AND ((REQMASTER.TYPE)='B')) " _
                & " ORDER BY Material_Issue_Master.MIS_NO;"



        Else
            strsql = "SELECT format(Material_Issue_Master.MIS_DATE,'DD/MM/YYYY') AS MDATE, Material_Issue_Master.MIS_NO, FGMaster.FGName, Material_Issue_Master.FG_QTY, Material_Issue_Master.VI_Req " _
                & " FROM Material_Issue_Master INNER JOIN FGMaster ON Material_Issue_Master.FGID = FGMaster.FID " _
                & " WHERE (((Material_Issue_Master.MIS_DATE) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((Material_Issue_Master.VI_Req)=True)) Material_Issue_Master.MIS_NO"
        End If

        Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
        adp.Fill(ds, "MIS")

        If cmd.ExecuteScalar > 0 Then
            strsql = "SELECT Format([Material_Issue_Master].[MIS_DATE],'dd/MM/yyyy') AS MDATE, Material_Issue_Master.MIS_NO, FGMaster.FGName, Material_Issue_Master.FG_QTY, Material_Issue_Master.VI_Req, REQMASTER.TYPE " _
                & " FROM (Material_Issue_Master INNER JOIN FGMaster ON Material_Issue_Master.FGID = FGMaster.FID) INNER JOIN REQMASTER ON (REQMASTER.RQID = Material_Issue_Master.RQID) AND (FGMaster.FID = REQMASTER.FID)" _
                & " WHERE (((Material_Issue_Master.MIS_NO) Not In (SELECT MIS_NO FROM PackingVI_Detail)) AND ((REQMASTER.TYPE)='B') AND ((Material_Issue_Master.MIS_DATE) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))" _
                & " ORDER BY Material_Issue_Master.MIS_NO;"

            adp.SelectCommand.CommandText = strsql
            adp.Fill(ds, "MIS")
        End If

        adp.SelectCommand.CommandText = "Select CompanyName from companyMaster"
        adp.Fill(ds, "Company")

        myrpt.DataSource = ds

        myrpt.XrTableCell1.DataBindings.Add("Text", ds, "MIS.MDATE")
        myrpt.XrTableCell2.DataBindings.Add("Text", ds, "MIS.MIS_NO")
        myrpt.XrTableCell3.DataBindings.Add("Text", ds, "MIS.FGName")
        myrpt.XrTableCell4.DataBindings.Add("Text", ds, "MIS.FG_QTY")

        myrpt.XrLabel1.DataBindings.Add("Text", ds, "Company.CompanyName")
        myrpt.XrLabel4.Text = Format(Today.Date, "dd/MM/yyyy")
        myrpt.XrLabel6.Text = Format(dtpFrom.EditValue, "dd/MM/yyyy")
        myrpt.XrLabel8.Text = Format(dtpTo.EditValue, "dd/MM/yyyy")


        'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
        ''myrpt.PrintingSystem = printingSystem
        'myrpt.ShowPreview()
        Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
        printingSystem.ShowRibbonPreview()
        adp.Dispose()
    End Sub

    Public Sub ShowBOM(ByVal strFGID As String)
        Try
            Dim strSqlMaster As String
            If strFGID <> "" Then
                strSqlMaster = "SELECT Batchdetail.BatchID, RMItemMaster.RMItemName, UnitMaster.UnitName, Batchdetail.Qty as BDQty, FGMaster.FGName, BatchMaster.Qty as BMQty, BatchMaster.FID " _
                     & " FROM (FGMaster INNER JOIN (BatchMaster INNER JOIN (Batchdetail INNER JOIN RMItemMaster ON Batchdetail.RID = RMItemMaster.Rid) ON BatchMaster.BatchID = Batchdetail.BatchID) " _
                     & " ON FGMaster.FID = BatchMaster.FID) INNER JOIN UnitMaster ON Batchdetail.UnitID = UnitMaster.UnitID " _
                     & " WHERE (((BatchMaster.FID)='" & strFGID.Trim & "'))"
            End If

            Dim myRpt As New rptBOM
            Dim ds As New DataSet

            Dim adp As New OleDb.OleDbDataAdapter(strSqlMaster, conn)
            adp.Fill(ds, "BOM")

            adp.SelectCommand.CommandText = "Select * from companyMaster"
            adp.Fill(ds, "Company")


            myRpt.DataSource = ds
            myRpt.XrLabel2.DataBindings.Add("Text", ds, "BOM.BatchID")
            myRpt.XrLabel4.DataBindings.Add("Text", ds, "BOM.FGName")
            myRpt.XrLabel6.DataBindings.Add("Text", ds, "BOM.BMQty")

            myRpt.XrTableCell1.DataBindings.Add("Text", ds, "BOM.RMItemName")
            myRpt.XrTableCell2.DataBindings.Add("Text", ds, "BOM.UnitName")
            myRpt.XrTableCell3.DataBindings.Add("Text", ds, "BOM.BDQty")

            myRpt.XrLabel7.DataBindings.Add("Text", ds, "Company.CompanyName")

            myRpt.XrLabel11.Text = Today.Date

            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            'myRpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub showFGCompReg(ByVal strFID As String)
        Try
            Dim myrpt As New rptCompReg
            Dim strsql As String
            Dim ds As New DataSet
            Dim adpt As New OleDb.OleDbDataAdapter

            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            adpt.SelectCommand = New OleDb.OleDbCommand
            adpt.SelectCommand.Connection = conn
            If strID = "" Then
                adpt.SelectCommand.CommandText = "Select FGMaster.FID,FGMaster.FGName from FGMaster"
            Else
                adpt.SelectCommand.CommandText = "Select FGMaster.FID,FGMaster.FGName from FGMaster where FID='" & strFID.Trim
            End If
            adpt.Fill(ds, "FGStock")
            For i As Integer = 0 To ds.Tables("FGStock").Rows.Count - 1
                'adpt.SelectCommand.CommandText = "SELECT FGStock.FID, FGMaster.FGName, FGStock.Batch_No, FGStock.Balance_Qty, FGStock.Date" _
                '    & " FROM FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID " _
                '    & " WHERE (((FGStock.Balanc_Qty)>0) AND ((FGStock.Date) < #" & dtpFrom.Text.Trim & "#));"

                'adpt.SelectCommand.CommandText = "SELECT FGStock.FID, FGMaster.FGName, FGStock.Batch_No, FGStock.Balance_Qty, FGStock.Date " _
                '     & " FROM FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID " _
                '     & " WHERE ( ((FGStock.Date)<=# " & Format(dtpFrom.EditValue, "dd/MM/yyyy").Trim & "#)) and FGStock.FID ='" & ds.Tables("FGStock").Rows(i).Item("FID") & "'"
                '((FGStock.Balance_Qty)>0) AND


                Dim opStock As Double
                Dim RecStock As Double
                Dim IssStock As Double
                Dim RetStock As Double
                strFID = ds.Tables("FGStock").Rows(i).Item("FID")
                '****************************************************************************
                '           CALCULATION OF OPENING STOCK
                '****************************************************************************

                cmd.Connection = conn

                'Opening Stock 
                cmd.CommandText = "SELECT FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName, Sum(FG_Opening_Stock.Opening_Qty) AS SumOfOpening_Qty " _
                    & " FROM ((FGMaster INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN FG_Opening_Stock ON (UnitMaster.UnitID = FG_Opening_Stock.UnitID) AND (FGMaster.FID = FG_Opening_Stock.FID) " _
                    & " WHERE(((FG_Opening_Stock.Register_Date) < #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "#))" _
                    & " GROUP BY FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName " _
                    & " HAVING (((FGMaster.FID)='" & strFID & "'));"

                dr = cmd.ExecuteReader
                Do While dr.Read
                    opStock = dr.Item("SumOfOpening_Qty")
                Loop
                dr.Close()

                'Goods Receive
                cmd.CommandText = "SELECT FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName, Sum(FinishGoods_QCDetail.QC_No) AS SumOfQC_No" _
                    & " FROM FinishGoods_QCMaster INNER JOIN (((FGMaster INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN FinishGoods_QCDetail ON FGMaster.FID = FinishGoods_QCDetail.FID) ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO " _
                    & " WHERE (((FinishGoods_QCMaster.VI_Date) < #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "#))" _
                    & " GROUP BY FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName " _
                    & " HAVING (((FGMaster.FID)='" & strFID & "'));"
                dr = cmd.ExecuteReader
                Do While dr.Read
                    RecStock = dr.Item("SumOfQC_No")
                Loop
                dr.Close()

                'Goods Received through Inward Trading
                cmd.CommandText = "SELECT FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName, Sum(TI_Rec_Det.QTY) AS SumOfQTY " _
                    & " FROM ((FGMaster INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN (TI_Rec_Master INNER JOIN TI_Rec_Det ON TI_Rec_Master.RecID = TI_Rec_Det.RecID) ON FGMaster.FID = TI_Rec_Det.FID " _
                    & " WHERE(((TI_Rec_Master.RecDate)  < #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "#))" _
                    & " GROUP BY FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName " _
                    & " HAVING (((FGMaster.FID)='" & strFID & "'));"

                dr = cmd.ExecuteReader
                Do While dr.Read
                    RecStock = RecStock + dr.Item("SumOfQTY")
                Loop
                dr.Close()


                'ISSUE QTY (CHALLAN)
                cmd.CommandText = "SELECT FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName, Sum(ChallanDetail.Qty) AS SumOfQty " _
                    & " FROM ((FGMaster INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN (ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) ON FGMaster.FID = ChallanDetail.FID " _
                    & " WHERE(((ChallanMaster.Challan_dt) < #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "#)) " _
                    & " GROUP BY FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName " _
                    & " HAVING (((FGMaster.FID)='" & strFID & "'));"
                dr = cmd.ExecuteReader
                Do While dr.Read
                    IssStock = dr.Item("SumOfQty")
                Loop
                dr.Close()

                'Return Qty
                cmd.CommandText = "SELECT FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName, Sum(FG_Ret_Det.Ret_Qty) AS SumOfRet_Qty " _
                    & " FROM ((FGMaster INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN (FG_Ret_Master INNER JOIN FG_Ret_Det ON FG_Ret_Master.RetNo = FG_Ret_Det.RetNo) ON FGMaster.FID = FG_Ret_Det.FID " _
                    & " WHERE(((FG_Ret_Master.RetDate) < #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "#)) " _
                    & " GROUP BY FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName " _
                    & " HAVING (((FGMaster.FID)='" & strFID & "'));"
                dr = cmd.ExecuteReader
                Do While dr.Read
                    RetStock = dr.Item("SumOfRet_Qty")
                Loop
                dr.Close()

                opStock = opStock + RecStock - IssStock + RetStock

                cmd.CommandText = "Insert Into Temp_Reg (ID,Product,Rec_Dt,Inward_BatchNo,Qty_Rec) values ('" _
                    & ds.Tables("FGStock").Rows(i).Item("FID") & "','" & Replace(ds.Tables("FGStock").Rows(i).Item("FGName"), "'", "''") & "','" & dtpFrom.Text.Trim & "','" & "Opening Stock" & "'," & opStock & ")"
                cmd.ExecuteNonQuery()
                '****************************************************************************************************************
                '                   Code for opening stock calculating end here.
                '****************************************************************************************************************

                'adpt.SelectCommand.CommandText = "SELECT FGStock.FID, FGMaster.FGName, FGStock.Balance_Qty,FGStock.Received_Qty, FGStock.Batch_No, FGStock.Date, FGStock.Type " _
                '     & " FROM FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID " _
                '     & " WHERE (((FGStock.FID)='" & ds.Tables("FGStock").Rows(i).Item("FID") & "') AND ((FGStock.Date)<#" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "#));"



                'adpt.Fill(ds, "FGOpening")
                'For k As Integer = 0 To ds.Tables("FGOpening").Rows.Count - 1
                '    'Opening Stock
                '    'If ds.Tables("FGOpening").Rows(k).Item("Balance_Qty") > 0 Then
                '    '    cmd.CommandText = "Insert Into Temp_Reg (ID,Product,Rec_Dt,Inward_BatchNo,Qty_Rec) values ('" _
                '    '        & ds.Tables("FGStock").Rows(i).Item("FID") & "','" & Replace(ds.Tables("FGStock").Rows(i).Item("FGName"), "'", "''") & "','" & dtpFrom.Text.Trim & "','" & ds.Tables("FGOpening").Rows(k).Item("Batch_No") & "'," & ds.Tables("FGOpening").Rows(k).Item("Balance_Qty") & ")"
                '    'Else
                '    cmd.CommandText = "Insert Into Temp_Reg (ID,Product,Rec_Dt,Inward_BatchNo,Qty_Rec) values ('" _
                '         & ds.Tables("FGStock").Rows(i).Item("FID") & "','" & Replace(ds.Tables("FGStock").Rows(i).Item("FGName"), "'", "''") & "','" & dtpFrom.Text.Trim & "','" & ds.Tables("FGOpening").Rows(k).Item("Batch_No") & "'," & ds.Tables("FGOpening").Rows(k).Item("Received_Qty") & ")"
                '    'End If
                '    cmd.ExecuteNonQuery()
                'Next
                'ds.Tables("FGOpening").Rows.Clear()

                strsql = "SELECT FGStock.Batch_No, FGStock.Issue_Qty, format(FGStock.Date,'DD/MM/YYYY') AS FDATE, FGStock.Received_Qty " _
                    & " FROM FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID " _
                    & " WHERE (((FGStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((FGStock.FID)='" & ds.Tables("FGStock").Rows(i).Item("FID") & "')) " _
                    & " and FGStock.Type = 'Opening'"

                adpt.SelectCommand.CommandText = strsql
                adpt.Fill(ds, "FGOpen")
                For j As Integer = 0 To ds.Tables("FGOpen").Rows.Count - 1
                    cmd.CommandText = "Insert Into Temp_Reg (ID,Product,Rec_Dt,Inward_BatchNo,Qty_Rec) values ('" _
                        & ds.Tables("FGStock").Rows(i).Item("FID") & "','" & Replace(ds.Tables("FGStock").Rows(i).Item("FGName"), "'", "''") & "','" & ds.Tables("FGOpen").Rows(j).Item("FDate") & "','" & ds.Tables("FGOpen").Rows(j).Item("Batch_No") & "'," & ds.Tables("FGOpen").Rows(j).Item("Received_Qty") & ")"
                    cmd.ExecuteNonQuery()
                Next
                ds.Tables("FGOpen").Rows.Clear()

                'Inward Qty
                strsql = "SELECT format(FinishGoods_QCMaster.VI_Date,'DD/MM/YYYY') as VIDate, FinishGoods_QCMaster.FGVI_NO,FinishGoods_QCDetail.Batch_No, FinishGoods_QCDetail.QC_No, FGMaster.FGName, FGMaster.fid" _
                    & " FROM FinishGoods_QCMaster INNER JOIN (FGMaster INNER JOIN FinishGoods_QCDetail ON FGMaster.fid = FinishGoods_QCDetail.fID) ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO " _
                    & " WHERE (FinishGoods_QCMaster.VI_DATE Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "# AND FGMaster.fid='" & ds.Tables("FGStock").Rows(i).Item("FID") & "'" _
                    & " AND ((FinishGoods_QCMaster.St_Check=True AND FinishGoods_QCMaster.St_Date Is Not Null) OR FinishGoods_QCMaster.St_Check=False))"

                adpt.SelectCommand.CommandText = strsql
                adpt.Fill(ds, "FGInward")
                For j As Integer = 0 To ds.Tables("FGInward").Rows.Count - 1
                    cmd.CommandText = "Insert Into Temp_Reg (ID,Product,Rec_Dt,VINo,Inward_BatchNo,Qty_Rec) values ('" _
                        & ds.Tables("FGStock").Rows(i).Item("FID") & "','" & Replace(ds.Tables("FGStock").Rows(i).Item("FGName"), "'", "''") & "','" & ds.Tables("FGInward").Rows(j).Item("VIDate") & "','" & ds.Tables("FGInward").Rows(j).Item("FGVI_NO") & "','" & ds.Tables("FGInward").Rows(j).Item("Batch_No") & "'," & ds.Tables("FGInward").Rows(j).Item("QC_No") & ")"
                    cmd.ExecuteNonQuery()
                Next
                ds.Tables("FGInward").Rows.Clear()

                'Trading Item Inward
                strsql = "SELECT format(TI_Rec_Master.RecDate,'dd/MM/yyyy') AS RDATE, TI_Rec_Det.Batch_No, TI_Rec_Det.QTY, TI_Rec_Det.FID" _
                    & " FROM TI_Rec_Master INNER JOIN TI_Rec_Det ON TI_Rec_Master.RecID = TI_Rec_Det.RecID " _
                    & " WHERE (((TI_Rec_Master.RecDate) Between#" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((TI_Rec_Det.FID)='" & ds.Tables("FGStock").Rows(i).Item("FID") & "'))"
                adpt.SelectCommand.CommandText = strsql
                adpt.Fill(ds, "TradingInward")
                For j As Integer = 0 To ds.Tables("TradingInward").Rows.Count - 1
                    cmd.CommandText = "Insert Into Temp_Reg (ID,Product,Rec_Dt,Inward_BatchNo,Qty_Rec) values ('" _
                        & ds.Tables("FGStock").Rows(i).Item("FID") & "','" & Replace(ds.Tables("FGStock").Rows(i).Item("FGName"), "'", "''") & "','" & ds.Tables("TradingInward").Rows(j).Item("RDate") & "','" & ds.Tables("TradingInward").Rows(j).Item("Batch_No") & "'," & ds.Tables("TradingInward").Rows(j).Item("Qty") & ")"
                    cmd.ExecuteNonQuery()
                Next
                ds.Tables("TradingInward").Rows.Clear()

                'Good Return
                strsql = "SELECT format(FG_Ret_Master.RetDate,'DD/MM/YYYY') AS RDate, FG_Ret_Det.BatchID as Batch_No, FG_Ret_Det.Ret_Qty, FG_Ret_Det.FID" _
                    & " FROM FG_Ret_Master INNER JOIN FG_Ret_Det ON FG_Ret_Master.RetNo = FG_Ret_Det.RetNo " _
                    & " WHERE (((FG_Ret_Det.FID)='" & ds.Tables("FGStock").Rows(i).Item("FID") & "') AND ((FG_Ret_Master.RetDate) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(DateAdd(DateInterval.Day, 1, dtpTo.EditValue), "MM/dd/yyyy") & "#)) "
                '& " and FG_Ret_Master.Year ='C'"

                adpt.SelectCommand.CommandText = strsql
                adpt.Fill(ds, "FGReturn")
                For j As Integer = 0 To ds.Tables("FGReturn").Rows.Count - 1
                    cmd.CommandText = "Insert Into Temp_Reg (ID,Product,Rec_Dt,Inward_BatchNo,Qty_Rec) values ('" _
                        & ds.Tables("FGStock").Rows(i).Item("FID") & "','" & Replace(ds.Tables("FGStock").Rows(i).Item("FGName"), "'", "''") & "','" & ds.Tables("FGReturn").Rows(j).Item("RDate") & "','" & ds.Tables("FGReturn").Rows(j).Item("Batch_No") & "'," & ds.Tables("FGReturn").Rows(j).Item("Ret_Qty") & ")"
                    cmd.ExecuteNonQuery()
                Next
                ds.Tables("FGReturn").Rows.Clear()

                'Issue
                strsql = "SELECT ChallanMaster.Challan_No, ChallanMaster.Challan_dt, ChallanDetail.BatchID, ChallanDetail.Qty, ChallanDetail.FID" _
                    & " FROM ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No " _
                    & " WHERE (((ChallanMaster.Challan_dt) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((ChallanDetail.FID)='" & ds.Tables("FGStock").Rows(i).Item("FID") & "'));"
                adpt.SelectCommand.CommandText = strsql
                adpt.Fill(ds, "Challan")
                For j As Integer = 0 To ds.Tables("Challan").Rows.Count - 1
                    cmd.CommandText = "Insert Into Temp_Reg (ID,Product,MISNo,Rec_Dt,Issue_Date,Outward_BatchNo,Issue_Qty) values ('" _
                        & ds.Tables("FGStock").Rows(i).Item("FID") & "','" & Replace(ds.Tables("FGStock").Rows(i).Item("FGName"), "'", "''") & "','" & ds.Tables("Challan").Rows(j).Item("Challan_No") & "','" & ds.Tables("Challan").Rows(j).Item("Challan_dt") & "','" & ds.Tables("Challan").Rows(j).Item("Challan_dt") & "','" & ds.Tables("Challan").Rows(j).Item("BatchID") & "'," & ds.Tables("Challan").Rows(j).Item("Qty") & ")"
                    cmd.ExecuteNonQuery()
                Next
                ds.Tables("Challan").Rows.Clear()
            Next

            ds.Tables.Clear()

            adpt.SelectCommand.CommandText = "Select *,Format(Rec_Dt,'DD/MM/YYYY') AS Rdate,format(Issue_Date,'DD/MM/YYYY') AS IDate from Temp_Reg ORDER BY Rec_Dt, Inward_Batchno DESC , Outward_Batchno"
            adpt.Fill(ds, "FGComp")


            adpt.SelectCommand.CommandText = "Select CompanyName from companyMaster"
            adpt.Fill(ds, "Company")

            myrpt.DataSource = ds


            myrpt.GroupHeader1.GroupFields.Item(0).FieldName = "Product"
            myrpt.XrLabel1.DataBindings.Add("Text", ds, "FGComp.Product")

            myrpt.XrTableCell1.DataBindings.Add("Text", ds, "FGComp.Rdate")
            myrpt.XrTableCell2.DataBindings.Add("Text", ds, "FGComp.VINO")
            myrpt.XrTableCell3.DataBindings.Add("Text", ds, "FGComp.Qty_Rec")
            myrpt.XrTableCell4.DataBindings.Add("Text", ds, "FGComp.Inward_Batchno")

            myrpt.XrTableCell5.DataBindings.Add("Text", ds, "FGComp.Outward_Batchno")
            myrpt.XrTableCell17.DataBindings.Add("Text", ds, "FGComp.IDate")
            myrpt.XrTableCell16.DataBindings.Add("Text", ds, "FGComp.MISNO")
            myrpt.XrTableCell18.DataBindings.Add("Text", ds, "FGComp.Issue_Qty")
            'myrptXrTableCell20.DataBindings.Add("Text", ds, "MIS.RMVI_NO")


            myrpt.XrLabel13.DataBindings.Add("Text", ds, "Company.CompanyName")
            myrpt.XrLabel31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "FGComp.Qty_Rec", "")})
            myrpt.XrLabel32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "FGComp.Issue_Qty", "")})

            cmd.CommandText = "Delete from Temp_Reg"
            cmd.ExecuteNonQuery()
            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            'myrpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
            printingSystem.ShowRibbonPreview()
            adpt.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    'Private Sub showCWPWS()
    '    Try
    '        Dim strSql As String
    '        If strID = "" Then
    '            Select Case strReport
    '                Case "CWPWS", "PWCWS"
    '                    strSql = "SELECT ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName, ChallanDetail.Challan_No, format(ChallanMaster.Challan_dt,'DD/MM/YYYY') as Challan_Dt, ChallanDetail.Qty, ChallanDetail.BatchID " _
    '                        & " FROM ((ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID " _
    '                        & " WHERE (((ChallanMaster.Challan_dt) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))"
    '                    'Case "CWPWS_Cons", "PWCWS_Cons"
    '                    '    strSql = "SELECT ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName, ChallanDetail.Challan_No, Format(ChallanMaster.Challan_dt,'dd/mm/yyyy') AS Challan_Dt, Sum(ChallanDetail.Qty) AS Qty, ChallanDetail.BatchID" _
    '                    '        & " FROM (ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN (ChallanDetail INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID) ON ChallanMaster.Challan_No = ChallanDetail.Challan_No " _
    '                    '        & " GROUP BY ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName, ChallanDetail.Challan_No, Format(ChallanMaster.Challan_dt,'dd/mm/yyyy'), ChallanDetail.BatchID, ChallanMaster.Challan_dt" _
    '                    '        & " HAVING (((ChallanMaster.Challan_dt) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
    '                    '        & " ORDER BY CustomerMaster.CustName, FGMaster.FGName; "

    '                Case "CWPWS_Cons", "PWCWS_Cons"
    '                    strSql = "SELECT ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName, Sum(ChallanDetail.Qty) AS Qty " _
    '                          & " FROM (ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN (ChallanDetail INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID) ON ChallanMaster.Challan_No = ChallanDetail.Challan_No " _
    '                          & " WHERE (((ChallanMaster.Challan_dt) Between#" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
    '                          & " GROUP BY ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName " _
    '                          & " ORDER BY CustomerMaster.CustName, FGMaster.FGName; "

    '            End Select

    '        Else
    '            Select Case strReport
    '                Case "CWPWS"
    '                    strSql = "SELECT ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName, ChallanDetail.Challan_No, format(ChallanMaster.Challan_dt,'DD/MM/YYYY') as Challan_Dt, ChallanDetail.Qty, ChallanDetail.BatchID " _
    '                        & " FROM ((ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID " _
    '                        & " WHERE (((ChallanMaster.CID)='" & strID & "') AND ((ChallanMaster.Challan_dt) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))"
    '                Case "CWPWS_Cons"
    '                    strSql = "SELECT ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName, ChallanDetail.Challan_No, Format(ChallanMaster.Challan_dt,'dd/mm/yyyy') AS Challan_Dt, Sum(ChallanDetail.Qty) AS Qty, ChallanDetail.BatchID" _
    '                        & " FROM (ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN (ChallanDetail INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID) ON ChallanMaster.Challan_No = ChallanDetail.Challan_No " _
    '                        & " GROUP BY ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName, ChallanDetail.Challan_No, Format(ChallanMaster.Challan_dt,'dd/mm/yyyy'), ChallanDetail.BatchID, ChallanMaster.Challan_dt" _
    '                        & " HAVING (((ChallanMaster.CID)='" & strID & "') AND ((ChallanMaster.Challan_dt) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))" _
    '                        & " ORDER BY CustomerMaster.CustName, FGMaster.FGName; "
    '                Case "PWCWS"
    '                    strSql = "SELECT ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName, ChallanDetail.Challan_No, format(ChallanMaster.Challan_dt,'DD/MM/YYYY') as Challan_Dt, ChallanDetail.Qty, ChallanDetail.BatchID " _
    '                       & " FROM ((ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID " _
    '                       & " WHERE (((ChallanDetail.FID)='" & strID & "') AND ((ChallanMaster.Challan_dt) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))"
    '                Case "PWCWS_Cons"
    '                    strSql = "SELECT ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName, ChallanDetail.Challan_No, Format(ChallanMaster.Challan_dt,'dd/mm/yyyy') AS Challan_Dt, Sum(ChallanDetail.Qty) AS Qty, ChallanDetail.BatchID" _
    '                        & " FROM (ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN (ChallanDetail INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID) ON ChallanMaster.Challan_No = ChallanDetail.Challan_No " _
    '                        & " GROUP BY ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName, ChallanDetail.Challan_No, Format(ChallanMaster.Challan_dt,'dd/mm/yyyy'), ChallanDetail.BatchID, ChallanMaster.Challan_dt" _
    '                        & " HAVING (((ChallanMaster.FID)='" & strID & "') AND ((ChallanMaster.Challan_dt) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))" _
    '                        & " ORDER BY CustomerMaster.CustName, FGMaster.FGName; "

    '            End Select
    '        End If

    '        Dim myRpt As New rptCWPWSales
    '        Dim ds As New DataSet
    '        Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
    '        adp.Fill(ds, "CP")

    '        adp.SelectCommand.CommandText = "Select * from companyMaster"
    '        adp.Fill(ds, "Company")

    '        myRpt.DataSource = ds

    '        Select Case strReport
    '            Case "CWPWS", "CWPWS_Cons"
    '                myRpt.XrTableCell1.DataBindings.Add("Text", ds, "CP.FGName")
    '                myRpt.XrLabel3.Text = "Product"

    '                myRpt.GroupHeader2.GroupFields.Item(0).FieldName = "CustName"
    '                myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "Challan_No"
    '                myRpt.XrLabel1.Text = "Customer: "
    '                myRpt.XrLabel2.DataBindings.Add("Text", ds, "CP.CustName")
    '                myRpt.XrLabel9.Text = "Customer wise Product wise Sales"
    '            Case "PWCWS", "PWCWS_Cons"
    '                myRpt.XrTableCell2.DataBindings.Add("Text", ds, "CP.FGName")

    '                myRpt.XrLabel3.Text = "Customer Name"

    '                myRpt.GroupHeader2.GroupFields.Item(0).FieldName = "FGName"
    '                myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "Challan_No"

    '                myRpt.XrLabel1.Text = "Product: "
    '                myRpt.XrLabel2.DataBindings.Add("Text", ds, "CP.FGName")
    '                myRpt.XrTableCell1.DataBindings.Add("Text", ds, "CP.CustName")
    '                myRpt.XrLabel9.Text = "Product wise Customer wise Sales"
    '        End Select
    '        myRpt.XrLabel10.Text = "Between " & dtpFrom.Text & " To " & dtpTo.Text
    '        myRpt.XrLabel12.Text = Format(Now, "dd-MM-yyyy")
    '        If strReport <> "PWCWS_Cons" And strReport <> "CWPWS_Cons" Then
    '            myRpt.XrTableCell2.DataBindings.Add("Text", ds, "CP.Challan_No")
    '            myRpt.XrTableCell3.DataBindings.Add("Text", ds, "CP.Challan_dt")
    '            myRpt.XrTableCell4.DataBindings.Add("Text", ds, "CP.BatchID")
    '        End If
    '        myRpt.XrTableCell5.DataBindings.Add("Text", ds, "CP.Qty")

    '        'myRpt.XrLabel18.DataBindings.Add("Text", ds, "CP.FGName")
    '        'myRpt.XrLabel20.DataBindings.Add("Text", ds, "CP.Qty")

    '        myRpt.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "CP.Qty", "")})
    '        myRpt.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "CP.Qty", "")})

    '        myRpt.XrLabel8.DataBindings.Add("Text", ds, "Company.CompanyName")
    '        Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
    '        'myrpt.PrintingSystem = printingSystem
    '        myRpt.ShowPreview()
    '        adp.Dispose()

    '    Catch ex As Exception
    '        If show_error Then
    '            MsgBox(ex.ToString)
    '        End If
    '    End Try
    'End Sub

    Private Sub showCWPWS()
        Try
            Dim strSql As String
            If strID = "" Then
                Select Case strReport
                    Case "CWPWS", "PWCWS"
                        strSql = "SELECT ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName, ChallanDetail.Challan_No, format(ChallanMaster.Challan_dt,'DD/MM/YYYY') as Challan_Dt, ChallanDetail.Qty, ChallanDetail.BatchID " _
                            & " FROM ((ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID " _
                            & " WHERE (((ChallanMaster.Challan_dt) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))"
                        'Case "CWPWS_Cons", "PWCWS_Cons"
                        '    strSql = "SELECT ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName, ChallanDetail.Challan_No, Format(ChallanMaster.Challan_dt,'dd/mm/yyyy') AS Challan_Dt, Sum(ChallanDetail.Qty) AS Qty, ChallanDetail.BatchID" _
                        '        & " FROM (ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN (ChallanDetail INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID) ON ChallanMaster.Challan_No = ChallanDetail.Challan_No " _
                        '        & " GROUP BY ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName, ChallanDetail.Challan_No, Format(ChallanMaster.Challan_dt,'dd/mm/yyyy'), ChallanDetail.BatchID, ChallanMaster.Challan_dt" _
                        '        & " HAVING (((ChallanMaster.Challan_dt) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                        '        & " ORDER BY CustomerMaster.CustName, FGMaster.FGName; "

                    Case "CWPWS_Cons", "PWCWS_Cons"
                        strSql = "SELECT ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName, Sum(ChallanDetail.Qty) AS Qty " _
                              & " FROM (ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN (ChallanDetail INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID) ON ChallanMaster.Challan_No = ChallanDetail.Challan_No " _
                              & " WHERE (((ChallanMaster.Challan_dt) Between#" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                              & " GROUP BY ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName " _
                              & " ORDER BY CustomerMaster.CustName, FGMaster.FGName; "

                End Select

            Else
                Select Case strReport
                    Case "CWPWS"
                        strSql = "SELECT ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName, ChallanDetail.Challan_No, format(ChallanMaster.Challan_dt,'DD/MM/YYYY') as Challan_Dt, ChallanDetail.Qty, ChallanDetail.BatchID " _
                            & " FROM ((ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID " _
                            & " WHERE (((ChallanMaster.CID)='" & strID & "') AND ((ChallanMaster.Challan_dt) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))"
                    Case "CWPWS_Cons"
                        'strSql = "SELECT ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName, ChallanDetail.Challan_No, Format(ChallanMaster.Challan_dt,'dd/mm/yyyy') AS Challan_Dt, Sum(ChallanDetail.Qty) AS Qty, ChallanDetail.BatchID" _
                        '    & " FROM (ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN (ChallanDetail INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID) ON ChallanMaster.Challan_No = ChallanDetail.Challan_No " _
                        '    & " GROUP BY ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName, ChallanDetail.Challan_No, Format(ChallanMaster.Challan_dt,'dd/mm/yyyy'), ChallanDetail.BatchID, ChallanMaster.Challan_dt" _
                        '    & " HAVING (((ChallanMaster.CID)='" & strID & "') AND ((ChallanMaster.Challan_dt) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))" _
                        '    & " ORDER BY CustomerMaster.CustName, FGMaster.FGName; "

                        strSql = "SELECT ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName, Sum(ChallanDetail.Qty) AS Qty " _
                            & " FROM (ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN (ChallanDetail INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID) ON ChallanMaster.Challan_No = ChallanDetail.Challan_No " _
                            & " WHERE (((ChallanMaster.Challan_dt) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                            & " GROUP BY ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName " _
                            & " HAVING (((ChallanMaster.CID)='" & strID & "')) " _
                            & " ORDER BY CustomerMaster.CustName, FGMaster.FGName; "


                    Case "PWCWS"
                        strSql = "SELECT ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName, ChallanDetail.Challan_No, format(ChallanMaster.Challan_dt,'DD/MM/YYYY') as Challan_Dt, ChallanDetail.Qty, ChallanDetail.BatchID " _
                           & " FROM ((ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID " _
                           & " WHERE (((ChallanDetail.FID)='" & strID & "') AND ((ChallanMaster.Challan_dt) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))"
                    Case "PWCWS_Cons"
                        strSql = "SELECT ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName, ChallanDetail.Challan_No, Format(ChallanMaster.Challan_dt,'dd/mm/yyyy') AS Challan_Dt, Sum(ChallanDetail.Qty) AS Qty, ChallanDetail.BatchID" _
                            & " FROM (ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN (ChallanDetail INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID) ON ChallanMaster.Challan_No = ChallanDetail.Challan_No " _
                            & " GROUP BY ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.FID, FGMaster.FGName, ChallanDetail.Challan_No, Format(ChallanMaster.Challan_dt,'dd/mm/yyyy'), ChallanDetail.BatchID, ChallanMaster.Challan_dt" _
                            & " HAVING (((ChallanDetail.FID)='" & strID & "') AND ((ChallanMaster.Challan_dt) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))" _
                            & " ORDER BY CustomerMaster.CustName, FGMaster.FGName; "

                End Select
            End If

            Dim myRpt As New rptCWPWSales
            Dim ds As New DataSet
            Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
            adp.Fill(ds, "CP")
            ds.Tables("CP").Columns.Add("Ret_Qty")

            adp.SelectCommand.CommandText = "Select * from companyMaster"
            adp.Fill(ds, "Company")

            For Each dr As DataRow In ds.Tables("CP").Rows
                strSql = "SELECT  Sum(FG_Ret_Det.Ret_Qty) AS SumOfRet_Qty" _
                    & " FROM FG_Ret_Master INNER JOIN FG_Ret_Det ON FG_Ret_Master.RetNo = FG_Ret_Det.RetNo " _
                    & " GROUP BY FG_Ret_Master.Challan_No, FG_Ret_Master.RetDate, FG_Ret_Master.CID, FG_Ret_Det.FID, FG_Ret_Det.BatchID" _
                    & " HAVING (((FG_Ret_Master.RetDate) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                    & " AND FG_Ret_Det.FID ='" & dr.Item("FID") & "' AND FG_Ret_Master.CID = '" & dr.Item("CID") & "'"

                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = adp.SelectCommand.Connection
                cmd.CommandText = strSql
                Dim returnQty As Integer = cmd.ExecuteScalar()
                dr.Item("Ret_Qty") = returnQty
            Next
            ds.Tables("CP").AcceptChanges()

            myRpt.DataSource = ds

            Select Case strReport
                Case "CWPWS", "CWPWS_Cons"
                    myRpt.XrTableCell1.DataBindings.Add("Text", ds, "CP.FGName")
                    myRpt.XrLabel3.Text = "Product"

                    myRpt.GroupHeader2.GroupFields.Item(0).FieldName = "CustName"
                    myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "Challan_No"
                    myRpt.XrLabel1.Text = "Customer: "
                    myRpt.XrLabel2.DataBindings.Add("Text", ds, "CP.CustName")
                    myRpt.XrLabel9.Text = "Customer wise Product wise Sales"
                    If strReport = "CWPWS_Cons" Then
                        myRpt.XrTableCell2.Visible = False
                        myRpt.XrTableCell3.Visible = False
                        myRpt.XrTableCell4.Visible = False

                        myRpt.XrLabel4.Width = -1
                        myRpt.XrLabel5.Width = -1
                        myRpt.XrLabel6.Width = -1
                        myRpt.XrLabel7.Left = myRpt.XrLabel4.Left
                        myRpt.XrLabel7.Width = 358
                        myRpt.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
                        myRpt.XrLabel4.Visible = False

                        myRpt.XrLabel5.Visible = False
                        myRpt.XrLabel6.Visible = False
                        myRpt.XrTableCell2.Width = -1
                        myRpt.XrTableCell2.CanShrink = True
                        myRpt.XrTableCell3.Width = -1
                        myRpt.XrTableCell3.CanShrink = True
                        myRpt.XrTableCell4.Width = -1
                        myRpt.XrTableCell4.CanShrink = True
                        myRpt.XrTableCell1.Width = 525  'myRpt.XrTableCell1.Width + myRpt.XrTableCell2.Width + myRpt.XrTableCell3.Width + myRpt.XrTableCell4.Width
                    End If
                Case "PWCWS", "PWCWS_Cons"
                    myRpt.XrTableCell2.DataBindings.Add("Text", ds, "CP.FGName")

                    myRpt.XrLabel3.Text = "Customer Name"

                    myRpt.GroupHeader2.GroupFields.Item(0).FieldName = "FGName"
                    myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "Challan_No"

                    myRpt.XrLabel1.Text = "Product: "
                    myRpt.XrLabel2.DataBindings.Add("Text", ds, "CP.FGName")
                    myRpt.XrTableCell1.DataBindings.Add("Text", ds, "CP.CustName")
                    myRpt.XrLabel9.Text = "Product wise Customer wise Sales"
            End Select
            myRpt.XrLabel10.Text = "Between " & dtpFrom.Text & " To " & dtpTo.Text
            myRpt.XrLabel12.Text = Format(Now, "dd-MM-yyyy")
            If strReport <> "PWCWS_Cons" And strReport <> "CWPWS_Cons" Then
                myRpt.XrTableCell2.DataBindings.Add("Text", ds, "CP.Challan_No")
                myRpt.XrTableCell3.DataBindings.Add("Text", ds, "CP.Challan_dt")
                myRpt.XrTableCell4.DataBindings.Add("Text", ds, "CP.BatchID")
            End If
            myRpt.XrTableCell5.DataBindings.Add("Text", ds, "CP.Qty")
            myRpt.XrTableCell6.DataBindings.Add("Text", ds, "CP.Ret_Qty")
            'myRpt.XrLabel18.DataBindings.Add("Text", ds, "CP.FGName")
            'myRpt.XrLabel20.DataBindings.Add("Text", ds, "CP.Qty")

            myRpt.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "CP.Qty", "")})
            myRpt.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "CP.Qty", "")})

            myRpt.XrLabel8.DataBindings.Add("Text", ds, "Company.CompanyName")
            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            'myRpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()

        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Public Sub showInwardTriplicate(ByVal strRMVINo As String)
        Try
            Dim strSql As String
            If strRMVINo <> "" Then
                strSql = "SELECT QCMaster.RMVI_NO, format(QCMaster.Date,'DD/MM/YYYY') AS QDATE, RMItemMaster.RMItemName, QCDetail.QC_No, QCDetail.Accepted_Qty, QCDetail.Reject_Qty, QCDetail.Reason, QCDetail.PO_NO, QCDetail.TCNO " _
                    & " FROM RMItemMaster INNER JOIN (QCMaster INNER JOIN QCDetail ON QCMaster.RMVI_NO = QCDetail.RMVI_NO) ON RMItemMaster.Rid = QCDetail.RID " _
                    & " WHERE (((QCMaster.RMVI_NO)='" & strRMVINo.Trim & ")) "
            Else
                DevExpress.XtraEditors.XtraMessageBox.Show("Select RMVI No first.", "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim myRpt As New rptInwardTriplicate
            Dim ds As New DataSet

            Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
            adp.Fill(ds, "QC")

            adp.SelectCommand.CommandText = "Select *, (Add1 + ',' + Add2 + ',' + City + ',' + State + ',' + Pincode + ',' + country +' Phone: ' + phone + ', Fax: ' + fax ) as Address from companyMaster"
            adp.Fill(ds, "Company")


            myRpt.DataSource = ds
            myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "RMVI_NO"
            myRpt.XrLabel11.DataBindings.Add("Text", ds, "QC.RMVI_NO")
            myRpt.XrLabel13.DataBindings.Add("Text", ds, "QC.QDATE")

            myRpt.XrLabel9.DataBindings.Add("Text", ds, "Company.CompanyName")
            myRpt.XrLabel14.DataBindings.Add("Text", ds, "Company.Address")

            myRpt.XrTableCell1.DataBindings.Add("Text", ds, "QC.RMItemName")
            myRpt.XrTableCell2.DataBindings.Add("Text", ds, "QC.QC_No")
            myRpt.XrTableCell3.DataBindings.Add("Text", ds, "QC.Accepted_Qty")
            myRpt.XrTableCell4.DataBindings.Add("Text", ds, "QC.Reject_Qty")
            myRpt.XrTableCell5.DataBindings.Add("Text", ds, "QC.Reason")
            myRpt.XrTableCell6.DataBindings.Add("Text", ds, "QC.PO_NO")
            myRpt.XrTableCell7.DataBindings.Add("Text", ds, "QC.TCNO")

            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            'myRpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()

        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub showRMCompReg(ByVal strRID As String)
        Try
            Dim myrpt As New rptCompReg
            Dim strsql As String
            Dim ds As New DataSet
            Dim adpt As New OleDb.OleDbDataAdapter

            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            adpt.SelectCommand = New OleDb.OleDbCommand
            adpt.SelectCommand.Connection = conn
            If strID = "" Then
                adpt.SelectCommand.CommandText = "Select RMItemMaster.RID,RMItemMaster.RMItemName from RMItemMaster"
            Else
                adpt.SelectCommand.CommandText = "Select RMItemMaster.RID,RMItemMaster.RMItemName from RMItemMaster where RID='" & strRID.Trim
            End If
            adpt.Fill(ds, "RMStock")
            For i As Integer = 0 To ds.Tables("RMStock").Rows.Count - 1
                adpt.SelectCommand.CommandText = "SELECT RMStock.RID, RMItemMaster.RMItemName, RMStock.RMVI_No, RMStock.Balance_Qty, RMStock.Date " _
                     & " FROM RMItemMaster INNER JOIN RMStock ON RMItemMaster.RID = RMStock.RID " _
                     & " WHERE (((RMStock.Balance_Qty)>0) AND ((RMStock.Date)<# " & Format(dtpFrom.EditValue, "MM/dd/yyyy").Trim & "#)) and RMStock.RID ='" & ds.Tables("RMStock").Rows(i).Item("RID") & "'"

                adpt.Fill(ds, "RMOpening")
                For k As Integer = 0 To ds.Tables("RMOpening").Rows.Count - 1
                    'Opening Stock
                    cmd.CommandText = "Insert Into Temp_Reg (ID,Product,Rec_Dt,Inward_BatchNo,Qty_Rec) values ('" _
                        & ds.Tables("RMStock").Rows(i).Item("RID") & "','" & Replace(ds.Tables("RMStock").Rows(i).Item("RMItemName"), "'", "''") & "','" & Format(dtpFrom.EditValue, "MM/dd/yyyy").Trim & "','" & ds.Tables("RMOpening").Rows(k).Item("RMVI_No") & "'," & ds.Tables("RMOpening").Rows(k).Item("Balance_Qty") & ")"
                    cmd.ExecuteNonQuery()
                Next
                ds.Tables("RMOpening").Rows.Clear()

                strsql = "SELECT RMStock.RMVI_No, RMstock.Issue_Qty, format(RMStock.Date,'DD/MM/YYYY') AS FDATE, RMStock.Received_Qty " _
                    & " FROM RMItemMaster INNER JOIN RMStock ON RMItemMaster.RID = RMStock.RID " _
                    & " WHERE (((RMStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((RMStock.RID)='" & ds.Tables("RMStock").Rows(i).Item("RID") & "'))"

                adpt.SelectCommand.CommandText = strsql
                adpt.Fill(ds, "RMOpen")
                For j As Integer = 0 To ds.Tables("RMOpen").Rows.Count - 1
                    cmd.CommandText = "Insert Into Temp_Reg (ID,Product,Rec_Dt,Inward_BatchNo,Qty_Rec) values ('" _
                        & ds.Tables("RMStock").Rows(i).Item("RID") & "','" & Replace(ds.Tables("RMStock").Rows(i).Item("RMItemName"), "'", "''") & "','" & ds.Tables("RMOpen").Rows(j).Item("FDate") & "','" & ds.Tables("RMOpen").Rows(j).Item("RMVI_No") & "'," & ds.Tables("RMOpen").Rows(j).Item("Received_Qty") & ")"
                    cmd.ExecuteNonQuery()
                Next
                ds.Tables("RMOpen").Rows.Clear()


                'Issue
                strsql = "SELECT Material_Issue_Master.MIS_NO, Material_Issue_Master.MIS_DATE, Material_Issue_Detail.RMVI_NO, Material_Issue_Detail.Issued_Qty, RMStock.RID " _
                    & " FROM RMStock INNER JOIN (Material_Issue_Master INNER JOIN Material_Issue_Detail ON Material_Issue_Master.MIS_NO = Material_Issue_Detail.MIS_NO) ON RMStock.RID = Material_Issue_Detail.RID " _
                    & " GROUP BY Material_Issue_Master.MIS_NO, Material_Issue_Master.MIS_DATE, Material_Issue_Detail.RMVI_NO, Material_Issue_Detail.Issued_Qty, RMStock.RID " _
                    & " HAVING (((Material_Issue_Master.MIS_DATE) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((RMStock.RID)='" & ds.Tables("RMStock").Rows(i).Item("RID") & "'));"

                adpt.SelectCommand.CommandText = strsql
                adpt.Fill(ds, "MIS")
                For j As Integer = 0 To ds.Tables("MIS").Rows.Count - 1
                    cmd.CommandText = "Insert Into Temp_Reg (ID,Product,MISNo,Rec_Dt,Issue_Date,Outward_Batchno,Issue_Qty) values ('" _
                        & ds.Tables("RMStock").Rows(i).Item("RID") & "','" & Replace(ds.Tables("RMStock").Rows(i).Item("RMItemName"), "'", "''") & "','" & ds.Tables("MIS").Rows(j).Item("MIS_NO") & "','" & ds.Tables("MIS").Rows(j).Item("MIS_DATE") & "','" & ds.Tables("MIS").Rows(j).Item("MIS_DATE") & "','" & ds.Tables("MIS").Rows(j).Item("RMVI_NO") & "'," & ds.Tables("MIS").Rows(j).Item("Issued_Qty") & ")"
                    cmd.ExecuteNonQuery()
                Next
                ds.Tables("MIS").Rows.Clear()

                'MIS_RETURN_REISSUE
                strsql = "SELECT MIS_Return_Master.MIS_NO, MIS_Return_Master.Return_Date, MIS_Return_Detail.RMVI_NO, MIS_Return_Detail.Qty, MIS_Return_Detail.Type " _
                    & " FROM (MIS_Return_Master INNER JOIN MIS_Return_Detail ON MIS_Return_Master.ID = MIS_Return_Detail.ReturnID) INNER JOIN RMStock ON MIS_Return_Detail.RID = RMStock.RID " _
                    & " WHERE (((RMStock.RID)='" & ds.Tables("RMStock").Rows(i).Item("RID") & "')) " _
                    & " GROUP BY MIS_Return_Master.MIS_NO, MIS_Return_Master.Return_Date, MIS_Return_Detail.RMVI_NO, MIS_Return_Detail.Qty, MIS_Return_Detail.Type " _
                    & " HAVING (((MIS_Return_Master.Return_Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))"

                adpt.SelectCommand.CommandText = strsql
                adpt.Fill(ds, "MIS_RETURN_REISSUE")
                For j As Integer = 0 To ds.Tables("MIS_RETURN_REISSUE").Rows.Count - 1
                    If (ds.Tables("MIS_RETURN_REISSUE").Rows(j).Item("Type").ToString() = "Return") Then
                        cmd.CommandText = "Insert Into Temp_Reg (ID,Product,Rec_Dt,Inward_BatchNo,Qty_Rec) values ('" _
                           & ds.Tables("RMStock").Rows(i).Item("RID") & "','" & Replace(ds.Tables("RMStock").Rows(i).Item("RMItemName"), "'", "''") & "','" & ds.Tables("MIS_RETURN_REISSUE").Rows(j).Item("Return_Date") & "','" & ds.Tables("MIS_RETURN_REISSUE").Rows(j).Item("RMVI_No") & "'," & ds.Tables("MIS_RETURN_REISSUE").Rows(j).Item("Qty") & ")"
                        cmd.ExecuteNonQuery()
                    Else
                        cmd.CommandText = "Insert Into Temp_Reg (ID,Product,MISNo,Issue_Date,Outward_Batchno,Issue_Qty) values ('" _
                            & ds.Tables("RMStock").Rows(i).Item("RID") & "','" & Replace(ds.Tables("RMStock").Rows(i).Item("RMItemName"), "'", "''") & "','" & ds.Tables("MIS_RETURN_REISSUE").Rows(j).Item("MIS_NO") & "','" & ds.Tables("MIS_RETURN_REISSUE").Rows(j).Item("Return_Date") & "','" & ds.Tables("MIS_RETURN_REISSUE").Rows(j).Item("RMVI_NO") & "'," & ds.Tables("MIS_RETURN_REISSUE").Rows(j).Item("Qty") & ")"
                        cmd.ExecuteNonQuery()
                    End If                   
                Next
                ds.Tables("MIS_RETURN_REISSUE").Rows.Clear()
            Next

            ds.Tables.Clear()

            adpt.SelectCommand.CommandText = "Select *,Format(Rec_Dt,'DD/MM/YYYY') AS Rdate,format(Issue_Date,'DD/MM/YYYY') AS IDATE from Temp_Reg ORDER BY Rec_Dt, Inward_Batchno DESC , Outward_Batchno;"
            adpt.Fill(ds, "RMComp")


            adpt.SelectCommand.CommandText = "Select CompanyName from companyMaster"
            adpt.Fill(ds, "Company")

            myrpt.DataSource = ds
            myrpt.GroupHeader1.GroupFields.Item(0).FieldName = "Product"
            myrpt.XrLabel1.DataBindings.Add("Text", ds, "RMComp.Product")

            myrpt.XrTableCell1.DataBindings.Add("Text", ds, "RMComp.Rdate")
            myrpt.XrTableCell2.DataBindings.Add("Text", ds, "RMComp.VINO")
            myrpt.XrTableCell3.DataBindings.Add("Text", ds, "RMComp.Qty_Rec")
            myrpt.XrTableCell4.DataBindings.Add("Text", ds, "RMComp.Inward_Batchno")

            myrpt.XrTableCell5.DataBindings.Add("Text", ds, "RMComp.Outward_Batchno")
            myrpt.XrTableCell17.DataBindings.Add("Text", ds, "RMComp.IDATE")
            myrpt.XrTableCell16.DataBindings.Add("Text", ds, "RMComp.MISNO")
            myrpt.XrTableCell18.DataBindings.Add("Text", ds, "RMComp.Issue_Qty")
            'myrptXrTableCell20.DataBindings.Add("Text", ds, "MIS.RMVI_NO")

            myrpt.XrLabel13.DataBindings.Add("Text", ds, "Company.CompanyName")
            myrpt.XrLabel15.Text = "RMVI No"
            myrpt.XrLabel11.Text = "Batch No"

            myrpt.XrLabel31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMComp.Qty_Rec", "")})
            myrpt.XrLabel32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMComp.Issue_Qty", "")})



            cmd.CommandText = "Delete from Temp_Reg"
            cmd.ExecuteNonQuery()
            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            'myrpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
            printingSystem.ShowRibbonPreview()
            adpt.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Private Sub showPendingMIS()
        Try
            Dim myrpt As New rptPendingMIS
            Dim strsql As String
            Dim ds As New DataSet

            cmd = New OleDb.OleDbCommand
            cmd.CommandText = "Select count(*) from Material_Issue_Master "
            cmd.Connection = conn
            If cmd.ExecuteScalar > 0 Then
                strsql = "SELECT REQMASTER.REQID, format(REQMASTER.REQDATE,'DD/MM/YYYY') AS REQDATE, FGMaster.FGName, REQMASTER.QTY " _
                    & " FROM FGMaster INNER JOIN (REQMASTER INNER JOIN Material_Issue_Master " _
                    & " ON REQMASTER.RQID <> Material_Issue_Master.RQID) ON FGMaster.FID = REQMASTER.FID " _
                    & " WHERE (((REQMASTER.REQDATE) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))"
            Else
                strsql = "SELECT REQMASTER.REQID, format(REQMASTER.REQDATE,'DD/MM/YYYY') AS REQDATE, FGMaster.FGName, REQMASTER.QTY " _
                    & " FROM FGMaster INNER JOIN REQMASTER  ON FGMaster.FID = REQMASTER.FID " _
                    & " WHERE (((REQMASTER.REQDATE) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))"
            End If

            Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
            adp.Fill(ds, "MIS")

            adp.SelectCommand.CommandText = "Select CompanyName from companyMaster"
            adp.Fill(ds, "Company")

            myrpt.DataSource = ds

            myrpt.XrTableCell1.DataBindings.Add("Text", ds, "MIS.REQID")
            myrpt.XrTableCell2.DataBindings.Add("Text", ds, "MIS.REQDATE")
            myrpt.XrTableCell3.DataBindings.Add("Text", ds, "MIS.FGName")
            myrpt.XrTableCell7.DataBindings.Add("Text", ds, "MIS.QTY")

            myrpt.XrLabel2.DataBindings.Add("Text", ds, "Company.CompanyName")
            myrpt.XrLabel4.Text = Today.Date
            myrpt.XrLabel6.Text = dtpFrom.Text
            myrpt.XrLabel8.Text = dtpTo.Text

            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            'myrpt.PrintingSystem = printingSystem
            'myrpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()
        Catch EX As Exception
            If show_error Then
                MsgBox(EX.ToString)
            End If
        End Try
    End Sub
    Private Sub showPendingRMVI()
        Try
            Dim myrpt As New rptPendingRMVI
            Dim strsql As String
            Dim ds As New DataSet

            'strsql = "SELECT Purchase_Master.PO_No, format(Purchase_Master.PO_Date,'DD/MM/YYYY') AS PO_DATE, RMItemMaster.RMItemName, Purchase_Detail.Qty" _
            '    & " FROM ((Purchase_Master INNER JOIN QCDetail ON Purchase_Master.PO_No <> QCDetail.PO_NO) INNER JOIN Purchase_Detail ON Purchase_Master.PO_No = Purchase_Detail.PO_No) INNER JOIN RMItemMaster ON Purchase_Detail.RMItemID = RMItemMaster.Rid" _
            '    & " WHERE (((Purchase_Master.PO_Date)  Between #" & dtpFrom.Text & "# and #" & dtpTo.Text & "#))"

            'strsql = "SELECT Purchase_Master.PO_NO, Format(Purchase_Master.PO_Date,'dd/mm/yyyy') AS PO_DATE, RMItemMaster.RMItemName, Purchase_Detail.Qty " _
            '    & " FROM RMItemMaster INNER JOIN ((Purchase_Master INNER JOIN QCDetail ON Purchase_Master.PO_No <> QCDetail.PO_NO) INNER JOIN Purchase_Detail ON Purchase_Master.PO_No = Purchase_Detail.PO_No) ON RMItemMaster.Rid = Purchase_Detail.RMItemID " _
            '    & " WHERE (((Purchase_Master.PO_Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))" _
            '    & " GROUP BY Purchase_Master.PO_No, Format(Purchase_Master.PO_Date,'dd/mm/yyyy'), RMItemMaster.RMItemName, Purchase_Detail.Qty"

            strsql = "SELECT Purchase_master.PO_NO, Format(Purchase_Master.PO_Date,'dd/mm/yyyy') AS PO_DATE,RMItemMaster.RMItemName, Purchase_Detail.Qty " _
                & " FROM RMItemMaster INNER JOIN (Purchase_master INNER JOIN Purchase_Detail ON Purchase_master.PO_No = Purchase_Detail.PO_No) ON RMItemMaster.Rid = Purchase_Detail.RMItemID" _
                & " WHERE (((Purchase_master.PO_NO) Not In (SELECT QCDetail.PO_NO " _
                & " FROM(QCDetail) " _
                & " GROUP BY QCDetail.PO_NO)))" _
                & " GROUP BY Purchase_master.PO_NO, Purchase_master.PO_Date, Purchase_Detail.Qty, RMItemMaster.RMItemName " _
                & " HAVING (((Purchase_master.PO_Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#));"


            Dim adp As New OleDb.OleDbDataAdapter(strsql, conn)
            adp.Fill(ds, "RMVI")

            adp.SelectCommand.CommandText = "Select CompanyName from companyMaster"
            adp.Fill(ds, "Company")

            myrpt.DataSource = ds

            myrpt.XrTableCell1.DataBindings.Add("Text", ds, "RMVI.PO_NO")
            myrpt.XrTableCell2.DataBindings.Add("Text", ds, "RMVI.PO_DATE")
            myrpt.XrTableCell3.DataBindings.Add("Text", ds, "RMVI.RMItemName")
            myrpt.XrTableCell7.DataBindings.Add("Text", ds, "RMVI.Qty")

            myrpt.XrLabel2.DataBindings.Add("Text", ds, "Company.CompanyName")
            myrpt.XrLabel4.Text = Today.Date
            myrpt.XrLabel6.Text = dtpFrom.Text
            myrpt.XrLabel8.Text = dtpTo.Text

            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            'myrpt.PrintingSystem = printingSystem
            'myrpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Public Sub showFGStock()
        Try
            Dim myRpt As New rptRMStock
            Dim ds As New DataSet

            ds.Tables.Add("FGStock")
            ds.Tables(0).Columns.Add("FGName", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("Unit", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("TDate", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("GroupName", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("Batch_No", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("Type", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("Opn_Qty", System.Type.GetType("System.Double"))
            ds.Tables(0).Columns.Add("Rec_Qty", System.Type.GetType("System.Double"))
            ds.Tables(0).Columns.Add("Issue_Qty", System.Type.GetType("System.Double"))
            ds.Tables(0).Columns.Add("Ret_Qty", System.Type.GetType("System.Double"))
            ds.Tables(0).Columns.Add("Balance_Qty", System.Type.GetType("System.Double"))

            Dim adp As New OleDb.OleDbDataAdapter
            If strID = "" Then
                adp.SelectCommand = New OleDb.OleDbCommand
                adp.SelectCommand.Connection = conn
                adp.SelectCommand.CommandText = "SELECT format(FGStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, FGMaster.FGName, FGStock.Batch_No, FGStock.Type, FGStock.Received_Qty as Opn_Qty, FGStock.Issue_Qty, " _
                    & " UnitMaster.UnitName,FGStock.Ret_Qty, FGStock.Balance_Qty " _
                    & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID " _
                    & " WHERE (((FGStock.Date)<#" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "#) AND ((FGStock.Balance_Qty)>0)) Order by FGMaster.FGName,FGStock.Date "
                adp.Fill(ds.Tables("FGStock"))

                adp.SelectCommand.CommandText = "SELECT format(FGStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, FGMaster.FGName, FGStock.Batch_No, FGStock.Type, FGStock.Received_Qty as Opn_Qty, FGStock.Issue_Qty, FGStock.Ret_Qty, FGStock.Balance_Qty, " _
                    & " UnitMaster.UnitName " _
                    & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID " _
                    & " WHERE (((FGStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((FGStock.Type)='Opening')) Order by FGMaster.FGName,FGStock.Date "
                adp.Fill(ds.Tables("FGStock"))

                adp.SelectCommand.CommandText = "SELECT format(FGStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, FGMaster.FGName, FGStock.Batch_No, FGStock.Type, FGStock.Received_Qty as Rec_Qty, FGStock.Issue_Qty, FGStock.Ret_Qty, FGStock.Balance_Qty, " _
                    & " UnitMaster.UnitName " _
                    & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID " _
                    & " WHERE (((FGStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((FGStock.Type)='Inward')) Order by FGMaster.FGName,FGStock.Date"
                adp.Fill(ds.Tables("FGStock"))

                adp.SelectCommand.CommandText = "SELECT format(FGStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, FGMaster.FGName, FGStock.Batch_No, FGStock.Type,  FGStock.Issue_Qty, FGStock.Ret_Qty, FGStock.Balance_Qty, " _
                    & " UnitMaster.UnitName " _
                    & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID " _
                    & " WHERE (((FGStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((FGStock.Type)='Return')) Order by FGMaster.FGName,FGStock.Date"
                adp.Fill(ds.Tables("FGStock"))
            Else
                adp.SelectCommand = New OleDb.OleDbCommand
                adp.SelectCommand.Connection = conn
                If strReport = "FG_Stock_Group" Then

                    adp.SelectCommand.CommandText = "SELECT format(FGStock.Date,'dd/MM/yyyy') AS TDate, GroupMaster.GroupName, FGMaster.FGName, FGStock.Batch_No, FGStock.Type, FGStock.Received_Qty as Opn_Qty, FGStock.Issue_Qty, FGStock.Ret_Qty, FGStock.Balance_Qty, " _
                       & " UnitMaster.UnitName " _
                       & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID " _
                       & " WHERE (((FGStock.Date)<#" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "#) AND ((FGStock.Balance_Qty)>0)) and GroupMaster.GroupName ='" & strID & "' Order by FGMaster.FGName,FGStock.Date "
                    adp.Fill(ds.Tables("FGStock"))

                    adp.SelectCommand.CommandText = "SELECT format(FGStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, FGMaster.FGName, FGStock.Batch_No, FGStock.Type, FGStock.Received_Qty as Opn_Qty, FGStock.Issue_Qty, FGStock.Ret_Qty, FGStock.Balance_Qty, " _
                        & " UnitMaster.UnitName " _
                        & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID " _
                        & " WHERE (((FGStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((FGStock.Type)='Opening')) and GroupMaster.GroupName ='" & strID & "' Order by FGMaster.FGName,FGStock.Date "
                    adp.Fill(ds.Tables("FGStock"))

                    adp.SelectCommand.CommandText = "SELECT format(FGStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, FGMaster.FGName, FGStock.Batch_No, FGStock.Type, FGStock.Received_Qty as Rec_Qty, FGStock.Issue_Qty, FGStock.Ret_Qty, FGStock.Balance_Qty, " _
                        & " UnitMaster.UnitName " _
                        & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID " _
                        & " WHERE (((FGStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((FGStock.Type)='Inward')) and GroupMaster.GroupName ='" & strID & "' Order by FGMaster.FGName,FGStock.Date"
                    adp.Fill(ds.Tables("FGStock"))

                    adp.SelectCommand.CommandText = "SELECT format(FGStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, FGMaster.FGName, FGStock.Batch_No, FGStock.Type,  FGStock.Issue_Qty, FGStock.Ret_Qty, FGStock.Balance_Qty, " _
                        & " UnitMaster.UnitName " _
                        & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID " _
                        & " WHERE (((FGStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((FGStock.Type)='Return')) and GroupMaster.GroupName ='" & strID & "' Order by FGMaster.FGName,FGStock.Date"
                    adp.Fill(ds.Tables("FGStock"))

                Else
                    adp.SelectCommand.CommandText = "SELECT format(FGStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, FGMaster.FGName, FGStock.Batch_No, FGStock.Type, FGStock.Received_Qty as Opn_Qty, FGStock.Issue_Qty, FGStock.Ret_Qty, FGStock.Balance_Qty, " _
                        & " UnitMaster.UnitName " _
                        & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID " _
                        & " WHERE (((FGStock.Date)<#" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "#) AND ((FGStock.Balance_Qty)>0)) and FGMaster.FGName ='" & strID & "' Order by FGMaster.FGName,FGStock.Date "
                    adp.Fill(ds.Tables("FGStock"))

                    adp.SelectCommand.CommandText = "SELECT format(FGStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, FGMaster.FGName, FGStock.Batch_No, FGStock.Type, FGStock.Received_Qty as Opn_Qty, FGStock.Issue_Qty, FGStock.Ret_Qty, FGStock.Balance_Qty, " _
                        & " UnitMaster.UnitName " _
                        & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID " _
                        & " WHERE (((FGStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((FGStock.Type)='Opening')) and FGMaster.FGName ='" & strID & "' Order by FGMaster.FGName,FGStock.Date "
                    adp.Fill(ds.Tables("FGStock"))

                    adp.SelectCommand.CommandText = "SELECT format(FGStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, FGMaster.FGName, FGStock.Batch_No, FGStock.Type, FGStock.Received_Qty as Rec_Qty, FGStock.Issue_Qty, FGStock.Ret_Qty, FGStock.Balance_Qty, " _
                        & " UnitMaster.UnitName " _
                        & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID " _
                        & " WHERE (((FGStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((FGStock.Type)='Inward')) and FGMaster.FGName ='" & strID & "' Order by FGMaster.FGName,FGStock.Date"
                    adp.Fill(ds.Tables("FGStock"))

                    adp.SelectCommand.CommandText = "SELECT format(FGStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, FGMaster.FGName, FGStock.Batch_No, FGStock.Type, FGStock.Issue_Qty, FGStock.Ret_Qty, FGStock.Balance_Qty, " _
                        & " UnitMaster.UnitName " _
                        & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID " _
                        & " WHERE (((FGStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((FGStock.Type)='Return')) and FGMaster.FGName ='" & strID & "' Order by FGMaster.FGName,FGStock.Date"
                    adp.Fill(ds.Tables("FGStock"))
                End If
            End If


            adp.SelectCommand.CommandText = "Select CompanyName from companyMaster"
            adp.Fill(ds, "Company")

            myRpt.DataSource = ds.Tables(0)
            myRpt.XrTableCell1.DataBindings.Add("Text", ds, "FGStock.TDate")
            myRpt.XrTableCell2.DataBindings.Add("Text", ds, "FGStock.FGName")
            myRpt.XrTableCell3.DataBindings.Add("Text", ds, "FGStock.UnitName")
            myRpt.XrTableCell4.DataBindings.Add("Text", ds, "FGStock.Batch_No")
            myRpt.XrTableCell5.DataBindings.Add("Text", ds, "FGStock.Rec_Qty")
            myRpt.XrTableCell6.DataBindings.Add("Text", ds, "FGStock.Issue_Qty")
            myRpt.XrTableCell7.DataBindings.Add("Text", ds, "FGStock.Balance_Qty")
            myRpt.XrTableCell8.DataBindings.Add("Text", ds, "FGStock.Opn_Qty")
            myRpt.XrTableCell9.DataBindings.Add("Text", ds, "FGStock.Ret_Qty")


            myRpt.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "FGStock.Balance_Qty", "")})
            myRpt.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "FGStock.Issue_Qty", "")})
            myRpt.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "FGStock.Rec_Qty", "")})
            myRpt.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "FGStock.Ret_Qty", "")})
            myRpt.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "FGStock.Opn_Qty", "")})


            myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "GroupName"
            myRpt.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "FGStock.GroupName", "")})

            myRpt.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "Company.CompanyName")})
            'myRpt.XrLabel9.Summary.Func.Sum()
            myRpt.XrLabel1.Text = "Finish Goods Stock Statement"
            myRpt.XrLabel1.Text = myRpt.XrLabel1.Text & " Between " & Format(dtpFrom.EditValue, "dd/MM/yyyy") & " and " & Format(dtpTo.EditValue, "dd/MM/yyyy")
            myRpt.XrLabel5.Text = "Batch No"
            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            'myrpt.PrintingSystem = printingSystem
            'myRpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Public Sub showRMQC()
        Try
            'DHAVAL
            Dim myrpt As New rptRMQC
            Dim ds As New DataSet
            Dim str As String
            If lkupName.Text = "" Then
                str = "SELECT  QCMaster.Sr_No,QCMaster.RMVI_NO, RMItemMaster.RMItemName, format(QCMaster.Date,'DD/MM/YYYY') AS VI_Date, RMItemMaster.DrawNo, QCDetail.Inspected_No, QCDetail.QC_No, QCDetail.Reject_Qty," _
                    & " QCDetail.Reason,QCDetail.TCNO ,QCDetail.Challan_No,QCDetail.DR_Check " _
                    & " FROM RMItemMaster INNER JOIN (QCMaster INNER JOIN QCDetail ON QCMaster.RMVI_NO = QCDetail.RMVI_NO) ON RMItemMaster.Rid = QCDetail.RID " _
                    & " WHERE (((QCMaster.Date)  between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) ORDER BY QCMaster.Sr_No " _
                    & " "
            Else
                str = "SELECT  QCMaster.Sr_No,QCMaster.RMVI_NO, RMItemMaster.RMItemName, format(QCMaster.Date,'DD/MM/YYYY') AS VI_Date, RMItemMaster.DrawNo, QCDetail.Inspected_No, QCDetail.QC_No, QCDetail.Reject_Qty," _
                    & " QCDetail.Reason,QCDetail.TCNo,QCDetail.Challan_No,QCDetail.DR_Check " _
                    & " FROM RMItemMaster INNER JOIN (QCMaster INNER JOIN QCDetail ON QCMaster.RMVI_NO = QCDetail.RMVI_NO) ON RMItemMaster.Rid = QCDetail.RID " _
                    & " WHERE QCMaster.RMVI_NO='" & strID & "' AND QCMaster.Date between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "# ORDER BY QCMaster.Sr_No"
            End If

            Dim adp As New OleDb.OleDbDataAdapter(str, conn)
            adp.Fill(ds, "RMQC")



            adp.SelectCommand.CommandText = "Select * from companyMaster"
            adp.Fill(ds, "Company")


            myrpt.DataSource = ds
            myrpt.XrTableCell1.DataBindings.Add("Text", ds.Tables(0), "RMVI_NO")
            myrpt.XrTableCell3.DataBindings.Add("Text", ds.Tables(0), "VI_Date")
            myrpt.XrTableCell2.DataBindings.Add("Text", ds.Tables(0), "RMItemName")
            myrpt.XrTableCell4.DataBindings.Add("Text", ds.Tables(0), "DrawNo")
            'myrpt.XrTableCell12.DataBindings.Add("Text", ds.Tables(0), "Model_No")
            myrpt.XrTableCell5.DataBindings.Add("Text", ds.Tables(0), "DR_Check")
            myrpt.XrTableCell6.DataBindings.Add("Text", ds.Tables(0), "Inspected_No")
            myrpt.XrTableCell7.DataBindings.Add("Text", ds.Tables(0), "QC_No")
            myrpt.XrTableCell8.DataBindings.Add("Text", ds.Tables(0), "Reject_Qty")
            myrpt.XrTableCell9.DataBindings.Add("Text", ds.Tables(0), "Reason")
            myrpt.XrTableCell10.DataBindings.Add("Text", ds.Tables(0), "TCNO")
            myrpt.XrTableCell35.DataBindings.Add("Text", ds.Tables(0), "Sr_No")
            myrpt.XrTableCell12.DataBindings.Add("Text", ds.Tables(0), "Challan_No")
            'myrpt.XrTableCell21.DataBindings.Add("Text", ds.Tables(0), "Batch_NO")

            myrpt.XrLabel2.DataBindings.Add("Text", ds.Tables(1), "CompanyName")
            'myrpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()
        Catch ex As Exception
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub

    Public Sub ShowMIS(ByVal strMIS As String)
        Try
            If strMIS Is Nothing Or strMIS.Trim = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Invalid MIS No", "Requisition", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Dim myRpt As New rptMIS
                Dim strSql As String
                Dim ds As New DataSet


                'strSql = "SELECT RMItemMaster.RMItemName, Material_Issue_Detail.Issued_Qty, RMItemMaster.RMItemId,Material_Issue_Detail.RMVI_NO " _
                '& " FROM Material_Issue_Detail INNER JOIN RMItemMaster ON Material_Issue_Detail.RID = RMItemMaster.Rid " _
                '& " WHERE (((Material_Issue_Detail.MIS_NO)='" & strMIS.Trim & "'));"

                'strSql = "SELECT RMItemMaster.RMItemName, UnitMaster.UnitName, Material_Issue_Detail.Issued_Qty, RMItemMaster.RMItemId, Material_Issue_Detail.RMVI_NO " _
                '    & " FROM (Material_Issue_Detail INNER JOIN RMItemMaster ON Material_Issue_Detail.RID = RMItemMaster.Rid) INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID " _
                '    & " WHERE (((Material_Issue_Detail.MIS_NO)='" & strMIS.Trim & ")); "




                'adp.Fill(ds, "MISDetail")


                strSql = "SELECT Material_Issue_Master.MIS_NO, Format(Material_Issue_Master.MIS_DATE,'dd/mm/yyyy') AS MIS_DATE, " _
                & " FGMaster.FGName, FGMaster.Draw_No, FGMaster.FGID, Material_Issue_Master.FG_QTY," _
                & " RMItemMaster.RMItemName, UnitMaster.UnitName, Material_Issue_Detail.Issued_Qty," _
                & " RMItemMaster.RMItemId,Material_Issue_Detail.RMVI_NO " _
                & " FROM (((Material_Issue_Master INNER JOIN FGMaster ON Material_Issue_Master.FGID = FGMaster.FID) " _
                & " INNER JOIN Material_Issue_Detail ON Material_Issue_Master.MIS_NO = Material_Issue_Detail.MIS_NO) " _
                & " INNER JOIN RMItemMaster ON Material_Issue_Detail.RID = RMItemMaster.Rid) INNER JOIN UnitMaster ON " _
                & " RMItemMaster.UnitID = UnitMaster.UnitID " _
                & " WHERE (((Material_Issue_Master.MIS_NO)='" & strMIS.Trim & "))"

                'strSql = "SELECT Material_Issue_Master.MIS_NO, Format(Material_Issue_Master.MIS_DATE,'dd/mm/yyyy') AS MIS_DATE, " _
                '    & " FGMaster.FGName, FGMaster.Draw_No, FGMaster.FGID, Material_Issue_Master.FG_QTY," _
                '    & " RMItemMaster.RMItemName, UnitMaster.UnitName, Material_Issue_Detail.Issued_Qty, " _
                '    & " RMItemMaster.RMItemId, Material_Issue_Detail.RMVI_NO, REQMASTER.WORKORDERNO " _
                '    & " FROM ((Material_Issue_Master INNER JOIN FGMaster ON Material_Issue_Master.FGID = FGMaster.FID) " _
                '    & " INNER JOIN ((Material_Issue_Detail INNER JOIN RMItemMaster ON Material_Issue_Detail.RID = RMItemMaster.Rid) " _
                '    & " INNER JOIN UnitMaster ON RMItemMaster.UnitID = UnitMaster.UnitID) ON Material_Issue_Master.MIS_NO = Material_Issue_Detail.MIS_NO) " _
                '    & " INNER JOIN REQMASTER ON (REQMASTER.RQID = Material_Issue_Master.RQID) AND (FGMaster.FID = REQMASTER.FID)" _
                '    & " WHERE (((Material_Issue_Master.MIS_NO)='16/16-17'));"

                strSql = "SELECT Material_Issue_Master.MIS_NO, Format(Material_Issue_Master.MIS_DATE,'dd/mm/yyyy') AS MIS_DATE," _
                    & " FGMaster.FGName, FGMaster.Draw_No, FGMaster.FGID, Material_Issue_Master.FG_QTY, " _
                    & " RMItemMaster.RMItemName, UnitMaster.UnitName, Material_Issue_Detail.Issued_Qty, " _
                    & " RMItemMaster.RMItemId, Material_Issue_Detail.RMVI_NO, REQMASTER.WORKORDERNO " _
                    & " FROM ((Material_Issue_Master INNER JOIN FGMaster ON Material_Issue_Master.FGID = FGMaster.FID) " _
                    & " INNER JOIN ((Material_Issue_Detail INNER JOIN RMItemMaster ON Material_Issue_Detail.RID = RMItemMaster.Rid) " _
                    & " INNER JOIN UnitMaster ON RMItemMaster.UnitID = UnitMaster.UnitID) ON Material_Issue_Master.MIS_NO = Material_Issue_Detail.MIS_NO) " _
                    & " INNER JOIN REQMASTER ON (REQMASTER.RQID = Material_Issue_Master.RQID) AND (FGMaster.FID = REQMASTER.FID)" _
                    & " WHERE (((Material_Issue_Master.MIS_NO)='" & strMIS.Trim & "))"




                Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
                adp.Fill(ds, "MISMaster")
                'Dim woNo As String
                'If ds.Tables("MISMaster").Rows.Count > 0 Then
                '    woNo = ds.Tables("MISMaster").Rows(0).Item("WORKORDERNO").ToString()
                'End If

                strSql = "SELECT Material_Issue_Master.MIS_NO, Format(Material_Issue_Master.MIS_DATE,'dd/mm/yyyy') AS MIS_DATE, " _
                & " FGMaster.FGName, FGMaster.Draw_No, FGMaster.FGID, Material_Issue_Master.FG_QTY," _
                & " SemiFGMaster.FGName as RMItemName, UnitMaster.UnitName, Material_Issue_Detail.Issued_Qty," _
                & " SemiFGMaster.SFGID as RMItemId,Material_Issue_Detail.RMVI_NO " _
                & " FROM (((Material_Issue_Master INNER JOIN FGMaster ON Material_Issue_Master.FGID = FGMaster.FID) " _
                & " INNER JOIN Material_Issue_Detail ON Material_Issue_Master.MIS_NO = Material_Issue_Detail.MIS_NO) " _
                & " INNER JOIN SemiFGMaster ON Material_Issue_Detail.RID = SemiFGMaster.SFid) INNER JOIN UnitMaster ON " _
                & " SemiFGMaster.UnitID = UnitMaster.UnitID " _
                & " WHERE (((Material_Issue_Master.MIS_NO)='" & strMIS.Trim & "))"

                adp.SelectCommand.CommandText = strSql
                adp.Fill(ds, "MIS_SemiFGItem")
                ds.Tables("MISMaster").Merge(ds.Tables("MIS_SemiFGItem"))
                adp.SelectCommand.CommandText = "Select * from companyMaster"
                adp.Fill(ds, "Company")

                myRpt.DataSource = ds


                myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "MIS_NO"
                myRpt.XrTableCell1.DataBindings.Add("Text", ds, "MISMaster.RMItemName")
                myRpt.XrTableCell2.DataBindings.Add("Text", ds, "MISMaster.Issued_Qty")
                myRpt.XrTableCell3.DataBindings.Add("Text", ds, "MISMaster.RMItemId")
                myRpt.XrTableCell4.DataBindings.Add("Text", ds, "MISMaster.RMVI_NO")
                myRpt.XrTableCell10.DataBindings.Add("Text", ds, "MISMaster.UnitName")
                myRpt.xrlblWOVal.DataBindings.Add("Text", ds, "MISMaster.WORKORDERNO")

                myRpt.XrLabel1.DataBindings.Add("Text", ds, "Company.CompanyName")
                'myRpt.XrLabel2.DataBindings.Add("Text", ds, "Company.City")

                myRpt.XrLabel5.DataBindings.Add("Text", ds, "MISMaster.MIS_NO")
                myRpt.XrLabel6.DataBindings.Add("Text", ds, "MISMaster.MIS_DATE")

                myRpt.XrLabel12.DataBindings.Add("Text", ds, "MISMaster.FG_QTY")
                myRpt.XrLabel13.DataBindings.Add("Text", ds, "MISMaster.Draw_No")
                myRpt.XrLabel9.DataBindings.Add("Text", ds, "MISMaster.FGID")
                myRpt.XrLabel7.DataBindings.Add("Text", ds, "MISMaster.FGName")

                'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
                ''myrpt.PrintingSystem = printingSystem
                'myRpt.ShowPreview()
                Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
                printingSystem.ShowRibbonPreview()
                adp.Dispose()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ShowCMIS(ByVal strMIS As String)
        Try
            If strMIS Is Nothing Or strMIS.Trim = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Invalid MIS No", "Requisition", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Dim myRpt As New rptMIS
                Dim strSql As String
                Dim ds As New DataSet


                strSql = "SELECT SEMI_Material_Issue_Master.MIS_NO, Format(SEMI_Material_Issue_Master.MIS_DATE,'dd/mm/yyyy') AS MIS_DATE," _
                    & " SemiFGMaster.FGName, SemiFGMaster.Draw_No, SEMI_Material_Issue_Master.SFG_QTY, SemiFGMaster.SFID, " _
                    & " SEMI_Material_Issue_Detail.Issued_Qty, SEMI_Material_Issue_Detail.RMVI_NO, RMItemMaster.RMItemName," _
                    & " UnitMaster.UnitName, RMItemMaster.RMItemId" _
                    & " FROM UnitMaster INNER JOIN (((SEMI_Material_Issue_Master INNER JOIN SEMI_Material_Issue_Detail ON SEMI_Material_Issue_Master.MIS_NO = SEMI_Material_Issue_Detail.MIS_NO) INNER JOIN RMItemMaster ON SEMI_Material_Issue_Detail.RID = RMItemMaster.Rid) INNER JOIN SemiFGMaster ON SEMI_Material_Issue_Master.SFGID = SemiFGMaster.SFID) ON UnitMaster.UnitID = SemiFGMaster.UnitID " _
                    & " WHERE (((SEMI_Material_Issue_Master.MIS_NO)='" & strMIS.Trim & "))"


                Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
                adp.Fill(ds, "MISMaster")
                
                adp.SelectCommand.CommandText = "Select * from companyMaster"
                adp.Fill(ds, "Company")

                myRpt.DataSource = ds


                myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "MIS_NO"
                myRpt.XrTableCell1.DataBindings.Add("Text", ds, "MISMaster.RMItemName")
                myRpt.XrTableCell2.DataBindings.Add("Text", ds, "MISMaster.Issued_Qty")
                myRpt.XrTableCell3.DataBindings.Add("Text", ds, "MISMaster.RMItemId")
                myRpt.XrTableCell4.DataBindings.Add("Text", ds, "MISMaster.RMVI_NO")
                myRpt.XrTableCell10.DataBindings.Add("Text", ds, "MISMaster.UnitName")


                myRpt.XrLabel1.DataBindings.Add("Text", ds, "Company.CompanyName")
                'myRpt.XrLabel2.DataBindings.Add("Text", ds, "Company.City")

                myRpt.XrLabel5.DataBindings.Add("Text", ds, "MISMaster.MIS_NO")
                myRpt.XrLabel6.DataBindings.Add("Text", ds, "MISMaster.MIS_DATE")

                myRpt.XrLabel12.DataBindings.Add("Text", ds, "MISMaster.SFG_QTY")
                myRpt.XrLabel13.DataBindings.Add("Text", ds, "MISMaster.Draw_No")
                myRpt.XrLabel9.DataBindings.Add("Text", ds, "MISMaster.FGID")
                myRpt.XrLabel7.DataBindings.Add("Text", ds, "MISMaster.FGName")
                myRpt.xrlblReportTitle.Text = myRpt.xrlblReportTitle.Text + " (Semi Finish Good)"

                'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
                ''myrpt.PrintingSystem = printingSystem
                'myRpt.ShowPreview()

                Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
                printingSystem.ShowRibbonPreview()
                adp.Dispose()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub showSterilization()
        Try
            Dim myrpt As New rptFinalProduct
            Dim ds As New DataSet
            Dim Str As String
            Str = "SELECT FGMaster.FGName, FinishGoods_QCDetail.QC_No, FinishGoods_QCDetail.Batch_NO, FinishGoods_QCMaster.FGVI_NO,format(FinishGoods_QCMaster.VI_Date,'DD/MM/YYYY') AS VI_DATE, " _
                    & " FinishGoods_QCDetail.MIS_NO, FORMAT(Material_Issue_Master.MIS_DATE,'DD/MM/YYYY') AS MIS_DATE , FORMAT(FinishGoods_QCMaster.ST_Date,'DD/MM/YYYY') AS ST_DATE " _
                    & " FROM ((FinishGoods_QCMaster INNER JOIN FinishGoods_QCDetail ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO) INNER JOIN FGMaster ON FinishGoods_QCDetail.FID = FGMaster.FID) INNER JOIN Material_Issue_Master ON FinishGoods_QCDetail.MIS_NO = Material_Issue_Master.MIS_NO " _
                    & " WHERE FinishGoods_QCMaster.ST_Check=True and FinishGoods_QCMaster.ST_Date between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#"
            Dim adp As New OleDb.OleDbDataAdapter(Str, conn)

            adp.Fill(ds, "FinalProduct")

            adp.SelectCommand.CommandText = "Select * from companyMaster"
            adp.Fill(ds, "Company")

            myrpt.DataSource = ds.Tables(0)

            myrpt.XrTableCell5.DataBindings.Add("Text", ds.Tables(0), "FGName")
            myrpt.XrTableCell10.DataBindings.Add("Text", ds.Tables(0), "QC_No")
            myrpt.XrTableCell11.DataBindings.Add("Text", ds.Tables(0), "Batch_NO")
            myrpt.XrTableCell12.DataBindings.Add("Text", ds.Tables(0), "VI_Date")
            myrpt.XrTableCell13.DataBindings.Add("Text", ds.Tables(0), "FGVI_NO")
            myrpt.XrTableCell14.DataBindings.Add("Text", ds.Tables(0), "VI_Date")
            myrpt.XrTableCell15.DataBindings.Add("Text", ds.Tables(0), "MIS_NO")
            myrpt.XrTableCell16.DataBindings.Add("Text", ds.Tables(0), "MIS_DATE")
            myrpt.XrTableCell17.DataBindings.Add("Text", ds.Tables(0), "ST_DATE")
            myrpt.XrLabel2.DataBindings.Add("Text", ds, "Company.CompanyName")

            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Public Sub ShowMat_Req(ByVal strReqID As String)
        Try
            If strReqID Is Nothing OrElse strReqID.Trim = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Invalid Requisition No", "Requisition", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Dim myRpt As New rptMatIndentSlip
                Dim strSql As String
                Dim ds As New DataSet
                strSql = "SELECT FGMaster.FGName, REQMASTER.REQID,FORMAT(REQMASTER.REQDATE,'DD/MM/YYYY') AS RDATE, RMItemMaster.RMItemName, REQDETAIL.QTY,  REQMASTER.QTY AS FGQTY, REQMASTER.WORKORDERNO " _
                    & " FROM ((FGMaster INNER JOIN REQMASTER ON FGMaster.FID = REQMASTER.FID) INNER JOIN REQDETAIL ON REQMASTER.RQID = REQDETAIL.RQID) INNER JOIN RMItemMaster ON REQDETAIL.RID = RMItemMaster.Rid" _
                    & " GROUP BY FGMaster.FGName, REQMASTER.REQID,REQMASTER.REQDATE, RMItemMaster.RMItemName, REQDETAIL.QTY, REQMASTER.QTY,REQMASTER.WORKORDERNO  " _
                    & " HAVING (((REQMASTER.REQID)='" & strReqID.Trim & "))"

                Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
                adp.Fill(ds, "MIS")

                adp.SelectCommand.CommandText = "Select * from companyMaster"
                adp.Fill(ds, "Company")

                myRpt.DataSource = ds.Tables(0)
                myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "REQID"
                myRpt.XrTableCell1.DataBindings.Add("Text", ds, "MIS.RMItemName")
                myRpt.XrTableCell2.DataBindings.Add("Text", ds, "MIS.QTY")
                'myRpt.XrTableCell3.DataBindings.Add("Text", ds, "MIS.Qty")

                myRpt.XrLabel1.DataBindings.Add("Text", ds, "Company.CompanyName")
                myRpt.XrLabel2.DataBindings.Add("Text", ds, "Company.City")

                myRpt.XrLabel17.DataBindings.Add("Text", ds, "MIS.FGQTY")
                myRpt.XrLabel8.DataBindings.Add("Text", ds, "MIS.REqID")
                myRpt.XrLabel9.DataBindings.Add("Text", ds, "MIS.FGName")
                'myRpt.XrLabel10.DataBindings.Add("Text", ds, "MIS.CustCity")
                myRpt.XrLabel11.DataBindings.Add("Text", ds, "MIS.RDATE")
                myRpt.xrlblWorkOrderNoVal.DataBindings.Add("Text", ds, "MIS.WORKORDERNO")

                'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
                ''myrpt.PrintingSystem = printingSystem
                'myRpt.ShowPreview()
                Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
                printingSystem.ShowRibbonPreview()
                adp.Dispose()
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Public Sub ShowMat_Req_SEMI_Finish_Good(ByVal strReqID As String)
        Try
            If strReqID Is Nothing OrElse strReqID.Trim = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Invalid Requisition No", "Requisition", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Dim myRpt As New rptMatIndentSlip
                Dim strSql As String
                Dim ds As New DataSet

                strSql = "SELECT SemiFGMaster.FGName, SEMI_FG_REQMASTER.REQID,FORMAT(SEMI_FG_REQMASTER.REQDATE,'DD/MM/YYYY') AS RDATE, RMItemMaster.RMItemName, SEMI_FG_REQDETAIL.QTY,  SEMI_FG_REQMASTER.QTY AS FGQTY " _
                    & " FROM ((SemiFGMaster INNER JOIN SEMI_FG_REQMASTER ON SemiFGMaster.SFID = SEMI_FG_REQMASTER.SFID) INNER JOIN SEMI_FG_REQDETAIL ON SEMI_FG_REQMASTER.RQID = SEMI_FG_REQDETAIL.RQID) INNER JOIN RMItemMaster ON SEMI_FG_REQDETAIL.RID = RMItemMaster.Rid " _
                    & " GROUP BY SemiFGMaster.FGName, SEMI_FG_REQMASTER.REQID,SEMI_FG_REQMASTER.REQDATE, RMItemMaster.RMItemName, SEMI_FG_REQDETAIL.QTY, SEMI_FG_REQMASTER.QTY " _
                    & " HAVING (((SEMI_FG_REQMASTER.REQID)='" & strReqID.Trim & "))"

                'strSql = "SELECT SemiFGMaster.FGName, SEMI_FG_REQMASTER.REQID,FORMAT(SEMI_FG_REQMASTER.REQDATE,'DD/MM/YYYY') AS RDATE, RMItemMaster.RMItemName, SEMI_FG_REQDETAIL.QTY,  SEMI_FG_REQMASTER.QTY AS FGQTY " _
                '    & " FROM ((SemiFGMaster INNER JOIN SEMI_FG_REQMASTER ON SemiFGMaster.SFID = SEMI_FG_REQMASTER.SFID) INNER JOIN SEMI_FG_REQDETAIL ON SEMI_FG_REQMASTER.RQID = SEMI_FG_REQDETAIL.RQID) INNER JOIN SEMI_FG_REQMASTER ON SEMI_FG_REQDETAIL.RID = RMItemMaster.Rid" _
                '    & " GROUP BY SemiFGMaster.FGName, SEMI_FG_REQMASTER.REQID,SEMI_FG_REQMASTER.REQDATE, RMItemMaster.RMItemName, SEMI_FG_REQDETAIL.QTY, SEMI_FG_REQMASTER.QTY " _
                '    & " HAVING (((SEMI_FG_REQMASTER.REQID)='" & strReqID.Trim & "))"

                Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
                adp.Fill(ds, "MIS")

                adp.SelectCommand.CommandText = "Select * from companyMaster"
                adp.Fill(ds, "Company")

                myRpt.DataSource = ds.Tables(0)
                myRpt.XrLabel6.Text = "Semi Finish Good:"
                myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "REQID"
                myRpt.XrTableCell1.DataBindings.Add("Text", ds, "MIS.RMItemName")
                myRpt.XrTableCell2.DataBindings.Add("Text", ds, "MIS.QTY")
                'myRpt.XrTableCell3.DataBindings.Add("Text", ds, "MIS.Qty")

                myRpt.XrLabel1.DataBindings.Add("Text", ds, "Company.CompanyName")
                myRpt.XrLabel2.DataBindings.Add("Text", ds, "Company.City")

                myRpt.XrLabel17.DataBindings.Add("Text", ds, "MIS.FGQTY")
                myRpt.XrLabel8.DataBindings.Add("Text", ds, "MIS.REqID")
                myRpt.XrLabel9.DataBindings.Add("Text", ds, "MIS.FGName")
                'myRpt.XrLabel10.DataBindings.Add("Text", ds, "MIS.CustCity")
                myRpt.XrLabel11.DataBindings.Add("Text", ds, "MIS.RDATE")

                'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
                ''myrpt.PrintingSystem = printingSystem
                'myRpt.ShowPreview()
                Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
                printingSystem.ShowRibbonPreview()
                adp.Dispose()
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Public Sub showDemoIssue(ByVal strDemoIssue As String)
        Try
            If strDemoIssue Is Nothing Or strDemoIssue.Trim = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Invalid Demo Issue ID", "Demo Issue", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim myRpt As New rptDemoIssue
                Dim strSql As String
                Dim ds As New DataSet

                strSql = "SELECT JW_ISSUE_Master.JWID, format(JW_ISSUE_Master.JWDATE,'DD/MM/YYYY') AS JWDATE, JW_ISSUE_Master.JW_Name, JW_ISSUE_Master.CY, FGMaster.FGName, UnitMaster.UnitName, JW_ISSUE_DET.BATCH_NO, JW_ISSUE_DET.QTY" _
                    & " FROM ((JW_ISSUE_Master INNER JOIN JW_ISSUE_DET ON JW_ISSUE_Master.JID = JW_ISSUE_DET.JID) INNER JOIN FGMaster ON JW_ISSUE_DET.FID = FGMaster.FID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID " _
                    & " WHERE (((JW_ISSUE_Master.JWID)='" & strDemoIssue.Trim & "')) and JW_Issue_Master.CY ='" & strCY.Trim & "';"

                Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
                adp.Fill(ds, "DemoIssue")

                adp.SelectCommand.CommandText = "Select *, (Add1 + ',' + Add2 + ',' + City + ',' + State + ',' + Pincode + ',' + country +' Phone: ' + phone + ', Fax: ' + fax ) as Address from companyMaster"
                adp.Fill(ds, "Company")

                myRpt.DataSource = ds.Tables(0)

                myRpt.XrTableCell1.DataBindings.Add("Text", ds, "DemoIssue.FGName")
                myRpt.XrTableCell2.DataBindings.Add("Text", ds, "DemoIssue.BATCH_NO")
                myRpt.XrTableCell3.DataBindings.Add("Text", ds, "DemoIssue.UnitName")
                myRpt.XrTableCell4.DataBindings.Add("Text", ds, "DemoIssue.QTY")

                myRpt.XrLabel8.DataBindings.Add("Text", ds, "DemoIssue.JWID")
                myRpt.XrLabel15.DataBindings.Add("Text", ds, "DemoIssue.JWDATE")
                myRpt.XrLabel13.DataBindings.Add("Text", ds, "DemoIssue.JW_Name")


                myRpt.XrLabel10.DataBindings.Add("Text", ds, "Company.CompanyName")
                myRpt.XrLabel16.DataBindings.Add("Text", ds, "Company.Address")


                'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
                ''myrpt.PrintingSystem = printingSystem
                'myRpt.ShowPreview()
                Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
                printingSystem.ShowRibbonPreview()
                adp.Dispose()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub showDemoRet(ByVal strDemoRet As String)
        Try
            If strDemoRet Is Nothing Or strDemoRet.Trim = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Invalid Demo Return ID", "Demo Return", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim myRpt As New rptDemoRet
                Dim strSql As String
                Dim ds As New DataSet

                strSql = "SELECT JW_Ret_Master.JW_Ret_ID, format(JW_Ret_Master.JW_Ret_Dt,'DD/MM/YYYY') AS JW_RET_DT, JW_Ret_Master.JW_Issue_ID, FGMaster.FGName, UnitMaster.UnitName, JW_Ret_Det.Batch_No, JW_ISSUE_DET.QTY, JW_Ret_Det.Ret_Qty, JW_Ret_Master.CY " _
                    & " FROM JW_ISSUE_Master INNER JOIN ((((JW_Ret_Master INNER JOIN JW_Ret_Det ON JW_Ret_Master.ID = JW_Ret_Det.ID) INNER JOIN FGMaster ON JW_Ret_Det.FID = FGMaster.FID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN JW_ISSUE_DET ON JW_Ret_Det.FID = JW_ISSUE_DET.FID) ON (JW_ISSUE_Master.JWID = JW_Ret_Master.JW_Issue_ID) AND (JW_ISSUE_Master.JID = JW_ISSUE_DET.JID) " _
                    & " WHERE (((JW_Ret_Master.JW_Ret_ID)='" & strDemoRet.Trim & "') AND ((JW_Ret_Master.CY)='" & strCY.Trim & "')); "

                Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
                adp.Fill(ds, "DemoIssue")

                adp.SelectCommand.CommandText = "Select *, (Add1 + ',' + Add2 + ',' + City + ',' + State + ',' + Pincode + ',' + country +' Phone: ' + phone + ', Fax: ' + fax ) as Address from companyMaster"
                adp.Fill(ds, "Company")

                myRpt.DataSource = ds.Tables(0)

                myRpt.XrTableCell1.DataBindings.Add("Text", ds, "DemoIssue.FGName")
                myRpt.XrTableCell2.DataBindings.Add("Text", ds, "DemoIssue.BATCH_NO")
                myRpt.XrTableCell3.DataBindings.Add("Text", ds, "DemoIssue.QTY")
                myRpt.XrTableCell4.DataBindings.Add("Text", ds, "DemoIssue.Ret_Qty")

                myRpt.XrLabel8.DataBindings.Add("Text", ds, "DemoIssue.JW_Ret_ID")
                myRpt.XrLabel15.DataBindings.Add("Text", ds, "DemoIssue.JW_RET_DT")
                myRpt.XrLabel13.DataBindings.Add("Text", ds, "DemoIssue.JW_Issue_ID")


                myRpt.XrLabel10.DataBindings.Add("Text", ds, "Company.CompanyName")
                myRpt.XrLabel16.DataBindings.Add("Text", ds, "Company.Address")


                'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
                ''myrpt.PrintingSystem = printingSystem
                'myRpt.ShowPreview()
                Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
                printingSystem.ShowRibbonPreview()
                adp.Dispose()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub showGoodsRet(ByVal strRetNo As String)
        Try
            If strRetNo = Nothing Or strRetNo = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Invalid Goods Return ID", "Demo Return", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim myRpt As New rptGoodsRet
                Dim strSql As String
                Dim ds As New DataSet

                strSql = "SELECT FG_Ret_Master.RetNo, FG_Ret_Master.RetDate, FG_Ret_Master.Challan_No, FG_Ret_Master.Challan_Dt, CustomerMaster.CustName, FGMaster.FGName, UnitMaster.UnitName, FG_Ret_Det.BatchID, FG_Ret_Det.Ret_Qty, FG_Ret_Master.CY " _
                    & " FROM (((FG_Ret_Master INNER JOIN FG_Ret_Det ON FG_Ret_Master.RetNo = FG_Ret_Det.RetNo) INNER JOIN FGMaster ON FG_Ret_Det.FID = FGMaster.FID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN CustomerMaster ON FG_Ret_Master.CID = CustomerMaster.CID " _
                    & " WHERE (((FG_Ret_Master.RetNo)= '" & strRetNo & "'))" 'AND ((FG_Ret_Master.CY)='" & strCY.Trim & "'));"


                Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
                adp.Fill(ds, "GoodsRet")

                adp.SelectCommand.CommandText = "Select *, (Add1 + ',' + Add2 + ',' + City + ',' + State + ',' + Pincode + ',' + country +' Phone: ' + phone + ', Fax: ' + fax ) as Address from companyMaster"
                adp.Fill(ds, "Company")

                myRpt.DataSource = ds.Tables(0)

                myRpt.XrTableCell1.DataBindings.Add("Text", ds, "GoodsRet.FGName")
                myRpt.XrTableCell2.DataBindings.Add("Text", ds, "GoodsRet.BatchID")
                myRpt.XrTableCell3.DataBindings.Add("Text", ds, "GoodsRet.UnitName")
                myRpt.XrTableCell4.DataBindings.Add("Text", ds, "GoodsRet.Ret_Qty")

                myRpt.XrLabel8.DataBindings.Add("Text", ds, "GoodsRet.RetNo")
                myRpt.XrLabel15.DataBindings.Add("Text", ds, "GoodsRet.RetDate")
                myRpt.XrLabel9.DataBindings.Add("Text", ds, "GoodsRet.Challan_No")
                myRpt.XrLabel18.DataBindings.Add("Text", ds, "GoodsRet.Challan_Dt")
                myRpt.XrLabel13.DataBindings.Add("Text", ds, "GoodsRet.CustName")


                myRpt.XrLabel10.DataBindings.Add("Text", ds, "Company.CompanyName")
                myRpt.XrLabel16.DataBindings.Add("Text", ds, "Company.Address")


                'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
                ''myrpt.PrintingSystem = printingSystem
                'myRpt.ShowPreview()
                Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
                printingSystem.ShowRibbonPreview()
                adp.Dispose()
            End If
        Catch ex As Exception
            ModMain.Logs.ErrorMessage = ex.Message
            ModMain.Logs.Details = ex.ToString
            ModMain.Logs.Method = "frmPara.showGoodsRet"
            Logger.WriteLog(ModMain.Logs)
        End Try
    End Sub
    Public Sub ShowChallan(ByVal strChallanID As String)
        Try
            If strChallanID Is Nothing Or String.IsNullOrEmpty(strChallanID) Then
                DevExpress.XtraEditors.XtraMessageBox.Show("Invalid Challan No", "Challan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                Dim myRpt As New rptChallan
                Dim strSql As String
                Dim ds As New DataSet
                'strSql = "SELECT CustomerMaster.CustName, CustomerMaster.CustADD, CustomerMaster.CustCity, CustomerMaster.CustPin,CustomerMaster.DLNO , " _
                '    & " ChallanMaster.Challan_No, format(ChallanMaster.Challan_dt,'DD/MM/YYYY') as Challan_dt, ChallanMaster.Order_No, format(ChallanMaster.Order_Date,'DD/MM/YYYY') As Order_Date, ChallanMaster.M_Of_Des, " _
                '    & " FORMAT(ChallanMaster.Des_Date,'DD/MM/YYYY') as Des_Date, FGMaster.FGName,FGMaster.ExpirationPeriod, ChallanDetail.BatchID, ChallanDetail.Qty, ChallanDetail.Rate, ChallanDetail.Remarks," _
                '    & " FORMAT(FinishGoods_QCDetail.MFG_Date,'DD/MM/YYYY') as MFG_Date, FORMAT(FinishGoods_QCDetail.Exp_Date,'DD/MM/YYYY') as Exp_Date" _
                '    & " FROM ((ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN (ChallanDetail INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID) ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) LEFT JOIN FinishGoods_QCDetail ON (ChallanDetail.FID = FinishGoods_QCDetail.FID) AND (ChallanDetail.BatchID = FinishGoods_QCDetail.FGVI_NO)" _
                '    & " WHERE (((ChallanMaster.Challan_No)='" & strChallanID.Trim & "))"

                strSql = "SELECT CustomerMaster.CustName, CustomerMaster.CustADD, CustomerMaster.CustCity, CustomerMaster.CustPin,CustomerMaster.DLNO , " _
                   & " ChallanMaster.Challan_No, format(ChallanMaster.Challan_dt,'DD/MM/YYYY') as Challan_dt, ChallanMaster.Order_No, format(ChallanMaster.Order_Date,'DD/MM/YYYY') As Order_Date, ChallanMaster.M_Of_Des, " _
                   & " FORMAT(ChallanMaster.Des_Date,'DD/MM/YYYY') as Des_Date, FGMaster.FGName,FGMaster.ExpirationPeriod, ChallanDetail.BatchID, ChallanDetail.Qty, ChallanDetail.Rate, ChallanDetail.Remarks" _
                   & " FROM ((ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN CustomerMaster " _
                   & " ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID" _
                   & " WHERE (((ChallanMaster.Challan_No)='" & strChallanID.Trim & "))"


                Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
                adp.Fill(ds, "Challan")

                ds.Tables("Challan").Columns.Add("Mfg_Date")
                ds.Tables("Challan").Columns.Add("Exp_Date")

                For i As Integer = 0 To ds.Tables("Challan").Rows.Count - 1
                    strSql = "SELECT FinishGoods_QCDetail.MFG_Date, FinishGoods_QCDetail.Exp_Date " _
                        & " FROM FGMaster INNER JOIN FinishGoods_QCDetail ON FGMaster.FID = FinishGoods_QCDetail.FID " _
                        & " WHERE (((FGMaster.FGName)='" & ds.Tables("Challan").Rows(i).Item("FGName") & "') AND ((FinishGoods_QCDetail.Batch_NO)='" & ds.Tables("Challan").Rows(i).Item("BatchID") & "'));"
                    adp.SelectCommand.CommandText = strSql
                    adp.Fill(ds, "Temp_FG_QC_Det")
                    If (ds.Tables("Temp_FG_QC_Det").Rows.Count > 0) Then
                        If (ds.Tables("Temp_FG_QC_Det").Rows(0).Item("Mfg_Date").ToString() = "30/12/1899 00:00:00") Then
                            ds.Tables("Challan").Rows(i).Item("Mfg_Date") = ""
                        Else
                            ds.Tables("Challan").Rows(i).Item("Mfg_Date") = Format(ds.Tables("Temp_FG_QC_Det").Rows(0).Item("MFG_Date"), "MM/yyyy")
                        End If

                        If (ds.Tables("Temp_FG_QC_Det").Rows(0).Item("Exp_Date").ToString() = "30/12/1899 00:00:00") Then
                            ds.Tables("Challan").Rows(i).Item("Exp_Date") = ""
                        Else
                            ds.Tables("Challan").Rows(i).Item("Exp_Date") = Format(ds.Tables("Temp_FG_QC_Det").Rows(0).Item("Exp_Date"), "MM/yyyy")
                        End If

                        ds.Tables("Challan").AcceptChanges()
                    End If
                    ds.Tables.Remove("Temp_FG_QC_Det")
                Next


                adp.SelectCommand.CommandText = "Select *, (Add1 + ',' + Add2 + ',' + City + ',' + State + ',' + Pincode + ',' + country +' Phone: ' + phone + ', Fax: ' + fax +', CST: ' + CST + ',GST: ' + GST ) as Address,('MFG.D.L.No: ' + DLNO) as DLNO,('Excise Registration Number: ' + EX_REG_NO) as EX_REG_NO from companyMaster"
                adp.Fill(ds, "Company")

                myRpt.DataSource = ds.Tables(0)
                myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "Challan_No"
                myRpt.XrTableCell1.DataBindings.Add("Text", ds, "Challan.FGName")
                myRpt.XrTableCell2.DataBindings.Add("Text", ds, "Challan.BatchID")
                myRpt.XrTableCell3.DataBindings.Add("Text", ds, "Challan.Qty")
                myRpt.XrTableCell4.DataBindings.Add("Text", ds, "Challan.Rate")
                myRpt.XrTableCellMfgDate.DataBindings.Add("Text", ds, "Challan.Mfg_Date")
                myRpt.XrTableCellExpDate.DataBindings.Add("Text", ds, "Challan.Exp_Date")
                myRpt.XrTableCell5.DataBindings.Add("Text", ds, "Challan.Remarks")
                'myRpt.XrTableCellExpDate.DataBindings.Add("Text", ds, "Challan.ExpirationPeriod")

                myRpt.XrLabel12.DataBindings.Add("Text", ds, "Challan.CustName")
                myRpt.XrLabel13.DataBindings.Add("Text", ds, "Challan.CustAdd")
                myRpt.XrLabel14.DataBindings.Add("Text", ds, "Challan.CustCity")
                myRpt.XrLabel15.DataBindings.Add("Text", ds, "Challan.CustPin")
                myRpt.XrLabel33.DataBindings.Add("Text", ds, "Challan.DLNO")

                myRpt.XrLabel17.DataBindings.Add("Text", ds, "Challan.Challan_No")
                myRpt.XrLabel24.DataBindings.Add("Text", ds, "Challan.Challan_dt")
                myRpt.XrLabel23.DataBindings.Add("Text", ds, "Challan.Order_No")
                myRpt.XrLabel25.DataBindings.Add("Text", ds, "Challan.Order_Date")
                myRpt.XrLabel26.DataBindings.Add("Text", ds, "Challan.M_Of_Des")
                myRpt.XrLabel27.DataBindings.Add("Text", ds, "Challan.Des_Date")
                myRpt.XrLabel28.DataBindings.Add("Text", ds, "Company.CompanyName")
                myRpt.XrLabel29.DataBindings.Add("Text", ds, "Company.CompanyName")
                myRpt.XrLabel30.DataBindings.Add("Text", ds, "Company.Address")
                myRpt.XrLabel31.DataBindings.Add("Text", ds, "Company.DLNO")
                myRpt.xrlblExRegNoVal.DataBindings.Add("Text", ds, "Company.EX_REG_NO")


                'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
                ''myrpt.PrintingSystem = printingSystem
                'myRpt.ShowPreview()
                Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
                printingSystem.ShowRibbonPreview()
                adp.Dispose()
            End If
        Catch ex As Exception
            ModMain.Logs.ErrorMessage = ex.Message
            ModMain.Logs.Details = ex.ToString
            ModMain.Logs.Method = "frmPara.ShowChallan"
            Logger.WriteLog(ModMain.Logs)
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Public Sub showRMList(ByVal strGroupid As String)
        Try
            Dim myRpt As New rptRMITEMLIST
            Dim strSql As String
            Dim ds As New DataSet
            If Not strGroupid Is Nothing OrElse strGroupid <> "" Then
                strSql = "SELECT RMItemMaster.RMItemId, RMItemMaster.RMItemName, GroupMaster.GroupName, UnitMaster.UnitName, RMItemMaster.DrawNo, RMItemMaster.ModNo, RMItemMaster.ROL, RMItemMaster.Min_qty, RMItemMaster.Notes" _
                    & " FROM (RMItemMaster INNER JOIN GroupMaster ON RMItemMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID " _
                    & " WHERE (((RMItemMaster.GroupID)='" & strGroupid & "')) order by RMItemMaster.RMItemName "
            Else
                strSql = "SELECT RMItemMaster.RMItemId, RMItemMaster.RMItemName, GroupMaster.GroupName, UnitMaster.UnitName, " _
                    & " RMItemMaster.DrawNo, RMItemMaster.ModNo, RMItemMaster.ROL, RMItemMaster.Min_qty, RMItemMaster.Notes" _
                    & " FROM (RMItemMaster INNER JOIN GroupMaster ON RMItemMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID order by RMItemMaster.RMItemName "
            End If

            Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
            adp.Fill(ds, "RMSList")


            adp.SelectCommand.CommandText = "Select CompanyName from companyMaster"
            adp.Fill(ds, "Company")


            myRpt.DataSource = ds
            myRpt.XrTableCell1.DataBindings.Add("Text", ds, "RMSList.RMItemId")
            myRpt.XrTableCell2.DataBindings.Add("Text", ds, "RMSList.RMItemName")
            myRpt.XrTableCell3.DataBindings.Add("Text", ds, "RMSList.UnitName")
            myRpt.XrTableCell4.DataBindings.Add("Text", ds, "RMSList.DrawNo")
            myRpt.XrTableCell5.DataBindings.Add("Text", ds, "RMSList.ModNo")
            myRpt.XrTableCell6.DataBindings.Add("Text", ds, "RMSList.ROL")
            myRpt.XrTableCell7.DataBindings.Add("Text", ds, "RMSList.Min_Qty")
            myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "GroupName"
            myRpt.XrLabel1.DataBindings.Add("Text", ds, "RMSList.GroupName")

            myRpt.XrLabel10.DataBindings.Add("Text", ds, "Company.CompanyName")
            'myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "RMSList.GroupName"
            'myRpt.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMSList.Min_Qty", "")})

            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            'myRpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()
        Catch ex As Exception
            ModMain.Logs.ErrorMessage = ex.Message
            ModMain.Logs.Details = ex.ToString
            ModMain.Logs.Method = "frmPara.showRMList"
            Logger.WriteLog(ModMain.Logs)
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Public Sub showMISRejectionReport(ByVal strID As String)
        Try
            Dim myRpt As New rptMISRejectionComponent
            Dim strSql As String
            Dim ds As New DataSet
         
            strSql = "SELECT MIS_Return_Master.ID, MIS_Return_Master.MIS_NO, Material_Issue_Master.MIS_DATE, Material_Issue_Master.FG_QTY," & _
                " MIS_Return_Master.Return_Date, " & _
                " FGMaster.FGName, RMItemMaster.RMItemName AS Product, MIS_Return_Detail.Type, MIS_Return_Detail.RMVI_NO, MIS_Return_Detail.Qty " & _
                ", REQMASTER.WORKORDERNO " & _
                " FROM ((MIS_Return_Detail INNER JOIN RMItemMaster ON MIS_Return_Detail.RID = RMItemMaster.Rid) " & _
                " INNER JOIN ((MIS_Return_Master INNER JOIN Material_Issue_Master ON MIS_Return_Master.MIS_NO = Material_Issue_Master.MIS_NO) " & _
                " INNER JOIN FGMaster ON Material_Issue_Master.FGID = FGMaster.FID) ON MIS_Return_Detail.ReturnID = MIS_Return_Master.ID) " & _
                " INNER JOIN REQMASTER ON (REQMASTER.RQID = Material_Issue_Master.RQID) AND (FGMaster.FID = REQMASTER.FID)" & _
                " WHERE (((MIS_Return_Master.ID)=" & strID & "));"

            Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
            adp.Fill(ds, "MIS")

            strSql = "SELECT MIS_Return_Master.ID, MIS_Return_Master.MIS_NO, Material_Issue_Master.MIS_DATE, MIS_Return_Master.Return_Date," & _
                " FGMaster.FGName, SemiFGMaster.FGName as Product, MIS_Return_Detail.Type, MIS_Return_Detail.RMVI_NO, MIS_Return_Detail.Qty " & _
                " FROM (MIS_Return_Detail INNER JOIN SemiFGMaster ON MIS_Return_Detail.RID = SemiFGMaster.SFID) " & _
                " INNER JOIN ((MIS_Return_Master INNER JOIN Material_Issue_Master ON MIS_Return_Master.MIS_NO = Material_Issue_Master.MIS_NO) " & _
                " INNER JOIN FGMaster ON Material_Issue_Master.FGID = FGMaster.FID) ON MIS_Return_Detail.ReturnID = MIS_Return_Master.ID" & _
                " WHERE (((MIS_Return_Master.ID)=" & strID & "));"


            adp = New OleDb.OleDbDataAdapter(strSql, conn)
            Dim dtSemiFG As New DataTable
            adp.Fill(dtSemiFG)
            ds.Tables("MIS").Merge(dtSemiFG)

            myRpt.DataSource = ds.Tables("MIS")
            myRpt.lblFGVal.DataBindings.Add("Text", ds, "MIS.FGName")
            myRpt.lblMISDateVal.DataBindings.Add("Text", ds, "MIS.MIS_DATE")
            myRpt.lblMISNoVal.DataBindings.Add("Text", ds, "MIS.MIS_NO")
            myRpt.lblRetDateVal.DataBindings.Add("Text", ds, "MIS.Return_Date")
            myRpt.xrlblWOVal.DataBindings.Add("Text", ds, "MIS.WORKORDERNO")

            myRpt.xrTabCellID.DataBindings.Add("Text", ds, "MIS.ID")
            myRpt.xrTabCellName.DataBindings.Add("Text", ds, "MIS.Product")
            myRpt.xrTabCellBatchNo.DataBindings.Add("Text", ds, "MIS.RMVI_NO")
            myRpt.xrTabCellType.DataBindings.Add("Text", ds, "MIS.Type")
            myRpt.xrTabCellQty.DataBindings.Add("Text", ds, "MIS.Qty")
            myRpt.xrTabCellMisQtyVal.DataBindings.Add("Text", ds, "MIS.FG_QTY")
            myRpt.xrlblDateVal.Text = Now.Date

            'myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "RMSList.GroupName"
            'myRpt.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMSList.Min_Qty", "")})
            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            'myRpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()
        Catch ex As Exception
            ModMain.Logs.ErrorMessage = ex.Message
            ModMain.Logs.Details = ex.ToString
            ModMain.Logs.Method = "frmPara.ShowMISRejectionReport"
            Logger.WriteLog(ModMain.Logs)
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
    Public Sub showSemiMISRejectionReport(ByVal strID As String)
        Try
            Dim myRpt As New rptMISRejectionComponent
            Dim strSql As String
            Dim ds As New DataSet



            'strSql = "SELECT MIS_Return_Master.ID, MIS_Return_Master.MIS_NO, Material_Issue_Master.MIS_DATE, MIS_Return_Master.Return_Date," & _
            '    " FGMaster.FGName, SemiFGMaster.FGName as Product, MIS_Return_Detail.Type, MIS_Return_Detail.RMVI_NO, MIS_Return_Detail.Qty " & _
            '    " FROM (MIS_Return_Detail INNER JOIN SemiFGMaster ON MIS_Return_Detail.RID = SemiFGMaster.SFID) " & _
            '    " INNER JOIN ((MIS_Return_Master INNER JOIN Material_Issue_Master ON MIS_Return_Master.MIS_NO = Material_Issue_Master.MIS_NO) " & _
            '    " INNER JOIN FGMaster ON Material_Issue_Master.FGID = FGMaster.FID) ON MIS_Return_Detail.ReturnID = MIS_Return_Master.ID" & _
            '    " WHERE (((MIS_Return_Master.ID)=" & strID & "));"

            strSql = "SELECT Semi_MIS_Return_Master.ID, Semi_MIS_Return_Detail.MIS_NO, SemiFGMaster.FGName, " _
                & " SEMI_Material_Issue_Master.MIS_DATE,SEMI_Material_Issue_Master.SFG_QTY," & _
                " Semi_MIS_Return_Master.Return_Date, RMItemMaster.RMItemName as Product, Semi_MIS_Return_Detail.RMVI_NO, " & _
                " Semi_MIS_Return_Detail.Type, Semi_MIS_Return_Detail.Qty" & _
                " FROM SemiFGMaster INNER JOIN (((Semi_MIS_Return_Master INNER JOIN Semi_MIS_Return_Detail ON " & _
                " Semi_MIS_Return_Master.ID = Semi_MIS_Return_Detail.ReturnID) INNER JOIN SEMI_Material_Issue_Master ON " & _
                " Semi_MIS_Return_Master.MIS_NO = SEMI_Material_Issue_Master.MIS_NO) INNER JOIN RMItemMaster ON " & _
                " Semi_MIS_Return_Detail.RID = RMItemMaster.Rid) ON SemiFGMaster.SFID = SEMI_Material_Issue_Master.SFGID " & _
                " WHERE (((Semi_MIS_Return_Master.ID)=" & strID & "));"
            Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
            adp.Fill(ds, "MIS")


            myRpt.DataSource = ds.Tables("MIS")
            myRpt.lblFGVal.DataBindings.Add("Text", ds, "MIS.FGName")
            myRpt.lblMISDateVal.DataBindings.Add("Text", ds, "MIS.MIS_DATE")
            myRpt.lblMISNoVal.DataBindings.Add("Text", ds, "MIS.MIS_NO")
            myRpt.lblRetDateVal.DataBindings.Add("Text", ds, "MIS.Return_Date")

            myRpt.xrTabCellID.DataBindings.Add("Text", ds, "MIS.ID")
            myRpt.xrTabCellName.DataBindings.Add("Text", ds, "MIS.Product")
            myRpt.xrTabCellBatchNo.DataBindings.Add("Text", ds, "MIS.RMVI_NO")
            myRpt.xrTabCellType.DataBindings.Add("Text", ds, "MIS.Type")
            myRpt.xrTabCellQty.DataBindings.Add("Text", ds, "MIS.Qty")
            myRpt.xrTabCellMisQtyVal.DataBindings.Add("Text", ds, "MIS.SFG_QTY")
            myRpt.xrlblDateVal.Text = Now.Date

            'myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "RMSList.GroupName"
            'myRpt.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMSList.Min_Qty", "")})
            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            'myRpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()
        Catch ex As Exception
            ModMain.Logs.ErrorMessage = ex.Message
            ModMain.Logs.Details = ex.ToString
            ModMain.Logs.Method = "frmPara.ShowMISRejectionReport"
            Logger.WriteLog(ModMain.Logs)
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Public Sub showCustList(ByVal strGroupid As String)
        Try
            Dim myRpt As New XtraReport3
            Dim strSql As String
            Dim ds As New DataSet
            If Not strGroupid Is Nothing OrElse strGroupid <> "" Then
                strSql = "SELECT CustomerMaster.CustID, CustomerMaster.CustName, CustomerMaster.CustADD, CustomerMaster.CustCity, CustomerMaster.CustPin, CustomerMaster.CustPhone, CustomerMaster.CustMobile, " _
                    & " CustomerMaster.CustGSTno, CustomerMaster.CustCSTno, CustomerMaster.CustExno, GroupMaster.GroupName " _
                    & " FROM CustomerMaster INNER JOIN GroupMaster ON CustomerMaster.CustGRno = GroupMaster.GroupID " _
                    & " WHERE (((CustomerMaster.CustID)='" & strGroupid & "')) order by CustomerMaster.CustName"
            Else
                strSql = "SELECT CustomerMaster.CustID, CustomerMaster.CustName, CustomerMaster.CustADD, CustomerMaster.CustCity, " _
                    & " CustomerMaster.CustPin, CustomerMaster.CustPhone, CustomerMaster.CustMobile, " _
                    & " CustomerMaster.CustGSTno, CustomerMaster.CustCSTno, CustomerMaster.CustExno, GroupMaster.GroupName " _
                    & " FROM CustomerMaster INNER JOIN GroupMaster ON CustomerMaster.CustGRno = GroupMaster.GroupID order by CustomerMaster.CustName "
            End If

            Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
            adp.Fill(ds, "CustList")

            adp.SelectCommand.CommandText = "Select * from companyMaster"
            adp.Fill(ds, "Company")

            myRpt.DataSource = ds.Tables(0)
            myRpt.XrTableCell4.DataBindings.Add("Text", ds, "CustList.CustName")
            myRpt.XrTableCell3.DataBindings.Add("Text", ds, "CustList.GroupName")
            myRpt.XrTableCell8.DataBindings.Add("Text", ds, "CustList.CustAdd")
            myRpt.XrTableCell14.DataBindings.Add("Text", ds, "CustList.CustCity")
            myRpt.XrTableCell5.DataBindings.Add("Text", ds, "CustList.CustPin")
            myRpt.XrTableCell15.DataBindings.Add("Text", ds, "CustList.CustPhone")
            myRpt.XrTableCell16.DataBindings.Add("Text", ds, "CustList.CustMobile")
            myRpt.XrTableCell10.DataBindings.Add("Text", ds, "CustList.CustGSTno")
            myRpt.XrTableCell12.DataBindings.Add("Text", ds, "CustList.CustCSTno")
            myRpt.XrTableCell7.DataBindings.Add("Text", ds, "CustList.CustEXno")

            myRpt.XrLabel5.DataBindings.Add("Text", ds, "Company.CompanyName")


            'myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "RMSList.GroupName"
            'myRpt.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMSList.Min_Qty", "")})
            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            'myRpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()
        Catch ex As Exception
            ModMain.Logs.ErrorMessage = ex.Message
            ModMain.Logs.Details = ex.ToString
            ModMain.Logs.Method = "frmPara.showCustList"
            Logger.WriteLog(ModMain.Logs)
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Public Sub showSuppList(ByVal strGroupid As String)
        Try
            Dim myRpt As New XtraReport3
            Dim strSql As String
            Dim ds As New DataSet
            If Not strGroupid Is Nothing OrElse strGroupid <> "" Then
                strSql = "SELECT SupplierMaster.SuppID, SupplierMaster.SuppName, SupplierMaster.SuppADD, SupplierMaster.SuppCity, " _
                    & " SupplierMaster.SuppPin, SupplierMaster.SuppPhone, SupplierMaster.SuppMobile, " _
                    & " SupplierMaster.SuppGSTno, SupplierMaster.SuppCSTno, SupplierMaster.SuppExno, GroupMaster.GroupName " _
                    & " FROM SupplierMaster INNER JOIN GroupMaster ON SupplierMaster.SuppGRno = GroupMaster.GroupID " _
                    & " WHERE (((SupplierMaster.SuppID)='" & strGroupid & "')) order by  SupplierMaster.SuppName"
            Else
                strSql = "SELECT SupplierMaster.SuppID, SupplierMaster.SuppName, SupplierMaster.SuppADD, SupplierMaster.SuppCity, " _
                  & " SupplierMaster.SuppPin, SupplierMaster.SuppPhone, SupplierMaster.SuppMobile, " _
                  & " SupplierMaster.SuppGSTno, SupplierMaster.SuppCSTno, SupplierMaster.SuppExno, GroupMaster.GroupName " _
                  & " FROM SupplierMaster INNER JOIN GroupMaster ON SupplierMaster.SuppGRno = GroupMaster.GroupID order by SupplierMaster.SuppName "
            End If

            Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
            adp.Fill(ds, "SuppList")

            adp.SelectCommand.CommandText = "Select * from companyMaster"
            adp.Fill(ds, "Company")

            myRpt.DataSource = ds
            myRpt.XrTableCell4.DataBindings.Add("Text", ds, "SuppList.SuppName")
            myRpt.XrTableCell3.DataBindings.Add("Text", ds, "SuppList.GroupName")
            myRpt.XrTableCell8.DataBindings.Add("Text", ds, "SuppList.SuppAdd")
            myRpt.XrTableCell14.DataBindings.Add("Text", ds, "SuppList.SuppCity")
            myRpt.XrTableCell5.DataBindings.Add("Text", ds, "SuppList.SuppPin")
            myRpt.XrTableCell15.DataBindings.Add("Text", ds, "SuppList.SuppPhone")
            myRpt.XrTableCell16.DataBindings.Add("Text", ds, "SuppList.SuppMobile")
            myRpt.XrTableCell10.DataBindings.Add("Text", ds, "SuppList.SuppGSTno")
            myRpt.XrTableCell12.DataBindings.Add("Text", ds, "SuppList.SuppCSTno")
            myRpt.XrTableCell7.DataBindings.Add("Text", ds, "SuppList.SuppEXno")

            myRpt.XrLabel5.DataBindings.Add("Text", ds, "Company.CompanyName")
            myRpt.XrLabel1.Text = "List of Supplier"
            myRpt.XrLabel2.Text = Format(Now.Date, "dd/MM/yyyy")

            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            'myRpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()
            
        Catch ex As Exception
            ModMain.Logs.ErrorMessage = ex.Message
            ModMain.Logs.Details = ex.ToString
            ModMain.Logs.Method = "frmPara.ShowSuppList"
            Logger.WriteLog(ModMain.Logs)
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub


    Public Sub showFGList(ByVal strGroupid As String)
        Try
            Dim myRpt As New rptRMITEMLIST
            Dim strSql As String
            Dim ds As New DataSet
            If Not strGroupid Is Nothing OrElse strGroupid <> "" Then
                strSql = "SELECT FGMaster.FGId, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName, FGMaster.Draw_No as DrawNo, FGMaster.Model_No as ModNo, FGMaster.Min_qty, FGMaster.Notes" _
                    & " FROM (FGMaster INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON FGMaster.UnitId = UnitMaster.UnitID " _
                    & " WHERE (((FGMaster.GroupID)='" & strGroupid & "')) order by FGMaster.FGName"
            Else
                strSql = "SELECT FGMaster.FGId, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName, FGMaster.Draw_No as DrawNo, FGMaster.Model_No as ModNo, FGMaster.Min_qty, FGMaster.Notes" _
                  & " FROM (FGMaster INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON FGMaster.UnitId = UnitMaster.UnitID  order by FGMaster.FGName "
            End If

            Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
            adp.Fill(ds, "FGList")

            adp.SelectCommand.CommandText = "Select CompanyName from companyMaster"
            adp.Fill(ds, "Company")

            myRpt.DataSource = ds.Tables(0)
            myRpt.XrTableCell1.DataBindings.Add("Text", ds, "FGList.FGId")
            myRpt.XrTableCell2.DataBindings.Add("Text", ds, "FGList.FGName")
            myRpt.XrTableCell3.DataBindings.Add("Text", ds, "FGList.UnitName")
            myRpt.XrTableCell4.DataBindings.Add("Text", ds, "FGList.DrawNo")
            myRpt.XrTableCell5.DataBindings.Add("Text", ds, "FGList.ModNo")
            myRpt.XrTableCell6.DataBindings.Add("Text", ds, "FGList.Min_Qty")
            myRpt.XrTableCell7.DataBindings.Add("Text", ds, "FGList.Notes")
            myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "GroupName"
            myRpt.XrLabel1.DataBindings.Add("Text", ds, "FGList.GroupName")

            myRpt.XrLabel10.DataBindings.Add("Text", ds, "Company.CompanyName")

            myRpt.XrLabel2.Text = "Finish Good ID"
            myRpt.XrLabel3.Text = "Finish Good Name"

            myRpt.XrLabel7.Text = "Min Qty"
            myRpt.XrLabel8.Text = "Notes"

            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            'myRpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()
        Catch ex As Exception
            ModMain.Logs.ErrorMessage = ex.Message
            ModMain.Logs.Details = ex.ToString
            ModMain.Logs.Method = "frmPara.showFGList"
            Logger.WriteLog(ModMain.Logs)
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub showFGStockCons()
        Try
            Dim myRpt As New rptRMStock
            Dim cmd As OleDb.OleDbCommand
            Dim ds As New DataSet

            ds.Tables.Add("FGStock")
            ds.Tables(0).Columns.Add("FGName", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("Unit", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("TDate", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("GroupName", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("Batch_No", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("Type", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("Opn_Qty", System.Type.GetType("System.Double"))
            ds.Tables(0).Columns.Add("Rec_Qty", System.Type.GetType("System.Double"))
            ds.Tables(0).Columns.Add("Issue_Qty", System.Type.GetType("System.Double"))
            ds.Tables(0).Columns.Add("Ret_Qty", System.Type.GetType("System.Double"))
            ds.Tables(0).Columns.Add("Balance_Qty", System.Type.GetType("System.Double"))

            Dim adp As New OleDb.OleDbDataAdapter
            If strID = "" Then
                adp.SelectCommand = New OleDb.OleDbCommand
                adp.SelectCommand.Connection = conn

                adp.SelectCommand.CommandText = "SELECT FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName " _
                    & " FROM (FGMaster INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID " _
                    & " ORDER BY FGMaster.FID; "
                adp.Fill(ds, "FGMaster")
                For i As Integer = 0 To ds.Tables("FGMaster").Rows.Count - 1
                    Call FGSStockCalculation(ds.Tables("FGMaster").Rows(i))
                Next





                ' adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type, Sum(FGStock.Received_Qty) AS Opn_Qty, Sum(FGStock.Issue_Qty) AS Issue_Qty, " _
                '     & " Sum(FGStock.Ret_Qty) AS Ret_Qty, Sum(FGStock.Balance_Qty) AS Balance_Qty " _
                '     & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID " _
                '     & " WHERE (((FGStock.Date)<#" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "#))" _
                '     & " GROUP BY GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type " _
                '     & " HAVING(((Sum(FGStock.Balance_Qty)) > 0)) " _
                '     & " Order by FGMaster.FGName"
                ' adp.Fill(ds.Tables("FGStock"))

                ' adp.SelectCommand.CommandText = "Select "



                ' adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type, Sum(FGStock.Received_Qty) AS Rec_Qty, Sum(FGStock.Issue_Qty) AS Issue_Qty, Sum(FGStock.Ret_Qty) AS Ret_Qty, Sum(FGStock.Balance_Qty) AS Balance_Qty " _
                '     & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID " _
                '     & " WHERE (((FGStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                '     & " GROUP BY GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type " _
                '     & " HAVING(((FGStock.Type) = 'Opening')) " _
                '     & " ORDER BY FGMaster.FGName "

                ' adp.Fill(ds.Tables("FGStock"))

                ' adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type, Sum(FGStock.Received_Qty) AS Rec_Qty, Sum(FGStock.Issue_Qty) AS Issue_Qty, Sum(FGStock.Ret_Qty) AS Ret_Qty, Sum(FGStock.Balance_Qty) AS Balance_Qty " _
                ' & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID " _
                ' & " WHERE (((FGStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                ' & " GROUP BY GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type " _
                ' & " HAVING(((FGStock.Type) = 'Inward')) " _
                ' & " ORDER BY FGMaster.FGName "

                ' adp.Fill(ds.Tables("FGStock"))

                ' adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName,  Sum(FGStock.Issue_Qty) AS Issue_Qty, Sum(FGStock.Ret_Qty) AS Ret_Qty, Sum(FGStock.Balance_Qty) AS Balance_Qty " _
                '& " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID " _
                '& " WHERE (((FGStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                '& " GROUP BY GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type " _
                '& " HAVING(((FGStock.Type) = 'Return')) " _
                '& " ORDER BY FGMaster.FGName "

                ' adp.Fill(ds.Tables("FGStock"))
            Else

                adp.SelectCommand = New OleDb.OleDbCommand
                adp.SelectCommand.Connection = conn

                adp.SelectCommand.CommandText = "SELECT FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName " _
                    & " FROM (FGMaster INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID " _
                    & " where FGMaster.FGName ='" & strID & "' ORDER BY FGMaster.FID; "
                adp.Fill(ds, "FGMaster")
                For i As Integer = 0 To ds.Tables("FGMaster").Rows.Count - 1
                    Call FGSStockCalculation(ds.Tables("FGMaster").Rows(i))
                Next

                'adp.SelectCommand = New OleDb.OleDbCommand
                'adp.SelectCommand.Connection = conn

                'adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type, Sum(FGStock.Received_Qty) AS Opn_Qty, Sum(FGStock.Issue_Qty) AS Issue_Qty, " _
                '     & " Sum(FGStock.Ret_Qty) AS Ret_Qty, Sum(FGStock.Balance_Qty) AS Balance_Qty " _
                '     & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID " _
                '     & " WHERE (((FGStock.Date)<#" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "#))" _
                '     & " GROUP BY GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type " _
                '     & " HAVING(((Sum(FGStock.Balance_Qty)) > 0)) and FGMaster.FGName = '" & strID.Trim & "'" _
                '     & " Order by FGMaster.FGName"
                'adp.Fill(ds.Tables("FGStock"))

                'adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type, Sum(FGStock.Received_Qty) AS Rec_Qty, Sum(FGStock.Issue_Qty) AS Issue_Qty, Sum(FGStock.Ret_Qty) AS Ret_Qty, Sum(FGStock.Balance_Qty) AS Balance_Qty " _
                '    & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID " _
                '    & " WHERE (((FGStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                '    & " GROUP BY GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type " _
                '    & " HAVING(((FGStock.Type) = 'Opening')) and FGMaster.FGName = '" & strID.Trim & "'" _
                '    & " ORDER BY FGMaster.FGName "

                'adp.Fill(ds.Tables("FGStock"))

                'adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type, Sum(FGStock.Received_Qty) AS Rec_Qty, Sum(FGStock.Issue_Qty) AS Issue_Qty, Sum(FGStock.Ret_Qty) AS Ret_Qty, Sum(FGStock.Balance_Qty) AS Balance_Qty " _
                '& " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID " _
                '& " WHERE (((FGStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                '& " GROUP BY GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type " _
                '& " HAVING(((FGStock.Type) = 'Inward')) and FGMaster.FGName = '" & strID.Trim & "'" _
                '& " ORDER BY FGMaster.FGName "

                'adp.Fill(ds.Tables("FGStock"))

                'adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type, Sum(FGStock.Issue_Qty) AS Issue_Qty, Sum(FGStock.Ret_Qty) AS Ret_Qty, Sum(FGStock.Balance_Qty) AS Balance_Qty " _
                '    & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID " _
                '    & " WHERE (((FGStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                '    & " GROUP BY GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type " _
                '    & " HAVING(((FGStock.Type) = 'Return')) and FGMaster.FGName = '" & strID.Trim & "'" _
                '    & " ORDER BY FGMaster.FGName "

                'adp.Fill(ds.Tables("FGStock"))
            End If
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            'For i As Integer = 0 To ds.Tables("FGStock").Rows.Count - 1
            '    cmd.CommandText = "Insert into Temp_Cons values('" & Replace(ds.Tables(0).Rows(i).Item("FGName"), "'", "''") & "','" & ds.Tables(0).Rows(i).Item("UnitName") & "','" _
            '        & ds.Tables(0).Rows(i).Item("GroupName") & "','" & IIf(IsDBNull(ds.Tables(0).Rows(i).Item("Batch_No")), "", ds.Tables(0).Rows(i).Item("Batch_No")) & "','" & ds.Tables(0).Rows(i).Item("Type") & "'," _
            '         & IIf(IsDBNull(ds.Tables(0).Rows(i).Item("Opn_Qty")), 0, ds.Tables(0).Rows(i).Item("Opn_Qty")) & "," _
            '        & IIf(IsDBNull(ds.Tables(0).Rows(i).Item("Rec_Qty")), 0, ds.Tables(0).Rows(i).Item("Rec_Qty")) & "," _
            '        & IIf(IsDBNull(ds.Tables(0).Rows(i).Item("Issue_Qty")), 0, ds.Tables(0).Rows(i).Item("Issue_Qty")) & "," _
            '        & IIf(IsDBNull(ds.Tables(0).Rows(i).Item("Ret_Qty")), 0, ds.Tables(0).Rows(i).Item("Ret_Qty")) & "," _
            '        & IIf(IsDBNull(ds.Tables(0).Rows(i).Item("Balance_Qty")), 0, ds.Tables(0).Rows(i).Item("Balance_Qty")) & ")"
            '    cmd.ExecuteNonQuery()
            'Next
            'cmd.Dispose()
            'ds.Tables("FGStock").Rows.Clear()

            adp.SelectCommand.CommandText = "SELECT Temp_Cons.FGName, Temp_Cons.UnitName, Temp_Cons.GroupName, " _
                & " Temp_Cons.BatchNo, Sum(Temp_Cons.Opn_Qty) AS Opn_Qty, Sum(Temp_Cons.Rec_Qty) AS Rec_Qty, " _
                & " Sum(Temp_Cons.Issue_Qty) AS Issue_Qty, Sum(Temp_Cons.Ret_Qty) AS Ret_Qty, Sum(Temp_Cons.Balance_Qty) AS Balance_Qty" _
                & " FROM(Temp_Cons) GROUP BY Temp_Cons.FGName, Temp_Cons.UnitName, Temp_Cons.GroupName, Temp_Cons.BatchNo;"
            adp.Fill(ds, "FGStockCons")

            adp.SelectCommand.CommandText = "Select CompanyName from companyMaster"
            adp.Fill(ds, "Company")

            myRpt.DataSource = ds.Tables("FGStockCons")
            'myRpt.XrTableCell1.DataBindings.Add("Text", ds, "FGStock.TDate")
            myRpt.XrTableCell2.DataBindings.Add("Text", ds, "FGStockCons.FGName")
            myRpt.XrTableCell3.DataBindings.Add("Text", ds, "FGStockCons.UnitName")
            'myRpt.XrTableCell4.DataBindings.Add("Text", ds, "FGStock.Batch_No")
            myRpt.XrTableCell5.DataBindings.Add("Text", ds, "FGStockCons.Rec_Qty")
            myRpt.XrTableCell6.DataBindings.Add("Text", ds, "FGStockCons.Issue_Qty")
            myRpt.XrTableCell7.DataBindings.Add("Text", ds, "FGStockCons.Balance_Qty")
            myRpt.XrTableCell8.DataBindings.Add("Text", ds, "FGStockCons.Opn_Qty")
            myRpt.XrTableCell9.DataBindings.Add("Text", ds, "FGStockCons.Ret_Qty")


            myRpt.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "FGStockCons.Balance_Qty", "")})
            myRpt.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "FGStockCons.Issue_Qty", "")})
            myRpt.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "FGStockCons.Rec_Qty", "")})
            myRpt.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "FGStockCons.Ret_Qty", "")})
            myRpt.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "FGStockCons.Opn_Qty", "")})


            myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "GroupName"


            myRpt.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "FGStockCons.GroupName", "")})

            myRpt.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "Company.CompanyName")})
            'myRpt.XrLabel9.Summary.Func.Sum()
            myRpt.XrLabel1.Text = "Finish Goods Stock Statement"
            myRpt.XrLabel1.Text = myRpt.XrLabel1.Text & " Between " & Format(dtpFrom.EditValue, "dd/MM/yyyy") & " and " & Format(dtpTo.EditValue, "dd/MM/yyyy")
            myRpt.XrLabel4.Text = ""
            myRpt.XrLabel5.Text = ""
            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            'myRpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()

            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "Delete from Temp_Cons"
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        Catch ex As Exception
            ModMain.Logs.ErrorMessage = ex.Message
            ModMain.Logs.Details = ex.ToString
            ModMain.Logs.Method = "frmPara.showFGStockCons"
            Logger.WriteLog(ModMain.Logs)
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub ShowFGStockConslidated()
        Try
            Dim myRpt As New rptRMStock
            Dim cmd As OleDb.OleDbCommand
            Dim ds As New DataSet

            'ds.Tables.Add("FGStock")
            'ds.Tables(0).Columns.Add("FGName", System.Type.GetType("System.String"))
            'ds.Tables(0).Columns.Add("Unit", System.Type.GetType("System.String"))
            'ds.Tables(0).Columns.Add("TDate", System.Type.GetType("System.String"))
            'ds.Tables(0).Columns.Add("GroupName", System.Type.GetType("System.String"))
            'ds.Tables(0).Columns.Add("Batch_No", System.Type.GetType("System.String"))
            'ds.Tables(0).Columns.Add("Type", System.Type.GetType("System.String"))
            'ds.Tables(0).Columns.Add("Opn_Qty", System.Type.GetType("System.Double"))
            'ds.Tables(0).Columns.Add("Rec_Qty", System.Type.GetType("System.Double"))
            'ds.Tables(0).Columns.Add("Issue_Qty", System.Type.GetType("System.Double"))
            'ds.Tables(0).Columns.Add("Ret_Qty", System.Type.GetType("System.Double"))
            'ds.Tables(0).Columns.Add("Balance_Qty", System.Type.GetType("System.Double"))

            Dim adp As New OleDb.OleDbDataAdapter
            If strID = "" Then
                Dim DR As OleDb.OleDbDataReader
                cmd.Connection = conn
                cmd.CommandText = "Select FID from FGMaster order by FID"
                DR = cmd.ExecuteReader()

                adp.SelectCommand = New OleDb.OleDbCommand
                adp.SelectCommand.Connection = conn
                adp.SelectCommand.CommandText = "Select FID From FGMaster Order by FID"
                adp.Fill(ds, "FGMaster")

                For i As Integer = 0 To ds.Tables("FGMaster").Rows.Count - 1
                    FGSStockCalculation(ds.Tables("FGMaster").Rows(i).Item(0))
                Next


                adp.SelectCommand.CommandText = "SELECT FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName, Sum(FinishGoods_QCDetail.QC_No) AS SumOfQC_No" _
                 & " FROM FinishGoods_QCMaster INNER JOIN (((FGMaster INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN FinishGoods_QCDetail ON FGMaster.FID = FinishGoods_QCDetail.FID) ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO " _
                 & " WHERE (((FinishGoods_QCMaster.VI_Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                 & " GROUP BY FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName;"


                adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type, Sum(FGStock.Received_Qty) AS Rec_Qty, Sum(FGStock.Issue_Qty) AS Issue_Qty, Sum(FGStock.Ret_Qty) AS Ret_Qty, Sum(FGStock.Balance_Qty) AS Balance_Qty " _
                    & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID " _
                    & " WHERE (((FGStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                    & " GROUP BY GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type " _
                    & " HAVING(((FGStock.Type) = 'Opening')) " _
                    & " ORDER BY FGMaster.FGName "

                adp.Fill(ds.Tables("FGStock"))

                adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type, Sum(FGStock.Received_Qty) AS Rec_Qty, Sum(FGStock.Issue_Qty) AS Issue_Qty, Sum(FGStock.Ret_Qty) AS Ret_Qty, Sum(FGStock.Balance_Qty) AS Balance_Qty " _
                & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID " _
                & " WHERE (((FGStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                & " GROUP BY GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type " _
                & " HAVING(((FGStock.Type) = 'Inward')) " _
                & " ORDER BY FGMaster.FGName "

                adp.Fill(ds.Tables("FGStock"))

                adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName,  Sum(FGStock.Issue_Qty) AS Issue_Qty, Sum(FGStock.Ret_Qty) AS Ret_Qty, Sum(FGStock.Balance_Qty) AS Balance_Qty " _
               & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID " _
               & " WHERE (((FGStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
               & " GROUP BY GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type " _
               & " HAVING(((FGStock.Type) = 'Return')) " _
               & " ORDER BY FGMaster.FGName "

                adp.Fill(ds.Tables("FGStock"))
            Else
                adp.SelectCommand = New OleDb.OleDbCommand
                adp.SelectCommand.Connection = conn

                adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type, Sum(FGStock.Received_Qty) AS Opn_Qty, Sum(FGStock.Issue_Qty) AS Issue_Qty, " _
                     & " Sum(FGStock.Ret_Qty) AS Ret_Qty, Sum(FGStock.Balance_Qty) AS Balance_Qty " _
                     & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID " _
                     & " WHERE (((FGStock.Date)<#" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "#))" _
                     & " GROUP BY GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type " _
                     & " HAVING(((Sum(FGStock.Balance_Qty)) > 0)) and FGMaster.FGName = '" & strID.Trim & "'" _
                     & " Order by FGMaster.FGName"
                adp.Fill(ds.Tables("FGStock"))

                adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type, Sum(FGStock.Received_Qty) AS Rec_Qty, Sum(FGStock.Issue_Qty) AS Issue_Qty, Sum(FGStock.Ret_Qty) AS Ret_Qty, Sum(FGStock.Balance_Qty) AS Balance_Qty " _
                    & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID " _
                    & " WHERE (((FGStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                    & " GROUP BY GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type " _
                    & " HAVING(((FGStock.Type) = 'Opening')) and FGMaster.FGName = '" & strID.Trim & "'" _
                    & " ORDER BY FGMaster.FGName "

                adp.Fill(ds.Tables("FGStock"))

                adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type, Sum(FGStock.Received_Qty) AS Rec_Qty, Sum(FGStock.Issue_Qty) AS Issue_Qty, Sum(FGStock.Ret_Qty) AS Ret_Qty, Sum(FGStock.Balance_Qty) AS Balance_Qty " _
                & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID " _
                & " WHERE (((FGStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                & " GROUP BY GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type " _
                & " HAVING(((FGStock.Type) = 'Inward')) and FGMaster.FGName = '" & strID.Trim & "'" _
                & " ORDER BY FGMaster.FGName "

                adp.Fill(ds.Tables("FGStock"))

                adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type, Sum(FGStock.Issue_Qty) AS Issue_Qty, Sum(FGStock.Ret_Qty) AS Ret_Qty, Sum(FGStock.Balance_Qty) AS Balance_Qty " _
                    & " FROM ((FGMaster INNER JOIN FGStock ON FGMaster.FID = FGStock.FID) INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID " _
                    & " WHERE (((FGStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) " _
                    & " GROUP BY GroupMaster.GroupName, FGMaster.FGName, UnitMaster.UnitName, FGStock.Type " _
                    & " HAVING(((FGStock.Type) = 'Return')) and FGMaster.FGName = '" & strID.Trim & "'" _
                    & " ORDER BY FGMaster.FGName "

                adp.Fill(ds.Tables("FGStock"))
            End If
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            For i As Integer = 0 To ds.Tables("FGStock").Rows.Count - 1
                cmd.CommandText = "Insert into Temp_Cons values('" & Replace(ds.Tables(0).Rows(i).Item("FGName"), "'", "''") & "','" & ds.Tables(0).Rows(i).Item("UnitName") & "','" _
                    & ds.Tables(0).Rows(i).Item("GroupName") & "','" & IIf(IsDBNull(ds.Tables(0).Rows(i).Item("Batch_No")), "", ds.Tables(0).Rows(i).Item("Batch_No")) & "','" & ds.Tables(0).Rows(i).Item("Type") & "'," _
                     & IIf(IsDBNull(ds.Tables(0).Rows(i).Item("Opn_Qty")), 0, ds.Tables(0).Rows(i).Item("Opn_Qty")) & "," _
                    & IIf(IsDBNull(ds.Tables(0).Rows(i).Item("Rec_Qty")), 0, ds.Tables(0).Rows(i).Item("Rec_Qty")) & "," _
                    & IIf(IsDBNull(ds.Tables(0).Rows(i).Item("Issue_Qty")), 0, ds.Tables(0).Rows(i).Item("Issue_Qty")) & "," _
                    & IIf(IsDBNull(ds.Tables(0).Rows(i).Item("Ret_Qty")), 0, ds.Tables(0).Rows(i).Item("Ret_Qty")) & "," _
                    & IIf(IsDBNull(ds.Tables(0).Rows(i).Item("Balance_Qty")), 0, ds.Tables(0).Rows(i).Item("Balance_Qty")) & ")"
                cmd.ExecuteNonQuery()
            Next
            cmd.Dispose()
            ds.Tables("FGStock").Rows.Clear()


            adp.SelectCommand.CommandText = "SELECT Temp_Cons.FGName, Temp_Cons.UnitName, Temp_Cons.GroupName, " _
                & " Temp_Cons.BatchNo, Sum(Temp_Cons.Opn_Qty) AS Opn_Qty, Sum(Temp_Cons.Rec_Qty) AS Rec_Qty, " _
                & " Sum(Temp_Cons.Issue_Qty) AS Issue_Qty, Sum(Temp_Cons.Ret_Qty) AS Ret_Qty, Sum(Temp_Cons.Balance_Qty) AS Balance_Qty" _
                & " FROM(Temp_Cons) GROUP BY Temp_Cons.FGName, Temp_Cons.UnitName, Temp_Cons.GroupName, Temp_Cons.BatchNo;"
            adp.Fill(ds, "FGStockCons")

            adp.SelectCommand.CommandText = "Select CompanyName from companyMaster"
            adp.Fill(ds, "Company")

            myRpt.DataSource = ds.Tables("FGStockCons")
            'myRpt.XrTableCell1.DataBindings.Add("Text", ds, "FGStock.TDate")
            myRpt.XrTableCell2.DataBindings.Add("Text", ds, "FGStockCons.FGName")
            myRpt.XrTableCell3.DataBindings.Add("Text", ds, "FGStockCons.UnitName")
            'myRpt.XrTableCell4.DataBindings.Add("Text", ds, "FGStock.Batch_No")
            myRpt.XrTableCell5.DataBindings.Add("Text", ds, "FGStockCons.Rec_Qty")
            myRpt.XrTableCell6.DataBindings.Add("Text", ds, "FGStockCons.Issue_Qty")
            myRpt.XrTableCell7.DataBindings.Add("Text", ds, "FGStockCons.Balance_Qty")
            myRpt.XrTableCell8.DataBindings.Add("Text", ds, "FGStockCons.Opn_Qty")
            myRpt.XrTableCell9.DataBindings.Add("Text", ds, "FGStockCons.Ret_Qty")


            myRpt.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "FGStockCons.Balance_Qty", "")})
            myRpt.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "FGStockCons.Issue_Qty", "")})
            myRpt.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "FGStockCons.Rec_Qty", "")})
            myRpt.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "FGStockCons.Ret_Qty", "")})
            myRpt.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "FGStockCons.Opn_Qty", "")})


            myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "GroupName"


            myRpt.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "FGStockCons.GroupName", "")})

            myRpt.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "Company.CompanyName")})
            'myRpt.XrLabel9.Summary.Func.Sum()
            myRpt.XrLabel1.Text = "Finish Goods Stock Statement"
            myRpt.XrLabel1.Text = myRpt.XrLabel1.Text & " Between " & Format(dtpFrom.EditValue, "dd/MM/yyyy") & " and " & Format(dtpTo.EditValue, "dd/MM/yyyy")
            myRpt.XrLabel4.Text = ""
            myRpt.XrLabel5.Text = ""
            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            'myRpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()

            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "Delete from Temp_Cons"
            cmd.ExecuteNonQuery()
            cmd.Dispose()

        Catch ex As Exception
            ModMain.Logs.ErrorMessage = ex.Message
            ModMain.Logs.Details = ex.ToString
            ModMain.Logs.Method = "frmPara.ShowFGStockConsolidated"
            Logger.WriteLog(ModMain.Logs)
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub FGSStockCalculation(ByVal DRFG As DataRow)
        Dim cmd As New OleDb.OleDbCommand
        Dim DR As OleDb.OleDbDataReader
        Try
            Dim strFID As String
            Dim opStock As Double
            Dim RecStock As Double
            Dim IssStock As Double
            Dim RetStock As Double
            strFID = DRFG.Item("FID")
            '****************************************************************************
            '           CALCULATION OF OPENING STOCK
            '****************************************************************************

            cmd.Connection = conn

            'Opening Stock 
            cmd.CommandText = "SELECT FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName, Sum(FG_Opening_Stock.Opening_Qty) AS SumOfOpening_Qty " _
                & " FROM ((FGMaster INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN FG_Opening_Stock ON (UnitMaster.UnitID = FG_Opening_Stock.UnitID) AND (FGMaster.FID = FG_Opening_Stock.FID) " _
                & " WHERE(((FG_Opening_Stock.Register_Date) < #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "#)) " _
                & " GROUP BY FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName " _
                & " HAVING (((FGMaster.FID)='" & strFID & "'));"

            DR = cmd.ExecuteReader
            Do While DR.Read
                opStock = DR.Item("SumOfOpening_Qty")
            Loop
            DR.Close()

            'Goods Receive
            cmd.CommandText = "SELECT FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName, Sum(FinishGoods_QCDetail.QC_No) AS SumOfQC_No" _
                & " FROM FinishGoods_QCMaster INNER JOIN (((FGMaster INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN FinishGoods_QCDetail ON FGMaster.FID = FinishGoods_QCDetail.FID) ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO " _
                & " WHERE (((FinishGoods_QCMaster.VI_Date) < #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "#))" _
                & " GROUP BY FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName " _
                & " HAVING (((FGMaster.FID)='" & strFID & "'));"
            DR = cmd.ExecuteReader
            Do While DR.Read
                RecStock = DR.Item("SumOfQC_No")
            Loop
            DR.Close()

            'Goods Received through Inward Trading
            cmd.CommandText = "SELECT FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName, Sum(TI_Rec_Det.QTY) AS SumOfQTY " _
                & " FROM ((FGMaster INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN (TI_Rec_Master INNER JOIN TI_Rec_Det ON TI_Rec_Master.RecID = TI_Rec_Det.RecID) ON FGMaster.FID = TI_Rec_Det.FID " _
                & " WHERE(((TI_Rec_Master.RecDate)  < #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "#))" _
                & " GROUP BY FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName " _
                & " HAVING (((FGMaster.FID)='" & strFID & "'));"

            DR = cmd.ExecuteReader
            Do While DR.Read
                RecStock = RecStock + DR.Item("SumOfQTY")
            Loop
            DR.Close()


            'ISSUE QTY (CHALLAN)
            cmd.CommandText = "SELECT FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName, Sum(ChallanDetail.Qty) AS SumOfQty " _
                & " FROM ((FGMaster INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN (ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) ON FGMaster.FID = ChallanDetail.FID " _
                & " WHERE(((ChallanMaster.Challan_dt) < #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "#)) " _
                & " GROUP BY FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName " _
                & " HAVING (((FGMaster.FID)='" & strFID & "'));"
            DR = cmd.ExecuteReader
            Do While DR.Read
                IssStock = DR.Item("SumOfQty")
            Loop
            DR.Close()

            'Return Qty
            cmd.CommandText = "SELECT FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName, Sum(FG_Ret_Det.Ret_Qty) AS SumOfRet_Qty " _
                & " FROM ((FGMaster INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN (FG_Ret_Master INNER JOIN FG_Ret_Det ON FG_Ret_Master.RetNo = FG_Ret_Det.RetNo) ON FGMaster.FID = FG_Ret_Det.FID " _
                & " WHERE(((FG_Ret_Master.RetDate) < #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "#)) " _
                & " GROUP BY FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName " _
                & " HAVING (((FGMaster.FID)='" & strFID & "'));"
            DR = cmd.ExecuteReader
            Do While DR.Read
                RetStock = DR.Item("SumOfRet_Qty")
            Loop
            DR.Close()

            opStock = opStock + RecStock - IssStock + RetStock

            cmd.CommandText = "Insert into Temp_Cons (FGName,UnitName,GroupName,BatchNo,Opn_Qty)  values ('" & DRFG.Item("FGName").ToString & "','" & DRFG.Item("UnitName").ToString & "','" & DRFG.Item("GroupName").ToString & "','" & DRFG.Item("FID").ToString & "'," & opStock & ")"
            cmd.ExecuteNonQuery()

            'Add code for given period Receipt - Issue + Return
            opStock = 0
            RecStock = 0
            IssStock = 0
            RetStock = 0

            'Opening Stock
            cmd.CommandText = "SELECT FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName, Sum(FG_Opening_Stock.Opening_Qty) AS SumOfOpening_Qty " _
                & " FROM ((FGMaster INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN FG_Opening_Stock ON (UnitMaster.UnitID = FG_Opening_Stock.UnitID) AND (FGMaster.FID = FG_Opening_Stock.FID) " _
                & " WHERE(((FG_Opening_Stock.Register_Date) between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))  " _
                & " GROUP BY FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName " _
                & " HAVING (((FGMaster.FID)='" & strFID & "'));"

            DR = cmd.ExecuteReader
            Do While DR.Read
                opStock = DR.Item("SumOfOpening_Qty")
            Loop
            DR.Close()



            'Goods Receive
            cmd.CommandText = "SELECT FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName, Sum(FinishGoods_QCDetail.QC_No) AS SumOfQC_No" _
                & " FROM FinishGoods_QCMaster INNER JOIN (((FGMaster INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN FinishGoods_QCDetail ON FGMaster.FID = FinishGoods_QCDetail.FID) ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO " _
                & " WHERE (((FinishGoods_QCMaster.VI_Date) between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))  " _
                & " GROUP BY FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName " _
                & " HAVING (((FGMaster.FID)='" & strFID & "'));"
            DR = cmd.ExecuteReader
            Do While DR.Read
                RecStock = DR.Item("SumOfQC_No")
            Loop
            DR.Close()

            'Goods Received From Inward Triplicated
            cmd.CommandText = "SELECT FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName, Sum(TI_Rec_Det.QTY) AS SumOfQTY " _
                    & " FROM ((FGMaster INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN (TI_Rec_Master INNER JOIN TI_Rec_Det ON TI_Rec_Master.RecID = TI_Rec_Det.RecID) ON FGMaster.FID = TI_Rec_Det.FID " _
                    & " WHERE(((TI_Rec_Master.RecDate)  between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))  " _
                    & " GROUP BY FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName " _
                    & " HAVING (((FGMaster.FID)='" & strFID & "'));"

            DR = cmd.ExecuteReader
            Do While DR.Read
                RecStock = RecStock + DR.Item("SumOfQTY")
            Loop
            DR.Close()


            cmd.CommandText = "update Temp_Cons set Rec_Qty =" & opStock + RecStock & " where BATCHNO ='" & DRFG.Item("FID").ToString & "'"
            cmd.ExecuteNonQuery()

            'ISSUE QTY (CHALLAN)
            cmd.CommandText = "SELECT FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName, Sum(ChallanDetail.Qty) AS SumOfQty " _
                & " FROM ((FGMaster INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN (ChallanMaster INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) ON FGMaster.FID = ChallanDetail.FID " _
                & " WHERE(((ChallanMaster.Challan_dt) between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))  " _
                & " GROUP BY FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName " _
                & " HAVING (((FGMaster.FID)='" & strFID & "'));"
            DR = cmd.ExecuteReader
            Do While DR.Read
                IssStock = DR.Item("SumOfQty")
            Loop
            DR.Close()

            cmd.CommandText = "update Temp_Cons set Issue_Qty =" & IssStock & " where BATCHNO ='" & DRFG.Item("FID").ToString & "'"
            cmd.ExecuteNonQuery()

            'Return Qty
            cmd.CommandText = "SELECT FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName, Sum(FG_Ret_Det.Ret_Qty) AS SumOfRet_Qty " _
                            & " FROM ((FGMaster INNER JOIN UnitMaster ON FGMaster.UnitID = UnitMaster.UnitID) INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) INNER JOIN (FG_Ret_Master INNER JOIN FG_Ret_Det ON FG_Ret_Master.RetNo = FG_Ret_Det.RetNo) ON FGMaster.FID = FG_Ret_Det.FID " _
                            & " WHERE(((FG_Ret_Master.RetDate)between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy 23:59:59") & "#))  " _
                            & " GROUP BY FGMaster.FID, FGMaster.FGName, GroupMaster.GroupName, UnitMaster.UnitName " _
                            & " HAVING (((FGMaster.FID)='" & strFID & "'));"
            DR = cmd.ExecuteReader
            Do While DR.Read
                RetStock = DR.Item("SumOfRet_Qty")
            Loop
            DR.Close()

            cmd.CommandText = "update Temp_Cons set Ret_Qty =" & RetStock & ", Balance_Qty = (Opn_Qty + Rec_Qty - Issue_Qty + " & RetStock & ") where BATCHNO ='" & DRFG.Item("FID").ToString & "'"
            cmd.ExecuteNonQuery()



        Catch ex As Exception
            ModMain.Logs.ErrorMessage = ex.Message
            ModMain.Logs.Details = ex.ToString
            ModMain.Logs.Method = "frmPara.FGSStockCalculation"
            Logger.WriteLog(ModMain.Logs)
        End Try
    End Sub


    Private Sub showRMStockCons()
        Try
            Dim myRpt As New rptRMStock
            Dim ds As New DataSet
            ds.Clear()

            ds.Tables.Add("RMStock")
            ds.Tables(0).Columns.Add("RMName", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("TDate", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("GroupName", System.Type.GetType("System.String"))
            'ds.Tables(0).Columns.Add("RMVI", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("Type", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("Opn_Qty", System.Type.GetType("System.Double"))
            ds.Tables(0).Columns.Add("Rec_Qty", System.Type.GetType("System.Double"))
            ds.Tables(0).Columns.Add("Issue_Qty", System.Type.GetType("System.Double"))
            ds.Tables(0).Columns.Add("Ret_Qty", System.Type.GetType("System.Double"))
            ds.Tables(0).Columns.Add("Balance_Qty", System.Type.GetType("System.Double"))

            Dim adp As New OleDb.OleDbDataAdapter
            If strID = "" Then
                adp.SelectCommand = New OleDb.OleDbCommand
                adp.SelectCommand.Connection = conn


                'Opening Balance Before Given date
                adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, RMItemMaster.RMItemName, UnitMaster.UnitName, Sum(RMStock.Received_Qty) as Opn_Qty, Sum(RMStock.Issue_Qty) AS Issue_Qty, Sum(RMStock.Balance_Qty) AS Balance_Qty " _
                     & " FROM ((RMItemMaster INNER JOIN RMStock ON RMItemMaster.Rid = RMStock.RID) INNER JOIN GroupMaster ON RMItemMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID " _
                     & " WHERE (((RMStock.Date)<#" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "#)) " _
                     & " GROUP BY GroupMaster.GroupName, RMItemMaster.RMItemName, UnitMaster.UnitName" _
                     & " HAVING (((Sum(RMStock.Balance_Qty))>0)); "
                adp.Fill(ds.Tables("RMStock"))

                'All transactions for opening between given date
                adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, RMItemMaster.RMItemName, UnitMaster.UnitName, Sum(RMStock.Received_Qty) AS Rec_Qty, Sum(RMStock.Issue_Qty) AS Issue_Qty, Sum(RMStock.Balance_Qty) AS Balance_Qty " _
                    & " FROM ((RMItemMaster INNER JOIN RMStock ON RMItemMaster.Rid = RMStock.RID) INNER JOIN GroupMaster ON RMItemMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID " _
                    & " WHERE (((RMStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((RMStock.Type)='Opening')) " _
                    & " GROUP BY GroupMaster.GroupName, RMItemMaster.RMItemName, UnitMaster.UnitName; "
                adp.Fill(ds.Tables("RMStock"))

                'All inwards between given date
                adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, RMItemMaster.RMItemName, UnitMaster.UnitName, Sum(RMStock.Received_Qty) AS Rec_Qty, Sum(RMStock.Issue_Qty) AS Issue_Qty, Sum(RMStock.Balance_Qty) AS Balance_Qty " _
                   & " FROM ((RMItemMaster INNER JOIN RMStock ON RMItemMaster.Rid = RMStock.RID) INNER JOIN GroupMaster ON RMItemMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID " _
                   & " WHERE (((RMStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((RMStock.Type)='Inward')) " _
                   & " GROUP BY GroupMaster.GroupName, RMItemMaster.RMItemName, UnitMaster.UnitName; "
                adp.Fill(ds.Tables("RMStock"))


            Else
                adp.SelectCommand = New OleDb.OleDbCommand
                adp.SelectCommand.Connection = conn

                For i As Integer = 0 To lstList.CheckedItems.Count - 1
                    strID = lstList.CheckedItems(i).Text
                    'Opening Balance Before Given date
                    adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, RMItemMaster.RMItemName, UnitMaster.UnitName, Sum(RMStock.Received_Qty) AS Rec_Qty, Sum(RMStock.Issue_Qty) AS Issue_Qty, Sum(RMStock.Balance_Qty) AS Balance_Qty " _
                         & " FROM ((RMItemMaster INNER JOIN RMStock ON RMItemMaster.Rid = RMStock.RID) INNER JOIN GroupMaster ON RMItemMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID " _
                         & " WHERE (((RMStock.Date)<#" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "#)) " _
                         & " GROUP BY GroupMaster.GroupName, RMItemMaster.RMItemName, UnitMaster.UnitName" _
                         & " HAVING (((Sum(RMStock.Balance_Qty))>0)) and (((RMItemMaster.RMItemName)='" & strID.Trim & "')); "
                    adp.Fill(ds.Tables("RMStock"))

                    'All transactions for opening between given date
                    adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, RMItemMaster.RMItemName, UnitMaster.UnitName, Sum(RMStock.Received_Qty) AS Rec_Qty, Sum(RMStock.Issue_Qty) AS Issue_Qty, Sum(RMStock.Balance_Qty) AS Balance_Qty " _
                        & " FROM ((RMItemMaster INNER JOIN RMStock ON RMItemMaster.Rid = RMStock.RID) INNER JOIN GroupMaster ON RMItemMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID " _
                        & " WHERE (((RMStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((RMStock.Type)='Opening')) " _
                        & " GROUP BY GroupMaster.GroupName, RMItemMaster.RMItemName, UnitMaster.UnitName " _
                        & " HAVING (((RMItemMaster.RMItemName)='" & strID.Trim & "')); "
                    adp.Fill(ds.Tables("RMStock"))

                    'All inwards between given date
                    adp.SelectCommand.CommandText = "SELECT GroupMaster.GroupName, RMItemMaster.RMItemName, UnitMaster.UnitName, Sum(RMStock.Received_Qty) AS Rec_Qty, Sum(RMStock.Issue_Qty) AS Issue_Qty, Sum(RMStock.Balance_Qty) AS Balance_Qty " _
                       & " FROM ((RMItemMaster INNER JOIN RMStock ON RMItemMaster.Rid = RMStock.RID) INNER JOIN GroupMaster ON RMItemMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON RMItemMaster.UnitId = UnitMaster.UnitID " _
                       & " WHERE (((RMStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((RMStock.Type)='Inward')) " _
                       & " GROUP BY GroupMaster.GroupName, RMItemMaster.RMItemName, UnitMaster.UnitName " _
                       & " HAVING (((RMItemMaster.RMItemName)='" & strID.Trim & "')); "
                    adp.Fill(ds.Tables("RMStock"))
                Next
            End If

            'Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
            'adp.Fill(ds, "RMStock")
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            For i As Integer = 0 To ds.Tables("RMStock").Rows.Count - 1
                cmd.CommandText = "Insert into Temp_Cons values('" & ds.Tables(0).Rows(i).Item("RMItemName") & "','','" _
                    & ds.Tables(0).Rows(i).Item("GroupName") & "','','" & ds.Tables(0).Rows(i).Item("Type") & "'," _
                    & IIf(IsDBNull(ds.Tables(0).Rows(i).Item("Opn_Qty")), 0, ds.Tables(0).Rows(i).Item("Opn_Qty")) & "," _
                    & IIf(IsDBNull(ds.Tables(0).Rows(i).Item("Rec_Qty")), 0, ds.Tables(0).Rows(i).Item("Rec_Qty")) & "," _
                    & IIf(IsDBNull(ds.Tables(0).Rows(i).Item("Issue_Qty")), 0, ds.Tables(0).Rows(i).Item("Issue_Qty")) & "," _
                    & IIf(IsDBNull(ds.Tables(0).Rows(i).Item("Ret_Qty")), 0, ds.Tables(0).Rows(i).Item("Ret_Qty")) & "," _
                    & IIf(IsDBNull(ds.Tables(0).Rows(i).Item("Balance_Qty")), 0, ds.Tables(0).Rows(i).Item("Balance_Qty")) & ")"
                cmd.ExecuteNonQuery()
            Next
            cmd.Dispose()
            ds.Tables("RMStock").Rows.Clear()

            adp.SelectCommand.CommandText = "SELECT Temp_Cons.FGName, Temp_Cons.UnitName, Temp_Cons.GroupName, " _
                & " Temp_Cons.BatchNo, Sum(Temp_Cons.Opn_Qty) AS Opn_Qty, Sum(Temp_Cons.Rec_Qty) AS Rec_Qty, " _
                & " Sum(Temp_Cons.Issue_Qty) AS Issue_Qty, Sum(Temp_Cons.Ret_Qty) AS Ret_Qty, Sum(Temp_Cons.Balance_Qty) AS Balance_Qty" _
                & " FROM(Temp_Cons) GROUP BY Temp_Cons.FGName, Temp_Cons.UnitName, Temp_Cons.GroupName, Temp_Cons.BatchNo;"
            adp.Fill(ds, "RMStock")



            adp.SelectCommand.CommandText = "Select CompanyName from companyMaster"
            adp.Fill(ds, "Company")

            myRpt.DataSource = ds.Tables(0)
            ' myRpt.XrLabel2.DataBindings.Add("Text", ds, "RMStock.RMItemName")
            ' myRpt.XrTableCell1.DataBindings.Add("Text", ds, "RMStock.TDATE")
            myRpt.XrTableCell2.DataBindings.Add("Text", ds, "RMStock.FGName")
            myRpt.XrTableCell3.DataBindings.Add("Text", ds, "RMStock.UnitName")
            'myRpt.XrTableCell4.DataBindings.Add("Text", ds, "RMStock.RMVI_No")
            myRpt.XrTableCell5.DataBindings.Add("Text", ds, "RMStock.Rec_Qty")
            myRpt.XrTableCell6.DataBindings.Add("Text", ds, "RMStock.Issue_Qty")
            myRpt.XrTableCell7.DataBindings.Add("Text", ds, "RMStock.Balance_Qty")
            myRpt.XrTableCell8.DataBindings.Add("Text", ds, "RMStock.Opn_Qty")
            'myRpt.XrTableCell9.DataBindings.Add("Text", ds, "RMStock.Ret_Qty")

            myRpt.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.Balance_Qty", "")})
            myRpt.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.Issue_Qty", "")})
            myRpt.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.Rec_Qty", "")})
            myRpt.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.Opn_Qty", "")})
            myRpt.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.Ret_Qty", "")})

            myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "GroupName"
            myRpt.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.GroupName", "")})

            myRpt.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "Company.CompanyName", "")})
            myRpt.XrLabel4.Text = ""
            myRpt.XrLabel5.Text = ""
            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            'myRpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()
            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            cmd.CommandText = "Delete from Temp_Cons"
            cmd.ExecuteNonQuery()
            cmd.Dispose()
        Catch ex As Exception
            ModMain.Logs.ErrorMessage = ex.Message
            ModMain.Logs.Details = ex.ToString
            ModMain.Logs.Method = "frmPara.showRMStockCons"
            Logger.WriteLog(ModMain.Logs)
            If show_error Then
                MsgBox(ex.ToString)
            End If
        Finally
        End Try
    End Sub
    Public Sub showRMRejection()
        Dim dtCMISReturn As New DataTable
        Dim dtMISReturn As New DataTable
        Dim strSql As String

        dtMISReturn = getMISReturn()
        dtCMISReturn = getCMISReturn()

        dtMISReturn.Merge(dtCMISReturn)
        Dim myrpt As New rptRM_Rejection

        myrpt.DataSource = dtMISReturn
        myrpt.lblRMNameVal.DataBindings.Add("Text", dtMISReturn, "RMItemName")
        myrpt.lblType.Text = "Return"
        myrpt.lblMISNo.DataBindings.Add("Text", dtMISReturn, "MIS_NO")
        myrpt.lblReturnDate.DataBindings.Add("Text", dtMISReturn, "Return_Date")
        myrpt.lblProductName.DataBindings.Add("Text", dtMISReturn, "FGName")
        myrpt.lblRMVI.DataBindings.Add("Text", dtMISReturn, "RMVI_NO")
        myrpt.lblQty.DataBindings.Add("Text", dtMISReturn, "Qty")

        Dim adp As New OleDb.OleDbDataAdapter("Select * from companyMaster", conn)
        Dim dsCompany As New DataSet

        adp.Fill(dsCompany, "Company")
        myrpt.lblCompany.DataBindings.Add("Text", dsCompany.Tables(0), "CompanyName")
        'myrpt.ShowPreview()
        Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
        printingSystem.ShowRibbonPreview()
        adp.Dispose()
    End Sub

    Private Function getCMISReturn() As DataTable
        Dim strsql As String
        Dim cmisReturn As New DataSet
        If strID = "" Then
            'strsql = "SELECT MIS_Return_Master.MIS_NO, MIS_Return_Master.Return_Date, FGMaster.FGName, " _
            '        & " RMItemMaster.RMItemName, MIS_Return_Detail.RMVI_NO, MIS_Return_Detail.Qty, MIS_Return_Detail.Type" _
            '        & " FROM ((Material_Issue_Master INNER JOIN (MIS_Return_Master INNER JOIN MIS_Return_Detail ON " _
            '        & " MIS_Return_Master.MIS_NO = MIS_Return_Detail.MIS_NO) ON Material_Issue_Master.MIS_NO = MIS_Return_Master.MIS_NO) " _
            '        & " INNER JOIN FGMaster ON Material_Issue_Master.FGID = FGMaster.FID) INNER JOIN RMItemMaster ON " _
            '        & " MIS_Return_Detail.RID = RMItemMaster.Rid" _
            '        & " WHERE (((MIS_Return_Detail.Type)='Return'));"

            strsql = "SELECT Semi_MIS_Return_Master.MIS_NO, Semi_MIS_Return_Master.Return_Date, SemiFGMaster.FGName," _
                    & " RMItemMaster.RMItemName, Semi_MIS_Return_Detail.RMVI_NO, Semi_MIS_Return_Detail.Qty, Semi_MIS_Return_Detail.Type" _
                    & " FROM (((Semi_MIS_Return_Master INNER JOIN Semi_MIS_Return_Detail ON " _
                    & " Semi_MIS_Return_Master.MIS_NO = Semi_MIS_Return_Detail.MIS_NO) INNER JOIN RMItemMaster ON" _
                    & " Semi_MIS_Return_Detail.RID = RMItemMaster.Rid) INNER JOIN SEMI_Material_Issue_Master " _
                    & " ON Semi_MIS_Return_Master.MIS_NO = SEMI_Material_Issue_Master.MIS_NO) INNER JOIN " _
                    & " SemiFGMaster ON SEMI_Material_Issue_Master.SFGID = SemiFGMaster.SFID" _
                    & " WHERE (Semi_MIS_Return_Detail.Type)='Return' and " _
                    & " (Semi_MIS_Return_Master.Return_Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#"
        Else
            strID = strID.Replace("A =", "RMItemMaster.RMItemName =")

            'strsql = "SELECT MIS_Return_Master.MIS_NO, MIS_Return_Master.Return_Date, FGMaster.FGName, " _
            '      & " RMItemMaster.RMItemName, MIS_Return_Detail.RMVI_NO, MIS_Return_Detail.Qty, MIS_Return_Detail.Type" _
            '      & " FROM ((Material_Issue_Master INNER JOIN (MIS_Return_Master INNER JOIN MIS_Return_Detail ON " _
            '      & " MIS_Return_Master.MIS_NO = MIS_Return_Detail.MIS_NO) ON Material_Issue_Master.MIS_NO = MIS_Return_Master.MIS_NO) " _
            '      & " INNER JOIN FGMaster ON Material_Issue_Master.FGID = FGMaster.FID) INNER JOIN RMItemMaster ON " _
            '      & " MIS_Return_Detail.RID = RMItemMaster.Rid" _
            '      & " WHERE ((MIS_Return_Detail.Type)='Return' AND (" & strID & "))"

            strsql = "SELECT Semi_MIS_Return_Master.MIS_NO, Semi_MIS_Return_Master.Return_Date, SemiFGMaster.FGName," _
                 & " RMItemMaster.RMItemName, Semi_MIS_Return_Detail.RMVI_NO, Semi_MIS_Return_Detail.Qty, Semi_MIS_Return_Detail.Type" _
                 & " FROM (((Semi_MIS_Return_Master INNER JOIN Semi_MIS_Return_Detail ON " _
                 & " Semi_MIS_Return_Master.MIS_NO = Semi_MIS_Return_Detail.MIS_NO) INNER JOIN RMItemMaster ON" _
                 & " Semi_MIS_Return_Detail.RID = RMItemMaster.Rid) INNER JOIN SEMI_Material_Issue_Master " _
                 & " ON Semi_MIS_Return_Master.MIS_NO = SEMI_Material_Issue_Master.MIS_NO) INNER JOIN " _
                 & " SemiFGMaster ON SEMI_Material_Issue_Master.SFGID = SemiFGMaster.SFID" _
                 & " WHERE (Semi_MIS_Return_Detail.Type)='Return' AND " _
                 & " (Semi_MIS_Return_Master.Return_Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#" _
                 & " and ((RMItemMaster.RMItemName ='" & strID & "))"
        End If

        Dim adp As New OleDb.OleDbDataAdapter
        adp.SelectCommand = New OleDb.OleDbCommand
        adp.SelectCommand.Connection = conn
        adp.SelectCommand.CommandText = strsql
        adp.Fill(cmisReturn, "CMIS_Return")
        Return cmisReturn.Tables("CMIS_Return")

    End Function

    Private Function getMISReturn() As DataTable
        Dim strsql As String
        Dim misReturn As New DataSet
        If strID = "" Then
            strsql = "SELECT MIS_Return_Master.MIS_NO, MIS_Return_Master.Return_Date, FGMaster.FGName, " _
                    & " RMItemMaster.RMItemName, MIS_Return_Detail.RMVI_NO, MIS_Return_Detail.Qty, MIS_Return_Detail.Type" _
                    & " FROM ((Material_Issue_Master INNER JOIN (MIS_Return_Master INNER JOIN MIS_Return_Detail ON " _
                    & " MIS_Return_Master.MIS_NO = MIS_Return_Detail.MIS_NO) ON Material_Issue_Master.MIS_NO = MIS_Return_Master.MIS_NO) " _
                    & " INNER JOIN FGMaster ON Material_Issue_Master.FGID = FGMaster.FID) INNER JOIN RMItemMaster ON " _
                    & " MIS_Return_Detail.RID = RMItemMaster.Rid" _
                    & " WHERE (((MIS_Return_Detail.Type)='Return')) AND " _
                    & " (MIS_Return_Master.Return_Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#"

            strsql = "SELECT MIS_Return_Master.ID, MIS_Return_Master.MIS_NO, MIS_Return_Master.Return_Date, FGMaster.FGName, " _
                & " RMItemMaster.RMItemName, MIS_Return_Detail.RMVI_NO, MIS_Return_Detail.Qty, MIS_Return_Detail.Type " _
                & " FROM MIS_Return_Master INNER JOIN ((Material_Issue_Master INNER JOIN FGMaster ON Material_Issue_Master.FGID = FGMaster.FID) " _
                & " INNER JOIN (MIS_Return_Detail INNER JOIN RMItemMaster ON MIS_Return_Detail.RID = RMItemMaster.Rid) " _
                & " ON Material_Issue_Master.MIS_NO = MIS_Return_Detail.MIS_NO) ON MIS_Return_Master.ID = MIS_Return_Detail.ReturnID " _
                & " WHERE (((MIS_Return_Detail.Type)='Return')) AND " _
                & " (MIS_Return_Master.Return_Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#"
        Else
            strID = strID.Replace("A =", "RMItemMaster.RMItemName =")

            strsql = "SELECT MIS_Return_Master.ID, MIS_Return_Master.MIS_NO, MIS_Return_Master.Return_Date, FGMaster.FGName, " _
                & " RMItemMaster.RMItemName, MIS_Return_Detail.RMVI_NO, MIS_Return_Detail.Qty, MIS_Return_Detail.Type " _
                & " FROM MIS_Return_Master INNER JOIN ((Material_Issue_Master INNER JOIN FGMaster ON Material_Issue_Master.FGID = FGMaster.FID) " _
                & " INNER JOIN (MIS_Return_Detail INNER JOIN RMItemMaster ON MIS_Return_Detail.RID = RMItemMaster.Rid) " _
                & " ON Material_Issue_Master.MIS_NO = MIS_Return_Detail.MIS_NO) ON MIS_Return_Master.ID = MIS_Return_Detail.ReturnID " _
                & " WHERE (MIS_Return_Detail.Type)='Return' AND " _
                & " (MIS_Return_Master.Return_Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#" _
                & " and ((RMItemMaster.RMItemName ='" & strID & "))"
        End If

        Dim adp As New OleDb.OleDbDataAdapter
        adp.SelectCommand = New OleDb.OleDbCommand
        adp.SelectCommand.Connection = conn
        adp.SelectCommand.CommandText = strsql
        adp.Fill(misReturn, "MIS_Return")
        Return misReturn.Tables("MIS_Return")
       
    End Function

    Public Sub showRMStock()
        Try
            Dim myRpt As New rptRMStock
            Dim ds As New DataSet
            ds.Clear()

            ds.Tables.Add("RMStock")
            ds.Tables(0).Columns.Add("RMName", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("TDate", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("GroupName", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("RMVI", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("Type", System.Type.GetType("System.String"))
            ds.Tables(0).Columns.Add("Opn_Qty", System.Type.GetType("System.Double"))
            ds.Tables(0).Columns.Add("Rec_Qty", System.Type.GetType("System.Double"))
            ds.Tables(0).Columns.Add("Issue_Qty", System.Type.GetType("System.Double"))
            ds.Tables(0).Columns.Add("Ret_Qty", System.Type.GetType("System.Double"))
            ds.Tables(0).Columns.Add("Balance_Qty", System.Type.GetType("System.Double"))

            Dim adp As New OleDb.OleDbDataAdapter
            If strID = "" Then
                adp.SelectCommand = New OleDb.OleDbCommand
                adp.SelectCommand.Connection = conn
                adp.SelectCommand.CommandText = "SELECT format(RMStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, RMItemMaster.RMItemName, RMStock.RMVI_No, RMStock.Type, RMStock.Received_Qty as Opn_Qty, RMStock.Issue_Qty, " _
                    & " UnitMaster.UnitName,RMStock.Balance_Qty " _
                    & " FROM ((RMItemMaster INNER JOIN RMStock ON RMItemMaster.RID = RMStock.RID) INNER JOIN GroupMaster ON RMItemMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON RMItemMaster.UnitID = UnitMaster.UnitID " _
                    & " WHERE (((RMStock.Date)<#" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "#) AND ((RMStock.Balance_Qty)>0)) Order by RMItemMaster.RMItemName,RMStock.Date "
                adp.Fill(ds.Tables("RMStock"))


                adp.SelectCommand.CommandText = "SELECT format(RMStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, RMItemMaster.RMItemName, RMStock.RMVI_No, RMStock.Type, RMStock.Received_Qty as Opn_Qty, RMStock.Issue_Qty, " _
                   & " UnitMaster.UnitName,RMStock.Balance_Qty " _
                   & " FROM ((RMItemMaster INNER JOIN RMStock ON RMItemMaster.RID = RMStock.RID) INNER JOIN GroupMaster ON RMItemMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON RMItemMaster.UnitID = UnitMaster.UnitID " _
                   & " WHERE (((RMStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((RMStock.Type)='Opening')) Order by RMItemMaster.RMItemName,RMStock.Date "
                adp.Fill(ds.Tables("RMStock"))

                adp.SelectCommand.CommandText = "SELECT format(RMStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, RMItemMaster.RMItemName, RMStock.RMVI_No, RMStock.Type, RMStock.Received_Qty as Rec_Qty, RMStock.Issue_Qty, " _
                    & " UnitMaster.UnitName,RMStock.Balance_Qty " _
                    & " FROM ((RMItemMaster INNER JOIN RMStock ON RMItemMaster.RID = RMStock.RID) INNER JOIN GroupMaster ON RMItemMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON RMItemMaster.UnitID = UnitMaster.UnitID " _
                    & " WHERE (((RMStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((RMStock.Type)='Inward')) Order by RMItemMaster.RMItemName,RMStock.Date "
                adp.Fill(ds.Tables("RMStock"))
            Else
                adp.SelectCommand = New OleDb.OleDbCommand
                adp.SelectCommand.Connection = conn
                For i As Integer = 0 To lstList.CheckedItems.Count - 1
                    If strReport = "RM_Stock_Group" Then
                        'strID = strID.Replace("or A", "Or GroupMaster.GroupName") & "'"
                        strID = lstList.CheckedItems(i).Text & "'"
                        adp.SelectCommand.CommandText = "SELECT format(RMStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, RMItemMaster.RMItemName, RMStock.RMVI_No, RMStock.Type, RMStock.Received_Qty as Opn_Qty, RMStock.Issue_Qty, " _
                            & " UnitMaster.UnitName,RMStock.Balance_Qty " _
                            & " FROM ((RMItemMaster INNER JOIN RMStock ON RMItemMaster.RID = RMStock.RID) INNER JOIN GroupMaster ON RMItemMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON RMItemMaster.UnitID = UnitMaster.UnitID " _
                            & " WHERE (((RMStock.Date)<#" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "#) AND ((RMStock.Balance_Qty)>0)) and GroupMaster.GroupName ='" & strID & " Order by RMItemMaster.RMItemName,RMStock.Date "
                        adp.Fill(ds.Tables("RMStock"))

                        adp.SelectCommand.CommandText = "SELECT format(RMStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, RMItemMaster.RMItemName, RMStock.RMVI_No, RMStock.Type, RMStock.Received_Qty as Opn_Qty, RMStock.Issue_Qty, " _
                           & " UnitMaster.UnitName,RMStock.Balance_Qty " _
                           & " FROM ((RMItemMaster INNER JOIN RMStock ON RMItemMaster.RID = RMStock.RID) INNER JOIN GroupMaster ON RMItemMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON RMItemMaster.UnitID = UnitMaster.UnitID " _
                           & " WHERE (((RMStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((RMStock.Type)='Opening'))  and GroupMaster.GroupName ='" & strID & " Order by RMItemMaster.RMItemName,RMStock.Date "
                        adp.Fill(ds.Tables("RMStock"))

                        adp.SelectCommand.CommandText = "SELECT format(RMStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, RMItemMaster.RMItemName, RMStock.RMVI_No, RMStock.Type, RMStock.Received_Qty as Rec_Qty, RMStock.Issue_Qty, " _
                            & " UnitMaster.UnitName,RMStock.Balance_Qty " _
                            & " FROM ((RMItemMaster INNER JOIN RMStock ON RMItemMaster.RID = RMStock.RID) INNER JOIN GroupMaster ON RMItemMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON RMItemMaster.UnitID = UnitMaster.UnitID " _
                            & " WHERE (((RMStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((RMStock.Type)='Inward'))  and GroupMaster.GroupName ='" & strID & " Order by RMItemMaster.RMItemName,RMStock.Date "
                        adp.Fill(ds.Tables("RMStock"))
                    Else
                        'strID = strID.Replace("or A", "Or RMItemMaster.RMItemName")
                        strID = lstList.CheckedItems(i).Text & "'"
                        adp.SelectCommand.CommandText = "SELECT format(RMStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, RMItemMaster.RMItemName, RMStock.RMVI_No, RMStock.Type, RMStock.Received_Qty as Opn_Qty, RMStock.Issue_Qty, " _
                            & " UnitMaster.UnitName,RMStock.Balance_Qty " _
                            & " FROM ((RMItemMaster INNER JOIN RMStock ON RMItemMaster.RID = RMStock.RID) INNER JOIN GroupMaster ON RMItemMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON RMItemMaster.UnitID = UnitMaster.UnitID " _
                            & " WHERE (((RMStock.Date)<#" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "#) AND ((RMStock.Balance_Qty)>0)) and (RMItemMaster.RMItemName ='" & strID & ") Order by RMItemMaster.RMItemName,RMStock.Date "
                        adp.Fill(ds.Tables("RMStock"))

                        adp.SelectCommand.CommandText = "SELECT format(RMStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, RMItemMaster.RMItemName, RMStock.RMVI_No, RMStock.Type, RMStock.Received_Qty as Opn_Qty, RMStock.Issue_Qty, " _
                           & " UnitMaster.UnitName,RMStock.Balance_Qty " _
                           & " FROM ((RMItemMaster INNER JOIN RMStock ON RMItemMaster.RID = RMStock.RID) INNER JOIN GroupMaster ON RMItemMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON RMItemMaster.UnitID = UnitMaster.UnitID " _
                           & " WHERE (((RMStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((RMStock.Type)='Opening'))  and (RMItemMaster.RMItemName ='" & strID & ") Order by RMItemMaster.RMItemName,RMStock.Date "
                        adp.Fill(ds.Tables("RMStock"))

                        adp.SelectCommand.CommandText = "SELECT format(RMStock.Date,'DD/MM/YYYY') AS TDate, GroupMaster.GroupName, RMItemMaster.RMItemName, RMStock.RMVI_No, RMStock.Type, RMStock.Received_Qty as Rec_Qty, RMStock.Issue_Qty, " _
                            & " UnitMaster.UnitName,RMStock.Balance_Qty " _
                            & " FROM ((RMItemMaster INNER JOIN RMStock ON RMItemMaster.RID = RMStock.RID) INNER JOIN GroupMaster ON RMItemMaster.GroupID = GroupMaster.GroupID) INNER JOIN UnitMaster ON RMItemMaster.UnitID = UnitMaster.UnitID " _
                            & " WHERE (((RMStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((RMStock.Type)='Inward'))  and (RMItemMaster.RMItemName ='" & strID & ") Order by RMItemMaster.RMItemName,RMStock.Date "
                        adp.Fill(ds.Tables("RMStock"))

                    End If
                Next
            End If

            'Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
            'adp.Fill(ds, "RMStock")

            adp.SelectCommand.CommandText = "Select CompanyName from companyMaster"
            adp.Fill(ds, "Company")

            myRpt.DataSource = ds.Tables(0)
            ' myRpt.XrLabel2.DataBindings.Add("Text", ds, "RMStock.RMItemName")
            myRpt.XrTableCell1.DataBindings.Add("Text", ds, "RMStock.TDATE")
            myRpt.XrTableCell2.DataBindings.Add("Text", ds, "RMStock.RMItemName")
            myRpt.XrTableCell3.DataBindings.Add("Text", ds, "RMStock.UnitName")
            myRpt.XrTableCell4.DataBindings.Add("Text", ds, "RMStock.RMVI_No")
            myRpt.XrTableCell5.DataBindings.Add("Text", ds, "RMStock.Rec_Qty")
            myRpt.XrTableCell6.DataBindings.Add("Text", ds, "RMStock.Issue_Qty")
            myRpt.XrTableCell7.DataBindings.Add("Text", ds, "RMStock.Balance_Qty")
            myRpt.XrTableCell8.DataBindings.Add("Text", ds, "RMStock.Opn_Qty")
            myRpt.XrTableCell9.DataBindings.Add("Text", ds, "RMStock.Ret_Qty")

            myRpt.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.Balance_Qty", "")})
            myRpt.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.Issue_Qty", "")})
            myRpt.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.Rec_Qty", "")})
            myRpt.XrLabel19.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.Opn_Qty", "")})
            myRpt.XrLabel17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.Ret_Qty", "")})

            myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "GroupName"
            myRpt.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMStock.GroupName", "")})

            myRpt.XrLabel16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "Company.CompanyName", "")})
            myRpt.XrLabel1.Text = myRpt.XrLabel1.Text & " Between " & Format(dtpFrom.EditValue, "dd/MM/yyyy") & " and " & Format(dtpTo.EditValue, "dd/MM/yyyy")

            'myRpt.XrLabel9.Summary.Func.Sum()
            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            'myrpt.PrintingSystem = printingSystem
            'myRpt.ShowPreview()
            'Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
            'printingSystem.ShowRibbonPreview()
            'Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
            'printingSystem.ShowRibbonPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()
        Catch ex As Exception
            ModMain.Logs.ErrorMessage = ex.Message
            ModMain.Logs.Details = ex.ToString
            ModMain.Logs.Method = "frmPara.showRMStock"
            Logger.WriteLog(ModMain.Logs)
            If show_error Then
                MsgBox(ex.ToString)
            End If
        Finally
        End Try
    End Sub

    Public Sub ShowPOReport(ByVal strObjID As String)
        Try
            Dim myRpt As New rptPO
            Dim strSql As String
            Dim ds As New DataSet

            strSql = "SELECT Purchase_Master.PO_No,format(Purchase_Master.PO_Date,'DD/MM/YYYY') as PO_Date, Purchase_Master.Qtn_No, format(Purchase_Master.Qtn_date,'DD/MM/YYYY') AS Qtn_date, " _
                & " Purchase_Master.Terms, SupplierMaster.SuppName, RMItemMaster.RMItemName, UnitMaster.UnitName, format(Purchase_Detail.Delivery_Date,'DD/MM/YYYY') as Delivery_Date, Purchase_Detail.Qty, Purchase_Detail.Rate, Purchase_Detail.Amount" _
                & " FROM (((Purchase_Master INNER JOIN Purchase_Detail ON Purchase_Master.PO_No = Purchase_Detail.PO_No) INNER JOIN SupplierMaster ON Purchase_Master.SuppID = SupplierMaster.SID) INNER JOIN RMItemMaster ON Purchase_Detail.RMItemID = RMItemMaster.Rid) INNER JOIN UnitMaster ON Purchase_Detail.UnitID = UnitMaster.UnitID " _
                & " WHERE (((Purchase_Master.PO_No)='" & strObjID & "))"

            Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
            adp.Fill(ds, "Purchase")

            adp.SelectCommand.CommandText = "Select CompanyName,(Add1 +' ' + Add2 ) as Address,(City + ' ' + pincode + ' ' + State + ' ' + Country)as CityPin from CompanyMaster"
            adp.Fill(ds, "CompanyMaster")

            myRpt.DataSource = ds

            myRpt.GroupHeader1.GroupFields.Item(0).FieldName = "PO_No"
            myRpt.XrLabel1.DataBindings.Add("Text", ds.Tables(0), "PO_No")

            myRpt.XrLabel2.DataBindings.Add("Text", ds, "Purchase.PO_Date")
            myRpt.XrLabel3.DataBindings.Add("Text", ds, "Purchase.SuppName")

            myRpt.XrLabel12.DataBindings.Add("Text", ds, "CompanyMaster.CompanyName")
            myRpt.XrLabel23.DataBindings.Add("Text", ds, "CompanyMaster.CompanyName")
            myRpt.XrLabel13.DataBindings.Add("Text", ds, "CompanyMaster.Address")
            myRpt.XrLabel14.DataBindings.Add("Text", ds, "CompanyMaster.CityPin")

            myRpt.XrTableCell4.DataBindings.Add("Text", ds, "Purchase.RMItemName")
            myRpt.XrTableCell1.DataBindings.Add("Text", ds, "Purchase.UnitName")
            myRpt.XrTableCell2.DataBindings.Add("Text", ds, "Purchase.Qty")
            myRpt.XrTableCell3.DataBindings.Add("Text", ds, "Purchase.Rate")
            myRpt.XrTableCell5.DataBindings.Add("Text", ds, "Purchase.Amount")


            myRpt.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "Purchase.Amount", "")})

            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            'myRpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myRpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()
        Catch ex As Exception
            ModMain.Logs.ErrorMessage = ex.Message
            ModMain.Logs.Details = ex.ToString
            ModMain.Logs.Method = "frmPara.ShowPOReport"
            Logger.WriteLog(ModMain.Logs)
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Public Sub showInvoiceReport(ByVal strObjID As String)
        Try
            Dim myrpt As New rptOrder
            Dim ds As New DataSet
            Dim str As String

            'str = "SELECT FGMaster.FGName, InvoiceDetail.Qty, InvoiceDetail.Type, InvoiceDetail.Remarks,InvoiceDetail.Order_No" _
            '   & " FROM InvoiceDetail INNER JOIN FGMaster ON InvoiceDetail.FID = FGMaster.FID" _
            '   & " WHERE (((InvoiceDetail.Order_No)='" & strObjID.Trim & "))"

            'adp.SelectCommand.Connection = conn
            'adp.Fill(ds, "InvMaster")

            'strObjID = strObjID.Replace("InvoiceDetail", "InvoiceMaster")
            'adp.SelectCommand.CommandText = "SELECT InvoiceMaster.Order_No, format(InvoiceMaster.Order_Date,'DD/MM/YYYY') AS Order_Date, " _
            '    & " InvoiceMaster.Challan_No, InvoiceMaster.Ref_By, InvoiceMaster.CID, " _
            '    & " InvoiceMaster.Del_Time, InvoiceMaster.A_Des_Date, InvoiceMaster.Cour_Name, " _
            '    & " InvoiceMaster.Cour_D_No, CustomerMaster.CustName,CustomerMaster.CustCity, " _
            '    & " InvoiceMaster.Qtn_No " _
            '    & " FROM InvoiceMaster INNER JOIN CustomerMaster ON InvoiceMaster.CID = CustomerMaster.CID" _
            '    & " WHERE (((InvoiceMaster.Order_No)='" & strObjID.Trim & "))"

            str = "SELECT InvoiceMaster.Order_No, Format(InvoiceMaster.Order_Date,'dd/mm/yyyy') AS Order_Date, " _
                & " InvoiceMaster.Challan_No, InvoiceMaster.Ref_By, InvoiceMaster.CID, InvoiceMaster.Del_Time," _
                & " InvoiceMaster.A_Des_Date, InvoiceMaster.Cour_Name, InvoiceMaster.Cour_D_No, CustomerMaster.CustName," _
                & " CustomerMaster.CustCity, InvoiceMaster.Qtn_No, FGMaster.FGName, InvoiceDetail.Qty, InvoiceDetail.Type," _
                & " InvoiceDetail.Remarks " _
                & " FROM FGMaster INNER JOIN ((InvoiceMaster INNER JOIN CustomerMaster ON InvoiceMaster.CID = CustomerMaster.CID) INNER JOIN InvoiceDetail ON InvoiceMaster.Order_No = InvoiceDetail.Order_No) ON FGMaster.FID = InvoiceDetail.FID " _
                & " WHERE (((InvoiceMaster.Order_No)='" & strObjID.Trim & "))"

            Dim adp As New OleDb.OleDbDataAdapter(str, conn)
            adp.Fill(ds, "InvMaster")

            'ds.Tables("InvMaster").Columns("Order_No").
            'Dim mykey(1) As DataColumn
            'mykey(0) = New DataColumn("Order_No")
            'ds.Tables("InvMaster").PrimaryKey = mykey


            adp.SelectCommand.CommandText = "Select CompanyName,(Add1 +' ' + Add2 ) as Address,(City + ' ' + pincode)as CityPin,State,Country,Phone,Fax from CompanyMaster"
            adp.Fill(ds, "CompanyMaster")

            myrpt.DataSource = ds

            myrpt.GroupHeader1.GroupFields.Item(0).FieldName = "Order_No"
            myrpt.XrTableCell4.DataBindings.Add("Text", ds, "InvMaster.FGName")
            myrpt.XrTableCell2.DataBindings.Add("Text", ds, "InvMaster.Qty")
            myrpt.XrTableCell3.DataBindings.Add("Text", ds, "InvMaster.TypeDet")
            myrpt.XrTableCell5.DataBindings.Add("Text", ds, "InvMaster.Remarks")



            'myrpt.XrLabel30.DataBindings.Add("Text", ds, "InvMaster.Order_No")
            myrpt.XrLabel31.DataBindings.Add("Text", ds, "InvMaster.Order_No")
            myrpt.XrLabel32.DataBindings.Add("Text", ds, "InvMaster.Order_Date")


            myrpt.XrLabel7.DataBindings.Add("Text", ds, "InvMaster.Ref_By")
            myrpt.XrLabel1.DataBindings.Add("Text", ds, "InvMaster.Type")

            myrpt.XrLabel2.DataBindings.Add("Text", ds, "InvMaster.CustName")
            myrpt.XrLabel3.DataBindings.Add("Text", ds, "InvMaster.CustCity")
            myrpt.XrLabel11.DataBindings.Add("Text", ds, "InvMaster.Del_Time")
            myrpt.XrLabel23.DataBindings.Add("Text", ds, "InvMaster.A_Des_Date")

            myrpt.XrLabel24.DataBindings.Add("Text", ds, "InvMaster.Qtn_No")

            myrpt.XrLabel25.DataBindings.Add("Text", ds, "InvMaster.Cour_Name")
            myrpt.XrLabel28.DataBindings.Add("Text", ds, "InvMaster.Cour_D_No")



            myrpt.XrLabel27.DataBindings.Add("Text", ds, "InvMaster.Challan_No")

            myrpt.XrLabel12.DataBindings.Add("Text", ds, "CompanyMaster.CompanyName")
            myrpt.XrLabel26.DataBindings.Add("Text", ds, "CompanyMaster.CompanyName")
            myrpt.XrLabel13.DataBindings.Add("Text", ds, "CompanyMaster.Address")
            myrpt.XrLabel40.DataBindings.Add("Text", ds, "CompanyMaster.CityPin")
            myrpt.XrLabel41.DataBindings.Add("Text", ds, "CompanyMaster.State")
            myrpt.XrLabel42.DataBindings.Add("Text", ds, "CompanyMaster.Country")
            myrpt.XrLabel37.DataBindings.Add("Text", ds, "CompanyMaster.Phone")
            myrpt.XrLabel39.DataBindings.Add("Text", ds, "CompanyMaster.Fax")

            'myrpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()
        Catch EX As Exception
            ModMain.Logs.ErrorMessage = EX.Message
            ModMain.Logs.Details = EX.ToString
            ModMain.Logs.Method = "frmPara.showInvoiceReport"
            Logger.WriteLog(ModMain.Logs)
            If show_error Then
                MsgBox(EX.ToString)
            End If
        End Try
    End Sub

    Public Sub showDispostionReport(ByVal strObjID As String)

        Dim myrpt As New rptDispostion
        Dim str As String
        Dim ds As New DataSet
        Try
            If strObjID = "R" Then
                str = "SELECT RMItemMaster.RMItemName as Item, Disposition_Status.VINO,RMItemMaster.DrawNo as Draw, Disposition_Status.Disposed_Qty, Disposition_Status.Reason, Disposition_Status.Method, Disposition_Status.Disposed_By, Disposition_Status.Dispose_Date, Disposition_Status.Category, Disposition_Status.Dispose_Date " _
                   & " FROM Disposition_Status INNER JOIN (QCDetail INNER JOIN RMItemMaster ON QCDetail.RID = RMItemMaster.Rid) ON Disposition_Status.ItemID = QCDetail.RID " _
                   & " WHERE (((Disposition_Status.Category)='" & "R" & "') AND ((Disposition_Status.Dispose_Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))"

            ElseIf strObjID = "F" Then
                str = "SELECT (CompanyMaster.CompanyName + ',' + CompanyMaster.City) as Name,FGMaster.FGName as Item,Disposition_Status.VINO ,Disposition_Status.Disposed_Qty, FGMaster.Draw_No as Draw, Disposition_Status.Reason, Disposition_Status.Method, Disposition_Status.Disposed_By, Disposition_Status.Dispose_Date, Disposition_Status.Category " _
                & " FROM CompanyMaster,Disposition_Status INNER JOIN (FGMaster INNER JOIN GroupMaster ON FGMaster.GroupID = GroupMaster.GroupID) ON Disposition_Status.ItemID = FGMaster.FID " _
                & " WHERE (((Disposition_Status.Category)= '" & "F" & "') AND ((Disposition_Status.Dispose_Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))"

            End If

            Dim adp As New OleDb.OleDbDataAdapter(str, conn)
            adp.Fill(ds, "Dis")
            myrpt.DataSource = ds.Tables(0)
            'myrpt.XrLabel1.DataBindings.Add("Text", ds.Tables(0), "Name")
            myrpt.XrTableCell3.DataBindings.Add("Text", ds.Tables(0), "Item")
            myrpt.XrTableCell22.DataBindings.Add("Text", ds.Tables(0), "VINO")
            myrpt.XrTableCell20.DataBindings.Add("Text", ds.Tables(0), "Dispose_Qty")
            myrpt.XrTableCell4.DataBindings.Add("Text", ds.Tables(0), "Draw")
            myrpt.XrTableCell5.DataBindings.Add("Text", ds.Tables(0), "Reason")
            myrpt.XrTableCell10.DataBindings.Add("Text", ds.Tables(0), "Method")
            myrpt.XrTableCell11.DataBindings.Add("Text", ds.Tables(0), "Disposed_By")
            myrpt.XrTableCell12.DataBindings.Add("Text", ds.Tables(0), "Date")

            'myrpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()
        Catch ex As Exception
            ModMain.Logs.ErrorMessage = ex.Message
            ModMain.Logs.Details = ex.ToString
            ModMain.Logs.Method = "frmPara.ShowDispositionReport"
            Logger.WriteLog(ModMain.Logs)
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Public Sub showNonConProReport()
        Try
            Dim myrpt As New rptNonConProuduct
            Dim str As String
            Dim ds As New DataSet

            str = "SELECT Non_Con_Product.Complain_Date, Non_Con_Product.ComPlain_No, RMItemMaster.RMItemName, Non_Con_Product.Qty, Non_Con_Product.Make, Non_Con_Product.Item_Sr_No, SupplierMaster.SuppName, Non_Con_Product.Action_Taken, Non_Con_Product.Remark, Non_Con_Product.Complain_Date" _
                            & " FROM (Non_Con_Product INNER JOIN RMItemMaster ON Non_Con_Product.RID = RMItemMaster.Rid) INNER JOIN SupplierMaster ON Non_Con_Product.SID = SupplierMaster.SID " _
                            & " WHERE (((Non_Con_Product.Complain_Date) Between  #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))"


            Dim adp As New OleDb.OleDbDataAdapter(str, conn)
            adp.Fill(ds, "Non_Con")


            myrpt.DataSource = ds.Tables(0)
            myrpt.XrTableCell13.DataBindings.Add("Text", ds.Tables(0), "Complain_Date")
            myrpt.XrTableCell12.DataBindings.Add("Text", ds.Tables(0), "Qty")
            myrpt.XrTableCell14.DataBindings.Add("Text", ds.Tables(0), "ComPlain_No")
            myrpt.XrTableCell15.DataBindings.Add("Text", ds.Tables(0), "RMItemName")
            myrpt.XrTableCell16.DataBindings.Add("Text", ds.Tables(0), "Make")
            myrpt.XrTableCell17.DataBindings.Add("Text", ds.Tables(0), "Item_Sr_No")
            myrpt.XrTableCell10.DataBindings.Add("Text", ds.Tables(0), "SuppName")
            myrpt.XrTableCell18.DataBindings.Add("Text", ds.Tables(0), "Reason_Defect")
            myrpt.XrTableCell4.DataBindings.Add("Text", ds.Tables(0), "Action_Taken")
            myrpt.XrTableCell29.DataBindings.Add("Text", ds.Tables(0), "Remark")
            'myrpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()
        Catch ex As Exception
            ModMain.Logs.ErrorMessage = ex.Message
            ModMain.Logs.Details = ex.ToString
            ModMain.Logs.Method = "frmPara.showNonConProReport"
            Logger.WriteLog(ModMain.Logs)
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Public Sub showFinishGoodQC()
        Try
            'DHAVAL
            Dim myrpt As New rptFGQC
            Dim ds As New DataSet
            Dim str As String
            If strID = "" Then
                str = "SELECT  FinishGoods_QCMaster.Sr_No,FinishGoods_QCMaster.FGVI_NO, format(FinishGoods_QCMaster.VI_Date,'DD/MM/YYYY') AS VI_Date, FGMaster.FGName, FGMaster.Draw_No, FGMaster.Model_No, FinishGoods_QCDetail.Dim_Check, FinishGoods_QCDetail.Inspected_No, FinishGoods_QCDetail.QC_No, FinishGoods_QCDetail.Reject_Qty, FinishGoods_QCDetail.Reason, FinishGoods_QCDetail.MIS_NO, FinishGoods_QCDetail.Batch_NO" _
                        & " FROM (FinishGoods_QCMaster INNER JOIN FinishGoods_QCDetail ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO) INNER JOIN FGMaster ON FinishGoods_QCDetail.FID = FGMaster.FID " _
                        & " WHERE (((FinishGoods_QCMaster.VI_Date)Between  #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) order by FinishGoods_QCMaster.Sr_No"
            Else
                str = "SELECT  FinishGoods_QCMaster.Sr_No,FinishGoods_QCMaster.FGVI_NO, format(FinishGoods_QCMaster.VI_Date,'DD/MM/YYYY') AS VI_Date, FGMaster.FGName, FGMaster.Draw_No, FGMaster.Model_No, FinishGoods_QCDetail.Dim_Check, FinishGoods_QCDetail.Inspected_No, FinishGoods_QCDetail.QC_No, FinishGoods_QCDetail.Reject_Qty, FinishGoods_QCDetail.Reason, FinishGoods_QCDetail.MIS_NO, FinishGoods_QCDetail.Batch_NO" _
                    & " FROM (FinishGoods_QCMaster INNER JOIN FinishGoods_QCDetail ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO) INNER JOIN FGMaster ON FinishGoods_QCDetail.FID = FGMaster.FID " _
                    & " WHERE (((FinishGoods_QCMaster.VI_Date)Between  #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)) and FinishGoods_QCMaster.FGVI_NO ='" & strID.Trim & "'  order by FinishGoods_QCMaster.Sr_No"
            End If

            Dim adp As New OleDb.OleDbDataAdapter(str, conn)
            adp.Fill(ds, "FinishQC")


            adp.SelectCommand.CommandText = "Select * from companyMaster"
            adp.Fill(ds, "Company")


            myrpt.DataSource = ds
            myrpt.XrTableCell25.DataBindings.Add("Text", ds.Tables(0), "Sr_No")
            myrpt.XrTableCell23.DataBindings.Add("Text", ds.Tables(0), "FGVI_NO")
            myrpt.XrTableCell13.DataBindings.Add("Text", ds.Tables(0), "VI_Date")
            myrpt.XrTableCell14.DataBindings.Add("Text", ds.Tables(0), "FGName")
            myrpt.XrTableCell15.DataBindings.Add("Text", ds.Tables(0), "Draw_No")
            myrpt.XrTableCell12.DataBindings.Add("Text", ds.Tables(0), "Model_No")
            myrpt.XrTableCell16.DataBindings.Add("Text", ds.Tables(0), "Dim_Check")
            myrpt.XrTableCell17.DataBindings.Add("Text", ds.Tables(0), "Inspected_No")
            myrpt.XrTableCell10.DataBindings.Add("Text", ds.Tables(0), "QC_No")
            myrpt.XrTableCell18.DataBindings.Add("Text", ds.Tables(0), "Reject_Qty")
            myrpt.XrTableCell4.DataBindings.Add("Text", ds.Tables(0), "Reason")
            myrpt.XrTableCell29.DataBindings.Add("Text", ds.Tables(0), "MIS_NO")
            myrpt.XrTableCell21.DataBindings.Add("Text", ds.Tables(0), "Batch_NO")

            myrpt.XrLabel1.DataBindings.Add("Text", ds.Tables(1), "CompanyName")

            'myrpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()
        Catch ex As Exception
            ModMain.Logs.ErrorMessage = ex.Message
            ModMain.Logs.Details = ex.ToString
            ModMain.Logs.Method = "frmPara.showFinishGoodQC"
            Logger.WriteLog(ModMain.Logs)
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Public Sub showbatchReg()
        'DHAVAL
        Try
            Dim str As String
            str = "SELECT  FGMaster.FGName, FinishGoods_QCDetail.QC_No, FinishGoods_QCDetail.Batch_NO, FinishGoods_QCMaster.FGVI_NO,FORMAT(FinishGoods_QCMaster.VI_Date, 'DD/MM/YYYY') as VI_Date, FinishGoods_QCDetail.MIS_NO, format(Material_Issue_Master.MIS_DATE,'DD/MM/YYYY') as MIS_DATE, " _
                    & " format(FinishGoods_QCMaster.St_Date,'DD/MM/YYYY') AS ST_DATE " _
                    & " FROM ((FinishGoods_QCMaster INNER JOIN FinishGoods_QCDetail ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO) INNER JOIN FGMaster ON FinishGoods_QCDetail.FID = FGMaster.FID) INNER JOIN Material_Issue_Master ON FinishGoods_QCDetail.MIS_NO = Material_Issue_Master.MIS_NO" _
                    & " WHERE (((FinishGoods_QCMaster.VI_Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# And #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))"
            Batch(str)

        Catch ex As Exception
            ModMain.Logs.ErrorMessage = ex.Message
            ModMain.Logs.Details = ex.ToString
            ModMain.Logs.Method = "frmPara.showbatchReg"
            Logger.WriteLog(ModMain.Logs)
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Public Sub showbbatchRefFG(ByVal strObjID)
        'DHAVAL
        Try
            Dim str As String
            str = "SELECT FGMaster.FGName, FinishGoods_QCDetail.QC_No, FinishGoods_QCDetail.Batch_NO, FinishGoods_QCMaster.FGVI_NO,format(FinishGoods_QCMaster.VI_Date,'DD/MM/YYYY') AS VI_DATE, " _
                    & " FinishGoods_QCDetail.MIS_NO, FORMAT(Material_Issue_Master.MIS_DATE,'DD/MM/YYYY') AS MIS_DATE , FORMAT(FinishGoods_QCMaster.ST_Date,'DD/MM/YYYY') AS ST_DATE " _
                    & " FROM ((FinishGoods_QCMaster INNER JOIN FinishGoods_QCDetail ON FinishGoods_QCMaster.FGVI_NO = FinishGoods_QCDetail.FGVI_NO) INNER JOIN FGMaster ON FinishGoods_QCDetail.FID = FGMaster.FID) INNER JOIN Material_Issue_Master ON FinishGoods_QCDetail.MIS_NO = Material_Issue_Master.MIS_NO " _
                    & " WHERE (((FinishGoods_QCDetail.FID)='" & strObjID & ")) and FinishGoods_QCMaster.VI_Date between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#"
            Batch(str)
        Catch ex As Exception
            ModMain.Logs.ErrorMessage = ex.Message
            ModMain.Logs.Details = ex.ToString
            ModMain.Logs.Method = "frmPara.showbatchRefFG"
            Logger.WriteLog(ModMain.Logs)
            If show_error Then
                MessageBox.Show(ex.ToString)
            End If
        End Try
    End Sub
    Public Sub Batch(ByVal str As String)
        Try
            Dim myrpt As New rptFinalProduct
            Dim ds As New DataSet
            Dim adp As New OleDb.OleDbDataAdapter(str, conn)

            adp.Fill(ds, "FinalProduct")
            myrpt.DataSource = ds.Tables(0)

            adp.SelectCommand.CommandText = "Select * from companyMaster"
            adp.Fill(ds, "Company")

            myrpt.XrTableCell5.DataBindings.Add("Text", ds.Tables(0), "FGName")
            myrpt.XrTableCell10.DataBindings.Add("Text", ds.Tables(0), "QC_No")
            myrpt.XrTableCell11.DataBindings.Add("Text", ds.Tables(0), "Batch_NO")
            myrpt.XrTableCell12.DataBindings.Add("Text", ds.Tables(0), "VI_Date")
            myrpt.XrTableCell13.DataBindings.Add("Text", ds.Tables(0), "FGVI_NO")
            myrpt.XrTableCell14.DataBindings.Add("Text", ds.Tables(0), "VI_Date")
            myrpt.XrTableCell15.DataBindings.Add("Text", ds.Tables(0), "MIS_NO")
            myrpt.XrTableCell16.DataBindings.Add("Text", ds.Tables(0), "MIS_DATE")
            myrpt.XrTableCell17.DataBindings.Add("Text", ds.Tables(0), "ST_DATE")

            myrpt.XrLabel2.DataBindings.Add("Text", ds.Tables(1), "CompanyName")

            'myrpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
            printingSystem.ShowRibbonPreview()
            adp.Dispose()
        Catch ex As Exception
            ModMain.Logs.ErrorMessage = ex.Message
            ModMain.Logs.Details = ex.ToString
            ModMain.Logs.Method = "frmPara.Batch"
            Logger.WriteLog(ModMain.Logs)
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub getSelectedSemifinishGoodIds()
        For i As Integer = 0 To lstList.CheckedItems.Count - 1
            If i = 0 Then
                strID = lstList.CheckedItems(i).SubItems(1).Text & "'"
            Else
                strID = strID & " or SFID = '" & lstList.CheckedItems(i).SubItems(1).Text & "'"
            End If
        Next
    End Sub

    Private Sub showSemiFinishCompReg(ByVal strSFID As String)
        Try
            Dim myrpt As New rptCompReg
            Dim strsql As String
            Dim ds As New DataSet
            Dim adpt As New OleDb.OleDbDataAdapter

            cmd = New OleDb.OleDbCommand
            cmd.Connection = conn
            adpt.SelectCommand = New OleDb.OleDbCommand
            adpt.SelectCommand.Connection = conn
            If strID = "" Then
                adpt.SelectCommand.CommandText = "SELECT SemiFGMaster.SFID, SemiFGMaster.FGName FROM SemiFGMaster"
            Else
                adpt.SelectCommand.CommandText = "SELECT SemiFGMaster.SFID, SemiFGMaster.FGName FROM SemiFGMaster where SFID='" & strSFID.Trim
            End If
            adpt.Fill(ds, "RMStock")
            For i As Integer = 0 To ds.Tables("RMStock").Rows.Count - 1
                'adpt.SelectCommand.CommandText = "SELECT RMStock.RID, RMItemMaster.RMItemName, RMStock.RMVI_No, RMStock.Balance_Qty, RMStock.Date " _
                '     & " FROM RMItemMaster INNER JOIN RMStock ON RMItemMaster.RID = RMStock.RID " _
                '     & " WHERE (((RMStock.Balance_Qty)>0) AND ((RMStock.Date)<# " & Format(dtpFrom.EditValue, "MM/dd/yyyy").Trim & "#)) and RMStock.RID ='" & ds.Tables("RMStock").Rows(i).Item("RID") & "'"

                adpt.SelectCommand.CommandText = "SELECT SemiFGStock.SFID, SemiFGMaster.FGName, SemiFGStock.Batch_No, SemiFGStock.Balance_Qty, SemiFGStock.Date" _
                     & " FROM SemiFGStock INNER JOIN SemiFGMaster ON SemiFGStock.SFID = SemiFGMaster.SFID " _
                     & " WHERE (((SemiFGStock.SFID)='" & ds.Tables("RMStock").Rows(i).Item("SFID") & "') " _
                     & " AND ((SemiFGStock.Balance_Qty)>0) AND ((SemiFGStock.Date) <# " & Format(dtpFrom.EditValue, "MM/dd/yyyy").Trim & "#));"


                adpt.Fill(ds, "RMOpening")
                For k As Integer = 0 To ds.Tables("RMOpening").Rows.Count - 1
                    'Opening Stock
                    cmd.CommandText = "Insert Into Temp_Reg (ID,Product,Rec_Dt,Inward_BatchNo,Qty_Rec) values ('" _
                        & ds.Tables("RMStock").Rows(i).Item("SFID") & "','" & Replace(ds.Tables("RMStock").Rows(i).Item("FGName"), "'", "''") & "','" _
                        & Format(dtpFrom.EditValue, "MM/dd/yyyy").Trim & "','" & ds.Tables("RMOpening").Rows(k).Item("Batch_No") & "'," _
                        & ds.Tables("RMOpening").Rows(k).Item("Balance_Qty") & ")"
                    cmd.ExecuteNonQuery()
                Next
                ds.Tables("RMOpening").Rows.Clear()

                strsql = "SELECT SemiFGStock.Batch_No, SemiFGStock.Issue_Qty, format(SemiFGStock.Date,'DD/MM/YYYY') AS FDATE, SemiFGStock.Received_Qty " _
                    & " FROM SemiFGMaster INNER JOIN SemiFGStock ON SemiFGMaster.SFID = SemiFGStock.SFID " _
                    & " WHERE (((SemiFGStock.Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" _
                    & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((SemiFGStock.SFID)='" & ds.Tables("RMStock").Rows(i).Item("SFID") & "'))"

                adpt.SelectCommand.CommandText = strsql
                adpt.Fill(ds, "RMOpen")
                For j As Integer = 0 To ds.Tables("RMOpen").Rows.Count - 1
                    cmd.CommandText = "Insert Into Temp_Reg (ID,Product,Rec_Dt,Inward_BatchNo,Qty_Rec) values ('" _
                        & ds.Tables("RMStock").Rows(i).Item("SFID") & "','" & Replace(ds.Tables("RMStock").Rows(i).Item("FGName"), "'", "''") & "','" & ds.Tables("RMOpen").Rows(j).Item("FDate") & "','" _
                        & ds.Tables("RMOpen").Rows(j).Item("Batch_No") & "'," & ds.Tables("RMOpen").Rows(j).Item("Received_Qty") & ")"
                    cmd.ExecuteNonQuery()
                Next
                ds.Tables("RMOpen").Rows.Clear()


                'Issue
                strsql = "SELECT Material_Issue_Master.MIS_NO, Material_Issue_Master.MIS_DATE, Material_Issue_Detail.RMVI_NO," _
                    & " Material_Issue_Detail.Issued_Qty " _
                    & " FROM Material_Issue_Master INNER JOIN (SemiFGStock INNER JOIN Material_Issue_Detail ON SemiFGStock.SFID = Material_Issue_Detail.RID) " _
                    & " ON Material_Issue_Master.MIS_NO = Material_Issue_Detail.MIS_NO " _
                    & " GROUP BY Material_Issue_Master.MIS_NO, Material_Issue_Master.MIS_DATE, Material_Issue_Detail.RMVI_NO, " _
                    & " Material_Issue_Detail.Issued_Qty, SemiFGStock.SFID " _
                    & " HAVING (((Material_Issue_Master.MIS_DATE) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)" _
                    & " AND ((SemiFGStock.SFID)='" & ds.Tables("RMStock").Rows(i).Item("SFID") & "'));"

                'strsql = "SELECT Semi_Material_Issue_Master.MIS_NO, Semi_Material_Issue_Master.MIS_DATE, Semi_Material_Issue_Detail.RMVI_NO, " _
                '    & " Semi_Material_Issue_Detail.Issued_Qty, SemiFGStock.SFID " _
                '    & " FROM SemiFGStock INNER JOIN (Semi_Material_Issue_Master INNER JOIN Semi_Material_Issue_Detail ON " _
                '    & " Semi_Material_Issue_Master.MIS_NO = Semi_Material_Issue_Detail.MIS_NO) ON SemiFGStock.SFID = Semi_Material_Issue_Detail.RID " _
                '    & " GROUP BY Material_Issue_Master.MIS_NO, Material_Issue_Master.MIS_DATE, Material_Issue_Detail.RMVI_NO, Material_Issue_Detail.Issued_Qty, RMStock.RID " _
                '    & " HAVING (((Material_Issue_Master.MIS_DATE) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((RMStock.RID)='" & ds.Tables("RMStock").Rows(i).Item("RID") & "'));"

                adpt.SelectCommand.CommandText = strsql
                adpt.Fill(ds, "MIS")
                For j As Integer = 0 To ds.Tables("MIS").Rows.Count - 1
                    cmd.CommandText = "Insert Into Temp_Reg (ID,Product,MISNo,Rec_Dt,Issue_Date,Outward_Batchno,Issue_Qty) values ('" _
                        & ds.Tables("RMStock").Rows(i).Item("SFID") & "','" & Replace(ds.Tables("RMStock").Rows(i).Item("FGName"), "'", "''") & "','" & ds.Tables("MIS").Rows(j).Item("MIS_NO") & "','" & ds.Tables("MIS").Rows(j).Item("MIS_DATE") & "','" & ds.Tables("MIS").Rows(j).Item("MIS_DATE") & "','" & ds.Tables("MIS").Rows(j).Item("RMVI_NO") & "'," & ds.Tables("MIS").Rows(j).Item("Issued_Qty") & ")"
                    cmd.ExecuteNonQuery()
                Next
                ds.Tables("MIS").Rows.Clear()

                'MIS_RETURN_REISSUE
                strsql = "SELECT MIS_Return_Master.MIS_NO, MIS_Return_Master.Return_Date, MIS_Return_Detail.RMVI_NO, MIS_Return_Detail.Qty, MIS_Return_Detail.Type " _
                    & " FROM (MIS_Return_Master INNER JOIN MIS_Return_Detail ON MIS_Return_Master.ID = MIS_Return_Detail.ReturnID) INNER JOIN SemiFGStock ON MIS_Return_Detail.RID = SemiFGStock.SFID " _
                    & " WHERE (((SemiFGStock.SFID)='" & ds.Tables("RMStock").Rows(i).Item("SFID") & "')) " _
                    & " GROUP BY MIS_Return_Master.MIS_NO, MIS_Return_Master.Return_Date, MIS_Return_Detail.RMVI_NO, MIS_Return_Detail.Qty, MIS_Return_Detail.Type " _
                    & " HAVING (((MIS_Return_Master.Return_Date) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# and #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#))"

                adpt.SelectCommand.CommandText = strsql
                adpt.Fill(ds, "MIS_RETURN_REISSUE")
                For j As Integer = 0 To ds.Tables("MIS_RETURN_REISSUE").Rows.Count - 1
                    If (ds.Tables("MIS_RETURN_REISSUE").Rows(j).Item("Type").ToString() = "Return") Then
                        cmd.CommandText = "Insert Into Temp_Reg (ID,Product,Rec_Dt,Inward_BatchNo,Qty_Rec) values ('" _
                           & ds.Tables("RMStock").Rows(i).Item("SFID") & "','" & Replace(ds.Tables("RMStock").Rows(i).Item("FGName"), "'", "''") & "','" & ds.Tables("MIS_RETURN_REISSUE").Rows(j).Item("Return_Date") & "','" & ds.Tables("MIS_RETURN_REISSUE").Rows(j).Item("RMVI_No") & "'," & ds.Tables("MIS_RETURN_REISSUE").Rows(j).Item("Qty") & ")"
                        cmd.ExecuteNonQuery()
                    Else
                        cmd.CommandText = "Insert Into Temp_Reg (ID,Product,MISNo,Issue_Date,Outward_Batchno,Issue_Qty) values ('" _
                            & ds.Tables("RMStock").Rows(i).Item("SFID") & "','" & Replace(ds.Tables("RMStock").Rows(i).Item("FGName"), "'", "''") & "','" & ds.Tables("MIS_RETURN_REISSUE").Rows(j).Item("MIS_NO") & "','" & ds.Tables("MIS_RETURN_REISSUE").Rows(j).Item("Return_Date") & "','" & ds.Tables("MIS_RETURN_REISSUE").Rows(j).Item("RMVI_NO") & "'," & ds.Tables("MIS_RETURN_REISSUE").Rows(j).Item("Qty") & ")"
                        cmd.ExecuteNonQuery()
                    End If
                Next
                ds.Tables("MIS_RETURN_REISSUE").Rows.Clear()
            Next

            ds.Tables.Clear()

            adpt.SelectCommand.CommandText = "Select *,Format(Rec_Dt,'DD/MM/YYYY') AS Rdate,format(Issue_Date,'DD/MM/YYYY') AS IDATE from Temp_Reg ORDER BY Rec_Dt, Inward_Batchno DESC , Outward_Batchno;"
            adpt.Fill(ds, "RMComp")


            adpt.SelectCommand.CommandText = "Select CompanyName from companyMaster"
            adpt.Fill(ds, "Company")

            myrpt.DataSource = ds
            myrpt.GroupHeader1.GroupFields.Item(0).FieldName = "Product"
            myrpt.XrLabel1.DataBindings.Add("Text", ds, "RMComp.Product")

            myrpt.XrTableCell1.DataBindings.Add("Text", ds, "RMComp.Rdate")
            myrpt.XrTableCell2.DataBindings.Add("Text", ds, "RMComp.VINO")
            myrpt.XrTableCell3.DataBindings.Add("Text", ds, "RMComp.Qty_Rec")
            myrpt.XrTableCell4.DataBindings.Add("Text", ds, "RMComp.Inward_Batchno")

            myrpt.XrTableCell5.DataBindings.Add("Text", ds, "RMComp.Outward_Batchno")
            myrpt.XrTableCell17.DataBindings.Add("Text", ds, "RMComp.IDATE")
            myrpt.XrTableCell16.DataBindings.Add("Text", ds, "RMComp.MISNO")
            myrpt.XrTableCell18.DataBindings.Add("Text", ds, "RMComp.Issue_Qty")
            'myrptXrTableCell20.DataBindings.Add("Text", ds, "MIS.RMVI_NO")

            myrpt.XrLabel13.DataBindings.Add("Text", ds, "Company.CompanyName")
            myrpt.XrLabel15.Text = "RMVI No"
            myrpt.XrLabel11.Text = "Batch No"

            myrpt.XrLabel31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMComp.Qty_Rec", "")})
            myrpt.XrLabel32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "RMComp.Issue_Qty", "")})



            cmd.CommandText = "Delete from Temp_Reg"
            cmd.ExecuteNonQuery()
            'Dim printingSystem As DevExpress.XtraPrinting.PrintingSystem
            ''myrpt.PrintingSystem = printingSystem
            'myrpt.ShowPreview()
            Dim printingSystem As DevExpress.XtraReports.UI.ReportPrintTool = New DevExpress.XtraReports.UI.ReportPrintTool(myrpt)
            printingSystem.ShowRibbonPreview()
            adpt.Dispose()
        Catch ex As Exception            
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

End Class
