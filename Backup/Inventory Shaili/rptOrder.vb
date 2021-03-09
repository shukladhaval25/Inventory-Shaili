Imports DevExpress.XtraReports.UI

Public Class rptOrder
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Component Designer generated code "

    Public Sub New(ByVal Container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Designer support
        Container.Add(Me)
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

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.
    'Do not modify it using the code editor.
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine7 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine8 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine9 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine10 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine11 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine12 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine13 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine14 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine15 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine16 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel35 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel39 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel42 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel42 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel39 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine9 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine8 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine7 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine6 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine16 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine15 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine14 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine13 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine12 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine11 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine10 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.Height = 25
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
        Me.XrTable1.StyleName = "Style1"
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell5})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(700, 25)
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Size = New System.Drawing.Size(300, 25)
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Location = New System.Drawing.Point(300, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Size = New System.Drawing.Size(67, 25)
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Location = New System.Drawing.Point(367, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Size = New System.Drawing.Size(140, 25)
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Location = New System.Drawing.Point(507, 0)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Size = New System.Drawing.Size(193, 25)
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel22
        '
        Me.XrLabel22.Location = New System.Drawing.Point(500, 83)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Size = New System.Drawing.Size(67, 25)
        Me.XrLabel22.Text = "Date :"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel42
        '
        Me.XrLabel42.Location = New System.Drawing.Point(283, 100)
        Me.XrLabel42.Name = "XrLabel42"
        Me.XrLabel42.Size = New System.Drawing.Size(142, 17)
        '
        'XrLabel41
        '
        Me.XrLabel41.Location = New System.Drawing.Point(158, 100)
        Me.XrLabel41.Name = "XrLabel41"
        Me.XrLabel41.Size = New System.Drawing.Size(150, 17)
        '
        'XrLabel40
        '
        Me.XrLabel40.Location = New System.Drawing.Point(8, 100)
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Size = New System.Drawing.Size(150, 17)
        '
        'XrLabel39
        '
        Me.XrLabel39.Location = New System.Drawing.Point(250, 125)
        Me.XrLabel39.Name = "XrLabel39"
        Me.XrLabel39.Size = New System.Drawing.Size(175, 17)
        '
        'XrLabel38
        '
        Me.XrLabel38.Location = New System.Drawing.Point(200, 125)
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Size = New System.Drawing.Size(42, 17)
        Me.XrLabel38.Text = " Fax :"
        '
        'XrLabel37
        '
        Me.XrLabel37.Location = New System.Drawing.Point(67, 125)
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Size = New System.Drawing.Size(125, 17)
        '
        'XrLabel36
        '
        Me.XrLabel36.Location = New System.Drawing.Point(8, 125)
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Size = New System.Drawing.Size(50, 17)
        Me.XrLabel36.Text = " Phone :"
        '
        'XrLabel14
        '
        Me.XrLabel14.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.XrLabel14.Location = New System.Drawing.Point(8, 17)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.ParentStyleUsing.UseFont = False
        Me.XrLabel14.Size = New System.Drawing.Size(217, 25)
        Me.XrLabel14.Text = " AN ISO 9001 : 2000 COMPANY"
        '
        'XrLine4
        '
        Me.XrLine4.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine4.Location = New System.Drawing.Point(703, 150)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.Size = New System.Drawing.Size(9, 200)
        '
        'XrLine9
        '
        Me.XrLine9.Location = New System.Drawing.Point(8, 292)
        Me.XrLine9.Name = "XrLine9"
        Me.XrLine9.Size = New System.Drawing.Size(700, 8)
        '
        'XrLine8
        '
        Me.XrLine8.Location = New System.Drawing.Point(8, 258)
        Me.XrLine8.Name = "XrLine8"
        Me.XrLine8.Size = New System.Drawing.Size(692, 8)
        '
        'XrLine7
        '
        Me.XrLine7.Location = New System.Drawing.Point(8, 225)
        Me.XrLine7.Name = "XrLine7"
        Me.XrLine7.Size = New System.Drawing.Size(692, 8)
        '
        'XrLine6
        '
        Me.XrLine6.Location = New System.Drawing.Point(8, 192)
        Me.XrLine6.Name = "XrLine6"
        Me.XrLine6.Size = New System.Drawing.Size(692, 8)
        '
        'XrLabel32
        '
        Me.XrLabel32.Location = New System.Drawing.Point(567, 83)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Size = New System.Drawing.Size(133, 25)
        XrSummary1.FormatString = "{0:#.00}"
        XrSummary1.IgnoreNullValues = True
        Me.XrLabel32.Summary = XrSummary1
        '
        'XrLabel31
        '
        Me.XrLabel31.Location = New System.Drawing.Point(567, 50)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Size = New System.Drawing.Size(133, 25)
        XrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        XrSummary2.IgnoreNullValues = True
        Me.XrLabel31.Summary = XrSummary2
        '
        'XrLabel29
        '
        Me.XrLabel29.Location = New System.Drawing.Point(500, 50)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Size = New System.Drawing.Size(67, 25)
        Me.XrLabel29.Text = "Order NO."
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.Location = New System.Drawing.Point(342, 167)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.ParentStyleUsing.UseFont = False
        Me.XrLabel9.Size = New System.Drawing.Size(292, 26)
        Me.XrLabel9.Text = " Description"
        '
        'XrLabel17
        '
        Me.XrLabel17.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel17.Location = New System.Drawing.Point(83, 167)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.ParentStyleUsing.UseFont = False
        Me.XrLabel17.Size = New System.Drawing.Size(166, 25)
        Me.XrLabel17.Text = " Item"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.XrLabel15.Location = New System.Drawing.Point(283, 8)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.ParentStyleUsing.UseFont = False
        Me.XrLabel15.Size = New System.Drawing.Size(192, 25)
        Me.XrLabel15.Text = "ORDER MEMO"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrLabel13.Location = New System.Drawing.Point(8, 75)
        Me.XrLabel13.Multiline = True
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.ParentStyleUsing.UseFont = False
        Me.XrLabel13.Size = New System.Drawing.Size(417, 17)
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.XrLabel12.Location = New System.Drawing.Point(8, 42)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.ParentStyleUsing.UseFont = False
        Me.XrLabel12.Size = New System.Drawing.Size(417, 25)
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrTable2.Location = New System.Drawing.Point(8, 342)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.ParentStyleUsing.UseBorders = False
        Me.XrTable2.ParentStyleUsing.UseFont = False
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.Size = New System.Drawing.Size(700, 25)
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell6, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell10})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Size = New System.Drawing.Size(700, 25)
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Size = New System.Drawing.Size(300, 25)
        Me.XrTableCell6.Text = "Item"
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Location = New System.Drawing.Point(300, 0)
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Size = New System.Drawing.Size(67, 25)
        Me.XrTableCell8.Text = "Qty"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Location = New System.Drawing.Point(367, 0)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Size = New System.Drawing.Size(139, 25)
        Me.XrTableCell9.Text = " Type"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Location = New System.Drawing.Point(506, 0)
        Me.XrTableCell10.Multiline = True
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Size = New System.Drawing.Size(194, 25)
        Me.XrTableCell10.Text = "Remarks"
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel8.Location = New System.Drawing.Point(17, 267)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.ParentStyleUsing.UseFont = False
        Me.XrLabel8.Size = New System.Drawing.Size(200, 25)
        Me.XrLabel8.Text = " Name of Customer"
        '
        'XrLabel7
        '
        Me.XrLabel7.Location = New System.Drawing.Point(342, 200)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Size = New System.Drawing.Size(83, 25)
        '
        'XrLine5
        '
        Me.XrLine5.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine5.Location = New System.Drawing.Point(303, 150)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.Size = New System.Drawing.Size(8, 192)
        '
        'XrLine2
        '
        Me.XrLine2.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine2.Location = New System.Drawing.Point(4, 150)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(8, 192)
        '
        'XrLine1
        '
        Me.XrLine1.Location = New System.Drawing.Point(8, 142)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(700, 17)
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel6.Location = New System.Drawing.Point(17, 200)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.ParentStyleUsing.UseFont = False
        Me.XrLabel6.Size = New System.Drawing.Size(92, 25)
        Me.XrLabel6.Text = " Ref."
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel5.Location = New System.Drawing.Point(17, 300)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.ParentStyleUsing.UseFont = False
        Me.XrLabel5.Size = New System.Drawing.Size(75, 25)
        Me.XrLabel5.Text = " City"
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.XrLabel4.Location = New System.Drawing.Point(17, 233)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.ParentStyleUsing.UseFont = False
        Me.XrLabel4.Size = New System.Drawing.Size(75, 25)
        Me.XrLabel4.Text = " Type"
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.Location = New System.Drawing.Point(342, 300)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.ParentStyleUsing.UseFont = False
        Me.XrLabel3.Size = New System.Drawing.Size(283, 25)
        '
        'XrLabel2
        '
        Me.XrLabel2.Location = New System.Drawing.Point(342, 267)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Size = New System.Drawing.Size(283, 25)
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.Location = New System.Drawing.Point(342, 233)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.ParentStyleUsing.UseFont = False
        Me.XrLabel1.Size = New System.Drawing.Size(175, 25)
        '
        'XrLabel10
        '
        Me.XrLabel10.Location = New System.Drawing.Point(16, 67)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel10.Text = " Qtn. NO."
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine3, Me.XrLabel26, Me.XrLabel25, Me.XrLabel24, Me.XrLabel28, Me.XrLabel27, Me.XrLabel11, Me.XrLabel35, Me.XrLabel34, Me.XrLine16, Me.XrLine15, Me.XrLine14, Me.XrLine13, Me.XrLine12, Me.XrLine11, Me.XrLine10, Me.XrLabel18, Me.XrLabel19, Me.XrLabel10, Me.XrLabel16, Me.XrLabel20, Me.XrLabel23, Me.XrLabel21})
        Me.PageFooter.Height = 223
        Me.PageFooter.Name = "PageFooter"
        '
        'XrLabel26
        '
        Me.XrLabel26.Location = New System.Drawing.Point(532, 150)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Size = New System.Drawing.Size(184, 25)
        '
        'XrLabel25
        '
        Me.XrLabel25.Location = New System.Drawing.Point(124, 100)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Size = New System.Drawing.Size(175, 25)
        '
        'XrLabel24
        '
        Me.XrLabel24.Location = New System.Drawing.Point(124, 67)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Size = New System.Drawing.Size(150, 25)
        '
        'XrLabel28
        '
        Me.XrLabel28.Location = New System.Drawing.Point(466, 100)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Size = New System.Drawing.Size(225, 25)
        '
        'XrLabel27
        '
        Me.XrLabel27.Location = New System.Drawing.Point(466, 67)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Size = New System.Drawing.Size(208, 25)
        '
        'XrLabel11
        '
        Me.XrLabel11.Location = New System.Drawing.Point(341, 8)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Size = New System.Drawing.Size(341, 25)
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel35
        '
        Me.XrLabel35.Location = New System.Drawing.Point(499, 192)
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Size = New System.Drawing.Size(175, 16)
        Me.XrLabel35.Text = " Authorised Signatory"
        '
        'XrLabel34
        '
        Me.XrLabel34.Location = New System.Drawing.Point(499, 150)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Size = New System.Drawing.Size(50, 16)
        Me.XrLabel34.Text = " For"
        '
        'XrLine16
        '
        Me.XrLine16.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine16.Location = New System.Drawing.Point(701, 3)
        Me.XrLine16.Name = "XrLine16"
        Me.XrLine16.Size = New System.Drawing.Size(8, 133)
        '
        'XrLine15
        '
        Me.XrLine15.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine15.Location = New System.Drawing.Point(4, 3)
        Me.XrLine15.Name = "XrLine15"
        Me.XrLine15.Size = New System.Drawing.Size(8, 133)
        '
        'XrLine14
        '
        Me.XrLine14.Location = New System.Drawing.Point(7, 133)
        Me.XrLine14.Name = "XrLine14"
        Me.XrLine14.Size = New System.Drawing.Size(700, 8)
        '
        'XrLine13
        '
        Me.XrLine13.Location = New System.Drawing.Point(8, 92)
        Me.XrLine13.Name = "XrLine13"
        Me.XrLine13.Size = New System.Drawing.Size(692, 8)
        '
        'XrLine12
        '
        Me.XrLine12.Location = New System.Drawing.Point(7, 58)
        Me.XrLine12.Name = "XrLine12"
        Me.XrLine12.Size = New System.Drawing.Size(692, 8)
        '
        'XrLine11
        '
        Me.XrLine11.Location = New System.Drawing.Point(8, 33)
        Me.XrLine11.Name = "XrLine11"
        Me.XrLine11.Size = New System.Drawing.Size(692, 8)
        '
        'XrLine10
        '
        Me.XrLine10.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine10.Location = New System.Drawing.Point(305, 5)
        Me.XrLine10.Name = "XrLine10"
        Me.XrLine10.Size = New System.Drawing.Size(9, 133)
        '
        'XrLabel18
        '
        Me.XrLabel18.Location = New System.Drawing.Point(16, 42)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Size = New System.Drawing.Size(166, 17)
        Me.XrLabel18.Text = " Actual Dispatch Time"
        '
        'XrLabel19
        '
        Me.XrLabel19.Location = New System.Drawing.Point(341, 100)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Size = New System.Drawing.Size(125, 25)
        Me.XrLabel19.Text = "Courier DOC. NO."
        '
        'XrLabel16
        '
        Me.XrLabel16.Location = New System.Drawing.Point(16, 8)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel16.Text = " Delivery Time"
        '
        'XrLabel20
        '
        Me.XrLabel20.Location = New System.Drawing.Point(16, 100)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel20.Text = "Courier Name"
        '
        'XrLabel23
        '
        Me.XrLabel23.Location = New System.Drawing.Point(341, 42)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Size = New System.Drawing.Size(341, 25)
        XrSummary3.FormatString = "{0:#.00}"
        XrSummary3.IgnoreNullValues = True
        Me.XrLabel23.Summary = XrSummary3
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel21
        '
        Me.XrLabel21.Location = New System.Drawing.Point(341, 67)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Size = New System.Drawing.Size(125, 25)
        Me.XrLabel21.Text = " CHALLAN NO."
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrLabel2, Me.XrLabel3, Me.XrLabel4, Me.XrLabel5, Me.XrLabel6, Me.XrLine1, Me.XrLine2, Me.XrLine5, Me.XrLabel7, Me.XrLabel8, Me.XrTable2, Me.XrLabel12, Me.XrLabel13, Me.XrLabel22, Me.XrLabel17, Me.XrLabel9, Me.XrLabel29, Me.XrLabel31, Me.XrLabel32, Me.XrLine6, Me.XrLine7, Me.XrLine8, Me.XrLine9, Me.XrLine4, Me.XrLabel14, Me.XrLabel36, Me.XrLabel37, Me.XrLabel38, Me.XrLabel39, Me.XrLabel40, Me.XrLabel41, Me.XrLabel42, Me.XrLabel15})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField(Nothing, DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage
        Me.GroupHeader1.Height = 368
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand
        '
        'XrLine3
        '
        Me.XrLine3.Location = New System.Drawing.Point(8, 0)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.Size = New System.Drawing.Size(698, 9)
        '
        'rptOrder
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.GroupHeader1})
        Me.Margins = New System.Drawing.Printing.Margins(100, 26, 100, 42)
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

End Class
