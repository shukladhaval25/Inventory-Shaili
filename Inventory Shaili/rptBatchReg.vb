Imports DevExpress.XtraReports.UI

Public Class rptBatchReg
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
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Subreport1 As DevExpress.XtraReports.UI.Subreport
    Private WithEvents RptSubBatchStock1 As Inventory_Shaili.rptSubBatchStock ' Shaili.rptSubBatchStock
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Subreport1 = New DevExpress.XtraReports.UI.Subreport
        Me.RptSubBatchStock1 = New Inventory_Shaili.rptSubBatchStock
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RptSubBatchStock1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.Height = 36
        Me.Detail.Name = "Detail"
        '
        'XrTable1
        '
        Me.XrTable1.Location = New System.Drawing.Point(8, 8)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.Size = New System.Drawing.Size(675, 25)
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(675, 25)
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Size = New System.Drawing.Size(81, 25)
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Location = New System.Drawing.Point(81, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Size = New System.Drawing.Size(84, 25)
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Location = New System.Drawing.Point(165, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Size = New System.Drawing.Size(418, 25)
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Location = New System.Drawing.Point(583, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Size = New System.Drawing.Size(92, 25)
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'Subreport1
        '
        Me.Subreport1.Location = New System.Drawing.Point(8, 8)
        Me.Subreport1.Name = "Subreport1"
        Me.Subreport1.ReportSource = Me.RptSubBatchStock1
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrLabel11, Me.XrLabel10, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1, Me.XrLabel9, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel8, Me.XrLine1, Me.XrLabel7})
        Me.PageHeader.Height = 138
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLine2
        '
        Me.XrLine2.Location = New System.Drawing.Point(8, 125)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(675, 8)
        '
        'XrLabel11
        '
        Me.XrLabel11.Location = New System.Drawing.Point(600, 100)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Size = New System.Drawing.Size(83, 23)
        Me.XrLabel11.Text = "Batch Qty."
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.Location = New System.Drawing.Point(175, 100)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Size = New System.Drawing.Size(417, 23)
        Me.XrLabel10.Text = "Product Name"
        '
        'XrLabel3
        '
        Me.XrLabel3.Location = New System.Drawing.Point(167, 58)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Size = New System.Drawing.Size(100, 23)
        Me.XrLabel3.Text = "XrLabel3"
        '
        'XrLabel2
        '
        Me.XrLabel2.Location = New System.Drawing.Point(8, 58)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Size = New System.Drawing.Size(159, 23)
        Me.XrLabel2.Text = "Batch Register Between "
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.Location = New System.Drawing.Point(8, 8)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.ParentStyleUsing.UseFont = False
        Me.XrLabel1.Size = New System.Drawing.Size(675, 34)
        Me.XrLabel1.Text = "XrLabel1"
        '
        'XrLabel9
        '
        Me.XrLabel9.Location = New System.Drawing.Point(92, 100)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Size = New System.Drawing.Size(84, 23)
        Me.XrLabel9.Text = "Batch No."
        '
        'XrLabel6
        '
        Me.XrLabel6.Location = New System.Drawing.Point(558, 58)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Size = New System.Drawing.Size(42, 25)
        Me.XrLabel6.Text = "Date:"
        '
        'XrLabel5
        '
        Me.XrLabel5.Location = New System.Drawing.Point(308, 58)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Size = New System.Drawing.Size(100, 23)
        Me.XrLabel5.Text = "XrLabel5"
        '
        'XrLabel4
        '
        Me.XrLabel4.Location = New System.Drawing.Point(267, 58)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Size = New System.Drawing.Size(42, 23)
        Me.XrLabel4.Text = "And"
        '
        'XrLabel8
        '
        Me.XrLabel8.Location = New System.Drawing.Point(8, 100)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Size = New System.Drawing.Size(84, 23)
        Me.XrLabel8.Text = "Batch Date"
        '
        'XrLine1
        '
        Me.XrLine1.Location = New System.Drawing.Point(8, 92)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(675, 8)
        '
        'XrLabel7
        '
        Me.XrLabel7.Location = New System.Drawing.Point(600, 58)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Size = New System.Drawing.Size(83, 25)
        Me.XrLabel7.Text = "XrLabel7"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 10
        Me.PageFooter.Name = "PageFooter"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.BorderWidth = 0
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine3, Me.Subreport1})
        Me.GroupFooter1.Height = 43
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.ParentStyleUsing.UseBorderWidth = False
        '
        'XrLine3
        '
        Me.XrLine3.Location = New System.Drawing.Point(8, 0)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.ParentStyleUsing.UseBorders = False
        Me.XrLine3.ParentStyleUsing.UseBorderWidth = False
        Me.XrLine3.Size = New System.Drawing.Size(675, 8)
        '
        'rptBatchReg
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.GroupFooter1})
        Me.Margins = New System.Drawing.Printing.Margins(100, 31, 100, 100)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RptSubBatchStock1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Private Sub Subreport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Subreport1.BeforePrint
        'Dim detail As rptSubBatchStock = CType(Subreport1.ReportSource, rptSubBatchStock)
      
    End Sub
End Class

