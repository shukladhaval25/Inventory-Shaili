<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptBWFG
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
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrTabCellBatchDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabCellMfgDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabCellExpDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabCellQty = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.xrlblReportTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrlblCompanytitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrlblDateValue = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.grpHeaderFG = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrBatchDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrMfgDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrExpDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabCellBatchNo = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrBatchNo = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabCellProductName = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.HeightF = 28.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(11.0!, 0.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(659.0!, 25.0!)
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTabCellBatchNo, Me.xrTabCellProductName, Me.xrTabCellBatchDate, Me.xrTabCellMfgDate, Me.xrTabCellExpDate, Me.xrTabCellQty})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96.0!)
        Me.XrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow1.Weight = 1.0R
        '
        'xrTabCellBatchDate
        '
        Me.xrTabCellBatchDate.Name = "xrTabCellBatchDate"
        Me.xrTabCellBatchDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrTabCellBatchDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.xrTabCellBatchDate.Weight = 0.1294890709096998R
        '
        'xrTabCellMfgDate
        '
        Me.xrTabCellMfgDate.Name = "xrTabCellMfgDate"
        Me.xrTabCellMfgDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrTabCellMfgDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.xrTabCellMfgDate.Weight = 0.1346104438098682R
        '
        'xrTabCellExpDate
        '
        Me.xrTabCellExpDate.Name = "xrTabCellExpDate"
        Me.xrTabCellExpDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrTabCellExpDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.xrTabCellExpDate.Weight = 0.14434744989745354R
        '
        'xrTabCellQty
        '
        Me.xrTabCellQty.Name = "xrTabCellQty"
        Me.xrTabCellQty.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrTabCellQty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.xrTabCellQty.Weight = 0.13827773978388183R
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 46.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10, Me.XrPageInfo1})
        Me.BottomMargin.HeightF = 34.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(541.9999!, 9.999974!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(66.0!, 17.0!)
        Me.XrLabel10.Text = "Page No.:"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(616.9999!, 9.999974!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(50.0!, 17.0!)
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlblReportTitle, Me.xrlblCompanytitle, Me.XrLabel12, Me.xrlblDateValue, Me.XrLine2})
        Me.ReportHeader.HeightF = 91.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'xrlblReportTitle
        '
        Me.xrlblReportTitle.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.xrlblReportTitle.LocationFloat = New DevExpress.Utils.PointFloat(11.0!, 56.00001!)
        Me.xrlblReportTitle.Name = "xrlblReportTitle"
        Me.xrlblReportTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlblReportTitle.SizeF = New System.Drawing.SizeF(658.0!, 25.0!)
        Me.xrlblReportTitle.Text = "Batch wise Finish Good Between {0} and {1}"
        Me.xrlblReportTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlblCompanytitle
        '
        Me.xrlblCompanytitle.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrlblCompanytitle.ForeColor = System.Drawing.Color.Maroon
        Me.xrlblCompanytitle.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 12.5!)
        Me.xrlblCompanytitle.Name = "xrlblCompanytitle"
        Me.xrlblCompanytitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlblCompanytitle.SizeF = New System.Drawing.SizeF(475.0!, 34.0!)
        Me.xrlblCompanytitle.Text = "xrlblCompanytitle"
        Me.xrlblCompanytitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(500.0!, 12.5!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(50.0!, 25.0!)
        Me.XrLabel12.Text = "Date:"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlblDateValue
        '
        Me.xrlblDateValue.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.xrlblDateValue.LocationFloat = New DevExpress.Utils.PointFloat(550.0!, 12.5!)
        Me.xrlblDateValue.Name = "xrlblDateValue"
        Me.xrlblDateValue.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlblDateValue.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        Me.xrlblDateValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine2
        '
        Me.XrLine2.BackColor = System.Drawing.Color.White
        Me.XrLine2.BorderColor = System.Drawing.Color.IndianRed
        Me.XrLine2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLine2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(11.0!, 81.00001!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrLine2.SizeF = New System.Drawing.SizeF(659.0!, 9.0!)
        '
        'grpHeaderFG
        '
        Me.grpHeaderFG.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.grpHeaderFG.HeightF = 40.0!
        Me.grpHeaderFG.Name = "grpHeaderFG"
        '
        'XrTable2
        '
        Me.XrTable2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(11.0!, 10.00001!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96.0!)
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(659.0!, 25.0!)
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrBatchNo, Me.XrTableCell3, Me.xrBatchDate, Me.xrMfgDate, Me.xrExpDate, Me.XrTableCell6})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 96.0!)
        Me.XrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow2.Weight = 1.0R
        '
        'xrBatchDate
        '
        Me.xrBatchDate.Name = "xrBatchDate"
        Me.xrBatchDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrBatchDate.Text = "Batch Date"
        Me.xrBatchDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.xrBatchDate.Weight = 0.12948909406415973R
        '
        'xrMfgDate
        '
        Me.xrMfgDate.Name = "xrMfgDate"
        Me.xrMfgDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrMfgDate.Text = "Mfg. Date"
        Me.xrMfgDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.xrMfgDate.Weight = 0.1346104438098682R
        '
        'xrExpDate
        '
        Me.xrExpDate.Name = "xrExpDate"
        Me.xrExpDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.xrExpDate.Text = "Exp. Date"
        Me.xrExpDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.xrExpDate.Weight = 0.14434744989745354R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTableCell6.Text = "Qty"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell6.Weight = 0.13827778609280161R
        '
        'xrTabCellBatchNo
        '
        Me.xrTabCellBatchNo.Name = "xrTabCellBatchNo"
        Me.xrTabCellBatchNo.Weight = 0.13884673748103188R
        '
        'xrBatchNo
        '
        Me.xrBatchNo.Name = "xrBatchNo"
        Me.xrBatchNo.Text = "Batch No"
        Me.xrBatchNo.Weight = 0.13884673748103188R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "Product Name"
        Me.XrTableCell3.Weight = 0.31442848865468515R
        '
        'xrTabCellProductName
        '
        Me.xrTabCellProductName.Name = "xrTabCellProductName"
        Me.xrTabCellProductName.Weight = 0.3144285581180648R
        '
        'rptBWFG
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.grpHeaderFG})
        Me.Margins = New System.Drawing.Printing.Margins(72, 100, 46, 34)
        Me.Version = "10.1"
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents xrlblReportTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlblCompanytitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlblDateValue As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents grpHeaderFG As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrBatchDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrMfgDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrExpDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrTabCellBatchDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabCellMfgDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabCellExpDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabCellQty As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents xrTabCellBatchNo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabCellProductName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrBatchNo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
End Class
