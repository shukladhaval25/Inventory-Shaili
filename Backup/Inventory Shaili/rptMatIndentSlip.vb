Imports DevExpress.XtraReports.UI

Public Class rptMatIndentSlip
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
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrControl1 As DevExpress.XtraReports.UI.XRControl
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
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
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
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
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrControl1 = New DevExpress.XtraReports.UI.XRControl
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.Height = 34
        Me.Detail.Name = "Detail"
        Me.Detail.ParentStyleUsing.UseBorders = False
        '
        'XrTable1
        '
        Me.XrTable1.Location = New System.Drawing.Point(8, 0)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.Size = New System.Drawing.Size(634, 34)
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(634, 34)
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Size = New System.Drawing.Size(192, 34)
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Location = New System.Drawing.Point(192, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Size = New System.Drawing.Size(83, 34)
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Location = New System.Drawing.Point(275, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Size = New System.Drawing.Size(82, 34)
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Location = New System.Drawing.Point(357, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Size = New System.Drawing.Size(99, 34)
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Location = New System.Drawing.Point(456, 0)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Size = New System.Drawing.Size(84, 34)
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Location = New System.Drawing.Point(540, 0)
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Size = New System.Drawing.Size(94, 34)
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrLabel3, Me.XrLine1, Me.XrLabel2, Me.XrLabel1})
        Me.PageHeader.Height = 109
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLine2
        '
        Me.XrLine2.Location = New System.Drawing.Point(8, 100)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.Size = New System.Drawing.Size(634, 8)
        '
        'XrLabel3
        '
        Me.XrLabel3.Location = New System.Drawing.Point(167, 75)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Size = New System.Drawing.Size(292, 25)
        Me.XrLabel3.Text = "MATERIAL INDENT SLIP"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine1
        '
        Me.XrLine1.Location = New System.Drawing.Point(8, 67)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.Size = New System.Drawing.Size(634, 8)
        '
        'XrLabel2
        '
        Me.XrLabel2.Location = New System.Drawing.Point(8, 33)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Size = New System.Drawing.Size(634, 25)
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.Location = New System.Drawing.Point(133, 8)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.ParentStyleUsing.UseFont = False
        Me.XrLabel1.Size = New System.Drawing.Size(367, 25)
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel17
        '
        Me.XrLabel17.Location = New System.Drawing.Point(383, 58)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Size = New System.Drawing.Size(50, 25)
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel16
        '
        Me.XrLabel16.Location = New System.Drawing.Point(350, 58)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Size = New System.Drawing.Size(33, 25)
        Me.XrLabel16.Text = "Qty.:"
        '
        'XrLabel11
        '
        Me.XrLabel11.Location = New System.Drawing.Point(517, 58)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Size = New System.Drawing.Size(117, 25)
        '
        'XrLabel10
        '
        Me.XrLabel10.Location = New System.Drawing.Point(517, 25)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Size = New System.Drawing.Size(117, 25)
        '
        'XrLabel9
        '
        Me.XrLabel9.Location = New System.Drawing.Point(125, 58)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Size = New System.Drawing.Size(217, 25)
        '
        'XrLabel8
        '
        Me.XrLabel8.Location = New System.Drawing.Point(125, 25)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Size = New System.Drawing.Size(217, 25)
        '
        'XrLabel7
        '
        Me.XrLabel7.Location = New System.Drawing.Point(458, 58)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Size = New System.Drawing.Size(59, 25)
        Me.XrLabel7.Text = "Date:"
        '
        'XrLabel6
        '
        Me.XrLabel6.Location = New System.Drawing.Point(17, 58)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Size = New System.Drawing.Size(108, 25)
        Me.XrLabel6.Text = "Finish Good :"
        '
        'XrLabel5
        '
        Me.XrLabel5.Location = New System.Drawing.Point(458, 25)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Size = New System.Drawing.Size(59, 25)
        Me.XrLabel5.Text = "Dept.:"
        '
        'XrLabel4
        '
        Me.XrLabel4.Location = New System.Drawing.Point(17, 25)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Size = New System.Drawing.Size(108, 25)
        Me.XrLabel4.Text = "Requisitioned by:"
        '
        'XrTable2
        '
        Me.XrTable2.Location = New System.Drawing.Point(8, 92)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.Size = New System.Drawing.Size(634, 34)
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell12})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.ParentStyleUsing.UseBorders = False
        Me.XrTableRow2.Size = New System.Drawing.Size(634, 34)
        '
        'XrTableCell7
        '
        Me.XrTableCell7.BackColor = System.Drawing.Color.White
        Me.XrTableCell7.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.ParentStyleUsing.UseBackColor = False
        Me.XrTableCell7.ParentStyleUsing.UseBorderWidth = False
        Me.XrTableCell7.Size = New System.Drawing.Size(192, 34)
        Me.XrTableCell7.Text = "Description of material"
        '
        'XrTableCell8
        '
        Me.XrTableCell8.BackColor = System.Drawing.Color.White
        Me.XrTableCell8.Location = New System.Drawing.Point(192, 0)
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.ParentStyleUsing.UseBackColor = False
        Me.XrTableCell8.ParentStyleUsing.UseBorderWidth = False
        Me.XrTableCell8.Size = New System.Drawing.Size(83, 34)
        Me.XrTableCell8.Text = "Qty Reqd."
        '
        'XrTableCell9
        '
        Me.XrTableCell9.BackColor = System.Drawing.Color.White
        Me.XrTableCell9.Location = New System.Drawing.Point(275, 0)
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.ParentStyleUsing.UseBackColor = False
        Me.XrTableCell9.ParentStyleUsing.UseBorderWidth = False
        Me.XrTableCell9.Size = New System.Drawing.Size(82, 34)
        Me.XrTableCell9.Text = "Reqd. On"
        '
        'XrTableCell10
        '
        Me.XrTableCell10.BackColor = System.Drawing.Color.White
        Me.XrTableCell10.Location = New System.Drawing.Point(357, 0)
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.ParentStyleUsing.UseBackColor = False
        Me.XrTableCell10.ParentStyleUsing.UseBorderWidth = False
        Me.XrTableCell10.Size = New System.Drawing.Size(99, 34)
        Me.XrTableCell10.Text = "Qty. Recd."
        '
        'XrTableCell11
        '
        Me.XrTableCell11.BackColor = System.Drawing.Color.White
        Me.XrTableCell11.Location = New System.Drawing.Point(456, 0)
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.ParentStyleUsing.UseBackColor = False
        Me.XrTableCell11.ParentStyleUsing.UseBorderWidth = False
        Me.XrTableCell11.Size = New System.Drawing.Size(84, 34)
        Me.XrTableCell11.Text = "Signature of the Receiver"
        '
        'XrTableCell12
        '
        Me.XrTableCell12.BackColor = System.Drawing.Color.White
        Me.XrTableCell12.Location = New System.Drawing.Point(540, 0)
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.ParentStyleUsing.UseBackColor = False
        Me.XrTableCell12.ParentStyleUsing.UseBorderWidth = False
        Me.XrTableCell12.Size = New System.Drawing.Size(94, 34)
        Me.XrTableCell12.Text = "Remarks"
        '
        'XrControl1
        '
        Me.XrControl1.BackColor = System.Drawing.Color.White
        Me.XrControl1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrControl1.Location = New System.Drawing.Point(8, 17)
        Me.XrControl1.Name = "XrControl1"
        Me.XrControl1.ParentStyleUsing.UseBackColor = False
        Me.XrControl1.ParentStyleUsing.UseBorders = False
        Me.XrControl1.ParentStyleUsing.UseBorderWidth = False
        Me.XrControl1.Size = New System.Drawing.Size(634, 75)
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine3, Me.XrLabel15, Me.XrLabel14, Me.XrLabel13, Me.XrLabel12})
        Me.PageFooter.Height = 61
        Me.PageFooter.Name = "PageFooter"
        '
        'XrLine3
        '
        Me.XrLine3.Location = New System.Drawing.Point(8, 50)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.Size = New System.Drawing.Size(634, 8)
        '
        'XrLabel15
        '
        Me.XrLabel15.Location = New System.Drawing.Point(533, 25)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Size = New System.Drawing.Size(50, 25)
        Me.XrLabel15.Text = "Date:"
        '
        'XrLabel14
        '
        Me.XrLabel14.Location = New System.Drawing.Point(258, 25)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Size = New System.Drawing.Size(108, 25)
        Me.XrLabel14.Text = "INDENTOR"
        '
        'XrLabel13
        '
        Me.XrLabel13.Location = New System.Drawing.Point(133, 25)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Size = New System.Drawing.Size(108, 25)
        Me.XrLabel13.Text = "W.M"
        '
        'XrLabel12
        '
        Me.XrLabel12.Location = New System.Drawing.Point(8, 25)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Size = New System.Drawing.Size(108, 25)
        Me.XrLabel12.Text = "Director"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2, Me.XrLabel4, Me.XrLabel5, Me.XrLabel6, Me.XrLabel7, Me.XrLabel17, Me.XrLabel9, Me.XrLabel10, Me.XrLabel11, Me.XrLabel16, Me.XrLabel8, Me.XrControl1})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.Height = 126
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'rptMatIndentSlip
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.GroupHeader1})
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

End Class

