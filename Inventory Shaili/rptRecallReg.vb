Imports DevExpress.XtraReports.UI

Public Class rptRecallReg
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
    Private WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.
    'Do not modify it using the code editor.
    Friend WithEvents Subreport1 As DevExpress.XtraReports.UI.Subreport
    Friend WithEvents Subreport2 As DevExpress.XtraReports.UI.Subreport
    Private WithEvents RptMISRecall1 As Inventory_Shaili.rptRM_Rejection
    Private WithEvents RptBatchRecall1 As Inventory_Shaili.rptBatchRecall
    Friend WithEvents Subreport3 As DevExpress.XtraReports.UI.Subreport
    Private WithEvents RptChallanRecall1 As Inventory_Shaili.rptChallanRecall
    Private WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.Subreport3 = New DevExpress.XtraReports.UI.Subreport
        Me.RptChallanRecall1 = New Inventory_Shaili.rptChallanRecall
        Me.Subreport1 = New DevExpress.XtraReports.UI.Subreport
        Me.RptMISRecall1 = New Inventory_Shaili.rptRM_Rejection
        Me.Subreport2 = New DevExpress.XtraReports.UI.Subreport
        Me.RptBatchRecall1 = New Inventory_Shaili.rptBatchRecall
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.RptChallanRecall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RptMISRecall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RptBatchRecall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Subreport3, Me.Subreport1, Me.Subreport2})
        Me.Detail.Height = 123
        Me.Detail.Name = "Detail"
        '
        'Subreport3
        '
        Me.Subreport3.Location = New System.Drawing.Point(17, 83)
        Me.Subreport3.Name = "Subreport3"
        Me.Subreport3.ReportSource = Me.RptChallanRecall1
        '
        'Subreport1
        '
        Me.Subreport1.Location = New System.Drawing.Point(17, 0)
        Me.Subreport1.Name = "Subreport1"
        Me.Subreport1.ReportSource = Me.RptMISRecall1
        '
        'Subreport2
        '
        Me.Subreport2.Location = New System.Drawing.Point(17, 42)
        Me.Subreport2.Name = "Subreport2"
        Me.Subreport2.ReportSource = Me.RptBatchRecall1
        '
        'PageFooter
        '
        Me.PageFooter.Height = 18
        Me.PageFooter.Name = "PageFooter"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.XrLabel1})
        Me.PageHeader.Height = 83
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel2
        '
        Me.XrLabel2.Location = New System.Drawing.Point(17, 50)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Size = New System.Drawing.Size(516, 25)
        Me.XrLabel2.Text = "Product Recall Register"
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.XrLabel1.Location = New System.Drawing.Point(17, 8)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.ParentStyleUsing.UseFont = False
        Me.XrLabel1.Size = New System.Drawing.Size(516, 34)
        '
        'rptRecallReg
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageFooter, Me.PageHeader})
        Me.Margins = New System.Drawing.Printing.Margins(100, 17, 100, 100)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        CType(Me.RptChallanRecall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RptMISRecall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RptBatchRecall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Private Sub rptRecallReg_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Disposed
        Try
            dsSub.Clear()
            dsSub.Dispose()
        Catch ex As Exception
        End Try
    End Sub
End Class

