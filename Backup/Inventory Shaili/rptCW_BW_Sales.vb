Imports DevExpress.XtraReports.UI

Public Class rptCW_BW_Sales
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Component Designer generated code "

    Public Sub New(Container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        Container.Add(me)
    End Sub

    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Component overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Private WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Private WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    Friend WithEvents GrpHeaderBatch As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Public WithEvents GrpHeaderCust As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine7 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine8 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine9 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.GrpHeaderBatch = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLine8 = New DevExpress.XtraReports.UI.XRLine
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.GrpHeaderCust = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.XrLine9 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine7 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine6 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.Height = 30
        Me.Detail.Name = "Detail"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrTable1.Location = New System.Drawing.Point(33, 0)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.ParentStyleUsing.UseBorders = False
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.Size = New System.Drawing.Size(659, 25)
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell7, Me.XrTableCell3})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(659, 25)
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Size = New System.Drawing.Size(183, 25)
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Location = New System.Drawing.Point(183, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Size = New System.Drawing.Size(146, 25)
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Location = New System.Drawing.Point(546, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Size = New System.Drawing.Size(113, 25)
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel13, Me.XrLabel12, Me.XrLabel11, Me.XrLabel3})
        Me.PageHeader.Height = 76
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel13.Location = New System.Drawing.Point(592, 8)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.ParentStyleUsing.UseFont = False
        Me.XrLabel13.Size = New System.Drawing.Size(100, 25)
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel12.Location = New System.Drawing.Point(542, 8)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.ParentStyleUsing.UseFont = False
        Me.XrLabel12.Size = New System.Drawing.Size(50, 25)
        Me.XrLabel12.Text = "Date:"
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.ForeColor = System.Drawing.Color.Maroon
        Me.XrLabel11.Location = New System.Drawing.Point(25, 8)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.ParentStyleUsing.UseFont = False
        Me.XrLabel11.ParentStyleUsing.UseForeColor = False
        Me.XrLabel11.Size = New System.Drawing.Size(475, 34)
        Me.XrLabel11.Text = "XrLabel11"
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel3.Location = New System.Drawing.Point(25, 50)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.ParentStyleUsing.UseFont = False
        Me.XrLabel3.Size = New System.Drawing.Size(667, 25)
        Me.XrLabel3.Text = "Customer wise Batch wise Sales Between"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10, Me.XrPageInfo1})
        Me.PageFooter.Height = 29
        Me.PageFooter.Name = "PageFooter"
        '
        'XrLabel10
        '
        Me.XrLabel10.Location = New System.Drawing.Point(567, 8)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Size = New System.Drawing.Size(66, 17)
        Me.XrLabel10.Text = "Page No.:"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Location = New System.Drawing.Point(642, 8)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Size = New System.Drawing.Size(50, 17)
        '
        'GrpHeaderBatch
        '
        Me.GrpHeaderBatch.BackColor = System.Drawing.Color.White
        Me.GrpHeaderBatch.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine8, Me.XrTable2, Me.XrLine1, Me.XrLabel4, Me.XrLabel2})
        Me.GrpHeaderBatch.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GrpHeaderBatch.Height = 76
        Me.GrpHeaderBatch.Name = "GrpHeaderBatch"
        Me.GrpHeaderBatch.ParentStyleUsing.UseBackColor = False
        '
        'XrLine8
        '
        Me.XrLine8.BackColor = System.Drawing.Color.White
        Me.XrLine8.BorderColor = System.Drawing.Color.SaddleBrown
        Me.XrLine8.ForeColor = System.Drawing.Color.Teal
        Me.XrLine8.Location = New System.Drawing.Point(433, 0)
        Me.XrLine8.Name = "XrLine8"
        Me.XrLine8.ParentStyleUsing.UseBackColor = False
        Me.XrLine8.ParentStyleUsing.UseBorderColor = False
        Me.XrLine8.ParentStyleUsing.UseBorders = False
        Me.XrLine8.ParentStyleUsing.UseForeColor = False
        Me.XrLine8.Size = New System.Drawing.Size(259, 9)
        '
        'XrTable2
        '
        Me.XrTable2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.XrTable2.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrTable2.Location = New System.Drawing.Point(33, 50)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.ParentStyleUsing.UseBackColor = False
        Me.XrTable2.ParentStyleUsing.UseBorders = False
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.Size = New System.Drawing.Size(659, 25)
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell8, Me.XrTableCell6})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Size = New System.Drawing.Size(659, 25)
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Size = New System.Drawing.Size(183, 25)
        Me.XrTableCell4.Text = "Challan Date"
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Location = New System.Drawing.Point(183, 0)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Size = New System.Drawing.Size(146, 25)
        Me.XrTableCell5.Text = "Challan No"
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Location = New System.Drawing.Point(546, 0)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Size = New System.Drawing.Size(113, 25)
        Me.XrTableCell6.Text = "Qty"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLine1
        '
        Me.XrLine1.BackColor = System.Drawing.Color.White
        Me.XrLine1.BorderColor = System.Drawing.Color.SaddleBrown
        Me.XrLine1.ForeColor = System.Drawing.Color.Teal
        Me.XrLine1.Location = New System.Drawing.Point(433, 33)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.ParentStyleUsing.UseBackColor = False
        Me.XrLine1.ParentStyleUsing.UseBorderColor = False
        Me.XrLine1.ParentStyleUsing.UseBorders = False
        Me.XrLine1.ParentStyleUsing.UseForeColor = False
        Me.XrLine1.Size = New System.Drawing.Size(259, 9)
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.GhostWhite
        Me.XrLabel4.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.ForeColor = System.Drawing.Color.IndianRed
        Me.XrLabel4.Location = New System.Drawing.Point(433, 8)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.ParentStyleUsing.UseBackColor = False
        Me.XrLabel4.ParentStyleUsing.UseBorderColor = False
        Me.XrLabel4.ParentStyleUsing.UseFont = False
        Me.XrLabel4.ParentStyleUsing.UseForeColor = False
        Me.XrLabel4.Size = New System.Drawing.Size(75, 25)
        Me.XrLabel4.Text = "Batch No:"
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.GhostWhite
        Me.XrLabel2.BorderColor = System.Drawing.Color.Empty
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.ForeColor = System.Drawing.Color.IndianRed
        Me.XrLabel2.Location = New System.Drawing.Point(508, 8)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.ParentStyleUsing.UseBackColor = False
        Me.XrLabel2.ParentStyleUsing.UseBorderColor = False
        Me.XrLabel2.ParentStyleUsing.UseFont = False
        Me.XrLabel2.ParentStyleUsing.UseForeColor = False
        Me.XrLabel2.Size = New System.Drawing.Size(184, 25)
        '
        'GrpHeaderCust
        '
        Me.GrpHeaderCust.BackColor = System.Drawing.Color.White
        Me.GrpHeaderCust.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrLabel5, Me.XrLabel1})
        Me.GrpHeaderCust.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GrpHeaderCust.Height = 36
        Me.GrpHeaderCust.Level = 1
        Me.GrpHeaderCust.Name = "GrpHeaderCust"
        Me.GrpHeaderCust.ParentStyleUsing.UseBackColor = False
        '
        'XrLine2
        '
        Me.XrLine2.BackColor = System.Drawing.Color.White
        Me.XrLine2.BorderColor = System.Drawing.Color.IndianRed
        Me.XrLine2.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.XrLine2.Location = New System.Drawing.Point(33, 0)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.ParentStyleUsing.UseBackColor = False
        Me.XrLine2.ParentStyleUsing.UseBorderColor = False
        Me.XrLine2.ParentStyleUsing.UseBorders = False
        Me.XrLine2.ParentStyleUsing.UseForeColor = False
        Me.XrLine2.Size = New System.Drawing.Size(659, 9)
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.ForeColor = System.Drawing.Color.Navy
        Me.XrLabel5.Location = New System.Drawing.Point(33, 8)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.ParentStyleUsing.UseFont = False
        Me.XrLabel5.ParentStyleUsing.UseForeColor = False
        Me.XrLabel5.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel5.Text = "Customer :"
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.ForeColor = System.Drawing.Color.Navy
        Me.XrLabel1.Location = New System.Drawing.Point(133, 8)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.ParentStyleUsing.UseFont = False
        Me.XrLabel1.ParentStyleUsing.UseForeColor = False
        Me.XrLabel1.Size = New System.Drawing.Size(241, 25)
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine4, Me.XrLine3, Me.XrLabel8, Me.XrLabel7})
        Me.GroupFooter1.Height = 33
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrLine4
        '
        Me.XrLine4.Location = New System.Drawing.Point(483, 0)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.Size = New System.Drawing.Size(209, 8)
        '
        'XrLine3
        '
        Me.XrLine3.Location = New System.Drawing.Point(483, 25)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.Size = New System.Drawing.Size(209, 8)
        '
        'XrLabel8
        '
        Me.XrLabel8.Location = New System.Drawing.Point(575, 10)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Size = New System.Drawing.Size(108, 16)
        XrSummary1.FormatString = "{0:#.00}"
        XrSummary1.IgnoreNullValues = True
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel8.Summary = XrSummary1
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel7
        '
        Me.XrLabel7.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel7.ForeColor = System.Drawing.Color.Black
        Me.XrLabel7.Location = New System.Drawing.Point(500, 10)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.ParentStyleUsing.UseBorderColor = False
        Me.XrLabel7.ParentStyleUsing.UseFont = False
        Me.XrLabel7.ParentStyleUsing.UseForeColor = False
        Me.XrLabel7.Size = New System.Drawing.Size(84, 16)
        Me.XrLabel7.Text = "Batch Total:"
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine9, Me.XrLine7, Me.XrLabel9, Me.XrLabel6, Me.XrLine6, Me.XrLine5})
        Me.GroupFooter2.Height = 42
        Me.GroupFooter2.Level = 1
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'XrLine9
        '
        Me.XrLine9.BackColor = System.Drawing.Color.White
        Me.XrLine9.BorderColor = System.Drawing.Color.IndianRed
        Me.XrLine9.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.XrLine9.Location = New System.Drawing.Point(33, 33)
        Me.XrLine9.Name = "XrLine9"
        Me.XrLine9.ParentStyleUsing.UseBackColor = False
        Me.XrLine9.ParentStyleUsing.UseBorderColor = False
        Me.XrLine9.ParentStyleUsing.UseBorders = False
        Me.XrLine9.ParentStyleUsing.UseForeColor = False
        Me.XrLine9.Size = New System.Drawing.Size(659, 9)
        '
        'XrLine7
        '
        Me.XrLine7.Location = New System.Drawing.Point(408, 28)
        Me.XrLine7.Name = "XrLine7"
        Me.XrLine7.Size = New System.Drawing.Size(284, 8)
        '
        'XrLabel9
        '
        Me.XrLabel9.Location = New System.Drawing.Point(575, 10)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Size = New System.Drawing.Size(108, 16)
        XrSummary2.FormatString = "{0:#.00}"
        XrSummary2.IgnoreNullValues = True
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel9.Summary = XrSummary2
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel6
        '
        Me.XrLabel6.BorderColor = System.Drawing.Color.Transparent
        Me.XrLabel6.ForeColor = System.Drawing.Color.Black
        Me.XrLabel6.Location = New System.Drawing.Point(417, 10)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.ParentStyleUsing.UseBorderColor = False
        Me.XrLabel6.ParentStyleUsing.UseFont = False
        Me.XrLabel6.ParentStyleUsing.UseForeColor = False
        Me.XrLabel6.Size = New System.Drawing.Size(176, 16)
        Me.XrLabel6.Text = "Customer wise Sales Total:"
        '
        'XrLine6
        '
        Me.XrLine6.Location = New System.Drawing.Point(408, 25)
        Me.XrLine6.Name = "XrLine6"
        Me.XrLine6.Size = New System.Drawing.Size(284, 8)
        '
        'XrLine5
        '
        Me.XrLine5.Location = New System.Drawing.Point(408, 0)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.Size = New System.Drawing.Size(284, 8)
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Location = New System.Drawing.Point(329, 0)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Size = New System.Drawing.Size(217, 25)
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Location = New System.Drawing.Point(329, 0)
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Size = New System.Drawing.Size(217, 25)
        Me.XrTableCell8.Text = "Item"
        '
        'rptCW_BW_Sales
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.GrpHeaderBatch, Me.GrpHeaderCust, Me.GroupFooter1, Me.GroupFooter2})
        Me.Margins = New System.Drawing.Printing.Margins(100, 25, 100, 100)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

End Class

