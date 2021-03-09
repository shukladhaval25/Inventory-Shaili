Imports DevExpress.XtraReports.UI

Public Class rptGoodsRet
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
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.Height = 42
        Me.Detail.Name = "Detail"
        '
        'XrTable1
        '
        Me.XrTable1.Location = New System.Drawing.Point(8, 8)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.Size = New System.Drawing.Size(675, 34)
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell7})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(675, 34)
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Size = New System.Drawing.Size(231, 34)
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Location = New System.Drawing.Point(231, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Size = New System.Drawing.Size(109, 34)
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Location = New System.Drawing.Point(340, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Size = New System.Drawing.Size(85, 34)
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Location = New System.Drawing.Point(425, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Size = New System.Drawing.Size(92, 34)
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Location = New System.Drawing.Point(517, 0)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Size = New System.Drawing.Size(63, 34)
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Location = New System.Drawing.Point(580, 0)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Size = New System.Drawing.Size(43, 34)
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Location = New System.Drawing.Point(623, 0)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Size = New System.Drawing.Size(52, 34)
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel18, Me.XrLabel17, Me.XrLabel9, Me.XrLabel1, Me.XrLabel16, Me.XrLabel15, Me.XrLabel14, Me.XrLabel13, Me.XrLabel12, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6, Me.XrLabel10, Me.XrLine2, Me.XrLine1, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2})
        Me.PageHeader.Height = 219
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel18
        '
        Me.XrLabel18.Location = New System.Drawing.Point(433, 117)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Size = New System.Drawing.Size(117, 25)
        Me.XrLabel18.Text = "XrLabel18"
        Me.XrLabel18.WordWrap = False
        '
        'XrLabel17
        '
        Me.XrLabel17.Location = New System.Drawing.Point(300, 117)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Size = New System.Drawing.Size(83, 17)
        Me.XrLabel17.Text = "Challan Date:"
        '
        'XrLabel9
        '
        Me.XrLabel9.Location = New System.Drawing.Point(108, 117)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Size = New System.Drawing.Size(184, 25)
        Me.XrLabel9.Text = "XrLabel9"
        '
        'XrLabel1
        '
        Me.XrLabel1.Location = New System.Drawing.Point(8, 117)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Size = New System.Drawing.Size(159, 25)
        Me.XrLabel1.Text = "Challan No:"
        '
        'XrLabel16
        '
        Me.XrLabel16.Location = New System.Drawing.Point(8, 33)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Size = New System.Drawing.Size(659, 33)
        Me.XrLabel16.Text = "XrLabel16"
        '
        'XrLabel15
        '
        Me.XrLabel15.Location = New System.Drawing.Point(433, 92)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Size = New System.Drawing.Size(117, 25)
        Me.XrLabel15.Text = "xrLabel15"
        Me.XrLabel15.WordWrap = False
        '
        'XrLabel14
        '
        Me.XrLabel14.Location = New System.Drawing.Point(300, 92)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Size = New System.Drawing.Size(150, 33)
        Me.XrLabel14.Text = "Demo Return Date:"
        '
        'XrLabel13
        '
        Me.XrLabel13.Location = New System.Drawing.Point(108, 142)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Size = New System.Drawing.Size(517, 34)
        Me.XrLabel13.Text = "XrLabel13"
        '
        'XrLabel12
        '
        Me.XrLabel12.Location = New System.Drawing.Point(8, 142)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Size = New System.Drawing.Size(100, 25)
        Me.XrLabel12.Text = "Customer Name:"
        '
        'XrLabel8
        '
        Me.XrLabel8.Location = New System.Drawing.Point(117, 92)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Size = New System.Drawing.Size(175, 25)
        Me.XrLabel8.Text = "xrLabel8"
        '
        'XrLabel7
        '
        Me.XrLabel7.Location = New System.Drawing.Point(8, 92)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Size = New System.Drawing.Size(133, 33)
        Me.XrLabel7.Text = "Goods Return No:"
        '
        'XrLabel6
        '
        Me.XrLabel6.Location = New System.Drawing.Point(8, 67)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Size = New System.Drawing.Size(434, 25)
        Me.XrLabel6.Text = "Goods Return Report"
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.XrLabel10.Location = New System.Drawing.Point(8, 8)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.ParentStyleUsing.UseFont = False
        Me.XrLabel10.Size = New System.Drawing.Size(675, 25)
        Me.XrLabel10.Text = "Company Title"
        '
        'XrLine2
        '
        Me.XrLine2.Location = New System.Drawing.Point(8, 208)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(684, 9)
        '
        'XrLine1
        '
        Me.XrLine1.Location = New System.Drawing.Point(8, 167)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(684, 8)
        '
        'XrLabel5
        '
        Me.XrLabel5.Location = New System.Drawing.Point(450, 183)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Size = New System.Drawing.Size(62, 25)
        Me.XrLabel5.Text = "Return Qty"
        '
        'XrLabel4
        '
        Me.XrLabel4.Location = New System.Drawing.Point(360, 183)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Size = New System.Drawing.Size(58, 25)
        Me.XrLabel4.Text = "Unit"
        '
        'XrLabel3
        '
        Me.XrLabel3.Location = New System.Drawing.Point(192, 183)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Size = New System.Drawing.Size(200, 25)
        Me.XrLabel3.Text = "Batch No"
        '
        'XrLabel2
        '
        Me.XrLabel2.Location = New System.Drawing.Point(8, 183)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Size = New System.Drawing.Size(92, 25)
        Me.XrLabel2.Text = "Product Name"
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel11, Me.XrPageInfo1})
        Me.PageFooter.Height = 35
        Me.PageFooter.Name = "PageFooter"
        '
        'XrLabel11
        '
        Me.XrLabel11.Location = New System.Drawing.Point(533, 8)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Size = New System.Drawing.Size(67, 25)
        Me.XrLabel11.Text = "Page No."
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Location = New System.Drawing.Point(600, 8)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Size = New System.Drawing.Size(83, 25)
        '
        'rptGoodsRet
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Margins = New System.Drawing.Printing.Margins(100, 55, 100, 100)
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region
End Class

