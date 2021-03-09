<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptDateWisePackingVI
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
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrTabCellVINO = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabCellVIDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabCellProduct = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabCellBatchNo = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabCellPackingVINo = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabCellQCQty = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabCellExpDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.xrlblCompanytitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrlblDateValue = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrlblReportTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrlblVINo = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrlblVIDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrlblProduct = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrlblBatchNo = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrlblPackingVI = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrlblQCQty = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrlblExpDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrlblPVIDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrlblPVIDateVal = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabCellMISNo = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabCellWONo = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.HeightF = 34.99997!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(810.0001!, 25.0!)
        Me.XrTable2.StylePriority.UseBorders = False
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTabCellVINO, Me.xrTabCellVIDate, Me.xrTabCellProduct, Me.xrTabCellBatchNo, Me.xrTabCellPackingVINo, Me.xrTabCellMISNo, Me.xrTabCellWONo, Me.xrTabCellQCQty, Me.xrTabCellExpDate})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'xrTabCellVINO
        '
        Me.xrTabCellVINO.Name = "xrTabCellVINO"
        Me.xrTabCellVINO.Text = "VI No"
        Me.xrTabCellVINO.Weight = 0.32632169581110781R
        '
        'xrTabCellVIDate
        '
        Me.xrTabCellVIDate.Name = "xrTabCellVIDate"
        Me.xrTabCellVIDate.Text = "VI Date"
        Me.xrTabCellVIDate.Weight = 0.31137129014697373R
        '
        'xrTabCellProduct
        '
        Me.xrTabCellProduct.Name = "xrTabCellProduct"
        Me.xrTabCellProduct.Text = "Product"
        Me.xrTabCellProduct.Weight = 0.73607229962078846R
        '
        'xrTabCellBatchNo
        '
        Me.xrTabCellBatchNo.Name = "xrTabCellBatchNo"
        Me.xrTabCellBatchNo.Text = "Batch No"
        Me.xrTabCellBatchNo.Weight = 0.34492749222733171R
        '
        'xrTabCellPackingVINo
        '
        Me.xrTabCellPackingVINo.Name = "xrTabCellPackingVINo"
        Me.xrTabCellPackingVINo.Text = "Packing VI No"
        Me.xrTabCellPackingVINo.Weight = 0.34467511873705886R
        '
        'xrTabCellQCQty
        '
        Me.xrTabCellQCQty.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTabCellQCQty.Name = "xrTabCellQCQty"
        Me.xrTabCellQCQty.StylePriority.UseBorders = False
        Me.xrTabCellQCQty.StylePriority.UseTextAlignment = False
        Me.xrTabCellQCQty.Text = "QC Qty"
        Me.xrTabCellQCQty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.xrTabCellQCQty.Weight = 0.18836313757810619R
        '
        'xrTabCellExpDate
        '
        Me.xrTabCellExpDate.Name = "xrTabCellExpDate"
        Me.xrTabCellExpDate.StylePriority.UseTextAlignment = False
        Me.xrTabCellExpDate.Text = "Exp. Date"
        Me.xrTabCellExpDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.xrTabCellExpDate.Weight = 0.31021990562265739R
        '
        'TopMargin
        '
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.xrlblCompanytitle, Me.XrLabel12, Me.xrlblDateValue, Me.xrlblReportTitle})
        Me.PageHeader.HeightF = 102.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 77.00001!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(630.0!, 23.0!)
        '
        'xrlblCompanytitle
        '
        Me.xrlblCompanytitle.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrlblCompanytitle.ForeColor = System.Drawing.Color.Maroon
        Me.xrlblCompanytitle.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 10.00001!)
        Me.xrlblCompanytitle.Name = "xrlblCompanytitle"
        Me.xrlblCompanytitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlblCompanytitle.SizeF = New System.Drawing.SizeF(475.0!, 34.0!)
        Me.xrlblCompanytitle.Text = "xrlblCompanytitle"
        Me.xrlblCompanytitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(497.5!, 10.00001!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(50.0!, 25.0!)
        Me.XrLabel12.Text = "Date:"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlblDateValue
        '
        Me.xrlblDateValue.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.xrlblDateValue.LocationFloat = New DevExpress.Utils.PointFloat(547.5!, 10.00001!)
        Me.xrlblDateValue.Name = "xrlblDateValue"
        Me.xrlblDateValue.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlblDateValue.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        Me.xrlblDateValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlblReportTitle
        '
        Me.xrlblReportTitle.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.xrlblReportTitle.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 59.00002!)
        Me.xrlblReportTitle.Name = "xrlblReportTitle"
        Me.xrlblReportTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlblReportTitle.SizeF = New System.Drawing.SizeF(630.0!, 25.0!)
        Me.xrlblReportTitle.Text = "Date wise Packing Visual Inspection Between {0} and {1}"
        Me.xrlblReportTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrTable1, Me.xrlblPVIDate, Me.xrlblPVIDateVal})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 93.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 41.66667!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(337.5!, 2.083332!)
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 65.99998!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(810.0001!, 25.0!)
        Me.XrTable1.StylePriority.UseBorders = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrlblVINo, Me.xrlblVIDate, Me.xrlblProduct, Me.xrlblBatchNo, Me.xrlblPackingVI, Me.XrTableCell1, Me.XrTableCell3, Me.xrlblQCQty, Me.xrlblExpDate})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'xrlblVINo
        '
        Me.xrlblVINo.Name = "xrlblVINo"
        Me.xrlblVINo.StylePriority.UseTextAlignment = False
        Me.xrlblVINo.Text = "VI No"
        Me.xrlblVINo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.xrlblVINo.Weight = 0.32632169581110781R
        '
        'xrlblVIDate
        '
        Me.xrlblVIDate.Name = "xrlblVIDate"
        Me.xrlblVIDate.StylePriority.UseTextAlignment = False
        Me.xrlblVIDate.Text = "VI Date"
        Me.xrlblVIDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.xrlblVIDate.Weight = 0.31137129014697373R
        '
        'xrlblProduct
        '
        Me.xrlblProduct.Name = "xrlblProduct"
        Me.xrlblProduct.StylePriority.UseTextAlignment = False
        Me.xrlblProduct.Text = "Product"
        Me.xrlblProduct.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.xrlblProduct.Weight = 0.73607227257608354R
        '
        'xrlblBatchNo
        '
        Me.xrlblBatchNo.Name = "xrlblBatchNo"
        Me.xrlblBatchNo.StylePriority.UseTextAlignment = False
        Me.xrlblBatchNo.Text = "Batch No"
        Me.xrlblBatchNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.xrlblBatchNo.Weight = 0.34492739605058592R
        '
        'xrlblPackingVI
        '
        Me.xrlblPackingVI.Name = "xrlblPackingVI"
        Me.xrlblPackingVI.StylePriority.UseTextAlignment = False
        Me.xrlblPackingVI.Text = "Packing VI No"
        Me.xrlblPackingVI.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.xrlblPackingVI.Weight = 0.34467532670372114R
        '
        'xrlblQCQty
        '
        Me.xrlblQCQty.Name = "xrlblQCQty"
        Me.xrlblQCQty.StylePriority.UseTextAlignment = False
        Me.xrlblQCQty.Text = "QC Qty"
        Me.xrlblQCQty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.xrlblQCQty.Weight = 0.17803908406188243R
        '
        'xrlblExpDate
        '
        Me.xrlblExpDate.Name = "xrlblExpDate"
        Me.xrlblExpDate.StylePriority.UseTextAlignment = False
        Me.xrlblExpDate.Text = "Exp. Date"
        Me.xrlblExpDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.xrlblExpDate.Weight = 0.32054362547862286R
        '
        'xrlblPVIDate
        '
        Me.xrlblPVIDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlblPVIDate.ForeColor = System.Drawing.Color.DarkCyan
        Me.xrlblPVIDate.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 10.00001!)
        Me.xrlblPVIDate.Name = "xrlblPVIDate"
        Me.xrlblPVIDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlblPVIDate.SizeF = New System.Drawing.SizeF(233.3333!, 25.0!)
        Me.xrlblPVIDate.StylePriority.UseFont = False
        Me.xrlblPVIDate.StylePriority.UseForeColor = False
        Me.xrlblPVIDate.StylePriority.UseTextAlignment = False
        Me.xrlblPVIDate.Text = "Packing Visual Inspection Date:"
        Me.xrlblPVIDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlblPVIDateVal
        '
        Me.xrlblPVIDateVal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlblPVIDateVal.ForeColor = System.Drawing.Color.DarkCyan
        Me.xrlblPVIDateVal.LocationFloat = New DevExpress.Utils.PointFloat(245.8333!, 10.00001!)
        Me.xrlblPVIDateVal.Name = "xrlblPVIDateVal"
        Me.xrlblPVIDateVal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlblPVIDateVal.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        Me.xrlblPVIDateVal.StylePriority.UseFont = False
        Me.xrlblPVIDateVal.StylePriority.UseForeColor = False
        Me.xrlblPVIDateVal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "MIS No."
        Me.XrTableCell1.Weight = 0.23138493678398195R
        '
        'xrTabCellMISNo
        '
        Me.xrTabCellMISNo.Name = "xrTabCellMISNo"
        Me.xrTabCellMISNo.Text = "MIS No"
        Me.xrTabCellMISNo.Weight = 0.23138516823818395R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "W.O No"
        Me.XrTableCell3.Weight = 0.20666437238704097R
        '
        'xrTabCellWONo
        '
        Me.xrTabCellWONo.Name = "xrTabCellWONo"
        Me.xrTabCellWONo.Text = "WO No"
        Me.xrTabCellWONo.Weight = 0.20666389201779184R
        '
        'rptDateWisePackingVI
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageHeader, Me.GroupHeader1})
        Me.Margins = New System.Drawing.Printing.Margins(9, 11, 100, 100)
        Me.Version = "10.1"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents xrlblCompanytitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlblDateValue As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlblReportTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrTabCellVINO As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabCellVIDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabCellProduct As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabCellBatchNo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabCellPackingVINo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabCellQCQty As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabCellExpDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrlblVINo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrlblVIDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrlblProduct As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrlblBatchNo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrlblPackingVI As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrlblQCQty As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrlblExpDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrlblPVIDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlblPVIDateVal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrTabCellMISNo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabCellWONo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
End Class
