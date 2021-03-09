<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptLineClearance
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrTableExpired = New DevExpress.XtraReports.UI.XRTable()
        Me.xrTableRowFG_Expired = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrTabCellProductName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabCellQty = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.xrlblDateVal = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrlblDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.ReportTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblFGVal = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblFG = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblWONoVal = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabBatchNo = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.xrTableExpired, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTableExpired})
        Me.Detail.HeightF = 36.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrTableExpired
        '
        Me.xrTableExpired.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.xrTableExpired.LocationFloat = New DevExpress.Utils.PointFloat(11.0417!, 0.0!)
        Me.xrTableExpired.Name = "xrTableExpired"
        Me.xrTableExpired.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRowFG_Expired})
        Me.xrTableExpired.SizeF = New System.Drawing.SizeF(715.334!, 25.0!)
        Me.xrTableExpired.StylePriority.UseBorders = False
        '
        'xrTableRowFG_Expired
        '
        Me.xrTableRowFG_Expired.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTabBatchNo, Me.xrTabCellProductName, Me.xrTabCellQty})
        Me.xrTableRowFG_Expired.Name = "xrTableRowFG_Expired"
        Me.xrTableRowFG_Expired.Weight = 1.0R
        '
        'xrTabCellProductName
        '
        Me.xrTabCellProductName.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTabCellProductName.Name = "xrTabCellProductName"
        Me.xrTabCellProductName.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.xrTabCellProductName.StylePriority.UseBorders = False
        Me.xrTabCellProductName.StylePriority.UsePadding = False
        Me.xrTabCellProductName.Text = "xrTabCellProductName"
        Me.xrTabCellProductName.Weight = 1.2312889879583151R
        '
        'xrTabCellQty
        '
        Me.xrTabCellQty.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTabCellQty.Name = "xrTabCellQty"
        Me.xrTabCellQty.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100.0!)
        Me.xrTabCellQty.StylePriority.UseBorders = False
        Me.xrTabCellQty.StylePriority.UsePadding = False
        Me.xrTabCellQty.StylePriority.UseTextAlignment = False
        Me.xrTabCellQty.Text = "xrTabCellQty"
        Me.xrTabCellQty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.xrTabCellQty.Weight = 1.0889118722490274R
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlblDateVal, Me.xrlblDate, Me.XrLine1, Me.ReportTitle})
        Me.TopMargin.HeightF = 61.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlblDateVal
        '
        Me.xrlblDateVal.LocationFloat = New DevExpress.Utils.PointFloat(625.3339!, 30.16667!)
        Me.xrlblDateVal.Name = "xrlblDateVal"
        Me.xrlblDateVal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlblDateVal.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xrlblDateVal.Text = "xrlblDateVal"
        '
        'xrlblDate
        '
        Me.xrlblDate.LocationFloat = New DevExpress.Utils.PointFloat(583.6672!, 30.16667!)
        Me.xrlblDate.Name = "xrlblDate"
        Me.xrlblDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlblDate.SizeF = New System.Drawing.SizeF(41.66669!, 23.0!)
        Me.xrlblDate.Text = "Date:"
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 53.16668!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(719.7917!, 2.0!)
        '
        'ReportTitle
        '
        Me.ReportTitle.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportTitle.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 23.91667!)
        Me.ReportTitle.Name = "ReportTitle"
        Me.ReportTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ReportTitle.SizeF = New System.Drawing.SizeF(559.7941!, 29.25!)
        Me.ReportTitle.StylePriority.UseFont = False
        Me.ReportTitle.Text = "Line Clearance Report"
        '
        'lblFGVal
        '
        Me.lblFGVal.LocationFloat = New DevExpress.Utils.PointFloat(135.0!, 10.00001!)
        Me.lblFGVal.Name = "lblFGVal"
        Me.lblFGVal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblFGVal.SizeF = New System.Drawing.SizeF(516.5846!, 22.99998!)
        '
        'lblFG
        '
        Me.lblFG.LocationFloat = New DevExpress.Utils.PointFloat(11.04167!, 10.00001!)
        Me.lblFG.Name = "lblFG"
        Me.lblFG.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblFG.SizeF = New System.Drawing.SizeF(123.9583!, 22.99998!)
        Me.lblFG.Text = "Finish Good:"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(11.04167!, 78.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(715.3339!, 25.0!)
        Me.XrTable1.StylePriority.UseBorders = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell5})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell2.StylePriority.UsePadding = False
        Me.XrTableCell2.Text = "Packing VI No"
        Me.XrTableCell2.Weight = 1.2312891477695189R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "Packing VI Date"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell5.Weight = 1.0889115222073198R
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
        Me.BottomMargin.HeightF = 102.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(676.3756!, 10.00001!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(48.95831!, 23.0!)
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.lblWONoVal, Me.lblFGVal, Me.lblFG, Me.XrTable1})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 103.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel1
        '
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(11.04171!, 37.99999!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(123.9583!, 22.99998!)
        Me.XrLabel1.Text = "Work Order No:"
        '
        'lblWONoVal
        '
        Me.lblWONoVal.LocationFloat = New DevExpress.Utils.PointFloat(135.0!, 37.99998!)
        Me.lblWONoVal.Name = "lblWONoVal"
        Me.lblWONoVal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblWONoVal.SizeF = New System.Drawing.SizeF(266.5846!, 22.99998!)
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.XrTableCell1.StylePriority.UsePadding = False
        Me.XrTableCell1.Text = "Batch No"
        Me.XrTableCell1.Weight = 0.88160483034632675R
        '
        'xrTabBatchNo
        '
        Me.xrTabBatchNo.Name = "xrTabBatchNo"
        Me.xrTabBatchNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.xrTabBatchNo.StylePriority.UsePadding = False
        Me.xrTabBatchNo.Text = "xrTabBatchNo"
        Me.xrTabBatchNo.Weight = 0.88160474256239885R
        '
        'rptLineClearance
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1})
        Me.Margins = New System.Drawing.Printing.Margins(56, 50, 61, 102)
        Me.Version = "10.1"
        CType(Me.xrTableExpired, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents xrTableExpired As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents xrTableRowFG_Expired As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrTabCellProductName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabCellQty As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrlblDateVal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlblDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents lblFGVal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblFG As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblWONoVal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrTabBatchNo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
End Class
