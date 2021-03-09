Imports DevExpress.XtraReports.UI
Public Class rptNonConProuduct
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
        Me.Detail.Height = 25
        Me.Detail.Name = "Detail"
        '
        'XrTable3
        '
        Me.XrTable3.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrTable3.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrTable3.Location = New System.Drawing.Point(0, 0)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.ParentStyleUsing.UseBorders = False
        Me.XrTable3.ParentStyleUsing.UseFont = False
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable3.Size = New System.Drawing.Size(742, 25)
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell13, Me.XrTableCell14, Me.XrTableCell15, Me.XrTableCell12, Me.XrTableCell16, Me.XrTableCell17, Me.XrTableCell10, Me.XrTableCell18, Me.XrTableCell4, Me.XrTableCell29})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Size = New System.Drawing.Size(742, 25)
        '
        'XrTableCell13
        '
        Me.XrTableCell13.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Size = New System.Drawing.Size(83, 25)
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        'XrSummary1.FuncScripts.OnGetResult = "private object OnGetResult(System.Collections.ArrayList accumulatedValues) {" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & " re" & _
        '"turn null;" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "}" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)
        'XrSummary1.FuncScripts.OnReset = "private void OnReset() {" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "}" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)
        'XrSummary1.FuncScripts.OnRowChanged = "private void OnRowChanged() {" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "}" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)
        Me.XrTableCell13.Summary = XrSummary1
        '
        'XrTableCell14
        '
        Me.XrTableCell14.Location = New System.Drawing.Point(83, 0)
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Size = New System.Drawing.Size(75, 25)
        '
        'XrTableCell15
        '
        Me.XrTableCell15.Location = New System.Drawing.Point(158, 0)
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.Size = New System.Drawing.Size(128, 25)
        Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Location = New System.Drawing.Point(286, 0)
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Size = New System.Drawing.Size(49, 25)
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Location = New System.Drawing.Point(335, 0)
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.Size = New System.Drawing.Size(49, 25)
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrTableCell17
        '
        Me.XrTableCell17.Location = New System.Drawing.Point(384, 0)
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.Size = New System.Drawing.Size(72, 25)
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Location = New System.Drawing.Point(456, 0)
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Size = New System.Drawing.Size(75, 25)
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Location = New System.Drawing.Point(531, 0)
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.Size = New System.Drawing.Size(75, 25)
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Location = New System.Drawing.Point(606, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Size = New System.Drawing.Size(68, 25)
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable4})
        Me.PageFooter.Height = 116
        Me.PageFooter.Name = "PageFooter"
        '
        'XrTable4
        '
        Me.XrTable4.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrTable4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTable4.Location = New System.Drawing.Point(0, 8)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.ParentStyleUsing.UseBorders = False
        Me.XrTable4.ParentStyleUsing.UseFont = False
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4, Me.XrTableRow5, Me.XrTableRow6})
        Me.XrTable4.Size = New System.Drawing.Size(742, 102)
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell19, Me.XrTableCell20, Me.XrTableCell21})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Size = New System.Drawing.Size(742, 34)
        '
        'XrTableCell19
        '
        Me.XrTableCell19.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell19.Name = "XrTableCell19"
        Me.XrTableCell19.Size = New System.Drawing.Size(248, 34)
        Me.XrTableCell19.Text = " AUTHORITY"
        '
        'XrTableCell20
        '
        Me.XrTableCell20.Location = New System.Drawing.Point(248, 0)
        Me.XrTableCell20.Name = "XrTableCell20"
        Me.XrTableCell20.Size = New System.Drawing.Size(248, 34)
        Me.XrTableCell20.Text = "SIGNATURE"
        '
        'XrTableCell21
        '
        Me.XrTableCell21.Location = New System.Drawing.Point(496, 0)
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.Size = New System.Drawing.Size(246, 34)
        Me.XrTableCell21.Text = "DESIGNATION"
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell22, Me.XrTableCell23, Me.XrTableCell24})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Size = New System.Drawing.Size(742, 34)
        '
        'XrTableCell22
        '
        Me.XrTableCell22.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.Size = New System.Drawing.Size(248, 34)
        Me.XrTableCell22.Text = " REVIEWED BY"
        '
        'XrTableCell23
        '
        Me.XrTableCell23.Location = New System.Drawing.Point(248, 0)
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.Size = New System.Drawing.Size(248, 34)
        '
        'XrTableCell24
        '
        Me.XrTableCell24.Location = New System.Drawing.Point(496, 0)
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.Size = New System.Drawing.Size(246, 34)
        Me.XrTableCell24.Text = "MR"
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell25, Me.XrTableCell26, Me.XrTableCell27})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Size = New System.Drawing.Size(742, 34)
        '
        'XrTableCell25
        '
        Me.XrTableCell25.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.Size = New System.Drawing.Size(248, 34)
        Me.XrTableCell25.Text = "APPROVED BY"
        '
        'XrTableCell26
        '
        Me.XrTableCell26.Location = New System.Drawing.Point(248, 0)
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.Size = New System.Drawing.Size(248, 34)
        Me.XrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTableCell27
        '
        Me.XrTableCell27.Location = New System.Drawing.Point(496, 0)
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.Size = New System.Drawing.Size(246, 34)
        Me.XrTableCell27.Text = "PARTNER"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel6, Me.XrLine3, Me.XrLine5, Me.XrLine4, Me.XrLabel5, Me.XrLine1, Me.XrLabel1, Me.XrLabel2, Me.XrLabel4, Me.XrLabel3, Me.XrLine2, Me.XrTable2})
        Me.PageHeader.Height = 207
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.Location = New System.Drawing.Point(417, 133)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.ParentStyleUsing.UseFont = False
        Me.XrLabel6.Size = New System.Drawing.Size(83, 19)
        Me.XrLabel6.Text = "Issue Date :"
        '
        'XrLine3
        '
        Me.XrLine3.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine3.Location = New System.Drawing.Point(0, 50)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.ParentStyleUsing.UseBorders = False
        Me.XrLine3.Size = New System.Drawing.Size(8, 117)
        '
        'XrLine5
        '
        Me.XrLine5.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine5.Location = New System.Drawing.Point(392, 50)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.Size = New System.Drawing.Size(8, 108)
        '
        'XrLine4
        '
        Me.XrLine4.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine4.Location = New System.Drawing.Point(733, 50)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.ParentStyleUsing.UseBorders = False
        Me.XrLine4.Size = New System.Drawing.Size(9, 108)
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.Location = New System.Drawing.Point(417, 108)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.ParentStyleUsing.UseFont = False
        Me.XrLabel5.Size = New System.Drawing.Size(75, 19)
        Me.XrLabel5.Text = "Issue No.:"
        '
        'XrLine1
        '
        Me.XrLine1.Location = New System.Drawing.Point(0, 42)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.ParentStyleUsing.UseBorders = False
        Me.XrLine1.Size = New System.Drawing.Size(742, 8)
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.Location = New System.Drawing.Point(217, 0)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.ParentStyleUsing.UseFont = False
        Me.XrLabel1.Size = New System.Drawing.Size(150, 25)
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.Location = New System.Drawing.Point(0, 58)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.ParentStyleUsing.UseFont = False
        Me.XrLabel2.Size = New System.Drawing.Size(375, 25)
        Me.XrLabel2.Text = " NON CONFORMING PRODUCT REGISTER"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.Location = New System.Drawing.Point(417, 83)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.ParentStyleUsing.UseFont = False
        Me.XrLabel4.Size = New System.Drawing.Size(58, 19)
        Me.XrLabel4.Text = " Rev. 00"
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.Location = New System.Drawing.Point(417, 58)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.ParentStyleUsing.UseFont = False
        Me.XrLabel3.Size = New System.Drawing.Size(166, 19)
        Me.XrLabel3.Text = " PRO -4/R - 1/NCP"
        '
        'XrLine2
        '
        Me.XrLine2.Location = New System.Drawing.Point(0, 158)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.ParentStyleUsing.UseBorders = False
        Me.XrLine2.Size = New System.Drawing.Size(742, 8)
        '
        'XrTable2
        '
        Me.XrTable2.Borders = DevExpress.XtraPrinting.BorderSide.All
        Me.XrTable2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable2.Location = New System.Drawing.Point(0, 175)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.ParentStyleUsing.UseBorders = False
        Me.XrTable2.ParentStyleUsing.UseFont = False
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.Size = New System.Drawing.Size(742, 25)
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell11, Me.XrTableCell9, Me.XrTableCell2, Me.XrTableCell5, Me.XrTableCell1, Me.XrTableCell3, Me.XrTableCell28})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Size = New System.Drawing.Size(742, 25)
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Size = New System.Drawing.Size(83, 25)
        Me.XrTableCell6.Text = " Date"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Location = New System.Drawing.Point(83, 0)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Size = New System.Drawing.Size(75, 25)
        Me.XrTableCell7.Text = " Complain No."
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Location = New System.Drawing.Point(158, 0)
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Size = New System.Drawing.Size(128, 25)
        Me.XrTableCell8.Text = " Item Name"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Location = New System.Drawing.Point(286, 0)
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Size = New System.Drawing.Size(49, 25)
        Me.XrTableCell11.Text = " Qty"
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Location = New System.Drawing.Point(335, 0)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Size = New System.Drawing.Size(49, 25)
        Me.XrTableCell9.Text = "Make"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Location = New System.Drawing.Point(384, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Size = New System.Drawing.Size(72, 25)
        Me.XrTableCell2.Text = "Item Sr. No."
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Location = New System.Drawing.Point(456, 0)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Size = New System.Drawing.Size(77, 25)
        Me.XrTableCell5.Text = " Customer Name"
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Location = New System.Drawing.Point(533, 0)
        Me.XrTableCell1.Multiline = True
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Size = New System.Drawing.Size(75, 25)
        Me.XrTableCell1.Text = " Reason Of Defect"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Location = New System.Drawing.Point(608, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Size = New System.Drawing.Size(67, 25)
        Me.XrTableCell3.Text = " Action Taken"
        '
        'XrTableCell28
        '
        Me.XrTableCell28.Location = New System.Drawing.Point(675, 0)
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.Size = New System.Drawing.Size(67, 25)
        Me.XrTableCell28.Text = " Remark"
        '
        'XrTableCell29
        '
        Me.XrTableCell29.Location = New System.Drawing.Point(674, 0)
        Me.XrTableCell29.Name = "XrTableCell29"
        Me.XrTableCell29.Size = New System.Drawing.Size(68, 25)
        Me.XrTableCell29.Text = " "
        '
        'rptNonConProuduct
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageFooter, Me.PageHeader})
        Me.Margins = New System.Drawing.Printing.Margins(100, 0, 56, 100)
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

End Class
