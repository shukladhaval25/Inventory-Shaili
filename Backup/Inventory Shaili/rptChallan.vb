Imports DevExpress.XtraReports.UI

Public Class rptChallan
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
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrControl1 As DevExpress.XtraReports.UI.XRControl
    Friend WithEvents XrControl2 As DevExpress.XtraReports.UI.XRControl
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
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
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
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptChallan))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel
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
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrControl2 = New DevExpress.XtraReports.UI.XRControl
        Me.XrControl1 = New DevExpress.XtraReports.UI.XRControl
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.Height = 26
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
        Me.XrTable1.Size = New System.Drawing.Size(684, 25)
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Size = New System.Drawing.Size(684, 25)
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Size = New System.Drawing.Size(257, 25)
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Location = New System.Drawing.Point(257, 0)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Size = New System.Drawing.Size(93, 25)
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Location = New System.Drawing.Point(350, 0)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Size = New System.Drawing.Size(91, 25)
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Location = New System.Drawing.Point(441, 0)
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Size = New System.Drawing.Size(82, 25)
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Location = New System.Drawing.Point(523, 0)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Size = New System.Drawing.Size(161, 25)
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel30
        '
        Me.XrLabel30.Location = New System.Drawing.Point(25, 42)
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Size = New System.Drawing.Size(667, 33)
        Me.XrLabel30.Text = "XrLabel30"
        '
        'XrLabel29
        '
        Me.XrLabel29.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrLabel29.Location = New System.Drawing.Point(8, 8)
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.ParentStyleUsing.UseFont = False
        Me.XrLabel29.Size = New System.Drawing.Size(684, 34)
        '
        'XrLabel25
        '
        Me.XrLabel25.Location = New System.Drawing.Point(606, 142)
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Size = New System.Drawing.Size(83, 25)
        '
        'XrLabel27
        '
        Me.XrLabel27.Location = New System.Drawing.Point(435, 192)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Size = New System.Drawing.Size(244, 24)
        '
        'XrLabel26
        '
        Me.XrLabel26.Location = New System.Drawing.Point(477, 167)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Size = New System.Drawing.Size(203, 25)
        '
        'XrLabel24
        '
        Me.XrLabel24.Location = New System.Drawing.Point(606, 117)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Size = New System.Drawing.Size(83, 25)
        '
        'XrLabel23
        '
        Me.XrLabel23.Location = New System.Drawing.Point(435, 142)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Size = New System.Drawing.Size(119, 25)
        '
        'XrLabel22
        '
        Me.XrLabel22.Location = New System.Drawing.Point(565, 142)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Size = New System.Drawing.Size(40, 25)
        Me.XrLabel22.Text = "Date.:"
        '
        'XrLabel21
        '
        Me.XrLabel21.Location = New System.Drawing.Point(565, 117)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Size = New System.Drawing.Size(40, 25)
        Me.XrLabel21.Text = "Date.:"
        '
        'XrLabel20
        '
        Me.XrLabel20.Location = New System.Drawing.Point(358, 192)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Size = New System.Drawing.Size(72, 22)
        Me.XrLabel20.Text = "Date.:"
        '
        'XrLabel19
        '
        Me.XrLabel19.Location = New System.Drawing.Point(358, 167)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Size = New System.Drawing.Size(114, 25)
        Me.XrLabel19.Text = "Mode of Despatch :"
        '
        'XrLabel18
        '
        Me.XrLabel18.Location = New System.Drawing.Point(358, 142)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Size = New System.Drawing.Size(72, 25)
        Me.XrLabel18.Text = "Order No.:"
        '
        'XrLabel17
        '
        Me.XrLabel17.Location = New System.Drawing.Point(435, 117)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Size = New System.Drawing.Size(119, 25)
        '
        'XrLabel16
        '
        Me.XrLabel16.Location = New System.Drawing.Point(358, 117)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Size = New System.Drawing.Size(84, 25)
        Me.XrLabel16.Text = "Challan No.:"
        '
        'XrLabel15
        '
        Me.XrLabel15.Location = New System.Drawing.Point(67, 200)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Size = New System.Drawing.Size(275, 16)
        '
        'XrLabel14
        '
        Me.XrLabel14.Location = New System.Drawing.Point(67, 175)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Size = New System.Drawing.Size(275, 25)
        '
        'XrLabel13
        '
        Me.XrLabel13.Location = New System.Drawing.Point(67, 150)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Size = New System.Drawing.Size(275, 25)
        '
        'XrLabel12
        '
        Me.XrLabel12.Location = New System.Drawing.Point(67, 125)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Size = New System.Drawing.Size(275, 25)
        '
        'XrLabel11
        '
        Me.XrLabel11.Location = New System.Drawing.Point(17, 117)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Size = New System.Drawing.Size(41, 25)
        Me.XrLabel11.Text = "M/s."
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel7.Location = New System.Drawing.Point(531, 267)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.ParentStyleUsing.UseBorders = False
        Me.XrLabel7.Size = New System.Drawing.Size(161, 25)
        Me.XrLabel7.Text = "Remarks"
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel6.Location = New System.Drawing.Point(449, 267)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.ParentStyleUsing.UseBorders = False
        Me.XrLabel6.Size = New System.Drawing.Size(82, 25)
        Me.XrLabel6.Text = "Rate/Unit"
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel5.Location = New System.Drawing.Point(358, 267)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.ParentStyleUsing.UseBorders = False
        Me.XrLabel5.Size = New System.Drawing.Size(91, 25)
        Me.XrLabel5.Text = "Qty."
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel4.Location = New System.Drawing.Point(267, 267)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.ParentStyleUsing.UseBorders = False
        Me.XrLabel4.Size = New System.Drawing.Size(91, 25)
        Me.XrLabel4.Text = "Batch No."
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel3.Location = New System.Drawing.Point(8, 267)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.ParentStyleUsing.UseBorders = False
        Me.XrLabel3.Size = New System.Drawing.Size(257, 25)
        Me.XrLabel3.Text = "Product Description"
        '
        'XrLabel2
        '
        Me.XrLabel2.Location = New System.Drawing.Point(8, 225)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Size = New System.Drawing.Size(684, 33)
        Me.XrLabel2.Text = resources.GetString("XrLabel2.Text")
        '
        'XrControl2
        '
        Me.XrControl2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrControl2.Location = New System.Drawing.Point(352, 108)
        Me.XrControl2.Name = "XrControl2"
        Me.XrControl2.ParentStyleUsing.UseBorders = False
        Me.XrControl2.Size = New System.Drawing.Size(342, 117)
        '
        'XrControl1
        '
        Me.XrControl1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrControl1.Location = New System.Drawing.Point(8, 108)
        Me.XrControl1.Name = "XrControl1"
        Me.XrControl1.ParentStyleUsing.UseBorders = False
        Me.XrControl1.Size = New System.Drawing.Size(342, 117)
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.Location = New System.Drawing.Point(275, 75)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.ParentStyleUsing.UseFont = False
        Me.XrLabel1.Size = New System.Drawing.Size(200, 25)
        Me.XrLabel1.Text = "DEMO CHALLAN"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel28, Me.XrLabel10, Me.XrLabel9, Me.XrLabel8})
        Me.PageFooter.Height = 125
        Me.PageFooter.Name = "PageFooter"
        '
        'XrLabel28
        '
        Me.XrLabel28.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel28.Location = New System.Drawing.Point(383, 100)
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.ParentStyleUsing.UseFont = False
        Me.XrLabel28.Size = New System.Drawing.Size(309, 25)
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel10
        '
        Me.XrLabel10.Location = New System.Drawing.Point(550, 8)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Size = New System.Drawing.Size(109, 25)
        Me.XrLabel10.Text = "E.&.O.E."
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel9
        '
        Me.XrLabel9.Location = New System.Drawing.Point(8, 100)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Size = New System.Drawing.Size(259, 25)
        Me.XrLabel9.Text = "Receiver's Signature with Stamp."
        '
        'XrLabel8
        '
        Me.XrLabel8.Location = New System.Drawing.Point(8, 8)
        Me.XrLabel8.Multiline = True
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Size = New System.Drawing.Size(259, 50)
        Me.XrLabel8.Text = "Subject to Vadodara Jurisdiction" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Packed By:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Received the above goods in good co" & _
            "ndition."
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrControl1, Me.XrControl2, Me.XrLabel2, Me.XrLabel3, Me.XrLabel4, Me.XrLabel5, Me.XrLabel6, Me.XrLabel7, Me.XrLabel11, Me.XrLabel12, Me.XrLabel13, Me.XrLabel14, Me.XrLabel15, Me.XrLabel16, Me.XrLabel17, Me.XrLabel18, Me.XrLabel19, Me.XrLabel20, Me.XrLabel21, Me.XrLabel22, Me.XrLabel23, Me.XrLabel24, Me.XrLabel26, Me.XrLabel27, Me.XrLabel25, Me.XrLabel30, Me.XrLabel29})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.Height = 293
        Me.GroupHeader1.KeepTogether = True
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.PageBreak = DevExpress.XtraReports.UI.PageBreak.BeforeBand
        '
        'rptChallan
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.GroupHeader1})
        Me.Margins = New System.Drawing.Printing.Margins(100, 33, 100, 100)
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

End Class

