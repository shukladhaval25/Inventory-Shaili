<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptRejectionComponent
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
        Me.xrTabFG = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabProdut = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabMIS = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabMISDateVal = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabCellQty = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabMISNo = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabMISDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.xrTabRetDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabRetDateVal = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabRMVI = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabRMVINoVal = New DevExpress.XtraReports.UI.XRTableCell()
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
        Me.xrTableExpired.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 7.999992!)
        Me.xrTableExpired.Name = "xrTableExpired"
        Me.xrTableExpired.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRowFG_Expired})
        Me.xrTableExpired.SizeF = New System.Drawing.SizeF(778.9999!, 25.0!)
        Me.xrTableExpired.StylePriority.UseBorders = False
        '
        'xrTableRowFG_Expired
        '
        Me.xrTableRowFG_Expired.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTabFG, Me.xrTabProdut, Me.xrTabMIS, Me.xrTabMISDateVal, Me.xrTabRetDateVal, Me.xrTabRMVINoVal, Me.xrTabCellQty})
        Me.xrTableRowFG_Expired.Name = "xrTableRowFG_Expired"
        Me.xrTableRowFG_Expired.Weight = 1.0R
        '
        'xrTabFG
        '
        Me.xrTabFG.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTabFG.Name = "xrTabFG"
        Me.xrTabFG.StylePriority.UseBorders = False
        Me.xrTabFG.Text = "xrTabFG"
        Me.xrTabFG.Weight = 0.56602213335977858R
        '
        'xrTabProdut
        '
        Me.xrTabProdut.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTabProdut.Name = "xrTabProdut"
        Me.xrTabProdut.StylePriority.UseBorders = False
        Me.xrTabProdut.Text = "xrTabCellProductName"
        Me.xrTabProdut.Weight = 0.65501959269717558R
        '
        'xrTabMIS
        '
        Me.xrTabMIS.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTabMIS.Name = "xrTabMIS"
        Me.xrTabMIS.StylePriority.UseBorders = False
        Me.xrTabMIS.Weight = 0.38154240006433016R
        '
        'xrTabMISDateVal
        '
        Me.xrTabMISDateVal.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTabMISDateVal.Name = "xrTabMISDateVal"
        Me.xrTabMISDateVal.StylePriority.UseBorders = False
        Me.xrTabMISDateVal.StylePriority.UseTextAlignment = False
        Me.xrTabMISDateVal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.xrTabMISDateVal.Weight = 0.41435648475643555R
        '
        'xrTabCellQty
        '
        Me.xrTabCellQty.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTabCellQty.Name = "xrTabCellQty"
        Me.xrTabCellQty.StylePriority.UseBorders = False
        Me.xrTabCellQty.StylePriority.UseTextAlignment = False
        Me.xrTabCellQty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.xrTabCellQty.Weight = 0.35961330453042584R
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrTable1, Me.ReportTitle})
        Me.TopMargin.HeightF = 177.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 120.875!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(719.7917!, 2.0!)
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 145.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(778.9999!, 25.0!)
        Me.XrTable1.StylePriority.UseBorders = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.xrTabMISNo, Me.xrTabMISDate, Me.xrTabRetDate, Me.xrTabRMVI, Me.XrTableCell5})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "Finish Good"
        Me.XrTableCell1.Weight = 0.5660222887701033R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "Product Name"
        Me.XrTableCell2.Weight = 0.65501947047677955R
        '
        'xrTabMISNo
        '
        Me.xrTabMISNo.Name = "xrTabMISNo"
        Me.xrTabMISNo.Text = "MIS No"
        Me.xrTabMISNo.Weight = 0.38154239941787454R
        '
        'xrTabMISDate
        '
        Me.xrTabMISDate.Name = "xrTabMISDate"
        Me.xrTabMISDate.StylePriority.UseTextAlignment = False
        Me.xrTabMISDate.Text = "MIS Date"
        Me.xrTabMISDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.xrTabMISDate.Weight = 0.41435648508827116R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "Qty"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell5.Weight = 0.35961330552497517R
        '
        'ReportTitle
        '
        Me.ReportTitle.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportTitle.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 91.62502!)
        Me.ReportTitle.Name = "ReportTitle"
        Me.ReportTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ReportTitle.SizeF = New System.Drawing.SizeF(715.3339!, 29.25!)
        Me.ReportTitle.StylePriority.UseFont = False
        Me.ReportTitle.Text = "Material Rejection Component"
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
        'xrTabRetDate
        '
        Me.xrTabRetDate.Name = "xrTabRetDate"
        Me.xrTabRetDate.Text = "Return Date"
        Me.xrTabRetDate.Weight = 0.40997993110805259R
        '
        'xrTabRetDateVal
        '
        Me.xrTabRetDateVal.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTabRetDateVal.Name = "xrTabRetDateVal"
        Me.xrTabRetDateVal.StylePriority.UseBorders = False
        Me.xrTabRetDateVal.Weight = 0.40997993241722464R
        '
        'xrTabRMVI
        '
        Me.xrTabRMVI.Name = "xrTabRMVI"
        Me.xrTabRMVI.Text = "RMVI No"
        Me.xrTabRMVI.Weight = 0.4152716199371092R
        '
        'xrTabRMVINoVal
        '
        Me.xrTabRMVINoVal.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTabRMVINoVal.Name = "xrTabRMVINoVal"
        Me.xrTabRMVINoVal.StylePriority.UseBorders = False
        Me.xrTabRMVINoVal.Weight = 0.41527161834893606R
        '
        'rptRejectionComponent
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Margins = New System.Drawing.Printing.Margins(26, 25, 177, 102)
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
    Friend WithEvents xrTabFG As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabProdut As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabMIS As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabMISDateVal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabCellQty As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabMISNo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabMISDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents xrTabRetDateVal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabRMVINoVal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabRetDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabRMVI As DevExpress.XtraReports.UI.XRTableCell
End Class
