Public Class frmPara1
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
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lkupName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents grpdate As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lkupGroup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblGroup As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.lkupGroup = New DevExpress.XtraEditors.LookUpEdit
        Me.lblGroup = New System.Windows.Forms.Label
        Me.grpdate = New DevExpress.XtraEditors.GroupControl
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpTo = New DevExpress.XtraEditors.DateEdit
        Me.dtpFrom = New DevExpress.XtraEditors.DateEdit
        Me.lkupName = New DevExpress.XtraEditors.LookUpEdit
        Me.lblName = New System.Windows.Forms.Label
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.cmdOK = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.lkupGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpdate.SuspendLayout()
        CType(Me.dtpTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkupName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lkupGroup)
        Me.GroupControl1.Controls.Add(Me.lblGroup)
        Me.GroupControl1.Controls.Add(Me.grpdate)
        Me.GroupControl1.Controls.Add(Me.lkupName)
        Me.GroupControl1.Controls.Add(Me.lblName)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(344, 144)
        Me.GroupControl1.TabIndex = 1
        '
        'lkupGroup
        '
        Me.lkupGroup.EditValue = ""
        Me.lkupGroup.Location = New System.Drawing.Point(104, 48)
        Me.lkupGroup.Name = "lkupGroup"
        Me.lkupGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupGroup.Properties.NullText = ""
        Me.lkupGroup.Size = New System.Drawing.Size(232, 20)
        Me.lkupGroup.TabIndex = 3
        '
        'lblGroup
        '
        Me.lblGroup.Location = New System.Drawing.Point(16, 48)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(88, 24)
        Me.lblGroup.TabIndex = 4
        Me.lblGroup.Text = "Label1"
        '
        'grpdate
        '
        Me.grpdate.Controls.Add(Me.Label3)
        Me.grpdate.Controls.Add(Me.Label2)
        Me.grpdate.Controls.Add(Me.dtpTo)
        Me.grpdate.Controls.Add(Me.dtpFrom)
        Me.grpdate.Location = New System.Drawing.Point(8, 80)
        Me.grpdate.Name = "grpdate"
        Me.grpdate.Size = New System.Drawing.Size(328, 56)
        Me.grpdate.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(176, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "To"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
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
        Me.dtpTo.TabIndex = 5
        '
        'dtpFrom
        '
        Me.dtpFrom.EditValue = New Date(2007, 1, 19, 0, 0, 0, 0)
        Me.dtpFrom.Location = New System.Drawing.Point(56, 24)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFrom.Size = New System.Drawing.Size(96, 20)
        Me.dtpFrom.TabIndex = 4
        '
        'lkupName
        '
        Me.lkupName.EditValue = ""
        Me.lkupName.Location = New System.Drawing.Point(104, 24)
        Me.lkupName.Name = "lkupName"
        Me.lkupName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkupName.Properties.NullText = ""
        Me.lkupName.Size = New System.Drawing.Size(232, 20)
        Me.lkupName.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(16, 24)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(88, 24)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Label1"
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(184, 160)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(72, 24)
        Me.cmdCancel.TabIndex = 7
        Me.cmdCancel.Text = "&Cancel"
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(104, 160)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(72, 24)
        Me.cmdOK.TabIndex = 6
        Me.cmdOK.Text = "&OK"
        '
        'frmPara1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(358, 191)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPara1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Parameter"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.lkupGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpdate.ResumeLayout(False)
        CType(Me.dtpTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkupName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public strReport As String
    Dim strID As String
    Dim strGroupID As String
    Private Sub frmPara1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Select Case strReport
                Case "CW_BW_Sales"
                    FillLookup("SELECT CustomerMaster.CustName, CustomerMaster.CID " _
                        & " FROM CustomerMaster INNER JOIN GroupMaster ON CustomerMaster.CustGRno = GroupMaster.GroupID " _
                        & " GROUP BY CustomerMaster.CustName, CustomerMaster.CID ", "Customer", "Name", "CustID", lkupName)
                    lblName.Text = "Customer"

                    FillLookup("SELECT FGStock.Batch_No, FGStock.Batch_No" _
                        & " FROM(FGStock) " _
                        & " GROUP BY FGStock.Batch_No, FGStock.Batch_No " _
                        & " ORDER BY FGStock.Batch_No", "Batch", "Batch No", "Batch No", lkupGroup)
                    lblGroup.Text = "Batch No"
                Case "BW_CW_Sales"
                    FillLookup("SELECT FGStock.Batch_No, FGStock.Batch_No" _
                       & " FROM(FGStock) " _
                       & " GROUP BY FGStock.Batch_No, FGStock.Batch_No " _
                       & " ORDER BY FGStock.Batch_No", "Batch", "Batch No", "Batch No", lkupName)
                    lblName.Text = "Batch No"

                    FillLookup("SELECT CustomerMaster.CustName, CustomerMaster.CID " _
                      & " FROM CustomerMaster INNER JOIN GroupMaster ON CustomerMaster.CustGRno = GroupMaster.GroupID " _
                      & " GROUP BY CustomerMaster.CustName, CustomerMaster.CID ", "Customer", "Name", "CustID", lkupGroup)
                    lblGroup.Text = "Customer"
            End Select
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

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Try
            Select Case strReport
                Case "CW_BW_Sales"

                    Dim myRpt As New rptCW_BW_Sales

                    Dim ds As New DataSet
                    Dim strSql As String
                    If strID = "" And strGroupID.Trim = "" Then
                        strSql = "SELECT format(ChallanMaster.Challan_dt,'dd/MM/yyyy') as CDate, ChallanMaster.Challan_No, ChallanDetail.BatchID, CustomerMaster.CustName,ChallanDetail.Qty, Sum([Qty]*[ChallanDetail]![Rate]) AS Expr1,FGMaster.FGName " _
                            & " FROM ((ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID " _
                            & " GROUP BY ChallanMaster.Challan_No, ChallanDetail.BatchID, CustomerMaster.CustName, ChallanMaster.Challan_dt, FGMaster.FGName,ChallanDetail.Qty " _
                            & " HAVING (((ChallanMaster.Challan_dt) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# AND #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)); "
                    ElseIf strID <> "" And strGroupID.Trim <> "" Then
                        strSql = "SELECT format(ChallanMaster.Challan_dt,'dd/MM/yyyy') as CDate, ChallanMaster.Challan_No, ChallanDetail.BatchID, ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.Qty,  Sum([Qty]*[ChallanDetail]![Rate]) AS Expr1,FGMaster.FGName " _
                           & " FROM ((ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID " _
                           & " GROUP BY ChallanMaster.Challan_No, ChallanDetail.BatchID, CustomerMaster.CustName, ChallanMaster.Challan_dt, FGMaster.FGName,ChallanDetail.Qty,ChallanMaster.CID " _
                           & " HAVING (((ChallanMaster.Challan_dt) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# AND #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((ChallanDetail.BatchID)='" & strGroupID.Trim & "') AND ((ChallanMaster.CID)='" & strID.Trim & "'));"
                    ElseIf strID = "" And strGroupID.Trim <> "" Then
                        strSql = "SELECT format(ChallanMaster.Challan_dt,'dd/MM/yyyy') as CDate, ChallanMaster.Challan_No, ChallanDetail.BatchID, ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.Qty, Sum([Qty]*[ChallanDetail]![Rate]) AS Expr1,FGMaster.FGName " _
                           & " FROM ((ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID " _
                           & " GROUP BY ChallanMaster.Challan_No, ChallanDetail.BatchID, CustomerMaster.CustName, ChallanMaster.Challan_dt, FGMaster.FGName,ChallanDetail.Qty,ChallanMaster.CID " _
                           & " HAVING (((ChallanMaster.Challan_dt) Between # " & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# AND #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((ChallanDetail.BatchID)='" & strGroupID.Trim & "'))"
                    ElseIf strID <> "" And strGroupID.Trim = "" Then
                        strSql = "SELECT format(ChallanMaster.Challan_dt,'dd/MM/yyyy') as CDate, ChallanMaster.Challan_No, ChallanDetail.BatchID, ChallanMaster.CID, CustomerMaster.CustName, ChallanDetail.Qty, Sum([Qty]*[ChallanDetail]![Rate]) AS Expr1,FGMaster.FGName" _
                           & " FROM ((ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID " _
                           & " GROUP BY ChallanMaster.Challan_No, ChallanDetail.BatchID, CustomerMaster.CustName, ChallanMaster.Challan_dt, FGMaster.FGName,ChallanDetail.Qty,ChallanMaster.CID " _
                           & " HAVING (((ChallanMaster.Challan_dt) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# AND #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((ChallanMaster.CID)='" & strID.Trim & "'))"
                    End If
                    Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
                    adp.Fill(ds, "Challan")

                    adp.SelectCommand.CommandText = "Select * from companyMaster"
                    adp.Fill(ds, "Company")

                    myrpt.DataSource = ds.Tables(0)

                    myRpt.XrTableCell1.DataBindings.Add("Text", ds, "Challan.CDate")
                    myRpt.XrTableCell2.DataBindings.Add("Text", ds, "Challan_No")
                    myRpt.XrTableCell3.DataBindings.Add("Text", ds, "Challan.Qty")
                    myRpt.XrTableCell7.DataBindings.Add("Text", ds, "Challan.FGName")
                    myRpt.XrLabel2.DataBindings.Add("Text", ds, "Company.CompanyName")

                    myRpt.GrpHeaderCust.GroupFields.Item(0).FieldName = "CustName"
                    myRpt.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "Challan.CustName", "")})

                    myRpt.GrpHeaderBatch.GroupFields.Item(0).FieldName = "BatchID"
                    myRpt.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "Challan.BatchID", "")})

                    myRpt.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "Company.CompanyName", "")})

                    myRpt.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "Challan.Qty", "")})
                    myRpt.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "Challan.Qty", "")})
                    myRpt.XrLabel3.Text = myRpt.XrLabel3.Text & "  " & Format(dtpFrom.EditValue, "dd/MM/yyyy") & " and " & Format(dtpTo.EditValue, "dd/MM/yyyy")
                    myRpt.XrLabel13.Text = Format(Now, "dd/MM/yyyy")


                    myRpt.ShowPreview()
                    adp.Dispose()

                Case "BW_CW_Sales"
                    Dim myRpt As New rptCW_BW_Sales

                    Dim ds As New DataSet
                    Dim strSql As String
                    If strID = "" And strGroupID.Trim = "" Then
                        strSql = "SELECT format(ChallanMaster.Challan_dt,'dd/MM/yyyy') as CDate, ChallanMaster.Challan_No, ChallanDetail.BatchID, CustomerMaster.CustName,ChallanDetail.Qty, Sum([Qty]*[ChallanDetail]![Rate]) AS Expr1,FGMaster.FGName " _
                            & " FROM ((ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID " _
                            & " GROUP BY ChallanMaster.Challan_No, ChallanDetail.BatchID, CustomerMaster.CustName, ChallanMaster.Challan_dt, FGMaster.FGName,ChallanDetail.Qty,ChallanMaster.CID " _
                            & " HAVING (((ChallanMaster.Challan_dt) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# AND #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#)); "
                    ElseIf strID <> "" And strGroupID.Trim <> "" Then
                        strSql = "SELECT format(ChallanMaster.Challan_dt,'dd/MM/yyyy') as CDate, ChallanMaster.Challan_No, ChallanDetail.BatchID, CustomerMaster.CustName,ChallanDetail.Qty, Sum([Qty]*[ChallanDetail]![Rate]) AS Expr1,FGMaster.FGName " _
                            & " FROM ((ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID " _
                            & " GROUP BY ChallanMaster.Challan_No, ChallanDetail.BatchID, CustomerMaster.CustName, ChallanMaster.Challan_dt, FGMaster.FGName,ChallanDetail.Qty,ChallanMaster.CID " _
                            & " HAVING (((ChallanMaster.Challan_dt) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# AND #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((ChallanDetail.BatchID)='" & strID.Trim & "') AND ((ChallanMaster.CID)='" & strGroupID.Trim & "'));"
                    ElseIf strID = "" And strGroupID.Trim <> "" Then

                        strSql = "SELECT format(ChallanMaster.Challan_dt,'dd/MM/yyyy') as CDate, ChallanMaster.Challan_No, ChallanDetail.BatchID, CustomerMaster.CustName,ChallanDetail.Qty, Sum([Qty]*[ChallanDetail]![Rate]) AS Expr1,FGMaster.FGName " _
                            & " FROM ((ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID " _
                            & " GROUP BY ChallanMaster.Challan_No, ChallanDetail.BatchID, CustomerMaster.CustName, ChallanMaster.Challan_dt, FGMaster.FGName,ChallanDetail.Qty,ChallanMaster.CID " _
                            & " HAVING (((ChallanMaster.Challan_dt) Between # " & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# AND #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((ChallanMaster.CID)='" & strGroupID.Trim & "'))"

                    ElseIf strID <> "" And strGroupID.Trim = "" Then
                        strSql = "SELECT format(ChallanMaster.Challan_dt,'dd/MM/yyyy') as CDate, ChallanMaster.Challan_No, ChallanDetail.BatchID, CustomerMaster.CustName,ChallanDetail.Qty, Sum([Qty]*[ChallanDetail]![Rate]) AS Expr1,FGMaster.FGName " _
                            & " FROM ((ChallanMaster INNER JOIN CustomerMaster ON ChallanMaster.CID = CustomerMaster.CID) INNER JOIN ChallanDetail ON ChallanMaster.Challan_No = ChallanDetail.Challan_No) INNER JOIN FGMaster ON ChallanDetail.FID = FGMaster.FID " _
                            & " GROUP BY ChallanMaster.Challan_No, ChallanDetail.BatchID, CustomerMaster.CustName, ChallanMaster.Challan_dt, FGMaster.FGName,ChallanDetail.Qty,ChallanMaster.CID " _
                            & " HAVING (((ChallanMaster.Challan_dt) Between #" & Format(dtpFrom.EditValue, "MM/dd/yyyy") & "# AND #" & Format(dtpTo.EditValue, "MM/dd/yyyy") & "#) AND ((ChallanDetail.BatchID)='" & strID.Trim & "'))"
                    End If
                    Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)
                    adp.Fill(ds, "Challan")

                    adp.SelectCommand.CommandText = "Select * from companyMaster"
                    adp.Fill(ds, "Company")

                    myrpt.DataSource = ds.Tables(0)

                    myRpt.XrTableCell1.DataBindings.Add("Text", ds, "Challan.CDate")
                    myRpt.XrTableCell2.DataBindings.Add("Text", ds, "Challan_No")
                    myRpt.XrTableCell3.DataBindings.Add("Text", ds, "Challan.Qty")
                    myRpt.XrTableCell7.DataBindings.Add("Text", ds, "Challan.FGName")
                    myRpt.XrLabel2.DataBindings.Add("Text", ds, "Company.CompanyName")

                    myRpt.GrpHeaderCust.GroupFields.Item(0).FieldName = "BatchID"
                    myRpt.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "Challan.BatchID", "")})

                    myRpt.GrpHeaderBatch.GroupFields.Item(0).FieldName = "CustName"
                    myRpt.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "Challan.CustName", "")})

                    myRpt.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "Company.CompanyName", "")})

                    myRpt.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "Challan.Qty", "")})
                    myRpt.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", ds, "Challan.Qty", "")})
                    myRpt.XrLabel3.Text = myRpt.XrLabel3.Text & "  " & Format(dtpFrom.EditValue, "MM/dd/yyyy") & " and " & Format(dtpTo.EditValue, "dd/MM/yyyy")
                    myRpt.XrLabel13.Text = Format(Now, "dd/MM/yyyy")

                    myrpt.XrLabel5.Text = "Batch No"
                    myrpt.XrLabel4.Text = "Customer"


                    myRpt.ShowPreview()
                    adp.Dispose()



            End Select
            Me.Close()
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
                strID = row(1).ToString
            Else
                strID = ""
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub

    Private Sub lkupGroup_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkupGroup.EditValueChanged
        Try
            If lkupGroup.EditValue <> "" Then
                Dim row As DataRowView = lkupGroup.Properties.GetDataSourceRowByKeyValue(lkupGroup.EditValue)
                strGroupID = row(1).ToString
            Else
                strGroupID = ""
            End If
        Catch ex As Exception
            If show_error Then
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub
End Class