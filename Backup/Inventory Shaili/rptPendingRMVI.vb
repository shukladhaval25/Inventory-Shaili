Imports DevExpress.XtraReports.UI

Public Class rptPendingRMVI
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
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.Height = 31
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel8, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLine2, Me.XrLine1, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1, Me.XrTable2})
        Me.PageHeader.Height = 167
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 3
        Me.PageFooter.Name = "PageFooter"
        '
        'XrTable1
        '
        Me.XrTable1.Location = New System.Drawing.Point(8, 0)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.Size = New System.Drawing.Size(642, 25)
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell7})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(642, 25)
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Size = New System.Drawing.Size(125, 25)
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Location = New System.Drawing.Point(125, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Size = New System.Drawing.Size(132, 25)
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Location = New System.Drawing.Point(257, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Size = New System.Drawing.Size(300, 25)
        '
        'XrTable2
        '
        Me.XrTable2.Location = New System.Drawing.Point(8, 133)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.Size = New System.Drawing.Size(642, 25)
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell8})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Size = New System.Drawing.Size(642, 25)
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Size = New System.Drawing.Size(125, 25)
        Me.XrTableCell4.Text = "Purchase Order No"
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Location = New System.Drawing.Point(125, 0)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Size = New System.Drawing.Size(132, 25)
        Me.XrTableCell5.Text = "Purchase Order Date"
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Location = New System.Drawing.Point(257, 0)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Size = New System.Drawing.Size(300, 25)
        Me.XrTableCell6.Text = "Item Name"
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel1.Location = New System.Drawing.Point(8, 58)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.ParentStyleUsing.UseFont = False
        Me.XrLabel1.Size = New System.Drawing.Size(417, 25)
        Me.XrLabel1.Text = "Pending raw material visual inspection report"
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.XrLabel2.Location = New System.Drawing.Point(8, 8)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.ParentStyleUsing.UseFont = False
        Me.XrLabel2.Size = New System.Drawing.Size(642, 33)
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel3.Location = New System.Drawing.Point(475, 58)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.ParentStyleUsing.UseFont = False
        Me.XrLabel3.Size = New System.Drawing.Size(50, 25)
        Me.XrLabel3.Text = "Date :"
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel4.Location = New System.Drawing.Point(525, 58)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.ParentStyleUsing.UseFont = False
        Me.XrLabel4.Size = New System.Drawing.Size(125, 25)
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Location = New System.Drawing.Point(557, 0)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Size = New System.Drawing.Size(85, 25)
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Location = New System.Drawing.Point(557, 0)
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Size = New System.Drawing.Size(85, 25)
        Me.XrTableCell8.Text = "Qty"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLine1
        '
        Me.XrLine1.BorderWidth = 2
        Me.XrLine1.Location = New System.Drawing.Point(8, 125)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.ParentStyleUsing.UseBorderWidth = False
        Me.XrLine1.Size = New System.Drawing.Size(642, 8)
        '
        'XrLine2
        '
        Me.XrLine2.BorderWidth = 2
        Me.XrLine2.Location = New System.Drawing.Point(8, 158)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.ParentStyleUsing.UseBorderWidth = False
        Me.XrLine2.Size = New System.Drawing.Size(642, 9)
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel5.Location = New System.Drawing.Point(8, 92)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.ParentStyleUsing.UseFont = False
        Me.XrLabel5.Size = New System.Drawing.Size(75, 25)
        Me.XrLabel5.Text = "Between"
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel6.Location = New System.Drawing.Point(83, 92)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.ParentStyleUsing.UseFont = False
        Me.XrLabel6.Size = New System.Drawing.Size(92, 25)
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel7.Location = New System.Drawing.Point(175, 92)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.ParentStyleUsing.UseFont = False
        Me.XrLabel7.Size = New System.Drawing.Size(41, 25)
        Me.XrLabel7.Text = "To"
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel8.Location = New System.Drawing.Point(217, 92)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.ParentStyleUsing.UseFont = False
        Me.XrLabel8.Size = New System.Drawing.Size(92, 25)
        '
        'rptPendingRMVI
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
        Me.Margins = New System.Drawing.Printing.Margins(100, 54, 100, 100)
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

End Class

