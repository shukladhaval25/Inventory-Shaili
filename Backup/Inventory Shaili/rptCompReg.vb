Imports DevExpress.XtraReports.UI

Public Class rptCompReg
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
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
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
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.Height = 23
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
        Me.XrTable1.Size = New System.Drawing.Size(709, 23)
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell4, Me.XrTableCell3, Me.XrTableCell16, Me.XrTableCell5, Me.XrTableCell17, Me.XrTableCell18, Me.XrTableCell28, Me.XrTableCell29})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(709, 23)
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Size = New System.Drawing.Size(84, 23)
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Location = New System.Drawing.Point(84, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Size = New System.Drawing.Size(67, 23)
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Location = New System.Drawing.Point(151, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Size = New System.Drawing.Size(66, 23)
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Location = New System.Drawing.Point(217, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Size = New System.Drawing.Size(75, 23)
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Location = New System.Drawing.Point(292, 0)
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.Size = New System.Drawing.Size(66, 23)
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Location = New System.Drawing.Point(358, 0)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Size = New System.Drawing.Size(67, 23)
        '
        'XrTableCell17
        '
        Me.XrTableCell17.Location = New System.Drawing.Point(425, 0)
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.Size = New System.Drawing.Size(67, 23)
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Location = New System.Drawing.Point(492, 0)
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.Size = New System.Drawing.Size(67, 23)
        Me.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrTableCell28
        '
        Me.XrTableCell28.Location = New System.Drawing.Point(559, 0)
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.Size = New System.Drawing.Size(64, 23)
        Me.XrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrTableCell29
        '
        Me.XrTableCell29.Location = New System.Drawing.Point(623, 0)
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.Size = New System.Drawing.Size(86, 23)
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3, Me.XrLabel13})
        Me.PageHeader.Height = 101
        Me.PageHeader.Name = "PageHeader"
        '
        'XrTable3
        '
        Me.XrTable3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.Location = New System.Drawing.Point(17, 42)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.ParentStyleUsing.UseBorders = False
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3, Me.XrTableRow4})
        Me.XrTable3.Size = New System.Drawing.Size(700, 59)
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell9, Me.XrTableCell10, Me.XrTableCell15, Me.XrTableCell11})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Size = New System.Drawing.Size(700, 30)
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Size = New System.Drawing.Size(233, 30)
        Me.XrTableCell9.Text = "Operational Manual"
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Location = New System.Drawing.Point(233, 0)
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Size = New System.Drawing.Size(233, 30)
        Me.XrTableCell10.Text = "Issue No" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'XrTableCell15
        '
        Me.XrTableCell15.Location = New System.Drawing.Point(466, 0)
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.Size = New System.Drawing.Size(93, 30)
        Me.XrTableCell15.Text = "Page"
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
        Me.XrTableCell11.Location = New System.Drawing.Point(559, 0)
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Size = New System.Drawing.Size(141, 30)
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrPageInfo1.BorderWidth = 0
        Me.XrPageInfo1.Location = New System.Drawing.Point(17, 8)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.ParentStyleUsing.UseBorders = False
        Me.XrPageInfo1.ParentStyleUsing.UseBorderWidth = False
        Me.XrPageInfo1.Size = New System.Drawing.Size(92, 17)
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell12, Me.XrTableCell13, Me.XrTableCell14})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Size = New System.Drawing.Size(700, 29)
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Size = New System.Drawing.Size(233, 29)
        Me.XrTableCell12.Text = "Document No. STR /R-1/C-R"
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Location = New System.Drawing.Point(233, 0)
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Size = New System.Drawing.Size(233, 29)
        Me.XrTableCell13.Text = "Revison No. 01"
        '
        'XrTableCell14
        '
        Me.XrTableCell14.Location = New System.Drawing.Point(466, 0)
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Size = New System.Drawing.Size(234, 29)
        Me.XrTableCell14.Text = "Effective Date 01-04-2005"
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.XrLabel13.ForeColor = System.Drawing.Color.Maroon
        Me.XrLabel13.Location = New System.Drawing.Point(17, 8)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.ParentStyleUsing.UseFont = False
        Me.XrLabel13.ParentStyleUsing.UseForeColor = False
        Me.XrLabel13.Size = New System.Drawing.Size(434, 25)
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable4})
        Me.PageFooter.Height = 105
        Me.PageFooter.Name = "PageFooter"
        '
        'XrTable4
        '
        Me.XrTable4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable4.Location = New System.Drawing.Point(33, 8)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.ParentStyleUsing.UseBorders = False
        Me.XrTable4.ParentStyleUsing.UseFont = False
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow5, Me.XrTableRow6, Me.XrTableRow7})
        Me.XrTable4.Size = New System.Drawing.Size(642, 92)
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell19, Me.XrTableCell20, Me.XrTableCell21})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Size = New System.Drawing.Size(642, 31)
        '
        'XrTableCell19
        '
        Me.XrTableCell19.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.Size = New System.Drawing.Size(215, 31)
        Me.XrTableCell19.Text = " AUTHORITY"
        '
        'XrTableCell20
        '
        Me.XrTableCell20.Location = New System.Drawing.Point(215, 0)
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.Size = New System.Drawing.Size(215, 31)
        Me.XrTableCell20.Text = "SIGNATURE"
        '
        'XrTableCell21
        '
        Me.XrTableCell21.Location = New System.Drawing.Point(430, 0)
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.Size = New System.Drawing.Size(212, 31)
        Me.XrTableCell21.Text = "DESIGNATION"
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell22, Me.XrTableCell23, Me.XrTableCell24})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Size = New System.Drawing.Size(642, 31)
        '
        'XrTableCell22
        '
        Me.XrTableCell22.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.Size = New System.Drawing.Size(215, 31)
        Me.XrTableCell22.Text = " REVIEWED BY"
        '
        'XrTableCell23
        '
        Me.XrTableCell23.Location = New System.Drawing.Point(215, 0)
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.Size = New System.Drawing.Size(215, 31)
        '
        'XrTableCell24
        '
        Me.XrTableCell24.Location = New System.Drawing.Point(430, 0)
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.Size = New System.Drawing.Size(212, 31)
        Me.XrTableCell24.Text = "MR"
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell25, Me.XrTableCell26, Me.XrTableCell27})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Size = New System.Drawing.Size(642, 30)
        '
        'XrTableCell25
        '
        Me.XrTableCell25.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.Size = New System.Drawing.Size(215, 30)
        Me.XrTableCell25.Text = "APPROVED BY"
        '
        'XrTableCell26
        '
        Me.XrTableCell26.Location = New System.Drawing.Point(215, 0)
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.Size = New System.Drawing.Size(215, 30)
        Me.XrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTableCell27
        '
        Me.XrTableCell27.Location = New System.Drawing.Point(430, 0)
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.Size = New System.Drawing.Size(212, 30)
        Me.XrTableCell27.Text = "PARTNER"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel30, Me.XrLabel29, Me.XrLabel28, Me.XrLabel27, Me.XrLabel26, Me.XrLabel25, Me.XrLabel24, Me.XrLabel23, Me.XrLabel22, Me.XrLabel21, Me.XrLabel20, Me.XrLabel19, Me.XrLabel18, Me.XrLabel17, Me.XrLabel16, Me.XrLabel15, Me.XrLabel14, Me.XrLabel12, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage
        Me.GroupHeader1.Height = 118
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand
        Me.GroupHeader1.RepeatEveryPage = True
        '
        'XrLabel30
        '
        Me.XrLabel30.BackColor = System.Drawing.Color.Gainsboro
        Me.XrLabel30.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel30.Location = New System.Drawing.Point(367, 75)
        Me.XrLabel30.Multiline = True
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.ParentStyleUsing.UseBackColor = False
        Me.XrLabel30.ParentStyleUsing.UseBorders = False
        Me.XrLabel30.Size = New System.Drawing.Size(66, 42)
        Me.XrLabel30.Text = "Batch No."
        '
        'XrLabel29
        '
        Me.XrLabel29.BackColor = System.Drawing.Color.Gainsboro
        Me.XrLabel29.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel29.Location = New System.Drawing.Point(300, 50)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.ParentStyleUsing.UseBackColor = False
        Me.XrLabel29.ParentStyleUsing.UseBorders = False
        Me.XrLabel29.Size = New System.Drawing.Size(417, 25)
        Me.XrLabel29.Text = "Material Issue"
        Me.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel28
        '
        Me.XrLabel28.BackColor = System.Drawing.Color.Gainsboro
        Me.XrLabel28.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel28.Location = New System.Drawing.Point(433, 75)
        Me.XrLabel28.Multiline = True
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.ParentStyleUsing.UseBackColor = False
        Me.XrLabel28.ParentStyleUsing.UseBorders = False
        Me.XrLabel28.Size = New System.Drawing.Size(67, 42)
        Me.XrLabel28.Text = "Date"
        '
        'XrLabel27
        '
        Me.XrLabel27.BackColor = System.Drawing.Color.Gainsboro
        Me.XrLabel27.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel27.Location = New System.Drawing.Point(225, 75)
        Me.XrLabel27.Multiline = True
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.ParentStyleUsing.UseBackColor = False
        Me.XrLabel27.ParentStyleUsing.UseBorders = False
        Me.XrLabel27.Size = New System.Drawing.Size(75, 42)
        Me.XrLabel27.Text = "Qty " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Recived"
        '
        'XrLabel26
        '
        Me.XrLabel26.BackColor = System.Drawing.Color.Gainsboro
        Me.XrLabel26.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel26.Location = New System.Drawing.Point(300, 75)
        Me.XrLabel26.Multiline = True
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.ParentStyleUsing.UseBackColor = False
        Me.XrLabel26.ParentStyleUsing.UseBorders = False
        Me.XrLabel26.Size = New System.Drawing.Size(66, 42)
        Me.XrLabel26.Text = "MIS No." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Challan no"
        '
        'XrLabel25
        '
        Me.XrLabel25.BackColor = System.Drawing.Color.Gainsboro
        Me.XrLabel25.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel25.Location = New System.Drawing.Point(500, 75)
        Me.XrLabel25.Multiline = True
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.ParentStyleUsing.UseBackColor = False
        Me.XrLabel25.ParentStyleUsing.UseBorders = False
        Me.XrLabel25.Size = New System.Drawing.Size(67, 42)
        Me.XrLabel25.Text = "Qty"
        '
        'XrLabel24
        '
        Me.XrLabel24.BackColor = System.Drawing.Color.Gainsboro
        Me.XrLabel24.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel24.Location = New System.Drawing.Point(567, 75)
        Me.XrLabel24.Multiline = True
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.ParentStyleUsing.UseBackColor = False
        Me.XrLabel24.ParentStyleUsing.UseBorders = False
        Me.XrLabel24.Size = New System.Drawing.Size(64, 42)
        Me.XrLabel24.Text = "Balance"
        '
        'XrLabel23
        '
        Me.XrLabel23.BackColor = System.Drawing.Color.Gainsboro
        Me.XrLabel23.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel23.Location = New System.Drawing.Point(8, 50)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.ParentStyleUsing.UseBackColor = False
        Me.XrLabel23.ParentStyleUsing.UseBorders = False
        Me.XrLabel23.Size = New System.Drawing.Size(292, 25)
        Me.XrLabel23.Text = "Material Receipt"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel22
        '
        Me.XrLabel22.BackColor = System.Drawing.Color.Gainsboro
        Me.XrLabel22.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel22.Location = New System.Drawing.Point(92, 75)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.ParentStyleUsing.UseBackColor = False
        Me.XrLabel22.ParentStyleUsing.UseBorders = False
        Me.XrLabel22.Size = New System.Drawing.Size(66, 42)
        Me.XrLabel22.Text = "Particulars V.I.No"
        '
        'XrLabel21
        '
        Me.XrLabel21.BackColor = System.Drawing.Color.Gainsboro
        Me.XrLabel21.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel21.Location = New System.Drawing.Point(8, 75)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.ParentStyleUsing.UseBackColor = False
        Me.XrLabel21.ParentStyleUsing.UseBorders = False
        Me.XrLabel21.Size = New System.Drawing.Size(84, 42)
        Me.XrLabel21.Text = "Date"
        '
        'XrLabel20
        '
        Me.XrLabel20.BackColor = System.Drawing.Color.Gainsboro
        Me.XrLabel20.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel20.Location = New System.Drawing.Point(158, 75)
        Me.XrLabel20.Multiline = True
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.ParentStyleUsing.UseBackColor = False
        Me.XrLabel20.ParentStyleUsing.UseBorders = False
        Me.XrLabel20.Size = New System.Drawing.Size(67, 42)
        Me.XrLabel20.Text = "Batch No"
        '
        'XrLabel19
        '
        Me.XrLabel19.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel19.Location = New System.Drawing.Point(158, 75)
        Me.XrLabel19.Multiline = True
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.ParentStyleUsing.UseBorders = False
        Me.XrLabel19.Size = New System.Drawing.Size(67, 42)
        Me.XrLabel19.Text = "Batch No"
        '
        'XrLabel18
        '
        Me.XrLabel18.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel18.Location = New System.Drawing.Point(8, 75)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.ParentStyleUsing.UseBorders = False
        Me.XrLabel18.Size = New System.Drawing.Size(84, 42)
        Me.XrLabel18.Text = "Date"
        '
        'XrLabel17
        '
        Me.XrLabel17.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel17.Location = New System.Drawing.Point(92, 75)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.ParentStyleUsing.UseBorders = False
        Me.XrLabel17.Size = New System.Drawing.Size(66, 42)
        Me.XrLabel17.Text = "Particulars V.I.No"
        '
        'XrLabel16
        '
        Me.XrLabel16.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel16.Location = New System.Drawing.Point(8, 50)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.ParentStyleUsing.UseBorders = False
        Me.XrLabel16.Size = New System.Drawing.Size(292, 25)
        Me.XrLabel16.Text = "Material Receipt"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel15
        '
        Me.XrLabel15.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel15.Location = New System.Drawing.Point(367, 75)
        Me.XrLabel15.Multiline = True
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.ParentStyleUsing.UseBorders = False
        Me.XrLabel15.Size = New System.Drawing.Size(66, 42)
        Me.XrLabel15.Text = "Batch No."
        '
        'XrLabel14
        '
        Me.XrLabel14.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel14.Location = New System.Drawing.Point(158, 75)
        Me.XrLabel14.Multiline = True
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.ParentStyleUsing.UseBorders = False
        Me.XrLabel14.Size = New System.Drawing.Size(67, 42)
        Me.XrLabel14.Text = "Batch No"
        '
        'XrLabel12
        '
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.ForeColor = System.Drawing.Color.Navy
        Me.XrLabel12.Location = New System.Drawing.Point(75, 8)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.ParentStyleUsing.UseFont = False
        Me.XrLabel12.ParentStyleUsing.UseForeColor = False
        Me.XrLabel12.Size = New System.Drawing.Size(58, 25)
        Me.XrLabel12.Text = "Title -"
        '
        'XrLabel11
        '
        Me.XrLabel11.BackColor = System.Drawing.Color.Gainsboro
        Me.XrLabel11.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel11.Location = New System.Drawing.Point(631, 75)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.ParentStyleUsing.UseBackColor = False
        Me.XrLabel11.ParentStyleUsing.UseBorders = False
        Me.XrLabel11.Size = New System.Drawing.Size(86, 42)
        Me.XrLabel11.Text = "RMVI No"
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel10.Location = New System.Drawing.Point(300, 50)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.ParentStyleUsing.UseBorders = False
        Me.XrLabel10.Size = New System.Drawing.Size(417, 25)
        Me.XrLabel10.Text = "Material Issue"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel9.Location = New System.Drawing.Point(8, 50)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.ParentStyleUsing.UseBorders = False
        Me.XrLabel9.Size = New System.Drawing.Size(292, 25)
        Me.XrLabel9.Text = "Material Receipt"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel8.Location = New System.Drawing.Point(567, 75)
        Me.XrLabel8.Multiline = True
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.ParentStyleUsing.UseBorders = False
        Me.XrLabel8.Size = New System.Drawing.Size(64, 42)
        Me.XrLabel8.Text = "Balance"
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel7.Location = New System.Drawing.Point(500, 75)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.ParentStyleUsing.UseBorders = False
        Me.XrLabel7.Size = New System.Drawing.Size(67, 42)
        Me.XrLabel7.Text = "Qty"
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel6.Location = New System.Drawing.Point(433, 75)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.ParentStyleUsing.UseBorders = False
        Me.XrLabel6.Size = New System.Drawing.Size(67, 42)
        Me.XrLabel6.Text = "Date"
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel5.Location = New System.Drawing.Point(300, 75)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.ParentStyleUsing.UseBorders = False
        Me.XrLabel5.Size = New System.Drawing.Size(66, 42)
        Me.XrLabel5.Text = "MIS No." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Challan no"
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.Location = New System.Drawing.Point(225, 75)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.ParentStyleUsing.UseBorders = False
        Me.XrLabel4.Size = New System.Drawing.Size(75, 42)
        Me.XrLabel4.Text = "Qty " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Recived"
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel3.Location = New System.Drawing.Point(92, 75)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.ParentStyleUsing.UseBorders = False
        Me.XrLabel3.Size = New System.Drawing.Size(66, 42)
        Me.XrLabel3.Text = "Particulars V.I.No"
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.Location = New System.Drawing.Point(8, 75)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.ParentStyleUsing.UseBorders = False
        Me.XrLabel2.Size = New System.Drawing.Size(84, 42)
        Me.XrLabel2.Text = "Date"
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.ForeColor = System.Drawing.Color.Navy
        Me.XrLabel1.Location = New System.Drawing.Point(133, 8)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.ParentStyleUsing.UseFont = False
        Me.XrLabel1.ParentStyleUsing.UseForeColor = False
        Me.XrLabel1.Size = New System.Drawing.Size(525, 25)
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel34, Me.XrLabel33, Me.XrLine2, Me.XrLine1, Me.XrLabel32, Me.XrLabel31})
        Me.GroupFooter1.Height = 34
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrLabel34
        '
        Me.XrLabel34.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel34.Location = New System.Drawing.Point(367, 8)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.ParentStyleUsing.UseFont = False
        Me.XrLabel34.Size = New System.Drawing.Size(100, 16)
        Me.XrLabel34.Text = "Total Issue:"
        '
        'XrLabel33
        '
        Me.XrLabel33.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel33.Location = New System.Drawing.Point(108, 8)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.ParentStyleUsing.UseFont = False
        Me.XrLabel33.Size = New System.Drawing.Size(100, 16)
        Me.XrLabel33.Text = "Total Receipt:"
        '
        'XrLine2
        '
        Me.XrLine2.Location = New System.Drawing.Point(8, 25)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(709, 9)
        '
        'XrLine1
        '
        Me.XrLine1.Location = New System.Drawing.Point(8, 0)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(709, 9)
        '
        'XrLabel32
        '
        Me.XrLabel32.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel32.Location = New System.Drawing.Point(467, 8)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.ParentStyleUsing.UseFont = False
        Me.XrLabel32.Size = New System.Drawing.Size(100, 17)
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel32.Summary = XrSummary3
        Me.XrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel31
        '
        Me.XrLabel31.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel31.Location = New System.Drawing.Point(200, 8)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.ParentStyleUsing.UseFont = False
        Me.XrLabel31.Size = New System.Drawing.Size(100, 17)
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel31.Summary = XrSummary4
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'rptCompReg
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.GroupHeader1, Me.GroupFooter1})
        Me.Margins = New System.Drawing.Printing.Margins(100, 9, 100, 100)
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Private Sub XrTableCell1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles XrTableCell1.TextChanged
        Try
            If XrTableCell17.Text <> "" Then
                XrTableCell1.Text = ""
                XrTableCell3.Text = ""
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub XrLabel1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles XrLabel1.TextChanged
        Try
            XrTableCell28.Text = ""
        Catch ex As Exception
        End Try
    End Sub

    Private Sub XrTableCell18_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrTableCell18.BeforePrint
        Try
            If XrTableCell18.Text <> "" Then
                XrTableCell28.Text = Val(XrTableCell28.Text) - Val(XrTableCell18.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub XrTableCell3_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrTableCell3.BeforePrint
        Try
            If XrTableCell3.Text <> "" Then
                XrTableCell28.Text = Val(XrTableCell28.Text) + Val(XrTableCell3.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub XrTableCell17_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles XrTableCell17.TextChanged
        Try
            If XrTableCell17.Text <> "" Then
                XrTableCell1.Text = ""
                XrTableCell3.Text = ""
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub XrTableCell18_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles XrTableCell18.TextChanged
        If XrTableCell18.Text = "" OrElse XrTableCell18.Text = 0 Then
            XrTableCell18.Text = ""
        End If

    End Sub
End Class

