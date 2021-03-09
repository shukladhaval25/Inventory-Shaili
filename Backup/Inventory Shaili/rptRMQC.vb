Imports DevExpress.XtraReports.UI

Public Class rptRMQC
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
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.Height = 35
        Me.Detail.Name = "Detail"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrTable1.Location = New System.Drawing.Point(8, 0)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.ParentStyleUsing.UseBorders = False
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.Size = New System.Drawing.Size(1034, 34)
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell35, Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell12})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(1034, 34)
        '
        'XrTableCell35
        '
        Me.XrTableCell35.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.Size = New System.Drawing.Size(44, 34)
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Location = New System.Drawing.Point(44, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Size = New System.Drawing.Size(90, 34)
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Location = New System.Drawing.Point(134, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Size = New System.Drawing.Size(191, 34)
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Location = New System.Drawing.Point(325, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Size = New System.Drawing.Size(75, 34)
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Location = New System.Drawing.Point(400, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Size = New System.Drawing.Size(75, 34)
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Location = New System.Drawing.Point(475, 0)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Size = New System.Drawing.Size(67, 34)
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Location = New System.Drawing.Point(542, 0)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Size = New System.Drawing.Size(61, 34)
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Location = New System.Drawing.Point(603, 0)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Size = New System.Drawing.Size(70, 34)
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Location = New System.Drawing.Point(673, 0)
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Size = New System.Drawing.Size(53, 34)
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Location = New System.Drawing.Point(726, 0)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Size = New System.Drawing.Size(132, 34)
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Location = New System.Drawing.Point(858, 0)
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Size = New System.Drawing.Size(67, 34)
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Location = New System.Drawing.Point(925, 0)
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Size = New System.Drawing.Size(43, 34)
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Location = New System.Drawing.Point(968, 0)
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Size = New System.Drawing.Size(66, 34)
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel1, Me.XrTable2})
        Me.PageHeader.Height = 161
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.Location = New System.Drawing.Point(8, 17)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.ParentStyleUsing.UseFont = False
        Me.XrLabel2.Size = New System.Drawing.Size(650, 33)
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.Location = New System.Drawing.Point(8, 58)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.ParentStyleUsing.UseFont = False
        Me.XrLabel1.Size = New System.Drawing.Size(650, 26)
        Me.XrLabel1.Text = "Title - Incoming Material - Evaluation Inspection Report"
        '
        'XrTable2
        '
        Me.XrTable2.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrTable2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTable2.Location = New System.Drawing.Point(8, 92)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.ParentStyleUsing.UseBorders = False
        Me.XrTable2.ParentStyleUsing.UseFont = False
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.Size = New System.Drawing.Size(1034, 66)
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell34, Me.XrTableCell13, Me.XrTableCell14, Me.XrTableCell15, Me.XrTableCell16, Me.XrTableCell17, Me.XrTableCell18, Me.XrTableCell19, Me.XrTableCell20, Me.XrTableCell21, Me.XrTableCell22, Me.XrTableCell23, Me.XrTableCell24})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Size = New System.Drawing.Size(1034, 66)
        '
        'XrTableCell34
        '
        Me.XrTableCell34.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.Size = New System.Drawing.Size(43, 66)
        Me.XrTableCell34.Text = "Sr. No"
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Location = New System.Drawing.Point(43, 0)
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Size = New System.Drawing.Size(91, 66)
        Me.XrTableCell13.Text = "VI NO"
        '
        'XrTableCell14
        '
        Me.XrTableCell14.Location = New System.Drawing.Point(134, 0)
        Me.XrTableCell14.Multiline = True
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Size = New System.Drawing.Size(191, 66)
        Me.XrTableCell14.Text = "Description - " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Specification of Material"
        '
        'XrTableCell15
        '
        Me.XrTableCell15.Location = New System.Drawing.Point(325, 0)
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.Size = New System.Drawing.Size(75, 66)
        Me.XrTableCell15.Text = "Date"
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Location = New System.Drawing.Point(400, 0)
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.Size = New System.Drawing.Size(75, 66)
        Me.XrTableCell16.Text = "Drawing No. if applicable"
        '
        'XrTableCell17
        '
        Me.XrTableCell17.Location = New System.Drawing.Point(475, 0)
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.Size = New System.Drawing.Size(67, 66)
        Me.XrTableCell17.Text = "Draw. & Specification Checked"
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Location = New System.Drawing.Point(542, 0)
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.Size = New System.Drawing.Size(61, 66)
        Me.XrTableCell18.Text = "Inspected No."
        '
        'XrTableCell19
        '
        Me.XrTableCell19.Location = New System.Drawing.Point(603, 0)
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.Size = New System.Drawing.Size(70, 66)
        Me.XrTableCell19.Text = "Q.C OK No."
        '
        'XrTableCell20
        '
        Me.XrTableCell20.Location = New System.Drawing.Point(673, 0)
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.Size = New System.Drawing.Size(53, 66)
        Me.XrTableCell20.Text = "Reject No."
        '
        'XrTableCell21
        '
        Me.XrTableCell21.Location = New System.Drawing.Point(726, 0)
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.Size = New System.Drawing.Size(132, 66)
        Me.XrTableCell21.Text = "Reasib For Rejection"
        '
        'XrTableCell22
        '
        Me.XrTableCell22.Location = New System.Drawing.Point(858, 0)
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.Size = New System.Drawing.Size(67, 66)
        Me.XrTableCell22.Text = "T.C Rcvd/No"
        '
        'XrTableCell23
        '
        Me.XrTableCell23.Location = New System.Drawing.Point(925, 0)
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.Size = New System.Drawing.Size(43, 66)
        Me.XrTableCell23.Text = "Sign. Inspector"
        '
        'XrTableCell24
        '
        Me.XrTableCell24.Location = New System.Drawing.Point(968, 0)
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.Size = New System.Drawing.Size(66, 66)
        Me.XrTableCell24.Text = "Challan  / Inv. No"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable4})
        Me.PageFooter.Height = 120
        Me.PageFooter.Name = "PageFooter"
        '
        'XrTable4
        '
        Me.XrTable4.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrTable4.Location = New System.Drawing.Point(133, 8)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.ParentStyleUsing.UseBorders = False
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4, Me.XrTableRow5, Me.XrTableRow6})
        Me.XrTable4.Size = New System.Drawing.Size(733, 102)
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell25, Me.XrTableCell26, Me.XrTableCell27})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Size = New System.Drawing.Size(733, 34)
        '
        'XrTableCell25
        '
        Me.XrTableCell25.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell25.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.ParentStyleUsing.UseFont = False
        Me.XrTableCell25.Size = New System.Drawing.Size(245, 34)
        Me.XrTableCell25.Text = " AUTHORITY"
        '
        'XrTableCell26
        '
        Me.XrTableCell26.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell26.Location = New System.Drawing.Point(245, 0)
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.ParentStyleUsing.UseFont = False
        Me.XrTableCell26.Size = New System.Drawing.Size(245, 34)
        Me.XrTableCell26.Text = "SIGNATURE"
        '
        'XrTableCell27
        '
        Me.XrTableCell27.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell27.Location = New System.Drawing.Point(490, 0)
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.ParentStyleUsing.UseFont = False
        Me.XrTableCell27.Size = New System.Drawing.Size(243, 34)
        Me.XrTableCell27.Text = "DESIGNATION"
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell28, Me.XrTableCell29, Me.XrTableCell30})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Size = New System.Drawing.Size(733, 34)
        '
        'XrTableCell28
        '
        Me.XrTableCell28.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.Size = New System.Drawing.Size(245, 34)
        Me.XrTableCell28.Text = " REVIEWED BY"
        '
        'XrTableCell29
        '
        Me.XrTableCell29.Location = New System.Drawing.Point(245, 0)
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.Size = New System.Drawing.Size(245, 34)
        '
        'XrTableCell30
        '
        Me.XrTableCell30.Location = New System.Drawing.Point(490, 0)
        Me.XrTableCell30.Name = "XrTableCell30"
        Me.XrTableCell30.Size = New System.Drawing.Size(243, 34)
        Me.XrTableCell30.Text = "MR"
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell31, Me.XrTableCell32, Me.XrTableCell33})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Size = New System.Drawing.Size(733, 34)
        '
        'XrTableCell31
        '
        Me.XrTableCell31.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.Size = New System.Drawing.Size(245, 34)
        Me.XrTableCell31.Text = "APPROVED BY"
        '
        'XrTableCell32
        '
        Me.XrTableCell32.Location = New System.Drawing.Point(245, 0)
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.Size = New System.Drawing.Size(245, 34)
        '
        'XrTableCell33
        '
        Me.XrTableCell33.Location = New System.Drawing.Point(490, 0)
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.Size = New System.Drawing.Size(243, 34)
        Me.XrTableCell33.Text = "PARTNER"
        '
        'rptRMQC
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(100, 14, 100, 100)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

End Class

