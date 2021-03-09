<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptMISRejectionComponent
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
        Me.xrTabCellID = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabCellName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabCellBatchNo = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabCellMisQtyVal = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabCellType = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTabCellQty = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.lblRetDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblRetDateVal = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblFGVal = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblFG = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblMISDateVal = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblMISDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblMISNoVal = New DevExpress.XtraReports.UI.XRLabel()
        Me.lblMISNO = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrlblDateVal = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrlblDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportTitle = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrlblWOVal = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.xrTableExpired.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0.0!)
        Me.xrTableExpired.Name = "xrTableExpired"
        Me.xrTableExpired.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRowFG_Expired})
        Me.xrTableExpired.SizeF = New System.Drawing.SizeF(715.3339!, 25.0!)
        Me.xrTableExpired.StylePriority.UseBorders = False
        '
        'xrTableRowFG_Expired
        '
        Me.xrTableRowFG_Expired.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTabCellID, Me.xrTabCellName, Me.xrTabCellBatchNo, Me.xrTabCellMisQtyVal, Me.xrTabCellType, Me.xrTabCellQty})
        Me.xrTableRowFG_Expired.Name = "xrTableRowFG_Expired"
        Me.xrTableRowFG_Expired.Weight = 1.0R
        '
        'xrTabCellID
        '
        Me.xrTabCellID.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTabCellID.Name = "xrTabCellID"
        Me.xrTabCellID.StylePriority.UseBorders = False
        Me.xrTabCellID.Text = "xrTabCellID"
        Me.xrTabCellID.Weight = 0.21633799041043858R
        '
        'xrTabCellName
        '
        Me.xrTabCellName.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTabCellName.Name = "xrTabCellName"
        Me.xrTabCellName.StylePriority.UseBorders = False
        Me.xrTabCellName.Text = "xrTabCellProductName"
        Me.xrTabCellName.Weight = 1.0946132977978396R
        '
        'xrTabCellBatchNo
        '
        Me.xrTabCellBatchNo.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTabCellBatchNo.Name = "xrTabCellBatchNo"
        Me.xrTabCellBatchNo.StylePriority.UseBorders = False
        Me.xrTabCellBatchNo.Text = "xrTabCellBatchNo"
        Me.xrTabCellBatchNo.Weight = 0.49616202213713123R
        '
        'xrTabCellMisQtyVal
        '
        Me.xrTabCellMisQtyVal.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTabCellMisQtyVal.Name = "xrTabCellMisQtyVal"
        Me.xrTabCellMisQtyVal.StylePriority.UseBorders = False
        Me.xrTabCellMisQtyVal.StylePriority.UseTextAlignment = False
        Me.xrTabCellMisQtyVal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.xrTabCellMisQtyVal.Weight = 0.38426263196886323R
        '
        'xrTabCellType
        '
        Me.xrTabCellType.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTabCellType.Name = "xrTabCellType"
        Me.xrTabCellType.StylePriority.UseBorders = False
        Me.xrTabCellType.StylePriority.UseTextAlignment = False
        Me.xrTabCellType.Text = "xrTabCellType"
        Me.xrTabCellType.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.xrTabCellType.Weight = 0.562833854485379R
        '
        'xrTabCellQty
        '
        Me.xrTabCellQty.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xrTabCellQty.Name = "xrTabCellQty"
        Me.xrTabCellQty.StylePriority.UseBorders = False
        Me.xrTabCellQty.StylePriority.UseTextAlignment = False
        Me.xrTabCellQty.Text = "xrTabCellQty"
        Me.xrTabCellQty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.xrTabCellQty.Weight = 0.44759566937465478R
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.xrlblWOVal, Me.lblRetDate, Me.lblRetDateVal, Me.lblFGVal, Me.lblFG, Me.lblMISDateVal, Me.lblMISDate, Me.lblMISNoVal, Me.lblMISNO, Me.xrlblDateVal, Me.xrlblDate, Me.XrLine1, Me.XrTable1, Me.ReportTitle})
        Me.TopMargin.HeightF = 192.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'lblRetDate
        '
        Me.lblRetDate.LocationFloat = New DevExpress.Utils.PointFloat(464.6252!, 99.20834!)
        Me.lblRetDate.Name = "lblRetDate"
        Me.lblRetDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblRetDate.SizeF = New System.Drawing.SizeF(83.83438!, 23.0!)
        Me.lblRetDate.Text = "Return Date:"
        '
        'lblRetDateVal
        '
        Me.lblRetDateVal.LocationFloat = New DevExpress.Utils.PointFloat(548.4596!, 99.20834!)
        Me.lblRetDateVal.Name = "lblRetDateVal"
        Me.lblRetDateVal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblRetDateVal.SizeF = New System.Drawing.SizeF(102.0833!, 23.0!)
        Me.lblRetDateVal.WordWrap = False
        '
        'lblFGVal
        '
        Me.lblFGVal.LocationFloat = New DevExpress.Utils.PointFloat(133.9583!, 130.2083!)
        Me.lblFGVal.Name = "lblFGVal"
        Me.lblFGVal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblFGVal.SizeF = New System.Drawing.SizeF(516.5846!, 22.99998!)
        '
        'lblFG
        '
        Me.lblFG.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 130.2083!)
        Me.lblFG.Name = "lblFG"
        Me.lblFG.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblFG.SizeF = New System.Drawing.SizeF(123.9583!, 22.99998!)
        Me.lblFG.Text = "Finish Good:"
        '
        'lblMISDateVal
        '
        Me.lblMISDateVal.LocationFloat = New DevExpress.Utils.PointFloat(250.8039!, 99.20834!)
        Me.lblMISDateVal.Name = "lblMISDateVal"
        Me.lblMISDateVal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblMISDateVal.SizeF = New System.Drawing.SizeF(102.0833!, 23.0!)
        Me.lblMISDateVal.WordWrap = False
        '
        'lblMISDate
        '
        Me.lblMISDate.LocationFloat = New DevExpress.Utils.PointFloat(189.3456!, 99.20834!)
        Me.lblMISDate.Name = "lblMISDate"
        Me.lblMISDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblMISDate.SizeF = New System.Drawing.SizeF(61.45834!, 23.0!)
        Me.lblMISDate.Text = "MIS Date:"
        '
        'lblMISNoVal
        '
        Me.lblMISNoVal.LocationFloat = New DevExpress.Utils.PointFloat(71.45834!, 99.20834!)
        Me.lblMISNoVal.Name = "lblMISNoVal"
        Me.lblMISNoVal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblMISNoVal.SizeF = New System.Drawing.SizeF(102.0833!, 23.0!)
        '
        'lblMISNO
        '
        Me.lblMISNO.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 99.20834!)
        Me.lblMISNO.Name = "lblMISNO"
        Me.lblMISNO.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lblMISNO.SizeF = New System.Drawing.SizeF(61.45834!, 23.0!)
        Me.lblMISNO.Text = "MIS No:"
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
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 163.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(715.3339!, 25.0!)
        Me.XrTable1.StylePriority.UseBorders = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell6, Me.XrTableCell4, Me.XrTableCell5})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "ID"
        Me.XrTableCell1.Weight = 0.21633802257019991R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "Product Name"
        Me.XrTableCell2.Weight = 1.0946132997869373R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "Batch No"
        Me.XrTableCell3.Weight = 0.49616188847561293R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Text = "MIS Qty"
        Me.XrTableCell6.Weight = 0.38426263370931846R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.Text = "Type"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell4.Weight = 0.56283371980536367R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "Qty"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell5.Weight = 0.44759593597573316R
        '
        'ReportTitle
        '
        Me.ReportTitle.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportTitle.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 23.91667!)
        Me.ReportTitle.Name = "ReportTitle"
        Me.ReportTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ReportTitle.SizeF = New System.Drawing.SizeF(559.7941!, 29.25!)
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
        'XrLabel1
        '
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(8.95834!, 65.625!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(104.1667!, 23.0!)
        Me.XrLabel1.Text = "Work Order No:"
        '
        'xrlblWOVal
        '
        Me.xrlblWOVal.LocationFloat = New DevExpress.Utils.PointFloat(113.125!, 65.625!)
        Me.xrlblWOVal.Name = "xrlblWOVal"
        Me.xrlblWOVal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlblWOVal.SizeF = New System.Drawing.SizeF(189.7622!, 23.0!)
        '
        'rptMISRejectionComponent
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Margins = New System.Drawing.Printing.Margins(65, 50, 192, 102)
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
    Friend WithEvents xrTabCellID As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabCellName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabCellBatchNo As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabCellType As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTabCellQty As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrlblDateVal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlblDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportTitle As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents lblRetDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblRetDateVal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblFGVal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblFG As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblMISDateVal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblMISDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblMISNoVal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lblMISNO As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrTabCellMisQtyVal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlblWOVal As DevExpress.XtraReports.UI.XRLabel
End Class
