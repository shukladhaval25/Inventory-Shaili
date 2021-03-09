<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDayBook
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.cmdReport = New DevExpress.XtraEditors.SimpleButton
        Me.grdTrans = New DevExpress.XtraGrid.GridControl
        Me.gvTrans = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.grpTransDate = New DevExpress.XtraEditors.GroupControl
        Me.chkAll = New DevExpress.XtraEditors.CheckEdit
        Me.chkGoodsRet = New DevExpress.XtraEditors.CheckEdit
        Me.chkDemoRet = New DevExpress.XtraEditors.CheckEdit
        Me.chkDemoIssue = New DevExpress.XtraEditors.CheckEdit
        Me.chkTI = New DevExpress.XtraEditors.CheckEdit
        Me.chkChallan = New DevExpress.XtraEditors.CheckEdit
        Me.chkOrder = New DevExpress.XtraEditors.CheckEdit
        Me.chkFGQC = New DevExpress.XtraEditors.CheckEdit
        Me.chkMIS = New DevExpress.XtraEditors.CheckEdit
        Me.chkReqMast = New DevExpress.XtraEditors.CheckEdit
        Me.chkRMVI = New DevExpress.XtraEditors.CheckEdit
        Me.chkPO = New DevExpress.XtraEditors.CheckEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdShow = New DevExpress.XtraEditors.SimpleButton
        Me.dtpTo = New DevExpress.XtraEditors.DateEdit
        Me.dtpFrom = New DevExpress.XtraEditors.DateEdit
        Me.grpDefTrans = New DevExpress.XtraEditors.GroupControl
        Me.lnkOneYear = New System.Windows.Forms.LinkLabel
        Me.lnkOneMonth = New System.Windows.Forms.LinkLabel
        Me.lnk15Days = New System.Windows.Forms.LinkLabel
        Me.lnkWeek = New System.Windows.Forms.LinkLabel
        Me.lnkYesterday = New System.Windows.Forms.LinkLabel
        Me.lnkToday = New System.Windows.Forms.LinkLabel
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grdTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpTransDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTransDate.SuspendLayout()
        CType(Me.chkAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkGoodsRet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDemoRet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDemoIssue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkChallan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOrder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFGQC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkMIS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkReqMast.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRMVI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDefTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDefTrans.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.cmdReport)
        Me.GroupControl1.Controls.Add(Me.grdTrans)
        Me.GroupControl1.Controls.Add(Me.grpTransDate)
        Me.GroupControl1.Controls.Add(Me.grpDefTrans)
        Me.GroupControl1.Location = New System.Drawing.Point(5, 11)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(834, 632)
        Me.GroupControl1.TabIndex = 19
        Me.GroupControl1.Text = "Day Book Register"
        '
        'cmdReport
        '
        Me.cmdReport.Location = New System.Drawing.Point(17, 607)
        Me.cmdReport.Name = "cmdReport"
        Me.cmdReport.Size = New System.Drawing.Size(162, 23)
        Me.cmdReport.TabIndex = 26
        Me.cmdReport.Text = "Show &Report"
        '
        'grdTrans
        '
        Me.grdTrans.EmbeddedNavigator.Name = ""
        Me.grdTrans.Location = New System.Drawing.Point(206, 23)
        Me.grdTrans.MainView = Me.gvTrans
        Me.grdTrans.Name = "grdTrans"
        Me.grdTrans.Size = New System.Drawing.Size(623, 604)
        Me.grdTrans.TabIndex = 21
        Me.grdTrans.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTrans})
        '
        'gvTrans
        '
        Me.gvTrans.GridControl = Me.grdTrans
        Me.gvTrans.Name = "gvTrans"
        Me.gvTrans.OptionsBehavior.Editable = False
        '
        'grpTransDate
        '
        Me.grpTransDate.Controls.Add(Me.chkAll)
        Me.grpTransDate.Controls.Add(Me.chkGoodsRet)
        Me.grpTransDate.Controls.Add(Me.chkDemoRet)
        Me.grpTransDate.Controls.Add(Me.chkDemoIssue)
        Me.grpTransDate.Controls.Add(Me.chkTI)
        Me.grpTransDate.Controls.Add(Me.chkChallan)
        Me.grpTransDate.Controls.Add(Me.chkOrder)
        Me.grpTransDate.Controls.Add(Me.chkFGQC)
        Me.grpTransDate.Controls.Add(Me.chkMIS)
        Me.grpTransDate.Controls.Add(Me.chkReqMast)
        Me.grpTransDate.Controls.Add(Me.chkRMVI)
        Me.grpTransDate.Controls.Add(Me.chkPO)
        Me.grpTransDate.Controls.Add(Me.Label2)
        Me.grpTransDate.Controls.Add(Me.Label1)
        Me.grpTransDate.Controls.Add(Me.cmdShow)
        Me.grpTransDate.Controls.Add(Me.dtpTo)
        Me.grpTransDate.Controls.Add(Me.dtpFrom)
        Me.grpTransDate.Location = New System.Drawing.Point(6, 205)
        Me.grpTransDate.Name = "grpTransDate"
        Me.grpTransDate.Size = New System.Drawing.Size(194, 396)
        Me.grpTransDate.TabIndex = 20
        Me.grpTransDate.Text = "Advance Option"
        '
        'chkAll
        '
        Me.chkAll.Location = New System.Drawing.Point(8, 342)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Properties.Caption = "Show All"
        Me.chkAll.Size = New System.Drawing.Size(172, 19)
        Me.chkAll.TabIndex = 24
        '
        'chkGoodsRet
        '
        Me.chkGoodsRet.Location = New System.Drawing.Point(8, 323)
        Me.chkGoodsRet.Name = "chkGoodsRet"
        Me.chkGoodsRet.Properties.Caption = "Show only Goods Return"
        Me.chkGoodsRet.Size = New System.Drawing.Size(172, 19)
        Me.chkGoodsRet.TabIndex = 23
        '
        'chkDemoRet
        '
        Me.chkDemoRet.Location = New System.Drawing.Point(8, 285)
        Me.chkDemoRet.Name = "chkDemoRet"
        Me.chkDemoRet.Properties.Caption = "Show only Demo Return"
        Me.chkDemoRet.Size = New System.Drawing.Size(172, 19)
        Me.chkDemoRet.TabIndex = 22
        '
        'chkDemoIssue
        '
        Me.chkDemoIssue.Location = New System.Drawing.Point(8, 266)
        Me.chkDemoIssue.Name = "chkDemoIssue"
        Me.chkDemoIssue.Properties.Caption = "Show only Demo Issue"
        Me.chkDemoIssue.Size = New System.Drawing.Size(172, 19)
        Me.chkDemoIssue.TabIndex = 21
        '
        'chkTI
        '
        Me.chkTI.Location = New System.Drawing.Point(8, 304)
        Me.chkTI.Name = "chkTI"
        Me.chkTI.Properties.Caption = "Show only Trading Inward"
        Me.chkTI.Size = New System.Drawing.Size(172, 19)
        Me.chkTI.TabIndex = 20
        '
        'chkChallan
        '
        Me.chkChallan.Location = New System.Drawing.Point(8, 247)
        Me.chkChallan.Name = "chkChallan"
        Me.chkChallan.Properties.Caption = "Show only Challan"
        Me.chkChallan.Size = New System.Drawing.Size(172, 19)
        Me.chkChallan.TabIndex = 19
        '
        'chkOrder
        '
        Me.chkOrder.Location = New System.Drawing.Point(8, 228)
        Me.chkOrder.Name = "chkOrder"
        Me.chkOrder.Properties.Caption = "Show only Order Memo"
        Me.chkOrder.Size = New System.Drawing.Size(172, 19)
        Me.chkOrder.TabIndex = 18
        '
        'chkFGQC
        '
        Me.chkFGQC.Location = New System.Drawing.Point(8, 209)
        Me.chkFGQC.Name = "chkFGQC"
        Me.chkFGQC.Properties.Caption = "Show only VI of Finish Goods"
        Me.chkFGQC.Size = New System.Drawing.Size(172, 19)
        Me.chkFGQC.TabIndex = 17
        '
        'chkMIS
        '
        Me.chkMIS.Location = New System.Drawing.Point(8, 190)
        Me.chkMIS.Name = "chkMIS"
        Me.chkMIS.Properties.Caption = "Show only MIS"
        Me.chkMIS.Size = New System.Drawing.Size(172, 19)
        Me.chkMIS.TabIndex = 16
        '
        'chkReqMast
        '
        Me.chkReqMast.Location = New System.Drawing.Point(8, 171)
        Me.chkReqMast.Name = "chkReqMast"
        Me.chkReqMast.Properties.Caption = "Show only Requisition Master"
        Me.chkReqMast.Size = New System.Drawing.Size(172, 19)
        Me.chkReqMast.TabIndex = 15
        '
        'chkRMVI
        '
        Me.chkRMVI.Location = New System.Drawing.Point(8, 152)
        Me.chkRMVI.Name = "chkRMVI"
        Me.chkRMVI.Properties.Caption = "Show only RMVI"
        Me.chkRMVI.Size = New System.Drawing.Size(172, 19)
        Me.chkRMVI.TabIndex = 14
        '
        'chkPO
        '
        Me.chkPO.Location = New System.Drawing.Point(8, 133)
        Me.chkPO.Name = "chkPO"
        Me.chkPO.Properties.Caption = "Show Only Purchase Order"
        Me.chkPO.Size = New System.Drawing.Size(172, 19)
        Me.chkPO.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Transaction To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Transaction From"
        '
        'cmdShow
        '
        Me.cmdShow.Location = New System.Drawing.Point(11, 367)
        Me.cmdShow.Name = "cmdShow"
        Me.cmdShow.Size = New System.Drawing.Size(162, 23)
        Me.cmdShow.TabIndex = 4
        Me.cmdShow.Text = "&Show Transactions"
        '
        'dtpTo
        '
        Me.dtpTo.EditValue = New Date(2007, 1, 19, 0, 0, 0, 0)
        Me.dtpTo.Location = New System.Drawing.Point(8, 104)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpTo.Properties.DisplayFormat.FormatString = "d"
        Me.dtpTo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.dtpTo.Size = New System.Drawing.Size(165, 20)
        Me.dtpTo.TabIndex = 3
        '
        'dtpFrom
        '
        Me.dtpFrom.EditValue = New Date(2007, 1, 19, 0, 0, 0, 0)
        Me.dtpFrom.Location = New System.Drawing.Point(8, 54)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpFrom.Properties.DisplayFormat.FormatString = "d"
        Me.dtpFrom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.dtpFrom.Size = New System.Drawing.Size(165, 20)
        Me.dtpFrom.TabIndex = 1
        '
        'grpDefTrans
        '
        Me.grpDefTrans.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDefTrans.Appearance.Options.UseFont = True
        Me.grpDefTrans.Controls.Add(Me.lnkOneYear)
        Me.grpDefTrans.Controls.Add(Me.lnkOneMonth)
        Me.grpDefTrans.Controls.Add(Me.lnk15Days)
        Me.grpDefTrans.Controls.Add(Me.lnkWeek)
        Me.grpDefTrans.Controls.Add(Me.lnkYesterday)
        Me.grpDefTrans.Controls.Add(Me.lnkToday)
        Me.grpDefTrans.Location = New System.Drawing.Point(5, 23)
        Me.grpDefTrans.Name = "grpDefTrans"
        Me.grpDefTrans.Size = New System.Drawing.Size(195, 176)
        Me.grpDefTrans.TabIndex = 20
        Me.grpDefTrans.Text = "Transaction By"
        '
        'lnkOneYear
        '
        Me.lnkOneYear.AutoSize = True
        Me.lnkOneYear.Location = New System.Drawing.Point(5, 151)
        Me.lnkOneYear.Name = "lnkOneYear"
        Me.lnkOneYear.Size = New System.Drawing.Size(75, 13)
        Me.lnkOneYear.TabIndex = 26
        Me.lnkOneYear.TabStop = True
        Me.lnkOneYear.Text = "Last One Year"
        '
        'lnkOneMonth
        '
        Me.lnkOneMonth.AutoSize = True
        Me.lnkOneMonth.Location = New System.Drawing.Point(5, 127)
        Me.lnkOneMonth.Name = "lnkOneMonth"
        Me.lnkOneMonth.Size = New System.Drawing.Size(83, 13)
        Me.lnkOneMonth.TabIndex = 25
        Me.lnkOneMonth.TabStop = True
        Me.lnkOneMonth.Text = "Last One Month"
        '
        'lnk15Days
        '
        Me.lnk15Days.AutoSize = True
        Me.lnk15Days.Location = New System.Drawing.Point(5, 103)
        Me.lnk15Days.Name = "lnk15Days"
        Me.lnk15Days.Size = New System.Drawing.Size(69, 13)
        Me.lnk15Days.TabIndex = 24
        Me.lnk15Days.TabStop = True
        Me.lnk15Days.Text = "Last 15 Days"
        '
        'lnkWeek
        '
        Me.lnkWeek.AutoSize = True
        Me.lnkWeek.Location = New System.Drawing.Point(5, 79)
        Me.lnkWeek.Name = "lnkWeek"
        Me.lnkWeek.Size = New System.Drawing.Size(86, 13)
        Me.lnkWeek.TabIndex = 23
        Me.lnkWeek.TabStop = True
        Me.lnkWeek.Text = "Lasat One Week"
        '
        'lnkYesterday
        '
        Me.lnkYesterday.AutoSize = True
        Me.lnkYesterday.Location = New System.Drawing.Point(5, 55)
        Me.lnkYesterday.Name = "lnkYesterday"
        Me.lnkYesterday.Size = New System.Drawing.Size(56, 13)
        Me.lnkYesterday.TabIndex = 22
        Me.lnkYesterday.TabStop = True
        Me.lnkYesterday.Text = "Yesterday"
        '
        'lnkToday
        '
        Me.lnkToday.AutoSize = True
        Me.lnkToday.Location = New System.Drawing.Point(5, 31)
        Me.lnkToday.Name = "lnkToday"
        Me.lnkToday.Size = New System.Drawing.Size(42, 13)
        Me.lnkToday.TabIndex = 21
        Me.lnkToday.TabStop = True
        Me.lnkToday.Text = "Todays"
        '
        'frmDayBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 648)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmDayBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Day Book Details"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grdTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpTransDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTransDate.ResumeLayout(False)
        Me.grpTransDate.PerformLayout()
        CType(Me.chkAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkGoodsRet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDemoRet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDemoIssue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkChallan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOrder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFGQC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkMIS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkReqMast.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRMVI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDefTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDefTrans.ResumeLayout(False)
        Me.grpDefTrans.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpTransDate As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdShow As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtpTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtpFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents grpDefTrans As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkTI As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkChallan As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkOrder As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkFGQC As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkMIS As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkReqMast As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkRMVI As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkPO As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lnkWeek As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkYesterday As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkToday As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkOneYear As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkOneMonth As System.Windows.Forms.LinkLabel
    Friend WithEvents lnk15Days As System.Windows.Forms.LinkLabel
    Friend WithEvents chkDemoIssue As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkDemoRet As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAll As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkGoodsRet As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents grdTrans As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvTrans As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cmdReport As DevExpress.XtraEditors.SimpleButton
End Class
