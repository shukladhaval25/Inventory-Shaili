Imports DevExpress.XtraReports.UI

Public Class rptCWPWSales
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Component Designer generated code "

    Public Sub New(Container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Designer support
        Container.Add(me)
    End Sub

    Public Sub New()
        MyBase.New()

        'This call is required by the Designer.
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

    'Required by the Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Private WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Private WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.
    'Do not modify it using the code editor.
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine8 As DevExpress.XtraReports.UI.XRLine
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.XrLine8 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.Height = 34
        Me.Detail.Name = "Detail"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Location = New System.Drawing.Point(8, 0)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.ParentStyleUsing.UseBorders = False
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.Size = New System.Drawing.Size(700, 25)
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(700, 25)
        '
        'XrTableCell1
        '
        Me.XrTableCell1.BackColor = System.Drawing.Color.AliceBlue
        Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.ParentStyleUsing.UseBackColor = False
        Me.XrTableCell1.Size = New System.Drawing.Size(267, 25)
        '
        'XrTableCell2
        '
        Me.XrTableCell2.BackColor = System.Drawing.Color.AliceBlue
        Me.XrTableCell2.Location = New System.Drawing.Point(267, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.ParentStyleUsing.UseBackColor = False
        Me.XrTableCell2.Size = New System.Drawing.Size(83, 25)
        '
        'XrTableCell3
        '
        Me.XrTableCell3.BackColor = System.Drawing.Color.AliceBlue
        Me.XrTableCell3.Location = New System.Drawing.Point(350, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.ParentStyleUsing.UseBackColor = False
        Me.XrTableCell3.Size = New System.Drawing.Size(92, 25)
        '
        'XrTableCell4
        '
        Me.XrTableCell4.BackColor = System.Drawing.Color.AliceBlue
        Me.XrTableCell4.Location = New System.Drawing.Point(442, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.ParentStyleUsing.UseBackColor = False
        Me.XrTableCell4.Size = New System.Drawing.Size(100, 25)
        '
        'XrTableCell5
        '
        Me.XrTableCell5.BackColor = System.Drawing.Color.AliceBlue
        Me.XrTableCell5.Location = New System.Drawing.Point(542, 0)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.ParentStyleUsing.UseBackColor = False
        Me.XrTableCell5.Size = New System.Drawing.Size(83, 25)
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel12, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.XrLabel8})
        Me.PageHeader.Height = 77
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel12
        '
        Me.XrLabel12.Location = New System.Drawing.Point(533, 50)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Size = New System.Drawing.Size(100, 25)
        '
        'XrLabel11
        '
        Me.XrLabel11.Location = New System.Drawing.Point(492, 50)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Size = New System.Drawing.Size(41, 25)
        Me.XrLabel11.Text = "Date:"
        '
        'XrLabel10
        '
        Me.XrLabel10.Location = New System.Drawing.Point(217, 50)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Size = New System.Drawing.Size(275, 25)
        '
        'XrLabel9
        '
        Me.XrLabel9.Location = New System.Drawing.Point(8, 50)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Size = New System.Drawing.Size(209, 25)
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.ForeColor = System.Drawing.Color.Maroon
        Me.XrLabel8.Location = New System.Drawing.Point(8, 8)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.ParentStyleUsing.UseFont = False
        Me.XrLabel8.ParentStyleUsing.UseForeColor = False
        Me.XrLabel8.Size = New System.Drawing.Size(475, 25)
        Me.XrLabel8.Text = "XrLabel8"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine5, Me.XrLabel17, Me.XrLine4, Me.XrLine3, Me.XrLabel16, Me.XrPageInfo1, Me.XrLabel13})
        Me.PageFooter.Height = 76
        Me.PageFooter.Name = "PageFooter"
        '
        'XrLine5
        '
        Me.XrLine5.Location = New System.Drawing.Point(375, 38)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.Size = New System.Drawing.Size(267, 8)
        '
        'XrLabel17
        '
        Me.XrLabel17.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel17.Location = New System.Drawing.Point(517, 12)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.ParentStyleUsing.UseFont = False
        Me.XrLabel17.Size = New System.Drawing.Size(116, 17)
        XrSummary3.IgnoreNullValues = True
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel17.Summary = XrSummary3
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLine4
        '
        Me.XrLine4.Location = New System.Drawing.Point(375, 33)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.Size = New System.Drawing.Size(267, 8)
        '
        'XrLine3
        '
        Me.XrLine3.Location = New System.Drawing.Point(375, 0)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.Size = New System.Drawing.Size(267, 8)
        '
        'XrLabel16
        '
        Me.XrLabel16.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel16.Location = New System.Drawing.Point(417, 12)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.ParentStyleUsing.UseFont = False
        Me.XrLabel16.Size = New System.Drawing.Size(100, 17)
        Me.XrLabel16.Text = "Grand Total:"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Location = New System.Drawing.Point(600, 50)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Size = New System.Drawing.Size(83, 25)
        '
        'XrLabel13
        '
        Me.XrLabel13.Location = New System.Drawing.Point(550, 50)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Size = New System.Drawing.Size(49, 25)
        Me.XrLabel13.Text = "Page"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.Height = 0
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLabel7
        '
        Me.XrLabel7.BackColor = System.Drawing.Color.Cornsilk
        Me.XrLabel7.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel7.Location = New System.Drawing.Point(550, 33)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.ParentStyleUsing.UseBackColor = False
        Me.XrLabel7.ParentStyleUsing.UseBorders = False
        Me.XrLabel7.Size = New System.Drawing.Size(83, 25)
        Me.XrLabel7.Text = "Qty"
        '
        'XrLabel6
        '
        Me.XrLabel6.BackColor = System.Drawing.Color.Cornsilk
        Me.XrLabel6.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel6.Location = New System.Drawing.Point(450, 33)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.ParentStyleUsing.UseBackColor = False
        Me.XrLabel6.ParentStyleUsing.UseBorders = False
        Me.XrLabel6.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel6.Text = "Batch No"
        '
        'XrLabel5
        '
        Me.XrLabel5.BackColor = System.Drawing.Color.Cornsilk
        Me.XrLabel5.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel5.Location = New System.Drawing.Point(358, 33)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.ParentStyleUsing.UseBackColor = False
        Me.XrLabel5.ParentStyleUsing.UseBorders = False
        Me.XrLabel5.Size = New System.Drawing.Size(92, 25)
        Me.XrLabel5.Text = "Challan Date"
        '
        'XrLabel4
        '
        Me.XrLabel4.BackColor = System.Drawing.Color.Cornsilk
        Me.XrLabel4.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.Location = New System.Drawing.Point(275, 33)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.ParentStyleUsing.UseBackColor = False
        Me.XrLabel4.ParentStyleUsing.UseBorders = False
        Me.XrLabel4.Size = New System.Drawing.Size(83, 25)
        Me.XrLabel4.Text = "Challan No."
        '
        'XrLabel3
        '
        Me.XrLabel3.BackColor = System.Drawing.Color.Cornsilk
        Me.XrLabel3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel3.Location = New System.Drawing.Point(8, 33)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.ParentStyleUsing.UseBackColor = False
        Me.XrLabel3.ParentStyleUsing.UseBorders = False
        Me.XrLabel3.Size = New System.Drawing.Size(267, 25)
        '
        'XrLabel2
        '
        Me.XrLabel2.BackColor = System.Drawing.Color.Thistle
        Me.XrLabel2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.Location = New System.Drawing.Point(117, 8)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.ParentStyleUsing.UseBackColor = False
        Me.XrLabel2.ParentStyleUsing.UseBorders = False
        Me.XrLabel2.ParentStyleUsing.UseFont = False
        Me.XrLabel2.Size = New System.Drawing.Size(591, 25)
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Thistle
        Me.XrLabel1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.Location = New System.Drawing.Point(8, 8)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.ParentStyleUsing.UseBackColor = False
        Me.XrLabel1.ParentStyleUsing.UseBorders = False
        Me.XrLabel1.ParentStyleUsing.UseFont = False
        Me.XrLabel1.Size = New System.Drawing.Size(109, 25)
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel15.Location = New System.Drawing.Point(417, 8)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.ParentStyleUsing.UseFont = False
        Me.XrLabel15.Size = New System.Drawing.Size(100, 17)
        Me.XrLabel15.Text = "Group Total:"
        '
        'XrLine2
        '
        Me.XrLine2.Location = New System.Drawing.Point(375, 25)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(267, 8)
        '
        'XrLine1
        '
        Me.XrLine1.Location = New System.Drawing.Point(375, 0)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(267, 8)
        '
        'XrLabel14
        '
        Me.XrLabel14.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel14.Location = New System.Drawing.Point(517, 8)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.ParentStyleUsing.UseFont = False
        Me.XrLabel14.Size = New System.Drawing.Size(116, 17)
        XrSummary4.IgnoreNullValues = True
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel14.Summary = XrSummary4
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'GroupHeader2
        '
        Me.GroupHeader2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel18, Me.XrLabel2, Me.XrLabel3, Me.XrLabel4, Me.XrLabel5, Me.XrLabel6, Me.XrLabel7, Me.XrLabel1})
        Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader2.Height = 67
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        Me.GroupHeader2.ParentStyleUsing.UseBackColor = False
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel14, Me.XrLine1, Me.XrLine2, Me.XrLabel15, Me.XrLine8})
        Me.GroupFooter2.Height = 42
        Me.GroupFooter2.Level = 1
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'XrLine8
        '
        Me.XrLine8.ForeColor = System.Drawing.Color.Brown
        Me.XrLine8.LineWidth = 2
        Me.XrLine8.Location = New System.Drawing.Point(8, 33)
        Me.XrLine8.Name = "XrLine8"
        Me.XrLine8.ParentStyleUsing.UseForeColor = False
        Me.XrLine8.Size = New System.Drawing.Size(634, 9)
        '
        'XrLabel18
        '
        Me.XrLabel18.BackColor = System.Drawing.Color.Cornsilk
        Me.XrLabel18.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel18.Location = New System.Drawing.Point(633, 33)
        Me.XrLabel18.Multiline = True
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.ParentStyleUsing.UseBackColor = False
        Me.XrLabel18.ParentStyleUsing.UseBorders = False
        Me.XrLabel18.Size = New System.Drawing.Size(75, 25)
        Me.XrLabel18.Text = "Return Qty"
        '
        'XrTableCell6
        '
        Me.XrTableCell6.BackColor = System.Drawing.Color.AliceBlue
        Me.XrTableCell6.Location = New System.Drawing.Point(625, 0)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.ParentStyleUsing.UseBackColor = False
        Me.XrTableCell6.Size = New System.Drawing.Size(75, 25)
        '
        'rptCWPWSales
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.GroupHeader1, Me.GroupFooter1, Me.GroupHeader2, Me.GroupFooter2})
        Me.Margins = New System.Drawing.Printing.Margins(100, 28, 100, 100)
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

End Class

